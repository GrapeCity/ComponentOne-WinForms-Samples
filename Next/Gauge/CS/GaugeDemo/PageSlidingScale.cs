using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GaugeDemo
{
    public partial class PageSlidingScale : BaseGaugePage
    {
        public PageSlidingScale()
        {
            InitializeComponent();
        }

        private void c1RadialGauge1_ValueChanged(object sender, EventArgs e)
        {
            double v = c1RadialGauge1.Value;
            c1RadialGauge1.Minimum = v - 15.0;
            c1RadialGauge1.Maximum = v + 15.0;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            c1RadialGauge1.Value = trackBar1.Value * 0.25;
        }
    }
}
