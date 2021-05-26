using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.TouchToolKit;

namespace TouchToolkitDemo.C1ZoomPages.Help_Forms
{
    public partial class ControlBarUserControl03 : UserControl
    {
        public ControlBarUserControl03()
        {
            InitializeComponent();
        }

        C1Zoom zoomObj;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            zoomObj = this.C1ZoomCommandProvider1.OwnerGcZoom;

            button5_Click(null, EventArgs.Empty);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (zoomObj.FullScreenMode == FullScreenMode.FullScreen || zoomObj.FullScreenMode == FullScreenMode.FullScreenWithTaskBar)
            {
                button5.Text = "Normal form";
            }
            else
            {
                button5.Text = "Full screen";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (zoomObj.Target as Form).Close();
        }
    }
}
