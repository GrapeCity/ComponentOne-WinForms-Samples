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

            comboBoxSymbol.DataSource = dataService.GetCompanies();
            comboBoxSymbol.DisplayMember = "Name";

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "Date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.Options = new PointAndFigureOptions() { ReversalAmount = 3 };

            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.Series[0].Style.StrokeColor = Color.Black;
            financialChart1.Series[0].AltStyle = new C1.Win.Chart.ChartStyle() { StrokeColor = Color.Red };
            financialChart1.Series[0].Style.StrokeWidth = 1.5f;

            financialChart1.AxisX.MajorGrid = true;

            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.PointAndFigure;
            financialChart1.EndUpdate();

            scaling.DataSource = Enum.GetValues(typeof(PointAndFigureScaling));
            dataFields.DataSource = new DataFields[] { DataFields.Close, DataFields.HighLow };
            boxSize.Enabled = false;
            period.Enabled = false;

        }

        private void comboBoxSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = dataService.GetSymbolData(comboBoxSymbol.SelectedValue.ToString());
            financialChart1.DataSource = data;
            financialChart1.Rebind();
        }

        private void scaling_SelectedIndexChanged(object sender, EventArgs e)
        {
            var scale = (PointAndFigureScaling)scaling.SelectedValue;
            ((PointAndFigureOptions)financialChart1.Options).Scaling = scale;
            boxSize.Enabled = scale == PointAndFigureScaling.Fixed;
            period.Enabled = scale == PointAndFigureScaling.Dynamic;
        }

        private void dataFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            financialChart1.Options.DataFields = (DataFields)dataFields.SelectedValue;
        }

        private void boxSize_ValueChanged(object sender, EventArgs e)
        {
            financialChart1.Options.BoxSize = (int)boxSize.Value;
        }

        private void reversal_ValueChanged(object sender, EventArgs e)
        {
            financialChart1.Options.ReversalAmount = (double)reversal.Value;
        }

        private void period_ValueChanged(object sender, EventArgs e)
        {
            ((PointAndFigureOptions)financialChart1.Options).Period = (int)period.Value;
        }

        private void squareGrid_CheckedChanged(object sender, EventArgs e)
        {
            ((PointAndFigureOptions)financialChart1.Options).SquareGrid = squareGrid.Checked;
        }
    }
}
