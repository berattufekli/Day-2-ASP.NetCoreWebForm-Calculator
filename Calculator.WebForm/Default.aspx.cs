using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator.WebForm
{
    public partial class Default : System.Web.UI.Page
    {
        double num1, num2, sonuc;

        static string islem;

        static private bool firstNumSelected = false;
        static private bool secondNumSelected = false;


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (!firstNumSelected || islem == null)
            {
                resultNum1.Text += button.Text;
            }
            else
            {
                resultNum2.Text += button.Text;
                secondNumSelected = true;
            }
        }

        protected void Plus_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                islem = "+";
                resultOp.Text = "+";
                firstNumSelected = true;
            }
            else if (firstNumSelected && islem != "+" && !secondNumSelected)
            {
                islem = "+";
                resultOp.Text = islem;
            }
            else if (firstNumSelected && islem == "+" && secondNumSelected)
            {
                num1 = Convert.ToDouble(resultNum1.Text);
                num2 = Convert.ToDouble(resultNum2.Text);
                sonuc = Plus(num1, num2);

                previousNum1.Text = resultNum1.Text;
                previousOp.Text = resultOp.Text;
                previousNum2.Text = resultNum2.Text;

                resultNum1.Text = sonuc.ToString();
                resultOp.Text = islem;
                resultNum2.Text = "";
                secondNumSelected = false;
            }

        }

        protected void Minus_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                islem = "-";
                resultOp.Text = "-";
                firstNumSelected = true;
            }
            else if (firstNumSelected && islem != "-" && !secondNumSelected)
            {
                islem = "-";
                resultOp.Text = islem;
            }
            else if (firstNumSelected && islem == "-" && secondNumSelected)
            {
                num1 = Convert.ToDouble(resultNum1.Text);
                num2 = Convert.ToDouble(resultNum2.Text);
                sonuc = Minus(num1, num2);

                previousNum1.Text = resultNum1.Text;
                previousOp.Text = resultOp.Text;
                previousNum2.Text = resultNum2.Text;

                resultNum1.Text = sonuc.ToString();
                resultOp.Text = islem;
                resultNum2.Text = "";
                secondNumSelected = false;
            }
        }

        protected void Equals_Click(object sender, EventArgs e)
        {
            if(firstNumSelected && secondNumSelected && islem != null)
            {
                num1 = Convert.ToDouble(resultNum1.Text);
                num2 = Convert.ToDouble(resultNum2.Text);

                if (islem == "+")
                {
                    num1 = Convert.ToDouble(resultNum1.Text);
                    num2 = Convert.ToDouble(resultNum2.Text);
                    sonuc = Plus(num1, num2);

                    previousNum1.Text = resultNum1.Text;
                    previousOp.Text = resultOp.Text;
                    previousNum2.Text = resultNum2.Text;

                    resultNum1.Text = sonuc.ToString();
                }
                else if (islem == "-")
                {
                    num1 = Convert.ToDouble(resultNum1.Text);
                    num2 = Convert.ToDouble(resultNum2.Text);
                    sonuc = Minus(num1, num2);

                    previousNum1.Text = resultNum1.Text;
                    previousOp.Text = resultOp.Text;
                    previousNum2.Text = resultNum2.Text;

                    resultNum1.Text = sonuc.ToString();
                }
                else if (islem == "x")
                {
                    num1 = Convert.ToDouble(resultNum1.Text);
                    num2 = Convert.ToDouble(resultNum2.Text);
                    sonuc = Multiply(num1, num2);

                    previousNum1.Text = resultNum1.Text;
                    previousOp.Text = resultOp.Text;
                    previousNum2.Text = resultNum2.Text;

                    resultNum1.Text = sonuc.ToString();
                }
                else if (islem == "/")
                {
                    if (resultNum2.Text != "0")
                    {
                        num1 = Convert.ToDouble(resultNum1.Text);
                        num2 = Convert.ToDouble(resultNum2.Text);
                        sonuc = Divide(num1, num2);

                        previousNum1.Text = resultNum1.Text;
                        previousOp.Text = resultOp.Text;
                        previousNum2.Text = resultNum2.Text;

                        resultNum1.Text = sonuc.ToString();
                        resultOp.Text = islem;
                        resultNum2.Text = "";
                        secondNumSelected = false;
                    }
                    else
                    {
                        previousNum1.Text = "Please try again.";
                        resultNum1.Text = "";
                        resultOp.Text = "";
                        resultNum2.Text = "";
                        firstNumSelected = false;
                        islem = "";
                    }
                }
                else if(islem == "%")
                {
                    num1 = Convert.ToDouble(resultNum1.Text);
                    num2 = Convert.ToDouble(resultNum2.Text);
                    sonuc = Mod(num1, num2);

                    previousNum1.Text = resultNum1.Text;
                    previousOp.Text = resultOp.Text;
                    previousNum2.Text = resultNum2.Text;

                    resultNum1.Text = sonuc.ToString();
                }

                resultOp.Text = "";
                resultNum2.Text = "";
                secondNumSelected = false;
                islem = "";
                firstNumSelected = false;
            }
        }

        protected void Multiply_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                islem = "x";
                resultOp.Text = "x";
                firstNumSelected = true;
            }
            else if (firstNumSelected && islem != "x" && !secondNumSelected)
            {
                islem = "x";
                resultOp.Text = islem;
            }
            else if (firstNumSelected && islem == "x" && secondNumSelected)
            {
                num1 = Convert.ToDouble(resultNum1.Text);
                num2 = Convert.ToDouble(resultNum2.Text);
                sonuc = Multiply(num1, num2);

                previousNum1.Text = resultNum1.Text;
                previousOp.Text = resultOp.Text;
                previousNum2.Text = resultNum2.Text;

                resultNum1.Text = sonuc.ToString();
                resultOp.Text = islem;
                resultNum2.Text = "";
                secondNumSelected = false;
            }
        }

        protected void Divide_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                islem = "/";
                resultOp.Text = "/";
                firstNumSelected = true;
            }
            else if (firstNumSelected && islem != "/" && !secondNumSelected)
            {
                islem = "/";
                resultOp.Text = islem;
            }
            else if (firstNumSelected && islem == "/" && secondNumSelected)
            {
                if(resultNum2.Text != "0")
                {
                    num1 = Convert.ToDouble(resultNum1.Text);
                    num2 = Convert.ToDouble(resultNum2.Text);
                    sonuc = Divide(num1, num2);

                    previousNum1.Text = resultNum1.Text;
                    previousOp.Text = resultOp.Text;
                    previousNum2.Text = resultNum2.Text;

                    resultNum1.Text = sonuc.ToString();
                    resultOp.Text = islem;
                    resultNum2.Text = "";
                    secondNumSelected = false;
                }
                else
                {
                    previousNum1.Text = "Please try again.";
                    resultNum1.Text = "";
                    resultOp.Text = "";
                    resultNum2.Text = "";
                    firstNumSelected = false;
                    islem = "";
                }
            }
        }

        protected void Mod_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                islem = "%";
                resultOp.Text = "%";
                firstNumSelected = true;
            }
            else if (firstNumSelected && islem != "%" && !secondNumSelected)
            {
                islem = "%";
                resultOp.Text = islem;
            }
            else if (firstNumSelected && islem == "%" && secondNumSelected)
            {
                num1 = Convert.ToDouble(resultNum1.Text);
                num2 = Convert.ToDouble(resultNum2.Text);
                sonuc = Mod(num1, num2);

                previousNum1.Text = resultNum1.Text;
                previousOp.Text = resultOp.Text;
                previousNum2.Text = resultNum2.Text;

                resultNum1.Text = sonuc.ToString();
                resultOp.Text = islem;
                resultNum2.Text = "";
                secondNumSelected = false;
            }
        }

        protected void Negative_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected && resultNum1.Text.Length > 0)
            {
                resultNum1.Text = (Convert.ToDouble(resultNum1.Text) * (-1)).ToString();
            }
            else if(!firstNumSelected && resultNum1.Text.Length == 0)
            {
                resultNum1.Text += "-";
            }
            else if(firstNumSelected && resultNum2.Text.Length > 0)
            {
                resultNum2.Text = (Convert.ToDouble(resultNum2.Text) * (-1)).ToString();
            }
            else if(firstNumSelected && resultNum2.Text.Length == 0)
            {
                resultNum2.Text += "-";
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            islem = "";
            resultNum1.Text = "";
            resultNum2.Text = "";
            resultOp.Text = "";
            previousNum1.Text = "";
            previousNum2.Text = "";
            previousOp.Text = "";
            firstNumSelected = false;
            secondNumSelected = false;
        }

        protected void Del_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected && resultNum1.Text.Length > 0)
            {
                resultNum1.Text = resultNum1.Text.Substring(0, resultNum1.Text.Length - 1);
            }
            else if(resultNum2.Text.Length>0)
            {
                resultNum2.Text = resultNum2.Text.Substring(0, resultNum2.Text.Length - 1);
            }
            else if(resultNum2.Text.Length == 0)
            {
                resultOp.Text = "";
                secondNumSelected = false;
                firstNumSelected = false;
                islem = null;
            }
            
            
        }

        protected void Comma_Click(object sender, EventArgs e)
        {
            if(!firstNumSelected && resultNum1.Text.Length > 0)
            {
                resultNum1.Text += ",";
            }
            else if(firstNumSelected && resultNum2.Text.Length > 0)
            {
                resultNum2.Text += ",";
            }
        }

        public double Plus(double mum1, double num2)
        {
            return mum1 + num2;
        }

        public double Minus(double mum1, double num2)
        {
            return mum1 - num2;
        }


        public double Multiply(double mum1, double num2)
        {
            return mum1 * num2;
        }

        public double Divide(double mum1, double num2)
        {
            
             return mum1 / num2;
                        
        }

        public double Mod(double mum1, double num2)
        { 
            return mum1 % num2;
        }


    }
}