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
            int productID = check.findProductID(salesProductText.Text);

            if ((check.checkProductExists(salesProductText.Text) == true) &&
                (check.checkDate(salesDateText.Text) == true) &&
                (check.checkIntFormat(salesQuantityText.Text) == true)
                )
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
                {
                    connection.Open();
                    SQLiteCommand insertSale = new SQLiteCommand("INSERT INTO Supplier(supplierName, telephoneNumber, emailAddress) " +
                       "VALUES ('" + productID + "', '" + salesDateText.Text + "', '" + int.Parse(salesQuantityText.Text) + "')", connection);
                    insertSale.ExecuteNonQuery();

                    MessageBox.Show("Sale successfully added.");
                }
            }
            check.alertsSent = 0;
        }
    }
}
