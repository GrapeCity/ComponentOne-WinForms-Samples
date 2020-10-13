Namespace C1ZoomPages
	Partial Class InputFormforControlBar
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim controlBar1 As New C1.Win.TouchToolKit.ControlBar()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.textBox3 = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.button1 = New System.Windows.Forms.Button()
			Me.gcZoom1 = New C1.Win.TouchToolKit.C1Zoom(Me.components)
			Me.SuspendLayout()
			' 
			' textBox1
			' 
			Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.textBox1.Location = New System.Drawing.Point(29, 67)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(202, 26)
			Me.textBox1.TabIndex = 0
			' 
			' textBox2
			' 
			Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.textBox2.Location = New System.Drawing.Point(29, 148)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New System.Drawing.Size(202, 26)
			Me.textBox2.TabIndex = 1
			' 
			' textBox3
			' 
			Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.textBox3.Location = New System.Drawing.Point(29, 233)
			Me.textBox3.Name = "textBox3"
			Me.textBox3.Size = New System.Drawing.Size(202, 26)
			Me.textBox3.TabIndex = 2
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label1.Location = New System.Drawing.Point(15, 26)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(119, 20)
			Me.label1.TabIndex = 1
			Me.label1.Text = "InputNumber 1:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label2.Location = New System.Drawing.Point(12, 109)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(119, 20)
			Me.label2.TabIndex = 1
			Me.label2.Text = "InputNumber 2:"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label3.Location = New System.Drawing.Point(15, 192)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(119, 20)
			Me.label3.TabIndex = 1
			Me.label3.Text = "InputNumber 3:"
			' 
			' button1
			' 
			Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.button1.Location = New System.Drawing.Point(105, 287)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(126, 61)
			Me.button1.TabIndex = 3
			Me.button1.Text = "OK"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' gcZoom1
			' 
            controlBar1.Content = GetType(C1ZoomPages.Help_Forms.KeyboadControlBar)
			controlBar1.TransparencyKey = System.Drawing.SystemColors.Control
			controlBar1.Opacity = 0.9
			controlBar1.PositionMode = C1.Win.TouchToolKit.PositionMode.Fixed
			controlBar1.TransparentBackground = True
			Me.gcZoom1.ControlBars.Add(controlBar1)
			Me.gcZoom1.Target = Me
			' 
			' InputFormforControlBar
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(250, 371)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.textBox3)
			Me.Controls.Add(Me.textBox2)
			Me.Controls.Add(Me.textBox1)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "InputFormforControlBar"
			Me.Text = "InputFormforControlBar"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private textBox1 As System.Windows.Forms.TextBox
		Private textBox2 As System.Windows.Forms.TextBox
		Private textBox3 As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private button1 As System.Windows.Forms.Button
		Private gcZoom1 As C1.Win.TouchToolKit.C1Zoom
	End Class
End Namespace
