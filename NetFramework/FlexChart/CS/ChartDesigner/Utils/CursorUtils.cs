using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace C1.Win.FlexChart.Designer.Utils
{
    class CursorUtils
    {
        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

        [DllImport("user32.dll")]
        extern static bool DestroyIcon(IntPtr handle);

        public static Cursor CreateCursor(Bitmap bmp,
            int xHotSpot, int yHotSpot)
        {
            IconInfo tmp = new IconInfo();
            var hIcon = bmp.GetHicon();
            GetIconInfo(hIcon, ref tmp);
            tmp.xHotspot = xHotSpot;
            tmp.yHotspot = yHotSpot;
            tmp.fIcon = false;
            var cursor = new Cursor(CreateIconIndirect(ref tmp));
            DestroyIcon(hIcon);
            return cursor;
        }
    }
}
