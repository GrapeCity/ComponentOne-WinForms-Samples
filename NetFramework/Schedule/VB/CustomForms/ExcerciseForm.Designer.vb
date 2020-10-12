Namespace TestSchedule
    Partial Class ExerciseForm
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExerciseForm))
			Me.cmbLabel = New System.Windows.Forms.ComboBox
			Me.cmbLocation = New System.Windows.Forms.ComboBox
			Me.lblLabel = New System.Windows.Forms.Label
			Me.lblLocation = New System.Windows.Forms.Label
			Me.lblSubject = New System.Windows.Forms.Label
			Me.pnTime = New System.Windows.Forms.Panel
			Me.tpEnd = New System.Windows.Forms.DateTimePicker
			Me.tpStart = New System.Windows.Forms.DateTimePicker
			Me.dpEnd = New System.Windows.Forms.DateTimePicker
			Me.dpStart = New System.Windows.Forms.DateTimePicker
			Me.lblEnd = New System.Windows.Forms.Label
			Me.lblStart = New System.Windows.Forms.Label
			Me.pnProps = New System.Windows.Forms.Panel
			Me.txtBody = New System.Windows.Forms.RichTextBox
			Me.toolStrip1 = New System.Windows.Forms.ToolStrip
			Me.btnSave = New System.Windows.Forms.ToolStripButton
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
			Me.btnDelete = New System.Windows.Forms.ToolStripButton
			Me.pnSubject = New System.Windows.Forms.Panel
			Me.cmbExercise = New System.Windows.Forms.ComboBox
			Me.label2 = New System.Windows.Forms.Label
			Me.label1 = New System.Windows.Forms.Label
			Me.cmbCategory = New System.Windows.Forms.ComboBox
			Me.cmbInstructor = New System.Windows.Forms.ComboBox
			Me.groupBox1 = New System.Windows.Forms.GroupBox
			Me.pnTime.SuspendLayout()
			Me.pnProps.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.pnSubject.SuspendLayout()
			Me.SuspendLayout()
			'
			'cmbLabel
			'
			Me.cmbLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbLabel.FormattingEnabled = True
			Me.cmbLabel.Location = New System.Drawing.Point(91, 181)
			Me.cmbLabel.Margin = New System.Windows.Forms.Padding(4)
			Me.cmbLabel.Name = "cmbLabel"
			Me.cmbLabel.Size = New System.Drawing.Size(304, 25)
			Me.cmbLabel.TabIndex = 9
			'
			'cmbLocation
			'
			Me.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbLocation.FormattingEnabled = True
			Me.cmbLocation.Location = New System.Drawing.Point(91, 52)
			Me.cmbLocation.Margin = New System.Windows.Forms.Padding(4)
			Me.cmbLocation.Name = "cmbLocation"
			Me.cmbLocation.Size = New System.Drawing.Size(304, 25)
			Me.cmbLocation.TabIndex = 3
			'
			'lblLabel
			'
			Me.lblLabel.AutoSize = True
			Me.lblLabel.Location = New System.Drawing.Point(10, 184)
			Me.lblLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.lblLabel.Name = "lblLabel"
			Me.lblLabel.Size = New System.Drawing.Size(44, 17)
			Me.lblLabel.TabIndex = 8
			Me.lblLabel.Text = "Le&vel:"
			'
			'lblLocation
			'
			Me.lblLocation.AutoSize = True
			Me.lblLocation.Location = New System.Drawing.Point(10, 55)
			Me.lblLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.lblLocation.Name = "lblLocation"
			Me.lblLocation.Size = New System.Drawing.Size(65, 17)
			Me.lblLocation.TabIndex = 2
			Me.lblLocation.Text = "&Location:"
			'
			'lblSubject
			'
			Me.lblSubject.AutoSize = True
			Me.lblSubject.Location = New System.Drawing.Point(10, 12)
			Me.lblSubject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.lblSubject.Name = "lblSubject"
			Me.lblSubject.Size = New System.Drawing.Size(70, 17)
			Me.lblSubject.TabIndex = 0
			Me.lblSubject.Text = "&Exercise:"
			'
			'pnTime
			'
			Me.pnTime.Controls.Add(Me.tpEnd)
			Me.pnTime.Controls.Add(Me.tpStart)
			Me.pnTime.Controls.Add(Me.dpEnd)
			Me.pnTime.Controls.Add(Me.dpStart)
			Me.pnTime.Controls.Add(Me.lblEnd)
			Me.pnTime.Controls.Add(Me.lblStart)
			Me.pnTime.Dock = System.Windows.Forms.DockStyle.Top
			Me.pnTime.Location = New System.Drawing.Point(0, 245)
			Me.pnTime.Margin = New System.Windows.Forms.Padding(4)
			Me.pnTime.Name = "pnTime"
			Me.pnTime.Size = New System.Drawing.Size(412, 77)
			Me.pnTime.TabIndex = 2
			'
			'tpEnd
			'
			Me.tpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
			Me.tpEnd.Location = New System.Drawing.Point(286, 45)
			Me.tpEnd.Margin = New System.Windows.Forms.Padding(4)
			Me.tpEnd.Name = "tpEnd"
			Me.tpEnd.ShowUpDown = True
			Me.tpEnd.Size = New System.Drawing.Size(109, 24)
			Me.tpEnd.TabIndex = 5
			'
			'tpStart
			'
			Me.tpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
			Me.tpStart.Location = New System.Drawing.Point(286, 11)
			Me.tpStart.Margin = New System.Windows.Forms.Padding(4)
			Me.tpStart.Name = "tpStart"
			Me.tpStart.ShowUpDown = True
			Me.tpStart.Size = New System.Drawing.Size(109, 24)
			Me.tpStart.TabIndex = 2
			'
			'dpEnd
			'
			Me.dpEnd.CustomFormat = "MM/dd/yyy"
			Me.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.dpEnd.Location = New System.Drawing.Point(90, 45)
			Me.dpEnd.Margin = New System.Windows.Forms.Padding(4)
			Me.dpEnd.Name = "dpEnd"
			Me.dpEnd.Size = New System.Drawing.Size(188, 24)
			Me.dpEnd.TabIndex = 4
			'
			'dpStart
			'
			Me.dpStart.CustomFormat = "MM/dd/yyy"
			Me.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.dpStart.Location = New System.Drawing.Point(90, 11)
			Me.dpStart.Margin = New System.Windows.Forms.Padding(4)
			Me.dpStart.Name = "dpStart"
			Me.dpStart.Size = New System.Drawing.Size(188, 24)
			Me.dpStart.TabIndex = 1
			'
			'lblEnd
			'
			Me.lblEnd.AutoSize = True
			Me.lblEnd.Location = New System.Drawing.Point(10, 50)
			Me.lblEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.lblEnd.Name = "lblEnd"
			Me.lblEnd.Size = New System.Drawing.Size(67, 17)
			Me.lblEnd.TabIndex = 3
			Me.lblEnd.Text = "En&d time:"
			'
			'lblStart
			'
			Me.lblStart.AutoSize = True
			Me.lblStart.Location = New System.Drawing.Point(10, 16)
			Me.lblStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.lblStart.Name = "lblStart"
			Me.lblStart.Size = New System.Drawing.Size(73, 17)
			Me.lblStart.TabIndex = 0
			Me.lblStart.Text = "Start &time:"
			'
			'pnProps
			'
			Me.pnProps.Controls.Add(Me.txtBody)
			Me.pnProps.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pnProps.Location = New System.Drawing.Point(0, 322)
			Me.pnProps.Margin = New System.Windows.Forms.Padding(4)
			Me.pnProps.Name = "pnProps"
			Me.pnProps.Size = New System.Drawing.Size(412, 115)
			Me.pnProps.TabIndex = 4
			'
			'txtBody
			'
			Me.txtBody.Dock = System.Windows.Forms.DockStyle.Fill
			Me.txtBody.Location = New System.Drawing.Point(0, 0)
			Me.txtBody.Margin = New System.Windows.Forms.Padding(4)
			Me.txtBody.Name = "txtBody"
			Me.txtBody.Size = New System.Drawing.Size(412, 115)
			Me.txtBody.TabIndex = 3
			Me.txtBody.Text = ""
			'
			'toolStrip1
			'
			Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.toolStripSeparator1, Me.btnDelete})
			Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
			Me.toolStrip1.Size = New System.Drawing.Size(412, 25)
			Me.toolStrip1.TabIndex = 0
			Me.toolStrip1.Text = "toolStrip1"
			'
			'btnSave
			'
			Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New System.Drawing.Size(112, 22)
			Me.btnSave.Text = "&Save and Close"
			'
			'toolStripSeparator1
			'
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
			'
			'btnDelete
			'
			Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnDelete.Name = "btnDelete"
			Me.btnDelete.Size = New System.Drawing.Size(53, 22)
			Me.btnDelete.Text = "Delete"
			'
			'pnSubject
			'
			Me.pnSubject.Controls.Add(Me.cmbExercise)
			Me.pnSubject.Controls.Add(Me.label2)
			Me.pnSubject.Controls.Add(Me.label1)
			Me.pnSubject.Controls.Add(Me.cmbCategory)
			Me.pnSubject.Controls.Add(Me.cmbInstructor)
			Me.pnSubject.Controls.Add(Me.cmbLabel)
			Me.pnSubject.Controls.Add(Me.groupBox1)
			Me.pnSubject.Controls.Add(Me.lblSubject)
			Me.pnSubject.Controls.Add(Me.lblLocation)
			Me.pnSubject.Controls.Add(Me.cmbLocation)
			Me.pnSubject.Controls.Add(Me.lblLabel)
			Me.pnSubject.Dock = System.Windows.Forms.DockStyle.Top
			Me.pnSubject.Location = New System.Drawing.Point(0, 25)
			Me.pnSubject.Margin = New System.Windows.Forms.Padding(4)
			Me.pnSubject.Name = "pnSubject"
			Me.pnSubject.Size = New System.Drawing.Size(412, 220)
			Me.pnSubject.TabIndex = 1
			'
			'cmbExercise
			'
			Me.cmbExercise.FormattingEnabled = True
			Me.cmbExercise.Items.AddRange(New Object() {"LA Spin ", "Aerobics", "Yoga ", "Body Pump", "Pilates", "Abs and Back Workout", "Combat Kickboxing", "Kids Parties", "Swimming Lessons", "Dance Cardio Funk", "Swim Time", "Yoga Kundalini", "Swimming", "Step", "Aerobics", "Yoga Fusion", "LA Water Aerobics", "Dance Salsa", "Tai Chi", "Combat Fight", "Body Combat", "Circuit", "Synergize", "LA Core Stability", "Combat Tae Kwon Do"})
			Me.cmbExercise.Location = New System.Drawing.Point(91, 9)
			Me.cmbExercise.Margin = New System.Windows.Forms.Padding(4)
			Me.cmbExercise.Name = "cmbExercise"
			Me.cmbExercise.Size = New System.Drawing.Size(304, 25)
			Me.cmbExercise.TabIndex = 1
			'
			'label2
			'
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(10, 141)
			Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(70, 17)
			Me.label2.TabIndex = 6
			Me.label2.Text = "&Category:"
			'
			'label1
			'
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(10, 98)
			Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(74, 17)
			Me.label1.TabIndex = 4
			Me.label1.Text = "&Instructor:"
			'
			'cmbCategory
			'
			Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbCategory.FormattingEnabled = True
			Me.cmbCategory.Location = New System.Drawing.Point(91, 138)
			Me.cmbCategory.Margin = New System.Windows.Forms.Padding(4)
			Me.cmbCategory.Name = "cmbCategory"
			Me.cmbCategory.Size = New System.Drawing.Size(304, 25)
			Me.cmbCategory.TabIndex = 7
			'
			'cmbInstructor
			'
			Me.cmbInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbInstructor.FormattingEnabled = True
			Me.cmbInstructor.Location = New System.Drawing.Point(91, 95)
			Me.cmbInstructor.Margin = New System.Windows.Forms.Padding(4)
			Me.cmbInstructor.Name = "cmbInstructor"
			Me.cmbInstructor.Size = New System.Drawing.Size(304, 25)
			Me.cmbInstructor.TabIndex = 5
			'
			'groupBox1
			'
			Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.groupBox1.Location = New System.Drawing.Point(0, 218)
			Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
			Me.groupBox1.Size = New System.Drawing.Size(412, 2)
			Me.groupBox1.TabIndex = 13
			Me.groupBox1.TabStop = False
			'
			'ExerciseForm
			'
			Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
			Me.AutoSize = True
			Me.ClientSize = New System.Drawing.Size(412, 437)
			Me.Controls.Add(Me.pnProps)
			Me.Controls.Add(Me.pnTime)
			Me.Controls.Add(Me.pnSubject)
			Me.Controls.Add(Me.toolStrip1)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.MinimumSize = New System.Drawing.Size(300, 300)
			Me.Name = "ExerciseForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Exercise"
			Me.pnTime.ResumeLayout(False)
			Me.pnTime.PerformLayout()
			Me.pnProps.ResumeLayout(False)
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.pnSubject.ResumeLayout(False)
			Me.pnSubject.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

#End Region

        Friend WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
        Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
        Friend WithEvents cmbLabel As System.Windows.Forms.ComboBox
        Friend WithEvents cmbLocation As System.Windows.Forms.ComboBox
        Friend WithEvents lblLabel As System.Windows.Forms.Label
        Friend WithEvents lblLocation As System.Windows.Forms.Label
        Friend WithEvents lblSubject As System.Windows.Forms.Label
        Friend WithEvents pnTime As System.Windows.Forms.Panel
        Friend WithEvents tpEnd As System.Windows.Forms.DateTimePicker
        Friend WithEvents tpStart As System.Windows.Forms.DateTimePicker
        Friend WithEvents dpEnd As System.Windows.Forms.DateTimePicker
        Friend WithEvents dpStart As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblEnd As System.Windows.Forms.Label
        Friend WithEvents lblStart As System.Windows.Forms.Label
        Friend WithEvents pnProps As System.Windows.Forms.Panel
        Friend WithEvents txtBody As System.Windows.Forms.RichTextBox
        Friend WithEvents pnSubject As System.Windows.Forms.Panel
        Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cmbExercise As System.Windows.Forms.ComboBox
        Friend WithEvents label2 As System.Windows.Forms.Label
        Friend WithEvents label1 As System.Windows.Forms.Label
        Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
        Friend WithEvents cmbInstructor As System.Windows.Forms.ComboBox
    End Class
End Namespace
