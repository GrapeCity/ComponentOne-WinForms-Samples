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
    public partial class PageSwissRailwayClock : BaseGaugePage
    {
        public PageSwissRailwayClock()
        {
            InitializeComponent();
            OnTimer();
        }

        protected override void OnTimer()
        {
            PointerCollection pointers = c1RadialGauge1.MorePointers;
            double seconds = DateTime.Now.TimeOfDay.TotalSeconds;
            pointers["hours"].Value = Math.Floor((seconds % 43200.0) / 3600.0);
            pointers["minutes"].Value = Math.Floor((seconds - (Math.Floor(seconds / 3600.0) * 3600.0)) / 60.0);
            pointers["seconds"].Value = seconds - (Math.Floor(seconds / 60.0) * 60.0);
        }
    }
}
