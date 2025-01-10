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
using C1.Win.SuperTooltip;
using FlexChartExplorer.Data;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class TrendLine : FlexChartBaseSample
    {
        private ComboBoxEx _cbFitType;
        private CheckBoxEx _chbShowEquation;
        private CheckBoxEx _chbShowRSquared;
        private C1.Win.Chart.TrendLine _trendLine;
        private C1SuperLabel _slEquationLabel;
        private NumericUpDownEx _udOrder;
        private LabelEx _lOrder, _lblFitType;
        private UnitsCost _clickedItem;
        private FlexChart flexChart1;

        public TrendLine()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Relationship between Production and Cost";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = DataService.GetUnitCostData();
            this.flexChart1.ChartType = ChartType.LineSymbols;
            this.flexChart1.BindingX = "Units";
            var closePrice = new Series
            {
                Binding = "Cost",
                Name="Cost",
            };
            _trendLine = new C1.Win.Chart.TrendLine()
            {
                Name="Trend Line",
                Binding = "Cost",
                Order = 4,
                FitType = FitType.Linear,
            };
            this.flexChart1.Series.Add(closePrice);
            this.flexChart1.Series.Add(_trendLine);
            this.flexChart1.AxisX.Title = "Quantity";
            this.flexChart1.AxisX.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.AxisY.Title = "Per Unit Cost";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.Rendered += FlexChart1_Rendered;
            this.flexChart1.MouseUp += (s, e) => { _clickedItem = null; };
            this.flexChart1.MouseLeave += (s, e) => { _clickedItem = null; };
            this.flexChart1.MouseDown += FlexChart1_MouseDown;
            this.flexChart1.MouseMove += FlexChart1_MouseMove;
        }

        private void FlexChart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_clickedItem != null)
            {
                var newY = flexChart1.PointToData(new Point(e.X, e.Y)).Y;
                if (newY > 0 && newY < 10000)
                {
                    _clickedItem.Cost = (int)newY;
                    flexChart1.Rebind();
                }
            }
        }

        private void FlexChart1_MouseDown(object sender, MouseEventArgs e)
        {
            var ht = flexChart1.HitTest(new Point(e.X, e.Y));
            if(ht.Distance<3 && ht.X!=null && ht.Y != null)
            {
                _clickedItem = (UnitsCost)ht.Item;
            }
        }

        private void FlexChart1_Rendered(object sender, RenderEventArgs e)
        {
            _slEquationLabel.Location = new Point((int)flexChart1.PlotRect.Left + 30, (int)flexChart1.PlotRect.Top + 10);
            //Change Equation Label text
            _slEquationLabel.Text = GetEquationString(_trendLine);
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            //Init ShowEquation CheckBox
            _chbShowEquation = new CheckBoxEx("Show Equation") { Checked=true};
            _chbShowEquation.CheckedChanged += (s, e) =>
            {
                _slEquationLabel.Visible = _chbShowEquation.Checked || _chbShowRSquared.Checked;
                    _slEquationLabel.Text = GetEquationString(_trendLine);
            };

            //Init ShowRSquared CheckBox
            _chbShowRSquared = new CheckBoxEx("Show R2") { Checked = true };
            _chbShowRSquared.CheckedChanged += (s, e) =>
            {
                _slEquationLabel.Visible = _chbShowEquation.Checked || _chbShowRSquared.Checked;
                _slEquationLabel.Text = GetEquationString(_trendLine);
            };

            //Init Fit Type ComboBox
            _cbFitType = ControlFactory.EnumBasedCombo(typeof(FitType), "FitType");
            _cbFitType.SelectedIndex = 0;
            _cbFitType.SelectedIndexChanged += (s, e) => 
            {
                _trendLine.FitType = (FitType)Enum.Parse(typeof(FitType), _cbFitType.SelectedItem.DisplayText);
                _lOrder.Visible = _udOrder.Visible = _trendLine.FitType == FitType.Fourier || _trendLine.FitType == FitType.Polynom;
            };
            //Init Order
            _lOrder = new LabelEx("Order :") { Visible = false};
            _udOrder = new NumericUpDownEx() { Minimum = 2, Maximum = 9, Value = 4, Increment = 1, Visible=false };
            _udOrder.ValueChanged += (s, e) => { _trendLine.Order = Convert.ToInt32(_udOrder.Value); };

            //Init Equation SuperLabel
            _slEquationLabel = new C1SuperLabel() { AutoSize = true, UseMnemonic = true };

            _lblFitType = new LabelEx("Fut Type:");

            this.pnlControls.Controls.Add(_chbShowEquation);
            this.pnlControls.Controls.Add(_chbShowRSquared);
            this.pnlControls.Controls.Add(_lblFitType);
            this.pnlControls.Controls.Add(_cbFitType);
            this.pnlControls.Controls.Add(_lOrder);
            this.pnlControls.Controls.Add(_udOrder);
            this.flexChart1.Controls.Add(_slEquationLabel);
        }
        string GetEquationString(C1.Win.Chart.TrendLine trendLine)
        {
            string result = String.Empty;
            int X = 1, Y0 = 0;

            switch (trendLine.FitType)
            {
                case FitType.Linear:
                    result = String.Format("y={1:0.0000}x{0:+0.0000;-0.0000;+0}", trendLine.Coefficients[0], trendLine.Coefficients[1]);
                    break;
                case FitType.Exponent:
                    result = String.Format("y={0:0.0000}e<sup>{1:0.0000}x</sup>", trendLine.Coefficients[0], trendLine.Coefficients[1]);
                    break;
                case FitType.Logarithmic:
                    result = String.Format("y={1:0.0000}ln(x){0:+0.0000;-0.0000;+0}", trendLine.Coefficients[0], trendLine.Coefficients[1]);
                    break;
                case FitType.Power:
                    result = String.Format("y={0:0.0000}x<sup>{1:0.0000}</sup>", trendLine.Coefficients[0], trendLine.Coefficients[1]);
                    break;
                case FitType.Polynom:
                    result = String.Format("{1:+0.0000;-0.0000;+0}x{0:+0.0000;-0.0000;+0}", trendLine.Coefficients[0], trendLine.Coefficients[1]);
                    for (int i = 2; i <= Convert.ToInt32(_udOrder.Value); i++)
                        result = result.Insert(0, String.Format("{0:+0.000;-0.0000;+0}x<sup>{1}</sup>", trendLine.Coefficients[i], i));
                    result = result.Remove(0, 1).Insert(0, "y=");
                    break;
                case FitType.Fourier:
                    result = String.Format("{0:+0.0000;-0.0000;+0}", trendLine.Coefficients[0]);
                    for (int i = 2, a = 1; i <= Convert.ToInt32(_udOrder.Value); i++, a = i % 2 == 0 ? a + 1 : a)
                        result += String.Format("{0:+0.000;-0.0000;+0}{2}({1}x)", trendLine.Coefficients[i - 1], a == 1 ? "" : a.ToString(), (i) % 2 == 0 ? "cos" : "sin");
                    result = result.Remove(0, 1).Insert(0, "y=");
                    break;
                case FitType.MaxX: result = "x=" + trendLine.GetValues(X).Max(); break;
                case FitType.MinX: result = "x=" + trendLine.GetValues(X).Min(); break;
                case FitType.MaxY: result = "y=" + trendLine.GetValues(Y0).Max(); break;
                case FitType.MinY: result = "y=" + trendLine.GetValues(Y0).Min(); break;
                case FitType.AverageX: result = "x=" + trendLine.GetValues(X).Average(); break;
                case FitType.AverageY: result = "y=" + trendLine.GetValues(Y0).Average(); break;
            }

            if (_chbShowRSquared.Checked)
            {
                var rsq = trendLine.GetRegressionStatistics().Rsq;
                if(!double.IsNaN(rsq)) 
                    result += $"<br>R2 = {rsq:0.0000}";
            }
            return result;
        }
    }
}
