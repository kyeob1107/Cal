using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        elementaryArithmetic func = new elementaryArithmetic();

        private void digitButton1_Click(object sender, EventArgs e)
        {
            if (func.operatorChangeFlag == true)
            {
                textBoxCalculation.Text = "";
                func.operatorChangeFlag = false;
            }
            string strNumber = textBoxCalculation.Text += "1";
            double doubleNumber = Double.Parse(strNumber);
            textBoxCalculation.Text = doubleNumber.ToString();
        }

        private void digitButton2_Click(object sender, EventArgs e)
        {
            if (func.operatorChangeFlag == true)
            {
                textBoxCalculation.Text = "";
                func.operatorChangeFlag = false;
            }
            string strNumber = textBoxCalculation.Text += "2";
            double doubleNumber = Double.Parse(strNumber);
            textBoxCalculation.Text = doubleNumber.ToString();
        }

        private void digitButton3_Click(object sender, EventArgs e)
        {
            if (func.operatorChangeFlag == true)
            {
                textBoxCalculation.Text = "";
                func.operatorChangeFlag = false;
            }
            string strNumber = textBoxCalculation.Text += "3";
            double doubleNumber = Double.Parse(strNumber);
            textBoxCalculation.Text = doubleNumber.ToString();
        }

        private void digitButton4_Click(object sender, EventArgs e)
        {
            if (func.operatorChangeFlag == true)
            {
                textBoxCalculation.Text = "";
                func.operatorChangeFlag = false;
            }
            string strNumber = textBoxCalculation.Text += "4";
            double doubleNumber = Double.Parse(strNumber);
            textBoxCalculation.Text = doubleNumber.ToString();
        }

        private void digitButton5_Click(object sender, EventArgs e)
        {
            if (func.operatorChangeFlag == true)
            {
                textBoxCalculation.Text = "";
                func.operatorChangeFlag = false;
            }
            string strNumber = textBoxCalculation.Text += "5";
            double doubleNumber = Double.Parse(strNumber);
            textBoxCalculation.Text = doubleNumber.ToString();
        }

        private void digitButton6_Click(object sender, EventArgs e)
        {
            if (func.operatorChangeFlag == true)
            {
                textBoxCalculation.Text = "";
                func.operatorChangeFlag = false;
            }
            string strNumber = textBoxCalculation.Text += "6";
            double doubleNumber = Double.Parse(strNumber);
            textBoxCalculation.Text = doubleNumber.ToString();
        }

        private void digitButton7_Click(object sender, EventArgs e)
        {
            if (func.operatorChangeFlag == true)
            {
                textBoxCalculation.Text = "";
                func.operatorChangeFlag = false;
            }
            string strNumber = textBoxCalculation.Text += "7";
            double doubleNumber = Double.Parse(strNumber);
            textBoxCalculation.Text = doubleNumber.ToString();
        }

        private void digitButton8_Click(object sender, EventArgs e)
        {
            if (func.operatorChangeFlag == true)
            {
                textBoxCalculation.Text = "";
                func.operatorChangeFlag = false;
            }
            string strNumber = textBoxCalculation.Text += "8";
            double doubleNumber = Double.Parse(strNumber);
            textBoxCalculation.Text = doubleNumber.ToString();
        }

        private void digitButton9_Click(object sender, EventArgs e)
        {
            if (func.operatorChangeFlag == true)
            {
                textBoxCalculation.Text = "";
                func.operatorChangeFlag = false;
            }
            string strNumber = textBoxCalculation.Text += "9";
            double doubleNumber = Double.Parse(strNumber);
            textBoxCalculation.Text = doubleNumber.ToString();
        }

        private void digitButton0_Click(object sender, EventArgs e)
        {
            if (func.operatorChangeFlag == true)
            {
                textBoxCalculation.Text = "";
                func.operatorChangeFlag = false;
            }
            string strNumber = textBoxCalculation.Text += "9";
            double doubleNumber = Double.Parse(strNumber);
            textBoxCalculation.Text = doubleNumber.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            func.Add(textBoxCalculation.Text);
            textBoxCalculation.Text += " + ";
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            func.Subtract(textBoxCalculation.Text);
            textBoxCalculation.Text += " - ";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            func.Multiply(textBoxCalculation.Text);
            textBoxCalculation.Text += " * ";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            func.Divide(textBoxCalculation.Text);
            textBoxCalculation.Text += " / ";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {           
            textboxResult.Text = func.Result(textBoxCalculation.Text);
        }
    }
}
