Partial Class CellEditorForm
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
		Me._gbxSpan = New System.Windows.Forms.GroupBox()
		Me._nudColSpan = New System.Windows.Forms.NumericUpDown()
		Me._nudRowSpan = New System.Windows.Forms.NumericUpDown()
		Me._lblRowSpan = New System.Windows.Forms.Label()
		Me._lblColSpan = New System.Windows.Forms.Label()
		Me._chbHeader = New System.Windows.Forms.CheckBox()
		Me._gbxAlignment = New System.Windows.Forms.GroupBox()
		Me._cbxHorizontalAlignment = New System.Windows.Forms.ComboBox()
		Me._cbxVerticalAlignment = New System.Windows.Forms.ComboBox()
		Me._lblHorizontalAlignment = New System.Windows.Forms.Label()
		Me._lblVerticalAlignment = New System.Windows.Forms.Label()
		Me._containerMain.SuspendLayout()
		Me._gbxSpan.SuspendLayout()
		DirectCast((Me._nudColSpan), System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast((Me._nudRowSpan), System.ComponentModel.ISupportInitialize).BeginInit()
		Me._gbxAlignment.SuspendLayout()
		Me.SuspendLayout()
		' 
		' _btnOK
		' 
		Me._btnOK.Location = New System.Drawing.Point(216, 242)
		' 
		' _btnCancel
		' 
		Me._btnCancel.Location = New System.Drawing.Point(313, 242)
		' 
		' _btnAplly
		' 
		Me._btnAplly.Location = New System.Drawing.Point(410, 242)
		' 
		' _containerMain
		' 
		Me._containerMain.Controls.Add(Me._gbxSpan)
		Me._containerMain.Controls.Add(Me._chbHeader)
		Me._containerMain.Controls.Add(Me._gbxAlignment)
		Me._containerMain.Size = New System.Drawing.Size(489, 224)
		' 
		' _gbxSpan
		' 
		Me._gbxSpan.Controls.Add(Me._nudColSpan)
		Me._gbxSpan.Controls.Add(Me._nudRowSpan)
		Me._gbxSpan.Controls.Add(Me._lblRowSpan)
		Me._gbxSpan.Controls.Add(Me._lblColSpan)
		Me._gbxSpan.Dock = System.Windows.Forms.DockStyle.Top
		Me._gbxSpan.Location = New System.Drawing.Point(3, 92)
		Me._gbxSpan.Name = "_gbxSpan"
		Me._gbxSpan.Size = New System.Drawing.Size(483, 75)
		Me._gbxSpan.TabIndex = 1
		Me._gbxSpan.TabStop = False
		Me._gbxSpan.Text = "Span"
		' 
		' _nudColSpan
		' 
		Me._nudColSpan.Location = New System.Drawing.Point(118, 20)
		Me._nudColSpan.Name = "_nudColSpan"
		Me._nudColSpan.Size = New System.Drawing.Size(95, 21)
		Me._nudColSpan.TabIndex = 1
		' 
		' _nudRowSpan
		' 
		Me._nudRowSpan.Location = New System.Drawing.Point(118, 47)
		Me._nudRowSpan.Name = "_nudRowSpan"
		Me._nudRowSpan.Size = New System.Drawing.Size(95, 21)
		Me._nudRowSpan.TabIndex = 3
		' 
		' _lblRowSpan
		' 
		Me._lblRowSpan.AutoSize = True
		Me._lblRowSpan.Location = New System.Drawing.Point(17, 49)
		Me._lblRowSpan.Name = "_lblRowSpan"
		Me._lblRowSpan.Size = New System.Drawing.Size(32, 13)
		Me._lblRowSpan.TabIndex = 2
		Me._lblRowSpan.Text = "&Row:"
		' 
		' _lblColSpan
		' 
		Me._lblColSpan.AutoSize = True
		Me._lblColSpan.Location = New System.Drawing.Point(17, 22)
		Me._lblColSpan.Name = "_lblColSpan"
		Me._lblColSpan.Size = New System.Drawing.Size(46, 13)
		Me._lblColSpan.TabIndex = 0
		Me._lblColSpan.Text = "&Column:"
		' 
		' _chbHeader
		' 
		Me._chbHeader.AutoSize = True
		Me._chbHeader.Location = New System.Drawing.Point(20, 176)
		Me._chbHeader.Name = "_chbHeader"
		Me._chbHeader.Size = New System.Drawing.Size(61, 17)
		Me._chbHeader.TabIndex = 2
		Me._chbHeader.Text = "Hea&der"
		Me._chbHeader.UseVisualStyleBackColor = True
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
		Me._gbxAlignment.Size = New System.Drawing.Size(483, 75)
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
		Me._cbxHorizontalAlignment.Size = New System.Drawing.Size(359, 21)
		Me._cbxHorizontalAlignment.TabIndex = 3
		' 
		' _cbxVerticalAlignment
		' 
		Me._cbxVerticalAlignment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._cbxVerticalAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cbxVerticalAlignment.FormattingEnabled = True
		Me._cbxVerticalAlignment.Location = New System.Drawing.Point(118, 19)
		Me._cbxVerticalAlignment.Name = "_cbxVerticalAlignment"
		Me._cbxVerticalAlignment.Size = New System.Drawing.Size(359, 21)
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
		' CellEditorForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.ClientSize = New System.Drawing.Size(513, 279)
		Me.MinimumSize = New System.Drawing.Size(521, 174)
		Me.Name = "CellEditorForm"
		Me.Text = "Cell Properties"
		Me._containerMain.ResumeLayout(False)
		Me._containerMain.PerformLayout()
		Me._gbxSpan.ResumeLayout(False)
		Me._gbxSpan.PerformLayout()
		DirectCast((Me._nudColSpan), System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast((Me._nudRowSpan), System.ComponentModel.ISupportInitialize).EndInit()
		Me._gbxAlignment.ResumeLayout(False)
		Me._gbxAlignment.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private _gbxSpan As System.Windows.Forms.GroupBox
	Private _nudColSpan As System.Windows.Forms.NumericUpDown
	Private _nudRowSpan As System.Windows.Forms.NumericUpDown
	Private _lblRowSpan As System.Windows.Forms.Label
	Private _lblColSpan As System.Windows.Forms.Label
	Private _chbHeader As System.Windows.Forms.CheckBox
	Private _gbxAlignment As System.Windows.Forms.GroupBox
	Private _cbxHorizontalAlignment As System.Windows.Forms.ComboBox
	Private _cbxVerticalAlignment As System.Windows.Forms.ComboBox
	Private _lblHorizontalAlignment As System.Windows.Forms.Label
	Private _lblVerticalAlignment As System.Windows.Forms.Label

End Class
