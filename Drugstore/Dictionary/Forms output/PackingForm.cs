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
    public partial class PackingForm : UserControl
    {
        public PackingForm()
        {
            InitializeComponent();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            PackForm PForm = new PackForm();
            PForm.ShowDialog();
            if (PForm.ShowDialog() == DialogResult.OK)
                this.упаковкиTableAdapter.Fill(this.drugstoreDataSet.Упаковки);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                PackForm PForm = new PackForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (PForm.ShowDialog() == DialogResult.OK)
                    this.упаковкиTableAdapter.Fill(this.drugstoreDataSet.Упаковки);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Packing.deleteId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                this.упаковкиTableAdapter.Fill(this.drugstoreDataSet.Упаковки);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PackForm PForm = new PackForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            PForm.ShowDialog();
        }

        private void PackingForm_Load(object sender, EventArgs e)
        {
            this.упаковкиTableAdapter.Fill(this.drugstoreDataSet.Упаковки);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            PackForm PForm = new PackForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            PForm.ShowDialog();
        }
    }
}
