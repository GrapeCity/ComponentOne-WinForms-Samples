namespace GaugeDemo
{
    partial class PageSwissRailwayClock
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
            C1.Win.Gauge.C1GaugeSingleMark c1GaugeSingleMark1 = new C1.Win.Gauge.C1GaugeSingleMark();
            C1.Win.Gauge.C1GaugeSingleMark c1GaugeSingleMark2 = new C1.Win.Gauge.C1GaugeSingleMark();
            C1.Win.Gauge.C1GaugeSingleMark c1GaugeSingleMark3 = new C1.Win.Gauge.C1GaugeSingleMark();
            C1.Win.Gauge.C1GaugeEllipse c1GaugeEllipse1 = new C1.Win.Gauge.C1GaugeEllipse();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer1 = new C1.Win.Gauge.C1GaugePointer();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer2 = new C1.Win.Gauge.C1GaugePointer();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer3 = new C1.Win.Gauge.C1GaugePointer();
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Gauge1.Gauges.AddRange(new C1.Win.Gauge.C1GaugeBase[] {
            this.c1RadialGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(16, 21);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(359, 396);
            this.c1Gauge1.TabIndex = 2;
            this.c1Gauge1.ViewTag = ((long)(637653654040177012));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Visible = false;
            c1GaugeMarks1.Alignment = C1.Win.Gauge.C1GaugeAlignment.In;
            c1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            c1GaugeMarks1.From = 0.5;
            c1GaugeMarks1.Interval = 5;
            c1GaugeMarks1.Length = 20;
            c1GaugeMarks1.Location = 89;
            c1GaugeMarks1.ScaleFrom = 0;
            c1GaugeMarks1.ViewTag = ((long)(634302468273582893));
            c1GaugeMarks1.Width = 6;
            c1GaugeMarks2.Alignment = C1.Win.Gauge.C1GaugeAlignment.In;
            c1GaugeMarks2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.Black;
            c1GaugeMarks2.From = 0.5;
            c1GaugeMarks2.Interval = 1;
            c1GaugeMarks2.Length = 7;
            c1GaugeMarks2.Location = 89;
            c1GaugeMarks2.ScaleFrom = 0;
            c1GaugeMarks2.ViewTag = ((long)(634583943250743575));
            c1GaugeMarks2.Width = 2.7;
            c1GaugeSingleMark1.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeSingleMark1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark1.CustomShape.EndWidth = 9.5;
            c1GaugeSingleMark1.CustomShape.StartWidth = 11;
            c1GaugeSingleMark1.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            c1GaugeSingleMark1.Length = 80;
            c1GaugeSingleMark1.Location = -23;
            c1GaugeSingleMark1.PointerIndex = 0;
            c1GaugeSingleMark1.Shadow.Visible = true;
            c1GaugeSingleMark1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Custom;
            c1GaugeSingleMark1.ViewTag = ((long)(649194152710971984));
            c1GaugeSingleMark2.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeSingleMark2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark2.CustomShape.EndWidth = 7.8;
            c1GaugeSingleMark2.CustomShape.StartWidth = 9.7;
            c1GaugeSingleMark2.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            c1GaugeSingleMark2.Length = 104;
            c1GaugeSingleMark2.Location = -21;
            c1GaugeSingleMark2.PointerIndex = 1;
            c1GaugeSingleMark2.Shadow.Visible = true;
            c1GaugeSingleMark2.Shape = C1.Win.Gauge.C1GaugeMarkShape.Custom;
            c1GaugeSingleMark2.ViewTag = ((long)(649475636021529278));
            c1GaugeSingleMark3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark3.Filling.Color = System.Drawing.Color.IndianRed;
            c1GaugeSingleMark3.Length = 16;
            c1GaugeSingleMark3.Location = 62;
            c1GaugeSingleMark3.PointerIndex = 2;
            c1GaugeSingleMark3.Shadow.Visible = true;
            c1GaugeSingleMark3.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round;
            c1GaugeSingleMark3.ViewTag = ((long)(684378357605785544));
            c1GaugeSingleMark3.Width = 16;
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeMarks1,
            c1GaugeMarks2,
            c1GaugeSingleMark1,
            c1GaugeSingleMark2,
            c1GaugeSingleMark3});
            c1GaugeEllipse1.Border.Color = System.Drawing.Color.DarkGray;
            c1GaugeEllipse1.Border.Thickness = 5;
            c1GaugeEllipse1.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            c1GaugeEllipse1.Height = -0.97;
            c1GaugeEllipse1.HitTestable = false;
            c1GaugeEllipse1.Width = -0.97;
            this.c1RadialGauge1.FaceShapes.AddRange(new C1.Win.Gauge.C1GaugeBaseShape[] {
            c1GaugeEllipse1});
            this.c1RadialGauge1.Maximum = 60;
            c1GaugePointer1.Name = "hours";
            c1GaugePointer1.Value = 0.42;
            c1GaugePointer1.ValueFactor = 5;
            c1GaugePointer1.ViewTag = ((long)(635146893204754921));
            c1GaugePointer1.Visible = false;
            c1GaugePointer2.Name = "minutes";
            c1GaugePointer2.Value = 22.3;
            c1GaugePointer2.ViewTag = ((long)(635428368181515579));
            c1GaugePointer2.Visible = false;
            c1GaugePointer3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugePointer3.Filling.Color = System.Drawing.Color.IndianRed;
            c1GaugePointer3.Name = "seconds";
            c1GaugePointer3.Offset = -30;
            c1GaugePointer3.Shadow.Visible = true;
            c1GaugePointer3.Shape = C1.Win.Gauge.C1GaugePointerShape.Rectangle;
            c1GaugePointer3.Value = 17;
            c1GaugePointer3.ViewTag = ((long)(635709843158236236));
            c1GaugePointer3.Width = 2.5;
            this.c1RadialGauge1.MorePointers.AddRange(new C1.Win.Gauge.C1GaugePointer[] {
            c1GaugePointer1,
            c1GaugePointer2,
            c1GaugePointer3});
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Visible = false;
            this.c1RadialGauge1.Radius = 0.5;
            this.c1RadialGauge1.StartAngle = 0;
            this.c1RadialGauge1.SweepAngle = 360;
            this.c1RadialGauge1.ViewTag = ((long)(636272793112967623));
            // 
            // PageSwissRailwayClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageSwissRailwayClock";
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
