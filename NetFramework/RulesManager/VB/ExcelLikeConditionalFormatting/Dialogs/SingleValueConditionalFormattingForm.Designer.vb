<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleValueConditionalFormattingForm
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
        Me.tbValue = New System.Windows.Forms.TextBox()
        Me.lblWithText = New System.Windows.Forms.Label()
        Me.cmbStylePreset = New System.Windows.Forms.ComboBox()
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpEditorLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpEditorLayout
        '
        Me.tlpEditorLayout.BackColor = System.Drawing.Color.White
        Me.tlpEditorLayout.ColumnCount = 3
        Me.tlpEditorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpEditorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.tlpEditorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.0!))
        Me.tlpEditorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEditorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEditorLayout.Controls.Add(Me.tbValue, 0, 0)
        Me.tlpEditorLayout.Controls.Add(Me.lblWithText, 1, 0)
        Me.tlpEditorLayout.Controls.Add(Me.cmbStylePreset, 2, 0)
        Me.tlpEditorLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEditorLayout.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tlpEditorLayout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tlpEditorLayout.Location = New System.Drawing.Point(0, 31)
        Me.tlpEditorLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditorLayout.Name = "tlpEditorLayout"
        Me.tlpEditorLayout.RowCount = 1
        Me.tlpEditorLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEditorLayout.Size = New System.Drawing.Size(478, 31)
        Me.tlpEditorLayout.TabIndex = 1
        Me.themeController.SetTheme(Me.tlpEditorLayout, "(default)")
        '
        'tbValue
        '
        Me.tbValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tbValue.Location = New System.Drawing.Point(3, 3)
        Me.tbValue.Name = "tbValue"
        Me.tbValue.Size = New System.Drawing.Size(185, 25)
        Me.tbValue.TabIndex = 0
        Me.themeController.SetTheme(Me.tbValue, "(default)")
        '
        'lblWithText
        '
        Me.lblWithText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWithText.AutoSize = True
        Me.lblWithText.BackColor = System.Drawing.Color.White
        Me.lblWithText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblWithText.Location = New System.Drawing.Point(194, 7)
        Me.lblWithText.Name = "lblWithText"
        Me.lblWithText.Size = New System.Drawing.Size(37, 17)
        Me.lblWithText.TabIndex = 1
        Me.lblWithText.Text = "with"
        Me.lblWithText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.themeController.SetTheme(Me.lblWithText, "(default)")
        '
        'cmbStylePreset
        '
        Me.cmbStylePreset.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStylePreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStylePreset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cmbStylePreset.FormattingEnabled = True
        Me.cmbStylePreset.Items.AddRange(New Object() {"Light Red Fill with Dark Red Text", "Yellow Fill with Dark Yellow Text", "Green Fill with Dark Green Text", "Light Red Fill", "Red Text", "Red Border"})
        Me.cmbStylePreset.Location = New System.Drawing.Point(237, 5)
        Me.cmbStylePreset.Name = "cmbStylePreset"
        Me.cmbStylePreset.Size = New System.Drawing.Size(238, 25)
        Me.cmbStylePreset.TabIndex = 2
        Me.themeController.SetTheme(Me.cmbStylePreset, "(default)")
        '
        'SingleValueConditionalFormattingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 101)
        Me.EditorRowControl = Me.tlpEditorLayout
        Me.Name = "SingleValueConditionalFormattingForm"
        Me.Text = "SingleValueConditionalFormattingForm"
        Me.themeController.SetTheme(Me, "(default)")
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpEditorLayout.ResumeLayout(False)
        Me.tlpEditorLayout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpEditorLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbValue As System.Windows.Forms.TextBox
    Friend WithEvents lblWithText As System.Windows.Forms.Label
    Friend WithEvents cmbStylePreset As System.Windows.Forms.ComboBox
End Class
