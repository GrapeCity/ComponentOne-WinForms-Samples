namespace GaugeDemo
{
    partial class PageInteractive
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
            C1.Win.Gauge.CommonColorMap commonColorMap1 = new C1.Win.Gauge.CommonColorMap();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.Gauge.C1GaugeLabels();
            C1.Win.Gauge.C1GaugeSingleMark c1GaugeSingleMark1 = new C1.Win.Gauge.C1GaugeSingleMark();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeEllipse c1GaugeEllipse1 = new C1.Win.Gauge.C1GaugeEllipse();
            C1.Win.Gauge.C1GaugeEllipse c1GaugeEllipse2 = new C1.Win.Gauge.C1GaugeEllipse();
            C1.Win.Gauge.C1GaugeEllipse c1GaugeEllipse3 = new C1.Win.Gauge.C1GaugeEllipse();
            C1.Win.Gauge.C1GaugeRectangle c1GaugeRectangle1 = new C1.Win.Gauge.C1GaugeRectangle();
            this.C1Gauge1 = new C1.Win.Gauge.C1Gauge();
            this.C1RadialGauge1 = new C1.Win.Gauge.C1RadialGauge();
            this.gaugePanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1Gauge1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugePanel
            // 
            this.gaugePanel.Controls.Add(this.C1Gauge1);
            // 
            // gaugeGrid
            // 
            this.gaugeGrid.SelectedObject = this.C1RadialGauge1;
            // 
            // C1Gauge1
            // 
            this.C1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.C1Gauge1.Gauges.AddRange(new C1.Win.Gauge.C1GaugeBase[] {
            this.C1RadialGauge1});
            this.C1Gauge1.Location = new System.Drawing.Point(15, 15);
            this.C1Gauge1.Name = "C1Gauge1";
            this.C1Gauge1.Size = new System.Drawing.Size(361, 406);
            this.C1Gauge1.TabIndex = 1;
            this.C1Gauge1.ViewTag = ((long)(638369401555506787));
            // 
            // C1RadialGauge1
            // 
            this.C1RadialGauge1.Cap.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            this.C1RadialGauge1.Cap.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            this.C1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.LightSkyBlue;
            this.C1RadialGauge1.Cap.Filling.Color2 = System.Drawing.Color.Black;
            this.C1RadialGauge1.Cap.HitTestable = false;
            this.C1RadialGauge1.Cap.Radius = 30;
            this.C1RadialGauge1.Cap.Shadow.Visible = true;
            commonColorMap1.Name = "rangeColors";
            commonColorMap1.ValueColors.AddRange(new C1.Win.Gauge.C1GaugeValueColor[] {
            new C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.LightSkyBlue, 1, ((long)(637241566911221021))),
            new C1.Win.Gauge.C1GaugeValueColor(30, -1, System.Drawing.Color.LimeGreen, 1, ((long)(637523042084282907))),
            new C1.Win.Gauge.C1GaugeValueColor(60, -1, System.Drawing.Color.Yellow, 1, ((long)(640057159105629385))),
            new C1.Win.Gauge.C1GaugeValueColor(100, -1, System.Drawing.Color.OrangeRed, 1, ((long)(637804517159929222)))});
            commonColorMap1.ViewTag = ((long)(636960091733788884));
            this.C1RadialGauge1.ColorMaps.AddRange(new C1.Win.Gauge.CommonColorMap[] {
            commonColorMap1});
            c1GaugeRange1.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeRange1.AntiAliasing = C1.Win.Gauge.C1GaugeRangeAntiAliasing.LowQuality;
            c1GaugeRange1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeRange1.ColorMapName = "rangeColors";
            c1GaugeRange1.HitTestable = false;
            c1GaugeRange1.Location = 61;
            c1GaugeRange1.ViewTag = ((long)(636678616231258153));
            c1GaugeMarks1.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeMarks1.HitTestable = false;
            c1GaugeMarks1.Interval = 10;
            c1GaugeMarks1.Length = 20;
            c1GaugeMarks1.Location = 60;
            c1GaugeMarks1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks1.ViewTag = ((long)(635271056971997689));
            c1GaugeMarks1.Width = 3;
            c1GaugeMarks2.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.DimGray;
            c1GaugeMarks2.HitTestable = false;
            c1GaugeMarks2.Interval = 2.5;
            c1GaugeMarks2.Location = 60;
            c1GaugeMarks2.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks2.ViewTag = ((long)(635552533455524530));
            c1GaugeMarks2.Width = 3;
            c1GaugeLabels1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeLabels1.FontSize = 10;
            c1GaugeLabels1.HitTestable = false;
            c1GaugeLabels1.Interval = 10;
            c1GaugeLabels1.IsRotated = true;
            c1GaugeLabels1.Location = 89;
            c1GaugeLabels1.ViewTag = ((long)(636115488361649120));
            c1GaugeSingleMark1.Angle = 0;
            c1GaugeSingleMark1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark1.Clippings.AddRange(new C1.Win.Gauge.C1GaugeClipping[] {
            new C1.Win.Gauge.C1GaugeClipping("face", C1.Win.Gauge.C1GaugeClipOperation.Exclude, 1)});
            c1GaugeSingleMark1.ColorMapName = "rangeColors";
            c1GaugeSingleMark1.Filling.Color = System.Drawing.Color.DarkGray;
            c1GaugeSingleMark1.HitTestable = false;
            c1GaugeSingleMark1.Length = 212;
            c1GaugeSingleMark1.Location = 0;
            c1GaugeSingleMark1.PointerIndex = 100;
            c1GaugeSingleMark1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round;
            c1GaugeSingleMark1.ViewTag = ((long)(636396980395055364));
            c1GaugeSingleMark1.Width = 212;
            c1GaugeSingleLabel1.Angle = 180;
            c1GaugeSingleLabel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeSingleLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            c1GaugeSingleLabel1.FontSize = 10;
            c1GaugeSingleLabel1.Format = "0.0";
            c1GaugeSingleLabel1.HitTestable = false;
            c1GaugeSingleLabel1.Location = 76;
            c1GaugeSingleLabel1.PointerIndex = 100;
            c1GaugeSingleLabel1.ViewTag = ((long)(639774705812283003));
            this.C1RadialGauge1.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeRange1,
            c1GaugeMarks1,
            c1GaugeMarks2,
            c1GaugeLabels1,
            c1GaugeSingleMark1,
            c1GaugeSingleLabel1});
            c1GaugeEllipse1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeEllipse1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            c1GaugeEllipse1.Filling.Color = System.Drawing.Color.White;
            c1GaugeEllipse1.Filling.Color2 = System.Drawing.Color.DarkSlateBlue;
            c1GaugeEllipse1.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.BackwardDiagonal;
            c1GaugeEllipse1.Gradient.Falloff = C1.Win.Gauge.C1GaugeGradientFalloff.Triangular;
            c1GaugeEllipse1.Height = 224;
            c1GaugeEllipse1.Name = "back";
            c1GaugeEllipse1.Width = 224;
            c1GaugeEllipse2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeEllipse2.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            c1GaugeEllipse2.Filling.Color = System.Drawing.Color.RoyalBlue;
            c1GaugeEllipse2.Filling.Color2 = System.Drawing.Color.White;
            c1GaugeEllipse2.HitTestable = false;
            c1GaugeEllipse2.Name = "face";
            c1GaugeEllipse3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeEllipse3.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            c1GaugeEllipse3.Filling.Color = System.Drawing.Color.DarkSlateBlue;
            c1GaugeEllipse3.Filling.Color2 = System.Drawing.Color.WhiteSmoke;
            c1GaugeEllipse3.Filling.SwapColors = true;
            c1GaugeEllipse3.Height = 100;
            c1GaugeEllipse3.HitTestable = false;
            c1GaugeEllipse3.Width = 100;
            c1GaugeRectangle1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeRectangle1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeRectangle1.Border.Thickness = 0.5;
            c1GaugeRectangle1.CenterPointY = 0.88;
            c1GaugeRectangle1.CornerRadius = 5;
            c1GaugeRectangle1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Hatch;
            c1GaugeRectangle1.Filling.Color = System.Drawing.Color.Transparent;
            c1GaugeRectangle1.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugeRectangle1.Filling.HatchStyle = C1.Win.Gauge.C1GaugeHatchStyle.NarrowHorizontal;
            c1GaugeRectangle1.Height = 16;
            c1GaugeRectangle1.HitTestable = false;
            c1GaugeRectangle1.Width = 34;
            this.C1RadialGauge1.FaceShapes.AddRange(new C1.Win.Gauge.C1GaugeBaseShape[] {
            c1GaugeEllipse1,
            c1GaugeEllipse2,
            c1GaugeEllipse3,
            c1GaugeRectangle1});
            this.C1RadialGauge1.Name = "C1RadialGauge1";
            this.C1RadialGauge1.OffAngle = -180;
            this.C1RadialGauge1.Pointer.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            this.C1RadialGauge1.Pointer.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            this.C1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.Black;
            this.C1RadialGauge1.Pointer.Filling.Color2 = System.Drawing.Color.LightBlue;
            this.C1RadialGauge1.Pointer.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.Vertical;
            this.C1RadialGauge1.Pointer.HitTestable = false;
            this.C1RadialGauge1.Pointer.Length = 30;
            this.C1RadialGauge1.Pointer.Offset = 28;
            this.C1RadialGauge1.Pointer.Shadow.Visible = true;
            this.C1RadialGauge1.Pointer.Width = 12;
            this.C1RadialGauge1.Radius = 0.44;
            this.C1RadialGauge1.StartAngle = -150;
            this.C1RadialGauge1.SweepAngle = 300;
            this.C1RadialGauge1.ViewTag = ((long)(636959884989692302));
            this.C1RadialGauge1.ItemMouseDown += new C1.Win.Gauge.ItemMouseEventHandler(this.c1RadialGauge1_ItemMouseMove);
            this.C1RadialGauge1.ItemMouseMove += new C1.Win.Gauge.ItemMouseEventHandler(this.c1RadialGauge1_ItemMouseMove);
            this.C1RadialGauge1.FormatLabel += new C1.Win.Gauge.FormatLabelEventHandler(this.c1RadialGauge1_FormatLabel);
            // 
            // PageInteractive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.Name = "PageInteractive";
            this.gaugePanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.C1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal C1.Win.Gauge.C1Gauge C1Gauge1;
        internal C1.Win.Gauge.C1RadialGauge C1RadialGauge1;
    }
}
