Namespace TestSchedule
    Partial Class ReminderForm
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
        Private Sub InitializeComponent()
            Me.TextBox1 = New System.Windows.Forms.TextBox
            Me.Button1 = New System.Windows.Forms.Button
            Me.Button2 = New System.Windows.Forms.Button
            Me.Button3 = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'TextBox1
            '
            Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.TextBox1.Enabled = False
            Me.TextBox1.Location = New System.Drawing.Point(0, 0)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TextBox1.Size = New System.Drawing.Size(518, 68)
            Me.TextBox1.TabIndex = 0
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(11, 84)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(134, 23)
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "Dismiss"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Location = New System.Drawing.Point(176, 84)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(150, 23)
            Me.Button2.TabIndex = 2
            Me.Button2.Text = "Remind again later"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Button3
            '
            Me.Button3.Location = New System.Drawing.Point(356, 84)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(149, 23)
            Me.Button3.TabIndex = 3
            Me.Button3.Text = "Edit event"
            Me.Button3.UseVisualStyleBackColor = True
            '
            'ReminderForm
            '
			Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(518, 115)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.TextBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "ReminderForm"
            Me.ShowIcon = False
            Me.Text = "ReminderForm"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button3 As System.Windows.Forms.Button
    End Class
End Namespace