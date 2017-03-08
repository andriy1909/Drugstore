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
        public string birth { get; set; } //дата народження
        public string registration { get; set; } //дата реєстрації

        static string connectString = Properties.Settings.Default.DrugstoreConnectionString;

        public Customers()
        { }

        void setCustomers()
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
            while (dataReader1.Read())
            {

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
                command.Parameters.AddWithValue("@name", name);
               

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
