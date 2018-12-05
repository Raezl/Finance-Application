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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            new IncomeExpense().Show();
            new Transaction().WriteXML("01/01/2000");
        }

        private void btnViewTransaction_Click(object sender, EventArgs e)
        {
            new View_Transaction().Show();
        }
    }
}
