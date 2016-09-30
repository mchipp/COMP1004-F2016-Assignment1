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
using System.Globalization;

/// <summary>
/// Application: Assignment 1 - Sharp Mail Order - Sales Bonus
/// Author: Mark Chipp 200180985 "mark.chipp@live.ca, mark.chipp@mygeorgian.ca"
/// Last edited: September 30, 2016
/// Description: This application takes, as input, an employees name and ID, as well
/// as their total hours worked, and the total sales of the business for a four week
/// period. It will calculate the amount of sales bonus the employee has earned
/// and return these values in standard accounting format. The form allows use in
/// multiple languages.
/// </summary>

namespace COMP1004_F2016_Assignment1
{
    public partial class SalesBonusForm : Form
    {
        public SalesBonusForm()
        {
            InitializeComponent();
        }

        // +++++++++++++++++++ Event Handlers +++++++++++++++++++

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
        /// Opens a dialogue to confirm form is printing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your form has been sent to the printer.", "Now Printing");
        }

        /// <summary>
        /// Terminates process when form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesBonusForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Clears all fields except for TotalMonthlySalesTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeesNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            HoursWorkedTextBox.Text = "0";
            SalesBonusTextBox.Text = "";
            EmployeesNameTextBox.Focus();
        }

        /// <summary>
        /// Alls ClearAllFields() function when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesBonusForm_Load(object sender, EventArgs e)
        {
            EmployeesNameTextBox.Focus();
        }

        /// <summary>
        /// Sets all text lables to English
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeesNameLabel.Text = "Employee's Name:";
            EmployeeIDLabel.Text = "Employee ID:";
            TotalHoursWorkedLabel.Text = "Total Hours Worked:";
            TotalMonthlySalesLabel.Text = "Total Monthly Sales:";
            SalesBonusLabel.Text = "Sales Bonus:";
            this.Text = "Sales Bonus";
            LanguageGroupBox.Text = "Language";
            CalculateButton.Text = "Calculate";
            PrintButton.Text = "Print";
            NextButton.Text = "Next";
        }

        /// <summary>
        /// Sets all text lables to French
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeesNameLabel.Text = "Le nom de l'employé:";
            EmployeeIDLabel.Text = "Employé Id:";
            TotalHoursWorkedLabel.Text = "Total des heures travaillées:";
            TotalMonthlySalesLabel.Text = "Total des ventes mensuelles:";
            SalesBonusLabel.Text = "Bonus de vente:";
            this.Text = "Bonus de vente";
            LanguageGroupBox.Text = "La langue";
            CalculateButton.Text = "Calculer";
            PrintButton.Text = "Impression";
            NextButton.Text = "Prochain";
        }

        /// <summary>
        /// Sets all text lables to Spanish
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpanishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeesNameLabel.Text = "Nombre del empleado:";
            EmployeeIDLabel.Text = "ID de empleado: ";
            TotalHoursWorkedLabel.Text = "El total de horas trabajadas:";
            TotalMonthlySalesLabel.Text = "Total de ventas mensuales:";
            SalesBonusLabel.Text = "Bono de ventas:";
            this.Text = "Bono de ventas";
            LanguageGroupBox.Text = "Idioma";
            CalculateButton.Text = "Calcular";
            PrintButton.Text = "Impresión";
            NextButton.Text = "Siguiente";
        }

        /// <summary>
        /// Sets all text lables to German
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GermanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeesNameLabel.Text = "Mitarbeiter Name:";
            EmployeeIDLabel.Text = "Angestellten ID:";
            TotalHoursWorkedLabel.Text = "Gesamtarbeitsstunden:";
            TotalMonthlySalesLabel.Text = "Insgesamt monatlichen Umsatz:";
            SalesBonusLabel.Text = "Der Umsatz Bonus:";
            this.Text = "Der Umsatz Bonus";
            LanguageGroupBox.Text = "Sprache";
            CalculateButton.Text = "Berechnen";
            PrintButton.Text = "Drucken";
            NextButton.Text = "Nächster";
        }


        // +++++++++++++++++++ Functions +++++++++++++++++++

        /// <summary>
        /// Calculates the total bonus by multiplying total hours worked by
        /// total sales. Incluse try/catch handling for input errors, and
        /// verification that hours worked is within acceptable range.
        /// </summary>
        private void CalculateTotal()
        {
            // Local Variables
            const double bonusRate = 0.02;
            double hoursWorked;
            double totalSales;
            double salesBonus;
            double percentageOfHoursWprked;
            double employeeSalesBonus;

            // error handling for erroneous input
            try
            {
                //Convert.ToString(double.Parse(TotalMonthlySalesTextBox.Text, NumberStyles.Currency));
                totalSales = Convert.ToDouble(double.Parse(TotalMonthlySalesTextBox.Text, NumberStyles.Currency));
                hoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text);

                // error handling for hours worked input exceeding 160 hours
                if (hoursWorked <= 160 && hoursWorked >= 0)
                {
                    // calculate the dollar amount of total sales bonus
                    salesBonus = totalSales * bonusRate;
                    // calculate percentage of total business hours the employee worked
                    percentageOfHoursWprked = (hoursWorked / 160);
                    // calclate the dollar amount of sales bonus the employee earned
                    employeeSalesBonus = salesBonus * percentageOfHoursWprked;

                    // convert doubles to accounting formatted text output
                    TotalMonthlySalesTextBox.Text = totalSales.ToString("C2");
                    SalesBonusTextBox.Text = employeeSalesBonus.ToString("C2");
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

        /// <summary>
        /// Resets the Hours Worked text box, placing focus over the field text.
        /// </summary>
        private void ResetHoursWorkedTextBox()
        {
            HoursWorkedTextBox.Focus();
            HoursWorkedTextBox.Text = "0";
            HoursWorkedTextBox.SelectAll();
        }
    }
}