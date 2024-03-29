using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static double a = 0, b = 0, result = 0;
        static string whichOperator = "";

        #region Numbers
        protected void AddNumber(string sayi)
        {
            Calc.Text += sayi;
        }
        protected void ButtonNum1_Click(object sender, EventArgs e)
        {
            AddNumber("1");
        }

        protected void ButtonNum2_Click(object sender, EventArgs e)
        {
            AddNumber("2");
        }

        protected void ButtonNum3_Click(object sender, EventArgs e)
        {
            AddNumber("3");
        }

        protected void ButtonNum4_Click(object sender, EventArgs e)
        {
            AddNumber("4");
        }

        protected void ButtonNum5_Click(object sender, EventArgs e)
        {
            AddNumber("5");
        }

        protected void ButtonNum6_Click(object sender, EventArgs e)
        {
            AddNumber("6");
        }

        protected void ButtonNum7_Click(object sender, EventArgs e)
        {
            AddNumber("7");
        }

        protected void ButtonNum8_Click(object sender, EventArgs e)
        {
            AddNumber("8");
        }

        protected void ButtonNum9_Click(object sender, EventArgs e)
        {
            AddNumber("9");
        }

        protected void ButtonNum0_Click(object sender, EventArgs e)
        {
            AddNumber("0");
        }
        #endregion

        #region Operators
        protected void ButtonEqualTo_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(Calc.Text);
            switch(whichOperator)
            {
                case "Plus":
                    ValuesText.Text = $"{a} + {b} = {a + b}";
                    break;
                case "Minus":
                    ValuesText.Text = $"{a} - {b} = {a - b}";
                    break;
                case "Multi":
                    ValuesText.Text = $"{a} x {b} = {a * b}";
                    break;
                case "Split":
                    ValuesText.Text = $"{a} / {b} = {a / b}";
                    break;
            }    
            Calc.Text = "";
            a = 0;
            b = 0;
        }
        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
            a += Convert.ToDouble(Calc.Text);
            ValuesText.Text = $"{a} + ";
            whichOperator = "Plus";
            Calc.Text = "";
        }
        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            a += Convert.ToDouble(Calc.Text);
            ValuesText.Text = $"{a} - ";
            whichOperator = "Minus";
            Calc.Text = "";
        }
        protected void ButtonSplit_Click(object sender, EventArgs e)
        {
            a += Convert.ToDouble(Calc.Text);
            ValuesText.Text = $"{a} / ";
            whichOperator = "Split";
            Calc.Text = "";
        }
        protected void ButtonNumMultiple_Click(object sender, EventArgs e)
        {
            a += Convert.ToDouble(Calc.Text);
            ValuesText.Text = $"{a} x ";
            whichOperator = "Multi";
            Calc.Text = "";
        }
        protected void ButtonC_Click(object sender, EventArgs e)
        {
            Calc.Text = "";
            ValuesText.Text = "0";
            a = 0;
            b = 0;
        }
        #endregion
    }
}