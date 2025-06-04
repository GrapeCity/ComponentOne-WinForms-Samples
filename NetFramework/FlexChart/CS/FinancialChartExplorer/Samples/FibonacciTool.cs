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
using C1.Chart;
using C1.Win.Chart;
using C1.Win.C1Themes;
using C1.Win.C1Input;

namespace FinancialChartExplorer.Samples
{
    public partial class FibonacciTool : UserControl
    {
        FinancialSeries defaultSeries = new FinancialSeries() { Name = "Box", Binding = "high,low,open,close" };
        Fibonacci fibonacci = new Fibonacci() { Binding = "close" };
        FibonacciArcs arcs = new FibonacciArcs() { Binding = "close", StartX = 46, StartY = 19.75, EndX = 54, EndY = 17.1 };
        FibonacciFans fans = new FibonacciFans() { Binding = "close", StartX = 10, StartY = 18.12, EndX = 32, EndY = 20.53 };
        FibonacciTimeZones timeZones = new FibonacciTimeZones() { Binding = "close", StartX = 0, EndX = 3 };
        Series currentFibonacciTool = null;
        C1.Win.Chart.Interaction.RangeSelector rangeSelector;

        public FibonacciTool()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var dataService = DataService.GetService();
            var data = dataService.GetSymbolData("box");

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Series.Add(defaultSeries);
            financialChart1.Series.Add(arcs);
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Candlestick;
            financialChart1.DataSource = data;
            financialChart1.EndUpdate();

            c1CmdToolType.ItemsDataSource = new string[]
            {
               "Acrs",
               "Fans",
               "Retracements",
               "Time Zone"
            };

            c1CmbLabelPosition.ItemsDataSource = Enum.GetNames(typeof(LabelPosition)).ToList();

            if (!string.IsNullOrEmpty(DataService.SelectedSymbol))
            {
                c1CmbLabelPosition.SelectedIndex = 0;
                c1CmdToolType.SelectedIndex = 0;
            }

            UpdateControls(arcs);
        }

        private void c1CmdToolType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Series ser = null;
            if (c1CmdToolType.SelectedIndex == 0)
                ser = arcs;
            else if (c1CmdToolType.SelectedIndex == 1)
                ser = fans;
            else if (c1CmdToolType.SelectedIndex == 2)
                ser = fibonacci;
            else if (c1CmdToolType.SelectedIndex == 3)
                ser = timeZones;

            UpdateControls(ser);
            if (ser != null && !financialChart1.Series.Contains(ser))
            {
                financialChart1.Series.Remove(currentFibonacciTool);
                financialChart1.Series.Add(ser);
            }

            currentFibonacciTool = ser;

            // After tool type changes, update range selector visibility
            UpdateRangeSelectorVisibility();
        }

        private void UpdateControls(Series series)
        {
            for (int i = 6; i < flowLayoutPanel1.Controls.Count; i++)
            {
                var ctrl = flowLayoutPanel1.Controls[i];
                ctrl.Visible = false;
            }

            if (series is FibonacciArcs || series is FibonacciFans)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                nudStartX.Visible = true;
                nudEndX.Visible = true;
                nudStartY.Visible = true;
                nudEndY.Visible = true;

                if (series is FibonacciArcs)
                {
                    var ser = series as FibonacciArcs;
                    nudStartX.Value = Convert.ToDecimal(ser.StartX);
                    nudEndX.Value = Convert.ToDecimal(ser.EndX);
                    nudStartY.Value = Convert.ToDecimal(ser.StartY);
                    nudEndY.Value = Convert.ToDecimal(ser.EndY);
                    c1CmbLabelPosition.SelectedItem = ser.LabelPosition.ToString();
                }
                else if (series is FibonacciFans)
                {
                    var ser = series as FibonacciFans;
                    nudStartX.Value = Convert.ToDecimal(ser.StartX);
                    nudEndX.Value = Convert.ToDecimal(ser.EndX);
                    nudStartY.Value = Convert.ToDecimal(ser.StartY);
                    nudEndY.Value = Convert.ToDecimal(ser.EndY);
                    c1CmbLabelPosition.SelectedItem = ser.LabelPosition.ToString();
                }
            }
            else if (series is Fibonacci)
            {
                var ser = series as Fibonacci;
                c1CbRangeSelector.Visible = true;
                c1CbUptrend.Visible = true;
                c1CbUptrend.Checked = ser.Uptrend;
                c1CmbLabelPosition.SelectedItem = ser.LabelPosition.ToString();
            }
            else if (series is FibonacciTimeZones)
            {
                var ser = series as FibonacciTimeZones;
                label2.Visible = true;
                label3.Visible = true;
                nudStartX.Visible = true;
                nudEndX.Visible = true;

                nudStartX.Value = Convert.ToDecimal(ser.StartX);
                nudEndX.Value = Convert.ToDecimal(ser.EndX);
                c1CmbLabelPosition.SelectedItem = ser.LabelPosition.ToString();
            }
        }

        private void nudStartX_ValueChanged_1(object sender, EventArgs e)
        {
            if (currentFibonacciTool == arcs)
            {
                arcs.StartX = nudStartX.Value;
            }
            else if (currentFibonacciTool == fans)
            {
                fans.StartX = nudStartX.Value;
            }
            else if (currentFibonacciTool == timeZones)
            {
                timeZones.StartX = nudStartX.Value;
            }
        }

        private void nudEndX_ValueChanged_1(object sender, EventArgs e)
        {
            if (currentFibonacciTool == arcs)
            {
                arcs.EndX = nudEndX.Value;
            }
            else if (currentFibonacciTool == fans)
            {
                fans.EndX = nudEndX.Value;
            }
            else if (currentFibonacciTool == timeZones)
            {
                timeZones.EndX = nudEndX.Value;
            }
        }

        private void nudStartY_ValueChanged_1(object sender, EventArgs e)
        {
            if (currentFibonacciTool == arcs)
            {
                arcs.StartY = nudStartY.Value;
            }
            else if (currentFibonacciTool == fans)
            {
                fans.StartY = nudStartY.Value;
            }
        }

        private void nudEndY_ValueChanged_1(object sender, EventArgs e)
        {
            if (currentFibonacciTool == arcs)
            {
                arcs.EndY = nudEndY.Value;
            }
            else if (currentFibonacciTool == fans)
            {
                fans.EndY = nudEndY.Value;
            }
        }

        private void c1CmbLabelPosition_SelectedItemChanged(object sender, EventArgs e)
        {
            if (currentFibonacciTool == null) return;
            var position = (LabelPosition)Enum.Parse(typeof(LabelPosition), c1CmbLabelPosition.SelectedItem.ToString());
            if (currentFibonacciTool is Fibonacci)
            {
                ((Fibonacci)currentFibonacciTool).LabelPosition = position;
            }
            else if (currentFibonacciTool is FibonacciExtension)
            {
                ((FibonacciExtension)currentFibonacciTool).LabelPosition = position;
            }
        }

        private void c1CbUptrend_CheckedChanged(object sender, EventArgs e)
        {
            if (currentFibonacciTool == fibonacci)
            {
                fibonacci.Uptrend = c1CbUptrend.Checked;
            }
        }

        private void c1CbRangeSelector_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRangeSelectorVisibility();
        }
        private void UpdateRangeSelectorVisibility()
        {
            // Only apply if the current tool is the Fibonacci retracement tool
            if (currentFibonacciTool == fibonacci)
            {
                if (c1CbRangeSelector.Checked)
                {
                    if (rangeSelector == null)
                    {
                        rangeSelector = new C1.Win.Chart.Interaction.RangeSelector(financialChart1);
                        rangeSelector.ValueChanged += RangeSelector_ValueChanged;
                    }
                    if (!financialChart1.Controls.Contains(rangeSelector))
                    {
                        financialChart1.Controls.Add(rangeSelector);
                        rangeSelector.BringToFront();
                    }
                }
                else
                {
                    if (rangeSelector != null && financialChart1.Controls.Contains(rangeSelector))
                    {
                        financialChart1.Controls.Remove(rangeSelector);
                    }
                }
            }
            else
            {
                // If the current tool is not fibonacci retracement, ensure range selector is not visible
                if (rangeSelector != null && financialChart1.Controls.Contains(rangeSelector))
                {
                    financialChart1.Controls.Remove(rangeSelector);
                }
            }
        }

        private void RangeSelector_ValueChanged(object sender, EventArgs e)
        {
            financialChart1.BeginUpdate();
            fibonacci.MinX = rangeSelector.LowerValue;
            fibonacci.MaxX = rangeSelector.UpperValue;
            rangeSelector.Styles.BarStyle.SelectedAreaColor = Color.FromArgb(50, Color.Gray);
            financialChart1.EndUpdate();
        }
    }
}
