using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using C1.Win.Gauge;

namespace GaugeDemo
{
    public partial class PageCircularProgress : BaseGaugePage
    {
        public PageCircularProgress()
        {
            InitializeComponent();

            trackBar1.Value = (int)(c1RadialGauge1.MorePointers[0].Value + 0.5);
            trackBar2.Value = (int)(c1RadialGauge1.MorePointers[1].Value + 0.5);
            trackBar3.Value = (int)(c1RadialGauge1.MorePointers[2].Value + 0.5);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            c1RadialGauge1.MorePointers[0].Value = trackBar1.Value;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            c1RadialGauge1.MorePointers[1].Value = trackBar2.Value;
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            c1RadialGauge1.MorePointers[2].Value = trackBar3.Value;
        }
    }
}
