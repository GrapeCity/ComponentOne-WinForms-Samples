using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.TouchToolKit;

namespace TouchDemo.C1ZoomPages.Help_Forms
{
    public partial class ControlBarUserControl02 : UserControl
    {
        public ControlBarUserControl02()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            myTrackBar1.Value = this.C1ZoomCommandProvider1.OwnerGcZoom.ZoomFactor;
            myTrackBar1.ValueChanged += myTrackBar1_ValueChanged;
            this.C1ZoomCommandProvider1.OwnerGcZoom.ZoomFactorChanged += OwnerC1Zoom_ZoomFactorChanged;
            base.OnLoad(e);
        }

        void OwnerC1Zoom_ZoomFactorChanged(object sender, EventArgs e)
        {
            myTrackBar1.Value = this.C1ZoomCommandProvider1.OwnerGcZoom.ZoomFactor;
        }

        void myTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.C1ZoomCommandProvider1.OwnerGcZoom.ZoomFactor = myTrackBar1.Value;
        }
    }
}
