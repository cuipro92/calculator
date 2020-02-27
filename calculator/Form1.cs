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

        public void Display()
        {
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
                str = str + "0";
                temp = temp + "0";
                Display();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            str = str + "1";
            temp = temp + "1";
            Display();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            str = str + "2";
            temp = temp + "2";
            Display();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            str = str + "3";
            temp = temp + "3";
            Display();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            str = str + "4";
            temp = temp + "4";
            Display();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            str = str + "5";
            temp = temp + "5";
            Display();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            str = str + "6";
            temp = temp + "6";
            Display();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            str = str + "7";
            temp = temp + "7";
            Display();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            str = str + "8";
            temp = temp + "8";
            Display();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            str = str + "9";
            temp = temp + "9";
            Display();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!temp.Contains("."))
            {
                str = str + ".";
                temp = temp + ".";
                Display();
            }
            
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                str = str + "+";
                temp = "";
                Display();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                str = str + "-";
                temp = ""; 
                Display();
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                str = str + "×";
                temp = "";
                Display();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                str = str + "÷";
                temp = "";
                Display();
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                str = str + "%";
                temp = "";
                Display();
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
            str = str + "(";
            Display();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            str = str + ")";
            Display();
        }

        private void lblDisplay_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
