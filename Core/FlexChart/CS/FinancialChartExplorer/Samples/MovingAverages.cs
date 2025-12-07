using C1.Chart;
using C1.Win.Chart.Finance;

using FinancialChartExplorer.Services;

namespace FinancialChartExplorer.Samples
{
    public partial class MovingAverages : UserControl
    {
        public MovingAverages()
        {
            InitializeComponent();
        }
        DataService dataService;
        MovingAverage ma;

        private void OnLoad(object sender, EventArgs e)
        {
            dataService = DataService.GetService();

            var data = dataService.GetSymbolData("box");
            c1MovingAverage.ItemsDataSource = Enum.GetValues(typeof(MovingAverageType));

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "close";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Line;

            ma = new MovingAverage();
            financialChart1.Series.Add(ma);

            financialChart1.DataSource = data;

            financialChart1.EndUpdate();

            if (!string.IsNullOrEmpty(DataService.SelectedSymbol))
            {
                c1MovingAverage.SelectedIndex = 0;
            }
        }

        private void c1MovingAverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ma.Type = (MovingAverageType)c1MovingAverage.SelectedValue;
        }

        private void period_ValueChanged_1(object sender, EventArgs e)
        {
            ma.Period = Convert.ToInt32(period.Value);
        }
    }
}
