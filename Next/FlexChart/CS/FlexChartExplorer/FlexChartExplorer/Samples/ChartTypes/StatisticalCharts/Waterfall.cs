using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using BaseExplorer;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class Waterfall : FlexChartBaseSample
    {
        private CheckBoxEx _chbRelData, _chbConnLine, _chbTotal, _chbInterTotals;
        private C1.Win.Chart.Waterfall _waterfall;
        private FlexChart flexChart1;

        public Waterfall()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.BindingX = "Month";
            _waterfall = new C1.Win.Chart.Waterfall() {Binding="PChange", Name = "Increment,Decrement,Total"};
            _waterfall.IntermediateTotalLabels = new string[] { "Q1", "Q2", "Q3", "Q4" };
            _waterfall.IntermediateTotalPositions = new int[] { 3, 6, 9, 12 };
            _waterfall.Start = 0.15;
            _waterfall.StartLabel = (DateTime.Now.Year - 2).ToString(); _waterfall.TotalLabel = (DateTime.Now.Year-1).ToString();

            _waterfall.StartStyle.FillColor = Color.FromArgb(unchecked((int)0xff7dc7ed));
            _waterfall.FallingStyle.FillColor = Color.FromArgb(unchecked((int)0xffdd2714));
            _waterfall.RisingStyle.FillColor = Color.FromArgb(unchecked((int)0xff0f9d58));
            _waterfall.RisingStyle.StrokeColor = Color.FromArgb(unchecked((int)0xff0f9d58));
            _waterfall.IntermediateTotalStyle.FillColor = Color.FromArgb(unchecked((int)0xff7dc7ed));
            _waterfall.TotalStyle.FillColor = Color.FromArgb(unchecked((int)0xff7dc7ed));
            _waterfall.ConnectorLineStyle.StrokeColor = Color.FromArgb(unchecked((int)0xff030303));
            _waterfall.ConnectorLineStyle.StrokeDashPattern = new float[] { 3, 3 };
            _waterfall.ConnectorLineStyle.StrokeWidth = 2;

            this.flexChart1.Series.Add(_waterfall);

            this.flexChart1.DataSource = FinancialDataSource.GetProfitStatement();
            this.flexChart1.Header.Content = string.Format("{0} : Profit Analysis", DateTime.Now.Year-1);
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.AxisX.LabelAngle = 30;
            this.flexChart1.AxisY.Format = "p0";
            this.flexChart1.AxisY.Title = "Profit Percent(%)";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            

            _chbRelData = new CheckBoxEx("Relative Data");
            _chbRelData.CheckedChanged += (s, e) => _waterfall.RelativeData = _chbRelData.Checked;
            
            _chbConnLine = new CheckBoxEx("Connector Lines");
            _chbConnLine.CheckedChanged += (s, e) => _waterfall.ConnectorLines = _chbConnLine.Checked;
           
            _chbTotal = new CheckBoxEx("Show Total");
            _chbTotal.CheckedChanged += (s, e) => _waterfall.ShowTotal = _chbTotal.Checked;
            
            _chbInterTotals = new CheckBoxEx("Show Intermediate Totals");
            _chbInterTotals.CheckedChanged += (s, e) => _waterfall.ShowIntermediateTotal = _chbInterTotals.Checked;
            
            this.pnlControls.Controls.Add(_chbRelData);
            this.pnlControls.Controls.Add(_chbConnLine);
            this.pnlControls.Controls.Add(_chbTotal);
            this.pnlControls.Controls.Add(_chbInterTotals);
        }
    }
}
