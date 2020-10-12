using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Ribbon;

namespace ClickOnceDemo.GcZoomPages.ControlHosts
{
    public class TextBoxHost : C1.Win.C1Ribbon.RibbonControlHost
    {
        public TextBoxHost()
            : base(new System.Windows.Forms.TextBox())
        {
        }

        /// <summary>
        /// Gets the hosted TextBox control.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TextBox TextBox
        {
            get { return (TextBox)Control; }
        }
    }
}
