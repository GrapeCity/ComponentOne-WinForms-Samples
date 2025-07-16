Imports C1.Win.Ribbon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits C1RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.C1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        Me.C1FlexGrid1 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.CarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New UnboundMode.DataSet1()
        Me.CarsTableAdapter = New UnboundMode.DataSet1TableAdapters.CarsTableAdapter()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.BottomToolBarHolder = Me.RibbonBottomToolBar1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.HideTabHeaderRow = True
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Margin = New System.Windows.Forms.Padding(6)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(2012, 154)
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
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.DataSource = Me.CarsBindingSource
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 154)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None
        Me.C1FlexGrid1.Size = New System.Drawing.Size(2012, 869)
        Me.C1FlexGrid1.TabIndex = 1
        Me.C1ThemeController1.SetTheme(Me.C1FlexGrid1, "(default)")
        Me.C1FlexGrid1.Tree.Indent = 18
        '
        'CarsBindingSource
        '
        Me.CarsBindingSource.DataMember = "Cars"
        Me.CarsBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarsTableAdapter
        '
        Me.CarsTableAdapter.ClearBeforeFill = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2012, 1023)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents C1ThemeController1 As C1.Win.Themes.C1ThemeController
    Friend WithEvents cmbThemes As C1.Win.Ribbon.RibbonComboBox
    Friend WithEvents C1FlexGrid1 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CarsBindingSource As BindingSource
    Friend WithEvents CarsTableAdapter As DataSet1TableAdapters.CarsTableAdapter
End Class
