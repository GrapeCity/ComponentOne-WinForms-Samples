using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using FlexChartExplorer.Data;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class NumericLabels : FlexChartBaseSample
    {
        private CheckBoxEx cbRoundLimits, cbLabelMin, cbLabelMax;
        private FlexChart flexChart1;
        private Func<double, double> _yFunc = x => Math.Round(Math.Sin(x) * Math.Tan(x), 3);

        public NumericLabels()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            flexChart1.BeginUpdate();

            flexChart1.Header.Content = "Signal Intensity";
            flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            flexChart1.ChartType = ChartType.Line;

            flexChart1.DataSource = DataService.CreateDataPoints(x => x, _yFunc, 360);
            flexChart1.BindingX = "X";
            flexChart1.Binding = "Y";
            flexChart1.Series.Add(new Series());

            flexChart1.AxisX.Title = "Time";

            flexChart1.EndUpdate();
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            Chart = flexChart1;

            cbLabelMin = new CheckBoxEx("Label Min");
            cbLabelMin.CheckedChanged += (s, e) => { flexChart1.AxisY.LabelMin = cbLabelMin.Checked; };

            cbLabelMax = new CheckBoxEx("Label Max");
            cbLabelMax.CheckedChanged += (s, e) => { flexChart1.AxisY.LabelMax = cbLabelMax.Checked; };

            cbRoundLimits = new CheckBoxEx("Round Limits");
            cbRoundLimits.CheckedChanged += (s, e) => 
            { 
                flexChart1.AxisY.RoundLimits = cbRoundLimits.Checked; 
                cbLabelMin.Visible = cbLabelMax.Visible = !cbRoundLimits.Checked;
            };

            pnlControls.Controls.Add(cbRoundLimits);

            pnlControls.Controls.Add(cbLabelMin);
            pnlControls.Controls.Add(cbLabelMax);
        }
    }
}
