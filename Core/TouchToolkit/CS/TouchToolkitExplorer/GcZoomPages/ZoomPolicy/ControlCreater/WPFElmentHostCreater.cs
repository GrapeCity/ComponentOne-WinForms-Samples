using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ClickOnceDemo.GcZoomPages
{
    public static class WPFElmentHostCreater
    {
        public static Control CreateControl(string zoomPolicy, Font font, Size layoutSize)
        {
            switch (zoomPolicy)
            {
                case "WPF_ElementHostZoomPolicy":
                    // Create the ElementHost control for hosting the
                    // WPF UserControl.
                    ElementHost host = new ElementHost();
                    host.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                    host.Bounds = new Rectangle(6, 6, 100, 30);

                    System.Windows.Controls.Grid grid = new System.Windows.Controls.Grid();
                    // Create a WPF Button
                    System.Windows.Controls.Button btn = new System.Windows.Controls.Button();
                    btn.Content = "Button in WPF";
                    btn.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                    btn.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                    btn.Width = 100;
                    btn.Height = 30;
                    grid.Children.Add(btn);

                    // Add it to ElementHost 
                    host.Child = grid;
                    return host;
                default:
                    break;
            }
            return null;
        }

        internal static string[] WPFElmentHostPolicies = new string[] 
        {
            "WPF_ElementHostZoomPolicy",
        };


        internal static string GetDescription(string zoomPolicy)
        {
            return Properties.Resources.ZoomPolicy_WPF_ElementHost;
        }
    }
}
