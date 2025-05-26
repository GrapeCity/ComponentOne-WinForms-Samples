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
using C1.Win.C1Input;

namespace FinancialChartExplorer.Samples
{
    public partial class PointAndFigure : UserControl
    {
        public PointAndFigure()
        {
            InitializeComponent();
        }

        DataService dataService;
        private void OnLoad(object sender, EventArgs e)
        {
            dataService = DataService.GetService();

            c1ComboBox1.ItemsDataSource = dataService.GetCompanies();
            c1ComboBox1.ItemsDisplayMember = "Name";

            c1DataFields.ItemsDataSource = new DataFields[] { DataFields.Close, DataFields.HighLow };
            c1Scaling.ItemsDataSource = Enum.GetValues(typeof(PointAndFigureScaling));

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "Date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.Options = new PointAndFigureOptions() { ReversalAmount = 3 };

            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.Series[0].Style.StrokeColor = Color.Gray;
            financialChart1.Series[0].AltStyle = new C1.Win.Chart.ChartStyle() { StrokeColor = Color.Red };
            financialChart1.Series[0].Style.StrokeWidth = 1.5f;

            financialChart1.AxisX.MajorGrid = true;

            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.PointAndFigure;
            financialChart1.EndUpdate();

            if (!string.IsNullOrEmpty(DataService.SelectedSymbol))
            {
                c1ComboBox1.SelectedItem = DataService.SelectedSymbol;
                c1DataFields.SelectedIndex = 0;
                c1Scaling.SelectedIndex = 0;
            }

            boxSize.Enabled = false;
            period.Enabled = false;
        }
        
        private void c1ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCompanyName = c1ComboBox1.SelectedItem.ToString();
            DataService.SelectedSymbol = selectedCompanyName;
            var data = dataService.GetSymbolData(selectedCompanyName);
            financialChart1.DataSource = data;
            financialChart1.Rebind();
        }

        private void c1Scaling_SelectedIndexChanged(object sender, EventArgs e)
        {
            var scale = (PointAndFigureScaling)Enum.Parse(typeof(PointAndFigureScaling), c1Scaling.Value.ToString());
            ((PointAndFigureOptions)financialChart1.Options).Scaling = scale;
            boxSize.Enabled = scale == PointAndFigureScaling.Fixed;
            period.Enabled = scale == PointAndFigureScaling.Dynamic;
        }

        private void c1DataFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            financialChart1.Options.DataFields = (DataFields)Enum.Parse(typeof(DataFields), c1DataFields.Value.ToString());
        }
        private void c1SquareGrid_CheckedChanged(object sender, EventArgs e)
        {
            ((PointAndFigureOptions)financialChart1.Options).SquareGrid = c1SquareGrid.Checked;
        }
        private void reversal_ValueChanged_1(object sender, EventArgs e)
        {
            financialChart1.Options.ReversalAmount = Convert.ToDouble(reversal.Value);
        }

        private void boxSize_ValueChanged_1(object sender, EventArgs e)
        {
            financialChart1.Options.BoxSize = Convert.ToInt32(boxSize.Value);
        }

        private void period_ValueChanged_1(object sender, EventArgs e)
        {
            ((PointAndFigureOptions)financialChart1.Options).Period = Convert.ToInt32(period.Value);
        }
    }
}
