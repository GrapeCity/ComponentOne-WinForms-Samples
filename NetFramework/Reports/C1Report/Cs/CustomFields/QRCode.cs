//----------------------------------------------------------------------------
// QRCode.cs
//
// Custom C1Report field: QRCode
//
// Copyright (C) ComponentOne LLC
//----------------------------------------------------------------------------

#if !(CLR40 || CLR45)
#error This code requires .NET 4.0 or newer.
#endif

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;
using C1.C1Preview;
using C1.BarCode;
using System.Collections.Generic;
using NSD = C1.Win.Interop;

namespace C1.C1Report.CustomFields
{
    /// <summary>
    /// Inherits from <see cref="Field"/> and uses an instance of
    /// <b>C1.Win.C1BarCode.C1QRCode</b> component to draw QR (Quick Response) 2D barcode.
    /// </summary>
#if GRAPECITY
    [Description("QRコード")]
#else
    [Description("QRCode")]
#endif
    public class QRCode : C1.C1Report.Field
    {
        #region nested types
        /// <summary>
        /// Specifies the type of encoding to use (more flexible encodings consume more space).
        /// <para>For more details see <b>C1.Win.C1BarCode.Encoding</b>.</para>
        /// </summary>
        public enum EncodingEnum
        {
            /// <summary>
            /// Select encoding automatically based on the content.
            /// </summary>
            Automatic,
            /// <summary>
            /// Encode up to 395 alpha-numeric values. Alpha-numeric values include digits from 0 to 9,
            /// uppercase letters from A to Z, space, and the following additional characters:
            /// dollar, percentage, asterisk, plus, minus, slash, and colon ([0-9][A-Z][$%*+-./:]).
            /// </summary>
            AlphaNumeric,
            /// <summary>
            /// Encode up to 271 bytes.
            /// </summary>
            Byte,
            /// <summary>
            /// Encode up to 652 numeric values.
            /// </summary>
            Numeric,
        }

        /// <summary>
        /// Specifies the error-correction level (higher levels consume more space).
        /// <para>For more details see <b>C1.Win.C1BarCode.ErrorCorrectionLevel</b>.</para>
        /// </summary>
        public enum ErrorCorrectionLevelEnum
        {
            /// <summary>
            /// Able to correct up to 7% damage.
            /// </summary>
            L,
            /// <summary>
            /// Able to correct up to 15% damage.
            /// </summary>
            M,
            /// <summary>
            /// Able to correct up to 25% damage.
            /// </summary>
            Q,
            /// <summary>
            /// Able to correct up to 30% damage.
            /// </summary>
            H,
        }
        #endregion
        #region private data
        private int _codeVersion;
        private ErrorCorrectionLevelEnum _errorCorrectionLevel;
        private int _symbolSize;
        private BarEngine _barEngine;
        private Image _image;
        private string _text = string.Empty;
        private bool _dirty;

        private static Dictionary<ErrorCorrectionLevelEnum, int> s_ErrorLevelMapping;
        private static Dictionary<ErrorCorrectionLevelEnum, int> ErrorLevelMapping
        {
            get
            {
                if (s_ErrorLevelMapping != null)
                    return s_ErrorLevelMapping;

                s_ErrorLevelMapping = new Dictionary<ErrorCorrectionLevelEnum, int>();
                s_ErrorLevelMapping.Add(ErrorCorrectionLevelEnum.L, 0);
                s_ErrorLevelMapping.Add(ErrorCorrectionLevelEnum.M, 1);
                s_ErrorLevelMapping.Add(ErrorCorrectionLevelEnum.Q, 2);
                s_ErrorLevelMapping.Add(ErrorCorrectionLevelEnum.H, 3);

                return s_ErrorLevelMapping;
            }
        }
        #endregion

        #region core functionality
        /// <summary>
        /// Initializes a new instance of the <b>QRCode</b> class.
        /// </summary>
        public QRCode()
        {
            //
            PictureAlign = C1.C1Report.PictureAlignEnum.CenterMiddle;
            SymbolSize = 3;
        }

        /// <summary>
        /// Renders QRCode content using the <b>C1QRCode</b> control.
        /// </summary>
        /// <param name="value">IN/OUT: Field text.</param>
        /// <param name="img">IN/OUT: Field image.</param>
        /// <param name="designTime">Design or run time.</param>
        override protected void GetRenderContent(ref string value, ref Image img, bool designTime)
        {
            if (_text != value)
            {
                SetDirty();
                _text = value;
            }
#if false
            // at design time, we draw on screen, so resolution needs to be adjusted:
            // Looks like AdjustImageSize(...) method is not needed more all
            // additional work done in the C1ReportDesigner code
            if (designTime)
                img = AdjustImageSize(Image);
            else
                img = Image;
#endif
            img = Image;
        }

        private void UpdateImage()
        {
            _image = null;

            _barEngine = _barEngine ?? new BarEngine();

            // setup options affecting size of barcode
            _barEngine.IsAutoModuleSize = false;
            _barEngine.FixedModuleSize = (float)SymbolSize;

            // common options
            _barEngine.CodeType = BarStyle.cbsQRCode;
            _barEngine.CaptionPos = BarCodeCaptionPosition.None;

            // QRCode
            _barEngine.QRCodeModel = 2;//Model2
            _barEngine.QRCodeMask = -1;//-1 means auto
            _barEngine.QRVersion = CodeVersion == 0 ? -1 : CodeVersion;//-1 means auto
            _barEngine.QRConnection = false;
            _barEngine.QRConnectionNo = 0;
            _barEngine.QRErrorLevel = ErrorLevelMapping[ErrorCorrectionLevel];
            _barEngine.QRCodeEncoding = System.Text.Encoding.UTF8;// old Custom QRCode use UTF8 to encode text.

            using (GraphicsHolder gh = GraphicsHolder.FromScreen())
            {
                NSD.Size size;
                using (DrawDevice dd = new DrawDevice(this, gh.Graphics))
                    size = _barEngine.CalculateSize2(dd, Text);
                bool isBarcodeEmpty = size.Width == 0 || size.Height == 0;
                Rectangle rcImage = isBarcodeEmpty ? new Rectangle(0, 0, 1, 1)
                    : new Rectangle(0, 0, (int)(size.Width + 0.5), (int)(size.Height + 0.5));

                IntPtr dc = gh.Graphics.GetHdc();
                _image = new Metafile(dc, rcImage, MetafileFrameUnit.Pixel);
                gh.Graphics.ReleaseHdc(dc);
                using (var gDraw = Graphics.FromImage(_image))
                using (var bBack = new SolidBrush(Color.Transparent))
                {
                    gDraw.FillRectangle(bBack, rcImage);
                    if (!isBarcodeEmpty)
                    {
                        using (DrawDevice dd  = new DrawDevice(this, gDraw))
                        {
                            _barEngine.DrawEx(dd, rcImage, _text);
                        }
                    }
                }
            }
        }
        #endregion

        private Image Image
        {
            get 
            {
                if (_dirty)
                {
                    UpdateImage();
                    _dirty = false;
                }

                return _image;
            }
        }

        #region Public properties
        /// <summary>
        /// Gets or sets the version of QR code to generate.
        /// <para>For more details see <b>C1.Win.C1BarCode.C1QRCode</b> documentation.</para>
        /// </summary>
        [Category("QRCode")]
        [DefaultValue(0)]
        public int CodeVersion
        {
            get { return _codeVersion; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException();
                }

                if (value != _codeVersion)
                {
                    _codeVersion = value;
                    SetDirty();
                }
            }
        }

        /// <summary>
        /// Gets or sets the encoding used to translate the content in the field's text
        /// into binary values to be encoded in the QR code.
        /// <para>For more details see <b>C1.Win.C1BarCode.C1QRCode</b> documentation.</para>
        /// </summary>
        [Category("QRCode")]
        [DefaultValue(EncodingEnum.Automatic)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        [Obsolete]
        public EncodingEnum Encoding { get; set; }

        /// <summary>
        /// Gets the exception that prevented the field's text from being encoded.
        /// <para>For more details see <b>C1.Win.C1BarCode.C1QRCode</b> documentation.</para>
        /// </summary>
        [Category("QRCode")]
        [Browsable(false)]
        [Obsolete]
        public Exception EncodingException
        {
            get { return null; }
        }

        /// <summary>
        /// Gets or sets the error correction level used to create the QR code.
        /// <para>For more details see <b>C1.Win.C1BarCode.C1QRCode</b> documentation.</para>
        /// </summary>
        [Category("QRCode")]
        [DefaultValue(ErrorCorrectionLevelEnum.L)]
        public ErrorCorrectionLevelEnum ErrorCorrectionLevel
        {
            get
            {
                return _errorCorrectionLevel;
            }
            set
            {
                if (value != _errorCorrectionLevel)
                {
                    _errorCorrectionLevel = value;
                    SetDirty();
                }
            }
        }

        /// <summary>
        /// Gets or sets the size, in pixels, of the symbols used to build the QR image. Must be between 2-10.
        /// <para>For more details see <b>C1.Win.C1BarCode.C1QRCode</b> documentation.</para>
        /// </summary>
        [Category("QRCode")]
        [DefaultValue(3)]
        public int SymbolSize
        {
            get { return _symbolSize; }
            set
            {
                if (value != _symbolSize)
                {
                    _symbolSize = value;
                    SetDirty();
                }
            }
        }
        #endregion

        #region private methods
        private void SetDirty()
        {
            _dirty = true;
            OnPropertyChanged();
        }

#if false
        /// <summary>
        /// Adjusts image size to account for difference between logical 
        /// and physical screen resolutions.
        /// </summary>
        private Image AdjustImageSize(Image img)
        {
            using (Bitmap bmp = new Bitmap(1, 1))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                IntPtr hdc = g.GetHdc();
                try
                {
                    RectangleF rc = new RectangleF(0, 0,
                        img.Width * bmp.HorizontalResolution / img.HorizontalResolution,
                        img.Height * bmp.VerticalResolution / img.VerticalResolution);
                    Image imgFixed = new Metafile(hdc, rc, MetafileFrameUnit.Pixel);
                    using (Graphics meta = Graphics.FromImage(imgFixed))
                        meta.DrawImage(img, rc);

                    return imgFixed;
                }
                finally
                {
                    g.ReleaseHdc(hdc);
                }
            }
        }
#endif
        #endregion

        private class DrawDevice : IDrawingDevice, IDisposable
        {
            private QRCode m_Owner;
            private Brush _foreBrush;
            private Graphics _graphics;

            #region Constructors
            public DrawDevice(QRCode owner,Graphics g)
            {
                m_Owner = owner;
                _graphics = g;
#if WPF
                _foreBrush = new SolidBrush(Utils.FromWpfColor(m_Owner.ForeColor));
#else
                _foreBrush = new SolidBrush(m_Owner.ForeColor);
#endif
            }
            #endregion

            #region Public
            public NSD.Size MeasureString(string text)
            {
                return NSD.Size.Empty;
            }

            public void FillRectangle(NSD.Rect bounds)
            {
                _graphics.FillRectangle(_foreBrush,
                    (float)bounds.X,
                    (float)bounds.Y,
                    (float)bounds.Width,
                    (float)bounds.Height);
            }

            public void DrawRectangle(NSD.Rect bounds, int strokeThickness, Color stroke)
            {
                // looks like this method is unusable
                throw new InvalidOperationException("Should never be here");
            }

            public void DrawString(string text, NSD.Point point)
            {
                //do nothing, QRCode Custom field does not draw string.
            }

            public void FillPolygon(NSD.Point[] bounds)
            {
                //do nothing, QRCode Custom field does not draw polygons.
            }

            public void DrawEllipse(NSD.Point center, double rx, double ry, double width)
            {
                //do nothing, QRCode Custom field does not draw ellipses.
            }

            #endregion

            public void Dispose()
            {
                if (_foreBrush != null)
                {
                    _foreBrush.Dispose();
                    _foreBrush = null;
                }
            }
        }
    }
}
