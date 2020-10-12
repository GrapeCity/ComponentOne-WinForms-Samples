Partial Class TaskInfoDialog
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
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.cbTask = New System.Windows.Forms.ComboBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.tbTaskName = New System.Windows.Forms.TextBox()
		Me.tbResource = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.tbStart = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.tbDuration = New System.Windows.Forms.TextBox()
		Me.tbPercentComplete = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label1.Location = New System.Drawing.Point(13, 67)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(70, 15)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Task Name:"
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label2.Location = New System.Drawing.Point(13, 96)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(62, 15)
		Me.label2.TabIndex = 0
		Me.label2.Text = "Resource:"
		' 
		' cbTask
		' 
		Me.cbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbTask.FormattingEnabled = True
		Me.cbTask.Location = New System.Drawing.Point(91, 12)
		Me.cbTask.Name = "cbTask"
		Me.cbTask.Size = New System.Drawing.Size(209, 23)
		Me.cbTask.TabIndex = 1
		AddHandler Me.cbTask.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbTask_SelectedIndexChanged)
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label3.Location = New System.Drawing.Point(13, 20)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(34, 15)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Task:"
		' 
		' tbTaskName
		' 
		Me.tbTaskName.Location = New System.Drawing.Point(91, 59)
		Me.tbTaskName.Name = "tbTaskName"
		Me.tbTaskName.[ReadOnly] = True
		Me.tbTaskName.Size = New System.Drawing.Size(209, 23)
		Me.tbTaskName.TabIndex = 3
		' 
		' tbResource
		' 
		Me.tbResource.Location = New System.Drawing.Point(91, 88)
		Me.tbResource.Name = "tbResource"
		Me.tbResource.[ReadOnly] = True
		Me.tbResource.Size = New System.Drawing.Size(209, 23)
		Me.tbResource.TabIndex = 3
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label4.Location = New System.Drawing.Point(13, 126)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(38, 15)
		Me.label4.TabIndex = 0
		Me.label4.Text = "Start:"
		' 
		' tbStart
		' 
		Me.tbStart.Location = New System.Drawing.Point(91, 118)
		Me.tbStart.Name = "tbStart"
		Me.tbStart.[ReadOnly] = True
		Me.tbStart.Size = New System.Drawing.Size(209, 23)
		Me.tbStart.TabIndex = 3
		' 
		' label5
		' 
		Me.label5.AutoSize = True
		Me.label5.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label5.Location = New System.Drawing.Point(12, 153)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(59, 15)
		Me.label5.TabIndex = 0
		Me.label5.Text = "Duration:"
		' 
		' tbDuration
		' 
		Me.tbDuration.Location = New System.Drawing.Point(91, 147)
		Me.tbDuration.Name = "tbDuration"
		Me.tbDuration.[ReadOnly] = True
		Me.tbDuration.Size = New System.Drawing.Size(209, 23)
		Me.tbDuration.TabIndex = 3
		' 
		' tbPercentComplete
		' 
		Me.tbPercentComplete.Location = New System.Drawing.Point(91, 176)
		Me.tbPercentComplete.Name = "tbPercentComplete"
		Me.tbPercentComplete.[ReadOnly] = True
		Me.tbPercentComplete.Size = New System.Drawing.Size(209, 23)
		Me.tbPercentComplete.TabIndex = 3
		' 
		' label6
		' 
		Me.label6.AutoSize = True
		Me.label6.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label6.Location = New System.Drawing.Point(13, 184)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(77, 15)
		Me.label6.TabIndex = 0
		Me.label6.Text = "% Complete:"
		' 
		' TaskInfoDialog
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(312, 209)
		Me.Controls.Add(Me.tbPercentComplete)
		Me.Controls.Add(Me.tbDuration)
		Me.Controls.Add(Me.tbStart)
		Me.Controls.Add(Me.tbResource)
		Me.Controls.Add(Me.tbTaskName)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.cbTask)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "TaskInfoDialog"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.Text = "Task Infomation"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.TaskInfoDialog_Load)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private cbTask As System.Windows.Forms.ComboBox
	Private label3 As System.Windows.Forms.Label
	Private tbTaskName As System.Windows.Forms.TextBox
	Private tbResource As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private tbStart As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private tbDuration As System.Windows.Forms.TextBox
	Private tbPercentComplete As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
End Class
