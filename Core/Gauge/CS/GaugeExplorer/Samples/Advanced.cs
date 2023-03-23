using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.Gauge;

namespace SampleExplorer
{
    public partial class Advanced : UserControl
    {
        Random rnd;
        public Advanced()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            c1RadialGauge2.Value = trackBar1.Value * 0.25;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            c1RadialGauge1.Value = trackBar2.Value;
        }

        private void c1RadialGauge2_ValueChanged(object sender, EventArgs e)
        {
            double v = c1RadialGauge2.Value;
            c1RadialGauge2.Minimum = v - 15.0;
            c1RadialGauge2.Maximum = v + 15.0;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            c1LinearGauge1.Value = trackBar3.Value / 100.00;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            foreach(C1GaugePointer p in c1LinearGauge2.MorePointers)
            {
                p.Value = rnd.Next(trackBar4.Value, 100);
            }
        }
    }
}
