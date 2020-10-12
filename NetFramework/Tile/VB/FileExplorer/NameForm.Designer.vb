<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NameForm
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
        Me.cancButton = New System.Windows.Forms.Button
        Me.okButton = New System.Windows.Forms.Button
        Me.label2 = New System.Windows.Forms.Label
        Me.nameBox = New System.Windows.Forms.TextBox
        Me.nameLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cancButton
        '
        Me.cancButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancButton.Location = New System.Drawing.Point(270, 97)
        Me.cancButton.Name = "cancButton"
        Me.cancButton.Size = New System.Drawing.Size(75, 23)
        Me.cancButton.TabIndex = 9
        Me.cancButton.Text = "Cancel"
        Me.cancButton.UseVisualStyleBackColor = True
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(189, 97)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 8
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label2.Location = New System.Drawing.Point(20, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(325, 2)
        Me.label2.TabIndex = 7
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(20, 33)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(325, 23)
        Me.nameBox.TabIndex = 6
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(17, 15)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(105, 15)
        Me.nameLabel.TabIndex = 5
        Me.nameLabel.Text = "New Folder Name:"
        '
        'NameForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.cancButton
        Me.ClientSize = New System.Drawing.Size(364, 136)
        Me.Controls.Add(Me.cancButton)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.nameLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NameForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create New Folder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cancButton As System.Windows.Forms.Button
    Private WithEvents okButton As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents nameBox As System.Windows.Forms.TextBox
    Private WithEvents nameLabel As System.Windows.Forms.Label
End Class
