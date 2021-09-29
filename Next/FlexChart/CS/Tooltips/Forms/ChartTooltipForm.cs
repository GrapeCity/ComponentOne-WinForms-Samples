using C1.Chart;
using C1.Win.Chart;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tooltips.Data;

namespace Tooltips.Forms
{
    public partial class ChartTooltipForm : Form
    {
        const double MAX_DIST = 5;
        List<Order> _orders;
        IEnumerable<object> _orderTotalByCountry;
        DateTime _start, _end;
        Random _rnd;
        public ChartTooltipForm()
        {
            InitializeComponent();
            this.Text = Tooltips.Resources.AppResources.TitleChartTooltips;
            _start = new DateTime(2013, 1, 1);
            _end = new DateTime(2015, 12, 31);
            _orders = new List<Order>();
            _rnd = new Random();
            c1SuperTooltip1.AutomaticDelay = 0;
            c1SuperTooltip1.AutoPopDelay = int.MaxValue;
            InitData();
            InitChart();
        }

        private void InitChart()
        {
            flexChart.Series.Clear();
            flexChart.DataSource = _orderTotalByCountry;
            flexChart.BindingX = "XValue";
            flexChart.Legend.Position = C1.Chart.Position.Bottom;
            flexChart.AxisY.AxisLine = true;
            flexChart.AxisY.Title = "Order Total";
            Series orderTotalSeries = new Series { Name = "Order Total", Binding = "YValue" };
            flexChart.Series.Add(orderTotalSeries);
            flexChart.DataLabel.Content = "{y}";
            flexChart.DataLabel.Position = LabelPosition.Top;
            flexChart.MouseMove += flexChart_MouseMove;
            flexChart.ToolTip.Active = false;
        }

        void flexChart_MouseMove(object sender, MouseEventArgs e)
        {
            var hitTestInfo = flexChart.HitTest(e.Location);
            if (hitTestInfo != null && hitTestInfo.Item != null && hitTestInfo.Distance <= MAX_DIST)
            {

                var item = hitTestInfo.Item as FlexPoint;
                // Get Detailed data for the data point hit
                var data = from order in _orders
                           where order.ShippedCountry.Equals(item.XValue)
                           group order by order.OrderDate.Year into newGroup
                           orderby newGroup.Key
                           select new
                           {
                               Year = newGroup.Key,
                               Amount = newGroup.Sum(order => order.Amount)
                           };

                //Prepare chart for the data point hit
                var chart = new FlexChart();
                chart.DataSource = data;
                chart.Footer.Content =  Tooltips.Resources.AppResources.OrderChartFooter + item.XValue;
                chart.BindingX = "Year";
                chart.Font = new Font("Segoe UI", flexChart.Font.Size);
                Series orderAmountSeries = new Series { Name = "Amount", Binding = "Amount" };
                orderAmountSeries.Style.FillColor = ColorTranslator.FromHtml("#DA3E52");
                chart.Series.Add(orderAmountSeries);
                chart.Legend.Position = Position.None;
                chart.AxisX.MajorUnit = 1;
                chart.DataLabel.Content = "{y}";
                chart.DataLabel.Position = LabelPosition.Top;
                using (var ms = new MemoryStream())
                {
                    //Save the chart to C1SuperTooltip's Images collection 
                    chart.SaveImage(ms, ImageFormat.Png, 400, 300);
                    var img = Image.FromStream(ms);
                    var imageName = item.XValue + ".png";
                    c1SuperTooltip1.Images.Add(imageName, img);
                }

                string html = "<img src='res://" + item.XValue + ".png'/>";
                c1SuperTooltip1.SetToolTip(flexChart, html);
            }
            else
            {
                c1SuperTooltip1.Hide();
                c1SuperTooltip1.Images.Clear();
            }
        }

        private void InitData()
        {
            string[] countries = "India|China|USA|Japan|France|Germany|Russia|Australia|Brazil".Split('|');
            _orders = new List<Order>();
            for (int i = 0; i < 50; i++)
            {
                _orders.Add(new Order
                {
                    OrderId = i + 500,
                    Amount = _rnd.NextDouble() > 0.8 ? _rnd.Next(500) : _rnd.Next(150),
                    ShippedCountry = GetRandomString(countries),
                    OrderDate = RandomDay()
                });
            }

            _orderTotalByCountry = from order in _orders
                                   group order by order.ShippedCountry into newGroup
                                   orderby newGroup.Key
                                   select new FlexPoint
                                   {
                                       XValue = newGroup.Key,
                                       YValue = newGroup.Sum(order => order.Amount)
                                   };
        }

        private string GetRandomString(string[] arr)
        {
            return arr[_rnd.Next(arr.Length)];
        }

        private DateTime RandomDay()
        {
            int range = (_end - _start).Days;
            return _start.AddDays(_rnd.Next(range));
        }

    }
}
