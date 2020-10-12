using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GaugeDemo
{
    public partial class PageIntervalWidth : BaseGaugePage
    {
        public PageIntervalWidth()
        {
            InitializeComponent();
        }

        protected override void OnTimer()
        {
            UpdateValue(c1RadialGauge1, 20);
            UpdateValue(c1LinearGauge1, 20);
            UpdateValue(c1LinearGauge2, 20);
        }
    }
}
