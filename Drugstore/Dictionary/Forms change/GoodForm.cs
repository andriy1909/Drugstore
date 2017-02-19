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
        int id;

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
            this.id = id;
            tbName.Text = goods.name;
            tbOdVum.Text = goods.odVum;
            tbKodMoriona.Text = goods.morion;
            tbMinZapas.Text = Convert.ToString(goods.minCount);
            tbArtikyl.Text = goods.articul;
            tbBarCode.Text = goods.barCode;
            tbStavkaNDS.Text = Convert.ToString(goods.stavkaNDS);

            cbProducer.DisplayMember = goods.maker.ToString();
            cbProducer.Text = Producers.getName(goods.maker);

            tbInPrice.Text = Convert.ToString(goods.inPrice);
            tbInPriceNoNDS.Text = Convert.ToString(goods.inPriceNoNDS);
            tbMarkUp.Text = Convert.ToString(goods.extra);

            cbPack.DisplayMember = goods.pack.ToString();
            cbPack.Text = Packing.getname(goods.pack);

            tbOutPrice.Text = Convert.ToString(goods.price);
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
            cbAnalog.Text = "";
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            goods.id = id;
            goods.name = tbName.Text;
            goods.odVum = tbOdVum.Text;
            goods.morion = tbKodMoriona.Text;
            goods.minCount = Convert.ToInt32(tbMinZapas.Text);
            goods.articul = tbArtikyl.Text;
            goods.barCode = tbBarCode.Text;
            goods.stavkaNDS = float.Parse(tbStavkaNDS.Text);
            goods.maker = Convert.ToInt32(cbProducer.SelectedValue);
            goods.inPrice = float.Parse(tbInPrice.Text);
            goods.inPriceNoNDS = float.Parse(tbInPriceNoNDS.Text);
            goods.extra = float.Parse(tbMarkUp.Text);
            goods.pack = Convert.ToInt32(cbPack.SelectedValue);
            goods.price = float.Parse(tbOutPrice.Text);
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float extraPrice = 0;
            if (tbMarkUp.Focused)
            {
                if (tbMarkUp.TextLength != 0)
                {
                   // tbInPriceNoNDS.Text = ((float.Parse(tbInPrice.Text)/100) * float.Parse(tbMarkUp.Text)).ToString().Trim();
                   // if (cbStavkaNDS.Checked)
                   //     extraPrice = (float.Parse(tbInPrice.Text) / 100 * float.Parse(tbStavkaNDS.Text)) + float.Parse(tbInPrice.Text) + float.Parse(tbMarkUp.Text);
                   //  else
                    extraPrice = (((float.Parse(tbInPrice.Text) / 100) * float.Parse(tbMarkUp.Text)) + float.Parse(tbInPrice.Text));
                }
                else
                    extraPrice = float.Parse(tbInPrice.Text);

                tbOutPrice.Text = extraPrice.ToString().Trim();
            }
        }

        private void tbInPrice_TextChanged(object sender, EventArgs e)
        {
            float InPrice = 0;
            if (tbInPrice.Focused)
            {
                if (tbInPrice.TextLength != 0)
                {
                  //  tbInPriceNoNDS.Text = (float.Parse(tbInPrice.Text) + float.Parse(tbMarkUp.Text)).ToString().Trim();
                  //  if (cbStavkaNDS.Checked)
                  //      InPrice = (float.Parse(tbInPrice.Text) / 100 * float.Parse(tbStavkaNDS.Text)) + float.Parse(tbInPrice.Text) + float.Parse(tbMarkUp.Text);
                  //  else
                InPrice = float.Parse(tbInPrice.Text) + ((float.Parse(tbInPrice.Text)/100)*float.Parse(tbMarkUp.Text));
                }
                tbOutPrice.Text = InPrice.ToString().Trim();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float OutPrice = 0;
            if (tbOutPrice.Focused)
            {
                if (tbOutPrice.TextLength != 0)
                    OutPrice = ((float.Parse(tbOutPrice.Text) - float.Parse(tbInPrice.Text))/(float.Parse(tbInPrice.Text)/100));

                tbMarkUp.Text = OutPrice.ToString().Trim();
            }
        }

        private void tbStavkaNDS_TextChanged(object sender, EventArgs e)
        {
            /*
            float NDS = 0;
            if (tbStavkaNDS.Focused)
                if(tbStavkaNDS.TextLength != 0)
                    NDS = (float.Parse(tbInPrice.Text) / 100 * float.Parse(tbStavkaNDS.Text)) + float.Parse(tbInPrice.Text) + float.Parse(tbMarkUp.Text);
                else
                    NDS = float.Parse(tbInPrice.Text) + float.Parse(tbMarkUp.Text);

            tbOutPrice.Text = NDS.ToString().Trim();
              */
        }

        private void cbStavkaNDS_CheckedChanged(object sender, EventArgs e)
        {
/*
            if (cbStavkaNDS.Checked)
            {
                tbStavkaNDS.Text = "0";
                tbInPriceNoNDS.Text = "0";
                tbOutPrice.Text = ((float.Parse(tbInPrice.Text) / 100 * float.Parse(tbStavkaNDS.Text)) + float.Parse(tbInPrice.Text) + float.Parse(tbMarkUp.Text)).ToString().Trim();
                tbStavkaNDS.Visible = true;
                tbInPriceNoNDS.Visible = true;
                label5.Visible = true;
                label11.Visible = true;

            }
            else
            {
                tbOutPrice.Text = (float.Parse(tbInPrice.Text) + float.Parse(tbMarkUp.Text)).ToString().Trim();
                tbStavkaNDS.Visible = false;
                tbInPriceNoNDS.Visible = false;
                label5.Visible = false;
                label11.Visible = false;
            }
           */
        }


    }
}
