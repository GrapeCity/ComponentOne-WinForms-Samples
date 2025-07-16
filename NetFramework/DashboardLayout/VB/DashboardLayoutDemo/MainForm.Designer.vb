Namespace DashboardDemo
    Partial Public Class MainForm
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
                SampleHelper.DisposeInstance()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim elementSize1 As C1.Chart.ElementSize = New C1.Chart.ElementSize()
            Dim series1 As C1.Win.Chart.Series = New C1.Win.Chart.Series()
            Dim flexPieSlice1 As C1.Win.Chart.FlexPieSlice = New C1.Win.Chart.FlexPieSlice()
            Dim flexPieSlice2 As C1.Win.Chart.FlexPieSlice = New C1.Win.Chart.FlexPieSlice()
            Dim flexPieSlice3 As C1.Win.Chart.FlexPieSlice = New C1.Win.Chart.FlexPieSlice()
            Dim flexPieSlice4 As C1.Win.Chart.FlexPieSlice = New C1.Win.Chart.FlexPieSlice()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.c1DashboardLayout1 = New C1.Win.Layout.C1DashboardLayout()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.panel10 = New System.Windows.Forms.Panel()
            Me.panel6 = New System.Windows.Forms.Panel()
            Me.panel8 = New System.Windows.Forms.Panel()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.panel9 = New System.Windows.Forms.Panel()
            Me.panel5 = New System.Windows.Forms.Panel()
            Me.panel7 = New System.Windows.Forms.Panel()
            Me.c1SplitterPanel1 = New C1.Win.SplitContainer.C1SplitterPanel()
            Me.c1SplitContainer1 = New C1.Win.SplitContainer.C1SplitContainer()
            Me.splitpanelSales = New C1.Win.SplitContainer.C1SplitterPanel()
            Me.c1FlexGrid1 = New DashboardDemo.Controls.DemoFlexGrid()
            Me.c1SplitterPanel4 = New C1.Win.SplitContainer.C1SplitterPanel()
            Me.flexChart1 = New DashboardDemo.Controls.DemoFlexChart()
            Me.c1SplitterPanel2 = New C1.Win.SplitContainer.C1SplitterPanel()
            Me.flexPie1 = New DashboardDemo.Controls.DemoFlexPie()
            Me.c1SplitterPanel3 = New C1.Win.SplitContainer.C1SplitterPanel()
            Me.c1TrueDBGrid1 = New DashboardDemo.Controls.DemoTrueDBGrid()
            Me.c1SplitterPanel5 = New C1.Win.SplitContainer.C1SplitterPanel()
            Me.labelSales = New DashboardDemo.Controls.DemoLabel()
            Me.c1ThemeController1 = New C1.Win.Themes.C1ThemeController()
            CType((Me.c1DashboardLayout1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.c1DashboardLayout1.FlowLayoutControl.SuspendLayout()
            Me.c1DashboardLayout1.GridLayoutControl.SuspendLayout()
            CType((Me.c1DashboardLayout1.SplitLayoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.c1DashboardLayout1.SplitLayoutControl.SuspendLayout()
            Me.c1DashboardLayout1.SuspendLayout()
            Me.c1SplitterPanel1.SuspendLayout()
            CType((Me.c1SplitContainer1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.c1SplitContainer1.SuspendLayout()
            Me.splitpanelSales.SuspendLayout()
            CType((Me.c1FlexGrid1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.c1SplitterPanel4.SuspendLayout()
            CType((Me.flexChart1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.c1SplitterPanel2.SuspendLayout()
            Me.c1SplitterPanel3.SuspendLayout()
            CType((Me.c1TrueDBGrid1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.c1SplitterPanel5.SuspendLayout()
            CType((Me.labelSales), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.c1ThemeController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.c1DashboardLayout1.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1DashboardLayout1.FlowLayoutControl.AutoScroll = True
            Me.c1DashboardLayout1.FlowLayoutControl.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.FlowLayoutControl.Controls.Add(Me.panel2)
            Me.c1DashboardLayout1.FlowLayoutControl.Controls.Add(Me.panel4)
            Me.c1DashboardLayout1.FlowLayoutControl.Controls.Add(Me.panel10)
            Me.c1DashboardLayout1.FlowLayoutControl.Controls.Add(Me.panel6)
            Me.c1DashboardLayout1.FlowLayoutControl.Controls.Add(Me.panel8)
            Me.c1DashboardLayout1.FlowLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1DashboardLayout1.FlowLayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.c1DashboardLayout1.FlowLayoutControl.Name = "FlowContentPanel"
            Me.c1DashboardLayout1.FlowLayoutControl.Size = New System.Drawing.Size(1016, 517)
            Me.c1DashboardLayout1.FlowLayoutControl.TabIndex = 0
            Me.c1DashboardLayout1.GridLayoutControl.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.GridLayoutControl.ColumnCount = 4
            Me.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.c1DashboardLayout1.GridLayoutControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.c1DashboardLayout1.GridLayoutControl.Controls.Add(Me.panel1, 0, 0)
            Me.c1DashboardLayout1.GridLayoutControl.Controls.Add(Me.panel3, 3, 0)
            Me.c1DashboardLayout1.GridLayoutControl.Controls.Add(Me.panel9, 3, 2)
            Me.c1DashboardLayout1.GridLayoutControl.Controls.Add(Me.panel5, 2, 1)
            Me.c1DashboardLayout1.GridLayoutControl.Controls.Add(Me.panel7, 1, 0)
            Me.c1DashboardLayout1.GridLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1DashboardLayout1.GridLayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.c1DashboardLayout1.GridLayoutControl.Name = "GridContentPanel"
            Me.c1DashboardLayout1.GridLayoutControl.RowCount = 3
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.c1DashboardLayout1.GridLayoutControl.Size = New System.Drawing.Size(1016, 517)
            Me.c1DashboardLayout1.GridLayoutControl.TabIndex = 0
            Me.c1DashboardLayout1.LayoutType = C1.Win.Layout.LayoutType.Split
            Me.c1DashboardLayout1.Location = New System.Drawing.Point(0, 155)
            Me.c1DashboardLayout1.Margin = New System.Windows.Forms.Padding(0)
            Me.c1DashboardLayout1.Name = "c1DashboardLayout1"
            Me.c1DashboardLayout1.Size = New System.Drawing.Size(1016, 517)
            Me.c1DashboardLayout1.SplitLayoutControl.AutoSizeElement = C1.Framework.AutoSizeElement.Both
            Me.c1DashboardLayout1.SplitLayoutControl.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.SplitLayoutControl.CollapsingAreaColor = System.Drawing.Color.FromArgb((CInt(((CByte((240)))))), (CInt(((CByte((245)))))), (CInt(((CByte((250)))))))
            Me.c1DashboardLayout1.SplitLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1DashboardLayout1.SplitLayoutControl.FixedLineColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((166)))))), (CInt(((CByte((194)))))))
            Me.c1DashboardLayout1.SplitLayoutControl.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((30)))))), (CInt(((CByte((57)))))), (CInt(((CByte((91)))))))
            Me.c1DashboardLayout1.SplitLayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.c1DashboardLayout1.SplitLayoutControl.Name = "SplitContentPanel"
            Me.c1DashboardLayout1.SplitLayoutControl.Panels.Add(Me.c1SplitterPanel1)
            Me.c1DashboardLayout1.SplitLayoutControl.Panels.Add(Me.c1SplitterPanel2)
            Me.c1DashboardLayout1.SplitLayoutControl.Panels.Add(Me.c1SplitterPanel3)
            Me.c1DashboardLayout1.SplitLayoutControl.Panels.Add(Me.c1SplitterPanel5)
            Me.c1DashboardLayout1.SplitLayoutControl.Size = New System.Drawing.Size(1016, 517)
            Me.c1DashboardLayout1.SplitLayoutControl.SplitterColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((166)))))), (CInt(((CByte((194)))))))
            Me.c1DashboardLayout1.SplitLayoutControl.TabIndex = 0
            Me.c1DashboardLayout1.SplitLayoutControl.ToolTipGradient = C1.Win.SplitContainer.ToolTipGradient.Blue
            Me.c1DashboardLayout1.SplitLayoutControl.UseParentVisualStyle = False
            Me.c1DashboardLayout1.TabIndex = 2
            Me.c1DashboardLayout1.Text = "c1DashboardLayout1"
            Me.c1ThemeController1.SetTheme(Me.c1DashboardLayout1, "(default)")
            Me.panel2.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.SetCaption(Me.panel2, "Sales")
            Me.c1DashboardLayout1.SetId(Me.panel2, "4f7a73f8-6e97-4b25-a74c-ba9b2bd0e6fa")
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Margin = New System.Windows.Forms.Padding(0)
            Me.panel2.Name = "panel2"
            Me.panel2.Padding = New System.Windows.Forms.Padding(10)
            Me.panel2.Size = New System.Drawing.Size(447, 272)
            Me.panel2.TabIndex = 0
            Me.c1ThemeController1.SetTheme(Me.panel2, "(default)")
            Me.panel4.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.SetCaption(Me.panel4, "Sales By Employee")
            Me.c1DashboardLayout1.SetId(Me.panel4, "096928d8-3c66-4891-91d5-ba2002e05142")
            Me.panel4.Location = New System.Drawing.Point(447, 0)
            Me.panel4.Margin = New System.Windows.Forms.Padding(0)
            Me.panel4.Name = "panel4"
            Me.panel4.Padding = New System.Windows.Forms.Padding(10)
            Me.panel4.Size = New System.Drawing.Size(333, 272)
            Me.panel4.TabIndex = 8
            Me.c1ThemeController1.SetTheme(Me.panel4, "(default)")
            Me.panel10.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.SetCaption(Me.panel10, "Customers")
            Me.c1DashboardLayout1.SetId(Me.panel10, "d3c1bda0-485f-487b-8542-b073f9015f7b")
            Me.panel10.Location = New System.Drawing.Point(780, 0)
            Me.panel10.Margin = New System.Windows.Forms.Padding(0)
            Me.panel10.Name = "panel10"
            Me.panel10.Padding = New System.Windows.Forms.Padding(10)
            Me.panel10.Size = New System.Drawing.Size(236, 272)
            Me.panel10.TabIndex = 11
            Me.c1ThemeController1.SetTheme(Me.panel10, "(default)")
            Me.panel6.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.SetCaption(Me.panel6, "Sales By Country")
            Me.c1DashboardLayout1.SetId(Me.panel6, "74047b16-f54c-47c2-8171-896bd7701fe1")
            Me.panel6.Location = New System.Drawing.Point(0, 272)
            Me.panel6.Margin = New System.Windows.Forms.Padding(0)
            Me.panel6.Name = "panel6"
            Me.panel6.Padding = New System.Windows.Forms.Padding(10)
            Me.panel6.Size = New System.Drawing.Size(447, 404)
            Me.panel6.TabIndex = 12
            Me.c1ThemeController1.SetTheme(Me.panel6, "(default)")
            Me.panel8.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.SetCaption(Me.panel8, "Total Sales")
            Me.c1DashboardLayout1.SetId(Me.panel8, "90db4822-a7cd-4d1a-b7f5-b20177de2e58")
            Me.panel8.Location = New System.Drawing.Point(447, 272)
            Me.panel8.Margin = New System.Windows.Forms.Padding(0)
            Me.panel8.Name = "panel8"
            Me.panel8.Padding = New System.Windows.Forms.Padding(10)
            Me.panel8.Size = New System.Drawing.Size(333, 176)
            Me.panel8.TabIndex = 9
            Me.c1ThemeController1.SetTheme(Me.panel8, "(default)")
            AddHandler Me.panel8.Resize, New System.EventHandler(AddressOf Me.panel8_Resize)
            Me.panel1.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.SetCaption(Me.panel1, "Sales")
            Me.c1DashboardLayout1.GridLayoutControl.SetColumnSpan(Me.panel1, 2)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1DashboardLayout1.SetId(Me.panel1, "4f7a73f8-6e97-4b25-a74c-ba9b2bd0e6fa")
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Margin = New System.Windows.Forms.Padding(0)
            Me.panel1.Name = "panel1"
            Me.panel1.Padding = New System.Windows.Forms.Padding(10)
            Me.c1DashboardLayout1.GridLayoutControl.SetRowSpan(Me.panel1, 3)
            Me.panel1.Size = New System.Drawing.Size(508, 517)
            Me.panel1.TabIndex = 0
            Me.c1ThemeController1.SetTheme(Me.panel1, "(default)")
            Me.panel3.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.SetCaption(Me.panel3, "Sales By Employee")
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1DashboardLayout1.SetId(Me.panel3, "096928d8-3c66-4891-91d5-ba2002e05142")
            Me.panel3.Location = New System.Drawing.Point(762, 0)
            Me.panel3.Margin = New System.Windows.Forms.Padding(0)
            Me.panel3.Name = "panel3"
            Me.panel3.Padding = New System.Windows.Forms.Padding(10)
            Me.c1DashboardLayout1.GridLayoutControl.SetRowSpan(Me.panel3, 2)
            Me.panel3.Size = New System.Drawing.Size(254, 309)
            Me.panel3.TabIndex = 1
            Me.c1ThemeController1.SetTheme(Me.panel3, "(default)")
            Me.panel9.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.SetCaption(Me.panel9, "Customers")
            Me.panel9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1DashboardLayout1.SetId(Me.panel9, "d3c1bda0-485f-487b-8542-b073f9015f7b")
            Me.panel9.Location = New System.Drawing.Point(762, 309)
            Me.panel9.Margin = New System.Windows.Forms.Padding(0)
            Me.panel9.Name = "panel9"
            Me.panel9.Padding = New System.Windows.Forms.Padding(10)
            Me.panel9.Size = New System.Drawing.Size(254, 208)
            Me.panel9.TabIndex = 4
            Me.c1ThemeController1.SetTheme(Me.panel9, "(default)")
            Me.panel5.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.SetCaption(Me.panel5, "Sales By Country")
            Me.panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1DashboardLayout1.SetId(Me.panel5, "74047b16-f54c-47c2-8171-896bd7701fe1")
            Me.panel5.Location = New System.Drawing.Point(508, 103)
            Me.panel5.Margin = New System.Windows.Forms.Padding(0)
            Me.panel5.Name = "panel5"
            Me.panel5.Padding = New System.Windows.Forms.Padding(10)
            Me.c1DashboardLayout1.GridLayoutControl.SetRowSpan(Me.panel5, 2)
            Me.panel5.Size = New System.Drawing.Size(254, 414)
            Me.panel5.TabIndex = 2
            Me.c1ThemeController1.SetTheme(Me.panel5, "(default)")
            Me.panel7.BackColor = System.Drawing.SystemColors.Control
            Me.c1DashboardLayout1.SetCaption(Me.panel7, "Total Sales")
            Me.panel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1DashboardLayout1.SetId(Me.panel7, "90db4822-a7cd-4d1a-b7f5-b20177de2e58")
            Me.panel7.Location = New System.Drawing.Point(508, 0)
            Me.panel7.Margin = New System.Windows.Forms.Padding(0)
            Me.panel7.Name = "panel7"
            Me.panel7.Padding = New System.Windows.Forms.Padding(10)
            Me.panel7.Size = New System.Drawing.Size(254, 103)
            Me.panel7.TabIndex = 5
            Me.c1ThemeController1.SetTheme(Me.panel7, "(default)")
            AddHandler Me.panel7.Resize, New System.EventHandler(AddressOf Me.panel7_Resize)
            Me.c1DashboardLayout1.SetCaption(Me.c1SplitterPanel1, "")
            Me.c1SplitterPanel1.Controls.Add(Me.c1SplitContainer1)
            Me.c1SplitterPanel1.Dock = C1.Win.SplitContainer.PanelDockStyle.Left
            Me.c1DashboardLayout1.SetId(Me.c1SplitterPanel1, "d01255ea-1089-4fb2-bec2-cfb3e5874880")
            Me.c1SplitterPanel1.Location = New System.Drawing.Point(0, 0)
            Me.c1SplitterPanel1.Name = "c1SplitterPanel1"
            Me.c1SplitterPanel1.Padding = New System.Windows.Forms.Padding(10)
            Me.c1SplitterPanel1.Size = New System.Drawing.Size(506, 517)
            Me.c1SplitterPanel1.TabIndex = 0
            Me.c1SplitterPanel1.Width = 506
            Me.c1SplitContainer1.AutoSizeElement = C1.Framework.AutoSizeElement.Both
            Me.c1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb((CInt(((CByte((240)))))), (CInt(((CByte((245)))))), (CInt(((CByte((250)))))))
            Me.c1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((166)))))), (CInt(((CByte((194)))))))
            Me.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((30)))))), (CInt(((CByte((57)))))), (CInt(((CByte((91)))))))
            Me.c1SplitContainer1.Location = New System.Drawing.Point(10, 10)
            Me.c1SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
            Me.c1SplitContainer1.Name = "c1SplitContainer1"
            Me.c1SplitContainer1.Panels.Add(Me.splitpanelSales)
            Me.c1SplitContainer1.Panels.Add(Me.c1SplitterPanel4)
            Me.c1SplitContainer1.Size = New System.Drawing.Size(486, 497)
            Me.c1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((166)))))), (CInt(((CByte((194)))))))
            Me.c1SplitContainer1.TabIndex = 0
            Me.c1SplitContainer1.ToolTipGradient = C1.Win.SplitContainer.ToolTipGradient.Blue
            Me.c1SplitContainer1.UseParentVisualStyle = False
            Me.c1DashboardLayout1.SetCaption(Me.splitpanelSales, "Sales")
            Me.splitpanelSales.Controls.Add(Me.c1FlexGrid1)
            Me.splitpanelSales.Height = 246
            Me.c1DashboardLayout1.SetId(Me.splitpanelSales, "4f7a73f8-6e97-4b25-a74c-ba9b2bd0e6fa")
            Me.splitpanelSales.Location = New System.Drawing.Point(0, 21)
            Me.splitpanelSales.Name = "splitpanelSales"
            Me.splitpanelSales.Padding = New System.Windows.Forms.Padding(10)
            Me.splitpanelSales.Size = New System.Drawing.Size(486, 225)
            Me.splitpanelSales.TabIndex = 2
            Me.c1FlexGrid1.AllowEditing = False
            Me.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:"
            Me.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1FlexGrid1.Location = New System.Drawing.Point(10, 10)
            Me.c1FlexGrid1.Name = "c1FlexGrid1"
            Me.c1FlexGrid1.Rows.DefaultSize = 19
            Me.c1FlexGrid1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None
            Me.c1FlexGrid1.Size = New System.Drawing.Size(466, 205)
            Me.c1FlexGrid1.TabIndex = 0
            Me.c1ThemeController1.SetTheme(Me.c1FlexGrid1, "(default)")
            Me.c1DashboardLayout1.SetCaption(Me.c1SplitterPanel4, "Sales By Country")
            Me.c1SplitterPanel4.Controls.Add(Me.flexChart1)
            Me.c1SplitterPanel4.Height = 247
            Me.c1DashboardLayout1.SetId(Me.c1SplitterPanel4, "74047b16-f54c-47c2-8171-896bd7701fe1")
            Me.c1SplitterPanel4.Location = New System.Drawing.Point(0, 271)
            Me.c1SplitterPanel4.Name = "c1SplitterPanel4"
            Me.c1SplitterPanel4.Padding = New System.Windows.Forms.Padding(10)
            Me.c1SplitterPanel4.Size = New System.Drawing.Size(486, 226)
            Me.c1SplitterPanel4.TabIndex = 3
            Me.flexChart1.AxisX.Chart = Me.flexChart1
            Me.flexChart1.AxisX.DataSource = Nothing
            Me.flexChart1.AxisX.GroupProvider = Nothing
            Me.flexChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None
            Me.flexChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center
            Me.flexChart1.AxisX.PlotAreaName = Nothing
            Me.flexChart1.AxisX.Position = C1.Chart.Position.Bottom
            Me.flexChart1.AxisY.AxisLine = False
            Me.flexChart1.AxisY.Chart = Me.flexChart1
            Me.flexChart1.AxisY.DataSource = Nothing
            Me.flexChart1.AxisY.GroupProvider = Nothing
            Me.flexChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None
            Me.flexChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center
            Me.flexChart1.AxisY.MajorGrid = True
            Me.flexChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None
            Me.flexChart1.AxisY.PlotAreaName = Nothing
            Me.flexChart1.AxisY.Position = C1.Chart.Position.Left
            Me.flexChart1.ChartType = C1.Chart.ChartType.Bar
            Me.flexChart1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.flexChart1.Legend.ItemMaxWidth = 0
            Me.flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto
            Me.flexChart1.Legend.Position = C1.Chart.Position.None
            Me.flexChart1.Legend.Reversed = False
            Me.flexChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None
            Me.flexChart1.Legend.Title = Nothing
            Me.flexChart1.Location = New System.Drawing.Point(10, 10)
            Me.flexChart1.Margin = New System.Windows.Forms.Padding(10)
            Me.flexChart1.Name = "flexChart1"
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage
            elementSize1.Value = 70.0R
            Me.flexChart1.Options.ClusterSize = elementSize1
            Me.flexChart1.PlotMargin = New System.Windows.Forms.Padding(0)
            Me.flexChart1.SelectedSeries = Nothing
            Me.flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red
            series1.DataLabel = Nothing
            series1.Name = "Series 1"
            series1.StackingGroup = -1
            series1.Style.StrokeWidth = 2.0F
            Me.flexChart1.Series.Add(series1)
            Me.flexChart1.Size = New System.Drawing.Size(466, 206)
            Me.flexChart1.TabIndex = 0
            Me.flexChart1.Text = "flexChart1"
            Me.flexChart1.ToolTip.Content = "{value}"
            Me.c1DashboardLayout1.SetCaption(Me.c1SplitterPanel2, "Sales By Employee")
            Me.c1SplitterPanel2.Controls.Add(Me.flexPie1)
            Me.c1SplitterPanel2.Height = 256
            Me.c1DashboardLayout1.SetId(Me.c1SplitterPanel2, "096928d8-3c66-4891-91d5-ba2002e05142")
            Me.c1SplitterPanel2.Location = New System.Drawing.Point(510, 21)
            Me.c1SplitterPanel2.Name = "c1SplitterPanel2"
            Me.c1SplitterPanel2.Padding = New System.Windows.Forms.Padding(10)
            Me.c1SplitterPanel2.Size = New System.Drawing.Size(506, 235)
            Me.c1SplitterPanel2.TabIndex = 1
            flexPieSlice1.Name = "Slice1"
            flexPieSlice1.Value = 1.0R
            flexPieSlice2.Name = "Slice2"
            flexPieSlice2.Value = 2.0R
            flexPieSlice3.Name = "Slice3"
            flexPieSlice3.Value = 3.0R
            flexPieSlice4.Name = "Slice4"
            flexPieSlice4.Value = 4.0R
            Me.flexPie1.DataSource = New C1.Win.Chart.FlexPieSlice() {flexPieSlice1, flexPieSlice2, flexPieSlice3, flexPieSlice4}
            Me.flexPie1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.flexPie1.Legend.ItemMaxWidth = 0
            Me.flexPie1.Legend.Orientation = C1.Chart.Orientation.Auto
            Me.flexPie1.Legend.Position = C1.Chart.Position.Right
            Me.flexPie1.Legend.Reversed = False
            Me.flexPie1.Legend.TextWrapping = C1.Chart.TextWrapping.None
            Me.flexPie1.Legend.Title = Nothing
            Me.flexPie1.Location = New System.Drawing.Point(10, 10)
            Me.flexPie1.Name = "flexPie1"
            Me.flexPie1.SelectionStyle.StrokeColor = System.Drawing.Color.Red
            Me.flexPie1.Size = New System.Drawing.Size(486, 215)
            Me.flexPie1.TabIndex = 0
            Me.flexPie1.Text = "flexPie1"
            Me.flexPie1.ToolTip.Content = "{value}"
            Me.c1DashboardLayout1.SetCaption(Me.c1SplitterPanel3, "Customers")
            Me.c1SplitterPanel3.Controls.Add(Me.c1TrueDBGrid1)
            Me.c1SplitterPanel3.Dock = C1.Win.SplitContainer.PanelDockStyle.Left
            Me.c1SplitterPanel3.Height = 257
            Me.c1DashboardLayout1.SetId(Me.c1SplitterPanel3, "d3c1bda0-485f-487b-8542-b073f9015f7b")
            Me.c1SplitterPanel3.Location = New System.Drawing.Point(510, 281)
            Me.c1SplitterPanel3.Name = "c1SplitterPanel3"
            Me.c1SplitterPanel3.Padding = New System.Windows.Forms.Padding(10)
            Me.c1SplitterPanel3.Size = New System.Drawing.Size(251, 236)
            Me.c1SplitterPanel3.TabIndex = 2
            Me.c1SplitterPanel3.Width = 251
            Me.c1TrueDBGrid1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((240)))))), (CInt(((CByte((240)))))), (CInt(((CByte((240)))))))
            Me.c1TrueDBGrid1.DataView = C1.Win.TrueDBGrid.DataViewEnum.Form
            Me.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1TrueDBGrid1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
            Me.c1TrueDBGrid1.Images.Add((CType((resources.GetObject("c1TrueDBGrid1.Images")), System.Drawing.Image)))
            Me.c1TrueDBGrid1.Location = New System.Drawing.Point(10, 10)
            Me.c1TrueDBGrid1.Name = "c1TrueDBGrid1"
            Me.c1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
            Me.c1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
            Me.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
            Me.c1TrueDBGrid1.PrintInfo.PageSettings = (CType((resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")), System.Drawing.Printing.PageSettings))
            Me.c1TrueDBGrid1.Size = New System.Drawing.Size(231, 216)
            Me.c1TrueDBGrid1.TabIndex = 0
            Me.c1ThemeController1.SetTheme(Me.c1TrueDBGrid1, "(default)")
            Me.c1TrueDBGrid1.UseCompatibleTextRendering = False
            Me.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag")
            Me.c1DashboardLayout1.SetCaption(Me.c1SplitterPanel5, "Total Sales")
            Me.c1SplitterPanel5.Controls.Add(Me.labelSales)
            Me.c1SplitterPanel5.Dock = C1.Win.SplitContainer.PanelDockStyle.Right
            Me.c1SplitterPanel5.Height = 257
            Me.c1DashboardLayout1.SetId(Me.c1SplitterPanel5, "90db4822-a7cd-4d1a-b7f5-b20177de2e58")
            Me.c1SplitterPanel5.Location = New System.Drawing.Point(765, 281)
            Me.c1SplitterPanel5.Name = "c1SplitterPanel5"
            Me.c1SplitterPanel5.Padding = New System.Windows.Forms.Padding(10)
            Me.c1SplitterPanel5.Size = New System.Drawing.Size(251, 236)
            Me.c1SplitterPanel5.TabIndex = 4
            Me.c1SplitterPanel5.Width = 251
            AddHandler Me.c1SplitterPanel5.Resize, New System.EventHandler(AddressOf Me.c1SplitterPanel5_Resize)
            Me.labelSales.AutoSize = True
            Me.labelSales.BackColor = System.Drawing.Color.Transparent
            Me.labelSales.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.labelSales.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.labelSales.ForeColor = System.Drawing.Color.Black
            Me.labelSales.Location = New System.Drawing.Point(60, 44)
            Me.labelSales.Name = "labelSales"
            Me.labelSales.Size = New System.Drawing.Size(137, 37)
            Me.labelSales.TabIndex = 0
            Me.labelSales.Tag = Nothing
            Me.labelSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.c1ThemeController1.SetTheme(Me.labelSales, "(default)")
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1016, 672)
            Me.Controls.Add(Me.c1DashboardLayout1)
            Me.Name = "MainForm"
            Me.Text = "MainForm"
            Me.c1ThemeController1.SetTheme(Me, "(default)")
            AddHandler Me.DemoThemeChanged, New System.EventHandler(Of C1.Win.Themes.ThemeEventArgs)(AddressOf Me.MainForm_DemoThemeChanged)
            AddHandler Me.ToolIconAppearanceChanged, New System.EventHandler(Of DashboardDemo.Controls.ToolIconAppearanceEventArgs)(AddressOf Me.MainForm_ToolIconAppearanceChanged)
            AddHandler Me.ApplyLayoutClicked, New System.EventHandler(Of DashboardDemo.Controls.FilePathEventArgs)(AddressOf Me.MainForm_ApplyLayoutClicked)
            AddHandler Me.SaveLayoutClicked, New System.EventHandler(Of DashboardDemo.Controls.FilePathEventArgs)(AddressOf Me.MainForm_SaveLayoutClicked)
            AddHandler Me.ResetLayoutClicked, New System.EventHandler(Of DashboardDemo.Controls.FilePathEventArgs)(AddressOf Me.MainForm_ResetLayoutClicked)
            AddHandler Me.LayoutTypeChanged, New System.EventHandler(Of DashboardDemo.Controls.LayoutTypeEventArgs)(AddressOf Me.MainForm_LayoutTypeChanged)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.MainForm_Load)
            Me.Controls.SetChildIndex(Me.c1DashboardLayout1, 0)
            Me.c1DashboardLayout1.FlowLayoutControl.ResumeLayout(False)
            Me.c1DashboardLayout1.GridLayoutControl.ResumeLayout(False)
            CType((Me.c1DashboardLayout1.SplitLayoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.c1DashboardLayout1.SplitLayoutControl.ResumeLayout(False)
            CType((Me.c1DashboardLayout1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.c1DashboardLayout1.ResumeLayout(False)
            Me.c1SplitterPanel1.ResumeLayout(False)
            CType((Me.c1SplitContainer1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.c1SplitContainer1.ResumeLayout(False)
            Me.splitpanelSales.ResumeLayout(False)
            CType((Me.c1FlexGrid1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.c1SplitterPanel4.ResumeLayout(False)
            CType((Me.flexChart1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.c1SplitterPanel2.ResumeLayout(False)
            Me.c1SplitterPanel3.ResumeLayout(False)
            CType((Me.c1TrueDBGrid1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.c1SplitterPanel5.ResumeLayout(False)
            Me.c1SplitterPanel5.PerformLayout()
            CType((Me.labelSales), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.c1ThemeController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private c1DashboardLayout1 As C1.Win.Layout.C1DashboardLayout
        Private c1SplitContainer1 As C1.Win.SplitContainer.C1SplitContainer
        Private splitpanelSales As C1.Win.SplitContainer.C1SplitterPanel
        Private c1FlexGrid1 As Controls.DemoFlexGrid
        Private flexPie1 As Controls.DemoFlexPie
        Private flexChart1 As Controls.DemoFlexChart
        Private labelSales As Controls.DemoLabel
        Private c1TrueDBGrid1 As Controls.DemoTrueDBGrid
        Private c1ThemeController1 As C1.Win.Themes.C1ThemeController
        Private panel2 As System.Windows.Forms.Panel
        Private panel1 As System.Windows.Forms.Panel
        Private panel3 As System.Windows.Forms.Panel
        Private panel5 As System.Windows.Forms.Panel
        Private panel9 As System.Windows.Forms.Panel
        Private panel4 As System.Windows.Forms.Panel
        Private panel8 As System.Windows.Forms.Panel
        Private panel10 As System.Windows.Forms.Panel
        Private panel6 As System.Windows.Forms.Panel
        Private panel7 As System.Windows.Forms.Panel
        Private c1SplitterPanel1 As C1.Win.SplitContainer.C1SplitterPanel
        Private c1SplitterPanel2 As C1.Win.SplitContainer.C1SplitterPanel
        Private c1SplitterPanel3 As C1.Win.SplitContainer.C1SplitterPanel
        Private c1SplitterPanel4 As C1.Win.SplitContainer.C1SplitterPanel
        Private c1SplitterPanel5 As C1.Win.SplitContainer.C1SplitterPanel
    End Class
End Namespace
