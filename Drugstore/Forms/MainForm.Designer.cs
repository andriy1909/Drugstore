namespace Drugstore
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.роботаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фінансиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslText = new System.Windows.Forms.ToolStripLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContext = new System.Windows.Forms.Panel();
            this.tsbPrev = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsddAllWindows = new System.Windows.Forms.ToolStripDropDownButton();
            this.робочеМісцеКасираToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.накладніПриходуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відпускТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.касаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.введенняЗалишківПоКасіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списанняТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.введенняЗалишківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ревізіяТоварівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товариToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постачальникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.виробникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кодиПостачальниківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упаковкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.роботаToolStripMenuItem,
            this.фінансиToolStripMenuItem,
            this.складToolStripMenuItem,
            this.довідникиToolStripMenuItem,
            this.налаштуванняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // роботаToolStripMenuItem
            // 
            this.роботаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.робочеМісцеКасираToolStripMenuItem,
            this.прайслистиToolStripMenuItem,
            this.накладніПриходуToolStripMenuItem,
            this.відпускТовараToolStripMenuItem});
            this.роботаToolStripMenuItem.Name = "роботаToolStripMenuItem";
            this.роботаToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.роботаToolStripMenuItem.Text = "Робота";
            this.роботаToolStripMenuItem.Click += new System.EventHandler(this.роботаToolStripMenuItem_Click);
            // 
            // фінансиToolStripMenuItem
            // 
            this.фінансиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.касаToolStripMenuItem,
            this.введенняЗалишківПоКасіToolStripMenuItem});
            this.фінансиToolStripMenuItem.Name = "фінансиToolStripMenuItem";
            this.фінансиToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.фінансиToolStripMenuItem.Text = "Фінанси";
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списанняТовараToolStripMenuItem,
            this.введенняЗалишківToolStripMenuItem,
            this.ревізіяТоварівToolStripMenuItem});
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.складToolStripMenuItem.Text = "Склад";
            // 
            // довідникиToolStripMenuItem
            // 
            this.довідникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товариToolStripMenuItem,
            this.постачальникиToolStripMenuItem,
            this.виробникиToolStripMenuItem,
            this.кодиПостачальниківToolStripMenuItem,
            this.упаковкиToolStripMenuItem});
            this.довідникиToolStripMenuItem.Name = "довідникиToolStripMenuItem";
            this.довідникиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.довідникиToolStripMenuItem.Text = "Довідники";
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            this.налаштуванняToolStripMenuItem.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(851, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 16);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrev,
            this.tsbNext,
            this.tsbClose,
            this.tsddAllWindows,
            this.toolStripSeparator1,
            this.tslText});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(851, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslText
            // 
            this.tslText.BackColor = System.Drawing.Color.Transparent;
            this.tslText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tslText.Name = "tslText";
            this.tslText.Size = new System.Drawing.Size(0, 22);
            this.tslText.ToolTipText = "   ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 76);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.loginToolStripMenuItem.Text = "Увійти";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.logoutToolStripMenuItem.Text = "Змінити користувача";
            this.logoutToolStripMenuItem.Visible = false;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.settingToolStripMenuItem.Text = "Налаштування";
            // 
            // pnContext
            // 
            this.pnContext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnContext.ContextMenuStrip = this.contextMenuStrip1;
            this.pnContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContext.Location = new System.Drawing.Point(0, 49);
            this.pnContext.Name = "pnContext";
            this.pnContext.Size = new System.Drawing.Size(851, 385);
            this.pnContext.TabIndex = 3;
            // 
            // tsbPrev
            // 
            this.tsbPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrev.Image = global::Drugstore.Properties.Resources.prev;
            this.tsbPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrev.Name = "tsbPrev";
            this.tsbPrev.Size = new System.Drawing.Size(23, 22);
            this.tsbPrev.Text = "Назад";
            this.tsbPrev.Click += new System.EventHandler(this.tsbPrev_Click);
            // 
            // tsbNext
            // 
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNext.Image = global::Drugstore.Properties.Resources.next;
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(23, 22);
            this.tsbNext.Text = "Далі";
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = global::Drugstore.Properties.Resources.close;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(23, 22);
            this.tsbClose.Text = "Закрити";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tsddAllWindows
            // 
            this.tsddAllWindows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddAllWindows.Image = ((System.Drawing.Image)(resources.GetObject("tsddAllWindows.Image")));
            this.tsddAllWindows.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddAllWindows.Name = "tsddAllWindows";
            this.tsddAllWindows.Size = new System.Drawing.Size(67, 22);
            this.tsddAllWindows.Text = "Всі вікна";
            // 
            // робочеМісцеКасираToolStripMenuItem
            // 
            this.робочеМісцеКасираToolStripMenuItem.Image = global::Drugstore.Properties.Resources.SlotMachine_16px;
            this.робочеМісцеКасираToolStripMenuItem.Name = "робочеМісцеКасираToolStripMenuItem";
            this.робочеМісцеКасираToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.робочеМісцеКасираToolStripMenuItem.Text = "Робоче місце касира";
            this.робочеМісцеКасираToolStripMenuItem.Click += new System.EventHandler(this.робочеМісцеКасираToolStripMenuItem_Click);
            // 
            // прайслистиToolStripMenuItem
            // 
            this.прайслистиToolStripMenuItem.Image = global::Drugstore.Properties.Resources.PurchaseOrder_16px;
            this.прайслистиToolStripMenuItem.Name = "прайслистиToolStripMenuItem";
            this.прайслистиToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.прайслистиToolStripMenuItem.Text = "Прайслисти";
            // 
            // накладніПриходуToolStripMenuItem
            // 
            this.накладніПриходуToolStripMenuItem.Image = global::Drugstore.Properties.Resources.Sell_16px;
            this.накладніПриходуToolStripMenuItem.Name = "накладніПриходуToolStripMenuItem";
            this.накладніПриходуToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.накладніПриходуToolStripMenuItem.Text = "Накладні приходу";
            this.накладніПриходуToolStripMenuItem.Click += new System.EventHandler(this.накладніПриходуToolStripMenuItem_Click);
            // 
            // відпускТовараToolStripMenuItem
            // 
            this.відпускТовараToolStripMenuItem.Image = global::Drugstore.Properties.Resources.ShoppingCartLoaded_16px;
            this.відпускТовараToolStripMenuItem.Name = "відпускТовараToolStripMenuItem";
            this.відпускТовараToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.відпускТовараToolStripMenuItem.Text = "Відпуск товара";
            this.відпускТовараToolStripMenuItem.Click += new System.EventHandler(this.відпускТовараToolStripMenuItem_Click);
            // 
            // касаToolStripMenuItem
            // 
            this.касаToolStripMenuItem.Image = global::Drugstore.Properties.Resources.Coins_16px;
            this.касаToolStripMenuItem.Name = "касаToolStripMenuItem";
            this.касаToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.касаToolStripMenuItem.Text = "Каса";
            // 
            // введенняЗалишківПоКасіToolStripMenuItem
            // 
            this.введенняЗалишківПоКасіToolStripMenuItem.Image = global::Drugstore.Properties.Resources.Expensive_2_16px;
            this.введенняЗалишківПоКасіToolStripMenuItem.Name = "введенняЗалишківПоКасіToolStripMenuItem";
            this.введенняЗалишківПоКасіToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.введенняЗалишківПоКасіToolStripMenuItem.Text = "Введення залишків по касі";
            // 
            // списанняТовараToolStripMenuItem
            // 
            this.списанняТовараToolStripMenuItem.Image = global::Drugstore.Properties.Resources.Trash_16px;
            this.списанняТовараToolStripMenuItem.Name = "списанняТовараToolStripMenuItem";
            this.списанняТовараToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.списанняТовараToolStripMenuItem.Text = "Списання товара";
            this.списанняТовараToolStripMenuItem.Click += new System.EventHandler(this.списанняТовараToolStripMenuItem_Click);
            // 
            // введенняЗалишківToolStripMenuItem
            // 
            this.введенняЗалишківToolStripMenuItem.Image = global::Drugstore.Properties.Resources.Inspection_16px;
            this.введенняЗалишківToolStripMenuItem.Name = "введенняЗалишківToolStripMenuItem";
            this.введенняЗалишківToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.введенняЗалишківToolStripMenuItem.Text = "Введення залишків";
            this.введенняЗалишківToolStripMenuItem.Click += new System.EventHandler(this.введенняЗалишківToolStripMenuItem_Click);
            // 
            // ревізіяТоварівToolStripMenuItem
            // 
            this.ревізіяТоварівToolStripMenuItem.Image = global::Drugstore.Properties.Resources.Fine_Print_16px;
            this.ревізіяТоварівToolStripMenuItem.Name = "ревізіяТоварівToolStripMenuItem";
            this.ревізіяТоварівToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ревізіяТоварівToolStripMenuItem.Text = "Ревізія товарів";
            this.ревізіяТоварівToolStripMenuItem.Click += new System.EventHandler(this.ревізіяТоварівToolStripMenuItem_Click);
            // 
            // товариToolStripMenuItem
            // 
            this.товариToolStripMenuItem.Image = global::Drugstore.Properties.Resources.Box_16px;
            this.товариToolStripMenuItem.Name = "товариToolStripMenuItem";
            this.товариToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.товариToolStripMenuItem.Text = "Товари";
            this.товариToolStripMenuItem.Click += new System.EventHandler(this.товариToolStripMenuItem_Click);
            // 
            // постачальникиToolStripMenuItem
            // 
            this.постачальникиToolStripMenuItem.Image = global::Drugstore.Properties.Resources.Truck_16px;
            this.постачальникиToolStripMenuItem.Name = "постачальникиToolStripMenuItem";
            this.постачальникиToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.постачальникиToolStripMenuItem.Text = "Постачальники";
            this.постачальникиToolStripMenuItem.Click += new System.EventHandler(this.постачальникиToolStripMenuItem_Click);
            // 
            // виробникиToolStripMenuItem
            // 
            this.виробникиToolStripMenuItem.Image = global::Drugstore.Properties.Resources.Deployment_16px;
            this.виробникиToolStripMenuItem.Name = "виробникиToolStripMenuItem";
            this.виробникиToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.виробникиToolStripMenuItem.Text = "Виробники";
            this.виробникиToolStripMenuItem.Click += new System.EventHandler(this.виробникиToolStripMenuItem_Click);
            // 
            // кодиПостачальниківToolStripMenuItem
            // 
            this.кодиПостачальниківToolStripMenuItem.Image = global::Drugstore.Properties.Resources.Refresh_Barcode_16px;
            this.кодиПостачальниківToolStripMenuItem.Name = "кодиПостачальниківToolStripMenuItem";
            this.кодиПостачальниківToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.кодиПостачальниківToolStripMenuItem.Text = "Коди постачальників";
            this.кодиПостачальниківToolStripMenuItem.Click += new System.EventHandler(this.кодиПостачальниківToolStripMenuItem_Click);
            // 
            // упаковкиToolStripMenuItem
            // 
            this.упаковкиToolStripMenuItem.Image = global::Drugstore.Properties.Resources.package;
            this.упаковкиToolStripMenuItem.Name = "упаковкиToolStripMenuItem";
            this.упаковкиToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.упаковкиToolStripMenuItem.Text = "Упаковки";
            this.упаковкиToolStripMenuItem.Click += new System.EventHandler(this.упаковкиToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(851, 456);
            this.Controls.Add(this.pnContext);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Аптека";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPrev;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.Panel pnContext;
        private System.Windows.Forms.ToolStripMenuItem роботаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem робочеМісцеКасираToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фінансиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem касаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem введенняЗалишківПоКасіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списанняТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem введенняЗалишківToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ревізіяТоварівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товариToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постачальникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem виробникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кодиПостачальниківToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsddAllWindows;
        private System.Windows.Forms.ToolStripMenuItem накладніПриходуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відпускТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упаковкиToolStripMenuItem;
    }
}

