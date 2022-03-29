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
    public partial class PageKnob : BaseGaugePage
    {
        public PageKnob()
        {
            InitializeComponent();
        }

        private void c1RadialGauge1_PointerDragMove(object sender, PointerDragEventArgs e)
        {
            e.Pointer.Value = e.NewValue;
        }
    }
}
