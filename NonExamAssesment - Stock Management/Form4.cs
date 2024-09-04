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
    public partial class DeliveryDataEntryPage : Form
    {
        public DeliveryDataEntryPage()
        {
            InitializeComponent();
            connection.Open();

            deliveryDateText.AppendText(todayDate);
        }

        public static SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True");

        public performChecks check = new performChecks();

        public string todayDate = DateTime.Today.ToShortDateString();

        private void deliverySubmitButton_Click(object sender, EventArgs e)
        {
            /*
            if ((checkSupplier(deliverySupplierText.Text) == true) &&
                (checkProduct(deliveryStockItemText.Text) == true) &&
                (checkDate(deliveryDateText.Text) == true) &&
                (checkQuantity(deliveryQuantityText.Text) == true)
                )
            {
                MessageBox.Show("Ready to go");
            }
            */
        }
    }
}
