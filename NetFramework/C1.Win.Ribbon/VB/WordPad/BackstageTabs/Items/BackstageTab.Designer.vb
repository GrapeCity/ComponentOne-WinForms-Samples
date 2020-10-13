<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackstageTab
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
        Me.c1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.ItemButton1 = New WordPad.ItemButton()
        CType(Me.c1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblCaption.Location = New System.Drawing.Point(21, 7)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(155, 65)
        Me.lblCaption.TabIndex = 3
        Me.lblCaption.Text = "label1"
        '
        'c1InputPanel1
        '
        Me.c1InputPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1InputPanel1.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.c1InputPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.c1InputPanel1.DesignScaleFactor = 1.003259!
        Me.c1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.c1InputPanel1.Location = New System.Drawing.Point(22, 121)
        Me.c1InputPanel1.Name = "c1InputPanel1"
        Me.c1InputPanel1.Size = New System.Drawing.Size(540, 167)
        Me.c1InputPanel1.TabIndex = 4
        Me.c1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Custom
        '
        'ItemButton1
        '
        Me.ItemButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ItemButton1.ItemImage = Nothing
        Me.ItemButton1.ItemText = "label1"
        Me.ItemButton1.Location = New System.Drawing.Point(32, 75)
        Me.ItemButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemButton1.Name = "ItemButton1"
        Me.ItemButton1.Size = New System.Drawing.Size(380, 40)
        Me.ItemButton1.TabIndex = 5
        '
        'BackstageTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Controls.Add(Me.ItemButton1)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.c1InputPanel1)
        Me.Name = "BackstageTab"
        Me.Size = New System.Drawing.Size(579, 291)
        CType(Me.c1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblCaption As Label
    Private WithEvents c1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents ItemButton1 As ItemButton
End Class
