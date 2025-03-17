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
using BaseExplorer;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class NumericAxisGrouping : FlexChartBaseSample
    {
        private ComboBoxEx _cbYGroupSeparator;
        private LabelEx _lblGroupSeparator;
        private FlexChart flexChart1;

        public NumericAxisGrouping()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.SplineSymbols;
            this.flexChart1.Header.Content = "Monthly Mean Temperature(°F)";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = DataService.GetTemperatureData(new[] { "Tokyo" }, true, 12, true).First().Data;
            this.flexChart1.BindingX = "Date";
            this.flexChart1.Series.Add(new Series { Binding = "HighTemp", Name = "Tokyo" });

            this.flexChart1.AxisY.GroupProvider = new MyGroupProvider();
            this.flexChart1.AxisY.GroupStyle.StrokeWidth = 2;
            this.flexChart1.AxisY.GroupSeparator = AxisGroupSeparator.Horizontal;
            this.flexChart1.AxisY.Title = "Temperature (°F)";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;

            this.flexChart1.Rendered += (s, e) => { _cbYGroupSeparator.SelectedIndex = (int)flexChart1.AxisY.GroupSeparator; };
        }
        class MyGroupProvider : IAxisGroupProvider
        {
            public int GetLevels(IRange range)
            {
                return 1;
            }

            public IList<IRange> GetRanges(IRange range, int level)
            {
                var ranges = new List<IRange>();
                if (level == 1)
                {
                    ranges.Add(new DoubleRange("Low", 0, 55));
                    ranges.Add(new DoubleRange("Medium", 55, 100));
                    ranges.Add(new DoubleRange("High", 100, 140));
                }
                return ranges;
            }
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbYGroupSeparator = ControlFactory.EnumBasedCombo(typeof(AxisGroupSeparator), "AxisY Group Separator");
            _cbYGroupSeparator.Width = 240;
            _cbYGroupSeparator.SelectedIndexChanged += (s, e) => { flexChart1.AxisY.GroupSeparator = (AxisGroupSeparator)Enum.Parse(typeof(AxisGroupSeparator), _cbYGroupSeparator.SelectedItem.DisplayText); };

            _lblGroupSeparator = new LabelEx("AxisY Group Seperator:");

            this.pnlControls.Controls.Add(_lblGroupSeparator);
            this.pnlControls.Controls.Add(_cbYGroupSeparator);
        }
    }
}
