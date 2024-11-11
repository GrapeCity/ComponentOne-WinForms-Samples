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
    public partial class Labels : FlexChartBaseSample
    {
        private ComboBoxEx _cbChartType, _cbLabelPosition;
        private CheckBoxEx _chbLabelBorder, _chbConnectingLine;
        private LabelEx _lLabelAngle;
        private NumericUpDownEx _udLabelAngle;
        private FlexChart flexChart1;

        public Labels()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {

            var data = DataService.GetTemperatureData(new string[] { "Tokyo", "London" }, true, 7, true);

            this.flexChart1.Header.Content = "Monthly Mean Temperature(°F)";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.BindingX = "Date";

            foreach (var item in data)
            {
                var series = new Series
                {
                    Name = item.Name,
                    Binding = "HighTemp",
                    DataSource = item.Data,
                };
                this.flexChart1.Series.Add(series);
            }
            this.flexChart1.AxisY.Title = "Temperature (°F)";
            this.flexChart1.AxisY.Style.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.AxisX.AxisLine = false;

            this.flexChart1.DataLabel.Content = "{y}";
            this.flexChart1.DataLabel.Position = LabelPosition.Top;
            this.flexChart1.Rendered += (s, e) => { _cbLabelPosition.SelectedItem = flexChart1.DataLabel.Position; };
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbChartType = ChartControlFactory.BasicChartTypesCombo();
            _cbChartType.SelectedIndexChanged += (s, e) => { flexChart1.ChartType = (ChartType)Enum.Parse(typeof(ChartType), _cbChartType.SelectedValue.ToString()); };

            _cbLabelPosition = ControlFactory.EnumBasedCombo(typeof(LabelPosition), "Label Position");
            _cbLabelPosition.SelectedIndexChanged += (s, e) => { flexChart1.DataLabel.Position = (LabelPosition)Enum.Parse(typeof(LabelPosition), _cbLabelPosition.SelectedValue.ToString()); };

            _chbLabelBorder = new CheckBoxEx("Label Border");
            _chbLabelBorder.CheckedChanged += (s, e) => { flexChart1.DataLabel.Border = _chbLabelBorder.Checked; };

            _chbConnectingLine = new CheckBoxEx("Connecting Line");
            _chbConnectingLine.CheckedChanged += (s, e) => { flexChart1.DataLabel.ConnectingLine = _chbConnectingLine.Checked; };

            _lLabelAngle = new LabelEx("Angle :");
            _udLabelAngle = new NumericUpDownEx { Minimum = -90, Maximum = 90, Value = 0, Increment = 30, Width = 40 };
            _udLabelAngle.ValueChanged += (s, e) => { flexChart1.DataLabel.Angle = (int)_udLabelAngle.Value; };

            this.pnlControls.Controls.Add(_cbChartType);
            this.pnlControls.Controls.Add(_cbLabelPosition);
            this.pnlControls.Controls.Add(_chbLabelBorder);
            this.pnlControls.Controls.Add(_chbConnectingLine);
            this.pnlControls.Controls.Add(_lLabelAngle);
            this.pnlControls.Controls.Add(_udLabelAngle);
        }
    }
}
