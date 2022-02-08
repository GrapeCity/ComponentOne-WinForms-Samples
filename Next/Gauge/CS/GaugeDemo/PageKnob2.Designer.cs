namespace GaugeDemo
{
    partial class PageKnob2
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
            C1.Win.Gauge.C1GaugeCaption c1GaugeCaption1 = new C1.Win.Gauge.C1GaugeCaption();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeEllipse c1GaugeEllipse1 = new C1.Win.Gauge.C1GaugeEllipse();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel2 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeEllipse c1GaugeEllipse2 = new C1.Win.Gauge.C1GaugeEllipse();
            this.c1Gauge1 = new C1.Win.Gauge.C1Gauge();
            this.c1RadialGauge2 = new C1.Win.Gauge.C1RadialGauge();
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
            this.gaugeGrid.SelectedObject = this.c1Gauge1;
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            c1GaugeCaption1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            c1GaugeCaption1.FontSize = 6;
            c1GaugeCaption1.Text = "0";
            this.c1Gauge1.CoverShapes.AddRange(new C1.Win.Gauge.C1GaugeBaseShape[] {
            c1GaugeCaption1});
            this.c1Gauge1.Gauges.AddRange(new C1.Win.Gauge.C1GaugeBase[] {
            this.c1RadialGauge2,
            this.c1RadialGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(17, 26);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Selectable = true;
            this.c1Gauge1.Size = new System.Drawing.Size(357, 383);
            this.c1Gauge1.TabIndex = 1;
            this.c1Gauge1.ViewTag = ((long)(634609965734186602));
            this.c1Gauge1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1Gauge1_KeyDown);
            // 
            // c1RadialGauge2
            // 
            this.c1RadialGauge2.Cap.Visible = false;
            c1GaugeSingleLabel1.Angle = 0;
            c1GaugeSingleLabel1.FontSize = 10;
            c1GaugeSingleLabel1.Location = 85;
            c1GaugeSingleLabel1.OrthogonalOffset = -95;
            c1GaugeSingleLabel1.PointerIndex = 100;
            c1GaugeSingleLabel1.ViewTag = ((long)(638550678938439511));
            this.c1RadialGauge2.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeSingleLabel1});
            c1GaugeEllipse1.Border.Color = System.Drawing.Color.Gray;
            c1GaugeEllipse1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            c1GaugeEllipse1.Filling.Color2 = System.Drawing.Color.DarkGoldenrod;
            c1GaugeEllipse1.HitTestable = false;
            this.c1RadialGauge2.FaceShapes.AddRange(new C1.Win.Gauge.C1GaugeBaseShape[] {
            c1GaugeEllipse1});
            this.c1RadialGauge2.Maximum = 54;
            this.c1RadialGauge2.Minimum = -54;
            this.c1RadialGauge2.Name = "c1RadialGauge2";
            this.c1RadialGauge2.Pointer.Border.Color = System.Drawing.Color.Gray;
            this.c1RadialGauge2.Pointer.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            this.c1RadialGauge2.Pointer.Filling.Color = System.Drawing.Color.White;
            this.c1RadialGauge2.Pointer.Filling.Color2 = System.Drawing.Color.DarkGray;
            this.c1RadialGauge2.Pointer.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialInner;
            this.c1RadialGauge2.Pointer.Length = 30;
            this.c1RadialGauge2.Pointer.Offset = 65;
            this.c1RadialGauge2.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Round;
            this.c1RadialGauge2.Pointer.Width = 30;
            this.c1RadialGauge2.SlidingScale = true;
            this.c1RadialGauge2.StartAngle = -540;
            this.c1RadialGauge2.SweepAngle = 1080;
            this.c1RadialGauge2.ViewTag = ((long)(636017396939781318));
            this.c1RadialGauge2.PointerDragMove += new C1.Win.Gauge.PointerDragEventHandler(this.c1RadialGauge2_PointerDragMove);
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Visible = false;
            c1GaugeSingleLabel2.Angle = 0;
            c1GaugeSingleLabel2.FontSize = 10;
            c1GaugeSingleLabel2.Location = 85;
            c1GaugeSingleLabel2.OrthogonalOffset = 95;
            c1GaugeSingleLabel2.PointerIndex = 100;
            c1GaugeSingleLabel2.ViewTag = ((long)(636017371211619752));
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeSingleLabel2});
            c1GaugeEllipse2.Border.Color = System.Drawing.Color.Gray;
            c1GaugeEllipse2.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            c1GaugeEllipse2.Filling.Color = System.Drawing.Color.Gainsboro;
            c1GaugeEllipse2.Filling.Color2 = System.Drawing.Color.SeaGreen;
            c1GaugeEllipse2.Height = 120;
            c1GaugeEllipse2.HitTestable = false;
            c1GaugeEllipse2.Width = 120;
            this.c1RadialGauge1.FaceShapes.AddRange(new C1.Win.Gauge.C1GaugeBaseShape[] {
            c1GaugeEllipse2});
            this.c1RadialGauge1.Maximum = 27;
            this.c1RadialGauge1.Minimum = -27;
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.Gray;
            this.c1RadialGauge1.Pointer.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            this.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.White;
            this.c1RadialGauge1.Pointer.Filling.Color2 = System.Drawing.Color.DarkGray;
            this.c1RadialGauge1.Pointer.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialInner;
            this.c1RadialGauge1.Pointer.Length = 30;
            this.c1RadialGauge1.Pointer.Offset = 22;
            this.c1RadialGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Round;
            this.c1RadialGauge1.Pointer.Width = 30;
            this.c1RadialGauge1.SlidingScale = true;
            this.c1RadialGauge1.StartAngle = -540;
            this.c1RadialGauge1.SweepAngle = 1080;
            this.c1RadialGauge1.ViewTag = ((long)(634891441129901224));
            this.c1RadialGauge1.PointerDragMove += new C1.Win.Gauge.PointerDragEventHandler(this.c1RadialGauge1_PointerDragMove);
            // 
            // PageKnob2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PageKnob2";
            this.gaugePanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Gauge.C1Gauge c1Gauge1;
        private C1.Win.Gauge.C1RadialGauge c1RadialGauge2;
        private C1.Win.Gauge.C1RadialGauge c1RadialGauge1;
    }
}
