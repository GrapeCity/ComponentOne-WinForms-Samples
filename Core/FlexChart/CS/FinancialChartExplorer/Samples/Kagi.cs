using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Chart.Finance;
using C1.Win.Chart.Finance;

using FinancialChartExplorer.Services;

namespace FinancialChartExplorer.Samples
{
    public partial class Kagi: UserControl
    {
        public Kagi()
        {
            InitializeComponent();
        }

        DataService dataService;

        private void OnLoad(object sender, EventArgs e)
        {
            dataService = DataService.GetService();

            comboBoxSymbol.DataSource = dataService.GetCompanies();
            comboBoxSymbol.DisplayMember = "Name";

            rangeMode.DataSource = Enum.GetValues(typeof(RangeMode));
            dataFields.DataSource = Enum.GetValues(typeof(DataFields));

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Kagi;
            financialChart1.EndUpdate();
        }

        private void comboBoxSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = dataService.GetSymbolData(comboBoxSymbol.SelectedValue.ToString());
            financialChart1.DataSource = data;
            financialChart1.Rebind();
        }

        private void rangeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            financialChart1.Options.RangeMode = (RangeMode)rangeMode.SelectedValue;
            if (financialChart1.Options.RangeMode == RangeMode.Fixed)
            {
                reversalAmount.Minimum = 1;
                reversalAmount.Maximum = 14;
                reversalAmount.Increment = 1;
                reversalAmount.DecimalPlaces = 0;
            }
            else if (financialChart1.Options.RangeMode == RangeMode.ATR)
            {
                reversalAmount.Minimum = 2;
                reversalAmount.Maximum = 14;
                reversalAmount.Increment = 1;
                reversalAmount.DecimalPlaces = 0;
            }
            else
            {
                reversalAmount.Minimum = 0;
                reversalAmount.Maximum = 1;
                reversalAmount.DecimalPlaces = 2;
                reversalAmount.Increment = (decimal)0.05;
                if (reversalAmount.Value >= 1)
                    reversalAmount.Value = (decimal)0.05;
            }
        }

        private void dataFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            financialChart1.Options.DataFields = (DataFields)dataFields.SelectedValue;
        }

        private void reversalAmount_ValueChanged(object sender, EventArgs e)
        {
            financialChart1.Options.ReversalAmount = (double)reversalAmount.Value;
        }
    }
}
