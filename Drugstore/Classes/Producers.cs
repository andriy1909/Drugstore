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
    public class Producers
    {
        public int id { get; set; }
        public string name { get; set; }

        static string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

        public Producers()
        {
 
        }

        public void setProvider(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static string getName(int id)
        {
            string name = "";
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Виробники WHERE Код=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();

            while (dataReader1.Read())
            {

                name = dataReader1["Назва"].ToString().Trim();
            }

            bd.Close();
            return name;
        }

        public void getDataItem(int id)
        {

            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Виробники WHERE Код=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            this.id = id;
            while (dataReader1.Read())
            {
                name = dataReader1["Назва"].ToString().Trim();
            }
            bd.Close();
        }
        public void insertItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Виробники VALUES(@name)", connection);
                command.Parameters.AddWithValue("@name", name);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void updateItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand("UPDATE Виробники SET Назва=@name WHERE Код=" + id.ToString(), connection);
                command.Parameters.AddWithValue("@name", name);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void deleteId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM Виробники WHERE Код=" + id.ToString(), connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
