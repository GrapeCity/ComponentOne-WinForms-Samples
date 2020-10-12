using C1.Framework;
using C1.Win.BarCode;
using C1.Win.TouchToolKit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.ZoomPolicies
{

    public class C1BarcodeZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1BarCode); }
        }

        public override void ZoomBounds(Control control, ZoomBoundsInfo infos)
        {
            C1BarCode barcode = control as C1BarCode;
            barcode.ModuleSize = infos.Zoom(barcode.ModuleSize);
            barcode.BarHeight = infos.Zoom(barcode.BarHeight);
            base.ZoomBounds(control, infos);
        }
     }
}

