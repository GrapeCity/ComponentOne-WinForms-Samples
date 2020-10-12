Partial Class FindOptions
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

	#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me._lblFindWhat = New System.Windows.Forms.Label()
		Me._tbFindPattern = New System.Windows.Forms.TextBox()
		Me._btnClose = New System.Windows.Forms.Button()
		Me._btnFindNext = New System.Windows.Forms.Button()
		Me._gbxFindOptions = New System.Windows.Forms.GroupBox()
		Me._chbSearchUp = New System.Windows.Forms.CheckBox()
        Me._chbMatchWholeWord = New System.Windows.Forms.CheckBox()
        Me._chbMatchCase = New System.Windows.Forms.CheckBox()
        Me._gbxFindOptions.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' _lblFindWhat
        ' 
        Me._lblFindWhat.AutoSize = True
        Me._lblFindWhat.Location = New System.Drawing.Point(12, 27)
        Me._lblFindWhat.Name = "_lblFindWhat"
        Me._lblFindWhat.Size = New System.Drawing.Size(56, 13)
        Me._lblFindWhat.TabIndex = 0
        Me._lblFindWhat.Text = "Fi&nd what:"
        ' 
        ' _tbFindPattern
        ' 
        Me._tbFindPattern.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._tbFindPattern.Location = New System.Drawing.Point(90, 24)
        Me._tbFindPattern.Name = "_tbFindPattern"
        Me._tbFindPattern.Size = New System.Drawing.Size(307, 20)
        Me._tbFindPattern.TabIndex = 1
        AddHandler Me._tbFindPattern.TextChanged, New System.EventHandler(AddressOf Me._tbFindPattern_TextChanged)
        ' 
        ' _btnClose
        ' 
        Me._btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnClose.Location = New System.Drawing.Point(306, 210)
        Me._btnClose.Name = "_btnClose"
        Me._btnClose.Size = New System.Drawing.Size(91, 25)
        Me._btnClose.TabIndex = 4
        Me._btnClose.Text = "Close"
        Me._btnClose.UseVisualStyleBackColor = True
        ' 
        ' _btnFindNext
        ' 
        Me._btnFindNext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._btnFindNext.Location = New System.Drawing.Point(209, 210)
        Me._btnFindNext.Name = "_btnFindNext"
        Me._btnFindNext.Size = New System.Drawing.Size(91, 25)
        Me._btnFindNext.TabIndex = 3
        Me._btnFindNext.Text = "Find &Next"
        Me._btnFindNext.UseVisualStyleBackColor = True
        ' 
        ' _gbxFindOptions
        ' 
        Me._gbxFindOptions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._gbxFindOptions.Controls.Add(Me._chbSearchUp)
        Me._gbxFindOptions.Controls.Add(Me._chbMatchWholeWord)
        Me._gbxFindOptions.Controls.Add(Me._chbMatchCase)
        Me._gbxFindOptions.Location = New System.Drawing.Point(15, 107)
        Me._gbxFindOptions.Name = "_gbxFindOptions"
        Me._gbxFindOptions.Size = New System.Drawing.Size(382, 97)
        Me._gbxFindOptions.TabIndex = 2
        Me._gbxFindOptions.TabStop = False
        Me._gbxFindOptions.Text = "Find options"
        ' 
        ' _chbSearchUp
        ' 
        Me._chbSearchUp.AutoSize = True
        Me._chbSearchUp.Location = New System.Drawing.Point(6, 65)
        Me._chbSearchUp.Name = "_chbSearchUp"
        Me._chbSearchUp.Size = New System.Drawing.Size(75, 17)
        Me._chbSearchUp.TabIndex = 2
        Me._chbSearchUp.Text = "Search &up"
        Me._chbSearchUp.UseVisualStyleBackColor = True
        ' 
        ' _chbMatchWholeWord
        ' 
        Me._chbMatchWholeWord.AutoSize = True
        Me._chbMatchWholeWord.Location = New System.Drawing.Point(6, 42)
        Me._chbMatchWholeWord.Name = "_chbMatchWholeWord"
        Me._chbMatchWholeWord.Size = New System.Drawing.Size(137, 17)
        Me._chbMatchWholeWord.TabIndex = 1
        Me._chbMatchWholeWord.Text = "Match whole word onl&y"
        Me._chbMatchWholeWord.UseVisualStyleBackColor = True
        ' 
        ' _chbMatchCase
        ' 
        Me._chbMatchCase.AutoSize = True
        Me._chbMatchCase.Location = New System.Drawing.Point(6, 19)
        Me._chbMatchCase.Name = "_chbMatchCase"
        Me._chbMatchCase.Size = New System.Drawing.Size(82, 17)
        Me._chbMatchCase.TabIndex = 0
        Me._chbMatchCase.Text = "Matc&h case"
        Me._chbMatchCase.UseVisualStyleBackColor = True
        ' 
        ' FindOptions
        ' 
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.Controls.Add(Me._lblFindWhat)
        Me.Controls.Add(Me._tbFindPattern)
        Me.Controls.Add(Me._btnClose)
        Me.Controls.Add(Me._btnFindNext)
        Me.Controls.Add(Me._gbxFindOptions)
        Me.MinimumSize = New System.Drawing.Size(409, 247)
        Me.Name = "FindOptions"
        Me.Size = New System.Drawing.Size(409, 247)
        Me._gbxFindOptions.ResumeLayout(False)
        Me._gbxFindOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Protected _lblFindWhat As System.Windows.Forms.Label
    Protected _tbFindPattern As System.Windows.Forms.TextBox
    Protected _gbxFindOptions As System.Windows.Forms.GroupBox
    Protected _chbSearchUp As System.Windows.Forms.CheckBox
    Protected _chbMatchWholeWord As System.Windows.Forms.CheckBox
	Protected _chbMatchCase As System.Windows.Forms.CheckBox
	Protected _btnClose As System.Windows.Forms.Button
	Protected _btnFindNext As System.Windows.Forms.Button

End Class
