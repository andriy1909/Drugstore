using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore
{
    class InvoicesTbl : Invoices
    {
        public int id { get; set; }
        public int doc { get; set; }
        public int good { get; set; }
        public string barCode { get; set; }
        public string nameGood { get; set; }
        public int pack { get; set; }
        public int count { get; set; }
        public decimal price { get; set; }
        public decimal discont { get; set; }

        public InvoicesTbl()
        {

        }

        public void getData(int id)
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM " + typeDoc + "Тбл WHERE Код=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                this.id = id;
                doc = (int)dataReader1["Документ"];
                good = (int)dataReader1["Товар"];
                pack = (int)dataReader1["Упаковка"];
                count = (int)dataReader1["Кількість"];
                price = (decimal)dataReader1["Ціна"];
                discont = (decimal)dataReader1["Знижка"];
                Goods goodDic = new Goods();
                goodDic.getDataItem(good);
                nameGood = goodDic.name;
                barCode = goodDic.barCode;
            }
        bd.Close();
        }

        public void insertItemTbl()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO " + typeDoc + "Тбл VALUES(@doc, @good, @pack, @count, @price, @discont)", connection);
                command.Parameters.AddWithValue("@doc", doc);
                command.Parameters.AddWithValue("@good", good);
                command.Parameters.AddWithValue("@pack", pack);
                command.Parameters.AddWithValue("@count", count);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@discont", discont);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateItemTbl()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE " + typeDoc + "Тбл SET Документ=@doc, Товар=@good, Упаковка=@pack, Кількість=@count, Ціна=@price, Знижка=@discont WHERE Код=" + id.ToString(), connection);
                command.Parameters.AddWithValue("@doc", doc);
                command.Parameters.AddWithValue("@good", good);
                command.Parameters.AddWithValue("@pack", pack);
                command.Parameters.AddWithValue("@count", count);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@discont", discont);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void deleteIdTbl(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "DELETE " + typeDoc + "Тбл " +
                    "WHERE Код=" + id.ToString(), connection);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void deleteIdTblTbl(int id, string typeDoc)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "DELETE " + typeDoc + "Тбл " +
                    "WHERE Код=" + id.ToString(), connection);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
