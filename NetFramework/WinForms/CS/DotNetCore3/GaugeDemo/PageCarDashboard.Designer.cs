namespace GaugeDemo
{
    partial class PageCarDashboard
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
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange2 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange3 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel2 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels2 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel3 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange4 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeEllipse c1GaugeEllipse1 = new C1.Win.C1Gauge.C1GaugeEllipse();
            C1.Win.C1Gauge.C1GaugePointer c1GaugePointer1 = new C1.Win.C1Gauge.C1GaugePointer();
            C1.Win.C1Gauge.C1GaugePointer c1GaugePointer2 = new C1.Win.C1Gauge.C1GaugePointer();
            C1.Win.C1Gauge.C1GaugePointer c1GaugePointer3 = new C1.Win.C1Gauge.C1GaugePointer();
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
            this.timer1.Interval = 300;
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Gauge1.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1RadialGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(1, 3);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(388, 430);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(640781521076085716));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Visible = false;
            c1GaugeRange1.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            c1GaugeRange1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeRange1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeRange1.Filling.Color = System.Drawing.Color.AntiqueWhite;
            c1GaugeRange1.Filling.Color2 = System.Drawing.Color.RosyBrown;
            c1GaugeRange1.Gradient.CenterPointX = 0.4;
            c1GaugeRange1.Gradient.CenterPointY = 0.6;
            c1GaugeRange1.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialInner;
            c1GaugeRange1.Gradient.Falloff = C1.Win.C1Gauge.C1GaugeGradientFalloff.SigmaBell;
            c1GaugeRange1.Location = 90;
            c1GaugeRange1.Location2 = 30;
            c1GaugeRange1.ViewTag = ((long)(655418274945540252));
            c1GaugeRange1.Width = 40;
            c1GaugeRange1.Width2 = 10;
            c1GaugeMarks1.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            c1GaugeMarks1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.RosyBrown;
            c1GaugeMarks1.Interval = 10;
            c1GaugeMarks1.Length = 39.5;
            c1GaugeMarks1.Length2 = 11.5;
            c1GaugeMarks1.Location = 89;
            c1GaugeMarks1.Location2 = 32.3;
            c1GaugeMarks1.ScaleFrom = -90;
            c1GaugeMarks1.ScaleTo = 180;
            c1GaugeMarks1.ViewTag = ((long)(656825655115455895));
            c1GaugeMarks1.Width = 1;
            c1GaugeRange2.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeRange2.Border.Color = System.Drawing.Color.LightCoral;
            c1GaugeRange2.Location = 95;
            c1GaugeRange2.Location2 = 35;
            c1GaugeRange2.ValueColors.AddRange(new C1.Win.C1Gauge.C1GaugeValueColor[] {
            new C1.Win.C1Gauge.C1GaugeValueColor(-90, -1, System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))), 1, ((long)(676529226475175784))),
            new C1.Win.C1Gauge.C1GaugeValueColor(-40, -1, System.Drawing.Color.PaleGreen, 1, ((long)(677936611759773970))),
            new C1.Win.C1Gauge.C1GaugeValueColor(-25, -1, System.Drawing.Color.LightSalmon, 1, ((long)(678218087732741609))),
            new C1.Win.C1Gauge.C1GaugeValueColor(-7, -1, System.Drawing.Color.IndianRed, 1, ((long)(677655136309166209))),
            new C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.SteelBlue, 1, ((long)(678499567948351913))),
            new C1.Win.C1Gauge.C1GaugeValueColor(70, -1, System.Drawing.Color.MidnightBlue, 1, ((long)(678781044024275440))),
            new C1.Win.C1Gauge.C1GaugeValueColor(180, -1, System.Drawing.Color.IndianRed, 1, ((long)(677373661041038885)))});
            c1GaugeRange2.ViewTag = ((long)(653447916928237854));
            c1GaugeRange2.Width = 18;
            c1GaugeRange2.Width2 = 18;
            c1GaugeRange3.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            c1GaugeRange3.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeRange3.Filling.Color = System.Drawing.Color.LightCoral;
            c1GaugeRange3.Location = 95;
            c1GaugeRange3.Location2 = 35;
            c1GaugeRange3.ViewTag = ((long)(655136798311694813));
            c1GaugeRange3.Width = 5;
            c1GaugeMarks2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks2.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.White;
            c1GaugeMarks2.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugeMarks2.From = -90;
            c1GaugeMarks2.Interval = 10;
            c1GaugeMarks2.IsRotated = false;
            c1GaugeMarks2.Length = 5;
            c1GaugeMarks2.Location = 91.5;
            c1GaugeMarks2.Location2 = 32.7;
            c1GaugeMarks2.SequenceNo = -1;
            c1GaugeMarks2.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks2.ViewTag = ((long)(641063176673067260));
            c1GaugeSingleLabel1.Angle = -86;
            c1GaugeSingleLabel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            c1GaugeSingleLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeSingleLabel1.FontSize = 9;
            c1GaugeSingleLabel1.Location = 100;
            c1GaugeSingleLabel1.SequenceNo = 0;
            c1GaugeSingleLabel1.Text = " RPM\r\nx1000";
            c1GaugeSingleLabel1.ViewTag = ((long)(637122515720112954));
            c1GaugeLabels1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeLabels1.FontSize = 10;
            c1GaugeLabels1.FontSize2 = 14;
            c1GaugeLabels1.Interval = 10;
            c1GaugeLabels1.Location = 103;
            c1GaugeLabels1.Location2 = 84;
            c1GaugeLabels1.ScaleFrom = -90;
            c1GaugeLabels1.ScaleTo = 0;
            c1GaugeLabels1.To = -1;
            c1GaugeLabels1.ValueFactor = 0.1;
            c1GaugeLabels1.ValueOffset = 9;
            c1GaugeLabels1.ViewTag = ((long)(636559562791001442));
            c1GaugeSingleLabel2.Angle = 170;
            c1GaugeSingleLabel2.Color = System.Drawing.Color.White;
            c1GaugeSingleLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeSingleLabel2.FontSize = 10;
            c1GaugeSingleLabel2.Location = 24;
            c1GaugeSingleLabel2.Text = "MPH";
            c1GaugeSingleLabel2.ViewTag = ((long)(637403993970580858));
            c1GaugeLabels2.Color = System.Drawing.Color.White;
            c1GaugeLabels2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeLabels2.FontSize = 11;
            c1GaugeLabels2.FontSize2 = 6;
            c1GaugeLabels2.Interval = 10;
            c1GaugeLabels2.Location = 84;
            c1GaugeLabels2.Location2 = 44;
            c1GaugeLabels2.ScaleFrom = 0;
            c1GaugeLabels2.ViewTag = ((long)(641344658725412619));
            c1GaugeSingleLabel3.Angle = -113;
            c1GaugeSingleLabel3.Color = System.Drawing.Color.Snow;
            c1GaugeSingleLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeSingleLabel3.FontSize = 10;
            c1GaugeSingleLabel3.Location = 102;
            c1GaugeSingleLabel3.Text = "Fuel";
            c1GaugeSingleLabel3.ViewTag = ((long)(688914168538589149));
            c1GaugeRange4.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            c1GaugeRange4.AntiAliasing = C1.Win.C1Gauge.C1GaugeRangeAntiAliasing.LowQuality;
            c1GaugeRange4.Border.Color = System.Drawing.Color.White;
            c1GaugeRange4.From = 60;
            c1GaugeRange4.Location = 100;
            c1GaugeRange4.Location2 = 106;
            c1GaugeRange4.To = 80;
            c1GaugeRange4.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None;
            c1GaugeRange4.ValueColors.AddRange(new C1.Win.C1Gauge.C1GaugeValueColor[] {
            new C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.LightCoral, 1, ((long)(688069741589521705))),
            new C1.Win.C1Gauge.C1GaugeValueColor(double.NaN, 2, System.Drawing.Color.Lavender, 1, ((long)(688351217164156560)))});
            c1GaugeRange4.ViewTag = ((long)(687788264195372779));
            c1GaugeRange4.Width = 6;
            c1GaugeRange4.Width2 = 14;
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeRange1,
            c1GaugeMarks1,
            c1GaugeRange2,
            c1GaugeRange3,
            c1GaugeMarks2,
            c1GaugeSingleLabel1,
            c1GaugeLabels1,
            c1GaugeSingleLabel2,
            c1GaugeLabels2,
            c1GaugeSingleLabel3,
            c1GaugeRange4});
            c1GaugeEllipse1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeEllipse1.CenterPointX = 0.44;
            c1GaugeEllipse1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeEllipse1.Filling.Color = System.Drawing.Color.Lavender;
            c1GaugeEllipse1.Filling.Color2 = System.Drawing.Color.DarkBlue;
            c1GaugeEllipse1.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.Vertical;
            c1GaugeEllipse1.Height = -1.05;
            c1GaugeEllipse1.RotateAngle = -32;
            c1GaugeEllipse1.Width = -1.1;
            this.c1RadialGauge1.FaceShapes.AddRange(new C1.Win.C1Gauge.C1GaugeBaseShape[] {
            c1GaugeEllipse1});
            this.c1RadialGauge1.Maximum = 186;
            this.c1RadialGauge1.Minimum = -95;
            c1GaugePointer1.Border.Color = System.Drawing.Color.DarkSlateBlue;
            c1GaugePointer1.Border.Thickness = 1;
            c1GaugePointer1.CustomShape.EndWidth = 0;
            c1GaugePointer1.CustomShape.StartAngle = -25;
            c1GaugePointer1.CustomShape.StartWidth = 12;
            c1GaugePointer1.Filling.Color = System.Drawing.Color.RoyalBlue;
            c1GaugePointer1.Length = 10;
            c1GaugePointer1.Name = "mph";
            c1GaugePointer1.Offset = 80;
            c1GaugePointer1.Offset2 = 20;
            c1GaugePointer1.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom;
            c1GaugePointer1.SweepTime = 10;
            c1GaugePointer1.Value = 65;
            c1GaugePointer1.ViewTag = ((long)(677092177610324687));
            c1GaugePointer2.Border.Color = System.Drawing.Color.DarkOliveGreen;
            c1GaugePointer2.Border.Thickness = 1;
            c1GaugePointer2.CustomShape.EndWidth = 0;
            c1GaugePointer2.CustomShape.StartAngle = -25;
            c1GaugePointer2.CustomShape.StartWidth = 12;
            c1GaugePointer2.Filling.Color = System.Drawing.Color.OliveDrab;
            c1GaugePointer2.Length = 10;
            c1GaugePointer2.Name = "rpm";
            c1GaugePointer2.Offset = 80;
            c1GaugePointer2.Offset2 = 20;
            c1GaugePointer2.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom;
            c1GaugePointer2.SweepTime = 7;
            c1GaugePointer2.Value = 2500;
            c1GaugePointer2.ValueFactor = 0.01;
            c1GaugePointer2.ValueOffset = -90;
            c1GaugePointer2.ViewTag = ((long)(682721708515102101));
            c1GaugePointer3.Name = "fuel";
            c1GaugePointer3.SweepTime = 30;
            c1GaugePointer3.Value = 70;
            c1GaugePointer3.ValueFactor = 0.2;
            c1GaugePointer3.ValueOffset = 60;
            c1GaugePointer3.ViewTag = ((long)(688632692472186167));
            c1GaugePointer3.Visible = false;
            this.c1RadialGauge1.MorePointers.AddRange(new C1.Win.C1Gauge.C1GaugePointer[] {
            c1GaugePointer1,
            c1GaugePointer2,
            c1GaugePointer3});
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Visible = false;
            this.c1RadialGauge1.PointerOriginX = 0.56;
            this.c1RadialGauge1.Radius = 0.45;
            this.c1RadialGauge1.StartAngle = -76;
            this.c1RadialGauge1.SweepAngle = 506;
            this.c1RadialGauge1.Viewport.AspectPinX = 0.45;
            this.c1RadialGauge1.Viewport.AspectPinY = 0.5;
            this.c1RadialGauge1.Viewport.AspectRatio = 1;
            this.c1RadialGauge1.ViewTag = ((long)(652884948141329328));
            // 
            // PageCase9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageCase9";
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
