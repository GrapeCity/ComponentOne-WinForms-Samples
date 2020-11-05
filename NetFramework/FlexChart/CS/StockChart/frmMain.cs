using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using StockChart.Data;

using C1.Chart;
using C1.Chart.Annotation;
using C1.Chart.Finance;
using C1.Win.Chart.Finance;
using C1.Win.Chart;
using C1.Win.Chart.Interaction;

namespace StockChart
{
    public partial class frmMain : Form
    {
        private const string _comparisonBinding = "Percentage";
        private readonly Color _baseSeriesColor = Color.FromArgb(255, 165, 0);

        private string _symbol = "MSFT";
        private string _binding = "Close";
        private SymbolData _quoteData = null;
        ComparisonSymbols _comparisonSymbols;

        RangeSelector rs;
        LineMarker marker;
        C1.Win.Chart.Annotation.AnnotationLayer annotationLayer;

        SolidBrush axisRectSB = new SolidBrush(Color.FromArgb(255, 42, 42, 42));
        SolidBrush axisFontSB = new SolidBrush(Color.FromArgb(255, 170, 170, 170));
        Font axisFont = new System.Drawing.Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);

        public string Binding
        {
            get { return _binding; }
            set { _binding = value; }
        }

        IDataService DataService
        {
            get { return Data.DataService.Instance; }
        }

        private string Symbol
        {
            get
            {
                return _symbol;
            }
            set
            {
                if (_symbol != value)
                    _symbol = value;
            }
        }

        MovingAverage ma;
        Series fs;
        Series vs;

        public frmMain()
        {
            AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();

            Load += (se, ar) =>
            {
                DataService.NewsLoaded += (s, e) => SetupAnnotations(ucToolbar.IsShowNews);
                GetSymbolData("MSFT", new Action<string, SymbolData>((s, d) =>
                {
                    _quoteData = d;
                    InitializeTopChart();
                    UpdateTitleBar();
                }));

                GetSymbolData("INX", new Action<string, SymbolData>((s, d) => InitializeBottomChart(d)), false, false);
                CreateMarker();
                InitializeControls();
            };
        }

        #region initialization

        private void InitializeTopChart()
        {
            if (_quoteData == null || !_quoteData.Any())
                return;

            var maxVolume = _quoteData.Max(p => p.Volume);

            HsbColor hsb = ColorEx.RgbToHsb(_baseSeriesColor);

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "Date";
            financialChart1.ToolTip.Active = false;
            financialChart1.AxisY.Position = Position.Right;
            financialChart1.AxisY.MajorGrid = false;
            financialChart1.AxisY.MinorGrid = false;
            financialChart1.AxisY.Format = null;
            financialChart1.Legend.Position = Position.None;

            ma = new MovingAverage()
            {
                Binding = Binding,
                Type = C1.Chart.MovingAverageType.Simple,
                Period = 10,
                Visibility = SeriesVisibility.Hidden
            };
            ma.Style.StrokeWidth = 1;
            ma.Style.FillColor = ma.Style.StrokeColor
                = ColorEx.HsbToRgb(new HsbColor() { A = hsb.A, H = hsb.H, S = Math.Max(hsb.B / 2, 0), B = Math.Min(hsb.B * 2, 1) });
            financialChart1.Series.Add(ma);

            fs = new Series() { Binding = Binding, Name = Symbol.ToUpper() };
            fs.ChartType = ChartType.Line;
            fs.Style.StrokeWidth = 2;
            fs.Style.FillColor = Color.FromArgb(64, _baseSeriesColor);
            fs.Style.StrokeColor = _baseSeriesColor;
            financialChart1.Series.Add(fs);

            vs = new Series() { Binding = "Volume", AxisY = new C1.Win.Chart.Axis() { Max = maxVolume * 8 }, ChartType = C1.Chart.ChartType.Column };
            vs.Style.FillColor = Color.FromArgb(255, 165, 0);
            vs.Style.StrokeColor = Color.FromArgb(255, 165, 0);
            financialChart1.Series.Add(vs);

            financialChart1.ChartType = FinancialChartType.Line;
            financialChart1.DataSource = _quoteData;
            financialChart1.EndUpdate();
            financialChart1.MouseMove += FinancialChart1_MouseMove;
        }

        void InitializeBottomChart(SymbolData data)
        {
            financialChart2.BeginUpdate();
            financialChart2.BindingX = "Date";
            financialChart2.Binding = "Close";
            financialChart2.AxisY.Position = Position.None;
            var cs = new FinancialSeries();
            cs.Style.StrokeWidth = 2;
            cs.Style.FillColor = Color.FromArgb(255, 165, 0);
            cs.Style.StrokeColor = Color.FromArgb(255, 165, 0);
            financialChart2.Series.Add(cs);
            financialChart2.ChartType = FinancialChartType.Line;
            financialChart2.DataSource = data;
            financialChart2.ToolTip.Content = null;
            financialChart2.AxisX.Min = new DateTime(2007, 12, 31, 0, 0, 0).ToOADate();
            financialChart2.EndUpdate();
            financialChart2.Rendered += (s1, e1) => RefreshRangeSelector();
        }

        private void InitializeControls()
        {
            ucTitlebar.OnSymbolChanged += (o, e) =>
            {
                GetSymbolData(e.Value, new Action<string, SymbolData>((sym, data) =>
                {
                    if (data != null && data.Any())
                    {
                        _quoteData = data;
                        Symbol = e.Value.ToUpper();
                        UpdateTitleBar();
                        UpdateChart();
                        SetupAnnotations(ucToolbar.IsShowNews);
                    }
                }));
            };

            ucToolbar.OnComparisonChanged += (o, e) =>
            {
                if (_comparisonSymbols == null)
                    _comparisonSymbols = new ComparisonSymbols(financialChart1);

                if (e.Value.ToUpper() == Symbol.ToUpper())
                    return;

                GetSymbolData(e.Value, (sym, data) =>
                {
                    if (data != null)
                    {
                        var s = new Symbol(e.Value.ToUpper()) { DataSource = data };
                        if (_comparisonSymbols.Add(s, _comparisonBinding, ucToolbar.IsShowMovingAverage))
                        {
                            ChangeMode(true);

                            ucToolbar.AddSeriesController(s, () =>
                            {
                                if (s.Visibility == SeriesVisibility.Visible)
                                    s.MovingAverage.Visibility = ucToolbar.IsShowMovingAverage ? SeriesVisibility.Visible : SeriesVisibility.Hidden;
                                var checkedSymbol = from p in _comparisonSymbols where p.Value.Visibility == SeriesVisibility.Visible select p;
                                if (checkedSymbol == null || !checkedSymbol.Any())
                                    ChangeMode(false);
                                else
                                    ChangeMode(true);
                                UpdateYRange();
                            });

                            if (_comparisonSymbols.Keys.Count > 4)
                            {
                                var key = ucToolbar.GetFirstSeriesCOntroller();
                                var value = _comparisonSymbols[key];
                                ucToolbar.RemoveSeriesController(value);
                                _comparisonSymbols.Remove(value);
                            }
                            UpdateDataRange();
                        }
                    }
                });
            };

            ucToolbar.OnSelectedIndexChanged += (o, e) =>
            {
                if (rs == null)
                    return;

                DateTime lowValue = DateTime.Now;
                switch (e.Value)
                {
                    case 0:
                        lowValue = DateTime.Now.AddMonths(-1);
                        break;
                    case 1:
                        lowValue = DateTime.Now.AddMonths(-3);
                        break;
                    case 2:
                        lowValue = DateTime.Now.AddMonths(-6);
                        break;
                    case 3:
                        lowValue = new DateTime(DateTime.Now.Year, 1, 1);
                        break;
                    case 4:
                        lowValue = DateTime.Now.AddYears(-1);
                        break;
                    case 5:
                        lowValue = DateTime.Now.AddYears(-3);
                        break;
                    case 6:
                        lowValue = DateTime.Now.AddYears(-6);
                        break;
                    case 7:
                        lowValue = _quoteData.Min(p => p.Date);
                        break;
                    default:
                        break;
                }
                rs.UpperValue = DateTime.Now.ToOADate();
                rs.LowerValue = lowValue.ToOADate();

                ucToolbar.RangeText = FormatRange(lowValue, DateTime.Today);
            };

            ucToolbar.OnReseted += (o, e) =>
            {
                if (_comparisonSymbols != null && _comparisonSymbols.Any())
                {
                    _comparisonSymbols.Clear();


                    ChangeMode(false);

                    UpdateYRange();
                    ucToolbar.RemoveAllSeriesController();
                    var removeItems = (from p in financialChart1.Series where p != fs && p != ma && p != vs select p).ToList();

                    for (int i = 0; i < removeItems.Count; i++)
                        financialChart1.Series.Remove(removeItems[i]);
                }
            };

            ucToolbar.OnShowVolumeChanged += (o, e) =>
            {
                if (vs != null)
                    vs.Visibility = e.Value ? SeriesVisibility.Visible : SeriesVisibility.Hidden;
            };

            ucToolbar.OnChartTypeChanged += (o, e) =>
            {
                if (fs == null)
                    return;

                financialChart1.BeginUpdate();
                switch (e.Type)
                {
                    case ChartType.Line:
                    case ChartType.Area:
                        fs.Style.FillColor = Color.FromArgb(64, _baseSeriesColor);
                        fs.Binding = Binding;
                        break;
                    case ChartType.Candlestick:
                        fs.Style.FillColor = Color.FromArgb(255, _baseSeriesColor);
                        fs.Binding = "High,Low,Open,Close";
                        break;
                    case ChartType.HighLowOpenClose:
                    default:
                        fs.Style.FillColor = Color.FromArgb(64, _baseSeriesColor);
                        fs.Binding = "High,Low,Open,Close";
                        break;
                }
                fs.ChartType = e.Type;
                financialChart1.EndUpdate();
            };

            ucToolbar.OnSaveImage += (o, e) =>
            {
                string filter = string.Empty;
                var format = ImageFormat.Png;
                switch (e.Value)
                {
                    case "PNG":
                        filter = "PNG|*.png";
                        format = C1.Win.Chart.ImageFormat.Png;
                        break;
                    case "JPG":
                        filter = "JPG|*.jpg";
                        format = C1.Win.Chart.ImageFormat.Jpg;
                        break;
                    case "SVG":
                        filter = "SVG|*.svg";
                        format = C1.Win.Chart.ImageFormat.Svg;
                        break;
                    default:
                        filter = "PNG|*.png";
                        format = C1.Win.Chart.ImageFormat.Png;
                        break;
                }

                using (var dialog = new SaveFileDialog())
                {
                    dialog.Filter = filter;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = dialog.FileName;
                        using (System.IO.FileStream fs = new System.IO.FileStream(dialog.FileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write))
                        {
                            financialChart1.SaveImage(fs, format, financialChart1.Width, financialChart1.Height);
                        }
                    }
                }
            };

            ucToolbar.OnMovingAverageVisibilityChanged += (o, e) =>
            {
                if (ma != null)
                {
                    ma.Visibility = e.Value ? SeriesVisibility.Visible : SeriesVisibility.Hidden;
                    if (_comparisonSymbols != null)
                        foreach (var kv in _comparisonSymbols)
                        {
                            kv.Value.MovingAverage.Visibility = ma.Visibility;
                        }
                }
            };

            ucToolbar.OnMovingAverageTypeChanged += (o, e) =>
            {
                if (ma != null)
                {
                    ma.Type = e.Type;
                    if (_comparisonSymbols != null)
                    {
                        _comparisonSymbols.Type = e.Type;
                    }
                }
            };

            ucToolbar.OnMovingAveragePeriodChanged += (o, e) =>
            {
                if (ma != null)
                {
                    ma.Period = e.Value;
                    if (_comparisonSymbols != null)
                    {
                        _comparisonSymbols.Period = e.Value;
                    }
                }
            };

            ucToolbar.OnLineMarkerVisibilityChanged += (o, e) => marker.Visible = e.Value;
            ucToolbar.OnNewsVisibilityChanged += (o, e) => SetupAnnotations(e.Value);
        }

        #endregion

        #region Annotations

        private void SetupAnnotations(bool isShown = true)
        {
            if (annotationLayer == null)
                annotationLayer = new C1.Win.Chart.Annotation.AnnotationLayer(financialChart1);
            else
                annotationLayer.Annotations.Clear();

            if (isShown)
                SetupAnnotation(_quoteData);
        }

        void SetupAnnotation(IEnumerable<Quote> dataSource)
        {
            foreach (var d in dataSource)
            {
                if (!string.IsNullOrEmpty(d.Events))
                {
                    var dSquare = new C1.Win.Chart.Annotation.Square("N", 20)
                    {
                        SeriesIndex = 0,
                        Location = new PointF((float)d.Date.ToOADate(), (float)(_isConfrontation ? d.Percentage : d.Close)),// d.GetValue(Binding)),
                        Attachment = AnnotationAttachment.DataCoordinate,
                        TooltipText = d.Events,
                    };
                    dSquare.ContentStyle.StrokeColor = Color.Black;
                    dSquare.ContentStyle.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
                    dSquare.Style.FillColor = Color.FromArgb(136, 136, 136);
                    dSquare.Style.StrokeColor = Color.Black;
                    dSquare.Style.StrokeWidth = 1;
                    annotationLayer.Annotations.Add(dSquare);
                }
            }
        }

        #endregion

        #region marker

        void CreateMarker()
        {
            marker = new LineMarker(financialChart1);
            marker.Lines = LineMarkerLines.Both;
            marker.Visible = ucToolbar.IsLineMarkerChecked;
            marker.LineWidth = 1;
            marker.DragThreshold = 10;
            marker.Paint += lineMarker_Paint;
        }

        void lineMarker_Paint(object sender, PaintEventArgs e)
        {
            var chartPoint = new Point(marker.X, marker.Y);
            var _hitTestInfo = financialChart1.HitTest(chartPoint, MeasureOption.X);

            var hitTestInfo = financialChart1.HitTest(chartPoint);

            var isLeft = marker.X > financialChart1.PlotRect.Width / 2;

            //draw X rectangle
            var xRect = new Rectangle(marker.X - 60, (int)(financialChart1.PlotRect.Top + financialChart1.PlotRect.Height), 120, 25);

            e.Graphics.FillRectangle(axisRectSB, xRect);
            var text = hitTestInfo.Format("{x:dd-MM-yyyy}");
            SizeF fontSize = e.Graphics.MeasureString(text, axisFont);
            e.Graphics.DrawString(text, axisFont, axisFontSB, xRect.X + (120 - fontSize.Width) / 2, xRect.Y + (25 - fontSize.Height) / 2);

            var value = financialChart1.AxisY.ActualMin + (financialChart1.AxisY.ActualMax - financialChart1.AxisY.ActualMin) * (financialChart1.PlotRect.Top + financialChart1.PlotRect.Height - marker.Y) / financialChart1.PlotRect.Height;
            text = string.Format(_isConfrontation ? "{0:+#0.##%;-#0.##%;#0.##%}" : "{0:.##}", value);

            //draw Y rectangle
            if (isLeft)
            {
                var yRect = new Rectangle((int)(financialChart1.PlotRect.Left), marker.Y - 25 / 2, 60, 25);
                e.Graphics.FillRectangle(axisRectSB, yRect);
                fontSize = e.Graphics.MeasureString(text, axisFont);
                e.Graphics.DrawString(text, axisFont, axisFontSB, yRect.X + (60 - fontSize.Width) / 2, yRect.Y + (25 - fontSize.Height) / 2);
            }
            else
            {
                var yRect = new Rectangle((int)(financialChart1.PlotRect.Right - 60), marker.Y - 25 / 2, 60, 25);
                e.Graphics.FillRectangle(axisRectSB, yRect);
                fontSize = e.Graphics.MeasureString(text, axisFont);
                e.Graphics.DrawString(text, axisFont, axisFontSB, yRect.X + (60 - fontSize.Width) / 2, yRect.Y + (25 - fontSize.Height) / 2);
            }
        }

        #endregion

        #region Update

        private void UpdateChart()
        {
            financialChart1.BeginUpdate();
            fs.Name = Symbol;
            financialChart1.DataSource = _quoteData;
            UpdateDataRange();
            financialChart1.EndUpdate();
        }

        private bool _isConfrontation = false;
        private void ChangeMode(bool isConfrontation)
        {

            if (_isConfrontation == isConfrontation)
                return;

            ucToolbar.ShowChartType = !isConfrontation;
            ucToolbar.EnableReset = isConfrontation;
            ucToolbar.IsShowNews = !isConfrontation;

            if (isConfrontation)
            {
                Binding = fs.Binding = ma.Binding = "Percentage";
                financialChart1.AxisY.Format = "P0";
            }
            else
            {
                Binding = fs.Binding = ma.Binding = "Close";
                financialChart1.AxisY.Format = null;
            }
            _isConfrontation = isConfrontation;
            fs.Rebind();
            ma.Rebind();
            SetupAnnotations(!isConfrontation && ucToolbar.IsNewsChecked);
        }

        private void FinancialChart1_MouseMove(object sender, MouseEventArgs e)
        {
            var ht = financialChart1.HitTest(e.Location);
            if (ht != null)
            {
                var result = new StringBuilder();
                if (ht.PointIndex >= 0)
                {
                    DateTime currDate = DateTime.MaxValue;
                    if (ht.Series != null && ht.Item is Quote)
                        currDate = Convert.ToDateTime(((Quote)ht.Item).Date);

                    if (ht.Series is MovingAverage)
                        currDate = currDate.AddDays(0 - (ht.Series as MovingAverage).Period);

                    if (currDate == DateTime.MaxValue)
                        return;

                    Stack<QuoteInfo> quotes = new Stack<QuoteInfo>();

                    if (_quoteData != null)
                    {
                        result.Append(string.Format("{0}: ", Symbol));
                        var quote = (from p in _quoteData where (p.Date >= currDate) select p).FirstOrDefault();

                        if (quote != null)
                        {
                            double dd = _isConfrontation ? quote.Percentage : quote.Close;// quote.GetValue(this.Binding);

                            quotes.Push(new QuoteInfo()
                            {
                                Symbol = Symbol,
                                Color = _baseSeriesColor,
                                Value = dd,
                                Volume = Convert.ToInt64(quote.Volume),
                                Date = Convert.ToDateTime(quote.Date)
                            });
                        }
                    }

                    if (_comparisonSymbols != null)
                    {
                        foreach (var series in financialChart1.Series)
                        {
                            if (series.Visibility == SeriesVisibility.Visible && !(series is MovingAverage) && !string.IsNullOrEmpty(series.Name))
                            {
                                var currSeries = (from p in (from kv in _comparisonSymbols.Values select kv) where p.Series == series select p).FirstOrDefault();

                                if (currSeries != null)
                                {
                                    var quote = (from p in currSeries.DataSource where (p.Date >= currDate) select p).FirstOrDefault();

                                    if (quote != null)
                                    {
                                        System.Diagnostics.Debug.WriteLine(currDate.ToShortDateString());
                                        double dd = _isConfrontation ? quote.Percentage : quote.Close;// quote.GetValue(this.Binding);

                                        quotes.Push(new QuoteInfo()
                                        {
                                            Symbol = currSeries.Code,
                                            Color = currSeries.Color,
                                            Value = dd,
                                            Volume = Convert.ToInt64(quote.Volume),
                                            Date = Convert.ToDateTime(quote.Date)
                                        });
                                    }
                                }
                            }

                        }
                    }
                    ucToolbar.QuotesInfoDisplayMode = this.Binding == _comparisonBinding ? DisplayMode.Comparison : DisplayMode.Independent;
                    ucToolbar.QuotesInfo = quotes;
                }

            }
        }

        void RefreshRangeSelector()
        {
            if (rs == null && financialChart2.AxisX.ActualMin != financialChart2.AxisX.ActualMax && !double.IsNaN(financialChart2.AxisX.ActualMax) )
            {
                rs = new RangeSelector(financialChart2);
                rs.Styles.BarStyle.SelectedAreaColor = Color.FromArgb(80, 189, 189, 189);
                rs.ValueChanged += (s, e) =>
                {
                    UpdateDataRange();
                    ucToolbar.RangeText = FormatRange(DateTime.FromOADate(rs.LowerValue), DateTime.FromOADate(rs.UpperValue));
                };

                var lowValue = new DateTime(DateTime.Now.Year, 1, 1);
                rs.LowerValue = lowValue.ToOADate();
                rs.UpperValue = DateTime.Now.ToOADate();

                ucToolbar.RangeText = FormatRange(lowValue, DateTime.Now);
            }
        }

        string FormatRange(DateTime d1, DateTime d2)
        {
            return string.Format(Thread.CurrentThread.CurrentUICulture, "{0:MMM dd, yyyy} - {1:MMM dd, yyyy}", d1, d2);
        }

        void UpdateDataRange()
        {
            if (_quoteData == null)
                return;

            DateTime ds = DateTime.FromOADate(rs.LowerValue);
            Quote quote = _quoteData.FirstOrDefault(p => p.Date >= ds);
            if (quote == null)
                return;

            financialChart1.BeginUpdate();
            _quoteData.ReferenceValue = quote.Close;

            if (_comparisonSymbols != null)
            {
                foreach (var kv in _comparisonSymbols)
                {
                    quote = kv.Value.DataSource.FirstOrDefault(p => p.Date >= ds);
                    if (quote != null)
                    {
                        kv.Value.DataSource.ReferenceValue = quote.Close;
                        kv.Value.Series.Rebind();
                        kv.Value.MovingAverage.Rebind();
                    }
                }
            }

            fs.Rebind();
            ma.Rebind();
            UpdateYRange();
            financialChart1.EndUpdate();
        }

        void UpdateYRange()
        {
            IEnumerable<QuoteRange> ranges = new QuoteRange[] { _quoteData.GetSymbolYRange(rs.LowerValue, rs.UpperValue, Binding) };

            if (_comparisonSymbols != null)
            {
                var cssRange = from cs in _comparisonSymbols where cs.Value.Visibility == SeriesVisibility.Visible select cs.Value.DataSource.GetSymbolYRange(rs.LowerValue, rs.UpperValue, Binding);
                ranges = ranges.Union(cssRange);
            }
            if (ranges.Any())
            {
                financialChart1.AxisX.Min = rs.LowerValue;
                financialChart1.AxisX.Max = rs.UpperValue;
                financialChart1.AxisY.Min = ranges.Min(p => p == null ? int.MaxValue : p.PriceMin);
                financialChart1.AxisY.Max = ranges.Max(p => p == null ? int.MinValue : p.PriceMax);
                if (ranges.First() != null)
                {
                    vs.AxisY.Min = ranges.First().VolumeMin;
                    vs.AxisY.Max = ranges.First().VolumeMax * 12;
                }
            }
        }

        void UpdateTitleBar()
        {
            ucTitlebar.StockName = DataService.GetSymbolName(Symbol);
            if (_quoteData != null && _quoteData.Count > 0)
            {
                ucTitlebar.Price = _quoteData.Last().Close;
                ucTitlebar.Difference = _quoteData[Math.Max(_quoteData.Count - 1, 0)].Close - _quoteData[Math.Max(_quoteData.Count - 2, 0)].Close;
            }
        }

        #endregion

        #region Progress Bar

        ProgressBar pbar;

        void ShowProgressBar()
        {
            if (pbar == null)
            {
                pbar = new ProgressBar() { Style = ProgressBarStyle.Marquee, Width = 120 };
                financialChart1.Controls.Add(pbar);
                financialChart1.Rendered += (s, e) =>
                {
                    if (pbar.Visible)
                    {
                        var msg = "Loading..";
                        var sz = e.Graphics.MeasureString(msg, Control.DefaultFont);
                        var loc = new Point((financialChart1.Width - pbar.Width) / 2, (financialChart1.Height - pbar.Height) / 2);
                        var mrg = 12;
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(32, 255, 255, 255)), new RectangleF(loc.X - mrg, loc.Y - sz.Height - mrg, pbar.Width + mrg * 2, pbar.Height + sz.Height + mrg * 2));
                        e.Graphics.DrawString(msg, Control.DefaultFont, Brushes.White, (financialChart1.Width - sz.Width) / 2, (financialChart1.Height - pbar.Height) / 2 - sz.Height);
                        pbar.Location = loc;
                    }
                };
            }

            pbar.Visible = true;
            financialChart1.Invalidate();
        }

        void HideProgressBar()
        {
            if (pbar != null)
                pbar.Visible = false;
        }

        void GetSymbolData(string sym, Action<string, SymbolData> action, bool showProgressBar = true, bool loadEvents = true)
        {
            if (showProgressBar)
                ShowProgressBar();
            DataService.GetSymbolDataAsync(sym, (name, data) =>
            {
                if (showProgressBar)
                    HideProgressBar();
                if (action != null)
                    action(name, data);
            }, loadEvents);
        }

        #endregion
    }
}
