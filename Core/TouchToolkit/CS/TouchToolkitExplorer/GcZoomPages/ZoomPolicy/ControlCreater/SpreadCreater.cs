using FarPoint.Win.Spread;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceDemo.GcZoomPages
{
    public static class SpreadCreater
    {
        public static Control CreateControl(string zoomPolicy, Font font, Size layoutSize)
        {
            if (zoomPolicy == "SpreadZoomPolicy")
            {
                FpSpread spread1 = new FpSpread();
                spread1.Sheets.Add(new SheetView());
                spread1.Sheets.Add(new SheetView());
                spread1.Dock = DockStyle.Fill;
                return spread1;
            }
            return null;
        }

        internal static string[] SpreadPolicies = new string[] 
        {
            "SpreadZoomPolicy",
        };


        internal static string GetDescription(string zoomPolicy)
        {
            return Properties.Resources.ZoomPolicy_Spread;
        }
    }
}
