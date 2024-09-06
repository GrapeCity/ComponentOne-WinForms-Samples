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
    public partial class ErrorBar : FlexChartBaseSample
    {
        private ComboBoxEx _cbChartType, _cbErrorAmount, _cbDirection, _cbEndStyle;
        private CheckBoxEx _chbRotate;
        private C1.Win.Chart.ErrorBar _bar;
        private FlexChart flexChart1;

        public ErrorBar()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Sales Forecast Accuracy";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.BindingX = "Name";
            this.flexChart1.AxisX.AxisLine = false;

            _bar = new C1.Win.Chart.ErrorBar()
            {
                Binding = "Sales",
                Name = "Sales",
                ErrorAmount = ErrorAmount.FixedValue,
                ErrorValue = 50,
            };
            this.flexChart1.Series.Add(_bar);
            this.flexChart1.DataSource = SalesDataSource.GetCountrySales();            
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbChartType = ChartControlFactory.BasicChartTypesCombo();
            _cbChartType.SelectedIndexChanged += (s, e) => this.flexChart1.ChartType = (ChartType)Enum.Parse(typeof(ChartType), _cbChartType.SelectedItem.ToString());

            _cbErrorAmount = ControlFactory.EnumBasedCombo(typeof(ErrorAmount), "Error amount");
            _cbErrorAmount.Size = new Size(180, 21);
            _cbErrorAmount.SelectedIndexChanged += _cbErrorAmount_SelectedIndexChanged;

            _cbDirection = ControlFactory.EnumBasedCombo(typeof(ErrorBarDirection), "Direction");
            _cbDirection.SelectedIndexChanged += (s, e) => _bar.Direction = (ErrorBarDirection)Enum.Parse(typeof(ErrorBarDirection), _cbDirection.SelectedItem.ToString());
            
            _cbEndStyle = ControlFactory.EnumBasedCombo(typeof(ErrorBarEndStyle), "End style");
            _cbEndStyle.SelectedIndexChanged += (s, e) => _bar.EndStyle = (ErrorBarEndStyle)Enum.Parse(typeof(ErrorBarEndStyle), _cbEndStyle.SelectedItem.ToString());
            
            _chbRotate = new CheckBoxEx("Rotate");
            _chbRotate.CheckedChanged += (s, e) => this.flexChart1.Rotated = _chbRotate.Checked;

            this.pnlControls.Controls.Add(_cbChartType);
            this.pnlControls.Controls.Add(_cbErrorAmount);
            this.pnlControls.Controls.Add(_cbDirection);
            this.pnlControls.Controls.Add(_cbEndStyle);
            this.pnlControls.Controls.Add(_chbRotate);
        }

        private void _cbErrorAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bar.ErrorAmount = (ErrorAmount)Enum.Parse(typeof(ErrorAmount), _cbErrorAmount.SelectedItem.ToString());
            switch (_bar.ErrorAmount)
            {
                case ErrorAmount.FixedValue:
                    _bar.ErrorValue = 50;
                    break;
                case ErrorAmount.Percentage:
                    _bar.ErrorValue = 0.1;
                    break;
                case ErrorAmount.StandardDeviation:
                    _bar.ErrorValue = 1.0;
                    break;
                case ErrorAmount.Custom:
                    _bar.CustomMinusErrorValue = 20;
                    _bar.CustomPlusErrorValue = 50;
                    break;
            }
        }
    }
}
