using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using C1.Win.Sizer;

namespace GradientGallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Font = SystemInformation.MenuFont;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        double _angle = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            _angle += 0.08;
            this.c1Sizer1.Gradient.Center = new Point(
                (int)(50 + 80 * Math.Cos(_angle)),
                (int)(50 + 80 * Math.Sin(_angle)));
            this.c1Sizer4.Gradient.Center = this.c1Sizer1.Gradient.Center;
        }

        private void c1Sizer5_MouseEnter(object sender, EventArgs e)
        {
            C1Sizer sizer = sender as C1Sizer;
            sizer.BackColor = Color.Orange;
            sizer.Gradient.BackColor2 = Color.Gold;
        }
        private void c1Sizer5_MouseLeave(object sender, EventArgs e)
        {
            C1Sizer sizer = sender as C1Sizer;
            sizer.BackColor = Color.SteelBlue;
            sizer.Gradient.BackColor2 = Color.LightSteelBlue;
        }

        private void c1Sizer11_MouseEnter(object sender, EventArgs e)
        {
            C1Sizer sizer = sender as C1Sizer;
            sizer.BackColor = Color.Orange;
            sizer.Gradient.BackColor2 = Color.Gold;
        }
        private void c1Sizer11_MouseLeave(object sender, EventArgs e)
        {
            C1Sizer sizer = sender as C1Sizer;
            sizer.BackColor = Color.Silver;
            sizer.Gradient.BackColor2 = Color.DarkGray;
        }
    }
}