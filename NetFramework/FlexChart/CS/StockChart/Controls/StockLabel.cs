using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockChart.Controls
{
    class StockLabel: System.Windows.Forms.Label
    {
        public StockLabel()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);
        }

        private string _stockName;
        public string StockName
        {
            get
            {
                return _stockName;
            }
            set
            {
                _stockName = value;
                this.Invalidate();
            }
        }

        private Font _nameFont;
        public Font NameFont
        {
            get { return _nameFont == null ? this.Font : _nameFont; }
            set { _nameFont = value; ; this.Invalidate(); }
        }

        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                this.Invalidate();
            }
        }

        private Font _priceFont;
        public Font PriceFont
        {
            get { return _priceFont == null ? this.Font : _priceFont; }
            set { _priceFont = value; ; this.Invalidate(); }
        }

        private double _difference;
        public double Difference
        {
            get
            {
                return _difference;
            }
            set
            {
                _difference = value;
                this.Invalidate();
            }
        }

        private Font _diffFont;
        public Font DiffFont
        {
            get { return _diffFont == null ? this.Font : _diffFont; }
            set { _diffFont = value; this.Invalidate(); }
        }



        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);


            Graphics g = pe.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;

            float left = 0;

            SizeF fontSize = g.MeasureString(this.StockName, this.NameFont);
            g.DrawString(this.StockName, this.NameFont, new SolidBrush(Color.FromArgb(255, 165, 0)), new PointF(left, (this.Height - fontSize.Height) / 2));

            left += fontSize.Width;
            left += 5;


            var price = this.Price.ToString("0.00");
            fontSize = g.MeasureString(price, this.PriceFont);
            g.DrawString(price, this.PriceFont, new SolidBrush(Color.FromArgb(136, 136, 136)), new PointF(left, (this.Height - fontSize.Height) / 2));

            left += fontSize.Width;
            left += 5;


            var diff = string.Format((this.Difference >= 0 ? "+{0:0.00}" : "{0:0.00}"), this.Difference);
            if (this.Difference == 0)
            {
                diff = "0.00";
            }
            fontSize = g.MeasureString(diff, this.DiffFont);
            g.DrawString(diff, this.DiffFont,
                this.Difference >= 0 ? new SolidBrush(Color.FromArgb(18, 155, 20))
                : new SolidBrush(Color.FromArgb(255, 30, 0)), new PointF(left, (this.Height - fontSize.Height) / 2));

            left += fontSize.Width;
            left += 5; 


        }


    }
}
