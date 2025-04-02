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
using C1.Win.C1Themes;

namespace FinancialChartExplorer.Samples
{
    public partial class Kagi: UserControl
    {
        private decimal reversalMinValue;
        private decimal reversalMaxValue;
        public Kagi()
        {
            InitializeComponent();
        }

        DataService DataService;

        private void OnLoad(object sender, EventArgs e)
        {
            DataService = DataService.GetService();

            c1ComboBox1.ItemsDataSource = DataService.GetCompanies();
            c1ComboBox1.ItemsDisplayMember = "Name";

            c1RangeMode.ItemsDataSource = Enum.GetValues(typeof(RangeMode));
            c1DataFields.ItemsDataSource = Enum.GetValues(typeof(DataFields));

            if (!string.IsNullOrEmpty(DataService.SelectedSymbol))
            {
                c1ComboBox1.SelectedItem = DataService.SelectedSymbol;
                c1RangeMode.SelectedIndex = 0;
                c1DataFields.SelectedIndex = 0;
            }

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Kagi;
            financialChart1.EndUpdate();
        }

        private void c1ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCompanyName = c1ComboBox1.SelectedItem.ToString();
            DataService.SelectedSymbol = selectedCompanyName;
            var data = DataService.GetSymbolData(selectedCompanyName);
            financialChart1.DataSource = data;
            financialChart1.Rebind();
        }

        
        private void c1RangeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            financialChart1.Options.RangeMode = (RangeMode)c1RangeMode.SelectedIndex;

            if (financialChart1.Options.RangeMode == RangeMode.Fixed)
            {
                SetC1NumericEditRange(1, 14, 1);
            }
            else if (financialChart1.Options.RangeMode == RangeMode.ATR)
            {
                SetC1NumericEditRange(2, 14, 1);
            }
            else
            {
                SetC1NumericEditRange(0, 1, 0.05m);
                if ((decimal)reversalAmount1.Value >= 1)
                    reversalAmount1.Value = 0.05m;
            }
        }

        private void SetC1NumericEditRange(decimal minValue, decimal maxValue, decimal increment)
        {
            reversalMinValue = minValue;
            reversalMaxValue = maxValue;
            reversalAmount1.Increment = increment;
        }

        private void c1DataFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            financialChart1.Options.DataFields = (DataFields)c1DataFields.SelectedIndex;
        }

        private void reversalAmount1_ValueChanged(object sender, EventArgs e)
        {
            if ((decimal)reversalAmount1.Value < reversalMinValue)
            {
                reversalAmount1.Value = reversalMinValue;
            }
            else if ((decimal)reversalAmount1.Value > reversalMaxValue)
            {
                reversalAmount1.Value = reversalMaxValue;
            }

            financialChart1.Options.ReversalAmount = Convert.ToDouble(reversalAmount1.Value);
        }
    }
}
