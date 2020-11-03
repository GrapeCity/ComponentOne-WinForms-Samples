using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.ComponentModel;
using System.Drawing;

using C1.Chart;
using C1.Chart.Finance;
using C1.Win.Chart.Finance;

namespace StockAnalysis.CustomIndicators
{
    class BaseIndicator
    {
        internal protected int period = 14;
        internal Object.QuoteData[] quotes = null;

        public BaseIndicator() { }

        public int Period
        {
            get { return period; }
            set
            {
                if (period != value)
                {
                    period = value;
                    OnPropertyChanged("Period");
                }
            }
        }

        public IEnumerable<Object.QuoteData> QuoteData
        {
            get { return quotes; }
            set
            {
                if (quotes != value)
                {
                    quotes = value.ToArray();
                    OnPropertyChanged("QuoteData");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = null;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    class ADXIndicator : BaseIndicator
    {
        AdxDataPoint[] adxDataPoints = null;

        public ADXIndicator() : base() {  }

        #region ReadOnly Properies
        public AdxDataPoint[] AdxDataSource
        {
            get { return adxDataPoints; }
        }

        public DIPASeries DIPA
        {
            get { return new DIPASeries() { DataSource = adxDataPoints }; }
        }

        public DINASeries DINA
        {
            get { return new DINASeries() { DataSource = adxDataPoints }; }
        }

        public ADXSeries ADX
        {
            get { return new ADXSeries() { DataSource = adxDataPoints, Period = this.period }; }
        }
        #endregion

        protected override void OnPropertyChanged(string propertyName)
        {
            if (propertyName == "Period" || propertyName == "QuoteData")
            {
                base.OnPropertyChanged(propertyName);

                adxDataPoints = null;
                if (Period > 0 && quotes != null && quotes.Length > 0 && Period < quotes.Length)
                {
                    Create(quotes, Period, out adxDataPoints);
                    OnPropertyChanged("AdxDataSource");
                }
            }
            else
            {
                base.OnPropertyChanged(propertyName);
            }
        }

        public static void Create(Object.QuoteData[] quoteData, int period, out AdxDataPoint[] adxDataPts)
        {
            // calculate the DIP-Average, DIN-Average and ADX.
            int dataLen = quoteData.Length;

            double pfactor = (double)(period - 1) / period;

            double tr;
            double dmp;
            double dmn;
            double dx = 0.0;
            double dmpA = 0.0;
            double dmnA = 0.0;
            double trA = 0.0;
            double adxfirst = 0.0;

            adxDataPts = new AdxDataPoint[dataLen];
            adxDataPts[0] = new AdxDataPoint(quoteData[0].LocalDate);

            for (int i = 1; i < dataLen; i++)
            {
                adxDataPts[i] = new AdxDataPoint(quoteData[i].LocalDate);

                double h = quoteData[i].High, l = quoteData[i].Low;
                double ph = quoteData[i - 1].High, pl = quoteData[i - 1].Low, pc = quoteData[i - 1].Close;

                tr = Math.Max(h - l, Math.Max(Math.Abs(h - pc), Math.Abs(l - pc)));

                if ((h - ph) >= (pl - l))
                {
                    dmp = ((h - ph) > 0.0) ? (h - ph) : 0.0;
                    dmn = 0.0;
                }
                else
                {
                    dmp = 0.0;
                    dmn = ((pl - l) > 0.0) ? (pl - l) : 0.0;
                }

                if (i <= period)
                {
                    trA += tr;
                    dmpA += dmp;
                    dmnA += dmn;
                }
                else
                {
                    trA = trA * pfactor + tr;
                    dmpA = dmpA * pfactor + dmp;
                    dmnA = dmnA * pfactor + dmn;
                }

                if (i >= period)
                {
                    double dipa = dmpA / trA * 100;
                    double dina = dmnA / trA * 100;

                    dx = Math.Abs(dipa - dina) / (dipa + dina) * 100;

                    adxDataPts[i].DIPA = dipa;
                    adxDataPts[i].DINA = dina;

                    if (i <= period + period - 1)
                    {
                        adxfirst += dx / period;
                        if (i == period + period - 1) 
                            adxDataPts[period + period - 1].ADX = adxfirst;
                    }
                }

                if (i > period + period - 1)
                {
                    adxDataPts[i].ADX = (adxDataPts[i-1].ADX * (period - 1) + dx) / period;
                }
            }
        }

        #region Classes
        public class AdxDataPoint
        {
            public string LocalDate { get; set; }
            public double DIPA { get; set; }
            public double DINA { get; set; }
            public double ADX { get; set; }

            public AdxDataPoint()
            {
                LocalDate = string.Empty;
                DIPA = DINA = ADX = double.NaN;     // default to hole value
            }

            public AdxDataPoint(string ldate)
            {
                LocalDate = ldate;
                DIPA = DINA = ADX = double.NaN;     // default to hole value
            }
        }

        public class DIPASeries : FinancialSeries, ISeries
        {
            public DIPASeries() : base()
            {
                Name = "ADXDIPASeries";
                BindingX = "LocalDate";
                Binding = "DIPA";
                ChartType = FinancialChartType.Line;
                Style.StrokeColor = Color.Green;
                Style.StrokeWidth = 1;
                Visibility = SeriesVisibility.Plot;
            }
        }

        public class DINASeries : FinancialSeries, ISeries
        {
            public DINASeries() : base()
            {
                Name = "ADXDINASeries";
                BindingX = "LocalDate";
                Binding = "DINA";
                ChartType = FinancialChartType.Line;
                Style.StrokeColor = Color.Red;
                Style.StrokeWidth = 1;
                Visibility = SeriesVisibility.Plot;
            }
        }

        public class ADXSeries : FinancialSeries, ISeries
        {
            public ADXSeries() : base()
            {
                Name = "ADXSeries";
                BindingX = "LocalDate";
                Binding = "ADX";
                ChartType = FinancialChartType.Line;
                Style.StrokeColor = Color.Black;
                Style.StrokeWidth = 1;
                Visibility = SeriesVisibility.Plot;
            }

            public int Period { get; internal set; }
        }
        #endregion
    }
}
