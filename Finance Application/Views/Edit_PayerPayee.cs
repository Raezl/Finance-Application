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
    
    public partial class Edit_PayerPayee : Form
    {
        int PPId;
        public Edit_PayerPayee(int id)
        {
            PPId = id;
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            PayerPayee rec = new PayerPayee();
            rec.PPId = PPId;
            rec.Address = txtAddress.Text;
            rec.Name = txtName.Text;
            rec.Email = txtEmail.Text;
            rec.DOB = dtpDOB.Value.ToString("yyyy-MM-dd");
            if (rec.UpdatePayerPayee(rec))
            {
                rec.WritePayerPayeeXML();
                MessageBox.Show("Payer/Payee record updated");
            }
        }

        private void Edit_PayerPayee_Load(object sender, EventArgs e)
        {
            PayerPayee obj = new PayerPayee();
            obj = obj.PPRecord(PPId);
            txtAddress.Text = obj.Address;
            txtName.Text = obj.Name;
            txtEmail.Text = obj.Email;
            dtpDOB.Value = DateTime.Parse(obj.DOB);

        }
    }
}
