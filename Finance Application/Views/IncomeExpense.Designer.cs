namespace Finance_Application.Views
{
    partial class IncomeExpense
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numudEntries = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.threadAddTransaction = new System.ComponentModel.BackgroundWorker();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Location = new System.Drawing.Point(12, 33);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(447, 417);
            this.tabs.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(439, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entry 01";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxPayerPayee);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboxType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTransactionDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioYes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rtxtDescription);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numudAmount);
            this.groupBox1.Controls.Add(this.txtCategory);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 377);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Details";
            // 
            // cboxPayerPayee
            // 
            this.cboxPayerPayee.FormattingEnabled = true;
            this.cboxPayerPayee.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cboxPayerPayee.Location = new System.Drawing.Point(127, 341);
            this.cboxPayerPayee.Name = "cboxPayerPayee";
            this.cboxPayerPayee.Size = new System.Drawing.Size(153, 21);
            this.cboxPayerPayee.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Payer/Payee";
            // 
            // cboxType
            // 
            this.cboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cboxType.Location = new System.Drawing.Point(127, 299);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(121, 21);
            this.cboxType.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Transaction Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Location = new System.Drawing.Point(127, 259);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTransactionDate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Checked = true;
            this.radioNo.Location = new System.Drawing.Point(207, 215);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(39, 17);
            this.radioNo.TabIndex = 11;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 217);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recurring";
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Location = new System.Drawing.Point(127, 217);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(43, 17);
            this.radioYes.TabIndex = 10;
            this.radioYes.Text = "Yes";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 72);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(127, 106);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(204, 80);
            this.rtxtDescription.TabIndex = 9;
            this.rtxtDescription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // numudAmount
            // 
            this.numudAmount.Location = new System.Drawing.Point(127, 70);
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
            this.numudAmount.TabIndex = 8;
            this.numudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(127, 35);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 20);
            this.txtCategory.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(299, 456);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(380, 456);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numudEntries
            // 
            this.numudEntries.Location = new System.Drawing.Point(131, 7);
            this.numudEntries.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numudEntries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numudEntries.Name = "numudEntries";
            this.numudEntries.Size = new System.Drawing.Size(81, 20);
            this.numudEntries.TabIndex = 18;
            this.numudEntries.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Number of entries";
            // 
            // threadAddTransaction
            // 
            this.threadAddTransaction.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadAddTransaction_DoWork);
            // 
            // IncomeExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 483);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numudEntries);
            this.Controls.Add(this.label1);
            this.Name = "IncomeExpense";
            this.Text = "IncomeExpense";
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numudEntries;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker threadAddTransaction;
    }
}