Partial Class HyperlinkEditorForm
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
		Me._tbLink = New System.Windows.Forms.TextBox()
		Me._lblTitle = New System.Windows.Forms.Label()
		Me._tbAccessKey = New System.Windows.Forms.TextBox()
		Me._tbTitle = New System.Windows.Forms.TextBox()
		Me._tbText = New System.Windows.Forms.TextBox()
		Me._lblText = New System.Windows.Forms.Label()
		Me._lblTabIndex = New System.Windows.Forms.Label()
		Me._lblAccessKey = New System.Windows.Forms.Label()
		Me._lblLink = New System.Windows.Forms.Label()
		Me._lblTarget = New System.Windows.Forms.Label()
		Me._cmbTarget = New System.Windows.Forms.ComboBox()
		Me._cgbxBasic = New System.Windows.Forms.GroupBox()
		Me._btnSelectImageSource = New System.Windows.Forms.Button()
		Me._cgbxAdvanced = New System.Windows.Forms.GroupBox()
		Me._tbTabIndex = New System.Windows.Forms.NumericUpDown()
		Me._containerMain.SuspendLayout()
		Me._cgbxBasic.SuspendLayout()
		Me._cgbxAdvanced.SuspendLayout()
		DirectCast((Me._tbTabIndex), System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' _btnOK
		' 
		Me._btnOK.Location = New System.Drawing.Point(216, 286)
		' 
		' _btnCancel
		' 
		Me._btnCancel.Location = New System.Drawing.Point(313, 286)
		' 
		' _btnAplly
		' 
		Me._btnAplly.Location = New System.Drawing.Point(410, 286)
		' 
		' _containerMain
		' 
		Me._containerMain.Controls.Add(Me._cgbxAdvanced)
		Me._containerMain.Controls.Add(Me._cgbxBasic)
		Me._containerMain.Size = New System.Drawing.Size(489, 268)
		' 
		' _tbLink
		' 
		Me._tbLink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._tbLink.Location = New System.Drawing.Point(105, 46)
		Me._tbLink.Name = "_tbLink"
		Me._tbLink.Size = New System.Drawing.Size(339, 21)
		Me._tbLink.TabIndex = 3
		' 
		' _lblTitle
		' 
		Me._lblTitle.AutoSize = True
		Me._lblTitle.Location = New System.Drawing.Point(17, 22)
		Me._lblTitle.Name = "_lblTitle"
		Me._lblTitle.Size = New System.Drawing.Size(59, 13)
		Me._lblTitle.TabIndex = 0
		Me._lblTitle.Text = "&Screen tip:"
		' 
		' _tbAccessKey
		' 
		Me._tbAccessKey.Location = New System.Drawing.Point(105, 73)
		Me._tbAccessKey.Name = "_tbAccessKey"
		Me._tbAccessKey.Size = New System.Drawing.Size(120, 21)
		Me._tbAccessKey.TabIndex = 5
		' 
		' _tbTitle
		' 
		Me._tbTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._tbTitle.Location = New System.Drawing.Point(105, 19)
		Me._tbTitle.Name = "_tbTitle"
		Me._tbTitle.Size = New System.Drawing.Size(372, 21)
		Me._tbTitle.TabIndex = 1
		' 
		' _tbText
		' 
		Me._tbText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._tbText.Location = New System.Drawing.Point(105, 19)
		Me._tbText.Name = "_tbText"
		Me._tbText.Size = New System.Drawing.Size(372, 21)
		Me._tbText.TabIndex = 1
		' 
		' _lblText
		' 
		Me._lblText.AutoSize = True
		Me._lblText.Location = New System.Drawing.Point(17, 22)
		Me._lblText.Name = "_lblText"
		Me._lblText.Size = New System.Drawing.Size(82, 13)
		Me._lblText.TabIndex = 0
		Me._lblText.Text = "&Text to display:"
		' 
		' _lblTabIndex
		' 
		Me._lblTabIndex.AutoSize = True
		Me._lblTabIndex.Location = New System.Drawing.Point(17, 101)
		Me._lblTabIndex.Name = "_lblTabIndex"
		Me._lblTabIndex.Size = New System.Drawing.Size(58, 13)
		Me._lblTabIndex.TabIndex = 6
		Me._lblTabIndex.Text = "Tab &index:"
		' 
		' _lblAccessKey
		' 
		Me._lblAccessKey.AutoSize = True
		Me._lblAccessKey.Location = New System.Drawing.Point(17, 75)
		Me._lblAccessKey.Name = "_lblAccessKey"
		Me._lblAccessKey.Size = New System.Drawing.Size(64, 13)
		Me._lblAccessKey.TabIndex = 4
		Me._lblAccessKey.Text = "Access &key:"
		' 
		' _lblLink
		' 
		Me._lblLink.AutoSize = True
		Me._lblLink.Location = New System.Drawing.Point(17, 49)
		Me._lblLink.Name = "_lblLink"
		Me._lblLink.Size = New System.Drawing.Size(50, 13)
		Me._lblLink.TabIndex = 2
		Me._lblLink.Text = "&Address:"
		' 
		' _lblTarget
		' 
		Me._lblTarget.AutoSize = True
		Me._lblTarget.Location = New System.Drawing.Point(17, 49)
		Me._lblTarget.Name = "_lblTarget"
		Me._lblTarget.Size = New System.Drawing.Size(74, 13)
		Me._lblTarget.TabIndex = 2
		Me._lblTarget.Text = "Ta&rget frame:"
		' 
		' _cmbTarget
		' 
        Me._cmbTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me._cmbTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me._cmbTarget.Location = New System.Drawing.Point(105, 46)
		Me._cmbTarget.Name = "_cmbTarget"
		Me._cmbTarget.Size = New System.Drawing.Size(120, 21)
		Me._cmbTarget.TabIndex = 3
		' 
		' _cgbxBasic
		' 
		Me._cgbxBasic.Controls.Add(Me._btnSelectImageSource)
		Me._cgbxBasic.Controls.Add(Me._tbLink)
		Me._cgbxBasic.Controls.Add(Me._tbText)
		Me._cgbxBasic.Controls.Add(Me._lblText)
		Me._cgbxBasic.Controls.Add(Me._lblLink)
		Me._cgbxBasic.Dock = System.Windows.Forms.DockStyle.Top
		Me._cgbxBasic.Location = New System.Drawing.Point(3, 17)
		Me._cgbxBasic.Name = "_cgbxBasic"
		Me._cgbxBasic.Size = New System.Drawing.Size(483, 75)
		Me._cgbxBasic.TabIndex = 0
		Me._cgbxBasic.TabStop = False
		Me._cgbxBasic.Text = "Basic"
		' 
		' _btnSelectImageSource
		' 
		Me._btnSelectImageSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._btnSelectImageSource.Image = Global.CustomDialogs.Resources.openfolder
		Me._btnSelectImageSource.Location = New System.Drawing.Point(450, 46)
		Me._btnSelectImageSource.Name = "_btnSelectImageSource"
		Me._btnSelectImageSource.Size = New System.Drawing.Size(27, 21)
		Me._btnSelectImageSource.TabIndex = 4
		Me._btnSelectImageSource.UseVisualStyleBackColor = True
		' 
		' _cgbxAdvanced
		' 
		Me._cgbxAdvanced.Controls.Add(Me._tbTabIndex)
		Me._cgbxAdvanced.Controls.Add(Me._tbTitle)
		Me._cgbxAdvanced.Controls.Add(Me._lblTitle)
		Me._cgbxAdvanced.Controls.Add(Me._lblTabIndex)
		Me._cgbxAdvanced.Controls.Add(Me._tbAccessKey)
		Me._cgbxAdvanced.Controls.Add(Me._lblAccessKey)
		Me._cgbxAdvanced.Controls.Add(Me._lblTarget)
		Me._cgbxAdvanced.Controls.Add(Me._cmbTarget)
		Me._cgbxAdvanced.Dock = System.Windows.Forms.DockStyle.Top
		Me._cgbxAdvanced.Location = New System.Drawing.Point(3, 92)
		Me._cgbxAdvanced.Name = "_cgbxAdvanced"
		Me._cgbxAdvanced.Size = New System.Drawing.Size(483, 128)
		Me._cgbxAdvanced.TabIndex = 1
		Me._cgbxAdvanced.TabStop = False
		Me._cgbxAdvanced.Text = "Advanced"
		' 
		' _tbTabIndex
		' 
		Me._tbTabIndex.Location = New System.Drawing.Point(105, 99)
		Me._tbTabIndex.Name = "_tbTabIndex"
		Me._tbTabIndex.Size = New System.Drawing.Size(119, 21)
		Me._tbTabIndex.TabIndex = 7
		' 
		' HyperlinkEditorForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.ClientSize = New System.Drawing.Size(513, 323)
		Me.MinimumSize = New System.Drawing.Size(521, 174)
		Me.Name = "HyperlinkEditorForm"
		Me.Text = "Hyperlink Properties"
		Me._containerMain.ResumeLayout(False)
		Me._cgbxBasic.ResumeLayout(False)
		Me._cgbxBasic.PerformLayout()
		Me._cgbxAdvanced.ResumeLayout(False)
		Me._cgbxAdvanced.PerformLayout()
		DirectCast((Me._tbTabIndex), System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private _tbLink As System.Windows.Forms.TextBox
	Private _lblTitle As System.Windows.Forms.Label
	Private _tbAccessKey As System.Windows.Forms.TextBox
	Private _tbTitle As System.Windows.Forms.TextBox
	Private _tbText As System.Windows.Forms.TextBox
	Private _lblText As System.Windows.Forms.Label
	Private _lblTabIndex As System.Windows.Forms.Label
	Private _lblAccessKey As System.Windows.Forms.Label
	Private _lblLink As System.Windows.Forms.Label
	Private _lblTarget As System.Windows.Forms.Label
	Private _cmbTarget As System.Windows.Forms.ComboBox
	Private _cgbxBasic As System.Windows.Forms.GroupBox
	Private _btnSelectImageSource As System.Windows.Forms.Button
	Private _cgbxAdvanced As System.Windows.Forms.GroupBox
	Private _tbTabIndex As System.Windows.Forms.NumericUpDown

End Class
