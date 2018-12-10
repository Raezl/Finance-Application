using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Application.Views
{
    public partial class Edit_Transaction : Form
    {
        private int transactionId;
        public Edit_Transaction(int id)
        {
            transactionId = id;
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Transaction modified = new Transaction();
            modified.Category = txtCategory.Text;
            modified.Date = dtpTransactionDate.Value.ToString("yyyy-MM-dd");
            modified.Description = rtxtDescription.Text;
            modified.Recuring = radioYes.Checked ? true : false;
            modified.TransactionType = cboxType.Text;
            modified.TransactionId = transactionId;
            modified.PayerPayeePPId = ((KeyValuePair<int, string>)cboxPayerPayee.SelectedItem).Key;
            if (modified.UpdateTransaction(modified))
            {
                MessageBox.Show("Transaction modified");
                modified.WriteTransactionXML(modified.Date);
            }
           
        }

       
        private void Edit_Transaction_Load(object sender, EventArgs e)
        {
            Transaction rec = new Transaction().GetTransaction(transactionId);
            txtCategory.Text = rec.Category;
            dtpTransactionDate.Value = DateTime.Parse(rec.Date);
            rtxtDescription.Text = rec.Description;

            List<String> lst = new PayerPayee().ReadPayerPayeeXML();
            Dictionary<int, string> item = new Dictionary<int, string>();
            for (int i = 0; i < lst.Count; i += 6)
            {
                item.Add(Convert.ToInt32(lst[i]), lst[i + 1]);
            }
            cboxPayerPayee.DataSource = new BindingSource(item, null);
            cboxPayerPayee.DisplayMember = "Value";
            cboxPayerPayee.ValueMember = "Key";
        }
    }
}
