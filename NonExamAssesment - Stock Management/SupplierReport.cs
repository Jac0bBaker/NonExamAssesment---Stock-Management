using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace NonExamAssesment___Stock_Management
{
    public partial class SupplierReport : Form
    {
        public SupplierReport()
        {
            InitializeComponent();
            SupplierReportDateRangeStartText.AppendText(todayDate);
            SupplierReportDateRangeEndText.AppendText(dateWeekAgo);
            check.populateSupplierCombo(SupplierReportSupplierCombo);
        }

        public performChecks check = new performChecks();

        public string todayDate = DateTime.Today.ToShortDateString();
        public string dateWeekAgo = DateTime.Today.AddDays(-7).ToShortDateString();

        private void SupplierReportSubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
