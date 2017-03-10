using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore
{
    public class Workers
    {
        public int id { get; set; } //код
        public string passport { get; set; } //паспорт
        public string identnumb { get; set; } //ідинтифікаційний номер
        public string surname { get; set; } //прізвище
        public string name { get; set; } //імя
        public string secondname { get; set; } //побатькові
        public string number { get; set; } //мобільний телефон
        public int workplace { get; set; } //робоче місце
        public DateTime birth { get; set; } //дата народження
        public DateTime registration { get; set; } //дата прийому
        public string region { get; set; } //область
        public string area { get; set; } //район
        public string city { get; set; } //місто
        public string index { get; set; } //поштовий індекс
        public string address { get; set; } //адрес
        public string position { get; set; } //посада
        public string login { get; set; } //логін
        public string password { get; set; } //пароль

        static string connectString = Properties.Settings.Default.DrugstoreConnectionString;

        public Workers()
        { }

        void setWorkers(string passport, string identnumb, string surname, string name, string secondname, string number,
        int workplace, DateTime birth, DateTime registration, string region, string area, 
        string city, string index, string address, string position, string login, string password, int id = 0)
        {
            this.id = id;
            this.passport = passport;
            this.identnumb = identnumb;
            this.surname = surname;
            this.name = name;
            this.secondname = secondname;
            this.number = number;
            this.workplace = workplace;
            this.birth = birth;
            this.registration = registration;
            this.region = region;
            this.area = area;
            this.city = city;
            this.index = index;
            this.address = address;
            this.position = position;
            this.login = login;
            this.password = password;
        }

        public void getDataItem(int id)
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Працівники WHERE Код=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            this.id = id;
            while (dataReader1.Read())
            {
                passport = dataReader1["Паспорт"].ToString().Trim();
                identnumb = dataReader1["ІдентКод"].ToString().Trim();
                surname = dataReader1["Прізвище"].ToString().Trim();
                name = dataReader1["Імя"].ToString().Trim();
                secondname = dataReader1["Побатькові"].ToString().Trim();
                number = dataReader1["Телефон"].ToString().Trim();
                workplace = Convert.ToInt32(dataReader1["РобочеМісце"]);
                birth = (DateTime)dataReader1["ДатаНар"];
                registration = (DateTime)dataReader1["ДатаПрийому"];
                region = dataReader1["Область"].ToString().Trim();
                area = dataReader1["Район"].ToString().Trim();
                city = dataReader1["Місто"].ToString().Trim();
                index = dataReader1["ПоштІндекс"].ToString().Trim();
                address = dataReader1["Адреса"].ToString().Trim();
                position = dataReader1["Посада"].ToString().Trim();
                login = dataReader1["Логін"].ToString().Trim();
                password = dataReader1["Пароль"].ToString().Trim(); 
            }
            bd.Close();
        }

        public void insertItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Працівники VALUES(@passport, @identnumb, @surname, @name, @secondname, @number," +
                    "@workplace, @birth, @registration, @region, @area, @city, @index, @address, " +
                    "@position, @login, @password)", connection);

                command.Parameters.AddWithValue("@passport", passport);
                command.Parameters.AddWithValue("@identnumb", identnumb);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@secondname", secondname);
                command.Parameters.AddWithValue("@number", number);
                command.Parameters.AddWithValue("@workplace", workplace);
                command.Parameters.AddWithValue("@birth", birth);
                command.Parameters.AddWithValue("@registration", registration);
                command.Parameters.AddWithValue("@region", region);
                command.Parameters.AddWithValue("@area", area);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@index", index);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@position", position);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Працівники SET Паспорт=@passport, ІдентКод=@identnumb, Прізвище=@surname, Імя=@name, Побатькові=@secondname, " +
                    "Телефон=@number, РобочеМісце=@workplace, ДатаНар=@birth, ДатаПрийому=@registration, Область=@region, "+
                    "Район=@area, Місто=@city, ПоштІндекс=@index, Адреса=@address, Посада=@position, Логін=@login, Пароль=@password " +
                    "WHERE Код=" + id.ToString(), connection);
                command.Parameters.AddWithValue("@passport", passport);
                command.Parameters.AddWithValue("@identnumb", identnumb);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@secondname", secondname);
                command.Parameters.AddWithValue("@number", number);
                command.Parameters.AddWithValue("@workplace", workplace);
                command.Parameters.AddWithValue("@birth", birth);
                command.Parameters.AddWithValue("@registration", registration);
                command.Parameters.AddWithValue("@region", region);
                command.Parameters.AddWithValue("@area", area);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@index", index);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@position", position);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void deleteId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "DELETE FROM Працівники " +
                    "WHERE Код=" + id.ToString(), connection);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
