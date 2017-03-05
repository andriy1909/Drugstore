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
