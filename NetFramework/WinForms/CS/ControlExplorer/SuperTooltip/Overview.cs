using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1SuperTooltip;

namespace ControlExplorer.SuperTooltip
{
    public partial class Overview : C1DemoForm
    {
        public Overview()
        {
            InitializeComponent();

            // add demo properties
            AddProperty("BackgroundGradient", c1SuperTooltip1);
            AddProperty("Border", c1SuperTooltip1);
            AddProperty("IsBalloon", c1SuperTooltip1);  
            AddProperty("RoundedCorners", c1SuperTooltip1);
            AddProperty("Shadow", c1SuperTooltip1);
            AddProperty("UseFading", c1SuperTooltip1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1SuperTooltip1.Show(c1SuperTooltip1.GetToolTip(button1), button1);
        }

    }
}
