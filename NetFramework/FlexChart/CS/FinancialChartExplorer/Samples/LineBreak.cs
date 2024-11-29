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
using C1.Win.C1Input;

namespace FinancialChartExplorer.Samples
{
    public partial class LineBreak : UserControl
    {
        public LineBreak()
        {
            InitializeComponent();
        }

        DataService dataService;

        private void HeikinAshi_Load(object sender, EventArgs e)
        {
            dataService = DataService.GetService();
            DoubleBuffered=true;
            c1ComboBox1.ItemsDataSource = dataService.GetCompanies();
            c1ComboBox1.ItemsDisplayMember = "Name";

            // Set the value of c1ComboBox1 based on the Singleton's SelectedItem
            if (!string.IsNullOrEmpty(Singleton.Instance.SelectedItem))
            {
                c1ComboBox1.SelectedItem =  Singleton.Instance.SelectedItem;
            }

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.LineBreak;
            financialChart1.EndUpdate();
        }
        private void c1ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCompanyName = c1ComboBox1.SelectedItem.ToString();
            Singleton.Instance.SelectedItem = selectedCompanyName;
            var data = dataService.GetSymbolData(selectedCompanyName);
            financialChart1.DataSource = data;
            financialChart1.Rebind();
        }
        private void newLineBreaks_ValueChanged(object sender, EventArgs e)
        {
            financialChart1.Options.NewLineBreaks = Convert.ToInt32(newLineBreaks.Value);
        }
    }
}
