///<summary>
///	Name of Programme - Sharp Mail Order - SALES BONUS
///	Name - sahil verma
///	Student Number - 200335300
///	Date Last Modified - Jan-29, 2017
///	Short revision history - fnctionality added, picture structured, structured
///	Description - the app calculate the sales bonus of the employee by getting the 
///	values of his/her hours and the monthly sale.
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class MailOrder : System.Windows.Forms.Form
    {
        //'_' means private variables 
        //PRIVATE INSTANCE VARIABLES
        private double _percentageOfHoursWorked;
        private double _totalBonusAmount;

        //CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++
        public MailOrder()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Entering number of hours and total sales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _textFields(object sender, EventArgs e)
        {
            //textbox _textFields = (Button)sender;
            TextBox textFields = sender as TextBox;
            double storingData;
            switch (textFields.Name.ToString())
            {
                case "NumberOfHours":
                    //will check if there's any value in text field
                    if (NumberOfHours.Text.Length != 0)
                    {
                        //it will store number of hours in variable storingData
                        if (double.TryParse(NumberOfHours.Text, out storingData))
                        {

                            if (double.Parse(NumberOfHours.Text) < 0 || double.Parse(NumberOfHours.Text) > 160)
                            {
                                MessageBox.Show("Number should be +ve and < 160", "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                                NumberOfHours.ResetText();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter numbers only", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                            NumberOfHours.ResetText();

                        }
                    }

                break;

                case "TotalSales":
                    if(TotalSales.Text.Length != 0)
                    {
                        if (!double.TryParse(TotalSales.Text , out storingData))
                        { 
                            MessageBox.Show("Enter numbers only", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                            TotalSales.Text = TotalSales.Text.Remove(TotalSales.Text.Length -1);
                            TotalSales.SelectionStart = TotalSales.Text.Length;

                        }
                    }
                break;
            }
        }

        /// <summary>
        /// calculate, print and clears the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Button_click(object sender, EventArgs e)
        {
            //Button _textFields = (Button)sender;
            Button Button_click = sender as Button;

            switch (Button_click.Text.ToString())
            {
                case "Calculate":
                    _percentageOfHoursWorked = Double.Parse(NumberOfHours.Text) / 160;
                    _totalBonusAmount = Double.Parse(TotalSales.Text) * 0.02;
                    SalesBonus.Text = (_percentageOfHoursWorked * _totalBonusAmount).ToString();

                break;
                //will show a message box that it prints the form
                case "Print":
                    MessageBox.Show("The form is being send to the printer","Title",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                break;

                // will clear the text fields
                case "Next":
                    empName.ResetText();
                    ID.ResetText();
                    NumberOfHours.ResetText();
                    SalesBonus.ResetText();
                break;
            }
        }

        /// <summary>
        /// changing the language from english to french and visa-versa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeLanguage(object sender, EventArgs e)
        {
            switch (englishRadioButton.Checked)
            {
                case true:
                    nameOfEmployee.Text = "Employee's Name";
                    Employee.Text = "Employee ID:";
                    Hours.Text = "Total Hours:";
                    Sales.Text = "Total Sales:";
                    Bonus.Text = "Sales Bonus:";
                    Calculate.Text = "Calculate";
                    Print.Text = "Print";
                    Next.Text = "Next";
                
                    break;

                case false:
                    nameOfEmployee.Text = "Lenomde l'employé";
                    Employee.Text = "ID de l'employé";
                    Hours.Text = "Heures de travail";
                    Sales.Text = "Le total des ventes";
                    Bonus.Text = "Bonus de ventes";
                    Calculate.Text = "Calculer";
                    Print.Text = "Imprimer";
                    Next.Text = "Next";
                    break;

            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Employee_Click(object sender, EventArgs e)
        {

        }

        private void SalesBonus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
