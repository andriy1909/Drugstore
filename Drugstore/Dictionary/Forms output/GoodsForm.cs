using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore.Dictionary
{
    public partial class GoodsForm : UserControl
    {
        public GoodsForm()
        {
            InitializeComponent();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            GoodForm GForm = new GoodForm();
            if (GForm.ShowDialog() == DialogResult.OK)
                товариTableAdapter.Fill(drugstoreDataSet.Товари);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                if (MessageBox.Show("Видалити запис?", "Попередження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Goods.deleteId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)); // Потрібно провірити
                    товариTableAdapter.Fill(drugstoreDataSet.Товари);
                }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                GoodForm GForm = new GoodForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (GForm.ShowDialog() == DialogResult.OK)
                    товариTableAdapter.Fill(drugstoreDataSet.Товари);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GoodForm GForm = new GoodForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            if (GForm.ShowDialog() == DialogResult.OK)
                товариTableAdapter.Fill(drugstoreDataSet.Товари);
        }

        private void GoodsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Товари". При необходимости она может быть перемещена или удалена.
            товариTableAdapter.Fill(drugstoreDataSet.Товари);
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            товариTableAdapter.Fill(this.drugstoreDataSet.Товари);
        }
    }
}
