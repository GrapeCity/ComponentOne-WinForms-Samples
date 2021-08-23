namespace GaugeDemo
{
    partial class PageKnob
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
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeSingleMark c1GaugeSingleMark1 = new C1.Win.C1Gauge.C1GaugeSingleMark();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
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
            // c1Gauge1
            // 
            this.c1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Gauge1.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1RadialGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(3, 3);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(382, 430);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(635266116717091809));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Visible = false;
            c1GaugeRange1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeRange1.Filling.Color = System.Drawing.Color.Green;
            c1GaugeRange1.HitTestable = false;
            c1GaugeRange1.Location = 70;
            c1GaugeRange1.Location2 = 100;
            c1GaugeRange1.ViewTag = ((long)(635265198974198125));
            c1GaugeRange1.Width = 1;
            c1GaugeSingleMark1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeSingleMark1.Filling.Color = System.Drawing.Color.Gainsboro;
            c1GaugeSingleMark1.Filling.Color2 = System.Drawing.Color.Blue;
            c1GaugeSingleMark1.HitTestable = false;
            c1GaugeSingleMark1.IsRotated = false;
            c1GaugeSingleMark1.Length = 30;
            c1GaugeSingleMark1.Location = 37;
            c1GaugeSingleMark1.PointerIndex = 100;
            c1GaugeSingleMark1.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round;
            c1GaugeSingleMark1.ViewTag = ((long)(635546684858422655));
            c1GaugeSingleMark1.Width = 30;
            c1GaugeMarks1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            c1GaugeMarks1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.White;
            c1GaugeMarks1.Filling.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            c1GaugeMarks1.FromPointerIndex = 100;
            c1GaugeMarks1.Interval = 5000;
            c1GaugeMarks1.IsRotated = false;
            c1GaugeMarks1.Length = 10;
            c1GaugeMarks1.Location = 70;
            c1GaugeMarks1.Location2 = 100;
            c1GaugeMarks1.ScaleFrom = 0;
            c1GaugeMarks1.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks1.ShowIrregularFrom = true;
            c1GaugeMarks1.ViewTag = ((long)(636672592310256828));
            c1GaugeMarks1.Width = 10;
            c1GaugeSingleLabel1.Angle = 47;
            c1GaugeSingleLabel1.Color = System.Drawing.Color.Green;
            c1GaugeSingleLabel1.FontSize = 10;
            c1GaugeSingleLabel1.Format = "#0.0";
            c1GaugeSingleLabel1.Location = 120;
            c1GaugeSingleLabel1.PointerIndex = 100;
            c1GaugeSingleLabel1.ViewTag = ((long)(636954074038533652));
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeRange1,
            c1GaugeSingleMark1,
            c1GaugeMarks1,
            c1GaugeSingleLabel1});
            c1GaugeEllipse1.Border.Color = System.Drawing.Color.Silver;
            c1GaugeEllipse1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeEllipse1.Filling.Color = System.Drawing.Color.Gainsboro;
            c1GaugeEllipse1.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugeEllipse1.Height = 120;
            c1GaugeEllipse1.HitTestable = false;
            c1GaugeEllipse1.Width = 120;
            this.c1RadialGauge1.FaceShapes.AddRange(new C1.Win.C1Gauge.C1GaugeBaseShape[] {
            c1GaugeEllipse1});
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            this.c1RadialGauge1.Pointer.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.None;
            this.c1RadialGauge1.Pointer.Length = 30;
            this.c1RadialGauge1.Pointer.Offset = 22;
            this.c1RadialGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Round;
            this.c1RadialGauge1.Pointer.Width = 30;
            this.c1RadialGauge1.SweepAngle = 1000;
            this.c1RadialGauge1.ViewTag = ((long)(634702240281386949));
            this.c1RadialGauge1.PointerDragMove += new C1.Win.C1Gauge.PointerDragEventHandler(this.c1RadialGauge1_PointerDragMove);
            // 
            // PageKnob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.Name = "PageKnob";
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
