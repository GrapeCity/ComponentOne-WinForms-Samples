<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CredentialDialog
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
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbDomain = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbPath = New System.Windows.Forms.TextBox()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 91)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(52, 15)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Domain:"
        '
        'tbDomain
        '
        Me.tbDomain.Location = New System.Drawing.Point(87, 88)
        Me.tbDomain.Name = "tbDomain"
        Me.tbDomain.Size = New System.Drawing.Size(209, 23)
        Me.tbDomain.TabIndex = 15
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(221, 147)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(140, 147)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 16
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 65)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 15)
        Me.label2.TabIndex = 12
        Me.label2.Text = "Password:"
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(87, 62)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(209, 23)
        Me.tbPassword.TabIndex = 13
        '
        'tbPath
        '
        Me.tbPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPath.Location = New System.Drawing.Point(12, 13)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.ReadOnly = True
        Me.tbPath.Size = New System.Drawing.Size(284, 16)
        Me.tbPath.TabIndex = 9
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(87, 36)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(209, 23)
        Me.tbUser.TabIndex = 11
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 39)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(33, 15)
        Me.label1.TabIndex = 10
        Me.label1.Text = "User:"
        '
        'CredentialDialog
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(308, 182)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.tbDomain)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbPath)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CredentialDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label3 As Label
    Private WithEvents tbDomain As TextBox
    Private WithEvents btnCancel As Button
    Private WithEvents btnOk As Button
    Private WithEvents label2 As Label
    Private WithEvents tbPassword As TextBox
    Private WithEvents tbPath As TextBox
    Private WithEvents tbUser As TextBox
    Private WithEvents label1 As Label
End Class
