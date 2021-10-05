using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseExplorer;
using C1.Chart;
using FlexChartExplorer.Data;
using C1.Win.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class CollapsibleAxisGrouping : FlexChartBaseSample
    {
        LabelEx _tbVisibilityLevel;
        NumericUpDownEx _udVisibilityLevel;
        private FlexChart flexChart1;

        public CollapsibleAxisGrouping()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Line;
            this.flexChart1.Header.Content = "Stock Price Forecast";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = FinancialDataSource.GetQuotes(DateTime.Today,1000);
            this.flexChart1.BindingX = "Date";
            this.flexChart1.Series.Add(new Series { Binding = "High" });

            var dtGroupProvider = new DateTimeGroupProvider();
            dtGroupProvider.GroupTypes.Add(TimeUnits.Month);
            dtGroupProvider.GroupTypes.Add(TimeUnits.Quarter);
            dtGroupProvider.GroupTypes.Add(TimeUnits.Year);
            
            this.flexChart1.AxisX.GroupProvider = dtGroupProvider;
            this.flexChart1.AxisX.GroupVisibilityLevel = 1;
            this.flexChart1.AxisX.GroupSeparator = AxisGroupSeparator.Horizontal;
            this.flexChart1.AxisX.LabelAngle = 90;
            this.flexChart1.AxisX.Format = "dd-MM-yyyy";
            
            this.flexChart1.Rendered += (s, e) => { _udVisibilityLevel.Value = flexChart1.AxisX.GroupVisibilityLevel;};
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _tbVisibilityLevel = new LabelEx("Group Visibility Level");
            _udVisibilityLevel = new NumericUpDownEx() { Minimum = -4, Maximum = 4, Value = 1, Increment=1 };
            _udVisibilityLevel.ValueChanged += (s, e) => { flexChart1.AxisX.GroupVisibilityLevel = (int)_udVisibilityLevel.Value; };

            this.pnlControls.Controls.Add(_tbVisibilityLevel);
            this.pnlControls.Controls.Add(_udVisibilityLevel);
        }
    }
}
