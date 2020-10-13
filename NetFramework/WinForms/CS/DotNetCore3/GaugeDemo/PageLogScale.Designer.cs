namespace GaugeDemo
{
    partial class PageLogScale
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
            C1.Win.C1Gauge.CommonFont commonFont2 = new C1.Win.C1Gauge.CommonFont();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels3 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels4 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange2 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks6 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks7 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks8 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks9 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks10 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel2 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeRectangle c1GaugeRectangle2 = new C1.Win.C1Gauge.C1GaugeRectangle();
            C1.Win.C1Gauge.C1GaugeSector c1GaugeSector5 = new C1.Win.C1Gauge.C1GaugeSector();
            C1.Win.C1Gauge.C1GaugeSector c1GaugeSector6 = new C1.Win.C1Gauge.C1GaugeSector();
            C1.Win.C1Gauge.C1GaugeSector c1GaugeSector7 = new C1.Win.C1Gauge.C1GaugeSector();
            C1.Win.C1Gauge.C1GaugeSector c1GaugeSector8 = new C1.Win.C1Gauge.C1GaugeSector();
            this.c1Gauge1 = new C1.Win.C1Gauge.C1Gauge();
            this.c1RadialGauge1 = new C1.Win.C1Gauge.C1RadialGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.gaugePanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugePanel
            // 
            this.gaugePanel.Controls.Add(this.label1);
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
            this.c1Gauge1.Location = new System.Drawing.Point(6, 6);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(379, 424);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(636406609817355893));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Visible = false;
            commonFont2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            commonFont2.FontSize = 2.6;
            commonFont2.Name = "labelFont";
            this.c1RadialGauge1.CommonFonts.AddRange(new C1.Win.C1Gauge.CommonFont[] {
            commonFont2});
            c1GaugeLabels3.CommonFontName = "labelFont";
            c1GaugeLabels3.HitTestable = false;
            c1GaugeLabels3.Interval = 1;
            c1GaugeLabels3.IntervalCoeff = 18;
            c1GaugeLabels3.IsRotated = true;
            c1GaugeLabels3.Location = 95;
            c1GaugeLabels3.To = 300;
            c1GaugeLabels3.ValueOffset = -100;
            c1GaugeLabels3.ViewTag = ((long)(646258289201856091));
            c1GaugeLabels4.CommonFontName = "labelFont";
            c1GaugeLabels4.From = 400;
            c1GaugeLabels4.HitTestable = false;
            c1GaugeLabels4.Interval = 1;
            c1GaugeLabels4.IntervalCoeff = 9;
            c1GaugeLabels4.IsRotated = true;
            c1GaugeLabels4.Location = 95;
            c1GaugeLabels4.To = 600;
            c1GaugeLabels4.ValueOffset = -100;
            c1GaugeLabels4.ViewTag = ((long)(649354648548552152));
            c1GaugeRange2.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeRange2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeRange2.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            c1GaugeRange2.From = 600;
            c1GaugeRange2.HitTestable = false;
            c1GaugeRange2.Location = 87.5;
            c1GaugeRange2.ViewTag = ((long)(649636126668672600));
            c1GaugeRange2.Width = 3;
            c1GaugeMarks6.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks6.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks6.Filling.Color = System.Drawing.Color.Black;
            c1GaugeMarks6.HitTestable = false;
            c1GaugeMarks6.Interval = 1;
            c1GaugeMarks6.IntervalCoeff = 18;
            c1GaugeMarks6.Length = 5;
            c1GaugeMarks6.Location = 87.5;
            c1GaugeMarks6.ViewTag = ((long)(645976808331978366));
            c1GaugeMarks6.Width = 0.2;
            c1GaugeMarks7.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks7.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks7.Filling.Color = System.Drawing.Color.Black;
            c1GaugeMarks7.From = 100;
            c1GaugeMarks7.HitTestable = false;
            c1GaugeMarks7.Interval = 1;
            c1GaugeMarks7.IntervalCoeff = 180;
            c1GaugeMarks7.Length = 3;
            c1GaugeMarks7.Location = 87.5;
            c1GaugeMarks7.To = 150;
            c1GaugeMarks7.ViewTag = ((long)(650199140502477661));
            c1GaugeMarks7.Width = 0.2;
            c1GaugeMarks8.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks8.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks8.Filling.Color = System.Drawing.Color.Black;
            c1GaugeMarks8.From = 150;
            c1GaugeMarks8.HitTestable = false;
            c1GaugeMarks8.Interval = 1;
            c1GaugeMarks8.IntervalCoeff = 90;
            c1GaugeMarks8.Length = 3;
            c1GaugeMarks8.Location = 87.5;
            c1GaugeMarks8.To = 600;
            c1GaugeMarks8.ViewTag = ((long)(650480635266470085));
            c1GaugeMarks8.Width = 0.2;
            c1GaugeMarks9.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks9.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks9.Filling.Color = System.Drawing.Color.Black;
            c1GaugeMarks9.From = 600;
            c1GaugeMarks9.HitTestable = false;
            c1GaugeMarks9.Interval = 1;
            c1GaugeMarks9.IntervalCoeff = 36;
            c1GaugeMarks9.Length = 3;
            c1GaugeMarks9.Location = 87.5;
            c1GaugeMarks9.ViewTag = ((long)(651043594119340417));
            c1GaugeMarks9.Width = 0.2;
            c1GaugeMarks10.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks10.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks10.Filling.Color = System.Drawing.Color.Black;
            c1GaugeMarks10.HitTestable = false;
            c1GaugeMarks10.Interval = 1;
            c1GaugeMarks10.IntervalCoeff = 18;
            c1GaugeMarks10.Length = 4;
            c1GaugeMarks10.Location = 73;
            c1GaugeMarks10.SequenceNo = 1;
            c1GaugeMarks10.ViewTag = ((long)(649917638929085762));
            c1GaugeMarks10.Width = 0.2;
            c1GaugeSingleLabel2.Angle = -8;
            c1GaugeSingleLabel2.FontSize = 4;
            c1GaugeSingleLabel2.Format = "\"V = [\"0\"]\"";
            c1GaugeSingleLabel2.HitTestable = false;
            c1GaugeSingleLabel2.Location = 60;
            c1GaugeSingleLabel2.OrthogonalAlignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeSingleLabel2.PointerIndex = 100;
            c1GaugeSingleLabel2.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None;
            c1GaugeSingleLabel2.ValueColors.AddRange(new C1.Win.C1Gauge.C1GaugeValueColor[] {
            new C1.Win.C1Gauge.C1GaugeValueColor(100, -1, System.Drawing.Color.Black, 1, ((long)(684539149286312450))),
            new C1.Win.C1Gauge.C1GaugeValueColor(600.5, -1, System.Drawing.Color.Red, 1, ((long)(684820624429572632)))});
            c1GaugeSingleLabel2.ValueOffset = -100;
            c1GaugeSingleLabel2.ViewTag = ((long)(660613758344991672));
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeLabels3,
            c1GaugeLabels4,
            c1GaugeRange2,
            c1GaugeMarks6,
            c1GaugeMarks7,
            c1GaugeMarks8,
            c1GaugeMarks9,
            c1GaugeMarks10,
            c1GaugeSingleLabel2});
            c1GaugeRectangle2.Border.Color = System.Drawing.Color.LightSteelBlue;
            c1GaugeRectangle2.CenterPointY = 0.125;
            c1GaugeRectangle2.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeRectangle2.Filling.Color = System.Drawing.Color.LightSteelBlue;
            c1GaugeRectangle2.Filling.Color2 = System.Drawing.Color.White;
            c1GaugeRectangle2.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.Vertical;
            c1GaugeRectangle2.Height = -0.25;
            c1GaugeRectangle2.Width = -0.5;
            c1GaugeSector5.Border.Color = System.Drawing.Color.Gray;
            c1GaugeSector5.CenterRadius = 1.3;
            c1GaugeSector5.CornerRadius = 1;
            c1GaugeSector5.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeSector5.Filling.Color = System.Drawing.Color.Gray;
            c1GaugeSector5.Filling.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            c1GaugeSector5.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialInner;
            c1GaugeSector5.Gradient.FocusScaleX = 0.7;
            c1GaugeSector5.Gradient.FocusScaleY = 0.7;
            c1GaugeSector5.HitTestable = false;
            c1GaugeSector5.InnerRadius = 73;
            c1GaugeSector5.OuterRadius = 98.5;
            c1GaugeSector5.StartAngle = -29;
            c1GaugeSector5.SweepAngle = 58;
            c1GaugeSector6.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeSector6.CenterRadius = 1.3;
            c1GaugeSector6.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeSector6.Filling.Color = System.Drawing.Color.Gainsboro;
            c1GaugeSector6.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugeSector6.Filling.SwapColors = true;
            c1GaugeSector6.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.Horizontal;
            c1GaugeSector6.Gradient.Falloff = C1.Win.C1Gauge.C1GaugeGradientFalloff.Triangular;
            c1GaugeSector6.Gradient.FocusScaleX = 0.7;
            c1GaugeSector6.Gradient.FocusScaleY = 0.7;
            c1GaugeSector6.Gradient.ScaleX = 0.6;
            c1GaugeSector6.Gradient.ScaleY = 0.2;
            c1GaugeSector6.Gradient.TranslateX = 0.2;
            c1GaugeSector6.HitTestable = false;
            c1GaugeSector6.InnerRadius = 80;
            c1GaugeSector6.OuterRadius = 84.5;
            c1GaugeSector6.StartAngle = -29;
            c1GaugeSector6.SweepAngle = 58;
            c1GaugeSector7.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeSector7.CenterRadius = 1.3;
            c1GaugeSector7.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeSector7.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeSector7.Filling.Color2 = System.Drawing.Color.Gray;
            c1GaugeSector7.Filling.SwapColors = true;
            c1GaugeSector7.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialInner;
            c1GaugeSector7.Gradient.FocusScaleX = 0.98;
            c1GaugeSector7.Gradient.FocusScaleY = 0.98;
            c1GaugeSector7.HitTestable = false;
            c1GaugeSector7.InnerRadius = 84.4;
            c1GaugeSector7.OuterRadius = 85.5;
            c1GaugeSector7.StartAngle = -29;
            c1GaugeSector7.SweepAngle = 58;
            c1GaugeSector8.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeSector8.CenterRadius = 1.3;
            c1GaugeSector8.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeSector8.Filling.Color = System.Drawing.Color.White;
            c1GaugeSector8.Filling.Color2 = System.Drawing.Color.Gray;
            c1GaugeSector8.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialInner;
            c1GaugeSector8.Gradient.FocusScaleX = 0.98;
            c1GaugeSector8.Gradient.FocusScaleY = 0.98;
            c1GaugeSector8.HitTestable = false;
            c1GaugeSector8.InnerRadius = 79;
            c1GaugeSector8.OuterRadius = 80.1;
            c1GaugeSector8.StartAngle = -29;
            c1GaugeSector8.SweepAngle = 58;
            this.c1RadialGauge1.FaceShapes.AddRange(new C1.Win.C1Gauge.C1GaugeBaseShape[] {
            c1GaugeRectangle2,
            c1GaugeSector5,
            c1GaugeSector6,
            c1GaugeSector7,
            c1GaugeSector8});
            this.c1RadialGauge1.IsLogarithmic = true;
            this.c1RadialGauge1.Maximum = 850;
            this.c1RadialGauge1.Minimum = 100;
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.DodgerBlue;
            this.c1RadialGauge1.Pointer.Border.Thickness = 0.2;
            this.c1RadialGauge1.Pointer.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            this.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.Black;
            this.c1RadialGauge1.Pointer.Filling.Color2 = System.Drawing.Color.Gainsboro;
            this.c1RadialGauge1.Pointer.Filling.Opacity = 0.7;
            this.c1RadialGauge1.Pointer.Filling.Opacity2 = 0.5;
            this.c1RadialGauge1.Pointer.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.Vertical;
            this.c1RadialGauge1.Pointer.HitTestable = false;
            this.c1RadialGauge1.Pointer.Length = 22;
            this.c1RadialGauge1.Pointer.Offset = 67;
            this.c1RadialGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Arrow2;
            this.c1RadialGauge1.Pointer.Value = 300;
            this.c1RadialGauge1.Pointer.ValueOffset = 100;
            this.c1RadialGauge1.Pointer.Width = 1.3;
            this.c1RadialGauge1.PointerOriginY = 2;
            this.c1RadialGauge1.Radius = 2;
            this.c1RadialGauge1.StartAngle = -28;
            this.c1RadialGauge1.SweepAngle = 56;
            this.c1RadialGauge1.Viewport.AspectPinY = 0.5;
            this.c1RadialGauge1.Viewport.AspectRatio = 2;
            this.c1RadialGauge1.ViewTag = ((long)(636688084856520121));
            this.c1RadialGauge1.ItemMouseDown += new C1.Win.C1Gauge.ItemMouseEventHandler(this.c1RadialGauge1_ItemMouseMove);
            this.c1RadialGauge1.ItemMouseMove += new C1.Win.C1Gauge.ItemMouseEventHandler(this.c1RadialGauge1_ItemMouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "* You can drag the pointer or click the scale";
            // 
            // PageLogScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.Name = "PageLogScale";
            this.gaugePanel.ResumeLayout(false);
            this.gaugePanel.PerformLayout();
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Gauge.C1Gauge c1Gauge1;
        private C1.Win.C1Gauge.C1RadialGauge c1RadialGauge1;
        private System.Windows.Forms.Label label1;
    }
}
