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
    public partial class StockQueryPage : Form
    {
        public StockQueryPage()
        {
            InitializeComponent();
            QueryDateRangeStartText.AppendText(todayDate);
            QueryDateRangeEndText.AppendText(dateWeekAgo);
            check.populateProductCombo(QueryProductCombo);
        }

        public performChecks check = new performChecks();

        public string todayDate = DateTime.Today.ToShortDateString();
        public string dateWeekAgo = DateTime.Today.AddDays(-7).ToShortDateString();
    }
}
