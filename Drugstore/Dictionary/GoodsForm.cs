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
            GForm.ShowDialog();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Goods.deleteId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)); // Потрібно провірити
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            GoodForm GForm = new GoodForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            GForm.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GoodForm GForm = new GoodForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            GForm.ShowDialog();
        }

        private void GoodsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Товари". При необходимости она может быть перемещена или удалена.
            //this.товариTableAdapter.Fill(this.drugstoreDataSet.Товари);
        }
    }
}
