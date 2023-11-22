using C1.Framework;
using C1.Win.Ribbon;
using ControlExplorer.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer
{
    // todo: 
    // - search combo ( E11A E094 E000 )
    // - switch themes (need our combo)

    public partial class Explorer : C1RibbonForm
    {
        public static string SuiteDescription = "Over 30 .NET Windows Forms controls, including the ones you can't get anywhere else.\n\nComponentOne Studio® WinForms Edition controls come packed with endless built-in features, superior flexibility, and the outstanding assurance that these controls will stand the test of time.";
        public static Explorer TheExplorer { get; private set; }

        public Explorer()
        {
            InitializeComponent();
            TheExplorer = this;
            InitializeHomeSiteLinkButtons();
        }

        private void Explorer_Load(object sender, EventArgs e)
        {
            // todo: apply themes?
        }

        public void ShowControl(ControlInfo info)
        {
            if (info.Features.Count == 0)
                return;
            var feature = info.Features[0];
            var sample = feature as SampleInfo;
            if (sample == null)
            {
                sample = ((CategoryInfo)feature).Samples[0];
            }
            if (sample != null)
            {
                try
                {
                    this.Cursor = Cursors.AppStarting;
                    LockWindowUpdate(Handle);
                    var featureNavigation = new FeatureNavigation(info);
                    featureNavigation.Dock = DockStyle.Fill;
                    this.navigationPanel.Controls.Clear();
                    this.navigationPanel.Controls.Add(featureNavigation);
                }
                finally
                {
                    LockWindowUpdate(IntPtr.Zero);
                    this.Cursor = Cursors.Default;
                }
            }
        }

        public void ShowSample(SampleInfo info)
        {
            if (info != null)
            {
                try
                {
                    this.Cursor = Cursors.AppStarting;
                    LockWindowUpdate(Handle);
                    this.demoViewer1.Show(info);
                    this.allControls1.Visible = false;
                }
                finally
                {
                    LockWindowUpdate(IntPtr.Zero);
                    this.Cursor = Cursors.Default;
                }
            }
        }


        public void GoHome()
        {
            this.navigationPanel.Controls.Clear();
            this.navigationPanel.Controls.Add(this.homeNavigation1);
            this.allControls1.Visible = true;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", ExactSpelling = true)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);

        #region home site links
        // todo: use other images from Noela (better png)
        private void InitializeHomeSiteLinkButtons()
        {
            {   // Support
                var icon1 = new C1PathIcon();
                icon1.Data = "M7.755,10.727c-0.457,0-0.828,0.381-0.828,0.838c0,0.447,0.359,0.839,0.828,0.839s0.838-0.392,0.838-0.839C8.593,11.107,8.212,10.727,7.755,10.727z";
                icon1.ViewBox = new Rectangle(0,0,16, 16);
                icon1.Size = new Size(16, 16);
                var icon2 = new C1PathIcon();
                icon2.Data = "M7.896,4.375c-1.469,0-2.145,0.871-2.145,1.46c0,0.425,0.359,0.621,0.652,0.621c0.59,0,0.35-0.839,1.461-0.839c0.543,0,0.98,0.239,0.98,0.74c0,0.588-0.611,0.926-0.971,1.23C7.56,7.861,7.146,8.308,7.146,9.244c0,0.566,0.152,0.73,0.6,0.73c0.533,0,0.643-0.24,0.643-0.447c0-0.566,0.01-0.893,0.609-1.361c0.295-0.229,1.219-0.97,1.219-1.993C10.216,5.148,9.292,4.375,7.896,4.375z";
                icon2.ViewBox = new Rectangle(0, 0, 16, 16);
                icon2.Size = new Size(16, 16);
                var icon3 = new C1PathIcon();
                icon3.Data = "M7.999,0c-4.42,0-8,3.578-8,8v7.375C-0.001,15.721,0.28,16,0.626,16h7.373c4.422,0,8.002-3.578,8.002-8C16.001,3.579,12.421,0,7.999,0z M7.999,14.75h-6.75V8c0-3.73,3.02-6.75,6.75-6.75c3.732,0,6.75,3.02,6.75,6.75S11.731,14.75,7.999,14.75z";
                icon3.ViewBox = new Rectangle(0, 0, 16, 16);
                icon3.Size = new Size(16, 16);
                var cicon = new C1CompositeIcon();
                cicon.Size = new Size(16, 16);
                cicon.Icons.Add(icon3);
                cicon.Icons.Add(icon2);
                cicon.Icons.Add(icon1);
                btnSupport.Icon = cicon;
            }

            {   // About
                var icon1 = new C1PolygonIcon();
                List<PointF> points = new List<PointF>();
                points.Add(new PointF(8.842999f, 5.088f));
                points.Add(new PointF(8.842999f, 5.55357552f));
                points.Add(new PointF(8.465575f, 5.93099976f));
                points.Add(new PointF(8f, 5.93099976f));
                points.Add(new PointF(7.534424f, 5.93099976f));
                points.Add(new PointF(7.15699959f, 5.55357552f));
                points.Add(new PointF(7.15699959f, 5.088f));
                points.Add(new PointF(7.15699959f, 4.62242365f));
                points.Add(new PointF(7.534424f, 4.24499941f));
                points.Add(new PointF(8f, 4.24499941f));
                points.Add(new PointF(8.465575f, 4.24499941f));
                points.Add(new PointF(8.842999f, 4.62242365f));
                points.Add(new PointF(8.842999f, 5.088f));
                icon1.Points = points.ToArray();
                icon1.IsClosed = true;
                icon1.ViewBox = new Rectangle(0, 0, 16, 16);
                icon1.Size = new Size(16, 16);
                
                var icon2 = new C1PathIcon();
                icon2.Data = "M8,0C3.578,0,0,3.578,0,8s3.578,8,8,8s8-3.578,8-8S12.422,0,8,0z M8,14.75c-3.73,0-6.75-3.02-6.75-6.75c0-3.731,3.02-6.75,6.75-6.75c3.732,0,6.75,3.02,6.75,6.75S11.732,14.75,8,14.75z";
                icon2.ViewBox = new Rectangle(0, 0, 16, 16);
                icon2.Size = new Size(16, 16);
                var icon3 = new C1PathIcon();
                icon3.Data = "M8,6.697c-0.344,0-0.625,0.279-0.625,0.625v4.025c0,0.346,0.281,0.625,0.625,0.625c0.346,0,0.625-0.279,0.625-0.625V7.322C8.625,6.977,8.346,6.697,8,6.697z";
                icon3.ViewBox = new Rectangle(0, 0, 16, 16);
                icon3.Size = new Size(16, 16);
                var cicon = new C1CompositeIcon();
                cicon.Size = new Size(16, 16);
                cicon.Icons.Add(icon3);
                cicon.Icons.Add(icon2);
                cicon.Icons.Add(icon1);
                btnAbout.Icon = cicon;
            }

            {   // Pricing
                var icon1 = new C1PathIcon();
                icon1.Data = "M15,0.5H1c-0.551,0-1,0.447-1,1v9c0,0.553,0.449,1,1,1h14c0.553,0,1-0.447,1-1v-9C16,0.947,15.553,0.5,15,0.5z M15,10.5H1v-9h14V10.5z";
                icon1.ViewBox = new Rectangle(0, 0, 16, 16);
                icon1.Size = new Size(16, 16);
                var icon2 = new C1PathIcon();
                icon2.Data = "M8,9c1.658,0,3-1.344,3-3S9.658,3,8,3C6.344,3,5,4.344,5,6S6.344,9,8,9z M8,4c1.105,0,2.002,0.896,2.002,2S9.105,8,8,8C6.896,8,6.002,7.104,6.002,6S6.896,4,8,4z";
                icon2.ViewBox = new Rectangle(0, 0, 16, 16);
                icon2.Size = new Size(16, 16);

                GraphicsPath path = new GraphicsPath();
                path.AddRectangle(new RectangleF(2.502f, 5.5f, 0.998f, 1));
                var Points = path.PathPoints;

                var icon3 = new C1PolygonIcon();
                List<PointF> points = new List<PointF>();
                points.Add(new PointF(2.5f, 5.5f));
                points.Add(new PointF(3.5f, 5.5f));
                points.Add(new PointF(3.5f, 6.5f));
                points.Add(new PointF(2.5f, 6.5f));
                icon3.Points = points.ToArray();
                icon3.IsClosed = true;
                icon3.ViewBox = new Rectangle(0, 0, 16, 16);
                icon3.Size = new Size(16, 16);

                var icon4 = new C1PolygonIcon();
                points = new List<PointF>();
                points.Add(new PointF(12.5f, 5.5f));
                points.Add(new PointF(13.5f, 5.5f));
                points.Add(new PointF(13.5f, 6.5f));
                points.Add(new PointF(12.5f, 6.5f));
                icon4.Points = points.ToArray();
                icon4.IsClosed = true;
                icon4.ViewBox = new Rectangle(0, 0, 16, 16);
                icon4.Size = new Size(16, 16);

                var icon5 = new C1PathIcon();
                icon5.Data = "M0.5,12.5H0c0,0.553,0.449,1,1,1h14c0.553,0,1-0.447,1-1H1H0.5z";
                icon5.ViewBox = new Rectangle(0, 0, 16, 16);
                icon5.Size = new Size(16, 16);
                var icon6 = new C1PathIcon();
                icon6.Data = "M0.5,14.5H0c0,0.553,0.449,1,1,1h14c0.553,0,1-0.447,1-1H1H0.5z";
                icon6.ViewBox = new Rectangle(0, 0, 16, 16);
                icon6.Size = new Size(16, 16);
                var cicon = new C1CompositeIcon();
                cicon.Size = new Size(16, 16);
                cicon.Icons.Add(icon2);
                cicon.Icons.Add(icon1);
                cicon.Icons.Add(icon3);
                cicon.Icons.Add(icon4);
                cicon.Icons.Add(icon5);
                cicon.Icons.Add(icon6);
                btnPricing.Icon = cicon;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "https://developer.mescius.com/componentone/download";
            System.Diagnostics.Process.Start(info);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "https://developer.mescius.com/componentone/winforms-ui-controls";
            System.Diagnostics.Process.Start(info);
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "https://developer.mescius.com/support/contact";
            System.Diagnostics.Process.Start(info);
        }

        private void btnPricing_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "https://developer.mescius.com/pricing";
            System.Diagnostics.Process.Start(info);
        }
        #endregion
    }
}
