using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Chart.Finance;

using FinancialChartExplorer.Services;

namespace FinancialChartExplorer.Samples
{
    public partial class Volume : UserControl
    {
        public Volume()
        {
            InitializeComponent();
        }

        DataService dataService;

        private void OnLoad(object sender, EventArgs e)
        {
            var sample = this.Tag as Sample;
            Debug.Assert(sample!=null);
            
            dataService = DataService.GetService();

            comboBoxSymbol.DataSource = dataService.GetCompanies();
            comboBoxSymbol.DisplayMember = "Name";

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Series.Add(new FinancialSeries());

            if (sample.Name == "ColumnVolume")
            {
                financialChart1.Binding = "close,volume";
                financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.ColumnVolume;
                financialChart1.ToolTip.Content = "Date: {date}\nClose: {close}\nVolume: {volume}";
            }
            else
            {
                if (sample.Name == "EquiVolume")
                    financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.EquiVolume;
                else if (sample.Name == "CandleVolume")
                    financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.CandleVolume;
                else
                    financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.ArmsCandleVolume;

                financialChart1.Binding = "high,low,open,close,volume";
                financialChart1.ToolTip.Content = "Date: {date}\nOpen: {open}\nHigh: {high}\nLow: {low}\nClose: {close}\nVolume: {volume}";
            }

            financialChart1.EndUpdate();
        }

        private void comboBoxSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = dataService.GetSymbolData(comboBoxSymbol.SelectedValue.ToString(), 30);
            financialChart1.DataSource = data;
            financialChart1.Rebind();
        }
    }
}
