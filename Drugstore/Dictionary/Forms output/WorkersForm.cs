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
    public partial class WorkersForm : UserControl
    {
        public WorkersForm()
        {
            InitializeComponent();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            WorkerForm WForm = new WorkerForm();
            if (WForm.ShowDialog() == DialogResult.OK)
                працівникиTableAdapter.Fill(drugstoreDataSet.Працівники);
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            працівникиTableAdapter.Fill(drugstoreDataSet.Працівники);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                WorkerForm WForm = new WorkerForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (WForm.ShowDialog() == DialogResult.OK)
                    працівникиTableAdapter.Fill(drugstoreDataSet.Працівники);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show("Видалити запис?", "Попередження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Workers.deleteId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    працівникиTableAdapter.Fill(drugstoreDataSet.Працівники);
                }
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            працівникиTableAdapter.Fill(drugstoreDataSet.Працівники);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            WorkerForm WForm = new WorkerForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            if (WForm.ShowDialog() == DialogResult.OK)
                працівникиTableAdapter.Fill(drugstoreDataSet.Працівники);
        }
    }
}
