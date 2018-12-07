namespace Finance_Application.Views
{
    partial class Add_IncomeExpense
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
            this.tabsIncomeExpense = new System.Windows.Forms.TabControl();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numudEntries = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.threadAddTransaction = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numudEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsIncomeExpense
            // 
            this.tabsIncomeExpense.Location = new System.Drawing.Point(12, 33);
            this.tabsIncomeExpense.Name = "tabsIncomeExpense";
            this.tabsIncomeExpense.SelectedIndex = 0;
            this.tabsIncomeExpense.Size = new System.Drawing.Size(447, 417);
            this.tabsIncomeExpense.TabIndex = 21;
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
            this.numudEntries.ValueChanged += new System.EventHandler(this.numudEntries_ValueChanged);
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
            this.threadAddTransaction.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ThreadAddTransaction_DoWork);
            // 
            // Add_IncomeExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 483);
            this.Controls.Add(this.tabsIncomeExpense);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numudEntries);
            this.Controls.Add(this.label1);
            this.Name = "Add_IncomeExpense";
            this.Text = "IncomeExpense";
            this.Load += new System.EventHandler(this.Add_IncomeExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numudEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsIncomeExpense;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numudEntries;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker threadAddTransaction;
    }
}