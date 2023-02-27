<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeriesDialog
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
        Me._pBox = New System.Windows.Forms.PictureBox
        Me._btnCancel = New System.Windows.Forms.Button
        Me._btnOk = New System.Windows.Forms.Button
        Me._rbSeries = New System.Windows.Forms.RadioButton
        Me._rbOccurrence = New System.Windows.Forms.RadioButton
        Me._lblMessage = New System.Windows.Forms.Label
        CType(Me._pBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pBox
        '
        Me._pBox.Location = New System.Drawing.Point(12, 12)
        Me._pBox.Name = "_pBox"
        Me._pBox.Size = New System.Drawing.Size(32, 32)
        Me._pBox.TabIndex = 11
        Me._pBox.TabStop = False
        '
        '_btnCancel
        '
        Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCancel.Location = New System.Drawing.Point(147, 146)
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(75, 23)
        Me._btnCancel.TabIndex = 10
        Me._btnCancel.Text = "&Cancel"
        Me._btnCancel.UseVisualStyleBackColor = True
        '
        '_btnOk
        '
        Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me._btnOk.Location = New System.Drawing.Point(53, 146)
        Me._btnOk.Name = "_btnOk"
        Me._btnOk.Size = New System.Drawing.Size(75, 23)
        Me._btnOk.TabIndex = 9
        Me._btnOk.Text = "&OK"
        Me._btnOk.UseVisualStyleBackColor = True
        '
        '_rbSeries
        '
        Me._rbSeries.AutoSize = True
        Me._rbSeries.Location = New System.Drawing.Point(53, 108)
        Me._rbSeries.Name = "_rbSeries"
        Me._rbSeries.Size = New System.Drawing.Size(102, 17)
        Me._rbSeries.TabIndex = 8
        Me._rbSeries.Text = "Open the &series."
        Me._rbSeries.UseVisualStyleBackColor = True
        '
        '_rbOccurrence
        '
        Me._rbOccurrence.AutoSize = True
        Me._rbOccurrence.Checked = True
        Me._rbOccurrence.Location = New System.Drawing.Point(53, 73)
        Me._rbOccurrence.Name = "_rbOccurrence"
        Me._rbOccurrence.Size = New System.Drawing.Size(130, 17)
        Me._rbOccurrence.TabIndex = 7
        Me._rbOccurrence.TabStop = True
        Me._rbOccurrence.Text = "Open &this occurrence."
        Me._rbOccurrence.UseVisualStyleBackColor = True
        '
        '_lblMessage
        '
        Me._lblMessage.Location = New System.Drawing.Point(50, 12)
        Me._lblMessage.Name = "_lblMessage"
        Me._lblMessage.Size = New System.Drawing.Size(222, 58)
        Me._lblMessage.TabIndex = 6
        Me._lblMessage.Text = """{0}"" is recurring appointment. Do you want to open only this occurrence or the s" & _
            "eries?"
        '
        'SeriesDialog
        '
        Me.AcceptButton = Me._btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me._btnCancel
        Me.ClientSize = New System.Drawing.Size(280, 175)
        Me.Controls.Add(Me._pBox)
        Me.Controls.Add(Me._btnCancel)
        Me.Controls.Add(Me._btnOk)
        Me.Controls.Add(Me._rbSeries)
        Me.Controls.Add(Me._rbOccurrence)
        Me.Controls.Add(Me._lblMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SeriesDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SeriesDialog"
        CType(Me._pBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents _pBox As System.Windows.Forms.PictureBox
    Private WithEvents _btnCancel As System.Windows.Forms.Button
    Private WithEvents _btnOk As System.Windows.Forms.Button
    Private WithEvents _rbSeries As System.Windows.Forms.RadioButton
    Private WithEvents _rbOccurrence As System.Windows.Forms.RadioButton
    Private WithEvents _lblMessage As System.Windows.Forms.Label
End Class
