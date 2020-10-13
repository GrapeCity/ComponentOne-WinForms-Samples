Namespace C1WordsX
	Partial Class SetLanguage
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me._list = New System.Windows.Forms.ListBox()
			Me._btnOK = New System.Windows.Forms.Button()
			Me._btnCancel = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' _list
			' 
			Me._list.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._list.FormattingEnabled = True
			Me._list.ItemHeight = 16
			Me._list.Location = New System.Drawing.Point(12, 33)
			Me._list.Name = "_list"
			Me._list.Size = New System.Drawing.Size(382, 180)
			Me._list.TabIndex = 0
			' 
			' _btnOK
			' 
			Me._btnOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOK.Location = New System.Drawing.Point(220, 223)
			Me._btnOK.Name = "_btnOK"
			Me._btnOK.Size = New System.Drawing.Size(84, 25)
			Me._btnOK.TabIndex = 1
			Me._btnOK.Text = "OK"
			Me._btnOK.UseVisualStyleBackColor = True
			AddHandler Me._btnOK.Click, New System.EventHandler(AddressOf Me._btnOK_Click)
			' 
			' _btnCancel
			' 
			Me._btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnCancel.Location = New System.Drawing.Point(310, 223)
			Me._btnCancel.Name = "_btnCancel"
			Me._btnCancel.Size = New System.Drawing.Size(84, 25)
			Me._btnCancel.TabIndex = 2
			Me._btnCancel.Text = "Cancel"
			Me._btnCancel.UseVisualStyleBackColor = True
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(9, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(161, 17)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Select default language:"
			' 
			' SetLanguageDialog
			' 
			Me.AcceptButton = Me._btnOK
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnCancel
			Me.ClientSize = New System.Drawing.Size(406, 260)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me._btnCancel)
			Me.Controls.Add(Me._btnOK)
			Me.Controls.Add(Me._list)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "SetLanguageDialog"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Language"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _list As System.Windows.Forms.ListBox
		Private _btnOK As System.Windows.Forms.Button
		Private _btnCancel As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace
