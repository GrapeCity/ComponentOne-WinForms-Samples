namespace ControlExplorer.Gauges
{
    partial class SimpleGauges
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange2 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange3 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange4 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange5 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel2 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels2 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugePointer c1GaugePointer1 = new C1.Win.C1Gauge.C1GaugePointer();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange10 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks3 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks4 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels4 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange11 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange12 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange13 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange6 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange7 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange8 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange9 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels3 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.C1Gauge.C1GaugeMarks();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.c1Gauge1 = new C1.Win.C1Gauge.C1Gauge();
            this.c1RadialGauge1 = new C1.Win.C1Gauge.C1RadialGauge();
            this.c1Gauge2 = new C1.Win.C1Gauge.C1Gauge();
            this.c1RadialGauge2 = new C1.Win.C1Gauge.C1RadialGauge();
            this.c1Gauge3 = new C1.Win.C1Gauge.C1Gauge();
            this.c1LinearGauge1 = new C1.Win.C1Gauge.C1LinearGauge();
            this.c1Gauge4 = new C1.Win.C1Gauge.C1Gauge();
            this.c1LinearGauge2 = new C1.Win.C1Gauge.C1LinearGauge();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge4)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Gauge1.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1RadialGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(4, 4);
            this.c1Gauge1.Margin = new System.Windows.Forms.Padding(4);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(468, 350);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(637779738145036078));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1RadialGauge1.Cap.Radius = 5D;
            c1GaugeRange1.Border.Color = System.Drawing.SystemColors.ControlDark;
            c1GaugeRange1.Filling.Color = System.Drawing.SystemColors.ControlLight;
            c1GaugeRange1.FromPointerIndex = 100;
            c1GaugeRange1.Location = 60D;
            c1GaugeRange1.ViewTag = ((long)(640162063073460990));
            c1GaugeRange1.Width = 22D;
            c1GaugeRange2.Border.Color = System.Drawing.SystemColors.Highlight;
            c1GaugeRange2.Filling.Color = System.Drawing.SystemColors.Highlight;
            c1GaugeRange2.Location = 60D;
            c1GaugeRange2.Name = "Before";
            c1GaugeRange2.ToPointerIndex = 100;
            c1GaugeRange2.ViewTag = ((long)(640443538688254004));
            c1GaugeRange2.Width = 22D;
            c1GaugeSingleLabel1.Angle = 0D;
            c1GaugeSingleLabel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            c1GaugeSingleLabel1.FontSize = 18D;
            c1GaugeSingleLabel1.Format = "####0";
            c1GaugeSingleLabel1.Location = -20D;
            c1GaugeSingleLabel1.PointerIndex = 100;
            c1GaugeSingleLabel1.ViewTag = ((long)(642976825261498990));
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeRange1,
            c1GaugeRange2,
            c1GaugeSingleLabel1});
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1RadialGauge1.Pointer.CustomShape.EndWidth = 0.15D;
            this.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1RadialGauge1.Pointer.Length = 64D;
            this.c1RadialGauge1.Pointer.Offset = 0D;
            this.c1RadialGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom;
            this.c1RadialGauge1.Pointer.Value = 45D;
            this.c1RadialGauge1.PointerOriginY = 0.7D;
            this.c1RadialGauge1.Radius = 0.6D;
            this.c1RadialGauge1.StartAngle = -90D;
            this.c1RadialGauge1.SweepAngle = 180D;
            this.c1RadialGauge1.ViewTag = ((long)(639317637171740509));
            // 
            // c1Gauge2
            // 
            this.c1Gauge2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Gauge2.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1RadialGauge2});
            this.c1Gauge2.Location = new System.Drawing.Point(480, 4);
            this.c1Gauge2.Margin = new System.Windows.Forms.Padding(4);
            this.c1Gauge2.Name = "c1Gauge2";
            this.c1Gauge2.Size = new System.Drawing.Size(468, 350);
            this.c1Gauge2.TabIndex = 1;
            this.c1Gauge2.ViewTag = ((long)(673939112474135485));
            // 
            // c1RadialGauge2
            // 
            this.c1RadialGauge2.Cap.Border.Color = System.Drawing.Color.Transparent;
            this.c1RadialGauge2.Cap.Filling.Color = System.Drawing.Color.Transparent;
            c1GaugeRange3.Border.Color = System.Drawing.Color.Silver;
            c1GaugeRange3.Filling.Color = System.Drawing.Color.Gainsboro;
            c1GaugeRange3.Location = 62D;
            c1GaugeRange3.ViewTag = ((long)(678724189005611733));
            c1GaugeRange3.Width = 24D;
            c1GaugeRange4.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange4.Filling.Color = System.Drawing.Color.WhiteSmoke;
            c1GaugeRange4.Filling.Opacity = 0.8D;
            c1GaugeRange4.From = 0.4D;
            c1GaugeRange4.Location = 62D;
            c1GaugeRange4.ToPointerIndex = 0;
            c1GaugeRange4.ViewTag = ((long)(679005668368820277));
            c1GaugeRange4.Width = 22D;
            c1GaugeRange5.Border.Color = System.Drawing.Color.SteelBlue;
            c1GaugeRange5.Filling.Color = System.Drawing.Color.DodgerBlue;
            c1GaugeRange5.Location = 62D;
            c1GaugeRange5.ToPointerIndex = 100;
            c1GaugeRange5.ViewTag = ((long)(678442712392127481));
            c1GaugeRange5.Width = 10D;
            c1GaugeSingleLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            c1GaugeSingleLabel2.Format = "####0";
            c1GaugeSingleLabel2.Location = 0D;
            c1GaugeSingleLabel2.PointerIndex = 100;
            c1GaugeSingleLabel2.ViewTag = ((long)(693642383431092450));
            c1GaugeLabels1.Color = System.Drawing.Color.Gray;
            c1GaugeLabels1.From = 100D;
            c1GaugeLabels1.Interval = 100D;
            c1GaugeLabels1.OrthogonalOffset = 10D;
            c1GaugeLabels1.ViewTag = ((long)(704056960355416928));
            c1GaugeLabels2.Color = System.Drawing.Color.Gray;
            c1GaugeLabels2.From = 0D;
            c1GaugeLabels2.Interval = 100D;
            c1GaugeLabels2.OrthogonalOffset = -10D;
            c1GaugeLabels2.To = 0D;
            c1GaugeLabels2.ViewTag = ((long)(704338438500357676));
            this.c1RadialGauge2.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeRange3,
            c1GaugeRange4,
            c1GaugeRange5,
            c1GaugeSingleLabel2,
            c1GaugeLabels1,
            c1GaugeLabels2});
            c1GaugePointer1.Border.Color = System.Drawing.Color.Transparent;
            c1GaugePointer1.Filling.Color = System.Drawing.Color.Transparent;
            c1GaugePointer1.Name = "pointerOffset";
            c1GaugePointer1.Value = 55D;
            c1GaugePointer1.ViewTag = ((long)(679287144603580458));
            c1GaugePointer1.Visible = false;
            this.c1RadialGauge2.MorePointers.AddRange(new C1.Win.C1Gauge.C1GaugePointer[] {
            c1GaugePointer1});
            this.c1RadialGauge2.Name = "c1RadialGauge2";
            this.c1RadialGauge2.Pointer.Border.Color = System.Drawing.Color.Transparent;
            this.c1RadialGauge2.Pointer.Filling.Color = System.Drawing.Color.Transparent;
            this.c1RadialGauge2.Pointer.Value = 50D;
            this.c1RadialGauge2.PointerOriginY = 0.7D;
            this.c1RadialGauge2.Radius = 0.6D;
            this.c1RadialGauge2.StartAngle = -90D;
            this.c1RadialGauge2.SweepAngle = 180D;
            this.c1RadialGauge2.ViewTag = ((long)(677879762176235198));
            // 
            // c1Gauge3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.c1Gauge3, 2);
            this.c1Gauge3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Gauge3.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1LinearGauge1});
            this.c1Gauge3.Location = new System.Drawing.Point(4, 362);
            this.c1Gauge3.Margin = new System.Windows.Forms.Padding(4);
            this.c1Gauge3.Name = "c1Gauge3";
            this.c1Gauge3.Size = new System.Drawing.Size(944, 351);
            this.c1Gauge3.TabIndex = 2;
            this.c1Gauge3.ViewTag = ((long)(714190067052356887));
            // 
            // c1LinearGauge1
            // 
            c1GaugeRange10.Border.Color = System.Drawing.Color.Black;
            c1GaugeRange10.Filling.Color = System.Drawing.Color.Black;
            c1GaugeRange10.ViewTag = ((long)(717286292691556980));
            c1GaugeRange10.Width = 0.1D;
            c1GaugeMarks3.Border.Color = System.Drawing.Color.Black;
            c1GaugeMarks3.Filling.Color = System.Drawing.Color.Black;
            c1GaugeMarks3.Interval = 25D;
            c1GaugeMarks3.Length = 4D;
            c1GaugeMarks3.Location = 43D;
            c1GaugeMarks3.ViewTag = ((long)(736708070189897828));
            c1GaugeMarks3.Width = 0.1D;
            c1GaugeMarks4.Border.Color = System.Drawing.Color.Black;
            c1GaugeMarks4.Interval = 5D;
            c1GaugeMarks4.Length = 2D;
            c1GaugeMarks4.Location = 44D;
            c1GaugeMarks4.ViewTag = ((long)(740648722200817145));
            c1GaugeMarks4.Width = 0.1D;
            c1GaugeLabels4.Interval = 25D;
            c1GaugeLabels4.Location = 38D;
            c1GaugeLabels4.ViewTag = ((long)(740930198312349440));
            c1GaugeRange11.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange11.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            c1GaugeRange11.Location = 48D;
            c1GaugeRange11.Location2 = 48.5D;
            c1GaugeRange11.To = 49.5D;
            c1GaugeRange11.ViewTag = ((long)(741211674624702052));
            c1GaugeRange11.Width = 1D;
            c1GaugeRange11.Width2 = 2D;
            c1GaugeRange12.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange12.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            c1GaugeRange12.From = 50.5D;
            c1GaugeRange12.Location = 48.5D;
            c1GaugeRange12.Location2 = 49D;
            c1GaugeRange12.To = 99.5D;
            c1GaugeRange12.ViewTag = ((long)(741493151396224170));
            c1GaugeRange12.Width = 2D;
            c1GaugeRange12.Width2 = 3D;
            c1GaugeRange13.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange13.Filling.Color = System.Drawing.Color.LightCoral;
            c1GaugeRange13.From = 100.5D;
            c1GaugeRange13.Location = 49D;
            c1GaugeRange13.Location2 = 49.5D;
            c1GaugeRange13.ViewTag = ((long)(741774628525849801));
            c1GaugeRange13.Width = 3D;
            c1GaugeRange13.Width2 = 4D;
            this.c1LinearGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeRange10,
            c1GaugeMarks3,
            c1GaugeMarks4,
            c1GaugeLabels4,
            c1GaugeRange11,
            c1GaugeRange12,
            c1GaugeRange13});
            this.c1LinearGauge1.Maximum = 150D;
            this.c1LinearGauge1.Name = "c1LinearGauge1";
            this.c1LinearGauge1.Pointer.Border.Color = System.Drawing.Color.Black;
            this.c1LinearGauge1.Pointer.Filling.Color = System.Drawing.SystemColors.Desktop;
            this.c1LinearGauge1.Pointer.Length = 3D;
            this.c1LinearGauge1.Pointer.Offset = 43.5D;
            this.c1LinearGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Triangle;
            this.c1LinearGauge1.Pointer.Value = 50D;
            this.c1LinearGauge1.Pointer.Width = 3D;
            this.c1LinearGauge1.ViewTag = ((long)(716441866908225388));
            // 
            // c1Gauge4
            // 
            this.c1Gauge4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Gauge4.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1LinearGauge2});
            this.c1Gauge4.Location = new System.Drawing.Point(956, 4);
            this.c1Gauge4.Margin = new System.Windows.Forms.Padding(4);
            this.c1Gauge4.Name = "c1Gauge4";
            this.tableLayoutPanel1.SetRowSpan(this.c1Gauge4, 2);
            this.c1Gauge4.Size = new System.Drawing.Size(441, 709);
            this.c1Gauge4.TabIndex = 3;
            this.c1Gauge4.ViewTag = ((long)(871817599189911585));
            // 
            // c1LinearGauge2
            // 
            c1GaugeRange6.Border.Color = System.Drawing.SystemColors.Control;
            c1GaugeRange6.Filling.Color = System.Drawing.SystemColors.Control;
            c1GaugeRange6.ViewTag = ((long)(883076603783459191));
            c1GaugeRange6.Width = 22D;
            c1GaugeRange7.Border.Color = System.Drawing.Color.DarkGray;
            c1GaugeRange7.Filling.Color = System.Drawing.Color.DarkGray;
            c1GaugeRange7.FromPointerIndex = 100;
            c1GaugeRange7.ViewTag = ((long)(872662025214005804));
            c1GaugeRange7.Width = 18D;
            c1GaugeRange8.Border.Color = System.Drawing.Color.DodgerBlue;
            c1GaugeRange8.Filling.Color = System.Drawing.Color.DodgerBlue;
            c1GaugeRange8.ToPointerIndex = 100;
            c1GaugeRange8.ViewTag = ((long)(872943500927327535));
            c1GaugeRange8.Width = 18D;
            c1GaugeMarks1.Border.Color = System.Drawing.SystemColors.Control;
            c1GaugeMarks1.Filling.Color = System.Drawing.SystemColors.Control;
            c1GaugeMarks1.Interval = 10D;
            c1GaugeMarks1.Length = 20D;
            c1GaugeMarks1.Location = 45D;
            c1GaugeMarks1.ViewTag = ((long)(873787926996745707));
            c1GaugeMarks1.Width = 1D;
            c1GaugeRange9.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange9.Filling.Color = System.Drawing.Color.Black;
            c1GaugeRange9.From = 101D;
            c1GaugeRange9.Location = 32D;
            c1GaugeRange9.To = 149D;
            c1GaugeRange9.ViewTag = ((long)(892646753983524618));
            c1GaugeRange9.Width = 0.5D;
            c1GaugeLabels3.From = 100D;
            c1GaugeLabels3.Interval = 50D;
            c1GaugeLabels3.Location = 20D;
            c1GaugeLabels3.ViewTag = ((long)(893209706679185460));
            c1GaugeMarks2.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.Black;
            c1GaugeMarks2.From = 101D;
            c1GaugeMarks2.Interval = 48D;
            c1GaugeMarks2.Length = 4D;
            c1GaugeMarks2.Location = 30D;
            c1GaugeMarks2.ViewTag = ((long)(925579333281543316));
            c1GaugeMarks2.Width = 0.5D;
            this.c1LinearGauge2.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeRange6,
            c1GaugeRange7,
            c1GaugeRange8,
            c1GaugeMarks1,
            c1GaugeRange9,
            c1GaugeLabels3,
            c1GaugeMarks2});
            this.c1LinearGauge2.IsReversed = true;
            this.c1LinearGauge2.Maximum = 150D;
            this.c1LinearGauge2.Name = "c1LinearGauge2";
            this.c1LinearGauge2.Orientation = C1.Win.C1Gauge.C1GaugeOrientation.Vertical;
            this.c1LinearGauge2.Pointer.Value = 75D;
            this.c1LinearGauge2.Pointer.Visible = false;
            this.c1LinearGauge2.ViewTag = ((long)(872099074213158419));
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.Controls.Add(this.c1Gauge1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.c1Gauge4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.c1Gauge2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.c1Gauge3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1401, 717);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // SimpleGauges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 717);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SimpleGauges";
            this.Text = "SimpleGauges";
            this.Load += new System.EventHandler(this.SimpleGauges_Load);
            this.BackColorChanged += new System.EventHandler(this.SimpleGauges_BackColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge4)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private C1.Win.C1Gauge.C1Gauge c1Gauge1;
        private C1.Win.C1Gauge.C1Gauge c1Gauge2;
        private C1.Win.C1Gauge.C1RadialGauge c1RadialGauge2;
        private C1.Win.C1Gauge.C1Gauge c1Gauge3;
        private C1.Win.C1Gauge.C1LinearGauge c1LinearGauge1;
        private C1.Win.C1Gauge.C1Gauge c1Gauge4;
        private C1.Win.C1Gauge.C1LinearGauge c1LinearGauge2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.C1Gauge.C1RadialGauge c1RadialGauge1;
    }
}