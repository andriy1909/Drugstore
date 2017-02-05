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
    public class Goods
    {
        public int id { get; set; }              //код
        public string name { get; set; }         //назва
        public string odVum { get; set; }        //од. виміру
        public int morion { get; set; }          //код моріона
        public int minCount { get; set; }        //мінімальний запас 
        public string articul { get; set; }      //артикул
        public string barCode { get; set; }      //штрихкод
        public float stavkaNDS { get; set; }     //ставка НДС
        public int maker { get; set; }           //виробник
        public float inPrice { get; set; }       //вх ціна
        public float inPriceNoNDS { get; set; }  //вх ціна без ндс
        public float extra { get; set; }         //націнка
        public int pack { get; set; }            //упаковка
        public float price { get; set; }         //ціна
        public string info { get; set; }         //інформація
        public byte[] image { get; set; }        //зображення
        public bool isReturn { get; set; }       //можл повернення
        public bool recept { get; set; }         //рецепт
        public int analog { get; set; }          //аналог
        public int count { get; set; }           //кількість
        public string positiont { get; set; }    //позиція

        static string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

        public Goods()
        {

        }

        public void setGood(string name, string odVum, int morion, int minCount, string articul, string barCode, float stavkaNDS,
            int maker, float inPrice, float inPriceNoNDS, float extra, int pack, float price, string info, Image image, bool isReturn,
            bool recept, int analog, int count, string positiont, int id = 0)
        {
            this.id = id;
            this.name = name;
            this.odVum = odVum;
            this.morion = morion;
            this.minCount = minCount;
            this.articul = articul;
            this.barCode = barCode;
            this.stavkaNDS = stavkaNDS;
            this.maker = maker;
            this.inPrice = inPrice;
            this.inPriceNoNDS = inPriceNoNDS;
            this.extra = extra;
            this.pack = pack;
            this.price = price;
            this.info = info;
            setImage(image);
            this.isReturn = isReturn;
            this.recept = recept;
            this.analog = analog;
            this.count = count;
            this.positiont = positiont;
        }

        public Image getImage()
        {
            Image newImage = null;
            if (image != null)
            {
                using (MemoryStream stream = new MemoryStream(image))
                {
                    newImage = Image.FromStream(stream);
                }
            }
            return newImage;
        }
        public void setImage(Image img)
        {
            ImageConverter converter = new ImageConverter();
            image = (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public void getDataItem(int id)
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Товари WHERE Код=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                name = dataReader1["Назва"].ToString().Trim();
                odVum = dataReader1["ОдВим"].ToString().Trim();
                morion = (int)dataReader1["КодМоріона"];
                minCount = (int)dataReader1["МінЗапас"];
                articul = dataReader1["Артикул"].ToString().Trim();
                barCode = dataReader1["ШтрихКод"].ToString().Trim();
                stavkaNDS = (float)dataReader1["СтавкаНДС"];
                maker = (int)dataReader1["Виробник"];
                inPrice = (float)dataReader1["ВхЦіна"];
                inPriceNoNDS = (float)dataReader1["ВхЦінаБезНДС"];
                extra = (float)dataReader1["Націнка"];
                pack = (int)dataReader1["Упаковка"];
                price = (float)dataReader1["Ціна"];
                info = dataReader1["Інформація"].ToString().Trim();
                image = (byte[])dataReader1["Фото"];
                isReturn = (bool)dataReader1["МожливістьПовернення"];
                recept = (bool)dataReader1["Рецепт"];
                analog = (int)dataReader1["Аналог"];
                count = (int)dataReader1["Кількість"];
                positiont = dataReader1["Позиція"].ToString().Trim();
            }
            bd.Close();
        }

        public void insertItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Товари VALUES(@name, @odVum, @morion, @minCount, @articul, @barCode, @stavkaNDS, @maker, " +
                    "@inPrice, @inPriceNoNDS, @extra, @pack, @price, @info, @image, @isReturn, @recept " +
                    "@analog, @count, @positiont)", connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@odVum", odVum);
                command.Parameters.AddWithValue("@morion", morion);
                command.Parameters.AddWithValue("@minCount", minCount);
                command.Parameters.AddWithValue("@articul", articul);
                command.Parameters.AddWithValue("@barCode", barCode);
                command.Parameters.AddWithValue("@stavkaNDS", stavkaNDS);
                command.Parameters.AddWithValue("@maker", maker);
                command.Parameters.AddWithValue("@inPrice", inPrice);
                command.Parameters.AddWithValue("@inPriceNoNDS", inPriceNoNDS);
                command.Parameters.AddWithValue("@extra", extra);
                command.Parameters.AddWithValue("@pack", pack);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@info", info);
                command.Parameters.AddWithValue("@image", image);
                command.Parameters.AddWithValue("@isReturn", isReturn);
                command.Parameters.AddWithValue("@recept", recept);
                command.Parameters.AddWithValue("@analog", analog);
                command.Parameters.AddWithValue("@count", count);
                command.Parameters.AddWithValue("@positiont", positiont);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateItem(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Товари SET Назва=@name, ОдВим=@odVum, КодМоріона=@morion, МінЗапас=@minCount, Артикул=@articul, ШтрихКод=@barCode, " +
                    "СтавкаНДС=@stavkaNDS, Виробник=@maker, ВхЦіна=@inPrice, ВхЦінаБезНДС=@inPriceNoNDS, Націнка=@extra, Упаковка=@pack, " +
                    "Ціна=@price, Інформація=@info, Фото=@image, МожливістьПовернення=@isReturn, Рецепт=@recept Аналог=@analog, Кількість=@count, " +
                    "Позиція=@positiont WHERE Код=" + id.ToString(), connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@odVum", odVum);
                command.Parameters.AddWithValue("@morion", morion);
                command.Parameters.AddWithValue("@minCount", minCount);
                command.Parameters.AddWithValue("@articul", articul);
                command.Parameters.AddWithValue("@barCode", barCode);
                command.Parameters.AddWithValue("@stavkaNDS", stavkaNDS);
                command.Parameters.AddWithValue("@maker", maker);
                command.Parameters.AddWithValue("@inPrice", inPrice);
                command.Parameters.AddWithValue("@inPriceNoNDS", inPriceNoNDS);
                command.Parameters.AddWithValue("@extra", extra);
                command.Parameters.AddWithValue("@pack", pack);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@info", info);
                command.Parameters.AddWithValue("@image", image);
                command.Parameters.AddWithValue("@isReturn", isReturn);
                command.Parameters.AddWithValue("@recept", recept);
                command.Parameters.AddWithValue("@analog", analog);
                command.Parameters.AddWithValue("@count", count);
                command.Parameters.AddWithValue("@positiont", positiont);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void deleteId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "DELETE FROM Товари " +
                    "WHERE Код=" + id.ToString(), connection);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}