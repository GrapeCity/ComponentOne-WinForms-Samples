using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Chart;
using C1.Chart.Finance;
using C1.Win.Chart;
using C1.Win.Chart.Finance;

using DrawingTools.Data;

namespace DrawingTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FlexChart CreateChart(List<Quote> data)
        {
            var chart = new FinancialChart() { Dock = DockStyle.Fill, ChartType = FinancialChartType.Candlestick};
            chart.Margin = new Padding(10, 10, 10, 10);
            chart.PlotMargin = new Padding(50, 32, 10, 0);
            chart.DataSource = data;
            chart.Binding = "High,Low,Open,Close";
            chart.BindingX = "Date";
            chart.AxisX.Min = data[0].Date.ToOADate();
            chart.AxisX.Max = data[data.Count / 4].Date.ToOADate();
            chart.ToolTip.Content = null;
            chart.Series.Add(new FinancialSeries() { SymbolSize = 4 });

            var dl = new DrawingLayer(chart);
            dl.StatusChanged += (s, e) => statusLbl.Text = dl.Status;

            return chart;
        }

        FlexChart CreateOverviewChart(List<Quote> data)
        {
            var chart = new FlexChart() { Dock = DockStyle.Fill, ChartType = ChartType.Line };
            chart.AxisY.Labels = false;
            chart.Margin = new Padding(10, 0, 10, 0);
            chart.PlotMargin = new Padding(50, 0, 10, 0);
            chart.DataSource = data;
            chart.Binding = "Close";
            chart.BindingX = "Date";

            chart.ToolTip.Content = null;
            chart.Series.Add(new Series());
            return chart;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var rnd = new Random();
            var len = 100;
            var pts = new Point[len];

            for (var i = 0; i < len; i++)
                pts[i] = new Point(i, rnd.Next(0, 100));

            var data = DataService.GetFinancialData();

            var chart = CreateChart(data);

            tableLayoutPanel1.Controls.Add(chart);
            tableLayoutPanel1.SetColumnSpan(chart, 2);
            tableLayoutPanel1.SetRow(chart, 1);

            var chart1 = CreateOverviewChart(data);

            var first = true;
            chart1.Rendered += (s1, e1) =>
            {
                if (first)
                {
                    first = false;
                    var sel = new C1.Win.Chart.Interaction.RangeSelector(chart1);
                    sel.LowerValue = data[0].Date.ToOADate();
                    sel.UpperValue = data[data.Count / 4].Date.ToOADate();
                    sel.ValueChanged += (s, _) =>
                    {
                        chart.AxisX.Min = sel.LowerValue;
                        chart.AxisX.Max = sel.UpperValue;
                    };
                }
            };

            tableLayoutPanel1.Controls.Add(chart1);
            tableLayoutPanel1.SetColumnSpan(chart1, 2);
            tableLayoutPanel1.SetRow(chart1, 2);

        }
    }
}
