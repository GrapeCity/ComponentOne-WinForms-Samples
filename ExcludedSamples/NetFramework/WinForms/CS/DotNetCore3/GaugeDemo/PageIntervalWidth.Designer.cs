namespace GaugeDemo
{
    partial class PageIntervalWidth
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
            C1.Win.C1Gauge.C1GaugeCaption c1GaugeCaption1 = new C1.Win.C1Gauge.C1GaugeCaption();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks3 = new C1.Win.C1Gauge.C1GaugeMarks();
            this.c1Gauge1 = new C1.Win.C1Gauge.C1Gauge();
            this.c1RadialGauge1 = new C1.Win.C1Gauge.C1RadialGauge();
            this.c1LinearGauge1 = new C1.Win.C1Gauge.C1LinearGauge();
            this.c1LinearGauge2 = new C1.Win.C1Gauge.C1LinearGauge();
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
            this.gaugeGrid.SelectedObject = this.c1Gauge1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Gauge1.BackColor = System.Drawing.Color.LightSalmon;
            c1GaugeCaption1.Alignment = System.Drawing.StringAlignment.Near;
            c1GaugeCaption1.Height = -1;
            c1GaugeCaption1.LineAlignment = System.Drawing.StringAlignment.Near;
            c1GaugeCaption1.Text = "Space between tick marks remains unchanged when resizing the container control";
            c1GaugeCaption1.Viewport.MarginX = 35;
            c1GaugeCaption1.Viewport.TranslateY = 0.05;
            c1GaugeCaption1.Viewport.Y = 36;
            c1GaugeCaption1.Width = -1;
            this.c1Gauge1.FaceShapes.AddRange(new C1.Win.C1Gauge.C1GaugeBaseShape[] {
            c1GaugeCaption1});
            this.c1Gauge1.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1RadialGauge1,
            this.c1LinearGauge1,
            this.c1LinearGauge2});
            this.c1Gauge1.Location = new System.Drawing.Point(3, 3);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(385, 430);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(643314165155657364));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            this.c1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.DarkSlateBlue;
            this.c1RadialGauge1.Cap.Radius = 8;
            c1GaugeMarks1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.Gray;
            c1GaugeMarks1.IntervalWidth = 10;
            c1GaugeMarks1.Length = 10;
            c1GaugeMarks1.Location = 90;
            c1GaugeMarks1.SequenceNo = -1;
            c1GaugeMarks1.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks1.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None;
            c1GaugeMarks1.ValueColors.AddRange(new C1.Win.C1Gauge.C1GaugeValueColor[] {
            new C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Red, 1, ((long)(641062365341942114))),
            new C1.Win.C1Gauge.C1GaugeValueColor(double.NaN, 100, System.Drawing.Color.Gray, 1, ((long)(641343840318652770)))});
            c1GaugeMarks1.ViewTag = ((long)(640780890365211457));
            c1GaugeMarks1.Width = 10;
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeMarks1});
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            this.c1RadialGauge1.Pointer.CustomShape.EndRadius = 1;
            this.c1RadialGauge1.Pointer.CustomShape.EndWidth = 2;
            this.c1RadialGauge1.Pointer.CustomShape.StartWidth = 6;
            this.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.White;
            this.c1RadialGauge1.Pointer.Length = 80;
            this.c1RadialGauge1.Pointer.Offset = 0;
            this.c1RadialGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom;
            this.c1RadialGauge1.Pointer.SweepTime = 4;
            this.c1RadialGauge1.Pointer.Value = 70;
            this.c1RadialGauge1.PointerOriginY = 0.53;
            this.c1RadialGauge1.Radius = 0.5;
            this.c1RadialGauge1.StartAngle = -170;
            this.c1RadialGauge1.SweepAngle = 340;
            this.c1RadialGauge1.Viewport.ScaleX = 0.6;
            this.c1RadialGauge1.Viewport.ScaleY = 0.6;
            this.c1RadialGauge1.Viewport.TranslateX = 0.2;
            this.c1RadialGauge1.Viewport.TranslateY = 0.2;
            this.c1RadialGauge1.ViewTag = ((long)(643595640132398022));
            // 
            // c1LinearGauge1
            // 
            this.c1LinearGauge1.AxisLength = 1;
            this.c1LinearGauge1.AxisStart = 0;
            this.c1LinearGauge1.BaseFactor = 1;
            this.c1LinearGauge1.BaseOrigin = 0;
            c1GaugeMarks2.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.Gray;
            c1GaugeMarks2.IntervalWidth = 30;
            c1GaugeMarks2.Length = 100;
            c1GaugeMarks2.Location = 0;
            c1GaugeMarks2.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks2.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None;
            c1GaugeMarks2.ValueColors.AddRange(new C1.Win.C1Gauge.C1GaugeValueColor[] {
            new C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Green, 1, ((long)(641906790272084083))),
            new C1.Win.C1Gauge.C1GaugeValueColor(double.NaN, 100, System.Drawing.Color.Gray, 1, ((long)(642188265248794739)))});
            c1GaugeMarks2.ViewTag = ((long)(641625315295363426));
            c1GaugeMarks2.Width = 20;
            this.c1LinearGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeMarks2});
            this.c1LinearGauge1.Name = "c1LinearGauge1";
            this.c1LinearGauge1.Pointer.SweepTime = 5;
            this.c1LinearGauge1.Pointer.Value = 30;
            this.c1LinearGauge1.Pointer.Visible = false;
            this.c1LinearGauge1.Viewport.Height = 30;
            this.c1LinearGauge1.Viewport.MarginX = 39;
            this.c1LinearGauge1.Viewport.TranslateY = 0.05;
            this.c1LinearGauge1.ViewTag = ((long)(644158590085879337));
            // 
            // c1LinearGauge2
            // 
            this.c1LinearGauge2.AxisLength = 1;
            this.c1LinearGauge2.AxisStart = 0;
            this.c1LinearGauge2.BaseFactor = 1;
            this.c1LinearGauge2.BaseOrigin = 0;
            c1GaugeMarks3.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks3.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks3.Filling.Color = System.Drawing.Color.Gray;
            c1GaugeMarks3.IntervalWidth = 30;
            c1GaugeMarks3.Length = 100;
            c1GaugeMarks3.Location = 0;
            c1GaugeMarks3.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks3.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None;
            c1GaugeMarks3.ValueColors.AddRange(new C1.Win.C1Gauge.C1GaugeValueColor[] {
            new C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.MidnightBlue, 1, ((long)(642751215202216051))),
            new C1.Win.C1Gauge.C1GaugeValueColor(double.NaN, 100, System.Drawing.Color.Gray, 1, ((long)(643032690178926707)))});
            c1GaugeMarks3.ViewTag = ((long)(642469740225505395));
            c1GaugeMarks3.Width = 20;
            this.c1LinearGauge2.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeMarks3});
            this.c1LinearGauge2.IsReversed = true;
            this.c1LinearGauge2.Name = "c1LinearGauge2";
            this.c1LinearGauge2.Pointer.SweepTime = 5;
            this.c1LinearGauge2.Pointer.Value = 30;
            this.c1LinearGauge2.Pointer.Visible = false;
            this.c1LinearGauge2.Viewport.Height = -30;
            this.c1LinearGauge2.Viewport.MarginX = 39;
            this.c1LinearGauge2.Viewport.ScaleY = 0.95;
            this.c1LinearGauge2.Viewport.Y = -30;
            this.c1LinearGauge2.ViewTag = ((long)(644721540039330651));
            // 
            // PageCase6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageCase6";
            this.gaugePanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Gauge.C1Gauge c1Gauge1;
        private C1.Win.C1Gauge.C1RadialGauge c1RadialGauge1;
        private C1.Win.C1Gauge.C1LinearGauge c1LinearGauge1;
        private C1.Win.C1Gauge.C1LinearGauge c1LinearGauge2;
    }
}
