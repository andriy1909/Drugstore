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
        bool addEdit; //true-додавання; false-редагування

        public GoodForm()
        {
            InitializeComponent();
            addEdit = true;
        }

        public GoodForm(int id)
        {
            InitializeComponent();
            Goods goods = new Goods();
            goods.getDataItem(id);
            
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
            pictureBox1.Image = goods.getImage();
            cbReturn.Checked = goods.isReturn;
            checkBox1.Checked = goods.recept;
            cbAnalog.Text = Convert.ToString(goods.analog);
            tbPos.Text = goods.positiont;

            addEdit = false;
        }

        private void GoodForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Товари". При необходимости она может быть перемещена или удалена.
            this.товариTableAdapter.Fill(this.drugstoreDataSet.Товари);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Упаковки". При необходимости она может быть перемещена или удалена.
            this.упаковкиTableAdapter.Fill(this.drugstoreDataSet.Упаковки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Виробники". При необходимости она может быть перемещена или удалена.
            this.виробникиTableAdapter.Fill(this.drugstoreDataSet.Виробники);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            goods.name = tbName.Text;
            goods.odVum = tbOdVum.Text;
            goods.morion = Convert.ToInt32(tbKodMoriona.Text);
            goods.minCount = Convert.ToInt32(tbMinZapas.Text);
            goods.articul = tbArtikyl.Text;
            goods.barCode = tbBarCode.Text;
            goods.stavkaNDS = float.Parse(tbSatvkaNDS.Text);
            goods.maker = Convert.ToInt32(cbProducer.SelectedValue);
            goods.inPrice = float.Parse(tbInPrice.Text);
            goods.inPriceNoNDS = float.Parse(tbInPriceNoNDS.Text);
            goods.extra = float.Parse(textBox2.Text);
            goods.pack = Convert.ToInt32(cbPack.SelectedValue);
            goods.price = float.Parse(textBox1.Text);
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
                goods.updateItem();
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
 
        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = (sender as TextBox).Text;
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
                if (e.KeyChar == '.' || e.KeyChar == ',')
                    if (!text.Contains(".") && text.Length > 1)
                        e.KeyChar = '.';
                    else
                        e.Handled = true;
                else
                    e.Handled = true;
        }

        private void Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
                e.Handled = true;
        }

        private void TextDigit(object sender, EventArgs e)
        {
            try
            {
                if ((sender as TextBox).Text == "")
                    (sender as TextBox).Text = "0";
                else
                    (sender as TextBox).Text = Convert.ToDouble((sender as TextBox).Text).ToString();
            }
            catch
            {
            }
        }
    }
}
