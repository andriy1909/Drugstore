using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore.Documents
{
    public partial class InvoiceInForm : Form
    {
        public InvoiceInForm()
        {
            InitializeComponent();
        }

        private void InvoiceInForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Товари". При необходимости она может быть перемещена или удалена.
            this.товариTableAdapter.Fill(this.drugstoreDataSet.Товари);

        }
    }
}
