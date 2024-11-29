namespace SampleExplorer
{
    partial class Overview
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
                _salesByCountry?.Dispose();
                _salesTop10?.Dispose();
                _customers?.Dispose();
                _salesByEmployee?.Dispose();
                _totalSales?.Dispose();
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
            components = new System.ComponentModel.Container();
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            C1.Win.Chart.FlexPieSlice flexPieSlice1 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice2 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice3 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice4 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.Gauge.C1GaugeLabels();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange2 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange3 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel2 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel3 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel4 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeSingleMark c1GaugeSingleMark1 = new C1.Win.Gauge.C1GaugeSingleMark();
            C1.Win.Gauge.C1GaugeSingleMark c1GaugeSingleMark2 = new C1.Win.Gauge.C1GaugeSingleMark();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange4 = new C1.Win.Gauge.C1GaugeRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            c1DashboardLayout1 = new C1.Win.Layout.C1DashboardLayout();
            panel2 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            panel8 = new System.Windows.Forms.Panel();
            panel10 = new System.Windows.Forms.Panel();
            panel12 = new System.Windows.Forms.Panel();
            panel13 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            flexChart1 = new C1.Win.Chart.FlexChart();
            panel3 = new System.Windows.Forms.Panel();
            panel9 = new System.Windows.Forms.Panel();
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            panel5 = new System.Windows.Forms.Panel();
            flexPie1 = new C1.Win.Chart.FlexPie();
            panel7 = new System.Windows.Forms.Panel();
            c1Gauge1 = new C1.Win.Gauge.C1Gauge();
            c1LinearGauge1 = new C1.Win.Gauge.C1LinearGauge();
            panel11 = new System.Windows.Forms.Panel();
            c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            c1SplitterPanel1 = new C1.Win.SplitContainer.C1SplitterPanel();
            c1SplitterPanel2 = new C1.Win.SplitContainer.C1SplitterPanel();
            c1SplitterPanel3 = new C1.Win.SplitContainer.C1SplitterPanel();
            c1SplitterPanel4 = new C1.Win.SplitContainer.C1SplitterPanel();
            c1SplitterPanel5 = new C1.Win.SplitContainer.C1SplitterPanel();
            c1SplitterPanel6 = new C1.Win.SplitContainer.C1SplitterPanel();
            c1SplitterPanel7 = new C1.Win.SplitContainer.C1SplitterPanel();
            ((System.ComponentModel.ISupportInitialize)c1DashboardLayout1).BeginInit();
            c1DashboardLayout1.FlowLayoutControl.SuspendLayout();
            c1DashboardLayout1.GridLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1DashboardLayout1.SplitLayoutControl).BeginInit();
            c1DashboardLayout1.SplitLayoutControl.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flexChart1).BeginInit();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1Gauge1).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1TrueDBGrid1).BeginInit();
            SuspendLayout();
            // 
            // c1DashboardLayout1
            // 
            c1DashboardLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            c1DashboardLayout1.FlowLayoutControl.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(panel2);
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(panel4);
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(panel6);
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(panel8);
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(panel10);
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(panel12);
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(panel13);
            c1DashboardLayout1.FlowLayoutControl.Location = new System.Drawing.Point(0, 0);
            c1DashboardLayout1.FlowLayoutControl.Margin = new System.Windows.Forms.Padding(0);
            c1DashboardLayout1.FlowLayoutControl.Name = "FlowContentPanel";
            c1DashboardLayout1.FlowLayoutControl.TabIndex = 0;
            // 
            // 
            // 
            c1DashboardLayout1.GridLayoutControl.AutoScroll = true;
            c1DashboardLayout1.GridLayoutControl.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.GridLayoutControl.ColumnCount = 3;
            c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            c1DashboardLayout1.GridLayoutControl.Controls.Add(panel1, 2, 0);
            c1DashboardLayout1.GridLayoutControl.Controls.Add(panel3, 1, 1);
            c1DashboardLayout1.GridLayoutControl.Controls.Add(panel5, 1, 0);
            c1DashboardLayout1.GridLayoutControl.Controls.Add(panel7, 0, 0);
            c1DashboardLayout1.GridLayoutControl.Controls.Add(panel11, 0, 1);
            c1DashboardLayout1.GridLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.GridLayoutControl.Location = new System.Drawing.Point(10, 10);
            c1DashboardLayout1.GridLayoutControl.Margin = new System.Windows.Forms.Padding(0);
            c1DashboardLayout1.GridLayoutControl.Name = "GridContentPanel";
            c1DashboardLayout1.GridLayoutControl.RowCount = 2;
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            c1DashboardLayout1.GridLayoutControl.Size = new System.Drawing.Size(848, 464);
            c1DashboardLayout1.GridLayoutControl.TabIndex = 0;
            c1DashboardLayout1.LayoutType = C1.Win.Layout.LayoutType.Grid;
            c1DashboardLayout1.Location = new System.Drawing.Point(0, 0);
            c1DashboardLayout1.Margin = new System.Windows.Forms.Padding(0);
            c1DashboardLayout1.Name = "c1DashboardLayout1";
            c1DashboardLayout1.Size = new System.Drawing.Size(868, 484);
            // 
            // 
            // 
            c1DashboardLayout1.SplitLayoutControl.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            c1DashboardLayout1.SplitLayoutControl.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SplitLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SplitLayoutControl.HeaderButtonBackColor = System.Drawing.Color.Transparent;
            c1DashboardLayout1.SplitLayoutControl.Location = new System.Drawing.Point(0, 0);
            c1DashboardLayout1.SplitLayoutControl.Margin = new System.Windows.Forms.Padding(0);
            c1DashboardLayout1.SplitLayoutControl.Name = "SplitContentPanel";
            c1DashboardLayout1.SplitLayoutControl.Panels.Add(c1SplitterPanel1);
            c1DashboardLayout1.SplitLayoutControl.Panels.Add(c1SplitterPanel2);
            c1DashboardLayout1.SplitLayoutControl.Panels.Add(c1SplitterPanel3);
            c1DashboardLayout1.SplitLayoutControl.Panels.Add(c1SplitterPanel4);
            c1DashboardLayout1.SplitLayoutControl.Panels.Add(c1SplitterPanel5);
            c1DashboardLayout1.SplitLayoutControl.Panels.Add(c1SplitterPanel6);
            c1DashboardLayout1.SplitLayoutControl.Panels.Add(c1SplitterPanel7);
            c1DashboardLayout1.SplitLayoutControl.Size = new System.Drawing.Size(0, 0);
            c1DashboardLayout1.SplitLayoutControl.TabIndex = 0;
            c1DashboardLayout1.TabIndex = 0;
            c1DashboardLayout1.TabStop = false;
            c1DashboardLayout1.Text = "c1DashboardLayout1";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(panel2, "Sales By Country");
            c1DashboardLayout1.SetId(panel2, "C1.Win.Layout.FlowLayout~cf9b0a9d-9a3f-4d48-947b-257ba31c3b16");
            panel2.Location = new System.Drawing.Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new System.Windows.Forms.Padding(10);
            panel2.Size = new System.Drawing.Size(200, 100);
            panel2.TabIndex = 0;
            panel2.Text = "Sales By Country";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(panel4, "Sales");
            c1DashboardLayout1.SetId(panel4, "C1.Win.Layout.FlowLayout~c451c2d6-7660-47e9-9e27-1ebe098d5624");
            panel4.Location = new System.Drawing.Point(3, 109);
            panel4.Name = "panel4";
            panel4.Padding = new System.Windows.Forms.Padding(10);
            panel4.Size = new System.Drawing.Size(200, 100);
            panel4.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(panel6, "Sales By Employee");
            c1DashboardLayout1.SetId(panel6, "C1.Win.Layout.FlowLayout~97e5d98c-d0f5-450b-97c5-5df6499dae16");
            panel6.Location = new System.Drawing.Point(3, 215);
            panel6.Name = "panel6";
            panel6.Padding = new System.Windows.Forms.Padding(10);
            panel6.Size = new System.Drawing.Size(200, 100);
            panel6.TabIndex = 2;
            panel6.Text = "Sales By Employee";
            // 
            // panel8
            // 
            panel8.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(panel8, "Goal");
            c1DashboardLayout1.SetId(panel8, "C1.Win.Layout.FlowLayout~f2d0f705-5f80-49c5-8497-7742fa26b712");
            panel8.Location = new System.Drawing.Point(3, 321);
            panel8.Name = "panel8";
            panel8.Padding = new System.Windows.Forms.Padding(10);
            panel8.Size = new System.Drawing.Size(200, 100);
            panel8.TabIndex = 3;
            panel8.Text = "Calendar";
            // 
            // panel10
            // 
            panel10.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(panel10, "Sales");
            c1DashboardLayout1.SetId(panel10, "C1.Win.Layout.FlowLayout~be1a1442-59f7-4d53-9c37-756ed7e6859e");
            panel10.Location = new System.Drawing.Point(3, 427);
            panel10.Name = "panel10";
            panel10.Padding = new System.Windows.Forms.Padding(10);
            panel10.Size = new System.Drawing.Size(200, 100);
            panel10.TabIndex = 4;
            panel10.Text = "Sales";
            // 
            // panel12
            // 
            panel12.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(panel12, "Current Time");
            c1DashboardLayout1.SetId(panel12, "C1.Win.Layout.FlowLayout~c106cd55-f0dd-4c94-82cf-51e786aa4297");
            panel12.Location = new System.Drawing.Point(3, 533);
            panel12.Name = "panel12";
            panel12.Padding = new System.Windows.Forms.Padding(10);
            panel12.Size = new System.Drawing.Size(200, 100);
            panel12.TabIndex = 5;
            panel12.Text = "Current Time";
            // 
            // panel13
            // 
            panel13.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(panel13, "Customers");
            c1DashboardLayout1.SetId(panel13, "C1.Win.Layout.FlowLayout~aa75059c-7d31-42ec-b8f7-d25da356c8eb");
            panel13.Location = new System.Drawing.Point(3, 639);
            panel13.Name = "panel13";
            panel13.Padding = new System.Windows.Forms.Padding(10);
            panel13.Size = new System.Drawing.Size(200, 100);
            panel13.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(panel1, "Sales By Country");
            panel1.Controls.Add(flexChart1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SetId(panel1, "C1.Win.Layout.GridLayout~cf9b0a9d-9a3f-4d48-947b-257ba31c3b16");
            panel1.Location = new System.Drawing.Point(596, 3);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(10);
            panel1.Size = new System.Drawing.Size(249, 226);
            panel1.TabIndex = 0;
            panel1.Text = "Sales By Country";
            // 
            // flexChart1
            // 
            flexChart1.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            flexChart1.AnimationLoad.Duration = 400;
            flexChart1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexChart1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexChart1.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexChart1.AnimationUpdate.Duration = 400;
            flexChart1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexChart1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexChart1.AxisX.AxisLine = true;
            flexChart1.AxisX.Chart = flexChart1;
            flexChart1.AxisX.DataSource = null;
            flexChart1.AxisX.Formatter = null;
            flexChart1.AxisX.GroupProvider = null;
            flexChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart1.AxisX.GroupVisibilityLevel = 0;
            flexChart1.AxisX.PlotAreaName = null;
            flexChart1.AxisX.Position = C1.Chart.Position.Bottom;
            flexChart1.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart1.AxisY.AxisLine = false;
            flexChart1.AxisY.Chart = flexChart1;
            flexChart1.AxisY.DataSource = null;
            flexChart1.AxisY.Formatter = null;
            flexChart1.AxisY.GroupProvider = null;
            flexChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart1.AxisY.GroupVisibilityLevel = 0;
            flexChart1.AxisY.MajorGrid = true;
            flexChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            flexChart1.AxisY.PlotAreaName = null;
            flexChart1.AxisY.Position = C1.Chart.Position.Left;
            flexChart1.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart1.ChartType = C1.Chart.ChartType.Bar;
            flexChart1.DataLabel.Angle = 0;
            flexChart1.DataLabel.Border = false;
            flexChart1.DataLabel.ConnectingLine = false;
            flexChart1.DataLabel.Content = null;
            flexChart1.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            flexChart1.DataLabel.MaxAutoLabels = 100;
            flexChart1.DataLabel.MaxLines = 0;
            flexChart1.DataLabel.MaxWidth = 0;
            flexChart1.DataLabel.Offset = 0;
            flexChart1.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            flexChart1.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            flexChart1.DataLabel.Position = C1.Chart.LabelPosition.None;
            flexChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            flexChart1.Legend.ItemMaxWidth = 0;
            flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexChart1.Legend.Position = C1.Chart.Position.None;
            flexChart1.Legend.Reversed = false;
            flexChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexChart1.Legend.Title = null;
            flexChart1.Location = new System.Drawing.Point(10, 33);
            flexChart1.Margin = new System.Windows.Forms.Padding(10);
            flexChart1.Name = "flexChart1";
            flexChart1.Options.Chart = flexChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            flexChart1.Options.ClusterSize = elementSize1;
            flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            flexChart1.SelectedSeries = null;
            flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series1.DataLabel = null;
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            series1.Tooltip = null;
            flexChart1.Series.Add(series1);
            flexChart1.Size = new System.Drawing.Size(229, 183);
            flexChart1.TabIndex = 0;
            flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            flexChart1.ToolTip.Content = "{value}";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(panel3, "Sales");
            panel3.Controls.Add(panel9);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SetId(panel3, "C1.Win.Layout.GridLayout~c451c2d6-7660-47e9-9e27-1ebe098d5624");
            panel3.Location = new System.Drawing.Point(257, 235);
            panel3.Name = "panel3";
            panel3.Padding = new System.Windows.Forms.Padding(10);
            panel3.Size = new System.Drawing.Size(333, 226);
            panel3.TabIndex = 1;
            panel3.Text = "Current Time";
            // 
            // panel9
            // 
            panel9.Controls.Add(c1FlexGrid1);
            panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            panel9.Location = new System.Drawing.Point(10, 33);
            panel9.Margin = new System.Windows.Forms.Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new System.Windows.Forms.Padding(10);
            panel9.Size = new System.Drawing.Size(313, 183);
            panel9.TabIndex = 4;
            panel9.Text = "Sales";
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:";
            c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1FlexGrid1.Location = new System.Drawing.Point(10, 10);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new System.Drawing.Size(293, 163);
            c1FlexGrid1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(panel5, "Sales By Employee");
            panel5.Controls.Add(flexPie1);
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SetId(panel5, "C1.Win.Layout.GridLayout~97e5d98c-d0f5-450b-97c5-5df6499dae16");
            panel5.Location = new System.Drawing.Point(257, 3);
            panel5.Name = "panel5";
            panel5.Padding = new System.Windows.Forms.Padding(10);
            panel5.Size = new System.Drawing.Size(333, 226);
            panel5.TabIndex = 2;
            panel5.Text = "Sales By Employee";
            // 
            // flexPie1
            // 
            flexPie1.AnimationLoad.Attributes = C1.Chart.SliceAttribute.Radius;
            flexPie1.AnimationLoad.Duration = 400;
            flexPie1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexPie1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexPie1.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexPie1.AnimationUpdate.Duration = 400;
            flexPie1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexPie1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexPie1.DataLabel.Border = false;
            flexPie1.DataLabel.ConnectingLine = false;
            flexPie1.DataLabel.Content = null;
            flexPie1.DataLabel.Offset = 0;
            flexPie1.DataLabel.Overlapping = C1.Chart.PieLabelOverlapping.Default;
            flexPie1.DataLabel.Position = C1.Chart.PieLabelPosition.None;
            flexPieSlice1.Name = "Slice1";
            flexPieSlice1.Value = 1D;
            flexPieSlice2.Name = "Slice2";
            flexPieSlice2.Value = 2D;
            flexPieSlice3.Name = "Slice3";
            flexPieSlice3.Value = 3D;
            flexPieSlice4.Name = "Slice4";
            flexPieSlice4.Value = 4D;
            flexPie1.DataSource = new C1.Win.Chart.FlexPieSlice[]
    {
    flexPieSlice1,
    flexPieSlice2,
    flexPieSlice3,
    flexPieSlice4
    };
            flexPie1.Dock = System.Windows.Forms.DockStyle.Fill;
            flexPie1.Legend.ItemMaxWidth = 0;
            flexPie1.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexPie1.Legend.Position = C1.Chart.Position.Right;
            flexPie1.Legend.Reversed = false;
            flexPie1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexPie1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexPie1.Legend.Title = null;
            flexPie1.Location = new System.Drawing.Point(10, 33);
            flexPie1.Name = "flexPie1";
            flexPie1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            flexPie1.Size = new System.Drawing.Size(313, 183);
            flexPie1.TabIndex = 0;
            flexPie1.Text = "flexPie1";
            flexPie1.Titles = null;
            // 
            // 
            // 
            flexPie1.ToolTip.Content = "{value}";
            // 
            // panel7
            // 
            panel7.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(panel7, "Goal");
            panel7.Controls.Add(c1Gauge1);
            panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SetId(panel7, "C1.Win.Layout.GridLayout~f2d0f705-5f80-49c5-8497-7742fa26b712");
            panel7.Location = new System.Drawing.Point(3, 3);
            panel7.Name = "panel7";
            panel7.Padding = new System.Windows.Forms.Padding(10);
            panel7.Size = new System.Drawing.Size(248, 226);
            panel7.TabIndex = 3;
            panel7.Text = "Calendar";
            // 
            // c1Gauge1
            // 
            c1Gauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1Gauge1.Gauges.AddRange(new C1.Win.Gauge.C1GaugeBase[] { c1LinearGauge1 });
            c1Gauge1.Location = new System.Drawing.Point(10, 33);
            c1Gauge1.Name = "c1Gauge1";
            c1Gauge1.Size = new System.Drawing.Size(228, 183);
            c1Gauge1.TabIndex = 0;
            c1Gauge1.ViewTag = 649862838331919301L;
            // 
            // c1LinearGauge1
            // 
            c1LinearGauge1.AxisLength = 0.88D;
            c1GaugeRange1.Border.Color = System.Drawing.Color.Black;
            c1GaugeRange1.Filling.Color = System.Drawing.Color.Black;
            c1GaugeRange1.Location = 40D;
            c1GaugeRange1.ViewTag = 717286292691556980L;
            c1GaugeRange1.Width = 0.1D;
            c1GaugeMarks1.Alignment = C1.Win.Gauge.C1GaugeAlignment.In;
            c1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.FromArgb(68, 68, 68);
            c1GaugeMarks1.Interval = 500D;
            c1GaugeMarks1.Length = 7D;
            c1GaugeMarks1.Location = 40D;
            c1GaugeMarks1.ViewTag = 736708070189897828L;
            c1GaugeMarks1.Width = 1D;
            c1GaugeMarks2.Alignment = C1.Win.Gauge.C1GaugeAlignment.In;
            c1GaugeMarks2.Border.Color = System.Drawing.Color.FromArgb(68, 68, 68);
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.FromArgb(68, 68, 68);
            c1GaugeMarks2.Interval = 100D;
            c1GaugeMarks2.Length = 4D;
            c1GaugeMarks2.Location = 35D;
            c1GaugeMarks2.ViewTag = 740648722200817145L;
            c1GaugeMarks2.Visible = false;
            c1GaugeMarks2.Width = 1D;
            c1GaugeLabels1.Alignment = C1.Win.Gauge.C1GaugeAlignment.In;
            c1GaugeLabels1.Interval = 500D;
            c1GaugeLabels1.Location = 32D;
            c1GaugeLabels1.ViewTag = 740930198312349440L;
            c1GaugeRange2.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange2.Filling.Color = System.Drawing.Color.Silver;
            c1GaugeRange2.Location = 60D;
            c1GaugeRange2.ViewTag = 669734115192623138L;
            c1GaugeRange2.Width = 24D;
            c1GaugeRange3.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange3.Filling.Color = System.Drawing.Color.SteelBlue;
            c1GaugeRange3.Location = 60D;
            c1GaugeRange3.ToPointerIndex = 10;
            c1GaugeRange3.ViewTag = 669452639794046327L;
            c1GaugeRange3.Width = 24D;
            c1GaugeSingleLabel1.Color = System.Drawing.Color.White;
            c1GaugeSingleLabel1.FontSize = 12D;
            c1GaugeSingleLabel1.Format = "##";
            c1GaugeSingleLabel1.Location = 62D;
            c1GaugeSingleLabel1.OrthogonalOffset = -20D;
            c1GaugeSingleLabel1.PointerIndex = 100;
            c1GaugeSingleLabel1.ViewTag = 648343123971847526L;
            c1GaugeSingleLabel2.Location = 0D;
            c1GaugeSingleLabel2.Position = 0.5D;
            c1GaugeSingleLabel2.Text = "Thousands Of Dollars";
            c1GaugeSingleLabel2.ViewTag = 664781023878791980L;
            c1GaugeSingleLabel3.Format = "Sales  ##";
            c1GaugeSingleLabel3.Location = 84D;
            c1GaugeSingleLabel3.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeSingleLabel3.OrthogonalOffset = 15D;
            c1GaugeSingleLabel3.PointerIndex = 100;
            c1GaugeSingleLabel3.Position = 0D;
            c1GaugeSingleLabel3.ViewTag = 665343977590655058L;
            c1GaugeSingleLabel4.Location = 104D;
            c1GaugeSingleLabel4.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeSingleLabel4.OrthogonalOffset = 15D;
            c1GaugeSingleLabel4.Position = 0D;
            c1GaugeSingleLabel4.Text = "Goal   1500";
            c1GaugeSingleLabel4.ViewTag = 665625453783307579L;
            c1GaugeSingleMark1.AlignmentOffset = -1;
            c1GaugeSingleMark1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark1.Filling.Color = System.Drawing.Color.SteelBlue;
            c1GaugeSingleMark1.Length = 10D;
            c1GaugeSingleMark1.Location = 84D;
            c1GaugeSingleMark1.Position = 0D;
            c1GaugeSingleMark1.ViewTag = 671254961800690087L;
            c1GaugeSingleMark1.Width = 10D;
            c1GaugeSingleMark2.AlignmentOffset = -1;
            c1GaugeSingleMark2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark2.Filling.Color = System.Drawing.Color.Green;
            c1GaugeSingleMark2.Length = 10D;
            c1GaugeSingleMark2.Location = 104D;
            c1GaugeSingleMark2.Position = 0D;
            c1GaugeSingleMark2.ViewTag = 671536437573534036L;
            c1GaugeSingleMark2.Width = 10D;
            c1GaugeRange4.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeRange4.Filling.Color = System.Drawing.Color.Green;
            c1GaugeRange4.From = 1500D;
            c1GaugeRange4.Location = 39D;
            c1GaugeRange4.To = 2000D;
            c1GaugeRange4.ViewTag = 671817913772729123L;
            c1GaugeRange4.Width = 3D;
            c1LinearGauge1.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] { c1GaugeRange1, c1GaugeMarks1, c1GaugeMarks2, c1GaugeLabels1, c1GaugeRange2, c1GaugeRange3, c1GaugeSingleLabel1, c1GaugeSingleLabel2, c1GaugeSingleLabel3, c1GaugeSingleLabel4, c1GaugeSingleMark1, c1GaugeSingleMark2, c1GaugeRange4 });
            c1LinearGauge1.Maximum = 2000D;
            c1LinearGauge1.Name = "c1LinearGauge1";
            c1LinearGauge1.Pointer.Border.Color = System.Drawing.Color.FromArgb(68, 68, 68);
            c1LinearGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Rectangle;
            c1LinearGauge1.Pointer.Value = 1000D;
            c1LinearGauge1.Pointer.Visible = false;
            c1LinearGauge1.Viewport.AspectRatio = 2D;
            c1LinearGauge1.ViewTag = 716441866908225388L;
            // 
            // panel11
            // 
            panel11.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(panel11, "Customers");
            panel11.Controls.Add(c1TrueDBGrid1);
            panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SetId(panel11, "C1.Win.Layout.GridLayout~aa75059c-7d31-42ec-b8f7-d25da356c8eb");
            panel11.Location = new System.Drawing.Point(3, 235);
            panel11.Name = "panel11";
            panel11.Padding = new System.Windows.Forms.Padding(10);
            panel11.Size = new System.Drawing.Size(248, 226);
            panel11.TabIndex = 4;
            // 
            // c1TrueDBGrid1
            // 
            c1TrueDBGrid1.DataView = C1.Win.TrueDBGrid.DataViewEnum.Form;
            c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1TrueDBGrid1.Images.Add((System.Drawing.Image)resources.GetObject("c1TrueDBGrid1.Images"));
            c1TrueDBGrid1.Location = new System.Drawing.Point(10, 33);
            c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = null;
            c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            c1TrueDBGrid1.Size = new System.Drawing.Size(228, 183);
            c1TrueDBGrid1.TabIndex = 0;
            // 
            // c1SplitterPanel1
            // 
            c1SplitterPanel1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(c1SplitterPanel1, "Sales By Country");
            c1SplitterPanel1.Height = 40;
            c1DashboardLayout1.SetId(c1SplitterPanel1, "C1.Win.Layout.SplitLayout~cf9b0a9d-9a3f-4d48-947b-257ba31c3b16");
            c1SplitterPanel1.Location = new System.Drawing.Point(0, 21);
            c1SplitterPanel1.Name = "c1SplitterPanel1";
            c1SplitterPanel1.Padding = new System.Windows.Forms.Padding(10);
            c1SplitterPanel1.Size = new System.Drawing.Size(480, 19);
            c1SplitterPanel1.TabIndex = 0;
            c1SplitterPanel1.Text = "Sales By Country";
            // 
            // c1SplitterPanel2
            // 
            c1SplitterPanel2.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(c1SplitterPanel2, "Sales");
            c1SplitterPanel2.Height = 40;
            c1DashboardLayout1.SetId(c1SplitterPanel2, "C1.Win.Layout.SplitLayout~c451c2d6-7660-47e9-9e27-1ebe098d5624");
            c1SplitterPanel2.Location = new System.Drawing.Point(0, 44);
            c1SplitterPanel2.Name = "c1SplitterPanel2";
            c1SplitterPanel2.Padding = new System.Windows.Forms.Padding(10);
            c1SplitterPanel2.Size = new System.Drawing.Size(480, 40);
            c1SplitterPanel2.TabIndex = 1;
            // 
            // c1SplitterPanel3
            // 
            c1SplitterPanel3.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(c1SplitterPanel3, "Sales By Employee");
            c1SplitterPanel3.Height = 40;
            c1DashboardLayout1.SetId(c1SplitterPanel3, "C1.Win.Layout.SplitLayout~97e5d98c-d0f5-450b-97c5-5df6499dae16");
            c1SplitterPanel3.Location = new System.Drawing.Point(0, 109);
            c1SplitterPanel3.Name = "c1SplitterPanel3";
            c1SplitterPanel3.Padding = new System.Windows.Forms.Padding(10);
            c1SplitterPanel3.Size = new System.Drawing.Size(480, 19);
            c1SplitterPanel3.TabIndex = 2;
            c1SplitterPanel3.Text = "Sales By Employee";
            // 
            // c1SplitterPanel4
            // 
            c1SplitterPanel4.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(c1SplitterPanel4, "Goal");
            c1SplitterPanel4.Height = 40;
            c1DashboardLayout1.SetId(c1SplitterPanel4, "C1.Win.Layout.SplitLayout~f2d0f705-5f80-49c5-8497-7742fa26b712");
            c1SplitterPanel4.Location = new System.Drawing.Point(0, 153);
            c1SplitterPanel4.Name = "c1SplitterPanel4";
            c1SplitterPanel4.Padding = new System.Windows.Forms.Padding(10);
            c1SplitterPanel4.Size = new System.Drawing.Size(480, 19);
            c1SplitterPanel4.TabIndex = 3;
            c1SplitterPanel4.Text = "Calendar";
            // 
            // c1SplitterPanel5
            // 
            c1SplitterPanel5.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(c1SplitterPanel5, "Sales");
            c1SplitterPanel5.Height = 40;
            c1DashboardLayout1.SetId(c1SplitterPanel5, "C1.Win.Layout.SplitLayout~be1a1442-59f7-4d53-9c37-756ed7e6859e");
            c1SplitterPanel5.Location = new System.Drawing.Point(0, 197);
            c1SplitterPanel5.Name = "c1SplitterPanel5";
            c1SplitterPanel5.Padding = new System.Windows.Forms.Padding(10);
            c1SplitterPanel5.Size = new System.Drawing.Size(480, 19);
            c1SplitterPanel5.TabIndex = 4;
            c1SplitterPanel5.Text = "Sales";
            // 
            // c1SplitterPanel6
            // 
            c1SplitterPanel6.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(c1SplitterPanel6, "Current Time");
            c1SplitterPanel6.Height = 40;
            c1DashboardLayout1.SetId(c1SplitterPanel6, "C1.Win.Layout.SplitLayout~c106cd55-f0dd-4c94-82cf-51e786aa4297");
            c1SplitterPanel6.Location = new System.Drawing.Point(0, 241);
            c1SplitterPanel6.Name = "c1SplitterPanel6";
            c1SplitterPanel6.Padding = new System.Windows.Forms.Padding(10);
            c1SplitterPanel6.Size = new System.Drawing.Size(480, 19);
            c1SplitterPanel6.TabIndex = 5;
            c1SplitterPanel6.Text = "Current Time";
            // 
            // c1SplitterPanel7
            // 
            c1SplitterPanel7.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(c1SplitterPanel7, "Customers");
            c1SplitterPanel7.Height = 16;
            c1DashboardLayout1.SetId(c1SplitterPanel7, "C1.Win.Layout.SplitLayout~aa75059c-7d31-42ec-b8f7-d25da356c8eb");
            c1SplitterPanel7.Location = new System.Drawing.Point(0, 264);
            c1SplitterPanel7.Name = "c1SplitterPanel7";
            c1SplitterPanel7.Padding = new System.Windows.Forms.Padding(10);
            c1SplitterPanel7.Size = new System.Drawing.Size(480, 16);
            c1SplitterPanel7.TabIndex = 6;
            // 
            // Overview
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(c1DashboardLayout1);
            Name = "Overview";
            Size = new System.Drawing.Size(868, 484);
            Load += Overview_Load;
            c1DashboardLayout1.FlowLayoutControl.ResumeLayout(false);
            c1DashboardLayout1.GridLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1DashboardLayout1.SplitLayoutControl).EndInit();
            c1DashboardLayout1.SplitLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1DashboardLayout1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flexChart1).EndInit();
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1Gauge1).EndInit();
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1TrueDBGrid1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.Layout.C1DashboardLayout c1DashboardLayout1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Chart.FlexChart flexChart1;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private C1.Win.Chart.FlexPie flexPie1;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel9;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel5;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel6;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel7;
        private C1.Win.Gauge.C1Gauge c1Gauge1;
        private C1.Win.Gauge.C1LinearGauge c1LinearGauge1;
    }
}