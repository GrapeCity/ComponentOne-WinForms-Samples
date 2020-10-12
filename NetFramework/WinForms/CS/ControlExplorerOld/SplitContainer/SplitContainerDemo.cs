using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1SplitContainer;

namespace ControlExplorer.SplitContainer
{
    public partial class SplitContainerDemo : C1DemoForm
    {
        public SplitContainerDemo()
        {
            InitializeComponent();

            AddProperty("LineBelowHeader", c1SplitContainer1);
            AddProperty("RightToLeft", c1SplitContainer1);
        }

        private void Panel_CloseButtonClick(object sender, EventArgs e)
        {
            C1SplitterPanel panel = sender as C1SplitterPanel;
            if (panel != null)
            {
                panel.Collapsible = false;
                panel.Visible = false;
            }
        }
    }
}
