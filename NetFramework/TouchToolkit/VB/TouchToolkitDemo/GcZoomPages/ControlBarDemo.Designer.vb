Namespace C1ZoomPages
	Partial Class ControlBarDemo
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
			Me.button3 = New System.Windows.Forms.Button()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.button3)
			Me.panel1.Controls.Add(Me.button1)
			' 
			' button1
			' 
			Me.button1.Font = New System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(128))
			Me.button1.Image = My.Resources.map
			Me.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.button1.Location = New System.Drawing.Point(3, 16)
			Me.button1.Name = "button1"
			Me.button1.Padding = New System.Windows.Forms.Padding(3, 50, 3, 10)
			Me.button1.Size = New System.Drawing.Size(340, 369)
			Me.button1.TabIndex = 0
			Me.button1.Text = "ControlBar Demo for MapView"
			Me.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
			Me.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
			Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New EventHandler(AddressOf Me.button1_Click)
			' 
			' button3
			' 
			Me.button3.Font = New System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(128))
			Me.button3.Image = My.Resources.touchKeyboard
			Me.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.button3.Location = New System.Drawing.Point(347, 16)
			Me.button3.Name = "button3"
			Me.button3.Padding = New System.Windows.Forms.Padding(3, 50, 3, 10)
			Me.button3.Size = New System.Drawing.Size(340, 369)
			Me.button3.TabIndex = 1
			Me.button3.Text = "ControlBar Demo for Keyboard"
			Me.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
			Me.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.button3.UseVisualStyleBackColor = True
            AddHandler Me.button3.Click, New EventHandler(AddressOf Me.button3_Click)
			' 
			' ControlBarDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 18F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "ControlBarDemo"
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private button1 As System.Windows.Forms.Button
		Private button3 As System.Windows.Forms.Button
	End Class
End Namespace
