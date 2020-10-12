<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseConditionalFormattingForm
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
        Me.tlpMainLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOperationText = New System.Windows.Forms.Label()
        Me.tlpButtonsLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.themeController = New C1.Win.C1Themes.C1ThemeController()
        Me.tlpMainLayout.SuspendLayout()
        Me.tlpButtonsLayout.SuspendLayout()
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpMainLayout
        '
        Me.tlpMainLayout.BackColor = System.Drawing.Color.White
        Me.tlpMainLayout.ColumnCount = 1
        Me.tlpMainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMainLayout.Controls.Add(Me.lblOperationText, 0, 0)
        Me.tlpMainLayout.Controls.Add(Me.tlpButtonsLayout, 0, 2)
        Me.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMainLayout.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tlpMainLayout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tlpMainLayout.Location = New System.Drawing.Point(3, 4)
        Me.tlpMainLayout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpMainLayout.Name = "tlpMainLayout"
        Me.tlpMainLayout.RowCount = 3
        Me.tlpMainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpMainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpMainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpMainLayout.Size = New System.Drawing.Size(478, 93)
        Me.tlpMainLayout.TabIndex = 0
        Me.themeController.SetTheme(Me.tlpMainLayout, "(default)")
        '
        'lblOperationText
        '
        Me.lblOperationText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblOperationText.AutoSize = True
        Me.lblOperationText.BackColor = System.Drawing.Color.White
        Me.lblOperationText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperationText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblOperationText.Location = New System.Drawing.Point(0, 7)
        Me.lblOperationText.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOperationText.Name = "lblOperationText"
        Me.lblOperationText.Size = New System.Drawing.Size(74, 17)
        Me.lblOperationText.TabIndex = 0
        Me.lblOperationText.Text = "Operation:"
        Me.themeController.SetTheme(Me.lblOperationText, "(default)")
        '
        'tlpButtonsLayout
        '
        Me.tlpButtonsLayout.BackColor = System.Drawing.Color.White
        Me.tlpButtonsLayout.ColumnCount = 4
        Me.tlpButtonsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpButtonsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
        Me.tlpButtonsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.tlpButtonsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
        Me.tlpButtonsLayout.Controls.Add(Me.btnOk, 1, 0)
        Me.tlpButtonsLayout.Controls.Add(Me.btnCancel, 3, 0)
        Me.tlpButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpButtonsLayout.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tlpButtonsLayout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tlpButtonsLayout.Location = New System.Drawing.Point(0, 62)
        Me.tlpButtonsLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpButtonsLayout.Name = "tlpButtonsLayout"
        Me.tlpButtonsLayout.RowCount = 1
        Me.tlpButtonsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpButtonsLayout.Size = New System.Drawing.Size(478, 31)
        Me.tlpButtonsLayout.TabIndex = 1
        Me.themeController.SetTheme(Me.tlpButtonsLayout, "(default)")
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.BackColor = System.Drawing.Color.White
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnOk.Location = New System.Drawing.Point(286, 4)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(90, 27)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "OK"
        Me.themeController.SetTheme(Me.btnOk, "(default)")
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(385, 4)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 27)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.themeController.SetTheme(Me.btnCancel, "(default)")
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BaseConditionalFormattingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 101)
        Me.Controls.Add(Me.tlpMainLayout)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BaseConditionalFormattingForm"
        Me.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BaseConditionalFormattingForm"
        Me.themeController.SetTheme(Me, "(default)")
        Me.tlpMainLayout.ResumeLayout(False)
        Me.tlpMainLayout.PerformLayout()
        Me.tlpButtonsLayout.ResumeLayout(False)
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected WithEvents themeController As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents lblOperationText As System.Windows.Forms.Label
    Friend WithEvents tlpButtonsLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Protected WithEvents tlpMainLayout As System.Windows.Forms.TableLayoutPanel
End Class
