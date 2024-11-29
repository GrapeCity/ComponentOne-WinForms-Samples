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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.C1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.RibbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.RibbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.RibbonTab1 = New C1.Win.Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.Ribbon.RibbonGroup()
        Me.RibbonCMBThemes = New C1.Win.Ribbon.RibbonComboBox()
        Me.RibbonGroup2 = New C1.Win.Ribbon.RibbonGroup()
        Me.cbAutoApply = New C1.Win.Ribbon.RibbonCheckBox()
        Me.rbtnApplyFilter = New C1.Win.Ribbon.RibbonButton()
        Me.RibbonSeparator1 = New C1.Win.Ribbon.RibbonSeparator()
        Me.rbtnSaveFilter = New C1.Win.Ribbon.RibbonButton()
        Me.rbtnResetFilter = New C1.Win.Ribbon.RibbonButton()
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.C1DataFilter1 = New C1.Win.DataFilter.C1DataFilter()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.C1DataFilter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.BottomToolBarHolder = Me.RibbonBottomToolBar1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(1325, 201)
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
        Me.RibbonGroup2.Items.Add(Me.cbAutoApply)
        Me.RibbonGroup2.Items.Add(Me.rbtnApplyFilter)
        Me.RibbonGroup2.Items.Add(Me.RibbonSeparator1)
        Me.RibbonGroup2.Items.Add(Me.rbtnSaveFilter)
        Me.RibbonGroup2.Items.Add(Me.rbtnResetFilter)
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "Filter"
        '
        'cbAutoApply
        '
        Me.cbAutoApply.Checked = True
        Me.cbAutoApply.Name = "cbAutoApply"
        Me.cbAutoApply.Text = "Auto apply filter"
        '
        'rbtnApplyFilter
        '
        Me.rbtnApplyFilter.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbtnApplyFilter.IconSet"), System.Drawing.Image)))
        Me.rbtnApplyFilter.Name = "rbtnApplyFilter"
        Me.rbtnApplyFilter.Text = "Apply filter"
        '
        'RibbonSeparator1
        '
        Me.RibbonSeparator1.Name = "RibbonSeparator1"
        '
        'rbtnSaveFilter
        '
        Me.rbtnSaveFilter.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbtnSaveFilter.IconSet"), System.Drawing.Image)))
        Me.rbtnSaveFilter.Name = "rbtnSaveFilter"
        Me.rbtnSaveFilter.Text = "Save filter"
        '
        'rbtnResetFilter
        '
        Me.rbtnResetFilter.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbtnResetFilter.IconSet"), System.Drawing.Image)))
        Me.rbtnResetFilter.Name = "rbtnResetFilter"
        Me.rbtnResetFilter.Text = "Reset filter"
        '
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 201)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.C1DataFilter1)
        Me.SplitContainer1.Panel1MinSize = 270
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.C1FlexGrid1)
        Me.SplitContainer1.Panel2MinSize = 500
        Me.SplitContainer1.Size = New System.Drawing.Size(1325, 616)
        Me.SplitContainer1.SplitterDistance = 372
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 1
        '
        'C1DataFilter1
        '
        Me.C1DataFilter1.AutoGenerateFilters = True
        Me.C1DataFilter1.DataMember = Nothing
        Me.C1DataFilter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DataFilter1.Location = New System.Drawing.Point(0, 0)
        Me.C1DataFilter1.Name = "C1DataFilter1"
        Me.C1DataFilter1.Size = New System.Drawing.Size(372, 616)
        Me.C1DataFilter1.TabIndex = 0
        Me.C1DataFilter1.Text = "C1DataFilter1"
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexGrid1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.DefaultSize = 25
        Me.C1FlexGrid1.Size = New System.Drawing.Size(948, 616)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 817)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.C1DataFilter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents C1DataFilter1 As C1.Win.DataFilter.C1DataFilter
    Private WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents RibbonGroup2 As RibbonGroup
    Friend WithEvents cbAutoApply As RibbonCheckBox
    Friend WithEvents rbtnApplyFilter As RibbonButton
    Friend WithEvents RibbonSeparator1 As RibbonSeparator
    Friend WithEvents rbtnSaveFilter As RibbonButton
    Friend WithEvents rbtnResetFilter As RibbonButton
End Class
