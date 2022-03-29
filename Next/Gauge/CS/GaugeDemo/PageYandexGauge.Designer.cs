namespace GaugeDemo
{
    partial class PageYandexGauge
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
            C1.Win.Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel2 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel3 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeSegment c1GaugeSegment1 = new C1.Win.Gauge.C1GaugeSegment();
            this.c1Gauge1 = new C1.Win.Gauge.C1Gauge();
            this.c1RadialGauge1 = new C1.Win.Gauge.C1RadialGauge();
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
            // c1Gauge1
            // 
            this.c1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Gauge1.Gauges.AddRange(new C1.Win.Gauge.C1GaugeBase[] {
            this.c1RadialGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(12, 12);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(367, 412);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(637779738145036078));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.BehindPointers = true;
            this.c1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.Black;
            this.c1RadialGauge1.Cap.HitTestable = false;
            this.c1RadialGauge1.Cap.Radius = 15;
            c1GaugeRange1.Alignment = C1.Win.Gauge.C1GaugeAlignment.In;
            c1GaugeRange1.AntiAliasing = C1.Win.Gauge.C1GaugeRangeAntiAliasing.HighQuality;
            c1GaugeRange1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeRange1.Location = 85;
            c1GaugeRange1.ValueColors.AddRange(new C1.Win.Gauge.C1GaugeValueColor[] {
            new C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Gold, 1, ((long)(636371842368652348))),
            new C1.Win.Gauge.C1GaugeValueColor(100, -1, System.Drawing.Color.Red, 1, ((long)(636653317568599396)))});
            c1GaugeRange1.ViewTag = ((long)(636090364653824882));
            c1GaugeRange1.Width = 0;
            c1GaugeRange1.Width2 = 21;
            c1GaugeSingleLabel1.Angle = -72;
            c1GaugeSingleLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            c1GaugeSingleLabel1.FontSize = 14;
            c1GaugeSingleLabel1.Location = 80;
            c1GaugeSingleLabel1.Text = "0";
            c1GaugeSingleLabel1.ViewTag = ((long)(637216281821005865));
            c1GaugeSingleLabel2.Angle = 88;
            c1GaugeSingleLabel2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            c1GaugeSingleLabel2.FontSize = 20;
            c1GaugeSingleLabel2.Location = 76;
            c1GaugeSingleLabel2.Text = "∞";
            c1GaugeSingleLabel2.ViewTag = ((long)(637497758063980745));
            c1GaugeSingleLabel3.Angle = 0;
            c1GaugeSingleLabel3.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            c1GaugeSingleLabel3.FontSize = 14;
            c1GaugeSingleLabel3.Location = 26;
            c1GaugeSingleLabel3.Text = "Mb/s";
            c1GaugeSingleLabel3.ViewTag = ((long)(637779236517313508));
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeRange1,
            c1GaugeSingleLabel1,
            c1GaugeSingleLabel2,
            c1GaugeSingleLabel3});
            c1GaugeSegment1.Border.Thickness = 1.5;
            c1GaugeSegment1.CornerRadius = 3;
            c1GaugeSegment1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Hatch;
            c1GaugeSegment1.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            c1GaugeSegment1.Filling.HatchStyle = C1.Win.Gauge.C1GaugeHatchStyle.SmallGrid;
            c1GaugeSegment1.InnerRadius = 800;
            c1GaugeSegment1.StartAngle = -105;
            c1GaugeSegment1.SweepAngle = 210;
            this.c1RadialGauge1.FaceShapes.AddRange(new C1.Win.Gauge.C1GaugeBaseShape[] {
            c1GaugeSegment1});
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.DarkRed;
            this.c1RadialGauge1.Pointer.Border.Thickness = 0.5;
            this.c1RadialGauge1.Pointer.CustomShape.EndRadius = 0.5;
            this.c1RadialGauge1.Pointer.CustomShape.EndWidth = 1;
            this.c1RadialGauge1.Pointer.CustomShape.StartAngle = 50;
            this.c1RadialGauge1.Pointer.CustomShape.StartWidth = 10;
            this.c1RadialGauge1.Pointer.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            this.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.Pink;
            this.c1RadialGauge1.Pointer.Filling.Color2 = System.Drawing.Color.Red;
            this.c1RadialGauge1.Pointer.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.Horizontal;
            this.c1RadialGauge1.Pointer.Gradient.Falloff = C1.Win.Gauge.C1GaugeGradientFalloff.SigmaBell;
            this.c1RadialGauge1.Pointer.Gradient.ScaleX = 2;
            this.c1RadialGauge1.Pointer.HitTestable = false;
            this.c1RadialGauge1.Pointer.Length = 85;
            this.c1RadialGauge1.Pointer.Offset = -2;
            this.c1RadialGauge1.Pointer.Shadow.Visible = true;
            this.c1RadialGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom;
            this.c1RadialGauge1.Pointer.Value = 70;
            this.c1RadialGauge1.PointerOriginY = 0.786;
            this.c1RadialGauge1.Radius = 0.77;
            this.c1RadialGauge1.StartAngle = -60;
            this.c1RadialGauge1.SweepAngle = 140;
            this.c1RadialGauge1.Viewport.AspectPinX = 0.5;
            this.c1RadialGauge1.Viewport.AspectPinY = 0.5;
            this.c1RadialGauge1.Viewport.AspectRatio = 1.58;
            this.c1RadialGauge1.ViewTag = ((long)(637777636476463374));
            this.c1RadialGauge1.ItemMouseDown += new C1.Win.Gauge.ItemMouseEventHandler(this.c1RadialGauge1_ItemMouseMove);
            this.c1RadialGauge1.ItemMouseMove += new C1.Win.Gauge.ItemMouseEventHandler(this.c1RadialGauge1_ItemMouseMove);
            // 
            // PageYandexGauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.Name = "PageYandexGauge";
            this.gaugePanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Gauge.C1Gauge c1Gauge1;
        private C1.Win.Gauge.C1RadialGauge c1RadialGauge1;
    }
}
