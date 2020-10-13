<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GreaterThanForm
    Inherits SingleValueConditionalFormattingForm

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
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GreaterThanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 132)
        Me.ConditionalOperationText = "Format cells that are GREATER THAN:"
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "GreaterThanForm"
        Me.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Text = "Greater Than"
        Me.themeController.SetTheme(Me, "(default)")
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
