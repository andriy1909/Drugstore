using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore
{
    public class InvoiceTbl
    {
        public int id { get; set; }              //Код
        public int doc { get; set; }             //Документ
        public int good { get; set; }            //Товар
        public int count { get; set; }           //Кількість
        public float price { get; set; }         //Ціна

        static string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
        static string typeDoc = "НакладнаОтпуска";
        
        public InvoiceTbl()
        {
        }

        public InvoiceTbl(string type)
        {
            typeDoc = type;
        }

        public void setInvoice(int doc, int good, int count, float price, int id = 0)
        {
            this.id = id;
            this.doc = doc;
            this.good = good;
            this.count = count;
            this.price = price;
    }

        public void getData(int id)
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM " + typeDoc + "Тбл WHERE Код=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            this.id = id;
            while (dataReader1.Read())
            {
                doc = (int)dataReader1["Документ"];
                good = (int)dataReader1["Товар"];
                count = (int)dataReader1["Кількість"];
                price = (float)dataReader1["Ціна"];
            }
            bd.Close();
        }

        public void insertItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO " + typeDoc + "Тбл VALUES(@doc, @good, @count, @price)", connection);
                command.Parameters.AddWithValue("@doc", doc);
                command.Parameters.AddWithValue("@good", good);
                command.Parameters.AddWithValue("@count", count);
                command.Parameters.AddWithValue("@price", price);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        
        public void updateItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE " + typeDoc + "Тбл SET Документ=@doc, Товар=@good, Кількість=@count, Ціна=@price WHERE Код=" + id.ToString(), connection);
                command.Parameters.AddWithValue("@doc", doc);
                command.Parameters.AddWithValue("@good", good);
                command.Parameters.AddWithValue("@count", count);
                command.Parameters.AddWithValue("@price", price);

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
                    "DELETE FROM " + typeDoc + "Тбл " +
                    "WHERE Код=" + id.ToString(), connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
