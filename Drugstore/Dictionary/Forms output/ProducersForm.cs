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
    public partial class ProducersForm : UserControl
    {
        public ProducersForm()
        {
            InitializeComponent();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProducerForm PForm = new ProducerForm();
            if (PForm.ShowDialog() == DialogResult.OK)
                виробникиTableAdapter.Fill(drugstoreDataSet.Виробники);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ProducerForm PForm = new ProducerForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (PForm.ShowDialog() == DialogResult.OK)
                    виробникиTableAdapter.Fill(drugstoreDataSet.Виробники);
            }
        }

        private void ProducersForm_Load(object sender, EventArgs e)
        {
            виробникиTableAdapter.Fill(drugstoreDataSet.Виробники);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProducerForm PForm = new ProducerForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            if (PForm.ShowDialog() == DialogResult.OK)
                виробникиTableAdapter.Fill(drugstoreDataSet.Виробники);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                if (MessageBox.Show("Видалити запис?", "Попередження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Producers.deleteId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    виробникиTableAdapter.Fill(drugstoreDataSet.Виробники);
                }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            виробникиTableAdapter.Fill(drugstoreDataSet.Виробники);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
