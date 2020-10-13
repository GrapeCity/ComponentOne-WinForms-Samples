//----------------------------------------------------------------------------
// Utils.cs
//
// Copyright (C) ComponentOne LLC
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.IO;
using System.Resources;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;

namespace ReportStyle
{
    internal static class AppUtils
    {
        public static Image LoadResourceImage(Assembly assembly, string resourceName)
        {
            foreach (string res in assembly.GetManifestResourceNames())
            {
                if (res.EndsWith(resourceName))
                {
                    System.IO.Stream stream = assembly.GetManifestResourceStream(res);
                    return Image.FromStream(stream);
                }
            }
            return null;
        }

        public static Image LoadResourceImage(string resourceName)
        {
            return LoadResourceImage(Assembly.GetExecutingAssembly(), resourceName);
        }
    }
}
