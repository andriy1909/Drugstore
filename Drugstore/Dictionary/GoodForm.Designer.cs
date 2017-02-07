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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbAnalog = new System.Windows.Forms.ComboBox();
            this.fKТовариВиробникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.виробникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugstoreDataSet = new Drugstore.DrugstoreDataSet();
            this.упаковкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProducer = new System.Windows.Forms.ComboBox();
            this.tbBarCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbOdVum = new System.Windows.Forms.TextBox();
            this.tbPos = new System.Windows.Forms.TextBox();
            this.tbArtikyl = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbKodMoriona = new System.Windows.Forms.TextBox();
            this.tbMinZapas = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbReturn = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbSatvkaNDS = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbInPriceNoNDS = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbInPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbInform = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.виробникиTableAdapter = new Drugstore.DrugstoreDataSetTableAdapters.ВиробникиTableAdapter();
            this.упаковкиTableAdapter = new Drugstore.DrugstoreDataSetTableAdapters.УпаковкиTableAdapter();
            this.товариTableAdapter = new Drugstore.DrugstoreDataSetTableAdapters.ТовариTableAdapter();
            this.cbPack = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKТовариВиробникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.виробникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.упаковкиBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 244);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Drugstore.Properties.Resources.fototapeta_brak_zdjecia;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.tabControl1.Size = new System.Drawing.Size(429, 244);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.cbAnalog);
            this.tabPage1.Controls.Add(this.cbPack);
            this.tabPage1.Controls.Add(this.cbProducer);
            this.tabPage1.Controls.Add(this.tbBarCode);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.tbOdVum);
            this.tabPage1.Controls.Add(this.tbPos);
            this.tabPage1.Controls.Add(this.tbArtikyl);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.tbKodMoriona);
            this.tabPage1.Controls.Add(this.tbMinZapas);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.cbReturn);
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
            this.tabPage1.Size = new System.Drawing.Size(421, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основне";
            // 
            // cbAnalog
            // 
            this.cbAnalog.DataSource = this.fKТовариВиробникиBindingSource;
            this.cbAnalog.DisplayMember = "Назва";
            this.cbAnalog.FormattingEnabled = true;
            this.cbAnalog.Location = new System.Drawing.Point(297, 164);
            this.cbAnalog.Name = "cbAnalog";
            this.cbAnalog.Size = new System.Drawing.Size(112, 21);
            this.cbAnalog.TabIndex = 16;
            this.cbAnalog.ValueMember = "Код";
            // 
            // fKТовариВиробникиBindingSource
            // 
            this.fKТовариВиробникиBindingSource.DataMember = "FK_Товари_Виробники";
            this.fKТовариВиробникиBindingSource.DataSource = this.виробникиBindingSource;
            // 
            // виробникиBindingSource
            // 
            this.виробникиBindingSource.DataMember = "Виробники";
            this.виробникиBindingSource.DataSource = this.drugstoreDataSet;
            // 
            // drugstoreDataSet
            // 
            this.drugstoreDataSet.DataSetName = "DrugstoreDataSet";
            this.drugstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // упаковкиBindingSource
            // 
            this.упаковкиBindingSource.DataMember = "Упаковки";
            this.упаковкиBindingSource.DataSource = this.drugstoreDataSet;
            // 
            // cbProducer
            // 
            this.cbProducer.DataSource = this.виробникиBindingSource;
            this.cbProducer.DisplayMember = "Назва";
            this.cbProducer.FormattingEnabled = true;
            this.cbProducer.Location = new System.Drawing.Point(297, 63);
            this.cbProducer.Name = "cbProducer";
            this.cbProducer.Size = new System.Drawing.Size(112, 21);
            this.cbProducer.TabIndex = 15;
            this.cbProducer.ValueMember = "Код";
            // 
            // tbBarCode
            // 
            this.tbBarCode.Location = new System.Drawing.Point(99, 112);
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.Size = new System.Drawing.Size(112, 20);
            this.tbBarCode.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Штрихкод";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Упаковка";
            // 
            // tbOdVum
            // 
            this.tbOdVum.Location = new System.Drawing.Point(99, 37);
            this.tbOdVum.Name = "tbOdVum";
            this.tbOdVum.Size = new System.Drawing.Size(112, 20);
            this.tbOdVum.TabIndex = 2;
            // 
            // tbPos
            // 
            this.tbPos.Location = new System.Drawing.Point(297, 112);
            this.tbPos.Name = "tbPos";
            this.tbPos.Size = new System.Drawing.Size(112, 20);
            this.tbPos.TabIndex = 5;
            // 
            // tbArtikyl
            // 
            this.tbArtikyl.Location = new System.Drawing.Point(297, 37);
            this.tbArtikyl.Name = "tbArtikyl";
            this.tbArtikyl.Size = new System.Drawing.Size(112, 20);
            this.tbArtikyl.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(99, 11);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(310, 20);
            this.tbName.TabIndex = 2;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbKodMoriona
            // 
            this.tbKodMoriona.Location = new System.Drawing.Point(99, 63);
            this.tbKodMoriona.Name = "tbKodMoriona";
            this.tbKodMoriona.Size = new System.Drawing.Size(112, 20);
            this.tbKodMoriona.TabIndex = 2;
            // 
            // tbMinZapas
            // 
            this.tbMinZapas.Location = new System.Drawing.Point(297, 192);
            this.tbMinZapas.Name = "tbMinZapas";
            this.tbMinZapas.Size = new System.Drawing.Size(112, 20);
            this.tbMinZapas.TabIndex = 2;
            this.tbMinZapas.Text = "0";
            this.tbMinZapas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Count_KeyPress);
            this.tbMinZapas.Leave += new System.EventHandler(this.TextDigit);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(297, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "По рецепті";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbReturn
            // 
            this.cbReturn.AutoSize = true;
            this.cbReturn.Location = new System.Drawing.Point(26, 89);
            this.cbReturn.Name = "cbReturn";
            this.cbReturn.Size = new System.Drawing.Size(149, 17);
            this.cbReturn.TabIndex = 7;
            this.cbReturn.Text = "Можливість повернення";
            this.cbReturn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Одиниці виміру";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(244, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Позиція";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Аналог для препарата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Код Моріона";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Бажаний мінімальний запас";
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
            this.tabPage2.Size = new System.Drawing.Size(421, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ціни";
            // 
            // tbSatvkaNDS
            // 
            this.tbSatvkaNDS.Location = new System.Drawing.Point(173, 120);
            this.tbSatvkaNDS.Name = "tbSatvkaNDS";
            this.tbSatvkaNDS.Size = new System.Drawing.Size(161, 20);
            this.tbSatvkaNDS.TabIndex = 7;
            this.tbSatvkaNDS.Text = "0";
            this.tbSatvkaNDS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            this.tbSatvkaNDS.Leave += new System.EventHandler(this.TextDigit);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "0";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.TextDigit);
            // 
            // tbInPriceNoNDS
            // 
            this.tbInPriceNoNDS.Location = new System.Drawing.Point(173, 68);
            this.tbInPriceNoNDS.Name = "tbInPriceNoNDS";
            this.tbInPriceNoNDS.Size = new System.Drawing.Size(161, 20);
            this.tbInPriceNoNDS.TabIndex = 11;
            this.tbInPriceNoNDS.Text = "0";
            this.tbInPriceNoNDS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            this.tbInPriceNoNDS.Leave += new System.EventHandler(this.TextDigit);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.TextDigit);
            // 
            // tbInPrice
            // 
            this.tbInPrice.Location = new System.Drawing.Point(173, 42);
            this.tbInPrice.Name = "tbInPrice";
            this.tbInPrice.Size = new System.Drawing.Size(161, 20);
            this.tbInPrice.TabIndex = 13;
            this.tbInPrice.Text = "0";
            this.tbInPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            this.tbInPrice.Leave += new System.EventHandler(this.TextDigit);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ставка НДС";
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(113, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Відп. ціна";
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbInform);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(421, 218);
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
            this.tbInform.Size = new System.Drawing.Size(415, 212);
            this.tbInform.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Вибрати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btOk);
            this.panel2.Controls.Add(this.btCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 241);
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
            // виробникиTableAdapter
            // 
            this.виробникиTableAdapter.ClearBeforeFill = true;
            // 
            // упаковкиTableAdapter
            // 
            this.упаковкиTableAdapter.ClearBeforeFill = true;
            // 
            // товариTableAdapter
            // 
            this.товариTableAdapter.ClearBeforeFill = true;
            // 
            // cbPack
            // 
            this.cbPack.DataSource = this.упаковкиBindingSource;
            this.cbPack.DisplayMember = "Назва";
            this.cbPack.FormattingEnabled = true;
            this.cbPack.Location = new System.Drawing.Point(99, 138);
            this.cbPack.Name = "cbPack";
            this.cbPack.Size = new System.Drawing.Size(112, 21);
            this.cbPack.TabIndex = 16;
            this.cbPack.ValueMember = "Код";
            // 
            // GoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 271);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKТовариВиробникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.виробникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.упаковкиBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tbOdVum;
        private System.Windows.Forms.TextBox tbPos;
        private System.Windows.Forms.TextBox tbArtikyl;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbKodMoriona;
        private System.Windows.Forms.TextBox tbMinZapas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cbReturn;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbInform;
        private System.Windows.Forms.ComboBox cbProducer;
        private DrugstoreDataSet drugstoreDataSet;
        private System.Windows.Forms.BindingSource виробникиBindingSource;
        private DrugstoreDataSetTableAdapters.ВиробникиTableAdapter виробникиTableAdapter;
        private System.Windows.Forms.BindingSource упаковкиBindingSource;
        private DrugstoreDataSetTableAdapters.УпаковкиTableAdapter упаковкиTableAdapter;
        private System.Windows.Forms.BindingSource fKТовариВиробникиBindingSource;
        private DrugstoreDataSetTableAdapters.ТовариTableAdapter товариTableAdapter;
        private System.Windows.Forms.ComboBox cbAnalog;
        private System.Windows.Forms.TextBox tbInPriceNoNDS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbInPrice;
        private System.Windows.Forms.ComboBox cbPack;
    }
}