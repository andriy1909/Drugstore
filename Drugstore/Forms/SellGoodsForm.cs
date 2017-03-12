using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Drugstore.Forms
{
    public partial class SellGoodsForm : UserControl
    {
        string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

        public SellGoodsForm()
        {
            InitializeComponent();
        }

        public void addGood(int j)
        {
            try
            {
                int i = 0;
                dataGridView1.Rows.Add();
                i = dataGridView1.RowCount - 1;
                dataGridView1.Rows[i].Cells[0].Value = dataGridView2.Rows[j].Cells[2].Value;
                dataGridView1.Rows[i].Cells[1].Value = numericUpDown1.Value;
                decimal sum = (int)(double.Parse(dataGridView2.Rows[j].Cells[5].Value.ToString().Trim()) * Convert.ToDouble(numericUpDown1.Value) * 100);
                dataGridView1.Rows[i].Cells[2].Value = (sum / 100).ToString();

                this.товариTableAdapter.Fill(this.drugstoreDataSet.Товари);
                товариBindingSource.Sort = "Назва DESC";

                label1.Text = (double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString().Trim())).ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            addGood(dataGridView2.CurrentRow.Index);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                товариBindingSource.Filter = "Назва like '%" + textBox2.Text.Trim() + "%' ";
            }
            else
                товариBindingSource.Filter = "";
        }

        private void SellGoodsForm_Load(object sender, EventArgs e)
        {
            this.товариTableAdapter.Fill(this.drugstoreDataSet.Товари);
            товариBindingSource.Sort = "Назва DESC";
        }
        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int total = 0;
            // float cash = float.Parse(txtCash.Text.Substring(1, 5));
            // float change = 0.00f;
            //this prints the reciept
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up
            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("      DRUGSTORE", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Item Name".PadRight(30) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            decimal totalprice = 0;

          /*  foreach (string item in listBox1.Items)
            {
                //create the string to print on the reciept
                string productDescription = item;
                string productTotal = item.Substring(item.Length - 6, 6);
                float productPrice = float.Parse(item.Substring(item.Length - 5, 5));

                //MessageBox.Show(item.Substring(item.Length - 5, 5) + "PROD TOTAL: " + productTotal);

                totalprice += productPrice;
                if (productDescription.Contains("  -"))
                {
                    string productLine = productDescription.Substring(0, 24);
                    graphic.DrawString(productLine, new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Red), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }
                else
                {
                    string productLine = productDescription;
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }
            }
           */

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string productDescription = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
                string productTotal = dataGridView1.Rows[i].Cells[1].Value.ToString().Trim();
                decimal productPrice = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value.ToString().Trim());

                totalprice += productPrice;

                // if (productDescription.Contains("  -"))
                // {
                string productPriceOut = string.Format("{0:0.00}", productPrice);
                string productLine = productDescription;
                graphic.DrawString(productLine + "            " + productPriceOut, new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Red), startX, startY + offset);
                offset = offset + (int)fontHeight + 5; //make the spacing consistent

                // graphic.DrawString(productPriceOut, new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Red), startX, startY + offset);
                // offset = offset + (int)fontHeight + 5; //make the spacing consistent

             /* string productLine = productDescription;
                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, 0);
                string productPriceOut = productPrice.ToString().Trim();
                graphic.DrawString(productPriceOut, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }
                else
                {
                    string productLine = productDescription;

                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }
                */   
            }

            // change = (cash - totalprice);
            // when we have drawn all of the items add the total
            offset = offset + 20; //make some room so that the total stands out.
            graphic.DrawString("Всього ".PadRight(30) + String.Format("{0:c}", totalprice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            // offset = offset + 30; //make some room so that the total stands out.
            // graphic.DrawString("CASH ".PadRight(30) + String.Format("{0:c}", cash), font, new SolidBrush(Color.Black), startX, startY + offset);
            // offset = offset + 15;
            // graphic.DrawString("CHANGE ".PadRight(30) + String.Format("{0:c}", change), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("       Дякую за покупку,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("       Одужуйте швидше;)", font, new SolidBrush(Color.Black), startX, startY + offset);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("До сплати: " + label1.Text);
                label1.Text = "0";
                textBox1.Clear();

                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument; //add the document to the dialog box...        
                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing
                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                DialogResult result = printDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    printDocument.Print();
                }

                dataGridView1.Rows.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
          
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sort;
            if (comboBox1.Text == "▼")
                sort = "DESC";
            else
                sort = "ASC";
            товариBindingSource.Sort = comboBox3.Text + " " + sort;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView2.Rows[0].Selected = true;
                int i = товариBindingSource.Find("ШтрихКод", textBox1.Text);
                textBox1.Clear();
                if (i >= 0)
                {
                    addGood(i);
                }
                else
                    MessageBox.Show("Не знайдено");
            }
        }
    }
}
