using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurdueCalculator
{
    public partial class Form1 : Form
    {

        private double total = 0;
        private double current = 0;
        private string last = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "7";
            else
                txtDisplay.Text += "7";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "0";
            else
                txtDisplay.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "1";
            else
                txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "2";
            else
                txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "3";
            else
                txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "4";
            else
                txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "5";
            else
                txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "6";
            else
                txtDisplay.Text += "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "8";
            else
                txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "9";
            else
                txtDisplay.Text += "9";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            current = double.Parse(txtDisplay.Text);
            switch (last)
            {
                case "+":
                    total += current;
                    break;
                case "-":
                    total -= current;
                    break;
                case "*":
                    total *= current;
                    break;
                case "/":
                    total /= current;
                    break;

            }
            txtDisplay.Text = total.ToString();
            last = "";
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            total = double.Parse(txtDisplay.Text);
            last = "+";
            txtDisplay.Text = "0";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            total = double.Parse(txtDisplay.Text);
            last = "-";
            txtDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            total = double.Parse(txtDisplay.Text);
            last = "*";
            txtDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            total = double.Parse(txtDisplay.Text);
            last = "/";
            txtDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            current = 0;
            txtDisplay.Text = "0";
            last = "";
        }
    }
}
