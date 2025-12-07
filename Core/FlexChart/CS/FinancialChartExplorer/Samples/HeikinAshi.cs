using C1.Win.Chart.Finance;
using FinancialChartExplorer.Services;

namespace FinancialChartExplorer.Samples
{
    public partial class HeikinAshi : UserControl
    {
        public HeikinAshi()
        {
            InitializeComponent();
        }

        DataService? _dataService;

        private void HeikinAshi_Load(object sender, EventArgs e)
        {
            _dataService = DataService.GetService();

            c1ComboBox1.ItemsDataSource = _dataService.GetCompanies();
            c1ComboBox1.ItemsDisplayMember = "Name";
            if (!string.IsNullOrEmpty(DataService.SelectedSymbol))
            {
                c1ComboBox1.SelectedValue = DataService.SelectedSymbol;
            }

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.HeikinAshi;
            financialChart1.ToolTip.Content = "Date: {date}\nOpen: {open}\nHigh: {high}\nLow: {low}\nClose: {close}";
            financialChart1.EndUpdate();
        }

        private void c1ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c1ComboBox1.SelectedValue != null)
            {
                string selectedCompanyName = c1ComboBox1.SelectedValue.ToString();
                DataService.SelectedSymbol = selectedCompanyName;
                var data = _dataService.GetSymbolData(selectedCompanyName);
                financialChart1.DataSource = data;
                financialChart1.Rebind();
            }
        }
    }
}
