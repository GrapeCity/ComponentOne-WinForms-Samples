using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

using System.Runtime.InteropServices;
using System.Security.Permissions;

using D2D = C1.Util.DX.Direct2D;
using D3D = C1.Util.DX.Direct3D11;
using DW = C1.Util.DX.DirectWrite;
using DXGI = C1.Util.DX.DXGI;
using WIC = C1.Util.DX.WIC;
using STG = C1.Util.DX.Storage;
using C1.Util.DX;

using C1.Win.Bitmap;

namespace BitmapSamples
{
    public partial class FaceWarp : UserControl
    {
        //----------------------------------------------------------------------
        #region ** fields and constants

        const int
            TopMargin = 37,
            BottomMargin = 3,
            SideMargin = 3;

        float _scaleFactor = 1f;
        float _dpiX, _dpiY;

        C1Bitmap _bitmap;
        C1Bitmap _savedCopy;
        RectF _targetRect;
        Point2F _warpStart;
        Point2F _warpEnd;
        bool _drawLine;
        bool _needUpdateIM;
        bool _applyEffect;
        bool _initialized;

        // device independent resources

        D2D.Factory1 _d2dFactory;
        D2D.StrokeStyle _lineStrokeStyle;
        WIC.ImagingFactory2 _wicFactory;

        // device resources

        D2D.Brush _lineBrush;
        D2D.DeviceContext _d2dContext;
        D2D.Device _d2dDevice;
        D2D.Bitmap1 _targetBmp;
        D2D.Bitmap1 _imBmp;

        D2D.Effects.GaussianBlur _blur;
        WarpEffect _warp;

        #endregion

        //----------------------------------------------------------------------
        #region ** ctor/Dispose

        public FaceWarp()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);

            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_initialized)
                {
                    _initialized = false;
                    ClearSavedCopy();
                    _bitmap.Dispose();
                    DiscardDeviceResources();
                    DiscardDeviceIndependentResources();
                }
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** event handlers

        void FaceWarp_Load(object sender, EventArgs e)
        {
            if (!_initialized)
            {
                if (CreateDeviceIndependentResources())
                {
                    _bitmap = new C1Bitmap(_wicFactory);
                    _initialized = true;
                    LoadDefaultImage();
                }
                else
                {
                    btnLoad.Enabled = false;
                    btnExport.Enabled = false;
                    btnRestart.Enabled = false;
                }
            }
        }

        void btnLoad_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.ico;*.bmp;*.gif;*.png;*.jpg;*.jpeg;*.jxr;*.tif;*.tiff";
            ofd.Title = "Select the Image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _bitmap.Load(ofd.FileName, new FormatConverter(PixelFormat.Format32bppPBGRA));
                    PrepareForNewImage();
                }
                catch (Exception ex)
                {
                    LoadDefaultImage();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Png Files (*.png)|*.png";
            sfd.CheckPathExists = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _bitmap.SaveAsPng(sfd.FileName, null);
            }
        }

        void btnRestart_Click(object sender, EventArgs e)
        {
            UndoEffect();
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** overridden methods

        protected override void OnResize(EventArgs e)
        {
            if (_initialized)
            {
                DXUtil.Dispose(ref _targetBmp);
                if (_bitmap != null && _bitmap.HasImage)
                {
                    UpdateTargetRect();
                }
            }
            base.OnResize(e);
        }

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            _scaleFactor = (factor.Width + factor.Height) * 0.5f;
            base.ScaleControl(factor, specified);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _initialized)
            {
                UpdateLine(e.X, e.Y, false);
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _initialized)
            {
                UpdateLine(e.X, e.Y, true);
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _drawLine)
            {
                _drawLine = false;
                _needUpdateIM = true;
                _applyEffect = true;
                Invalidate(false);
            }
            base.OnMouseUp(e);
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Win32.WM_ERASEBKGND:
                    m.Result = new IntPtr(1);
                    return;
            }
            base.WndProc(ref m);
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** device independent resources

        bool CreateDeviceIndependentResources()
        {
            _d2dFactory = D2D.Factory1.Create(D2D.FactoryType.SingleThreaded);
            if (!_d2dFactory.IsSupported)
            {
                return false;
            }
            _d2dFactory.GetDesktopDpi(out _dpiX, out _dpiY);
            var ssp = new D2D.StrokeStyleProperties();
            ssp.StartCap = D2D.CapStyle.Round;
            ssp.EndCap = D2D.CapStyle.Triangle;
            _lineStrokeStyle = D2D.StrokeStyle.Create(_d2dFactory, ref ssp);
            _wicFactory = WIC.ImagingFactory2.Create();
            return true;
        }

        void DiscardDeviceIndependentResources()
        {
            _d2dFactory.Dispose();
            _lineStrokeStyle.Dispose();
            _wicFactory.Dispose();
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** device resources

        void CreateDeviceResources()
        {
            D3D.FeatureLevel actualLevel;
            D3D.DeviceContext d3dContext = null;
            var d3dDevice = new D3D.Device(IntPtr.Zero);
            var result = HResult.Ok;

            for (int i = 0; i <= 1; i++)
            {
                // use WARP if hardware is not available
                var dt = i == 0 ? D3D.DriverType.Hardware : D3D.DriverType.Warp;
                result = D3D.D3D11.CreateDevice(null, dt, IntPtr.Zero, D3D.DeviceCreationFlags.BgraSupport | D3D.DeviceCreationFlags.SingleThreaded,
                    null, 0, D3D.D3D11.SdkVersion, d3dDevice, out actualLevel, out d3dContext);
                if (result.Code != unchecked((int)0x887A0004)) // DXGI_ERROR_UNSUPPORTED
                {
                    break;
                }
            }
            result.CheckError();
            d3dContext.Dispose();

            var dxgiDevice = d3dDevice.QueryInterface<DXGI.Device>();
            d3dDevice.Dispose();

            _d2dDevice = D2D.Device.Create(_d2dFactory, dxgiDevice);
            dxgiDevice.Dispose();

            _d2dContext = D2D.DeviceContext.Create(_d2dDevice, D2D.DeviceContextOptions.None);
            _d2dContext.SetUnitMode(D2D.UnitMode.Pixels);

            _lineBrush = D2D.SolidColorBrush.Create(_d2dContext, ColorF.Blue);

            var sourceEffect = D2D.Effect.RegisterAndCreateCustom<WarpEffect>(_d2dFactory, _d2dContext);
            _warp = (WarpEffect)sourceEffect.CustomEffect;
            _warp.Effect = sourceEffect;

            _blur = D2D.Effects.GaussianBlur.Create(_d2dContext);
            _blur.StandardDeviation = 2f;
        }

        void DiscardDeviceResources()
        {
            if (_d2dContext != null)
            {
                DXUtil.Dispose(ref _blur);
                DXUtil.Dispose(ref _warp);
                DXUtil.Dispose(ref _imBmp);
                DXUtil.Dispose(ref _targetBmp);
                _d2dDevice.Dispose();
                _lineBrush.Dispose();
                _d2dContext.Dispose();
                _d2dContext = null;
            }
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** drawing logic

        /// <summary>
        /// Paints the control.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (_initialized)
            {
                IntPtr hdc = e.Graphics.GetHdc();
                try
                {
                    Render(hdc);
                }
                finally
                {
                    e.Graphics.ReleaseHdc();
                }
            }
            else
            {
                e.Graphics.Clear(Color.Firebrick);
                e.Graphics.DrawString("This sample requires Windows 7 or later operating system.", this.Font, Brushes.Azure,
                    new PointF(_scaleFactor * 16, _scaleFactor * 40));
            }
            base.OnPaint(e);
        }

        void Render(IntPtr hdc)
        {
            #region prepare device resources

            var rt = _d2dContext;
            if (rt == null)
            {
                CreateDeviceResources();
                rt = _d2dContext;
            }

            #endregion

            #region draw to the intermediate bitmap (of the original bitmap size)

            if (_imBmp == null && _bitmap.HasImage)
            {
                var bmProps = new D2D.BitmapProperties1(
                    new D2D.PixelFormat(DXGI.Format.B8G8R8A8_UNorm, D2D.AlphaMode.Premultiplied),
                    (float)_bitmap.DpiX, (float)_bitmap.DpiY, D2D.BitmapOptions.Target);
                _imBmp = D2D.Bitmap1.Create(rt, new Size2L(_bitmap.PixelWidth, _bitmap.PixelHeight), bmProps);
                _needUpdateIM = true;
            }
            if (_needUpdateIM && _imBmp != null)
            {
                _needUpdateIM = false;

                rt.SetTarget(_imBmp);
                rt.BeginDraw();

                rt.Clear(null);

                var buffer = _bitmap.ToD2DBitmap1(rt, D2D.BitmapOptions.None);
                if (!_applyEffect)
                    rt.DrawImage(buffer);
                else
                {
                    _warp.SetNormPositions(_warpEnd, _warpStart);
                    _warp.Effect.SetInput(0, buffer);

                    rt.DrawImage(_warp.Effect, Point2F.Empty);

                    //_blur.SetInputEffect(0, _warp.Effect);
                    //rt.DrawImage(_blur, Point2F.Empty);
                }
                buffer.Dispose();

                if (!rt.EndDraw(true))
                {
                    DiscardDeviceResources();
                    return;
                }
                rt.SetTarget(null);

                if (_applyEffect)
                {
                    _bitmap.ImportAsFragment(_imBmp, rt, new RectL(_bitmap.PixelWidth, _bitmap.PixelHeight), 0, 0);
                    _applyEffect = false;
                }
            }

            #endregion

            #region draw the result to the target bitmap (of the target control size)

            if (_targetBmp == null)
            {
                var bmProps = new D2D.BitmapProperties1(
                    new D2D.PixelFormat(DXGI.Format.B8G8R8A8_UNorm, D2D.AlphaMode.Ignore),
                    _dpiX, _dpiY, D2D.BitmapOptions.Target | D2D.BitmapOptions.GdiCompatible);
                _targetBmp = D2D.Bitmap1.Create(rt, new Size2L(Width, Height), bmProps);
            }
            rt.SetTarget(_targetBmp);

            rt.BeginDraw();
            rt.Clear(new ColorF(this.BackColor));

            if (!_targetRect.IsEmpty)
            {
                if (_imBmp != null)
                {
                    rt.DrawBitmap(_imBmp, _targetRect);
                }

                if (_drawLine)
                {
                    var pt1 = new Point2F(_targetRect.Width * _warpStart.X + _targetRect.Left, _targetRect.Height * _warpStart.Y + _targetRect.Top);
                    var pt2 = new Point2F(_targetRect.Width * _warpEnd.X + _targetRect.Left, _targetRect.Height * _warpEnd.Y + _targetRect.Top);
                    rt.DrawLine(pt1, pt2, _lineBrush, _scaleFactor * 7, _lineStrokeStyle);
                }
            }

            #endregion

            #region BitBlt to GDI

            var gi = rt.QueryGdiInterop();
            var gidc = gi.GetDC(D2D.DeviceContextInitializeMode.Copy);
            Win32.BitBlt(hdc, 0, 0, Width, Height, gidc, 0, 0, Win32.SRCCOPY);
            gi.ReleaseDC(null);
            gi.Dispose();

            #endregion

            #region EndDraw

            if (!rt.EndDraw(true))
            {
                DiscardDeviceResources();
                return;
            }
            rt.SetTarget(null);

            #endregion
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** Win32 interop helper class

        [System.Security.SuppressUnmanagedCodeSecurity()]
        static class Win32
        {
            internal const int
                WM_ERASEBKGND = 0x0014,
                SRCCOPY = 0x00CC0020;

            [DllImport("gdi32.dll", ExactSpelling = true)]
            internal static extern bool BitBlt(
                IntPtr hdcDest,
                int nXDest,
                int nYDest,
                int nWidth,
                int nHeight,
                IntPtr hdcSource,
                int nXSrc,
                int nYSrc,
                int dwRop);
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** other methods

        void LoadDefaultImage()
        {
            Assembly asm = typeof(CropPage).Assembly;
            using (Stream stream = asm.GetManifestResourceStream("BitmapSamples.Resources.Sheep.jpg"))
            {
                _bitmap.Load(stream, new FormatConverter(PixelFormat.Format32bppPBGRA));
            }
            PrepareForNewImage();
        }

        public void UndoEffect()
        {
            if (_savedCopy != null)
            {
                _needUpdateIM = true;
                _bitmap.ImportAsFragment(_savedCopy, 0, 0);
                Invalidate(false);
            }
        }

        void ClearSavedCopy()
        {
            if (_savedCopy != null)
            {
                _savedCopy.Dispose();
                _savedCopy = null;
            }
        }

        void PrepareForNewImage()
        {
            if (_initialized)
            {
                DXUtil.Dispose(ref _imBmp);
                ClearSavedCopy();
                _savedCopy = _bitmap.Transform();
                UpdateTargetRect();
                Invalidate(false);
            }
        }

        void UpdateTargetRect()
        {
            float hostW = this.Width;
            float hostH = this.Height;
            hostW -= _scaleFactor * SideMargin * 2;
            hostH -= _scaleFactor * (TopMargin + BottomMargin);
            float imgW = _bitmap.PixelWidth;
            float imgH = _bitmap.PixelHeight;
            if (hostW <= 0f || hostH <= 0f)
            {
                _targetRect = RectF.Empty;
                return;
            }
            float offsetX = _scaleFactor * SideMargin;
            float offsetY = _scaleFactor * TopMargin;
            if (imgW / imgH > hostW / hostH)
            {
                float newH = imgH * hostW / imgW;
                offsetY += (hostH - newH) / 2;
                hostH = newH;
            }
            else
            {
                float newW = imgW * hostH / imgH;
                offsetX += (hostW - newW) / 2;
                hostW = newW;
            }
            _targetRect = new RectF(offsetX, offsetY, hostW, hostH);
        }

        void UpdateLine(float x, float y, bool second)
        {
            if (!_bitmap.HasImage)
            {
                return;
            }
            x = Math.Max(_targetRect.Left, Math.Min(x, _targetRect.Right));
            y = Math.Max(_targetRect.Top, Math.Min(y, _targetRect.Bottom));
            var pt = new Point2F((x - _targetRect.Left) / _targetRect.Width, (y - _targetRect.Top) / _targetRect.Height);
            if (!second)
                _warpStart = pt;
            else if (pt != _warpStart)
            {
                _warpEnd = pt;
                _drawLine = true;
                Invalidate(false);
            }
        }

        #endregion
    }
}
