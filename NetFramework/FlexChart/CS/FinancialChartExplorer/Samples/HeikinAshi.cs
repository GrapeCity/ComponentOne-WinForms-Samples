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
using C1.Win.C1Themes;
using C1.Win.Ribbon;
using static C1.Util.Win.Win32;

namespace FinancialChartExplorer.Samples
{
    public partial class HeikinAshi : UserControl
    {
        public HeikinAshi()
        {
            InitializeComponent();
        }

        DataService DataService;

        private void HeikinAshi_Load(object sender, EventArgs e)
        {
            DataService = DataService.GetService();

            c1ComboBox1.ItemsDataSource = DataService.GetCompanies();
            c1ComboBox1.ItemsDisplayMember = "Name";

            if (!string.IsNullOrEmpty(DataService.SelectedSymbol))
            {
                c1ComboBox1.SelectedItem = DataService.SelectedSymbol;
            }

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.HeikinAshi;
            financialChart1.ToolTip.Content = "Date: {date}\nOpen: {open}\nHigh: {high}\nLow: {low}\nClose: {close}";
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
    }
}
