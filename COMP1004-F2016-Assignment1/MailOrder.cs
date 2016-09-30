using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assignment1
{
    public partial class SalesBonusForm : Form
    {
        public SalesBonusForm()
        {
            InitializeComponent();
            EmployeesNameTextBox.Focus();
        }

        /// <summary>
        /// Calculate button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        
        /// <summary>
        /// Calculates the total bonus by multiplying total hours worked by
        /// total sales.
        /// </summary>
        private void CalculateTotal()
        {
            // Local Variables
            const double bonusRate = 0.02;
            double hoursWorked;
            double totalSales;
            double salesBonus;
            double percentageOfHours;
            double employeeBonus;

            try
            {
                totalSales = Convert.ToDouble(TotalSalesTextBox.Text);
                hoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text);

                if (hoursWorked <= 160 && hoursWorked >= 0)
                {
                    salesBonus = totalSales * bonusRate;
                    percentageOfHours = (hoursWorked / 160);
                    employeeBonus = salesBonus * percentageOfHours;

                    TotalSalesTextBox.Text = totalSales.ToString("C2");
                    SalesBonusTextBox.Text = employeeBonus.ToString("C2");
                }
                else
                {
                    MessageBox.Show("Hours worked must be an integer from 0-160", "Input Error");
                    ResetHoursWorkedTextBox();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                ResetHoursWorkedTextBox();
            }
        }


        private void ResetHoursWorkedTextBox()
        {
            HoursWorkedTextBox.Focus();
            HoursWorkedTextBox.Text = "0";
            HoursWorkedTextBox.SelectAll();
        }

        private void SalesBonusForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            EmployeesNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            HoursWorkedTextBox.Text = "0";
            TotalSalesTextBox.Text = "0";
            SalesBonusTextBox.Text = "0";
            EmployeesNameTextBox.Focus();
        }

        private void SalesBonusForm_Load(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }
}
