using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Button1_Click_1(object sender, EventArgs e)
        {
            double resistor1;

            try
            {
                resistor1 = double.Parse(textBox1.Text);
                //This converts the numbers in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                resistor1 = 0.0;
            }
            //the try catch checks if the input is an integer and is not a string
            double resistor2;

            try
            {
                resistor2 = double.Parse(textBox2.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                resistor2 = 0.0;
            }
            //this try catch checks if the input is an integer and not a string

            double tot1 = resistor1 + resistor2;
            //this carries out the calculation to find out the total resistance of 2 resistors in a series circuit
            label1.Text = "Total Resistance = " + tot1.ToString("N3") + " Ω";
            //this prints the total resistance and it gives the answer to 3 decimal places

         
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double resistor3;

            try
            {
                resistor3 = double.Parse(textBox3.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                resistor3 = 0.0;
            }
            double resistor4;

            try
            {
                resistor4 = double.Parse(textBox4.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                resistor4 = 0.0;
            }
            double tot2 = (1 / ((1.0 / resistor3) + (1.0 / resistor4)));
            //this carries out the calculation to find out the total resistance of 2 resistors in a series circuit
            label2.Text = "Total Resistance = " + tot2.ToString("N3") + " Ω";
            //this prints the total resistance and it gives the answer to 3 decimal place
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double resistor5;

            try
            {
                resistor5 = double.Parse(textBox5.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                resistor5 = 0.0;
            }
            double resistor6;

            try
            {
                resistor6 = double.Parse(textBox6.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                resistor6 = 0.0;
            }
            double resistor7;

            try
            {
                resistor7 = double.Parse(textBox6.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                resistor7 = 0.0;
            }
            double tot3 = resistor5 + resistor6 + resistor7;
            //this carries out the calculation to find out the total resistance of 2 resistors in a series circuit
            label3.Text = "Total Resistance = " + tot3.ToString("N3") + " Ω";
            //this prints the total resistance and it gives the answer to 3 decimal place
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double resistor8;

            try
            {
                resistor8 = double.Parse(textBox3.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                resistor8 = 0.0;
            }
            double resistor9;

            try
            {
                resistor9 = double.Parse(textBox4.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                resistor9 = 0.0;
            }
            double resistor10;

            try
            {
                resistor10 = double.Parse(textBox6.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                resistor10 = 0.0;
            }
            double tot2 = (1 / ((1.0 / resistor8) + (1.0 / resistor9) + (1.0/ resistor10)));
            //this carries out the calculation to find out the total resistance of 2 resistors in a series circuit
            label4.Text = "Total Resistance = " + tot2.ToString("N3") + " Ω";
            //this will print the code and give the total resistance up to 3 decimal places
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
