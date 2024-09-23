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
    public partial class StockUsageEntryPage : Form
    {
        public StockUsageEntryPage()
        {
            InitializeComponent();
            UsageDateText.AppendText(todayDate);
            check.populateProductCombo(UsageProductCombo);
        }

        public performChecks check = new performChecks();

        public string todayDate = DateTime.Today.ToShortDateString();

        private void UsageStockItemButton_Click(object sender, EventArgs e)
        {
            int productID = check.findProductID(UsageProductCombo.Text);

            if ((check.checkDate(UsageDateText.Text) == true) &&
                (check.checkIntFormat(UsageQuantityText.Text) == true &&
                (check.checkOnSalesReport(UsageProductCombo.Text)) == false)
                )
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
                {
                    connection.Open();
                    SQLiteCommand insertSale = new SQLiteCommand("INSERT INTO Supplier(supplierName, telephoneNumber, emailAddress) " +
                       "VALUES ('" + productID + "', '" + UsageDateText.Text + "', '" + int.Parse(UsageQuantityText.Text) + "')", connection);
                    insertSale.ExecuteNonQuery();

                    MessageBox.Show("Usage successfully added.");
                }
            }
            else if (check.checkOnSalesReport(UsageProductCombo.Text) == true)
            {
                check.showAlerts("Only products not on the sales report can be added");
            }
            check.alertsSent = 0;
        }
    }
}
