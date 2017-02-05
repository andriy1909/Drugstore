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
    public partial class GoodForm : Form
    {
        public GoodForm()
        {
            InitializeComponent();
        }

        private void GoodForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Упаковки". При необходимости она может быть перемещена или удалена.
            this.упаковкиTableAdapter.Fill(this.drugstoreDataSet.Упаковки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Виробники". При необходимости она может быть перемещена или удалена.
            this.виробникиTableAdapter.Fill(this.drugstoreDataSet.Виробники);

            //Дія при редагуванні чи детальному огляді
            if () // потрібно придумати логіку
            {
            Goods goods = new Goods();
            goods.getDataItem(GoodsForm_DataGrid_RowIndex.Row_ind);

            tbCode.Text = Convert.ToString(goods.id);
            tbName.Text = goods.name;
            tbOdVum.Text = goods.odVum;
            tbKodMoriona.Text = Convert.ToString(goods.morion);
            tbMinZapas.Text = Convert.ToString(goods.minCount);
            tbArtikyl.Text = goods.articul;
            tbBarCode.Text = goods.barCode;
            tbSatvkaNDS.Text = Convert.ToString(goods.stavkaNDS);
            cbProducer.ValueMember = Convert.ToString(goods.maker);
            tbInPrice.Text = Convert.ToString(goods.inPrice);
            tbInPriceNoNDS.Text = Convert.ToString(goods.inPriceNoNDS);
            textBox2.Text = Convert.ToString(goods.extra);
            cbPack.ValueMember = Convert.ToString(goods.pack);
            textBox1.Text = Convert.ToString(goods.price);
            tbInform.Text = goods.info;
            pictureBox1.Image = goods.getImage; // Непонятки)
            cbReturn.Checked = goods.isReturn;
            checkBox1.Checked = goods.recept;
            tbAnalog.Text = Convert.ToString(goods.analog);
            textBox3.Text = Convert.ToString(goods.count);
            tbPos.Text = goods.positiont;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            goods.id = Convert.ToInt32(tbCode.Text);
            goods.name = tbName.Text;
            goods.odVum = tbOdVum.Text;
            goods.morion = Convert.ToInt32(tbKodMoriona.Text);
            goods.minCount = Convert.ToInt32(tbMinZapas.Text);
            goods.articul = tbArtikyl.Text;
            goods.barCode = tbBarCode.Text; 
            goods.stavkaNDS = float.Parse(tbSatvkaNDS.Text);
            goods.maker = Convert.ToInt32(cbProducer.ValueMember);
            goods.inPrice = float.Parse(tbInPrice.Text); 
            goods.inPriceNoNDS = float.Parse(tbInPriceNoNDS.Text);
            goods.extra = float.Parse(textBox2.Text);
            goods.pack = Convert.ToInt32(cbPack.ValueMember);
            goods.price = float.Parse(textBox1.Text);
            goods.info = tbInform.Text;
            goods.setImage(pictureBox1.Image);
            goods.isReturn = cbReturn.Checked;
            goods.recept = checkBox1.Checked;
            goods.analog = Convert.ToInt32(tbAnalog.Text);
            goods.count = Convert.ToInt32(textBox3.Text);
            goods.positiont = tbPos.Text;

            goods.insertItem();
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
