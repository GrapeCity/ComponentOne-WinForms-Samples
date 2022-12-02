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

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "close";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Line;

            ma = new MovingAverage();
            financialChart1.Series.Add( ma);

            financialChart1.DataSource = data;

            financialChart1.EndUpdate();

            movingAverage.DataSource = Enum.GetValues(typeof(MovingAverageType));
        }

        private void order_ValueChanged(object sender, EventArgs e)
        {
            // trendLine.Order = (int)order.Value;
        }

        private void period_ValueChanged(object sender, EventArgs e)
        {
            ma.Period = (int)period.Value;
        }

        private void movingAverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ma.Type = (MovingAverageType)movingAverage.SelectedItem;
        }
    }
}
