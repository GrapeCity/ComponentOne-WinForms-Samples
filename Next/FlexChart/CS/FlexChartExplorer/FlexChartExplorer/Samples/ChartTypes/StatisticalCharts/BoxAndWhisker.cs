using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using BaseExplorer;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class BoxAndWhisker : FlexChartBaseSample
    {
        private ComboBoxEx _cbQuartileCalc;
        private CheckBoxEx _chbMeanLine, _chbMean, _chbOutlier, _chbInnerPoints, _chbRotate;
        private FlexChart flexChart1;

        public BoxAndWhisker()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var data = DataService.GetTemperatureData(new string[] { "New York", "Chicago" }, false, 365, true);
            foreach (CityDataItem item in data)
            {
                var ds = item.Data.GroupBy(x => x.Date.Month).SelectMany(grp => grp).OrderBy(x=>x.Date.Day).Select(x=> new PointD{ X = x.Date.Month-1, Y = x.HighTemp }).ToList();
                BoxWhisker boxWhisker = new BoxWhisker()
                {
                    Name = item.Name,
                    DataSource = ds,
                    BindingX = "X",
                    Binding = "Y",
                    QuartileCalculation = QuartileCalculation.InclusiveMedian,
                };
                this.flexChart1.Series.Add(boxWhisker);
            }
            this.flexChart1.AxisX.DataSource = DataService.GetMonthAxisDataSource();
            this.flexChart1.AxisX.Binding = "Value,Name";
            this.flexChart1.AxisY.Title = "Temperature (°F)";
            this.flexChart1.AxisY.TitleStyle.Font = this.flexChart1.AxisX.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.ToolTip.Content = "Temperature Details For {seriesName} :\nMin:{Min}\nFirst Quartile:{FirstQuartile}\nMedian:{Median}\nMean:{Mean}\nThird Quartile:{ThirdQuartile}\nMax:{Max}";
            this.flexChart1.Header.Content = "Weather Report : Monthly Temperatures";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbQuartileCalc = ControlFactory.EnumBasedCombo(typeof(QuartileCalculation), "Quartile Calculation");
            _cbQuartileCalc.SelectedIndexChanged += _cbQuartileCalc_SelectedIndexChanged;
            _cbQuartileCalc.Size = new Size(210, 21);
            this.pnlControls.Controls.Add(_cbQuartileCalc);
            
            _chbMeanLine = new CheckBoxEx("Show mean line");
            _chbMeanLine.CheckedChanged += _chbMeanLine_CheckedChanged;
            this.pnlControls.Controls.Add(_chbMeanLine);

            _chbMean = new CheckBoxEx("Show mean") { Checked=true};
            _chbMean.CheckedChanged += _chbMean_CheckedChanged;
            this.pnlControls.Controls.Add(_chbMean);

            _chbOutlier = new CheckBoxEx("Show outlier") { Checked=true};
            _chbOutlier.CheckedChanged += _chbOutlier_CheckedChanged;
            this.pnlControls.Controls.Add(_chbOutlier);

            _chbInnerPoints = new CheckBoxEx("Show inner points");
            _chbInnerPoints.CheckedChanged += _chbInnerPoints_CheckedChanged;
            this.pnlControls.Controls.Add(_chbInnerPoints);

            _chbRotate = new CheckBoxEx("Rotate");
            _chbRotate.CheckedChanged += _chbRotate_CheckedChanged;
            this.pnlControls.Controls.Add(_chbRotate);
        }

        private void _chbRotate_CheckedChanged(object sender, EventArgs e)
        {
            this.flexChart1.Rotated = _chbRotate.Checked;
            if (_chbRotate.Checked)
            {
                this.flexChart1.AxisY.DataSource = DataService.GetMonthAxisDataSource();
                this.flexChart1.AxisY.Binding = "Value,Name";
                this.flexChart1.AxisX.DataSource = null;
                this.flexChart1.AxisX.Title = this.flexChart1.AxisY.Title;
                this.flexChart1.AxisY.Title = string.Empty;
            }
            else
            {
                this.flexChart1.AxisX.DataSource = DataService.GetMonthAxisDataSource();
                this.flexChart1.AxisY.Title = this.flexChart1.AxisX.Title;
                this.flexChart1.AxisX.Title = string.Empty;
                this.flexChart1.AxisY.Binding = "Value,Name";
                this.flexChart1.AxisY.DataSource = null;
            }
        }

        private void _chbInnerPoints_CheckedChanged(object sender, EventArgs e)
        {
            foreach (BoxWhisker boxWhisker in this.flexChart1.Series)
            {
                boxWhisker.ShowInnerPoints = _chbInnerPoints.Checked;
            }
        }

        private void _chbOutlier_CheckedChanged(object sender, EventArgs e)
        {
            foreach (BoxWhisker boxWhisker in this.flexChart1.Series)
            {
                boxWhisker.ShowOutliers = _chbOutlier.Checked;
            }
        }

        private void _chbMean_CheckedChanged(object sender, EventArgs e)
        {
            foreach (BoxWhisker boxWhisker in this.flexChart1.Series)
            {
                boxWhisker.ShowMeanMarks = _chbMean.Checked;
            }
        }

        private void _chbMeanLine_CheckedChanged(object sender, EventArgs e)
        {
            foreach (BoxWhisker boxWhisker in this.flexChart1.Series)
            {
                boxWhisker.ShowMeanLine = _chbMeanLine.Checked;
            }
        }

        private void _cbQuartileCalc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var quartCalculation = (QuartileCalculation)Enum.Parse(typeof(QuartileCalculation), _cbQuartileCalc.SelectedItem.ToString());
            foreach (BoxWhisker boxWhisker in this.flexChart1.Series)
            {
                boxWhisker.QuartileCalculation = quartCalculation;
            }
        }
    }
}
