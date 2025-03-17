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
    public partial class AutoLabels : FlexChartBaseSample
    {
        private ComboBoxEx _cbData, _cbOverlapping;
        private LabelEx _lblData, _lblOverlapping;
        private CheckBoxEx _chbLabelBorder;
        private FlexChart flexChart1;

        public AutoLabels()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Scatter;
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.BindingX = "X";
            this.flexChart1.Binding = "Y";
            this.flexChart1.Series.Add(new Series());
            this.flexChart1.DataSource = DataService.CreateDataPoints((x) => x, (y) => y, 100);
            this.flexChart1.DataLabel.Content = "{pointIndex}";
            this.flexChart1.DataLabel.Position = LabelPosition.Auto;
            this.flexChart1.DataLabel.ConnectingLine = true;

            this.flexChart1.Rendered += (s, e) =>
            {
                if (_cbData.SelectedItem != null)
                    flexChart1.Header.Content = "Data: "+ _cbData.SelectedValue.ToString();
            };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbData = ControlFactory.EnumBasedCombo(typeof(DataShape), "Data");
            _cbData.SelectedIndex = 0;
            _cbData.SelectedIndexChanged += _cbData_SelectedIndexChanged;

            _cbOverlapping = ControlFactory.EnumBasedCombo(typeof(LabelOverlapping), "Overlapping");
            _cbOverlapping.SelectedIndexChanged += (s, e) => { flexChart1.DataLabel.Overlapping = (LabelOverlapping)Enum.Parse(typeof(LabelOverlapping), _cbOverlapping.SelectedItem.DisplayText); };

            _chbLabelBorder = new CheckBoxEx("Label Border");
            _chbLabelBorder.CheckedChanged += (s, e) => { flexChart1.DataLabel.Border = _chbLabelBorder.Checked; };

            _lblData = new LabelEx("Data:");
            _lblOverlapping = new LabelEx("Overlapping:");

            this.pnlControls.Controls.Add(_lblData);
            this.pnlControls.Controls.Add(_cbData);
            this.pnlControls.Controls.Add(_lblOverlapping);
            this.pnlControls.Controls.Add(_cbOverlapping);
            this.pnlControls.Controls.Add(_chbLabelBorder);
        }

        private void _cbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rnd = new Random();
            var npts = 100;
            var dataShape = (DataShape)Enum.Parse(typeof(DataShape), _cbData.SelectedItem.DisplayText);
            Func<double, double> yFunc = (i)=>i;
            Func<double, double> xFunc = (i)=>i;
            switch (dataShape)
            {
                case DataShape.Line:
                    yFunc = (i) => (i);
                    break;
                case DataShape.Sin:
                    yFunc = (i) => (Math.Sin(0.1 * i));
                    break;
                case DataShape.Ellipse:
                    xFunc = (i) => Math.Sin((2 * Math.PI * i) / npts);
                    yFunc = (i) => Math.Cos((2 * Math.PI * i) / npts);
                    break;
                case DataShape.Grid:
                    xFunc = (i) => (int)(i % (Math.Sqrt(npts)));
                    yFunc = (i) => (int)(i / (Math.Sqrt(npts)));
                    break;
                case DataShape.Spiral:
                    xFunc = (i) => i * Math.Sin((4 * Math.PI * i) / npts);
                    yFunc = (i) => i * Math.Cos((4 * Math.PI * i) / npts);
                    break;
                case DataShape.Random:
                    yFunc = (i) => rnd.Next(100);
                    break;
            }
            flexChart1.DataSource = DataService.CreateDataPoints(xFunc, yFunc, npts);
        }
    }
    public enum DataShape
    {
        Line,
        Sin,
        Random,
        Ellipse,
        Spiral,
        Grid
    }
}
