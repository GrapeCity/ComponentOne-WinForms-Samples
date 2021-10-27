<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintTab
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintTab))
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.btnQPrint = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lblCaption.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblCaption.Location = New System.Drawing.Point(21, 7)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(166, 65)
        Me.lblCaption.TabIndex = 3
        Me.lblCaption.Text = "Label1"
        '
        'btnQPrint
        '
        Me.btnQPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnQPrint.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnQPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnQPrint.Location = New System.Drawing.Point(44, 80)
        Me.btnQPrint.Name = "btnQPrint"
        Me.btnQPrint.Size = New System.Drawing.Size(81, 86)
        Me.btnQPrint.TabIndex = 4
        Me.btnQPrint.Text = "Button1"
        Me.btnQPrint.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(44, 200)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(81, 86)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Button2"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'C1PrintPreviewControl1
        '
        Me.C1PrintPreviewControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1PrintPreviewControl1.Location = New System.Drawing.Point(160, 60)
        Me.C1PrintPreviewControl1.Name = "c1PrintPreviewControl1"
        Me.C1PrintPreviewControl1.NavigationPanelVisible = False
        Me.C1PrintPreviewControl1.PreviewPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage
        Me.C1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        Me.C1PrintPreviewControl1.PreviewPane.Name = "previewPane"
        Me.C1PrintPreviewControl1.PreviewPane.Size = New System.Drawing.Size(553, 448)
        Me.C1PrintPreviewControl1.PreviewPane.TabIndex = 0
        Me.C1PrintPreviewControl1.TabIndex = 0
        Me.C1ThemeController1.SetTheme(Me.C1PrintPreviewControl1, "(default)")
        '
        'PrintTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnQPrint)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Name = "PrintTab"
        Me.Size = New System.Drawing.Size(933, 604)
        Me.C1ThemeController1.SetTheme(Me, "Office2016DarkGray")
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents btnQPrint As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Private WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
End Class
