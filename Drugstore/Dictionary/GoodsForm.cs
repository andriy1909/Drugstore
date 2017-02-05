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
        public GoodsForm(Control contr)
        {
            Parent = contr;
            InitializeComponent();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            GoodForm GForm = new GoodForm();
            GForm.Show();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GoodForm GForm = new GoodForm();
            GForm.Show();
            GoodsForm_DataGrid_RowIndex.Row_ind = e.RowIndex;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            goods.deleteId(Convert.ToInt32(dataGridView1.SelectedCells[0].Value)); // Потрібно провірити
            dataGridView1.Refresh(); // Не знаю чи взагалі потрібно но обновити нада
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            GoodForm GForm = new GoodForm();
            GForm.Show();
        }
    }
}
