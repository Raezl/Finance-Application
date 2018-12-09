using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Finance_Application.Views
{
    public partial class UC_IncomeExpese : UserControl
    {

        public UC_IncomeExpese()
        {
            InitializeComponent();
        }

        public String validation{get; set;}

        public String Category {
            get
            {
                if (String.IsNullOrEmpty(txtCategory.Text))
                {
                    validation = null;
                    MessageBox.Show("Category Feild Cannot be empty");
                    return null;
                }
                else
                {
                    validation = "ok";
                    return txtCategory.Text;
                }
            }
            set
            {
                txtCategory.Text = value;
            }
        }
        public Double Amount {
            get
            {
                if (String.IsNullOrEmpty(txtAmount.Text))
                {
                    MessageBox.Show("Amount Field cannot be empty");
                    
                    return 0;
                }
                else if (!Regex.IsMatch(txtAmount.Text, "^[0-9]*$"))
                {
                    MessageBox.Show("Amount field can only contain numbers");
                    validation = null;
                    return 0;
                }
                else
                {
                    validation = "ok";
                    return Convert.ToDouble(txtAmount.Text);
                }
            }
            set
            {
                txtAmount.Text = value.ToString();
            }
        }
        public String Description { get
            {
                if (String.IsNullOrEmpty(rtxtDescription.Text))
                {
                    MessageBox.Show("Description Feild Cannot be empty");
                    validation = null;
                    return null;
                }else
                {
                    validation = "ok";
                    return rtxtDescription.Text;
                }
               
            }
            set { rtxtDescription.Text = value; }
        }
        public bool Recuring { get { return radioYes.Checked ? true : false; } set { if (value) { radioYes.Checked = true; radioNo.Checked = false; } else { radioYes.Checked = false; radioNo.Checked = true; } } } 
        public String Date { get {return dtpTransactionDate.Value.ToString("yyyy-MM-dd"); } set { DateTime.Parse(value); } }
        public String TransactionType {
            get
            {
                if (cboxType.SelectedIndex >-1)
                {
                    validation = "ok";
                    return cboxType.Text;
                }
                else
                {
                    validation = null;
                    MessageBox.Show("Transaction Type need to be selected");
                    return null;
                }
                
                
            }
            set { cboxType.SelectedText = value; } }
        public String PayerPayee { get; set; }
    }
}
