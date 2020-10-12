Namespace RichTextEditor
	Partial Class InsertDateTime
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
			Me._btnInsert = New System.Windows.Forms.Button()
			Me._btnClose = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me._lblDescription = New System.Windows.Forms.Label()
			Me._list = New System.Windows.Forms.ListBox()
			Me.SuspendLayout()
			' 
			' _btnInsert
			' 
			Me._btnInsert.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._btnInsert.Location = New System.Drawing.Point(115, 321)
			Me._btnInsert.Margin = New System.Windows.Forms.Padding(4)
			Me._btnInsert.Name = "_btnInsert"
			Me._btnInsert.Size = New System.Drawing.Size(100, 28)
			Me._btnInsert.TabIndex = 4
			Me._btnInsert.Text = "&OK"
			Me._btnInsert.UseVisualStyleBackColor = True
			AddHandler Me._btnInsert.Click, New System.EventHandler(AddressOf Me._btnInsert_Click)
			' 
			' _btnClose
			' 
			Me._btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnClose.Location = New System.Drawing.Point(223, 321)
			Me._btnClose.Margin = New System.Windows.Forms.Padding(4)
			Me._btnClose.Name = "_btnClose"
			Me._btnClose.Size = New System.Drawing.Size(100, 28)
			Me._btnClose.TabIndex = 5
			Me._btnClose.Text = "Cancel"
			Me._btnClose.UseVisualStyleBackColor = True
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(13, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(120, 17)
			Me.label1.TabIndex = 0
			Me.label1.Text = "&Available formats:"
			' 
			' _lblDescription
			' 
			Me._lblDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles)
			Me._lblDescription.AutoSize = True
			Me._lblDescription.Location = New System.Drawing.Point(13, 321)
			Me._lblDescription.Name = "_lblDescription"
			Me._lblDescription.Size = New System.Drawing.Size(0, 17)
			Me._lblDescription.TabIndex = 3
			' 
			' _list
			' 
			Me._list.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._list.FormattingEnabled = True
			Me._list.IntegralHeight = False
			Me._list.ItemHeight = 16
			Me._list.Location = New System.Drawing.Point(12, 29)
			Me._list.Name = "_list"
			Me._list.Size = New System.Drawing.Size(311, 285)
			Me._list.TabIndex = 6
			' 
			' InsertDateTime
			' 
			Me.AcceptButton = Me._btnInsert
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnClose
			Me.ClientSize = New System.Drawing.Size(335, 364)
			Me.Controls.Add(Me._list)
			Me.Controls.Add(Me._lblDescription)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me._btnClose)
			Me.Controls.Add(Me._btnInsert)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.KeyPreview = True
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "InsertDateTime"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Date and Time"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _btnInsert As System.Windows.Forms.Button
		Private _btnClose As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private _lblDescription As System.Windows.Forms.Label
		Private _list As System.Windows.Forms.ListBox
	End Class
End Namespace
