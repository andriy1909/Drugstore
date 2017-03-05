namespace Drugstore.Journals
{
    partial class JournalInvoiceInForm
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.drugstoreDataSet = new Drugstore.DrugstoreDataSet();
            this.накладнаПриходаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.накладнаПриходаTableAdapter = new Drugstore.DrugstoreDataSetTableAdapters.НакладнаПриходаTableAdapter();
            this.номерДокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаДокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.відповідальнийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.партнерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сумаДокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьТоварівDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заміткаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаПриходаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДокументаDataGridViewTextBoxColumn,
            this.датаДокументаDataGridViewTextBoxColumn,
            this.відповідальнийDataGridViewTextBoxColumn,
            this.партнерDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.сумаДокументаDataGridViewTextBoxColumn,
            this.кількістьТоварівDataGridViewTextBoxColumn,
            this.заміткаDataGridViewTextBoxColumn,
            this.оплатаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.накладнаПриходаBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(922, 494);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(922, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::Drugstore.Properties.Resources.edit_add_6635;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(66, 22);
            this.tsbAdd.Text = "Додати";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::Drugstore.Properties.Resources.edit_3262;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(87, 22);
            this.tsbEdit.Text = "Редагувати";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Drugstore.Properties.Resources.deletered_8548;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(79, 22);
            this.tsbDelete.Text = "Видалити";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // drugstoreDataSet
            // 
            this.drugstoreDataSet.DataSetName = "DrugstoreDataSet";
            this.drugstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // накладнаПриходаBindingSource
            // 
            this.накладнаПриходаBindingSource.DataMember = "НакладнаПрихода";
            this.накладнаПриходаBindingSource.DataSource = this.drugstoreDataSet;
            // 
            // накладнаПриходаTableAdapter
            // 
            this.накладнаПриходаTableAdapter.ClearBeforeFill = true;
            // 
            // номерДокументаDataGridViewTextBoxColumn
            // 
            this.номерДокументаDataGridViewTextBoxColumn.DataPropertyName = "НомерДокумента";
            this.номерДокументаDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерДокументаDataGridViewTextBoxColumn.Name = "номерДокументаDataGridViewTextBoxColumn";
            this.номерДокументаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаДокументаDataGridViewTextBoxColumn
            // 
            this.датаДокументаDataGridViewTextBoxColumn.DataPropertyName = "ДатаДокумента";
            this.датаДокументаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаДокументаDataGridViewTextBoxColumn.Name = "датаДокументаDataGridViewTextBoxColumn";
            // 
            // відповідальнийDataGridViewTextBoxColumn
            // 
            this.відповідальнийDataGridViewTextBoxColumn.DataPropertyName = "Відповідальний";
            this.відповідальнийDataGridViewTextBoxColumn.HeaderText = "Відповідальний";
            this.відповідальнийDataGridViewTextBoxColumn.Name = "відповідальнийDataGridViewTextBoxColumn";
            // 
            // партнерDataGridViewTextBoxColumn
            // 
            this.партнерDataGridViewTextBoxColumn.DataPropertyName = "Партнер";
            this.партнерDataGridViewTextBoxColumn.HeaderText = "Партнер";
            this.партнерDataGridViewTextBoxColumn.Name = "партнерDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.Visible = false;
            // 
            // сумаДокументаDataGridViewTextBoxColumn
            // 
            this.сумаДокументаDataGridViewTextBoxColumn.DataPropertyName = "СумаДокумента";
            this.сумаДокументаDataGridViewTextBoxColumn.HeaderText = "СумаДокумента";
            this.сумаДокументаDataGridViewTextBoxColumn.Name = "сумаДокументаDataGridViewTextBoxColumn";
            // 
            // кількістьТоварівDataGridViewTextBoxColumn
            // 
            this.кількістьТоварівDataGridViewTextBoxColumn.DataPropertyName = "КількістьТоварів";
            this.кількістьТоварівDataGridViewTextBoxColumn.HeaderText = "КількістьТоварів";
            this.кількістьТоварівDataGridViewTextBoxColumn.Name = "кількістьТоварівDataGridViewTextBoxColumn";
            // 
            // заміткаDataGridViewTextBoxColumn
            // 
            this.заміткаDataGridViewTextBoxColumn.DataPropertyName = "Замітка";
            this.заміткаDataGridViewTextBoxColumn.HeaderText = "Замітка";
            this.заміткаDataGridViewTextBoxColumn.Name = "заміткаDataGridViewTextBoxColumn";
            // 
            // оплатаDataGridViewTextBoxColumn
            // 
            this.оплатаDataGridViewTextBoxColumn.DataPropertyName = "Оплата";
            this.оплатаDataGridViewTextBoxColumn.HeaderText = "Оплата";
            this.оплатаDataGridViewTextBoxColumn.Name = "оплатаDataGridViewTextBoxColumn";
            this.оплатаDataGridViewTextBoxColumn.Visible = false;
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::Drugstore.Properties.Resources.Refresh_16px;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(75, 22);
            this.tsbRefresh.Text = "Оновити";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // JournalInvoiceInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "JournalInvoiceInForm";
            this.Size = new System.Drawing.Size(922, 519);
            this.Load += new System.EventHandler(this.JournalInvoiceInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаПриходаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаДокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn відповідальнийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn партнерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сумаДокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьТоварівDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заміткаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource накладнаПриходаBindingSource;
        private DrugstoreDataSet drugstoreDataSet;
        private DrugstoreDataSetTableAdapters.НакладнаПриходаTableAdapter накладнаПриходаTableAdapter;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
    }
}
