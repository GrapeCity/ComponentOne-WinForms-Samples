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
using C1.Win.Themes;
using C1.Win.Input;

namespace FinancialChartExplorer.Samples
{
    public partial class Overlays : UserControl
    {
        FinancialSeries defaultSeries;
        BollingerBands bollingerBands;
        Envelopes envelopes;
        IchimokuCloud ichimokuCloud;
        Alligator alligator;
        ZigZag zigZag;
        public Overlays()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var dataService = DataService.GetService();
            var data = dataService.GetSymbolData("box");
            
            InitOverlays();
            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close";
            financialChart1.Series.Add(defaultSeries);
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Candlestick;
            financialChart1.DataSource = data;

            financialChart1.EndUpdate();

            c1OverlayType.ItemsDataSource = new string[]
            {
               "Bollinger Bands",
               "Envelopes",
               "Ichimoku Cloud",
               "Alligator",
               "ZigZag"
            };
            
            c1MvaType.ItemsDataSource = Enum.GetNames(typeof(C1.Chart.Finance.MovingAverageType)).ToList();

            if (!string.IsNullOrEmpty(DataService.SelectedSymbol))
            {
                c1OverlayType.SelectedIndex = 0;
                c1MvaType.SelectedIndex = 0;
            }
            UpdateControls(bollingerBands);
        }

        private void InitOverlays()
        {
            defaultSeries = new FinancialSeries() { Name = "Box" };
            bollingerBands = new BollingerBands() { Name = "Bollinger Bands" };
            envelopes = new Envelopes() { Name = "Envoloper" };
            ichimokuCloud = new IchimokuCloud()
            {
                Name = "Ichimoku Cloud",
                ConversionLineStyle = new C1.Win.Chart.ChartStyle() { StrokeColor = Color.Orange },
                BaseLineStyle = new C1.Win.Chart.ChartStyle() { StrokeColor = Color.Blue },
                LaggingLineStyle = new C1.Win.Chart.ChartStyle() { StrokeColor = Color.Black },
                LeadingSpanALineStyle = new C1.Win.Chart.ChartStyle() { StrokeColor = Color.LightGreen },
                LeadingSpanBLineStyle = new C1.Win.Chart.ChartStyle() { StrokeColor = Color.IndianRed },
                BullishCloudColor = new SolidBrush(Color.LightGreen),
                BearishCloudColor = new SolidBrush(Color.IndianRed)
            };

            zigZag = new ZigZag() { Name = "ZigZag" };
            zigZag.Style.StrokeColor = Color.Green;
            zigZag.Style.StrokeWidth = 0.8f;

            alligator = new Alligator()
            {
                Name = "Alligator",
                JawLineStyle = new C1.Win.Chart.ChartStyle() { StrokeColor = Color.LightGreen },
                TeethLineStyle = new C1.Win.Chart.ChartStyle() { StrokeColor = Color.IndianRed },
                LipsLineStyle = new C1.Win.Chart.ChartStyle() { StrokeColor = Color.Black },
            };
        }
        
        private void c1OverlayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FinancialSeries ser = null;
            if (c1OverlayType.SelectedIndex == 0)
                ser = bollingerBands;
            else if (c1OverlayType.SelectedIndex == 1)
                ser = envelopes;
            else if (c1OverlayType.SelectedIndex == 2)
                ser = ichimokuCloud;
            else if (c1OverlayType.SelectedIndex == 3)
                ser = alligator;
            else if (c1OverlayType.SelectedIndex == 4)
                ser = zigZag;

            UpdateControls(ser);
            if (ser != null && !financialChart1.Series.Contains(ser))
            {
                financialChart1.Series.Clear();
                financialChart1.Series.Add(defaultSeries);
                financialChart1.Series.Add(ser);
            }
        }
        private void UpdateControls(FinancialSeries series)
        {
            string name = series.Name;
            for (int i = 4; i < flowLayoutPanel1.Controls.Count; i++)
            {
                var ctrl = flowLayoutPanel1.Controls[i];
                ctrl.Visible = false;
            }

            if (series is BollingerBands)
            {
                label3.Visible = true;
                nudMultiplier.Visible = true;
                nudMultiplier.Value = bollingerBands.Multiplier;

            }
            else if (series is Envelopes)
            {
                label4.Visible = true;
                label5.Visible = true;

                nudSize.Visible = true;
                c1MvaType.Visible = true;
            }
            else if (series is IchimokuCloud)
            {
                label2.Visible = false;
                period.Visible = false;

                conversionLabel.Visible = true;
                conversionPeriod.Visible = true;

                baseLabel.Visible = true;
                basePeriod.Visible = true;

                leadingLabel.Visible = true;
                leadingPeriod.Visible = true;

                laggingLabel.Visible = true;
                laggingPeriod.Visible = true;
            }
            else if (series is Alligator)
            {
                label2.Visible = false;
                period.Visible = false;

                jawPeriodLabel.Visible = true;
                jawPeriodNumberic.Visible = true;

                teethPeriodLabel.Visible = true;
                teethPeriodNumberic.Visible = true;

                lipsPeriodLabel.Visible = true;
                lipsPeriodNumberic.Visible = true;
            }
            else if (series is ZigZag)
            {
                label2.Visible = false;
                period.Visible = false;

                zigZagDistanceLabel.Visible = true;
                zigZagDistanceNumberic.Visible = true;
            }
        }

        private void c1MvaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            envelopes.Type = (C1.Chart.Finance.MovingAverageType)Enum.Parse(typeof(C1.Chart.Finance.MovingAverageType), c1MvaType.Text);
        }

        private void nudMultiplier_ValueChanged_1(object sender, EventArgs e)
        {
            bollingerBands.Multiplier = Convert.ToInt32(nudMultiplier.Value);
        }

        private void nudSize_ValueChanged_1(object sender, EventArgs e)
        {
            envelopes.Size = Convert.ToDouble(nudSize.Value) / 100;
        }

        private void conversionPeriod_ValueChanged(object sender, EventArgs e)
        {
            ichimokuCloud.ConversionPeriod = Convert.ToInt32(conversionPeriod.Value);
        }

        private void basePeriod_ValueChanged(object sender, EventArgs e)
        {
            ichimokuCloud.BasePeriod = Convert.ToInt32(basePeriod.Value);
        }

        private void leadingPeriod_ValueChanged(object sender, EventArgs e)
        {
            ichimokuCloud.LeadingPeriod = Convert.ToInt32(leadingPeriod.Value);
        }

        private void laggingPeriod_ValueChanged(object sender, EventArgs e)
        {
            ichimokuCloud.LaggingPeriod = Convert.ToInt32(laggingPeriod.Value);
        }

        private void lipsPeriodNumberic_ValueChanged_1(object sender, EventArgs e)
        {
            alligator.LipsPeriod = Convert.ToInt32(lipsPeriodNumberic.Value);
        }

        private void teethPeriodNumberic_ValueChanged_1(object sender, EventArgs e)
        {
            alligator.TeethPeriod = Convert.ToInt32(teethPeriodNumberic.Value);
        }

        private void jawPeriodNumberic_ValueChanged_1(object sender, EventArgs e)
        {
            alligator.JawPeriod = Convert.ToInt32(jawPeriodNumberic.Value);
        }

        private void zigZagDistanceNumberic_ValueChanged_1(object sender, EventArgs e)
        {
            zigZag.Distance = Convert.ToInt32(zigZagDistanceNumberic.Value);
        }

        private void period_ValueChanged_1(object sender, EventArgs e)
        {
            bollingerBands.Period = envelopes.Period = Convert.ToInt32(period.Value);
        }
    }
}
