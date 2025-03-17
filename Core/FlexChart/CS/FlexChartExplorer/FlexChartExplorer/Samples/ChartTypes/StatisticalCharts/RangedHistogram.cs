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
    public partial class RangedHistogram : FlexChartBaseSample
    {
        private C1.Win.Chart.RangedHistogram _rangedHistoSeries;
        private CheckBoxEx _chbByCategory, _chbOverflowBin, _chbUnderflowBin;
        private ComboBoxEx _cbMode;
        private LabelEx _lblMode, _lBinWidth, _lBinNumbers;
        private TextBox _tbBinWidth, _tbBinNumbers, _tbOverflow, _tbUnderflow;
        private FlexChart flexChart1;

        public RangedHistogram()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.RangedHistogram;
            this.flexChart1.Header.Content = "Age Distribution";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            _rangedHistoSeries = new C1.Win.Chart.RangedHistogram()
            {
                Binding = "Age",
                BinWidth = 10,
                BinMode = HistogramBinning.BinWidth,
                OverflowBin = 150,
                UnderflowBin = 0,
            };
            this.flexChart1.Series.Add(_rangedHistoSeries);
            this.flexChart1.AxisX.Title = "Age Groups";
            this.flexChart1.AxisX.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.AxisY.Title = "Number Of Persons";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.DataSource = Demographics.GetAgeData();
            this.flexChart1.Rendered += FlexChart1_Rendered;
        }

        private void FlexChart1_Rendered(object sender, RenderEventArgs e)
        {
            _tbBinWidth.Text = _rangedHistoSeries.BinWidth.ToString("0");
            _tbBinNumbers.Text = _rangedHistoSeries.NumberOfBins.ToString();
            _tbUnderflow.Text = _rangedHistoSeries.UnderflowBin.ToString("0");
            _tbOverflow.Text = _rangedHistoSeries.OverflowBin.ToString("0");
            _cbMode.SelectedIndex = (int)_rangedHistoSeries.BinMode;
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _chbByCategory = new CheckBoxEx("By Category");
            _chbByCategory.CheckedChanged += _chbByCategory_CheckedChanged;

            _cbMode = ControlFactory.EnumBasedCombo(typeof(HistogramBinning), "Mode");
            _cbMode.SelectedIndexChanged += _cbMode_SelectedIndexChanged;

            _chbOverflowBin = new CheckBoxEx("Overflow Bin");
            _chbOverflowBin.CheckedChanged += ChbOverflow_CheckedChanged;
            _tbOverflow = new TextBox() { Margin = new Padding(5), Width=60, Enabled=false};
            _tbOverflow.KeyPress+=(s,e)=> e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            _tbOverflow.TextChanged += TbOverflow_TextChanged;

            _chbUnderflowBin = new CheckBoxEx("Underflow Bin");
            _chbUnderflowBin.CheckedChanged += ChbUnderflow_CheckedChanged;
            _tbUnderflow = new TextBox() { Margin = new Padding(5), Width=60, Enabled=false};
            _tbUnderflow.KeyPress+=(s,e)=> e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            _tbUnderflow.TextChanged += TbUnderflow_TextChanged;

            _lBinWidth = new LabelEx("Bin Width :");
            _tbBinWidth = new TextBox() { Margin = new Padding(5), Width=60, Enabled=false};
            _tbBinWidth.KeyPress += (s, e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            _tbBinWidth.TextChanged += TbBinWidth_TextChanged;

            _lBinNumbers = new LabelEx("Number Of Bins :");
            _tbBinNumbers = new TextBox() { Margin = new Padding(5), Width=60, Enabled=false};
            _tbBinNumbers.KeyPress+=(s,e)=> e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            _tbBinNumbers.TextChanged += TbBinNum_TextChanged;

            _lblMode = new LabelEx("Mode:");

            this.pnlControls.Controls.Add(_chbByCategory);
            this.pnlControls.Controls.Add(_lblMode);
            this.pnlControls.Controls.Add(_chbOverflowBin);
            this.pnlControls.Controls.Add(_tbOverflow);
            this.pnlControls.Controls.Add(_chbUnderflowBin);
            this.pnlControls.Controls.Add(_tbUnderflow);
            this.pnlControls.Controls.Add(_lBinWidth);
            this.pnlControls.Controls.Add(_tbBinWidth);
            this.pnlControls.Controls.Add(_lBinNumbers);
            this.pnlControls.Controls.Add(_tbBinNumbers);
        }

        private void _cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            _rangedHistoSeries.BinMode = (HistogramBinning)Enum.Parse(typeof(HistogramBinning), _cbMode.SelectedItem.DisplayText);
            switch (_rangedHistoSeries.BinMode)
            {
                case HistogramBinning.Automatic:
                    _tbBinWidth.Enabled = false;
                    _tbBinNumbers.Enabled = false;
                    break;
                case HistogramBinning.BinWidth:
                    _tbBinWidth.Enabled = true;
                    _tbBinNumbers.Enabled = false;
                    break;
                case HistogramBinning.NumberOfBins:
                    _tbBinNumbers.Enabled = true;
                    _tbBinWidth.Enabled = false;
                    break;
            }
        }

        private void TbBinNum_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (Int32.TryParse(_tbBinNumbers.Text, out result))
            {
                _rangedHistoSeries.NumberOfBins = result;
            }
        }

        private void TbBinWidth_TextChanged(object sender, EventArgs e)
        {
            double result;
            if (Double.TryParse(_tbBinWidth.Text, out result))
            {
                _rangedHistoSeries.BinWidth = result;
            }
        }

        private void UpdateOverflowBin()
        {
            double result;
            if (_chbOverflowBin.Checked && Double.TryParse(_tbOverflow.Text, out result))
            {
                _rangedHistoSeries.OverflowBin = result;
            }
        }

        private void UpdateUnderflowBin()
        {
            double result;
            if (_chbUnderflowBin.Checked && Double.TryParse(_tbUnderflow.Text, out result))
            {
                _rangedHistoSeries.UnderflowBin = result;
            }
        }

        private void TbUnderflow_TextChanged(object sender, EventArgs e)
        {
            UpdateUnderflowBin();
        }

        private void TbOverflow_TextChanged(object sender, EventArgs e)
        {
            UpdateOverflowBin();
        }

        private void ChbUnderflow_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_chbUnderflowBin.Checked)
            {
                _tbUnderflow.Enabled = true;
                _rangedHistoSeries.ShowUnderflowBin = true;
                UpdateUnderflowBin();
            }
            else
            {
                _rangedHistoSeries.ShowUnderflowBin = false;
                _tbUnderflow.Enabled = false;
            }
        }

        private void ChbOverflow_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_chbOverflowBin.Checked)
            {
                _tbOverflow.Enabled = true;
                _rangedHistoSeries.ShowOverflowBin = true;
                UpdateOverflowBin();
            }
            else
            {
                _rangedHistoSeries.ShowOverflowBin = false;
                _tbOverflow.Enabled = false;
            }
        }
        private void _chbByCategory_CheckedChanged(object sender, EventArgs e)
        {
            if(_chbByCategory.Checked)
            {
                _rangedHistoSeries.BindingX = "AgeGroup";
                _rangedHistoSeries.Binding = "Count";
                _cbMode.Enabled = false;
                _chbOverflowBin.Enabled = false;
                _chbUnderflowBin.Enabled = false;
                _tbOverflow.Enabled = false;
                _tbUnderflow.Enabled = false;
                _tbBinWidth.Enabled = false;
                _tbBinNumbers.Enabled = false;
                //this.flexChart1.AxisX.Title = "House Category By Price";
                //this.flexChart1.AxisY.Title = "Total Sale";
            }
            else
            {
                _rangedHistoSeries.BindingX = "";
                _rangedHistoSeries.Binding = "Age";
                _cbMode.Enabled = true;
                _chbOverflowBin.Enabled = true;
                _chbUnderflowBin.Enabled = true;
                _tbOverflow.Enabled = _chbOverflowBin.Checked;
                _tbUnderflow.Enabled = _chbUnderflowBin.Checked;
                _tbBinWidth.Enabled = _rangedHistoSeries.BinMode==HistogramBinning.BinWidth;
                _tbBinNumbers.Enabled = _rangedHistoSeries.BinMode==HistogramBinning.NumberOfBins;
                //this.flexChart1.AxisX.Title = "Price Of Houses";
                //this.flexChart1.AxisY.Title = "Number Of Houses";
            }
        }
    }
}
