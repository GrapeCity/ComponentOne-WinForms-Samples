Partial Class FormattingForm
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary> 
	''' Disposes of the resources (other than memory) used by the System.Windows.Forms.Form.
	''' </summary>
	''' <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
	Protected Overloads Overrides Sub Dispose(disposing As Boolean)
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
		Me.btnOK = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me._cbInvisible = New System.Windows.Forms.CheckBox()
		Me._cbBold = New System.Windows.Forms.CheckBox()
		Me._cbItalic = New System.Windows.Forms.CheckBox()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me._rbNone = New System.Windows.Forms.RadioButton()
		Me._rbUnderline = New System.Windows.Forms.RadioButton()
		Me._rbStrikeout = New System.Windows.Forms.RadioButton()
		Me._rbOverline = New System.Windows.Forms.RadioButton()
		Me._tbSize = New System.Windows.Forms.TextBox()
		Me._tbTextColor = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me._cbFontFamily = New System.Windows.Forms.ComboBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.groupBox1.SuspendLayout()
		Me.groupBox3.SuspendLayout()
		Me.groupBox2.SuspendLayout()
		Me.SuspendLayout()
		' 
		' btnOK
		' 
		Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnOK.Location = New System.Drawing.Point(160, 220)
		Me.btnOK.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(85, 26)
		Me.btnOK.TabIndex = 1
		Me.btnOK.Text = "OK"
		Me.btnOK.UseVisualStyleBackColor = True
		' 
		' btnCancel
		' 
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(247, 220)
		Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(85, 26)
		Me.btnCancel.TabIndex = 2
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		' 
		' groupBox1
		' 
		Me.groupBox1.Controls.Add(Me.label1)
		Me.groupBox1.Controls.Add(Me.groupBox3)
		Me.groupBox1.Controls.Add(Me.groupBox2)
		Me.groupBox1.Controls.Add(Me._tbSize)
		Me.groupBox1.Controls.Add(Me._tbTextColor)
		Me.groupBox1.Controls.Add(Me.label3)
		Me.groupBox1.Controls.Add(Me._cbFontFamily)
		Me.groupBox1.Controls.Add(Me.label2)
		Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.groupBox1.Location = New System.Drawing.Point(9, 10)
		Me.groupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.groupBox1.Size = New System.Drawing.Size(323, 206)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = False
		Me.groupBox1.Text = "Font properties"
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.label1.Location = New System.Drawing.Point(13, 53)
		Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(30, 13)
		Me.label1.TabIndex = 2
		Me.label1.Text = "&Size:"
		' 
		' groupBox3
		' 
		Me.groupBox3.Controls.Add(Me._cbInvisible)
		Me.groupBox3.Controls.Add(Me._cbBold)
		Me.groupBox3.Controls.Add(Me._cbItalic)
		Me.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.groupBox3.Location = New System.Drawing.Point(7, 80)
		Me.groupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.groupBox3.Size = New System.Drawing.Size(146, 113)
		Me.groupBox3.TabIndex = 6
		Me.groupBox3.TabStop = False
		Me.groupBox3.Text = " Effects "
		' 
		' _cbInvisible
		' 
		Me._cbInvisible.AutoSize = True
		Me._cbInvisible.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me._cbInvisible.Location = New System.Drawing.Point(23, 67)
		Me._cbInvisible.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me._cbInvisible.Name = "_cbInvisible"
		Me._cbInvisible.Size = New System.Drawing.Size(70, 18)
		Me._cbInvisible.TabIndex = 2
		Me._cbInvisible.Text = "&In&visible"
		Me._cbInvisible.UseVisualStyleBackColor = True
		' 
		' _cbBold
		' 
		Me._cbBold.AutoSize = True
		Me._cbBold.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me._cbBold.Location = New System.Drawing.Point(23, 22)
		Me._cbBold.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me._cbBold.Name = "_cbBold"
		Me._cbBold.Size = New System.Drawing.Size(53, 18)
		Me._cbBold.TabIndex = 0
		Me._cbBold.Text = "&Bold"
		Me._cbBold.UseVisualStyleBackColor = True
		' 
		' _cbItalic
		' 
		Me._cbItalic.AutoSize = True
		Me._cbItalic.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me._cbItalic.Location = New System.Drawing.Point(23, 44)
		Me._cbItalic.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me._cbItalic.Name = "_cbItalic"
		Me._cbItalic.Size = New System.Drawing.Size(54, 18)
		Me._cbItalic.TabIndex = 1
		Me._cbItalic.Text = "&Italic"
		Me._cbItalic.UseVisualStyleBackColor = True
		' 
		' groupBox2
		' 
		Me.groupBox2.Controls.Add(Me._rbNone)
		Me.groupBox2.Controls.Add(Me._rbUnderline)
		Me.groupBox2.Controls.Add(Me._rbStrikeout)
		Me.groupBox2.Controls.Add(Me._rbOverline)
		Me.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.groupBox2.Location = New System.Drawing.Point(167, 80)
		Me.groupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.groupBox2.Size = New System.Drawing.Size(146, 113)
		Me.groupBox2.TabIndex = 7
		Me.groupBox2.TabStop = False
		Me.groupBox2.Text = " Text decoration "
		' 
		' _rbNone
		' 
		Me._rbNone.AutoSize = True
		Me._rbNone.Checked = True
		Me._rbNone.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me._rbNone.Location = New System.Drawing.Point(21, 88)
		Me._rbNone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me._rbNone.Name = "_rbNone"
		Me._rbNone.Size = New System.Drawing.Size(57, 18)
		Me._rbNone.TabIndex = 3
		Me._rbNone.TabStop = True
		Me._rbNone.Text = "&None"
		Me._rbNone.UseVisualStyleBackColor = True
		' 
		' _rbUnderline
		' 
		Me._rbUnderline.AutoSize = True
		Me._rbUnderline.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me._rbUnderline.Location = New System.Drawing.Point(20, 66)
		Me._rbUnderline.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me._rbUnderline.Name = "_rbUnderline"
		Me._rbUnderline.Size = New System.Drawing.Size(76, 18)
		Me._rbUnderline.TabIndex = 2
		Me._rbUnderline.Text = "&Underline"
		Me._rbUnderline.UseVisualStyleBackColor = True
		' 
		' _rbStrikeout
		' 
		Me._rbStrikeout.AutoSize = True
		Me._rbStrikeout.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me._rbStrikeout.Location = New System.Drawing.Point(21, 44)
		Me._rbStrikeout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me._rbStrikeout.Name = "_rbStrikeout"
		Me._rbStrikeout.Size = New System.Drawing.Size(73, 18)
		Me._rbStrikeout.TabIndex = 1
        Me._rbStrikeout.Text = "Stri&kethrough"
		Me._rbStrikeout.UseVisualStyleBackColor = True
		' 
		' _rbOverline
		' 
		Me._rbOverline.AutoSize = True
		Me._rbOverline.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me._rbOverline.Location = New System.Drawing.Point(21, 22)
		Me._rbOverline.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me._rbOverline.Name = "_rbOverline"
		Me._rbOverline.Size = New System.Drawing.Size(70, 18)
		Me._rbOverline.TabIndex = 0
		Me._rbOverline.Text = "&Overline"
		Me._rbOverline.UseVisualStyleBackColor = True
		' 
		' _tbSize
		' 
		Me._tbSize.Location = New System.Drawing.Point(77, 50)
		Me._tbSize.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me._tbSize.Name = "_tbSize"
		Me._tbSize.Size = New System.Drawing.Size(76, 20)
		Me._tbSize.TabIndex = 3
		' 
		' _cpTextColor
		' 
		Me._tbTextColor.Location = New System.Drawing.Point(223, 50)
		Me._tbTextColor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me._tbTextColor.Name = "_tbTextColor"
		Me._tbTextColor.Size = New System.Drawing.Size(92, 21)
		Me._tbTextColor.TabIndex = 5
		AddHandler Me._tbTextColor.Validated, New System.EventHandler(AddressOf _tbTextColor_Validated)
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.label3.Location = New System.Drawing.Point(165, 53)
		Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(57, 13)
		Me.label3.TabIndex = 4
		Me.label3.Text = "Text &color:"
		' 
		' _cbFontFamily
		' 
        Me._cbFontFamily.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me._cbFontFamily.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me._cbFontFamily.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me._cbFontFamily.FormattingEnabled = True
		Me._cbFontFamily.Location = New System.Drawing.Point(77, 20)
		Me._cbFontFamily.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me._cbFontFamily.Name = "_cbFontFamily"
		Me._cbFontFamily.Size = New System.Drawing.Size(237, 21)
		Me._cbFontFamily.TabIndex = 1
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.label2.Location = New System.Drawing.Point(13, 23)
		Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(60, 13)
		Me.label2.TabIndex = 0
		Me.label2.Text = "Font &family:"
		' 
		' FormattingForm
		' 
		Me.AcceptButton = Me.btnOK
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(343, 255)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnOK)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FormattingForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Formatting"
		Me.groupBox1.ResumeLayout(False)
		Me.groupBox1.PerformLayout()
		Me.groupBox3.ResumeLayout(False)
		Me.groupBox3.PerformLayout()
		Me.groupBox2.ResumeLayout(False)
		Me.groupBox2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private btnOK As System.Windows.Forms.Button
	Private btnCancel As System.Windows.Forms.Button
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private _cbItalic As System.Windows.Forms.CheckBox
	Private _cbBold As System.Windows.Forms.CheckBox
	Private label1 As System.Windows.Forms.Label
	Private _tbTextColor As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private _cbFontFamily As System.Windows.Forms.ComboBox
	Private label2 As System.Windows.Forms.Label
	Private _tbSize As System.Windows.Forms.TextBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private _rbOverline As System.Windows.Forms.RadioButton
	Private _rbNone As System.Windows.Forms.RadioButton
	Private _rbUnderline As System.Windows.Forms.RadioButton
	Private _rbStrikeout As System.Windows.Forms.RadioButton
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private _cbInvisible As System.Windows.Forms.CheckBox
End Class
