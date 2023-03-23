<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim C1CustomButton31 As C1.Win.C1Win7Pack.C1CustomButton = New C1.Win.C1Win7Pack.C1CustomButton
        Dim C1CustomButton32 As C1.Win.C1Win7Pack.C1CustomButton = New C1.Win.C1Win7Pack.C1CustomButton
        Me.label4 = New System.Windows.Forms.Label
        Me.removedListBox = New System.Windows.Forms.ListBox
        Me.label3 = New System.Windows.Forms.Label
        Me.rejectedListBox = New System.Windows.Forms.ListBox
        Me.taskbarButton = New C1.Win.C1Win7Pack.C1TaskbarButton(Me.components)
        Me.btnGetKnown = New System.Windows.Forms.Button
        Me.comboGetKnown = New System.Windows.Forms.ComboBox
        Me.knownListBox = New System.Windows.Forms.ListBox
        Me.label2 = New System.Windows.Forms.Label
        Me.btnClearCustom = New System.Windows.Forms.Button
        Me.btnClearKnown = New System.Windows.Forms.Button
        Me.rbKnownAfterCustom = New System.Windows.Forms.RadioButton
        Me.btnApplyChanges = New System.Windows.Forms.Button
        Me.rbKnownBeforeCustom = New System.Windows.Forms.RadioButton
        Me.registrationDialog = New C1.Win.C1Win7Pack.C1TaskDialog(Me.components)
        Me.comboKnownCategory = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.btnUnregister = New System.Windows.Forms.Button
        Me.btnRegister = New System.Windows.Forms.Button
        Me.btnAddJumpLink = New System.Windows.Forms.Button
        Me.btnAddJumpPath = New System.Windows.Forms.Button
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(122, 312)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(114, 13)
        Me.label4.TabIndex = 30
        Me.label4.Text = "Known Destinations:"
        '
        'removedListBox
        '
        Me.removedListBox.FormattingEnabled = True
        Me.removedListBox.Location = New System.Drawing.Point(212, 210)
        Me.removedListBox.Name = "removedListBox"
        Me.removedListBox.Size = New System.Drawing.Size(316, 43)
        Me.removedListBox.TabIndex = 25
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(212, 194)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(87, 13)
        Me.label3.TabIndex = 24
        Me.label3.Text = "Removed Items:"
        '
        'rejectedListBox
        '
        Me.rejectedListBox.FormattingEnabled = True
        Me.rejectedListBox.Location = New System.Drawing.Point(212, 115)
        Me.rejectedListBox.Name = "rejectedListBox"
        Me.rejectedListBox.Size = New System.Drawing.Size(316, 69)
        Me.rejectedListBox.TabIndex = 23
        '
        'taskbarButton
        '
        Me.taskbarButton.ContainerForm = Me
        Me.taskbarButton.RegistryProgID = "C1TaskbarDemo"
        Me.taskbarButton.WindowAppID = "JumpItemDemo"
        '
        'btnGetKnown
        '
        Me.btnGetKnown.Location = New System.Drawing.Point(15, 361)
        Me.btnGetKnown.Name = "btnGetKnown"
        Me.btnGetKnown.Size = New System.Drawing.Size(93, 23)
        Me.btnGetKnown.TabIndex = 29
        Me.btnGetKnown.Text = "Get Items"
        Me.btnGetKnown.UseVisualStyleBackColor = True
        '
        'comboGetKnown
        '
        Me.comboGetKnown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboGetKnown.FormattingEnabled = True
        Me.comboGetKnown.Items.AddRange(New Object() {"Recent", "Frequent"})
        Me.comboGetKnown.Location = New System.Drawing.Point(15, 328)
        Me.comboGetKnown.Name = "comboGetKnown"
        Me.comboGetKnown.Size = New System.Drawing.Size(93, 21)
        Me.comboGetKnown.TabIndex = 28
        '
        'knownListBox
        '
        Me.knownListBox.FormattingEnabled = True
        Me.knownListBox.Location = New System.Drawing.Point(122, 328)
        Me.knownListBox.Name = "knownListBox"
        Me.knownListBox.Size = New System.Drawing.Size(406, 56)
        Me.knownListBox.TabIndex = 31
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(212, 99)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(84, 13)
        Me.label2.TabIndex = 22
        Me.label2.Text = "Rejected Items:"
        '
        'btnClearCustom
        '
        Me.btnClearCustom.Location = New System.Drawing.Point(212, 275)
        Me.btnClearCustom.Name = "btnClearCustom"
        Me.btnClearCustom.Size = New System.Drawing.Size(150, 23)
        Me.btnClearCustom.TabIndex = 26
        Me.btnClearCustom.Text = "Clear Custom Categories"
        Me.btnClearCustom.UseVisualStyleBackColor = True
        '
        'btnClearKnown
        '
        Me.btnClearKnown.Location = New System.Drawing.Point(378, 275)
        Me.btnClearKnown.Name = "btnClearKnown"
        Me.btnClearKnown.Size = New System.Drawing.Size(150, 23)
        Me.btnClearKnown.TabIndex = 27
        Me.btnClearKnown.Text = "Clear Known Categories"
        Me.btnClearKnown.UseVisualStyleBackColor = True
        '
        'rbKnownAfterCustom
        '
        Me.rbKnownAfterCustom.AutoSize = True
        Me.rbKnownAfterCustom.Checked = True
        Me.rbKnownAfterCustom.Location = New System.Drawing.Point(148, 45)
        Me.rbKnownAfterCustom.Name = "rbKnownAfterCustom"
        Me.rbKnownAfterCustom.Size = New System.Drawing.Size(150, 17)
        Me.rbKnownAfterCustom.TabIndex = 3
        Me.rbKnownAfterCustom.TabStop = True
        Me.rbKnownAfterCustom.Text = "After Custom Categories"
        Me.rbKnownAfterCustom.UseVisualStyleBackColor = True
        '
        'btnApplyChanges
        '
        Me.btnApplyChanges.Location = New System.Drawing.Point(15, 275)
        Me.btnApplyChanges.Name = "btnApplyChanges"
        Me.btnApplyChanges.Size = New System.Drawing.Size(185, 23)
        Me.btnApplyChanges.TabIndex = 21
        Me.btnApplyChanges.Text = "Apply Changes to Jump List"
        Me.btnApplyChanges.UseVisualStyleBackColor = True
        '
        'rbKnownBeforeCustom
        '
        Me.rbKnownBeforeCustom.AutoSize = True
        Me.rbKnownBeforeCustom.Location = New System.Drawing.Point(148, 20)
        Me.rbKnownBeforeCustom.Name = "rbKnownBeforeCustom"
        Me.rbKnownBeforeCustom.Size = New System.Drawing.Size(159, 17)
        Me.rbKnownBeforeCustom.TabIndex = 2
        Me.rbKnownBeforeCustom.Text = "Before Custom Categories"
        Me.rbKnownBeforeCustom.UseVisualStyleBackColor = True
        '
        'registrationDialog
        '
        Me.registrationDialog.CheckBoxText = "Don't ask me again"
        Me.registrationDialog.Content = "'.txt' file type is not registered."
        C1CustomButton31.ID = 9
        C1CustomButton31.Name = "registerButton"
        C1CustomButton31.Note = "Register .txt files with this application to run this demo application correctly." & _
            ""
        C1CustomButton31.ShowElevationIcon = True
        C1CustomButton31.Text = "Register file type for this application"
        C1CustomButton32.ID = 10
        C1CustomButton32.Name = "ignoreButton"
        C1CustomButton32.Note = "You can try to apply changes without the registration."
        C1CustomButton32.Text = "Do not register the file type"
        Me.registrationDialog.CustomButtons.AddRange(New C1.Win.C1Win7Pack.C1CustomButton() {C1CustomButton31, C1CustomButton32})
        Me.registrationDialog.MainCommonIcon = C1.Win.C1Win7Pack.TaskDialogCommonIcon.Information
        Me.registrationDialog.MainInstruction = "This demo application needs to register .txt files as associated files to apply c" & _
            "hanges to the Jump List."
        Me.registrationDialog.NextID = 11
        Me.registrationDialog.WindowTitle = "C1JumpList Destinations"
        '
        'comboKnownCategory
        '
        Me.comboKnownCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboKnownCategory.FormattingEnabled = True
        Me.comboKnownCategory.Items.AddRange(New Object() {"Neither", "Recent", "Frequent"})
        Me.comboKnownCategory.Location = New System.Drawing.Point(16, 40)
        Me.comboKnownCategory.Name = "comboKnownCategory"
        Me.comboKnownCategory.Size = New System.Drawing.Size(108, 21)
        Me.comboKnownCategory.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Show"
        '
        'btnUnregister
        '
        Me.btnUnregister.Location = New System.Drawing.Point(343, 58)
        Me.btnUnregister.Name = "btnUnregister"
        Me.btnUnregister.Size = New System.Drawing.Size(185, 23)
        Me.btnUnregister.TabIndex = 18
        Me.btnUnregister.Text = "Unregister '.txt' File Type"
        Me.btnUnregister.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(343, 25)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(185, 23)
        Me.btnRegister.TabIndex = 17
        Me.btnRegister.Text = "Register '.txt' File Type"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnAddJumpLink
        '
        Me.btnAddJumpLink.Location = New System.Drawing.Point(15, 191)
        Me.btnAddJumpLink.Name = "btnAddJumpLink"
        Me.btnAddJumpLink.Size = New System.Drawing.Size(185, 62)
        Me.btnAddJumpLink.TabIndex = 20
        Me.btnAddJumpLink.Text = "Add ""JumpLink Category"" (consists of C1JumpLink objects that addresses .ico files" & _
            ")"
        Me.btnAddJumpLink.UseVisualStyleBackColor = True
        '
        'btnAddJumpPath
        '
        Me.btnAddJumpPath.Location = New System.Drawing.Point(15, 115)
        Me.btnAddJumpPath.Name = "btnAddJumpPath"
        Me.btnAddJumpPath.Size = New System.Drawing.Size(185, 62)
        Me.btnAddJumpPath.TabIndex = 19
        Me.btnAddJumpPath.Text = "Add ""JumpPath Category"" (consists of C1JumpPath objects that addresses .txt files" & _
            ")"
        Me.btnAddJumpPath.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rbKnownAfterCustom)
        Me.groupBox1.Controls.Add(Me.rbKnownBeforeCustom)
        Me.groupBox1.Controls.Add(Me.comboKnownCategory)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(316, 78)
        Me.groupBox1.TabIndex = 16
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Known Categories"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnApplyChanges
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 402)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.removedListBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.rejectedListBox)
        Me.Controls.Add(Me.btnGetKnown)
        Me.Controls.Add(Me.comboGetKnown)
        Me.Controls.Add(Me.knownListBox)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnClearCustom)
        Me.Controls.Add(Me.btnClearKnown)
        Me.Controls.Add(Me.btnApplyChanges)
        Me.Controls.Add(Me.btnUnregister)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnAddJumpLink)
        Me.Controls.Add(Me.btnAddJumpPath)
        Me.Controls.Add(Me.groupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1JumpList Destinations"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents removedListBox As System.Windows.Forms.ListBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents rejectedListBox As System.Windows.Forms.ListBox
    Private WithEvents taskbarButton As C1.Win.C1Win7Pack.C1TaskbarButton
    Private WithEvents btnGetKnown As System.Windows.Forms.Button
    Private WithEvents comboGetKnown As System.Windows.Forms.ComboBox
    Private WithEvents knownListBox As System.Windows.Forms.ListBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents btnClearCustom As System.Windows.Forms.Button
    Private WithEvents btnClearKnown As System.Windows.Forms.Button
    Private WithEvents btnApplyChanges As System.Windows.Forms.Button
    Private WithEvents btnUnregister As System.Windows.Forms.Button
    Private WithEvents btnRegister As System.Windows.Forms.Button
    Private WithEvents btnAddJumpLink As System.Windows.Forms.Button
    Private WithEvents btnAddJumpPath As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rbKnownAfterCustom As System.Windows.Forms.RadioButton
    Private WithEvents rbKnownBeforeCustom As System.Windows.Forms.RadioButton
    Private WithEvents comboKnownCategory As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents registrationDialog As C1.Win.C1Win7Pack.C1TaskDialog

End Class
