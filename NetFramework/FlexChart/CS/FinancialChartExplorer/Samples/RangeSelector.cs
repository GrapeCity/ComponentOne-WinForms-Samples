using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Chart.Finance;

using FinancialChartExplorer.Services;

namespace FinancialChartExplorer.Samples
{
    public partial class RangeSelector : UserControl
    {
        C1.Win.Chart.Interaction.RangeSelector rs;

        public RangeSelector()
        {
            InitializeComponent();
        }

        private void RangeSelector_Load(object sender, EventArgs e)
        {
            var dataService = DataService.GetService();
            var data = dataService.GetSymbolData("fb");

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.ToolTip.Content = "Date: {date}\nOpen: {open}\nHigh: {high}\nLow: {low}\nClose: {close}";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Candlestick;
            financialChart1.DataSource = data;
            financialChart1.EndUpdate();

            financialChart2.BeginUpdate();
            financialChart2.BindingX = "date";
            financialChart2.Binding = "close";
            financialChart2.Series.Add(new FinancialSeries());
            financialChart2.ChartType = C1.Chart.Finance.FinancialChartType.Line;
            financialChart2.DataSource = data;
            financialChart2.ToolTip.Content = null;
            financialChart2.EndUpdate();

            financialChart2.Rendered += financialChart2_Rendered;
        }

        void financialChart2_Rendered(object sender, C1.Win.Chart.RenderEventArgs e)
        {
            if (rs == null && financialChart2.AxisX.ActualMin != financialChart2.AxisX.ActualMax)
            {
                rs = new C1.Win.Chart.Interaction.RangeSelector(financialChart2);
                rs.ValueChanged += rs_ValueChanged;
            }
            rs.Styles.BarStyle.SelectedAreaColor = Color.FromArgb(50, Color.Gray);
        }

        void rs_ValueChanged(object sender, EventArgs e)
        {
            financialChart1.AxisX.Min = rs.LowerValue;
            financialChart1.AxisX.Max = rs.UpperValue;
        }
    }
}
