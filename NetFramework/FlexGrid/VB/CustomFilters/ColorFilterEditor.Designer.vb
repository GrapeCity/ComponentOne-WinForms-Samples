Namespace CustomFilters
	Partial Public Class ColorFilterEditor
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
			Me.panel1 = New Panel()
			Me.panel2 = New Panel()
			Me.panel3 = New Panel()
			Me.panel4 = New Panel()
			Me.panel5 = New Panel()
			Me.panel6 = New Panel()
			Me.panel7 = New Panel()
			Me.panel8 = New Panel()
			Me.panel9 = New Panel()
			Me.panel10 = New Panel()
			Me.panel11 = New Panel()
			Me.panel12 = New Panel()
			Me.label1 = New Label()
			Me._threshold = New NumericUpDown()
			Me.label2 = New Label()
			Me._target = New Panel()
			CType(Me._threshold, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BackColor = Color.Red
			Me.panel1.BorderStyle = BorderStyle.FixedSingle
			Me.panel1.Location = New Point(3, 3)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Size(60, 22)
			Me.panel1.TabIndex = 0
'			Me.panel1.Click += New System.EventHandler(Me.panel1_Click)
			' 
			' panel2
			' 
			Me.panel2.BackColor = Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(0))))))
			Me.panel2.BorderStyle = BorderStyle.FixedSingle
			Me.panel2.Location = New Point(69, 3)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New Size(60, 22)
			Me.panel2.TabIndex = 0
'			Me.panel2.Click += New System.EventHandler(Me.panel1_Click)
			' 
			' panel3
			' 
			Me.panel3.BackColor = Color.Blue
			Me.panel3.BorderStyle = BorderStyle.FixedSingle
			Me.panel3.Location = New Point(135, 3)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New Size(60, 22)
			Me.panel3.TabIndex = 0
'			Me.panel3.Click += New System.EventHandler(Me.panel1_Click)
			' 
			' panel4
			' 
			Me.panel4.BackColor = Color.Yellow
			Me.panel4.BorderStyle = BorderStyle.FixedSingle
			Me.panel4.Location = New Point(201, 3)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New Size(60, 22)
			Me.panel4.TabIndex = 0
'			Me.panel4.Click += New System.EventHandler(Me.panel1_Click)
			' 
			' panel5
			' 
			Me.panel5.BackColor = Color.White
			Me.panel5.BorderStyle = BorderStyle.FixedSingle
			Me.panel5.Location = New Point(3, 31)
			Me.panel5.Name = "panel5"
			Me.panel5.Size = New Size(60, 22)
			Me.panel5.TabIndex = 0
'			Me.panel5.Click += New System.EventHandler(Me.panel1_Click)
			' 
			' panel6
			' 
			Me.panel6.BackColor = Color.Silver
			Me.panel6.BorderStyle = BorderStyle.FixedSingle
			Me.panel6.Location = New Point(69, 31)
			Me.panel6.Name = "panel6"
			Me.panel6.Size = New Size(60, 22)
			Me.panel6.TabIndex = 0
'			Me.panel6.Click += New System.EventHandler(Me.panel1_Click)
			' 
			' panel7
			' 
			Me.panel7.BackColor = Color.Gray
			Me.panel7.BorderStyle = BorderStyle.FixedSingle
			Me.panel7.Location = New Point(135, 31)
			Me.panel7.Name = "panel7"
			Me.panel7.Size = New Size(60, 22)
			Me.panel7.TabIndex = 0
'			Me.panel7.Click += New System.EventHandler(Me.panel1_Click)
			' 
			' panel8
			' 
			Me.panel8.BackColor = Color.Black
			Me.panel8.BorderStyle = BorderStyle.FixedSingle
			Me.panel8.Location = New Point(201, 31)
			Me.panel8.Name = "panel8"
			Me.panel8.Size = New Size(60, 22)
			Me.panel8.TabIndex = 0
'			Me.panel8.Click += New System.EventHandler(Me.panel1_Click)
			' 
			' panel9
			' 
			Me.panel9.BackColor = Color.Gold
			Me.panel9.BorderStyle = BorderStyle.FixedSingle
			Me.panel9.Location = New Point(3, 59)
			Me.panel9.Name = "panel9"
			Me.panel9.Size = New Size(60, 22)
			Me.panel9.TabIndex = 0
'			Me.panel9.Click += New System.EventHandler(Me.panel1_Click)
			' 
			' panel10
			' 
			Me.panel10.BackColor = Color.PaleGoldenrod
			Me.panel10.BorderStyle = BorderStyle.FixedSingle
			Me.panel10.Location = New Point(69, 59)
			Me.panel10.Name = "panel10"
			Me.panel10.Size = New Size(60, 22)
			Me.panel10.TabIndex = 0
'			Me.panel10.Click += New System.EventHandler(Me.panel1_Click)
			' 
			' panel11
			' 
			Me.panel11.BackColor = Color.Orchid
			Me.panel11.BorderStyle = BorderStyle.FixedSingle
			Me.panel11.Location = New Point(135, 59)
			Me.panel11.Name = "panel11"
			Me.panel11.Size = New Size(60, 22)
			Me.panel11.TabIndex = 0
'			Me.panel11.Click += New System.EventHandler(Me.panel1_Click)
			' 
			' panel12
			' 
			Me.panel12.BackColor = Color.Thistle
			Me.panel12.BorderStyle = BorderStyle.FixedSingle
			Me.panel12.Location = New Point(201, 59)
			Me.panel12.Name = "panel12"
			Me.panel12.Size = New Size(60, 22)
			Me.panel12.TabIndex = 0
'			Me.panel12.Click += New System.EventHandler(Me.panel1_Click)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New Point(12, 133)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(76, 17)
			Me.label1.TabIndex = 1
			Me.label1.Text = "T&olerance:"
			' 
			' _threshold
			' 
			Me._threshold.Location = New Point(109, 131)
			Me._threshold.Maximum = New Decimal(New Integer() { 256, 0, 0, 0})
			Me._threshold.Name = "_threshold"
			Me._threshold.Size = New Size(136, 22)
			Me._threshold.TabIndex = 2
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New Point(12, 100)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(91, 17)
			Me.label2.TabIndex = 1
			Me.label2.Text = "&Target Color:"
			' 
			' _target
			' 
			Me._target.BackColor = Color.Gold
			Me._target.BorderStyle = BorderStyle.FixedSingle
			Me._target.Location = New Point(109, 98)
			Me._target.Name = "_target"
			Me._target.Size = New Size(136, 22)
			Me._target.TabIndex = 0
'			Me._target.Click += New System.EventHandler(Me._target_Click)
			' 
			' ColorFilterEditor
			' 
			Me.AutoScaleDimensions = New SizeF(8F, 16F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me._threshold)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.panel12)
			Me.Controls.Add(Me.panel8)
			Me.Controls.Add(Me.panel4)
			Me.Controls.Add(Me.panel11)
			Me.Controls.Add(Me.panel7)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel10)
			Me.Controls.Add(Me.panel6)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me._target)
			Me.Controls.Add(Me.panel9)
			Me.Controls.Add(Me.panel5)
			Me.Controls.Add(Me.panel1)
			Me.Name = "ColorFilterEditor"
			Me.Size = New Size(265, 167)
			CType(Me._threshold, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents panel1 As Panel
		Private WithEvents panel2 As Panel
		Private WithEvents panel3 As Panel
		Private WithEvents panel4 As Panel
		Private WithEvents panel5 As Panel
		Private WithEvents panel6 As Panel
		Private WithEvents panel7 As Panel
		Private WithEvents panel8 As Panel
		Private WithEvents panel9 As Panel
		Private WithEvents panel10 As Panel
		Private WithEvents panel11 As Panel
		Private WithEvents panel12 As Panel
		Private label1 As Label
		Private _threshold As NumericUpDown
		Private label2 As Label
		Private WithEvents _target As Panel
	End Class
End Namespace
