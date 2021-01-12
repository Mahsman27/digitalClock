using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            lblTime.Text = DateTime.Now.ToString("t");
            lblSeconds.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM, dd yyyy");
            lblDays.Text = DateTime.Now.ToString("dddd");

            btnClose.TabStop = false;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
