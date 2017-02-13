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
    public partial class PackForm : Form
    {
        bool addEdit; //true-додавання; false-редагування
        int id;

        public PackForm()
        {
            InitializeComponent();
            addEdit = true;
        }

        public PackForm(int id)
        {
            InitializeComponent();
            Packing packing = new Packing();
            packing.getDataItem(id);
            this.id = id;
            tbName.Text = packing.name;
            nNumerosity.Value = packing.numerosity;

            addEdit = false;
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            Packing packing = new Packing();
            packing.id = id;
            packing.name = tbName.Text;
            packing.numerosity = Convert.ToInt32(nNumerosity.Value);
            if (addEdit)
                packing.insertItem();
            else
                packing.updateItem();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
