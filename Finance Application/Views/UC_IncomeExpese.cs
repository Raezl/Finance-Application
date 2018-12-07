using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Application.Views
{
    public partial class UC_IncomeExpese : UserControl
    {
        public UC_IncomeExpese()
        {
            InitializeComponent();
        }

        public String Category { get { return txtCategory.Text; } set { txtCategory.Text = value; } }
        public Double Amount { get { return Convert.ToDouble(txtAmount.Text); } set { txtAmount.Text = value.ToString(); } }
        public String Description { get { return rtxtDescription.Text; } set { rtxtDescription.Text = value; } }
        public bool Recuring { get { return radioYes.Checked ? true : false; } set { if (value) { radioYes.Checked = true; radioNo.Checked = false; } else { radioYes.Checked = false; radioNo.Checked = true; } } } 
        public String Date { get {return dtpTransactionDate.Value.ToString("yyyy-MM-dd"); } set { DateTime.Parse(value); } }
        public String TransactionType { get {return cboxType.Text; } set { cboxType.SelectedText = value; } }
        public String PayerPayee { get; set; }
    }
}
