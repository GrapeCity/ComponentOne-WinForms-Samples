using C1.Chart;
using C1.Win.Chart;
using System;
using System.Windows.Forms;
using Tooltips.Data;

namespace Tooltips.Forms
{
    public partial class HTMLTooltipForm : Form
    {
        const double MAX_DIST = 5;
        public HTMLTooltipForm()
        {
            InitializeComponent();
            this.Text = Tooltips.Resources.AppResources.TitleHTMLTooltips;
            c1SuperTooltip1.AutomaticDelay = 0;
            c1SuperTooltip1.AutoPopDelay = int.MaxValue;
            InitCharts();
        }

        private void InitCharts()
        {
            flexChart.Series.Clear();
            flexChart.DataSource = CategoricalPoint.GetCategoricalData();
            flexChart.BindingX = "Name";
            flexChart.Series.Add(new Series { Name = "Sales", Binding = "Sales" });
            flexChart.Series.Add(new Series { Name = "Expenses", Binding = "Expenses", ChartType = ChartType.LineSymbols });
            flexChart.LegendToggle = true;
            flexChart.AxisX.Title = "Month";
            flexChart.AxisY.Title = "Value";
            flexChart.Legend.Position = Position.Bottom;
            //Hide the Default Tooltips
            flexChart.ToolTip.Active = false;
 
            flexPie.DataSource = FruitDataItem.CreateFruit();
            flexPie.Binding = "Value";
            flexPie.BindingName = "Fruit";
            flexPie.Legend.Position = Position.Bottom;
            //Hide the Default Tooltips
            flexPie.ToolTip.Active = false;
        }

        private void flexChart_MouseMove(object sender, MouseEventArgs e)
        {
            var hitTestInfo = flexChart.HitTest(e.Location);
            if (hitTestInfo == null)
                return;
            if (hitTestInfo.Item != null && hitTestInfo.Distance <= MAX_DIST)
            {
                var item = hitTestInfo.Item as CategoricalPoint;
                var htmlTemplate = @"<p><b>Month: </b>{0}
                                   <br/>
                                   <b>Sales: </b>{1}
                                   <br/>
                                   <b>Expenses: </b>{2}
                                   </p>";
                var htmlContent = String.Format(htmlTemplate, item.Name, item.Sales, item.Expenses);
                c1SuperTooltip1.SetToolTip(flexChart, htmlContent);
            }
            else
                c1SuperTooltip1.Hide();
        }

        private void flexPie_MouseMove(object sender, MouseEventArgs e)
        {
            var hitTestInfo = flexPie.HitTest(e.Location);
            if (hitTestInfo == null)
                return;
            if (hitTestInfo.Item != null && hitTestInfo.Distance <= MAX_DIST)
            {
                var item = hitTestInfo.Item as FruitDataItem;
                var htmlTemplate = @"<p><b>Fruit: </b>{0}
                                   <br/>
                                   <b>Value: </b>{1}
                                   </p>";
                var s2 = String.Format(htmlTemplate, item.Fruit, item.Value);
                c1SuperTooltip1.SetToolTip(flexPie, s2);
            }
            else
                c1SuperTooltip1.Hide();
        }
    }
}
