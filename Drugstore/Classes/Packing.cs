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
    public class Packing
    {
        public int id { get; set; }
        public string name { get; set; }
        public int numerosity { get; set; }


        static string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

        public Packing()
        {

        }

        public void setProvider(int id, string name, int numerosity)
        {
            this.id = id;
            this.name = name;
            this.numerosity = numerosity;
        }

        public void getDataItem(int id)
        {

            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Упаковки WHERE Код=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            this.id = id;
            while (dataReader1.Read())
            {
                name = dataReader1["Назва"].ToString().Trim();
                numerosity = Convert.ToInt32(dataReader1["Кількість"]);
            }
            bd.Close();
        }

        public static string getname(int id)
        {
            string name = "";
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Упаковки WHERE Код=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();

            while (dataReader1.Read())
            {
                name = dataReader1["Назва"].ToString().Trim();
            }
            bd.Close();
            return name;
        }

        public void insertItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Упаковки VALUES(@name, @numerosity)", connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@numerosity", numerosity);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand("UPDATE Упаковки SET Назва=@name, Кількість=@numerosity WHERE Код=" + id.ToString(), connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@numerosity", numerosity);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void deleteId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM Упаковки WHERE Код=" + id.ToString(), connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
