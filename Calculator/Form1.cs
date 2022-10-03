namespace Calculator
{
    public partial class OperaterDisplay : Form
    { 
        public double number { get; set; }
        public string symbol { get; set; }
        public OperaterDisplay()
        {
            InitializeComponent();
        }
        private void NumberDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            NumberDisplay.Text = NumberDisplay.Text + "0";
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            NumberDisplay.Text = NumberDisplay.Text + "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            NumberDisplay.Text = NumberDisplay.Text + "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            NumberDisplay.Text = NumberDisplay.Text + "3";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            NumberDisplay.Text = NumberDisplay.Text + "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            NumberDisplay.Text = NumberDisplay.Text + "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            NumberDisplay.Text = NumberDisplay.Text + "6";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            NumberDisplay.Text = NumberDisplay.Text + "7";
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            NumberDisplay.Text = NumberDisplay.Text + "8";
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            NumberDisplay.Text = NumberDisplay.Text + "9";
        }
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (!NumberDisplay.Text.Contains("."))
            {
                NumberDisplay.Text = NumberDisplay.Text + ".";
            } 
        }

        private void Percentagebutton_Click(object sender, EventArgs e)
        {
           
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
           
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NumberDisplay.Text != "")
            {
                SymbolDisplay.Text = "+";
                symbol = "+";
                number = Double.Parse(NumberDisplay.Text);
                NumberDisplay.Text = "";
            }

        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (NumberDisplay.Text != "")
            {
                SymbolDisplay.Text = "-";
                symbol = "-";
                number = Double.Parse(NumberDisplay.Text);
                NumberDisplay.Text = "";
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (NumberDisplay.Text != "")
            {
                SymbolDisplay.Text = "*";
                symbol = "*";
                number = Double.Parse(NumberDisplay.Text);
                NumberDisplay.Text = "";
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (NumberDisplay.Text != "")
            {
                SymbolDisplay.Text = "/";
                symbol = "/";
                number = Double.Parse(NumberDisplay.Text);
                NumberDisplay.Text = "";
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            switch (symbol)
            {
                case "+":
                    NumberDisplay.Text = (number + Double.Parse(NumberDisplay.Text)).ToString();
                    break;
                case "-":
                    NumberDisplay.Text = (number - Double.Parse(NumberDisplay.Text)).ToString();
                    break;
                case "*":
                    NumberDisplay.Text = (number * Double.Parse(NumberDisplay.Text)).ToString();
                    break;
                case "/":
                    NumberDisplay.Text = (number / Double.Parse(NumberDisplay.Text)).ToString();
                    break;
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NumberDisplay.Text = "";
            number = 0;
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
        }

        private void SymbolDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}