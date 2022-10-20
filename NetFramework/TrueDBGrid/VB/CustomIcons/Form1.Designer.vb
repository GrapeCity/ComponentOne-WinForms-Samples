<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.c1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.c1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        Me.ribbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.ribbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.ribbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.ribbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.ribbonTab1 = New C1.Win.Ribbon.RibbonTab()
        Me.ribbonGroup1 = New C1.Win.Ribbon.RibbonGroup()
        Me.ribbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.cmbTheme = New C1.Win.Ribbon.RibbonComboBox()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        CType(Me.c1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1TrueDBGrid1
        '
        Me.c1TrueDBGrid1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1TrueDBGrid1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c1TrueDBGrid1.Images.Add(CType(resources.GetObject("c1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.c1TrueDBGrid1.Location = New System.Drawing.Point(0, 34)
        Me.c1TrueDBGrid1.Name = "c1TrueDBGrid1"
        Me.c1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = Nothing
        Me.c1TrueDBGrid1.RowHeight = 17
        Me.c1TrueDBGrid1.Size = New System.Drawing.Size(800, 416)
        Me.c1TrueDBGrid1.TabIndex = 3
        Me.C1ThemeController1.SetTheme(Me.c1TrueDBGrid1, "(default)")
        Me.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag")
        '
        'c1Ribbon1
        '
        Me.c1Ribbon1.ApplicationMenuHolder = Me.ribbonApplicationMenu1
        Me.c1Ribbon1.BottomToolBarHolder = Me.ribbonBottomToolBar1
        Me.c1Ribbon1.ConfigToolBarHolder = Me.ribbonConfigToolBar1
        Me.c1Ribbon1.HideTabHeaderRow = True
        Me.c1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.c1Ribbon1.Minimized = True
        Me.c1Ribbon1.Name = "c1Ribbon1"
        Me.c1Ribbon1.QatHolder = Me.ribbonQat1
        Me.c1Ribbon1.Size = New System.Drawing.Size(800, 34)
        Me.c1Ribbon1.Tabs.Add(Me.ribbonTab1)
        Me.C1ThemeController1.SetTheme(Me.c1Ribbon1, "(default)")
        Me.c1Ribbon1.TopToolBarHolder = Me.ribbonTopToolBar1
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
        '
        'ribbonTab1
        '
        Me.ribbonTab1.Groups.Add(Me.ribbonGroup1)
        Me.ribbonTab1.Name = "ribbonTab1"
        Me.ribbonTab1.Text = "Tab"
        '
        'ribbonGroup1
        '
        Me.ribbonGroup1.Name = "ribbonGroup1"
        Me.ribbonGroup1.Text = "Group"
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
        Me.cmbTheme.TextAreaWidth = 120
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.c1TrueDBGrid1)
        Me.Controls.Add(Me.c1Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Custom Icons"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.c1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents c1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Private WithEvents c1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Private WithEvents ribbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Private WithEvents ribbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
    Private WithEvents ribbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Private WithEvents ribbonQat1 As C1.Win.Ribbon.RibbonQat
    Private WithEvents ribbonTab1 As C1.Win.Ribbon.RibbonTab
    Private WithEvents ribbonGroup1 As C1.Win.Ribbon.RibbonGroup
    Private WithEvents ribbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    Private WithEvents cmbTheme As C1.Win.Ribbon.RibbonComboBox
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
End Class
