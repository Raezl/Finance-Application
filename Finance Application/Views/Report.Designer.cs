namespace Finance_Application.Views
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxReportType = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewDataSet = new Finance_Application.ReportViewDataSet();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new Finance_Application.ReportViewDataSetTableAdapters.TransactionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportViewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Report Type";
            // 
            // cboxReportType
            // 
            this.cboxReportType.AutoCompleteCustomSource.AddRange(new string[] {
            "All",
            "Income",
            "Expense"});
            this.cboxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxReportType.FormattingEnabled = true;
            this.cboxReportType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cboxReportType.Location = new System.Drawing.Point(94, 18);
            this.cboxReportType.Name = "cboxReportType";
            this.cboxReportType.Size = new System.Drawing.Size(121, 21);
            this.cboxReportType.TabIndex = 5;
            this.cboxReportType.SelectedValueChanged += new System.EventHandler(this.cboxReportType_SelectedValueChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.transactionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Finance_Application.TransactionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(617, 352);
            this.reportViewer1.TabIndex = 6;
            // 
            // reportViewDataSet
            // 
            this.reportViewDataSet.DataSetName = "ReportViewDataSet";
            this.reportViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.reportViewDataSet;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 421);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cboxReportType);
            this.Controls.Add(this.label3);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportViewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxReportType;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportViewDataSet reportViewDataSet;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private ReportViewDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
    }
}