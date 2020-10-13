Partial Class ImageEditorForm
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me._cgbxImage = New System.Windows.Forms.Panel()
		Me._tbAlternate = New System.Windows.Forms.TextBox()
		Me._lblAlternate = New System.Windows.Forms.Label()
		Me._lblPath = New System.Windows.Forms.Label()
		Me._tbSource = New System.Windows.Forms.TextBox()
		Me._btnSelectImageSource = New System.Windows.Forms.Button()
		Me._cgbxSize = New System.Windows.Forms.GroupBox()
		Me._tbHeightValue = New System.Windows.Forms.NumericUpDown()
		Me._chkHeight = New System.Windows.Forms.CheckBox()
		Me._tbWidthValue = New System.Windows.Forms.NumericUpDown()
		Me._chkWidth = New System.Windows.Forms.CheckBox()
		Me._cbxWidthType = New System.Windows.Forms.ComboBox()
		Me._cbxHeightType = New System.Windows.Forms.ComboBox()
		Me._cgbxPreview = New System.Windows.Forms.GroupBox()
		Me._pbSourceImage = New System.Windows.Forms.PictureBox()
		Me._containerMain.SuspendLayout()
		Me._cgbxImage.SuspendLayout()
		Me._cgbxSize.SuspendLayout()
		DirectCast((Me._tbHeightValue), System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast((Me._tbWidthValue), System.ComponentModel.ISupportInitialize).BeginInit()
		Me._cgbxPreview.SuspendLayout()
		DirectCast((Me._pbSourceImage), System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' _btnOK
		' 
		Me._btnOK.Location = New System.Drawing.Point(240, 319)
		' 
		' _btnCancel
		' 
		Me._btnCancel.Location = New System.Drawing.Point(337, 319)
		' 
		' _btnAplly
		' 
		Me._btnAplly.Location = New System.Drawing.Point(434, 319)
		' 
		' _containerMain
		' 
		Me._containerMain.Controls.Add(Me._cgbxPreview)
		Me._containerMain.Controls.Add(Me._cgbxSize)
		Me._containerMain.Controls.Add(Me._cgbxImage)
		Me._containerMain.Size = New System.Drawing.Size(513, 301)
		' 
		' _cgbxImage
		' 
		Me._cgbxImage.Controls.Add(Me._tbAlternate)
		Me._cgbxImage.Controls.Add(Me._lblAlternate)
		Me._cgbxImage.Controls.Add(Me._lblPath)
		Me._cgbxImage.Controls.Add(Me._tbSource)
		Me._cgbxImage.Controls.Add(Me._btnSelectImageSource)
		Me._cgbxImage.Dock = System.Windows.Forms.DockStyle.Top
		Me._cgbxImage.Location = New System.Drawing.Point(3, 17)
		Me._cgbxImage.Name = "_cgbxImage"
		Me._cgbxImage.Size = New System.Drawing.Size(507, 73)
		Me._cgbxImage.TabIndex = 0
		Me._cgbxImage.Text = "&Path"
		' 
		' _tbAlternate
		' 
		Me._tbAlternate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._tbAlternate.Location = New System.Drawing.Point(96, 39)
		Me._tbAlternate.Name = "_tbAlternate"
		Me._tbAlternate.Size = New System.Drawing.Size(401, 21)
		Me._tbAlternate.TabIndex = 5
		' 
		' _lblAlternate
		' 
		Me._lblAlternate.AutoSize = True
		Me._lblAlternate.Location = New System.Drawing.Point(3, 42)
		Me._lblAlternate.Name = "_lblAlternate"
		Me._lblAlternate.Size = New System.Drawing.Size(87, 13)
		Me._lblAlternate.TabIndex = 4
		Me._lblAlternate.Text = "&Alternative text:"
		' 
		' _lblPath
		' 
		Me._lblPath.AutoSize = True
		Me._lblPath.Location = New System.Drawing.Point(34, 15)
		Me._lblPath.Name = "_lblPath"
		Me._lblPath.Size = New System.Drawing.Size(56, 13)
		Me._lblPath.TabIndex = 1
		Me._lblPath.Text = "&File name:"
		' 
		' _tbSource
		' 
		Me._tbSource.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._tbSource.Location = New System.Drawing.Point(96, 12)
		Me._tbSource.Name = "_tbSource"
		Me._tbSource.Size = New System.Drawing.Size(368, 21)
		Me._tbSource.TabIndex = 2
		' 
		' _btnSelectImageSource
		' 
		Me._btnSelectImageSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._btnSelectImageSource.Image = Resources.openfolder
		Me._btnSelectImageSource.Location = New System.Drawing.Point(470, 12)
		Me._btnSelectImageSource.Name = "_btnSelectImageSource"
		Me._btnSelectImageSource.Size = New System.Drawing.Size(27, 21)
		Me._btnSelectImageSource.TabIndex = 3
		Me._btnSelectImageSource.UseVisualStyleBackColor = True
		' 
		' _cgbxSize
		' 
		Me._cgbxSize.Controls.Add(Me._tbHeightValue)
		Me._cgbxSize.Controls.Add(Me._chkHeight)
		Me._cgbxSize.Controls.Add(Me._tbWidthValue)
		Me._cgbxSize.Controls.Add(Me._chkWidth)
		Me._cgbxSize.Controls.Add(Me._cbxWidthType)
		Me._cgbxSize.Controls.Add(Me._cbxHeightType)
		Me._cgbxSize.Dock = System.Windows.Forms.DockStyle.Top
		Me._cgbxSize.Location = New System.Drawing.Point(3, 90)
		Me._cgbxSize.Name = "_cgbxSize"
		Me._cgbxSize.Size = New System.Drawing.Size(507, 75)
		Me._cgbxSize.TabIndex = 1
		Me._cgbxSize.TabStop = False
		Me._cgbxSize.Text = "Size"
		' 
		' _tbHeightValue
		' 
		Me._tbHeightValue.Location = New System.Drawing.Point(121, 46)
		Me._tbHeightValue.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
		Me._tbHeightValue.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me._tbHeightValue.Name = "_tbHeightValue"
		Me._tbHeightValue.Size = New System.Drawing.Size(95, 21)
		Me._tbHeightValue.TabIndex = 4
		Me._tbHeightValue.Value = New Decimal(New Integer() {1, 0, 0, 0})
		' 
		' _chkHeight
		' 
		Me._chkHeight.AutoSize = True
		Me._chkHeight.Checked = True
		Me._chkHeight.CheckState = System.Windows.Forms.CheckState.Checked
		Me._chkHeight.Location = New System.Drawing.Point(19, 47)
		Me._chkHeight.Name = "_chkHeight"
		Me._chkHeight.Size = New System.Drawing.Size(98, 17)
		Me._chkHeight.TabIndex = 3
		Me._chkHeight.Text = "Specify &height:"
		Me._chkHeight.UseVisualStyleBackColor = True
		' 
		' _tbWidthValue
		' 
		Me._tbWidthValue.Location = New System.Drawing.Point(121, 19)
		Me._tbWidthValue.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
		Me._tbWidthValue.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me._tbWidthValue.Name = "_tbWidthValue"
		Me._tbWidthValue.Size = New System.Drawing.Size(95, 21)
		Me._tbWidthValue.TabIndex = 1
		Me._tbWidthValue.Value = New Decimal(New Integer() {1, 0, 0, 0})
		' 
		' _chkWidth
		' 
		Me._chkWidth.AutoSize = True
		Me._chkWidth.Checked = True
		Me._chkWidth.CheckState = System.Windows.Forms.CheckState.Checked
		Me._chkWidth.Location = New System.Drawing.Point(19, 21)
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
		Me._cbxWidthType.Location = New System.Drawing.Point(220, 19)
		Me._cbxWidthType.Name = "_cbxWidthType"
		Me._cbxWidthType.Size = New System.Drawing.Size(274, 21)
		Me._cbxWidthType.TabIndex = 2
		' 
		' _cbxHeightType
		' 
		Me._cbxHeightType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._cbxHeightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cbxHeightType.FormattingEnabled = True
		Me._cbxHeightType.Location = New System.Drawing.Point(220, 46)
		Me._cbxHeightType.Name = "_cbxHeightType"
		Me._cbxHeightType.Size = New System.Drawing.Size(274, 21)
		Me._cbxHeightType.TabIndex = 5
		' 
		' _cgbxPreview
		' 
		Me._cgbxPreview.Controls.Add(Me._pbSourceImage)
		Me._cgbxPreview.Dock = System.Windows.Forms.DockStyle.Fill
		Me._cgbxPreview.Location = New System.Drawing.Point(3, 165)
		Me._cgbxPreview.Name = "_cgbxPreview"
		Me._cgbxPreview.Size = New System.Drawing.Size(507, 133)
		Me._cgbxPreview.TabIndex = 3
		Me._cgbxPreview.TabStop = False
		Me._cgbxPreview.Text = "Preview"
		' 
		' _pbSourceImage
		' 
		Me._pbSourceImage.Dock = System.Windows.Forms.DockStyle.Fill
		Me._pbSourceImage.Location = New System.Drawing.Point(3, 17)
		Me._pbSourceImage.Name = "_pbSourceImage"
		Me._pbSourceImage.Size = New System.Drawing.Size(501, 113)
		Me._pbSourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me._pbSourceImage.TabIndex = 18
		Me._pbSourceImage.TabStop = False
		' 
		' ImageEditorForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.ClientSize = New System.Drawing.Size(537, 356)
		Me.MinimumSize = New System.Drawing.Size(545, 174)
		Me.Name = "ImageEditorForm"
		Me.Text = "Picture Properties"
		Me._containerMain.ResumeLayout(False)
		Me._cgbxImage.ResumeLayout(False)
		Me._cgbxImage.PerformLayout()
		Me._cgbxSize.ResumeLayout(False)
		Me._cgbxSize.PerformLayout()
		DirectCast((Me._tbHeightValue), System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast((Me._tbWidthValue), System.ComponentModel.ISupportInitialize).EndInit()
		Me._cgbxPreview.ResumeLayout(False)
		DirectCast((Me._pbSourceImage), System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private _cgbxImage As System.Windows.Forms.Panel
	Private _tbSource As System.Windows.Forms.TextBox
	Private _btnSelectImageSource As System.Windows.Forms.Button
	Private _cgbxSize As System.Windows.Forms.GroupBox
	Private _tbHeightValue As System.Windows.Forms.NumericUpDown
	Private _chkHeight As System.Windows.Forms.CheckBox
	Private _tbWidthValue As System.Windows.Forms.NumericUpDown
	Private _chkWidth As System.Windows.Forms.CheckBox
	Private _cbxWidthType As System.Windows.Forms.ComboBox
	Private _cbxHeightType As System.Windows.Forms.ComboBox
	Private _cgbxPreview As System.Windows.Forms.GroupBox
	Private _lblPath As System.Windows.Forms.Label
	Private _lblAlternate As System.Windows.Forms.Label
	Private _pbSourceImage As System.Windows.Forms.PictureBox
	Private _tbAlternate As System.Windows.Forms.TextBox

End Class
