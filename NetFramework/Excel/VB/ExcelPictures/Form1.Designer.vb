<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._btCreate = New System.Windows.Forms.Button
        Me._gboxSave = New System.Windows.Forms.GroupBox
        Me._radioDialog = New System.Windows.Forms.RadioButton
        Me._radioTemp = New System.Windows.Forms.RadioButton
        Me._cbPreview = New System.Windows.Forms.CheckBox
        Me.C1XLBook1 = New C1.C1Excel.C1XLBook
        Me._gboxSave.SuspendLayout()
        Me.SuspendLayout()
        '
        '_btCreate
        '
        Me._btCreate.Location = New System.Drawing.Point(11, 8)
        Me._btCreate.Name = "_btCreate"
        Me._btCreate.Size = New System.Drawing.Size(323, 29)
        Me._btCreate.TabIndex = 11
        Me._btCreate.Text = "Create Excel file with images"
        Me._btCreate.UseVisualStyleBackColor = True
        '
        '_gboxSave
        '
        Me._gboxSave.Controls.Add(Me._radioDialog)
        Me._gboxSave.Controls.Add(Me._radioTemp)
        Me._gboxSave.Controls.Add(Me._cbPreview)
        Me._gboxSave.Location = New System.Drawing.Point(11, 43)
        Me._gboxSave.Name = "_gboxSave"
        Me._gboxSave.Size = New System.Drawing.Size(323, 67)
        Me._gboxSave.TabIndex = 10
        Me._gboxSave.TabStop = False
        Me._gboxSave.Text = "Result option"
        '
        '_radioDialog
        '
        Me._radioDialog.AutoSize = True
        Me._radioDialog.Location = New System.Drawing.Point(185, 19)
        Me._radioDialog.Name = "_radioDialog"
        Me._radioDialog.Size = New System.Drawing.Size(105, 17)
        Me._radioDialog.TabIndex = 5
        Me._radioDialog.Text = "Use Save Dialog"
        Me._radioDialog.UseVisualStyleBackColor = True
        '
        '_radioTemp
        '
        Me._radioTemp.AutoSize = True
        Me._radioTemp.Checked = True
        Me._radioTemp.Location = New System.Drawing.Point(6, 19)
        Me._radioTemp.Name = "_radioTemp"
        Me._radioTemp.Size = New System.Drawing.Size(109, 17)
        Me._radioTemp.TabIndex = 3
        Me._radioTemp.TabStop = True
        Me._radioTemp.Text = "Use temporary file"
        Me._radioTemp.UseVisualStyleBackColor = True
        '
        '_cbPreview
        '
        Me._cbPreview.AutoSize = True
        Me._cbPreview.Checked = True
        Me._cbPreview.CheckState = System.Windows.Forms.CheckState.Checked
        Me._cbPreview.Location = New System.Drawing.Point(6, 42)
        Me._cbPreview.Name = "_cbPreview"
        Me._cbPreview.Size = New System.Drawing.Size(141, 17)
        Me._cbPreview.TabIndex = 1
        Me._cbPreview.Text = "Automatic result preview"
        Me._cbPreview.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 123)
        Me.Controls.Add(Me._btCreate)
        Me.Controls.Add(Me._gboxSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Excel: Add images to sheets"
        Me._gboxSave.ResumeLayout(False)
        Me._gboxSave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents _btCreate As System.Windows.Forms.Button
    Private WithEvents _gboxSave As System.Windows.Forms.GroupBox
    Private WithEvents _radioDialog As System.Windows.Forms.RadioButton
    Private WithEvents _radioTemp As System.Windows.Forms.RadioButton
    Private WithEvents _cbPreview As System.Windows.Forms.CheckBox
    Friend WithEvents C1XLBook1 As C1.C1Excel.C1XLBook

End Class
