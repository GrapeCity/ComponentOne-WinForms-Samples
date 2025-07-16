<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackstageTabFileList
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
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.AppMenuTabButton1 = New BackstageTabButton()
        Me.C1InputPanel1 = New C1.Win.InputPanel.C1InputPanel()
        Me.C1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lblCaption.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblCaption.Location = New System.Drawing.Point(24, 9)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(166, 65)
        Me.lblCaption.TabIndex = 2
        Me.lblCaption.Text = "Label1"
        '
        'AppMenuTabButton1
        '
        Me.AppMenuTabButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.AppMenuTabButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.AppMenuTabButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.AppMenuTabButton1.ItemImage = Nothing
        Me.AppMenuTabButton1.ItemText = "Label1"
        Me.AppMenuTabButton1.Location = New System.Drawing.Point(37, 98)
        Me.AppMenuTabButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AppMenuTabButton1.Name = "AppMenuTabButton1"
        Me.AppMenuTabButton1.Size = New System.Drawing.Size(443, 52)
        Me.AppMenuTabButton1.TabIndex = 0
        Me.C1ThemeController1.SetTheme(Me.AppMenuTabButton1, "(default)")
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel1.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.C1InputPanel1.DesignScaleFactor = 1.23718F
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.C1InputPanel1.Location = New System.Drawing.Point(26, 158)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(630, 218)
        Me.C1InputPanel1.TabIndex = 2
        Me.C1ThemeController1.SetTheme(Me.C1InputPanel1, "(default)")
        Me.C1InputPanel1.VisualStyle = C1.Win.InputPanel.VisualStyle.Custom
        '
        'C1ThemeController1
        '
        Me.C1ThemeController1.Theme = "Office2016DarkGray"
        '
        'AppMenuTabFileList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.AppMenuTabButton1)
        Me.Controls.Add(Me.lblCaption)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AppMenuTabFileList"
        Me.Size = New System.Drawing.Size(675, 381)
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents AppMenuTabButton1 As BackstageTabButton
    Friend WithEvents C1InputPanel1 As C1.Win.InputPanel.C1InputPanel
    Private WithEvents C1ThemeController1 As C1.Win.Themes.C1ThemeController
End Class
