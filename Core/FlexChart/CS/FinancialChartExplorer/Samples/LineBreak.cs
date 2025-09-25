using C1.Win.Chart.Finance;

using FinancialChartExplorer.Services;

namespace FinancialChartExplorer.Samples
{
    public partial class LineBreak : UserControl
    {
        public LineBreak()
        {
            InitializeComponent();
        }

        DataService _dataService;
        private void LineBreak_Load(object sender, EventArgs e)
        {
            _dataService = DataService.GetService();
            DoubleBuffered = true;
            c1ComboBox1.ItemsDataSource = _dataService.GetCompanies();
            c1ComboBox1.ItemsDisplayMember = "Name";

            // Set the value of c1ComboBox1 based on the Singleton's SelectedItem
            if (!string.IsNullOrEmpty(DataService.SelectedSymbol))
            {
                c1ComboBox1.SelectedValue = DataService.SelectedSymbol;
            }

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.LineBreak;
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

        private void newLineBreaks_ValueChanged(object sender, EventArgs e)
        {
            financialChart1.Options.NewLineBreaks = Convert.ToInt32(newLineBreaks.Value);
        }
    }
}
