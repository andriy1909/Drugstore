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
        int id;

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
            this.id = id;
            tbName.Text = providers.name;
            tbPhone.Text = providers.number;

            addEdit = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Providers providers = new Providers();
            providers.id = id;
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
    }
}
