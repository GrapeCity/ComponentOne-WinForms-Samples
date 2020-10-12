Partial Class FindReplaceForm
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
		Me._tbcFindReplace = New System.Windows.Forms.TabControl()
		Me._tpgFind = New System.Windows.Forms.TabPage()
		Me._findOption = New CustomDialogs.FindOptions()
		Me._tpgReplace = New System.Windows.Forms.TabPage()
		Me._replaceOption = New CustomDialogs.ReplaceOptions()
		Me._tbcFindReplace.SuspendLayout()
		Me._tpgFind.SuspendLayout()
		Me._tpgReplace.SuspendLayout()
		Me.SuspendLayout()
		' 
		' _tbcFindReplace
		' 
		Me._tbcFindReplace.Dock = System.Windows.Forms.DockStyle.Fill
		Me._tbcFindReplace.Location = New System.Drawing.Point(0, 0)
		Me._tbcFindReplace.Name = "_tbcFindReplace"
		Me._tbcFindReplace.SelectedIndex = 0
		Me._tbcFindReplace.Size = New System.Drawing.Size(499, 281)
		Me._tbcFindReplace.TabIndex = 5
		Me._tbcFindReplace.TabPages.Add(Me._tpgFind)
		Me._tbcFindReplace.TabPages.Add(Me._tpgReplace)
		AddHandler Me._tbcFindReplace.SelectedIndexChanged, New System.EventHandler(AddressOf Me.ChangeMode)
		' 
		' _tpgFind
		' 
		Me._tpgFind.BackColor = System.Drawing.SystemColors.Window
		Me._tpgFind.Controls.Add(Me._findOption)
		Me._tpgFind.Dock = System.Windows.Forms.DockStyle.Fill
		Me._tpgFind.Location = New System.Drawing.Point(1, 19)
		Me._tpgFind.Name = "_tpgFind"
		Me._tpgFind.Padding = New System.Windows.Forms.Padding(3)
		Me._tpgFind.Size = New System.Drawing.Size(497, 261)
		Me._tpgFind.TabIndex = 0
		Me._tpgFind.Text = "Find"
		Me._tpgFind.Visible = False
		' 
		' _findOption
		' 
		Me._findOption.Dock = System.Windows.Forms.DockStyle.Fill
		Me._findOption.Location = New System.Drawing.Point(3, 3)
		Me._findOption.MatchCase = False
		Me._findOption.MatchWholeWord = False
		Me._findOption.MinimumSize = New System.Drawing.Size(409, 247)
		Me._findOption.Name = "_findOption"
		Me._findOption.SearchPattern = ""
		Me._findOption.SearchUp = False
		Me._findOption.Size = New System.Drawing.Size(491, 255)
		Me._findOption.TabIndex = 0
		' 
		' _tpgReplace
		' 
		Me._tpgReplace.BackColor = System.Drawing.SystemColors.Window
		Me._tpgReplace.Controls.Add(Me._replaceOption)
		Me._tpgReplace.Dock = System.Windows.Forms.DockStyle.Fill
		Me._tpgReplace.Location = New System.Drawing.Point(1, 19)
		Me._tpgReplace.Name = "_tpgReplace"
		Me._tpgReplace.Padding = New System.Windows.Forms.Padding(3)
		Me._tpgReplace.Size = New System.Drawing.Size(497, 261)
		Me._tpgReplace.TabIndex = 1
		Me._tpgReplace.Text = "Replace"
		Me._tpgReplace.Visible = False
		' 
		' _replaceOption
		' 
		Me._replaceOption.Dock = System.Windows.Forms.DockStyle.Fill
		Me._replaceOption.Location = New System.Drawing.Point(3, 3)
		Me._replaceOption.MatchCase = False
		Me._replaceOption.MatchWholeWord = False
		Me._replaceOption.MinimumSize = New System.Drawing.Size(409, 247)
		Me._replaceOption.Name = "_replaceOption"
		Me._replaceOption.SearchPattern = ""
		Me._replaceOption.SearchUp = False
		Me._replaceOption.Size = New System.Drawing.Size(491, 255)
		Me._replaceOption.TabIndex = 0
		' 
		' FindReplaceForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(499, 281)
		Me.Controls.Add(Me._tbcFindReplace)
        Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(432, 317)
		Me.Name = "FindReplaceForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Find and Replace"
		Me._tbcFindReplace.ResumeLayout(False)
		Me._tpgFind.ResumeLayout(False)
		Me._tpgReplace.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private _tbcFindReplace As System.Windows.Forms.TabControl
	Private _tpgFind As System.Windows.Forms.TabPage
	Private _tpgReplace As System.Windows.Forms.TabPage
	Private _findOption As CustomDialogs.FindOptions
	Private _replaceOption As CustomDialogs.ReplaceOptions
End Class
