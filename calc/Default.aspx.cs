using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string rootCheck(string given)
    {
        if (given.Contains("√"))
        {
            double x = double.Parse(given.Substring(1));
            given = Math.Sqrt(x).ToString();
        } 
        return given;
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnNum0_Click(object sender, EventArgs e)
    {
        if (txtLCD.Text != "0")
        {
            txtLCD.Text += "0";
        }
    }
    protected void btnNum1_Click(object sender, EventArgs e)
    {
        if (txtLCD.Text == "0")
        {
            txtLCD.Text = "1";
        }
        else
        {
            txtLCD.Text += "1";
        }
    }
    protected void btnNum2_Click(object sender, EventArgs e)
    {
        if (txtLCD.Text == "0")
        {
            txtLCD.Text = "2";
        }
        else
        {
            txtLCD.Text += "2";
        }
    }
    protected void btnNum3_Click(object sender, EventArgs e)
    {
        if (txtLCD.Text == "0")
        {
            txtLCD.Text = "3";
        }
        else
        {
            txtLCD.Text += "3";
        }
    }
    protected void btnNum4_Click(object sender, EventArgs e)
    {
        if (txtLCD.Text == "0")
        {
            txtLCD.Text = "4";
        }
        else
        {
            txtLCD.Text += "4";
        }
    }
    protected void btnNum5_Click(object sender, EventArgs e)
    {
        if (txtLCD.Text == "0")
        {
            txtLCD.Text = "5";
        }
        else
        {
            txtLCD.Text += "5";
        }
    }
    protected void btnNum6_Click(object sender, EventArgs e)
    {
        if (txtLCD.Text == "0")
        {
            txtLCD.Text = "6";
        }
        else
        {
            txtLCD.Text += "6";
        }
    }
    protected void btnNum7_Click(object sender, EventArgs e)
    {
        if (txtLCD.Text == "0")
        {
            txtLCD.Text = "7";
        }
        else
        {
            txtLCD.Text += "7";
        }
    }
    protected void btnNum8_Click(object sender, EventArgs e)
    {
        if (txtLCD.Text == "0")
        {
            txtLCD.Text = "8";
        }
        else
        {
            txtLCD.Text += "8";
        }
    }
    protected void btnNum9_Click(object sender, EventArgs e)
    {
        if (txtLCD.Text == "0")
        {
            txtLCD.Text = "9";
        }
        else
        {
            txtLCD.Text += "9";
        }
    }
    protected void btnPoint_Click(object sender, EventArgs e)
    {
        if (!txtLCD.Text.Contains("."))
        {
            txtLCD.Text += ".";
        }
    }
    protected void btnPlus_Click(object sender, EventArgs e)
    {
        Session["num1"] = rootCheck(txtLCD.Text);
        Session["operand"] = "+";
        txtLCD.Text = "0";
        lblOperand.Text = "+";
    }
    protected void btnMinus_Click(object sender, EventArgs e)
    {
        Session["num1"] = rootCheck(txtLCD.Text);
        Session["operand"] = "-";
        txtLCD.Text = "0";
        lblOperand.Text = "-";
    }
    protected void btnMulti_Click(object sender, EventArgs e)
    {
        Session["num1"] = rootCheck(txtLCD.Text);
        Session["operand"] = "*";
        txtLCD.Text = "0";
        lblOperand.Text = "X";
    }
    protected void btnDivide_Click(object sender, EventArgs e)
    {
        Session["num1"] = rootCheck(txtLCD.Text);
        Session["operand"] = "/";
        txtLCD.Text = "0";
        lblOperand.Text = "÷";
    }
    protected void btnEqual_Click(object sender, EventArgs e)
    {
        //declare answer variable
        double answer = 0;

        //check if there's a number to calcuate against
        if (Session["num1"] != null)
        {
            Session["num2"] = rootCheck(txtLCD.Text);
            double dblNum1 = Double.Parse(Session["num1"].ToString());
            double dblNum2 = Double.Parse(Session["num2"].ToString());

            //swtich case of the propper operations
            string op = Session["operand"].ToString();
            switch (op)
            {
                //addition
                case "+":
                    answer = dblNum1 + dblNum2;
                    Session["num1"].Equals(null);
                    Session["num2"].Equals(null);
                    break;
                //subtraction
                case "-":
                    answer = dblNum1 - dblNum2;
                    Session["num1"].Equals(null);
                    Session["num2"].Equals(null);
                    break;
                //multiplication
                case "*":
                    answer = dblNum1 * dblNum2;
                    Session["num1"].Equals(null);
                    Session["num2"].Equals(null);
                    break;
                //division
                case "/":
                    //if user decides to divide by 0
                    if (Session["num2"].ToString() == "0")
                    {
                        txtLCD.Text = "ERR";
                    }
                    else
                    {
                        answer = dblNum1 / dblNum2;
                        Session["num1"].Equals(null);
                        Session["num2"].Equals(null);
                    }
                    break;
            }
            if (!txtLCD.Text.Contains("ERR"))
            {
                txtLCD.Text = answer.ToString();
                lblOperand.Text = "";
            }
        }
    }
    protected void btnSMem_Click(object sender, EventArgs e)
    {
        Session["mem"] = txtLCD.Text;
        lblMemory.Text = "M";
        txtLCD.Text = "";
    }
    protected void btnCMem_Click(object sender, EventArgs e)
    {
        Session["mem"] = "";
        lblMemory.Text = "";
    }
    protected void btnRMem_Click(object sender, EventArgs e)
    {
        txtLCD.Text = Session["mem"].ToString();
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        Session["mem"] = null;
        Session["num1"] = null;
        Session["num2"] = null;
        lblMemory.Text = "";
        lblOperand.Text = "";
        txtLCD.Text = "0";
    }
    protected void btnNegPos_Click(object sender, EventArgs e)
    {
        double given = double.Parse(txtLCD.Text);
        if (given < 0)
        {
            given = given * -1;
            txtLCD.Text = given.ToString();
        }
        else
        {
            txtLCD.Text = '-' + given.ToString();
        }
    }
    protected void btnPercent_Click(object sender, EventArgs e)
    {
        //I don't know why I've added this button. This button is never reliable I find.
        //Addition and subtraction make some sense I guess, multiplication and division is a mystery.

        //check if there's a number to calcuate against
        if (Session["num1"] != null)
        {
            double dblNum1 = Double.Parse(Session["num1"].ToString());
            double dblNum2 = Double.Parse(txtLCD.Text);
            dblNum2 = (dblNum1 * dblNum2) / 100;
            txtLCD.Text = dblNum2.ToString();
        }
    }
    protected void btnPi_Click(object sender, EventArgs e)
    {
        txtLCD.Text = Math.PI.ToString();
    }
    protected void btnSquareR_Click(object sender, EventArgs e)
    {
        if (txtLCD.Text == "0")
        {
            txtLCD.Text = "√";
        }
    }
}