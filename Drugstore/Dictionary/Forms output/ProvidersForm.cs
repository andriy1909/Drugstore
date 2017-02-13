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
    public partial class ProvidersForm : UserControl
    {
        public ProvidersForm()
        {
            InitializeComponent();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProviderForm ProForm = new ProviderForm();
            if (ProForm.ShowDialog() == DialogResult.OK)
                постачальникиTableAdapter.Fill(drugstoreDataSet.Постачальники);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                if (MessageBox.Show("Видалити запис?", "Попередження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Providers.deleteId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)); // Потрібно провірити
                    постачальникиTableAdapter.Fill(drugstoreDataSet.Постачальники);
                }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ProviderForm ProForm = new ProviderForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (ProForm.ShowDialog() == DialogResult.OK)
                    постачальникиTableAdapter.Fill(drugstoreDataSet.Постачальники);
            }

        }
        
         private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProviderForm ProForm = new ProviderForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            if (ProForm.ShowDialog() == DialogResult.OK)
                постачальникиTableAdapter.Fill(drugstoreDataSet.Постачальники);
        }

        private void ProvidersForm_Load(object sender, EventArgs e)
        {
            постачальникиTableAdapter.Fill(drugstoreDataSet.Постачальники);
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            постачальникиTableAdapter.Fill(drugstoreDataSet.Постачальники);
        }
    }
}
