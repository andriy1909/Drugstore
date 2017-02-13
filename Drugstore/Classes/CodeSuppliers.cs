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
    public class CodeSuppliers
    {
        public int id { get; set; }
        public int goods { get; set; }
        public string codegoods { get; set; }
        public int provider { get; set; }

        static string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

        public CodeSuppliers()
        {

        }

        public void setCodeSupplier(int id, int goods, string codegoods, int provider)
        {
            this.id = id;
            this.goods = goods;
            this.codegoods = codegoods;
            this.provider = provider;
        }

        public void getDataItem(int id)
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM КодиПостачальників WHERE Код=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            this.id = id;
            while (dataReader1.Read())
            {
                goods = Convert.ToInt32(dataReader1["Товар"]);
                codegoods = dataReader1["КодТовара"].ToString().Trim();
                provider = Convert.ToInt32(dataReader1["Постачальник"]);
            }
            bd.Close();
        }
        public void insertItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO КодиПостачальників VALUES(@goods, @codegoods, @provider)", connection);
                command.Parameters.AddWithValue("@goods", goods);
                command.Parameters.AddWithValue("@codegoods", codegoods);
                command.Parameters.AddWithValue("@provider", provider);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand("UPDATE КодиПостачальників SET Товар=@goods, КодТовара=@codegoods, Постачальник=@provider WHERE Код=" + id.ToString(), connection);
                command.Parameters.AddWithValue("@goods", goods);
                command.Parameters.AddWithValue("@codegoods", codegoods);
                command.Parameters.AddWithValue("@provider", provider);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void deleteId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM КодиПостачальників WHERE Код=" + id.ToString(), connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
