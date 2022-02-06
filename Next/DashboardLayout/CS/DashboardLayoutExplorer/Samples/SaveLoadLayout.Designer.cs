namespace SampleExplorer
{
    partial class SaveLoadLayout
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
                _defaultLayout?.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveLoadLayout));
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series2 = new C1.Win.Chart.Series();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks11 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks12 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeLabels c1GaugeLabels6 = new C1.Win.Gauge.C1GaugeLabels();
            C1.Win.Gauge.C1GaugeEllipse c1GaugeEllipse6 = new C1.Win.Gauge.C1GaugeEllipse();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer16 = new C1.Win.Gauge.C1GaugePointer();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer17 = new C1.Win.Gauge.C1GaugePointer();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer18 = new C1.Win.Gauge.C1GaugePointer();
            C1.Win.Chart.FlexPieSlice flexPieSlice5 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice6 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice7 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice8 = new C1.Win.Chart.FlexPieSlice();
            this.c1CommandDock1 = new C1.Win.Command.C1CommandDock();
            this.c1ToolBar1 = new C1.Win.Command.C1ToolBar();
            this.c1CommandHolder1 = new C1.Win.Command.C1CommandHolder();
            this.c1Command1 = new C1.Win.Command.C1Command();
            this.c1CommandLink1 = new C1.Win.Command.C1CommandLink();
            this.commandSave = new C1.Win.Command.C1Command();
            this.c1CommandLink2 = new C1.Win.Command.C1CommandLink();
            this.commandLoad = new C1.Win.Command.C1Command();
            this.c1CommandLink3 = new C1.Win.Command.C1CommandLink();
            this.commandReset = new C1.Win.Command.C1Command();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.c1DashboardLayout1 = new C1.Win.Layout.C1DashboardLayout();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flexChart1 = new C1.Win.Chart.FlexChart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.c1Gauge1 = new C1.Win.Gauge.C1Gauge();
            this.c1RadialGauge1 = new C1.Win.Gauge.C1RadialGauge();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flexPie1 = new C1.Win.Chart.FlexPie();
            this.panel7 = new System.Windows.Forms.Panel();
            this.c1CalendarView1 = new C1.Win.Calendar.C1CalendarView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
            this.c1CommandDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DashboardLayout1)).BeginInit();
            this.c1DashboardLayout1.GridLayoutControl.SuspendLayout();
            this.c1DashboardLayout1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1CommandDock1
            // 
            this.c1CommandDock1.Controls.Add(this.c1ToolBar1);
            this.c1CommandDock1.Id = 2;
            this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
            this.c1CommandDock1.Name = "c1CommandDock1";
            this.c1CommandDock1.Size = new System.Drawing.Size(800, 26);
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.AccessibleName = "Tool Bar";
            this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3});
            this.c1ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.c1ToolBar1.Movable = false;
            this.c1ToolBar1.Name = "c1ToolBar1";
            this.c1ToolBar1.Size = new System.Drawing.Size(298, 26);
            this.c1ToolBar1.Text = "c1ToolBar1";
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1Command1);
            this.c1CommandHolder1.Commands.Add(this.commandSave);
            this.c1CommandHolder1.Commands.Add(this.commandLoad);
            this.c1CommandHolder1.Commands.Add(this.commandReset);
            this.c1CommandHolder1.Owner = this;
            // 
            // c1Command1
            // 
            this.c1Command1.Name = "c1Command1";
            this.c1Command1.ShortcutText = "";
            this.c1Command1.Text = "New Command";
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.ButtonLook = ((C1.Win.Command.ButtonLookFlags)((C1.Win.Command.ButtonLookFlags.Text | C1.Win.Command.ButtonLookFlags.Image)));
            this.c1CommandLink1.Command = this.commandSave;
            this.c1CommandLink1.Text = "&Save Layout";
            // 
            // commandSave
            // 
            this.commandSave.Image = ((System.Drawing.Image)(resources.GetObject("commandSave.Image")));
            this.commandSave.Name = "commandSave";
            this.commandSave.ShortcutText = "";
            this.commandSave.Text = "&Save Layout";
            this.commandSave.ToolTipText = "Save Layout";
            this.commandSave.Click += new C1.Win.Command.ClickEventHandler(this.commandSave_Click);
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.ButtonLook = ((C1.Win.Command.ButtonLookFlags)((C1.Win.Command.ButtonLookFlags.Text | C1.Win.Command.ButtonLookFlags.Image)));
            this.c1CommandLink2.Command = this.commandLoad;
            this.c1CommandLink2.SortOrder = 1;
            this.c1CommandLink2.Text = "&Load  Layout";
            this.c1CommandLink2.ToolTipText = "Load Layout";
            // 
            // commandLoad
            // 
            this.commandLoad.Image = ((System.Drawing.Image)(resources.GetObject("commandLoad.Image")));
            this.commandLoad.Name = "commandLoad";
            this.commandLoad.ShortcutText = "";
            this.commandLoad.Text = "&Load Layout";
            this.commandLoad.Click += new C1.Win.Command.ClickEventHandler(this.commandLoad_Click);
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.ButtonLook = ((C1.Win.Command.ButtonLookFlags)((C1.Win.Command.ButtonLookFlags.Text | C1.Win.Command.ButtonLookFlags.Image)));
            this.c1CommandLink3.Command = this.commandReset;
            this.c1CommandLink3.SortOrder = 2;
            this.c1CommandLink3.Text = "&Reset Layout";
            this.c1CommandLink3.ToolTipText = "Reset Layout";
            // 
            // commandReset
            // 
            this.commandReset.Image = ((System.Drawing.Image)(resources.GetObject("commandReset.Image")));
            this.commandReset.Name = "commandReset";
            this.commandReset.ShortcutText = "";
            this.commandReset.Text = "&Reset Layout";
            this.commandReset.Click += new C1.Win.Command.ClickEventHandler(this.commandReset_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML files|*.xml";
            this.saveFileDialog1.Tag = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "XML files|*.xml";
            this.openFileDialog1.Tag = "";
            // 
            // c1DashboardLayout1
            // 
            this.c1DashboardLayout1.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // c1DashboardLayout1.FlowContentPanel
            // 
            this.c1DashboardLayout1.FlowLayoutControl.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.FlowLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.c1DashboardLayout1.FlowLayoutControl.Name = "FlowContentPanel";
            this.c1DashboardLayout1.FlowLayoutControl.Size = new System.Drawing.Size(200, 100);
            this.c1DashboardLayout1.FlowLayoutControl.TabIndex = 0;
            // 
            // c1DashboardLayout1.GridContentPanel
            // 
            this.c1DashboardLayout1.GridLayoutControl.AutoScroll = true;
            this.c1DashboardLayout1.GridLayoutControl.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.GridLayoutControl.ColumnCount = 3;
            this.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel1, 2, 0);
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel3, 1, 1);
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel5, 1, 0);
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel7, 0, 0);
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel9, 0, 1);
            this.c1DashboardLayout1.GridLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.GridLayoutControl.Location = new System.Drawing.Point(10, 10);
            this.c1DashboardLayout1.GridLayoutControl.Name = "GridContentPanel";
            this.c1DashboardLayout1.GridLayoutControl.RowCount = 2;
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.Size = new System.Drawing.Size(780, 404);
            this.c1DashboardLayout1.GridLayoutControl.TabIndex = 0;
            this.c1DashboardLayout1.LayoutType = C1.Win.Layout.LayoutType.Grid;
            this.c1DashboardLayout1.Location = new System.Drawing.Point(0, 26);
            this.c1DashboardLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.c1DashboardLayout1.Name = "c1DashboardLayout1";
            this.c1DashboardLayout1.Size = new System.Drawing.Size(800, 424);
            // 
            // c1DashboardLayout1.SplitContentPanel
            // 
            this.c1DashboardLayout1.SplitLayoutControl.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1DashboardLayout1.SplitLayoutControl.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SplitLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SplitLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.c1DashboardLayout1.SplitLayoutControl.Name = "SplitContentPanel";
            this.c1DashboardLayout1.SplitLayoutControl.Size = new System.Drawing.Size(0, 0);
            this.c1DashboardLayout1.SplitLayoutControl.TabIndex = 0;
            this.c1DashboardLayout1.SplitLayoutControl.UseParentVisualStyle = false;
            this.c1DashboardLayout1.TabIndex = 1;
            this.c1DashboardLayout1.Text = "c1DashboardLayout1";
            // 
            // panel1
            // 
            this.c1DashboardLayout1.SetCaption(this.panel1, "Sales By Country");
            this.panel1.Controls.Add(this.flexChart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel1, "cf9b0a9d-9a3f-4d48-947b-257ba31c3b16");
            this.panel1.Location = new System.Drawing.Point(520, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.c1DashboardLayout1.GridLayoutControl.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(260, 404);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "Sales By Country";
            // 
            // flexChart1
            // 
            this.flexChart1.AxisX.Chart = this.flexChart1;
            this.flexChart1.AxisX.DataSource = null;
            this.flexChart1.AxisX.GroupProvider = null;
            this.flexChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.flexChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.flexChart1.AxisX.GroupVisibilityLevel = 0;
            this.flexChart1.AxisX.LabelMax = false;
            this.flexChart1.AxisX.LabelMin = false;
            this.flexChart1.AxisX.PlotAreaName = null;
            this.flexChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.flexChart1.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.flexChart1.AxisY.AxisLine = false;
            this.flexChart1.AxisY.Chart = this.flexChart1;
            this.flexChart1.AxisY.DataSource = null;
            this.flexChart1.AxisY.GroupProvider = null;
            this.flexChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.flexChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.flexChart1.AxisY.GroupVisibilityLevel = 0;
            this.flexChart1.AxisY.LabelMax = false;
            this.flexChart1.AxisY.LabelMin = false;
            this.flexChart1.AxisY.MajorGrid = true;
            this.flexChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.flexChart1.AxisY.PlotAreaName = null;
            this.flexChart1.AxisY.Position = C1.Chart.Position.Left;
            this.flexChart1.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.flexChart1.ChartType = C1.Chart.ChartType.Bar;
            this.flexChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexChart1.Legend.ItemMaxWidth = 0;
            this.flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexChart1.Legend.Position = C1.Chart.Position.None;
            this.flexChart1.Legend.Reversed = false;
            this.flexChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.flexChart1.Legend.Title = null;
            this.flexChart1.Location = new System.Drawing.Point(10, 10);
            this.flexChart1.Margin = new System.Windows.Forms.Padding(10);
            this.flexChart1.Name = "flexChart1";
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.flexChart1.Options.ClusterSize = elementSize2;
            this.flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexChart1.SelectedSeries = null;
            this.flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series2.DataLabel = null;
            series2.Name = "Series 1";
            series2.StackingGroup = -1;
            series2.Style.StrokeWidth = 2F;
            this.flexChart1.Series.Add(series2);
            this.flexChart1.Size = new System.Drawing.Size(240, 384);
            this.flexChart1.TabIndex = 0;
            this.flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            this.flexChart1.ToolTip.Content = "{value}";
            // 
            // panel3
            // 
            this.c1DashboardLayout1.SetCaption(this.panel3, "Current Time");
            this.panel3.Controls.Add(this.c1Gauge1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel3, "c451c2d6-7660-47e9-9e27-1ebe098d5624");
            this.panel3.Location = new System.Drawing.Point(260, 202);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(260, 202);
            this.panel3.TabIndex = 1;
            this.panel3.Text = "Current Time";
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Gauge1.Gauges.AddRange(new C1.Win.Gauge.C1GaugeBase[] {
            this.c1RadialGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(10, 10);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(240, 182);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(637189667974941086));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Border.Color = System.Drawing.Color.DarkSeaGreen;
            this.c1RadialGauge1.Cap.Border.Thickness = 1.5D;
            this.c1RadialGauge1.Cap.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient;
            this.c1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.MistyRose;
            this.c1RadialGauge1.Cap.Filling.Color2 = System.Drawing.Color.DimGray;
            this.c1RadialGauge1.Cap.Radius = 5D;
            this.c1RadialGauge1.Cap.Shadow.Visible = true;
            c1GaugeMarks11.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks11.CustomShape.EndRadius = 2.5D;
            c1GaugeMarks11.CustomShape.StartRadius = 1.5D;
            c1GaugeMarks11.CustomShape.StartWidth = 3D;
            c1GaugeMarks11.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeMarks11.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugeMarks11.From = 0.5D;
            c1GaugeMarks11.Interval = 5D;
            c1GaugeMarks11.Length = 12D;
            c1GaugeMarks11.Location = 86D;
            c1GaugeMarks11.ScaleFrom = 0D;
            c1GaugeMarks11.Shadow.OffsetX = 0.5D;
            c1GaugeMarks11.Shadow.OffsetY = 0.5D;
            c1GaugeMarks11.Shadow.Visible = true;
            c1GaugeMarks11.Shape = C1.Win.Gauge.C1GaugeMarkShape.Custom;
            c1GaugeMarks11.ViewTag = ((long)(634302468273582893));
            c1GaugeMarks12.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks12.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            c1GaugeMarks12.From = 0.5D;
            c1GaugeMarks12.Interval = 1D;
            c1GaugeMarks12.Length = 3D;
            c1GaugeMarks12.Location = 90D;
            c1GaugeMarks12.ScaleFrom = 0D;
            c1GaugeMarks12.Shadow.OffsetX = 0.5D;
            c1GaugeMarks12.Shadow.OffsetY = 0.5D;
            c1GaugeMarks12.Shadow.Visible = true;
            c1GaugeMarks12.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks12.ViewTag = ((long)(634583943250743575));
            c1GaugeMarks12.Width = 3D;
            c1GaugeLabels6.Color = System.Drawing.Color.White;
            c1GaugeLabels6.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            c1GaugeLabels6.FontSize = 17D;
            c1GaugeLabels6.From = 0.5D;
            c1GaugeLabels6.Interval = 5D;
            c1GaugeLabels6.Location = 68D;
            c1GaugeLabels6.Name = "nums";
            c1GaugeLabels6.ScaleFrom = 0D;
            c1GaugeLabels6.Shadow.OffsetX = 0.5D;
            c1GaugeLabels6.Shadow.OffsetY = 0.5D;
            c1GaugeLabels6.Shadow.Visible = true;
            c1GaugeLabels6.ValueFactor = 0.2D;
            c1GaugeLabels6.ViewTag = ((long)(634865418227634241));
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeMarks11,
            c1GaugeMarks12,
            c1GaugeLabels6});
            c1GaugeEllipse6.Border.Color = System.Drawing.Color.DarkSeaGreen;
            c1GaugeEllipse6.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeEllipse6.Border.Thickness = 2D;
            c1GaugeEllipse6.Filling.Color = System.Drawing.Color.RoyalBlue;
            c1GaugeEllipse6.Filling.Color2 = System.Drawing.Color.DarkSlateGray;
            c1GaugeEllipse6.Gradient.CenterPointX = 0D;
            c1GaugeEllipse6.Gradient.CenterPointY = 0D;
            c1GaugeEllipse6.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialInner;
            c1GaugeEllipse6.Height = -0.97D;
            c1GaugeEllipse6.HitTestable = false;
            c1GaugeEllipse6.Width = -0.97D;
            this.c1RadialGauge1.FaceShapes.AddRange(new C1.Win.Gauge.C1GaugeBaseShape[] {
            c1GaugeEllipse6});
            this.c1RadialGauge1.Maximum = 60D;
            c1GaugePointer16.Border.Color = System.Drawing.Color.DimGray;
            c1GaugePointer16.CustomShape.EndRadius = 1.928571428571D;
            c1GaugePointer16.CustomShape.EndWidth = 3.857142857144D;
            c1GaugePointer16.CustomShape.StartRadius = 2.571428571429D;
            c1GaugePointer16.CustomShape.StartWidth = 9D;
            c1GaugePointer16.Filling.Color = System.Drawing.Color.DarkGray;
            c1GaugePointer16.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugePointer16.Length = 63D;
            c1GaugePointer16.Name = "hours";
            c1GaugePointer16.Offset = -15D;
            c1GaugePointer16.Shadow.Visible = true;
            c1GaugePointer16.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom;
            c1GaugePointer16.Value = 0.42D;
            c1GaugePointer16.ValueFactor = 5D;
            c1GaugePointer16.ViewTag = ((long)(635146893204754921));
            c1GaugePointer17.Border.Color = System.Drawing.Color.DimGray;
            c1GaugePointer17.CustomShape.EndRadius = 1.928571428571D;
            c1GaugePointer17.CustomShape.EndWidth = 3.857142857144D;
            c1GaugePointer17.CustomShape.StartRadius = 2.571428571429D;
            c1GaugePointer17.CustomShape.StartWidth = 9D;
            c1GaugePointer17.Filling.Color = System.Drawing.Color.DarkGray;
            c1GaugePointer17.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugePointer17.Length = 94D;
            c1GaugePointer17.Name = "minutes";
            c1GaugePointer17.Offset = -15D;
            c1GaugePointer17.Shadow.Visible = true;
            c1GaugePointer17.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom;
            c1GaugePointer17.Value = 22.3D;
            c1GaugePointer17.ViewTag = ((long)(635428368181515579));
            c1GaugePointer18.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugePointer18.Filling.Color = System.Drawing.Color.DarkGray;
            c1GaugePointer18.Length = 115D;
            c1GaugePointer18.Name = "seconds";
            c1GaugePointer18.Offset = -25D;
            c1GaugePointer18.Shadow.Visible = true;
            c1GaugePointer18.Shape = C1.Win.Gauge.C1GaugePointerShape.Round;
            c1GaugePointer18.Value = 17D;
            c1GaugePointer18.ViewTag = ((long)(635709843158236236));
            c1GaugePointer18.Width = 2D;
            this.c1RadialGauge1.MorePointers.AddRange(new C1.Win.Gauge.C1GaugePointer[] {
            c1GaugePointer16,
            c1GaugePointer17,
            c1GaugePointer18});
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Visible = false;
            this.c1RadialGauge1.Radius = 0.49D;
            this.c1RadialGauge1.StartAngle = 0D;
            this.c1RadialGauge1.SweepAngle = 360D;
            this.c1RadialGauge1.ViewTag = ((long)(636272793112967623));
            // 
            // panel5
            // 
            this.c1DashboardLayout1.SetCaption(this.panel5, "Sales By Employee");
            this.panel5.Controls.Add(this.flexPie1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel5, "97e5d98c-d0f5-450b-97c5-5df6499dae16");
            this.panel5.Location = new System.Drawing.Point(260, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(260, 202);
            this.panel5.TabIndex = 2;
            this.panel5.Text = "Sales By Employee";
            // 
            // flexPie1
            // 
            flexPieSlice5.Name = "Slice1";
            flexPieSlice5.Value = 1D;
            flexPieSlice6.Name = "Slice2";
            flexPieSlice6.Value = 2D;
            flexPieSlice7.Name = "Slice3";
            flexPieSlice7.Value = 3D;
            flexPieSlice8.Name = "Slice4";
            flexPieSlice8.Value = 4D;
            this.flexPie1.DataSource = new C1.Win.Chart.FlexPieSlice[] {
        flexPieSlice5,
        flexPieSlice6,
        flexPieSlice7,
        flexPieSlice8};
            this.flexPie1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexPie1.Legend.ItemMaxWidth = 0;
            this.flexPie1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexPie1.Legend.Position = C1.Chart.Position.None;
            this.flexPie1.Legend.Reversed = false;
            this.flexPie1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.flexPie1.Legend.Title = null;
            this.flexPie1.Location = new System.Drawing.Point(10, 10);
            this.flexPie1.Name = "flexPie1";
            this.flexPie1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.flexPie1.Size = new System.Drawing.Size(240, 182);
            this.flexPie1.TabIndex = 0;
            this.flexPie1.Text = "flexPie1";
            // 
            // 
            // 
            this.flexPie1.ToolTip.Content = "{value}";
            // 
            // panel7
            // 
            this.c1DashboardLayout1.SetCaption(this.panel7, "Calendar");
            this.panel7.Controls.Add(this.c1CalendarView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel7, "f2d0f705-5f80-49c5-8497-7742fa26b712");
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(260, 202);
            this.panel7.TabIndex = 3;
            this.panel7.Text = "Calendar";
            // 
            // c1CalendarView1
            // 
            this.c1CalendarView1.CaptionFormat = null;
            this.c1CalendarView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1CalendarView1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.c1CalendarView1.Location = new System.Drawing.Point(10, 10);
            this.c1CalendarView1.MaxDate = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.c1CalendarView1.Name = "c1CalendarView1";
            this.c1CalendarView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.c1CalendarView1.Size = new System.Drawing.Size(240, 182);
            this.c1CalendarView1.TabIndex = 0;
            this.c1CalendarView1.Text = "c1CalendarView1";
            // 
            // panel9
            // 
            this.c1DashboardLayout1.SetCaption(this.panel9, "Sales");
            this.panel9.Controls.Add(this.c1FlexGrid1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel9, "be1a1442-59f7-4d53-9c37-756ed7e6859e");
            this.panel9.Location = new System.Drawing.Point(0, 202);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10);
            this.panel9.Size = new System.Drawing.Size(260, 202);
            this.panel9.TabIndex = 4;
            this.panel9.Text = "Sales";
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(10, 10);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 19;
            this.c1FlexGrid1.Size = new System.Drawing.Size(240, 182);
            this.c1FlexGrid1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SaveLoadLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.c1DashboardLayout1);
            this.Controls.Add(this.c1CommandDock1);
            this.Name = "SaveLoadLayout";
            this.Text = "SaveLoadLayout";
            this.Load += new System.EventHandler(this.SaveLoadLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
            this.c1CommandDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.c1DashboardLayout1.GridLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DashboardLayout1)).EndInit();
            this.c1DashboardLayout1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Command.C1CommandDock c1CommandDock1;
        private C1.Win.Command.C1ToolBar c1ToolBar1;
        private C1.Win.Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.Command.C1Command c1Command1;
        private C1.Win.Command.C1Command commandSave;
        private C1.Win.Command.C1Command commandLoad;
        private C1.Win.Command.C1Command commandReset;
        private C1.Win.Command.C1CommandLink c1CommandLink1;
        private C1.Win.Command.C1CommandLink c1CommandLink2;
        private C1.Win.Command.C1CommandLink c1CommandLink3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private C1.Win.Layout.C1DashboardLayout c1DashboardLayout1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Chart.FlexChart flexChart1;
        private System.Windows.Forms.Panel panel3;
        private C1.Win.Gauge.C1Gauge c1Gauge1;
        private C1.Win.Gauge.C1RadialGauge c1RadialGauge1;
        private System.Windows.Forms.Panel panel5;
        private C1.Win.Chart.FlexPie flexPie1;
        private System.Windows.Forms.Panel panel7;
        private C1.Win.Calendar.C1CalendarView c1CalendarView1;
        private System.Windows.Forms.Panel panel9;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.Timer timer1;
    }
}