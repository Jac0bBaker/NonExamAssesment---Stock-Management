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
    public partial class DeliveryDataEntryPage : Form
    {
        public DeliveryDataEntryPage()
        {
            InitializeComponent();
            deliveryDateText.AppendText(todayDate);
        }

        public performChecks check = new performChecks();

        public string todayDate = DateTime.Today.ToShortDateString();

        private void deliverySubmitButton_Click(object sender, EventArgs e)
        {
            
            if ((check.checkSupplierExsists(deliverySupplierText.Text) == true) &&
                (check.checkProductExists(deliveryStockItemText.Text) == true) &&
                (check.checkDate(deliveryDateText.Text) == true) &&
                (check.checkIntFormat(deliveryQuantityText.Text) == true)
                )
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
                {
                    connection.Open();
                    SQLiteCommand insertSupplier = new SQLiteCommand("INSERT INTO Supplier(supplierName, telephoneNumber, emailAddress) " +
                       "VALUES ('" + deliverySupplierText.Text + "', '" + deliveryStockItemText.Text + "', '" + deliveryDateText.Text + "')", connection);
                    insertSupplier.ExecuteNonQuery();

                    MessageBox.Show("Delivery successfully added.");
                }
            }

            check.alertsSent = 0;
        }
    }
}
