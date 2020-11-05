using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.ComponentModel;
using System.Drawing;

using C1.Chart;
using C1.Chart.Finance;
using C1.Win.Chart;
using C1.Win.Chart.Finance;

namespace StockAnalysis.CustomIndicators
{
    class MassIndexIndicator : BaseIndicator 
    {
        MassIndexDataPoint[] massIndexDataPoints = null;

        public double Threshold { get; set; }

        #region ReadOnly Properies

        public MassIndexIndicator() : base() { this.period = 25; }

        public MassIndexDataPoint[] MassIndexDataSource
        {
            get { return massIndexDataPoints; }
        }

        public MassIndexSeries MassIndex
        {
            get { return new MassIndexSeries() { DataSource = massIndexDataPoints, Period = this.period }; }
        }

        public MassIndexThresholdSeries MassIndexThreshold
        {
            get
            {
                MassIndexThresholdSeries mis = new MassIndexIndicator.MassIndexThresholdSeries();
                mis.DataSource = new PointF[] 
                {
                    new PointF(0f, (float)this.Threshold),
                    new PointF(massIndexDataPoints.Length - 1, (float)this.Threshold),
                };
                mis.Threshold = this.Threshold;
                return mis;
            }
        }

        #endregion
        protected override void OnPropertyChanged(string propertyName)
        {
            if (propertyName == "Period" || propertyName == "QuoteData")
            {
                base.OnPropertyChanged(propertyName);

                massIndexDataPoints = null;
                if (Period > 0 && quotes != null && quotes.Length > 0 && Period < (quotes.Length-18))
                {
                    Create(quotes, Period, out massIndexDataPoints);
                    OnPropertyChanged("MassIndexDataSource");
                }
            }
            else
            {
                base.OnPropertyChanged(propertyName);
            }
        }

        public static void Create(Object.QuoteData[] quoteData, int period, out MassIndexDataPoint[] massIndexDataPts)
        {
            int len = quoteData.Length;
            massIndexDataPts = new MassIndexDataPoint[len];

            double ema = 0.0, ema2 = 0.0;
            for (int i = 0; i < 9; i++)
            {
                massIndexDataPts[i] = new MassIndexDataPoint(quoteData[i].LocalDate);
                ema += quoteData[i].High - quoteData[i].Low;
            }

            ema /= 9;
            ema2 = ema;

            for (int i = 9; i < 9 + 9 - 1; i++)
            {
                massIndexDataPts[i] = new MassIndexDataPoint(quoteData[i].LocalDate);
                ema = ema + 2.0 / (9 + 1) * (quoteData[i].High - quoteData[i].Low - ema);
                ema2 += ema;
            }

            ema2 /= 9;

            double emaRatio = 0.0;
            double[] emaRatios = new double[period];

            for (int i = 9 + 9 - 1; i < 9 + 9 - 1 + period; i++)
            {
                massIndexDataPts[i] = new MassIndexDataPoint(quoteData[i].LocalDate);
                ema = ema + 2.0 / (9 + 1) * (quoteData[i].High - quoteData[i].Low - ema);
                ema2 = ema2 + 2.0 / (9 + 1) * (ema - ema2);
                emaRatio += ema / ema2;
                emaRatios[i % period] = ema / ema2;
            }
            massIndexDataPts[9 + 9 - 2 + period] =
                new MassIndexDataPoint(quoteData[9 + 9 - 2 + period].LocalDate, emaRatio);

            for (int i = 9 + 9 + -1 + period; i < len; i++)
            {
                ema = ema + 2.0 / (9 + 1) * (quoteData[i].High - quoteData[i].Low - ema);
                ema2 = ema2 + 2.0 / (9 + 1) * (ema - ema2);
                emaRatio = ema / ema2;
                massIndexDataPts[i] = new MassIndexDataPoint(quoteData[i].LocalDate,
                    massIndexDataPts[i - 1].MassIndex - emaRatios[i % period] + emaRatio);
                emaRatios[i % period] = emaRatio;
            }
        }

        #region Classes

        public class MassIndexDataPoint
        {
            public string LocalDate { get; set; }
            public double MassIndex { get; set; }

            public MassIndexDataPoint()
            {
                LocalDate = string.Empty;
                MassIndex = double.NaN;     // default to hole value
            }

            public MassIndexDataPoint(string ldate)
            {
                LocalDate = ldate;
                MassIndex = double.NaN;     // default to hole value
            }

            public MassIndexDataPoint(string ldate, double massIndex)
            {
                LocalDate = ldate;
                MassIndex = massIndex;
            }
        }

        public class MassIndexSeries : FinancialSeries, ISeries
        {            
            public MassIndexSeries() : base()
            {
                Name = "MassIndexSeries";
                BindingX = "LocalDate";
                Binding = "MassIndex";
                ChartType = FinancialChartType.Line;
                Style.StrokeColor = Color.Blue;
                Style.StrokeWidth = 1;
                Visibility = SeriesVisibility.Plot;
            }

            public int Period { get; internal set; }
        }

        public class MassIndexThresholdSeries : FinancialSeries, ISeries
        {
            public MassIndexThresholdSeries() : base()
            {
                Name = "MassIndexThresholdSeries";
                BindingX = "X";
                Binding = "Y";
                ChartType = FinancialChartType.Line;
                Style.StrokeColor = Color.Green;
                Style.StrokeWidth = 1;
                Visibility = SeriesVisibility.Plot;
            }

            double threshold = double.NaN;

            public double Threshold
            {
                get { return threshold; }
                set
                {
                    if (value != threshold)
                    {
                        threshold = value;

                        PointF[] oa = this.DataSource as PointF[];
                        oa[0].Y = (float)threshold;
                        oa[1].Y = (float)threshold;
                        this.Rebind();
                    }
                }
            }
        }

        #endregion
    }
}
