Partial Class ReplaceOptions
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
		Me._lblReplaceWith = New System.Windows.Forms.Label()
		Me._tbReplacePattern = New System.Windows.Forms.TextBox()
		Me._btnReplaceAll = New System.Windows.Forms.Button()
		Me._btnReplace = New System.Windows.Forms.Button()
		Me._gbxFindOptions.SuspendLayout()
		Me.SuspendLayout()
		' 
		' _tbFindPattern
		' 
        AddHandler Me._tbFindPattern.TextChanged, AddressOf Me._tbFindPattern_TextChanged
		' 
		' _gbxFindOptions
		' 
		Me._gbxFindOptions.TabIndex = 4
		' 
		' _btnClose
		' 
		Me._btnClose.TabIndex = 8
		' 
		' _btnFindNext
		' 
		Me._btnFindNext.TabIndex = 7
		' 
		' _lblReplaceWith
		' 
		Me._lblReplaceWith.AutoSize = True
		Me._lblReplaceWith.Location = New System.Drawing.Point(12, 66)
		Me._lblReplaceWith.Name = "_lblReplaceWith"
		Me._lblReplaceWith.Size = New System.Drawing.Size(72, 13)
		Me._lblReplaceWith.TabIndex = 2
		Me._lblReplaceWith.Text = "Replace w&ith:"
		' 
		' _tbReplacePattern
		' 
		Me._tbReplacePattern.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._tbReplacePattern.Location = New System.Drawing.Point(90, 63)
		Me._tbReplacePattern.Name = "_tbReplacePattern"
		Me._tbReplacePattern.Size = New System.Drawing.Size(307, 20)
		Me._tbReplacePattern.TabIndex = 3
		' 
		' _btnReplaceAll
		' 
		Me._btnReplaceAll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._btnReplaceAll.Location = New System.Drawing.Point(112, 210)
		Me._btnReplaceAll.Name = "_btnReplaceAll"
		Me._btnReplaceAll.Size = New System.Drawing.Size(91, 25)
		Me._btnReplaceAll.TabIndex = 6
		Me._btnReplaceAll.Text = "Replace &All"
		Me._btnReplaceAll.UseVisualStyleBackColor = True
		' 
		' _btnReplace
		' 
		Me._btnReplace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._btnReplace.Location = New System.Drawing.Point(15, 210)
		Me._btnReplace.Name = "_btnReplace"
		Me._btnReplace.Size = New System.Drawing.Size(91, 25)
		Me._btnReplace.TabIndex = 5
		Me._btnReplace.Text = "&Replace"
		Me._btnReplace.UseVisualStyleBackColor = True
		' 
		' ReplaceOptions
		' 
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
		Me.Controls.Add(Me._tbReplacePattern)
		Me.Controls.Add(Me._lblReplaceWith)
		Me.Controls.Add(Me._btnReplaceAll)
		Me.Controls.Add(Me._btnReplace)
		Me.Name = "ReplaceOptions"
		Me.Controls.SetChildIndex(Me._btnReplace, 0)
		Me.Controls.SetChildIndex(Me._gbxFindOptions, 0)
		Me.Controls.SetChildIndex(Me._btnReplaceAll, 0)
		Me.Controls.SetChildIndex(Me._lblReplaceWith, 0)
		Me.Controls.SetChildIndex(Me._btnFindNext, 0)
		Me.Controls.SetChildIndex(Me._btnClose, 0)
		Me.Controls.SetChildIndex(Me._tbReplacePattern, 0)
		Me.Controls.SetChildIndex(Me._tbFindPattern, 0)
		Me.Controls.SetChildIndex(Me._lblFindWhat, 0)
		Me._gbxFindOptions.ResumeLayout(False)
		Me._gbxFindOptions.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private _lblReplaceWith As System.Windows.Forms.Label
	Private _tbReplacePattern As System.Windows.Forms.TextBox
	Private _btnReplaceAll As System.Windows.Forms.Button
	Private _btnReplace As System.Windows.Forms.Button
End Class
