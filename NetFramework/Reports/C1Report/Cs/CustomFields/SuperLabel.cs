//----------------------------------------------------------------------------
// SuperLabel.cs
//
// Custom C1Report field: SuperLabel
//
// Copyright (C) ComponentOne LLC
//----------------------------------------------------------------------------

#if !(CLR40 || CLR45)
#error This code requires .NET 4.0 or newer.
#endif
#if WPF
  #define DYNAMIC_ASMS // undefine this and add a reference to C1.Win.C1SuperTooltip.4 assembly to use static reference
#endif

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.IO;

using C1.C1Preview;

namespace C1.C1Report.CustomFields
{
    /// <summary>
    /// Inherits from <see cref="Field"/> and uses an instance of
    /// <b>C1.Win.C1SuperTooltip.C1SuperLabel</b> component to draw HTML content.
    /// </summary>
#if GRAPECITY
    [Description("スーパーラベル")]
#else
    [Description("SuperLabel")]
#endif
    public class SuperLabel : C1.C1Report.Field
    {
#if DYNAMIC_ASMS
        private dynamic _slbl = null;
#else
        private C1.Win.C1SuperTooltip.C1SuperLabel _slbl = null;
#endif

        /// <summary>
        /// Initializes a new instance of the <see cref="SuperLabel"/> class.
        /// </summary>
        public SuperLabel()
        {
#if DYNAMIC_ASMS
            _slbl = DynLoader.CreateC1SuperLabel();
#else
            _slbl = new C1.Win.C1SuperTooltip.C1SuperLabel();
#endif
            //
            PictureAlign = PictureAlignEnum.Clip;
        }

        /// <summary>
        /// Renders HTML content using the <b>C1SuperLabel</b> component.
        /// </summary>
        /// <param name="value">Field text.</param>
        /// <param name="img">Field image.</param>
        /// <param name="designTime">Whether we in design time or runtime.</param>
        override protected void GetRenderContent(ref string value, ref Image img, bool designTime)
        {
            // create image
            using (Bitmap bmp = new Bitmap(1, 1))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // calculate field size in pixels 
                // (based on field size in twips and screen resolution)
                PointF dpi = new PointF(g.DpiX, g.DpiY);
                Size size = GetFieldSizePixels(dpi);
                Rectangle rc = new Rectangle(Point.Empty, size);

                _slbl.Text = value; // show bound value instead of text (this.Text)
                _slbl.Font = this.Font;
                _slbl.BackColor = Utils.FromWpfColor(this.BackColor);
                _slbl.ForeColor = Utils.FromWpfColor(this.ForeColor);
                _slbl.Width = rc.Width;
                // handle CanGrow/CanShrink (TFS~~18920).
                if (!designTime && (CanGrow || CanShrink))
                {
                    var h = _slbl.Measure(rc.Width).Height;
                    if ((CanGrow && h > rc.Height) || (CanShrink && h < rc.Height))
                        _slbl.Height = rc.Height = h;
                    else
                        _slbl.Height = rc.Height;
                }
                else
                    _slbl.Height = rc.Height;

                // create metafile image (this is the return value)
                IntPtr hdc = g.GetHdc();
                try
                {
                    // consider the real screen logical dpi (144 in the big fonts mode (150%), and 96 and 120 in 100% and 125% accordingly)
                    // the folowing coefficients will != 1 in the big fonts mode only
                    float kX = dpi.X / GraphicsUtils.RealScreenDpiX;
                    float kY = dpi.Y / GraphicsUtils.RealScreenDpiY;
                    // set clipping area with taking account of the coefficients
                    Metafile m = new Metafile(hdc, new RectangleF(0, 0, rc.Width * kX, rc.Height * kY), MetafileFrameUnit.Pixel, this.ParentReport.EmfType);
                    using (Graphics meta = Graphics.FromImage(m))
                    {
                        meta.PageUnit = GraphicsUnit.Pixel;
                        _slbl.DrawToGraphics(meta, rc);
                    }
                    img = FixMetafile(m, hdc, dpi);
                }
                finally
                {
                    // done with reference dc
                    g.ReleaseHdc(hdc);
                }
            }
        }

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
        /// Windows processes metafiles incorrectly when large fonts is used
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
                            g3.DrawImage(m2, 0, 0, szFixed.Width, szFixed.Height);
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
    }
}
