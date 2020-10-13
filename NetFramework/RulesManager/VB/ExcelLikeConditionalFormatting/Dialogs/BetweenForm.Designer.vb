<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BetweenForm
    Inherits BaseConditionalFormattingForm

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tlpEditorLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.tbMinimumValue = New System.Windows.Forms.TextBox()
        Me.tbMaximumValue = New System.Windows.Forms.TextBox()
        Me.cmbStylePreset = New System.Windows.Forms.ComboBox()
        Me.lblAndText = New System.Windows.Forms.Label()
        Me.lblWithText = New System.Windows.Forms.Label()
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpEditorLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpEditorLayout
        '
        Me.tlpEditorLayout.BackColor = System.Drawing.Color.White
        Me.tlpEditorLayout.ColumnCount = 5
        Me.tlpEditorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
        Me.tlpEditorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.tlpEditorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
        Me.tlpEditorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.tlpEditorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.tlpEditorLayout.Controls.Add(Me.tbMinimumValue, 0, 0)
        Me.tlpEditorLayout.Controls.Add(Me.tbMaximumValue, 2, 0)
        Me.tlpEditorLayout.Controls.Add(Me.cmbStylePreset, 4, 0)
        Me.tlpEditorLayout.Controls.Add(Me.lblAndText, 1, 0)
        Me.tlpEditorLayout.Controls.Add(Me.lblWithText, 3, 0)
        Me.tlpEditorLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEditorLayout.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tlpEditorLayout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tlpEditorLayout.Location = New System.Drawing.Point(0, 31)
        Me.tlpEditorLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditorLayout.Name = "tlpEditorLayout"
        Me.tlpEditorLayout.RowCount = 1
        Me.tlpEditorLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpEditorLayout.Size = New System.Drawing.Size(632, 31)
        Me.tlpEditorLayout.TabIndex = 1
        Me.themeController.SetTheme(Me.tlpEditorLayout, "(default)")
        '
        'tbMinimumValue
        '
        Me.tbMinimumValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMinimumValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tbMinimumValue.Location = New System.Drawing.Point(3, 3)
        Me.tbMinimumValue.Name = "tbMinimumValue"
        Me.tbMinimumValue.Size = New System.Drawing.Size(164, 25)
        Me.tbMinimumValue.TabIndex = 0
        Me.themeController.SetTheme(Me.tbMinimumValue, "(default)")
        '
        'tbMaximumValue
        '
        Me.tbMaximumValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMaximumValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tbMaximumValue.Location = New System.Drawing.Point(210, 3)
        Me.tbMaximumValue.Name = "tbMaximumValue"
        Me.tbMaximumValue.Size = New System.Drawing.Size(164, 25)
        Me.tbMaximumValue.TabIndex = 1
        Me.themeController.SetTheme(Me.tbMaximumValue, "(default)")
        '
        'cmbStylePreset
        '
        Me.cmbStylePreset.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStylePreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStylePreset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cmbStylePreset.FormattingEnabled = True
        Me.cmbStylePreset.Items.AddRange(New Object() {"Light Red Fill with Dark Red Text", "Yellow Fill with Dark Yellow Text", "Green Fill with Dark Green Text", "Light Red Fill", "Red Text", "Red Border"})
        Me.cmbStylePreset.Location = New System.Drawing.Point(417, 5)
        Me.cmbStylePreset.Name = "cmbStylePreset"
        Me.cmbStylePreset.Size = New System.Drawing.Size(212, 25)
        Me.cmbStylePreset.TabIndex = 2
        Me.themeController.SetTheme(Me.cmbStylePreset, "(default)")
        '
        'lblAndText
        '
        Me.lblAndText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAndText.AutoSize = True
        Me.lblAndText.BackColor = System.Drawing.Color.White
        Me.lblAndText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblAndText.Location = New System.Drawing.Point(173, 7)
        Me.lblAndText.Name = "lblAndText"
        Me.lblAndText.Size = New System.Drawing.Size(31, 17)
        Me.lblAndText.TabIndex = 3
        Me.lblAndText.Text = "and"
        Me.lblAndText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.themeController.SetTheme(Me.lblAndText, "(default)")
        '
        'lblWithText
        '
        Me.lblWithText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWithText.AutoSize = True
        Me.lblWithText.BackColor = System.Drawing.Color.White
        Me.lblWithText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblWithText.Location = New System.Drawing.Point(380, 7)
        Me.lblWithText.Name = "lblWithText"
        Me.lblWithText.Size = New System.Drawing.Size(31, 17)
        Me.lblWithText.TabIndex = 4
        Me.lblWithText.Text = "with"
        Me.lblWithText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.themeController.SetTheme(Me.lblWithText, "(default)")
        '
        'BetweenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 101)
        Me.ConditionalOperationText = "Format cells that are BETWEEN:"
        Me.EditorRowControl = Me.tlpEditorLayout
        Me.Name = "BetweenForm"
        Me.Text = "Between"
        Me.themeController.SetTheme(Me, "(default)")
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpEditorLayout.ResumeLayout(False)
        Me.tlpEditorLayout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpEditorLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbMinimumValue As System.Windows.Forms.TextBox
    Friend WithEvents tbMaximumValue As System.Windows.Forms.TextBox
    Friend WithEvents cmbStylePreset As System.Windows.Forms.ComboBox
    Friend WithEvents lblAndText As System.Windows.Forms.Label
    Friend WithEvents lblWithText As System.Windows.Forms.Label
End Class
