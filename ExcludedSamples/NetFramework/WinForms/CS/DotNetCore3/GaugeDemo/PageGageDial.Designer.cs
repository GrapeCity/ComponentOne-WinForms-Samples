namespace GaugeDemo
{
    partial class PageGageDial
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
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks3 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeSector c1GaugeSector1 = new C1.Win.C1Gauge.C1GaugeSector();
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
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Gauge1.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1RadialGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(16, 16);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(360, 405);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(640216300207618618));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Visible = false;
            c1GaugeMarks1.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.Green;
            c1GaugeMarks1.Interval = 10;
            c1GaugeMarks1.Length = 4;
            c1GaugeMarks1.Location = 83;
            c1GaugeMarks1.ViewTag = ((long)(639371875277416646));
            c1GaugeMarks1.Width = 0.15;
            c1GaugeMarks2.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.Green;
            c1GaugeMarks2.Interval = 5;
            c1GaugeMarks2.Length = 3;
            c1GaugeMarks2.Location = 83;
            c1GaugeMarks2.ViewTag = ((long)(641060729845969881));
            c1GaugeMarks2.Width = 0.15;
            c1GaugeMarks3.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks3.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks3.Filling.Color = System.Drawing.Color.Green;
            c1GaugeMarks3.Interval = 1;
            c1GaugeMarks3.Length = 2;
            c1GaugeMarks3.Location = 83;
            c1GaugeMarks3.ViewTag = ((long)(639653350254137302));
            c1GaugeMarks3.Width = 0.15;
            c1GaugeLabels1.Color = System.Drawing.Color.DarkSlateGray;
            c1GaugeLabels1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeLabels1.FontSize = 2.1;
            c1GaugeLabels1.Interval = 10;
            c1GaugeLabels1.IsRotated = true;
            c1GaugeLabels1.Location = 89;
            c1GaugeLabels1.ViewTag = ((long)(639934825230857959));
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeMarks1,
            c1GaugeMarks2,
            c1GaugeMarks3,
            c1GaugeLabels1});
            c1GaugeSector1.Border.Color = System.Drawing.Color.DarkSeaGreen;
            c1GaugeSector1.Border.Thickness = 0.5;
            c1GaugeSector1.CenterRadius = 3;
            c1GaugeSector1.CornerRadius = 2;
            c1GaugeSector1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeSector1.Filling.Color = System.Drawing.Color.Lavender;
            c1GaugeSector1.Filling.Color2 = System.Drawing.Color.LightSlateGray;
            c1GaugeSector1.Filling.SwapColors = true;
            c1GaugeSector1.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialInner;
            c1GaugeSector1.Gradient.Falloff = C1.Win.C1Gauge.C1GaugeGradientFalloff.Triangular;
            c1GaugeSector1.Gradient.ScaleY = 0.5;
            c1GaugeSector1.InnerOffset = -150;
            c1GaugeSector1.InnerRadius = 220;
            c1GaugeSector1.Name = "sc";
            c1GaugeSector1.OuterRadius = 93;
            c1GaugeSector1.StartAngle = -15;
            c1GaugeSector1.SweepAngle = 30;
            this.c1RadialGauge1.FaceShapes.AddRange(new C1.Win.C1Gauge.C1GaugeBaseShape[] {
            c1GaugeSector1});
            this.c1RadialGauge1.Maximum = 30;
            this.c1RadialGauge1.Minimum = -30;
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            this.c1RadialGauge1.Pointer.Clippings.AddRange(new C1.Win.C1Gauge.C1GaugeClipping[] {
            new C1.Win.C1Gauge.C1GaugeClipping("sc", C1.Win.C1Gauge.C1GaugeClipOperation.Intersect, 1.01)});
            this.c1RadialGauge1.Pointer.CustomShape.EndAngle = 75;
            this.c1RadialGauge1.Pointer.CustomShape.EndRadius = 0.1;
            this.c1RadialGauge1.Pointer.CustomShape.EndSwellAngle = 45;
            this.c1RadialGauge1.Pointer.CustomShape.EndSwellWidth = 0.7;
            this.c1RadialGauge1.Pointer.CustomShape.EndWidth = 0.6;
            this.c1RadialGauge1.Pointer.CustomShape.StartWidth = 0.6;
            this.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.DarkSlateGray;
            this.c1RadialGauge1.Pointer.Length = 23;
            this.c1RadialGauge1.Pointer.Offset = 60;
            this.c1RadialGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom;
            this.c1RadialGauge1.Pointer.SweepTime = 5;
            this.c1RadialGauge1.Pointer.Value = 7;
            this.c1RadialGauge1.PointerOriginY = 3.5;
            this.c1RadialGauge1.Radius = 3.7;
            this.c1RadialGauge1.StartAngle = -15;
            this.c1RadialGauge1.SweepAngle = 30;
            this.c1RadialGauge1.Viewport.AspectPinY = 0.3;
            this.c1RadialGauge1.Viewport.AspectRatio = 2.1;
            this.c1RadialGauge1.ViewTag = ((long)(640497775184369276));
            // 
            // PageGageDial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageGageDial";
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
