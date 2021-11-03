namespace GaugeDemo
{
    partial class PageHelical
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
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeSingleMark c1GaugeSingleMark1 = new C1.Win.C1Gauge.C1GaugeSingleMark();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            this.c1Gauge1 = new C1.Win.C1Gauge.C1Gauge();
            this.c1RadialGauge1 = new C1.Win.C1Gauge.C1RadialGauge();
            this.gaugePanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugePanel
            // 
            this.gaugePanel.Controls.Add(this.c1Gauge1);
            // 
            // gaugeGrid
            // 
            this.gaugeGrid.SelectedObject = this.c1RadialGauge1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Gauge1.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1RadialGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(7, 15);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(378, 399);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(648099090741175142));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Visible = false;
            c1GaugeMarks1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.IntervalWidth = 15;
            c1GaugeMarks1.Length = 22;
            c1GaugeMarks1.Location = 20;
            c1GaugeMarks1.Location2 = 90;
            c1GaugeMarks1.Shadow.OffsetX = 0.5;
            c1GaugeMarks1.Shadow.OffsetY = 0.5;
            c1GaugeMarks1.Shadow.Visible = true;
            c1GaugeMarks1.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks1.ShowIrregularTo = true;
            c1GaugeMarks1.ValueColors.AddRange(new C1.Win.C1Gauge.C1GaugeValueColor[] {
            new C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Crimson, 1, ((long)(646691715857581860))),
            new C1.Win.C1Gauge.C1GaugeValueColor(50, -1, System.Drawing.Color.Chocolate, 1, ((long)(646973190834302516))),
            new C1.Win.C1Gauge.C1GaugeValueColor(80, -1, System.Drawing.Color.Teal, 1, ((long)(647254665811013172))),
            new C1.Win.C1Gauge.C1GaugeValueColor(100, -1, System.Drawing.Color.Olive, 1, ((long)(647536140787723828)))});
            c1GaugeMarks1.ViewTag = ((long)(646410240880851202));
            c1GaugeMarks1.Width = 12;
            c1GaugeLabels1.AllowFlip = true;
            c1GaugeLabels1.Color = System.Drawing.Color.White;
            c1GaugeLabels1.FontSize = 6.5;
            c1GaugeLabels1.Format = "n1";
            c1GaugeLabels1.IntervalWidth = 15;
            c1GaugeLabels1.IsRotated = true;
            c1GaugeLabels1.Location = 20;
            c1GaugeLabels1.Location2 = 90;
            c1GaugeLabels1.ShowIrregularTo = true;
            c1GaugeLabels1.TextAngle = 90;
            c1GaugeLabels1.ViewTag = ((long)(647817615764444485));
            c1GaugeSingleMark1.Angle = 0;
            c1GaugeSingleMark1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark1.Filling.Color = System.Drawing.Color.CadetBlue;
            c1GaugeSingleMark1.ImmediateUpdate = true;
            c1GaugeSingleMark1.Length = 24;
            c1GaugeSingleMark1.Location = 75;
            c1GaugeSingleMark1.OrthogonalOffset = 75;
            c1GaugeSingleMark1.PointerIndex = 100;
            c1GaugeSingleMark1.Shadow.OffsetX = 0.5;
            c1GaugeSingleMark1.Shadow.OffsetY = 0.5;
            c1GaugeSingleMark1.Shadow.Visible = true;
            c1GaugeSingleMark1.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round;
            c1GaugeSingleMark1.ShapeAngle = 90;
            c1GaugeSingleMark1.ValueColors.AddRange(new C1.Win.C1Gauge.C1GaugeValueColor[] {
            new C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Crimson, 1, ((long)(661328481413244809))),
            new C1.Win.C1Gauge.C1GaugeValueColor(50, -1, System.Drawing.Color.Chocolate, 1, ((long)(661609956394915749))),
            new C1.Win.C1Gauge.C1GaugeValueColor(80, -1, System.Drawing.Color.Teal, 1, ((long)(661891431375216610))),
            new C1.Win.C1Gauge.C1GaugeValueColor(100, -1, System.Drawing.Color.Olive, 1, ((long)(662172906356387521)))});
            c1GaugeSingleMark1.ViewTag = ((long)(658795202539365343));
            c1GaugeSingleMark1.Width = 12;
            c1GaugeSingleLabel1.Angle = 0;
            c1GaugeSingleLabel1.Color = System.Drawing.Color.White;
            c1GaugeSingleLabel1.FontSize = 6.5;
            c1GaugeSingleLabel1.Format = "n1";
            c1GaugeSingleLabel1.ImmediateUpdate = true;
            c1GaugeSingleLabel1.Location = 75;
            c1GaugeSingleLabel1.OrthogonalOffset = 75;
            c1GaugeSingleLabel1.PointerIndex = 100;
            c1GaugeSingleLabel1.ViewTag = ((long)(659076679335980092));
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeMarks1,
            c1GaugeLabels1,
            c1GaugeSingleMark1,
            c1GaugeSingleLabel1});
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Center;
            this.c1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.Black;
            this.c1RadialGauge1.Pointer.Border.Thickness = 2;
            this.c1RadialGauge1.Pointer.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            this.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.White;
            this.c1RadialGauge1.Pointer.Filling.Color2 = System.Drawing.Color.White;
            this.c1RadialGauge1.Pointer.Filling.Opacity = 0.7;
            this.c1RadialGauge1.Pointer.Filling.Opacity2 = 0.1;
            this.c1RadialGauge1.Pointer.Filling.SwapColors = true;
            this.c1RadialGauge1.Pointer.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.CornerRay;
            this.c1RadialGauge1.Pointer.Length = 26;
            this.c1RadialGauge1.Pointer.Offset = 20;
            this.c1RadialGauge1.Pointer.Offset2 = 90;
            this.c1RadialGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Round;
            this.c1RadialGauge1.Pointer.SweepTime = 20;
            this.c1RadialGauge1.Pointer.Value = 100;
            this.c1RadialGauge1.Pointer.Width = 16;
            this.c1RadialGauge1.PointerOriginX = 0.48;
            this.c1RadialGauge1.PointerOriginY = 0.47;
            this.c1RadialGauge1.Radius = 0.55;
            this.c1RadialGauge1.StartAngle = -90;
            this.c1RadialGauge1.SweepAngle = 1046;
            this.c1RadialGauge1.Viewport.AspectRatio = 0.95;
            this.c1RadialGauge1.ViewTag = ((long)(648380565717915800));
            // 
            // PageCase3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageCase3";
            this.gaugePanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Gauge.C1Gauge c1Gauge1;
        private C1.Win.C1Gauge.C1RadialGauge c1RadialGauge1;
    }
}
