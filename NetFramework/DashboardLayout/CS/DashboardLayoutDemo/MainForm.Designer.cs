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
            this.components = new System.ComponentModel.Container();
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            C1.Win.Chart.FlexPieSlice flexPieSlice1 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice2 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice3 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice4 = new C1.Win.Chart.FlexPieSlice();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.c1DashboardLayout1 = new C1.Win.Layout.C1DashboardLayout();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.c1SplitterPanel1 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.c1SplitContainer1 = new C1.Win.SplitContainer.C1SplitContainer();
            this.splitpanelSales = new C1.Win.SplitContainer.C1SplitterPanel();
            this.c1FlexGrid1 = new DashboardLayoutDemo.Controls.DemoFlexGrid();
            this.c1SplitterPanel4 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.flexChart1 = new DashboardLayoutDemo.Controls.DemoFlexChart();
            this.c1SplitterPanel2 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.flexPie1 = new DashboardLayoutDemo.Controls.DemoFlexPie();
            this.c1SplitterPanel3 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.c1TrueDBGrid1 = new DashboardLayoutDemo.Controls.DemoTrueDBGrid();
            this.c1SplitterPanel5 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.labelSales = new DashboardLayoutDemo.Controls.DemoLabel();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1DashboardLayout1)).BeginInit();
            this.c1DashboardLayout1.FlowLayoutControl.SuspendLayout();
            this.c1DashboardLayout1.GridLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DashboardLayout1.SplitLayoutControl)).BeginInit();
            this.c1DashboardLayout1.SplitLayoutControl.SuspendLayout();
            this.c1DashboardLayout1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.splitpanelSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.c1SplitterPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).BeginInit();
            this.c1SplitterPanel2.SuspendLayout();
            this.c1SplitterPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.c1SplitterPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1DashboardLayout1
            // 
            this.c1DashboardLayout1.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // c1DashboardLayout1.FlowContentPanel
            // 
            this.c1DashboardLayout1.FlowLayoutControl.AutoScroll = true;
            this.c1DashboardLayout1.FlowLayoutControl.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.FlowLayoutControl.Controls.Add(this.panel2);
            this.c1DashboardLayout1.FlowLayoutControl.Controls.Add(this.panel4);
            this.c1DashboardLayout1.FlowLayoutControl.Controls.Add(this.panel10);
            this.c1DashboardLayout1.FlowLayoutControl.Controls.Add(this.panel6);
            this.c1DashboardLayout1.FlowLayoutControl.Controls.Add(this.panel8);
            this.c1DashboardLayout1.FlowLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.FlowLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.c1DashboardLayout1.FlowLayoutControl.Name = "FlowContentPanel";
            this.c1DashboardLayout1.FlowLayoutControl.Size = new System.Drawing.Size(1016, 517);
            this.c1DashboardLayout1.FlowLayoutControl.TabIndex = 0;
            // 
            // c1DashboardLayout1.GridContentPanel
            // 
            this.c1DashboardLayout1.GridLayoutControl.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.GridLayoutControl.ColumnCount = 4;
            this.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel1, 0, 0);
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel3, 3, 0);
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel9, 3, 2);
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel5, 2, 1);
            this.c1DashboardLayout1.GridLayoutControl.Controls.Add(this.panel7, 1, 0);
            this.c1DashboardLayout1.GridLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.GridLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.c1DashboardLayout1.GridLayoutControl.Name = "GridContentPanel";
            this.c1DashboardLayout1.GridLayoutControl.RowCount = 3;
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.c1DashboardLayout1.GridLayoutControl.Size = new System.Drawing.Size(1016, 517);
            this.c1DashboardLayout1.GridLayoutControl.TabIndex = 0;
            this.c1DashboardLayout1.LayoutType = C1.Win.Layout.LayoutType.Split;
            this.c1DashboardLayout1.Location = new System.Drawing.Point(0, 155);
            this.c1DashboardLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.c1DashboardLayout1.Name = "c1DashboardLayout1";
            this.c1DashboardLayout1.Size = new System.Drawing.Size(1016, 517);
            // 
            // c1DashboardLayout1.SplitContentPanel
            // 
            this.c1DashboardLayout1.SplitLayoutControl.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1DashboardLayout1.SplitLayoutControl.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SplitLayoutControl.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.c1DashboardLayout1.SplitLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SplitLayoutControl.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(166)))), ((int)(((byte)(194)))));
            this.c1DashboardLayout1.SplitLayoutControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.c1DashboardLayout1.SplitLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.c1DashboardLayout1.SplitLayoutControl.Name = "SplitContentPanel";
            this.c1DashboardLayout1.SplitLayoutControl.Panels.Add(this.c1SplitterPanel1);
            this.c1DashboardLayout1.SplitLayoutControl.Panels.Add(this.c1SplitterPanel2);
            this.c1DashboardLayout1.SplitLayoutControl.Panels.Add(this.c1SplitterPanel3);
            this.c1DashboardLayout1.SplitLayoutControl.Panels.Add(this.c1SplitterPanel5);
            this.c1DashboardLayout1.SplitLayoutControl.Size = new System.Drawing.Size(1016, 517);
            this.c1DashboardLayout1.SplitLayoutControl.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(166)))), ((int)(((byte)(194)))));
            this.c1DashboardLayout1.SplitLayoutControl.TabIndex = 0;
            this.c1DashboardLayout1.SplitLayoutControl.ToolTipGradient = C1.Win.SplitContainer.ToolTipGradient.Blue;
            this.c1DashboardLayout1.SplitLayoutControl.UseParentVisualStyle = false;
            this.c1DashboardLayout1.TabIndex = 2;
            this.c1DashboardLayout1.Text = "c1DashboardLayout1";
            this.c1ThemeController1.SetTheme(this.c1DashboardLayout1, "(default)");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SetCaption(this.panel2, "Sales");
            this.c1DashboardLayout1.SetId(this.panel2, "4f7a73f8-6e97-4b25-a74c-ba9b2bd0e6fa");
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(447, 272);
            this.panel2.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.panel2, "(default)");
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SetCaption(this.panel4, "Sales By Employee");
            this.c1DashboardLayout1.SetId(this.panel4, "096928d8-3c66-4891-91d5-ba2002e05142");
            this.panel4.Location = new System.Drawing.Point(447, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(333, 272);
            this.panel4.TabIndex = 8;
            this.c1ThemeController1.SetTheme(this.panel4, "(default)");
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SetCaption(this.panel10, "Customers");
            this.c1DashboardLayout1.SetId(this.panel10, "d3c1bda0-485f-487b-8542-b073f9015f7b");
            this.panel10.Location = new System.Drawing.Point(780, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10);
            this.panel10.Size = new System.Drawing.Size(236, 272);
            this.panel10.TabIndex = 11;
            this.c1ThemeController1.SetTheme(this.panel10, "(default)");
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SetCaption(this.panel6, "Sales By Country");
            this.c1DashboardLayout1.SetId(this.panel6, "74047b16-f54c-47c2-8171-896bd7701fe1");
            this.panel6.Location = new System.Drawing.Point(0, 272);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(447, 404);
            this.panel6.TabIndex = 12;
            this.c1ThemeController1.SetTheme(this.panel6, "(default)");
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SetCaption(this.panel8, "Total Sales");
            this.c1DashboardLayout1.SetId(this.panel8, "90db4822-a7cd-4d1a-b7f5-b20177de2e58");
            this.panel8.Location = new System.Drawing.Point(447, 272);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10);
            this.panel8.Size = new System.Drawing.Size(333, 176);
            this.panel8.TabIndex = 9;
            this.c1ThemeController1.SetTheme(this.panel8, "(default)");
            this.panel8.Resize += new System.EventHandler(this.panel8_Resize);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SetCaption(this.panel1, "Sales");
            this.c1DashboardLayout1.GridLayoutControl.SetColumnSpan(this.panel1, 2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel1, "4f7a73f8-6e97-4b25-a74c-ba9b2bd0e6fa");
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.c1DashboardLayout1.GridLayoutControl.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(508, 517);
            this.panel1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.panel1, "(default)");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SetCaption(this.panel3, "Sales By Employee");
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel3, "096928d8-3c66-4891-91d5-ba2002e05142");
            this.panel3.Location = new System.Drawing.Point(762, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.c1DashboardLayout1.GridLayoutControl.SetRowSpan(this.panel3, 2);
            this.panel3.Size = new System.Drawing.Size(254, 309);
            this.panel3.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.panel3, "(default)");
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SetCaption(this.panel9, "Customers");
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel9, "d3c1bda0-485f-487b-8542-b073f9015f7b");
            this.panel9.Location = new System.Drawing.Point(762, 309);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10);
            this.panel9.Size = new System.Drawing.Size(254, 208);
            this.panel9.TabIndex = 4;
            this.c1ThemeController1.SetTheme(this.panel9, "(default)");
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SetCaption(this.panel5, "Sales By Country");
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel5, "74047b16-f54c-47c2-8171-896bd7701fe1");
            this.panel5.Location = new System.Drawing.Point(508, 103);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.c1DashboardLayout1.GridLayoutControl.SetRowSpan(this.panel5, 2);
            this.panel5.Size = new System.Drawing.Size(254, 414);
            this.panel5.TabIndex = 2;
            this.c1ThemeController1.SetTheme(this.panel5, "(default)");
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.c1DashboardLayout1.SetCaption(this.panel7, "Total Sales");
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DashboardLayout1.SetId(this.panel7, "90db4822-a7cd-4d1a-b7f5-b20177de2e58");
            this.panel7.Location = new System.Drawing.Point(508, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(254, 103);
            this.panel7.TabIndex = 5;
            this.c1ThemeController1.SetTheme(this.panel7, "(default)");
            this.panel7.Resize += new System.EventHandler(this.panel7_Resize);
            // 
            // c1SplitterPanel1
            // 
            this.c1DashboardLayout1.SetCaption(this.c1SplitterPanel1, "");
            this.c1SplitterPanel1.Controls.Add(this.c1SplitContainer1);
            this.c1SplitterPanel1.Dock = C1.Win.SplitContainer.PanelDockStyle.Left;
            this.c1DashboardLayout1.SetId(this.c1SplitterPanel1, "d01255ea-1089-4fb2-bec2-cfb3e5874880");
            this.c1SplitterPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel1.Name = "c1SplitterPanel1";
            this.c1SplitterPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(506, 517);
            this.c1SplitterPanel1.TabIndex = 0;
            this.c1SplitterPanel1.Width = 506;
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.c1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(166)))), ((int)(((byte)(194)))));
            this.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.c1SplitContainer1.Location = new System.Drawing.Point(10, 10);
            this.c1SplitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.c1SplitContainer1.Name = "c1SplitContainer1";
            this.c1SplitContainer1.Panels.Add(this.splitpanelSales);
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel4);
            this.c1SplitContainer1.Size = new System.Drawing.Size(486, 497);
            this.c1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(166)))), ((int)(((byte)(194)))));
            this.c1SplitContainer1.TabIndex = 0;
            this.c1SplitContainer1.ToolTipGradient = C1.Win.SplitContainer.ToolTipGradient.Blue;
            this.c1SplitContainer1.UseParentVisualStyle = false;
            // 
            // splitpanelSales
            // 
            this.c1DashboardLayout1.SetCaption(this.splitpanelSales, "Sales");
            this.splitpanelSales.Controls.Add(this.c1FlexGrid1);
            this.splitpanelSales.Height = 246;
            this.c1DashboardLayout1.SetId(this.splitpanelSales, "4f7a73f8-6e97-4b25-a74c-ba9b2bd0e6fa");
            this.splitpanelSales.Location = new System.Drawing.Point(0, 21);
            this.splitpanelSales.Name = "splitpanelSales";
            this.splitpanelSales.Padding = new System.Windows.Forms.Padding(10);
            this.splitpanelSales.Size = new System.Drawing.Size(486, 225);
            this.splitpanelSales.TabIndex = 2;
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowEditing = false;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(10, 10);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 19;
            this.c1FlexGrid1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.c1FlexGrid1.Size = new System.Drawing.Size(466, 205);
            this.c1FlexGrid1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1FlexGrid1, "(default)");
            // 
            // c1SplitterPanel4
            // 
            this.c1DashboardLayout1.SetCaption(this.c1SplitterPanel4, "Sales By Country");
            this.c1SplitterPanel4.Controls.Add(this.flexChart1);
            this.c1SplitterPanel4.Height = 247;
            this.c1DashboardLayout1.SetId(this.c1SplitterPanel4, "74047b16-f54c-47c2-8171-896bd7701fe1");
            this.c1SplitterPanel4.Location = new System.Drawing.Point(0, 271);
            this.c1SplitterPanel4.Name = "c1SplitterPanel4";
            this.c1SplitterPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.c1SplitterPanel4.Size = new System.Drawing.Size(486, 226);
            this.c1SplitterPanel4.TabIndex = 3;
            // 
            // flexChart1
            // 
            this.flexChart1.AxisX.Chart = this.flexChart1;
            this.flexChart1.AxisX.DataSource = null;
            this.flexChart1.AxisX.GroupProvider = null;
            this.flexChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.flexChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.flexChart1.AxisX.PlotAreaName = null;
            this.flexChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.flexChart1.AxisY.AxisLine = false;
            this.flexChart1.AxisY.Chart = this.flexChart1;
            this.flexChart1.AxisY.DataSource = null;
            this.flexChart1.AxisY.GroupProvider = null;
            this.flexChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.flexChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.flexChart1.AxisY.MajorGrid = true;
            this.flexChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.flexChart1.AxisY.PlotAreaName = null;
            this.flexChart1.AxisY.Position = C1.Chart.Position.Left;
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
            this.flexChart1.Size = new System.Drawing.Size(466, 206);
            this.flexChart1.TabIndex = 0;
            this.flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            this.flexChart1.ToolTip.Content = "{value}";
            // 
            // c1SplitterPanel2
            // 
            this.c1DashboardLayout1.SetCaption(this.c1SplitterPanel2, "Sales By Employee");
            this.c1SplitterPanel2.Controls.Add(this.flexPie1);
            this.c1SplitterPanel2.Height = 256;
            this.c1DashboardLayout1.SetId(this.c1SplitterPanel2, "096928d8-3c66-4891-91d5-ba2002e05142");
            this.c1SplitterPanel2.Location = new System.Drawing.Point(510, 21);
            this.c1SplitterPanel2.Name = "c1SplitterPanel2";
            this.c1SplitterPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.c1SplitterPanel2.Size = new System.Drawing.Size(506, 235);
            this.c1SplitterPanel2.TabIndex = 1;
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
            this.flexPie1.Size = new System.Drawing.Size(486, 215);
            this.flexPie1.TabIndex = 0;
            this.flexPie1.Text = "flexPie1";
            // 
            // 
            // 
            this.flexPie1.ToolTip.Content = "{value}";
            // 
            // c1SplitterPanel3
            // 
            this.c1DashboardLayout1.SetCaption(this.c1SplitterPanel3, "Customers");
            this.c1SplitterPanel3.Controls.Add(this.c1TrueDBGrid1);
            this.c1SplitterPanel3.Dock = C1.Win.SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanel3.Height = 257;
            this.c1DashboardLayout1.SetId(this.c1SplitterPanel3, "d3c1bda0-485f-487b-8542-b073f9015f7b");
            this.c1SplitterPanel3.Location = new System.Drawing.Point(510, 281);
            this.c1SplitterPanel3.Name = "c1SplitterPanel3";
            this.c1SplitterPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.c1SplitterPanel3.Size = new System.Drawing.Size(251, 236);
            this.c1SplitterPanel3.TabIndex = 2;
            this.c1SplitterPanel3.Width = 251;
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1TrueDBGrid1.DataView = C1.Win.TrueDBGrid.DataViewEnum.Form;
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(10, 10);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(231, 216);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1TrueDBGrid1, "(default)");
            this.c1TrueDBGrid1.UseCompatibleTextRendering = false;
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // c1SplitterPanel5
            // 
            this.c1DashboardLayout1.SetCaption(this.c1SplitterPanel5, "Total Sales");
            this.c1SplitterPanel5.Controls.Add(this.labelSales);
            this.c1SplitterPanel5.Dock = C1.Win.SplitContainer.PanelDockStyle.Right;
            this.c1SplitterPanel5.Height = 257;
            this.c1DashboardLayout1.SetId(this.c1SplitterPanel5, "90db4822-a7cd-4d1a-b7f5-b20177de2e58");
            this.c1SplitterPanel5.Location = new System.Drawing.Point(765, 281);
            this.c1SplitterPanel5.Name = "c1SplitterPanel5";
            this.c1SplitterPanel5.Padding = new System.Windows.Forms.Padding(10);
            this.c1SplitterPanel5.Size = new System.Drawing.Size(251, 236);
            this.c1SplitterPanel5.TabIndex = 4;
            this.c1SplitterPanel5.Width = 251;
            this.c1SplitterPanel5.Resize += new System.EventHandler(this.c1SplitterPanel5_Resize);
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.BackColor = System.Drawing.Color.Transparent;
            this.labelSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelSales.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSales.ForeColor = System.Drawing.Color.Black;
            this.labelSales.Location = new System.Drawing.Point(60, 44);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(137, 37);
            this.labelSales.TabIndex = 0;
            this.labelSales.Tag = null;
            this.labelSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c1ThemeController1.SetTheme(this.labelSales, "(default)");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 672);
            this.Controls.Add(this.c1DashboardLayout1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.c1ThemeController1.SetTheme(this, "(default)");            
            this.DemoThemeChanged += new System.EventHandler<C1.Win.Themes.ThemeEventArgs>(this.MainForm_DemoThemeChanged);
            this.ToolIconAppearanceChanged += new System.EventHandler<DashboardLayoutDemo.Controls.ToolIconAppearanceEventArgs>(this.MainForm_ToolIconAppearanceChanged);
            this.ApplyLayoutClicked += new System.EventHandler<DashboardLayoutDemo.Controls.FilePathEventArgs>(this.MainForm_ApplyLayoutClicked);
            this.SaveLayoutClicked += new System.EventHandler<DashboardLayoutDemo.Controls.FilePathEventArgs>(this.MainForm_SaveLayoutClicked);
            this.ResetLayoutClicked += new System.EventHandler<DashboardLayoutDemo.Controls.FilePathEventArgs>(this.MainForm_ResetLayoutClicked);
            this.LayoutTypeChanged += new System.EventHandler<DashboardLayoutDemo.Controls.LayoutTypeEventArgs>(this.MainForm_LayoutTypeChanged);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.c1DashboardLayout1, 0);
            this.c1DashboardLayout1.FlowLayoutControl.ResumeLayout(false);
            this.c1DashboardLayout1.GridLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DashboardLayout1.SplitLayoutControl)).EndInit();
            this.c1DashboardLayout1.SplitLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DashboardLayout1)).EndInit();
            this.c1DashboardLayout1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.splitpanelSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.c1SplitterPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).EndInit();
            this.c1SplitterPanel2.ResumeLayout(false);
            this.c1SplitterPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            this.c1SplitterPanel5.ResumeLayout(false);
            this.c1SplitterPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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