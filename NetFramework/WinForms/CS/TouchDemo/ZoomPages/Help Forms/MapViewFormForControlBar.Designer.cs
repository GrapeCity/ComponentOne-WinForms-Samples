namespace TouchToolKitDemo.C1ZoomPages.Help_Forms
{
    partial class MapViewFormForControlBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            C1.Win.TouchToolKit.ControlBar controlBar1 = new C1.Win.TouchToolKit.ControlBar();
            C1.Win.TouchToolKit.ControlBar controlBar2 = new C1.Win.TouchToolKit.ControlBar();
            this.C1Zoom1 = new C1.Win.TouchToolKit.C1Zoom(this.components);
            this.SuspendLayout();
            // 
            // C1Zoom1
            // 
            controlBar1.Content = typeof(TouchToolKitDemo.C1ZoomPages.Help_Forms.ControlBarUserControl01);
            controlBar1.TransparencyKey = System.Drawing.SystemColors.Control;
            controlBar1.DockPosition = System.Drawing.ContentAlignment.TopRight;
            controlBar1.Margin = new System.Windows.Forms.Padding(10);
            controlBar1.Opacity = 0.7D;
            controlBar1.TransparentBackground = true;
            controlBar2.Content = typeof(TouchToolKitDemo.C1ZoomPages.Help_Forms.ControlBarUserControl02);
            controlBar2.TransparencyKey = System.Drawing.SystemColors.Control;
            controlBar2.DockPosition = System.Drawing.ContentAlignment.TopLeft;
            controlBar2.Margin = new System.Windows.Forms.Padding(10);
            controlBar2.Opacity = 0.7D;
            controlBar2.TransparentBackground = true;
            this.C1Zoom1.ControlBars.Add(controlBar1);
            this.C1Zoom1.ControlBars.Add(controlBar2);
            this.C1Zoom1.FullScreenMode = C1.Win.TouchToolKit.FullScreenMode.FullScreen;
            this.C1Zoom1.InnerPanelLayoutMode = C1.Win.TouchToolKit.InnerPanelLayoutMode.MiddleCenter;
            this.C1Zoom1.IsHorizontalRailEnabled = false;
            this.C1Zoom1.IsVerticalRailEnabled = false;
            this.C1Zoom1.MaxZoomFactor = 4F;
            this.C1Zoom1.Target = this;
            // 
            // MapViewForControlBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MapViewForControlBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ControlBarForm";
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.TouchToolKit.C1Zoom C1Zoom1;
    }
}