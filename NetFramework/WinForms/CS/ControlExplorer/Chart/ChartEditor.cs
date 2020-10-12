using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Chart;

namespace ControlExplorer.Chart
{
    public partial class ChartEditor : C1DemoForm
    {
        public ChartEditor()
        {
            InitializeComponent();
        }

        private void c1CommandHolder1_CommandClick(object sender, C1.Win.C1Command.CommandClickEventArgs e)
        {
            if (e.Command == c1Command_ChartWizard)
            {
                // Show chart wizard
                c1Chart1.ShowWizard();
            }
            else if (e.Command == c1Command_ChartType)
            {
                // Show specific properties page
                c1Chart1.ShowProperties(PropertyPageFlags.GallerySimple);
            }
            else if (e.Command == c1Command_ChartProperties)
            {
                // Show general properties page
                c1Chart1.ShowProperties();
            }
            else if (e.Command == c1Command_DataBinding)
            {
                // Show data binding dialog
                c1Chart1.ShowDataBindingDialog();
            }
            else if (e.Command == c1Command_VisualEffects)
            {
                // Show visual effects editor
                c1Chart1.ShowVisualEffectsEditor();
            }
        }
    }
}
