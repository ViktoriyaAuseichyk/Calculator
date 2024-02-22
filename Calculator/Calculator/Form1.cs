using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private EventHandler plus;
        private EventHandler minus;
        private EventHandler multiplication;
        private EventHandler division;
        private EventHandler zero;
        private EventHandler one;
        private EventHandler two;
        private EventHandler three;
        private EventHandler four;
        private EventHandler five;
        private EventHandler six;
        private EventHandler seven;
        private EventHandler eight;
        private EventHandler nine;
        private EventHandler point;
        private EventHandler equally;
        private EventHandler clear;
        private EventHandler deleteChar;
        private EventHandler plusOrMinus;


        public event EventHandler Plus
        {
            add { plus += value; }
            remove { plus -= value; }
        }
        public event EventHandler Minus
        {
            add { minus += value; }
            remove { minus -= value; }
        }
        public event EventHandler Multiplication
        {
            add { multiplication += value; }
            remove { multiplication -= value; }
        }
        public event EventHandler Division
        {
            add { division += value; }
            remove { division -= value; }
        }
        public event EventHandler Zero
        {
            add { zero += value; }
            remove { zero -= value; }
        }
        public event EventHandler One
        {
            add { one += value; }
            remove { one -= value; }
        }
        public event EventHandler Two
        {
            add { two += value; }
            remove { two -= value; }
        }
        public event EventHandler Three
        {
            add { three += value; }
            remove { three -= value; }
        }
        public event EventHandler Four
        {
            add { four += value; }
            remove { four -= value; }
        }
        public event EventHandler Five
        {
            add { five += value; }
            remove { five -= value; }
        }
        public event EventHandler Six
        {
            add { six += value; }
            remove { six -= value; }
        }
        public event EventHandler Seven
        {
            add { seven += value; }
            remove { seven -= value; }
        }
        public event EventHandler Eight
        {
            add { eight += value; }
            remove { eight -= value; }
        }
        public event EventHandler Nine
        {
            add { nine += value; }
            remove { nine -= value; }
        }
        public event EventHandler Point
        {
            add { point += value; }
            remove { point -= value; }
        }
        public event EventHandler Equally
        {
            add { equally += value; }
            remove { equally -= value; }
        }
        public event EventHandler Clear
        {
            add { clear += value; }
            remove { clear -= value; }
        }
        public event EventHandler DeleteChar
        {
            add { deleteChar += value; }
            remove { deleteChar -= value; }
        }
        public event EventHandler PlusOrMinus
        {
            add { plusOrMinus += value; }
            remove { plusOrMinus -= value; }
        }


        private void PlusButton_Click(object sender, EventArgs e)
        {
            plus(sender, e);
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            minus(sender, e);
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            multiplication(sender, e);
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            division(sender, e);
        }
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            zero(sender, e);
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            one(sender, e);
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            two(sender, e);
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            three(sender, e);
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            four(sender, e);
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            five(sender, e);
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            six(sender, e);
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            seven(sender, e);
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            eight(sender, e);
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            nine(sender, e);
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            point(sender, e);
        }

        private void EquallyButton_Click(object sender, EventArgs e)
        {
            equally(sender, e);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clear(sender, e);
        }

        private void DeleteCharButton_Click(object sender, EventArgs e)
        {
            deleteChar(sender, e);
        }

        private void PlusOrMinusButton_Click(object sender, EventArgs e)
        {
            plusOrMinus(sender, e);
        }

    }
}
