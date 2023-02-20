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
            UpdateValue(c1RadialGauge3, 50);
            UpdateValue(c1RadialGauge5, 50);
            UpdateValue(c1RadialGauge5, 40, 0);
            UpdateValue(c1RadialGauge5, 50, 1);
            UpdateClock();
        }

        // Update clock gauge.
        private void UpdateClock()
        {
            var time = DateTime.Now;
            c1RadialGauge4.Value = time.Hour * 5;
            c1RadialGauge4.MorePointers[0].Value = time.Minute;
            c1RadialGauge4.MorePointers[1].Value = time.Second;
        }

        private void UpdateValue(C1GaugeBase gauge, double step, int pointerIndex = -1)
        {
            C1GaugePointer pointer =
                pointerIndex >= 0 && pointerIndex < gauge.MorePointers.Count ?
                gauge.MorePointers[pointerIndex] :
                null;

            double v = pointer is null ? gauge.Value : pointer.Value;
            double min, max;
            min = Math.Max(gauge.Minimum, v - step);
            max = Math.Min(gauge.Maximum, v + step);

            if (pointer is null)
                gauge.Value = _random.NextDouble() * (max - min) + min;
            else
                pointer.Value = _random.NextDouble() * (max - min) + min;
        }

        private void RadialGauges_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            UpdateClock();
        }
    }
}
