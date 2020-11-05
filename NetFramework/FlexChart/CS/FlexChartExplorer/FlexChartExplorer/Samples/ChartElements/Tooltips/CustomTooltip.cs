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
using C1.Win.C1SuperTooltip;
using FlexChartExplorer.Data;
using System.IO;

namespace FlexChartExplorer.Samples
{
    public partial class CustomTooltip : FlexChartBaseSample
    {
        const int MAX_DIST = 5;
        List<CountrySalesOrders> _data;
        C1SuperTooltip _c1SuperTooltip;
        private FlexChart flexChart1;

        public CustomTooltip()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Gross Sales";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = _data = SalesDataSource.GetSalesOrders();
            this.flexChart1.BindingX = "Name";
            this.flexChart1.Binding = "TotalAmount";
            this.flexChart1.Series.Add(new Series() { Name = "Amount" });
            this.flexChart1.DataLabel.Content = "{y}";
            this.flexChart1.DataLabel.Position = LabelPosition.Top;
            this.flexChart1.MouseMove += FlexChart1_MouseMove;
            //Hide the default tooltip
            this.flexChart1.ToolTip.Active = false;
        }

        private void FlexChart1_MouseMove(object sender, MouseEventArgs e)
        {
            var hitInfo = flexChart1.HitTest(e.Location);
            if (hitInfo != null && hitInfo.Item != null && hitInfo.Distance <= MAX_DIST)
            {
                var item = hitInfo.Item as CountrySalesOrders;
                var subData = from order in item.Orders
                              group order by order.Date.Year into newGroup
                              orderby newGroup.Key
                              select new
                              {
                                  Date = newGroup.Key,
                                  Amount = newGroup.Sum(x => x.Amount)
                              };
                var chart = new FlexChart();
                chart.DataSource = subData;
                chart.BindingX = "Date";
                chart.Header.Content = "Yearly Values : " + item.Name;
                chart.Header.Style.Font = StyleInfo.AxisTitleFont;

                var series = new Series() { Binding = "Amount" };
                series.Style.FillColor = ColorTranslator.FromHtml("#DA3E52");
                chart.Series.Add(series);

                chart.DataLabel.Content = "{y}";
                chart.DataLabel.Position = LabelPosition.Top;
                using (var ms = new MemoryStream())
                {
                    //Save the chart to C1SuperTooltip's Images collection 
                    chart.SaveImage(ms, ImageFormat.Png, 400, 300);
                    var img = Image.FromStream(ms);
                    var imageName = item.Name + ".png";
                    _c1SuperTooltip.Images.Add(imageName, img);
                }
                var html = "<img src='res://" + item.Name + ".png'/>";
                _c1SuperTooltip.SetToolTip(flexChart1, html);
            }
            else
            {
                _c1SuperTooltip.Hide();
                _c1SuperTooltip.Images.Clear();
            }
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _c1SuperTooltip = new C1SuperTooltip() { AutomaticDelay = 0, AutoPopDelay = int.MaxValue };
        }
    }
}
