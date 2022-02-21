using System;
using System.Windows.Forms;

namespace FirstCalculator
{
    public partial class Form1 : Form
    {
        double answer = 0;
        string operation = "  ";
        bool operationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void NormalButton_Click(object sender, EventArgs e)
        {
            if ((TxtAnswer.Text == "0") || operationPerformed == true)
            {
                TxtAnswer.Clear();
            }
            operationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!TxtAnswer.Text.Contains("."))
                {
                    TxtAnswer.Text = TxtAnswer.Text + button.Text;
                }
            }
            else
            {
                TxtAnswer.Text = TxtAnswer.Text + button.Text;
            }
        }

        private void OperratorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (answer == 0)
            {
                operation = button.Text;
                answer = double.Parse(TxtAnswer.Text);
                LblOperation.Text = answer + " " + operation;
                operationPerformed = true; 
            }
            else
            {
                BtnEquals.PerformClick();
                operation = button.Text;
                LblOperation.Text = answer + " " + operation;
                operationPerformed = true;
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtAnswer.Text = "0";
            answer = 0;
            LblOperation.Text = " ";
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            TxtAnswer.Text = "0";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "÷":
                    TxtAnswer.Text = (answer / double.Parse(TxtAnswer.Text)).ToString();
                    break;
                case "X":
                    TxtAnswer.Text = (answer * double.Parse(TxtAnswer.Text)).ToString();
                    break;
                case "+":
                    TxtAnswer.Text = (answer + double.Parse(TxtAnswer.Text)).ToString();
                    break;
                case "-":
                    TxtAnswer.Text = (answer - double.Parse(TxtAnswer.Text)).ToString();
                    break;
                default:
                    break;
            }
            LblOperation.Text = " ";
            answer = double.Parse(TxtAnswer.Text);
        }
    }
}
