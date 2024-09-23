using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void AlertsRefreshButton_Click(object sender, EventArgs e)
        {
            //This will go through each item which is on-demand and will look through the quantity.
            //There will then be a subtraction with the most recent delivery update.
            //If this falls below the minimum level the item is added until fixed.
        }
    }
}
