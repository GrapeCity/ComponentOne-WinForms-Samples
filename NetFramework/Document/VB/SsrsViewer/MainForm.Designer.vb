Imports C1.Win.Ribbon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits C1RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.c1SsrsDocumentSource1 = New C1.Win.C1Document.C1SSRSDocumentSource()
        Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
        Me.bwListReports = New System.ComponentModel.BackgroundWorker()
        Me.connPanel = New System.Windows.Forms.Panel()
        Me.btnShowReport = New System.Windows.Forms.Button()
        Me.btnHideReport = New System.Windows.Forms.Button()
        Me.tvReports = New System.Windows.Forms.TreeView()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.tbDomain = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbUserName = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbSSRSServer = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.spMain = New System.Windows.Forms.Splitter()
        Me.c1FlexViewer1 = New C1.Win.FlexViewer.C1FlexViewer()
        Me.connPanel.SuspendLayout()
        Me.gbLogin.SuspendLayout()
        CType(Me.c1FlexViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1SsrsDocumentSource1
        '
        Me.c1SsrsDocumentSource1.Language = New System.Globalization.CultureInfo("en-US")
        '
        'ilMain
        '
        Me.ilMain.ImageStream = CType(resources.GetObject("ilMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilMain.TransparentColor = System.Drawing.Color.Transparent
        Me.ilMain.Images.SetKeyName(0, "Folder.png")
        Me.ilMain.Images.SetKeyName(1, "CreateReportBlankReport.png")
        Me.ilMain.Images.SetKeyName(2, "RecurrenceEdit.png")
        Me.ilMain.Images.SetKeyName(3, "Connection.png")
        '
        'bwListReports
        '
        Me.bwListReports.WorkerSupportsCancellation = True
        '
        'connPanel
        '
        Me.connPanel.Controls.Add(Me.btnShowReport)
        Me.connPanel.Controls.Add(Me.btnHideReport)
        Me.connPanel.Controls.Add(Me.tvReports)
        Me.connPanel.Controls.Add(Me.btnOpen)
        Me.connPanel.Controls.Add(Me.gbLogin)
        Me.connPanel.Controls.Add(Me.tbSSRSServer)
        Me.connPanel.Controls.Add(Me.label1)
        Me.connPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.connPanel.Location = New System.Drawing.Point(0, 0)
        Me.connPanel.Name = "connPanel"
        Me.connPanel.Size = New System.Drawing.Size(290, 602)
        Me.connPanel.TabIndex = 1
        '
        'btnShowReport
        '
        Me.btnShowReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowReport.Location = New System.Drawing.Point(194, 573)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(89, 23)
        Me.btnShowReport.TabIndex = 7
        Me.btnShowReport.Text = "Show Report"
        Me.btnShowReport.UseVisualStyleBackColor = True
        '
        'btnHideReport
        '
        Me.btnHideReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHideReport.Enabled = False
        Me.btnHideReport.Location = New System.Drawing.Point(8, 573)
        Me.btnHideReport.Name = "btnHideReport"
        Me.btnHideReport.Size = New System.Drawing.Size(89, 23)
        Me.btnHideReport.TabIndex = 6
        Me.btnHideReport.Text = "Hide Report"
        Me.btnHideReport.UseVisualStyleBackColor = True
        '
        'tvReports
        '
        Me.tvReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvReports.HideSelection = False
        Me.tvReports.ImageIndex = 0
        Me.tvReports.ImageList = Me.ilMain
        Me.tvReports.Location = New System.Drawing.Point(8, 193)
        Me.tvReports.Name = "tvReports"
        Me.tvReports.SelectedImageIndex = 0
        Me.tvReports.Size = New System.Drawing.Size(275, 374)
        Me.tvReports.TabIndex = 5
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(208, 164)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 4
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'gbLogin
        '
        Me.gbLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLogin.Controls.Add(Me.tbDomain)
        Me.gbLogin.Controls.Add(Me.tbPassword)
        Me.gbLogin.Controls.Add(Me.tbUserName)
        Me.gbLogin.Controls.Add(Me.label4)
        Me.gbLogin.Controls.Add(Me.label3)
        Me.gbLogin.Controls.Add(Me.label2)
        Me.gbLogin.Location = New System.Drawing.Point(8, 53)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(274, 105)
        Me.gbLogin.TabIndex = 2
        Me.gbLogin.TabStop = False
        Me.gbLogin.Text = " Login information: "
        '
        'tbDomain
        '
        Me.tbDomain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDomain.Location = New System.Drawing.Point(80, 73)
        Me.tbDomain.Name = "tbDomain"
        Me.tbDomain.Size = New System.Drawing.Size(184, 23)
        Me.tbDomain.TabIndex = 5
        '
        'tbPassword
        '
        Me.tbPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPassword.Location = New System.Drawing.Point(80, 47)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(184, 23)
        Me.tbPassword.TabIndex = 3
        '
        'tbUserName
        '
        Me.tbUserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbUserName.Location = New System.Drawing.Point(80, 21)
        Me.tbUserName.Name = "tbUserName"
        Me.tbUserName.Size = New System.Drawing.Size(184, 23)
        Me.tbUserName.TabIndex = 1
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(6, 75)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(52, 15)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Domain:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 49)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(60, 15)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Password:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 23)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(68, 15)
        Me.label2.TabIndex = 0
        Me.label2.Text = "User Name:"
        '
        'tbSSRSServer
        '
        Me.tbSSRSServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSSRSServer.Location = New System.Drawing.Point(8, 25)
        Me.tbSSRSServer.Name = "tbSSRSServer"
        Me.tbSSRSServer.Size = New System.Drawing.Size(275, 23)
        Me.tbSSRSServer.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(7, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(70, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "SSRS Server:"
        '
        'spMain
        '
        Me.spMain.BackColor = System.Drawing.Color.LightGray
        Me.spMain.Location = New System.Drawing.Point(290, 0)
        Me.spMain.Name = "spMain"
        Me.spMain.Size = New System.Drawing.Size(4, 602)
        Me.spMain.TabIndex = 2
        Me.spMain.TabStop = False
        '
        'c1FlexViewer1
        '
        Me.c1FlexViewer1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.c1FlexViewer1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.c1FlexViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1FlexViewer1.Location = New System.Drawing.Point(294, 0)
        Me.c1FlexViewer1.Name = "c1FlexViewer1"
        Me.c1FlexViewer1.Size = New System.Drawing.Size(760, 602)
        Me.c1FlexViewer1.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1054, 602)
        Me.Controls.Add(Me.c1FlexViewer1)
        Me.Controls.Add(Me.spMain)
        Me.Controls.Add(Me.connPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "SSRS Report Viewer"
        Me.connPanel.ResumeLayout(False)
        Me.connPanel.PerformLayout()
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        CType(Me.c1FlexViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents c1SsrsDocumentSource1 As C1.Win.C1Document.C1SSRSDocumentSource
    Private WithEvents ilMain As ImageList
    Private WithEvents bwListReports As System.ComponentModel.BackgroundWorker
    Private WithEvents connPanel As Panel
    Private WithEvents btnShowReport As Button
    Private WithEvents btnHideReport As Button
    Private WithEvents tvReports As TreeView
    Private WithEvents btnOpen As Button
    Private WithEvents gbLogin As GroupBox
    Private WithEvents tbDomain As TextBox
    Private WithEvents tbPassword As TextBox
    Private WithEvents tbUserName As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents tbSSRSServer As TextBox
    Private WithEvents label1 As Label
    Private WithEvents spMain As Splitter
    Private WithEvents c1FlexViewer1 As C1.Win.FlexViewer.C1FlexViewer
End Class
