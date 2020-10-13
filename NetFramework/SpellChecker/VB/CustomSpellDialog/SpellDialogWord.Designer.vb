<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpellDialogWord
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
        Me._lblNotInDictionary = New System.Windows.Forms.Label
        Me._lblSuggestions = New System.Windows.Forms.Label
        Me._listSuggestions = New System.Windows.Forms.ListBox
        Me._lblRepeatedWord = New System.Windows.Forms.Label
        Me._btnCancel = New System.Windows.Forms.Button
        Me._lblRemove = New System.Windows.Forms.Label
        Me._lblChange = New System.Windows.Forms.Label
        Me._lblNoSuggestions = New System.Windows.Forms.Label
        Me._btnIgnore = New System.Windows.Forms.Button
        Me._btnIgnoreAll = New System.Windows.Forms.Button
        Me._btnAdd = New System.Windows.Forms.Button
        Me._btnChange = New System.Windows.Forms.Button
        Me._btnChangeAll = New System.Windows.Forms.Button
        Me._btnSuggest = New System.Windows.Forms.Button
        Me._txtError = New CustomSpellDialog.RicherTextBox
        Me.SuspendLayout()
        '
        '_lblNotInDictionary
        '
        Me._lblNotInDictionary.AutoSize = True
        Me._lblNotInDictionary.Location = New System.Drawing.Point(3, 9)
        Me._lblNotInDictionary.Name = "_lblNotInDictionary"
        Me._lblNotInDictionary.Size = New System.Drawing.Size(88, 13)
        Me._lblNotInDictionary.TabIndex = 1
        Me._lblNotInDictionary.Text = "Not in Dictionary:"
        '
        '_lblSuggestions
        '
        Me._lblSuggestions.AutoSize = True
        Me._lblSuggestions.Location = New System.Drawing.Point(3, 110)
        Me._lblSuggestions.Name = "_lblSuggestions"
        Me._lblSuggestions.Size = New System.Drawing.Size(68, 13)
        Me._lblSuggestions.TabIndex = 4
        Me._lblSuggestions.Text = "Suggestio&ns:"
        '
        '_listSuggestions
        '
        Me._listSuggestions.FormattingEnabled = True
        Me._listSuggestions.IntegralHeight = False
        Me._listSuggestions.Location = New System.Drawing.Point(7, 126)
        Me._listSuggestions.Name = "_listSuggestions"
        Me._listSuggestions.Size = New System.Drawing.Size(339, 83)
        Me._listSuggestions.TabIndex = 5
        '
        '_lblRepeatedWord
        '
        Me._lblRepeatedWord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._lblRepeatedWord.AutoSize = True
        Me._lblRepeatedWord.Location = New System.Drawing.Point(4, 235)
        Me._lblRepeatedWord.Name = "_lblRepeatedWord"
        Me._lblRepeatedWord.Size = New System.Drawing.Size(83, 13)
        Me._lblRepeatedWord.TabIndex = 6
        Me._lblRepeatedWord.Text = "Repeated word:"
        Me._lblRepeatedWord.Visible = False
        '
        '_btnCancel
        '
        Me._btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCancel.Location = New System.Drawing.Point(352, 229)
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(105, 24)
        Me._btnCancel.TabIndex = 16
        Me._btnCancel.Text = "&Cancel"
        Me._btnCancel.UseVisualStyleBackColor = True
        '
        '_lblRemove
        '
        Me._lblRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._lblRemove.AutoSize = True
        Me._lblRemove.Location = New System.Drawing.Point(299, 235)
        Me._lblRemove.Name = "_lblRemove"
        Me._lblRemove.Size = New System.Drawing.Size(47, 13)
        Me._lblRemove.TabIndex = 17
        Me._lblRemove.Text = "&Remove"
        Me._lblRemove.Visible = False
        '
        '_lblChange
        '
        Me._lblChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._lblChange.AutoSize = True
        Me._lblChange.Location = New System.Drawing.Point(249, 235)
        Me._lblChange.Name = "_lblChange"
        Me._lblChange.Size = New System.Drawing.Size(44, 13)
        Me._lblChange.TabIndex = 18
        Me._lblChange.Text = "&Change"
        Me._lblChange.Visible = False
        '
        '_lblNoSuggestions
        '
        Me._lblNoSuggestions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._lblNoSuggestions.AutoSize = True
        Me._lblNoSuggestions.Location = New System.Drawing.Point(159, 235)
        Me._lblNoSuggestions.Name = "_lblNoSuggestions"
        Me._lblNoSuggestions.Size = New System.Drawing.Size(84, 13)
        Me._lblNoSuggestions.TabIndex = 19
        Me._lblNoSuggestions.Text = "(no suggestions)"
        Me._lblNoSuggestions.Visible = False
        '
        '_btnIgnore
        '
        Me._btnIgnore.Location = New System.Drawing.Point(352, 25)
        Me._btnIgnore.Name = "_btnIgnore"
        Me._btnIgnore.Size = New System.Drawing.Size(105, 24)
        Me._btnIgnore.TabIndex = 20
        Me._btnIgnore.Text = "&Ignore Once"
        Me._btnIgnore.UseVisualStyleBackColor = True
        '
        '_btnIgnoreAll
        '
        Me._btnIgnoreAll.Location = New System.Drawing.Point(352, 55)
        Me._btnIgnoreAll.Name = "_btnIgnoreAll"
        Me._btnIgnoreAll.Size = New System.Drawing.Size(105, 24)
        Me._btnIgnoreAll.TabIndex = 21
        Me._btnIgnoreAll.Text = "I&gnore All"
        Me._btnIgnoreAll.UseVisualStyleBackColor = True
        '
        '_btnAdd
        '
        Me._btnAdd.Location = New System.Drawing.Point(352, 83)
        Me._btnAdd.Name = "_btnAdd"
        Me._btnAdd.Size = New System.Drawing.Size(105, 24)
        Me._btnAdd.TabIndex = 22
        Me._btnAdd.Text = "&Add to Dictionary"
        Me._btnAdd.UseVisualStyleBackColor = True
        '
        '_btnChange
        '
        Me._btnChange.Location = New System.Drawing.Point(352, 126)
        Me._btnChange.Name = "_btnChange"
        Me._btnChange.Size = New System.Drawing.Size(105, 24)
        Me._btnChange.TabIndex = 23
        Me._btnChange.Text = "&Change"
        Me._btnChange.UseVisualStyleBackColor = True
        '
        '_btnChangeAll
        '
        Me._btnChangeAll.Location = New System.Drawing.Point(352, 156)
        Me._btnChangeAll.Name = "_btnChangeAll"
        Me._btnChangeAll.Size = New System.Drawing.Size(105, 24)
        Me._btnChangeAll.TabIndex = 24
        Me._btnChangeAll.Text = "Change A&ll"
        Me._btnChangeAll.UseVisualStyleBackColor = True
        '
        '_btnSuggest
        '
        Me._btnSuggest.Location = New System.Drawing.Point(352, 186)
        Me._btnSuggest.Name = "_btnSuggest"
        Me._btnSuggest.Size = New System.Drawing.Size(105, 24)
        Me._btnSuggest.TabIndex = 25
        Me._btnSuggest.Text = "&Suggest"
        Me._btnSuggest.UseVisualStyleBackColor = True
        '
        '_txtError
        '
        Me._txtError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txtError.Location = New System.Drawing.Point(6, 25)
        Me._txtError.Name = "_txtError"
        Me._txtError.Size = New System.Drawing.Size(340, 82)
        Me._txtError.TabIndex = 2
        Me._txtError.Text = ""
        '
        'SpellDialogWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(463, 257)
        Me.Controls.Add(Me._btnSuggest)
        Me.Controls.Add(Me._btnChangeAll)
        Me.Controls.Add(Me._btnChange)
        Me.Controls.Add(Me._btnAdd)
        Me.Controls.Add(Me._btnIgnoreAll)
        Me.Controls.Add(Me._btnIgnore)
        Me.Controls.Add(Me._lblNoSuggestions)
        Me.Controls.Add(Me._lblChange)
        Me.Controls.Add(Me._lblRemove)
        Me.Controls.Add(Me._btnCancel)
        Me.Controls.Add(Me._lblRepeatedWord)
        Me.Controls.Add(Me._listSuggestions)
        Me.Controls.Add(Me._lblSuggestions)
        Me.Controls.Add(Me._txtError)
        Me.Controls.Add(Me._lblNotInDictionary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SpellDialogWord"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SpellDialogWord"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents _lblNotInDictionary As System.Windows.Forms.Label
    Friend WithEvents _txtError As RicherTextBox

    Private WithEvents _lblSuggestions As System.Windows.Forms.Label
    Private WithEvents _listSuggestions As System.Windows.Forms.ListBox
    Private WithEvents _lblRepeatedWord As System.Windows.Forms.Label
    Private WithEvents _btnCancel As System.Windows.Forms.Button
    Private WithEvents _lblRemove As System.Windows.Forms.Label
    Private WithEvents _lblChange As System.Windows.Forms.Label
    Private WithEvents _lblNoSuggestions As System.Windows.Forms.Label
    Private WithEvents _btnIgnore As System.Windows.Forms.Button
    Private WithEvents _btnIgnoreAll As System.Windows.Forms.Button
    Private WithEvents _btnAdd As System.Windows.Forms.Button
    Private WithEvents _btnChange As System.Windows.Forms.Button
    Private WithEvents _btnChangeAll As System.Windows.Forms.Button
    Private WithEvents _btnSuggest As System.Windows.Forms.Button
End Class
