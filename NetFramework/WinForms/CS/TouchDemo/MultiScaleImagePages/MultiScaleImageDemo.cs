using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchToolKitDemo.MultiScaleImagePages
{
    public partial class MultiScaleImageDemo : DemoBase
    {  
        public MultiScaleImageDemo()
        {
            InitializeComponent();

            this.Title = "C1MultiScaleImage";
            this.Description = "C1MultiScaleImage displays higher quality images when you zoom in the image as opposed to a zoomed image without C1MultiScaleImage. This page illustrates the difference between a PictureBox and C1MultiScaleImage.  To see the difference, zoom in the PictureBox and C1MultiScaleImage by touch.";
            
            zoomFactorLabel.Text = "ZoomFactor:" + (C1ZoomPanel1.ZoomFactor * 100).ToString() + "%";
            C1ZoomPanel1.ZoomFactorChanged += C1ZoomPanel1_ZoomFactorChanged;
        }

        void C1ZoomPanel1_ZoomFactorChanged(object sender, EventArgs e)
        {
            zoomFactorLabel.Text = "ZoomFactor:" + (C1ZoomPanel1.ZoomFactor*100).ToString() + "%";
        }
    }
}
