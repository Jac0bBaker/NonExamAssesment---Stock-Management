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
    public partial class SupplierEntryPage : Form
    {
        public SupplierEntryPage()
        {
            InitializeComponent();
        }

        public performChecks check = new performChecks();

        private void submitSupplierEntryButton_Click(object sender, EventArgs e)
        {
            if (check.checkValidTelephone(TelephoneNumberText.Text) == true &&
                check.checkValidEmail(EmailAddressText.Text) == true
                )
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
                {
                    connection.Open();
                    SQLiteCommand insertSupplier = new SQLiteCommand("INSERT INTO Supplier(supplierName, telephoneNumber, emailAddress) " +
                       "VALUES ('" + SupplierNameText.Text + "', '" + double.Parse(TelephoneNumberText.Text) + "', '" + EmailAddressText.Text + "')", connection);
                    insertSupplier.ExecuteNonQuery();

                    MessageBox.Show("Supplier successfully added.");
                }
            }

            check.alertsSent = 0;
        }
    }
}
