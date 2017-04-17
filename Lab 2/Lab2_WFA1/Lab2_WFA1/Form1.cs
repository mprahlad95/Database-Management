using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2_WFA1
{
    public partial class calculator : Form
    {
        string input = string.Empty;    //Empty string makes sure no garbage values are stored
        string op1 = string.Empty;
        string op2 = string.Empty;
        char Operator;
        double res = 0.0;
                        
        public calculator()
        {
            InitializeComponent();
        }


        private void calculator_Load(object sender, EventArgs e)
        {

        }


        private void cmd1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "1";
            this.textBox1.Text += input;
        }


        private void cmd2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "2";
            this.textBox1.Text += input;
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "3";
            this.textBox1.Text += input;
        }


        private void cmd4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "4";
            this.textBox1.Text += input;
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "5";
            this.textBox1.Text += input;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "6";
            this.textBox1.Text += input;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "7";
            this.textBox1.Text += input;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "8";
            this.textBox1.Text += input;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "9";
            this.textBox1.Text += input;
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "0";
            this.textBox1.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + ".";
            this.textBox1.Text += input;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1, num2;
            double.TryParse(op1, out num1);
            double.TryParse(op2, out num2);

            if (Operator == '+')
            {
                res = num1+num2;
                this.textBox1.Text = res.ToString();
            }

            else if (Operator == '-')
            {
                res = num1-num2;
                this.textBox1.Text = res.ToString();
            }

            else if (Operator == '/')
            {
                res = num1/num2;
                this.textBox1.Text = res.ToString();
            }
            
            else if (Operator == '*')
            {
                res = num1*num2;
                this.textBox1.Text = res.ToString();
            }
            op1=op2 = this.textBox1.Text;
        }

        private void div_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '/';
            input = string.Empty;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '*';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '-';
            input = string.Empty;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '+';
            input = string.Empty;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            res = 0.0;
            input = string.Empty;
            op1 = string.Empty;
            op2 = string.Empty;
            this.textBox1.Text = "0";
        }

        private void log_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1;
            double.TryParse(op2, out num1);
            res = Math.Log10(num1);
            this.textBox1.Text = res.ToString();
            op1 = op2 = this.textBox1.Text;
        }

        private void ln_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1;
            double.TryParse(op2, out num1);
            res = Math.Log(num1);
            this.textBox1.Text = res.ToString();
            op1 = op2 = this.textBox1.Text;
        }

        private void sin_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1;
            double.TryParse(op2, out num1);
            res = Math.Sin(num1);
            this.textBox1.Text = res.ToString();
            op1 = op2 = this.textBox1.Text;
        }

        private void perc_Click(object sender, EventArgs e)
        {
           
        }

        private void square_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1;
            double.TryParse(op2, out num1);
            res = num1 * num1;
            this.textBox1.Text = res.ToString();
            op1 = op2 = this.textBox1.Text;
        }

        private void cos_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1;
            double.TryParse(op2, out num1);
            res = Math.Cos(num1);
            this.textBox1.Text = res.ToString();
            op1 = op2 = this.textBox1.Text;
        }

        private void root_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1;
            double.TryParse(op2, out num1);
            res = Math.Sqrt(num1);
            this.textBox1.Text = res.ToString();
            op1 = op2 = this.textBox1.Text;
        }

        private void cube_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1;
            double.TryParse(op2, out num1);
            res = num1*num1*num1;
            this.textBox1.Text = res.ToString();
            op1 = op2 = this.textBox1.Text;
        }

        private void tan_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1;
            double.TryParse(op2, out num1);
            res = Math.Tan(num1);
            this.textBox1.Text = res.ToString();
            op1 = op2 = this.textBox1.Text;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '%';
            input = string.Empty;
        }

        private void fact_Click(object sender, EventArgs e)
        {
            op2 = input;
            long num1;
            res = 1;
            long.TryParse(op2, out num1);
            for (long i = num1; i > 0; i--)
                res *= i;
            
            this.textBox1.Text = res.ToString();
            op1 = op2 = this.textBox1.Text;
        }

        private void pi_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "3.14159";
            this.textBox1.Text += input;
        }

        private void cmd7_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "7";
            this.textBox1.Text += input;
        }

        





    }
}
