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
using C1.Win.C1Themes;
using C1.Win.C1Input;

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
            financialChart1.Series.Add( ma);

            financialChart1.DataSource = data;

            financialChart1.EndUpdate();

            if (!string.IsNullOrEmpty(Singleton.Instance.SelectedItem))
            {
                c1MovingAverage.SelectedIndex = 0;
            }
        }

        private void c1MovingAverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ma.Type = (MovingAverageType)c1MovingAverage.SelectedItem;
        }

        private void period_ValueChanged_1(object sender, EventArgs e)
        {
            ma.Period = Convert.ToInt32(period.Value);
        }
    }
}
