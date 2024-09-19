﻿using System;
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
        }

        public performChecks check = new performChecks();

        public string todayDate = DateTime.Today.ToShortDateString();

        private void UsageStockItemButton_Click(object sender, EventArgs e)
        {
            int productID = check.findProductID(UsageStockItemText.Text);

            if ((check.checkProductExists(UsageStockItemButton.Text) == true) &&
                (check.checkDate(UsageDateText.Text) == true) &&
                (check.checkIntFormat(UsageQuantityText.Text) == true)
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
            check.alertsSent = 0;
        }
    }
}
