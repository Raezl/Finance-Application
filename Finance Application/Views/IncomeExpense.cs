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
    public partial class IncomeExpense : Form
    {
        public IncomeExpense()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is RichTextBox)
                        (control as RichTextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Transaction record = new Transaction();
            record.Category = txtCategory.Text;
            record.Date = dtpTransactionDate.Value.ToString("yyyy-MM-dd");
            record.Description = rtxtDescription.Text;
            record.Recuring = radioNo.Checked ? false : true;
            record.TransactionType = cboxType.SelectedText;
            record.UserDetailsUserId = 1;
            record.PayerPayeePPId = 1;
            if (threadAddTransaction.IsBusy != true)
                threadAddTransaction.RunWorkerAsync(argument: record);
        }

         

        private void threadAddTransaction_DoWork(object sender, DoWorkEventArgs e)
        {
            if (new Transaction().AddTransaction((Transaction)e.Argument))
                MessageBox.Show("Record added successfully");
        }
        private void threadAddTransaction_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e)
        {
            ClearTextBoxes();
        }

    }
}
