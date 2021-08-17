
Namespace QuickStart
	Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">True if managed resources should be disposed; otherwise, False.</param>
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
            Me._c1FlexPivotPage = New C1.Win.FlexPivot.FlexPivotPage()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.radioButton4 = New System.Windows.Forms.RadioButton()
            Me.radioButton5 = New System.Windows.Forms.RadioButton()
            Me.radioButton6 = New System.Windows.Forms.RadioButton()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.radioButton3 = New System.Windows.Forms.RadioButton()
            Me.radioButton2 = New System.Windows.Forms.RadioButton()
            Me.radioButton1 = New System.Windows.Forms.RadioButton()
            Me.listBox1 = New System.Windows.Forms.ListBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.RadioButton7 = New System.Windows.Forms.RadioButton()
            CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            '_c1FlexPivotPage
            '
            Me._c1FlexPivotPage.Dock = System.Windows.Forms.DockStyle.Fill
            Me._c1FlexPivotPage.Location = New System.Drawing.Point(0, 139)
            Me._c1FlexPivotPage.Margin = New System.Windows.Forms.Padding(2)
            Me._c1FlexPivotPage.Name = "_c1FlexPivotPage"
            Me._c1FlexPivotPage.Size = New System.Drawing.Size(925, 438)
            Me._c1FlexPivotPage.TabIndex = 0
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.groupBox2)
            Me.panel1.Controls.Add(Me.groupBox1)
            Me.panel1.Controls.Add(Me.listBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(925, 139)
            Me.panel1.TabIndex = 1
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.Label7)
            Me.groupBox2.Controls.Add(Me.RadioButton7)
            Me.groupBox2.Controls.Add(Me.label4)
            Me.groupBox2.Controls.Add(Me.label5)
            Me.groupBox2.Controls.Add(Me.label6)
            Me.groupBox2.Controls.Add(Me.radioButton4)
            Me.groupBox2.Controls.Add(Me.radioButton5)
            Me.groupBox2.Controls.Add(Me.radioButton6)
            Me.groupBox2.Location = New System.Drawing.Point(268, 9)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(249, 119)
            Me.groupBox2.TabIndex = 1
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Use C1.DataEngine.Table"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(141, 69)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(0, 13)
            Me.label4.TabIndex = 5
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(141, 46)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(0, 13)
            Me.label5.TabIndex = 3
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(141, 23)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(0, 13)
            Me.label6.TabIndex = 1
            '
            'radioButton4
            '
            Me.radioButton4.AutoCheck = False
            Me.radioButton4.AutoSize = True
            Me.radioButton4.Location = New System.Drawing.Point(7, 67)
            Me.radioButton4.Name = "radioButton4"
            Me.radioButton4.Size = New System.Drawing.Size(113, 17)
            Me.radioButton4.TabIndex = 4
            Me.radioButton4.TabStop = True
            Me.radioButton4.Tag = "1000000"
            Me.radioButton4.Text = "1,000,000 rows"
            Me.radioButton4.UseVisualStyleBackColor = True
            '
            'radioButton5
            '
            Me.radioButton5.AutoCheck = False
            Me.radioButton5.AutoSize = True
            Me.radioButton5.Location = New System.Drawing.Point(7, 44)
            Me.radioButton5.Name = "radioButton5"
            Me.radioButton5.Size = New System.Drawing.Size(102, 17)
            Me.radioButton5.TabIndex = 2
            Me.radioButton5.TabStop = True
            Me.radioButton5.Tag = "500000"
            Me.radioButton5.Text = "500,000 rows"
            Me.radioButton5.UseVisualStyleBackColor = True
            '
            'radioButton6
            '
            Me.radioButton6.AutoCheck = False
            Me.radioButton6.AutoSize = True
            Me.radioButton6.Location = New System.Drawing.Point(7, 21)
            Me.radioButton6.Name = "radioButton6"
            Me.radioButton6.Size = New System.Drawing.Size(102, 17)
            Me.radioButton6.TabIndex = 0
            Me.radioButton6.TabStop = True
            Me.radioButton6.Tag = "100000"
            Me.radioButton6.Text = "100,000 rows"
            Me.radioButton6.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.radioButton3)
            Me.groupBox1.Controls.Add(Me.radioButton2)
            Me.groupBox1.Controls.Add(Me.radioButton1)
            Me.groupBox1.Location = New System.Drawing.Point(13, 9)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(249, 95)
            Me.groupBox1.TabIndex = 1
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Use System.Data.DataTable"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(141, 69)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(0, 13)
            Me.label3.TabIndex = 5
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(141, 46)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(0, 13)
            Me.label2.TabIndex = 3
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(141, 23)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(0, 13)
            Me.label1.TabIndex = 1
            '
            'radioButton3
            '
            Me.radioButton3.AutoCheck = False
            Me.radioButton3.AutoSize = True
            Me.radioButton3.Location = New System.Drawing.Point(7, 67)
            Me.radioButton3.Name = "radioButton3"
            Me.radioButton3.Size = New System.Drawing.Size(113, 17)
            Me.radioButton3.TabIndex = 4
            Me.radioButton3.TabStop = True
            Me.radioButton3.Tag = "1000000"
            Me.radioButton3.Text = "1,000,000 rows"
            Me.radioButton3.UseVisualStyleBackColor = True
            '
            'radioButton2
            '
            Me.radioButton2.AutoCheck = False
            Me.radioButton2.AutoSize = True
            Me.radioButton2.Location = New System.Drawing.Point(7, 44)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(102, 17)
            Me.radioButton2.TabIndex = 2
            Me.radioButton2.TabStop = True
            Me.radioButton2.Tag = "500000"
            Me.radioButton2.Text = "500,000 rows"
            Me.radioButton2.UseVisualStyleBackColor = True
            '
            'radioButton1
            '
            Me.radioButton1.AutoCheck = False
            Me.radioButton1.AutoSize = True
            Me.radioButton1.Location = New System.Drawing.Point(7, 21)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(102, 17)
            Me.radioButton1.TabIndex = 0
            Me.radioButton1.TabStop = True
            Me.radioButton1.Tag = "100000"
            Me.radioButton1.Text = "100,000 rows"
            Me.radioButton1.UseVisualStyleBackColor = True
            '
            'listBox1
            '
            Me.listBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.listBox1.FormattingEnabled = True
            Me.listBox1.Location = New System.Drawing.Point(541, 9)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(373, 121)
            Me.listBox1.TabIndex = 2
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(141, 92)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(0, 13)
            Me.Label7.TabIndex = 7
            '
            'RadioButton7
            '
            Me.RadioButton7.AutoCheck = False
            Me.RadioButton7.AutoSize = True
            Me.RadioButton7.Location = New System.Drawing.Point(7, 90)
            Me.RadioButton7.Name = "RadioButton7"
            Me.RadioButton7.Size = New System.Drawing.Size(113, 17)
            Me.RadioButton7.TabIndex = 6
            Me.RadioButton7.TabStop = True
            Me.RadioButton7.Tag = "5000000"
            Me.RadioButton7.Text = "5,000,000 rows"
            Me.RadioButton7.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(925, 577)
            Me.Controls.Add(Me._c1FlexPivotPage)
            Me.Controls.Add(Me.panel1)
            Me.Font = New System.Drawing.Font("Verdana", 8.25!)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "NorthWind Sales Data Analysis"
            CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private _c1FlexPivotPage As C1.Win.FlexPivot.FlexPivotPage
        Private panel1 As System.Windows.Forms.Panel
		Private listBox1 As System.Windows.Forms.ListBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private radioButton4 As System.Windows.Forms.RadioButton
		Private radioButton5 As System.Windows.Forms.RadioButton
		Private radioButton6 As System.Windows.Forms.RadioButton
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private radioButton3 As System.Windows.Forms.RadioButton
		Private radioButton2 As System.Windows.Forms.RadioButton
        Private radioButton1 As System.Windows.Forms.RadioButton
        Private WithEvents Label7 As System.Windows.Forms.Label
        Private WithEvents RadioButton7 As System.Windows.Forms.RadioButton
	End Class
End Namespace
