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
            goods.barCode = dataGridView1; // Штрих код???
            goods.stavkaNDS = float.Parse(tbSatvkaNDS.Text);
            goods.maker = Convert.ToInt32(tbProducer.Text);
            goods.inPrice = float.Parse(tbInPrice.Text); 
            goods.inPriceNoNDS = float.Parse(tbInPriceNoNDS.Text);
            goods.extra = float.Parse(textBox2.Text);
            goods.pack = dataGridView2; // Упаковки???
            goods.price = float.Parse(textBox1.Text);
            goods.info = tbInform.Text;
            goods.image = pictureBox1; // Картинка???
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
