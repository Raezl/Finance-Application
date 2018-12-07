namespace Finance_Application.Views
{
    partial class Edit_Transaction
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
            this.cboxPayerPayee = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numudAmount = new System.Windows.Forms.NumericUpDown();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxPayerPayee
            // 
            this.cboxPayerPayee.FormattingEnabled = true;
            this.cboxPayerPayee.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cboxPayerPayee.Location = new System.Drawing.Point(134, 332);
            this.cboxPayerPayee.Name = "cboxPayerPayee";
            this.cboxPayerPayee.Size = new System.Drawing.Size(153, 21);
            this.cboxPayerPayee.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Payer/Payee";
            // 
            // cboxType
            // 
            this.cboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cboxType.Location = new System.Drawing.Point(134, 290);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(121, 21);
            this.cboxType.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Transaction Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Category";
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Location = new System.Drawing.Point(134, 250);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTransactionDate.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Description";
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Checked = true;
            this.radioNo.Location = new System.Drawing.Point(214, 206);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(39, 17);
            this.radioNo.TabIndex = 26;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 208);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Recurring";
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Location = new System.Drawing.Point(134, 208);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(43, 17);
            this.radioYes.TabIndex = 25;
            this.radioYes.Text = "Yes";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 63);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Amount";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(134, 97);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(204, 80);
            this.rtxtDescription.TabIndex = 24;
            this.rtxtDescription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Date";
            // 
            // numudAmount
            // 
            this.numudAmount.Location = new System.Drawing.Point(134, 61);
            this.numudAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numudAmount.Name = "numudAmount";
            this.numudAmount.Size = new System.Drawing.Size(81, 20);
            this.numudAmount.TabIndex = 23;
            this.numudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(134, 26);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 20);
            this.txtCategory.TabIndex = 22;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(263, 378);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 32;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // Edit_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 414);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.cboxPayerPayee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTransactionDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioYes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numudAmount);
            this.Controls.Add(this.txtCategory);
            this.Name = "Edit_Transaction";
            this.Text = "Edit_Transaction";
            this.Load += new System.EventHandler(this.Edit_Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxPayerPayee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numudAmount;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnModify;
    }
}