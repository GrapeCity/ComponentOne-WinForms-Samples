<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits C1.Win.C1Ribbon.C1RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar
        Me.RibbonTab1 = New C1.Win.C1Ribbon.RibbonTab
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Cursor = System.Windows.Forms.Cursors.Default
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(540, 142)
        Me.C1Ribbon1.TabIndex = 0
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab1)
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.ID = "RibbonApplicationMenu1"
        '
        'RibbonQat1
        '
        Me.RibbonQat1.ID = "RibbonQat1"
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.ID = "RibbonConfigToolBar1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup1)
        Me.RibbonTab1.ID = "RibbonTab1"
        Me.RibbonTab1.Text = "Tab"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.ID = "RibbonGroup1"
        Me.RibbonGroup1.Text = "Group"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 271)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Friend WithEvents RibbonTab1 As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup

End Class
