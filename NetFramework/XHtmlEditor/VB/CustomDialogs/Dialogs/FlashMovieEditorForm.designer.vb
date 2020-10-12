Partial Class FlashMovieEditorForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' Disposes of the resources (other than memory) used by the System.Windows.Forms.Form.
    ''' </summary>
    ''' <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
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
        Me._cgbxImage = New System.Windows.Forms.Panel()
        Me._lblTitle = New System.Windows.Forms.Label()
        Me._tbTitle = New System.Windows.Forms.TextBox()
        Me._lblSource = New System.Windows.Forms.Label()
        Me._tbData = New System.Windows.Forms.TextBox()
        Me._btnSelectFile = New System.Windows.Forms.Button()
        Me._cgbxSize = New System.Windows.Forms.GroupBox()
        Me._chkHeight = New System.Windows.Forms.CheckBox()
        Me._chkWidth = New System.Windows.Forms.CheckBox()
        Me._cbxHeightType = New System.Windows.Forms.ComboBox()
        Me._nudHeightValue = New System.Windows.Forms.NumericUpDown()
        Me._cbxWidthType = New System.Windows.Forms.ComboBox()
        Me._nudWidthValue = New System.Windows.Forms.NumericUpDown()
        Me._cgbxOptions = New System.Windows.Forms.GroupBox()
        Me._chbLoop = New System.Windows.Forms.CheckBox()
        Me._chbAutoplay = New System.Windows.Forms.CheckBox()
        Me._containerMain.SuspendLayout()
        Me._cgbxImage.SuspendLayout()
        Me._cgbxSize.SuspendLayout()
        DirectCast((Me._nudHeightValue), System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast((Me._nudWidthValue), System.ComponentModel.ISupportInitialize).BeginInit()
        Me._cgbxOptions.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' _btnOK
        ' 
        Me._btnOK.Location = New System.Drawing.Point(256, 286)
        ' 
        ' _btnCancel
        ' 
        Me._btnCancel.Location = New System.Drawing.Point(353, 286)
        ' 
        ' _btnAplly
        ' 
        Me._btnAplly.Location = New System.Drawing.Point(450, 286)
        ' 
        ' _containerMain
        ' 
        Me._containerMain.Controls.Add(Me._cgbxOptions)
        Me._containerMain.Controls.Add(Me._cgbxSize)
        Me._containerMain.Controls.Add(Me._cgbxImage)
        Me._containerMain.Size = New System.Drawing.Size(529, 268)
        ' 
        ' _cgbxImage
        ' 
        Me._cgbxImage.Controls.Add(Me._lblTitle)
        Me._cgbxImage.Controls.Add(Me._tbTitle)
        Me._cgbxImage.Controls.Add(Me._lblSource)
        Me._cgbxImage.Controls.Add(Me._tbData)
        Me._cgbxImage.Controls.Add(Me._btnSelectFile)
        Me._cgbxImage.Dock = System.Windows.Forms.DockStyle.Top
        Me._cgbxImage.Location = New System.Drawing.Point(3, 17)
        Me._cgbxImage.Name = "_cgbxImage"
        Me._cgbxImage.Size = New System.Drawing.Size(523, 74)
        Me._cgbxImage.TabIndex = 6
        Me._cgbxImage.Text = "&Path"
        ' 
        ' _lblTitle
        ' 
        Me._lblTitle.AutoSize = True
        Me._lblTitle.Location = New System.Drawing.Point(3, 46)
        Me._lblTitle.Name = "_lblTitle"
        Me._lblTitle.Size = New System.Drawing.Size(87, 13)
        Me._lblTitle.TabIndex = 3
        Me._lblTitle.Text = "&Alternative text:"
        ' 
        ' _tbTitle
        ' 
        Me._tbTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._tbTitle.Location = New System.Drawing.Point(92, 41)
        Me._tbTitle.Name = "_tbTitle"
        Me._tbTitle.Size = New System.Drawing.Size(420, 21)
        Me._tbTitle.TabIndex = 4
        ' 
        ' _lblSource
        ' 
        Me._lblSource.AutoSize = True
        Me._lblSource.Location = New System.Drawing.Point(24, 19)
        Me._lblSource.Name = "_lblSource"
        Me._lblSource.Size = New System.Drawing.Size(66, 13)
        Me._lblSource.TabIndex = 0
        Me._lblSource.Text = "Source &URL:"
        ' 
        ' _tbData
        ' 
        Me._tbData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._tbData.Location = New System.Drawing.Point(92, 14)
        Me._tbData.Name = "_tbData"
        Me._tbData.Size = New System.Drawing.Size(389, 21)
        Me._tbData.TabIndex = 1
        ' 
        ' _btnSelectFile
        ' 
        Me._btnSelectFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._btnSelectFile.Image = Global.CustomDialogs.Resources.openfolder
        Me._btnSelectFile.Location = New System.Drawing.Point(487, 14)
        Me._btnSelectFile.Name = "_btnSelectFile"
        Me._btnSelectFile.Size = New System.Drawing.Size(27, 21)
        Me._btnSelectFile.TabIndex = 2
        Me._btnSelectFile.UseVisualStyleBackColor = True
        ' 
        ' _cgbxSize
        ' 
        Me._cgbxSize.Controls.Add(Me._chkHeight)
        Me._cgbxSize.Controls.Add(Me._chkWidth)
        Me._cgbxSize.Controls.Add(Me._cbxHeightType)
        Me._cgbxSize.Controls.Add(Me._nudHeightValue)
        Me._cgbxSize.Controls.Add(Me._cbxWidthType)
        Me._cgbxSize.Controls.Add(Me._nudWidthValue)
        Me._cgbxSize.Dock = System.Windows.Forms.DockStyle.Top
        Me._cgbxSize.Location = New System.Drawing.Point(3, 91)
        Me._cgbxSize.Name = "_cgbxSize"
        Me._cgbxSize.Size = New System.Drawing.Size(523, 75)
        Me._cgbxSize.TabIndex = 7
        Me._cgbxSize.TabStop = False
        Me._cgbxSize.Text = "Size"
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
        ' _cbxHeightType
        ' 
        Me._cbxHeightType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._cbxHeightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cbxHeightType.FormattingEnabled = True
        Me._cbxHeightType.Location = New System.Drawing.Point(220, 46)
        Me._cbxHeightType.Name = "_cbxHeightType"
        Me._cbxHeightType.Size = New System.Drawing.Size(292, 21)
        Me._cbxHeightType.TabIndex = 5
        ' 
        ' _nudHeightValue
        ' 
        Me._nudHeightValue.Location = New System.Drawing.Point(121, 46)
        Me._nudHeightValue.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me._nudHeightValue.Name = "_nudHeightValue"
        Me._nudHeightValue.Size = New System.Drawing.Size(95, 21)
        Me._nudHeightValue.TabIndex = 4
        ' 
        ' _cbxWidthType
        ' 
        Me._cbxWidthType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._cbxWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cbxWidthType.FormattingEnabled = True
        Me._cbxWidthType.Location = New System.Drawing.Point(220, 19)
        Me._cbxWidthType.Name = "_cbxWidthType"
        Me._cbxWidthType.Size = New System.Drawing.Size(292, 21)
        Me._cbxWidthType.TabIndex = 2
        ' 
        ' _nudWidthValue
        ' 
        Me._nudWidthValue.Location = New System.Drawing.Point(121, 19)
        Me._nudWidthValue.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me._nudWidthValue.Name = "_nudWidthValue"
        Me._nudWidthValue.Size = New System.Drawing.Size(95, 21)
        Me._nudWidthValue.TabIndex = 1
        ' 
        ' _cgbxOptions
        ' 
        Me._cgbxOptions.Controls.Add(Me._chbLoop)
        Me._cgbxOptions.Controls.Add(Me._chbAutoplay)
        Me._cgbxOptions.Dock = System.Windows.Forms.DockStyle.Top
        Me._cgbxOptions.Location = New System.Drawing.Point(3, 166)
        Me._cgbxOptions.Name = "_cgbxOptions"
        Me._cgbxOptions.Size = New System.Drawing.Size(523, 72)
        Me._cgbxOptions.TabIndex = 8
        Me._cgbxOptions.TabStop = False
        Me._cgbxOptions.Text = "Options"
        ' 
        ' _chbLoop
        ' 
        Me._chbLoop.AutoSize = True
        Me._chbLoop.Location = New System.Drawing.Point(19, 47)
        Me._chbLoop.Name = "_chbLoop"
        Me._chbLoop.Size = New System.Drawing.Size(49, 17)
        Me._chbLoop.TabIndex = 1
        Me._chbLoop.Text = "&Loop"
        Me._chbLoop.UseVisualStyleBackColor = True
        ' 
        ' _chbAutoplay
        ' 
        Me._chbAutoplay.AutoSize = True
        Me._chbAutoplay.Location = New System.Drawing.Point(19, 21)
        Me._chbAutoplay.Name = "_chbAutoplay"
        Me._chbAutoplay.Size = New System.Drawing.Size(69, 17)
        Me._chbAutoplay.TabIndex = 0
        Me._chbAutoplay.Text = "Auto&play"
        Me._chbAutoplay.UseVisualStyleBackColor = True
        ' 
        ' ObjectEditorForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.ClientSize = New System.Drawing.Size(553, 323)
        Me.MinimumSize = New System.Drawing.Size(561, 174)
        Me.Name = "ObjectEditorForm"
        Me.Text = "Movie in Flash Format Properties"
        Me._containerMain.ResumeLayout(False)
        Me._cgbxImage.ResumeLayout(False)
        Me._cgbxImage.PerformLayout()
        Me._cgbxSize.ResumeLayout(False)
        Me._cgbxSize.PerformLayout()
        DirectCast((Me._nudHeightValue), System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast((Me._nudWidthValue), System.ComponentModel.ISupportInitialize).EndInit()
        Me._cgbxOptions.ResumeLayout(False)
        Me._cgbxOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _cgbxImage As System.Windows.Forms.Panel
    Private _lblSource As System.Windows.Forms.Label
    Private _tbData As System.Windows.Forms.TextBox
    Private _btnSelectFile As System.Windows.Forms.Button
    Private _cgbxSize As System.Windows.Forms.GroupBox
    Private _cbxHeightType As System.Windows.Forms.ComboBox
    Private _nudHeightValue As System.Windows.Forms.NumericUpDown
    Private _cbxWidthType As System.Windows.Forms.ComboBox
    Private _nudWidthValue As System.Windows.Forms.NumericUpDown
    Private _chkHeight As System.Windows.Forms.CheckBox
    Private _chkWidth As System.Windows.Forms.CheckBox
    Private _cgbxOptions As System.Windows.Forms.GroupBox
    Private _chbLoop As System.Windows.Forms.CheckBox
    Private _chbAutoplay As System.Windows.Forms.CheckBox
    Private _lblTitle As System.Windows.Forms.Label
    Private _tbTitle As System.Windows.Forms.TextBox


End Class
