<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageRoot1
    Inherits BasePageNoGrid

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
        Me.label1 = New System.Windows.Forms.Label
        Me.gaugePanel.SuspendLayout()
        Me.gridPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'gaugePanel
        '
        Me.gaugePanel.Controls.Add(Me.label1)
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.label1.Location = New System.Drawing.Point(15, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(340, 25)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Select a sample from the tree view"
        '
        'PageRoot1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageRoot1"
        Me.gaugePanel.ResumeLayout(False)
        Me.gaugePanel.PerformLayout()
        Me.gridPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
