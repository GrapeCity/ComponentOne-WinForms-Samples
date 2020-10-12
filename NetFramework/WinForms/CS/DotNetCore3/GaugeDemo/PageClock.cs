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
    public partial class PageClock : BaseGaugePage
    {
        private bool _roman;

        public PageClock()
        {
            InitializeComponent();
            OnTimer();
        }

        protected override void OnTimer()
        {
            PointerCollection pointers = c1RadialGauge1.MorePointers;
            double seconds = Math.Floor(DateTime.Now.TimeOfDay.TotalSeconds);
            pointers["hours"].Value = (seconds % 43200.0) / 3600.0;
            pointers["minutes"].Value = (seconds - (Math.Floor(seconds / 3600.0) * 3600.0)) / 60.0;
            pointers["seconds"].Value = seconds - (Math.Floor(seconds / 60.0) * 60.0);
        }

        private void c1RadialGauge1_FormatLabel(object sender, FormatLabelEventArgs e)
        {
            if (_roman && e.Decorator.Name == "nums")
            {
                switch (Convert.ToInt32(e.ScaledValue))
                {
                    case 1: e.Text = "I"; break;
                    case 2: e.Text = "II"; break;
                    case 3: e.Text = "III"; break;
                    case 4: e.Text = "IV"; break;
                    case 5: e.Text = "V"; break;
                    case 6: e.Text = "VI"; break;
                    case 7: e.Text = "VII"; break;
                    case 8: e.Text = "VIII"; break;
                    case 9: e.Text = "IX"; break;
                    case 10: e.Text = "X"; break;
                    case 11: e.Text = "XI"; break;
                    case 12: e.Text = "XII"; break;
                }
            }
        }

        private void romanCheckBox_Click(object sender, EventArgs e)
        {
            _roman = romanCheckBox.Checked;
            c1Gauge1.InvalidateCache();
        }
    }
}
