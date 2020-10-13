using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceDemo.GcZoomPages
{
    public static class VBPowerPacksCreater
    {
        public static Control CreateControl(string zoomPolicy, Font font, Size layoutSize)
        {
            switch (zoomPolicy)
            {
                case "ShapeContainerZoomPolicy":
                    ShapeContainer shapeContainer1 = new ShapeContainer();
                    shapeContainer1.Dock = DockStyle.Fill;
                    shapeContainer1.Shapes.Add(new OvalShape(30, 30, 80, 80));
                    shapeContainer1.Shapes.Add(new RectangleShape(30, 120, 80, 80));
                    shapeContainer1.Shapes.Add(new LineShape(160, 30, 160, 200));
                    return shapeContainer1;
                default:
                    break;
            }
            return null;
        }


        internal static string[] VBPowerPacksPolicies = new string[] 
        {
            "ShapeContainerZoomPolicy",
        };


        internal static string GetDescription(string zoomPolicy)
        {
            return Properties.Resources.ZoomPolicy_VisualBasicPowerPacks;
        }
    }
}
