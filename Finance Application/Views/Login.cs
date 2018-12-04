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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (new UserDetails().LoginAuthentication(txtEmail.Text, txtPassword.Text))
            {
                new Dashboard().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invaid");
            }
        }
    }
}
