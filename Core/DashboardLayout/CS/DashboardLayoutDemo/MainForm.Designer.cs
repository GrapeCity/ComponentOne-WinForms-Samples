namespace DashboardLayoutDemo
{
    partial class MainForm
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
                SampleHelper.DisposeInstance();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            c1DashboardLayout1 = new C1.Win.Layout.C1DashboardLayout();
            panel2 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel10 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            panel8 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel9 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            panel7 = new System.Windows.Forms.Panel();
            c1SplitterPanel1 = new C1.Win.SplitContainer.C1SplitterPanel();
            c1SplitContainer1 = new C1.Win.SplitContainer.C1SplitContainer();
            splitpanelSales = new C1.Win.SplitContainer.C1SplitterPanel();
            c1FlexGrid1 = new Controls.DemoFlexGrid();
            c1SplitterPanel4 = new C1.Win.SplitContainer.C1SplitterPanel();
            flexChart1 = new Controls.DemoFlexChart();
            c1SplitterPanel2 = new C1.Win.SplitContainer.C1SplitterPanel();
            flexPie1 = new Controls.DemoFlexPie();
            c1SplitterPanel3 = new C1.Win.SplitContainer.C1SplitterPanel();
            c1TrueDBGrid1 = new Controls.DemoTrueDBGrid();
            c1SplitterPanel5 = new C1.Win.SplitContainer.C1SplitterPanel();
            labelSales = new Controls.DemoLabel();
            c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)c1DashboardLayout1).BeginInit();
            c1DashboardLayout1.FlowLayoutControl.SuspendLayout();
            c1DashboardLayout1.GridLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1DashboardLayout1.SplitLayoutControl).BeginInit();
            c1DashboardLayout1.SplitLayoutControl.SuspendLayout();
            c1SplitterPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1SplitContainer1).BeginInit();
            c1SplitContainer1.SuspendLayout();
            splitpanelSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            c1SplitterPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flexChart1).BeginInit();
            c1SplitterPanel2.SuspendLayout();
            c1SplitterPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1TrueDBGrid1).BeginInit();
            c1SplitterPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)labelSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController1).BeginInit();
            SuspendLayout();
            // 
            // c1DashboardLayout1
            // 
            c1DashboardLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            c1DashboardLayout1.FlowLayoutControl.AutoScroll = true;
            c1DashboardLayout1.FlowLayoutControl.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(panel2);
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(panel4);
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(panel10);
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(panel6);
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(panel8);
            c1DashboardLayout1.FlowLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.FlowLayoutControl.Location = new System.Drawing.Point(0, 0);
            c1DashboardLayout1.FlowLayoutControl.Margin = new System.Windows.Forms.Padding(0);
            c1DashboardLayout1.FlowLayoutControl.Name = "FlowContentPanel";
            c1DashboardLayout1.FlowLayoutControl.Size = new System.Drawing.Size(1016, 517);
            c1DashboardLayout1.FlowLayoutControl.TabIndex = 0;
            // 
            // 
            // 
            c1DashboardLayout1.GridLayoutControl.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.GridLayoutControl.ColumnCount = 4;
            c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            c1DashboardLayout1.GridLayoutControl.Controls.Add(panel1, 0, 0);
            c1DashboardLayout1.GridLayoutControl.Controls.Add(panel3, 3, 0);
            c1DashboardLayout1.GridLayoutControl.Controls.Add(panel9, 3, 2);
            c1DashboardLayout1.GridLayoutControl.Controls.Add(panel5, 2, 1);
            c1DashboardLayout1.GridLayoutControl.Controls.Add(panel7, 1, 0);
            c1DashboardLayout1.GridLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.GridLayoutControl.Location = new System.Drawing.Point(0, 0);
            c1DashboardLayout1.GridLayoutControl.Margin = new System.Windows.Forms.Padding(0);
            c1DashboardLayout1.GridLayoutControl.Name = "GridContentPanel";
            c1DashboardLayout1.GridLayoutControl.RowCount = 3;
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            c1DashboardLayout1.GridLayoutControl.Size = new System.Drawing.Size(1016, 517);
            c1DashboardLayout1.GridLayoutControl.TabIndex = 0;
            c1DashboardLayout1.LayoutType = C1.Win.Layout.LayoutType.Split;
            c1DashboardLayout1.Location = new System.Drawing.Point(0, 161);
            c1DashboardLayout1.Margin = new System.Windows.Forms.Padding(0);
            c1DashboardLayout1.Name = "c1DashboardLayout1";
            c1DashboardLayout1.Size = new System.Drawing.Size(1145, 521);
            // 
            // 
            // 
            c1DashboardLayout1.SplitLayoutControl.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            c1DashboardLayout1.SplitLayoutControl.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SplitLayoutControl.CollapsingAreaColor = System.Drawing.Color.FromArgb(240, 245, 250);
            c1DashboardLayout1.SplitLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SplitLayoutControl.FixedLineColor = System.Drawing.Color.FromArgb(145, 166, 194);
            c1DashboardLayout1.SplitLayoutControl.ForeColor = System.Drawing.Color.FromArgb(30, 57, 91);
            c1DashboardLayout1.SplitLayoutControl.HeaderHeight = 14;
            c1DashboardLayout1.SplitLayoutControl.Location = new System.Drawing.Point(10, 10);
            c1DashboardLayout1.SplitLayoutControl.Margin = new System.Windows.Forms.Padding(0);
            c1DashboardLayout1.SplitLayoutControl.Name = "SplitContentPanel";
            c1DashboardLayout1.SplitLayoutControl.Panels.Add(c1SplitterPanel1);
            c1DashboardLayout1.SplitLayoutControl.Panels.Add(c1SplitterPanel2);
            c1DashboardLayout1.SplitLayoutControl.Panels.Add(c1SplitterPanel3);
            c1DashboardLayout1.SplitLayoutControl.Panels.Add(c1SplitterPanel5);
            c1DashboardLayout1.SplitLayoutControl.Size = new System.Drawing.Size(1125, 501);
            c1DashboardLayout1.SplitLayoutControl.SplitterColor = System.Drawing.Color.FromArgb(145, 166, 194);
            c1DashboardLayout1.SplitLayoutControl.SplitterWidth = 3;
            c1DashboardLayout1.SplitLayoutControl.TabIndex = 0;
            c1DashboardLayout1.SplitLayoutControl.ToolTipGradient = C1.Win.SplitContainer.ToolTipGradient.Blue;
            c1DashboardLayout1.TabIndex = 2;
            c1DashboardLayout1.TabStop = false;
            c1DashboardLayout1.Text = "c1DashboardLayout1";
            c1ThemeController1.SetTheme(c1DashboardLayout1, "(default)");
            // 
            // panel2
            // 
            c1DashboardLayout1.SetCaption(panel2, "Sales");
            c1DashboardLayout1.SetId(panel2, "C1.Win.Layout.FlowLayout~4f7a73f8-6e97-4b25-a74c-ba9b2bd0e6fa");
            panel2.Location = new System.Drawing.Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new System.Windows.Forms.Padding(10);
            panel2.Size = new System.Drawing.Size(447, 272);
            panel2.TabIndex = 0;
            c1ThemeController1.SetTheme(panel2, "(default)");
            // 
            // panel4
            // 
            c1DashboardLayout1.SetCaption(panel4, "Sales By Employee");
            c1DashboardLayout1.SetId(panel4, "C1.Win.Layout.FlowLayout~096928d8-3c66-4891-91d5-ba2002e05142");
            panel4.Location = new System.Drawing.Point(456, 3);
            panel4.Name = "panel4";
            panel4.Padding = new System.Windows.Forms.Padding(10);
            panel4.Size = new System.Drawing.Size(333, 272);
            panel4.TabIndex = 8;
            c1ThemeController1.SetTheme(panel4, "(default)");
            // 
            // panel10
            // 
            c1DashboardLayout1.SetCaption(panel10, "Customers");
            c1DashboardLayout1.SetId(panel10, "C1.Win.Layout.FlowLayout~d3c1bda0-485f-487b-8542-b073f9015f7b");
            panel10.Location = new System.Drawing.Point(3, 281);
            panel10.Name = "panel10";
            panel10.Padding = new System.Windows.Forms.Padding(10);
            panel10.Size = new System.Drawing.Size(236, 272);
            panel10.TabIndex = 11;
            c1ThemeController1.SetTheme(panel10, "(default)");
            // 
            // panel6
            // 
            c1DashboardLayout1.SetCaption(panel6, "Sales By Country");
            c1DashboardLayout1.SetId(panel6, "C1.Win.Layout.FlowLayout~74047b16-f54c-47c2-8171-896bd7701fe1");
            panel6.Location = new System.Drawing.Point(245, 281);
            panel6.Name = "panel6";
            panel6.Padding = new System.Windows.Forms.Padding(10);
            panel6.Size = new System.Drawing.Size(447, 404);
            panel6.TabIndex = 12;
            c1ThemeController1.SetTheme(panel6, "(default)");
            // 
            // panel8
            // 
            c1DashboardLayout1.SetCaption(panel8, "Total Sales");
            c1DashboardLayout1.SetId(panel8, "C1.Win.Layout.FlowLayout~90db4822-a7cd-4d1a-b7f5-b20177de2e58");
            panel8.Location = new System.Drawing.Point(3, 691);
            panel8.Name = "panel8";
            panel8.Padding = new System.Windows.Forms.Padding(10);
            panel8.Size = new System.Drawing.Size(333, 176);
            panel8.TabIndex = 9;
            c1ThemeController1.SetTheme(panel8, "(default)");
            panel8.Resize += panel8_Resize;
            // 
            // panel1
            // 
            c1DashboardLayout1.SetCaption(panel1, "Sales");
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SetId(panel1, "C1.Win.Layout.GridLayout~4f7a73f8-6e97-4b25-a74c-ba9b2bd0e6fa");
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(10);
            panel1.Size = new System.Drawing.Size(502, 511);
            panel1.TabIndex = 0;
            c1ThemeController1.SetTheme(panel1, "(default)");
            // 
            // panel3
            // 
            c1DashboardLayout1.SetCaption(panel3, "Sales By Employee");
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SetId(panel3, "C1.Win.Layout.GridLayout~096928d8-3c66-4891-91d5-ba2002e05142");
            panel3.Location = new System.Drawing.Point(765, 3);
            panel3.Name = "panel3";
            panel3.Padding = new System.Windows.Forms.Padding(10);
            panel3.Size = new System.Drawing.Size(248, 303);
            panel3.TabIndex = 1;
            c1ThemeController1.SetTheme(panel3, "(default)");
            // 
            // panel9
            // 
            c1DashboardLayout1.SetCaption(panel9, "Customers");
            panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SetId(panel9, "C1.Win.Layout.GridLayout~d3c1bda0-485f-487b-8542-b073f9015f7b");
            panel9.Location = new System.Drawing.Point(765, 312);
            panel9.Name = "panel9";
            panel9.Padding = new System.Windows.Forms.Padding(10);
            panel9.Size = new System.Drawing.Size(248, 202);
            panel9.TabIndex = 4;
            c1ThemeController1.SetTheme(panel9, "(default)");
            // 
            // panel5
            // 
            c1DashboardLayout1.SetCaption(panel5, "Sales By Country");
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SetId(panel5, "C1.Win.Layout.GridLayout~74047b16-f54c-47c2-8171-896bd7701fe1");
            panel5.Location = new System.Drawing.Point(511, 106);
            panel5.Name = "panel5";
            panel5.Padding = new System.Windows.Forms.Padding(10);
            panel5.Size = new System.Drawing.Size(248, 408);
            panel5.TabIndex = 2;
            c1ThemeController1.SetTheme(panel5, "(default)");
            // 
            // panel7
            // 
            c1DashboardLayout1.SetCaption(panel7, "Total Sales");
            panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SetId(panel7, "C1.Win.Layout.GridLayout~90db4822-a7cd-4d1a-b7f5-b20177de2e58");
            panel7.Location = new System.Drawing.Point(511, 3);
            panel7.Name = "panel7";
            panel7.Padding = new System.Windows.Forms.Padding(10);
            panel7.Size = new System.Drawing.Size(248, 97);
            panel7.TabIndex = 5;
            c1ThemeController1.SetTheme(panel7, "(default)");
            panel7.Resize += panel7_Resize;
            // 
            // c1SplitterPanel1
            // 
            c1SplitterPanel1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(c1SplitterPanel1, "");
            c1SplitterPanel1.Controls.Add(c1SplitContainer1);
            c1SplitterPanel1.Dock = C1.Win.SplitContainer.PanelDockStyle.Left;
            c1SplitterPanel1.Height = 501;
            c1DashboardLayout1.SetId(c1SplitterPanel1, "C1.Win.Layout.SplitLayout~d01255ea-1089-4fb2-bec2-cfb3e5874880");
            c1SplitterPanel1.Location = new System.Drawing.Point(0, 0);
            c1SplitterPanel1.MinHeight = 41;
            c1SplitterPanel1.MinWidth = 41;
            c1SplitterPanel1.Name = "c1SplitterPanel1";
            c1SplitterPanel1.Padding = new System.Windows.Forms.Padding(10);
            c1SplitterPanel1.Size = new System.Drawing.Size(418, 501);
            c1SplitterPanel1.SizeRatio = 37.226D;
            c1SplitterPanel1.TabIndex = 0;
            c1SplitterPanel1.Width = 418;
            // 
            // c1SplitContainer1
            // 
            c1SplitContainer1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            c1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(240, 245, 250);
            c1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(145, 166, 194);
            c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(30, 57, 91);
            c1SplitContainer1.HeaderButtonBackColor = System.Drawing.Color.Transparent;
            c1SplitContainer1.HeaderHeight = 14;
            c1SplitContainer1.Location = new System.Drawing.Point(10, 10);
            c1SplitContainer1.Name = "c1SplitContainer1";
            c1SplitContainer1.Panels.Add(splitpanelSales);
            c1SplitContainer1.Panels.Add(c1SplitterPanel4);
            c1SplitContainer1.Size = new System.Drawing.Size(398, 481);
            c1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(145, 166, 194);
            c1SplitContainer1.SplitterWidth = 3;
            c1SplitContainer1.TabIndex = 0;
            c1SplitContainer1.ToolTipGradient = C1.Win.SplitContainer.ToolTipGradient.Blue;
            // 
            // splitpanelSales
            // 
            splitpanelSales.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(splitpanelSales, "Sales");
            splitpanelSales.Controls.Add(c1FlexGrid1);
            splitpanelSales.Height = 177;
            c1DashboardLayout1.SetId(splitpanelSales, "C1.Win.Layout.SplitLayout~4f7a73f8-6e97-4b25-a74c-ba9b2bd0e6fa");
            splitpanelSales.Location = new System.Drawing.Point(0, 0);
            splitpanelSales.MinHeight = 41;
            splitpanelSales.MinWidth = 41;
            splitpanelSales.Name = "splitpanelSales";
            splitpanelSales.Padding = new System.Windows.Forms.Padding(10);
            splitpanelSales.Size = new System.Drawing.Size(398, 177);
            splitpanelSales.SizeRatio = 37D;
            splitpanelSales.TabIndex = 2;
            splitpanelSales.Width = 398;
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.AllowEditing = false;
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:";
            c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1FlexGrid1.Location = new System.Drawing.Point(10, 33);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            c1FlexGrid1.Size = new System.Drawing.Size(378, 134);
            c1FlexGrid1.TabIndex = 0;
            c1ThemeController1.SetTheme(c1FlexGrid1, "(default)");
            // 
            // c1SplitterPanel4
            // 
            c1SplitterPanel4.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(c1SplitterPanel4, "Sales By Country");
            c1SplitterPanel4.Controls.Add(flexChart1);
            c1SplitterPanel4.Height = 301;
            c1DashboardLayout1.SetId(c1SplitterPanel4, "C1.Win.Layout.SplitLayout~74047b16-f54c-47c2-8171-896bd7701fe1");
            c1SplitterPanel4.Location = new System.Drawing.Point(0, 180);
            c1SplitterPanel4.MinHeight = 41;
            c1SplitterPanel4.MinWidth = 41;
            c1SplitterPanel4.Name = "c1SplitterPanel4";
            c1SplitterPanel4.Padding = new System.Windows.Forms.Padding(10);
            c1SplitterPanel4.Size = new System.Drawing.Size(398, 301);
            c1SplitterPanel4.TabIndex = 3;
            c1SplitterPanel4.Width = 398;
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
            flexChart1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
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
            flexChart1.Size = new System.Drawing.Size(378, 258);
            flexChart1.TabIndex = 0;
            flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            flexChart1.ToolTip.Content = "{value}";
            // 
            // c1SplitterPanel2
            // 
            c1SplitterPanel2.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(c1SplitterPanel2, "Sales By Employee");
            c1SplitterPanel2.Controls.Add(flexPie1);
            c1SplitterPanel2.Height = 179;
            c1DashboardLayout1.SetId(c1SplitterPanel2, "C1.Win.Layout.SplitLayout~096928d8-3c66-4891-91d5-ba2002e05142");
            c1SplitterPanel2.Location = new System.Drawing.Point(421, 0);
            c1SplitterPanel2.MinHeight = 41;
            c1SplitterPanel2.MinWidth = 41;
            c1SplitterPanel2.Name = "c1SplitterPanel2";
            c1SplitterPanel2.Padding = new System.Windows.Forms.Padding(10);
            c1SplitterPanel2.Size = new System.Drawing.Size(704, 179);
            c1SplitterPanel2.SizeRatio = 35.867D;
            c1SplitterPanel2.TabIndex = 1;
            c1SplitterPanel2.Width = 704;
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
            flexPie1.Size = new System.Drawing.Size(684, 136);
            flexPie1.TabIndex = 0;
            flexPie1.Text = "flexPie1";
            flexPie1.Titles = null;
            // 
            // 
            // 
            flexPie1.ToolTip.Content = "{value}";
            // 
            // c1SplitterPanel3
            // 
            c1SplitterPanel3.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(c1SplitterPanel3, "Customers");
            c1SplitterPanel3.Controls.Add(c1TrueDBGrid1);
            c1SplitterPanel3.Dock = C1.Win.SplitContainer.PanelDockStyle.Left;
            c1SplitterPanel3.Height = 319;
            c1DashboardLayout1.SetId(c1SplitterPanel3, "C1.Win.Layout.SplitLayout~d3c1bda0-485f-487b-8542-b073f9015f7b");
            c1SplitterPanel3.Location = new System.Drawing.Point(421, 182);
            c1SplitterPanel3.MinHeight = 41;
            c1SplitterPanel3.MinWidth = 41;
            c1SplitterPanel3.Name = "c1SplitterPanel3";
            c1SplitterPanel3.Padding = new System.Windows.Forms.Padding(10);
            c1SplitterPanel3.Size = new System.Drawing.Size(315, 319);
            c1SplitterPanel3.SizeRatio = 44.866D;
            c1SplitterPanel3.TabIndex = 2;
            c1SplitterPanel3.Width = 315;
            // 
            // c1TrueDBGrid1
            // 
            c1TrueDBGrid1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1TrueDBGrid1.DataView = C1.Win.TrueDBGrid.DataViewEnum.Form;
            c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1TrueDBGrid1.ForeColor = System.Drawing.SystemColors.ControlText;
            c1TrueDBGrid1.Images.Add((System.Drawing.Image)resources.GetObject("c1TrueDBGrid1.Images"));
            c1TrueDBGrid1.Location = new System.Drawing.Point(10, 33);
            c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = null;
            c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            c1TrueDBGrid1.RowHeight = 20;
            c1TrueDBGrid1.Size = new System.Drawing.Size(295, 276);
            c1TrueDBGrid1.TabIndex = 0;
            c1ThemeController1.SetTheme(c1TrueDBGrid1, "(default)");
            // 
            // c1SplitterPanel5
            // 
            c1SplitterPanel5.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SetCaption(c1SplitterPanel5, "Total Sales");
            c1SplitterPanel5.Controls.Add(labelSales);
            c1SplitterPanel5.Dock = C1.Win.SplitContainer.PanelDockStyle.Right;
            c1SplitterPanel5.Height = 319;
            c1DashboardLayout1.SetId(c1SplitterPanel5, "C1.Win.Layout.SplitLayout~90db4822-a7cd-4d1a-b7f5-b20177de2e58");
            c1SplitterPanel5.Location = new System.Drawing.Point(739, 182);
            c1SplitterPanel5.MinHeight = 41;
            c1SplitterPanel5.MinWidth = 41;
            c1SplitterPanel5.Name = "c1SplitterPanel5";
            c1SplitterPanel5.Padding = new System.Windows.Forms.Padding(10);
            c1SplitterPanel5.Size = new System.Drawing.Size(386, 319);
            c1SplitterPanel5.TabIndex = 4;
            c1SplitterPanel5.Width = 386;
            c1SplitterPanel5.Resize += c1SplitterPanel5_Resize;
            // 
            // labelSales
            // 
            labelSales.AutoSize = true;
            labelSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            labelSales.Location = new System.Drawing.Point(60, 45);
            labelSales.Name = "labelSales";
            labelSales.Size = new System.Drawing.Size(6, 6);
            labelSales.TabIndex = 0;
            labelSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            c1ThemeController1.SetTheme(labelSales, "(default)");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1145, 682);
            Controls.Add(c1DashboardLayout1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "MainForm";
            c1ThemeController1.SetTheme(this, "(default)");
            DemoThemeChanged += MainForm_DemoThemeChanged;
            ToolIconAppearanceChanged += MainForm_ToolIconAppearanceChanged;
            ApplyLayoutClicked += MainForm_ApplyLayoutClicked;
            SaveLayoutClicked += MainForm_SaveLayoutClicked;
            ResetLayoutClicked += MainForm_ResetLayoutClicked;
            LayoutTypeChanged += MainForm_LayoutTypeChanged;
            Load += MainForm_Load;
            Controls.SetChildIndex(c1DashboardLayout1, 0);
            c1DashboardLayout1.FlowLayoutControl.ResumeLayout(false);
            c1DashboardLayout1.GridLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1DashboardLayout1.SplitLayoutControl).EndInit();
            c1DashboardLayout1.SplitLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1DashboardLayout1).EndInit();
            c1SplitterPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1SplitContainer1).EndInit();
            c1SplitContainer1.ResumeLayout(false);
            splitpanelSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            c1SplitterPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flexChart1).EndInit();
            c1SplitterPanel2.ResumeLayout(false);
            c1SplitterPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1TrueDBGrid1).EndInit();
            c1SplitterPanel5.ResumeLayout(false);
            c1SplitterPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)labelSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private C1.Win.Layout.C1DashboardLayout c1DashboardLayout1;        
        private C1.Win.SplitContainer.C1SplitContainer c1SplitContainer1;
        private C1.Win.SplitContainer.C1SplitterPanel splitpanelSales;
        private Controls.DemoFlexGrid c1FlexGrid1;
        private Controls.DemoFlexPie flexPie1;
        private Controls.DemoFlexChart flexChart1;
        private Controls.DemoLabel labelSales;
        private Controls.DemoTrueDBGrid c1TrueDBGrid1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel1;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel2;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel3;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel4;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel5;
    }
}