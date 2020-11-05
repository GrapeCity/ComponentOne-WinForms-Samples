using C1.Chart;
using C1.Win.Chart.Finance;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using StockChart.Data;

namespace StockChart
{
    class ComparisonSymbols: System.Collections.Concurrent.ConcurrentDictionary<string, Symbol>
    {
        public static Color[] _Colors = new Color[]
        {
            Color.FromArgb(220,57,18),
            Color.FromArgb(16,150,24),
            Color.FromArgb(153,0,153),
            Color.FromArgb(59,62,172),
        };

        private C1.Win.Chart.FlexChart _chart;
        private List<C1.Win.Chart.Finance.MovingAverage> MovingAverages = new List<MovingAverage>();
        private List<C1.Win.Chart.Series> Serieses = new List<C1.Win.Chart.Series>();
        
        public ComparisonSymbols(C1.Win.Chart.FlexChart chart)
        {
            _chart = chart;
        }
        private MovingAverageType _movingAverageType = MovingAverageType.Exponential;
        /// <summary>
        /// Gets or sets the moving average type.
        /// </summary>
        public MovingAverageType Type
        {
            get { return _movingAverageType; }
            set { _movingAverageType = value; UpdateSettings(); }
        }

        private int _period = 10;
        /// <summary>
        /// Gets or sets the period of the moving average series.
        /// It should be set to integer value greater than 1. 
        /// </summary>
        public int Period
        {
            get { return _period; }
            set { _period = value; UpdateSettings(); }
        }

        void UpdateSettings()
        {
            foreach (var ma in MovingAverages)
            {
                ma.Type = this.Type;
                ma.Period = Period;
            }
        }

        public bool Add(Symbol s, string property, bool isShowMovingAverage = false)
        {
            if (this.Keys.Contains(s.Code))
            {
                return false;
            }

            if (base.TryAdd(s.Code, s))
            {
                InitSymbol(s, property, isShowMovingAverage);

                MovingAverages.Add(s.MovingAverage);
                Serieses.Add(s.Series);

                _chart.BeginInvoke(new Action(() =>
                {
                    _chart.BeginUpdate();
                    _chart.Series.Add(s.MovingAverage);
                    _chart.Series.Add(s.Series);
                    _chart.EndUpdate();
                }));
                return true;
            }
            return false;
        }

        public void Remove(Symbol s)
        {
            Symbol symbol;
            if (base.TryRemove(s.Code, out symbol))
            {
                if (Serieses.Contains(s.Series))
                {
                    Serieses.Remove(s.Series);
                }
                if (_chart.Series.Contains(s.Series))
                {
                    _chart.Series.Remove(s.Series);
                }

                if (MovingAverages.Contains(s.MovingAverage))
                {
                    MovingAverages.Remove(s.MovingAverage);
                }
                if (_chart.Series.Contains(s.MovingAverage))
                {
                    _chart.Series.Remove(s.MovingAverage);
                }
                s.Dispose();
            }

        }

        public new void Clear()
        {
            base.Clear();


            foreach (var series in Serieses)
            {
                if (_chart.Series.Contains(series))
                {
                    _chart.Series.Remove(series);
                }
                series.Dispose();
            }
            foreach (var ma in MovingAverages)
            {
                if (_chart.Series.Contains(ma))
                {
                    _chart.Series.Remove(ma);
                }
                ma.Dispose();
            }
            Serieses.Clear();
            MovingAverages.Clear();
        }

        static int IndexMemory = 0;
        void InitSymbol(Symbol s, string property, bool isShowMovingAverage = false)
        {
            s.Color = _Colors[IndexMemory % _Colors.Length];
            IndexMemory++;
            HsbColor hsb = ColorEx.RgbToHsb(s.Color);

            s.MovingAverage = new MovingAverage()
            {
                Binding = property,
                Type = MovingAverageType.Simple,
                Period = 10,
                Visibility = isShowMovingAverage ? SeriesVisibility.Visible : SeriesVisibility.Hidden,
            };
            s.MovingAverage.Style.StrokeWidth = 1;
            s.MovingAverage.Style.FillColor = s.MovingAverage.Style.StrokeColor 
                = ColorEx.HsbToRgb(new HsbColor() { A = hsb.A, H = hsb.H, S = Math.Max(hsb.B/ 2, 0), B = Math.Min(hsb.B * 2, 1) });
            s.MovingAverage.DataSource = s.DataSource;

            s.Series = new C1.Win.Chart.Series() { Binding = property, Name = s.Code.ToUpper() };
            s.Series.ChartType = ChartType.Line;
            s.Series.Style.StrokeWidth = 2;
            s.Series.Style.FillColor = Color.FromArgb(64, s.Color);
            s.Series.Style.StrokeColor = s.Color;
            s.Series.DataSource = s.DataSource;
        }

    }

    internal class Symbol: IDisposable
    {
        public Symbol(string code)
        {
            Code = code;
        }

        internal string Code
        {
            get;
            set;
        }

        internal Color Color
        {
            get;
            set;
        }

        
        internal SeriesVisibility Visibility
        {
            get { return MovingAverage.Visibility & Series.Visibility; }
            set { MovingAverage.Visibility = Series.Visibility = value; }
        }

        internal SymbolData DataSource
        {
            get;
            set;
        }

        internal C1.Win.Chart.Series Series
        {
            get;
            set;
        }

        internal C1.Win.Chart.Finance.MovingAverage MovingAverage
        {
            get;
            set;
        }

        public void Dispose()
        {
            this.Series.Dispose();
            this.MovingAverage.Dispose();
            this.DataSource = null;
        }
    }
}
