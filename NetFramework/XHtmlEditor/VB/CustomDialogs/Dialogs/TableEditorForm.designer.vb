Partial Class TableEditorForm
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
		Me.panel1 = New System.Windows.Forms.Panel()
		Me._tbSummary = New System.Windows.Forms.TextBox()
		Me._tbCaption = New System.Windows.Forms.TextBox()
		Me._lblSummary = New System.Windows.Forms.Label()
		Me._lblCaption = New System.Windows.Forms.Label()
		Me._gbxSize = New System.Windows.Forms.GroupBox()
		Me._tbWidthValue = New System.Windows.Forms.NumericUpDown()
		Me._chkWidth = New System.Windows.Forms.CheckBox()
		Me.lblColumnCount = New System.Windows.Forms.Label()
		Me._cbxWidthType = New System.Windows.Forms.ComboBox()
		Me._lblRowCount = New System.Windows.Forms.Label()
		Me._nudColumnCount = New System.Windows.Forms.NumericUpDown()
		Me._nudRowCount = New System.Windows.Forms.NumericUpDown()
		Me._gbxAlignment = New System.Windows.Forms.GroupBox()
		Me._lblCellPadding = New System.Windows.Forms.Label()
		Me._lblCellSpacing = New System.Windows.Forms.Label()
		Me._nudCellPadding = New System.Windows.Forms.NumericUpDown()
		Me._nudCellSpacing = New System.Windows.Forms.NumericUpDown()
		Me._gbxBorder = New System.Windows.Forms.GroupBox()
		Me._nudBorder = New System.Windows.Forms.NumericUpDown()
		Me._lblBorder = New System.Windows.Forms.Label()
		Me._containerMain.SuspendLayout()
		Me.panel1.SuspendLayout()
		Me._gbxSize.SuspendLayout()
		DirectCast((Me._tbWidthValue), System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast((Me._nudColumnCount), System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast((Me._nudRowCount), System.ComponentModel.ISupportInitialize).BeginInit()
		Me._gbxAlignment.SuspendLayout()
		DirectCast((Me._nudCellPadding), System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast((Me._nudCellSpacing), System.ComponentModel.ISupportInitialize).BeginInit()
		Me._gbxBorder.SuspendLayout()
		DirectCast((Me._nudBorder), System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' _btnOK
		' 
		Me._btnOK.Location = New System.Drawing.Point(256, 340)
		' 
		' _btnCancel
		' 
		Me._btnCancel.Location = New System.Drawing.Point(353, 340)
		' 
		' _btnAplly
		' 
		Me._btnAplly.Location = New System.Drawing.Point(450, 340)
		' 
		' _containerMain
		' 
		Me._containerMain.Controls.Add(Me._gbxBorder)
		Me._containerMain.Controls.Add(Me._gbxAlignment)
		Me._containerMain.Controls.Add(Me._gbxSize)
		Me._containerMain.Controls.Add(Me.panel1)
		Me._containerMain.Size = New System.Drawing.Size(529, 322)
		' 
		' panel1
		' 
		Me.panel1.Controls.Add(Me._tbSummary)
		Me.panel1.Controls.Add(Me._tbCaption)
		Me.panel1.Controls.Add(Me._lblSummary)
		Me.panel1.Controls.Add(Me._lblCaption)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(3, 17)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(523, 67)
		Me.panel1.TabIndex = 0
		' 
		' _tbSummary
		' 
		Me._tbSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._tbSummary.Location = New System.Drawing.Point(74, 36)
		Me._tbSummary.Name = "_tbSummary"
		Me._tbSummary.Size = New System.Drawing.Size(440, 21)
		Me._tbSummary.TabIndex = 3
		' 
		' _tbCaption
		' 
		Me._tbCaption.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._tbCaption.Location = New System.Drawing.Point(74, 9)
		Me._tbCaption.Name = "_tbCaption"
		Me._tbCaption.Size = New System.Drawing.Size(440, 21)
		Me._tbCaption.TabIndex = 1
		' 
		' _lblSummary
		' 
		Me._lblSummary.AutoSize = True
		Me._lblSummary.Location = New System.Drawing.Point(17, 39)
		Me._lblSummary.Name = "_lblSummary"
		Me._lblSummary.Size = New System.Drawing.Size(55, 13)
		Me._lblSummary.TabIndex = 2
		Me._lblSummary.Text = "S&ummary:"
		' 
		' _lblCaption
		' 
		Me._lblCaption.AutoSize = True
		Me._lblCaption.Location = New System.Drawing.Point(24, 12)
		Me._lblCaption.Name = "_lblCaption"
		Me._lblCaption.Size = New System.Drawing.Size(48, 13)
		Me._lblCaption.TabIndex = 0
		Me._lblCaption.Text = "C&aption:"
		' 
		' _gbxSize
		' 
		Me._gbxSize.Controls.Add(Me._tbWidthValue)
		Me._gbxSize.Controls.Add(Me._chkWidth)
		Me._gbxSize.Controls.Add(Me.lblColumnCount)
		Me._gbxSize.Controls.Add(Me._cbxWidthType)
		Me._gbxSize.Controls.Add(Me._lblRowCount)
		Me._gbxSize.Controls.Add(Me._nudColumnCount)
		Me._gbxSize.Controls.Add(Me._nudRowCount)
		Me._gbxSize.Dock = System.Windows.Forms.DockStyle.Top
		Me._gbxSize.Location = New System.Drawing.Point(3, 84)
		Me._gbxSize.Name = "_gbxSize"
		Me._gbxSize.Size = New System.Drawing.Size(523, 103)
		Me._gbxSize.TabIndex = 1
		Me._gbxSize.TabStop = False
		Me._gbxSize.Text = "Size"
		' 
		' _tbWidthValue
		' 
		Me._tbWidthValue.Location = New System.Drawing.Point(125, 74)
		Me._tbWidthValue.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
		Me._tbWidthValue.Name = "_tbWidthValue"
		Me._tbWidthValue.Size = New System.Drawing.Size(95, 21)
		Me._tbWidthValue.TabIndex = 5
		' 
		' _chkWidth
		' 
		Me._chkWidth.AutoSize = True
		Me._chkWidth.Checked = True
		Me._chkWidth.CheckState = System.Windows.Forms.CheckState.Checked
		Me._chkWidth.Location = New System.Drawing.Point(20, 75)
		Me._chkWidth.Name = "_chkWidth"
		Me._chkWidth.Size = New System.Drawing.Size(94, 17)
		Me._chkWidth.TabIndex = 4
		Me._chkWidth.Text = "Specify &width:"
		Me._chkWidth.UseVisualStyleBackColor = True
		' 
		' lblColumnCount
		' 
		Me.lblColumnCount.AutoSize = True
		Me.lblColumnCount.Location = New System.Drawing.Point(17, 22)
		Me.lblColumnCount.Name = "lblColumnCount"
		Me.lblColumnCount.Size = New System.Drawing.Size(102, 13)
		Me.lblColumnCount.TabIndex = 0
		Me.lblColumnCount.Text = "Number of &columns:"
		' 
		' _cbxWidthType
		' 
		Me._cbxWidthType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._cbxWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cbxWidthType.FormattingEnabled = True
		Me._cbxWidthType.Location = New System.Drawing.Point(224, 74)
		Me._cbxWidthType.Name = "_cbxWidthType"
		Me._cbxWidthType.Size = New System.Drawing.Size(290, 21)
		Me._cbxWidthType.TabIndex = 6
		' 
		' _lblRowCount
		' 
		Me._lblRowCount.AutoSize = True
		Me._lblRowCount.Location = New System.Drawing.Point(17, 49)
		Me._lblRowCount.Name = "_lblRowCount"
		Me._lblRowCount.Size = New System.Drawing.Size(87, 13)
		Me._lblRowCount.TabIndex = 2
		Me._lblRowCount.Text = "Number of &rows:"
		' 
		' _nudColumnCount
		' 
		Me._nudColumnCount.Location = New System.Drawing.Point(125, 20)
		Me._nudColumnCount.Name = "_nudColumnCount"
		Me._nudColumnCount.Size = New System.Drawing.Size(95, 21)
		Me._nudColumnCount.TabIndex = 1
		' 
		' _nudRowCount
		' 
		Me._nudRowCount.Location = New System.Drawing.Point(125, 47)
		Me._nudRowCount.Name = "_nudRowCount"
		Me._nudRowCount.Size = New System.Drawing.Size(95, 21)
		Me._nudRowCount.TabIndex = 3
		' 
		' _gbxAlignment
		' 
		Me._gbxAlignment.Controls.Add(Me._lblCellPadding)
		Me._gbxAlignment.Controls.Add(Me._lblCellSpacing)
		Me._gbxAlignment.Controls.Add(Me._nudCellPadding)
		Me._gbxAlignment.Controls.Add(Me._nudCellSpacing)
		Me._gbxAlignment.Dock = System.Windows.Forms.DockStyle.Top
		Me._gbxAlignment.Location = New System.Drawing.Point(3, 187)
		Me._gbxAlignment.Name = "_gbxAlignment"
		Me._gbxAlignment.Size = New System.Drawing.Size(523, 77)
		Me._gbxAlignment.TabIndex = 2
		Me._gbxAlignment.TabStop = False
		Me._gbxAlignment.Text = "Alignment"
		' 
		' _lblCellPadding
		' 
		Me._lblCellPadding.AutoSize = True
		Me._lblCellPadding.Location = New System.Drawing.Point(17, 49)
		Me._lblCellPadding.Name = "_lblCellPadding"
		Me._lblCellPadding.Size = New System.Drawing.Size(69, 13)
		Me._lblCellPadding.TabIndex = 2
		Me._lblCellPadding.Text = "Cell &padding:"
		' 
		' _lblCellSpacing
		' 
		Me._lblCellSpacing.AutoSize = True
		Me._lblCellSpacing.Location = New System.Drawing.Point(17, 22)
		Me._lblCellSpacing.Name = "_lblCellSpacing"
		Me._lblCellSpacing.Size = New System.Drawing.Size(67, 13)
		Me._lblCellSpacing.TabIndex = 0
		Me._lblCellSpacing.Text = "Cell &spacing:"
		' 
		' _nudCellPadding
		' 
		Me._nudCellPadding.Location = New System.Drawing.Point(125, 47)
		Me._nudCellPadding.Name = "_nudCellPadding"
		Me._nudCellPadding.Size = New System.Drawing.Size(95, 21)
		Me._nudCellPadding.TabIndex = 3
		' 
		' _nudCellSpacing
		' 
		Me._nudCellSpacing.Location = New System.Drawing.Point(125, 20)
		Me._nudCellSpacing.Name = "_nudCellSpacing"
		Me._nudCellSpacing.Size = New System.Drawing.Size(95, 21)
		Me._nudCellSpacing.TabIndex = 1
		' 
		' _gbxBorder
		' 
		Me._gbxBorder.Controls.Add(Me._nudBorder)
		Me._gbxBorder.Controls.Add(Me._lblBorder)
		Me._gbxBorder.Dock = System.Windows.Forms.DockStyle.Top
		Me._gbxBorder.Location = New System.Drawing.Point(3, 264)
		Me._gbxBorder.Name = "_gbxBorder"
		Me._gbxBorder.Size = New System.Drawing.Size(523, 49)
		Me._gbxBorder.TabIndex = 3
		Me._gbxBorder.TabStop = False
		Me._gbxBorder.Text = "Border"
		' 
		' _nudBorder
		' 
		Me._nudBorder.Location = New System.Drawing.Point(125, 20)
		Me._nudBorder.Name = "_nudBorder"
		Me._nudBorder.Size = New System.Drawing.Size(95, 21)
		Me._nudBorder.TabIndex = 1
		' 
		' _lblBorder
		' 
		Me._lblBorder.AutoSize = True
		Me._lblBorder.Location = New System.Drawing.Point(17, 22)
		Me._lblBorder.Name = "_lblBorder"
		Me._lblBorder.Size = New System.Drawing.Size(39, 13)
		Me._lblBorder.TabIndex = 0
		Me._lblBorder.Text = "Wi&dth:"
		' 
		' TableEditorForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.ClientSize = New System.Drawing.Size(553, 377)
		Me.MinimumSize = New System.Drawing.Size(561, 174)
		Me.Name = "TableEditorForm"
		Me.Text = "Table Properties"
		Me._containerMain.ResumeLayout(False)
		Me.panel1.ResumeLayout(False)
		Me.panel1.PerformLayout()
		Me._gbxSize.ResumeLayout(False)
		Me._gbxSize.PerformLayout()
		DirectCast((Me._tbWidthValue), System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast((Me._nudColumnCount), System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast((Me._nudRowCount), System.ComponentModel.ISupportInitialize).EndInit()
		Me._gbxAlignment.ResumeLayout(False)
		Me._gbxAlignment.PerformLayout()
		DirectCast((Me._nudCellPadding), System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast((Me._nudCellSpacing), System.ComponentModel.ISupportInitialize).EndInit()
		Me._gbxBorder.ResumeLayout(False)
		Me._gbxBorder.PerformLayout()
		DirectCast((Me._nudBorder), System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private panel1 As System.Windows.Forms.Panel
	Private _gbxBorder As System.Windows.Forms.GroupBox
	Private _nudBorder As System.Windows.Forms.NumericUpDown
	Private _lblBorder As System.Windows.Forms.Label
	Private _gbxAlignment As System.Windows.Forms.GroupBox
	Private _lblCellPadding As System.Windows.Forms.Label
	Private _lblCellSpacing As System.Windows.Forms.Label
	Private _nudCellPadding As System.Windows.Forms.NumericUpDown
	Private _nudCellSpacing As System.Windows.Forms.NumericUpDown
	Private _gbxSize As System.Windows.Forms.GroupBox
	Private _tbWidthValue As System.Windows.Forms.NumericUpDown
	Private _chkWidth As System.Windows.Forms.CheckBox
	Private lblColumnCount As System.Windows.Forms.Label
	Private _cbxWidthType As System.Windows.Forms.ComboBox
	Private _lblRowCount As System.Windows.Forms.Label
	Private _nudColumnCount As System.Windows.Forms.NumericUpDown
	Private _nudRowCount As System.Windows.Forms.NumericUpDown
	Private _tbSummary As System.Windows.Forms.TextBox
	Private _tbCaption As System.Windows.Forms.TextBox
	Private _lblSummary As System.Windows.Forms.Label
	Private _lblCaption As System.Windows.Forms.Label

End Class
