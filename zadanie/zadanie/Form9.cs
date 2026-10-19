using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie
{
    public partial class Task8V2Form : Form
    {
        private double firstOperand = 0;
        private string currentOperation = "";
        private bool isNewEntry = true;

        public Task8V2Form()
        {
            InitializeComponent();
        }

        // Ввод цифр
        private void Digit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewEntry || txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
                isNewEntry = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        // Ввод операции (+, -, *, /)
        private void Operation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!double.TryParse(txtDisplay.Text, out double value))
            {
                MessageBox.Show("Ошибка ввода числа!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Если уже была операция — сначала посчитаем промежуточный результат
            if (currentOperation != "" && !isNewEntry)
            {
                if (!Calculate(value)) return;
            }

            firstOperand = double.Parse(txtDisplay.Text);
            currentOperation = btn.Text;
            isNewEntry = true;
        }

        // Кнопка "="
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (currentOperation == "")
                return;

            if (!double.TryParse(txtDisplay.Text, out double secondOperand))
            {
                MessageBox.Show("Ошибка ввода числа!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Calculate(secondOperand);
            currentOperation = "";
            isNewEntry = true;
        }

        // Общий метод вычисления
        private bool Calculate(double secondOperand)
        {
            double result = 0;

            switch (currentOperation)
            {
                case "+":
                    result = firstOperand + secondOperand;
                    break;
                case "-":
                    result = firstOperand - secondOperand;
                    break;
                case "*":
                    result = firstOperand * secondOperand;
                    break;
                case "/":
                    if (secondOperand == 0)
                    {
                        MessageBox.Show("Деление на 0 невозможно!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDisplay.Text = "0";
                        currentOperation = "";
                        isNewEntry = true;
                        return false;
                    }
                    result = firstOperand / secondOperand;
                    break;
                default:
                    return false;
            }

            txtDisplay.Text = result.ToString();
            firstOperand = result;
            return true;
        }

        // Кнопка "Стереть"
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstOperand = 0;
            currentOperation = "";
            isNewEntry = true;
        }
    }
}
