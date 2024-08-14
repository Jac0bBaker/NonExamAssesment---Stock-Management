using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonExamAssesment___Stock_Management
{
    static class Forms
    {
        public static HomePage homeP = new HomePage();
        public static StockEntryPage stockEntryP = new StockEntryPage();
        public static SupplierEntryPage supplierP = new SupplierEntryPage();
        public static DeliveryDataEntryPage deliveryDataEntryP = new DeliveryDataEntryPage();
        public static SalesDataEntryPage salesDataEntryP = new SalesDataEntryPage();
        public static StockUsageEntryPage stockUsageEntryP = new StockUsageEntryPage();
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePage());
        }
    }
}
