// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BuildKit.Services;
public static class WindowsHelper
{
    private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        private const int SW_RESTORE = 9;
        private const int SW_MAXIMIZE = 3;

        public static List<string> GetAllWindowTitles()
        {
            var titles = new List<string>();

            EnumWindows((hWnd, lParam) =>
            {
                if (IsWindowVisible(hWnd))
                {
                    StringBuilder sb = new StringBuilder(256);
                    GetWindowText(hWnd, sb, 256);
                    string title = sb.ToString();
                    if (!string.IsNullOrWhiteSpace(title))
                    {
                        titles.Add(title);
                    }
                }
                return true;
            }, IntPtr.Zero);

            return titles;
        }

        public static IntPtr FindWindowByTitle(string title)
        {
            IntPtr foundWindow = IntPtr.Zero;
            EnumWindows((hWnd, lParam) =>
            {
                if (IsWindowVisible(hWnd))
                {
                    StringBuilder sb = new StringBuilder(256);
                    GetWindowText(hWnd, sb, 256);
                    if (sb.ToString() == title)
                    {
                        foundWindow = hWnd;
                        return false; // Stop enumeration
                    }
                }
                return true;
            }, IntPtr.Zero);
            return foundWindow;
        }

        public static IntPtr DetectNewWindow(HashSet<string> existingTitles, int maxRetries = 250)
        {
            for (int i = 0; i < maxRetries; i++)
            {
                var currentTitles = new HashSet<string>(GetAllWindowTitles());
                // Find titles in current that are not in existing
                var newTitles = currentTitles.Except(existingTitles).ToList();

                // Filter out irrelevant windows (similar to python script)
                var filteredTitles = newTitles.Where(t => 
                    !string.IsNullOrWhiteSpace(t) &&
                    !t.Contains("OleMainThreadWndName") &&
                    !t.Contains("MSCTFIME UI") &&
                    !t.Contains("Default IME") &&
                    !t.Contains("ConsoleWindowClass")
                ).ToList();

                if (filteredTitles.Any())
                {
                    string title = filteredTitles.First();
                    return FindWindowByTitle(title);
                }

                Thread.Sleep(200);
            }

            Console.WriteLine("Error: Maximum retries reached while detecting new window.");
            return IntPtr.Zero;
        }

        public static void BringToFrontAndMaximize(IntPtr hWnd)
        {
            if (hWnd == IntPtr.Zero) return;

            ShowWindow(hWnd, SW_RESTORE); // Restore if minimized
            Thread.Sleep(500);
            SetForegroundWindow(hWnd);
            Thread.Sleep(500);
            ShowWindow(hWnd, SW_MAXIMIZE); // Maximize
            Thread.Sleep(2000); // Wait for animation
        }

    public static void BringToFront(IntPtr hWnd)
        {
            if (hWnd == IntPtr.Zero) return;

            ShowWindow(hWnd, SW_RESTORE); // Restore if minimized
            Thread.Sleep(500);
           SetForegroundWindow(hWnd);
            Thread.Sleep(500);
            ShowWindow(hWnd, 1);
            //Thread.Sleep(2000); // Wait for animation
        }
}

