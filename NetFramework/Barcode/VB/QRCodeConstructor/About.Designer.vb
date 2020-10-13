<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits C1.Win.C1Ribbon.C1RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.btnOK = New C1.Win.C1Input.C1Button()
        Me.C1SuperLabel1 = New C1.Win.C1SuperTooltip.C1SuperLabel()
        Me.C1SuperLabel2 = New C1.Win.C1SuperTooltip.C1SuperLabel()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(313, 122)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'C1SuperLabel1
        '
        Me.C1SuperLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1SuperLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1SuperLabel1.Images.Add(New C1.Win.C1SuperTooltip.ImageEntry("d2hlogo_16.png", CType(resources.GetObject("C1SuperLabel1.Images"), System.Drawing.Image)))
        Me.C1SuperLabel1.Images.Add(New C1.Win.C1SuperTooltip.ImageEntry("winformsLogo_16.png", CType(resources.GetObject("C1SuperLabel1.Images1"), System.Drawing.Image)))
        Me.C1SuperLabel1.Location = New System.Drawing.Point(12, 43)
        Me.C1SuperLabel1.Name = "C1SuperLabel1"
        Me.C1SuperLabel1.Size = New System.Drawing.Size(376, 61)
        Me.C1SuperLabel1.TabIndex = 4
        Me.C1SuperLabel1.Text = "<b>Quick Response Code Builder was built " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<b>using ComponentOne's <br>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Studio f" & _
    "or Winforms<img src='res://winformsLogo_16.png'> " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</b>"
        Me.C1SuperLabel1.UseMnemonic = True
        '
        'C1SuperLabel2
        '
        Me.C1SuperLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1SuperLabel2.Location = New System.Drawing.Point(13, 13)
        Me.C1SuperLabel2.Name = "C1SuperLabel2"
        Me.C1SuperLabel2.Size = New System.Drawing.Size(356, 23)
        Me.C1SuperLabel2.TabIndex = 5
        Me.C1SuperLabel2.Text = "<b>© Dom Sinclair / View to Learn 2010</b>"
        Me.C1SuperLabel2.UseMnemonic = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 157)
        Me.Controls.Add(Me.C1SuperLabel2)
        Me.Controls.Add(Me.C1SuperLabel1)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As C1.Win.C1Input.C1Button
    Friend WithEvents C1SuperLabel1 As C1.Win.C1SuperTooltip.C1SuperLabel
    Friend WithEvents C1SuperLabel2 As C1.Win.C1SuperTooltip.C1SuperLabel
End Class
