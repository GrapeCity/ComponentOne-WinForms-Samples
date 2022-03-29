namespace GaugeDemo
{
    partial class PageInclined
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
            C1.Win.Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange2 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.Gauge.C1GaugeLabels();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks3 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeLabels c1GaugeLabels2 = new C1.Win.Gauge.C1GaugeLabels();
            this.c1Gauge1 = new C1.Win.Gauge.C1Gauge();
            this.c1LinearGauge1 = new C1.Win.Gauge.C1LinearGauge();
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
            this.gaugeGrid.SelectedObject = this.c1LinearGauge1;
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
            this.c1Gauge1.Gauges.AddRange(new C1.Win.Gauge.C1GaugeBase[] {
            this.c1LinearGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(12, 17);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(368, 404);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(640217874461468003));
            // 
            // c1LinearGauge1
            // 
            this.c1LinearGauge1.AxisLength = 0.93;
            c1GaugeRange1.AdjustAngle = true;
            c1GaugeRange1.AntiAliasing = C1.Win.Gauge.C1GaugeRangeAntiAliasing.HighQuality;
            c1GaugeRange1.Border.Color = System.Drawing.Color.Purple;
            c1GaugeRange1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeRange1.Location = 50;
            c1GaugeRange1.Location2 = 65;
            c1GaugeRange1.ScaleFrom = 0;
            c1GaugeRange1.ScaleTo = 100;
            c1GaugeRange1.ToPointerIndex = 100;
            c1GaugeRange1.ValueColors.AddRange(new C1.Win.Gauge.C1GaugeValueColor[] {
            new C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Blue, 1, ((long)(636558699764029463))),
            new C1.Win.Gauge.C1GaugeValueColor(25, -1, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))), 1, ((long)(636840174740750120))),
            new C1.Win.Gauge.C1GaugeValueColor(50, -1, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))), 1, ((long)(637121649717460776))),
            new C1.Win.Gauge.C1GaugeValueColor(75, -1, System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))), 1, ((long)(637403124694171432))),
            new C1.Win.Gauge.C1GaugeValueColor(100, -1, System.Drawing.Color.Red, 1, ((long)(637684599670882088)))});
            c1GaugeRange1.ViewTag = ((long)(636277224787288805));
            c1GaugeRange2.AdjustAngle = true;
            c1GaugeRange2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            c1GaugeRange2.Border.Thickness = 1;
            c1GaugeRange2.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.None;
            c1GaugeRange2.Location = 50;
            c1GaugeRange2.Location2 = 65;
            c1GaugeRange2.ViewTag = ((long)(637966074647592744));
            c1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            c1GaugeMarks1.Interval = 5;
            c1GaugeMarks1.Location = 35;
            c1GaugeMarks1.Location2 = 15;
            c1GaugeMarks1.OrthogonalOffset = 2;
            c1GaugeMarks1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks1.ShapeAngle = -10;
            c1GaugeMarks1.ViewTag = ((long)(638247549624303400));
            c1GaugeLabels1.Color = System.Drawing.Color.White;
            c1GaugeLabels1.FontSize = 4;
            c1GaugeLabels1.Format = "n1";
            c1GaugeLabels1.Interval = 5;
            c1GaugeLabels1.Location = 35;
            c1GaugeLabels1.Location2 = 15;
            c1GaugeLabels1.OrthogonalOffset = 2;
            c1GaugeLabels1.TextAngle = -10;
            c1GaugeLabels1.ViewTag = ((long)(638529024601034057));
            c1GaugeMarks2.IntervalWidth = 5;
            c1GaugeMarks2.Length = 10;
            c1GaugeMarks2.Location = 65;
            c1GaugeMarks2.Location2 = 85;
            c1GaugeMarks2.OrthogonalOffset = 4;
            c1GaugeMarks2.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks2.ToPointerIndex = 100;
            c1GaugeMarks2.ValueColors.AddRange(new C1.Win.Gauge.C1GaugeValueColor[] {
            new C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.White, 1, ((long)(639091974554465369))),
            new C1.Win.Gauge.C1GaugeValueColor(double.NaN, 100, System.Drawing.Color.Purple, 1, ((long)(639373449531306033)))});
            c1GaugeMarks2.ViewTag = ((long)(638810499577754713));
            c1GaugeMarks2.Width = 10;
            c1GaugeMarks3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks3.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            c1GaugeMarks3.Interval = 10;
            c1GaugeMarks3.Length = 10;
            c1GaugeMarks3.Location = 95;
            c1GaugeMarks3.SequenceNo = 1;
            c1GaugeMarks3.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks3.ViewTag = ((long)(639654924508026690));
            c1GaugeMarks3.Width = 0.5;
            c1GaugeLabels2.FontSize = 4;
            c1GaugeLabels2.Interval = 10;
            c1GaugeLabels2.Location = 95;
            c1GaugeLabels2.OrthogonalOffset = 3;
            c1GaugeLabels2.SequenceNo = 1;
            c1GaugeLabels2.ViewTag = ((long)(639936399484737346));
            this.c1LinearGauge1.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeRange1,
            c1GaugeRange2,
            c1GaugeMarks1,
            c1GaugeLabels1,
            c1GaugeMarks2,
            c1GaugeMarks3,
            c1GaugeLabels2});
            this.c1LinearGauge1.IsReversed = true;
            this.c1LinearGauge1.Name = "c1LinearGauge1";
            this.c1LinearGauge1.Orientation = C1.Win.Gauge.C1GaugeOrientation.Vertical;
            this.c1LinearGauge1.Pointer.Alignment = C1.Win.Gauge.C1GaugeAlignment.In;
            this.c1LinearGauge1.Pointer.Border.Color = System.Drawing.Color.MediumOrchid;
            this.c1LinearGauge1.Pointer.CustomShape.EndAngle = 68;
            this.c1LinearGauge1.Pointer.CustomShape.EndWidth = 4;
            this.c1LinearGauge1.Pointer.CustomShape.StartAngle = 68;
            this.c1LinearGauge1.Pointer.CustomShape.StartWidth = 4;
            this.c1LinearGauge1.Pointer.Filling.Color = System.Drawing.Color.MediumSeaGreen;
            this.c1LinearGauge1.Pointer.Length = 10;
            this.c1LinearGauge1.Pointer.Offset = 25;
            this.c1LinearGauge1.Pointer.Offset2 = 5;
            this.c1LinearGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom;
            this.c1LinearGauge1.Pointer.ShapeAngle = -10;
            this.c1LinearGauge1.Pointer.SweepTime = 5;
            this.c1LinearGauge1.Pointer.Value = 50;
            this.c1LinearGauge1.Viewport.AspectRatio = 0.9;
            this.c1LinearGauge1.ViewTag = ((long)(640499349438208660));
            // 
            // PageCase4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageCase4";
            this.gaugePanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Gauge.C1Gauge c1Gauge1;
        private C1.Win.Gauge.C1LinearGauge c1LinearGauge1;
    }
}
