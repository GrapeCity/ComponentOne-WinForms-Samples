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
        Me.label1 = New System.Windows.Forms.Label
        Me.c1InputPanel1 = New C1.Win.InputPanel.C1InputPanel
        Me.inputGroupHeader1 = New C1.Win.InputPanel.InputGroupHeader
        Me.inputLabel1 = New C1.Win.InputPanel.InputLabel
        Me.formBackColorEditor = New CustomEditors.ColorEditorHost
        Me.inputLabel5 = New C1.Win.InputPanel.InputLabel
        Me.formForeColorEditor = New CustomEditors.ColorEditorHost
        Me.inputLabel3 = New C1.Win.InputPanel.InputLabel
        Me.labelColorEditor = New CustomEditors.ColorEditorHost
        Me.inputGroupHeader2 = New C1.Win.InputPanel.InputGroupHeader
        Me.inputLabel4 = New C1.Win.InputPanel.InputLabel
        Me.formFontEditor = New CustomEditors.FontEditorHost
        Me.inputLabel2 = New C1.Win.InputPanel.InputLabel
        Me.labelFontEditor = New CustomEditors.FontEditorHost
        Me.demoLabel = New System.Windows.Forms.Label
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        CType(Me.c1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(9, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(253, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "The Color and Font editors based on UITypeEditors"
        '
        'c1InputPanel1
        '
        Me.c1InputPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1InputPanel1.BorderThickness = 2
        Me.c1InputPanel1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.c1InputPanel1.Items.Add(Me.inputGroupHeader1)
        Me.c1InputPanel1.Items.Add(Me.inputLabel1)
        Me.c1InputPanel1.Items.Add(Me.formBackColorEditor)
        Me.c1InputPanel1.Items.Add(Me.inputLabel5)
        Me.c1InputPanel1.Items.Add(Me.formForeColorEditor)
        Me.c1InputPanel1.Items.Add(Me.inputLabel3)
        Me.c1InputPanel1.Items.Add(Me.labelColorEditor)
        Me.c1InputPanel1.Items.Add(Me.inputGroupHeader2)
        Me.c1InputPanel1.Items.Add(Me.inputLabel4)
        Me.c1InputPanel1.Items.Add(Me.formFontEditor)
        Me.c1InputPanel1.Items.Add(Me.inputLabel2)
        Me.c1InputPanel1.Items.Add(Me.labelFontEditor)
        Me.c1InputPanel1.Location = New System.Drawing.Point(12, 33)
        Me.c1InputPanel1.Name = "c1InputPanel1"
        Me.c1InputPanel1.Size = New System.Drawing.Size(364, 200)
        Me.c1InputPanel1.TabIndex = 1
        '
        'inputGroupHeader1
        '
        Me.inputGroupHeader1.Text = "Color Editor"
        '
        'inputLabel1
        '
        Me.inputLabel1.Text = "Form BackColor:"
        Me.inputLabel1.Width = 91
        '
        'formBackColorEditor
        '
        Me.formBackColorEditor.BackColor = System.Drawing.SystemColors.Window
        Me.formBackColorEditor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.formBackColorEditor.Width = 237
        '
        'inputLabel5
        '
        Me.inputLabel5.Text = "Form ForeColor:"
        Me.inputLabel5.Width = 91
        '
        'formForeColorEditor
        '
        Me.formForeColorEditor.BackColor = System.Drawing.SystemColors.Window
        Me.formForeColorEditor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.formForeColorEditor.Width = 237
        '
        'inputLabel3
        '
        Me.inputLabel3.Text = "Label Color:"
        Me.inputLabel3.Width = 91
        '
        'labelColorEditor
        '
        Me.labelColorEditor.BackColor = System.Drawing.SystemColors.Window
        Me.labelColorEditor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.labelColorEditor.Width = 237
        '
        'inputGroupHeader2
        '
        Me.inputGroupHeader2.Text = "Font Editor"
        '
        'inputLabel4
        '
        Me.inputLabel4.Text = "Form Font:"
        Me.inputLabel4.Width = 91
        '
        'formFontEditor
        '
        Me.formFontEditor.BackColor = System.Drawing.SystemColors.Window
        Me.formFontEditor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.formFontEditor.Width = 236
        '
        'inputLabel2
        '
        Me.inputLabel2.Text = "Label Font:"
        Me.inputLabel2.Width = 91
        '
        'labelFontEditor
        '
        Me.labelFontEditor.BackColor = System.Drawing.SystemColors.Window
        Me.labelFontEditor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.labelFontEditor.Width = 236
        '
        'demoLabel
        '
        Me.demoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.demoLabel.AutoSize = True
        Me.demoLabel.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.demoLabel.Location = New System.Drawing.Point(12, 246)
        Me.demoLabel.Name = "demoLabel"
        Me.demoLabel.Size = New System.Drawing.Size(82, 19)
        Me.demoLabel.TabIndex = 2
        Me.demoLabel.Text = "Demo Label"
        '
        'button2
        '
        Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button2.BackColor = System.Drawing.SystemColors.Control
        Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button2.Location = New System.Drawing.Point(301, 246)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 4
        Me.button2.Text = "Cancel"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button1.BackColor = System.Drawing.SystemColors.Control
        Me.button1.Location = New System.Drawing.Point(220, 246)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 3
        Me.button1.Text = "OK"
        Me.button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AcceptButton = Me.button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.button2
        Me.ClientSize = New System.Drawing.Size(389, 281)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.demoLabel)
        Me.Controls.Add(Me.c1InputPanel1)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "Form1"
        Me.Text = "Custom Editors"
        CType(Me.c1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents c1InputPanel1 As C1.Win.InputPanel.C1InputPanel
    Private WithEvents inputGroupHeader1 As C1.Win.InputPanel.InputGroupHeader
    Private WithEvents inputLabel1 As C1.Win.InputPanel.InputLabel
    Private WithEvents formBackColorEditor As CustomEditors.ColorEditorHost
    Private WithEvents inputLabel5 As C1.Win.InputPanel.InputLabel
    Private WithEvents formForeColorEditor As CustomEditors.ColorEditorHost
    Private WithEvents inputLabel3 As C1.Win.InputPanel.InputLabel
    Private WithEvents labelColorEditor As CustomEditors.ColorEditorHost
    Private WithEvents inputGroupHeader2 As C1.Win.InputPanel.InputGroupHeader
    Private WithEvents inputLabel4 As C1.Win.InputPanel.InputLabel
    Private WithEvents formFontEditor As CustomEditors.FontEditorHost
    Private WithEvents inputLabel2 As C1.Win.InputPanel.InputLabel
    Private WithEvents labelFontEditor As CustomEditors.FontEditorHost
    Private WithEvents demoLabel As System.Windows.Forms.Label
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button

End Class
