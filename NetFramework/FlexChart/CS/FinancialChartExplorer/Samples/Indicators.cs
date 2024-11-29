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
using C1.Win.C1Themes;
using C1.Win.C1Input;

namespace FinancialChartExplorer.Samples
{
    
    public partial class Indicators : UserControl
    {
        ATR atr = new ATR() { Name = "ATR" };
        RSI rsi = new RSI() { Name = "RSI" };
        CCI cci = new CCI() { Name = "CCI" };
        Macd macd = new Macd() { Name = "MACD, Signal" };
        MacdHistogram macdHistogram = new MacdHistogram() { Name = "MACD Histogram" };
        Stochastic stochastic = new Stochastic() { Name = "%K, %D" };

        WilliamsR wi = new WilliamsR() { Name = "Williams %R" };

        public Indicators()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var dataService = DataService.GetService();
            var data = dataService.GetSymbolData("box");

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "close";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Line;
            financialChart1.DataSource = data;
            financialChart1.Rendered += (s, a) =>
                {
                    financialChart2.AxisX.Min = financialChart1.AxisX.ActualMin;
                    financialChart2.AxisX.Max = financialChart1.AxisX.ActualMax;
                };
            financialChart1.EndUpdate();

            financialChart2.BeginUpdate();
            financialChart2.ChartType = C1.Chart.Finance.FinancialChartType.Line;
            financialChart2.BindingX = "date";
            financialChart2.Binding = "high,low,close";
            financialChart2.Series.Add(atr);
            financialChart2.Legend.Position = C1.Chart.Position.Bottom;
            financialChart2.DataSource = data;
            financialChart2.EndUpdate();
            financialChart2.MouseMove += FinancialChart2_MouseMove;

            c1IndicatorType.ItemsDataSource = new string[]
            {
                "Average True Range",
                "Relative Strength Index",
                "Commodity Channel Index",
                "Williams %R",
                "MACD",
                "Stochastic"
            };

            if (!string.IsNullOrEmpty(Singleton.Instance.SelectedItem))
            {
                c1IndicatorType.SelectedIndex = 0;
            }
            period.Value = atr.Period;

            macd.MacdLineStyle.Stroke = Brushes.Red;
            macd.SignalLineStyle.Stroke = Brushes.Orange;

            stochastic.KLineStyle.Stroke = Brushes.Red;
            stochastic.DLineStyle.Stroke = Brushes.Orange;
            UpdateControls(atr);
        }

        private void FinancialChart2_MouseMove(object sender, MouseEventArgs e)
        {
            var hitTest = financialChart2.HitTest(e.Location);
            var series = hitTest != null ? hitTest.Series : null;
            if (series != null)
            {
                if (series == macd)
                {
                    financialChart2.ToolTip.Content = "Date: {Date}\u000AMACD: {Macd:n2}\u000ASignal: {Signal:n2}";
                }
                else if (series == stochastic)
                {
                    financialChart2.ToolTip.Content = "Date: {Date}\u000A%K: {K:n2}\u000A%D: {D:n2}";
                }
                else
                {
                    financialChart2.ToolTip.Content = "{seriesName}\u000ADate: {Date}\u000AY: {y:n2}\u000AVolume: {Volume:n0}";
                }
            }
        }

        private void c1IndicatorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FinancialSeries ser = null;
            if (c1IndicatorType.SelectedIndex == 0)
                ser = atr;
            else if (c1IndicatorType.SelectedIndex == 1)
                ser = rsi;
            else if (c1IndicatorType.SelectedIndex == 2)
                ser = cci;
            else if (c1IndicatorType.SelectedIndex == 3)
                ser = wi;
            else if (c1IndicatorType.SelectedIndex == 4)
                ser = macd;
            else if (c1IndicatorType.SelectedIndex == 5)
                ser = stochastic;

            UpdateControls(ser);

            if (ser != null && !financialChart2.Series.Contains(ser))
            {
                financialChart2.Series.Clear();
                financialChart2.Series.Add(ser);
                if (ser is Macd)
                {
                    financialChart2.Series.Add(macdHistogram);
                }
            }
        }

        private void UpdateControls(FinancialSeries series)
        {
            string name = series.Name;
            for (int i = 2; i < flowLayoutPanel1.Controls.Count; i++)
            {
                var ctrl = flowLayoutPanel1.Controls[i];
                ctrl.Visible = false;
            }

            if (series is ATR || series is RSI || series is CCI || series is WilliamsR)
            {
                label2.Visible = true;
                period.Visible = true;
            }
            else if (series is Macd)
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                nudFastPeriod.Visible = true;
                nudFastPeriod.Value = macd.FastPeriod;
                nudSlowPeriod.Visible = true;
                nudSlowPeriod.Value = macd.SlowPeriod;
                nudMacdSignalSmoothingPeriod.Visible = true;
                nudMacdSignalSmoothingPeriod.Value = macd.SmoothingPeriod;
            }
            else if (series is Stochastic)
            {
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                nudKPeriod.Visible = true;
                nudKPeriod.Value = stochastic.KPeriod;
                nudDPeriod.Visible = true;
                nudDPeriod.Value = stochastic.DPeriod;
                nudStochasticSmoothingPeriod.Visible = true;
                nudStochasticSmoothingPeriod.Value = stochastic.SmoothingPeriod;
            }
        }

        private void nudFastPeriod_ValueChanged_1(object sender, EventArgs e)
        {
            macd.FastPeriod = Convert.ToInt32(nudFastPeriod.Value);
        }

        private void nudSlowPeriod_ValueChanged_1(object sender, EventArgs e)
        {
            macd.SlowPeriod = Convert.ToInt32(nudSlowPeriod.Value);
        }

        private void nudMacdSignalSmoothingPeriod_ValueChanged_1(object sender, EventArgs e)
        {
            macd.SmoothingPeriod = Convert.ToInt32(nudMacdSignalSmoothingPeriod.Value);
        }

        private void nudKPeriod_ValueChanged_1(object sender, EventArgs e)
        {
            stochastic.KPeriod = Convert.ToInt32(nudKPeriod.Value);
        }

        private void nudDPeriod_ValueChanged_1(object sender, EventArgs e)
        {
            stochastic.DPeriod = Convert.ToInt32(nudDPeriod.Value);
        }

        private void nudStochasticSmoothingPeriod_ValueChanged(object sender, EventArgs e)
        {
            stochastic.SmoothingPeriod = Convert.ToInt32(nudStochasticSmoothingPeriod.Value);
        }

        private void period_ValueChanged_1(object sender, EventArgs e)
        {
            atr.Period = rsi.Period = cci.Period = Convert.ToInt32(period.Value);
        }
    }
}
