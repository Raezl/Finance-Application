﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Finance_Application.Views
{
   
    public partial class View_Transaction : Form
    {
        public View_Transaction()
        {
            InitializeComponent();
        }

        public void displayRecords(String date)
        {
            dataGridView1.Rows.Clear();
            List<String> lst = new Transaction().ReadTransactionXML(date);

            if (lst.Any())
            {
                for (int i = 0; i <lst.Count; i += 7)
                {
                    dataGridView1.Rows.Add(lst[i], lst[i + 1], lst[i + 2], lst[i + 3], lst[i + 4], lst[i + 5], lst[i + 6]);
                }
            }
            else
            {
                MessageBox.Show("No Records found for "+date);
            }
            
        }

        private void dtpTransactionDate_ValueChanged(object sender, EventArgs e)
        {
            displayRecords(dtpTransactionDate.Value.ToString("yyyy-MM-dd"));
        }

        private void View_Transaction_Load(object sender, EventArgs e)
        {
            displayRecords(dtpTransactionDate.Value.ToString(DateTime.Today.ToString("yyyy-MM-dd")));
        }

   
        private void btnModify_Click(object sender, EventArgs e)
        {
            string val = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["TransactionId"].Value.ToString();
            new Edit_Transaction(Convert.ToInt32(val)).Show();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string val = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["TransactionId"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the selected record?", "Confrim", MessageBoxButtons.YesNo);
            Transaction obj = new Transaction();
            if (dialogResult == DialogResult.Yes)
            {
                Debug.WriteLine(val);
                if(obj.RemoveTransaction(Convert.ToInt32(val)))
                {
                    new Transaction().WriteTransactionXML(dtpTransactionDate.Value.ToString("yyyy-MM-dd"));
                }
            }
        }
    }
}
