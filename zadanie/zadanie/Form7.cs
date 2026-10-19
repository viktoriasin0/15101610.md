using System;
using System.IO;
using System.Windows.Forms;

namespace zadanie
{
    public partial class Task7Form : Form
    {
        public Task7Form()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtNote.Text);
                    MessageBox.Show("Заметка сохранена!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Открыть заметку";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string loadedText = File.ReadAllText(openFileDialog.FileName);
                    txtNote.Clear();
                    txtNote.Text = loadedText;
                    MessageBox.Show("Заметка загружена!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}