using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        static double determinant3x3(double[,] matrix)
        {
            double determinant = (
                matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1])) -
                matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0])) +
                matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]))
                );
            return determinant;
        }

        static double determinant4x4(double[,] matrix)
        {
            double[,] tempMatrix1 = new double[3, 3];
            double[,] tempMatrix2 = new double[3, 3];
            double[,] tempMatrix3 = new double[3, 3];
            double[,] tempMatrix4 = new double[3, 3];
            int avoidColumn = 0;
            int tempRow = 0;
            int tempColumn = 0;
            while (avoidColumn < 4)
            {
                for (int row = 1; row < 4; row++)
                {
                    for (int column = 0; column < 4; column++)
                    {
                        switch (avoidColumn)
                        {
                            case 0:
                                if (column != avoidColumn)
                                {
                                    tempMatrix1[tempRow, tempColumn] = matrix[row, column];
                                    tempColumn++;
                                }
                                break;
                            case 1:
                                if (column != avoidColumn)
                                {
                                    tempMatrix2[tempRow, tempColumn] = matrix[row, column];
                                    tempColumn++;
                                }
                                break;
                            case 2:
                                if (column != avoidColumn)
                                {
                                    tempMatrix3[tempRow, tempColumn] = matrix[row, column];
                                    tempColumn++;
                                }
                                break;
                            case 3:
                                if (column != avoidColumn)
                                {
                                    tempMatrix4[tempRow, tempColumn] = matrix[row, column];
                                    tempColumn++;
                                }
                                break;
                        }
                    }
                    tempColumn = 0;
                    tempRow++;
                }
                tempRow = 0;
                avoidColumn++;
            }
            double determinant = (matrix[0, 0] * determinant3x3(tempMatrix1)) -
                (matrix[0, 1] * determinant3x3(tempMatrix2)) +
                (matrix[0, 2] * determinant3x3(tempMatrix3)) -
                (matrix[0, 3] * determinant3x3(tempMatrix4));
            return determinant;
        }

        static double[] calculateRegression(double[,] matrixM, double[,] matrixM0, double[,] matrixM1, double[,] matrixM2, double[,] matrixM3)
        {
            double[] reggressionFormula = new double[4];
            double a0 = determinant4x4(matrixM0) / determinant4x4(matrixM);
            reggressionFormula[0] = a0;
            double a1 = determinant4x4(matrixM1) / determinant4x4(matrixM);
            reggressionFormula[1] = a1;
            double a2 = determinant4x4(matrixM2) / determinant4x4(matrixM);
            reggressionFormula[2] = a2;
            double a3 = determinant4x4(matrixM3) / determinant4x4(matrixM);
            reggressionFormula[3] = a3;
            return reggressionFormula;
        }

        static double[] populateMatrices(List<int> quantity)
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
                matrixM1[row, 1] = matrixB[row, 0];
            }
            //Matrix M2
            for (int row = 0; row < 4; row++)
            {
                matrixM2[row, 2] = matrixB[row, 0];
            }
            //Matrix M3
            for (int row = 0; row < 4; row++)
            {
                matrixM3[row, 3] = matrixB[row, 0];
            }

            return calculateRegression(matrixM, matrixM0, matrixM1, matrixM2, matrixM3);
        }

        static double calculateDailyPrediction(double[] reggressionFormula)
        {
            double dailyPredictionQuantity = 0;
            string dayToday = DateTime.Today.DayOfWeek.ToString();
            switch (dayToday)
            {
                case "Monday":
                    dailyPredictionQuantity =
                        Math.Round((reggressionFormula[3] * Math.Pow(0, 3)) +
                        (reggressionFormula[2] * Math.Pow(0, 2)) +
                        (reggressionFormula[1] * 0) +
                        (reggressionFormula[0]), 0);
                    break;
                case "Tuesday":
                    dailyPredictionQuantity =
                        Math.Round((reggressionFormula[3] * Math.Pow(1, 3)) +
                        (reggressionFormula[2] * Math.Pow(1, 2)) +
                        (reggressionFormula[1] * 1) +
                        (reggressionFormula[0]), 0);
                    break;
                case "Wednesday":
                    dailyPredictionQuantity =
                        Math.Round((reggressionFormula[3] * Math.Pow(2, 3)) +
                        (reggressionFormula[2] * Math.Pow(2, 2)) +
                        (reggressionFormula[1] * 2) +
                        (reggressionFormula[0]), 0);
                    break;
                case "Thursday":
                    dailyPredictionQuantity =
                        Math.Round((reggressionFormula[3] * Math.Pow(3, 3)) +
                        (reggressionFormula[2] * Math.Pow(3, 2)) +
                        (reggressionFormula[1] * 3) +
                        (reggressionFormula[0]), 0);
                    break;
                case "Friday":
                    dailyPredictionQuantity =
                        Math.Round((reggressionFormula[3] * Math.Pow(4, 3)) +
                        (reggressionFormula[2] * Math.Pow(4, 2)) +
                        (reggressionFormula[1] * 4) +
                        (reggressionFormula[0]), 0);
                    break;
                case "Saturday":
                    dailyPredictionQuantity =
                        Math.Round((reggressionFormula[3] * Math.Pow(5, 3)) +
                        (reggressionFormula[2] * Math.Pow(5, 2)) +
                        (reggressionFormula[1] * 5) +
                        (reggressionFormula[0]), 0);
                    break;
                case "Sunday":
                    dailyPredictionQuantity =
                        Math.Round((reggressionFormula[3] * Math.Pow(6, 3)) +
                        (reggressionFormula[2] * Math.Pow(6, 2)) +
                        (reggressionFormula[1] * 6) +
                        (reggressionFormula[0]), 0);
                    break;
            }
            return dailyPredictionQuantity;
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
                    double[] reggressionFormula = populateMatrices(quantity);
                    PredictionNextDaySaleText.Text = calculateDailyPrediction(reggressionFormula).ToString();
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
                    double[] reggressionFormula = populateMatrices(quantity);
                    PredictionNextDaySaleText.Text = calculateDailyPrediction(reggressionFormula).ToString();
                }
            }
        }

        private void FuturePredictionButton_Click(object sender, EventArgs e)
        {

        }
    }
}