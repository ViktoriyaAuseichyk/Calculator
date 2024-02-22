using System;

namespace Calculator
{
    public class Presenter
    {
        private Form1 form1;
        private Model model;
        public Presenter(Form1 form1)
        {
            this.form1 = form1;
            model = new Model();
            form1.Plus += ViewPlus;
            form1.Minus += ViewMinus;
            form1.Multiplication += ViewMultiplication;
            form1.Division += ViewDivision;
            form1.Zero += ViewZero;
            form1.One += ViewOne;
            form1.Two += ViewTwo;
            form1.Three += ViewThree;
            form1.Four += ViewFour;
            form1.Five += ViewFive;
            form1.Six += ViewSix;
            form1.Seven += ViewSeven;
            form1.Eight += ViewEight;
            form1.Nine += ViewNine;
            form1.Point += ViewPoint;
            form1.Equally += ViewEqually;
            form1.Clear += ViewClear;
            form1.DeleteChar += ViewDeleteChar;
            form1.PlusOrMinus += ViewPlusOrMinus;
        }

        public void ViewFigure(string figure)
        {
            if (form1.ResultTextBox.Text.Length == 0)
            {
                if (this.form1.ExpressionOperatorTextBox.Text.Length == 0)
                {
                    if (this.form1.FirstTextBox.Text.Length != 12)
                    {
                        this.form1.FirstTextBox.Text = this.form1.FirstTextBox.Text + figure;
                    }
                    else
                    {
                        ;
                    }
                }
                else
                {
                    if (this.form1.SecondTextBox.Text.Length != 12)
                    {
                        this.form1.SecondTextBox.Text = this.form1.SecondTextBox.Text + figure;
                    }
                    else
                    {
                        ;
                    }
                }
            }
            else
            {
                ;
            }
        }
        public void ViewOperator(string oper)
        {
            if (this.form1.ExpressionOperatorTextBox.Text.Length == 0)
            {
                this.form1.ExpressionOperatorTextBox.Text = oper;
            }
            else
            {
                ;
            }

            if (this.form1.ResultTextBox.Text.Length != 0)
            {
                this.form1.FirstTextBox.Text = form1.ResultTextBox.Text;
                this.form1.ExpressionOperatorTextBox.Text = oper;
                this.form1.SecondTextBox.Clear();
                this.form1.ResultTextBox.Clear();
            }
        }

        public void ViewPlus(object sender, EventArgs e)
        {
            ViewOperator("+");
        }
        public void ViewMinus(object sender, EventArgs e)
        {
            ViewOperator("-");
        }
        public void ViewMultiplication(object sender, EventArgs e)
        {
            ViewOperator("*");
        }
        public void ViewDivision(object sender, EventArgs e)
        {
            ViewOperator("/");
        }
        public void ViewZero(object sender, EventArgs e)
        {
            ViewFigure("0");
        }
        public void ViewOne(object sender, EventArgs e)
        {
            ViewFigure("1");
        }
        public void ViewTwo(object sender, EventArgs e)
        {
            ViewFigure("2");
        }
        public void ViewThree(object sender, EventArgs e)
        {
            ViewFigure("3");
        }
        public void ViewFour(object sender, EventArgs e)
        {
            ViewFigure("4");
        }
        public void ViewFive(object sender, EventArgs e)
        {
            ViewFigure("5");
        }
        public void ViewSix(object sender, EventArgs e)
        {
            ViewFigure("6");
        }
        public void ViewSeven(object sender, EventArgs e)
        {
            ViewFigure("7");
        }
        public void ViewEight(object sender, EventArgs e)
        {
            ViewFigure("8");
        }
        public void ViewNine(object sender, EventArgs e)
        {
            ViewFigure("9");
        }
        public void ViewPoint(object sender, EventArgs e)
        {
            if (form1.ResultTextBox.Text.Length == 0)
            {
                if (this.form1.ExpressionOperatorTextBox.Text.Length == 0)
                {
                    if (this.form1.FirstTextBox.Text.Length != 12)
                    {
                        if (this.form1.FirstTextBox.Text.Length != 0)
                        {
                            if (this.form1.FirstTextBox.Text.IndexOf(',') == -1)
                            {
                                this.form1.FirstTextBox.Text = this.form1.FirstTextBox.Text + ",";
                            }
                            else
                            {
                                ;
                            }
                        }
                        else
                        {
                            ;
                        }
                    }
                    else
                    {
                        ;
                    }
                }
                else
                {
                    if (this.form1.SecondTextBox.Text.Length != 12)
                    {
                        if (this.form1.SecondTextBox.Text.Length != 0)
                        {
                            if (this.form1.SecondTextBox.Text.IndexOf(',') == -1)
                            {
                                this.form1.SecondTextBox.Text = this.form1.SecondTextBox.Text + ",";
                            }
                            else
                            {
                                ;
                            }
                        }
                        else
                        {
                            ;
                        }
                    }
                    else
                    {
                        ;
                    }
                }
            }
            else
            {
                ;
            }
        }
        public void ViewEqually(object sender, EventArgs e)
        {
            if (form1.ExpressionOperatorTextBox.Text.Length != 0)
            {
                string oper = form1.ExpressionOperatorTextBox.Text;
                string result;

                switch (oper)
                {
                    case "+":
                        {
                            result = model.Add(Convert.ToSingle(form1.FirstTextBox.Text), Convert.ToSingle(form1.SecondTextBox.Text));
                            form1.ResultTextBox.Text = Convert.ToString(result);
                            break;
                        }
                    case "-":
                        {
                            result = model.Sub(Convert.ToSingle(form1.FirstTextBox.Text), Convert.ToSingle(form1.SecondTextBox.Text));
                            form1.ResultTextBox.Text = Convert.ToString(result);
                            break;
                        }
                    case "*":
                        {
                            result = model.Multi(Convert.ToSingle(form1.FirstTextBox.Text), Convert.ToSingle(form1.SecondTextBox.Text));
                            form1.ResultTextBox.Text = Convert.ToString(result);
                            break;
                        }
                    case "/":
                        {
                            result = model.Div(Convert.ToSingle(form1.FirstTextBox.Text), Convert.ToSingle(form1.SecondTextBox.Text));
                            form1.ResultTextBox.Text = Convert.ToString(result);
                            break;
                        }
                    default:
                        {
                            result = "ERROR";
                            form1.ResultTextBox.Text = result;
                            break;
                        }
                }
            }
        }
        public void ViewClear(object sender, EventArgs e)
        {
            this.form1.FirstTextBox.Clear();
            this.form1.SecondTextBox.Clear();
            this.form1.ResultTextBox.Clear();
            this.form1.ExpressionOperatorTextBox.Clear();
        }
        public void ViewDeleteChar(object sender, EventArgs e)
        {
            if (form1.ResultTextBox.Text.Length == 0)
            {
                if (this.form1.ExpressionOperatorTextBox.Text.Length == 0)
                {
                    if (this.form1.FirstTextBox.Text.Length != 0)
                    {
                        this.form1.FirstTextBox.Text = this.form1.FirstTextBox.Text.Remove(form1.FirstTextBox.Text.Length - 1);
                    }
                    else
                    {
                        ;
                    }
                }
                else
                {
                    if (this.form1.SecondTextBox.Text.Length != 0)
                    {
                        this.form1.SecondTextBox.Text = this.form1.SecondTextBox.Text.Remove(form1.SecondTextBox.Text.Length - 1);
                    }
                    else
                    {
                        ;
                    }
                }
            }
            else
            {
                ;
            }
        }
        public void ViewPlusOrMinus(object sender, EventArgs e)
        {
            if (form1.ResultTextBox.Text.Length == 0)
            {
                if (this.form1.ExpressionOperatorTextBox.Text.Length == 0)
                {
                    if (this.form1.FirstTextBox.Text.IndexOf('-') == -1)
                    {
                        this.form1.FirstTextBox.Text = this.form1.FirstTextBox.Text.Insert(0, "-");
                    }
                    else
                    {
                        this.form1.FirstTextBox.Text = this.form1.FirstTextBox.Text.Remove(this.form1.FirstTextBox.Text.IndexOf('-'), this.form1.FirstTextBox.Text.IndexOf('-') + 1);
                    }
                }
                else
                {
                    if (this.form1.SecondTextBox.Text.IndexOf('-') == -1)
                    {
                        this.form1.SecondTextBox.Text = this.form1.SecondTextBox.Text.Insert(0, "-");
                    }
                    else
                    {
                        this.form1.SecondTextBox.Text = this.form1.SecondTextBox.Text.Remove(this.form1.SecondTextBox.Text.IndexOf('-'), this.form1.SecondTextBox.Text.IndexOf('-') + 1);
                    }
                }
            }
            else
            {
                ;
            }

        }
    }
}

