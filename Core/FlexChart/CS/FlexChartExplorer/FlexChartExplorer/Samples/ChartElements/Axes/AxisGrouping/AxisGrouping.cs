using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using FlexChartExplorer.Data;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class AxisGrouping : FlexChartBaseSample
    {
        private ComboBoxEx _cbGroupSeparator;
        private FlexChart flexChart1;

        public AxisGrouping()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "World GDP Ranking";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            SetFlatData();
            this.flexChart1.BindingX = "Country";
            var serCP = new Series { Name = "Current Prices", Binding = "CurrentPrices" };
            var serPPP = new Series { Name = "PPP valuation", Binding = "PPPValuation" };

            this.flexChart1.Series.Add(serCP);
            this.flexChart1.Series.Add(serPPP);

            this.flexChart1.AxisX.GroupSeparator = AxisGroupSeparator.Vertical;
            this.flexChart1.ToolTip.Content = "{x}\r{seriesName}\r{y}";
            this.flexChart1.Rendered += (s, e) => { _cbGroupSeparator.SelectedItem = flexChart1.AxisX.GroupSeparator; };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbGroupSeparator = ControlFactory.EnumBasedCombo(typeof(AxisGroupSeparator), "Axis Group Separator");
            _cbGroupSeparator.Width = 160;
            _cbGroupSeparator.SelectedIndexChanged += (s, e) => { flexChart1.AxisX.GroupSeparator = (AxisGroupSeparator)Enum.Parse(typeof(AxisGroupSeparator), _cbGroupSeparator.SelectedValue.ToString()); };

            this.pnlControls.Controls.Add(_cbGroupSeparator);
        }
        private void SetFlatData()
        {
            flexChart1.DataSource = HierarchicalDataSource.GetFlatOrHierarchicalGDPData(true);
            flexChart1.AxisX.GroupNames = "Continent";
            flexChart1.AxisX.GroupItemsPath = null;
        }
        private void SetHierarchicalData()
        {
            flexChart1.DataSource = HierarchicalDataSource.GetFlatOrHierarchicalGDPData(false);
            flexChart1.AxisX.GroupNames = "Continent";
            flexChart1.AxisX.GroupItemsPath = "Items";
        }
    }
}
