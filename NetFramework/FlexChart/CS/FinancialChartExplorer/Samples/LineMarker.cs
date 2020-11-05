using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Chart;
using C1.Win.Chart.Finance;

using FinancialChartExplorer.Services;
using C1.Win.Chart.Interaction;

namespace FinancialChartExplorer.Samples
{
    public partial class LineMarker : UserControl
    {
        DataService dataService;
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
            dataService = DataService.GetService();

            var data = dataService.GetSymbolData("box").Take(20);

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.ToolTip.Content = "";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Candlestick;
            financialChart1.DataSource = data;
            financialChart1.Rendered += FinancialChart1_Rendered;
            financialChart1.EndUpdate();


            cbLines.DataSource = Enum.GetValues(typeof(LineMarkerLines));
            cbAlignment.DataSource = Enum.GetValues(typeof(LineMarkerAlignment));
            cbInteraction.DataSource = Enum.GetValues(typeof(LineMarkerInteraction));

        }

        private void FinancialChart1_Rendered(object sender, C1.Win.Chart.RenderEventArgs e)
        {
            if (marker == null)
            {
                marker = new C1.Win.Chart.Interaction.LineMarker(financialChart1);
                marker.Content = "Date: {date}\nOpen: {open}\nHigh: {high}\nLow: {low}\nClose: {close}";
                cbLines.SelectedItem = LineMarkerLines.Both;
                cbAlignment.SelectedItem = LineMarkerAlignment.Auto;
                cbInteraction.SelectedItem = LineMarkerInteraction.Move;
            }
        }

        private void cbLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marker != null)
            {
                marker.Lines = (LineMarkerLines)cbLines.SelectedItem;
            }
        }

        private void cbAlignment_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (marker != null)
            {
                marker.Alignment = (LineMarkerAlignment)cbAlignment.SelectedItem;
            }
        }

        private void cbInteraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marker != null)
            {
                marker.Interaction = (LineMarkerInteraction)cbInteraction.SelectedItem;
            }
        }
    }
}
