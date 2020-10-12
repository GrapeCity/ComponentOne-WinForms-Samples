<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me._lblCopyright = New System.Windows.Forms.Label()
        Me._btnOK = New System.Windows.Forms.Button()
        Me._lblInstalledComponents = New System.Windows.Forms.TextBox()
        Me._panelResources = New System.Windows.Forms.Panel()
        Me._lblResources = New System.Windows.Forms.Label()
        Me._panelLinks = New System.Windows.Forms.Panel()
        Me._linkSubmitIncident = New System.Windows.Forms.LinkLabel()
        Me._linkHome = New System.Windows.Forms.LinkLabel()
        Me._linkSupport = New System.Windows.Forms.LinkLabel()
        Me._linkDownload = New System.Windows.Forms.LinkLabel()
        Me._linkContactUs = New System.Windows.Forms.LinkLabel()
        Me._linkVersionHistory = New System.Windows.Forms.LinkLabel()
        Me._linkResellers = New System.Windows.Forms.LinkLabel()
        Me._linkForums = New System.Windows.Forms.LinkLabel()
        Me._linkStore = New System.Windows.Forms.LinkLabel()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._panelResources.SuspendLayout()
        Me._panelLinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(158, 137)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 23
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(176, 12)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(357, 44)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox2.TabIndex = 24
        Me.pictureBox2.TabStop = False
        '
        '_lblCopyright
        '
        Me._lblCopyright.AutoSize = True
        Me._lblCopyright.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me._lblCopyright.ForeColor = System.Drawing.Color.Silver
        Me._lblCopyright.Location = New System.Drawing.Point(12, 292)
        Me._lblCopyright.Name = "_lblCopyright"
        Me._lblCopyright.Size = New System.Drawing.Size(220, 12)
        Me._lblCopyright.TabIndex = 25
        Me._lblCopyright.Text = "Copyright (c) 2009-{0} GrapeCity, Inc."
        '
        '_btnOK
        '
        Me._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me._btnOK.Location = New System.Drawing.Point(434, 279)
        Me._btnOK.Name = "_btnOK"
        Me._btnOK.Size = New System.Drawing.Size(100, 25)
        Me._btnOK.TabIndex = 26
        Me._btnOK.Text = "OK"
        Me._btnOK.UseVisualStyleBackColor = True
        '
        '_lblInstalledComponents
        '
        Me._lblInstalledComponents.BackColor = System.Drawing.Color.White
        Me._lblInstalledComponents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._lblInstalledComponents.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me._lblInstalledComponents.Location = New System.Drawing.Point(184, 62)
        Me._lblInstalledComponents.Multiline = True
        Me._lblInstalledComponents.Name = "_lblInstalledComponents"
        Me._lblInstalledComponents.ReadOnly = True
        Me._lblInstalledComponents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me._lblInstalledComponents.Size = New System.Drawing.Size(349, 129)
        Me._lblInstalledComponents.TabIndex = 27
        Me._lblInstalledComponents.Text = "C1dView"
        '
        '_panelResources
        '
        Me._panelResources.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer))
        Me._panelResources.Controls.Add(Me._lblResources)
        Me._panelResources.Controls.Add(Me._panelLinks)
        Me._panelResources.Location = New System.Drawing.Point(12, 198)
        Me._panelResources.Name = "_panelResources"
        Me._panelResources.Size = New System.Drawing.Size(521, 70)
        Me._panelResources.TabIndex = 28
        '
        '_lblResources
        '
        Me._lblResources.AutoSize = True
        Me._lblResources.ForeColor = System.Drawing.Color.Black
        Me._lblResources.Location = New System.Drawing.Point(3, 3)
        Me._lblResources.Name = "_lblResources"
        Me._lblResources.Size = New System.Drawing.Size(94, 13)
        Me._lblResources.TabIndex = 7
        Me._lblResources.Text = "Online Resources:"
        '
        '_panelLinks
        '
        Me._panelLinks.Controls.Add(Me._linkSubmitIncident)
        Me._panelLinks.Controls.Add(Me._linkHome)
        Me._panelLinks.Controls.Add(Me._linkSupport)
        Me._panelLinks.Controls.Add(Me._linkDownload)
        Me._panelLinks.Controls.Add(Me._linkContactUs)
        Me._panelLinks.Controls.Add(Me._linkVersionHistory)
        Me._panelLinks.Controls.Add(Me._linkResellers)
        Me._panelLinks.Controls.Add(Me._linkForums)
        Me._panelLinks.Controls.Add(Me._linkStore)
        Me._panelLinks.Location = New System.Drawing.Point(142, 2)
        Me._panelLinks.Name = "_panelLinks"
        Me._panelLinks.Size = New System.Drawing.Size(363, 59)
        Me._panelLinks.TabIndex = 3
        '
        '_linkSubmitIncident
        '
        Me._linkSubmitIncident.AutoSize = True
        Me._linkSubmitIncident.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._linkSubmitIncident.Location = New System.Drawing.Point(222, 41)
        Me._linkSubmitIncident.Name = "_linkSubmitIncident"
        Me._linkSubmitIncident.Size = New System.Drawing.Size(93, 12)
        Me._linkSubmitIncident.TabIndex = 16
        Me._linkSubmitIncident.TabStop = True
        Me._linkSubmitIncident.Tag = "SubmitIncident"
        Me._linkSubmitIncident.Text = "Submit Incident"
        '
        '_linkHome
        '
        Me._linkHome.AutoSize = True
        Me._linkHome.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._linkHome.Location = New System.Drawing.Point(3, 3)
        Me._linkHome.Name = "_linkHome"
        Me._linkHome.Size = New System.Drawing.Size(38, 12)
        Me._linkHome.TabIndex = 8
        Me._linkHome.TabStop = True
        Me._linkHome.Tag = "default.aspx"
        Me._linkHome.Text = "Home"
        '
        '_linkSupport
        '
        Me._linkSupport.AutoSize = True
        Me._linkSupport.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._linkSupport.Location = New System.Drawing.Point(222, 22)
        Me._linkSupport.Name = "_linkSupport"
        Me._linkSupport.Size = New System.Drawing.Size(103, 12)
        Me._linkSupport.TabIndex = 15
        Me._linkSupport.TabStop = True
        Me._linkSupport.Tag = "SuperProducts/SupportServices"
        Me._linkSupport.Text = "Technical Support"
        '
        '_linkDownload
        '
        Me._linkDownload.AutoSize = True
        Me._linkDownload.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._linkDownload.Location = New System.Drawing.Point(98, 3)
        Me._linkDownload.Name = "_linkDownload"
        Me._linkDownload.Size = New System.Drawing.Size(99, 12)
        Me._linkDownload.TabIndex = 11
        Me._linkDownload.TabStop = True
        Me._linkDownload.Tag = "Downloads"
        Me._linkDownload.Text = "Download Center"
        '
        '_linkContactUs
        '
        Me._linkContactUs.AutoSize = True
        Me._linkContactUs.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._linkContactUs.Location = New System.Drawing.Point(3, 22)
        Me._linkContactUs.Name = "_linkContactUs"
        Me._linkContactUs.Size = New System.Drawing.Size(65, 12)
        Me._linkContactUs.TabIndex = 9
        Me._linkContactUs.TabStop = True
        Me._linkContactUs.Tag = "ContactUs"
        Me._linkContactUs.Text = "Contact Us"
        '
        '_linkVersionHistory
        '
        Me._linkVersionHistory.AutoSize = True
        Me._linkVersionHistory.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._linkVersionHistory.Location = New System.Drawing.Point(98, 41)
        Me._linkVersionHistory.Name = "_linkVersionHistory"
        Me._linkVersionHistory.Size = New System.Drawing.Size(88, 12)
        Me._linkVersionHistory.TabIndex = 13
        Me._linkVersionHistory.TabStop = True
        Me._linkVersionHistory.Tag = "Redirector/WebRedirector.aspx?RedirectCode=C1VersionHistory"
        Me._linkVersionHistory.Text = "Version History"
        '
        '_linkResellers
        '
        Me._linkResellers.AutoSize = True
        Me._linkResellers.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._linkResellers.Location = New System.Drawing.Point(3, 41)
        Me._linkResellers.Name = "_linkResellers"
        Me._linkResellers.Size = New System.Drawing.Size(56, 12)
        Me._linkResellers.TabIndex = 10
        Me._linkResellers.TabStop = True
        Me._linkResellers.Tag = "Resellers"
        Me._linkResellers.Text = "Resellers"
        '
        '_linkForums
        '
        Me._linkForums.AutoSize = True
        Me._linkForums.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._linkForums.Location = New System.Drawing.Point(222, 3)
        Me._linkForums.Name = "_linkForums"
        Me._linkForums.Size = New System.Drawing.Size(46, 12)
        Me._linkForums.TabIndex = 14
        Me._linkForums.TabStop = True
        Me._linkForums.Tag = "http://helpcentral.componentone.com/CS/forums/"
        Me._linkForums.Text = "Forums"
        '
        '_linkStore
        '
        Me._linkStore.AutoSize = True
        Me._linkStore.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._linkStore.Location = New System.Drawing.Point(98, 22)
        Me._linkStore.Name = "_linkStore"
        Me._linkStore.Size = New System.Drawing.Size(63, 12)
        Me._linkStore.TabIndex = 12
        Me._linkStore.TabStop = True
        Me._linkStore.Tag = "Store"
        Me._linkStore.Text = "Web Store"
        '
        'AboutForm
        '
        Me.AcceptButton = Me._btnOK
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me._btnOK
        Me.ClientSize = New System.Drawing.Size(546, 313)
        Me.ControlBox = False
        Me.Controls.Add(Me._panelResources)
        Me.Controls.Add(Me._lblInstalledComponents)
        Me.Controls.Add(Me._btnOK)
        Me.Controls.Add(Me._lblCopyright)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.pictureBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AboutForm"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me._panelResources.ResumeLayout(False)
        Me._panelResources.PerformLayout()
        Me._panelLinks.ResumeLayout(False)
        Me._panelLinks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents _lblCopyright As System.Windows.Forms.Label
    Friend WithEvents _btnOK As System.Windows.Forms.Button
    Friend WithEvents _lblInstalledComponents As System.Windows.Forms.TextBox
    Friend WithEvents _panelResources As System.Windows.Forms.Panel
    Friend WithEvents _lblResources As System.Windows.Forms.Label
    Friend WithEvents _panelLinks As System.Windows.Forms.Panel
    Friend WithEvents _linkSubmitIncident As System.Windows.Forms.LinkLabel
    Friend WithEvents _linkHome As System.Windows.Forms.LinkLabel
    Friend WithEvents _linkSupport As System.Windows.Forms.LinkLabel
    Friend WithEvents _linkDownload As System.Windows.Forms.LinkLabel
    Friend WithEvents _linkContactUs As System.Windows.Forms.LinkLabel
    Friend WithEvents _linkVersionHistory As System.Windows.Forms.LinkLabel
    Friend WithEvents _linkResellers As System.Windows.Forms.LinkLabel
    Friend WithEvents _linkForums As System.Windows.Forms.LinkLabel
    Friend WithEvents _linkStore As System.Windows.Forms.LinkLabel
End Class
