using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using C1.Win.C1InputPanel;
using C1.Win.TouchToolKit;

namespace ControlExplorer.ZoomPolicies
{
    public class C1InputPanelZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1InputPanel); }
        }

        public override bool CanZoomChildren(Control control)
        {
            return false;
        }

        public override void ZoomBounds(Control control, ZoomBoundsInfo infos)
        {
            C1InputPanel ip = control as C1InputPanel;
            if (ip != null)
            {
                ip.UpdateFontZoom(infos.TargetFactor, false);
                float k = infos.TargetFactor / infos.CurrentFactor;
                control.Scale(new SizeF(k, k));
            }
        }

        public override IEnumerable<Control> GetChildren(Control control)
        {
            yield break;
        }
    }
}
