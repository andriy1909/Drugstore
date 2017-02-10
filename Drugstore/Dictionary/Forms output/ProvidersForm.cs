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
            Providers.deleteId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)); // Потрібно провірити
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ProviderForm ProForm = new ProviderForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            ProForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProvidersForm_Load(object sender, EventArgs e)
        {
            //Providers.getAllItems();
            dataGridView1.DataSource = Providers.getAllItems().Tables[13];
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
