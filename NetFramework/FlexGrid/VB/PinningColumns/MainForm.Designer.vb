Imports C1.Win.Ribbon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class MainForm
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
        Me.cmbThemes = New C1.Win.Ribbon.RibbonComboBox()
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.C1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.c1FlexGrid1 = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1FlexGrid2 = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me.c1FlexGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width
        Me.C1Ribbon1.BottomToolBarHolder = Me.RibbonBottomToolBar1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.HideTabHeaderRow = True
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "c1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(800, 77)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.C1ThemeController1.SetTheme(Me.C1Ribbon1, "(default)")
        Me.C1Ribbon1.TopToolBarHolder = Me.RibbonTopToolBar1
        Me.C1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified
        Me.RibbonApplicationMenu1.Name = "ribbonApplicationMenu1"
        Me.RibbonApplicationMenu1.Visible = False
        Me.RibbonBottomToolBar1.Name = "ribbonBottomToolBar1"
        Me.RibbonConfigToolBar1.Name = "ribbonConfigToolBar1"
        Me.RibbonQat1.Name = "ribbonQat1"
        Me.RibbonQat1.Visible = False
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup1)
        Me.RibbonTab1.Name = "ribbonTab1"
        Me.RibbonTab1.Text = "Tab"
        Me.RibbonGroup1.Items.Add(Me.cmbThemes)
        Me.RibbonGroup1.Name = "ribbonGroup1"
        Me.RibbonGroup1.Text = "Styles"
        Me.cmbThemes.Label = "Theme"
        Me.cmbThemes.Name = "cmbTheme"
        AddHandler Me.cmbThemes.SelectedIndexChanged, AddressOf Me.CmbThemes_SelectedIndexChanged
        Me.RibbonTopToolBar1.Name = "ribbonTopToolBar1"
        Me.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:"
        Me.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1FlexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.c1FlexGrid1.Name = "c1FlexGrid1"
        Me.c1FlexGrid1.Size = New System.Drawing.Size(334, 238)
        Me.c1FlexGrid1.TabIndex = 0
        Me.c1FlexGrid1.Text = "c1FlexGrid1"
        Me.C1ThemeController1.SetTheme(Me.c1FlexGrid1, "(default)")
        Me.c1FlexGrid2.ColumnInfo = "10,1,0,0,0,-1,Columns:"
        Me.c1FlexGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1FlexGrid2.Location = New System.Drawing.Point(0, 0)
        Me.c1FlexGrid2.Name = "c1FlexGrid2"
        Me.c1FlexGrid2.Size = New System.Drawing.Size(334, 238)
        Me.c1FlexGrid2.TabIndex = 0
        Me.c1FlexGrid2.Text = "c1FlexGrid12"
        Me.C1ThemeController1.SetTheme(Me.c1FlexGrid2, "(default)")
        Me.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.splitContainer1.Location = New System.Drawing.Point(0, 77)
        Me.splitContainer1.Name = "splitContainer1"
        Me.C1ThemeController1.SetTheme(Me.splitContainer1, "(default)")
        Me.splitContainer1.Panel1.Controls.Add(Me.c1FlexGrid1)
        Me.splitContainer1.Panel2.Controls.Add(Me.c1FlexGrid2)
        Me.splitContainer1.Size = New System.Drawing.Size(800, 370)
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.splitContainer1.SplitterDistance = 190
        Me.splitContainer1.TabIndex = 0
        Me.splitContainer1.Text = "splitContainer1"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Controls.Add(Me.splitContainer1)
        Me.Icon = (CType((resources.GetObject("$this.Icon")), System.Drawing.Icon))
        Me.Name = "MainForm"
        Me.Text = "Pinned Columns"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        AddHandler Me.Load, AddressOf Me.MainForm_Load
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel1.PerformLayout()
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1FlexGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
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
    Friend WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents c1FlexGrid1 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents c1FlexGrid2 As C1.Win.FlexGrid.C1FlexGrid
End Class
