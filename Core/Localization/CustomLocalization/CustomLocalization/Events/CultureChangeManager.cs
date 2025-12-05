using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Custom_Localization.Events
{
    public static class CultureManager
    {
        public static event EventHandler CultureChanged;

        public static void ChangeCulture(CultureInfo cultureKey)
        {
            Thread.CurrentThread.CurrentUICulture = cultureKey;
            Thread.CurrentThread.CurrentCulture = cultureKey;

            CultureChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}
