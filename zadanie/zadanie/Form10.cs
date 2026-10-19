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
    public partial class Task1Form : Form
    {
        private Random rnd = new Random();
        private int secretNumber;
        private int attempts;

        public Task1Form()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            secretNumber = rnd.Next(1, 101); 
            attempts = 0;
            lblHint.Text = "Подсказка:";
            lblAttempts.Text = "Попытки: 0";
            lblResult.Text = "";
            txtGuess.Clear();
            txtGuess.Focus();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGuess.Text, out int guess))
            {
                MessageBox.Show("Введите целое число!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            attempts++;
            lblAttempts.Text = "Попытки: " + attempts;

            if (guess == secretNumber)
            {
                lblHint.Text = "Подсказка:";
                lblResult.Text = "Вы угадали!";
                MessageBox.Show($"Вы угадали число {secretNumber} за {attempts} попыток!",
                    "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (guess < secretNumber)
            {
                lblHint.Text = "Подсказка: число больше!";
            }
            else
            {
                lblHint.Text = "Подсказка: число меньше!";
            }

            txtGuess.SelectAll();
            txtGuess.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
