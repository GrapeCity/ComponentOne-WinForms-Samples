using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Win.Chart;
using C1.Win.Chart.Designer;

namespace DesignerInPlaceDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Add(CreateChart1(), 0, 0);

            tableLayoutPanel1.Controls.Add(CreateChart2(), 1, 0);

            tableLayoutPanel1.Controls.Add(CreateChart3(), 0, 1);

            tableLayoutPanel1.Controls.Add(CreateChart4(), 1, 1);
        }

        FlexChart CreateChart1()
        {
            var pts = new SampleData.DataPoint[10];
            for (var i = 0; i < pts.Length; i++)
                pts[i] = new SampleData.DataPoint() { X = i, Y1 = i * i, Y2 = i * i * i };

            var chart = new FlexChart() { BindingX = "X", Binding = "Y1", ChartType = C1.Chart.ChartType.LineSymbols, DataSource = pts, Dock = DockStyle.Fill };
            chart.Series.Add(new Series() { Name = "y=f(x)" });

            chart.Click += Chart_Click;

            var designer = new ChartDesigner(chart);

            return chart;
        }

        FlexChart CreateChart2()
        {
            var chart = new FlexChart() { BindingX = "Country", DataSource = SampleData.GetCountryData(), Dock = DockStyle.Fill };
            chart.Series.Add(new Series() { Name = "Sales", Binding = "Sales" });
            chart.Series.Add(new Series() { Name = "Expenses", Binding = "Expenses" });

            chart.Click += Chart_Click;

            var designer = new ChartDesigner(chart);
            return chart;
        }


        FlexPie CreateChart3()
        {
            var chart = new FlexPie() { BindingName = "Country", Binding = "Sales", DataSource = SampleData.GetCountryData(), Dock = DockStyle.Fill };
            chart.Click += Chart_Click;

            var designer = new ChartDesigner(chart);
            return chart;
        }

        FlexChart CreateChart4()
        {
            var rnd = new Random();
            var pts = new SampleData.DataPoint[10];
            for (var i = 0; i < pts.Length; i++)
                pts[i] = new SampleData.DataPoint() { X = i, Y1 = i * i, Y2 = rnd.NextDouble() };

            var chart = new FlexChart() { BindingX = "X", Binding = "Y1,Y1", ChartType = C1.Chart.ChartType.Bubble, DataSource = pts, Dock = DockStyle.Fill };
            chart.Series.Add(new Series() { Name = "bubbles" });
            chart.Click += Chart_Click;

            var designer = new ChartDesigner(chart);

            return chart;
        }

        private void Chart_Click(object sender, EventArgs e)
        {
            foreach (FlexChartBase chart in tableLayoutPanel1.Controls)
            {
                if (chart != sender)
                {
                    var designer = ChartDesigner.GetDesigner(chart);
                    if (designer != null)
                        designer.Close();
                }
            }
        }
    }

    class SampleData
    {
        static Random rnd = new Random();

        public class DataItem
        {
            public string Country { get; set; }
            public int Sales { get; set; }
            public int Expenses { get; set; }
            public int Downloads { get; set; }
        }

        public class Quote
        {
            public DateTime Date { get; set; }
            public double High { get; set; }
            public double Low { get; set; }
            public double Open { get; set; }
            public double Close { get; set; }
            public double Volume { get; set; }
        }

        public class DataPoint
        {
            public double X { get; set; }
            public double Y1 { get; set; }
            public double Y2 { get; set; }
            public double Y3 { get; set; }
        }

        public static PointF[] GetPoints(int n = 100)
        {
            var pts = new PointF[n];

            for (var i = 0; i < n; i++)
            {
                pts[i] = new PointF(i, (float)rnd.NextDouble());
            }

            return pts;
        }

        public static List<DataItem> GetCountryData()
        {
            var data = new List<DataItem>();
            var countries = "US,Canada,Mexico,UK,Germany,France,Italy,Japan,Korea,China,Autralia,New Zealand".Split(',').Take(6).ToArray();


            for (var i = 0; i < countries.Length; i++)
            {
                data.Add(new DataItem()
                {
                    Country = countries[i],
                    Sales = (int)(rnd.NextDouble() * 10000),
                    Expenses = (int)(rnd.NextDouble() * 5000),
                    Downloads = (int)(rnd.NextDouble() * 20000)
                });
            }
            //
            return data;
        }

        public static List<Quote> GetFinancialData(int n = 50)
        {
            var data = new List<Quote>();
            var startDate = new DateTime(2017, 1, 1);
            var temp = 50;
            for (int i = 0; i < n; i++)
            {
                if (i % 7 == 0)
                    temp += i < 70 ? rnd.Next(5, 15) : -rnd.Next(1, 15);
                var open = rnd.Next(temp - 15, temp + 15);
                var close = rnd.Next(temp - 15, temp + 15);
                var high = open > close ? rnd.Next(open + 1, open + 10) : rnd.Next(close + 1, close + 10);
                var low = open > close ? rnd.Next(close - 10, close - 1) : rnd.Next(open - 10, open - 1);
                data.Add(new Quote
                {
                    Date = startDate.AddDays(i),
                    High = high,
                    Low = low,
                    Open = open,
                    Close = close,
                    Volume = rnd.Next(50, 200),
                });
            }
            return data;
        }
    }
}
