//----------------------------------------------------------------------------
// C1\Win\C1Report\CustomFields\Gradient.cs
//
// Custom C1Report field: Gradient
//
// This class inherits from C1Report.Field and uses a LinearGradient brush
// to draw a gradient background. If the field contains text, that is also
// displayed.
//
// Object Model:
//
// public Color ColorFrom
//	Initial color for the gradient background
//
// public Color ColorTo
//	Final color for the gradient background
//
// public int Angle
//	Angle for the gradient pattern, in degrees
//
// public int BorderRadius
//  Radius for rounded rectangles, in twips
//
// Copyright (C) 2004 - 2005 ComponentOne LLC
//----------------------------------------------------------------------------
// Status   Date        By          Comments
// Created	June 2004	Bernardo	-
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace C1.C1Report.CustomFields
{
    using C1.C1Preview;
	using C1.C1Report;
	//using C1.Win.C1Report.Util;

	/// <summary>
	/// This class inherits from <see cref="Field"/> and uses a LinearGradient brush
	/// to draw a gradient background. If the field contains text, that is also displayed.
	/// </summary>
#if GRAPECITY
    [Description("グラデーション")]
#else
    [Description("Gradient")]
#endif
    public class Gradient : C1.C1Report.Field
    {
        // ** fields
		private Color			_clrFrom, _clrTo;	// gradient colors
		private int				_angle;				// gradient angle
		private SolidBrush		_brBack, _brFore;	// back/fore brushes
		private StringFormat	_fmt;				// to align strings
        private CornerRadius _cornerRadius;

        // ** ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="Gradient"/> class.
        /// </summary>
        public Gradient()
        {
            // intialize instance
			ColorFrom    = Color.Blue;
			ColorTo      = Color.White;
			Angle        = 0;
            PictureAlign = PictureAlignEnum.Stretch;
            CornerRadius = new CornerRadius(0);
        }

        // ** properties
        /// <summary>
        /// Initial color for the gradient background.
        /// </summary>
        [ Category("Gradient"), DefaultValue(typeof(Color), "Blue") ]
        public Color ColorFrom
        {
            get { return _clrFrom; }
            set
            {
                _clrFrom = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Final color for the gradient background.
        /// </summary>
        [ Category("Gradient"), DefaultValue(typeof(Color), "White") ]
        public Color ColorTo
        {
            get { return _clrTo; }
            set
            {
                _clrTo = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Angle for the gradient pattern, in degrees.
        /// </summary>
        [ Category("Gradient"), DefaultValue(0) ]
        public int Angle
        {
            get { return _angle; }
            set
            {
                _angle = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// This property allows you to specify a rounded radius for the field background in twips.
        /// </summary>
        /// <remarks>
        /// The rounded gradients are not exported correctly to pdf (they are rendered 
        /// as regular rectangles). If you specify a BorderRadius, LineWidth, and Color, then
        /// the field will render a rounded border as well. 
        /// The rounded border is exported to pdf correctly.
        /// </remarks>
        [ Category("Border"), DefaultValue(0) ]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete]
        public int BorderRadius // <<B178>>
        {
            get { return _cornerRadius.All; }
            set
            {
                _cornerRadius.All = value;
                OnPropertyChanged();
            }
        }

        [Category("Border")]
        public CornerRadius CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                _cornerRadius = value;

                // prevent base class (Field) from drawing the border
                // if there's a positive radius (we will draw it ourselves)
                if (!_cornerRadius.IsAllCornerZero())
                {
                    BorderStyle = BorderStyleEnum.Transparent;
                }
                OnPropertyChanged();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        internal bool ShouldSerializeCornerRadius()
        {
            return CornerRadius.All != 0;
        }

        // ** overrides
        /// <summary>
        /// Selects the text or image that will be rendered by the field.
        /// </summary>
        /// <param name="value">Field text.</param>
        /// <param name="img">Field image.</param>
        /// <param name="designTime">Whether we in design time or runtime.</param>
        override protected void GetRenderContent(ref string value, ref Image img, bool designTime)
        {
            // create image
            C1Report parentReport = ParentReport;
            using (Bitmap bmp = new Bitmap(1, 1))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //
                PointF dpi = new PointF(g.DpiX, g.DpiY);

                // calculate field size in pixels 
                // (based on field size in twips and screen resolution)
                Rectangle rc = new Rectangle(Point.Empty, GetFieldSizePixels(dpi));

                // create metafile image (this is the return value)
                IntPtr hdc = g.GetHdc();
                // consider the real screen logical dpi (144 in the big fonts mode (150%), and 96 and 120 in 100% and 125% accordingly)
                // the folowing coefficients will != 1 in the big fonts mode only
                float kX = dpi.X / GraphicsUtils.RealScreenDpiX;
                float kY = dpi.Y / GraphicsUtils.RealScreenDpiY;
                // set clipping area with taking account of the coefficients
                img = new Metafile(hdc, new RectangleF(0, 0, rc.Width * kX, rc.Height * kY), MetafileFrameUnit.Pixel, this.ParentReport.EmfType);
                using (Graphics meta = Graphics.FromImage(img))
                {
                    // some multiples of 90 degrees create spurious lines <<B168>>
                    meta.PageUnit = GraphicsUnit.Pixel;
                    int angle = _angle;
                    while (angle < 0) angle += 360;
                    if (angle % 90 == 0) angle++;

                    // draw background
                    using (LinearGradientBrush br = new LinearGradientBrush(rc, _clrFrom, _clrTo, angle))
                    {
                        // fill background as usual
                        if (BackColor != Utils.TransparentColor)
                        {
                            // update brush
                            if (_brBack == null || _brBack.Color != Utils.FromWpfColor(BackColor))
                                _brBack = new SolidBrush(Utils.FromWpfColor(BackColor));
                            meta.FillRectangle(_brBack, rc);
                        }

                        // create pen if necessary
                        Pen pen = null;
                        if (BorderColor != Utils.TransparentColor && BorderStyle == BorderStyleEnum.Transparent && LineWidth > 0)
                        {
                            int lineWidth = Math.Max(1, (int)(LineWidth * dpi.X / 1440f));
                            rc.Inflate(-lineWidth / 2, -lineWidth / 2);
                            //rc.Inflate(-1, -1);
                            pen = new Pen(Utils.FromWpfColor(BorderColor), lineWidth);
                        }

                        // draw the background and border
                        rc.Width--;
                        rc.Height--;

                        // calculate corner radius in pixels
                        var cornerRadiusPixel = new CornerRadius(
                            (int)(_cornerRadius.TopLeftX * dpi.X / 1440f),
                            (int)(_cornerRadius.TopLeftY * dpi.Y / 1440f),
                            (int)(_cornerRadius.TopRightX * dpi.X / 1440f),
                            (int)(_cornerRadius.TopRightY * dpi.Y / 1440f),
                            (int)(_cornerRadius.BottomLeftX * dpi.X / 1440f),
                            (int)(_cornerRadius.BottomLeftY * dpi.Y / 1440f),
                            (int)(_cornerRadius.BottomRightX * dpi.X / 1440f),
                            (int)(_cornerRadius.BottomRightY * dpi.Y / 1440f));

                        RoundRect(meta, br, pen, rc, cornerRadiusPixel);

                        // dispose of pen
                        if (pen != null) pen.Dispose();
                    }

                    // draw string content
                    if (value != null && value.Length > 0)
                    {
                        // update brush
                        if (_brFore == null || _brFore.Color != Utils.FromWpfColor(ForeColor))
                            _brFore = new SolidBrush(Utils.FromWpfColor(ForeColor));

                        // draw string
                        meta.DrawString(value, Font, _brFore, rc, GetStringFormat());
                    }
                }

                img = FixMetafile((Metafile)img, hdc, dpi);

                // done with reference dc
                g.ReleaseHdc(hdc);
            }
        }

        // ** private
        private Size GetFieldSizePixels(PointF dpi)
        {
            Size sz = new Size((int)(Width / 1440f * dpi.X), (int)(Height / 1440f * dpi.Y));

            // can't be empty
            if (sz.Width <= 0) sz.Width = 1;
            if (sz.Height <= 0) sz.Height = 1;

            // return size
            return sz;
        }

        /// <summary>
        /// This method fixes the Windows bug.
        /// Windows processes metafiles created from Screen DC incorrectly when large fonts is used
        /// and new Windows7 scaling mode selected.
        /// </summary>
        /// <param name="metafile"></param>
        /// <returns></returns>
        private Metafile FixMetafile(Metafile m, IntPtr hdc, PointF dpi)
        {
            using (MemoryStream ms2 = new MemoryStream())
            {
                GraphicsUtils.WriteMetafileToStream(m, ms2);
                ms2.Seek(0, SeekOrigin.Begin);
                using (Metafile m2 = (Metafile)Image.FromStream(ms2))
                {
                    if (m.Width != m2.Width || m.Height != m2.Height)
                    {
                        // fix required
                        m.Dispose();
                        float kX = dpi.X / GraphicsUtils.RealScreenDpiX;
                        float kY = dpi.Y / GraphicsUtils.RealScreenDpiY;
                        Size szFixed = new Size(Utils.Round(m2.Width / GraphicsUtils.ScreenDpiX * m2.HorizontalResolution),
                            Utils.Round(m2.Height / GraphicsUtils.ScreenDpiY * m2.VerticalResolution));
                        Metafile m3 = new Metafile(hdc, new RectangleF(0, 0, szFixed.Width * kX, szFixed.Height * kY), MetafileFrameUnit.Pixel, this.ParentReport.EmfType);
                        using (Graphics g3 = Graphics.FromImage(m3))
                        {
                            g3.PageUnit = GraphicsUnit.Pixel;
                            g3.DrawImage(m2, 0, 0, szFixed.Width, szFixed.Height);
                        }
                        MemoryStream ms3 = new MemoryStream();
                        GraphicsUtils.WriteMetafileToStream(m3, ms3);
                        ms3.Seek(0, SeekOrigin.Begin);
                        return (Metafile)Image.FromStream(ms3);
                    }
                    else
                    {
                        return m;
                    }
                }
            }
        }

        /// <summary>
        /// Gets the StringFormat object used to draw the field text.
        /// </summary>
        private StringFormat GetStringFormat()
        {
            // create StringFormat on first use
            if (_fmt == null)
                _fmt = new StringFormat();

            // set horizontal alignment
            switch (Align)
            {
                case FieldAlignEnum.JustBottom:
                case FieldAlignEnum.JustMiddle:
                case FieldAlignEnum.JustTop:
                case FieldAlignEnum.LeftBottom:
                case FieldAlignEnum.LeftMiddle:
                case FieldAlignEnum.LeftTop:
                case FieldAlignEnum.General:
                    _fmt.Alignment = StringAlignment.Near;
                    break;
                case FieldAlignEnum.CenterBottom:
                case FieldAlignEnum.CenterMiddle:
                case FieldAlignEnum.CenterTop:
                    _fmt.Alignment = StringAlignment.Center;
                    break;
                case FieldAlignEnum.RightBottom:
                case FieldAlignEnum.RightMiddle:
                case FieldAlignEnum.RightTop:
                    _fmt.Alignment = StringAlignment.Far;
                    break;
            }

            // set vertical alignment
            switch (Align)
            {
                case FieldAlignEnum.LeftTop:
                case FieldAlignEnum.RightTop:
                case FieldAlignEnum.JustTop:
                case FieldAlignEnum.CenterTop:
                case FieldAlignEnum.General:
                    _fmt.LineAlignment = StringAlignment.Near;
                    break;
                case FieldAlignEnum.CenterBottom:
                case FieldAlignEnum.JustBottom:
                case FieldAlignEnum.LeftBottom:
                case FieldAlignEnum.RightBottom:
                    _fmt.LineAlignment = StringAlignment.Far;
                    break;
                case FieldAlignEnum.CenterMiddle:
                case FieldAlignEnum.JustMiddle:
                case FieldAlignEnum.LeftMiddle:
                case FieldAlignEnum.RightMiddle:
                    _fmt.LineAlignment = StringAlignment.Center;
                    break;
            }

            // done
            return _fmt;
        }
        /// <summary>
        /// Draw rounded rectangle.
        /// </summary>
        public void DrawRoundRect(Graphics g, Pen pen, Rectangle rc, int radiusX, int radiusY)
        {
            RoundRect(g, null, pen, rc, radiusX, radiusY);
        }
        /// <summary>
        /// Fill rounded rectangle.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="brush"></param>
        /// <param name="rc"></param>
        /// <param name="radiusX"></param>
        /// <param name="radiusY"></param>
        public void FillRoundRect(Graphics g, Brush brush, Rectangle rc, int radiusX, int radiusY)
        {
            RoundRect(g, brush, null, rc, radiusX, radiusY);
        }

        /// <summary>
        /// Draw and fill rounded rectangle.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="brush"></param>
        /// <param name="pen"></param>
        /// <param name="rc"></param>
        /// <param name="radiusX"></param>
        /// <param name="radiusY"></param>
        public void RoundRect(Graphics g, Brush brush, Pen pen, Rectangle rc, int radiusX, int radiusY)
        {
            // validate radii
            if (radiusX > rc.Width / 2) radiusX = rc.Width / 2;
            if (radiusY > rc.Height / 2) radiusY = rc.Height / 2;

            CornerRadius cornerRadius = new CornerRadius(0);
            cornerRadius.AllX = radiusX;
            cornerRadius.AllY = radiusY;

            RoundRect(g, brush, pen, rc, cornerRadius);
        }

        private static CornerRadius ValidateCornerRadius(Rectangle rc, CornerRadius cornerRadius)
        {
            var validateResult = cornerRadius;

            if (validateResult.TopLeftX == 0 || validateResult.TopLeftY == 0)
                validateResult.TopLeftX = validateResult.TopLeftY = 0;

            if (validateResult.TopRightX == 0 || validateResult.TopRightY == 0)
                validateResult.TopRightX = validateResult.TopRightY = 0;

            if (validateResult.BottomLeftX == 0 || validateResult.BottomLeftY == 0)
                validateResult.BottomLeftX = validateResult.BottomLeftY = 0;

            if (validateResult.BottomRightX == 0 || validateResult.BottomRightY == 0)
                validateResult.BottomRightX = validateResult.BottomRightY = 0;

            //X should not be greater than width.
            if (validateResult.TopLeftX > rc.Width) validateResult.TopLeftX = rc.Width;
            if (validateResult.TopRightX > rc.Width) validateResult.TopRightX = rc.Width;
            if (validateResult.BottomLeftX > rc.Width) validateResult.BottomLeftX = rc.Width;
            if (validateResult.BottomRightX > rc.Width) validateResult.BottomRightX = rc.Width;

            //Y should not be greater than height.
            if (validateResult.TopLeftY > rc.Height) validateResult.TopLeftY = rc.Height;
            if (validateResult.TopRightY > rc.Height) validateResult.TopRightY = rc.Height;
            if (validateResult.BottomLeftY > rc.Height) validateResult.BottomLeftY = rc.Height;
            if (validateResult.BottomRightY > rc.Height) validateResult.BottomRightY = rc.Height;

            //Sum of x should not be greater than width.
            //Keep TopLeft/BottomRight not changing, and reduce TopRight/BottomLeft.
            if (validateResult.TopLeftX + validateResult.TopRightX > rc.Width)
                validateResult.TopRightX = rc.Width - validateResult.TopLeftX;
            if (validateResult.BottomLeftX + validateResult.BottomRightX > rc.Width)
                validateResult.BottomLeftX = rc.Width - validateResult.BottomRightX;

            //Sum of y should not be greater than height.
            //Keep TopLeft/BottomRight not changing, and reduce TopRight/BottomLeft.
            if (validateResult.TopLeftY + validateResult.BottomLeftY > rc.Height)
                validateResult.BottomLeftY = rc.Height - validateResult.TopLeftY;
            if (validateResult.TopRightY + validateResult.BottomRightY > rc.Height)
                validateResult.TopRightY = rc.Height - validateResult.BottomRightY;

            return validateResult;
        }

        public void RoundRect(Graphics g, Brush brush, Pen pen, Rectangle rc, CornerRadius cornerRadius)
        {
            // validate rect
            if (rc.Width < 0 || rc.Height < 0)
                return;

            cornerRadius = ValidateCornerRadius(rc, cornerRadius);

            if (!cornerRadius.IsAllCornerZero())
            {
                try
                {
                    using (GraphicsPath gp = new GraphicsPath())
                    {
                        // build graphics path
                        gp.AddLine(rc.X + cornerRadius.TopLeftX, rc.Y, rc.Right - cornerRadius.TopRightX, rc.Y);//top line
                        if (cornerRadius.TopRightX != 0 && cornerRadius.TopRightY != 0)
                            gp.AddArc(rc.Right - 2 * cornerRadius.TopRightX, rc.Y,
                                2 * cornerRadius.TopRightX, 2 * cornerRadius.TopRightY, 270, 90);//top right corner

                        gp.AddLine(rc.Right, rc.Y + cornerRadius.TopRightY, rc.Right, rc.Bottom - cornerRadius.BottomRightY);//right line
                        if (cornerRadius.BottomRightX != 0 && cornerRadius.BottomRightY != 0)
                            gp.AddArc(rc.Right - 2 * cornerRadius.BottomRightX, rc.Bottom - 2 * cornerRadius.BottomRightY,
                                2 * cornerRadius.BottomRightX, 2 * cornerRadius.BottomRightY, 0, 90);//bottom right corner

                        gp.AddLine(rc.Right - cornerRadius.BottomRightX, rc.Bottom, rc.X + cornerRadius.BottomLeftX, rc.Bottom);//bottom line
                        if (cornerRadius.BottomLeftX != 0 && cornerRadius.BottomLeftY != 0)
                            gp.AddArc(rc.X, rc.Bottom - 2 * cornerRadius.BottomLeftY,
                                2 * cornerRadius.BottomLeftX, 2 * cornerRadius.BottomLeftY, 90, 90);//bottom left corner

                        gp.AddLine(rc.X, rc.Bottom - cornerRadius.BottomLeftY, rc.X, rc.Y + cornerRadius.TopLeftY);//left line
                        if (cornerRadius.TopLeftX != 0 && cornerRadius.TopLeftY != 0)
                            gp.AddArc(rc.X, rc.Y, 2 * cornerRadius.TopLeftX, 2 * cornerRadius.TopLeftY, 180, 90);//top left corner

                        gp.CloseFigure();

                        // fill
                        if (brush != null)
                            g.FillPath(brush, gp);

                        // and/or draw
                        if (pen != null)
                            g.DrawPath(pen, gp);
                    }

                    // round rect drawn successfully
                    return;
                }
                catch {}
            }

            // rectangle too small for corner size, draw straight rect
            if (brush != null)
                g.FillRectangle(brush, rc);
            if (pen != null)
                g.DrawRectangle(pen, rc);
        }
    }

    public class CornerRadiusConverter : ExpandableObjectConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            else
                return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            string strCornerRadius = value as string;
            if (strCornerRadius == null)
                return base.ConvertFrom(context, culture, value);

            strCornerRadius = strCornerRadius.Trim();
            if (strCornerRadius.Length == 0)
                return (object)null;

            if (culture == null)
                culture = System.Globalization.CultureInfo.CurrentCulture;

            strCornerRadius = strCornerRadius.TrimStart('{').TrimEnd('}');
            string[] strArray = strCornerRadius.Split(',');
            int[] numArray = new int[strArray.Length];
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(int));
            for (int index = 0; index < numArray.Length; ++index)
            {
                string str = strArray[index].Trim();
                string[] strSplitArray = str.Split('=');
                if (strSplitArray.Length == 2)
                {
                    str = strSplitArray[1];
                }
                numArray[index] = (int)converter.ConvertFromString(context, culture, str);
            }

            if (numArray.Length == 11)
                return (object)new CornerRadius(
                    numArray[3], numArray[4], numArray[5], numArray[6],
                    numArray[7], numArray[8], numArray[9], numArray[10]);

            throw new ArgumentException();
        }
    }

    [Serializable]
    [TypeConverter(typeof(CornerRadiusConverter))]
    public struct CornerRadius
    {
        private int _topLeftX;
        private int _topLeftY;
        private int _topRightX;
        private int _topRightY;
        private int _bottomLeftX;
        private int _bottomLeftY;
        private int _bottomRightX;
        private int _bottomRightY;

        public CornerRadius(int all)
        {
            _topLeftX = _topLeftY = _topRightX = _topRightY = _bottomLeftX = _bottomLeftY = _bottomRightX = _bottomRightY = all;
        }

        public CornerRadius(
            int topLeftX,
            int topLeftY,
            int topRightX,
            int topRightY,
            int bottomLeftX,
            int bottomLeftY,
            int bottomRightX,
            int bottomRightY)
        {
            _topLeftX = topLeftX;
            _topLeftY = topLeftY;
            _topRightX = topRightX;
            _topRightY = topRightY;
            _bottomLeftX = bottomLeftX;
            _bottomLeftY = bottomLeftY;
            _bottomRightX = bottomRightX;
            _bottomRightY = bottomRightY;
        }

        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]
        [DefaultValue(0)]
        public int TopLeftX
        {
            get { return _topLeftX; }
            set { _topLeftX = value < 0 ? 0 : value; }
        }

        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]
        [DefaultValue(0)]
        public int TopLeftY
        {
            get { return _topLeftY; }
            set { _topLeftY = value < 0 ? 0 : value; }
        }

        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]
        [DefaultValue(0)]
        public int TopRightX
        {
            get { return _topRightX; }
            set { _topRightX = value < 0 ? 0 : value; }
        }

        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]
        [DefaultValue(0)]
        public int TopRightY
        {
            get { return _topRightY; }
            set { _topRightY = value < 0 ? 0 : value; }
        }

        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]
        [DefaultValue(0)]
        public int BottomRightX 
        {
            get { return _bottomRightX; }
            set { _bottomRightX = value < 0 ? 0 : value; }
        }

        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]
        [DefaultValue(0)]
        public int BottomRightY
        {
            get { return _bottomRightY; }
            set { _bottomRightY = value < 0 ? 0 : value; }
        }

        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]
        [DefaultValue(0)]
        public int BottomLeftX
        {
            get { return _bottomLeftX; }
            set { _bottomLeftX = value < 0 ? 0 : value; }
        }

        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]
        [DefaultValue(0)]
        public int BottomLeftY 
        {
            get { return _bottomLeftY; }
            set { _bottomLeftY = value < 0 ? 0 : value; }
        }

        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]
        [DefaultValue(0)]
        public int All 
        {
            get 
            {
                return AllX == AllY ? AllX : -1;
            }
            set
            {
                SetAllX(value);
                SetAllY(value);
            }
        }

        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]
        [DefaultValue(0)]
        public int AllX
        { 
            get 
            {
                return (TopLeftX == TopRightX
                    && TopLeftX == BottomLeftX
                    && TopLeftX == BottomRightX) ? TopLeftX : -1;
            }
            set 
            {
                SetAllX(value);
            }
        }

        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]
        [DefaultValue(0)]
        public int AllY
        {
            get
            {
                return (TopLeftY == TopRightY
                    && TopLeftY == BottomLeftY
                    && TopLeftY == BottomRightY) ? TopLeftY : -1;
            }
            set 
            {
                SetAllY(value);
            }
        }

        private void SetAllX(int x)
        {
            TopLeftX = x;
            TopRightX = x;
            BottomLeftX = x;
            BottomRightX = x;
        }

        private void SetAllY(int y)
        {
            TopLeftY = y;
            TopRightY = y;
            BottomLeftY = y;
            BottomRightY = y;
        }

        internal bool IsAllCornerZero()
        {
            return (TopLeftX == 0 || TopLeftY == 0) &&
                (TopRightX == 0 || TopRightY == 0) &&
                (BottomLeftX == 0 && BottomLeftY == 0) &&
                (BottomRightX == 0 && BottomRightY == 0);
        }

        public override string ToString()
        {
            return "{ALL=" + All.ToString() +
                ", AllX=" + AllX.ToString() +
                ", AllY=" + AllY.ToString() +
                ", TopLeftX=" + TopLeftX.ToString() +
                ", TopLeftY=" + TopLeftY.ToString() +
                ", TopRightX=" + TopRightX.ToString() +
                ", TopRightY=" + TopRightY.ToString() +
                ", BottomLeftX=" + BottomLeftX.ToString() +
                ", BottomLeftY=" + BottomLeftY.ToString() +
                ", BottomRightX=" + BottomRightX.ToString() +
                ", BottomRightY=" + BottomRightY.ToString() + "}";
        }
    }
}
