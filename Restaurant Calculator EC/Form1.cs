using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Calculator_EC
{
    public partial class restaurantCalculator : Form
    {
        public restaurantCalculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal foodCharge;
            decimal tip;
            decimal tax;
            decimal total;

            // Get Food Charge
            foodCharge = decimal.Parse(foodtextBox.Text);

            // Calculate Tip 
            tip = foodCharge * 0.20m;

            // Calculate Tax
            tax = foodCharge * 0.06625m; // Tax is food charge w/o tip 

            // Calculate total 
            total = foodCharge + tip + tax;

            // Display tip 
            tipcalcLabel.Text = tip.ToString("c");

            // Display tax 
            taxcalcLabel.Text = tax.ToString("c");

            //Display Total 
            totalCalcLabel.Text = total.ToString("c"); 

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // exit app
            this.Close(); 
        }
    }
}
