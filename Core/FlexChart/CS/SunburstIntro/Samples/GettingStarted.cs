using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Chart;

using SunburstIntro.Services;

namespace SunburstIntro.Samples
{
    public partial class GettingStarted : UserControl
    {
        public GettingStarted()
        {
            InitializeComponent();
        }

        private void GettingStarted_Load(object sender, EventArgs e)
        {
            sunburst.BeginUpdate();
            sunburst.DataSource = DataService.CreateHierarchicalData();
            sunburst.Binding = "Value";
            sunburst.BindingName = "Year,Quarter,Month";
            sunburst.ChildItemsPath = "Items";
            sunburst.DataLabel.Content = "{name}";
            sunburst.DataLabel.Style.Font = new Font(FontFamily.GenericSansSerif, 7);
            sunburst.DataLabel.Position = C1.Chart.PieLabelPosition.Center;
            sunburst.EndUpdate();
        }
    }
}
