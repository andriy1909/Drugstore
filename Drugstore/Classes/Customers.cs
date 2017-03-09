using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore
{
    public class Customers
    {
        public int id { get; set; } //код
        public string surname { get; set; } //прізвище
        public string name { get; set; } //імя
        public string secondname { get; set; } //побатькові
        public string number { get; set; } //мобільний телефон
        public string card { get; set; } //картка
        public decimal discounts { get; set; } //знижки
        public DateTime birth { get; set; } //дата народження
        public DateTime registration { get; set; } //дата реєстрації

        static string connectString = Properties.Settings.Default.DrugstoreConnectionString;

        public Customers()
        { }

        void setCustomers(string surname, string name, string secondname, string number,
            string card, decimal discounts, DateTime birth, DateTime registration, int id = 0)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.secondname = secondname;
            this.number = number;
            this.card = card;
            this.discounts = discounts;
            this.birth = birth;
            this.registration = registration;
        }

        public void getDataItem(int id) // неготово
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Партнери WHERE Код=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            this.id = id;
            while (dataReader1.Read())
            {
                surname = dataReader1["Прізвище"].ToString().Trim();
                name = dataReader1["Імя"].ToString().Trim();
                secondname = dataReader1["Побатькові"].ToString().Trim();
                number = dataReader1["Телефон"].ToString().Trim();
                card = dataReader1["Картка"].ToString().Trim();
                discounts = (decimal)dataReader1["Знижка"];
                birth = (DateTime)dataReader1["ДатаНар"];
                registration = (DateTime)dataReader1["ДатаРеєстр"];
            }
            bd.Close();
        }

        public void insertItem() // неготово
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Партнери VALUES(@surname, @name, @secondname, @number,"+
                    "@card, @discounts, @birth, @registration)", connection);

                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@secondname", secondname);
                command.Parameters.AddWithValue("@number", number);
                command.Parameters.AddWithValue("@card", card);
                command.Parameters.AddWithValue("@discounts", discounts);
                command.Parameters.AddWithValue("@birth", birth);
                command.Parameters.AddWithValue("@registration", registration);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Партнери SET Прізвище=@surname, Імя=@name, Побатькові=@secondname," +
                    "Телефон=@number, Картка=@card, Знижка=@discounts, ДатаНар=@birth, ДатаРеєстр=@registration " +
                    "WHERE Код=" + id.ToString(), connection);

                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@secondname", secondname);
                command.Parameters.AddWithValue("@number", number);
                command.Parameters.AddWithValue("@card", card);
                command.Parameters.AddWithValue("@discounts", discounts);
                command.Parameters.AddWithValue("@birth", birth);
                command.Parameters.AddWithValue("@registration", registration);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void deleteId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "DELETE FROM Партнери " +
                    "WHERE Код=" + id.ToString(), connection);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
