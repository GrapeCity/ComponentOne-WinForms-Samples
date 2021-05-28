using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Ribbon;


namespace ClickOnceDemo.GcZoomPages.ControlHosts
{
    public class RadioButtonHost : C1.Win.C1Ribbon.RibbonControlHost
    {

        public RadioButtonHost()
            : base(new System.Windows.Forms.RadioButton())
        {
        }

        /// <summary>
        /// Gets the hosted RadioButton control.
        /// </summary>
       
        public RadioButton RadioButton
        {
            get { return (RadioButton)Control; }
        }
    }
}
