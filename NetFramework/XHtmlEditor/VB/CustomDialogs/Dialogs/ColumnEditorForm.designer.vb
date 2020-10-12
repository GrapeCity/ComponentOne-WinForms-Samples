Partial Class ColumnEditorForm
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
		Me._gbxSpan = New System.Windows.Forms.GroupBox()
		Me._nudSpan = New System.Windows.Forms.NumericUpDown()
		Me._lblSpan = New System.Windows.Forms.Label()
		Me._gbxWidth = New System.Windows.Forms.GroupBox()
		Me._tbWidthValue = New System.Windows.Forms.NumericUpDown()
		Me._chkWidth = New System.Windows.Forms.CheckBox()
		Me._cbxWidthType = New System.Windows.Forms.ComboBox()
		Me._gbxAlignment = New System.Windows.Forms.GroupBox()
		Me._cbxHorizontalAlignment = New System.Windows.Forms.ComboBox()
		Me._cbxVerticalAlignment = New System.Windows.Forms.ComboBox()
		Me._lblHorizontalAlignment = New System.Windows.Forms.Label()
		Me._lblVerticalAlignment = New System.Windows.Forms.Label()
		Me._containerMain.SuspendLayout()
		Me._gbxSpan.SuspendLayout()
		DirectCast((Me._nudSpan), System.ComponentModel.ISupportInitialize).BeginInit()
		Me._gbxWidth.SuspendLayout()
		DirectCast((Me._tbWidthValue), System.ComponentModel.ISupportInitialize).BeginInit()
		Me._gbxAlignment.SuspendLayout()
		Me.SuspendLayout()
		' 
		' _btnOK
		' 
		Me._btnOK.Location = New System.Drawing.Point(255, 286)
		' 
		' _btnCancel
		' 
		Me._btnCancel.Location = New System.Drawing.Point(352, 286)
		' 
		' _btnAplly
		' 
		Me._btnAplly.Location = New System.Drawing.Point(449, 286)
		' 
		' _containerMain
		' 
		Me._containerMain.Controls.Add(Me._gbxSpan)
		Me._containerMain.Controls.Add(Me._gbxWidth)
		Me._containerMain.Controls.Add(Me._gbxAlignment)
		Me._containerMain.Size = New System.Drawing.Size(529, 268)
		' 
		' _gbxSpan
		' 
		Me._gbxSpan.Controls.Add(Me._nudSpan)
		Me._gbxSpan.Controls.Add(Me._lblSpan)
		Me._gbxSpan.Dock = System.Windows.Forms.DockStyle.Top
		Me._gbxSpan.Location = New System.Drawing.Point(3, 143)
		Me._gbxSpan.Name = "_gbxSpan"
		Me._gbxSpan.Size = New System.Drawing.Size(523, 52)
		Me._gbxSpan.TabIndex = 2
		Me._gbxSpan.TabStop = False
		Me._gbxSpan.Text = "Span"
		' 
		' _nudSpan
		' 
		Me._nudSpan.Location = New System.Drawing.Point(118, 20)
		Me._nudSpan.Name = "_nudSpan"
		Me._nudSpan.Size = New System.Drawing.Size(95, 21)
		Me._nudSpan.TabIndex = 1
		' 
		' _lblSpan
		' 
		Me._lblSpan.AutoSize = True
		Me._lblSpan.Location = New System.Drawing.Point(17, 22)
		Me._lblSpan.Name = "_lblSpan"
		Me._lblSpan.Size = New System.Drawing.Size(46, 13)
		Me._lblSpan.TabIndex = 0
		Me._lblSpan.Text = "&Column:"
		' 
		' _gbxWidth
		' 
		Me._gbxWidth.Controls.Add(Me._tbWidthValue)
		Me._gbxWidth.Controls.Add(Me._chkWidth)
		Me._gbxWidth.Controls.Add(Me._cbxWidthType)
		Me._gbxWidth.Dock = System.Windows.Forms.DockStyle.Top
		Me._gbxWidth.Location = New System.Drawing.Point(3, 92)
		Me._gbxWidth.Name = "_gbxWidth"
		Me._gbxWidth.Size = New System.Drawing.Size(523, 51)
		Me._gbxWidth.TabIndex = 1
		Me._gbxWidth.TabStop = False
		Me._gbxWidth.Text = "Size"
		' 
		' _tbWidthValue
		' 
		Me._tbWidthValue.Location = New System.Drawing.Point(118, 19)
		Me._tbWidthValue.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
		Me._tbWidthValue.Name = "_tbWidthValue"
		Me._tbWidthValue.Size = New System.Drawing.Size(95, 21)
		Me._tbWidthValue.TabIndex = 1
		Me._tbWidthValue.ThousandsSeparator = True
		' 
		' _chkWidth
		' 
		Me._chkWidth.AutoSize = True
		Me._chkWidth.Checked = True
		Me._chkWidth.CheckState = System.Windows.Forms.CheckState.Checked
		Me._chkWidth.Location = New System.Drawing.Point(20, 20)
		Me._chkWidth.Name = "_chkWidth"
		Me._chkWidth.Size = New System.Drawing.Size(94, 17)
		Me._chkWidth.TabIndex = 0
		Me._chkWidth.Text = "Specify &width:"
		Me._chkWidth.UseVisualStyleBackColor = True
		' 
		' _cbxWidthType
		' 
		Me._cbxWidthType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._cbxWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cbxWidthType.FormattingEnabled = True
		Me._cbxWidthType.Location = New System.Drawing.Point(219, 18)
		Me._cbxWidthType.Name = "_cbxWidthType"
		Me._cbxWidthType.Size = New System.Drawing.Size(291, 21)
		Me._cbxWidthType.TabIndex = 2
		' 
		' _gbxAlignment
		' 
		Me._gbxAlignment.Controls.Add(Me._cbxHorizontalAlignment)
		Me._gbxAlignment.Controls.Add(Me._cbxVerticalAlignment)
		Me._gbxAlignment.Controls.Add(Me._lblHorizontalAlignment)
		Me._gbxAlignment.Controls.Add(Me._lblVerticalAlignment)
		Me._gbxAlignment.Dock = System.Windows.Forms.DockStyle.Top
		Me._gbxAlignment.Location = New System.Drawing.Point(3, 17)
		Me._gbxAlignment.Name = "_gbxAlignment"
		Me._gbxAlignment.Size = New System.Drawing.Size(523, 75)
		Me._gbxAlignment.TabIndex = 0
		Me._gbxAlignment.TabStop = False
		Me._gbxAlignment.Text = "Alignment"
		' 
		' _cbxHorizontalAlignment
		' 
		Me._cbxHorizontalAlignment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._cbxHorizontalAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cbxHorizontalAlignment.FormattingEnabled = True
		Me._cbxHorizontalAlignment.Location = New System.Drawing.Point(118, 46)
		Me._cbxHorizontalAlignment.Name = "_cbxHorizontalAlignment"
		Me._cbxHorizontalAlignment.Size = New System.Drawing.Size(399, 21)
		Me._cbxHorizontalAlignment.TabIndex = 3
		' 
		' _cbxVerticalAlignment
		' 
		Me._cbxVerticalAlignment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._cbxVerticalAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cbxVerticalAlignment.FormattingEnabled = True
		Me._cbxVerticalAlignment.Location = New System.Drawing.Point(118, 19)
		Me._cbxVerticalAlignment.Name = "_cbxVerticalAlignment"
		Me._cbxVerticalAlignment.Size = New System.Drawing.Size(399, 21)
		Me._cbxVerticalAlignment.TabIndex = 1
		' 
		' _lblHorizontalAlignment
		' 
		Me._lblHorizontalAlignment.AutoSize = True
		Me._lblHorizontalAlignment.Location = New System.Drawing.Point(17, 49)
		Me._lblHorizontalAlignment.Name = "_lblHorizontalAlignment"
		Me._lblHorizontalAlignment.Size = New System.Drawing.Size(59, 13)
		Me._lblHorizontalAlignment.TabIndex = 2
		Me._lblHorizontalAlignment.Text = "&Horizontal:"
		' 
		' _lblVerticalAlignment
		' 
		Me._lblVerticalAlignment.AutoSize = True
		Me._lblVerticalAlignment.Location = New System.Drawing.Point(17, 22)
		Me._lblVerticalAlignment.Name = "_lblVerticalAlignment"
		Me._lblVerticalAlignment.Size = New System.Drawing.Size(46, 13)
		Me._lblVerticalAlignment.TabIndex = 0
		Me._lblVerticalAlignment.Text = "&Vertical:"
		' 
		' ColumnEditorForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.ClientSize = New System.Drawing.Size(553, 323)
		Me.MinimumSize = New System.Drawing.Size(561, 174)
		Me.Name = "ColumnEditorForm"
		Me.Text = "Column Properties"
		Me._containerMain.ResumeLayout(False)
		Me._gbxSpan.ResumeLayout(False)
		Me._gbxSpan.PerformLayout()
		DirectCast((Me._nudSpan), System.ComponentModel.ISupportInitialize).EndInit()
		Me._gbxWidth.ResumeLayout(False)
		Me._gbxWidth.PerformLayout()
		DirectCast((Me._tbWidthValue), System.ComponentModel.ISupportInitialize).EndInit()
		Me._gbxAlignment.ResumeLayout(False)
		Me._gbxAlignment.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private _gbxSpan As System.Windows.Forms.GroupBox
	Private _nudSpan As System.Windows.Forms.NumericUpDown
	Private _lblSpan As System.Windows.Forms.Label
	Private _gbxWidth As System.Windows.Forms.GroupBox
	Private _cbxWidthType As System.Windows.Forms.ComboBox
	Private _gbxAlignment As System.Windows.Forms.GroupBox
	Private _cbxHorizontalAlignment As System.Windows.Forms.ComboBox
	Private _cbxVerticalAlignment As System.Windows.Forms.ComboBox
	Private _lblHorizontalAlignment As System.Windows.Forms.Label
	Private _lblVerticalAlignment As System.Windows.Forms.Label
	Private _chkWidth As System.Windows.Forms.CheckBox
	Private _tbWidthValue As System.Windows.Forms.NumericUpDown

End Class
