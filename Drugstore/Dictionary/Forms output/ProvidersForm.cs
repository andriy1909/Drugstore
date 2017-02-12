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
            ProForm.ShowDialog();
          
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Providers.deleteId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)); // Потрібно провірити
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ProviderForm ProForm = new ProviderForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                ProForm.ShowDialog();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProviderForm ProForm = new ProviderForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            ProForm.ShowDialog();
        }
        private void ProvidersForm_Load(object sender, EventArgs e)
        {
            this.постачальникиTableAdapter.Fill(this.drugstoreDataSet.Постачальники);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            постачальникиTableAdapter.Update(drugstoreDataSet);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

    }
}
