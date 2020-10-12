<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasePageNoGrid
    Inherits BaseGaugePage

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
        Me.gridPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitter1
        '
        Me.splitter1.Visible = False
        '
        'gridPanel
        '
        Me.gridPanel.Visible = False
        '
        'BasePageNoGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "BasePageNoGrid"
        Me.gridPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

End Class
