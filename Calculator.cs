using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarketnew
{
    public partial class Calculator : Form
    {
        private decimal valuefirst = 0.0m;
        private decimal valuesecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (TXTBox.Text.Contains("-"))
            {
                TXTBox.Text = TXTBox.Text.Trim('-');
            }
            else
            {
                TXTBox.Text = "-" + TXTBox.Text;
            }
        }

       

        private void button1_Click_3(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valuesecond = decimal.Parse(TXTBox.Text);
                    Result = valuefirst - valuesecond;
                    TXTBox.Text = Result.ToString();
                    break;

                case "+":
                    valuesecond = decimal.Parse(TXTBox.Text);
                    Result = valuefirst + valuesecond;
                    TXTBox.Text = Result.ToString();
                    break;
                case "/":
                    valuesecond = decimal.Parse(TXTBox.Text);
                    Result = valuefirst / valuesecond;
                    TXTBox.Text = Result.ToString();
                    break;
                case "*":
                    valuesecond = decimal.Parse(TXTBox.Text);
                    Result = valuefirst * valuesecond;
                    TXTBox.Text = Result.ToString();
                    break;
                case "%":
                    valuesecond = decimal.Parse(TXTBox.Text);
                    Result = valuefirst  % valuesecond;
                    TXTBox.Text = Result.ToString();
                    break;

            }
        }

        private void ModuleBtn_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(TXTBox.Text);
            TXTBox.Clear();
            operators = "%";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(TXTBox.Text);
            TXTBox.Clear();
            operators = "*";
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TXTBox.Text == "0")
            {
                TXTBox.Text = "0";
            }
            else
            {
                TXTBox.Text += "0";
            }
        }

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            if (!TXTBox.Text.Contains("."))
            {
                TXTBox.Text += ".";
            }
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            if (TXTBox.Text == "0")
            {
                TXTBox.Text = "1";
            }
            else
            {
                TXTBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TXTBox.Text == "0")
            {
                TXTBox.Text = "2";
            }
            else
            {
                TXTBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TXTBox.Text == "0")
            {
                TXTBox.Text = "3";
            }
            else
            {
                TXTBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TXTBox.Text == "0")
            {
                TXTBox.Text = "4";
            }
            else
            {
                TXTBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TXTBox.Text == "0")
            {
                TXTBox.Text = "5";
            }
            else
            {
                TXTBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TXTBox.Text == "0")
            {
                TXTBox.Text = "6";
            }
            else
            {
                TXTBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TXTBox.Text == "0")
            {
                TXTBox.Text = "7";
            }
            else
            {
                TXTBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TXTBox.Text == "0")
            {
                TXTBox.Text = "8";
            }
            else
            {
                TXTBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TXTBox.Text == "0")
            {
                TXTBox.Text = "9";
            }
            else
            {
                TXTBox.Text += "9";
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(TXTBox.Text);
            TXTBox.Clear();
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(TXTBox.Text);
            TXTBox.Clear();
            operators = "+";
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(TXTBox.Text);
            TXTBox.Clear();
            operators = "/";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
             valuefirst = 0.0m;
             valuesecond = 0.0m;
            TXTBox.Text = "0";
    }

        private void TXTBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
