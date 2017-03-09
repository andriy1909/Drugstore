namespace Drugstore.Dictionary
{
    partial class CustomersForm
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
            this.партнериBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugstoreDataSet = new Drugstore.DrugstoreDataSet();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.партнериTableAdapter = new Drugstore.DrugstoreDataSetTableAdapters.ПартнериTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прізвищеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.побатьковіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.карткаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.знижкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНарDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРеєстрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.партнериBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // партнериBindingSource
            // 
            this.партнериBindingSource.DataMember = "Партнери";
            // 
            // drugstoreDataSet
            // 
            this.drugstoreDataSet.DataSetName = "DrugstoreDataSet";
            this.drugstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tsbEdit
            // 
            this.tsbEdit.Image = global::Drugstore.Properties.Resources.edit_3262;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(87, 22);
            this.tsbEdit.Text = "Редагувати";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 14;
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
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::Drugstore.Properties.Resources.Refresh_16px;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(75, 22);
            this.tsbRefresh.Text = "Оновити";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // партнериTableAdapter
            // 
            this.партнериTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.прізвищеDataGridViewTextBoxColumn,
            this.імяDataGridViewTextBoxColumn,
            this.побатьковіDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.карткаDataGridViewTextBoxColumn,
            this.знижкаDataGridViewTextBoxColumn,
            this.датаНарDataGridViewTextBoxColumn,
            this.датаРеєстрDataGridViewTextBoxColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 503);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
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
            // карткаDataGridViewTextBoxColumn
            // 
            this.карткаDataGridViewTextBoxColumn.DataPropertyName = "Картка";
            this.карткаDataGridViewTextBoxColumn.HeaderText = "Картка";
            this.карткаDataGridViewTextBoxColumn.Name = "карткаDataGridViewTextBoxColumn";
            this.карткаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // знижкаDataGridViewTextBoxColumn
            // 
            this.знижкаDataGridViewTextBoxColumn.DataPropertyName = "Знижка";
            this.знижкаDataGridViewTextBoxColumn.HeaderText = "Знижка";
            this.знижкаDataGridViewTextBoxColumn.Name = "знижкаDataGridViewTextBoxColumn";
            this.знижкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаНарDataGridViewTextBoxColumn
            // 
            this.датаНарDataGridViewTextBoxColumn.DataPropertyName = "ДатаНар";
            this.датаНарDataGridViewTextBoxColumn.HeaderText = "ДатаНар";
            this.датаНарDataGridViewTextBoxColumn.Name = "датаНарDataGridViewTextBoxColumn";
            this.датаНарDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаРеєстрDataGridViewTextBoxColumn
            // 
            this.датаРеєстрDataGridViewTextBoxColumn.DataPropertyName = "ДатаРеєстр";
            this.датаРеєстрDataGridViewTextBoxColumn.HeaderText = "ДатаРеєстр";
            this.датаРеєстрDataGridViewTextBoxColumn.Name = "датаРеєстрDataGridViewTextBoxColumn";
            this.датаРеєстрDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CustomersForm";
            this.Size = new System.Drawing.Size(1008, 528);
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.партнериBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource партнериBindingSource;
        private DrugstoreDataSet drugstoreDataSet;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private DrugstoreDataSetTableAdapters.ПартнериTableAdapter партнериTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn побатьковіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn карткаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn знижкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНарDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРеєстрDataGridViewTextBoxColumn;


    }
}
