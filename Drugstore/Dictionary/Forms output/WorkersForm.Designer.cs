namespace Drugstore.Dictionary
{
    partial class WorkersForm
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.drugstoreDataSet = new Drugstore.DrugstoreDataSet();
            this.працівникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.працівникиTableAdapter = new Drugstore.DrugstoreDataSetTableAdapters.ПрацівникиTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ідентКодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прізвищеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.побатьковіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.робочеМісцеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНарDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПрийомуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.областьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.районDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.містоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поштІндексDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.посадаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логінDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.працівникиBindingSource)).BeginInit();
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
            this.кодDataGridViewTextBoxColumn,
            this.паспортDataGridViewTextBoxColumn,
            this.ідентКодDataGridViewTextBoxColumn,
            this.прізвищеDataGridViewTextBoxColumn,
            this.імяDataGridViewTextBoxColumn,
            this.побатьковіDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.робочеМісцеDataGridViewTextBoxColumn,
            this.датаНарDataGridViewTextBoxColumn,
            this.датаПрийомуDataGridViewTextBoxColumn,
            this.областьDataGridViewTextBoxColumn,
            this.районDataGridViewTextBoxColumn,
            this.містоDataGridViewTextBoxColumn,
            this.поштІндексDataGridViewTextBoxColumn,
            this.адресаDataGridViewTextBoxColumn,
            this.посадаDataGridViewTextBoxColumn,
            this.логінDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.працівникиBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 497);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::Drugstore.Properties.Resources.edit_add_6635;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(66, 22);
            this.tsbAdd.Text = "Додати";
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
            // працівникиBindingSource
            // 
            this.працівникиBindingSource.DataMember = "Працівники";
            this.працівникиBindingSource.DataSource = this.drugstoreDataSet;
            // 
            // працівникиTableAdapter
            // 
            this.працівникиTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // паспортDataGridViewTextBoxColumn
            // 
            this.паспортDataGridViewTextBoxColumn.DataPropertyName = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.Name = "паспортDataGridViewTextBoxColumn";
            this.паспортDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ідентКодDataGridViewTextBoxColumn
            // 
            this.ідентКодDataGridViewTextBoxColumn.DataPropertyName = "ІдентКод";
            this.ідентКодDataGridViewTextBoxColumn.HeaderText = "ІдентКод";
            this.ідентКодDataGridViewTextBoxColumn.Name = "ідентКодDataGridViewTextBoxColumn";
            this.ідентКодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // прізвищеDataGridViewTextBoxColumn
            // 
            this.прізвищеDataGridViewTextBoxColumn.DataPropertyName = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn.Name = "прізвищеDataGridViewTextBoxColumn";
            this.прізвищеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // імяDataGridViewTextBoxColumn
            // 
            this.імяDataGridViewTextBoxColumn.DataPropertyName = "Імя";
            this.імяDataGridViewTextBoxColumn.HeaderText = "Імя";
            this.імяDataGridViewTextBoxColumn.Name = "імяDataGridViewTextBoxColumn";
            this.імяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // побатьковіDataGridViewTextBoxColumn
            // 
            this.побатьковіDataGridViewTextBoxColumn.DataPropertyName = "Побатькові";
            this.побатьковіDataGridViewTextBoxColumn.HeaderText = "Побатькові";
            this.побатьковіDataGridViewTextBoxColumn.Name = "побатьковіDataGridViewTextBoxColumn";
            this.побатьковіDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // робочеМісцеDataGridViewTextBoxColumn
            // 
            this.робочеМісцеDataGridViewTextBoxColumn.DataPropertyName = "РобочеМісце";
            this.робочеМісцеDataGridViewTextBoxColumn.HeaderText = "РобочеМісце";
            this.робочеМісцеDataGridViewTextBoxColumn.Name = "робочеМісцеDataGridViewTextBoxColumn";
            this.робочеМісцеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаНарDataGridViewTextBoxColumn
            // 
            this.датаНарDataGridViewTextBoxColumn.DataPropertyName = "ДатаНар";
            this.датаНарDataGridViewTextBoxColumn.HeaderText = "ДатаНар";
            this.датаНарDataGridViewTextBoxColumn.Name = "датаНарDataGridViewTextBoxColumn";
            this.датаНарDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаПрийомуDataGridViewTextBoxColumn
            // 
            this.датаПрийомуDataGridViewTextBoxColumn.DataPropertyName = "ДатаПрийому";
            this.датаПрийомуDataGridViewTextBoxColumn.HeaderText = "ДатаПрийому";
            this.датаПрийомуDataGridViewTextBoxColumn.Name = "датаПрийомуDataGridViewTextBoxColumn";
            this.датаПрийомуDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // областьDataGridViewTextBoxColumn
            // 
            this.областьDataGridViewTextBoxColumn.DataPropertyName = "Область";
            this.областьDataGridViewTextBoxColumn.HeaderText = "Область";
            this.областьDataGridViewTextBoxColumn.Name = "областьDataGridViewTextBoxColumn";
            this.областьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // районDataGridViewTextBoxColumn
            // 
            this.районDataGridViewTextBoxColumn.DataPropertyName = "Район";
            this.районDataGridViewTextBoxColumn.HeaderText = "Район";
            this.районDataGridViewTextBoxColumn.Name = "районDataGridViewTextBoxColumn";
            this.районDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // містоDataGridViewTextBoxColumn
            // 
            this.містоDataGridViewTextBoxColumn.DataPropertyName = "Місто";
            this.містоDataGridViewTextBoxColumn.HeaderText = "Місто";
            this.містоDataGridViewTextBoxColumn.Name = "містоDataGridViewTextBoxColumn";
            this.містоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // поштІндексDataGridViewTextBoxColumn
            // 
            this.поштІндексDataGridViewTextBoxColumn.DataPropertyName = "ПоштІндекс";
            this.поштІндексDataGridViewTextBoxColumn.HeaderText = "ПоштІндекс";
            this.поштІндексDataGridViewTextBoxColumn.Name = "поштІндексDataGridViewTextBoxColumn";
            this.поштІндексDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресаDataGridViewTextBoxColumn
            // 
            this.адресаDataGridViewTextBoxColumn.DataPropertyName = "Адреса";
            this.адресаDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.адресаDataGridViewTextBoxColumn.Name = "адресаDataGridViewTextBoxColumn";
            this.адресаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // посадаDataGridViewTextBoxColumn
            // 
            this.посадаDataGridViewTextBoxColumn.DataPropertyName = "Посада";
            this.посадаDataGridViewTextBoxColumn.HeaderText = "Посада";
            this.посадаDataGridViewTextBoxColumn.Name = "посадаDataGridViewTextBoxColumn";
            this.посадаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // логінDataGridViewTextBoxColumn
            // 
            this.логінDataGridViewTextBoxColumn.DataPropertyName = "Логін";
            this.логінDataGridViewTextBoxColumn.HeaderText = "Логін";
            this.логінDataGridViewTextBoxColumn.Name = "логінDataGridViewTextBoxColumn";
            this.логінDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "WorkersForm";
            this.Size = new System.Drawing.Size(1028, 522);
            this.Load += new System.EventHandler(this.WorkersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.працівникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ідентКодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn побатьковіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn робочеМісцеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНарDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПрийомуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn областьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn районDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn містоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поштІндексDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn посадаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логінDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource працівникиBindingSource;
        private DrugstoreDataSet drugstoreDataSet;
        private DrugstoreDataSetTableAdapters.ПрацівникиTableAdapter працівникиTableAdapter;


    }
}
