using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            check.populateProductCombo(PredictionStockItemCombo);
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
            (new StockQueryPage()).Show();
        }

        private void StockRecordButton_Click(object sender, EventArgs e)
        {
            (new FullStockRecord()).Show();
        }

        private void SupplierReportButton_Click(object sender, EventArgs e)
        {
            (new SupplierReport()).Show();
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

        static int calculateWastage(int productID)
        {
            return 0;
        }

        private void WastageSubmitButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT productID FROM Product WHERE orderFrequency = $orderFrequency", connection);
                command.Parameters.AddWithValue("$orderFrequency", "daily");
            }
        }

        //---------------------------------------------------------------------------------------------

        public int calculateDeliveryQuantity(int productID)
        {
            int totalDeliveries = 0;

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                connection.Open();
                SQLiteCommand checkEachDelivery = new SQLiteCommand($"SELECT deliveryQuantity FROM Delivery WHERE productID = $productID", connection);
                checkEachDelivery.Parameters.AddWithValue("$productID", $"{productID}");
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
                connection.Open();
                SQLiteCommand checkEachSale = new SQLiteCommand($"SELECT salesQuantity FROM salesData WHERE productID = $productID", connection);
                checkEachSale.Parameters.AddWithValue("$productID", $"{productID}");
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
                connection.Open();
                SQLiteCommand checkEachUse = new SQLiteCommand($"SELECT usageQuantity FROM usageData WHERE productID = $productID", connection);
                checkEachUse.Parameters.AddWithValue("$productID", $"{productID}");
                SQLiteDataReader readUsage = checkEachUse.ExecuteReader();

                while (readUsage.Read())
                {
                    totalUsage += int.Parse(readUsage["usageQuantity"].ToString());
                }
            }
            return (calculateDeliveryQuantity(productID) - totalUsage);
        }

        private void AlertsRefreshButton_Click(object sender, EventArgs e)
        {
            AlertsList.Items.Clear();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                connection.Open();
                SQLiteCommand checkOrderFrequency = new SQLiteCommand("SELECT productName, orderFrequency, minStockLevel, onReport FROM Product WHERE orderFrequency = $orderFrequency", connection);
                checkOrderFrequency.Parameters.AddWithValue("$orderFrequency", "on-demand");
                SQLiteDataReader readProduct = checkOrderFrequency.ExecuteReader();

                while (readProduct.Read())
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

        //----------------------------------------------------------------------------------------------------------------------------------------------------

        static void populateMatrices(List<int> quantity)
        {
            //matrices M and B
            double[,] matrixM = new double[4, 4];
            double[,] matrixB = new double[4, 1];

            double[,] matrixM0 = new double[4, 4];
            double[,] matrixM1 = new double[4, 4];
            double[,] matrixM2 = new double[4, 4];
            double[,] matrixM3 = new double[4, 4];

            double sum = 0;

            //populate matrixM:
            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    for (int day = 0; day < quantity.Count; day++)
                    {
                        sum += Math.Pow(day, column + row);
                    }
                    matrixM[row, column] = sum;
                    sum = 0;
                }
            }

            //populate matrixB
            int dayOfWeek = 0;

            for (int row = 0; row < 4; row++)
            {
                for (int q = 0; q < quantity.Count; q++)
                {
                    sum += Math.Pow(dayOfWeek, row) * quantity[q];
                    dayOfWeek++;
                }
                matrixB[row, 0] = sum;
                sum = 0;
                dayOfWeek = 0;
            }

            Array.Copy(matrixM, matrixM0, 16);
            Array.Copy(matrixM, matrixM1, 16);
            Array.Copy(matrixM, matrixM2, 16);
            Array.Copy(matrixM, matrixM3, 16);

            //Matrix M0
            for (int row = 0; row < 4; row++)
            {
                matrixM0[row, 0] = matrixB[row, 0];
            }
            //Matrix M1
            for (int row = 0; row < 4; row++)
            {
                matrixM0[row, 1] = matrixB[row, 0];
            }
            //Matrix M2
            for (int row = 0; row < 4; row++)
            {
                matrixM0[row, 2] = matrixB[row, 0];
            }
            //Matrix M3
            for (int row = 0; row < 4; row++)
            {
                matrixM0[row, 3] = matrixB[row, 0];
            }


            /*for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    MessageBox.Show(matrixM0[i, j].ToString());
                }
            }*/

        }

        private void PredictionSubmitButton_Click(object sender, EventArgs e)
        {
            List<int> quantity = new List<int>();

            if (check.checkOnSalesReport(PredictionStockItemCombo.Text) == true)
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
                {
                    connection.Open();
                    SQLiteCommand fetchSales = new SQLiteCommand($@"
                    SELECT salesQuantity
                    FROM salesData
                    WHERE salesData.productID = (SELECT productID FROM Product WHERE productName = '{PredictionStockItemCombo.Text}')
                    ", connection);
                    SQLiteDataReader readSales = fetchSales.ExecuteReader();

                    while (readSales.Read())
                    {
                        quantity.Add(int.Parse(readSales["salesQuantity"].ToString()));
                    }

                    populateMatrices(quantity);
                }
            }

            else
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
                {
                    connection.Open();
                    SQLiteCommand fetchUsage = new SQLiteCommand($@"
                    SELECT usageQuantity
                    FROM usageData
                    WHERE usageData.productID = (SELECT productID FROM Product WHERE productName = '{PredictionStockItemCombo.Text}')
                    ", connection);
                    SQLiteDataReader readUsage = fetchUsage.ExecuteReader();

                    while (readUsage.Read())
                    {
                        quantity.Add(int.Parse(readUsage["usageQuantity"].ToString()));
                    }

                    populateMatrices(quantity);
                }
            }
        }
    }
}
