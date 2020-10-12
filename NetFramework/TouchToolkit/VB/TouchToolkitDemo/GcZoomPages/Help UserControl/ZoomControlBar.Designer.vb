Namespace C1ZoomPages.Help_Forms
	Partial Class ControlBarUserControl02
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
			Me.components = New System.ComponentModel.Container()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button5 = New System.Windows.Forms.Button()
			Me.button6 = New System.Windows.Forms.Button()
			Me.button7 = New System.Windows.Forms.Button()
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.myTrackBar1 = New C1ZoomPages.Help_Forms.MyTrackBar()
			Me.gcZoomCommandProvider1 = New C1.Win.TouchToolKit.C1ZoomCommandProvider(Me.components)
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.Color.White
			Me.button1.FlatAppearance.BorderSize = 3
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button1.Font = New System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.button1.ForeColor = System.Drawing.Color.Black
			Me.button1.Location = New System.Drawing.Point(101, 172)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(40, 36)
			Me.button1.TabIndex = 3
			Me.button1.Text = "-"
			Me.toolTip1.SetToolTip(Me.button1, "ZoomOut")
			Me.button1.UseVisualStyleBackColor = False
			Me.gcZoomCommandProvider1.SetZoomCommands(Me.button1, C1.Win.TouchToolKit.ZoomCommands.ZoomOut)
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.Color.White
			Me.button2.FlatAppearance.BorderSize = 3
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button2.Font = New System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.button2.ForeColor = System.Drawing.Color.Black
			Me.button2.Location = New System.Drawing.Point(101, 420)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(40, 36)
			Me.button2.TabIndex = 4
			Me.button2.Text = "+"
			Me.toolTip1.SetToolTip(Me.button2, "ZoomIn")
			Me.button2.UseVisualStyleBackColor = False
			Me.gcZoomCommandProvider1.SetZoomCommands(Me.button2, C1.Win.TouchToolKit.ZoomCommands.ZoomIn)
			' 
			' button4
			' 
			Me.button4.BackColor = System.Drawing.Color.White
			Me.button4.FlatAppearance.BorderSize = 3
			Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button4.Font = New System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(2))
			Me.button4.ForeColor = System.Drawing.Color.Black
			Me.button4.Location = New System.Drawing.Point(101, 129)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(40, 37)
			Me.button4.TabIndex = 5
			Me.button4.Text = ""
			Me.toolTip1.SetToolTip(Me.button4, "ScrollDown")
			Me.button4.UseVisualStyleBackColor = False
			Me.gcZoomCommandProvider1.SetZoomCommands(Me.button4, C1.Win.TouchToolKit.ZoomCommands.ScrollDown)
			' 
			' button5
			' 
			Me.button5.BackColor = System.Drawing.Color.White
			Me.button5.FlatAppearance.BorderSize = 3
			Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button5.Font = New System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(2))
			Me.button5.ForeColor = System.Drawing.Color.Black
			Me.button5.Location = New System.Drawing.Point(147, 87)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(40, 37)
			Me.button5.TabIndex = 6
			Me.button5.Text = ""
			Me.toolTip1.SetToolTip(Me.button5, "ScrollRight")
			Me.button5.UseVisualStyleBackColor = False
			Me.gcZoomCommandProvider1.SetZoomCommands(Me.button5, C1.Win.TouchToolKit.ZoomCommands.ScrollRight)
			' 
			' button6
			' 
			Me.button6.BackColor = System.Drawing.Color.White
			Me.button6.FlatAppearance.BorderSize = 3
			Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button6.Font = New System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(2))
			Me.button6.ForeColor = System.Drawing.Color.Black
			Me.button6.Location = New System.Drawing.Point(55, 87)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(40, 37)
			Me.button6.TabIndex = 7
			Me.button6.Text = ""
			Me.toolTip1.SetToolTip(Me.button6, "ScrollLeft")
			Me.button6.UseVisualStyleBackColor = False
			Me.gcZoomCommandProvider1.SetZoomCommands(Me.button6, C1.Win.TouchToolKit.ZoomCommands.ScrollLeft)
			' 
			' button7
			' 
			Me.button7.BackColor = System.Drawing.Color.White
			Me.button7.FlatAppearance.BorderSize = 3
			Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button7.Font = New System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(2))
			Me.button7.ForeColor = System.Drawing.Color.Black
			Me.button7.Location = New System.Drawing.Point(101, 44)
			Me.button7.Name = "button7"
			Me.button7.Size = New System.Drawing.Size(40, 37)
			Me.button7.TabIndex = 8
			Me.button7.Text = ""
			Me.toolTip1.SetToolTip(Me.button7, "ScrollUp")
			Me.button7.UseVisualStyleBackColor = False
			Me.gcZoomCommandProvider1.SetZoomCommands(Me.button7, C1.Win.TouchToolKit.ZoomCommands.ScrollUp)
			' 
			' toolTip1
			' 
			Me.toolTip1.ShowAlways = True
			' 
			' myTrackBar1
			' 
			Me.myTrackBar1.Location = New System.Drawing.Point(91, 215)
			Me.myTrackBar1.MaxValue = 4F
			Me.myTrackBar1.MinValue = 1F
			Me.myTrackBar1.Name = "myTrackBar1"
			Me.myTrackBar1.Size = New System.Drawing.Size(60, 205)
			Me.myTrackBar1.TabIndex = 9
			Me.myTrackBar1.Value = 1F
			' 
			' gcZoomCommandProvider1
			' 
			Me.gcZoomCommandProvider1.Target = Me
			' 
			' ControlBarUserControl02
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 12F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.myTrackBar1)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button4)
			Me.Controls.Add(Me.button5)
			Me.Controls.Add(Me.button6)
			Me.Controls.Add(Me.button7)
			Me.Name = "ControlBarUserControl02"
			Me.Size = New System.Drawing.Size(238, 494)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private toolTip1 As System.Windows.Forms.ToolTip
		Private button2 As System.Windows.Forms.Button
		Private button1 As System.Windows.Forms.Button
		Private button4 As System.Windows.Forms.Button
		Private button5 As System.Windows.Forms.Button
		Private button6 As System.Windows.Forms.Button
		Private button7 As System.Windows.Forms.Button
		Private myTrackBar1 As MyTrackBar
		Private gcZoomCommandProvider1 As C1.Win.TouchToolKit.C1ZoomCommandProvider
	End Class
End Namespace
