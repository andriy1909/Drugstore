namespace Drugstore
{
    partial class CodeSupplierForm
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
            this.btOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.постачальникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugstoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugstoreDataSet = new Drugstore.DrugstoreDataSet();
            this.cbGoods = new System.Windows.Forms.ComboBox();
            this.товариBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGoodsCode = new System.Windows.Forms.TextBox();
            this.товариTableAdapter = new Drugstore.DrugstoreDataSetTableAdapters.ТовариTableAdapter();
            this.постачальникиTableAdapter = new Drugstore.DrugstoreDataSetTableAdapters.ПостачальникиTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товариBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOk.Location = new System.Drawing.Point(270, 3);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(82, 27);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "ОК";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btOk);
            this.panel2.Controls.Add(this.btCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 33);
            this.panel2.TabIndex = 14;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(358, 3);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(90, 27);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Скасувати";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbProvider);
            this.panel1.Controls.Add(this.cbGoods);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbGoodsCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 223);
            this.panel1.TabIndex = 15;
            // 
            // cbProvider
            // 
            this.cbProvider.DataSource = this.постачальникиBindingSource;
            this.cbProvider.DisplayMember = "Назва";
            this.cbProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(186, 136);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(183, 26);
            this.cbProvider.TabIndex = 7;
            this.cbProvider.ValueMember = "Код";
            // 
            // постачальникиBindingSource
            // 
            this.постачальникиBindingSource.DataMember = "Постачальники";
            this.постачальникиBindingSource.DataSource = this.drugstoreDataSetBindingSource;
            // 
            // drugstoreDataSetBindingSource
            // 
            this.drugstoreDataSetBindingSource.DataSource = this.drugstoreDataSet;
            this.drugstoreDataSetBindingSource.Position = 0;
            // 
            // drugstoreDataSet
            // 
            this.drugstoreDataSet.DataSetName = "DrugstoreDataSet";
            this.drugstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbGoods
            // 
            this.cbGoods.DataSource = this.товариBindingSource;
            this.cbGoods.DisplayMember = "Назва";
            this.cbGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGoods.FormattingEnabled = true;
            this.cbGoods.Location = new System.Drawing.Point(186, 92);
            this.cbGoods.Name = "cbGoods";
            this.cbGoods.Size = new System.Drawing.Size(183, 26);
            this.cbGoods.TabIndex = 6;
            this.cbGoods.ValueMember = "Код";
            // 
            // товариBindingSource
            // 
            this.товариBindingSource.DataMember = "Товари";
            this.товариBindingSource.DataSource = this.drugstoreDataSetBindingSource;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Постачальник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(82, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Код товару";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(119, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Товар";
            // 
            // tbGoodsCode
            // 
            this.tbGoodsCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGoodsCode.Location = new System.Drawing.Point(186, 51);
            this.tbGoodsCode.MaxLength = 8;
            this.tbGoodsCode.Name = "tbGoodsCode";
            this.tbGoodsCode.Size = new System.Drawing.Size(183, 24);
            this.tbGoodsCode.TabIndex = 1;
            // 
            // товариTableAdapter
            // 
            this.товариTableAdapter.ClearBeforeFill = true;
            // 
            // постачальникиTableAdapter
            // 
            this.постачальникиTableAdapter.ClearBeforeFill = true;
            // 
            // CodeSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 256);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CodeSupplierForm";
            this.Text = "Код постачальника";
            this.Load += new System.EventHandler(this.CodeSupplierForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товариBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGoodsCode;
        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.ComboBox cbGoods;
        private System.Windows.Forms.BindingSource drugstoreDataSetBindingSource;
        private DrugstoreDataSet drugstoreDataSet;
        private System.Windows.Forms.BindingSource товариBindingSource;
        private DrugstoreDataSetTableAdapters.ТовариTableAdapter товариTableAdapter;
        private System.Windows.Forms.BindingSource постачальникиBindingSource;
        private DrugstoreDataSetTableAdapters.ПостачальникиTableAdapter постачальникиTableAdapter;
    }
}