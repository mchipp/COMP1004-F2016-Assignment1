﻿namespace COMP1004_F2016_Assignment1
{
    partial class SalesBonusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBonusForm));
            this.EmployeesNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.TotalHoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalMonthlySalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.EmployeesNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.TotalMonthlySalesTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.LanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.GermanRadioButton = new System.Windows.Forms.RadioButton();
            this.SpanishRadioButton = new System.Windows.Forms.RadioButton();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesNameLabel
            // 
            this.EmployeesNameLabel.AutoSize = true;
            this.EmployeesNameLabel.Location = new System.Drawing.Point(12, 94);
            this.EmployeesNameLabel.Name = "EmployeesNameLabel";
            this.EmployeesNameLabel.Size = new System.Drawing.Size(94, 13);
            this.EmployeesNameLabel.TabIndex = 0;
            this.EmployeesNameLabel.Text = "Employee\'s Name:";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(12, 120);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(70, 13);
            this.EmployeeIDLabel.TabIndex = 1;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // TotalHoursWorkedLabel
            // 
            this.TotalHoursWorkedLabel.AutoSize = true;
            this.TotalHoursWorkedLabel.Location = new System.Drawing.Point(12, 147);
            this.TotalHoursWorkedLabel.Name = "TotalHoursWorkedLabel";
            this.TotalHoursWorkedLabel.Size = new System.Drawing.Size(106, 13);
            this.TotalHoursWorkedLabel.TabIndex = 2;
            this.TotalHoursWorkedLabel.Text = "Total Hours Worked:";
            // 
            // TotalMonthlySalesLabel
            // 
            this.TotalMonthlySalesLabel.AutoSize = true;
            this.TotalMonthlySalesLabel.Location = new System.Drawing.Point(12, 171);
            this.TotalMonthlySalesLabel.Name = "TotalMonthlySalesLabel";
            this.TotalMonthlySalesLabel.Size = new System.Drawing.Size(103, 13);
            this.TotalMonthlySalesLabel.TabIndex = 3;
            this.TotalMonthlySalesLabel.Text = "Total Monthly Sales:";
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(12, 195);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(69, 13);
            this.SalesBonusLabel.TabIndex = 4;
            this.SalesBonusLabel.Text = "Sales Bonus:";
            // 
            // EmployeesNameTextBox
            // 
            this.EmployeesNameTextBox.Location = new System.Drawing.Point(119, 91);
            this.EmployeesNameTextBox.Name = "EmployeesNameTextBox";
            this.EmployeesNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.EmployeesNameTextBox.TabIndex = 5;
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(178, 117);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIDTextBox.TabIndex = 6;
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(178, 144);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.HoursWorkedTextBox.TabIndex = 7;
            this.HoursWorkedTextBox.Text = "0";
            // 
            // TotalMonthlySalesTextBox
            // 
            this.TotalMonthlySalesTextBox.Location = new System.Drawing.Point(178, 168);
            this.TotalMonthlySalesTextBox.Name = "TotalMonthlySalesTextBox";
            this.TotalMonthlySalesTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalMonthlySalesTextBox.TabIndex = 8;
            this.TotalMonthlySalesTextBox.Text = "0";
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.BackColor = System.Drawing.Color.White;
            this.SalesBonusTextBox.Location = new System.Drawing.Point(178, 192);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesBonusTextBox.TabIndex = 9;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 227);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(104, 227);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 11;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(197, 227);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 12;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // LanguageGroupBox
            // 
            this.LanguageGroupBox.Controls.Add(this.GermanRadioButton);
            this.LanguageGroupBox.Controls.Add(this.SpanishRadioButton);
            this.LanguageGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguageGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguageGroupBox.Location = new System.Drawing.Point(113, 9);
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.Size = new System.Drawing.Size(158, 69);
            this.LanguageGroupBox.TabIndex = 13;
            this.LanguageGroupBox.TabStop = false;
            this.LanguageGroupBox.Text = "Language";
            // 
            // GermanRadioButton
            // 
            this.GermanRadioButton.AutoSize = true;
            this.GermanRadioButton.Location = new System.Drawing.Point(84, 42);
            this.GermanRadioButton.Name = "GermanRadioButton";
            this.GermanRadioButton.Size = new System.Drawing.Size(71, 17);
            this.GermanRadioButton.TabIndex = 3;
            this.GermanRadioButton.TabStop = true;
            this.GermanRadioButton.Text = "Deutsche";
            this.GermanRadioButton.UseVisualStyleBackColor = true;
            this.GermanRadioButton.CheckedChanged += new System.EventHandler(this.GermanRadioButton_CheckedChanged);
            // 
            // SpanishRadioButton
            // 
            this.SpanishRadioButton.AutoSize = true;
            this.SpanishRadioButton.Location = new System.Drawing.Point(84, 19);
            this.SpanishRadioButton.Name = "SpanishRadioButton";
            this.SpanishRadioButton.Size = new System.Drawing.Size(63, 17);
            this.SpanishRadioButton.TabIndex = 2;
            this.SpanishRadioButton.TabStop = true;
            this.SpanishRadioButton.Text = "Español";
            this.SpanishRadioButton.UseVisualStyleBackColor = true;
            this.SpanishRadioButton.CheckedChanged += new System.EventHandler(this.SpanishRadioButton_CheckedChanged);
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(6, 42);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(65, 17);
            this.FrenchRadioButton.TabIndex = 1;
            this.FrenchRadioButton.TabStop = true;
            this.FrenchRadioButton.Text = "Français";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.FrenchRadioButton_CheckedChanged);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(6, 19);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(59, 17);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // SalesBonusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LanguageGroupBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalMonthlySalesTextBox);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeesNameTextBox);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalMonthlySalesLabel);
            this.Controls.Add(this.TotalHoursWorkedLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeesNameLabel);
            this.MaximizeBox = false;
            this.Name = "SalesBonusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesBonusForm_FormClosing);
            this.Load += new System.EventHandler(this.SalesBonusForm_Load);
            this.LanguageGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeesNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label TotalHoursWorkedLabel;
        private System.Windows.Forms.Label TotalMonthlySalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.TextBox EmployeesNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.TextBox TotalMonthlySalesTextBox;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton GermanRadioButton;
        private System.Windows.Forms.RadioButton SpanishRadioButton;
    }
}

