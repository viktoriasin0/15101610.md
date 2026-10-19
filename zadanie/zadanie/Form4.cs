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
    public partial class Task4Form : Form
    {
        public Task4Form()
        {
            InitializeComponent();
        }

        private void btnChange1_Click(object sender, EventArgs e)
        {
            btnChange1.Text = txtSource.Text;
        }

        private void btnChange2_Click(object sender, EventArgs e)
        {
            btnChange2.Text = txtSource.Text;
        }

        private void btnChange3_Click(object sender, EventArgs e)
        {
            btnChange3.Text = txtSource.Text;
        }
    }
}
