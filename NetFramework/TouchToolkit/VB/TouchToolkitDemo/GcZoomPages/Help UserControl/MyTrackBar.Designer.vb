Namespace C1ZoomPages.Help_Forms
	Partial Class MyTrackBar
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.Color.White
			Me.button1.Enabled = False
			Me.button1.FlatAppearance.BorderSize = 3
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button1.Location = New System.Drawing.Point(20, 0)
			Me.button1.Margin = New System.Windows.Forms.Padding(0)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(20, 216)
			Me.button1.TabIndex = 0
			Me.button1.UseVisualStyleBackColor = False
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.Color.White
			Me.button2.FlatAppearance.BorderSize = 3
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button2.Location = New System.Drawing.Point(5, 40)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(50, 25)
			Me.button2.TabIndex = 1
			Me.button2.UseVisualStyleBackColor = False
			' 
			' MyTrackBar
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Name = "MyTrackBar"
			Me.Size = New System.Drawing.Size(60, 220)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private button1 As System.Windows.Forms.Button
		Private button2 As System.Windows.Forms.Button
	End Class
End Namespace
