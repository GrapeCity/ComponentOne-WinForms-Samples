namespace GaugeDemo
{
    partial class PageLogarithmic
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
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeSingleMark c1GaugeSingleMark1 = new C1.Win.C1Gauge.C1GaugeSingleMark();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeEllipse c1GaugeEllipse1 = new C1.Win.C1Gauge.C1GaugeEllipse();
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
            this.c1Gauge1.Location = new System.Drawing.Point(19, 17);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(353, 374);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(638528936816453066));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.BehindPointers = true;
            this.c1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            c1GaugeMarks1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.Red;
            c1GaugeMarks1.Interval = 3;
            c1GaugeMarks1.Length = 10;
            c1GaugeMarks1.Location = 73;
            c1GaugeMarks1.ViewTag = ((long)(636840086956049122));
            c1GaugeMarks1.Width = 2;
            c1GaugeMarks2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.Gray;
            c1GaugeMarks2.Interval = 3;
            c1GaugeMarks2.IntervalCoeff = 10;
            c1GaugeMarks2.Length = 10;
            c1GaugeMarks2.Location = 73;
            c1GaugeMarks2.ViewTag = ((long)(637121561932769779));
            c1GaugeMarks2.Width = 2;
            c1GaugeLabels1.AllowFlip = true;
            c1GaugeLabels1.Color = System.Drawing.Color.WhiteSmoke;
            c1GaugeLabels1.FontSize = 12;
            c1GaugeLabels1.Interval = 3;
            c1GaugeLabels1.IsRotated = true;
            c1GaugeLabels1.Location = 58;
            c1GaugeLabels1.Name = "scale";
            c1GaugeLabels1.ViewTag = ((long)(637403036909480435));
            c1GaugeSingleMark1.AlignmentOffset = 1;
            c1GaugeSingleMark1.Border.Color = System.Drawing.Color.RosyBrown;
            c1GaugeSingleMark1.CustomShape.EndRadius = 5;
            c1GaugeSingleMark1.CustomShape.EndWidth = 22;
            c1GaugeSingleMark1.CustomShape.ScaleEndRadius = false;
            c1GaugeSingleMark1.CustomShape.ScaleStartRadius = false;
            c1GaugeSingleMark1.CustomShape.StartRadius = 5;
            c1GaugeSingleMark1.CustomShape.StartWidth = 22;
            c1GaugeSingleMark1.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            c1GaugeSingleMark1.Length = 13;
            c1GaugeSingleMark1.Location = 88;
            c1GaugeSingleMark1.PointerIndex = 100;
            c1GaugeSingleMark1.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Custom;
            c1GaugeSingleMark1.ViewTag = ((long)(637684511886201091));
            c1GaugeSingleLabel1.AllowFlip = true;
            c1GaugeSingleLabel1.Color = System.Drawing.Color.Black;
            c1GaugeSingleLabel1.FontSize = 7;
            c1GaugeSingleLabel1.Format = "####0";
            c1GaugeSingleLabel1.IsRotated = true;
            c1GaugeSingleLabel1.Location = 88;
            c1GaugeSingleLabel1.PointerIndex = 100;
            c1GaugeSingleLabel1.ViewTag = ((long)(637965986862951750));
            c1GaugeRange1.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            c1GaugeRange1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeRange1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeRange1.Filling.Color = System.Drawing.Color.IndianRed;
            c1GaugeRange1.Filling.Color2 = System.Drawing.Color.White;
            c1GaugeRange1.Filling.SwapColors = true;
            c1GaugeRange1.From = 128;
            c1GaugeRange1.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.Horizontal;
            c1GaugeRange1.Gradient.ScaleX = 0.37;
            c1GaugeRange1.Gradient.TranslateX = 0.65;
            c1GaugeRange1.Location = 50;
            c1GaugeRange1.ViewTag = ((long)(638247461839692407));
            c1GaugeRange1.Width = 1;
            c1GaugeRange1.Width2 = 20;
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeMarks1,
            c1GaugeMarks2,
            c1GaugeLabels1,
            c1GaugeSingleMark1,
            c1GaugeSingleLabel1,
            c1GaugeRange1});
            c1GaugeEllipse1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeEllipse1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeEllipse1.Filling.Color = System.Drawing.Color.Black;
            c1GaugeEllipse1.Filling.Color2 = System.Drawing.Color.Gray;
            this.c1RadialGauge1.FaceShapes.AddRange(new C1.Win.C1Gauge.C1GaugeBaseShape[] {
            c1GaugeEllipse1});
            this.c1RadialGauge1.IsLogarithmic = true;
            this.c1RadialGauge1.LogarithmicBase = 2;
            this.c1RadialGauge1.Maximum = 4096;
            this.c1RadialGauge1.Minimum = 1;
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.Salmon;
            this.c1RadialGauge1.Pointer.Length = 100;
            this.c1RadialGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Arrow1;
            this.c1RadialGauge1.Pointer.SweepTime = 2;
            this.c1RadialGauge1.Pointer.Value = 18;
            this.c1RadialGauge1.Pointer.Width = 5;
            this.c1RadialGauge1.ViewTag = ((long)(638810411793193724));
            // 
            // PageCase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageCase1";
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
