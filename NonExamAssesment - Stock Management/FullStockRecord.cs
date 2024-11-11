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
    public partial class FullStockRecord : Form
    {
        public FullStockRecord()
        {
            InitializeComponent();
        }

        public performChecks check = new performChecks();

        private void StockRecordSubmitButton_Click(object sender, EventArgs e)
        {
            int ycor = 80;
            double totalCost = 0;
            double totalValue = 0;

            Label reportProductNameLabel = new Label();
            reportProductNameLabel.Text = "Product Name";
            reportProductNameLabel.Font = new Font("Calibri", 15);
            reportProductNameLabel.Location = new Point(50, 50);
            this.Controls.Add(reportProductNameLabel);

            Label reportTotalCostLabel = new Label();
            reportTotalCostLabel.Text = "Total Cost";
            reportTotalCostLabel.Font = new Font("Calibri", 15);
            reportTotalCostLabel.Location = new Point(200, 50);
            this.Controls.Add(reportTotalCostLabel);

            Label reportTotalValueLabel = new Label();
            reportTotalValueLabel.Size = new Size(150, 20);
            reportTotalValueLabel.Text = "Total Value";
            reportTotalValueLabel.Font = new Font("Calibri", 15);
            reportTotalValueLabel.Location = new Point(350, 50);
            this.Controls.Add(reportTotalValueLabel);

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                connection.Open();
                SQLiteCommand fetchReportData = new SQLiteCommand($@"
                SELECT productName, ((SELECT sum(salesQuantity) FROM salesData WHERE productID = Product.productID) * productCost) AS totalCost,
                ((SELECT sum(salesQuantity) FROM salesData WHERE productID = Product.productID) * productPrice) AS totalValue
                FROM Product, salesData
                WHERE Product.productID = salesData.productID
                GROUP BY Product.productID
                ", connection);
                SQLiteDataReader readReportData = fetchReportData.ExecuteReader();
                while (readReportData.Read())
                {
                    Label reportProductNameLabelResult = new Label();
                    reportProductNameLabelResult.Text = readReportData["productName"].ToString();
                    reportProductNameLabelResult.Font = new Font("Calibri", 8);
                    reportProductNameLabelResult.Location = new Point(50, ycor);
                    this.Controls.Add(reportProductNameLabelResult);

                    Label reportTotalCostLabelResult = new Label();
                    reportTotalCostLabelResult.Text = readReportData["totalCost"].ToString();
                    reportTotalCostLabelResult.Font = new Font("Calibri", 8);
                    reportTotalCostLabelResult.Location = new Point(200, ycor);
                    this.Controls.Add(reportTotalCostLabelResult);

                    Label reportTotalValueLabelResult = new Label();
                    reportTotalValueLabelResult.Text = readReportData["totalValue"].ToString();
                    reportTotalValueLabelResult.Font = new Font("Calibri", 8);
                    reportTotalValueLabelResult.Location = new Point(350, ycor);
                    this.Controls.Add(reportTotalValueLabelResult);

                    ycor = ycor + 20;
                    totalCost = totalCost + double.Parse(readReportData["totalCost"].ToString());
                    totalValue = totalValue + double.Parse(readReportData["totalValue"].ToString());
                }
            }

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                connection.Open();
                SQLiteCommand fetchReportData = new SQLiteCommand($@"
                SELECT productName, ((SELECT sum(usageQuantity) FROM usageData WHERE productID = Product.productID) * productCost) AS totalCost,
                ((SELECT sum(usageQuantity) FROM usageData WHERE productID = Product.productID) * productPrice) AS totalValue
                FROM Product, usageData
                WHERE Product.productID = usageData.productID
                GROUP BY Product.productID

                ", connection);
                SQLiteDataReader readReportData = fetchReportData.ExecuteReader();
                while (readReportData.Read())
                {
                    Label reportProductNameLabelResult = new Label();
                    reportProductNameLabelResult.Text = readReportData["productName"].ToString();
                    reportProductNameLabelResult.Font = new Font("Calibri", 8);
                    reportProductNameLabelResult.Location = new Point(50, ycor);
                    this.Controls.Add(reportProductNameLabelResult);

                    Label reportTotalCostLabelResult = new Label();
                    reportTotalCostLabelResult.Text = readReportData["totalCost"].ToString();
                    reportTotalCostLabelResult.Font = new Font("Calibri", 8);
                    reportTotalCostLabelResult.Location = new Point(200, ycor);
                    this.Controls.Add(reportTotalCostLabelResult);

                    Label reportTotalValueLabelResult = new Label();
                    reportTotalValueLabelResult.Text = readReportData["totalValue"].ToString();
                    reportTotalValueLabelResult.Font = new Font("Calibri", 8);
                    reportTotalValueLabelResult.Location = new Point(350, ycor);
                    this.Controls.Add(reportTotalValueLabelResult);

                    ycor = ycor + 20;
                    totalCost = totalCost + double.Parse(readReportData["totalCost"].ToString());
                    totalValue = totalValue + double.Parse(readReportData["totalValue"].ToString());
                }

                Label totalCostTotal = new Label();
                totalCostTotal.Size = new Size(200, 20);
                totalCostTotal.Text = $"total cost: £{totalCost}";
                totalCostTotal.Font = new Font("Calibri", 15);
                totalCostTotal.Location = new Point(500, 100);
                this.Controls.Add(totalCostTotal);

                Label totalValueTotal = new Label();
                totalValueTotal.Size = new Size(200, 20);
                totalValueTotal.Text = $"total value: £{totalValue}";
                totalValueTotal.Font = new Font("Calibri", 15);
                totalValueTotal.Location = new Point(500, 200);
                this.Controls.Add(totalValueTotal);
            }
        }
    }
}
