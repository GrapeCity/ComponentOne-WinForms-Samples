using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Custom_Localization.UserControls.Events
{
    public class CultureChangedEventArgs : EventArgs
    {
        public CultureInfo Culture { get; }

        public CultureChangedEventArgs(CultureInfo culture)
        {
            Culture = culture ?? throw new ArgumentNullException(nameof(culture));
        }
    }
}
