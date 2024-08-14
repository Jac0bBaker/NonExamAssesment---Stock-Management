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
            Forms.stockEntryP.Show();
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            Forms.supplierP.Show();
        }

        private void AddStockUsageButton_Click(object sender, EventArgs e)
        {
            Forms.stockUsageEntryP.Show();
        }

        private void AddSalesDataButton_Click(object sender, EventArgs e)
        {
            Forms.salesDataEntryP.Show();
        }

        private void AddDeliveryDataButton_Click(object sender, EventArgs e)
        {
            Forms.deliveryDataEntryP.Show();
        }
    }
}
