Partial Class RowEditorForm
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
		Me._gbxAlignment = New System.Windows.Forms.GroupBox()
		Me._cbxHorizontalAlignment = New System.Windows.Forms.ComboBox()
		Me._cbxVerticalAlignment = New System.Windows.Forms.ComboBox()
		Me._lblHorizontalAlignment = New System.Windows.Forms.Label()
		Me._lblVerticalAlignment = New System.Windows.Forms.Label()
		Me._containerMain.SuspendLayout()
		Me._gbxAlignment.SuspendLayout()
		Me.SuspendLayout()
		' 
		' _btnOK
		' 
		Me._btnOK.Location = New System.Drawing.Point(213, 286)
		' 
		' _btnCancel
		' 
		Me._btnCancel.Location = New System.Drawing.Point(310, 286)
		' 
		' _btnAplly
		' 
		Me._btnAplly.Location = New System.Drawing.Point(407, 286)
		' 
		' _containerMain
		' 
		Me._containerMain.Controls.Add(Me._gbxAlignment)
		Me._containerMain.Size = New System.Drawing.Size(486, 268)
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
		Me._gbxAlignment.Size = New System.Drawing.Size(480, 75)
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
		Me._cbxHorizontalAlignment.Size = New System.Drawing.Size(356, 21)
		Me._cbxHorizontalAlignment.TabIndex = 3
		' 
		' _cbxVerticalAlignment
		' 
		Me._cbxVerticalAlignment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._cbxVerticalAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cbxVerticalAlignment.FormattingEnabled = True
		Me._cbxVerticalAlignment.Location = New System.Drawing.Point(118, 19)
		Me._cbxVerticalAlignment.Name = "_cbxVerticalAlignment"
		Me._cbxVerticalAlignment.Size = New System.Drawing.Size(356, 21)
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
		' RowEditorForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.ClientSize = New System.Drawing.Size(510, 323)
		Me.MinimumSize = New System.Drawing.Size(518, 174)
		Me.Name = "RowEditorForm"
		Me.Text = "Row Properties"
		Me._containerMain.ResumeLayout(False)
		Me._gbxAlignment.ResumeLayout(False)
		Me._gbxAlignment.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private _gbxAlignment As System.Windows.Forms.GroupBox
	Private _cbxHorizontalAlignment As System.Windows.Forms.ComboBox
	Private _cbxVerticalAlignment As System.Windows.Forms.ComboBox
	Private _lblHorizontalAlignment As System.Windows.Forms.Label
	Private _lblVerticalAlignment As System.Windows.Forms.Label


End Class
