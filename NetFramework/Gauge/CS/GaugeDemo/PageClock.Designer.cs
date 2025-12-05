namespace GaugeDemo
{
    partial class PageClock
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
            C1.Win.Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.Gauge.C1GaugeLabels();
            C1.Win.Gauge.C1GaugeRectangle c1GaugeRectangle1 = new C1.Win.Gauge.C1GaugeRectangle();
            C1.Win.Gauge.C1GaugeEllipse c1GaugeEllipse1 = new C1.Win.Gauge.C1GaugeEllipse();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer1 = new C1.Win.Gauge.C1GaugePointer();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer2 = new C1.Win.Gauge.C1GaugePointer();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer3 = new C1.Win.Gauge.C1GaugePointer();
            this.c1Gauge1 = new C1.Win.Gauge.C1Gauge();
            this.c1RadialGauge1 = new C1.Win.Gauge.C1RadialGauge();
            this.romanCheckBox = new System.Windows.Forms.CheckBox();
            this.gaugePanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugePanel
            // 
            this.gaugePanel.Controls.Add(this.romanCheckBox);
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
            this.c1Gauge1.ViewTag = ((long)(637653616036399049));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Border.Color = System.Drawing.Color.DarkSeaGreen;
            this.c1RadialGauge1.Cap.Border.Thickness = 1.5;
            this.c1RadialGauge1.Cap.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            this.c1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.MistyRose;
            this.c1RadialGauge1.Cap.Filling.Color2 = System.Drawing.Color.DimGray;
            this.c1RadialGauge1.Cap.Radius = 5;
            this.c1RadialGauge1.Cap.Shadow.Visible = true;
            c1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.CustomShape.EndRadius = 2.5;
            c1GaugeMarks1.CustomShape.StartRadius = 1.5;
            c1GaugeMarks1.CustomShape.StartWidth = 3;
            c1GaugeMarks1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.MistyRose;
            c1GaugeMarks1.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugeMarks1.Filling.SwapColors = true;
            c1GaugeMarks1.From = 0.5;
            c1GaugeMarks1.Interval = 5;
            c1GaugeMarks1.Length = 12;
            c1GaugeMarks1.Location = 86;
            c1GaugeMarks1.ScaleFrom = 0;
            c1GaugeMarks1.Shadow.OffsetX = 0.5;
            c1GaugeMarks1.Shadow.OffsetY = 0.5;
            c1GaugeMarks1.Shadow.Visible = true;
            c1GaugeMarks1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Custom;
            c1GaugeMarks1.ViewTag = ((long)(634302468273582893));
            c1GaugeMarks2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.Gray;
            c1GaugeMarks2.From = 0.5;
            c1GaugeMarks2.Interval = 1;
            c1GaugeMarks2.Length = 3;
            c1GaugeMarks2.Location = 90;
            c1GaugeMarks2.ScaleFrom = 0;
            c1GaugeMarks2.Shadow.OffsetX = 0.5;
            c1GaugeMarks2.Shadow.OffsetY = 0.5;
            c1GaugeMarks2.Shadow.Visible = true;
            c1GaugeMarks2.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks2.ViewTag = ((long)(634583943250743575));
            c1GaugeMarks2.Width = 3;
            c1GaugeLabels1.Color = System.Drawing.Color.Gainsboro;
            c1GaugeLabels1.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            c1GaugeLabels1.FontSize = 17;
            c1GaugeLabels1.From = 0.5;
            c1GaugeLabels1.Interval = 5;
            c1GaugeLabels1.Location = 68;
            c1GaugeLabels1.Name = "nums";
            c1GaugeLabels1.ScaleFrom = 0;
            c1GaugeLabels1.Shadow.OffsetX = 0.5;
            c1GaugeLabels1.Shadow.OffsetY = 0.5;
            c1GaugeLabels1.Shadow.Visible = true;
            c1GaugeLabels1.ValueFactor = 0.2;
            c1GaugeLabels1.ViewTag = ((long)(634865418227634241));
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeMarks1,
            c1GaugeMarks2,
            c1GaugeLabels1});
            c1GaugeRectangle1.Border.Color = System.Drawing.Color.DarkSeaGreen;
            c1GaugeRectangle1.Border.Thickness = 4;
            c1GaugeRectangle1.CornerRadius = 30;
            c1GaugeRectangle1.Filling.Color = System.Drawing.Color.DarkSlateGray;
            c1GaugeRectangle1.Filling.Color2 = System.Drawing.Color.White;
            c1GaugeRectangle1.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialOuter;
            c1GaugeRectangle1.HitTestable = false;
            c1GaugeEllipse1.Border.Color = System.Drawing.Color.DarkSeaGreen;
            c1GaugeEllipse1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeEllipse1.Border.Thickness = 2;
            c1GaugeEllipse1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            c1GaugeEllipse1.Filling.Color = System.Drawing.Color.SlateGray;
            c1GaugeEllipse1.Filling.Color2 = System.Drawing.Color.DarkSlateGray;
            c1GaugeEllipse1.Gradient.CenterPointX = 0.6;
            c1GaugeEllipse1.Gradient.CenterPointY = 0.65;
            c1GaugeEllipse1.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialInner;
            c1GaugeEllipse1.Gradient.FocusScaleX = 0.1;
            c1GaugeEllipse1.Gradient.FocusScaleY = 0.1;
            c1GaugeEllipse1.Height = -0.97;
            c1GaugeEllipse1.HitTestable = false;
            c1GaugeEllipse1.Width = -0.97;
            this.c1RadialGauge1.FaceShapes.AddRange(new C1.Win.Gauge.C1GaugeBaseShape[] {
            c1GaugeRectangle1,
            c1GaugeEllipse1});
            this.c1RadialGauge1.Maximum = 60;
            c1GaugePointer1.Border.Color = System.Drawing.Color.DimGray;
            c1GaugePointer1.CustomShape.EndRadius = 1.928571428571;
            c1GaugePointer1.CustomShape.EndWidth = 3.857142857144;
            c1GaugePointer1.CustomShape.StartRadius = 2.571428571429;
            c1GaugePointer1.CustomShape.StartWidth = 9;
            c1GaugePointer1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            c1GaugePointer1.Filling.Color = System.Drawing.Color.MistyRose;
            c1GaugePointer1.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugePointer1.Length = 63;
            c1GaugePointer1.Name = "hours";
            c1GaugePointer1.Offset = -15;
            c1GaugePointer1.Shadow.Visible = true;
            c1GaugePointer1.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom;
            c1GaugePointer1.Value = 0.42;
            c1GaugePointer1.ValueFactor = 5;
            c1GaugePointer1.ViewTag = ((long)(635146893204754921));
            c1GaugePointer2.Border.Color = System.Drawing.Color.DimGray;
            c1GaugePointer2.CustomShape.EndRadius = 1.928571428571;
            c1GaugePointer2.CustomShape.EndWidth = 3.857142857144;
            c1GaugePointer2.CustomShape.StartRadius = 2.571428571429;
            c1GaugePointer2.CustomShape.StartWidth = 9;
            c1GaugePointer2.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            c1GaugePointer2.Filling.Color = System.Drawing.Color.MistyRose;
            c1GaugePointer2.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugePointer2.Length = 94;
            c1GaugePointer2.Name = "minutes";
            c1GaugePointer2.Offset = -15;
            c1GaugePointer2.Shadow.Visible = true;
            c1GaugePointer2.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom;
            c1GaugePointer2.Value = 22.3;
            c1GaugePointer2.ViewTag = ((long)(635428368181515579));
            c1GaugePointer3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugePointer3.Filling.Color = System.Drawing.Color.DarkSeaGreen;
            c1GaugePointer3.Length = 115;
            c1GaugePointer3.Name = "seconds";
            c1GaugePointer3.Offset = -25;
            c1GaugePointer3.Shadow.Visible = true;
            c1GaugePointer3.Shape = C1.Win.Gauge.C1GaugePointerShape.Round;
            c1GaugePointer3.Value = 17;
            c1GaugePointer3.ViewTag = ((long)(635709843158236236));
            c1GaugePointer3.Width = 2;
            this.c1RadialGauge1.MorePointers.AddRange(new C1.Win.Gauge.C1GaugePointer[] {
            c1GaugePointer1,
            c1GaugePointer2,
            c1GaugePointer3});
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Visible = false;
            this.c1RadialGauge1.Radius = 0.49;
            this.c1RadialGauge1.StartAngle = 0;
            this.c1RadialGauge1.SweepAngle = 360;
            this.c1RadialGauge1.ViewTag = ((long)(636272793112967623));
            this.c1RadialGauge1.FormatLabel += new C1.Win.Gauge.FormatLabelEventHandler(this.c1RadialGauge1_FormatLabel);
            // 
            // romanCheckBox
            // 
            this.romanCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.romanCheckBox.AutoSize = true;
            this.romanCheckBox.Location = new System.Drawing.Point(326, 12);
            this.romanCheckBox.Name = "romanCheckBox";
            this.romanCheckBox.Size = new System.Drawing.Size(59, 17);
            this.romanCheckBox.TabIndex = 3;
            this.romanCheckBox.Text = "Roman";
            this.romanCheckBox.UseVisualStyleBackColor = true;
            this.romanCheckBox.Click += new System.EventHandler(this.romanCheckBox_Click);
            // 
            // PageClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageClock";
            this.gaugePanel.ResumeLayout(false);
            this.gaugePanel.PerformLayout();
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Gauge.C1Gauge c1Gauge1;
        private System.Windows.Forms.CheckBox romanCheckBox;
        private C1.Win.Gauge.C1RadialGauge c1RadialGauge1;

    }
}
