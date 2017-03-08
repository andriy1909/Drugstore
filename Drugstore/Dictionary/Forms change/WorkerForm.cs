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
    public partial class WorkerForm : Form
    {
        bool addEdit; //true-додавання; false-редагування
        int id;
        public WorkerForm()
        {
            InitializeComponent();
            addEdit = true;
        }

        public WorkerForm(int id)
        {
            InitializeComponent();
            Workers work = new Workers();
            work.getDataItem(id);
            this.id = id;
            tbPassport.Text = work.passport;
            tbIdentNum.Text = work.identnumb;
            tbSurname.Text = work.surname;
            tbName.Text = work.name;
            tbSecondName.Text = work.secondname;
            tbNumber.Text = work.number;
            tbWorkPlace.Text = Convert.ToString(work.workplace);
            tbBirth.Text = Convert.ToString(work.birth);
            tbReg.Text = Convert.ToString(work.registration);
            tbRig.Text = work.region;
            tbArea.Text = work.area;
            tbCity.Text = work.city;
            tbIndex.Text = work.index;
            tbAddress.Text = work.address;
            tbPosition.Text = work.position;
            tbLogin.Text = work.login;
            tbPass.Text = work.password;

            addEdit = false;
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Workers work = new Workers();
            work.getDataItem(id);
            work.id = id;
            work.passport = tbPassport.Text;
            work.identnumb = tbIdentNum.Text;
            work.surname = tbSurname.Text;
            work.name = tbName.Text;
            work.secondname = tbSecondName.Text;
            work.number = tbNumber.Text;
            work.workplace = Convert.ToInt32(tbWorkPlace.Text);
            work.birth = Convert.ToDateTime(tbBirth.Text);
            work.registration = Convert.ToDateTime(tbReg.Text);
            work.region = tbRig.Text;
            work.area = tbArea.Text;
            work.city = tbCity.Text;
            work.index = tbIndex.Text;
            work.address = tbAddress.Text;
            work.position = tbPosition.Text;
            work.login = tbLogin.Text;
            work.password = tbPass.Text;
            if (addEdit)
                work.insertItem();
            else
                work.updateItem();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
