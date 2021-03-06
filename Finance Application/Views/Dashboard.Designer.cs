﻿namespace Finance_Application.Views
{
    partial class Dashboard
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
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.btnViewTransaction = new System.Windows.Forms.Button();
            this.btnAddPP = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewPP = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(54, 41);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(111, 23);
            this.btnAddTransaction.TabIndex = 0;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // btnViewTransaction
            // 
            this.btnViewTransaction.Location = new System.Drawing.Point(54, 70);
            this.btnViewTransaction.Name = "btnViewTransaction";
            this.btnViewTransaction.Size = new System.Drawing.Size(110, 23);
            this.btnViewTransaction.TabIndex = 1;
            this.btnViewTransaction.Text = "View Transaction";
            this.btnViewTransaction.UseVisualStyleBackColor = true;
            this.btnViewTransaction.Click += new System.EventHandler(this.btnViewTransaction_Click);
            // 
            // btnAddPP
            // 
            this.btnAddPP.Location = new System.Drawing.Point(53, 121);
            this.btnAddPP.Name = "btnAddPP";
            this.btnAddPP.Size = new System.Drawing.Size(111, 23);
            this.btnAddPP.TabIndex = 3;
            this.btnAddPP.Text = "Add Payer/Payee";
            this.btnAddPP.UseVisualStyleBackColor = true;
            this.btnAddPP.Click += new System.EventHandler(this.btnAddPP_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnViewPP
            // 
            this.btnViewPP.Location = new System.Drawing.Point(53, 150);
            this.btnViewPP.Name = "btnViewPP";
            this.btnViewPP.Size = new System.Drawing.Size(111, 23);
            this.btnViewPP.TabIndex = 5;
            this.btnViewPP.Text = "View Payer/Payee";
            this.btnViewPP.UseVisualStyleBackColor = true;
            this.btnViewPP.Click += new System.EventHandler(this.btnViewPP_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(241, 41);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "View Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Predict";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnViewPP);
            this.Controls.Add(this.btnAddPP);
            this.Controls.Add(this.btnViewTransaction);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnViewTransaction;
        private System.Windows.Forms.Button btnAddPP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btnViewPP;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button button1;
    }
}