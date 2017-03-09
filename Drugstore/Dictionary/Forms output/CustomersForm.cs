using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore.Dictionary
{
    public partial class CustomersForm : UserControl
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            CustomerForm CForm = new CustomerForm();
            if (CForm.ShowDialog() == DialogResult.OK)
                партнериTableAdapter.Fill(drugstoreDataSet.Партнери);
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            партнериTableAdapter.Fill(drugstoreDataSet.Партнери);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                CustomerForm CForm = new CustomerForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (CForm.ShowDialog() == DialogResult.OK)
                    партнериTableAdapter.Fill(drugstoreDataSet.Партнери);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show("Видалити запис?", "Попередження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Customers.deleteId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    партнериTableAdapter.Fill(drugstoreDataSet.Партнери);
                }
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            партнериTableAdapter.Fill(drugstoreDataSet.Партнери);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerForm CForm = new CustomerForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            if (CForm.ShowDialog() == DialogResult.OK)
                партнериTableAdapter.Fill(drugstoreDataSet.Партнери);
        }
    }
}
