<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeoLocationDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeoLocationDialog))
        Me.C1SplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.brwsMap = New System.Windows.Forms.WebBrowser()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.brwsGetLatLon = New System.Windows.Forms.WebBrowser()
        Me.C1SplitterPanel3 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.btnWebOK = New C1.Win.C1Input.C1Button()
        Me.btnWebCancel = New C1.Win.C1Input.C1Button()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer1.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        Me.C1SplitterPanel2.SuspendLayout()
        Me.C1SplitterPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1SplitContainer1
        '
        Me.C1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.C1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1SplitContainer1.CollapsingCueColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.C1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.C1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.C1SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.C1SplitContainer1.Name = "C1SplitContainer1"
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel1)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel2)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel3)
        Me.C1SplitContainer1.Size = New System.Drawing.Size(576, 660)
        Me.C1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.C1SplitContainer1.SplitterWidth = 1
        Me.C1SplitContainer1.TabIndex = 0
        Me.C1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Silver
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.Controls.Add(Me.brwsMap)
        Me.C1SplitterPanel1.Height = 529
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(576, 529)
        Me.C1SplitterPanel1.SizeRatio = 80.233R
        Me.C1SplitterPanel1.TabIndex = 0
        '
        'brwsMap
        '
        Me.brwsMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.brwsMap.Location = New System.Drawing.Point(0, 0)
        Me.brwsMap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.brwsMap.MinimumSize = New System.Drawing.Size(27, 25)
        Me.brwsMap.Name = "brwsMap"
        Me.brwsMap.ScrollBarsEnabled = False
        Me.brwsMap.Size = New System.Drawing.Size(576, 529)
        Me.brwsMap.TabIndex = 0
        Me.brwsMap.Url = New System.Uri("", System.UriKind.Relative)
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.Controls.Add(Me.brwsGetLatLon)
        Me.C1SplitterPanel2.Height = 64
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(0, 530)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(576, 64)
        Me.C1SplitterPanel2.TabIndex = 1
        '
        'brwsGetLatLon
        '
        Me.brwsGetLatLon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.brwsGetLatLon.Location = New System.Drawing.Point(0, 0)
        Me.brwsGetLatLon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.brwsGetLatLon.MinimumSize = New System.Drawing.Size(27, 25)
        Me.brwsGetLatLon.Name = "brwsGetLatLon"
        Me.brwsGetLatLon.ScrollBarsEnabled = False
        Me.brwsGetLatLon.Size = New System.Drawing.Size(576, 64)
        Me.brwsGetLatLon.TabIndex = 0
        '
        'C1SplitterPanel3
        '
        Me.C1SplitterPanel3.Controls.Add(Me.btnWebOK)
        Me.C1SplitterPanel3.Controls.Add(Me.btnWebCancel)
        Me.C1SplitterPanel3.Height = 100
        Me.C1SplitterPanel3.Location = New System.Drawing.Point(0, 595)
        Me.C1SplitterPanel3.Name = "C1SplitterPanel3"
        Me.C1SplitterPanel3.Size = New System.Drawing.Size(576, 65)
        Me.C1SplitterPanel3.TabIndex = 2
        '
        'btnWebOK
        '
        Me.btnWebOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWebOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnWebOK.Location = New System.Drawing.Point(160, 11)
        Me.btnWebOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnWebOK.Name = "btnWebOK"
        Me.btnWebOK.Size = New System.Drawing.Size(100, 28)
        Me.btnWebOK.TabIndex = 1
        Me.btnWebOK.Text = "&OK"
        Me.btnWebOK.UseVisualStyleBackColor = True
        '
        'btnWebCancel
        '
        Me.btnWebCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWebCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnWebCancel.Location = New System.Drawing.Point(268, 11)
        Me.btnWebCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnWebCancel.Name = "btnWebCancel"
        Me.btnWebCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnWebCancel.TabIndex = 0
        Me.btnWebCancel.Text = "&Cancel"
        Me.btnWebCancel.UseVisualStyleBackColor = True
        '
        'GeoLocationDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 660)
        Me.Controls.Add(Me.C1SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GeoLocationDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Retrieve Latitude and Longitude"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer1.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        Me.C1SplitterPanel2.ResumeLayout(False)
        Me.C1SplitterPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1SplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents brwsGetLatLon As System.Windows.Forms.WebBrowser
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents btnWebOK As C1.Win.C1Input.C1Button
    Friend WithEvents btnWebCancel As C1.Win.C1Input.C1Button
    Friend WithEvents brwsMap As System.Windows.Forms.WebBrowser
    Friend WithEvents C1SplitterPanel3 As C1.Win.C1SplitContainer.C1SplitterPanel
End Class
