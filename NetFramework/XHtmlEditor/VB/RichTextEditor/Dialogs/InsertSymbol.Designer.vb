Namespace RichTextEditor
	Partial Class InsertSymbol
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
			Me.components = New System.ComponentModel.Container()
			Me._btnInsert = New System.Windows.Forms.Button()
			Me._btnClose = New System.Windows.Forms.Button()
			Me._panel = New System.Windows.Forms.FlowLayoutPanel()
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.label1 = New System.Windows.Forms.Label()
			Me._lblDescription = New System.Windows.Forms.Label()
			Me._focusBox = New System.Windows.Forms.TextBox()
			Me.SuspendLayout()
			' 
			' _btnInsert
			' 
			Me._btnInsert.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._btnInsert.Location = New System.Drawing.Point(282, 321)
			Me._btnInsert.Margin = New System.Windows.Forms.Padding(4)
			Me._btnInsert.Name = "_btnInsert"
			Me._btnInsert.Size = New System.Drawing.Size(100, 28)
			Me._btnInsert.TabIndex = 4
            Me._btnInsert.Enabled = False
            Me._btnInsert.Text = "&Insert"
            Me._btnInsert.UseVisualStyleBackColor = True
			AddHandler Me._btnInsert.Click, New System.EventHandler(AddressOf Me._btnInsert_Click)
			' 
			' _btnClose
			' 
			Me._btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me._btnClose.Location = New System.Drawing.Point(390, 321)
			Me._btnClose.Margin = New System.Windows.Forms.Padding(4)
			Me._btnClose.Name = "_btnClose"
			Me._btnClose.Size = New System.Drawing.Size(100, 28)
			Me._btnClose.TabIndex = 5
			Me._btnClose.Text = "Close"
			Me._btnClose.UseVisualStyleBackColor = True
			' 
			' _panel
			' 
			Me._panel.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._panel.AutoScroll = True
			Me._panel.Font = New System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
			Me._panel.Location = New System.Drawing.Point(16, 31)
			Me._panel.Margin = New System.Windows.Forms.Padding(4)
			Me._panel.Name = "_panel"
			Me._panel.Size = New System.Drawing.Size(473, 277)
			Me._panel.TabIndex = 1
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(13, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(205, 17)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Select symbol, then click Insert:"
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
			' _focusBox
			' 
			Me._focusBox.Location = New System.Drawing.Point(634, 6)
			Me._focusBox.Name = "_focusBox"
			Me._focusBox.Size = New System.Drawing.Size(100, 22)
			Me._focusBox.TabIndex = 2
			AddHandler Me._focusBox.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me._focusBox_KeyDown)
			' 
			' InsertSymbolDialog
			' 
			Me.AcceptButton = Me._btnInsert
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me._btnClose
			Me.ClientSize = New System.Drawing.Size(506, 364)
			Me.Controls.Add(Me._focusBox)
			Me.Controls.Add(Me._lblDescription)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me._panel)
			Me.Controls.Add(Me._btnClose)
			Me.Controls.Add(Me._btnInsert)
			Me.KeyPreview = True
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "InsertSymbolDialog"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Insert Symbol"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private _btnInsert As System.Windows.Forms.Button
		Private _btnClose As System.Windows.Forms.Button
		Private _panel As System.Windows.Forms.FlowLayoutPanel
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private label1 As System.Windows.Forms.Label
		Private _lblDescription As System.Windows.Forms.Label
		Private _focusBox As System.Windows.Forms.TextBox
	End Class
End Namespace
