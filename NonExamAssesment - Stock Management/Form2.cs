using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonExamAssesment___Stock_Management
{
    public partial class StockEntryPage : Form
    {
        public StockEntryPage()
        {
            InitializeComponent();
            
        }

        //public static SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public string onSalesReport(bool checkClicked)
        {
            if (checkClicked == true)
            {
                return "yes";
            }
            else
            {
                return "no";
            }
        }

        static int findSupplierID(string supplier)
        {
            int supplierID = 0; ;
            string supplierName = "";

            using(SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                connection.Open();
                SQLiteCommand selectName = new SQLiteCommand("SELECT supplierID, supplierName FROM supplier", connection);
                SQLiteDataReader readSupplier = selectName.ExecuteReader();
                while (readSupplier.Read())
                {
                    supplierID = int.Parse(readSupplier["supplierID"].ToString());
                    supplierName = readSupplier["supplierName"].ToString();

                    if (supplierName.ToUpper() == supplier.ToUpper())
                    {
                        break;
                    }
                }
            }
            return supplierID;
        }

        private void submitStockEntryButton_Click(object sender, EventArgs e)
        {
            performChecks check = new performChecks();

            if (check.checkIntFormat(MinStockLevelText.Text) == true &&
                check.checkDoubleFormat(ItemCostText.Text) == true &&
                check.checkDoubleFormat(ItemPriceText.Text) == true &&
                check.checkEmptyCombo(UnitTypeCombo.Text) == false &&
                check.checkSupplierExsists(SupplierNameText.Text)
                )
            {
                int supplierID = findSupplierID(SupplierNameText.Text);
                MessageBox.Show(supplierID.ToString());

                using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
                {
                    connection.Open();
                    SQLiteCommand insertProduct = new SQLiteCommand("INSERT INTO Product(productName, supplierID, productCost, productPrice, minStockLevel, unitType, orderFrequency, onReport) " +
                        "VALUES ('" + ItemNameText.Text + "', '" + supplierID + "', '" + double.Parse(ItemCostText.Text) + "', '" + double.Parse(ItemPriceText.Text) + "', '" + int.Parse(MinStockLevelText.Text) + "', '" + UnitTypeCombo.Text + "', '" + OrderFrequencyCombo.Text + "', '" + onSalesReport(OnSalesReportCheck.Checked) + "')", connection);
                    insertProduct.ExecuteNonQuery();

                    MessageBox.Show("Stock item successfully added.");
                }

                /*
                connection.Open();
                int supplierID = findSupplierID(SupplierNameText.Text);

                SQLiteCommand insertProduct = new SQLiteCommand("INSERT INTO Product(productName, supplierID, productCost, productPrice, minStockLevel, unitType, orderFrequency, onReport) " +
                    "VALUES ('" + ItemNameText.Text + "', '" + supplierID + "', '" + double.Parse(ItemCostText.Text) + "', '" + double.Parse(ItemPriceText.Text) + "', '" + int.Parse(MinStockLevelText.Text) + "', '" + UnitTypeCombo.Text + "', '" + OrderFrequencyCombo.Text + "', '" + onSalesReport(OnSalesReportCheck.Checked) + "')", connection);
                insertProduct.ExecuteNonQuery();

                MessageBox.Show("Stock item successfully added.");
                connection.Dispose(); */
            }

            check.alertsSent = 0;
        }
    }
}
