namespace ControlExplorer.DashboardLayout
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
            this.components = new System.ComponentModel.Container();
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            C1.Win.Chart.FlexPieSlice flexPieSlice1 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice2 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice3 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice4 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange2 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange3 = new C1.Win.C1Gauge.C1GaugeRange();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel2 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel3 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeSingleLabel c1GaugeSingleLabel4 = new C1.Win.C1Gauge.C1GaugeSingleLabel();
            C1.Win.C1Gauge.C1GaugeSingleMark c1GaugeSingleMark1 = new C1.Win.C1Gauge.C1GaugeSingleMark();
            C1.Win.C1Gauge.C1GaugeSingleMark c1GaugeSingleMark2 = new C1.Win.C1Gauge.C1GaugeSingleMark();
            C1.Win.C1Gauge.C1GaugeRange c1GaugeRange4 = new C1.Win.C1Gauge.C1GaugeRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.c1DashboardLayout1 = new C1.Win.Layout.C1DashboardLayout();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flexChart1 = new C1.Win.Chart.FlexChart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flexPie1 = new C1.Win.Chart.FlexPie();
            this.panel7 = new System.Windows.Forms.Panel();
            this.c1Gauge1 = new C1.Win.C1Gauge.C1Gauge();
            this.c1LinearGauge1 = new C1.Win.C1Gauge.C1LinearGauge();
            this.panel11 = new System.Windows.Forms.Panel();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.c1SplitterPanel1 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel2 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel3 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel4 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel5 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel6 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel7 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1DashboardLayout1)).BeginInit();
            this.c1DashboardLayout1.FlowLayoutControl.SuspendLayout();
            this.c1DashboardLayout1.GridLayoutControl.SuspendLayout();
            this.c1DashboardLayout1.SplitLayoutControl.SuspendLayout();
            this.c1DashboardLayout1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1DashboardLayout1
            // 
            this.c1DashboardLayout1.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // c1DashboardLayout1.FlowContentPanel
            // 
            this.c1DashboardLayout1.FlowLayoutControl.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.FlowLayoutControl.Controls.Add(this.panel2);
            this.c1DashboardLayout1.FlowLayoutControl.Controls.Add(this.panel4);
            this.c1DashboardLayout1.FlowLayoutControl.Controls.Add(this.panel6);
            this.c1DashboardLayout1.FlowLayoutControl.Controls.Add(this.panel8);
            this.c1DashboardLayout1.FlowLayoutControl.Controls.Add(this.panel10);
            this.c1DashboardLayout1.FlowLayoutControl.Controls.Add(this.panel12);
            this.c1DashboardLayout1.FlowLayoutControl.Controls.Add(this.panel13);
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
            this.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel1, 2, 0);
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel3, 1, 1);
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel5, 1, 0);
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel7, 0, 0);
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel11, 0, 1);
            this.c1DashboardLayout1.GridLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.GridLayoutControl.Location = new System.Drawing.Point(10, 10);
            this.c1DashboardLayout1.GridLayoutControl.Name = "GridContentPanel";
            this.c1DashboardLayout1.GridLayoutControl.RowCount = 2;
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.c1DashboardLayout1.GridLayoutControl.Size = new System.Drawing.Size(848, 464);
            this.c1DashboardLayout1.GridLayoutControl.TabIndex = 0;
            this.c1DashboardLayout1.LayoutType = C1.Win.Layout.LayoutType.Grid;
            this.c1DashboardLayout1.Location = new System.Drawing.Point(0, 0);
            this.c1DashboardLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.c1DashboardLayout1.Name = "c1DashboardLayout1";
            this.c1DashboardLayout1.Size = new System.Drawing.Size(868, 484);
            // 
            // c1DashboardLayout1.SplitContentPanel
            // 
            this.c1DashboardLayout1.SplitLayoutControl.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1DashboardLayout1.SplitLayoutControl.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SplitLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SplitLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.c1DashboardLayout1.SplitLayoutControl.Name = "SplitContentPanel";
            this.c1DashboardLayout1.SplitLayoutControl.Panels.Add(this.c1SplitterPanel1);
            this.c1DashboardLayout1.SplitLayoutControl.Panels.Add(this.c1SplitterPanel2);
            this.c1DashboardLayout1.SplitLayoutControl.Panels.Add(this.c1SplitterPanel3);
            this.c1DashboardLayout1.SplitLayoutControl.Panels.Add(this.c1SplitterPanel4);
            this.c1DashboardLayout1.SplitLayoutControl.Panels.Add(this.c1SplitterPanel5);
            this.c1DashboardLayout1.SplitLayoutControl.Panels.Add(this.c1SplitterPanel6);
            this.c1DashboardLayout1.SplitLayoutControl.Panels.Add(this.c1SplitterPanel7);
            this.c1DashboardLayout1.SplitLayoutControl.Size = new System.Drawing.Size(0, 0);
            this.c1DashboardLayout1.SplitLayoutControl.TabIndex = 0;
            this.c1DashboardLayout1.SplitLayoutControl.UseParentVisualStyle = false;
            this.c1DashboardLayout1.TabIndex = 0;
            this.c1DashboardLayout1.Text = "c1DashboardLayout1";
            // 
            // panel2
            // 
            this.c1DashboardLayout1.SetCaption(this.panel2, "Sales By Country");
            this.c1DashboardLayout1.SetId(this.panel2, "cf9b0a9d-9a3f-4d48-947b-257ba31c3b16");
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            this.panel2.Text = "Sales By Country";
            // 
            // panel4
            // 
            this.c1DashboardLayout1.SetCaption(this.panel4, "Sales");
            this.c1DashboardLayout1.SetId(this.panel4, "c451c2d6-7660-47e9-9e27-1ebe098d5624");
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.c1DashboardLayout1.SetCaption(this.panel6, "Sales By Employee");
            this.c1DashboardLayout1.SetId(this.panel6, "97e5d98c-d0f5-450b-97c5-5df6499dae16");
            this.panel6.Location = new System.Drawing.Point(0, 200);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 2;
            this.panel6.Text = "Sales By Employee";
            // 
            // panel8
            // 
            this.c1DashboardLayout1.SetCaption(this.panel8, "Goal");
            this.c1DashboardLayout1.SetId(this.panel8, "f2d0f705-5f80-49c5-8497-7742fa26b712");
            this.panel8.Location = new System.Drawing.Point(0, 300);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10);
            this.panel8.Size = new System.Drawing.Size(200, 100);
            this.panel8.TabIndex = 3;
            this.panel8.Text = "Calendar";
            // 
            // panel10
            // 
            this.c1DashboardLayout1.SetCaption(this.panel10, "Sales");
            this.c1DashboardLayout1.SetId(this.panel10, "be1a1442-59f7-4d53-9c37-756ed7e6859e");
            this.panel10.Location = new System.Drawing.Point(0, 400);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10);
            this.panel10.Size = new System.Drawing.Size(200, 100);
            this.panel10.TabIndex = 4;
            this.panel10.Text = "Sales";
            // 
            // panel12
            // 
            this.c1DashboardLayout1.SetCaption(this.panel12, "Current Time");
            this.c1DashboardLayout1.SetId(this.panel12, "c106cd55-f0dd-4c94-82cf-51e786aa4297");
            this.panel12.Location = new System.Drawing.Point(0, 500);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10);
            this.panel12.Size = new System.Drawing.Size(200, 100);
            this.panel12.TabIndex = 5;
            this.panel12.Text = "Current Time";
            // 
            // panel13
            // 
            this.c1DashboardLayout1.SetCaption(this.panel13, "Customers");
            this.c1DashboardLayout1.SetId(this.panel13, "aa75059c-7d31-42ec-b8f7-d25da356c8eb");
            this.panel13.Location = new System.Drawing.Point(0, 600);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(10);
            this.panel13.Size = new System.Drawing.Size(200, 100);
            this.panel13.TabIndex = 6;
            // 
            // panel1
            // 
            this.c1DashboardLayout1.SetCaption(this.panel1, "Sales By Country");
            this.panel1.Controls.Add(this.flexChart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel1, "cf9b0a9d-9a3f-4d48-947b-257ba31c3b16");
            this.panel1.Location = new System.Drawing.Point(564, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.c1DashboardLayout1.GridLayoutControl.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(284, 464);
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
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.flexChart1.Options.ClusterSize = elementSize1;
            this.flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexChart1.SelectedSeries = null;
            this.flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series1.DataLabel = null;
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            this.flexChart1.Series.Add(series1);
            this.flexChart1.Size = new System.Drawing.Size(264, 444);
            this.flexChart1.TabIndex = 0;
            this.flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            this.flexChart1.ToolTip.Content = "{value}";
            // 
            // panel3
            // 
            this.c1DashboardLayout1.SetCaption(this.panel3, "Sales");
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel3, "c451c2d6-7660-47e9-9e27-1ebe098d5624");
            this.panel3.Location = new System.Drawing.Point(282, 232);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(282, 232);
            this.panel3.TabIndex = 1;
            this.panel3.Text = "Current Time";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.c1FlexGrid1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(10, 10);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10);
            this.panel9.Size = new System.Drawing.Size(262, 212);
            this.panel9.TabIndex = 4;
            this.panel9.Text = "Sales";
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = -1;
            this.c1FlexGrid1.Size = new System.Drawing.Size(242, 192);
            this.c1FlexGrid1.TabIndex = 0;
            // 
            // panel5
            // 
            this.c1DashboardLayout1.SetCaption(this.panel5, "Sales By Employee");
            this.panel5.Controls.Add(this.flexPie1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel5, "97e5d98c-d0f5-450b-97c5-5df6499dae16");
            this.panel5.Location = new System.Drawing.Point(282, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(282, 232);
            this.panel5.TabIndex = 2;
            this.panel5.Text = "Sales By Employee";
            // 
            // flexPie1
            // 
            flexPieSlice1.Name = "Slice1";
            flexPieSlice1.Value = 1D;
            flexPieSlice2.Name = "Slice2";
            flexPieSlice2.Value = 2D;
            flexPieSlice3.Name = "Slice3";
            flexPieSlice3.Value = 3D;
            flexPieSlice4.Name = "Slice4";
            flexPieSlice4.Value = 4D;
            this.flexPie1.DataSource = new C1.Win.Chart.FlexPieSlice[] {
        flexPieSlice1,
        flexPieSlice2,
        flexPieSlice3,
        flexPieSlice4};
            this.flexPie1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexPie1.Legend.ItemMaxWidth = 0;
            this.flexPie1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexPie1.Legend.Position = C1.Chart.Position.Right;
            this.flexPie1.Legend.Reversed = false;
            this.flexPie1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.flexPie1.Legend.Title = null;
            this.flexPie1.Location = new System.Drawing.Point(10, 10);
            this.flexPie1.Name = "flexPie1";
            this.flexPie1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.flexPie1.Size = new System.Drawing.Size(262, 212);
            this.flexPie1.TabIndex = 0;
            this.flexPie1.Text = "flexPie1";
            // 
            // 
            // 
            this.flexPie1.ToolTip.Content = "{value}";
            // 
            // panel7
            // 
            this.c1DashboardLayout1.SetCaption(this.panel7, "Goal");
            this.panel7.Controls.Add(this.c1Gauge1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel7, "f2d0f705-5f80-49c5-8497-7742fa26b712");
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(282, 232);
            this.panel7.TabIndex = 3;
            this.panel7.Text = "Calendar";
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Gauge1.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1LinearGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(10, 10);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(262, 212);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(649862838331919301));
            // 
            // c1LinearGauge1
            // 
            this.c1LinearGauge1.AxisLength = 0.88D;
            c1GaugeRange1.Border.Color = System.Drawing.Color.Black;
            c1GaugeRange1.Filling.Color = System.Drawing.Color.Black;
            c1GaugeRange1.Location = 40D;
            c1GaugeRange1.ViewTag = ((long)(717286292691556980));
            c1GaugeRange1.Width = 0.1D;
            c1GaugeMarks1.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            c1GaugeMarks1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            c1GaugeMarks1.Interval = 500D;
            c1GaugeMarks1.Length = 7D;
            c1GaugeMarks1.Location = 40D;
            c1GaugeMarks1.ViewTag = ((long)(736708070189897828));
            c1GaugeMarks1.Width = 1D;
            c1GaugeMarks2.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            c1GaugeMarks2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            c1GaugeMarks2.Interval = 100D;
            c1GaugeMarks2.Length = 4D;
            c1GaugeMarks2.Location = 35D;
            c1GaugeMarks2.ViewTag = ((long)(740648722200817145));
            c1GaugeMarks2.Visible = false;
            c1GaugeMarks2.Width = 1D;
            c1GaugeLabels1.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.In;
            c1GaugeLabels1.Interval = 500D;
            c1GaugeLabels1.Location = 32D;
            c1GaugeLabels1.ViewTag = ((long)(740930198312349440));
            c1GaugeRange2.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange2.Filling.Color = System.Drawing.Color.Silver;
            c1GaugeRange2.Location = 60D;
            c1GaugeRange2.ViewTag = ((long)(669734115192623138));
            c1GaugeRange2.Width = 24D;
            c1GaugeRange3.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange3.Filling.Color = System.Drawing.Color.SteelBlue;
            c1GaugeRange3.Location = 60D;
            c1GaugeRange3.ToPointerIndex = 10;
            c1GaugeRange3.ViewTag = ((long)(669452639794046327));
            c1GaugeRange3.Width = 24D;
            c1GaugeSingleLabel1.Color = System.Drawing.Color.White;
            c1GaugeSingleLabel1.FontSize = 12D;
            c1GaugeSingleLabel1.Format = "##";
            c1GaugeSingleLabel1.Location = 62D;
            c1GaugeSingleLabel1.OrthogonalOffset = -20D;
            c1GaugeSingleLabel1.PointerIndex = 100;
            c1GaugeSingleLabel1.ViewTag = ((long)(648343123971847526));
            c1GaugeSingleLabel2.Location = 0D;
            c1GaugeSingleLabel2.Position = 0.5D;
            c1GaugeSingleLabel2.Text = "Thousands Of Dollars";
            c1GaugeSingleLabel2.ViewTag = ((long)(664781023878791980));
            c1GaugeSingleLabel3.Format = "Sales  ##";
            c1GaugeSingleLabel3.Location = 84D;
            c1GaugeSingleLabel3.OrthogonalAlignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeSingleLabel3.OrthogonalOffset = 15D;
            c1GaugeSingleLabel3.PointerIndex = 100;
            c1GaugeSingleLabel3.Position = 0D;
            c1GaugeSingleLabel3.ViewTag = ((long)(665343977590655058));
            c1GaugeSingleLabel4.Location = 104D;
            c1GaugeSingleLabel4.OrthogonalAlignment = C1.Win.C1Gauge.C1GaugeAlignment.Out;
            c1GaugeSingleLabel4.OrthogonalOffset = 15D;
            c1GaugeSingleLabel4.Position = 0D;
            c1GaugeSingleLabel4.Text = "Goal   1500";
            c1GaugeSingleLabel4.ViewTag = ((long)(665625453783307579));
            c1GaugeSingleMark1.AlignmentOffset = -1;
            c1GaugeSingleMark1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark1.Filling.Color = System.Drawing.Color.SteelBlue;
            c1GaugeSingleMark1.Length = 10D;
            c1GaugeSingleMark1.Location = 84D;
            c1GaugeSingleMark1.Position = 0D;
            c1GaugeSingleMark1.ViewTag = ((long)(671254961800690087));
            c1GaugeSingleMark1.Width = 10D;
            c1GaugeSingleMark2.AlignmentOffset = -1;
            c1GaugeSingleMark2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeSingleMark2.Filling.Color = System.Drawing.Color.Green;
            c1GaugeSingleMark2.Length = 10D;
            c1GaugeSingleMark2.Location = 104D;
            c1GaugeSingleMark2.Position = 0D;
            c1GaugeSingleMark2.ViewTag = ((long)(671536437573534036));
            c1GaugeSingleMark2.Width = 10D;
            c1GaugeRange4.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeRange4.Filling.Color = System.Drawing.Color.Green;
            c1GaugeRange4.From = 1500D;
            c1GaugeRange4.Location = 39D;
            c1GaugeRange4.To = 2000D;
            c1GaugeRange4.ViewTag = ((long)(671817913772729123));
            c1GaugeRange4.Width = 3D;
            this.c1LinearGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeRange1,
            c1GaugeMarks1,
            c1GaugeMarks2,
            c1GaugeLabels1,
            c1GaugeRange2,
            c1GaugeRange3,
            c1GaugeSingleLabel1,
            c1GaugeSingleLabel2,
            c1GaugeSingleLabel3,
            c1GaugeSingleLabel4,
            c1GaugeSingleMark1,
            c1GaugeSingleMark2,
            c1GaugeRange4});
            this.c1LinearGauge1.Maximum = 2000D;
            this.c1LinearGauge1.Name = "c1LinearGauge1";
            this.c1LinearGauge1.Pointer.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1LinearGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Rectangle;
            this.c1LinearGauge1.Pointer.Value = 1000D;
            this.c1LinearGauge1.Pointer.Visible = false;
            this.c1LinearGauge1.Viewport.AspectRatio = 2D;
            this.c1LinearGauge1.ViewTag = ((long)(716441866908225388));
            // 
            // panel11
            // 
            this.c1DashboardLayout1.SetCaption(this.panel11, "Customers");
            this.panel11.Controls.Add(this.c1TrueDBGrid1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel11, "aa75059c-7d31-42ec-b8f7-d25da356c8eb");
            this.panel11.Location = new System.Drawing.Point(0, 232);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10);
            this.panel11.Size = new System.Drawing.Size(282, 232);
            this.panel11.TabIndex = 4;
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Form;
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(10, 10);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = null;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(262, 212);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // c1SplitterPanel1
            // 
            this.c1DashboardLayout1.SetCaption(this.c1SplitterPanel1, "Sales By Country");
            this.c1SplitterPanel1.Height = 21;
            this.c1DashboardLayout1.SetId(this.c1SplitterPanel1, "cf9b0a9d-9a3f-4d48-947b-257ba31c3b16");
            this.c1SplitterPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel1.Name = "c1SplitterPanel1";
            this.c1SplitterPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(0, 0);
            this.c1SplitterPanel1.TabIndex = 0;
            this.c1SplitterPanel1.Text = "Sales By Country";
            // 
            // c1SplitterPanel2
            // 
            this.c1DashboardLayout1.SetCaption(this.c1SplitterPanel2, "Sales");
            this.c1SplitterPanel2.Height = 0;
            this.c1DashboardLayout1.SetId(this.c1SplitterPanel2, "c451c2d6-7660-47e9-9e27-1ebe098d5624");
            this.c1SplitterPanel2.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel2.Name = "c1SplitterPanel2";
            this.c1SplitterPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.c1SplitterPanel2.Size = new System.Drawing.Size(0, 0);
            this.c1SplitterPanel2.TabIndex = 1;
            // 
            // c1SplitterPanel3
            // 
            this.c1DashboardLayout1.SetCaption(this.c1SplitterPanel3, "Sales By Employee");
            this.c1SplitterPanel3.Height = 21;
            this.c1DashboardLayout1.SetId(this.c1SplitterPanel3, "97e5d98c-d0f5-450b-97c5-5df6499dae16");
            this.c1SplitterPanel3.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel3.Name = "c1SplitterPanel3";
            this.c1SplitterPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.c1SplitterPanel3.Size = new System.Drawing.Size(0, 0);
            this.c1SplitterPanel3.TabIndex = 2;
            this.c1SplitterPanel3.Text = "Sales By Employee";
            // 
            // c1SplitterPanel4
            // 
            this.c1DashboardLayout1.SetCaption(this.c1SplitterPanel4, "Goal");
            this.c1SplitterPanel4.Height = 21;
            this.c1DashboardLayout1.SetId(this.c1SplitterPanel4, "f2d0f705-5f80-49c5-8497-7742fa26b712");
            this.c1SplitterPanel4.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel4.Name = "c1SplitterPanel4";
            this.c1SplitterPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.c1SplitterPanel4.Size = new System.Drawing.Size(0, 0);
            this.c1SplitterPanel4.TabIndex = 3;
            this.c1SplitterPanel4.Text = "Calendar";
            // 
            // c1SplitterPanel5
            // 
            this.c1DashboardLayout1.SetCaption(this.c1SplitterPanel5, "Sales");
            this.c1SplitterPanel5.Height = 21;
            this.c1DashboardLayout1.SetId(this.c1SplitterPanel5, "be1a1442-59f7-4d53-9c37-756ed7e6859e");
            this.c1SplitterPanel5.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel5.Name = "c1SplitterPanel5";
            this.c1SplitterPanel5.Padding = new System.Windows.Forms.Padding(10);
            this.c1SplitterPanel5.Size = new System.Drawing.Size(0, 0);
            this.c1SplitterPanel5.TabIndex = 4;
            this.c1SplitterPanel5.Text = "Sales";
            // 
            // c1SplitterPanel6
            // 
            this.c1DashboardLayout1.SetCaption(this.c1SplitterPanel6, "Current Time");
            this.c1SplitterPanel6.Height = 21;
            this.c1DashboardLayout1.SetId(this.c1SplitterPanel6, "c106cd55-f0dd-4c94-82cf-51e786aa4297");
            this.c1SplitterPanel6.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel6.Name = "c1SplitterPanel6";
            this.c1SplitterPanel6.Padding = new System.Windows.Forms.Padding(10);
            this.c1SplitterPanel6.Size = new System.Drawing.Size(0, 0);
            this.c1SplitterPanel6.TabIndex = 5;
            this.c1SplitterPanel6.Text = "Current Time";
            // 
            // c1SplitterPanel7
            // 
            this.c1DashboardLayout1.SetCaption(this.c1SplitterPanel7, "Customers");
            this.c1SplitterPanel7.Height = 0;
            this.c1DashboardLayout1.SetId(this.c1SplitterPanel7, "aa75059c-7d31-42ec-b8f7-d25da356c8eb");
            this.c1SplitterPanel7.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel7.Name = "c1SplitterPanel7";
            this.c1SplitterPanel7.Padding = new System.Windows.Forms.Padding(10);
            this.c1SplitterPanel7.Size = new System.Drawing.Size(0, 0);
            this.c1SplitterPanel7.TabIndex = 6;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 484);
            this.Controls.Add(this.c1DashboardLayout1);
            this.Name = "Overview";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.c1DashboardLayout1.FlowLayoutControl.ResumeLayout(false);
            this.c1DashboardLayout1.GridLayoutControl.ResumeLayout(false);
            this.c1DashboardLayout1.SplitLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DashboardLayout1)).EndInit();
            this.c1DashboardLayout1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Layout.C1DashboardLayout c1DashboardLayout1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Chart.FlexChart flexChart1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private C1.Win.Chart.FlexPie flexPie1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel9;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel5;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel6;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel7;
        private C1.Win.C1Gauge.C1Gauge c1Gauge1;
        private C1.Win.C1Gauge.C1LinearGauge c1LinearGauge1;
    }
}