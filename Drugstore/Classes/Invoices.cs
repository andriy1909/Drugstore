using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore
{
    class Invoices : Document
    {
        public decimal sum { get; set; }
        public int sumCount { get; set; }
        public int pay { get; set; }
        public List<InvoicesTbl> table { get; set; }
        
        public Invoices()
        {

        }
        
        public void getDoc(int id)
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM " + typeDoc + " WHERE НомерДокумента=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                num = id;
                date = (DateTime)dataReader1["ДатаДокумента"];
                respons = (int)dataReader1["Відповідальний"];
                partner = (int)dataReader1["Партнер"];
                status = (int)dataReader1["Статус"];
                sum = (decimal)dataReader1["СумаДокумента"];
                sumCount = (int)dataReader1["КількістьТоварів"];
                memo = (String)dataReader1["Замітка"];
                pay = (int)dataReader1["Оплата"];
            }
            bd.Close();
        }

        public void insertItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO " + typeDoc + " VALUES(@date, @respons, @partner, @status, @sum, @sumCount,@memo,@pay)", connection);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@respons", respons);
                command.Parameters.AddWithValue("@partner", partner);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@sum", sum);
                command.Parameters.AddWithValue("@sumCount", sumCount);
                command.Parameters.AddWithValue("@memo", memo);
                command.Parameters.AddWithValue("@pay", pay);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE " + typeDoc + " SET ДатаДокумента=@date, Відповідальний=@respons, Партнер=@partner, Статус=@status, "+
                    "СумаДокумента=@sum, КількістьТоварів=@sumCount,Замітка=@memo,Оплата=@pay", connection);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@respons", respons);
                command.Parameters.AddWithValue("@partner", partner);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@sum", sum);
                command.Parameters.AddWithValue("@sumCount", sumCount);
                command.Parameters.AddWithValue("@memo", memo);
                command.Parameters.AddWithValue("@pay", pay);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
                
    }
}
