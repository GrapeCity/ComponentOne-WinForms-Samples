using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GaugeDemo
{
    public partial class PageCarDashboard : BaseGaugePage
    {
        public PageCarDashboard()
        {
            InitializeComponent();
        }

        protected override void OnTimer()
        {
            UpdateValue(c1RadialGauge1, "mph", 100, 0, 180);
            UpdateValue(c1RadialGauge1, "rpm", 3000, 0, 8300);
            UpdateValue(c1RadialGauge1, "fuel", 50, 0, 100);
        }
    }
}
