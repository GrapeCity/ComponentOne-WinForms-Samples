namespace GaugeDemo
{
    partial class PageMultithreaded
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel2 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel3 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel4 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel5 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeSingleMark c1GaugeSingleMark1 = new C1.Win.C1Gauge.C1GaugeSingleMark();
            C1.Win.C1Gauge.C1GaugeRectangle c1GaugeRectangle1 = new C1.Win.C1Gauge.C1GaugeRectangle();
            C1.Win.C1Gauge.C1GaugePointer c1GaugePointer1 = new C1.Win.C1Gauge.C1GaugePointer();
            C1.Win.C1Gauge.C1GaugePointer c1GaugePointer2 = new C1.Win.C1Gauge.C1GaugePointer();
            this.c1Gauge1 = new C1.Win.C1Gauge.C1Gauge();
            this.c1LinearGauge1 = new C1.Win.C1Gauge.C1LinearGauge();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gaugePanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugePanel
            // 
            this.gaugePanel.Controls.Add(this.button3);
            this.gaugePanel.Controls.Add(this.button2);
            this.gaugePanel.Controls.Add(this.button1);
            this.gaugePanel.Controls.Add(this.c1Gauge1);
            // 
            // gaugeGrid
            // 
            this.gaugeGrid.SelectedObject = this.c1LinearGauge1;
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Gauge1.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1LinearGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(8, 3);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(376, 330);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(636563101699690835));
            // 
            // c1LinearGauge1
            // 
            c1GaugeMarks1.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.Black;
            c1GaugeMarks1.Interval = 10;
            c1GaugeMarks1.Length = 10;
            c1GaugeMarks1.Location = 50;
            c1GaugeMarks1.ViewTag = ((long)(678503004323206706));
            c1GaugeMarks1.Width = 1;
            c1GaugeMarks2.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.Black;
            c1GaugeMarks2.Interval = 2.5;
            c1GaugeMarks2.Length = 6;
            c1GaugeMarks2.Location = 50;
            c1GaugeMarks2.ViewTag = ((long)(674843755455865891));
            c1GaugeMarks2.Width = 1;
            c1GaugeLabels1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeLabels1.FontSize = 6;
            c1GaugeLabels1.Interval = 10;
            c1GaugeLabels1.ViewTag = ((long)(675125231244322976));
            c1GaugeSingleLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeSingleLabel1.FontSize = 7;
            c1GaugeSingleLabel1.Location = 95;
            c1GaugeSingleLabel1.PointerIndex = 100;
            c1GaugeSingleLabel1.Position = 0.5;
            c1GaugeSingleLabel1.Text = "Value is below Minimum";
            c1GaugeSingleLabel1.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None;
            c1GaugeSingleLabel1.ValueColors.AddRange(new C1.Win.C1Gauge.C1GaugeValueColor[] {
            new C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.CornflowerBlue, 1, ((long)(673717850602170323))),
            new C1.Win.C1Gauge.C1GaugeValueColor(double.NaN, 0, System.Drawing.Color.White, 0, ((long)(673999326115721684)))});
            c1GaugeSingleLabel1.ViewTag = ((long)(673154898766071328));
            c1GaugeSingleLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeSingleLabel2.FontSize = 7;
            c1GaugeSingleLabel2.Location = 95;
            c1GaugeSingleLabel2.PointerIndex = 100;
            c1GaugeSingleLabel2.Position = 0.5;
            c1GaugeSingleLabel2.Text = "Value is above Maximum";
            c1GaugeSingleLabel2.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None;
            c1GaugeSingleLabel2.ValueColors.AddRange(new C1.Win.C1Gauge.C1GaugeValueColor[] {
            new C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.White, 0, ((long)(674280801592380936))),
            new C1.Win.C1Gauge.C1GaugeValueColor(double.NaN, 1, System.Drawing.Color.IndianRed, 1, ((long)(674562276824086177)))});
            c1GaugeSingleLabel2.ViewTag = ((long)(673436374572339432));
            c1GaugeRange1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeRange1.Location = 24;
            c1GaugeRange1.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None;
            c1GaugeRange1.ValueColors.AddRange(new C1.Win.C1Gauge.C1GaugeValueColor[] {
            new C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.CornflowerBlue, 1, ((long)(675688185048714551))),
            new C1.Win.C1Gauge.C1GaugeValueColor(double.NaN, 0, System.Drawing.Color.LimeGreen, 1, ((long)(675969660391416140))),
            new C1.Win.C1Gauge.C1GaugeValueColor(double.NaN, 1, System.Drawing.Color.IndianRed, 1, ((long)(676251135433310524)))});
            c1GaugeRange1.ViewTag = ((long)(675406709646489557));
            c1GaugeSingleLabel3.Color = System.Drawing.Color.White;
            c1GaugeSingleLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeSingleLabel3.FontSize = 7;
            c1GaugeSingleLabel3.Format = "\"value = \"0";
            c1GaugeSingleLabel3.ImmediateUpdate = true;
            c1GaugeSingleLabel3.Location = 7;
            c1GaugeSingleLabel3.PointerIndex = 100;
            c1GaugeSingleLabel3.Position = 0.5;
            c1GaugeSingleLabel3.ViewTag = ((long)(676532625544886845));
            c1GaugeSingleLabel4.Color = System.Drawing.Color.White;
            c1GaugeSingleLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeSingleLabel4.FontSize = 7;
            c1GaugeSingleLabel4.Format = "\"min = \"0";
            c1GaugeSingleLabel4.ImmediateUpdate = true;
            c1GaugeSingleLabel4.Location = 7;
            c1GaugeSingleLabel4.OrthogonalAlignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeSingleLabel4.PointerIndex = 0;
            c1GaugeSingleLabel4.Position = 0;
            c1GaugeSingleLabel4.ViewTag = ((long)(676814100673526191));
            c1GaugeSingleLabel5.Color = System.Drawing.Color.White;
            c1GaugeSingleLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeSingleLabel5.FontSize = 7;
            c1GaugeSingleLabel5.Format = "\"max = \"0";
            c1GaugeSingleLabel5.ImmediateUpdate = true;
            c1GaugeSingleLabel5.Location = 7;
            c1GaugeSingleLabel5.OrthogonalAlignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            c1GaugeSingleLabel5.PointerIndex = 1;
            c1GaugeSingleLabel5.Position = 1;
            c1GaugeSingleLabel5.ViewTag = ((long)(677095575673368170));
            c1GaugeSingleMark1.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeSingleMark1.Border.Color = System.Drawing.Color.Black;
            c1GaugeSingleMark1.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialOuter;
            c1GaugeSingleMark1.Length = 15;
            c1GaugeSingleMark1.Location = 33;
            c1GaugeSingleMark1.PointerIndex = 100;
            c1GaugeSingleMark1.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Triangle;
            c1GaugeSingleMark1.ValueColors.AddRange(new C1.Win.C1Gauge.C1GaugeValueColor[] {
            new C1.Win.C1Gauge.C1GaugeValueColor(double.NaN, 0, System.Drawing.Color.CornflowerBlue, 1, ((long)(677658542811202374))),
            new C1.Win.C1Gauge.C1GaugeValueColor(50, -1, System.Drawing.Color.White, 1, ((long)(677940017979483988))),
            new C1.Win.C1Gauge.C1GaugeValueColor(double.NaN, 1, System.Drawing.Color.IndianRed, 1, ((long)(678221493208209058)))});
            c1GaugeSingleMark1.ViewTag = ((long)(677377064084777247));
            c1GaugeSingleMark1.Width = 9;
            this.c1LinearGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeMarks1,
            c1GaugeMarks2,
            c1GaugeLabels1,
            c1GaugeSingleLabel1,
            c1GaugeSingleLabel2,
            c1GaugeRange1,
            c1GaugeSingleLabel3,
            c1GaugeSingleLabel4,
            c1GaugeSingleLabel5,
            c1GaugeSingleMark1});
            c1GaugeRectangle1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeRectangle1.CornerRadius = 10;
            c1GaugeRectangle1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeRectangle1.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            c1GaugeRectangle1.Filling.Color2 = System.Drawing.Color.White;
            c1GaugeRectangle1.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.Vertical;
            c1GaugeRectangle1.Gradient.Falloff = C1.Win.C1Gauge.C1GaugeGradientFalloff.SigmaBell;
            c1GaugeRectangle1.Height = -1.1;
            c1GaugeRectangle1.Width = -1.1;
            this.c1LinearGauge1.FaceShapes.AddRange(new C1.Win.C1Gauge.C1GaugeBaseShape[] {
            c1GaugeRectangle1});
            c1GaugePointer1.Filling.Color = System.Drawing.Color.CornflowerBlue;
            c1GaugePointer1.FlipShape = true;
            c1GaugePointer1.Length = 15;
            c1GaugePointer1.Name = "min";
            c1GaugePointer1.Offset = 70;
            c1GaugePointer1.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Triangle;
            c1GaugePointer1.SweepTime = 6;
            c1GaugePointer1.Value = 40;
            c1GaugePointer1.ViewTag = ((long)(640222285677810199));
            c1GaugePointer2.Filling.Color = System.Drawing.Color.IndianRed;
            c1GaugePointer2.FlipShape = true;
            c1GaugePointer2.Length = 15;
            c1GaugePointer2.Name = "max";
            c1GaugePointer2.Offset = 70;
            c1GaugePointer2.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Triangle;
            c1GaugePointer2.SweepTime = 6;
            c1GaugePointer2.Value = 60;
            c1GaugePointer2.ViewTag = ((long)(640503760658591088));
            this.c1LinearGauge1.MorePointers.AddRange(new C1.Win.C1Gauge.C1GaugePointer[] {
            c1GaugePointer1,
            c1GaugePointer2});
            this.c1LinearGauge1.Name = "c1LinearGauge1";
            this.c1LinearGauge1.Pointer.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            this.c1LinearGauge1.Pointer.Border.Color = System.Drawing.Color.Black;
            this.c1LinearGauge1.Pointer.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.None;
            this.c1LinearGauge1.Pointer.Length = 15;
            this.c1LinearGauge1.Pointer.Offset = 33;
            this.c1LinearGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Rectangle;
            this.c1LinearGauge1.Pointer.SweepTime = 6;
            this.c1LinearGauge1.Pointer.Value = 50;
            this.c1LinearGauge1.Pointer.Width = 0.01;
            this.c1LinearGauge1.Viewport.AspectRatio = 1.6;
            this.c1LinearGauge1.ViewTag = ((long)(636844576723984213));
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(221, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Thread 1 (value)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(221, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start Thread 2 (min)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(221, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Start Thread 3 (max)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PageCase12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageCase12";
            this.gaugePanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Gauge.C1Gauge c1Gauge1;
        private C1.Win.C1Gauge.C1LinearGauge c1LinearGauge1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}
