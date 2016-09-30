using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Application: Assignment 1 - Splash Screen
/// Author: Mark Chipp 200180985 "mark.chipp@live.ca, mark.chipp@mygeorgian.ca"
/// Last edited: September 30, 2016
/// Description: This file generates a splash screen for the mail order sales 
/// bonus calculator app.
/// </summary>

namespace COMP1004_F2016_Assignment1
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = false;

            SalesBonusForm salesBonusForm = new SalesBonusForm();
            salesBonusForm.Show();
            this.Hide();
        }
    }
}
