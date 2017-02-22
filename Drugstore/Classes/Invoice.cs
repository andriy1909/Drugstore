using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore
{
    public class Invoice
    {
        public int num { get; set; }              //НомерДокумента
        public DateTime date { get; set; }        //ДатаДокумента
        public int responsible { get; set; }      //Відповідальний
        public int partner { get; set; }          //Партнер
        public int status { get; set; }           //Статус
        public float sum { get; set; }            //СумаДокумента
        public int countGoods { get; set; }       //КількістьТоварів
        public string memo { get; set; }          //Замітка
        public int pay { get; set; }              //Оплата
        
        static string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
        static string typeDoc= "НакладнаОтпуска";

        public Invoice()
        {

        }

        public Invoice(string type)
        {
            typeDoc = type;
        }

        public void setInvoice(DateTime date, int responsible, int partner, int status, float sum, int countGoods, 
            string memo, int pay, int num=0)
        {
            this.date = date;
            this.responsible = responsible;
            this.partner = partner;
            this.status = status;
            this.sum = sum;
            this.countGoods = countGoods;
            this.memo = memo;
            this.pay = pay;
            this.num = num;
        }

        public void getData(int id)
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM " + typeDoc + " WHERE НомерДокумента=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                num = (int)dataReader1["НомерДокумента"];
                date = (DateTime)dataReader1["ДатаДокумента"];
                responsible = (int)dataReader1["Відповідальний"];
                partner = (int)dataReader1["Партнер"];
                status = (int)dataReader1["Статус"];
                sum = Convert.ToSingle(dataReader1["СумаДокумента"].ToString().Trim());
                countGoods = (int)dataReader1["КількістьТоварів"];
                memo = dataReader1["Замітка"].ToString().Trim();
                pay = (int)dataReader1["Оплата"];
            }
            bd.Close();
        }

        public void insertItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO " + typeDoc + " VALUES(@date, @responsible, @partner, @status, @sum, @countGoods, " +
                    "@memo, @pay)", connection);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@responsible", responsible);
                command.Parameters.AddWithValue("@partner", partner);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@sum", sum);
                command.Parameters.AddWithValue("@countGoods", countGoods);
                command.Parameters.AddWithValue("@memo", memo);
                command.Parameters.AddWithValue("@pay", pay);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public int insertEmptyDoc()
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO " + typeDoc + " OUTPUT INSERTED.IDENTITYCOL VALUES(@date, @responsible, @partner, @status, @sum, " +
                    "@countGoods, @memo, @pay)", connection);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@responsible", responsible);
                command.Parameters.AddWithValue("@partner", partner);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@sum", sum);
                command.Parameters.AddWithValue("@countGoods", countGoods);
                command.Parameters.AddWithValue("@memo", memo);
                command.Parameters.AddWithValue("@pay", pay);

                command.Connection.Open();
                command.ExecuteNonQuery();
                /*
                //По умолчанию параметры считаются входными, но все же для ясности:
                SqlParameter param.Direction = ParameterDirection.Input;
                command.Parameters.Add(param);

                // Выходной параметр.
                param = new SqlParameter();
                param.ParameterName = "@petName";
                param.SqlDbType = SqlDbType.Char;
                param.Size = 10;
                param.Direction = ParameterDirection.Output;
                command.Parameters.Add(param);

                // Выполнение хранимой процедуры.
                command.ExecuteNonQuery();
                // Возврат выходного параметра.
                id = (int)command.Parameters["@petName"].Value;*/
            }
            return id;
        }

        public void updateItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE " + typeDoc + " SET ДатаДокумента=@date, Відповідальний=@responsible, Партнер=@partner, Статус=@status, " +
                    "СумаДокумента=@sum, КількістьТоварів=@countGoods, Замітка=@memo, Оплата=@pay WHERE НомерДокумента=" + num.ToString(), connection);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@responsible", responsible);
                command.Parameters.AddWithValue("@partner", partner);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@sum", sum);
                command.Parameters.AddWithValue("@countGoods", countGoods);
                command.Parameters.AddWithValue("@memo", memo);
                command.Parameters.AddWithValue("@pay", pay);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void deleteId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "DELETE FROM " + typeDoc + "Тбл " +
                    "WHERE Код=" + id.ToString(), connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "DELETE FROM " + typeDoc + " " +
                    "WHERE НомерДокумента=" + id.ToString(), connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
