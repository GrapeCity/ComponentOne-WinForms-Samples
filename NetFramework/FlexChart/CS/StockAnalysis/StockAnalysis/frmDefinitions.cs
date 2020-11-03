using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using C1.Win.Chart.Annotation;

using StockAnalysis.CustomIndicators;

namespace StockAnalysis
{
    using C1.Chart.Finance;
    using C1.Win.Chart.Finance;

    #region Annotation Editor
    public class frmAnnotation : frmBase
    {
        AnnotationBase _anno = null;
        bool isText = false;
        bool isLine = false;
        bool isShape = false;

        private void init(bool useDefaults)
        {
            doNotLoadOrSave = true;
            this.ClientSize = new Size(300, 95);
            this.Text = "Annotation";
            if (useDefaults)
            {
                Content = "Annotation";
                Stroke = Color.LightGreen;
                Fill = Color.LightGreen;
                FontFamily = "Arial";
                FontSize = "10";
                FontWeight = "Regular";
                ForeGround = Color.Black;
            }
            InitializeFormProperties(GetType());
        }

        public frmAnnotation(AnnotationBase anno)
        {
            doNotLoadOrSave = true;

            _anno = anno;

            ChartStyle style = null;
            if (anno is Text)
            {
                isText = true;
                Text t = anno as Text;
                Content = t.Content;
                style = t.Style;
                // Stroke, Fill are eliminated.
            }
            else if(anno is Shape)
            {
                isShape = true;
                Shape s = anno as Shape;
                Content = s.Content;
                Stroke = s.Style.StrokeColor;
                Fill = s.Style.FillColor;
                style = s.ContentStyle;
            }
            else if (anno is Line)
            {
                isLine = true;
                Line l = anno as Line;
                Content = l.Content;
                Stroke = l.Style.StrokeColor;
                style = l.ContentStyle;
                // Fill is eliminated
            }

            FontFamily = style.Font.FontFamily.Name;
            FontSize = style.Font.Size.ToString();
            FontWeight = style.Font.Style.ToString();
            ForeGround = style.StrokeColor;

            init(false);
        }

        public frmAnnotation()
        {
            doNotLoadOrSave = true;
        }

        public string Content { get; set; }
        public Color Stroke { get; set; }
        public Color Fill { get; set; }

        [DisplayName("Font Family")]
        public string FontFamily { get; set; }

        [DisplayName("Font Size")]
        public string FontSize { get; set; }

        [DisplayName("Font Weight")]
        public string FontWeight { get; set; }

        public Color ForeGround { get; set; }

        protected override void addInputFields(PropertyInfo pi)
        {
            if (pi.Name == "Stroke" && isText) return;
            if (pi.Name == "Fill" && (isText || isLine)) return;
            base.addInputFields(pi);
        }
        protected override void addInputField2(PropertyInfo pi)
        {
            string name = getDisplayName(pi);

            if (pi.PropertyType == typeof(Color))
            {
                Button b = new Button();
                b.Name = "btn" + pi.Name;
                b.Text = null;

                Color colorValue = (Color)pi.GetValue(this, null);
                b.Size = new Size(lineHeight, 6 * lineHeight / 7);
                b.BackColor = (pi.Name == "Stroke") ? Color.White : colorValue;
                b.Location = new Point(lastXPosition - b.Size.Width - nextControl.X, lineCenter - b.Size.Height / 2);
                lastXPosition = b.Location.X;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderColor = colorValue;
                b.FlatAppearance.BorderSize = 2;
                b.Padding = b.Margin = new System.Windows.Forms.Padding(0);
                b.Click += (sender, e) =>
                {
                    Button bs = sender as Button;
                    Point cdePosition = new Point(this.Left + Width / 2 - 105, this.Top + Height / 2 - 171);
                    ColorDialogEx cde = new ColorDialogEx(cdePosition.X, cdePosition.Y, "Select " + name + " Color");
                    cde.SolidColorOnly = false;
                    cde.Color = bs.BackColor;
                    if (cde.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        b.FlatAppearance.BorderColor = cde.Color;
                        if (b.Name != "btnStroke") b.BackColor = cde.Color;
                        pi.SetValue(this, cde.Color, null);
                    }
                };
                this.Controls.Add(b);
            }
            else if (pi.Name.StartsWith("Font"))
            {
                ComboBox cb = new ComboBox();
                cb.Name = "cbo" + pi.Name;
                cb.Items.AddRange(getFontValues(pi.Name));
                cb.Size = new Size(pi.Name == "FontFamily" ? 200 : 70, 6 * lineHeight / 7);
                cb.Location = new Point(lastXPosition - cb.Size.Width - nextControl.X, lineCenter - cb.Size.Height / 2);
                lastXPosition = cb.Location.X;
                cb.FlatStyle = FlatStyle.Flat;
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                cb.DrawMode = DrawMode.OwnerDrawFixed;
                cb.DrawItem += (sender, e) =>
                {
                    string item = cb.Items[e.Index] as string;
                    Brush backBrush = (e.State.HasFlag(DrawItemState.Selected) && cb.DroppedDown)
                        ? Brushes.LightGray : Brushes.White;
                    e.Graphics.FillRectangle(backBrush, e.Bounds);

                    bool isSymbolFont = (item.IndexOf("symbol", StringComparison.OrdinalIgnoreCase) > -1) ||
                        (item.IndexOf("wingding", StringComparison.OrdinalIgnoreCase) > -1);

                    Font font = (pi.Name == "FontFamily" && !isSymbolFont) ? new Font(item, cb.Font.Size) : null;

                    SizeF sz = e.Graphics.MeasureString(item, (font != null) ? font : cb.Font);
                    e.Graphics.DrawString(item, (font != null) ? font : cb.Font, Brushes.Black,
                        new PointF(e.Bounds.Right - sz.Width - 2, e.Bounds.Y));

                    if (font != null) font.Dispose();
                };
                cb.SelectedItem = pi.GetValue(this, null);
                cb.SelectedValueChanged += (sender, e) =>
                { 
                    pi.SetValue(this, cb.SelectedItem as string, null);
                };
                this.Controls.Add(cb);
            }
            else
            {
                TextBox tb = new TextBox();
                tb.Name = "txt" + pi.Name;
                tb.Text = pi.GetValue(this, null).ToString();
                tb.BorderStyle = BorderStyle.FixedSingle;
                tb.TextAlign = HorizontalAlignment.Left;
                tb.Size = new Size(200, lineHeight);
                tb.TextChanged += (s, e) => { pi.SetValue(this, tb.Text, null); };
                tb.Location = new Point(lastXPosition - tb.Size.Width - nextControl.X, lineCenter - tb.Size.Height / 2);
                lastXPosition = tb.Location.X;
                this.Controls.Add(tb);
            }
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            ChartStyle style = null;
            if (isText)
            {
                Text t = _anno as Text;
                t.Content = this.Content;
                style = t.Style;
            }
            else if (isShape)
            {
                Shape s = _anno as Shape;
                s.Content = this.Content;
                style = s.ContentStyle;
                s.Style.StrokeColor = this.Stroke;
                s.Style.FillColor = this.Fill;
            }
            else if (isLine)
            {
                Line l = _anno as Line;
                l.Content = this.Content;
                style = l.ContentStyle;
                l.Style.StrokeColor = this.Stroke;
            }

            Font font = new Font(this.FontFamily, float.Parse(this.FontSize), 
                (FontStyle)Enum.Parse(typeof(FontStyle), this.FontWeight));

            style.StrokeColor = this.ForeGround;
            style.Font = font;

            base.btnOK_Click(sender, e);
        }
    }
    #endregion

    #region Font Editor
    public class frmAnnoFont : frmBase
    {
        public frmAnnoFont()
        {
            this.ClientSize = new Size(300, 95);
            this.Text = "Font";
            if (!IsKeyed)
            {
                FontFamily = "Arial";
                FontSize = "8";
                FontWeight = "Regular";
                Foreground = Color.Black;
            }
            InitializeFormProperties(GetType());
        }

        [DisplayName("Font Family")]
        public string FontFamily { get; set; }

        [DisplayName("Font Size")]
        public string FontSize { get; set; }

        [DisplayName("Font Weight")]
        public string FontWeight { get; set; }

        public Color Foreground { get; set; }

        protected override void addInputField2(PropertyInfo pi)
        {
            string name = getDisplayName(pi);

            if (pi.PropertyType == typeof(Color))
            {
                Button b = new Button();
                b.Name = "btn" + pi.Name;
                b.Text = null;

                Color colorValue = (Color)pi.GetValue(this, null);
                b.Size = new Size(lineHeight, 6 * lineHeight / 7);
                b.BackColor = (pi.Name == "Stroke") ? Color.White : colorValue;
                b.Location = new Point(lastXPosition - b.Size.Width - nextControl.X, lineCenter - b.Size.Height / 2);
                lastXPosition = b.Location.X;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderColor = colorValue;
                b.FlatAppearance.BorderSize = 2;
                b.Padding = b.Margin = new System.Windows.Forms.Padding(0);
                b.Click += (sender, e) =>
                {
                    Button bs = sender as Button;
                    Point cdePosition = bs.PointToScreen(new Point(0, bs.Height + 1));
                    ColorDialogEx cde = new ColorDialogEx(cdePosition.X, cdePosition.Y, "Select " + name + " Color");
                    cde.SolidColorOnly = true;
                    cde.Color = bs.BackColor;
                    if (cde.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        b.FlatAppearance.BorderColor = b.BackColor = cde.Color;
                        pi.SetValue(this, cde.Color, null);
                    }
                };
                this.Controls.Add(b);
            }
            else if (pi.Name.StartsWith("Font"))
            {
                ComboBox cb = new ComboBox();
                cb.Name = "cbo" + pi.Name;
                cb.Items.AddRange(getFontValues(pi.Name));
                cb.Size = new Size(pi.Name == "FontFamily" ? 200 : 70, 6 * lineHeight / 7);
                cb.Location = new Point(lastXPosition - cb.Size.Width - nextControl.X, lineCenter - cb.Size.Height / 2);
                lastXPosition = cb.Location.X;
                cb.FlatStyle = FlatStyle.Flat;
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                cb.DrawMode = DrawMode.OwnerDrawFixed;
                cb.DrawItem += (sender, e) =>
                {
                    string item = cb.Items[e.Index] as string;
                    Brush backBrush = (e.State.HasFlag(DrawItemState.Selected) && cb.DroppedDown)
                        ? Brushes.LightGray : Brushes.White;
                    e.Graphics.FillRectangle(backBrush, e.Bounds);

                    bool isSymbolFont = (item.IndexOf("symbol", StringComparison.OrdinalIgnoreCase) > -1) ||
                        (item.IndexOf("wingding", StringComparison.OrdinalIgnoreCase) > -1);

                    Font font = (pi.Name == "FontFamily" && !isSymbolFont) ? new Font(item, cb.Font.Size) : null;

                    SizeF sz = e.Graphics.MeasureString(item, (font != null) ? font : cb.Font);
                    e.Graphics.DrawString(item, (font != null) ? font : cb.Font, Brushes.Black,
                        new PointF(e.Bounds.Right - sz.Width - 2, e.Bounds.Y));

                    if (font != null) font.Dispose();
                };
                cb.SelectedItem = pi.GetValue(this, null);
                cb.SelectedValueChanged += (sender, e) =>
                {
                    pi.SetValue(this, cb.SelectedItem as string, null);
                };
                this.Controls.Add(cb);
            }
        }

        public Font GetFont()
        {
            Font font = new Font(this.FontFamily, float.Parse(this.FontSize),
                (FontStyle)Enum.Parse(typeof(FontStyle), this.FontWeight));

            return font;
        }

        public bool FontDiffers(Font font)
        {
            return font == null || font.FontFamily.Name != FontFamily || 
                font.Size.ToString() != FontSize || font.Style.ToString() != FontWeight;
        }
    }
    #endregion

    #region Chart Options
    public class frmKagi : frmBase
    {
        public frmKagi()
        {
            this.Text = "Kagi";
            if(!IsKeyed)
            {
                this.RangeMode = RangeMode.Fixed;
                this.ReversalAmount = 2.0;
                this.DataFields = DataFields.Close;
            }
            InitializeFormProperties(GetType());
        }

        public RangeMode RangeMode { get; set; }

        [DisplayName("Reversal Amount")]
        public double ReversalAmount { get; set; }

        [DisplayName("Data Fields")]
        public DataFields DataFields { get; set; }
    }

    public class frmRenko : frmBase
    {
        public frmRenko()
        {
            this.Text = "Renko";
            if (!IsKeyed)
            {
                this.RangeMode = RangeMode.Fixed;
                this.ReversalAmount = 2.0;
                this.DataFields = DataFields.Close;
            }
            InitializeFormProperties(GetType());
        }

        public RangeMode RangeMode { get; set; }
        public double ReversalAmount { get; set; }
        public DataFields DataFields { get; set; }
    }

    public class frmPointAndFigure : frmBase
    {
        public frmPointAndFigure()
        {
            this.Text = "Point & Figure";
            if (!IsKeyed)
            {
                this.DataFields = DataFields.Close;
                this.ReversalAmount = 2.0;
                this.Scaling = PointAndFigureScaling.Traditional;
                this.BoxSize = 2.0;
                this.Period = 14;
                this.SquareGrid = false;
            }
            InitializeFormProperties(GetType());
        }

        [DisplayName("Data Fields")]
        public DataFields DataFields { get; set; }

        [DisplayName("Reversal Amount")]
        public double ReversalAmount { get; set; }

        public PointAndFigureScaling Scaling { get; set; }
        
        [DisplayName("Box Size")]
        public double BoxSize { get; set; }

        [DisplayName("ATR Period")]
        public int Period { get; set; }

        [DisplayName("Square Grid")]
        public bool SquareGrid { get; set; }
    }
    #endregion

    #region Indicators
    
    public class frmATR : frmBase
    {
        public frmATR()
        {
            this.Text = "Average Time Range (ATR)";
            if (!IsKeyed)
            {
                this.Period = 14;
                this.ATR = Color.Black;
            }
            InitializeFormProperties(GetType());
        }

        public int Period { get; set; }
        public Color ATR { get; set; }

        public override void SetSeriesData(FinancialChart chart)
        {
            ATR atr = chart.Series.FirstOrDefault(s => s is ATR) as ATR;
            if (atr != null)
            {
                atr.Style.StrokeColor = ATR;
                atr.Period = Period;
            }
        }
    }

    public class frmADX : frmBase
    {
        static int dataLen = -1;

        public frmADX()
        {
            this.Text = "Average Directional Index (ADX)";
            if (!IsKeyed)
            {
                this.Period = 14;
                //this.ADXColor = Color.Black;
                this.UpTrend = Color.Green;
                this.DownTrend = Color.Red;
            }
            InitializeFormProperties(GetType());
        }

        public int Period { get; set; }
        //[DisplayName("ADX Color")]
        //public Color ADXColor { get; set; }
        public Color UpTrend { get; set; }
        public Color DownTrend { get; set; }

        public override void SetSeriesData(FinancialChart chart, object obj)
        {
            ADXIndicator.ADXSeries adxSeries = chart.Series.FirstOrDefault(s => s is ADXIndicator.ADXSeries) as ADXIndicator.ADXSeries;
            ADXIndicator.DINASeries dinaSeries = chart.Series.FirstOrDefault(s => s is ADXIndicator.DINASeries) as ADXIndicator.DINASeries;
            ADXIndicator.DIPASeries dipaSeries = chart.Series.FirstOrDefault(s => s is ADXIndicator.DIPASeries) as ADXIndicator.DIPASeries;

            //if (adxSeries != null)
            //    adxSeries.Style.StrokeColor = ADXColor;

            if (dinaSeries != null)
                dinaSeries.Style.StrokeColor = DownTrend;

            if (dipaSeries != null)
                dipaSeries.Style.StrokeColor = UpTrend;

            if (adxSeries != null && dinaSeries != null && dipaSeries != null)
            {
                if (obj is ViewModel.ViewModel)
                {
                    var viewModel = (ViewModel.ViewModel)obj;
                    dataLen = viewModel.CurrentQuote.Data.Count();

                    if (Period != adxSeries.Period)
                    {
                        ADXIndicator.AdxDataPoint[] adxDataPts;
                        IEnumerable<Object.QuoteData> quoteData = viewModel.CurrentQuote.Data;
                        ADXIndicator.Create(quoteData.ToArray(), Period, out adxDataPts);
                        dipaSeries.DataSource = dinaSeries.DataSource = adxSeries.DataSource = adxDataPts;
                        dipaSeries.Rebind();
                        dinaSeries.Rebind();
                        adxSeries.Rebind();
                    }
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK && dataLen > 1 && (Period < 1 || Period > dataLen-1))
            {
                MessageBox.Show("Period value must be > 1 and < " + (dataLen - 1).ToString(),
                    "A.D.X. Indicator parameter error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            base.OnClosing(e);
        }
    }

    public class frmMassIndex : frmBase
    {
        static int dataLen = -1;

        public frmMassIndex()
        {
            this.Text = "Mass Index";
            if (!IsKeyed)
            {
                this.Period = 25;
                this.Threshold = Color.Green;
                this.ThresholdValue = 29;
                Result = Color.Black;
            }
            InitializeFormProperties(GetType());
        }

        public int Period { get; set; }
        public Color Result { get; set; }
        public Color Threshold { get; set; }
        public double ThresholdValue { get; set; }

        public override void SetSeriesData(FinancialChart chart, object obj)
        {
            MassIndexIndicator.MassIndexSeries mis =
                chart.Series.FirstOrDefault(s => s is MassIndexIndicator.MassIndexSeries) as MassIndexIndicator.MassIndexSeries;

            MassIndexIndicator.MassIndexThresholdSeries mits =
                chart.Series.FirstOrDefault(s => s is MassIndexIndicator.MassIndexThresholdSeries) as MassIndexIndicator.MassIndexThresholdSeries;

            if (mis != null)
            {
                mis.Style.StrokeColor = Result;

                if (obj is ViewModel.ViewModel)
                {
                    var viewModel = (ViewModel.ViewModel)obj;
                    dataLen = viewModel.CurrentQuote.Data.Count();
                    if (Period > dataLen - 18)
                        Period = dataLen - 18;

                    if (Period != mis.Period)
                    {
                        MassIndexIndicator.MassIndexDataPoint[] massIndexDataPts;
                        IEnumerable<Object.QuoteData> quoteData = viewModel.CurrentQuote.Data;
                        MassIndexIndicator.Create(quoteData.ToArray(), Period, out massIndexDataPts);
                        mis.DataSource = massIndexDataPts;
                    }
                }
            }

            if (mits != null)
            {
                mits.Threshold = ThresholdValue;
                mits.Style.StrokeColor = Threshold;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK && dataLen > 1 && (Period < 1 || Period > dataLen - 18))
            {
                MessageBox.Show("Period value must be > 1 and < " + (dataLen - 18).ToString(),
                    "MassIndex Indicator parameter error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            base.OnClosing(e);
        }
    }

    public class frmRSI : frmBase
    {
        public frmRSI()
        {
            this.Text = "Relative Strength Index (RSI)";
            if (!IsKeyed)
            {
                this.Period = 14;
                this.RSI = Color.Black;
                this.ShowZones = true;
                this.OverBought = Color.Green;
                this.OverBoughtValue = 80.0;
                this.OverSold = Color.Red;
                this.OverSoldValue = 20.0;
            }
            InitializeFormProperties(GetType());
        }

        public int Period { get; set; }
        public Color RSI { get; set; }

        [DisplayName("Show Zones")]
        public bool ShowZones { get; set; }

        public Color OverBought { get; set; }
        public double OverBoughtValue { get; set; }

        public Color OverSold { get; set; }
        public double OverSoldValue { get; set; }

        public override void SetSeriesData(FinancialChart chart)
        {
            RSI primary = chart.Series.FirstOrDefault(s => s is RSI) as RSI;
            if (primary != null)
            {
                primary.Period = Period;
                primary.Style.StrokeColor = RSI;
                base.SetSeriesOvers(chart, primary, OverBoughtValue, OverBought, OverSoldValue, OverSold, ShowZones);
            }
        }
    }

    public class frmCCI : frmBase
    {
        public frmCCI()
        {
            this.Text = "Commodity Channel Index (CCI)";
            if (!IsKeyed)
            {
                this.Period = 20;
                this.Result = Color.Black;
                this.ShowZones = true;
                this.OverBought = Color.Green;
                this.OverBoughtValue = 100.0;
                this.OverSold = Color.Red;
                this.OverSoldValue = -100.0;
            }
            InitializeFormProperties(GetType());
        }

        public int Period { get; set; }
        public Color Result { get; set; }

        [DisplayName("Show Zones")]
        public bool ShowZones { get; set; }

        public Color OverBought { get; set; }
        public double OverBoughtValue { get; set; }

        public Color OverSold { get; set; }
        public double OverSoldValue { get; set; }

        public override void SetSeriesData(FinancialChart chart)
        {
            CCI primary = chart.Series.FirstOrDefault(s => s is CCI) as CCI;
            if (primary != null)
            {
                primary.Period = Period;
                primary.Style.StrokeColor = Result;
                base.SetSeriesOvers(chart, primary, OverBoughtValue, OverBought, OverSoldValue, OverSold, ShowZones);
            }
        }
    }

    public class frmWilliamsR : frmBase
    {
        public frmWilliamsR()
        {
            this.Text = "Williams% R";
            if (!IsKeyed)
            {
                this.Period = 14;
                this.Result = Color.Black;
                this.ShowZones = true;
                this.OverBought = Color.Green;
                this.OverBoughtValue = -20.0;
                this.OverSold = Color.Red;
                this.OverSoldValue = -80.0;
            }
            InitializeFormProperties(GetType());
        }

        public int Period { get; set; }
        public Color Result { get; set; }

        [DisplayName("Show Zones")]
        public bool ShowZones { get; set; }

        public Color OverBought { get; set; }
        public double OverBoughtValue { get; set; }

        public Color OverSold { get; set; }
        public double OverSoldValue { get; set; }

        public override void SetSeriesData(FinancialChart chart)
        {
            WilliamsR primary = chart.Series.FirstOrDefault(s => s is WilliamsR) as WilliamsR;
            if (primary != null)
            {
                primary.Period = Period;
                primary.Style.StrokeColor = Result;
                base.SetSeriesOvers(chart, primary, OverBoughtValue, OverBought, OverSoldValue, OverSold, ShowZones);
            }
        }

        protected override bool ValidateProperty(string propertyName, object value)
        {
            if (propertyName.StartsWith("Over") && (!(value is double) || (double)value > 0 || (double)value < -100))
            {
                MessageBox.Show("This value must be <= 0 and => -100");
                return false;
            }
            return base.ValidateProperty(propertyName, value);
        }
    }

    public class frmMacd : frmBase
    {
        public frmMacd()
        {
            this.Text = "MACD";
            if (!IsKeyed)
            {
                this.FastMAPeriod = 14;
                this.SlowMAPeriod = 26;
                this.SignalPeriod = 9;
                this.MACD = Color.Black;
                this.Signal = Color.Yellow;
                this.IncreasingBar = Color.Green;
                this.DecreasingBar = Color.Red;
            }
            InitializeFormProperties(GetType());
        }

        [DisplayName("Fast MA Period")]
        public int FastMAPeriod { get; set; }

        [DisplayName("Slow MA Period")]
        public int SlowMAPeriod { get; set; }

        [DisplayName("Signal Period")]
        public int SignalPeriod { get; set; }

        public Color MACD { get; set; }
        public Color Signal { get; set; }

        [DisplayName("Increasing Bar")]
        public Color IncreasingBar { get; set; }

        [DisplayName("Decreasing Bar")]
        public Color DecreasingBar { get; set; }

        public override void SetSeriesData(FinancialChart chart)
        {
            Macd macd = chart.Series.FirstOrDefault(s => s.Name == "Macd") as Macd;
            FinancialSeries mdh = chart.Series.FirstOrDefault(s => s.Name == "MacdHistogram") as FinancialSeries;
            //MacdHistogram mdh = chart.Series.FirstOrDefault(s => s.Name == "MacdHistogram") as MacdHistogram;
            if (macd != null)
            {
                macd.FastPeriod = this.FastMAPeriod;
                macd.SlowPeriod = this.SlowMAPeriod;
                macd.SmoothingPeriod = this.SignalPeriod;
                macd.Style.StrokeColor = this.MACD;
                macd.SignalLineStyle.StrokeColor = this.Signal;
            }

            if (mdh != null)
            {
                //mdh.FastPeriod = this.FastMAPeriod;
                //mdh.SlowPeriod = this.SlowMAPeriod;
                //mdh.SmoothingPeriod = this.SignalPeriod;
                mdh.Style.FillColor = mdh.Style.StrokeColor = IncreasingBar;
                mdh.AltStyle.FillColor = mdh.AltStyle.StrokeColor = DecreasingBar;
            }
        }
    }

    public class frmStochastic : frmBase
    {
        public frmStochastic()
        {
            this.Text = "Stochastic";
            if (!IsKeyed)
            {
                this.StochasticType = PresetTypes.Manual;
                this.DPeriod = 3;
                this.KPeriod = 14;
                this.SmoothingPeriod = 1;
                this.DColor = Color.Black;
                this.KColor = Color.Orange;
                this.ShowZones = true;
                this.OverBought = Color.Green;
                this.OverBoughtValue = 80.0;
                this.OverSold = Color.Red;
                this.OverSoldValue = 20.0;
            }
            InitializeFormProperties(GetType());
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            updateControls();
        }

        public enum PresetTypes { Manual, Fast, Slow, Full };
        
        PresetTypes stochasticType;

        [DisplayName("Stochastic Type")]
        public PresetTypes StochasticType
        { 
            get { return stochasticType; }
            set
            {
                if (value != stochasticType)
                {
                    stochasticType = value;
                    switch (value)
                    {
                        case PresetTypes.Fast:
                            DPeriod = 3;
                            KPeriod = 14;
                            SmoothingPeriod = 1;
                            break;

                        case PresetTypes.Slow:
                            DPeriod = 3;
                            KPeriod = 14;
                            SmoothingPeriod = 3;
                            break;

                        case PresetTypes.Full:
                            if(SmoothingPeriod == 1)
                                SmoothingPeriod = 3;
                            DPeriod = SmoothingPeriod;
                            KPeriod = 14;
                            break;
                    }
                    updateControls();
                }
            }
        }

        private void updateControls()
        {
            TextBox tb = Controls["txtDPeriod"] as TextBox;
            if (tb != null)
            {
                tb.Text = DPeriod.ToString();
                tb.ReadOnly = (stochasticType != PresetTypes.Manual);
            }

            tb = Controls["txtKPeriod"] as TextBox;
            if (tb != null)
            {
                tb.Text = KPeriod.ToString();
                tb.ReadOnly = (stochasticType != PresetTypes.Manual);
            }

            tb = Controls["txtSmoothingPeriod"] as TextBox;
            if (tb != null)
            {
                tb.Text = SmoothingPeriod.ToString();
                tb.ReadOnly = !(stochasticType == PresetTypes.Manual || stochasticType == PresetTypes.Full);
            }
        }

        [DisplayName("%D Period")]
        public int DPeriod { get; set; }

        [DisplayName("%K Period")]
        public int KPeriod { get; set; }

        int smoothingPeriod;

        [DisplayName("Smoothing Period")]
        public int SmoothingPeriod 
        {
            get { return smoothingPeriod; }
            set
            {
                if (value != smoothingPeriod)
                {
                    smoothingPeriod = value;
                    if (stochasticType == PresetTypes.Full)
                    {
                        DPeriod = smoothingPeriod;
                        updateControls();
                    }
                }
            }
        }

        [DisplayName("%D Line")]
        public Color DColor { get; set; }

        [DisplayName("%K Line")]
        public Color KColor { get; set; }

        [DisplayName("Show Zones")]
        public bool ShowZones { get; set; }

        public Color OverBought { get; set; }
        public double OverBoughtValue { get; set; }

        public Color OverSold { get; set; }
        public double OverSoldValue { get; set; }

        public override void SetSeriesData(FinancialChart chart)
        {
            Stochastic primary = chart.Series.FirstOrDefault(s => s is Stochastic) as Stochastic;

            if (primary != null)
            {
                primary.DPeriod = DPeriod;
                primary.KPeriod = KPeriod;
                primary.SmoothingPeriod = SmoothingPeriod;
                primary.DLineStyle.StrokeColor = DColor;
                primary.KLineStyle.StrokeColor = KColor;

                base.SetSeriesOvers(chart, primary, OverBoughtValue, OverBought, OverSoldValue, OverSold, ShowZones);
            }
        }
    }

    public class frmVolume : frmBase
    {
        public frmVolume()
        {
            this.Text = "Volume Chart";
            if (!IsKeyed)
            {
                UpVolume = Color.Green;
                DownVolume = Color.Red;
            }
            InitializeFormProperties(GetType());
        }

        [DisplayName("Up Volume")]
        public Color UpVolume { get; set; }

        [DisplayName("Down Volume")]
        public Color DownVolume { get; set; }

        public override void SetSeriesData(FinancialChart chart)
        {
            FinancialSeries fs = chart.Series.FirstOrDefault(s => s.Name == "Volume") as FinancialSeries;
            if (fs != null)
            {
                fs.Style.StrokeColor = fs.Style.FillColor = UpVolume;
                fs.AltStyle = new ChartStyle() { FillColor = DownVolume, StrokeColor = DownVolume };
            }
        }
    }
    #endregion

    #region Overlays

    public class frmIchimokuCloud : frmBase
    {
        public frmIchimokuCloud()
        {
            this.Text = "Ichimoku Cloud";
            if (!IsKeyed)
            {
                this.ConversionPeriod = 9;
                this.BasePeriod = 26;
                this.LeadingPeriod = 52;
                this.LaggingPeriod = 26;
                ConversionLineStyle = Color.Orange;
                BaseLineStyle = Color.Blue;
                LaggingLineStyle = Color.Black;
                LeadingSpanALineStyle = Color.Green;
                LeadingSpanBLineStyle = Color.Red;
                BullishCloudColor = Color.Green;
                BearishCloudColor = Color.Red;
            }
            InitializeFormProperties(GetType());
        }

        public int ConversionPeriod { get; set; }
        public int BasePeriod { get; set; }
        public int LeadingPeriod { get; set; }
        public int LaggingPeriod { get; set; }

        [DisplayName("Conversion LineStyle")]
        public Color ConversionLineStyle { get; set; }
        [DisplayName("Base LineStyle")]
        public Color BaseLineStyle { get; set; }
        [DisplayName("Lagging LineStyle")]
        public Color LaggingLineStyle { get; set; }
        [DisplayName("LeadingSpanA LineStyle ")]
        public Color LeadingSpanALineStyle { get; set; }
        [DisplayName("LeadingSpanB LineStyle")]
        public Color LeadingSpanBLineStyle { get; set; }
        [DisplayName("Bullish Color")]
        public Color BullishCloudColor { get; set; }
        [DisplayName("Bearish Color")]
        public Color BearishCloudColor { get; set; }

        public override void SetSeriesData(FinancialChart chart)
        {
            IchimokuCloud ichimokuCloud = chart.Series.FirstOrDefault(s => s is IchimokuCloud) as IchimokuCloud;
            if (ichimokuCloud != null)
            {
                ichimokuCloud.ConversionPeriod = this.ConversionPeriod;
                ichimokuCloud.BasePeriod = this.BasePeriod;
                ichimokuCloud.LeadingPeriod = this.LeadingPeriod;
                ichimokuCloud.LaggingPeriod = this.LaggingPeriod;
                ichimokuCloud.ConversionLineStyle.StrokeColor = ConversionLineStyle;
                ichimokuCloud.BaseLineStyle.StrokeColor = BaseLineStyle;
                ichimokuCloud.LaggingLineStyle.StrokeColor = LaggingLineStyle;
                ichimokuCloud.LeadingSpanALineStyle.StrokeColor = LeadingSpanALineStyle;
                ichimokuCloud.LeadingSpanBLineStyle.StrokeColor = LeadingSpanBLineStyle;
                ichimokuCloud.BullishCloudColor = new SolidBrush(BullishCloudColor);
                ichimokuCloud.BearishCloudColor = new SolidBrush(BearishCloudColor);
            }
        }
    }

    public class frmAlligator : frmBase
    {
        public frmAlligator()
        {
            this.Text = "Alligator";
            if (!IsKeyed)
            {
                this.JawPeriod = 13;
                this.TeethPeriod = 8;
                this.LipsPeriod = 5;              
                JawLineStyle = Color.Green;
                TeethLineStyle = Color.Red;
                LipsLineStyle = Color.Black;               
            }
            InitializeFormProperties(GetType());
        }

        public int JawPeriod { get; set; }
        public int TeethPeriod { get; set; }
        public int LipsPeriod { get; set; }       

        [DisplayName("Jaw Line Style")]
        public Color JawLineStyle { get; set; }
        [DisplayName("Teeth Line Style")]
        public Color TeethLineStyle { get; set; }
        [DisplayName("Lips LineStyle")]
        public Color LipsLineStyle { get; set; }       

        public override void SetSeriesData(FinancialChart chart)
        {
            Alligator alligator = chart.Series.FirstOrDefault(s => s is Alligator) as Alligator;
            if (alligator != null)
            {
                alligator.JawPeriod = this.JawPeriod;
                alligator.TeethPeriod = this.TeethPeriod;
                alligator.LipsPeriod = this.LipsPeriod;        
                alligator.JawLineStyle.StrokeColor = JawLineStyle;
                alligator.TeethLineStyle.StrokeColor = TeethLineStyle;
                alligator.LipsLineStyle.StrokeColor = LipsLineStyle;
                chart.Invalidate();
            }
        }
    }

    public class frmZigZag : frmBase
    {
        public frmZigZag()
        {
            this.Text = "ZigZag";
            if (!IsKeyed)
            {
                this.Distance = 5;               
                this.ZigZag = Color.Green;
            }
            InitializeFormProperties(GetType());
        }

        public int Distance { get; set; }    

        [DisplayName("ZigZag")]
        public Color ZigZag { get; set; }

        public override void SetSeriesData(FinancialChart chart)
        {
            ZigZag zigZag = chart.Series.FirstOrDefault(s => s is ZigZag) as ZigZag;
            if (zigZag != null)
            {              
                zigZag.Distance = this.Distance;
                zigZag.Style.StrokeColor = this.ZigZag;
            }
        }
    }

    public class frmBollingerBands : frmBase
    {
        public frmBollingerBands()
        {
            this.Text = "Bollinger Bands";
            if (!IsKeyed)
            {
                this.Period = 20;
                this.Multiplier = 2;
                this.BollingerBands = Color.Green;
            }
            InitializeFormProperties(GetType());
        }

        public int Period { get; set; }
        public int Multiplier { get; set; }

        [DisplayName("Bollinger Bands")]
        public Color BollingerBands { get; set; }

        public override void SetSeriesData(FinancialChart chart)
        {
            BollingerBands bb = chart.Series.FirstOrDefault(s => s is BollingerBands) as BollingerBands;
            if (bb != null)
            {
                bb.Multiplier = this.Multiplier;
                bb.Period = this.Period;
                bb.Style.StrokeColor = this.BollingerBands;
            }
        }
    }

    public class frmEnvelopes : frmBase
    {
        public frmEnvelopes()
        {
            this.Text = "Envelopes";
            if (!IsKeyed)
            {
                this.Period = 20;
                this.EnvelopeSize = 3.0;
                this.Type = MovingAverageType.Simple;
                Envelope = Color.Green;
            }
            InitializeFormProperties(GetType());
        }

        public int Period { get; set; }

        [DisplayName("Size (%)")]
        public double EnvelopeSize { get; set; }

        public MovingAverageType Type { get; set; }
        public Color Envelope { get; set; }

        public override void SetSeriesData(FinancialChart chart)
        {
            Envelopes env = chart.Series.FirstOrDefault(s => s is Envelopes) as Envelopes;
            if (env != null)
            {
                env.Period = this.Period;
                env.Size = this.EnvelopeSize / 100;
                env.Type = this.Type;
                env.Style.StrokeColor = this.Envelope;
            }
        }

    }

    public class frmFibonacciRetracements : frmBase
    {
        public frmFibonacciRetracements()
        {
            this.Text = "Fibonacci Retracements";
            if (!IsKeyed)
            {
                this.UpTrend = true;
                this.LabelPosition = LabelPosition.Left;
                this.LineColor = Color.Blue;
            }
            InitializeFormProperties(GetType());
        }

        public bool UpTrend { get; set; }

        [DisplayName("Label Position")]
        public LabelPosition LabelPosition { get; set; }

        [DisplayName("Line Color")]
        public Color LineColor { get; set; }

        public override void SetSeriesData(FinancialChart chart)
        {
            Fibonacci fibSeries = chart.Series.FirstOrDefault(s => s is Fibonacci) as Fibonacci;
            if (fibSeries != null)
            {
                fibSeries.Uptrend = this.UpTrend;
                fibSeries.LabelPosition = this.LabelPosition;
                fibSeries.Style.StrokeColor = this.LineColor;
            }
        }

        public override void BuildForm()
        {
            base.BuildForm();
            ComboBox cb = Controls["cboLabelPosition"] as ComboBox;
            cb.Items.Clear();
            cb.Items.AddRange(new object[] { "Left", "Center", "Right" });
            cb.SelectedItem = this.LabelPosition.ToString();
        }
    }

    public class frmFibonacciArcs : frmBase
    {
        public frmFibonacciArcs()
        {
            this.Text = "Fibonacci Arcs";
            if (!IsKeyed)
            {
                this.EndX = this.StartX = -1;
                this.EndY = this.StartY = 0;
                this.ArcColor = Color.Blue;
            }
            InitializeFormProperties(this.GetType());
        }

        public int StartX { get; set; }
        public int EndX { get; set; }
        public int StartY { get; set; }
        public int EndY { get; set; }

        [DisplayName("Fibonacci Arc Color")]
        public Color ArcColor { get; set; }

        public override void SetSeriesData(FinancialChart chart, object obj)
        {
            FibonacciArcs fiboArc = chart.Series.FirstOrDefault(s => s is FibonacciArcs) as FibonacciArcs;
            if (fiboArc != null)
            {
                fiboArc.StartX = this.StartX;
                fiboArc.EndX = this.EndX;
                fiboArc.StartY = this.StartY;
                fiboArc.EndY = this.EndY;
                fiboArc.Style.StrokeColor = this.ArcColor;

                if (fiboArc.StartX != null && Convert.ToInt32(fiboArc.StartX) < 0)
                    ((MainForm)obj).SetFibonacciValues(fiboArc as FibonacciExtension);
            }
        }
    }

    public class frmFibonacciFans : frmBase
    {
        public frmFibonacciFans()
        {
            this.Text = "Fibonacci Fans";
            if (!IsKeyed)
            {
                this.EndX = this.StartX = -1;
                this.EndY = this.StartY = 0;
                this.FanColor = Color.Blue;
            }
            InitializeFormProperties(this.GetType());
        }

        public int StartX { get; set; }
        public int EndX { get; set; }
        public int StartY { get; set; }
        public int EndY { get; set; }

        [DisplayName("Fibonacci Fan Color")]
        public Color FanColor { get; set; }

        public override void SetSeriesData(FinancialChart chart, object obj)
        {
            FibonacciFans fiboFan = chart.Series.FirstOrDefault(s => s is FibonacciFans) as FibonacciFans;
            if (fiboFan != null)
            {
                fiboFan.StartX = this.StartX;
                fiboFan.EndX = this.EndX;
                fiboFan.StartY = this.StartY;
                fiboFan.EndY = this.EndY;
                fiboFan.Style.StrokeColor = this.FanColor;

                if (fiboFan.StartX != null && Convert.ToInt32(fiboFan.StartX) < 0)
                    ((MainForm)obj).SetFibonacciValues(fiboFan as FibonacciExtension);
            }
        }
    }

    public class frmFibonacciTimeZones : frmBase
    {
        public frmFibonacciTimeZones()
        {
            this.Text = "Fibonacci Time Zones";
            if (!IsKeyed)
            {
                this.StartX = 0;
                this.EndX = 3;
                this.Color = Color.Blue;
            }
            InitializeFormProperties(GetType());
        }

        [DisplayName("Start X")]
        public int StartX { get; set; }

        [DisplayName("End X")]
        public int EndX { get; set; }

        public Color Color { get; set; }

        public override void SetSeriesData(FinancialChart chart, object obj)
        {
            FibonacciTimeZones ftz = chart.Series.FirstOrDefault(s => s is FibonacciTimeZones) as FibonacciTimeZones;
            if (ftz != null)
            {
                ftz.StartX = this.StartX;
                ftz.EndX = this.EndX;
                ftz.Style.StrokeColor = this.Color;

                if (ftz.StartX != null && Convert.ToInt32(ftz.StartX) < 0)
                    ((MainForm)obj).SetFibonacciValues(ftz as FibonacciExtension);
            }
        }
    }

    public class frmPivotPoints : frmBase
    {
        public frmPivotPoints()
        {
            this.Text = "Pivot Points";
            if (!IsKeyed)
            {
                this.PivotType = PivotPointType.Standard;
                this.Pivot = Color.Black;
                this.Resistance1 = Color.Green;
                this.Resistance2 = Color.DarkGreen;
                this.Resistance3 = Color.Blue;
                this.Support1 = Color.Yellow;
                this.Support2 = Color.Orange;
                this.Support3 = Color.Red;
            }
            InitializeFormProperties(GetType());
        }

        public enum PivotPointType { Standard, Fibonacci };

        public PivotPointType PivotType { get; set; }

        public Color Pivot { get; set; }

        [DisplayName("Resistance 1")]
        public Color Resistance1 { get; set; }

        [DisplayName("Resistance 2")]
        public Color Resistance2 { get; set; }

        [DisplayName("Resistance 3")]
        public Color Resistance3 { get; set; }

        [DisplayName("Support 1")]
        public Color Support1 { get; set; }

        [DisplayName("Support 2")]
        public Color Support2 { get; set; }

        [DisplayName("Support 3")]
        public Color Support3 { get; set; }

        public override void SetSeriesData(FinancialChart chart, object obj)
        {
            PivotPointOverlay.PivotSeries pivot = 
                chart.Series.FirstOrDefault(s => s is PivotPointOverlay.PivotSeries) as PivotPointOverlay.PivotSeries;

            PivotPointOverlay.S1Series s1 =
                chart.Series.FirstOrDefault(s => s is PivotPointOverlay.S1Series) as PivotPointOverlay.S1Series;

            PivotPointOverlay.S2Series s2 =
                chart.Series.FirstOrDefault(s => s is PivotPointOverlay.S2Series) as PivotPointOverlay.S2Series;

            PivotPointOverlay.S3Series s3 =
                chart.Series.FirstOrDefault(s => s is PivotPointOverlay.S3Series) as PivotPointOverlay.S3Series;

            PivotPointOverlay.R1Series r1 =
                chart.Series.FirstOrDefault(s => s is PivotPointOverlay.R1Series) as PivotPointOverlay.R1Series;

            PivotPointOverlay.R2Series r2 =
                chart.Series.FirstOrDefault(s => s is PivotPointOverlay.R2Series) as PivotPointOverlay.R2Series;

            PivotPointOverlay.R3Series r3 = 
                chart.Series.FirstOrDefault(s => s is PivotPointOverlay.R3Series) as PivotPointOverlay.R3Series;

            if (pivot != null) pivot.Style.StrokeColor = Pivot;
            if (s1 != null) s1.Style.StrokeColor = Support1;
            if (s2 != null) s2.Style.StrokeColor = Support2;
            if (s3 != null) s3.Style.StrokeColor = Support3;
            if (r1 != null) r1.Style.StrokeColor = Resistance1;
            if (r2 != null) r2.Style.StrokeColor = Resistance2;
            if (r3 != null) r3.Style.StrokeColor = Resistance3;

            bool isStandard = PivotType == PivotPointType.Standard;
            if (pivot != null && pivot.IsStandard != isStandard)
            {
                var viewModel = obj as ViewModel.ViewModel;
                IEnumerable<Object.QuoteData> quoteData = viewModel.CurrentQuote.Data;
                PivotPointOverlay.PivotPoint[] pivotData = null;
                PivotPointOverlay.Create(quoteData, isStandard, out pivotData);
                pivot.DataSource = s1.DataSource = s2.DataSource = s3.DataSource = r1.DataSource = r2.DataSource = r3.DataSource = pivotData;
                pivot.Rebind(); s1.Rebind(); s2.Rebind(); s3.Rebind(); r1.Rebind(); r2.Rebind(); r3.Rebind();
                pivot.IsStandard = isStandard;
            }
        }

    }
    #endregion

}
