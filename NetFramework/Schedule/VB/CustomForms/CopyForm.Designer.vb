Namespace TestSchedule
	Partial Class CopyForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me._message = New System.Windows.Forms.Label()
			Me.monthCalendar1 = New System.Windows.Forms.MonthCalendar()
			Me.SuspendLayout()
			'
			'_message
			'
			Me._message.Dock = System.Windows.Forms.DockStyle.Fill
			Me._message.Location = New System.Drawing.Point(164, 0)
			Me._message.Margin = New System.Windows.Forms.Padding(2)
			Me._message.Name = "_message"
			Me._message.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
			Me._message.Size = New System.Drawing.Size(131, 164)
			Me._message.TabIndex = 0
			Me._message.Text = "Select a week for copy to (choose one)"
			'
			'monthCalendar1
			'
			Me.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Left
			Me.monthCalendar1.Location = New System.Drawing.Point(0, 0)
			Me.monthCalendar1.Margin = New System.Windows.Forms.Padding(7)
			Me.monthCalendar1.Name = "monthCalendar1"
			Me.monthCalendar1.TabIndex = 1
			'
			'CopyForm
			'
			Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
			Me.AutoSize = True
			Me.ClientSize = New System.Drawing.Size(295, 164)
			Me.Controls.Add(Me._message)
			Me.Controls.Add(Me.monthCalendar1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "CopyForm"
			Me.Text = "Select Week"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Friend WithEvents monthCalendar1 As System.Windows.Forms.MonthCalendar
		Public _message As System.Windows.Forms.Label
	End Class
End Namespace
