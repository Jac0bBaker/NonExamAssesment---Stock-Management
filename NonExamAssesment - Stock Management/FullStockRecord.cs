using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonExamAssesment___Stock_Management
{
    public partial class FullStockRecord : Form
    {
        public FullStockRecord()
        {
            InitializeComponent();
            StockRecordDateRangeStartText.AppendText(todayDate);
            StockRecordDateRangeEndText.AppendText(dateWeekAgo);
        }

        public performChecks check = new performChecks();

        public string todayDate = DateTime.Today.ToShortDateString();
        public string dateWeekAgo = DateTime.Today.AddDays(-7).ToShortDateString();

        private void StockRecordSubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
