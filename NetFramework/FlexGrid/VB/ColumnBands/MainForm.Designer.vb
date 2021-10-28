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
        Dim Band1 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band2 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band3 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band4 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band5 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band6 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band7 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band8 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band9 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band10 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band11 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band12 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band13 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band14 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band15 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band16 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band17 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim Band18 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.C1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.RibbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.RibbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.RibbonTab1 = New C1.Win.Ribbon.RibbonTab()
        Me.rgThemes = New C1.Win.Ribbon.RibbonGroup()
        Me.cmbThemes = New C1.Win.Ribbon.RibbonComboBox()
        Me.rgBands = New C1.Win.Ribbon.RibbonGroup()
        Me.rbCreateBands = New C1.Win.Ribbon.RibbonButton()
        Me.rbClearBands = New C1.Win.Ribbon.RibbonButton()
        Me.rgAdditional = New C1.Win.Ribbon.RibbonGroup()
        Me.rbBandsColumnsRelation = New C1.Win.Ribbon.RibbonComboBox()
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.RibbonGroup1 = New C1.Win.Ribbon.RibbonGroup()
        Me.c1FlexGridBandedView1 = New C1.Win.C1FlexGrid.C1FlexGridBandedView()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1NWindDataSet = New ColumnBands.C1NWindDataSet()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.CarsTableAdapter1 = New ColumnBands.C1NWindDataSetTableAdapters.CarsTableAdapter()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1FlexGridBandedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NWindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonTab1.Groups.Add(Me.rgThemes)
        Me.RibbonTab1.Groups.Add(Me.rgBands)
        Me.RibbonTab1.Groups.Add(Me.rgAdditional)
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Tab"
        '
        'rgThemes
        '
        Me.rgThemes.Items.Add(Me.cmbThemes)
        Me.rgThemes.Name = "rgThemes"
        Me.rgThemes.Text = "Styles"
        '
        'cmbThemes
        '
        Me.cmbThemes.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        Me.cmbThemes.Label = "Theme"
        Me.cmbThemes.Name = "cmbThemes"
        '
        'rgBands
        '
        Me.rgBands.Items.Add(Me.rbCreateBands)
        Me.rgBands.Items.Add(Me.rbClearBands)
        Me.rgBands.Name = "rgBands"
        Me.rgBands.Text = "Bands"
        '
        'rbCreateBands
        '
        Me.rbCreateBands.IconSet.Add(New C1.Framework.C1BitmapIcon("OutlineGroup", New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 294))
        Me.rbCreateBands.Name = "rbCreateBands"
        Me.rbCreateBands.Text = "Create bands"
        '
        'rbClearBands
        '
        Me.rbClearBands.IconSet.Add(New C1.Framework.C1BitmapIcon("DeleteColumn", New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 117))
        Me.rbClearBands.Name = "rbClearBands"
        Me.rbClearBands.Text = "Clear bands"
        '
        'rgAdditional
        '
        Me.rgAdditional.Items.Add(Me.rbBandsColumnsRelation)
        Me.rgAdditional.Name = "rgAdditional"
        Me.rgAdditional.Text = "Additional"
        '
        'rbBandsColumnsRelation
        '
        Me.rbBandsColumnsRelation.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        Me.rbBandsColumnsRelation.Label = "Bands Columns Relation"
        Me.rbBandsColumnsRelation.Name = "rbBandsColumnsRelation"
        '
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Name = "RibbonGroup1"
        '
        'c1FlexGridBandedView1
        '
        Band1.Caption = "ID"
        Band1.Name = "ID"
        Band2.Caption = "Brand"
        Band2.Name = "Brand"
        Band3.Caption = "Model"
        Band3.Name = "Model"
        Band4.Caption = "Specifications"
        Band5.Caption = "Engine"
        Band6.Caption = "HP"
        Band6.Name = "HP"
        Band7.Caption = "Liter"
        Band7.Name = "Liter"
        Band8.Caption = "Cyl"
        Band8.Name = "Cyl"
        Band5.Children.Add(Band6)
        Band5.Children.Add(Band7)
        Band5.Children.Add(Band8)
        Band5.CollapseTo = "Cyl"
        Band5.Name = "Engine"
        Band9.Caption = "Transmission"
        Band10.Caption = "TransmissSpeedCount"
        Band10.IsCollapsed = True
        Band10.Name = "TransmissSpeedCount"
        Band11.Caption = "TransmissAutomatic"
        Band11.Name = "TransmissAutomatic"
        Band9.Children.Add(Band10)
        Band9.Children.Add(Band11)
        Band9.CollapseTo = "TransmissAutomatic"
        Band9.Name = "Transmission"
        Band4.Children.Add(Band5)
        Band4.Children.Add(Band9)
        Band4.CollapseTo = "TransmissAutomatic"
        Band4.Name = "Specifications"
        Band12.Caption = "MPG_City"
        Band12.Name = "MPG_City"
        Band13.Caption = "MPG_Highway"
        Band13.Name = "MPG_Highway"
        Band14.Caption = "Category"
        Band14.Name = "Category"
        Band15.Caption = "Description"
        Band15.Name = "Description"
        Band16.Caption = "Picture"
        Band16.Name = "Picture"
        Band17.Caption = "Price"
        Band17.Name = "Price"
        Band18.Caption = "Hyperlink"
        Band18.Name = "Hyperlink"
        Me.c1FlexGridBandedView1.Bands.Add(Band1)
        Me.c1FlexGridBandedView1.Bands.Add(Band2)
        Me.c1FlexGridBandedView1.Bands.Add(Band3)
        Me.c1FlexGridBandedView1.Bands.Add(Band4)
        Me.c1FlexGridBandedView1.Bands.Add(Band12)
        Me.c1FlexGridBandedView1.Bands.Add(Band13)
        Me.c1FlexGridBandedView1.Bands.Add(Band14)
        Me.c1FlexGridBandedView1.Bands.Add(Band15)
        Me.c1FlexGridBandedView1.Bands.Add(Band16)
        Me.c1FlexGridBandedView1.Bands.Add(Band17)
        Me.c1FlexGridBandedView1.Bands.Add(Band18)
        Me.c1FlexGridBandedView1.ColumnContextMenuEnabled = True
        Me.c1FlexGridBandedView1.FlexGrid = Me.C1FlexGrid1
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowEditing = False
        Me.C1FlexGrid1.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.Custom
        Me.C1FlexGrid1.BackColor = System.Drawing.Color.White
        Me.C1FlexGrid1.ColumnContextMenuEnabled = True
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.DataSource = Me.BindingSource1
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.C1FlexGrid1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 77)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 3
        Me.C1FlexGrid1.Rows.Fixed = 3
        Me.C1FlexGrid1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.C1FlexGrid1.Size = New System.Drawing.Size(1016, 683)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 1
        Me.C1ThemeController1.SetTheme(Me.C1FlexGrid1, "(default)")
        Me.C1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Cars"
        Me.BindingSource1.DataSource = Me.C1NWindDataSet
        '
        'C1NWindDataSet
        '
        Me.C1NWindDataSet.DataSetName = "C1NWindDataSet"
        Me.C1NWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'C1ThemeController1
        '
        Me.C1ThemeController1.Theme = "Office2016Green"
        '
        'CarsTableAdapter1
        '
        Me.CarsTableAdapter1.ClearBeforeFill = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 760)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Column Bands Sample"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1FlexGridBandedView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NWindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Friend WithEvents c1FlexGridBandedView1 As C1.Win.C1FlexGrid.C1FlexGridBandedView
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
    Friend WithEvents C1NWindDataSet As C1NWindDataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents CarsTableAdapter1 As C1NWindDataSetTableAdapters.CarsTableAdapter
    Friend WithEvents rgThemes As C1.Win.Ribbon.RibbonGroup
    Friend WithEvents rgBands As C1.Win.Ribbon.RibbonGroup
    Friend WithEvents rgAdditional As C1.Win.Ribbon.RibbonGroup
    Friend WithEvents rbCreateBands As C1.Win.Ribbon.RibbonButton
    Friend WithEvents rbClearBands As C1.Win.Ribbon.RibbonButton
    Friend WithEvents rbBandsColumnsRelation As C1.Win.Ribbon.RibbonComboBox
End Class
