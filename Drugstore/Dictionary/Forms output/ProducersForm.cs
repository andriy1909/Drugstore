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
            PForm.ShowDialog();
           // if (PForm.ShowDialog() == DialogResult.OK)
                this.виробникиTableAdapter.Fill(this.drugstoreDataSet.Виробники);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ProducerForm PForm = new ProducerForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (PForm.ShowDialog() == DialogResult.OK)
                    this.виробникиTableAdapter.Fill(this.drugstoreDataSet.Виробники);
            }
        }

        private void ProducersForm_Load(object sender, EventArgs e)
        {
            this.виробникиTableAdapter.Fill(this.drugstoreDataSet.Виробники);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProducerForm PForm = new ProducerForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            PForm.ShowDialog();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Producers.deleteId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                this.виробникиTableAdapter.Fill(this.drugstoreDataSet.Виробники);
            }
        }
    }
}
