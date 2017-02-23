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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                MessageBox.Show("До сплати: " + label1.Text);
                label1.Text = "0";
                textBox1.Clear();
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
