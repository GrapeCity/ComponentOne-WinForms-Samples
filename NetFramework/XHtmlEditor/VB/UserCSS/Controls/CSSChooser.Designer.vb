Namespace Controls
	Partial Class CSSChooser
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overloads Overrides Sub Dispose(disposing As Boolean)
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
			Me.lblFileName = New System.Windows.Forms.Label()
			Me.btnBrowse = New System.Windows.Forms.Button()
			Me.btnApplyCSS = New System.Windows.Forms.Button()
			Me.tbCustomDesignCSS = New System.Windows.Forms.TextBox()
			Me.rbFileDesignCSS = New System.Windows.Forms.RadioButton()
			Me.rbCustomDesignCSS = New System.Windows.Forms.RadioButton()
			Me.rbNoDesignCSS = New System.Windows.Forms.RadioButton()
			Me.SuspendLayout()
			' 
			' lblFileName
			' 
			Me.lblFileName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me.lblFileName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
			Me.lblFileName.Location = New System.Drawing.Point(24, 45)
			Me.lblFileName.Name = "lblFileName"
			Me.lblFileName.Size = New System.Drawing.Size(143, 43)
			Me.lblFileName.TabIndex = 13
			' 
			' btnBrowse
			' 
			Me.btnBrowse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me.btnBrowse.Enabled = False
			Me.btnBrowse.Location = New System.Drawing.Point(110, 23)
			Me.btnBrowse.Name = "btnBrowse"
			Me.btnBrowse.Size = New System.Drawing.Size(63, 20)
			Me.btnBrowse.TabIndex = 12
			Me.btnBrowse.Text = "Browse..."
			Me.btnBrowse.UseVisualStyleBackColor = True
			AddHandler Me.btnBrowse.Click, New System.EventHandler(AddressOf Me.btnBrowse_Click)
			' 
			' btnApplyCSS
			' 
			Me.btnApplyCSS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles)
			Me.btnApplyCSS.Location = New System.Drawing.Point(0, 179)
			Me.btnApplyCSS.Name = "btnApplyCSS"
			Me.btnApplyCSS.Size = New System.Drawing.Size(115, 26)
			Me.btnApplyCSS.TabIndex = 11
			Me.btnApplyCSS.Text = "Apply Custom CSS"
			Me.btnApplyCSS.UseVisualStyleBackColor = True
			AddHandler Me.btnApplyCSS.Click, New System.EventHandler(AddressOf Me.btnApplyCSS_Click)
			' 
			' tbCustomDesignCSS
			' 
			Me.tbCustomDesignCSS.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me.tbCustomDesignCSS.Enabled = False
			Me.tbCustomDesignCSS.Location = New System.Drawing.Point(3, 114)
			Me.tbCustomDesignCSS.Multiline = True
			Me.tbCustomDesignCSS.Name = "tbCustomDesignCSS"
			Me.tbCustomDesignCSS.Size = New System.Drawing.Size(170, 62)
			Me.tbCustomDesignCSS.TabIndex = 10
			' 
			' rbFileDesignCSS
			' 
			Me.rbFileDesignCSS.AutoSize = True
			Me.rbFileDesignCSS.Location = New System.Drawing.Point(4, 25)
			Me.rbFileDesignCSS.Name = "rbFileDesignCSS"
			Me.rbFileDesignCSS.Size = New System.Drawing.Size(85, 17)
			Me.rbFileDesignCSS.TabIndex = 9
			Me.rbFileDesignCSS.Text = "CSS from file"
			Me.rbFileDesignCSS.UseVisualStyleBackColor = True
			AddHandler Me.rbFileDesignCSS.CheckedChanged, New System.EventHandler(AddressOf Me.rbFileDesignCSS_CheckedChanged)
			' 
			' rbCustomDesignCSS
			' 
			Me.rbCustomDesignCSS.AutoSize = True
			Me.rbCustomDesignCSS.Location = New System.Drawing.Point(4, 91)
			Me.rbCustomDesignCSS.Name = "rbCustomDesignCSS"
			Me.rbCustomDesignCSS.Size = New System.Drawing.Size(120, 17)
			Me.rbCustomDesignCSS.TabIndex = 8
			Me.rbCustomDesignCSS.Text = "CSS from text below"
			Me.rbCustomDesignCSS.UseVisualStyleBackColor = True
			AddHandler Me.rbCustomDesignCSS.CheckedChanged, New System.EventHandler(AddressOf Me.rbCustomDesignCSS_CheckedChanged)
			' 
			' rbNoDesignCSS
			' 
			Me.rbNoDesignCSS.AutoSize = True
			Me.rbNoDesignCSS.Checked = True
			Me.rbNoDesignCSS.Location = New System.Drawing.Point(4, 2)
			Me.rbNoDesignCSS.Name = "rbNoDesignCSS"
			Me.rbNoDesignCSS.Size = New System.Drawing.Size(63, 17)
			Me.rbNoDesignCSS.TabIndex = 7
			Me.rbNoDesignCSS.TabStop = True
			Me.rbNoDesignCSS.Text = "No CSS"
			Me.rbNoDesignCSS.UseVisualStyleBackColor = True
			AddHandler Me.rbNoDesignCSS.CheckedChanged, New System.EventHandler(AddressOf Me.rbNoDesignCSS_CheckedChanged)
			' 
			' CSSChooser
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.lblFileName)
			Me.Controls.Add(Me.btnBrowse)
			Me.Controls.Add(Me.btnApplyCSS)
			Me.Controls.Add(Me.tbCustomDesignCSS)
			Me.Controls.Add(Me.rbFileDesignCSS)
			Me.Controls.Add(Me.rbCustomDesignCSS)
			Me.Controls.Add(Me.rbNoDesignCSS)
			Me.Name = "CSSChooser"
			Me.Size = New System.Drawing.Size(176, 211)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lblFileName As System.Windows.Forms.Label
		Private btnBrowse As System.Windows.Forms.Button
		Private btnApplyCSS As System.Windows.Forms.Button
		Private tbCustomDesignCSS As System.Windows.Forms.TextBox
		Private rbFileDesignCSS As System.Windows.Forms.RadioButton
		Private rbCustomDesignCSS As System.Windows.Forms.RadioButton
		Private rbNoDesignCSS As System.Windows.Forms.RadioButton
	End Class
End Namespace
