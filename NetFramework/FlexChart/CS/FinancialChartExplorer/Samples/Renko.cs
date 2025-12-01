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
using C1.Win.Themes;
using C1.Win.Input;

namespace FinancialChartExplorer.Samples
{
    public partial class Renko : UserControl
    {        
        public Renko()
        {
            InitializeComponent();
        }

        DataService dataService;
        private void OnLoad(object sender, EventArgs e)
        {
            dataService = DataService.GetService();

            c1ComboBox1.ItemsDataSource = dataService.GetCompanies();
            c1ComboBox1.ItemsDisplayMember = "Name";

            c1RangeMode.ItemsDataSource = Enum.GetValues(typeof(RangeMode));
            c1DataFields.ItemsDataSource = Enum.GetValues(typeof(DataFields));


            if (!string.IsNullOrEmpty(DataService.SelectedSymbol))
            {
                c1ComboBox1.SelectedValue = DataService.SelectedSymbol;
                c1RangeMode.SelectedIndex = 0;
                c1DataFields.SelectedIndex = 0;
            }

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Renko;
            financialChart1.EndUpdate();
        }

        private void c1ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCompanyName = c1ComboBox1.SelectedValue.ToString();
            DataService.SelectedSymbol = selectedCompanyName;
            var data = dataService.GetSymbolData(selectedCompanyName);
            financialChart1.DataSource = data;
            financialChart1.Rebind();
        }

        private void c1RangeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            financialChart1.Options.RangeMode = (RangeMode)c1RangeMode.SelectedIndex;
        }

        private void c1DataFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            financialChart1.Options.DataFields = (DataFields)c1DataFields.SelectedIndex;
        }
        private void boxSize_ValueChanged(object sender, EventArgs e)
        {
            financialChart1.Options.BoxSize = Convert.ToInt32(boxSize.Value);
        }
    }
}
