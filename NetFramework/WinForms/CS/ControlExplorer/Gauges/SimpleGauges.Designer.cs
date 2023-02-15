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
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange4 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks5 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks6 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels3 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange5 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange6 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange7 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange3 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks3 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks4 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels2 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugePointer c1GaugePointer1 = new C1.Win.C1Gauge.C1GaugePointer();
            C1.Win.C1Gauge.C1GaugePointer c1GaugePointer2 = new C1.Win.C1Gauge.C1GaugePointer();
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
            this.c1Gauge1.Size = new System.Drawing.Size(479, 367);
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
            this.c1RadialGauge1.Pointer.SweepTime = 3D;
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
            this.c1Gauge2.Location = new System.Drawing.Point(491, 4);
            this.c1Gauge2.Margin = new System.Windows.Forms.Padding(4);
            this.c1Gauge2.Name = "c1Gauge2";
            this.c1Gauge2.Size = new System.Drawing.Size(479, 367);
            this.c1Gauge2.TabIndex = 1;
            this.c1Gauge2.ViewTag = ((long)(673939112474135485));
            // 
            // c1RadialGauge2
            // 
            this.c1RadialGauge2.Cap.Border.Color = System.Drawing.SystemColors.Highlight;
            this.c1RadialGauge2.Cap.Filling.Color = System.Drawing.SystemColors.Highlight;
            this.c1RadialGauge2.Cap.Radius = 5D;
            c1GaugeMarks1.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            c1GaugeMarks1.Border.Thickness = 1D;
            c1GaugeMarks1.Interval = 20D;
            c1GaugeMarks1.Length = 10D;
            c1GaugeMarks1.Location = 70D;
            c1GaugeMarks1.ViewTag = ((long)(651719695147658837));
            c1GaugeMarks1.Width = 0.1D;
            c1GaugeMarks2.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            c1GaugeMarks2.Interval = 2D;
            c1GaugeMarks2.Length = 6D;
            c1GaugeMarks2.Location = 74D;
            c1GaugeMarks2.ViewTag = ((long)(742721980681543851));
            c1GaugeMarks2.Width = 0.1D;
            c1GaugeLabels1.FontSize = 8D;
            c1GaugeLabels1.Interval = 20D;
            c1GaugeLabels1.Location = 60D;
            c1GaugeLabels1.ViewTag = ((long)(652001172366915324));
            this.c1RadialGauge2.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeMarks1,
            c1GaugeMarks2,
            c1GaugeLabels1});
            this.c1RadialGauge2.Name = "c1RadialGauge2";
            this.c1RadialGauge2.Pointer.Border.Color = System.Drawing.SystemColors.Highlight;
            this.c1RadialGauge2.Pointer.CustomShape.EndWidth = 0.15D;
            this.c1RadialGauge2.Pointer.Filling.Color = System.Drawing.SystemColors.Highlight;
            this.c1RadialGauge2.Pointer.Length = 74D;
            this.c1RadialGauge2.Pointer.Offset = 0D;
            this.c1RadialGauge2.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom;
            this.c1RadialGauge2.Pointer.SweepTime = 3D;
            this.c1RadialGauge2.Pointer.Value = 10.8D;
            this.c1RadialGauge2.ViewTag = ((long)(639317637171740509));
            // 
            // c1Gauge3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.c1Gauge3, 2);
            this.c1Gauge3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Gauge3.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1LinearGauge1});
            this.c1Gauge3.Location = new System.Drawing.Point(4, 379);
            this.c1Gauge3.Margin = new System.Windows.Forms.Padding(4);
            this.c1Gauge3.Name = "c1Gauge3";
            this.c1Gauge3.Size = new System.Drawing.Size(966, 368);
            this.c1Gauge3.TabIndex = 2;
            this.c1Gauge3.ViewTag = ((long)(714190067052356887));
            // 
            // c1LinearGauge1
            // 
            c1GaugeRange4.Border.Color = System.Drawing.Color.Black;
            c1GaugeRange4.Filling.Color = System.Drawing.Color.Black;
            c1GaugeRange4.ViewTag = ((long)(717286292691556980));
            c1GaugeRange4.Width = 0.1D;
            c1GaugeMarks5.Border.Color = System.Drawing.Color.Black;
            c1GaugeMarks5.Filling.Color = System.Drawing.Color.Black;
            c1GaugeMarks5.Interval = 25D;
            c1GaugeMarks5.Length = 4D;
            c1GaugeMarks5.Location = 43D;
            c1GaugeMarks5.ViewTag = ((long)(736708070189897828));
            c1GaugeMarks5.Width = 0.1D;
            c1GaugeMarks6.Border.Color = System.Drawing.Color.Black;
            c1GaugeMarks6.Interval = 5D;
            c1GaugeMarks6.Length = 2D;
            c1GaugeMarks6.Location = 44D;
            c1GaugeMarks6.ViewTag = ((long)(740648722200817145));
            c1GaugeMarks6.Width = 0.1D;
            c1GaugeLabels3.Interval = 25D;
            c1GaugeLabels3.Location = 38D;
            c1GaugeLabels3.ViewTag = ((long)(740930198312349440));
            c1GaugeRange5.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange5.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            c1GaugeRange5.Location = 48D;
            c1GaugeRange5.Location2 = 48.5D;
            c1GaugeRange5.To = 49.5D;
            c1GaugeRange5.ViewTag = ((long)(741211674624702052));
            c1GaugeRange5.Width = 1D;
            c1GaugeRange5.Width2 = 2D;
            c1GaugeRange6.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange6.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            c1GaugeRange6.From = 50.5D;
            c1GaugeRange6.Location = 48.5D;
            c1GaugeRange6.Location2 = 49D;
            c1GaugeRange6.To = 99.5D;
            c1GaugeRange6.ViewTag = ((long)(741493151396224170));
            c1GaugeRange6.Width = 2D;
            c1GaugeRange6.Width2 = 3D;
            c1GaugeRange7.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange7.Filling.Color = System.Drawing.Color.LightCoral;
            c1GaugeRange7.From = 100.5D;
            c1GaugeRange7.Location = 49D;
            c1GaugeRange7.Location2 = 49.5D;
            c1GaugeRange7.ViewTag = ((long)(741774628525849801));
            c1GaugeRange7.Width = 3D;
            c1GaugeRange7.Width2 = 4D;
            this.c1LinearGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeRange4,
            c1GaugeMarks5,
            c1GaugeMarks6,
            c1GaugeLabels3,
            c1GaugeRange5,
            c1GaugeRange6,
            c1GaugeRange7});
            this.c1LinearGauge1.Maximum = 150D;
            this.c1LinearGauge1.Name = "c1LinearGauge1";
            this.c1LinearGauge1.Pointer.Border.Color = System.Drawing.Color.Black;
            this.c1LinearGauge1.Pointer.Filling.Color = System.Drawing.SystemColors.Desktop;
            this.c1LinearGauge1.Pointer.Length = 3D;
            this.c1LinearGauge1.Pointer.Offset = 43.5D;
            this.c1LinearGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Triangle;
            this.c1LinearGauge1.Pointer.SweepTime = 5D;
            this.c1LinearGauge1.Pointer.Value = 50D;
            this.c1LinearGauge1.Pointer.Width = 3D;
            this.c1LinearGauge1.ViewTag = ((long)(716441866908225388));
            // 
            // c1Gauge4
            // 
            this.c1Gauge4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Gauge4.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1LinearGauge2});
            this.c1Gauge4.Location = new System.Drawing.Point(978, 4);
            this.c1Gauge4.Margin = new System.Windows.Forms.Padding(4);
            this.c1Gauge4.Name = "c1Gauge4";
            this.tableLayoutPanel1.SetRowSpan(this.c1Gauge4, 2);
            this.c1Gauge4.Size = new System.Drawing.Size(451, 743);
            this.c1Gauge4.TabIndex = 3;
            this.c1Gauge4.ViewTag = ((long)(871817599189911585));
            // 
            // c1LinearGauge2
            // 
            this.c1LinearGauge2.AxisLength = 0.88D;
            c1GaugeRange3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeRange3.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeRange3.ViewTag = ((long)(717286292691556980));
            c1GaugeRange3.Width = 0.5D;
            c1GaugeMarks3.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            c1GaugeMarks3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeMarks3.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeMarks3.Interval = 10D;
            c1GaugeMarks3.Length = 15D;
            c1GaugeMarks3.Location = 45D;
            c1GaugeMarks3.ViewTag = ((long)(736708070189897828));
            c1GaugeMarks3.Width = 0.1D;
            c1GaugeMarks4.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            c1GaugeMarks4.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeMarks4.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeMarks4.Interval = 1D;
            c1GaugeMarks4.Length = 10D;
            c1GaugeMarks4.Location = 45D;
            c1GaugeMarks4.ViewTag = ((long)(740648722200817145));
            c1GaugeMarks4.Width = 0.1D;
            c1GaugeLabels2.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            c1GaugeLabels2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeLabels2.FontSize = 12D;
            c1GaugeLabels2.Interval = 10D;
            c1GaugeLabels2.Location = 28D;
            c1GaugeLabels2.ViewTag = ((long)(740930198312349440));
            this.c1LinearGauge2.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeRange3,
            c1GaugeMarks3,
            c1GaugeMarks4,
            c1GaugeLabels2});
            this.c1LinearGauge2.IsReversed = true;
            this.c1LinearGauge2.Maximum = 50D;
            c1GaugePointer1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            c1GaugePointer1.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            c1GaugePointer1.FlipShape = true;
            c1GaugePointer1.Length = 15D;
            c1GaugePointer1.Offset = 40D;
            c1GaugePointer1.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Triangle;
            c1GaugePointer1.SweepTime = 2D;
            c1GaugePointer1.Value = 15D;
            c1GaugePointer1.ViewTag = ((long)(845464713497643339));
            c1GaugePointer1.Width = 15D;
            c1GaugePointer2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            c1GaugePointer2.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            c1GaugePointer2.FlipShape = true;
            c1GaugePointer2.Length = 15D;
            c1GaugePointer2.Offset = 40D;
            c1GaugePointer2.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Triangle;
            c1GaugePointer2.SweepTime = 2D;
            c1GaugePointer2.Value = 26D;
            c1GaugePointer2.ViewTag = ((long)(845746188908663134));
            c1GaugePointer2.Width = 15D;
            this.c1LinearGauge2.MorePointers.AddRange(new C1.Win.C1Gauge.C1GaugePointer[] {
            c1GaugePointer1,
            c1GaugePointer2});
            this.c1LinearGauge2.Name = "c1LinearGauge2";
            this.c1LinearGauge2.Orientation = C1.Win.C1Gauge.C1GaugeOrientation.Vertical;
            this.c1LinearGauge2.Pointer.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(249)))), ((int)(((byte)(147)))));
            this.c1LinearGauge2.Pointer.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(249)))), ((int)(((byte)(147)))));
            this.c1LinearGauge2.Pointer.FlipShape = true;
            this.c1LinearGauge2.Pointer.Length = 15D;
            this.c1LinearGauge2.Pointer.Offset = 40D;
            this.c1LinearGauge2.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Triangle;
            this.c1LinearGauge2.Pointer.SweepTime = 2D;
            this.c1LinearGauge2.Pointer.Value = 35D;
            this.c1LinearGauge2.Pointer.Width = 15D;
            this.c1LinearGauge2.Viewport.AspectRatio = 0.3D;
            this.c1LinearGauge2.ViewTag = ((long)(716441866908225388));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1433, 751);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // SimpleGauges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 751);
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
        private C1.Win.C1Gauge.C1Gauge c1Gauge3;
        private C1.Win.C1Gauge.C1LinearGauge c1LinearGauge1;
        private C1.Win.C1Gauge.C1Gauge c1Gauge4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.C1Gauge.C1RadialGauge c1RadialGauge1;
        private C1.Win.C1Gauge.C1RadialGauge c1RadialGauge2;
        private C1.Win.C1Gauge.C1LinearGauge c1LinearGauge2;
    }
}