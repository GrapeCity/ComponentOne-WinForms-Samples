namespace GaugeDemo
{
    partial class PageSlidingScale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.Gauge.C1GaugeLabels();
            C1.Win.Gauge.C1GaugeSegment c1GaugeSegment1 = new C1.Win.Gauge.C1GaugeSegment();
            this.c1Gauge1 = new C1.Win.Gauge.C1Gauge();
            this.c1RadialGauge1 = new C1.Win.Gauge.C1RadialGauge();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            //this.gaugePanel.SuspendLayout();
            //this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugePanel
            // 
            this.gaugePanel.Controls.Add(this.c1Gauge1);
            this.gaugePanel.Controls.Add(this.trackBar1);
            // 
            // gaugeGrid
            // 
            this.gaugeGrid.SelectedObject = this.c1RadialGauge1;
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Gauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Gauge1.Gauges.AddRange(new C1.Win.Gauge.C1GaugeBase[] {
            this.c1RadialGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(20, 29);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(314, 373);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(649504984882777612));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Visible = false;
            c1GaugeMarks1.Alignment = C1.Win.Gauge.C1GaugeAlignment.In;
            c1GaugeMarks1.Border.Color = System.Drawing.Color.Blue;
            c1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.RoyalBlue;
            c1GaugeMarks1.Interval = 5;
            c1GaugeMarks1.Length = 6.5;
            c1GaugeMarks1.Location = 75;
            c1GaugeMarks1.ScaleFrom = -30;
            c1GaugeMarks1.ScaleTo = 30;
            c1GaugeMarks1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks1.ViewTag = ((long)(648660559952575640));
            c1GaugeMarks1.Width = 0.6;
            c1GaugeMarks2.Alignment = C1.Win.Gauge.C1GaugeAlignment.In;
            c1GaugeMarks2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.IndianRed;
            c1GaugeMarks2.Interval = 1;
            c1GaugeMarks2.Length = 4;
            c1GaugeMarks2.Location = 75;
            c1GaugeMarks2.ScaleFrom = -30;
            c1GaugeMarks2.ScaleTo = 30;
            c1GaugeMarks2.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks2.ViewTag = ((long)(648942034929296296));
            c1GaugeMarks2.Width = 0.6;
            c1GaugeLabels1.Color = System.Drawing.Color.MidnightBlue;
            c1GaugeLabels1.FontSize = 4;
            c1GaugeLabels1.Interval = 5;
            c1GaugeLabels1.IsRotated = true;
            c1GaugeLabels1.Location = 63;
            c1GaugeLabels1.ScaleFrom = -30;
            c1GaugeLabels1.ScaleTo = 30;
            c1GaugeLabels1.TextAngle = 90;
            c1GaugeLabels1.ViewTag = ((long)(649223509906016953));
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeMarks1,
            c1GaugeMarks2,
            c1GaugeLabels1});
            c1GaugeSegment1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeSegment1.CenterPointX = 0.305;
            c1GaugeSegment1.CornerRadius = 12;
            c1GaugeSegment1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            c1GaugeSegment1.Filling.Color = System.Drawing.Color.SlateGray;
            c1GaugeSegment1.Filling.Color2 = System.Drawing.Color.White;
            c1GaugeSegment1.Filling.HatchStyle = C1.Win.Gauge.C1GaugeHatchStyle.Vertical;
            c1GaugeSegment1.Filling.SwapColors = true;
            c1GaugeSegment1.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialInner;
            c1GaugeSegment1.Gradient.Falloff = C1.Win.Gauge.C1GaugeGradientFalloff.SigmaBell;
            c1GaugeSegment1.InnerRadius = 100;
            c1GaugeSegment1.OuterRadius = 50;
            c1GaugeSegment1.StartAngle = -180;
            c1GaugeSegment1.SweepAngle = 180;
            this.c1RadialGauge1.FaceShapes.AddRange(new C1.Win.Gauge.C1GaugeBaseShape[] {
            c1GaugeSegment1});
            this.c1RadialGauge1.Maximum = 15;
            this.c1RadialGauge1.Minimum = -15;
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Alignment = C1.Win.Gauge.C1GaugeAlignment.Center;
            this.c1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.IndianRed;
            this.c1RadialGauge1.Pointer.CustomShape.EndRadius = 0.333333333333;
            this.c1RadialGauge1.Pointer.CustomShape.EndWidth = 0.5;
            this.c1RadialGauge1.Pointer.CustomShape.StartRadius = 0.5;
            this.c1RadialGauge1.Pointer.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            this.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.RosyBrown;
            this.c1RadialGauge1.Pointer.Filling.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c1RadialGauge1.Pointer.FlipShape = true;
            this.c1RadialGauge1.Pointer.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.BackwardDiagonal;
            this.c1RadialGauge1.Pointer.Length = 4;
            this.c1RadialGauge1.Pointer.Offset = 80;
            this.c1RadialGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom;
            this.c1RadialGauge1.PointerOriginX = 2;
            this.c1RadialGauge1.Radius = 2.2;
            this.c1RadialGauge1.SlidingScale = true;
            this.c1RadialGauge1.StartAngle = -120;
            this.c1RadialGauge1.SweepAngle = 60;
            this.c1RadialGauge1.Viewport.AspectPinX = 0.45;
            this.c1RadialGauge1.Viewport.AspectRatio = 0.5;
            this.c1RadialGauge1.ViewTag = ((long)(649786459859508269));
            this.c1RadialGauge1.ValueChanged += new System.EventHandler(this.c1RadialGauge1_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackBar1.Location = new System.Drawing.Point(340, 29);
            this.trackBar1.Maximum = 120;
            this.trackBar1.Minimum = -120;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 373);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // PageSlidingScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageSlidingScale";
            this.gaugePanel.ResumeLayout(false);
            this.gaugePanel.PerformLayout();
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Gauge.C1Gauge c1Gauge1;
        private C1.Win.Gauge.C1RadialGauge c1RadialGauge1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}
