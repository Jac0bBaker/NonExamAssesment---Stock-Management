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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace NonExamAssesment___Stock_Management
{
    public partial class SupplierReport : Form
    {
        public SupplierReport()
        {
            InitializeComponent();
            check.populateSupplierCombo(SupplierReportSupplierCombo);
        }

        public performChecks check = new performChecks();

        public string todayDate = DateTime.Today.ToShortDateString();
        public string dateWeekAgo = DateTime.Today.AddDays(-7).ToShortDateString();

        private void SupplierReportSubmitButton_Click(object sender, EventArgs e)
        {
            int ycor = 100;

            Label supplierNameLabel = new Label();
            supplierNameLabel.Text = "Supplier Name";
            supplierNameLabel.Size = new Size(150, 20);
            supplierNameLabel.Font = new Font("Century", 10);
            supplierNameLabel.Location = new Point(50, 75);
            this.Controls.Add(supplierNameLabel);

            Label deliveryQuantityLabel = new Label();
            deliveryQuantityLabel.Text = "Delivery Quantity";
            deliveryQuantityLabel.Size = new Size(150, 20);
            deliveryQuantityLabel.Font = new Font("Century", 10);
            deliveryQuantityLabel.Location = new Point(200, 75);
            this.Controls.Add(deliveryQuantityLabel);

            Label costLabel = new Label();
            costLabel.Text = "Cost";
            costLabel.Font = new Font("Century", 10);
            costLabel.Location = new Point(350, 75);
            this.Controls.Add(costLabel);

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                double totalQuantity = 0;
                double totalCost = 0;

                connection.Open();
                SQLiteCommand fetchSupplierData = new SQLiteCommand($@"
                SELECT supplierName, SUM(deliveryQuantity) AS deliveryQuantity, SUM(deliveryQuantity * productCost) AS cost
                FROM Supplier, Product, Delivery
                WHERE (Supplier.supplierID = Product.supplierID) AND (Product.productID = Delivery.productID)
                GROUP BY supplierName", connection);
                SQLiteDataReader readSupplierData = fetchSupplierData.ExecuteReader();
                while (readSupplierData.Read())
                {
                    Label supplierNameLabelResult = new Label();
                    supplierNameLabelResult.Text = readSupplierData["supplierName"].ToString();
                    supplierNameLabelResult.Font = new Font("Calibri", 10);
                    supplierNameLabelResult.Location = new Point(50, ycor);
                    this.Controls.Add(supplierNameLabelResult);

                    Label deliveryQuantityLabelResult = new Label();
                    deliveryQuantityLabelResult.Text = readSupplierData["deliveryQuantity"].ToString();
                    deliveryQuantityLabelResult.Font = new Font("Century", 10);
                    deliveryQuantityLabelResult.Location = new Point(200, ycor);
                    this.Controls.Add(deliveryQuantityLabelResult);

                    Label costLabelResult = new Label();
                    costLabelResult.Text = readSupplierData["Cost"].ToString();
                    costLabelResult.Font = new Font("Calibri", 10);
                    costLabelResult.Location = new Point(350, ycor);
                    this.Controls.Add(costLabelResult);

                    ycor = ycor + 25;
                    totalQuantity = totalQuantity + double.Parse(readSupplierData["deliveryQuantity"].ToString());
                    totalCost = totalCost + double.Parse(readSupplierData["Cost"].ToString());
                }

                Label totalQuantityLabel = new Label();
                totalQuantityLabel.Size = new Size(200, 20);
                totalQuantityLabel.Text = $"Total Quantity: {totalQuantity}";
                totalQuantityLabel.Font = new Font("Century", 10);
                totalQuantityLabel.Location = new Point(500, 100);
                this.Controls.Add(totalQuantityLabel);

                Label totalCostLabel = new Label();
                totalCostLabel.Size = new Size(200, 20);
                totalCostLabel.Text = $"Total Cost: £{totalCost}";
                totalCostLabel.Font = new Font("Century", 10);
                totalCostLabel.Location = new Point(500, 150);
                this.Controls.Add(totalCostLabel);
            }
        }

        private void individualSupplierReportButton_Click(object sender, EventArgs e)
        {
            int ycor = 100;

            Label supplierNameLabel = new Label();
            supplierNameLabel.Text = "Supplier Name";
            supplierNameLabel.Size = new Size(150, 20);
            supplierNameLabel.Font = new Font("Century", 10);
            supplierNameLabel.Location = new Point(50, 75);
            this.Controls.Add(supplierNameLabel);

            Label productNameLabel = new Label();
            productNameLabel.Text = "Product Name";
            productNameLabel.Size = new Size(150, 20);
            productNameLabel.Font = new Font("Century", 10);
            productNameLabel.Location = new Point(200, 75);
            this.Controls.Add(productNameLabel);

            Label deliveryQuantityLabel = new Label();
            deliveryQuantityLabel.Text = "Delivery Quantity";
            deliveryQuantityLabel.Size = new Size(150, 20);
            deliveryQuantityLabel.Font = new Font("Century", 10);
            deliveryQuantityLabel.Location = new Point(350, 75);
            this.Controls.Add(deliveryQuantityLabel);

            Label costLabel = new Label();
            costLabel.Text = "Cost";
            costLabel.Font = new Font("Century", 10);
            costLabel.Location = new Point(500, 75);
            this.Controls.Add(costLabel);

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True"))
            {
                double totalQuantity = 0;
                double totalCost = 0;

                connection.Open();
                SQLiteCommand fetchSupplierData = new SQLiteCommand($@"
                SELECT supplierName, productName, deliveryQuantity, (deliveryQuantity * productCost) AS cost
                FROM Supplier, Product, Delivery
                WHERE (Supplier.supplierID = Product.supplierID) AND (Product.productID = Delivery.productID)
                AND Supplier.supplierName = '{SupplierReportSupplierCombo.Text}'", connection);
                SQLiteDataReader readSupplierData = fetchSupplierData.ExecuteReader();
                while (readSupplierData.Read())
                {
                    Label supplierNameLabelResult = new Label();
                    supplierNameLabelResult.Text = readSupplierData["supplierName"].ToString();
                    supplierNameLabelResult.Font = new Font("Calibri", 10);
                    supplierNameLabelResult.Location = new Point(50, ycor);
                    this.Controls.Add(supplierNameLabelResult);

                    Label productNameLabelResult = new Label();
                    productNameLabelResult.Text = readSupplierData["productName"].ToString();
                    productNameLabelResult.Font = new Font("Calibri", 10);
                    productNameLabelResult.Location = new Point(200, ycor);
                    this.Controls.Add(productNameLabelResult);

                    Label deliveryQuantityLabelResult = new Label();
                    deliveryQuantityLabelResult.Text = readSupplierData["deliveryQuantity"].ToString();
                    deliveryQuantityLabelResult.Font = new Font("Century", 10);
                    deliveryQuantityLabelResult.Location = new Point(350, ycor);
                    this.Controls.Add(deliveryQuantityLabelResult);

                    Label costLabelResult = new Label();
                    costLabelResult.Text = readSupplierData["Cost"].ToString();
                    costLabelResult.Font = new Font("Calibri", 10);
                    costLabelResult.Location = new Point(500, ycor);
                    this.Controls.Add(costLabelResult);

                    ycor = ycor + 25;
                    totalQuantity = totalQuantity + double.Parse(readSupplierData["deliveryQuantity"].ToString());
                    totalCost = totalCost + double.Parse(readSupplierData["Cost"].ToString());
                }

                Label totalQuantityLabel = new Label();
                totalQuantityLabel.Size = new Size(200, 20);
                totalQuantityLabel.Text = $"Total Quantity: {totalQuantity}";
                totalQuantityLabel.Font = new Font("Century", 10);
                totalQuantityLabel.Location = new Point(600, 100);
                this.Controls.Add(totalQuantityLabel);

                Label totalCostLabel = new Label();
                totalCostLabel.Size = new Size(200, 20);
                totalCostLabel.Text = $"Total Cost: £{totalCost}";
                totalCostLabel.Font = new Font("Century", 10);
                totalCostLabel.Location = new Point(600, 150);
                this.Controls.Add(totalCostLabel);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}