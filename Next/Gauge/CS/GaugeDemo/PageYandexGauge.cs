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
    public partial class PageYandexGauge : GaugeDemo.BaseGaugePage
    {
        public PageYandexGauge()
        {
            InitializeComponent();
        }

        private void c1RadialGauge1_ItemMouseMove(object sender, C1.Win.Gauge.ItemMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C1GaugePointer p = e.Gauge.Pointer;
                p.Value = p.GetValueAt(e.X, e.Y);
            }
        }
    }
}
