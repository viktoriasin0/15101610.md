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
    public partial class Task5Form : Form
    {
        public Task5Form()
        {
            InitializeComponent();
        }

        // Событие Load формы — прячем все метки
        private void Task5Form_Load(object sender, EventArgs e)
        {
            lblMsg1.Visible = false;
            lblMsg2.Visible = false;
            lblMsg3.Visible = false;
            lblMsg4.Visible = false;
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            lblMsg1.Visible = true;
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            lblMsg2.Visible = true;
        }

        private void btnShow3_Click(object sender, EventArgs e)
        {
            lblMsg3.Visible = true;
        }

        private void btnShow4_Click(object sender, EventArgs e)
        {
            lblMsg4.Visible = true;
        }
    }
}
