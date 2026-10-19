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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            new Task1Form().Show();
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            new Task2Form().Show();
        }

        private void btnTask3_Click(object sender, EventArgs e)
        {
            new Task3Form().Show();
        }

        private void btnTask4_Click(object sender, EventArgs e)
        {
            new Task4Form().Show();
        }

        private void btnTask5_Click(object sender, EventArgs e)
        {
            new Task5Form().Show();
        }

        private void btnTask6_Click(object sender, EventArgs e)
        {
            new Task6Form().Show();
        }

        private void btnTask7_Click(object sender, EventArgs e)
        {
            new Task7Form().Show();
        }

        private void btnTask8v1_Click(object sender, EventArgs e)
        {
            new Task8V1Form().Show();
        }

        private void btnTask8v2_Click(object sender, EventArgs e)
        {
            new Task8V2Form().Show();
        }
    }
}
