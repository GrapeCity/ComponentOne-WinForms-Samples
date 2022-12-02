using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            financialChart1.Series.Add( trendLine);
            financialChart1.ToolTip.Content = "{seriesName}\nY: {y:0.00}";
            financialChart1.DataSource = data;

            financialChart1.EndUpdate();

            fitType.DataSource = new FitType[] { FitType.Linear, FitType.Exponent, FitType.Polynom,
                FitType.AverageX, FitType.MinX, FitType.MaxX, FitType.AverageY, FitType.MinY, FitType.MaxY };
        }

        private void fitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            trendLine.FitType = (FitType)fitType.SelectedItem;
        }

        private void order_ValueChanged(object sender, EventArgs e)
        {
            trendLine.Order = (int)order.Value;
        }

        private void chkForecast_CheckedChanged(object sender, EventArgs e)
        {
            if (chkForecast.Checked)
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

        private void numForwardPeriods_ValueChanged(object sender, EventArgs e)
        {
            if (chkForecast.Checked)
            {
                trendLine.MaxX = maxX.AddDays(Convert.ToInt32(this.numForwardPeriods.Value)).ToOADate();
            }
        }

        private void numBackwardPeriods_ValueChanged(object sender, EventArgs e)
        {
            if (chkForecast.Checked)
            {
                trendLine.MinX = minX.AddDays(-Convert.ToInt32(this.numBackwardPeriods.Value)).ToOADate();
            }
        }
    }
}
