using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finance_Application;

namespace Finance_Application.Views
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserDetails usr = new UserDetails();
            usr.Name = txtName.Text;
            usr.Address = String.Format("{0},{1},{2}", txtStreet1.Text, txtStreet2.Text, txtCity.Text);
            usr.DOB = dtpDOB.Value.ToString("yyyy-MM-dd");
            usr.Email = txtEmail.Text;
            usr.Password = txtPassword.Text;
            usr.AddUser(usr);
        }
    }
}
