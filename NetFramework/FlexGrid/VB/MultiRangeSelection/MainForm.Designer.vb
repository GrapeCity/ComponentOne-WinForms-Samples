Imports C1.Win.Ribbon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits C1RibbonForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.c1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        Me.ribbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.ribbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.ribbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.ribbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.ribbonTab1 = New C1.Win.Ribbon.RibbonTab()
        Me.ribbonGroup1 = New C1.Win.Ribbon.RibbonGroup()
        Me.rbSelectRanges = New C1.Win.Ribbon.RibbonButton()
        Me.rbCopyToClipboard = New C1.Win.Ribbon.RibbonButton()
        Me.rbPasteFromClipboard = New C1.Win.Ribbon.RibbonButton()
        Me.rbExportToExcel = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.cmbTheme = New C1.Win.Ribbon.RibbonComboBox()
        Me.c1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        Me.c1FlexGrid1 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.c1NWindDataSet = New MultiRangeSelection.C1NWindDataSet()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ordersTableAdapter = New MultiRangeSelection.C1NWindDataSetTableAdapters.OrdersTableAdapter()
        CType(Me.c1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1NWindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'c1Ribbon1
        '
        Me.c1Ribbon1.AllowContextMenu = False
        Me.c1Ribbon1.AllowMinimize = False
        Me.c1Ribbon1.ApplicationMenuHolder = Me.ribbonApplicationMenu1
        Me.c1Ribbon1.BottomToolBarHolder = Me.ribbonBottomToolBar1
        Me.c1Ribbon1.ConfigToolBarHolder = Me.ribbonConfigToolBar1
        Me.c1Ribbon1.HideTabHeaderRow = True
        Me.c1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.c1Ribbon1.Name = "c1Ribbon1"
        Me.c1Ribbon1.QatHolder = Me.ribbonQat1
        Me.c1Ribbon1.Size = New System.Drawing.Size(1016, 77)
        Me.c1Ribbon1.Tabs.Add(Me.ribbonTab1)
        Me.c1ThemeController1.SetTheme(Me.c1Ribbon1, "(default)")
        Me.c1Ribbon1.TopToolBarHolder = Me.ribbonTopToolBar1
        Me.c1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified
        '
        'ribbonApplicationMenu1
        '
        Me.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1"
        Me.ribbonApplicationMenu1.Visible = False
        '
        'ribbonBottomToolBar1
        '
        Me.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1"
        '
        'ribbonConfigToolBar1
        '
        Me.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1"
        '
        'ribbonQat1
        '
        Me.ribbonQat1.Name = "ribbonQat1"
        Me.ribbonQat1.Visible = False
        '
        'ribbonTab1
        '
        Me.ribbonTab1.Groups.Add(Me.ribbonGroup1)
        Me.ribbonTab1.Name = "ribbonTab1"
        Me.ribbonTab1.Text = "Tab"
        '
        'ribbonGroup1
        '
        Me.ribbonGroup1.Items.Add(Me.rbSelectRanges)
        Me.ribbonGroup1.Items.Add(Me.rbCopyToClipboard)
        Me.ribbonGroup1.Items.Add(Me.rbPasteFromClipboard)
        Me.ribbonGroup1.Items.Add(Me.rbExportToExcel)
        Me.ribbonGroup1.Name = "ribbonGroup1"
        Me.ribbonGroup1.Text = "Main"
        '
        'rbSelectRanges
        '
        Me.rbSelectRanges.Name = "rbSelectRanges"
        Me.rbSelectRanges.Text = "Select ranges"
        '
        'rbCopyToClipboard
        '
        Me.rbCopyToClipboard.Name = "rbCopyToClipboard"
        Me.rbCopyToClipboard.Text = "Copy to clipboard"
        '
        'rbPasteFromClipboard
        '
        Me.rbPasteFromClipboard.Name = "rbPasteFromClipboard"
        Me.rbPasteFromClipboard.Text = "Paste from clipboard"
        '
        'rbExportToExcel
        '
        Me.rbExportToExcel.Name = "rbExportToExcel"
        Me.rbExportToExcel.Text = "Export to Excel"
        '
        'ribbonTopToolBar1
        '
        Me.ribbonTopToolBar1.Items.Add(Me.cmbTheme)
        Me.ribbonTopToolBar1.Name = "ribbonTopToolBar1"
        '
        'cmbTheme
        '
        Me.cmbTheme.Label = "Theme"
        Me.cmbTheme.Name = "cmbTheme"
        '
        'c1ThemeController1
        '
        Me.c1ThemeController1.Theme = "Office2016Green"
        '
        'c1FlexGrid1
        '
        Me.c1FlexGrid1.AutoClipboard = True
        Me.c1FlexGrid1.BackColor = System.Drawing.Color.White
        Me.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo")
        Me.c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.FlexGrid.ColumnPickerSearchMode.None
        Me.c1FlexGrid1.ColumnPickerInfo.ShowColumnMenuItem = False
        Me.c1FlexGrid1.ColumnPickerInfo.ShowToolButton = False
        Me.c1FlexGrid1.DataSource = Me.ordersBindingSource
        Me.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1FlexGrid1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1FlexGrid1.Location = New System.Drawing.Point(0, 77)
        Me.c1FlexGrid1.Name = "c1FlexGrid1"
        Me.c1FlexGrid1.Rows.Count = 1
        Me.c1FlexGrid1.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.MultiRange
        Me.c1FlexGrid1.Size = New System.Drawing.Size(1016, 658)
        Me.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo")
        Me.c1FlexGrid1.TabIndex = 1
        Me.c1ThemeController1.SetTheme(Me.c1FlexGrid1, "(default)")
        Me.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'ordersBindingSource
        '
        Me.ordersBindingSource.DataMember = "Orders"
        Me.ordersBindingSource.DataSource = Me.c1NWindDataSet
        '
        'c1NWindDataSet
        '
        Me.c1NWindDataSet.DataSetName = "C1NWindDataSet"
        Me.c1NWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'toolStrip1
        '
        Me.toolStrip1.BackColor = System.Drawing.Color.White
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripLabel1})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 735)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(1016, 25)
        Me.toolStrip1.TabIndex = 4
        Me.toolStrip1.Text = "toolStrip1"
        Me.c1ThemeController1.SetTheme(Me.toolStrip1, "(default)")
        '
        'toolStripLabel1
        '
        Me.toolStripLabel1.Name = "toolStripLabel1"
        Me.toolStripLabel1.Size = New System.Drawing.Size(98, 22)
        Me.toolStripLabel1.Text = "Selection statistic"
        '
        'ordersTableAdapter
        '
        Me.ordersTableAdapter.ClearBeforeFill = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 760)
        Me.Controls.Add(Me.c1FlexGrid1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.c1Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FlexGrid MultiRange Selection Sample"
        Me.c1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.c1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1NWindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents c1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Friend WithEvents ribbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Friend WithEvents ribbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
    Friend WithEvents ribbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Friend WithEvents ribbonQat1 As C1.Win.Ribbon.RibbonQat
    Friend WithEvents ribbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    Friend WithEvents c1ThemeController1 As C1.Win.Themes.C1ThemeController
    Friend WithEvents cmbTheme As C1.Win.Ribbon.RibbonComboBox
    Friend WithEvents c1FlexGrid1 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents ribbonTab1 As C1.Win.Ribbon.RibbonTab
    Friend WithEvents ribbonGroup1 As C1.Win.Ribbon.RibbonGroup
    Friend WithEvents rbCopyToClipboard As C1.Win.Ribbon.RibbonButton
    Friend WithEvents rbPasteFromClipboard As C1.Win.Ribbon.RibbonButton
    Friend WithEvents rbExportToExcel As C1.Win.Ribbon.RibbonButton
    Friend WithEvents c1NWindDataSet As C1NWindDataSet
    Friend WithEvents ordersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ordersTableAdapter As C1NWindDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents rbSelectRanges As RibbonButton
End Class
