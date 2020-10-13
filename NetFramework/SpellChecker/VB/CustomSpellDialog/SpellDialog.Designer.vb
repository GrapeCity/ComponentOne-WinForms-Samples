<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpellDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._lblRepeatedWord = New System.Windows.Forms.Label
        Me._lblNoSuggestions = New System.Windows.Forms.Label
        Me._lblChange = New System.Windows.Forms.Label
        Me._lblRemove = New System.Windows.Forms.Label
        Me._lblNotInDictionary = New System.Windows.Forms.Label
        Me._txtError = New System.Windows.Forms.TextBox
        Me._lblChangeTo = New System.Windows.Forms.Label
        Me._txtChangeTo = New System.Windows.Forms.TextBox
        Me._lblSuggestions = New System.Windows.Forms.Label
        Me._listSuggestions = New System.Windows.Forms.ListBox
        Me._btnIgnore = New System.Windows.Forms.Button
        Me._btnIgnoreAll = New System.Windows.Forms.Button
        Me._btnChange = New System.Windows.Forms.Button
        Me._btnChangeAll = New System.Windows.Forms.Button
        Me._btnAdd = New System.Windows.Forms.Button
        Me._btnSuggest = New System.Windows.Forms.Button
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me._btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        '_lblRepeatedWord
        '
        Me._lblRepeatedWord.AutoSize = True
        Me._lblRepeatedWord.Location = New System.Drawing.Point(12, 181)
        Me._lblRepeatedWord.Name = "_lblRepeatedWord"
        Me._lblRepeatedWord.Size = New System.Drawing.Size(83, 13)
        Me._lblRepeatedWord.TabIndex = 12
        Me._lblRepeatedWord.Text = "Repeated word:"
        Me._lblRepeatedWord.Visible = False
        '
        '_lblNoSuggestions
        '
        Me._lblNoSuggestions.AutoSize = True
        Me._lblNoSuggestions.Location = New System.Drawing.Point(101, 181)
        Me._lblNoSuggestions.Name = "_lblNoSuggestions"
        Me._lblNoSuggestions.Size = New System.Drawing.Size(84, 13)
        Me._lblNoSuggestions.TabIndex = 13
        Me._lblNoSuggestions.Text = "(no suggestions)"
        Me._lblNoSuggestions.Visible = False
        '
        '_lblChange
        '
        Me._lblChange.AutoSize = True
        Me._lblChange.Location = New System.Drawing.Point(191, 181)
        Me._lblChange.Name = "_lblChange"
        Me._lblChange.Size = New System.Drawing.Size(44, 13)
        Me._lblChange.TabIndex = 14
        Me._lblChange.Text = "&Change"
        Me._lblChange.Visible = False
        '
        '_lblRemove
        '
        Me._lblRemove.AutoSize = True
        Me._lblRemove.Location = New System.Drawing.Point(241, 181)
        Me._lblRemove.Name = "_lblRemove"
        Me._lblRemove.Size = New System.Drawing.Size(47, 13)
        Me._lblRemove.TabIndex = 15
        Me._lblRemove.Text = "&Remove"
        Me._lblRemove.Visible = False
        '
        '_lblNotInDictionary
        '
        Me._lblNotInDictionary.AutoSize = True
        Me._lblNotInDictionary.Location = New System.Drawing.Point(7, 9)
        Me._lblNotInDictionary.Name = "_lblNotInDictionary"
        Me._lblNotInDictionary.Size = New System.Drawing.Size(88, 13)
        Me._lblNotInDictionary.TabIndex = 17
        Me._lblNotInDictionary.Text = "Not in Dictionary:"
        '
        '_txtError
        '
        Me._txtError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._txtError.Location = New System.Drawing.Point(104, 6)
        Me._txtError.Name = "_txtError"
        Me._txtError.ReadOnly = True
        Me._txtError.Size = New System.Drawing.Size(364, 20)
        Me._txtError.TabIndex = 18
        '
        '_lblChangeTo
        '
        Me._lblChangeTo.AutoSize = True
        Me._lblChangeTo.Location = New System.Drawing.Point(7, 34)
        Me._lblChangeTo.Name = "_lblChangeTo"
        Me._lblChangeTo.Size = New System.Drawing.Size(63, 13)
        Me._lblChangeTo.TabIndex = 19
        Me._lblChangeTo.Text = "Change &To:"
        '
        '_txtChangeTo
        '
        Me._txtChangeTo.Location = New System.Drawing.Point(104, 31)
        Me._txtChangeTo.Name = "_txtChangeTo"
        Me._txtChangeTo.Size = New System.Drawing.Size(159, 20)
        Me._txtChangeTo.TabIndex = 20
        '
        '_lblSuggestions
        '
        Me._lblSuggestions.AutoSize = True
        Me._lblSuggestions.Location = New System.Drawing.Point(7, 57)
        Me._lblSuggestions.Name = "_lblSuggestions"
        Me._lblSuggestions.Size = New System.Drawing.Size(68, 13)
        Me._lblSuggestions.TabIndex = 21
        Me._lblSuggestions.Text = "Suggestio&ns:"
        '
        '_listSuggestions
        '
        Me._listSuggestions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._listSuggestions.FormattingEnabled = True
        Me._listSuggestions.IntegralHeight = False
        Me._listSuggestions.Location = New System.Drawing.Point(104, 57)
        Me._listSuggestions.Name = "_listSuggestions"
        Me._listSuggestions.Size = New System.Drawing.Size(159, 96)
        Me._listSuggestions.TabIndex = 22
        '
        '_btnIgnore
        '
        Me._btnIgnore.Location = New System.Drawing.Point(269, 57)
        Me._btnIgnore.Name = "_btnIgnore"
        Me._btnIgnore.Size = New System.Drawing.Size(95, 25)
        Me._btnIgnore.TabIndex = 23
        Me._btnIgnore.Text = "&Ignore"
        Me._btnIgnore.UseVisualStyleBackColor = True
        '
        '_btnIgnoreAll
        '
        Me._btnIgnoreAll.Location = New System.Drawing.Point(373, 57)
        Me._btnIgnoreAll.Name = "_btnIgnoreAll"
        Me._btnIgnoreAll.Size = New System.Drawing.Size(95, 25)
        Me._btnIgnoreAll.TabIndex = 24
        Me._btnIgnoreAll.Text = "I&gnore All"
        Me._btnIgnoreAll.UseVisualStyleBackColor = True
        '
        '_btnChange
        '
        Me._btnChange.Location = New System.Drawing.Point(269, 88)
        Me._btnChange.Name = "_btnChange"
        Me._btnChange.Size = New System.Drawing.Size(95, 25)
        Me._btnChange.TabIndex = 25
        Me._btnChange.Text = "&Change"
        Me._btnChange.UseVisualStyleBackColor = True
        '
        '_btnChangeAll
        '
        Me._btnChangeAll.Location = New System.Drawing.Point(373, 88)
        Me._btnChangeAll.Name = "_btnChangeAll"
        Me._btnChangeAll.Size = New System.Drawing.Size(95, 25)
        Me._btnChangeAll.TabIndex = 26
        Me._btnChangeAll.Text = "Change A&ll"
        Me._btnChangeAll.UseVisualStyleBackColor = True
        '
        '_btnAdd
        '
        Me._btnAdd.Location = New System.Drawing.Point(269, 119)
        Me._btnAdd.Name = "_btnAdd"
        Me._btnAdd.Size = New System.Drawing.Size(95, 25)
        Me._btnAdd.TabIndex = 27
        Me._btnAdd.Text = "&Add"
        Me._btnAdd.UseVisualStyleBackColor = True
        '
        '_btnSuggest
        '
        Me._btnSuggest.Location = New System.Drawing.Point(373, 119)
        Me._btnSuggest.Name = "_btnSuggest"
        Me._btnSuggest.Size = New System.Drawing.Size(95, 25)
        Me._btnSuggest.TabIndex = 28
        Me._btnSuggest.Text = "&Suggest"
        Me._btnSuggest.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Location = New System.Drawing.Point(0, 167)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(481, 2)
        Me.groupBox1.TabIndex = 29
        Me.groupBox1.TabStop = False
        '
        '_btnCancel
        '
        Me._btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCancel.Location = New System.Drawing.Point(372, 175)
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(95, 25)
        Me._btnCancel.TabIndex = 30
        Me._btnCancel.Text = "&Cancel"
        Me._btnCancel.UseVisualStyleBackColor = True
        '
        'SpellDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me._btnCancel
        Me.ClientSize = New System.Drawing.Size(479, 212)
        Me.Controls.Add(Me._btnCancel)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me._btnSuggest)
        Me.Controls.Add(Me._btnAdd)
        Me.Controls.Add(Me._btnChangeAll)
        Me.Controls.Add(Me._btnChange)
        Me.Controls.Add(Me._btnIgnoreAll)
        Me.Controls.Add(Me._btnIgnore)
        Me.Controls.Add(Me._listSuggestions)
        Me.Controls.Add(Me._lblSuggestions)
        Me.Controls.Add(Me._txtChangeTo)
        Me.Controls.Add(Me._lblChangeTo)
        Me.Controls.Add(Me._txtError)
        Me.Controls.Add(Me._lblNotInDictionary)
        Me.Controls.Add(Me._lblRemove)
        Me.Controls.Add(Me._lblChange)
        Me.Controls.Add(Me._lblNoSuggestions)
        Me.Controls.Add(Me._lblRepeatedWord)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SpellDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Spelling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents _lblRepeatedWord As System.Windows.Forms.Label
    Private WithEvents _lblNoSuggestions As System.Windows.Forms.Label
    Private WithEvents _lblChange As System.Windows.Forms.Label
    Private WithEvents _lblRemove As System.Windows.Forms.Label
    Private WithEvents _lblNotInDictionary As System.Windows.Forms.Label
    Private WithEvents _txtError As System.Windows.Forms.TextBox
    Private WithEvents _lblChangeTo As System.Windows.Forms.Label
    Private WithEvents _txtChangeTo As System.Windows.Forms.TextBox
    Private WithEvents _lblSuggestions As System.Windows.Forms.Label
    Private WithEvents _listSuggestions As System.Windows.Forms.ListBox
    Private WithEvents _btnIgnore As System.Windows.Forms.Button
    Private WithEvents _btnIgnoreAll As System.Windows.Forms.Button
    Private WithEvents _btnChange As System.Windows.Forms.Button
    Private WithEvents _btnChangeAll As System.Windows.Forms.Button
    Private WithEvents _btnAdd As System.Windows.Forms.Button
    Private WithEvents _btnSuggest As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents _btnCancel As System.Windows.Forms.Button
End Class
