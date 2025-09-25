using C1.Chart;
using C1.Win.Chart;
using C1.Win.Chart.Finance;

using FinancialChartExplorer.Services;

namespace FinancialChartExplorer.Samples
{
    public partial class TrendLines : UserControl
    {
        public TrendLines()
        {
            InitializeComponent();
        }

        DataService dataService;
        TrendLine trendLine;
        DateTime minX;
        DateTime maxX;

        private void OnLoad(object sender, EventArgs e)
        {
            dataService = DataService.GetService();

            var data = dataService.GetSymbolData("box");

            minX = data.Min(p => p.Date);
            maxX = data.Max(p => p.Date);

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "close";
            financialChart1.Series.Add(new FinancialSeries() { Name = "Box" });
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Line;

            trendLine = new TrendLine() { Name = "Trend line" };
            financialChart1.Series.Add(trendLine);
            financialChart1.ToolTip.Content = "{seriesName}\nY: {y:0.00}";
            financialChart1.DataSource = data;

            financialChart1.EndUpdate();

            c1FitType.ItemsDataSource = new FitType[] { FitType.Linear, FitType.Exponent, FitType.Polynom,
                FitType.AverageX, FitType.MinX, FitType.MaxX, FitType.AverageY, FitType.MinY, FitType.MaxY };

            if (!string.IsNullOrEmpty(DataService.SelectedSymbol))
            {
                c1FitType.SelectedIndex = 0;
            }
        }

        private void c1FitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            trendLine.FitType = (FitType)c1FitType.SelectedValue;
        }

        private void c1ChkForecast_CheckedChanged(object sender, EventArgs e)
        {
            if (c1ChkForecast.Checked)
            {
                financialChart1.BeginUpdate();
                financialChart1.BindingX = "Date";
                trendLine.MinX = minX.AddDays(-Convert.ToInt32(this.numBackwardPeriods.Value)).ToOADate();
                trendLine.MaxX = maxX.AddDays(Convert.ToInt32(this.numForwardPeriods.Value)).ToOADate();
                financialChart1.Rebind();
                financialChart1.EndUpdate();
            }
            else
            {
                financialChart1.BeginUpdate();
                financialChart1.BindingX = "date";
                trendLine.MinX = double.NaN;
                trendLine.MaxX = double.NaN;
                financialChart1.Rebind();
                financialChart1.EndUpdate();
            }
        }

        private void numForwardPeriods_ValueChanged_1(object sender, EventArgs e)
        {
            if (c1ChkForecast.Checked)
            {
                trendLine.MaxX = maxX.AddDays(Convert.ToInt32(this.numForwardPeriods.Value)).ToOADate();
            }
        }

        private void numBackwardPeriods_ValueChanged_1(object sender, EventArgs e)
        {
            if (c1ChkForecast.Checked)
            {
                trendLine.MinX = minX.AddDays(-Convert.ToInt32(this.numBackwardPeriods.Value)).ToOADate();
            }
        }
        private void order_ValueChanged_1(object sender, EventArgs e)
        {
            trendLine.Order = Convert.ToInt32(order.Value);
        }
    }
}
