using C1.Win.Chart.Finance;
using C1.Win.Chart.Interaction;
using FinancialChartExplorer.Services;

namespace FinancialChartExplorer.Samples
{
    public partial class LineMarker : UserControl
    {
        DataService _dataService;
        C1.Win.Chart.Interaction.LineMarker marker;

        public LineMarker()
        {
            InitializeComponent();
            Disposed += LineMarker_Disposed;
        }

        private void LineMarker_Disposed(object sender, EventArgs e)
        {
            if (marker != null)
            {
                marker.Remove();
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            _dataService = DataService.GetService();

            c1CbAlignment.ItemsDataSource = Enum.GetValues(typeof(LineMarkerAlignment));
            c1CbLines.ItemsDataSource = Enum.GetValues(typeof(LineMarkerLines));
            c1CbInteraction.ItemsDataSource = Enum.GetValues(typeof(LineMarkerInteraction));
            var data = _dataService.GetSymbolData("box").Take(20);

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.ToolTip.Content = "";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Candlestick;
            financialChart1.DataSource = data;
            financialChart1.Rendered += FinancialChart1_Rendered;
            financialChart1.EndUpdate();
        }

        private void FinancialChart1_Rendered(object sender, C1.Win.Chart.RenderEventArgs e)
        {
            if (marker == null)
            {
                marker = new C1.Win.Chart.Interaction.LineMarker(financialChart1);
                marker.Content = "Date: {date}\nOpen: {open}\nHigh: {high}\nLow: {low}\nClose: {close}";
                marker.LineColor = Color.Gray;
                c1CbLines.SelectedValue = LineMarkerLines.Both;
                c1CbAlignment.SelectedValue = LineMarkerAlignment.Auto;
                c1CbInteraction.SelectedValue = LineMarkerInteraction.Move;
            }
        }

        private void c1CbLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marker != null)
            {
                marker.Lines = (LineMarkerLines)c1CbLines.SelectedValue;
            }
        }

        private void c1CbAlignment_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (marker != null)
            {
                marker.Alignment = (LineMarkerAlignment)c1CbAlignment.SelectedValue;
            }
        }

        private void c1CbInteraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marker != null)
            {
                marker.Interaction = (LineMarkerInteraction)c1CbInteraction.SelectedValue;
            }
        }
    }
}
