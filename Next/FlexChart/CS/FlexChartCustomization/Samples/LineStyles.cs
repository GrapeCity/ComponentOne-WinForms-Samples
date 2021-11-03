using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Chart;

namespace FlexChartCustomization.Samples
{
    public partial class LineStyles : UserControl
    {
        public LineStyles()
        {
            InitializeComponent();
            InitializeControls();
            SetupChart();
        }
        void SetupChart()
        {
            List<DataItem> dataList = new List<DataItem>();
            dataList.Add(new DataItem() { X = 1, Y = 50 });
            dataList.Add(new DataItem() { X = 2, Y = 30 });
            dataList.Add(new DataItem() { X = 3, Y = 40 });
            dataList.Add(new DataItem() { X = 4, Y = 60 });
            dataList.Add(new DataItem() { X = 5, Y = 90 });
            dataList.Add(new DataItem() { X = 6, Y = 80 });
            dataList.Add(new DataItem() { X = 7, Y = 56 });
            dataList.Add(new DataItem() { X = 8, Y = 56 });
            dataList.Add(new DataItem() { X = 9, Y = 50 });
            dataList.Add(new DataItem() { X = 10, Y = 70 });

            flexChart1.BeginUpdate();
            flexChart1.ChartType = C1.Chart.ChartType.Line;
            var series = new Series()
            {
                Name = "Trend",
                DataSource = dataList,
                Binding = "Y",
                BindingX = "X",
            };
            flexChart1.Series.Add(series);
            series.SymbolRendered += Series_SymbolRendered;

            // Use this to avoid the default render of the lines.
            series.Style.StrokeColor = Color.Transparent;

            flexChart1.EndUpdate();
        }

        float previousX, previousY;
        int sequentialIncrement, sequentialDecrement;
        private void Series_SymbolRendered(object sender, RenderSymbolEventArgs e)
        {
            if (e.Index > 0)
            {
                Color lineColor;
                if (e.Point.Y == previousY)
                {
                    lineColor = Color.Yellow;
                    e.Engine.SetStrokePattern(new double[] { 2, 1 });
                }
                else if (e.Point.Y > previousY)
                {
                    lineColor = Color.FromArgb(Math.Min(100 + 50 * sequentialIncrement, 255), 0, 255, 0);
                    sequentialIncrement++;
                    sequentialDecrement = 0;
                    e.Engine.SetStrokePattern(null);
                }
                else
                {
                    lineColor = Color.FromArgb(Math.Min(100 + 50 * sequentialDecrement, 255), 255, 0, 0);
                    sequentialDecrement++;
                    sequentialIncrement = 0;
                    e.Engine.SetStrokePattern(null);
                }
                e.Engine.SetStroke(new SolidBrush(lineColor));
                e.Engine.SetStrokeThickness(3);
                e.Engine.DrawLine(previousX, previousY, e.Point.X, e.Point.Y);
            }
            previousX = e.Point.X;
            previousY = e.Point.Y;
        }

        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("lines", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("lines", "description").MakeRtf();
            baseSample1.pScroll.Controls.Remove(baseSample1.pControls);
            flexChart1 = baseSample1.flexChart1;
        }
        public class DataItem
        {
            public int X { get; set; }

            public int Y { get; set; }
        }
    }
}
