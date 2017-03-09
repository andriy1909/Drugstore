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
    public partial class CustomerForm : Form
    {
        bool addEdit; //true-додавання; false-редагування
        int id;
        public CustomerForm()
        {
            InitializeComponent();
            addEdit = true;
        }

        public CustomerForm(int id)
        {
            InitializeComponent();
            Customers cous = new Customers();
            cous.getDataItem(id);
            this.id = id;
            tbSurname.Text = cous.surname;
            tbName.Text = cous.name;
            tbSecondName.Text = cous.secondname;
            tbNumber.Text = cous.number;
            tbCard.Text = cous.card;
            tbDiscounts.Text = Convert.ToString(cous.discounts);
            tbBirth.Text = Convert.ToString(cous.birth);
            tbReg.Text = Convert.ToString(cous.registration);

            addEdit = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Customers cous = new Customers();
            cous.getDataItem(id);
            cous.id = id;
            cous.surname = tbSurname.Text;
            cous.name = tbName.Text;
            cous.secondname = tbSecondName.Text;
            cous.number = tbNumber.Text;
            cous.card = tbCard.Text;
            cous.discounts = Convert.ToDecimal(tbDiscounts.Text);
            cous.birth = Convert.ToDateTime(tbBirth.Text);
            cous.registration = Convert.ToDateTime(tbReg.Text);

            if (addEdit)
                cous.insertItem();
            else
                cous.updateItem();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
