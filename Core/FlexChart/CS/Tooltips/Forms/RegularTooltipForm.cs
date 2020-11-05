using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tooltips.Data;
using C1.Win.Chart;
using C1.Chart;

namespace Tooltips.Forms
{
    public partial class RegularTooltipForm : Form
    {
        public RegularTooltipForm()
        {
            InitializeComponent();
            this.Text = Tooltips.Resources.AppResources.TitleRegularTooltips;
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

            flexPie.DataSource = FruitDataItem.CreateFruit();
            flexPie.Binding = "Value";
            flexPie.BindingName = "Fruit";
            flexPie.Legend.Position = Position.Bottom;

            CustomizeTooltips();
        }

        private void CustomizeTooltips()
        {
            //Using property names as parameters
            flexChart.ToolTip.Content = Tooltips.Resources.AppResources.FlexChartRegularTooltipContent;
            flexPie.ToolTip.Content = Tooltips.Resources.AppResources.FlexPieRegularTooltipContent;

            //Using predefined parameter names
            //flexChart.ToolTip.Content = "Series: {seriesName}\nIndex: {pointIndex}\nX: {x}\nY: {y}";
            //flexPie.ToolTip.Content = "Index: {pointIndex}\nValue: {value}\nName: {name}";
        }
    }
}
