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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public performChecks check = new performChecks();

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StockQueryButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AddStockItemButton_Click(object sender, EventArgs e)
        {
            (new StockEntryPage()).Show();
            
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            (new SupplierEntryPage()).Show();
        }

        private void AddStockUsageButton_Click(object sender, EventArgs e)
        {
            (new StockUsageEntryPage()).Show();
        }

        private void AddSalesDataButton_Click(object sender, EventArgs e)
        {
            (new SalesDataEntryPage()).Show();
        }

        private void AddDeliveryDataButton_Click(object sender, EventArgs e)
        {
            (new DeliveryDataEntryPage()).Show();
        }

        private void WastageOutputBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void WastageSubmitButton_Click(object sender, EventArgs e)
        {
            
        }

        //---------------------------------------------------------------------------------------------

        public int calculateDeliveryQuantity(int productID)
        {
            int totalDeliveries = 0;

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                SQLiteCommand checkEachDelivery = new SQLiteCommand($"SELECT deliveryQuantity FROM Delivery WHERE productID = {productID}", connection);
                SQLiteDataReader readDeliveries = checkEachDelivery.ExecuteReader();

                while (readDeliveries.Read())
                {
                    totalDeliveries += int.Parse(readDeliveries["deliveryQuantity"].ToString());
                }
            }
            return totalDeliveries;
        }

        public int calculateQuantitySales(int productID) //this will add all the deliveies of a product and subtract all the sales
        {
            int totalSales = 0;
            
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                SQLiteCommand checkEachSale = new SQLiteCommand($"SELECT salesQuantity FROM salesData WHERE productID = {productID}", connection);
                SQLiteDataReader readSales = checkEachSale.ExecuteReader();

                while (readSales.Read())
                {
                    totalSales += int.Parse(readSales["salesQuantity"].ToString());
                }
            }
            return (calculateDeliveryQuantity(productID) - totalSales);
        }

        public int calculateQuantityUsage(int productID) //this will add all the deliveies of a product and subtract all the usage
        {
            int totalUsage = 0;

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                SQLiteCommand checkEachUse = new SQLiteCommand($"SELECT usageQuantity FROM usageData WHERE productID = {productID}", connection);
                SQLiteDataReader readUsage = checkEachUse.ExecuteReader();

                while (readUsage.Read())
                {
                    totalUsage += int.Parse(readUsage["salesQuantity"].ToString());
                }
            }
            return (calculateDeliveryQuantity(productID) - totalUsage);
        }

        private void AlertsRefreshButton_Click(object sender, EventArgs e)
        {
            //next to be added is feature to remove items which have been reordered

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                connection.Open();
                SQLiteCommand checkOrderFrequency = new SQLiteCommand("SELECT productName, orderFrequency, minStockLevel, onReport FROM Product", connection);
                SQLiteDataReader readProduct = checkOrderFrequency.ExecuteReader();

                while (readProduct.Read())
                {
                    if (readProduct["orderFrequency"].ToString() == "on-demand")
                    {
                        int productID = check.findProductID(readProduct["productName"].ToString());
                        if (readProduct["onReport"].ToString() == "yes")
                        {
                            if (int.Parse(readProduct["minStockLevel"].ToString()) >= calculateQuantitySales(productID))
                            {
                                AlertsList.Items.Add(readProduct["productName"].ToString());
                            }
                        }
                        else
                        {
                            if (int.Parse(readProduct["minStockLevel"].ToString()) >= calculateQuantityUsage(productID))
                            {
                                AlertsList.Items.Add(readProduct["productName"].ToString());
                            }
                        }
                        
                    }
                }

            }
        }
    }
}
