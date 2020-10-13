<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppMenuTabButton
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
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.lblText = New System.Windows.Forms.Label()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbImage
        '
        Me.pbImage.Location = New System.Drawing.Point(4, 4)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(32, 32)
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'lblText
        '
        Me.lblText.AutoEllipsis = True
        Me.lblText.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblText.Location = New System.Drawing.Point(42, 9)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(318, 21)
        Me.lblText.TabIndex = 1
        Me.lblText.Text = "Label1"
        '
        'AppMenuTabButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.pbImage)
        Me.Name = "AppMenuTabButton"
        Me.Size = New System.Drawing.Size(380, 40)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents lblText As System.Windows.Forms.Label
End Class
