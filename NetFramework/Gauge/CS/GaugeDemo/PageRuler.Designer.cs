namespace GaugeDemo
{
    partial class PageRuler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageRuler));
            C1.Win.Gauge.CommonBorder commonBorder1 = new C1.Win.Gauge.CommonBorder();
            C1.Win.Gauge.CommonBorder commonBorder2 = new C1.Win.Gauge.CommonBorder();
            C1.Win.Gauge.CommonBorder commonBorder3 = new C1.Win.Gauge.CommonBorder();
            C1.Win.Gauge.CommonFilling commonFilling1 = new C1.Win.Gauge.CommonFilling();
            C1.Win.Gauge.CommonFilling commonFilling2 = new C1.Win.Gauge.CommonFilling();
            C1.Win.Gauge.CommonFilling commonFilling3 = new C1.Win.Gauge.CommonFilling();
            C1.Win.Gauge.CommonShape commonShape1 = new C1.Win.Gauge.CommonShape();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.Gauge.C1GaugeLabels();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks3 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange2 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeRectangle c1GaugeRectangle1 = new C1.Win.Gauge.C1GaugeRectangle();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer1 = new C1.Win.Gauge.C1GaugePointer();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer2 = new C1.Win.Gauge.C1GaugePointer();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer3 = new C1.Win.Gauge.C1GaugePointer();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer4 = new C1.Win.Gauge.C1GaugePointer();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer5 = new C1.Win.Gauge.C1GaugePointer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.c1Gauge1 = new C1.Win.Gauge.C1Gauge();
            this.rulerGauge = new C1.Win.Gauge.C1LinearGauge();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gaugePanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugePanel
            // 
            this.gaugePanel.Controls.Add(this.panel1);
            // 
            // gaugeGrid
            // 
            this.gaugeGrid.SelectedObject = this.rulerGauge;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(172)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.c1Gauge1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(391, 436);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 34);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.panel2.Size = new System.Drawing.Size(389, 401);
            this.panel2.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(8, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightMargin = 320;
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(373, 393);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1Gauge1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1Gauge1.Gauges.AddRange(new C1.Win.Gauge.C1GaugeBase[] {
            this.rulerGauge});
            this.c1Gauge1.Location = new System.Drawing.Point(1, 1);
            this.c1Gauge1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(389, 33);
            this.c1Gauge1.TabIndex = 1;
            this.c1Gauge1.ViewTag = ((long)(634807802611695961));
            this.c1Gauge1.Resize += new System.EventHandler(this.c1Gauge1_Resize);
            // 
            // rulerGauge
            // 
            this.rulerGauge.AxisLength = 1;
            this.rulerGauge.AxisStart = 0;
            this.rulerGauge.BaseFactor = 1;
            this.rulerGauge.BaseOrigin = 0;
            commonBorder1.Color = System.Drawing.Color.DimGray;
            commonBorder1.Name = "Normal";
            commonBorder2.Color = System.Drawing.Color.IndianRed;
            commonBorder2.Name = "Hot";
            commonBorder3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            commonBorder3.Name = "Outer";
            this.rulerGauge.CommonBorders.AddRange(new C1.Win.Gauge.CommonBorder[] {
            commonBorder1,
            commonBorder2,
            commonBorder3});
            commonFilling1.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            commonFilling1.Color = System.Drawing.Color.Gray;
            commonFilling1.Color2 = System.Drawing.Color.White;
            commonFilling1.Name = "Normal";
            commonFilling2.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            commonFilling2.Color = System.Drawing.Color.LightCoral;
            commonFilling2.Color2 = System.Drawing.Color.White;
            commonFilling2.Name = "Hot";
            commonFilling3.Color = System.Drawing.Color.Black;
            commonFilling3.Name = "Outer";
            commonFilling3.Opacity = 0.1;
            this.rulerGauge.CommonFillings.AddRange(new C1.Win.Gauge.CommonFilling[] {
            commonFilling1,
            commonFilling2,
            commonFilling3});
            commonShape1.EndAngle = 45;
            commonShape1.EndWidth = 50;
            commonShape1.Name = "SimplePointer";
            commonShape1.StartWidth = 50;
            this.rulerGauge.CommonShapes.AddRange(new C1.Win.Gauge.CommonShape[] {
            commonShape1});
            c1GaugeRange1.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeRange1.Border.CommonBorderName = "Outer";
            c1GaugeRange1.Filling.CommonFillingName = "Outer";
            c1GaugeRange1.HitTestable = false;
            c1GaugeRange1.Location = 0;
            c1GaugeRange1.To = 0;
            c1GaugeRange1.ViewTag = ((long)(658173190335200112));
            c1GaugeRange1.Width = 100;
            c1GaugeLabels1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            c1GaugeLabels1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            c1GaugeLabels1.From = 40;
            c1GaugeLabels1.Interval = 40;
            c1GaugeLabels1.Location = 52;
            c1GaugeLabels1.ValueFactor = 0.025;
            c1GaugeLabels1.ViewTag = ((long)(688832955907896122));
            c1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.None;
            c1GaugeMarks1.HitTestable = false;
            c1GaugeMarks1.Interval = 40;
            c1GaugeMarks1.ScaleFrom = 0;
            c1GaugeMarks1.ViewTag = ((long)(689395905861317434));
            c1GaugeMarks2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            c1GaugeMarks2.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.None;
            c1GaugeMarks2.HitTestable = false;
            c1GaugeMarks2.Interval = 20;
            c1GaugeMarks2.Length = 40;
            c1GaugeMarks2.Location = 50;
            c1GaugeMarks2.ScaleFrom = 0;
            c1GaugeMarks2.ViewTag = ((long)(664362727045719722));
            c1GaugeMarks2.Width = 0.1;
            c1GaugeMarks3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            c1GaugeMarks3.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.None;
            c1GaugeMarks3.HitTestable = false;
            c1GaugeMarks3.Interval = 10;
            c1GaugeMarks3.Length = 16;
            c1GaugeMarks3.Location = 50;
            c1GaugeMarks3.ScaleFrom = 0;
            c1GaugeMarks3.ViewTag = ((long)(664644205730878892));
            c1GaugeMarks3.Width = 0.1;
            c1GaugeRange2.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeRange2.Border.CommonBorderName = "Outer";
            c1GaugeRange2.Filling.CommonFillingName = "Outer";
            c1GaugeRange2.FromPointerIndex = 0;
            c1GaugeRange2.HitTestable = false;
            c1GaugeRange2.Location = 0;
            c1GaugeRange2.ViewTag = ((long)(653385666070406411));
            c1GaugeRange2.Width = 100;
            this.rulerGauge.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeRange1,
            c1GaugeLabels1,
            c1GaugeMarks1,
            c1GaugeMarks2,
            c1GaugeMarks3,
            c1GaugeRange2});
            c1GaugeRectangle1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            c1GaugeRectangle1.Filling.Color = System.Drawing.Color.White;
            c1GaugeRectangle1.HitTestable = false;
            this.rulerGauge.FaceShapes.AddRange(new C1.Win.Gauge.C1GaugeBaseShape[] {
            c1GaugeRectangle1});
            this.rulerGauge.Maximum = 365;
            this.rulerGauge.Minimum = -8;
            c1GaugePointer1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugePointer1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.None;
            c1GaugePointer1.Length = 100;
            c1GaugePointer1.Name = "RightMargin";
            c1GaugePointer1.Offset = 0;
            c1GaugePointer1.Shape = C1.Win.Gauge.C1GaugePointerShape.Rectangle;
            c1GaugePointer1.Value = 320;
            c1GaugePointer1.ViewTag = ((long)(657044864145362080));
            c1GaugePointer1.Width = 30;
            c1GaugePointer2.Border.CommonBorderName = "Normal";
            c1GaugePointer2.Filling.CommonFillingName = "Normal";
            c1GaugePointer2.Length = 36;
            c1GaugePointer2.Name = "LeftIndent";
            c1GaugePointer2.Offset = 100;
            c1GaugePointer2.Shape = C1.Win.Gauge.C1GaugePointerShape.Rectangle;
            c1GaugePointer2.ViewTag = ((long)(637341394413943775));
            c1GaugePointer2.Width = 56;
            c1GaugePointer3.Alignment = C1.Win.Gauge.C1GaugeAlignment.In;
            c1GaugePointer3.Border.CommonBorderName = "Normal";
            c1GaugePointer3.CustomShape.CommonShapeName = "SimplePointer";
            c1GaugePointer3.CustomShape.EndWidth = 56;
            c1GaugePointer3.CustomShape.StartWidth = 56;
            c1GaugePointer3.Filling.CommonFillingName = "Normal";
            c1GaugePointer3.FlipShape = true;
            c1GaugePointer3.Length = 50;
            c1GaugePointer3.Name = "HangingIndent";
            c1GaugePointer3.Offset = 100;
            c1GaugePointer3.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom;
            c1GaugePointer3.ViewTag = ((long)(664925685614266166));
            c1GaugePointer4.Border.CommonBorderName = "Normal";
            c1GaugePointer4.CustomShape.CommonShapeName = "SimplePointer";
            c1GaugePointer4.CustomShape.EndWidth = 56;
            c1GaugePointer4.CustomShape.StartWidth = 56;
            c1GaugePointer4.Filling.CommonFillingName = "Normal";
            c1GaugePointer4.Length = 50;
            c1GaugePointer4.Name = "FirstLineIndent";
            c1GaugePointer4.Offset = -20;
            c1GaugePointer4.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom;
            c1GaugePointer4.ViewTag = ((long)(637622871569666258));
            c1GaugePointer5.Alignment = C1.Win.Gauge.C1GaugeAlignment.In;
            c1GaugePointer5.Border.CommonBorderName = "Normal";
            c1GaugePointer5.CustomShape.CommonShapeName = "SimplePointer";
            c1GaugePointer5.CustomShape.EndWidth = 56;
            c1GaugePointer5.CustomShape.StartWidth = 56;
            c1GaugePointer5.Filling.CommonFillingName = "Normal";
            c1GaugePointer5.FlipShape = true;
            c1GaugePointer5.Length = 50;
            c1GaugePointer5.Name = "RightIndent";
            c1GaugePointer5.Offset = 100;
            c1GaugePointer5.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom;
            c1GaugePointer5.Value = 320;
            c1GaugePointer5.ViewTag = ((long)(665207218141115929));
            this.rulerGauge.MorePointers.AddRange(new C1.Win.Gauge.C1GaugePointer[] {
            c1GaugePointer1,
            c1GaugePointer2,
            c1GaugePointer3,
            c1GaugePointer4,
            c1GaugePointer5});
            this.rulerGauge.Name = "rulerGauge";
            this.rulerGauge.Pointer.Visible = false;
            this.rulerGauge.Viewport.Height = 16;
            this.rulerGauge.Viewport.MarginX = 8;
            this.rulerGauge.Viewport.MarginY = 6;
            this.rulerGauge.ViewTag = ((long)(688270005954464810));
            this.rulerGauge.PointerValueChanged += new C1.Win.Gauge.PointerValueChangedEventHandler(this.rulerGauge_PointerValueChanged);
            this.rulerGauge.ItemMouseLeave += new C1.Win.Gauge.ItemEventHandler(this.rulerGauge_ItemMouseLeave);
            this.rulerGauge.PointerDragEnd += new C1.Win.Gauge.PointerDragEventHandler(this.rulerGauge_PointerDragEnd);
            this.rulerGauge.ItemStateChanged += new C1.Win.Gauge.ItemEventHandler(this.rulerGauge_ItemStateChanged);
            this.rulerGauge.PointerDragMove += new C1.Win.Gauge.PointerDragEventHandler(this.rulerGauge_PointerDragMove);
            this.rulerGauge.ItemMouseEnter += new C1.Win.Gauge.ItemEventHandler(this.rulerGauge_ItemMouseEnter);
            // 
            // PageRuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PageRuler";
            this.gaugePanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.RichTextBox richTextBox1;
        private C1.Win.Gauge.C1Gauge c1Gauge1;
        private C1.Win.Gauge.C1LinearGauge rulerGauge;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
