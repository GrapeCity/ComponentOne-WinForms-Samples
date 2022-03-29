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
        Me.C1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.RibbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.RibbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.RibbonTab1 = New C1.Win.Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.Ribbon.RibbonGroup()
        Me.cmbThemes = New C1.Win.Ribbon.RibbonComboBox()
        Me.RibbonGroup2 = New C1.Win.Ribbon.RibbonGroup()
        Me.rbCreateBands = New C1.Win.Ribbon.RibbonButton()
        Me.rbRemoveBands = New C1.Win.Ribbon.RibbonButton()
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1NWindDataSet = New RibbonAndTheme.C1NWindDataSet()
        Me.C1FlexGridBandedView1 = New C1.Win.C1FlexGrid.C1FlexGridBandedView()
        Me.OrdersTableAdapter = New RibbonAndTheme.C1NWindDataSetTableAdapters.OrdersTableAdapter()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NWindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGridBandedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.BottomToolBarHolder = Me.RibbonBottomToolBar1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.HideTabHeaderRow = True
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(1016, 77)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.C1ThemeController1.SetTheme(Me.C1Ribbon1, "(default)")
        Me.C1Ribbon1.TopToolBarHolder = Me.RibbonTopToolBar1
        Me.C1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.Name = "RibbonApplicationMenu1"
        Me.RibbonApplicationMenu1.Visible = False
        '
        'RibbonBottomToolBar1
        '
        Me.RibbonBottomToolBar1.Name = "RibbonBottomToolBar1"
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.Name = "RibbonConfigToolBar1"
        '
        'RibbonQat1
        '
        Me.RibbonQat1.Name = "RibbonQat1"
        Me.RibbonQat1.Visible = False
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup1)
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup2)
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Tab"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Items.Add(Me.cmbThemes)
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "Styles"
        '
        'cmbThemes
        '
        Me.cmbThemes.Label = "Theme"
        Me.cmbThemes.Name = "cmbThemes"
        Me.cmbThemes.TextAreaWidth = 120
        '
        'RibbonGroup2
        '
        Me.RibbonGroup2.Items.Add(Me.rbCreateBands)
        Me.RibbonGroup2.Items.Add(Me.rbRemoveBands)
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "Group"
        '
        'rbCreateBands
        '
        Me.rbCreateBands.IconSet.Add(New C1.Framework.C1BitmapIcon("NewWindow", New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 274))
        Me.rbCreateBands.IconSet.Add(New C1.Framework.C1BitmapIcon("NewWindow", New System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, "Preset_MediumImages", 274))
        Me.rbCreateBands.IconSet.Add(New C1.Framework.C1BitmapIcon("NewWindow", New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 177))
        Me.rbCreateBands.Name = "rbCreateBands"
        Me.rbCreateBands.Text = "Create column bands"
        '
        'rbRemoveBands
        '
        Me.rbRemoveBands.IconSet.Add(New C1.Framework.C1BitmapIcon("Delete", New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 115))
        Me.rbRemoveBands.IconSet.Add(New C1.Framework.C1BitmapIcon("Delete", New System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, "Preset_MediumImages", 115))
        Me.rbRemoveBands.IconSet.Add(New C1.Framework.C1BitmapIcon("Delete", New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 67))
        Me.rbRemoveBands.Name = "rbRemoveBands"
        Me.rbRemoveBands.Text = "Remove column bands"
        '
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.ColumnContextMenuEnabled = True
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.Highlight
        Me.C1FlexGrid1.ColumnPickerInfo.ShowColumnMenuItem = True
        Me.C1FlexGrid1.ColumnPickerInfo.ShowToolButton = True
        Me.C1FlexGrid1.DataSource = Me.OrdersBindingSource
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 77)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Size = New System.Drawing.Size(1016, 683)
        Me.C1FlexGrid1.TabIndex = 1
        Me.C1FlexGrid1.AllowEditing = False
        Me.C1ThemeController1.SetTheme(Me.C1FlexGrid1, "(default)")
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.C1NWindDataSet
        '
        'C1NWindDataSet
        '
        Me.C1NWindDataSet.DataSetName = "C1NWindDataSet"
        Me.C1NWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 760)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Column Picker Sample"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NWindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGridBandedView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat1 As C1.Win.Ribbon.RibbonQat
    Friend WithEvents RibbonTab1 As C1.Win.Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.Ribbon.RibbonGroup
    Friend WithEvents RibbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents cmbThemes As C1.Win.Ribbon.RibbonComboBox
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGridBandedView1 As C1.Win.C1FlexGrid.C1FlexGridBandedView
    Friend WithEvents C1NWindDataSet As C1NWindDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As C1NWindDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents RibbonGroup2 As RibbonGroup
    Friend WithEvents rbCreateBands As RibbonButton
    Friend WithEvents rbRemoveBands As RibbonButton
End Class
