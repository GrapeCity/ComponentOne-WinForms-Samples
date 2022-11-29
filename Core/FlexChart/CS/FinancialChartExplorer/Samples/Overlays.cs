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

            overlayType.DataSource = new string[]
            {              
               "Bollinger Bands",
               "Envelopes",
               "Ichimoku Cloud",
               "Alligator",
               "ZigZag"
            };

            mvaType.DataSource = Enum.GetNames(typeof(C1.Chart.Finance.MovingAverageType)).ToList();            
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
        private void overlayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FinancialSeries ser = null;            
            if (overlayType.SelectedIndex == 0)
                ser = bollingerBands;
            else if (overlayType.SelectedIndex == 1)
                ser = envelopes;
            else if (overlayType.SelectedIndex == 2)
                ser = ichimokuCloud;
            else if(overlayType.SelectedIndex == 3)
                ser = alligator;
            else if (overlayType.SelectedIndex == 4)
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
                mvaType.Visible = true;
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

        private void period_ValueChanged(object sender, EventArgs e)
        {
            bollingerBands.Period = envelopes.Period = (int)period.Value;
        }

        private void nudMultiplier_ValueChanged(object sender, EventArgs e)
        {
            bollingerBands.Multiplier = (int)nudMultiplier.Value;
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            envelopes.Size = (double)nudSize.Value /100;
        }

        private void mvaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            envelopes.Type = (C1.Chart.Finance.MovingAverageType)Enum.Parse(typeof(C1.Chart.Finance.MovingAverageType), mvaType.Text);
        }
        private void conversion_ValueChanged(object sender, EventArgs e)
        {
            ichimokuCloud.ConversionPeriod = (int)conversionPeriod.Value;
        }
        private void base_ValueChanged(object sender, EventArgs e)
        {
            ichimokuCloud.BasePeriod = (int)basePeriod.Value;
        }
        private void leading_ValueChanged(object sender, EventArgs e)
        {
            ichimokuCloud.LeadingPeriod = (int)leadingPeriod.Value;
        }
        private void lagging_ValueChanged(object sender, EventArgs e)
        {
            ichimokuCloud.LaggingPeriod = (int)laggingPeriod.Value;
        }

        private void jawPeriodNumberic_ValueChanged(object sender, EventArgs e)
        {
            alligator.JawPeriod = (int)jawPeriodNumberic.Value;
        }

        private void teethPeriodNumberic_ValueChanged(object sender, EventArgs e)
        {
            alligator.TeethPeriod = (int)teethPeriodNumberic.Value;
        }

        private void lipsPeriodNumberic_ValueChanged(object sender, EventArgs e)
        {
            alligator.LipsPeriod = (int)lipsPeriodNumberic.Value;
        }

        private void zigZagDistanceNumberic_ValueChanged(object sender, EventArgs e)
        {
            zigZag.Distance = (int)zigZagDistanceNumberic.Value;
        }
    }
}
