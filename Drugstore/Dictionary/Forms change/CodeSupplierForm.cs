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
    public partial class CodeSupplierForm : Form
    {
        bool addEdit; //true-додавання; false-редагування
        public CodeSupplierForm()
        {
           InitializeComponent();
           addEdit = true;
        }

        public CodeSupplierForm(int id)
        {
            InitializeComponent();
            CodeSuppliers codesupplier = new CodeSuppliers();
            codesupplier.getDataItem(id);

           // textBox1.Text = Convert.ToString(codesupplier.id);
            cbGoods.SelectedValue = Convert.ToInt32(codesupplier.goods);
            tbGoodsCode.Text = codesupplier.codegoods;
            cbProvider.SelectedValue = Convert.ToInt32(codesupplier.provider);
            
            addEdit = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            CodeSuppliers codesupplier = new CodeSuppliers();
            codesupplier.goods = Convert.ToInt32(cbGoods.SelectedValue);
            codesupplier.codegoods = tbGoodsCode.Text;
            codesupplier.provider = Convert.ToInt32(cbProvider.SelectedValue); 
            if(addEdit)
                codesupplier.insertItem();
            else
                codesupplier.updateItem();
        }
        
        private void CodeSupplierForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Постачальники". При необходимости она может быть перемещена или удалена.
            this.постачальникиTableAdapter.Fill(this.drugstoreDataSet.Постачальники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Товари". При необходимости она может быть перемещена или удалена.
            this.товариTableAdapter.Fill(this.drugstoreDataSet.Товари);

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
