using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Reflection;
using System.Runtime.InteropServices;

namespace C1.C1FlexReportExplorer
{
    public partial class PreviewForm : Form
    {
        #region Interop
        const int WS_POPUP = unchecked((int)0x80000000);
        const int SW_SHOWNOACTIVATE = 4;
        const int WS_EX_TOPMOST = 0x00000008;
        const int WS_EX_NOACTIVATE = 0x08000000;
        const int WS_EX_LAYERED = 0x00080000;
        const int AW_BLEND = 0x00080000;
        const int AW_HIDE = 0x00010000;

        [DllImport("user32")]
        static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
        const int
            SWP_NOSIZE = 0x1,
            SWP_NOMOVE = 0x2,
            SWP_NOZORDER = 0x4,
            SWP_NOREDRAW = 0x8,
            SWP_NOACTIVATE = 0x10,
            SWP_FRAMECHANGED = 0x20,
            SWP_SHOWWINDOW = 0x40,
            SWP_HIDEWINDOW = 0x80,
            SWP_NOCOPYBITS = 0x100,
            SWP_NOOWNERZORDER = 0x200,
            SWP_NOSENDCHANGING = 0x0400,
            SWP_DEFERERASE = 0x2000,
            SWP_ASYNCWINDOWPOS = 0x4000;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int dwTime, uint dwFlags);
        #endregion

        protected override CreateParams CreateParams
        {

        // [SecurityPermission(SecurityAction.LinkDemand)]
        get
            {
                CreateParams cp = base.CreateParams;
                // NOTE: WS_EX_NOACTIVATE works only on w2k/xp.
                try
                {
                    OperatingSystem os = Environment.OSVersion;
                    switch (os.Platform)
                    {
                        case PlatformID.Win32NT:
                            if (os.Version.Major > 4)
                                cp.ExStyle |= WS_EX_NOACTIVATE | WS_EX_TOPMOST;
                            else
                                cp.ExStyle |= WS_EX_TOPMOST;
                            break;
                        default:
                            cp.ExStyle |= WS_EX_TOPMOST;
                            break;
                    }
                }
                catch
                {
                }
                return cp;
            }
        }

        // This is to make sure our dummy var with its assignment are not optimized away
        // (we need to have the handle for preview to show the first time):
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]
        public PreviewForm()
        {
            InitializeComponent();
            CreateHandle();
            var dummy = this.pictureBox1.Handle;
            // SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void Show(Point location)
        {
            this.Location = location;
            SetWindowPos(this.Handle, IntPtr.Zero,  location.X, location.Y, this.Size.Width, this.Size.Height, SWP_HIDEWINDOW | SWP_NOACTIVATE);
            AnimateWindow(this.Handle, 500, AW_BLEND);
        }

        public new void Hide()
        {
            if (this.IsHandleCreated)
                AnimateWindow(this.Handle, 500, AW_HIDE | AW_BLEND);
        }
    }
}
