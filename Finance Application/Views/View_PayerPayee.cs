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
    public partial class View_PayerPayee : Form
    {
        public View_PayerPayee()
        {
            InitializeComponent();
        }

        private void View_PayerPayee_Load(object sender, EventArgs e)
        {
            List<String> lst = new PayerPayee().ReadPayerPayeeXML();
            for (int i = 0; i < lst.Count; i += 6)
            {
                dataGridView1.Rows.Add(lst[i], lst[i + 1], lst[i + 2], lst[i + 3], lst[i + 4], lst[i + 5]);
            }
        }
    }
}
