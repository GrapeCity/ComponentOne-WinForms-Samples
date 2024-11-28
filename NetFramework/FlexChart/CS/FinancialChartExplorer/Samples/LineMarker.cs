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
using C1.Win.C1Themes;

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

            c1CbAlignment.ItemsDataSource = Enum.GetValues(typeof(LineMarkerAlignment));
            c1CbLines.ItemsDataSource = Enum.GetValues(typeof(LineMarkerLines));
            c1CbInteraction.ItemsDataSource = Enum.GetValues(typeof(LineMarkerInteraction));
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
        }

        private void FinancialChart1_Rendered(object sender, C1.Win.Chart.RenderEventArgs e)
        {
            if (marker == null)
            {
                marker = new C1.Win.Chart.Interaction.LineMarker(financialChart1);
                marker.Content = "Date: {date}\nOpen: {open}\nHigh: {high}\nLow: {low}\nClose: {close}";
                marker.LineColor = Color.Gray;
                c1CbLines.SelectedItem = LineMarkerLines.Both;
                c1CbAlignment.SelectedItem = LineMarkerAlignment.Auto;
                c1CbInteraction.SelectedItem = LineMarkerInteraction.Move;
            }
        }

        private void c1CbLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marker != null)
            {
                marker.Lines = (LineMarkerLines)c1CbLines.SelectedItem;
            }
        }

        private void c1CbAlignment_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (marker != null)
            {
                marker.Alignment = (LineMarkerAlignment)c1CbAlignment.SelectedItem;
            }
        }

        private void c1CbInteraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marker != null)
            {
                marker.Interaction = (LineMarkerInteraction)c1CbInteraction.SelectedItem;
            }
        }
    }
}
