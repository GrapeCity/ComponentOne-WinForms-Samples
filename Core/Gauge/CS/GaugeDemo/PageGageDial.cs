using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GaugeDemo
{
    public partial class PageGageDial : BaseGaugePage
    {
        public PageGageDial()
        {
            InitializeComponent();
        }

        protected override void OnTimer()
        {
            UpdateValue(c1RadialGauge1, 30);
        }
    }
}
