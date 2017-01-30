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
        
        private void _textFields(object sender, EventArgs e)
        {
            //textbox _textFields = (Button)sender;
            TextBox textFields = sender as TextBox;
            double storingData;
            switch (textFields.Name.ToString())
            {
                case "NumberOfHours":
                    if (NumberOfHours.Text.Length != 0)
                    {
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

                case "Print":
                    MessageBox.Show("The form is being send to the printer","Title",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                break;

                case "Next":
                    empName.ResetText();
                    ID.ResetText();
                    NumberOfHours.ResetText();
                    SalesBonus.ResetText();
                break;
            }
        }

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
