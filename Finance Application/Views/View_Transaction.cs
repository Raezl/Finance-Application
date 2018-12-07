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
using System.Xml;

namespace Finance_Application.Views
{
   
    public partial class View_Transaction : Form
    {
        public View_Transaction()
        {
            InitializeComponent();
        }

        

        private void dtpTransactionDate_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void View_Transaction_Load(object sender, EventArgs e)
        {
            List<String> lst = new Transaction().ReadTransactionXML("2018-12-06");
            for (int i = 0; i < lst.Count; i += 6)
            {
                dataGridView1.Rows.Add(lst[i], lst[i + 1], lst[i + 2], lst[i + 3], lst[i + 4], lst[i + 5]);
            }
        }

   
        private void btnModify_Click(object sender, EventArgs e)
        {
            string val = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Column6"].Value.ToString();
          
            Debug.WriteLine(val);
        }
    }
}
