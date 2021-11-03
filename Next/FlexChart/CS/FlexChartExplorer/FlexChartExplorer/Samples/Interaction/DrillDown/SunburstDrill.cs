using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlexChartExplorer.Data;
using C1.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class SunburstDrill : FlexChartBaseSample
    {
        public SunburstDrill()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var sunburst = this.Chart as C1.Win.Chart.Sunburst;
            sunburst.Header.Content = "Sales over the years";
            sunburst.Header.Style.Font = StyleInfo.ChartHeaderFont;

            sunburst.DataSource = HierarchicalDataSource.GetSunburstData();
            sunburst.BindingName = "Year,Quarter,Month";
            sunburst.Binding = "Value";
            sunburst.ChildItemsPath = "Items";
            sunburst.DataLabel.Position = PieLabelPosition.Center;
            sunburst.DataLabel.Content = "{name} | {value}";
            sunburst.ToolTip.Content = "{name} Sales : {P:0}%";
            sunburst.Drilldown = true;
        }
        protected override void InitializeControls()
        {            
            this.Chart = new C1.Win.Chart.Sunburst { Dock = DockStyle.Fill };
        }
    }
}
