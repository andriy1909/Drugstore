namespace Drugstore
{
    partial class CustomerForm
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
            this.btCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCard = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBirth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbReg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDiscounts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(277, 3);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(92, 27);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Скасувати";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btOk);
            this.panel2.Controls.Add(this.btCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 33);
            this.panel2.TabIndex = 17;
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOk.Location = new System.Drawing.Point(189, 3);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(82, 27);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "ОК";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Імя";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(95, 44);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 24);
            this.tbName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Побатькові";
            // 
            // tbSecondName
            // 
            this.tbSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSecondName.Location = new System.Drawing.Point(115, 74);
            this.tbSecondName.MaxLength = 50;
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(200, 24);
            this.tbSecondName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(21, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Телефон";
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumber.Location = new System.Drawing.Point(115, 104);
            this.tbNumber.MaxLength = 50;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(200, 24);
            this.tbNumber.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Картка";
            // 
            // tbCard
            // 
            this.tbCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCard.Location = new System.Drawing.Point(134, 134);
            this.tbCard.MaxLength = 50;
            this.tbCard.Name = "tbCard";
            this.tbCard.Size = new System.Drawing.Size(200, 24);
            this.tbCard.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(24, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Дата народження";
            // 
            // tbBirth
            // 
            this.tbBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBirth.Location = new System.Drawing.Point(162, 194);
            this.tbBirth.MaxLength = 50;
            this.tbBirth.Name = "tbBirth";
            this.tbBirth.Size = new System.Drawing.Size(200, 24);
            this.tbBirth.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(25, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Дата реєстрації";
            // 
            // tbReg
            // 
            this.tbReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReg.Location = new System.Drawing.Point(147, 224);
            this.tbReg.MaxLength = 50;
            this.tbReg.Name = "tbReg";
            this.tbReg.Size = new System.Drawing.Size(200, 24);
            this.tbReg.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(25, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Знижка";
            // 
            // tbDiscounts
            // 
            this.tbDiscounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDiscounts.Location = new System.Drawing.Point(134, 164);
            this.tbDiscounts.MaxLength = 50;
            this.tbDiscounts.Name = "tbDiscounts";
            this.tbDiscounts.Size = new System.Drawing.Size(200, 24);
            this.tbDiscounts.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Прізвище";
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(95, 14);
            this.tbSurname.MaxLength = 50;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(200, 24);
            this.tbSurname.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbSurname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbDiscounts);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbReg);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbBirth);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbCard);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbSecondName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 299);
            this.panel1.TabIndex = 18;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 299);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerForm";
            this.Text = "Покупець";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBirth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbReg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDiscounts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Panel panel1;
    }
}