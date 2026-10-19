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
    public partial class Task8V1Form : Form
    {
        public Task8V1Form()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Проверка ввода чисел
            if (!double.TryParse(txtNum1.Text, out double a))
            {
                MessageBox.Show("Число 1 введено неверно!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtNum2.Text, out double b))
            {
                MessageBox.Show("Число 2 введено неверно!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string op = txtOp.Text.Trim();
            double result = 0;

            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("Деление на 0 невозможно!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = a / b;
                    break;
                default:
                    MessageBox.Show("Неизвестная операция. Используйте +, -, *, /",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            txtAnswer.Text = result.ToString();
        }
    }
}

