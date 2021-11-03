using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Gauge;

namespace GaugeDemo
{
    public partial class PageEqualizer : BaseGaugePage
    {
        public PageEqualizer()
        {
            InitializeComponent();
        }

        protected override void OnTimer()
        {
            UpdateValue(c1LinearGauge1, 0, 100);
            UpdateValue(c1LinearGauge1, 1, 100);
            UpdateValue(c1LinearGauge1, 2, 100);
            UpdateValue(c1LinearGauge1, 3, 100);
            UpdateValue(c1LinearGauge1, 4, 100);
            UpdateValue(c1LinearGauge1, 5, 100);
            UpdateValue(c1LinearGauge1, 6, 100);
            UpdateValue(c1LinearGauge1, 7, 100);
            UpdateValue(c1LinearGauge1, 8, 100);
            UpdateValue(c1LinearGauge1, 9, 100);
        }
    }
}
