using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Application.Views
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportViewDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.reportViewDataSet.Transactions);
            
            this.reportViewer1.RefreshReport();
        }

        private void cboxReportType_SelectedValueChanged(object sender, EventArgs e)
        {
            this.transactionsTableAdapter.FillBy(this.reportViewDataSet.Transactions, cboxReportType.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
