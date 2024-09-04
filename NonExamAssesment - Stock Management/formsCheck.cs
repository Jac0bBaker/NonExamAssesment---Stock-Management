using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonExamAssesment___Stock_Management
{
    public class performChecks
    {
        public performChecks()
        {
            connection.Open();
        }

        public static SQLiteConnection connection = new SQLiteConnection("Data Source=stockManagementDatabase.db;version=3;New=True;Compress=True");

        public int alertsSent = 0; //public as must be changed back to zero after each attempt

        protected void showAlerts(string alertText) //protected so that it cannot be accessed outside class
        {
            if (alertsSent < 1) //this prevents more than one alert being sent each run
            {
                MessageBox.Show(alertText);
                alertsSent++;
            }
        }

        public bool checkIntFormat(string number) //checks if an integer is inputted
        {
            bool intValue = true;
            try
            {
                int.Parse(number);
            }
            catch (Exception)
            {
                showAlerts("Please check you have correctly inputted an integer value where necessary");
                intValue = false;
            }
            return intValue;
        }

        public bool checkDoubleFormat(string number) //checks if a double is inputted
        {
            bool doubleValue = true;
            try
            {
                double.Parse(number);
            }
            catch (Exception)
            {
                showAlerts("Please check you have correctly inputted a decimal value where necessary");
                doubleValue = false;
            }
            return doubleValue;
        }

        public bool checkEmptyCombo(string comboBox) //checks all combo boxes are not left empty
        {
            if (comboBox == null)
            {
                showAlerts("Please check an option has been selected from each dropbox");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkDate(string date) //check date inputted follows the correct format
        {
            bool validDate = true;
            int month = 0;
            int day = 0;
            int year = 0;

            try
            {
                month = int.Parse(date[3].ToString() + date[4].ToString()); //the 3 & 4 chars of date should be the month

                if ((month > 12) || (month < 1))
                {
                    validDate = false;
                    showAlerts("Please check the month is not greater than 12 or lower than 1");
                }
            }
            catch (Exception)
            {
                showAlerts("Please check the month entered is valid");

            }

            try
            {
                day = int.Parse(date[0].ToString() + date[1].ToString()); //the 3 & 4 chars of date should be the month

                if ((month == 1) || (month == 3) || (month == 5) || (month == 7) || (month == 8) || (month == 10) || (month == 12))
                {
                    if ((day > 31) || (day < 0))
                    {
                        validDate = false;
                        showAlerts("Please check the day entered is valid");
                    }
                }
                else if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
                {
                    if ((day > 30) || (day < 0))
                    {
                        validDate = false;
                        showAlerts("Please check the day entered is valid");
                    }
                }
                else if (month == 2)
                {
                    if ((day > 28) || (day < 0))
                    {
                        validDate = false;
                        showAlerts("Please check the day entered is valid");
                    }
                }
            }
            catch (Exception)
            {
                showAlerts("Please check the day entered is valid");
            }

            try
            {
                year = int.Parse(date[6].ToString() + date[7].ToString() + date[8].ToString() + date[9].ToString());
            }
            catch (Exception)
            {
                showAlerts("Please check the year entered is valid");
            }

            return validDate;
        }

        public bool checkProductExists(string product) //check product exists
        {
            bool productExists = false;
            SQLiteCommand checkProductName = new SQLiteCommand("SELECT productName FROM Product", connection);
            SQLiteDataReader readProduct = checkProductName.ExecuteReader();

            while (readProduct.Read())
            {
                string productName = readProduct.Read().ToString();
                if (productName.ToUpper() == product.ToUpper())
                {
                    productExists = true;
                    break;
                }
            }

            if (productExists == false)
            {
                showAlerts("Product could not be found. Please check you have entered a valid product name");
            }
            return productExists;
        }

        public bool checkSupplierExsists(string supplier)
        {
            bool supplierExists = false;
            SQLiteCommand checkSupplierName = new SQLiteCommand("SELECT supplierName FROM Supplier", connection);
            SQLiteDataReader readSupplier = checkSupplierName.ExecuteReader();

            while (readSupplier.Read())
            {
                string supplierName = readSupplier.Read().ToString();
                if (supplierName.ToUpper() == supplier.ToUpper())
                {
                    supplierExists = true;
                    break;
                }
            }

            if (supplierExists == false)
            {
                showAlerts("Supplier could not be found. Please check you have entered a valid supplier name.");
            }
            return supplierExists;
        }

        public bool checkValidTelephone(string number)
        {
            bool validNumber = true;
            try //this will convert the inputted text into a double in order to check only a number was entered
            {
                double.Parse(number);
            }
            catch (Exception)
            {
                showAlerts("Please check the number entered contains no spaces and begins with a 0");
                validNumber = false;
            }

            if (number.Length != 11) //this checks all numbers are the correct length
            {
                showAlerts("Please check the number entered contains no spaces and begins with a 0");
                validNumber = false;
            }

            return validNumber;
        }

        public bool checkValidEmail(string email)
        {
            bool validEmail = false;
            if (email.Contains("@gmail.com") == true) //this checks only emails with @gmail.com are entered
            {
                validEmail = true;
            }
            else
            {
                showAlerts("Please check a valid email address has been entered");
            }

            return validEmail;
        }
    }
}
