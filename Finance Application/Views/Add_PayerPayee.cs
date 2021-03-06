﻿using System;
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
    public partial class Add_PayerPayee : Form
    {
        public Add_PayerPayee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address field cannot be empty");
            }
            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email field cannot be empty");
            }
            else if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name feild cannot be empty");
            }
            else
            {
                PayerPayee pp = new PayerPayee();
                pp.Name = txtName.Text;
                pp.Address = txtAddress.Text;
                pp.Email = txtEmail.Text;
                pp.DOB = dtpDOB.Value.ToString("yyyy-MM-dd");

                if (!ThreadAddPayerPayee.IsBusy)
                {
                    ThreadAddPayerPayee.RunWorkerAsync(argument: pp);
                }

            }   

        }

        private void ThreadAddPayerPayee_DoWork(object sender, DoWorkEventArgs e)
        {
            if (new PayerPayee().AddPayerPayee((PayerPayee)e.Argument))
            {
                new PayerPayee().WritePayerPayeeXML();
                MessageBox.Show("Payer/Payee Added Sucessfully");
            }
               
        }
        
    }
}
