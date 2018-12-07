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
    public partial class Add_IncomeExpense : Form
    {

        List<UserControl> _IEUControls = new List<UserControl>();

        public Add_IncomeExpense()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is RichTextBox)
                        (control as RichTextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (_IEUControls.Any())
            {
                foreach(UC_IncomeExpese control in _IEUControls)
                {
                    Transaction record = new Transaction();
                    record.Category = control.Category;
                    record.Date = control.Date;
                    record.Description = control.Description;
                    record.Recuring = control.Recuring;
                    record.TransactionType = control.TransactionType;
                    record.UserDetailsUserId = 1;
                    record.PayerPayeePPId = 1;

                    if (threadAddTransaction.IsBusy != true)
                        threadAddTransaction.RunWorkerAsync(argument: record);
                }
                
            }

            
          
        }
        
        private void ThreadAddTransaction_DoWork(object sender, DoWorkEventArgs e)
        {
            if (new Transaction().AddTransaction((Transaction)e.Argument))
            {
                MessageBox.Show("Record added successfully");
            } 
        }

        int tabno = 0;
        public void IETabPages()
        {
            int entires = Convert.ToInt32(Math.Round(numudEntries.Value, 0));

            Debug.WriteLine(" entries:" + entires + " Tabs:" + tabsIncomeExpense.TabCount);
            if (tabsIncomeExpense.TabCount <= entires)
            {
                for (int i = 0; i <= entires - tabsIncomeExpense.TabCount; ++i)
                {
                    tabno++;
                    Debug.WriteLine("" + i);
                    UC_IncomeExpese IEUsercontrol = new UC_IncomeExpese();
                    _IEUControls.Add(IEUsercontrol);
                    IEUsercontrol.Dock = DockStyle.Fill;
                    TabPage newTab = new TabPage();
                    newTab.Controls.Add(IEUsercontrol);
                    newTab.Text = "Record " + tabno;
                    tabsIncomeExpense.TabPages.Add(newTab);
                }
            }
        }



        private void numudEntries_ValueChanged(object sender, EventArgs e)
        {
            IETabPages();
        }

        private void Add_IncomeExpense_Load(object sender, EventArgs e)
        {
            IETabPages();
        }
    }
}
