<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlexGridSample
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlexGridSample))
        Me.flexGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.themeController = New C1.Win.C1Themes.C1ThemeController()
        CType(Me.flexGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flexGrid
        '
        Me.flexGrid.BackColor = System.Drawing.Color.White
        Me.flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:"
        Me.flexGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flexGrid.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.flexGrid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.flexGrid.Location = New System.Drawing.Point(0, 0)
        Me.flexGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flexGrid.Name = "flexGrid"
        Me.flexGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.flexGrid.Size = New System.Drawing.Size(700, 523)
        Me.flexGrid.StyleInfo = resources.GetString("flexGrid.StyleInfo")
        Me.flexGrid.TabIndex = 0
        Me.themeController.SetTheme(Me.flexGrid, "(default)")
        Me.flexGrid.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        '
        'FlexGridSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.flexGrid)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FlexGridSample"
        Me.Size = New System.Drawing.Size(700, 523)
        Me.themeController.SetTheme(Me, "(default)")
        CType(Me.flexGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flexGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents themeController As C1.Win.C1Themes.C1ThemeController
End Class
