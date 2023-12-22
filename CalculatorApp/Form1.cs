using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        

        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";



        public Form1()
        {
            InitializeComponent();
        }

        private void numOne_Click(object sender, EventArgs e)
        {
            outPut.Text = "";
            userInput += "1";
            outPut.Text += userInput;
        }

        private void numTwo_Click(object sender, EventArgs e)
        {
            outPut.Text = "";
            userInput += "2";
            outPut.Text += userInput;
        }

        private void numThree_Click(object sender, EventArgs e)
        {
            outPut.Text = "";
            userInput += "3";
            outPut.Text += userInput;
        }

        private void oppisiteSign_Click(object sender, EventArgs e)
        {
            if (double.TryParse(outPut.Text, out double userInput))
            {
                // Toggle the sign of the number
                userInput = -userInput;

                // Update the displayed number
                outPut.Text = userInput.ToString();
            }
            else
            {
                // Handle invalid number input
                outPut.Text = "Invalid input";
            }
        }
        private void numZero_Click(object sender, EventArgs e)
        {
            outPut.Text = "";
            userInput += "0";
            outPut.Text += userInput;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            outPut.Text += ".";
        }

        private void equalsSign_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum;

            // Assuming userInput, first, and function are declared and initialized elsewhere

            // Convert userInput and first to doubles
            if (!double.TryParse(userInput, out secondNum) || !double.TryParse(first, out firstNum))
            {
                outPut.Text = "Invalid input"; // Handle invalid input here
                return;
            }

            if (firstNum < 0)
            {
                firstNum *= -1; // Make sure the first number is positive for calculations
                first = firstNum.ToString(); // Update the string representation of the first number
            }

            if (userInput.StartsWith("-"))
            {
                secondNum *= -1; // Make sure the second number is negative for subtraction
            }

            // Perform the calculations based on the operator
            switch (function)
            {
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
                case '/':
                    if (secondNum == 0)
                    {
                        outPut.Text = "Cannot divide by 0";
                        return;
                    }
                    result = firstNum / secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
                default:
                    outPut.Text = "Invalid operator"; // Handle invalid operator here
                    return;
            }

            outPut.Text = result.ToString();
        }

        private void minusSign_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void numSix_Click(object sender, EventArgs e)
        {
            outPut.Text = "";
            userInput += "6";
            outPut.Text += userInput;
        }

        private void numFive_Click(object sender, EventArgs e)
        {
            outPut.Text = "";
            userInput += "5";
            outPut.Text += userInput;
        }

        private void numFour_Click(object sender, EventArgs e)
        {
            outPut.Text = "";
            userInput += "4";
            outPut.Text += userInput;
        }

        private void numNine_Click(object sender, EventArgs e)
        {
            outPut.Text = "";
            userInput += "9";
            outPut.Text += userInput;
        }

        private void pluseSign_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void numEight_Click(object sender, EventArgs e)
        {
            outPut.Text = "";
            userInput += "8";
            outPut.Text += userInput;
        }

        private void numSeven_Click(object sender, EventArgs e)
        {
            outPut.Text = "";
            userInput += "7";
            outPut.Text += userInput;
        }

        private void divisionSign_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void MultiplicationSign_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void percentSign_Click(object sender, EventArgs e)
        {
            function = '%';
            first = userInput;
            userInput = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            outPut.Text = "0";
        }
    }
}
