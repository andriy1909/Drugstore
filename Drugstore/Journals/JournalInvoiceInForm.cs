using System;
using Drugstore.Documents;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore.Journals
{
    public partial class JournalInvoiceInForm : UserControl
    {
        public JournalInvoiceInForm()
        {
            InitializeComponent();
        }

        public void update()
        {
            накладнаПриходаTableAdapter.Fill(drugstoreDataSet.НакладнаПрихода);
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            InvoiceInForm form = new InvoiceInForm();
            if (form.ShowDialog() == DialogResult.OK)
                update();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                InvoiceInForm form = new InvoiceInForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (form.ShowDialog() == DialogResult.OK)
                    update();
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                if (MessageBox.Show("Видалити запис?", "Попередження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Invoices.deleteId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), "НакладнаПрихода");
                    update();
                }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                InvoiceInForm GForm = new InvoiceInForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (GForm.ShowDialog() == DialogResult.OK)
                    update();
            }
        }       

        private void JournalInvoiceInForm_Load(object sender, EventArgs e)
        {
            update();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
