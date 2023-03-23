using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchToolkitDemo.MultiScaleImagePages
{
    public partial class MultiScaleImageDemo : DemoBase
    {  
        public MultiScaleImageDemo()
        {
            InitializeComponent();

            this.Title = "C1MultiScaleImage";
            this.Description = "C1MultiScaleImage can show image with better quality in zoom. This page shows difference between PictureBox and C1MultiScaleImage. \n -Please try zoom in the following zoompanel by touch.";
            
            zoomFactorLabel.Text = "ZoomFactor:" + (C1ZoomPanel1.ZoomFactor * 100).ToString() + "%";
            C1ZoomPanel1.ZoomFactorChanged += C1ZoomPanel1_ZoomFactorChanged;
        }

        void C1ZoomPanel1_ZoomFactorChanged(object sender, EventArgs e)
        {
            zoomFactorLabel.Text = "ZoomFactor:" + (C1ZoomPanel1.ZoomFactor*100).ToString() + "%";
        }
    }
}
