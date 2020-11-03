using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using C1.Chart;
using C1.Chart.Finance;
using C1.Win.Chart;
using C1.Win.Chart.Finance;

namespace StockAnalysis.CustomIndicators
{
    class PivotPointOverlay : BaseIndicator
    {
        PivotPoint[] pivotPoints = null;

        public PivotPointOverlay() : base() { IsStandard = true; }

        #region Properies


        public PivotPoint[] PivotPointsDataSource
        {
            get { return pivotPoints; }
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

        public bool IsStandard { get; set; }

        public PivotSeries Pivot
        {
            get { return new PivotSeries() { DataSource = pivotPoints, IsStandard = this.IsStandard }; }
        }

        public S1Series S1
        {
            get { return new S1Series() { DataSource = pivotPoints }; }
        }

        public S2Series S2
        {
            get { return new S2Series() { DataSource = pivotPoints }; }
        }

        public S3Series S3
        {
            get { return new S3Series() { DataSource = pivotPoints }; }
        }

        public R1Series R1
        {
            get { return new R1Series() { DataSource = pivotPoints }; }
        }

        public R2Series R2
        {
            get { return new R2Series() { DataSource = pivotPoints }; }
        }

        public R3Series R3
        {
            get { return new R3Series() { DataSource = pivotPoints }; }
        }
        #endregion

        protected override void OnPropertyChanged(string propertyName)
        {
            if (propertyName == "IsStandard" || propertyName == "QuoteData")
            {
                base.OnPropertyChanged(propertyName);

                pivotPoints = null;
                if (quotes != null && quotes.Length > 0)
                {
                    Create(quotes, IsStandard, out pivotPoints);
                    OnPropertyChanged("PivotPointsDataSource");
                }
            }
            else
            {
                base.OnPropertyChanged(propertyName);
            }
        }

        public static void Create(IEnumerable<Object.QuoteData> quoteData, bool isStandard, out PivotPoint[] pivotData)
        {
            Object.QuoteData[] qdata = quoteData.ToArray();
            int len = qdata.Length;

            pivotData = null;

            List<PivotPoint> pdatas = new List<PivotPoint>();

            DateTime dataDate = DateTime.MinValue;
            double high = double.MinValue, low = double.MaxValue, close = -1, pivot = -1;

            int p = 0;
            while (DateTime.Parse(qdata[p].LocalDate).Day > 7 && high == double.MinValue)
                p++; // skip to first complete month

            int month = DateTime.Parse(qdata[p].LocalDate).Month;
            high = qdata[p].High;
            low = qdata[p].Low;
            double delta = high - low;
            p++;

            while (p < qdata.Length)
            {
                DateTime qdate = DateTime.Parse(qdata[p].LocalDate);
                if (qdate.Month == month)
                {
                    if (qdata[p].High > high) high = qdata[p].High;
                    if (qdata[p].Low < low) low = qdata[p].Low;
                }
                else
                {
                    month = qdate.Month;
                    close = qdata[p - 1].Close;
                    pivot = (high + low + close) / 3;
                    delta = high - low;
                    pdatas.Add(new PivotPoint()
                    {
                        EffectiveDate = new DateTime(qdate.Year, qdate.Month, 1).ToShortDateString(),
                        StartingIndex = p,
                        Pivot = pivot,
                        S1 = isStandard ? pivot * 2 - high            : pivot - (0.382 * delta),
                        S2 = isStandard ? pivot - delta               : pivot - (0.618 * delta),
                        S3 = isStandard ? low - 2 * (high - pivot)    : pivot - (1.0 * delta),
                        R1 = isStandard ? pivot * 2 - low             : pivot + (0.382 * delta),
                        R2 = isStandard ? pivot + delta               : pivot + (0.618 * delta),
                        R3 = isStandard ? high + 2 * (pivot - low)    : pivot + (1.0 * delta),
                    });

                    high = qdata[p].High;
                    low = qdata[p].Low;
                }
                p++;
            }

            if (DateTime.Parse(qdata[--p].LocalDate).Month == month)
            {
                //create an extra PivotPoint element to match the last date
                PivotPoint pp = pdatas[pdatas.Count-1];
                pdatas.Add(new PivotPoint()
                {
                    EffectiveDate = qdata[p].LocalDate,
                    StartingIndex = p,
                    Pivot = pp.Pivot,
                    S1 = pp.S1,
                    S2 = pp.S2,
                    S3 = pp.S3,
                    R1 = pp.R1,
                    R2 = pp.R2,
                    R3 = pp.R3,
                });
            }
            pivotData = pdatas.ToArray();
        }

        #region Classes
        public class PivotPoint
        {
            public string EffectiveDate { get; set; }
            public int StartingIndex { get; set;}
            public double Pivot { get; set; }
            public double S1 { get; set; }
            public double S2 { get; set; }
            public double S3 { get; set; }
            public double R1 { get; set; }
            public double R2 { get; set; }
            public double R3 { get; set; }
        }

        public class PivotSeries : Series, ISeries
        {
            public PivotSeries()
                : base()
            {
                Name = "Pivot";
                BindingX = "StartingIndex";
                Binding = "Pivot";
                ChartType = C1.Chart.ChartType.Step;
                Style.StrokeWidth = 1;
                Visibility = SeriesVisibility.Visible;
            }

            public bool IsStandard { get; set; }
        }

        public class S1Series : Series, ISeries
        {
            public S1Series()
                : base()
            {
                Name = "S1";
                BindingX = "StartingIndex";
                Binding = "S1";
                ChartType = C1.Chart.ChartType.Step;
                Style.StrokeWidth = 1;
                Visibility = SeriesVisibility.Visible;
            }
        }

        public class S2Series : Series, ISeries
        {
            public S2Series()
                : base()
            {
                Name = "S2";
                BindingX = "StartingIndex";
                Binding = "S2";
                ChartType = C1.Chart.ChartType.Step;
                Style.StrokeWidth = 1;
                Visibility = SeriesVisibility.Visible;
            }
        }

        public class S3Series : Series, ISeries
        {
            public S3Series()
                : base()
            {
                Name = "S3";
                BindingX = "StartingIndex";
                Binding = "S3";
                ChartType = C1.Chart.ChartType.Step;
                Style.StrokeWidth = 1;
                Visibility = SeriesVisibility.Visible;
            }
        }

        public class R1Series : Series, ISeries
        {
            public R1Series()
                : base()
            {
                Name = "R1";
                BindingX = "StartingIndex";
                Binding = "R1";
                ChartType = C1.Chart.ChartType.Step;
                Style.StrokeWidth = 1;
                Visibility = SeriesVisibility.Visible;
            }
        }

        public class R2Series : Series, ISeries
        {
            public R2Series()
                : base()
            {
                Name = "R2";
                BindingX = "StartingIndex";
                Binding = "R2";
                ChartType = C1.Chart.ChartType.Step;
                Style.StrokeWidth = 1;
                Visibility = SeriesVisibility.Visible;
            }
        }

        public class R3Series : Series, ISeries
        {
            public R3Series()
                : base()
            {
                Name = "R3";
                BindingX = "StartingIndex";
                Binding = "R3";
                ChartType = C1.Chart.ChartType.Step;
                Style.StrokeWidth = 1;
                Visibility = SeriesVisibility.Visible;
            }
        }

        #endregion
    }

}
