using NCalc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string str = ""; // string display
        string temp = "";// variable temp used to check "."

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            txtResult.Text = "0";
            str = "";
        }

        public void DisplayLabelAndTextBox(string text)
        {
            str = str + text;
            lblDisplay.Text = str;
            temp = temp + text;
        }

        public void DisplayLabel(string text)
        {
            str = str + text;
            lblDisplay.Text = str;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            str = "";
            lblDisplay.Text = str;
            txtResult.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(str!="0")
            {
                DisplayLabelAndTextBox("0");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DisplayLabelAndTextBox("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DisplayLabelAndTextBox("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DisplayLabelAndTextBox("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DisplayLabelAndTextBox("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            DisplayLabelAndTextBox("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            DisplayLabelAndTextBox("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            DisplayLabelAndTextBox("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            DisplayLabelAndTextBox("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            DisplayLabelAndTextBox("9");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!temp.Contains("."))
            {
                DisplayLabelAndTextBox(".");
            }  
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                DisplayLabel("+");
                temp = "";
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                DisplayLabel("-");
                temp = "";
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                DisplayLabel("×");
                temp = "";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                DisplayLabel("÷");
                temp = "";
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                DisplayLabel("%");
                temp = "";
            }
        }
        //public double Calculation()
        //{
            
        //    switch (sign)
        //    {
        //        case "+":
        //            result = number1 + number2;
        //            break;
        //        case "-":
        //            result = number1 - number2;
        //            break;
        //        case "×":
        //            result = number1 * number2;
        //            break;
        //        case "÷":
        //            result = number1 / number2;
        //            break;
        //        case "%":
        //            result = number1 % number2;
        //            break;
        //        default:
        //            break;
        //    }
        //    return result;
        //}

        private void btnResult_Click(object sender, EventArgs e)
        {
            string disp = str;
            try
            {
                str = str.Replace("×", "*");
                str = str.Replace("÷", "/");

                // using NCalc to calculation 
                var a = new Expression(str).Evaluate();
                txtResult.Text = a.ToString();
                lblDisplay.Text = disp + "= " + a.ToString();
            }
            catch
            {
                lblDisplay.Text = disp + " operation fail !!!";
            } 
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayLabel("(");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DisplayLabel(")");
        }
    }
}
