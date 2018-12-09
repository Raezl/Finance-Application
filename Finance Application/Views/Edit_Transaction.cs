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
         
        public Edit_Transaction()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            
        }

       
        private void Edit_Transaction_Load(object sender, EventArgs e)
        {
            
            Transaction rec = new Transaction().GetTransaction(3);
            txtCategory.Text = rec.Category;
            dtpTransactionDate.Value = DateTime.Parse(rec.Date);
            rtxtDescription.Text = rec.Description;

            //cboxType.SelectedText;
            //record.PayerPayeePPId = 1;
        }
    }
}
