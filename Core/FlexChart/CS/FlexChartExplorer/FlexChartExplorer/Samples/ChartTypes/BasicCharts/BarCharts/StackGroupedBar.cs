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
    public partial class StackGroupedBar : FlexChartBaseSample
    {
        private ComboBoxEx _cbStacking;
        private FlexChart flexChart1;

        public StackGroupedBar()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Bar;
            this.flexChart1.Header.Content = "Product Sales in Holidays";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = SalesDataSource.GetSeasonSales(10);
            this.flexChart1.BindingX = "Name";
            var winterOnline = new Series
            {
                Binding = "WinterOnline",
                Name = "Online",
                LegendGroup = "Winter",
                StackingGroup = 0,
            };
            var winterOffline = new Series
            {
                Binding = "WinterOffline",
                Name = "Offline",
                LegendGroup = "Winter",
                StackingGroup = 0,
            };
            var summerOnline = new Series
            {
                Binding = "SummerOnline",
                Name = "Online",
                LegendGroup = "Summer",
                StackingGroup = 1,
            };
            var summerOffline = new Series
            {
                Binding = "SummerOffline",
                Name = "Offline",
                LegendGroup = "Summer",
                StackingGroup = 1,
            };
            this.flexChart1.Series.Add(winterOnline);
            this.flexChart1.Series.Add(winterOffline);
            this.flexChart1.Series.Add(summerOnline);
            this.flexChart1.Series.Add(summerOffline);

            this.flexChart1.Stacking = Stacking.Stacked;
            this.flexChart1.Legend.GroupHeaderStyle.Font = StyleInfo.LegendGroupHeaderFont;
            this.flexChart1.Legend.Position = Position.Right;
            this.flexChart1.ToolTip.Content = "{y:0}";
            this.flexChart1.Rendered += (s, e) => { _cbStacking.SelectedItem = flexChart1.Stacking; };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbStacking = ControlFactory.EnumBasedCombo(typeof(Stacking), "Stacking");
            _cbStacking.SelectedIndexChanged += (s, e) =>
            {
                flexChart1.Stacking = (Stacking)Enum.Parse(typeof(Stacking), _cbStacking.SelectedValue.ToString());
                flexChart1.AxisX.Format = flexChart1.Stacking == Stacking.Stacked100pc ? "p0" : "0";
            };
            this.pnlControls.Controls.Add(_cbStacking);
        }
    }
}
