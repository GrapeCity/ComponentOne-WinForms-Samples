namespace GaugeDemo
{
    partial class PageTrackBar
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
            C1.Win.C1Gauge.CommonFilling commonFilling1 = new C1.Win.C1Gauge.CommonFilling();
            C1.Win.C1Gauge.CommonFilling commonFilling2 = new C1.Win.C1Gauge.CommonFilling();
            C1.Win.C1Gauge.CommonFilling commonFilling3 = new C1.Win.C1Gauge.CommonFilling();
            C1.Win.C1Gauge.CommonFilling commonFilling4 = new C1.Win.C1Gauge.CommonFilling();
            C1.Win.C1Gauge.CommonFilling commonFilling5 = new C1.Win.C1Gauge.CommonFilling();
            C1.Win.C1Gauge.CommonGradient commonGradient1 = new C1.Win.C1Gauge.CommonGradient();
            C1.Win.C1Gauge.CommonGradient commonGradient2 = new C1.Win.C1Gauge.CommonGradient();
            C1.Win.C1Gauge.C1GaugeSingleMark c1GaugeSingleMark1 = new C1.Win.C1Gauge.C1GaugeSingleMark();
            C1.Win.C1Gauge.C1GaugeSingleMark c1GaugeSingleMark2 = new C1.Win.C1Gauge.C1GaugeSingleMark();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel2 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeSingleMark c1GaugeSingleMark3 = new C1.Win.C1Gauge.C1GaugeSingleMark();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel3 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel4 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeRectangle c1GaugeRectangle1 = new C1.Win.C1Gauge.C1GaugeRectangle();
            this.c1Gauge1 = new C1.Win.C1Gauge.C1Gauge();
            this.c1LinearGauge1 = new C1.Win.C1Gauge.C1LinearGauge();
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
            this.timer1.Interval = 50;
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Gauge1.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1LinearGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(3, 92);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(382, 222);
            this.c1Gauge1.SupportsTransitionEffect = true;
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(639206783579924141));
            // 
            // c1LinearGauge1
            // 
            this.c1LinearGauge1.AxisLength = 0.55;
            this.c1LinearGauge1.AxisStart = 0.25;
            this.c1LinearGauge1.BaseFactor = 0.88;
            this.c1LinearGauge1.BaseOrigin = 0.06;
            commonFilling1.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            commonFilling1.Color = System.Drawing.Color.DimGray;
            commonFilling1.Color2 = System.Drawing.Color.White;
            commonFilling1.Name = "normalButton";
            commonFilling1.SwapColors = true;
            commonFilling2.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            commonFilling2.Color = System.Drawing.Color.LightCoral;
            commonFilling2.Color2 = System.Drawing.Color.MistyRose;
            commonFilling2.Name = "pressedButton";
            commonFilling2.SwapColors = true;
            commonFilling3.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            commonFilling3.Color = System.Drawing.Color.SeaGreen;
            commonFilling3.Color2 = System.Drawing.Color.White;
            commonFilling3.Name = "hotButton";
            commonFilling3.SwapColors = true;
            commonFilling4.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            commonFilling4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            commonFilling4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            commonFilling4.Name = "normalPointer";
            commonFilling4.SwapColors = true;
            commonFilling5.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            commonFilling5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            commonFilling5.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            commonFilling5.Name = "hotPointer";
            commonFilling5.SwapColors = true;
            this.c1LinearGauge1.CommonFillings.AddRange(new C1.Win.C1Gauge.CommonFilling[] {
            commonFilling1,
            commonFilling2,
            commonFilling3,
            commonFilling4,
            commonFilling5});
            commonGradient1.CenterPointX = 0.7;
            commonGradient1.CenterPointY = 0.7;
            commonGradient1.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialOuter;
            commonGradient1.FocusScaleX = 0.2;
            commonGradient1.FocusScaleY = 0.2;
            commonGradient1.Name = "normal";
            commonGradient2.CenterPointX = 0.6;
            commonGradient2.CenterPointY = 0.6;
            commonGradient2.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialOuter;
            commonGradient2.FocusScaleX = 0.2;
            commonGradient2.FocusScaleY = 0.2;
            commonGradient2.Name = "pressed";
            this.c1LinearGauge1.CommonGradients.AddRange(new C1.Win.C1Gauge.CommonGradient[] {
            commonGradient1,
            commonGradient2});
            c1GaugeSingleMark1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark1.CustomShape.EndRadius = 12;
            c1GaugeSingleMark1.CustomShape.EndWidth = 36;
            c1GaugeSingleMark1.CustomShape.StartRadius = 12;
            c1GaugeSingleMark1.CustomShape.StartWidth = 36;
            c1GaugeSingleMark1.Filling.CommonFillingName = "normalButton";
            c1GaugeSingleMark1.Gradient.CommonGradientName = "normal";
            c1GaugeSingleMark1.Length = 36;
            c1GaugeSingleMark1.Location = 50;
            c1GaugeSingleMark1.Name = "minusButton";
            c1GaugeSingleMark1.Position = -0.25;
            c1GaugeSingleMark1.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Custom;
            c1GaugeSingleMark1.ViewTag = ((long)(635265244106009517));
            c1GaugeSingleMark2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark2.CustomShape.EndRadius = 12;
            c1GaugeSingleMark2.CustomShape.EndWidth = 36;
            c1GaugeSingleMark2.CustomShape.StartRadius = 12;
            c1GaugeSingleMark2.CustomShape.StartWidth = 36;
            c1GaugeSingleMark2.Filling.CommonFillingName = "normalButton";
            c1GaugeSingleMark2.Gradient.CommonGradientName = "normal";
            c1GaugeSingleMark2.Length = 36;
            c1GaugeSingleMark2.Location = 50;
            c1GaugeSingleMark2.Name = "plusButton";
            c1GaugeSingleMark2.Position = 1.15;
            c1GaugeSingleMark2.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Custom;
            c1GaugeSingleMark2.ViewTag = ((long)(635546719779070002));
            c1GaugeRange1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeRange1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeRange1.Filling.Color = System.Drawing.Color.RosyBrown;
            c1GaugeRange1.Filling.Color2 = System.Drawing.Color.White;
            c1GaugeRange1.Filling.SwapColors = true;
            c1GaugeRange1.Location = 50;
            c1GaugeRange1.ViewTag = ((long)(635828197239232703));
            c1GaugeSingleLabel1.Color = System.Drawing.Color.SeaGreen;
            c1GaugeSingleLabel1.FontSize = 29;
            c1GaugeSingleLabel1.HitTestable = false;
            c1GaugeSingleLabel1.Location = 50;
            c1GaugeSingleLabel1.Name = "minusLabel";
            c1GaugeSingleLabel1.Position = -0.25;
            c1GaugeSingleLabel1.Text = "-";
            c1GaugeSingleLabel1.ViewTag = ((long)(636109824900026389));
            c1GaugeSingleLabel2.Color = System.Drawing.Color.SeaGreen;
            c1GaugeSingleLabel2.FontSize = 27;
            c1GaugeSingleLabel2.HitTestable = false;
            c1GaugeSingleLabel2.Location = 50;
            c1GaugeSingleLabel2.Name = "plusLabel";
            c1GaugeSingleLabel2.Position = 1.15;
            c1GaugeSingleLabel2.Text = "+";
            c1GaugeSingleLabel2.ViewTag = ((long)(636391301269766722));
            c1GaugeSingleMark3.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark3.Filling.Color = System.Drawing.Color.Gray;
            c1GaugeSingleMark3.Location = 50;
            c1GaugeSingleMark3.Name = "offMark";
            c1GaugeSingleMark3.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round;
            c1GaugeSingleMark3.ViewTag = ((long)(638361660776914335));
            c1GaugeSingleMark3.Width = 7;
            c1GaugeSingleLabel3.FontSize = 12;
            c1GaugeSingleLabel3.Location = 75;
            c1GaugeSingleLabel3.Text = "Off";
            c1GaugeSingleLabel3.ViewTag = ((long)(638643135785906837));
            c1GaugeSingleLabel4.Color = System.Drawing.Color.Firebrick;
            c1GaugeSingleLabel4.FontSize = 14;
            c1GaugeSingleLabel4.Format = "0.0";
            c1GaugeSingleLabel4.Location = 23;
            c1GaugeSingleLabel4.PointerIndex = 100;
            c1GaugeSingleLabel4.Position = 0.5;
            c1GaugeSingleLabel4.ViewTag = ((long)(637244294654167433));
            this.c1LinearGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeSingleMark1,
            c1GaugeSingleMark2,
            c1GaugeRange1,
            c1GaugeSingleLabel1,
            c1GaugeSingleLabel2,
            c1GaugeSingleMark3,
            c1GaugeSingleLabel3,
            c1GaugeSingleLabel4});
            c1GaugeRectangle1.Border.Color = System.Drawing.Color.Gray;
            c1GaugeRectangle1.CenterPointX = 0.455;
            c1GaugeRectangle1.CornerRadius = 10;
            c1GaugeRectangle1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeRectangle1.Filling.Color = System.Drawing.Color.LightGray;
            c1GaugeRectangle1.Filling.Color2 = System.Drawing.Color.Gray;
            c1GaugeRectangle1.HitTestable = false;
            c1GaugeRectangle1.Width = -1.76;
            this.c1LinearGauge1.FaceShapes.AddRange(new C1.Win.C1Gauge.C1GaugeBaseShape[] {
            c1GaugeRectangle1});
            this.c1LinearGauge1.Name = "c1LinearGauge1";
            this.c1LinearGauge1.OffPosition = 0.21;
            this.c1LinearGauge1.Pointer.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Center;
            this.c1LinearGauge1.Pointer.Border.Color = System.Drawing.Color.DarkGray;
            this.c1LinearGauge1.Pointer.Filling.CommonFillingName = "normalPointer";
            this.c1LinearGauge1.Pointer.Length = 25;
            this.c1LinearGauge1.Pointer.Offset = 50;
            this.c1LinearGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Round;
            this.c1LinearGauge1.Pointer.Width = 12;
            this.c1LinearGauge1.Viewport.AspectRatio = 3;
            this.c1LinearGauge1.ViewTag = ((long)(634702292464031625));
            this.c1LinearGauge1.ItemMouseDown += new C1.Win.C1Gauge.ItemMouseEventHandler(this.c1LinearGauge1_ItemMouseDown);
            this.c1LinearGauge1.ItemMouseUp += new C1.Win.C1Gauge.ItemMouseEventHandler(this.c1LinearGauge1_ItemMouseUp);
            this.c1LinearGauge1.ItemStateChanged += new C1.Win.C1Gauge.ItemEventHandler(this.c1LinearGauge1_ItemStateChanged);
            this.c1LinearGauge1.PointerDragMove += new C1.Win.C1Gauge.PointerDragEventHandler(this.c1LinearGauge1_PointerDragMove);
            // 
            // PageTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.Name = "PageTrackBar";
            this.gaugePanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Gauge.C1Gauge c1Gauge1;
        private C1.Win.C1Gauge.C1LinearGauge c1LinearGauge1;
    }
}
