namespace Drugstore
{
    partial class GoodForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbInform = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.tbInPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbInPriceNoNDS = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbSatvkaNDS = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMinZapas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKodMoriona = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAnalog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbArtikyl = new System.Windows.Forms.TextBox();
            this.tbPos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbReturn = new System.Windows.Forms.CheckBox();
            this.tbOdVum = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbBarCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbProducer = new System.Windows.Forms.ComboBox();
            this.cbPack = new System.Windows.Forms.ComboBox();
            this.drugstoreDataSet = new Drugstore.DrugstoreDataSet();
            this.виробникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.виробникиTableAdapter = new Drugstore.DrugstoreDataSetTableAdapters.ВиробникиTableAdapter();
            this.упаковкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.упаковкиTableAdapter = new Drugstore.DrugstoreDataSetTableAdapters.УпаковкиTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.виробникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.упаковкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 272);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Drugstore.Properties.Resources.fototapeta_brak_zdjecia;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Вибрати";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btOk);
            this.panel2.Controls.Add(this.btCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 30);
            this.panel2.TabIndex = 12;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(423, 3);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(82, 27);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "ОК";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(511, 3);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(82, 27);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Скасувати";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbInform);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(421, 246);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Інформація";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbInform
            // 
            this.tbInform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInform.Location = new System.Drawing.Point(3, 3);
            this.tbInform.Multiline = true;
            this.tbInform.Name = "tbInform";
            this.tbInform.Size = new System.Drawing.Size(415, 240);
            this.tbInform.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tbSatvkaNDS);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.tbInPriceNoNDS);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.tbInPrice);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ціни";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Вх. ціна";
            // 
            // tbInPrice
            // 
            this.tbInPrice.Location = new System.Drawing.Point(173, 42);
            this.tbInPrice.Name = "tbInPrice";
            this.tbInPrice.Size = new System.Drawing.Size(161, 20);
            this.tbInPrice.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(113, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Відп. ціна";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Вх. ціна без НДС";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ставка НДС";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Націнка";
            // 
            // tbInPriceNoNDS
            // 
            this.tbInPriceNoNDS.Location = new System.Drawing.Point(173, 68);
            this.tbInPriceNoNDS.Name = "tbInPriceNoNDS";
            this.tbInPriceNoNDS.Size = new System.Drawing.Size(161, 20);
            this.tbInPriceNoNDS.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 11;
            // 
            // tbSatvkaNDS
            // 
            this.tbSatvkaNDS.Location = new System.Drawing.Point(173, 120);
            this.tbSatvkaNDS.Name = "tbSatvkaNDS";
            this.tbSatvkaNDS.Size = new System.Drawing.Size(161, 20);
            this.tbSatvkaNDS.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.cbPack);
            this.tabPage1.Controls.Add(this.cbProducer);
            this.tabPage1.Controls.Add(this.tbBarCode);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.tbOdVum);
            this.tabPage1.Controls.Add(this.tbCode);
            this.tabPage1.Controls.Add(this.tbPos);
            this.tabPage1.Controls.Add(this.tbArtikyl);
            this.tabPage1.Controls.Add(this.tbAnalog);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.tbKodMoriona);
            this.tabPage1.Controls.Add(this.tbMinZapas);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.cbReturn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основне";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Виробник";
            // 
            // tbMinZapas
            // 
            this.tbMinZapas.Location = new System.Drawing.Point(297, 221);
            this.tbMinZapas.Name = "tbMinZapas";
            this.tbMinZapas.Size = new System.Drawing.Size(112, 20);
            this.tbMinZapas.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Бажаний мінімальний запас";
            // 
            // tbKodMoriona
            // 
            this.tbKodMoriona.Location = new System.Drawing.Point(99, 89);
            this.tbKodMoriona.Name = "tbKodMoriona";
            this.tbKodMoriona.Size = new System.Drawing.Size(112, 20);
            this.tbKodMoriona.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Код Моріона";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Аналог для препарата:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(99, 11);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(310, 20);
            this.tbName.TabIndex = 2;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbAnalog
            // 
            this.tbAnalog.Location = new System.Drawing.Point(297, 193);
            this.tbAnalog.Name = "tbAnalog";
            this.tbAnalog.Size = new System.Drawing.Size(112, 20);
            this.tbAnalog.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Назва товара";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(244, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Позиція";
            // 
            // tbArtikyl
            // 
            this.tbArtikyl.Location = new System.Drawing.Point(297, 37);
            this.tbArtikyl.Name = "tbArtikyl";
            this.tbArtikyl.Size = new System.Drawing.Size(112, 20);
            this.tbArtikyl.TabIndex = 2;
            // 
            // tbPos
            // 
            this.tbPos.Location = new System.Drawing.Point(297, 138);
            this.tbPos.Name = "tbPos";
            this.tbPos.Size = new System.Drawing.Size(112, 20);
            this.tbPos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Артикул";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Одиниці виміру";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(99, 37);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(112, 20);
            this.tbCode.TabIndex = 2;
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код товара";
            // 
            // cbReturn
            // 
            this.cbReturn.AutoSize = true;
            this.cbReturn.Location = new System.Drawing.Point(26, 115);
            this.cbReturn.Name = "cbReturn";
            this.cbReturn.Size = new System.Drawing.Size(149, 17);
            this.cbReturn.TabIndex = 7;
            this.cbReturn.Text = "Можливість повернення";
            this.cbReturn.UseVisualStyleBackColor = true;
            // 
            // tbOdVum
            // 
            this.tbOdVum.Location = new System.Drawing.Point(99, 63);
            this.tbOdVum.Name = "tbOdVum";
            this.tbOdVum.Size = new System.Drawing.Size(112, 20);
            this.tbOdVum.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(238, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "По рецепті";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(297, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(238, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Кількість";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(167, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 272);
            this.tabControl1.TabIndex = 11;
            // 
            // tbBarCode
            // 
            this.tbBarCode.Location = new System.Drawing.Point(99, 138);
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.Size = new System.Drawing.Size(112, 20);
            this.tbBarCode.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Штрихкод";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Упаковка";
            // 
            // cbProducer
            // 
            this.cbProducer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.виробникиBindingSource, "Назва", true));
            this.cbProducer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.виробникиBindingSource, "Код", true));
            this.cbProducer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виробникиBindingSource, "Назва", true));
            this.cbProducer.FormattingEnabled = true;
            this.cbProducer.Location = new System.Drawing.Point(297, 63);
            this.cbProducer.Name = "cbProducer";
            this.cbProducer.Size = new System.Drawing.Size(112, 21);
            this.cbProducer.TabIndex = 15;
            // 
            // cbPack
            // 
            this.cbPack.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.упаковкиBindingSource, "Назва", true));
            this.cbPack.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.упаковкиBindingSource, "Код", true));
            this.cbPack.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.упаковкиBindingSource, "Назва", true));
            this.cbPack.FormattingEnabled = true;
            this.cbPack.Location = new System.Drawing.Point(99, 164);
            this.cbPack.Name = "cbPack";
            this.cbPack.Size = new System.Drawing.Size(112, 21);
            this.cbPack.TabIndex = 16;
            // 
            // drugstoreDataSet
            // 
            this.drugstoreDataSet.DataSetName = "DrugstoreDataSet";
            this.drugstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // виробникиBindingSource
            // 
            this.виробникиBindingSource.DataMember = "Виробники";
            this.виробникиBindingSource.DataSource = this.drugstoreDataSet;
            // 
            // виробникиTableAdapter
            // 
            this.виробникиTableAdapter.ClearBeforeFill = true;
            // 
            // упаковкиBindingSource
            // 
            this.упаковкиBindingSource.DataMember = "Упаковки";
            this.упаковкиBindingSource.DataSource = this.drugstoreDataSet;
            // 
            // упаковкиTableAdapter
            // 
            this.упаковкиTableAdapter.ClearBeforeFill = true;
            // 
            // GoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 298);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.GoodForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.виробникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.упаковкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbBarCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbOdVum;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbPos;
        private System.Windows.Forms.TextBox tbArtikyl;
        private System.Windows.Forms.TextBox tbAnalog;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbKodMoriona;
        private System.Windows.Forms.TextBox tbMinZapas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cbReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbSatvkaNDS;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbInPriceNoNDS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbInPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbInform;
        private System.Windows.Forms.ComboBox cbPack;
        private System.Windows.Forms.ComboBox cbProducer;
        private DrugstoreDataSet drugstoreDataSet;
        private System.Windows.Forms.BindingSource виробникиBindingSource;
        private DrugstoreDataSetTableAdapters.ВиробникиTableAdapter виробникиTableAdapter;
        private System.Windows.Forms.BindingSource упаковкиBindingSource;
        private DrugstoreDataSetTableAdapters.УпаковкиTableAdapter упаковкиTableAdapter;
    }
}