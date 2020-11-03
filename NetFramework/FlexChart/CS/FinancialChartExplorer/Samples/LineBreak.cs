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

            comboBoxSymbol.DataSource = dataService.GetCompanies();
            comboBoxSymbol.DisplayMember = "Name";

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.LineBreak;
            financialChart1.EndUpdate();
        }

        private void comboBoxSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = dataService.GetSymbolData(comboBoxSymbol.SelectedValue.ToString());
            financialChart1.DataSource = data;
            financialChart1.Rebind();
        }

        private void newLineBreaks_ValueChanged(object sender, EventArgs e)
        {
            financialChart1.Options.NewLineBreaks = (int)newLineBreaks.Value;
        }
    }
}
