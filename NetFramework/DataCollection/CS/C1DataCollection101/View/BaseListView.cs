using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace C1DataCollection101.View
{
    public abstract class BaseListView: ListView
    {
        public BaseListView()
        {
            DoubleBuffered = true;
            View = System.Windows.Forms.View.Tile;
            TileSize = new Size(10000, 52);
            Scrollable = true;
            FullRowSelect = true;
            MultiSelect = false;
            OwnerDraw = true;
            BorderStyle = BorderStyle.None;
            Margin = new Padding(0);
        }

        public event EventHandler<EventArgs> ItemClick;

        protected void OnItemClick(EventArgs e) => ItemClick?.Invoke(this, e);

        protected override void OnMouseMove(MouseEventArgs e)
        {
            var item = GetItemAt(e.Location.X, e.Location.Y);
            if (item != null)
                item.Selected = true;
            base.OnMouseMove(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            var item = GetItemAt(e.Location.X, e.Location.Y);
            if (item != null)
            {
                OnItemClick(EventArgs.Empty);
            }
        }

        #region Win32

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x83: // WM_NCCALCSIZE
                    int style = GetWindowLong(Handle, GWL_STYLE);
                    if ((style & WS_HSCROLL) == WS_HSCROLL)
                        SetWindowLong(Handle, GWL_STYLE, style & ~WS_HSCROLL);
                    base.WndProc(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private const int GWL_STYLE = -16;
        private const int WS_HSCROLL = 0x00100000;

        public static int GetWindowLong(IntPtr hWnd, int nIndex)
        {
            if (IntPtr.Size == 4)
                return (int)GetWindowLong32(hWnd, nIndex);
            else
                return (int)(long)GetWindowLongPtr64(hWnd, nIndex);
        }

        public static int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong)
        {
            if (IntPtr.Size == 4)
                return (int)SetWindowLongPtr32(hWnd, nIndex, dwNewLong);
            else
                return (int)(long)SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowLong", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowLong32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtr32(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, int dwNewLong);

        #endregion
    }
}
