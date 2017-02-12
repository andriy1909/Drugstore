using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore
{
    public class Providers
    {
        public int id { get; set; }
        public string name { get; set; }
        public string number { get; set; }

        static string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

        public Providers()
        {

        }

        public void setProvider(int id, string name, string number)
        {
            this.id = id;
            this.name = name;
            this.number = number;
        }

        public void getDataItem(int id)
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Постачальники WHERE Код=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                name = dataReader1["Назва"].ToString().Trim();
                number = dataReader1["Телефон"].ToString().Trim();
            }
            bd.Close();
        }

        public void insertItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Постачальники VALUES(@name, @number)", connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@number", number);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand("UPDATE Постачальники SET Назва=@name, Телефон=@number WHERE Код=" + id.ToString(), connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@number", number);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void deleteId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM Постачальники WHERE Код=" + id.ToString(), connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
