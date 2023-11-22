Namespace C1ZoomPages.Help_Forms
	Partial Class ShowControlForm
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
			Me.gcZoom1 = New C1.Win.TouchToolKit.C1Zoom(Me.components)
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.button2 = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.textBox3 = New System.Windows.Forms.TextBox()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gcZoom1
			' 
			Me.gcZoom1.AutoShowControl = True
			Me.gcZoom1.InnerPanelLayoutMode = C1.Win.TouchToolKit.InnerPanelLayoutMode.MiddleCenter
			Me.gcZoom1.MaxZoomFactor = 4F
			Me.gcZoom1.Target = Me
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BackColor = System.Drawing.Color.Blue
			Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
			Me.pictureBox1.Image = My.Resources.mescius_logo
			Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(580, 145)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' textBox1
			' 
			Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.textBox1.Location = New System.Drawing.Point(101, 210)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(422, 47)
			Me.textBox1.TabIndex = 1
			' 
			' button2
			' 
			Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.button2.Location = New System.Drawing.Point(354, 389)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(169, 54)
			Me.button2.TabIndex = 2
			Me.button2.Text = "Login"
			Me.button2.UseVisualStyleBackColor = True
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label1.Location = New System.Drawing.Point(12, 160)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(194, 39)
			Me.label1.TabIndex = 3
			Me.label1.Text = "UserName:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label2.Location = New System.Drawing.Point(12, 268)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(180, 39)
			Me.label2.TabIndex = 3
			Me.label2.Text = "Password:"
			' 
			' textBox3
			' 
			Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25F)
			Me.textBox3.Location = New System.Drawing.Point(101, 320)
			Me.textBox3.Name = "textBox3"
			Me.textBox3.Size = New System.Drawing.Size(422, 47)
			Me.textBox3.TabIndex = 4
			Me.textBox3.UseSystemPasswordChar = True
			' 
			' ShowControlForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 12F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(580, 464)
			Me.Controls.Add(Me.textBox3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.pictureBox1)
			Me.Name = "ShowControlForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "ShowControl"
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gcZoom1 As C1.Win.TouchToolKit.C1Zoom
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private button2 As System.Windows.Forms.Button
		Private textBox1 As System.Windows.Forms.TextBox
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private textBox3 As System.Windows.Forms.TextBox
	End Class
End Namespace
