using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonExamAssesment___Stock_Management
{
    public partial class SalesDataEntryPage : Form
    {
        public SalesDataEntryPage()
        {
            InitializeComponent();

            salesDateText.AppendText(todayDate);
        }

        public performChecks check = new performChecks();

        public string todayDate = DateTime.Today.ToShortDateString();

        private void salesSubmitButton_Click(object sender, EventArgs e)
        {
            //if ((check.checkProductExists))
        }
    }
}
