using C1.Win.C1Preview;
using C1.Win.TouchToolKit;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlExplorer.ZoomPolicies
{
    public class C1PrintPreviewControlZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1PrintPreviewControl); }
        }

        public override bool CanZoomChildren(System.Windows.Forms.Control control)
        {
            return false;
        }

        public override void ZoomFont(System.Windows.Forms.Control control, ZoomFontInfo infos)
        {
            control.Font = new System.Drawing.Font(control.Font.FontFamily, infos.CurrentFontSize);
        }

        public override void ZoomBounds(System.Windows.Forms.Control control, ZoomBoundsInfo infos)
        {
            var previewControl = control as C1PrintPreviewControl;

            if (previewControl.PreviewPane.ZoomMode == ZoomModeEnum.Custom ||
                previewControl.PreviewPane.ZoomMode == ZoomModeEnum.ActualSize)
            {
                previewControl.PreviewPane.ZoomFactor = infos.Zoom(previewControl.PreviewPane.ZoomFactor);
            }

            base.ZoomBounds(control, infos);
        }
    }

    public class C1PreviewPaneZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1PreviewPane); }
        }

        public override void ZoomBounds(System.Windows.Forms.Control control, ZoomBoundsInfo infos)
        {
            var previewPane = control as C1PreviewPane;

            if (previewPane.ZoomMode == ZoomModeEnum.Custom ||
                previewPane.ZoomMode == ZoomModeEnum.ActualSize)
            {
                previewPane.ZoomFactor = infos.Zoom(previewPane.ZoomFactor);
            }

            base.ZoomBounds(control, infos);
        }
    }
}

