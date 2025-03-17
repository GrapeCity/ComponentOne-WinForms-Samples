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
    public partial class StackedBar : FlexChartBaseSample
    {
        private ComboBoxEx _cbStacking;
        private FlexChart flexChart1;
        private LabelEx _lblStacking;

        public StackedBar()
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
            this.flexChart1.Series.Add(new Series { Binding = "WinterTotal", Name = "Winter" });
            this.flexChart1.Series.Add(new Series { Binding = "SummerTotal", Name = "Summer" });
            this.flexChart1.Stacking = Stacking.Stacked;
            this.flexChart1.ToolTip.Content = "{y:0}";
            this.flexChart1.Rendered += (s, e) => { _cbStacking.SelectedIndex = (int)flexChart1.Stacking; };
        }
        protected override void InitializeControls()
        {
            _lblStacking = new LabelEx("Stacking:");

            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbStacking = ControlFactory.EnumBasedCombo(typeof(Stacking), "Stacking");
            _cbStacking.SelectedIndexChanged += (s, e) => 
            {
                flexChart1.Stacking = (Stacking)Enum.Parse(typeof(Stacking), _cbStacking.SelectedItem.DisplayText);
                flexChart1.AxisX.Format = flexChart1.Stacking == Stacking.Stacked100pc ? "p0" : "0";
            };

            this.pnlControls.Controls.Add(_lblStacking);
            this.pnlControls.Controls.Add(_cbStacking);
        }
    }
}
