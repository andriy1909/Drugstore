using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore
{
    class Document
    {
        public int num { get; set; }
        public DateTime date { get; set; }
        public int respons { get; set; }
        public int partner { get; set; }
        public int status { get; set; }
        public string memo { get; set; }

        public static string connectString = Properties.Settings.Default.DrugstoreConnectionString;
        public string typeDoc = "";
        
        public void deleteId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "DELETE " + typeDoc + " " +
                    "WHERE НомерДокумента=" + id.ToString(), connection);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static int getLastNum(string typeDoc)
        {
            int id = 0;
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command = new SqlCommand("select top(1) id from "+typeDoc+" ORDER BY id DESC", bd);

            SqlDataReader dataReader1 = command.ExecuteReader();
            while (dataReader1.Read())
            {
                id = (int)dataReader1["id"];
            }
            bd.Close();
            return id;
        }
        public int getLastNum()
        {
            int id = 0;
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command = new SqlCommand("select top(1) id from " + typeDoc + " ORDER BY id DESC", bd);

            SqlDataReader dataReader1 = command.ExecuteReader();
            while (dataReader1.Read())
            {
                id = (int)dataReader1["id"];
            }
            bd.Close();
            return id;
        }
        public static void deleteId(int id, string typeDoc)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "DELETE " + typeDoc + " " +
                    "WHERE НомерДокумента=" + id.ToString(), connection);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
