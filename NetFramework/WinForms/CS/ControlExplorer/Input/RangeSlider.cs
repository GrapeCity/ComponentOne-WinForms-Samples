using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Input
{
    public partial class RangeSlider : C1DemoForm
    {
        public RangeSlider()
        {
            InitializeComponent();
        }

        private void c1RangeSlider1_LowerValueChanged(object sender, EventArgs e)
        {
            label1.Text = c1RangeSlider1.LowerValue.ToString();
        }

        private void c1RangeSlider1_UpperValueChanged(object sender, EventArgs e)
        {
            label2.Text = c1RangeSlider1.UpperValue.ToString();
        }
    }
}
