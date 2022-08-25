using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Smith
{
    public partial class frmCalculator : Form
    {
        //instance variables
        public double operand1;
        public double operand2;
        public double memValue;

        //instantiate Calculator class
        Calculator calc = new Calculator();
        MemoryCalculator memCal = new MemoryCalculator();
        public frmCalculator()
        {
            InitializeComponent();
            Calculator calc = new Calculator();
            MemoryCalculator memCal = new MemoryCalculator();
        }

        //event handlers 
        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Convert.ToDouble("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Convert.ToDouble("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Convert.ToDouble("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Convert.ToDouble("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Convert.ToDouble("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Convert.ToDouble("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Convert.ToDouble("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Convert.ToDouble("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Convert.ToDouble("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Convert.ToDouble("9");
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int stringLength = txtDisplay.Text.Length;
            string newText = txtDisplay.Text.Remove(stringLength - 1, 1);
            txtDisplay.Text = newText;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtDisplay.Text);
            calc.Add(operand1);
            txtDisplay.Text = "";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtDisplay.Text);
            calc.Subtract(operand1);
            txtDisplay.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtDisplay.Text);
            calc.Multiply(operand1);
            txtDisplay.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                operand1 = Convert.ToDouble(txtDisplay.Text);
                calc.Divide(operand1);
                txtDisplay.Text = "";
            }
            catch(DivideByZeroException ex)
            {
                if(operand2 == 0)
                {
                    txtDisplay.Text = "Can not divide by zero";
                }
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Sqrt(operand1).ToString();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
                operand2 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = calc.Equals(operand2).ToString();
        }

        private void btnRecip_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtDisplay.Text);
            operand2 = (1 / operand1);
            txtDisplay.Text = operand2.ToString();
        }

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtDisplay.Text);
            double newOp1 = operand1 * (-1);
            txtDisplay.Text = newOp1.ToString();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memCal.MemoryClear();
            lblMemory.Text = "";
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memCal.MemoryStore(Convert.ToDouble(txtDisplay.Text));
            if(memCal.memoryValue != 0)
            {
                lblMemory.Text = "M";
            }
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memCal.MemoryRecall().ToString();
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = memCal.MemoryAdd(operand1).ToString();
            
        }

    }
}
