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


        public void displayRecords()
        {
            dataGridView1.Rows.Clear();
            List<String> lst = new PayerPayee().ReadPayerPayeeXML();

            if (lst.Any())
            {
                for (int i = 0; i < lst.Count; i += 6)
                {
                    dataGridView1.Rows.Add(lst[i], lst[i + 1], lst[i + 2], lst[i + 3], lst[i + 4], lst[i + 5]);
                }
            }
            else
            {
                MessageBox.Show("No Records found");
            }

        }

        private void View_PayerPayee_Load(object sender, EventArgs e)
        {
            displayRecords();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var val = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["PPID"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the selected record?", "Confrim", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (new PayerPayee().RemovePayerPayee(Convert.ToInt32(val)))
                {
                    new PayerPayee().WritePayerPayeeXML();
                    MessageBox.Show("Record Deleted");
                }
            }
               

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var val = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["PPID"].Value.ToString();
            new Edit_PayerPayee(Convert.ToInt32(val)).Show();
        }
    }
}
