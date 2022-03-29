using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.Gauge;

namespace GaugeDemo
{
    public partial class PageInteractive : BaseGaugePage
    {
        public PageInteractive()
        {
            InitializeComponent();
        }

        private void c1RadialGauge1_ItemMouseMove(object sender, ItemMouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                C1GaugeEllipse el = e.Item as C1GaugeEllipse;
                if (el != null && el.Name == "back")
                {
                    C1GaugePointer p = e.Gauge.Pointer;
                    p.UpdateValue(p.GetValueAt(e.X, e.Y), 2.5);
                }
            }
        }

        private void c1RadialGauge1_FormatLabel(object sender, FormatLabelEventArgs e)
        {
            if (double.IsNaN(e.Value))
            {
                e.Text = "Off";
            }
        }
    }
}
