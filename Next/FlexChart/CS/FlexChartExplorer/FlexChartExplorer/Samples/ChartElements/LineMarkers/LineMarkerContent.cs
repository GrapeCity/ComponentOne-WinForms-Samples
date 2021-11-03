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
using C1.Win.Chart.Interaction;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class LineMarkerContent : FlexChartBaseSample
    {
        LineMarker _lineMarker;
        private FlexChart flexChart1;

        public LineMarkerContent()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Daily Price Movement";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.BindingX = "Date";
            this.flexChart1.ChartType = ChartType.Line;

            var high = new Series { Binding = "High", Name = "High" };
            var low = new Series { Binding = "Low", Name = "Low" };

            this.flexChart1.Series.Add(high);
            this.flexChart1.Series.Add(low);

            this.flexChart1.AxisY.Format = "c0";
            this.flexChart1.Rendered += (s, e) => 
            {
                if (_lineMarker == null)
                {
                    _lineMarker = new LineMarker(this.flexChart1) { LineWidth = 2, HorizontalPosition=0.5, VerticalPosition=0.5 };
                    _lineMarker.PositionChanged += (sender, eventArgs) => { SetLineMarkerContent(); };
                    //Just to find content of marker for default positions
                    _lineMarker.Paint += _lineMarker_Paint;
                }
            };
            this.flexChart1.DataSource = FinancialDataSource.GetQuotes();
        }

        private void _lineMarker_Paint(object sender, PaintEventArgs e)
        {
            SetLineMarkerContent();
            _lineMarker.Paint -= _lineMarker_Paint;
        }

        private void SetLineMarkerContent()
        {
            var content = string.Empty;
            var hitInfo = this.flexChart1.HitTest(new Point(_lineMarker.X, _lineMarker.Y), MeasureOption.X, -1);
            var item = (Quote)hitInfo.Item;
            if (item != null)
            {
                content += string.Format("Date : {0}\n", item.Date.ToShortDateString());
                foreach (var series in this.flexChart1.Series)
                {
                    var values = series.GetValues(0);
                    content += string.Format("{0} : {1:c}\n", series.Name, values[hitInfo.PointIndex]);
                }
                content += string.Format("Difference : {0:c}", item.High - item.Low);
            }
            _lineMarker.Content = content;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
