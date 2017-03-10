using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore.Documents
{
    public partial class InvoiceInForm : Form
    {
        bool addEdit; //true-додавання; false-редагування
        int id;
        string typeDoc = "НакладнаПрихода";
        Invoices doc;

        public InvoiceInForm()
        {
            InitializeComponent();
            addEdit = true;
            doc = new Invoices(typeDoc);
        }

        public InvoiceInForm(int id)
        {
            InitializeComponent();
            Invoices doc = new Invoices(typeDoc);
            doc.getDoc(id);
            this.id = id;
            dtpDate.Value = doc.date;
            tbnNum.Text = id.ToString();
            //cbPartner.Text = Partners.GetName(doc.partner.ToString());

            addEdit = false;
        }

        private void InvoiceInForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Партнери". При необходимости она может быть перемещена или удалена.
            this.партнериTableAdapter.Fill(this.drugstoreDataSet.Партнери);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Товари". При необходимости она может быть перемещена или удалена.
            this.товариTableAdapter.Fill(this.drugstoreDataSet.Товари);

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                dataGridView1.Rows.Add(new object[] {
                    dataGridView2.CurrentRow.Cells[0].Value,
                    dataGridView2.CurrentRow.Cells[2].Value,
                    dataGridView2.CurrentRow.Cells[1].Value,
                    1,
                    dataGridView2.CurrentRow.Cells[3].Value
                });
                /*GoodForm GForm = new GoodForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (GForm.ShowDialog() == DialogResult.OK)
                    товариTableAdapter.Fill(drugstoreDataSet.Товари);*/
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            pnGoodsDic.Visible = false;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            pnGoodsDic.Visible = true;
        }
            
        private void btOk_Click(object sender, EventArgs e)
        {
            if (addEdit)
                doc.insertItem();
            else
                doc.updateItem();
        }
        
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                switch (toolStripTextBox1.Text)
                {
                    case "2789437865789":
                        dataGridView1.Rows.Add(new object[] {
                    4,
                    "2789437865789",
                    "Кафетин",
                    1,
                    50.00
                });
                        break;
                    case "23457873579784":
                        dataGridView1.Rows.Add(new object[] {
                    4,
                    "23457873579784",
                    "Випсогал",
                    1,
                    30.00
                });
                        break;
                    case "34574576787546":
                        dataGridView1.Rows.Add(new object[] {
                    4,
                    "34574576787546",
                    "Декортин",
                    1,
                    150.00
                });
                        break;
                    default:
                        MessageBox.Show("Товар не знайдений");
                        break;
                }
                toolStripTextBox1.Clear();
            }
        }
    }
}
