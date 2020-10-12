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
    public partial class RadialGauges : C1DemoForm
    {
        Random _random;

        public RadialGauges()
        {
            InitializeComponent();
            _random = new Random();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateValue(c1RadialGauge1, 100);
            UpdateValue(c1RadialGauge2, 50);
            UpdateValue(c1RadialGauge3, 5);
            UpdateValue(c1RadialGauge4, 40);
            UpdateValue(c1RadialGauge5, 100);
            
        }

        private void UpdateValue(C1GaugeBase gauge, double step)
        {
            double v = gauge.Value;
            double min, max;
            min = Math.Max(gauge.Minimum, v - step);
            max = Math.Min(gauge.Maximum, v + step);
            gauge.Value = _random.NextDouble() * (max - min) + min;
        }

        private void RadialGauges_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
