Imports C1.Win.C1Input
Imports C1.Win.Ribbon
Imports C1.Win.TreeView

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim C1TreeColumn1 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.C1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.RibbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.RibbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.cmbThemes = New C1.Win.Ribbon.RibbonComboBox()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnExport = New C1.Win.C1Input.C1Button()
        Me.btnImport = New C1.Win.C1Input.C1Button()
        Me.c1TreeView1 = New C1.Win.TreeView.C1TreeView()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1TreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.C1Ribbon1.Size = New System.Drawing.Size(856, 34)
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
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Items.Add(Me.cmbThemes)
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'cmbThemes
        '
        Me.cmbThemes.Label = "Theme"
        Me.cmbThemes.Name = "cmbThemes"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnExport, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnImport, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.c1TreeView1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 34)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(856, 466)
        Me.TableLayoutPanel1.TabIndex = 0
        Me.C1ThemeController1.SetTheme(Me.TableLayoutPanel1, "(default)")
        '
        'btnExport
        '
        Me.btnExport.AutoSize = True
        Me.btnExport.Location = New System.Drawing.Point(431, 3)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Padding = New System.Windows.Forms.Padding(4)
        Me.btnExport.Size = New System.Drawing.Size(92, 31)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "Export to XML"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.AutoSize = True
        Me.btnImport.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnImport.Location = New System.Drawing.Point(323, 3)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Padding = New System.Windows.Forms.Padding(4)
        Me.btnImport.Size = New System.Drawing.Size(102, 31)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "Import from XML"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'c1TreeView1
        '
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
        C1TreeColumn1.DisplayFieldName = Nothing
        C1TreeColumn1.HeaderText = "Column1"
        C1TreeColumn1.Name = "Column1"
        Me.c1TreeView1.Columns.Add(C1TreeColumn1)
        Me.TableLayoutPanel1.SetColumnSpan(Me.c1TreeView1, 2)
        Me.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1TreeView1.Location = New System.Drawing.Point(3, 103)
        Me.c1TreeView1.Name = "c1TreeView1"
        Me.c1TreeView1.Size = New System.Drawing.Size(850, 360)
        Me.c1TreeView1.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 500)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.btnExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1TreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat1 As C1.Win.Ribbon.RibbonQat
    Friend WithEvents RibbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents cmbThemes As RibbonComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnImport As C1Button
    Friend WithEvents btnExport As C1Button
    Friend WithEvents c1TreeView1 As C1TreeView
End Class
