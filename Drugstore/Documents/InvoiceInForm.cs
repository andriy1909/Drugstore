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
        bool addEdit; //true-додавання; false-редагування
        int id;

        public InvoiceInForm()
        {
            InitializeComponent();
            addEdit = true;
        }

        public InvoiceInForm(int id)
        {
            InitializeComponent();
            Invoices invoices = new Invoices();
            invoices.getDoc(id);
            this.id = id;
            dtpDate.Value = invoices.date;
            tbnNum.Text = id.ToString();
            cbPartner.Text = invoices.partner.ToString();

            addEdit = false;
        }

        private void InvoiceInForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Партнери". При необходимости она может быть перемещена или удалена.
            this.партнериTableAdapter.Fill(this.drugstoreDataSet.Партнери);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Товари". При необходимости она может быть перемещена или удалена.
            this.товариTableAdapter.Fill(this.drugstoreDataSet.Товари);

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                /*GoodForm GForm = new GoodForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (GForm.ShowDialog() == DialogResult.OK)
                    товариTableAdapter.Fill(drugstoreDataSet.Товари);*/
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            pnGoodsDic.Visible = false;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            pnGoodsDic.Visible = true;
        }

        
    
        private void btOk_Click(object sender, EventArgs e)
        {
            /*Goods goods = new Goods();
            goods.id = id;
            goods.name = tbName.Text;
            goods.odVum = cbOdVum.Text;
            goods.morion = tbKodMoriona.Text;
            goods.minCount = Convert.ToInt32(tbMinZapas.Text);
            goods.articul = tbArtikyl.Text;
            goods.barCode = tbBarCode.Text;
            goods.stavkaNDS = decimal.Parse(tbStavkaNDS.Text);
            goods.maker = Convert.ToInt32(cbProducer.SelectedValue);
            goods.inPrice = decimal.Parse(tbInPrice.Text);
            goods.inPriceNoNDS = decimal.Parse(tbInPriceNoNDS.Text);
            goods.extra = decimal.Parse(tbMarkUp.Text);
            goods.pack = Convert.ToInt32(cbPack.SelectedValue);
            goods.price = decimal.Parse(tbOutPrice.Text);
            goods.info = tbInform.Text;
            goods.setImage(pictureBox1.Image);
            goods.isReturn = cbReturn.Checked;
            goods.recept = checkBox1.Checked;
            if (cbAnalog.Text != "")
                goods.analog = Convert.ToInt32(cbAnalog.SelectedValue);
            else
                goods.analog = 0;
            goods.positiont = tbPos.Text;

            if (addEdit)
                goods.insertItem();
            else
                goods.updateItem();*/
        }
        
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
