﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GaugeDemo
{
    public partial class PageInclined : BaseGaugePage
    {
        public PageInclined()
        {
            InitializeComponent();
        }

        protected override void OnTimer()
        {
            UpdateValue(c1LinearGauge1, 100);
        }
    }
}
