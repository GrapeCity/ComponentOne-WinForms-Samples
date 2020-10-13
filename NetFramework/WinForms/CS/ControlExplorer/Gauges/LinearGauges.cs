using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Gauge;

namespace ControlExplorer.Gauges
{
    public partial class LinearGauges : C1DemoForm
    {
        Random _random;

        public LinearGauges()
        {
            InitializeComponent();
            _random = new Random();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateValue(c1LinearGauge1, 100);
            UpdateValue(c1LinearGauge2, 50);
            UpdateValue(c1LinearGauge3, 5);
            UpdateValue(c1LinearGauge4, 40);
            UpdateValue(c1LinearGauge5, 100);
        }

        private void UpdateValue(C1GaugeBase gauge, double step)
        {
            double v = gauge.Value;
            double min, max;
            min = Math.Max(gauge.Minimum, v - step);
            max = Math.Min(gauge.Maximum, v + step);
            gauge.Value = _random.NextDouble() * (max - min) + min;
            if (gauge.MorePointers.Count > 0)
            {
                gauge.MorePointersValue_0 = _random.NextDouble() * (max - min) + min;
            }
        }

        private void LinearGauges_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
