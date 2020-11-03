using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockChart
{
    class ComparisonQuotesLabel : System.Windows.Forms.Label
    {
        public ComparisonQuotesLabel()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);
        }

        private IEnumerable<QuoteInfo> _quotesInfo;
        public IEnumerable<QuoteInfo> QuotesInfo
        {
            get { return _quotesInfo; }
            set
            {
                _quotesInfo = value;
                this.Invalidate();
            }
        }

        private DisplayMode _displayMode = DisplayMode.Independent;
        public DisplayMode DisplayMode
        {
            get { return _displayMode; }
            set { _displayMode = value; this.Invalidate(); }
        }


        private const int GAP = 5;
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (this._quotesInfo == null || this._quotesInfo.Count() == 0)
            {
                return;
            }

            Graphics g = pe.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;
            
            float right = 0;

            if (this.DisplayMode == DisplayMode.Comparison)
            {

                foreach (var quote in this._quotesInfo)
                {
                    var format = string.Format((quote.Value >= 0 ? "+{0:P2}" : "{0:P2}"), quote.Value);
                    if (quote.Value == 0)
                    {
                        format = "{0:P2}";
                    }

                    string value = string.Format(format, quote.Value);
                    SizeF fontSize = g.MeasureString(value, this.Font);
                    var thisWidth = GAP + fontSize.Width;
                    g.DrawString(value, this.Font,
                    quote.Value >= 0 ? new SolidBrush(Color.FromArgb(18, 155, 20))
                        : new SolidBrush(Color.FromArgb(255, 30, 0))
                        , new PointF(this.Width - right - thisWidth, (this.Height - fontSize.Height) / 2));

                    right += thisWidth;


                    Font nameFont = new Font(this.Font, FontStyle.Bold);
                    fontSize = g.MeasureString(quote.Symbol, nameFont);
                    thisWidth = GAP + fontSize.Width;
                    g.DrawString(quote.Symbol, nameFont, new SolidBrush(quote.Color), new PointF(this.Width - right - thisWidth, (this.Height - fontSize.Height) / 2));

                    right += thisWidth;

                }
            }
            else
            {

                var quote = this._quotesInfo.FirstOrDefault();

                if (quote != null)
                {
                    string volume = string.Format("Volume: {0:D0}", quote.Volume);
                    SizeF volumeSize = g.MeasureString(volume, this.Font);
                    var VolumeWidth = GAP + volumeSize.Width;


                    string price = string.Format("Price: {0:.##}", quote.Value);
                    SizeF priceSize = g.MeasureString(price, this.Font);
                    var priceWidth = GAP + priceSize.Width;


                    string date = string.Format("{0:MMM dd, yyyy}", quote.Date);
                    SizeF dateSize = g.MeasureString(date, this.Font);
                    var dateWidth = GAP + dateSize.Width;

                    var totalWidth = dateWidth + priceWidth + VolumeWidth;
                    

                    g.DrawString(volume, this.Font,
                        new SolidBrush(Color.FromArgb(136, 136, 136))
                        , new PointF(this.Width - VolumeWidth, (this.Height - volumeSize.Height) / 2));


                    g.DrawString(price, this.Font,
                        new SolidBrush(Color.FromArgb(136, 136, 136))
                        , new PointF(this.Width - VolumeWidth - priceWidth, (this.Height - priceSize.Height) / 2));


                    g.DrawString(date, this.Font,
                        new SolidBrush(Color.FromArgb(136, 136, 136))
                        , new PointF(this.Width - VolumeWidth - priceWidth - dateWidth, (this.Height - dateSize.Height) / 2));
                    
                }
            }



        }


    }


    public enum DisplayMode
    {
        Independent,
        Comparison,
    }
    public class QuoteInfo
    {
        public string Symbol { get; set; }
        public Color Color { get; set; }
        public double Value { get; set; }
        public long Volume { get; set; }
        public DateTime Date { get; set; }
    }
}
