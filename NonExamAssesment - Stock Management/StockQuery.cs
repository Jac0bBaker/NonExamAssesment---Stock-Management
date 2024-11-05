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
    public partial class StockQueryPage : Form
    {
        public StockQueryPage()
        {
            InitializeComponent();
            QueryDateRangeStartText.AppendText(todayDate);
            QueryDateRangeEndText.AppendText(dateWeekAgo);
            check.populateProductCombo(QueryProductCombo);
        }

        public performChecks check = new performChecks();

        public string todayDate = DateTime.Today.ToShortDateString();
        public string dateWeekAgo = DateTime.Today.AddDays(-7).ToShortDateString();

        private void QuerySubmitButton_Click(object sender, EventArgs e)
        {
            int ycor = 100;

            Label salesQuantityLabel = new Label();
            salesQuantityLabel.Text = "Sales Quantity";
            salesQuantityLabel.Font = new Font("Century", 10);
            salesQuantityLabel.Location = new Point(50, 75);
            this.Controls.Add(salesQuantityLabel);

            Label salesDateLabel = new Label();
            salesDateLabel.Text = "Sales Date";
            salesDateLabel.Font = new Font("Century", 10);
            salesDateLabel.Location = new Point(200, 75);
            this.Controls.Add(salesDateLabel);

            Label deliveryQuantityLabel = new Label();
            deliveryQuantityLabel.Text = "Delivery Quantity";
            deliveryQuantityLabel.Font = new Font("Century", 10);
            deliveryQuantityLabel.Location = new Point(350, 75);
            this.Controls.Add(deliveryQuantityLabel);

            Label deliveryDateLabel = new Label();
            deliveryDateLabel.Text = "DeliveryDate";
            deliveryDateLabel.Font = new Font("Century", 10);
            deliveryDateLabel.Location = new Point(500, 75);
            this.Controls.Add(deliveryDateLabel);

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                connection.Open();
                SQLiteCommand fetchSalesData = new SQLiteCommand(@"
                SELECT salesQuantity, strftime('%Y-%m-%d', salesDate) AS salesDateString
                FROM salesData
                WHERE salesData.productID = (SELECT productID FROM Product WHERE productName = 'sandwiches')
                ORDER BY salesDateString", connection);
                SQLiteDataReader readSalesData = fetchSalesData.ExecuteReader();
                while (readSalesData.Read())
                {
                    Label salesQuantityLabelResult = new Label();
                    salesQuantityLabelResult.Text = readSalesData["salesQuantity"].ToString();
                    salesQuantityLabelResult.Font = new Font("Calibri", 10);
                    salesQuantityLabelResult.Location = new Point(50, ycor);
                    this.Controls.Add(salesQuantityLabelResult);

                    //this is leading to an error because date is written in incorrect format so it just returns null
                    Label salesDateLabelResult = new Label();
                    salesDateLabelResult.Text = readSalesData["salesDateString"].ToString();
                    salesDateLabelResult.Font = new Font("Century", 10);
                    salesDateLabelResult.Location = new Point(200, ycor);
                    this.Controls.Add(salesDateLabelResult);

                    ycor = ycor + 25;
                }
            }

            ycor = 100;
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                connection.Open();
                SQLiteCommand fetchDeliveryData = new SQLiteCommand(@"
                SELECT deliveryQuantity, strftime('%Y-%m-%d', deliveryDate) AS deliveryDateString
                FROM Delivery
                WHERE Delivery.productID = (SELECT productID FROM Product WHERE productName = 'sandwiches')
                ORDER BY deliveryDateString", connection);
                SQLiteDataReader readDeliveryData = fetchDeliveryData.ExecuteReader();
                while (readDeliveryData.Read())
                {
                    Label deliveryQuantityLabelResult = new Label();
                    deliveryQuantityLabelResult.Text = readDeliveryData["deliveryQuantity"].ToString();
                    deliveryQuantityLabelResult.Font = new Font("Calibri", 10);
                    deliveryQuantityLabelResult.Location = new Point(350, ycor);
                    this.Controls.Add(deliveryQuantityLabelResult);

                    Label deliveryDateLabelResult = new Label();
                    deliveryDateLabelResult.Text = readDeliveryData["deliveryDateString"].ToString();
                    deliveryDateLabelResult.Font = new Font("Calibri", 10);
                    deliveryDateLabelResult.Location = new Point(500, ycor);
                    this.Controls.Add(deliveryDateLabelResult);

                    ycor = ycor + 25;
                }
            }
        }
    }
}
