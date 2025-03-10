<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim C1TreeColumn2 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.c1TreeView1 = New C1.Win.TreeView.C1TreeView()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.c1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.c1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.label4 = New System.Windows.Forms.Label()
        Me.nudLevelsCount = New System.Windows.Forms.NumericUpDown()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.nudRootNodesCount = New System.Windows.Forms.NumericUpDown()
        Me.nudNodesCount = New System.Windows.Forms.NumericUpDown()
        Me.nudColumnsCount = New System.Windows.Forms.NumericUpDown()
        Me.btnClearTree = New C1.Win.C1Input.C1Button()
        Me.btnGenereteTree = New C1.Win.C1Input.C1Button()
        Me.c1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.pgColumn = New System.Windows.Forms.PropertyGrid()
        Me.cmbSelectedColumn = New C1.Win.C1Input.C1ComboBox()
        Me.c1Label1 = New C1.Win.C1Input.C1Label()
        Me.btnAddNewColumn = New C1.Win.C1Input.C1Button()
        Me.btnRemoveColumn = New C1.Win.C1Input.C1Button()
        Me.c1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.pgNode = New System.Windows.Forms.PropertyGrid()
        Me.btnRemoveSelectedNodes = New C1.Win.C1Input.C1Button()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.c1TreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.c1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1DockingTab1.SuspendLayout()
        Me.c1DockingTabPage1.SuspendLayout()
        CType(Me.nudLevelsCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRootNodesCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNodesCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudColumnsCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClearTree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGenereteTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1DockingTabPage2.SuspendLayout()
        CType(Me.cmbSelectedColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddNewColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRemoveColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1DockingTabPage3.SuspendLayout()
        CType(Me.btnRemoveSelectedNodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1ThemeController1
        '
        Me.C1ThemeController1.Theme = "Office365White"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panel2.Controls.Add(Me.c1TreeView1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(557, 935)
        Me.panel2.TabIndex = 2
        Me.C1ThemeController1.SetTheme(Me.panel2, "(default)")
        '
        'c1TreeView1
        '
        Me.c1TreeView1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.c1TreeView1.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.c1TreeView1.ButtonImageList.ImageSize = New System.Drawing.Size(16, 16)
        '
        '
        '
        Me.c1TreeView1.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.c1TreeView1.CheckImageList.ImageSize = New System.Drawing.Size(16, 16)
        C1TreeColumn2.HeaderText = "Column1"
        C1TreeColumn2.Name = "Column1"
        Me.c1TreeView1.Columns.Add(C1TreeColumn2)
        Me.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.c1TreeView1.Name = "c1TreeView1"
        Me.c1TreeView1.Size = New System.Drawing.Size(557, 935)
        Me.c1TreeView1.TabIndex = 0
        Me.C1ThemeController1.SetTheme(Me.c1TreeView1, "(default)")
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panel1.Controls.Add(Me.c1DockingTab1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(574, 935)
        Me.panel1.TabIndex = 1
        Me.C1ThemeController1.SetTheme(Me.panel1, "(default)")
        '
        'c1DockingTab1
        '
        Me.c1DockingTab1.BackColor = System.Drawing.Color.White
        Me.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1DockingTab1.Controls.Add(Me.c1DockingTabPage1)
        Me.c1DockingTab1.Controls.Add(Me.c1DockingTabPage2)
        Me.c1DockingTab1.Controls.Add(Me.c1DockingTabPage3)
        Me.c1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1DockingTab1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.c1DockingTab1.HotTrack = True
        Me.c1DockingTab1.Location = New System.Drawing.Point(0, 0)
        Me.c1DockingTab1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.c1DockingTab1.Name = "c1DockingTab1"
        Me.c1DockingTab1.SelectedIndex = 2
        Me.c1DockingTab1.Size = New System.Drawing.Size(574, 935)
        Me.c1DockingTab1.TabIndex = 1
        Me.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        Me.c1DockingTab1.TabsShowFocusCues = False
        Me.c1DockingTab1.TabsSpacing = 2
        Me.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007
        Me.C1ThemeController1.SetTheme(Me.c1DockingTab1, "(default)")
        '
        'c1DockingTabPage1
        '
        Me.c1DockingTabPage1.CaptionText = "TreeView"
        Me.c1DockingTabPage1.Controls.Add(Me.propertyGrid1)
        Me.c1DockingTabPage1.Controls.Add(Me.label4)
        Me.c1DockingTabPage1.Controls.Add(Me.nudLevelsCount)
        Me.c1DockingTabPage1.Controls.Add(Me.label3)
        Me.c1DockingTabPage1.Controls.Add(Me.label2)
        Me.c1DockingTabPage1.Controls.Add(Me.label1)
        Me.c1DockingTabPage1.Controls.Add(Me.nudRootNodesCount)
        Me.c1DockingTabPage1.Controls.Add(Me.nudNodesCount)
        Me.c1DockingTabPage1.Controls.Add(Me.nudColumnsCount)
        Me.c1DockingTabPage1.Controls.Add(Me.btnClearTree)
        Me.c1DockingTabPage1.Controls.Add(Me.btnGenereteTree)
        Me.c1DockingTabPage1.Location = New System.Drawing.Point(5, 37)
        Me.c1DockingTabPage1.Name = "c1DockingTabPage1"
        Me.c1DockingTabPage1.Size = New System.Drawing.Size(564, 893)
        Me.c1DockingTabPage1.TabIndex = 0
        Me.c1DockingTabPage1.Text = "Edit TreeView"
        '
        'propertyGrid1
        '
        Me.propertyGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.propertyGrid1.CategoryForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.propertyGrid1.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.propertyGrid1.CommandsForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.propertyGrid1.CommandsLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.propertyGrid1.DisabledItemForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.propertyGrid1.HelpBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.propertyGrid1.HelpForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.propertyGrid1.LineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.propertyGrid1.Location = New System.Drawing.Point(0, 342)
        Me.propertyGrid1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.SelectedObject = Me.c1TreeView1
        Me.propertyGrid1.Size = New System.Drawing.Size(555, 512)
        Me.propertyGrid1.TabIndex = 18
        Me.C1ThemeController1.SetTheme(Me.propertyGrid1, "(default)")
        Me.propertyGrid1.ViewBackColor = System.Drawing.Color.White
        Me.propertyGrid1.ViewForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(95, 185)
        Me.label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(116, 21)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Count of levels:"
        Me.C1ThemeController1.SetTheme(Me.label4, "(default)")
        '
        'nudLevelsCount
        '
        Me.nudLevelsCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.nudLevelsCount.Location = New System.Drawing.Point(253, 181)
        Me.nudLevelsCount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.nudLevelsCount.Name = "nudLevelsCount"
        Me.nudLevelsCount.Size = New System.Drawing.Size(148, 29)
        Me.nudLevelsCount.TabIndex = 16
        Me.C1ThemeController1.SetTheme(Me.nudLevelsCount, "(default)")
        Me.nudLevelsCount.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(88, 135)
        Me.label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(122, 21)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Count of Nodes:"
        Me.C1ThemeController1.SetTheme(Me.label3, "(default)")
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(46, 85)
        Me.label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(155, 21)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Count of RootNodes:"
        Me.C1ThemeController1.SetTheme(Me.label2, "(default)")
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(73, 35)
        Me.label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(136, 21)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Count of columns:"
        Me.C1ThemeController1.SetTheme(Me.label1, "(default)")
        '
        'nudRootNodesCount
        '
        Me.nudRootNodesCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.nudRootNodesCount.Location = New System.Drawing.Point(253, 81)
        Me.nudRootNodesCount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.nudRootNodesCount.Name = "nudRootNodesCount"
        Me.nudRootNodesCount.Size = New System.Drawing.Size(148, 29)
        Me.nudRootNodesCount.TabIndex = 12
        Me.C1ThemeController1.SetTheme(Me.nudRootNodesCount, "(default)")
        Me.nudRootNodesCount.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'nudNodesCount
        '
        Me.nudNodesCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.nudNodesCount.Location = New System.Drawing.Point(253, 131)
        Me.nudNodesCount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.nudNodesCount.Name = "nudNodesCount"
        Me.nudNodesCount.Size = New System.Drawing.Size(148, 29)
        Me.nudNodesCount.TabIndex = 11
        Me.C1ThemeController1.SetTheme(Me.nudNodesCount, "(default)")
        Me.nudNodesCount.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'nudColumnsCount
        '
        Me.nudColumnsCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.nudColumnsCount.Location = New System.Drawing.Point(253, 31)
        Me.nudColumnsCount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.nudColumnsCount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudColumnsCount.Name = "nudColumnsCount"
        Me.nudColumnsCount.Size = New System.Drawing.Size(148, 29)
        Me.nudColumnsCount.TabIndex = 10
        Me.C1ThemeController1.SetTheme(Me.nudColumnsCount, "(default)")
        Me.nudColumnsCount.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'btnClearTree
        '
        Me.btnClearTree.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnClearTree.Location = New System.Drawing.Point(310, 244)
        Me.btnClearTree.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnClearTree.Name = "btnClearTree"
        Me.btnClearTree.Size = New System.Drawing.Size(222, 67)
        Me.btnClearTree.TabIndex = 4
        Me.btnClearTree.Text = "Clear Tree"
        Me.C1ThemeController1.SetTheme(Me.btnClearTree, "(default)")
        Me.btnClearTree.UseVisualStyleBackColor = True
        Me.btnClearTree.UseVisualStyleForeColor = True
        Me.btnClearTree.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'btnGenereteTree
        '
        Me.btnGenereteTree.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnGenereteTree.Location = New System.Drawing.Point(51, 244)
        Me.btnGenereteTree.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnGenereteTree.Name = "btnGenereteTree"
        Me.btnGenereteTree.Size = New System.Drawing.Size(229, 67)
        Me.btnGenereteTree.TabIndex = 3
        Me.btnGenereteTree.Text = "Generate Tree"
        Me.C1ThemeController1.SetTheme(Me.btnGenereteTree, "(default)")
        Me.btnGenereteTree.UseVisualStyleBackColor = True
        Me.btnGenereteTree.UseVisualStyleForeColor = True
        Me.btnGenereteTree.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1DockingTabPage2
        '
        Me.c1DockingTabPage2.Controls.Add(Me.pgColumn)
        Me.c1DockingTabPage2.Controls.Add(Me.cmbSelectedColumn)
        Me.c1DockingTabPage2.Controls.Add(Me.c1Label1)
        Me.c1DockingTabPage2.Controls.Add(Me.btnAddNewColumn)
        Me.c1DockingTabPage2.Controls.Add(Me.btnRemoveColumn)
        Me.c1DockingTabPage2.Location = New System.Drawing.Point(5, 37)
        Me.c1DockingTabPage2.Name = "c1DockingTabPage2"
        Me.c1DockingTabPage2.Size = New System.Drawing.Size(564, 893)
        Me.c1DockingTabPage2.TabIndex = 1
        Me.c1DockingTabPage2.Text = "Columns"
        '
        'pgColumn
        '
        Me.pgColumn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgColumn.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pgColumn.CategoryForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pgColumn.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pgColumn.CommandsBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pgColumn.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pgColumn.CommandsForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pgColumn.CommandsLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.pgColumn.DisabledItemForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pgColumn.HelpBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pgColumn.HelpForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pgColumn.LineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pgColumn.Location = New System.Drawing.Point(24, 190)
        Me.pgColumn.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pgColumn.Name = "pgColumn"
        Me.pgColumn.Size = New System.Drawing.Size(509, 642)
        Me.pgColumn.TabIndex = 4
        Me.C1ThemeController1.SetTheme(Me.pgColumn, "(default)")
        Me.pgColumn.ViewBackColor = System.Drawing.Color.White
        Me.pgColumn.ViewForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        '
        'cmbSelectedColumn
        '
        Me.cmbSelectedColumn.AllowSpinLoop = False
        Me.cmbSelectedColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmbSelectedColumn.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmbSelectedColumn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmbSelectedColumn.GapHeight = 0
        Me.cmbSelectedColumn.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.cmbSelectedColumn.Location = New System.Drawing.Point(275, 144)
        Me.cmbSelectedColumn.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmbSelectedColumn.Name = "cmbSelectedColumn"
        Me.cmbSelectedColumn.Size = New System.Drawing.Size(249, 29)
        Me.cmbSelectedColumn.Style.DropDownCorners = New C1.Framework.Corners(0, 0, 4, 4)
        Me.cmbSelectedColumn.Style.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmbSelectedColumn.Style.SelectionView = C1.Win.C1Input.SelectionView.LeftBorderLine
        Me.cmbSelectedColumn.TabIndex = 3
        Me.cmbSelectedColumn.Tag = Nothing
        Me.cmbSelectedColumn.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.cmbSelectedColumn, "(default)")
        Me.cmbSelectedColumn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1Label1
        '
        Me.c1Label1.AutoSize = True
        Me.c1Label1.BackColor = System.Drawing.Color.Transparent
        Me.c1Label1.BorderColor = System.Drawing.Color.Transparent
        Me.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.c1Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.c1Label1.Location = New System.Drawing.Point(116, 148)
        Me.c1Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.c1Label1.Name = "c1Label1"
        Me.c1Label1.Padding = New System.Windows.Forms.Padding(2)
        Me.c1Label1.Size = New System.Drawing.Size(130, 29)
        Me.c1Label1.TabIndex = 2
        Me.c1Label1.Tag = Nothing
        Me.c1Label1.Text = "Current column:"
        Me.c1Label1.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.c1Label1, "(default)")
        Me.c1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom
        '
        'btnAddNewColumn
        '
        Me.btnAddNewColumn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAddNewColumn.Location = New System.Drawing.Point(24, 37)
        Me.btnAddNewColumn.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnAddNewColumn.Name = "btnAddNewColumn"
        Me.btnAddNewColumn.Size = New System.Drawing.Size(211, 88)
        Me.btnAddNewColumn.TabIndex = 1
        Me.btnAddNewColumn.Text = "Add column"
        Me.C1ThemeController1.SetTheme(Me.btnAddNewColumn, "(default)")
        Me.btnAddNewColumn.UseVisualStyleBackColor = True
        Me.btnAddNewColumn.UseVisualStyleForeColor = True
        Me.btnAddNewColumn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'btnRemoveColumn
        '
        Me.btnRemoveColumn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnRemoveColumn.Location = New System.Drawing.Point(275, 37)
        Me.btnRemoveColumn.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnRemoveColumn.Name = "btnRemoveColumn"
        Me.btnRemoveColumn.Size = New System.Drawing.Size(211, 88)
        Me.btnRemoveColumn.TabIndex = 0
        Me.btnRemoveColumn.Text = "Remove column"
        Me.C1ThemeController1.SetTheme(Me.btnRemoveColumn, "(default)")
        Me.btnRemoveColumn.UseVisualStyleBackColor = True
        Me.btnRemoveColumn.UseVisualStyleForeColor = True
        Me.btnRemoveColumn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1DockingTabPage3
        '
        Me.c1DockingTabPage3.Controls.Add(Me.pgNode)
        Me.c1DockingTabPage3.Controls.Add(Me.btnRemoveSelectedNodes)
        Me.c1DockingTabPage3.Location = New System.Drawing.Point(5, 37)
        Me.c1DockingTabPage3.Name = "c1DockingTabPage3"
        Me.c1DockingTabPage3.Size = New System.Drawing.Size(564, 893)
        Me.c1DockingTabPage3.TabIndex = 2
        Me.c1DockingTabPage3.Text = "Nodes"
        '
        'pgNode
        '
        Me.pgNode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgNode.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pgNode.CategoryForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pgNode.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pgNode.CommandsBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pgNode.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pgNode.CommandsForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pgNode.CommandsLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.pgNode.DisabledItemForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pgNode.HelpBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pgNode.HelpForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pgNode.LineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pgNode.Location = New System.Drawing.Point(0, 158)
        Me.pgNode.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pgNode.Name = "pgNode"
        Me.pgNode.Size = New System.Drawing.Size(555, 696)
        Me.pgNode.TabIndex = 0
        Me.C1ThemeController1.SetTheme(Me.pgNode, "(default)")
        Me.pgNode.ViewBackColor = System.Drawing.Color.White
        Me.pgNode.ViewForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        '
        'btnRemoveSelectedNodes
        '
        Me.btnRemoveSelectedNodes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnRemoveSelectedNodes.Location = New System.Drawing.Point(122, 38)
        Me.btnRemoveSelectedNodes.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnRemoveSelectedNodes.Name = "btnRemoveSelectedNodes"
        Me.btnRemoveSelectedNodes.Size = New System.Drawing.Size(328, 90)
        Me.btnRemoveSelectedNodes.TabIndex = 1
        Me.btnRemoveSelectedNodes.Text = "Remove selected nodes"
        Me.C1ThemeController1.SetTheme(Me.btnRemoveSelectedNodes, "(default)")
        Me.btnRemoveSelectedNodes.UseVisualStyleBackColor = True
        Me.btnRemoveSelectedNodes.UseVisualStyleForeColor = True
        Me.btnRemoveSelectedNodes.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'splitContainer1
        '
        Me.splitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.panel2)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.panel1)
        Me.splitContainer1.Size = New System.Drawing.Size(1138, 935)
        Me.splitContainer1.SplitterDistance = 557
        Me.splitContainer1.SplitterWidth = 7
        Me.splitContainer1.TabIndex = 2
        Me.C1ThemeController1.SetTheme(Me.splitContainer1, "(default)")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 935)
        Me.Controls.Add(Me.splitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "UnboundMode"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.c1TreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me.c1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1DockingTab1.ResumeLayout(False)
        Me.c1DockingTabPage1.ResumeLayout(False)
        Me.c1DockingTabPage1.PerformLayout()
        CType(Me.nudLevelsCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRootNodesCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNodesCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudColumnsCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClearTree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGenereteTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1DockingTabPage2.ResumeLayout(False)
        Me.c1DockingTabPage2.PerformLayout()
        CType(Me.cmbSelectedColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddNewColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRemoveColumn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1DockingTabPage3.ResumeLayout(False)
        CType(Me.btnRemoveSelectedNodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Private WithEvents splitContainer1 As SplitContainer
    Private WithEvents panel2 As Panel
    Private WithEvents c1TreeView1 As C1.Win.TreeView.C1TreeView
    Private WithEvents panel1 As Panel
    Private WithEvents c1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Private WithEvents c1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Private WithEvents propertyGrid1 As PropertyGrid
    Private WithEvents label4 As Label
    Private WithEvents nudLevelsCount As NumericUpDown
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents nudRootNodesCount As NumericUpDown
    Private WithEvents nudNodesCount As NumericUpDown
    Private WithEvents nudColumnsCount As NumericUpDown
    Private WithEvents btnClearTree As C1.Win.C1Input.C1Button
    Private WithEvents btnGenereteTree As C1.Win.C1Input.C1Button
    Private WithEvents c1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Private WithEvents pgColumn As PropertyGrid
    Private WithEvents cmbSelectedColumn As C1.Win.C1Input.C1ComboBox
    Private WithEvents c1Label1 As C1.Win.C1Input.C1Label
    Private WithEvents btnAddNewColumn As C1.Win.C1Input.C1Button
    Private WithEvents btnRemoveColumn As C1.Win.C1Input.C1Button
    Private WithEvents c1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Private WithEvents pgNode As PropertyGrid
    Private WithEvents btnRemoveSelectedNodes As C1.Win.C1Input.C1Button
End Class
