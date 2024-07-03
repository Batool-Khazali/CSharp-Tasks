using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_2
{
    public partial class Task_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(firstNumber.Text);
            double num2 = Convert.ToDouble(secondNumber.Text);

            double sum()
            { 
                return num1 + num2;
            }

            result.Text = sum().ToString();
        }

        protected void subtract_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(firstNumber.Text);
            double num2 = Convert.ToDouble(secondNumber.Text);

            double sub()
            {
                return num1 - num2;
            }

            result.Text = sub().ToString();
        }

        protected void multiply_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(firstNumber.Text);
            double num2 = Convert.ToDouble(secondNumber.Text);

            double multi()
            {
                return num1 * num2;
            }

            result.Text = multi().ToString();
        }

        protected void divide_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(firstNumber.Text);
            double num2 = Convert.ToDouble(secondNumber.Text);

            double divi()
            {
                return num1 / num2;
            }

            result.Text = divi().ToString();
        }
    }
}