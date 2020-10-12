using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Chart;
using C1.Chart.Finance;
using C1.Win.Chart.Finance;

namespace ControlExplorer.FlexChart
{
    public partial class FinancialChartIntro : C1DemoForm
    {
        public FinancialChartIntro()
        {
            InitializeComponent();
        }

        private void FinancialChartIntro_Load(object sender, EventArgs e)
        {
            chartType.DataSource = new FinancialChartType[] 
            {
                FinancialChartType.Candlestick, 
                FinancialChartType.HeikinAshi,
                FinancialChartType.HighLowOpenClose,
                FinancialChartType.Line,
                FinancialChartType.LineSymbols,
                FinancialChartType.Area,
                FinancialChartType.Scatter
            };
            chartType.SelectedValueChanged += (s, a) => SetChartType((FinancialChartType)chartType.SelectedItem);

            flexChart1.BeginUpdate();
            flexChart1.Legend.Position = Position.Bottom;
            flexChart1.ToolTip.Content = "Date:{Time:MMM-dd}\nHigh:{High}\nLow:{Low}\nOpen:{Open}\nClose:{Close}";
            var ser = new FinancialSeries() { Name = "Acme Corp." };
            flexChart1.Series.Add(ser);
            flexChart1.BindingX = "Time";
            flexChart1.DataSource = QuoteService.GetSampleData(56);
            SetChartType( FinancialChartType.Candlestick);
            var ma = new MovingAverage() { Binding = "Close", Period = 7, Name = "MovAvg 7", Visibility = SeriesVisibility.Hidden };
            ((C1.Chart.ISeries)ma).ChartType = C1.Chart.ChartType.Line;
            flexChart1.Series.Add(ma);
            var ma2 = new MovingAverage() { Binding = "Close", Period = 14, Name = "MovAvg 14", Visibility = SeriesVisibility.Hidden };
            ((C1.Chart.ISeries)ma2).ChartType = C1.Chart.ChartType.Line;
            flexChart1.Series.Add(ma2);
            flexChart1.EndUpdate();

            movAvg.CheckedChanged += (s, a) => ma.Visibility = movAvg.Checked ? SeriesVisibility.Visible : SeriesVisibility.Hidden;
            movAvg2.CheckedChanged += (s, a) => ma2.Visibility = movAvg2.Checked ? SeriesVisibility.Visible : SeriesVisibility.Hidden;
        }

        void SetChartType(FinancialChartType chartType)
        {
            flexChart1.ChartType = chartType;

            if (chartType == FinancialChartType.Line || chartType == FinancialChartType.Area
                || chartType == FinancialChartType.LineSymbols)
            {
                flexChart1.Binding = "Close";
            }
            else
            {
                flexChart1.Binding = "High,Low,Open,Close";
            }
        }
    }

    public class Quote
    {
        public DateTime Time { get; set; }

        public double Open { get; set; }
        public double Close { get; set; }
        public double High { get; set; }
        public double Low { get; set; }

        public double Volume { get; set; }
    }

    public class QuoteService
    {
        static Random rnd = new Random();

        public static List<Quote> GetSampleData(int npts)
        {
            var data = new List<Quote>();
            var dt = DateTime.Today;
            for (var i = 0; i < npts; i++)
            {
                var q = new Quote();

                q.Time = dt.AddDays(i);

                if (i > 0)
                    q.Open = data[i - 1].Close;
                else
                    q.Open = 1000;

                q.High = q.Open + rnd.Next(50);
                q.Low = q.Open - rnd.Next(50);

                q.Close = rnd.Next((int)q.Low, (int)q.High);

                q.Volume = rnd.Next(0, 100);
                data.Add(q);
            }

            return data;
        }
    }
}
