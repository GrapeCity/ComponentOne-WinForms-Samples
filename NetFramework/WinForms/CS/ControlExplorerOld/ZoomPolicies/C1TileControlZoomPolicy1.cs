using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using C1.Win.C1Tile;
using C1.Win.TouchToolKit;

namespace ControlExplorer.ZoomPolicies
{
    public class C1TileControlZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1TileControl); }
        }

        public override void ZoomBounds(Control control, ZoomBoundsInfo infos)
        {
            float k = infos.TargetFactor / infos.CurrentFactor;
            control.Scale(new SizeF(k, k));
        }

        public override void ZoomFont(Control control, ZoomFontInfo infos)
        {
            C1TileControl tc = control as C1TileControl;
            if (tc != null)
            {
                if (tc.TextSize != 0f)
                    tc.TextSize *= infos.DeltaFactor;
                if (tc.GroupTextSize != 0f)
                    tc.GroupTextSize *= infos.DeltaFactor;
                else
                    tc.GroupFont = infos.Zoom(tc.GroupFont);
                ZoomFont(tc.DefaultTemplate.Elements, infos);
                foreach (Template template in tc.Templates)
                {
                    ZoomFont(template.Elements, infos);
                }
            }
            base.ZoomFont(control, infos);
        }

        static void ZoomFont(ElementCollection elements, ZoomFontInfo infos)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                var element = elements[i];
                TextElement textElement = element as TextElement;
                if (textElement != null)
                {
                    if (textElement.FontSize != 0f)
                        textElement.FontSize *= infos.DeltaFactor;
                    else
                        textElement.Font = infos.Zoom(textElement.Font);
                }
                else
                {
                    PanelElement panelElement = element as PanelElement;
                    if (panelElement != null)
                    {
                        ZoomFont(panelElement.Children, infos);
                    }
                }
            }
        }
    }
}
