using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class ProviderForm : Form
    {
        bool addEdit; //true-додавання; false-редагування
        public ProviderForm()
        {
            InitializeComponent();
            addEdit = true;
        }

        public ProviderForm(int id)
        {
            InitializeComponent();
            Providers providers = new Providers();
            providers.getDataItem(id);

            tbCode.Text = Convert.ToString(providers.id);
            tbName.Text = providers.name;
            tbPhone.Text = providers.number;

            addEdit = false;
        }
        private void ProviderForm_Load(object sender, EventArgs e)
        {

        }
        private void btOk_Click(object sender, EventArgs e)
        {
            Providers providers = new Providers();
            providers.name = tbName.Text;
            providers.number = tbPhone.Text;
            if (addEdit)
                providers.insertItem();
            else
                providers.updateItem();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
