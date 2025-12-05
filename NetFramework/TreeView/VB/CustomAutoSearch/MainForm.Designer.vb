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
        Dim C1TreeColumn1 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Me.C1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.RibbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.RibbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.RibbonTab1 = New C1.Win.Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.Ribbon.RibbonGroup()
        Me.RibbonCMBThemes = New C1.Win.Ribbon.RibbonComboBox()
        Me.RibbonGroup2 = New C1.Win.Ribbon.RibbonGroup()
        Me.RibbonTextBox1 = New C1.Win.Ribbon.RibbonTextBox()
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.C1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        Me.C1TreeView1 = New C1.Win.TreeView.C1TreeView()
        Me.DataSet1 = New CustomAutoSearch.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TerritoriesTableAdapter = New CustomAutoSearch.DataSet1TableAdapters.TerritoriesTableAdapter()
        Me.RegionTableAdapter = New CustomAutoSearch.DataSet1TableAdapters.RegionTableAdapter()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width
        Me.C1Ribbon1.BottomToolBarHolder = Me.RibbonBottomToolBar1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(640, 143)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.C1ThemeController1.SetTheme(Me.C1Ribbon1, "(default)")
        Me.C1Ribbon1.TopToolBarHolder = Me.RibbonTopToolBar1
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.Name = "RibbonApplicationMenu1"
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
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup1)
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup2)
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Styles"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Items.Add(Me.RibbonCMBThemes)
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "Theme"
        '
        'RibbonCMBThemes
        '
        Me.RibbonCMBThemes.Name = "RibbonCMBThemes"
        '
        'RibbonGroup2
        '
        Me.RibbonGroup2.Items.Add(Me.RibbonTextBox1)
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "Auto search"
        '
        'RibbonTextBox1
        '
        Me.RibbonTextBox1.Label = "Search"
        Me.RibbonTextBox1.Name = "RibbonTextBox1"
        '
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'C1TreeView1
        '
        C1TreeColumn1.DisplayFieldName = "RegionDescription\TerritoryDescription"
        C1TreeColumn1.HeaderText = "Column1"
        C1TreeColumn1.Name = "Column1"
        Me.C1TreeView1.Columns.Add(C1TreeColumn1)
        Me.C1TreeView1.BindingInfo.DataMember = Nothing
        Me.C1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TreeView1.BindingInfo.KeyField = Nothing
        Me.C1TreeView1.Location = New System.Drawing.Point(0, 143)
        Me.C1TreeView1.Name = "C1TreeView1"
        Me.C1TreeView1.BindingInfo.ParentKeyField = Nothing
        Me.C1TreeView1.ShowColumnHeaders = False
        Me.C1TreeView1.Size = New System.Drawing.Size(640, 297)
        Me.C1TreeView1.TabIndex = 1
        Me.C1ThemeController1.SetTheme(Me.C1TreeView1, "(default)")
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataMember = "Territories"
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        '
        'TerritoriesTableAdapter
        '
        Me.TerritoriesTableAdapter.ClearBeforeFill = True
        '
        'RegionTableAdapter
        '
        Me.RegionTableAdapter.ClearBeforeFill = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 440)
        Me.Controls.Add(Me.C1TreeView1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Private WithEvents RibbonCMBThemes As C1.Win.Ribbon.RibbonComboBox
    Private WithEvents RibbonApplicationMenu1 As RibbonApplicationMenu
    Private WithEvents RibbonBottomToolBar1 As RibbonBottomToolBar
    Private WithEvents RibbonConfigToolBar1 As RibbonConfigToolBar
    Private WithEvents RibbonQat1 As RibbonQat
    Private WithEvents RibbonTab1 As RibbonTab
    Private WithEvents RibbonGroup1 As RibbonGroup
    Private WithEvents RibbonTopToolBar1 As RibbonTopToolBar
    Private WithEvents C1ThemeController1 As C1.Win.Themes.C1ThemeController
    Friend WithEvents RibbonGroup2 As RibbonGroup
    Friend WithEvents RibbonTextBox1 As RibbonTextBox
    Friend WithEvents C1TreeView1 As C1.Win.TreeView.C1TreeView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents TerritoriesTableAdapter As DataSet1TableAdapters.TerritoriesTableAdapter
    Friend WithEvents RegionTableAdapter As DataSet1TableAdapters.RegionTableAdapter
End Class
