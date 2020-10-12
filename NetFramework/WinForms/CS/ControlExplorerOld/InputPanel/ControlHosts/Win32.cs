using System;
using System.Runtime.InteropServices;

namespace ControlExplorer.InputPanel.ControlHosts
{
    internal static class Win32
    {
        internal const int
            CB_SHOWDROPDOWN = 0x14F;

        [DllImport("USER32.DLL")]
        internal static extern int MsgWaitForMultipleObjects(
            int nCount, IntPtr pHandles, short bWaitAll, int dwMilliseconds, int dwWakeMask);

        [DllImport("USER32.DLL", EntryPoint = "PostMessageW")]
        internal static extern IntPtr PostMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
    }
}
