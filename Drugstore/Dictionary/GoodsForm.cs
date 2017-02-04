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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
