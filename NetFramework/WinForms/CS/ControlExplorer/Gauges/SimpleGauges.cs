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
    public partial class SimpleGauges : C1DemoForm
    {
        Random _random;

        public SimpleGauges()
        {
            InitializeComponent();
            _random = new Random();
        }

        private void UpdateValue(C1GaugeBase gauge, double step)
        {
            double v = gauge.Value;
            double min, max;
            min = Math.Max(gauge.Minimum, v - step);
            max = Math.Min(gauge.Maximum, v + step);
            gauge.Value = _random.NextDouble() * (max - min) + min;
        }

        private void SimpleGauges_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            UpdateValue(c1RadialGauge1, 5);

            UpdateValue(c1RadialGauge2, 5);
            PointerCollection pointers = c1RadialGauge2.MorePointers;
            pointers["pointerOffset"].Value = c1RadialGauge2.Value > 95 ? 100 : c1RadialGauge2.Value+5;

            UpdateValue(c1LinearGauge1, 5);
            UpdateValue(c1LinearGauge2, 5);
        }

        private void SimpleGauges_BackColorChanged(object sender, EventArgs e)
        {
            var decor0 = c1LinearGauge2.Decorators[0] as C1GaugeRange;
            if (decor0 != null)
            {
                decor0.Border.Color = this.BackColor;
                decor0.Filling.Color = this.BackColor;
            }
            var decor3 = c1LinearGauge2.Decorators[3] as C1GaugeMarks;
            if(decor3 != null)
            {
                decor3.Border.Color = this.BackColor;
                decor3.Filling.Color = this.BackColor;
            }
        }
    }
}
