<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QrFormatter
    Inherits C1.Win.C1Ribbon.C1RibbonForm

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
        Me.components = New System.ComponentModel.Container()
        Dim RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QrFormatter))
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.RibbonTab1 = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.btnContact = New C1.Win.C1Ribbon.RibbonButton()
        Me.btnUrl = New C1.Win.C1Ribbon.RibbonButton()
        Me.btnSMS = New C1.Win.C1Ribbon.RibbonButton()
        Me.btnEmail = New C1.Win.C1Ribbon.RibbonButton()
        Me.btnPlainText = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonGroup2 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.btnCreateQRCode = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonGroup3 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.btnSaveImage = New C1.Win.C1Ribbon.RibbonButton()
        Me.btnCopyToClipboard = New C1.Win.C1Ribbon.RibbonButton()
        Me.btnPrint = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonGroup4 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.btnProperties = New C1.Win.C1Ribbon.RibbonButton()
        Me.bcQRCode = New C1.Win.C1BarCode.C1QRCode()
        Me.dckTab = New C1.Win.C1Command.C1DockingTab()
        Me.pgeContact = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtEmailAddress = New C1.Win.C1Input.C1TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtYear = New C1.Win.C1Input.C1TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMonth = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDay = New C1.Win.C1Input.C1TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMemo = New C1.Win.C1Input.C1TextBox()
        Me.txtCountry = New C1.Win.C1Input.C1TextBox()
        Me.txtPostcode = New C1.Win.C1Input.C1TextBox()
        Me.txtTown = New C1.Win.C1Input.C1TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStreet = New C1.Win.C1Input.C1TextBox()
        Me.txtWebsite = New C1.Win.C1Input.C1TextBox()
        Me.txtMobileTelephone = New C1.Win.C1Input.C1TextBox()
        Me.txtMainTelephone = New C1.Win.C1Input.C1TextBox()
        Me.txtLastName = New C1.Win.C1Input.C1TextBox()
        Me.txtFirstName = New C1.Win.C1Input.C1TextBox()
        Me.lblMemo = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelNo = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.pgeURL = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtFormWebsiteAddress = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pgeSMS = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtSMSMessage = New C1.Win.C1Input.C1TextBox()
        Me.txtSMSTelephoneNumber = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pgeEmail = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtBody = New C1.Win.C1Input.C1TextBox()
        Me.txtSubject = New C1.Win.C1Input.C1TextBox()
        Me.txtFormEmailAddress = New C1.Win.C1Input.C1TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pgeProperties = New C1.Win.C1Command.C1DockingTabPage()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.pgeIntro = New C1.Win.C1Command.C1DockingTabPage()
        Me.lblIntro = New C1.Win.C1SuperTooltip.C1SuperLabel()
        Me.pgePlainText = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtPlainText = New C1.Win.C1Input.C1TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.C1SuperTooltip2 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.epGood = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.epBad = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dckTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dckTab.SuspendLayout()
        Me.pgeContact.SuspendLayout()
        CType(Me.txtEmailAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStreet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWebsite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMobileTelephone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMainTelephone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgeURL.SuspendLayout()
        CType(Me.txtFormWebsiteAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgeSMS.SuspendLayout()
        CType(Me.txtSMSMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSMSTelephoneNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgeEmail.SuspendLayout()
        CType(Me.txtBody, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormEmailAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgeProperties.SuspendLayout()
        Me.pgeIntro.SuspendLayout()
        Me.pgePlainText.SuspendLayout()
        CType(Me.txtPlainText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epGood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epBad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonQat1
        '
        RibbonQat1.BelowRibbon = True
        RibbonQat1.Enabled = False
        RibbonQat1.Name = "RibbonQat1"
        RibbonQat1.Visible = False
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = RibbonQat1
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.C1Ribbon1.ToolTipSettings.Opacity = 0.8R
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.Name = "RibbonApplicationMenu1"
        Me.RibbonApplicationMenu1.Text = "File"
        Me.RibbonApplicationMenu1.Visible = False
        Me.RibbonApplicationMenu1.Win7Look = True
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.Name = "RibbonConfigToolBar1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup1)
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup2)
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup3)
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup4)
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Home"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Items.Add(Me.btnContact)
        Me.RibbonGroup1.Items.Add(Me.btnUrl)
        Me.RibbonGroup1.Items.Add(Me.btnSMS)
        Me.RibbonGroup1.Items.Add(Me.btnEmail)
        Me.RibbonGroup1.Items.Add(Me.btnPlainText)
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "Build QR Code Options"
        '
        'btnContact
        '
        Me.btnContact.LargeImage = CType(resources.GetObject("btnContact.LargeImage"), System.Drawing.Image)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.SmallImage = CType(resources.GetObject("btnContact.SmallImage"), System.Drawing.Image)
        Me.btnContact.Text = "Build Contact"
        Me.btnContact.ToolTip = resources.GetString("btnContact.ToolTip")
        '
        'btnUrl
        '
        Me.btnUrl.LargeImage = CType(resources.GetObject("btnUrl.LargeImage"), System.Drawing.Image)
        Me.btnUrl.Name = "btnUrl"
        Me.btnUrl.SmallImage = CType(resources.GetObject("btnUrl.SmallImage"), System.Drawing.Image)
        Me.btnUrl.Text = "Build URL"
        Me.btnUrl.ToolTip = resources.GetString("btnUrl.ToolTip")
        '
        'btnSMS
        '
        Me.btnSMS.LargeImage = CType(resources.GetObject("btnSMS.LargeImage"), System.Drawing.Image)
        Me.btnSMS.Name = "btnSMS"
        Me.btnSMS.SmallImage = CType(resources.GetObject("btnSMS.SmallImage"), System.Drawing.Image)
        Me.btnSMS.Text = "Build SMS"
        Me.btnSMS.ToolTip = resources.GetString("btnSMS.ToolTip")
        '
        'btnEmail
        '
        Me.btnEmail.LargeImage = CType(resources.GetObject("btnEmail.LargeImage"), System.Drawing.Image)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.SmallImage = CType(resources.GetObject("btnEmail.SmallImage"), System.Drawing.Image)
        Me.btnEmail.Text = "Build Email"
        Me.btnEmail.ToolTip = resources.GetString("btnEmail.ToolTip")
        '
        'btnPlainText
        '
        Me.btnPlainText.LargeImage = CType(resources.GetObject("btnPlainText.LargeImage"), System.Drawing.Image)
        Me.btnPlainText.Name = "btnPlainText"
        Me.btnPlainText.SmallImage = CType(resources.GetObject("btnPlainText.SmallImage"), System.Drawing.Image)
        Me.btnPlainText.Text = "Build Plain Text"
        Me.btnPlainText.ToolTip = resources.GetString("btnPlainText.ToolTip")
        '
        'RibbonGroup2
        '
        Me.RibbonGroup2.Items.Add(Me.btnCreateQRCode)
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "Create QR Code"
        '
        'btnCreateQRCode
        '
        Me.btnCreateQRCode.LargeImage = CType(resources.GetObject("btnCreateQRCode.LargeImage"), System.Drawing.Image)
        Me.btnCreateQRCode.Name = "btnCreateQRCode"
        Me.btnCreateQRCode.SmallImage = CType(resources.GetObject("btnCreateQRCode.SmallImage"), System.Drawing.Image)
        Me.btnCreateQRCode.Text = "Create QR Code"
        '
        'RibbonGroup3
        '
        Me.RibbonGroup3.Items.Add(Me.btnSaveImage)
        Me.RibbonGroup3.Items.Add(Me.btnCopyToClipboard)
        Me.RibbonGroup3.Items.Add(Me.btnPrint)
        Me.RibbonGroup3.Name = "RibbonGroup3"
        Me.RibbonGroup3.Text = "Save QR Code"
        '
        'btnSaveImage
        '
        Me.btnSaveImage.LargeImage = CType(resources.GetObject("btnSaveImage.LargeImage"), System.Drawing.Image)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.SmallImage = CType(resources.GetObject("btnSaveImage.SmallImage"), System.Drawing.Image)
        Me.btnSaveImage.Text = "Save as Image"
        '
        'btnCopyToClipboard
        '
        Me.btnCopyToClipboard.LargeImage = CType(resources.GetObject("btnCopyToClipboard.LargeImage"), System.Drawing.Image)
        Me.btnCopyToClipboard.Name = "btnCopyToClipboard"
        Me.btnCopyToClipboard.SmallImage = CType(resources.GetObject("btnCopyToClipboard.SmallImage"), System.Drawing.Image)
        Me.btnCopyToClipboard.Text = "Copy Text to Clipboard"
        '
        'btnPrint
        '
        Me.btnPrint.LargeImage = CType(resources.GetObject("btnPrint.LargeImage"), System.Drawing.Image)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.SmallImage = CType(resources.GetObject("btnPrint.SmallImage"), System.Drawing.Image)
        Me.btnPrint.Text = "Print QR Code"
        '
        'RibbonGroup4
        '
        Me.RibbonGroup4.Items.Add(Me.btnProperties)
        Me.RibbonGroup4.Name = "RibbonGroup4"
        Me.RibbonGroup4.Text = "QR Code Properties"
        '
        'btnProperties
        '
        Me.btnProperties.LargeImage = CType(resources.GetObject("btnProperties.LargeImage"), System.Drawing.Image)
        Me.btnProperties.Name = "btnProperties"
        Me.btnProperties.SmallImage = CType(resources.GetObject("btnProperties.SmallImage"), System.Drawing.Image)
        Me.btnProperties.Text = "View QR Code Properties"
        '
        'bcQRCode
        '
        Me.bcQRCode.Location = New System.Drawing.Point(12, 211)
        Me.bcQRCode.Name = "bcQRCode"
        Me.bcQRCode.Size = New System.Drawing.Size(85, 85)
        Me.bcQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bcQRCode.SymbolSize = 4
        Me.bcQRCode.TabIndex = 1
        Me.bcQRCode.Text = "C1QRCode1"
        Me.C1SuperTooltip1.SetToolTip(Me.bcQRCode, "This image may be scanned with<br/>free QR reader applications<br/>available for " & _
        "most smart phones.")
        '
        'dckTab
        '
        Me.dckTab.Controls.Add(Me.pgeContact)
        Me.dckTab.Controls.Add(Me.pgeURL)
        Me.dckTab.Controls.Add(Me.pgeSMS)
        Me.dckTab.Controls.Add(Me.pgeEmail)
        Me.dckTab.Controls.Add(Me.pgeProperties)
        Me.dckTab.Controls.Add(Me.pgeIntro)
        Me.dckTab.Controls.Add(Me.pgePlainText)
        Me.dckTab.Location = New System.Drawing.Point(259, 168)
        Me.dckTab.Name = "dckTab"
        Me.dckTab.SelectedIndex = 6
        Me.dckTab.Size = New System.Drawing.Size(524, 398)
        Me.dckTab.TabIndex = 2
        Me.dckTab.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.dckTab.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Silver
        Me.dckTab.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Silver
        '
        'pgeContact
        '
        Me.pgeContact.Controls.Add(Me.txtEmailAddress)
        Me.pgeContact.Controls.Add(Me.Label15)
        Me.pgeContact.Controls.Add(Me.txtYear)
        Me.pgeContact.Controls.Add(Me.Label14)
        Me.pgeContact.Controls.Add(Me.txtMonth)
        Me.pgeContact.Controls.Add(Me.Label13)
        Me.pgeContact.Controls.Add(Me.txtDay)
        Me.pgeContact.Controls.Add(Me.Label12)
        Me.pgeContact.Controls.Add(Me.Label11)
        Me.pgeContact.Controls.Add(Me.txtMemo)
        Me.pgeContact.Controls.Add(Me.txtCountry)
        Me.pgeContact.Controls.Add(Me.txtPostcode)
        Me.pgeContact.Controls.Add(Me.txtTown)
        Me.pgeContact.Controls.Add(Me.Label10)
        Me.pgeContact.Controls.Add(Me.Label9)
        Me.pgeContact.Controls.Add(Me.Label8)
        Me.pgeContact.Controls.Add(Me.Label7)
        Me.pgeContact.Controls.Add(Me.txtStreet)
        Me.pgeContact.Controls.Add(Me.txtWebsite)
        Me.pgeContact.Controls.Add(Me.txtMobileTelephone)
        Me.pgeContact.Controls.Add(Me.txtMainTelephone)
        Me.pgeContact.Controls.Add(Me.txtLastName)
        Me.pgeContact.Controls.Add(Me.txtFirstName)
        Me.pgeContact.Controls.Add(Me.lblMemo)
        Me.pgeContact.Controls.Add(Me.lblAddress)
        Me.pgeContact.Controls.Add(Me.lblWebsite)
        Me.pgeContact.Controls.Add(Me.lblEmail)
        Me.pgeContact.Controls.Add(Me.lblTelNo)
        Me.pgeContact.Controls.Add(Me.lblFullName)
        Me.pgeContact.Location = New System.Drawing.Point(1, 24)
        Me.pgeContact.Name = "pgeContact"
        Me.pgeContact.Size = New System.Drawing.Size(522, 373)
        Me.pgeContact.TabIndex = 0
        Me.pgeContact.Text = "Build Contact Details"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.epGood.SetIconPadding(Me.txtEmailAddress, 5)
        Me.epBad.SetIconPadding(Me.txtEmailAddress, 5)
        Me.txtEmailAddress.Location = New System.Drawing.Point(190, 127)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(210, 18)
        Me.txtEmailAddress.TabIndex = 4
        Me.txtEmailAddress.Tag = Nothing
        Me.txtEmailAddress.TextDetached = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "E Mail Address:"
        '
        'txtYear
        '
        Me.txtYear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYear.Location = New System.Drawing.Point(362, 343)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(38, 18)
        Me.txtYear.TabIndex = 13
        Me.txtYear.Tag = Nothing
        Me.txtYear.TextDetached = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(324, 347)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Year:"
        '
        'txtMonth
        '
        Me.txtMonth.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonth.Location = New System.Drawing.Point(281, 343)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(30, 18)
        Me.txtMonth.TabIndex = 12
        Me.txtMonth.Tag = Nothing
        Me.txtMonth.TextDetached = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(235, 348)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Month:"
        '
        'txtDay
        '
        Me.txtDay.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDay.Location = New System.Drawing.Point(190, 342)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(30, 18)
        Me.txtDay.TabIndex = 11
        Me.txtDay.Tag = Nothing
        Me.txtDay.TextDetached = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(155, 347)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Day:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 342)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Birthday:"
        '
        'txtMemo
        '
        Me.txtMemo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemo.Location = New System.Drawing.Point(190, 295)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(210, 37)
        Me.txtMemo.TabIndex = 10
        Me.txtMemo.Tag = Nothing
        Me.txtMemo.TextDetached = True
        '
        'txtCountry
        '
        Me.txtCountry.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountry.Location = New System.Drawing.Point(190, 267)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(100, 18)
        Me.txtCountry.TabIndex = 9
        Me.txtCountry.Tag = Nothing
        Me.txtCountry.TextDetached = True
        '
        'txtPostcode
        '
        Me.txtPostcode.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPostcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPostcode.Location = New System.Drawing.Point(190, 239)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(100, 18)
        Me.txtPostcode.TabIndex = 8
        Me.txtPostcode.Tag = Nothing
        Me.txtPostcode.TextDetached = True
        '
        'txtTown
        '
        Me.txtTown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTown.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTown.Location = New System.Drawing.Point(190, 211)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(100, 18)
        Me.txtTown.TabIndex = 7
        Me.txtTown.Tag = Nothing
        Me.txtTown.TextDetached = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Country:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Post / Zip Code:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Town / City:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "House No. and Street:"
        '
        'txtStreet
        '
        Me.txtStreet.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreet.Location = New System.Drawing.Point(190, 183)
        Me.txtStreet.Multiline = True
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(210, 18)
        Me.txtStreet.TabIndex = 6
        Me.txtStreet.Tag = Nothing
        Me.txtStreet.TextDetached = True
        '
        'txtWebsite
        '
        Me.txtWebsite.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtWebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWebsite.Location = New System.Drawing.Point(190, 155)
        Me.txtWebsite.Multiline = True
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(210, 18)
        Me.txtWebsite.TabIndex = 5
        Me.txtWebsite.Tag = Nothing
        Me.txtWebsite.TextDetached = True
        '
        'txtMobileTelephone
        '
        Me.txtMobileTelephone.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtMobileTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileTelephone.Location = New System.Drawing.Point(190, 99)
        Me.txtMobileTelephone.Name = "txtMobileTelephone"
        Me.txtMobileTelephone.Size = New System.Drawing.Size(152, 18)
        Me.txtMobileTelephone.TabIndex = 3
        Me.txtMobileTelephone.Tag = Nothing
        Me.txtMobileTelephone.TextDetached = True
        '
        'txtMainTelephone
        '
        Me.txtMainTelephone.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtMainTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMainTelephone.Location = New System.Drawing.Point(190, 71)
        Me.txtMainTelephone.Name = "txtMainTelephone"
        Me.txtMainTelephone.Size = New System.Drawing.Size(152, 18)
        Me.txtMainTelephone.TabIndex = 2
        Me.txtMainTelephone.Tag = Nothing
        Me.txtMainTelephone.TextDetached = True
        '
        'txtLastName
        '
        Me.txtLastName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Location = New System.Drawing.Point(190, 43)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(152, 18)
        Me.txtLastName.TabIndex = 1
        Me.txtLastName.Tag = Nothing
        Me.txtLastName.TextDetached = True
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Location = New System.Drawing.Point(190, 15)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(152, 18)
        Me.txtFirstName.TabIndex = 0
        Me.txtFirstName.Tag = Nothing
        Me.txtFirstName.TextDetached = True
        '
        'lblMemo
        '
        Me.lblMemo.AutoSize = True
        Me.lblMemo.Location = New System.Drawing.Point(14, 295)
        Me.lblMemo.Name = "lblMemo"
        Me.lblMemo.Size = New System.Drawing.Size(39, 13)
        Me.lblMemo.TabIndex = 5
        Me.lblMemo.Text = "Memo:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(14, 155)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(49, 13)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Website:"
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Location = New System.Drawing.Point(14, 99)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(95, 13)
        Me.lblWebsite.TabIndex = 3
        Me.lblWebsite.Text = "Mobile Telephone:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(14, 71)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(87, 13)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Main Telephone:"
        '
        'lblTelNo
        '
        Me.lblTelNo.AutoSize = True
        Me.lblTelNo.Location = New System.Drawing.Point(14, 43)
        Me.lblTelNo.Name = "lblTelNo"
        Me.lblTelNo.Size = New System.Drawing.Size(61, 13)
        Me.lblTelNo.TabIndex = 1
        Me.lblTelNo.Text = "Last Name:"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(14, 15)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(60, 13)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "First Name:"
        '
        'pgeURL
        '
        Me.pgeURL.Controls.Add(Me.txtFormWebsiteAddress)
        Me.pgeURL.Controls.Add(Me.Label1)
        Me.pgeURL.Location = New System.Drawing.Point(1, 24)
        Me.pgeURL.Name = "pgeURL"
        Me.pgeURL.Size = New System.Drawing.Size(522, 373)
        Me.pgeURL.TabIndex = 1
        Me.pgeURL.Text = "Build URL"
        '
        'txtFormWebsiteAddress
        '
        Me.txtFormWebsiteAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtFormWebsiteAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFormWebsiteAddress.Location = New System.Drawing.Point(52, 43)
        Me.txtFormWebsiteAddress.Name = "txtFormWebsiteAddress"
        Me.txtFormWebsiteAddress.Size = New System.Drawing.Size(455, 18)
        Me.txtFormWebsiteAddress.TabIndex = 1
        Me.txtFormWebsiteAddress.Tag = Nothing
        Me.txtFormWebsiteAddress.TextDetached = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "URL:"
        '
        'pgeSMS
        '
        Me.pgeSMS.Controls.Add(Me.txtSMSMessage)
        Me.pgeSMS.Controls.Add(Me.txtSMSTelephoneNumber)
        Me.pgeSMS.Controls.Add(Me.Label3)
        Me.pgeSMS.Controls.Add(Me.Label2)
        Me.pgeSMS.Location = New System.Drawing.Point(1, 24)
        Me.pgeSMS.Name = "pgeSMS"
        Me.pgeSMS.Size = New System.Drawing.Size(522, 373)
        Me.pgeSMS.TabIndex = 2
        Me.pgeSMS.Text = "Build SMS"
        '
        'txtSMSMessage
        '
        Me.txtSMSMessage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtSMSMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.epGood.SetError(Me.txtSMSMessage, " ")
        Me.epGood.SetIconPadding(Me.txtSMSMessage, 5)
        Me.epBad.SetIconPadding(Me.txtSMSMessage, 5)
        Me.txtSMSMessage.Location = New System.Drawing.Point(190, 93)
        Me.txtSMSMessage.Multiline = True
        Me.txtSMSMessage.Name = "txtSMSMessage"
        Me.txtSMSMessage.Size = New System.Drawing.Size(210, 139)
        Me.txtSMSMessage.TabIndex = 3
        Me.txtSMSMessage.Tag = Nothing
        Me.txtSMSMessage.TextDetached = True
        '
        'txtSMSTelephoneNumber
        '
        Me.txtSMSTelephoneNumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtSMSTelephoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSMSTelephoneNumber.Location = New System.Drawing.Point(190, 45)
        Me.txtSMSTelephoneNumber.Name = "txtSMSTelephoneNumber"
        Me.txtSMSTelephoneNumber.Size = New System.Drawing.Size(132, 18)
        Me.txtSMSTelephoneNumber.TabIndex = 2
        Me.txtSMSTelephoneNumber.Tag = Nothing
        Me.txtSMSTelephoneNumber.TextDetached = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "SMS Message Body:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Telephone Number:"
        '
        'pgeEmail
        '
        Me.pgeEmail.Controls.Add(Me.txtBody)
        Me.pgeEmail.Controls.Add(Me.txtSubject)
        Me.pgeEmail.Controls.Add(Me.txtFormEmailAddress)
        Me.pgeEmail.Controls.Add(Me.Label6)
        Me.pgeEmail.Controls.Add(Me.Label5)
        Me.pgeEmail.Controls.Add(Me.Label4)
        Me.pgeEmail.Location = New System.Drawing.Point(1, 24)
        Me.pgeEmail.Name = "pgeEmail"
        Me.pgeEmail.Size = New System.Drawing.Size(522, 373)
        Me.pgeEmail.TabIndex = 3
        Me.pgeEmail.Text = "Build E Mail Form"
        '
        'txtBody
        '
        Me.txtBody.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBody.Location = New System.Drawing.Point(190, 127)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(247, 138)
        Me.txtBody.TabIndex = 5
        Me.txtBody.Tag = Nothing
        Me.txtBody.TextDetached = True
        '
        'txtSubject
        '
        Me.txtSubject.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubject.Location = New System.Drawing.Point(190, 85)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(247, 18)
        Me.txtSubject.TabIndex = 4
        Me.txtSubject.Tag = Nothing
        Me.txtSubject.TextDetached = True
        '
        'txtFormEmailAddress
        '
        Me.txtFormEmailAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtFormEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFormEmailAddress.Location = New System.Drawing.Point(190, 43)
        Me.txtFormEmailAddress.Name = "txtFormEmailAddress"
        Me.txtFormEmailAddress.Size = New System.Drawing.Size(210, 18)
        Me.txtFormEmailAddress.TabIndex = 3
        Me.txtFormEmailAddress.Tag = Nothing
        Me.txtFormEmailAddress.TextDetached = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Body:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Subject:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "E mail Address:"
        '
        'pgeProperties
        '
        Me.pgeProperties.Controls.Add(Me.PropertyGrid1)
        Me.pgeProperties.Location = New System.Drawing.Point(1, 24)
        Me.pgeProperties.Name = "pgeProperties"
        Me.pgeProperties.Size = New System.Drawing.Size(522, 373)
        Me.pgeProperties.TabIndex = 4
        Me.pgeProperties.Text = "QR Code Properties"
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.SelectedObject = Me.bcQRCode
        Me.PropertyGrid1.Size = New System.Drawing.Size(522, 373)
        Me.PropertyGrid1.TabIndex = 0
        '
        'pgeIntro
        '
        Me.pgeIntro.Controls.Add(Me.lblIntro)
        Me.pgeIntro.Location = New System.Drawing.Point(1, 24)
        Me.pgeIntro.Name = "pgeIntro"
        Me.pgeIntro.Size = New System.Drawing.Size(522, 373)
        Me.pgeIntro.TabIndex = 5
        Me.pgeIntro.Text = "Intro"
        '
        'lblIntro
        '
        Me.lblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.Location = New System.Drawing.Point(45, 120)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(433, 132)
        Me.lblIntro.TabIndex = 0
        Me.lblIntro.Text = resources.GetString("lblIntro.Text")
        Me.lblIntro.UseMnemonic = True
        '
        'pgePlainText
        '
        Me.pgePlainText.Controls.Add(Me.txtPlainText)
        Me.pgePlainText.Controls.Add(Me.Label16)
        Me.pgePlainText.Location = New System.Drawing.Point(1, 24)
        Me.pgePlainText.Name = "pgePlainText"
        Me.pgePlainText.Size = New System.Drawing.Size(522, 373)
        Me.pgePlainText.TabIndex = 6
        Me.pgePlainText.Text = "Plain Text"
        '
        'txtPlainText
        '
        Me.txtPlainText.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtPlainText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.epGood.SetIconPadding(Me.txtPlainText, 5)
        Me.epBad.SetIconPadding(Me.txtPlainText, 5)
        Me.txtPlainText.Location = New System.Drawing.Point(17, 54)
        Me.txtPlainText.Multiline = True
        Me.txtPlainText.Name = "txtPlainText"
        Me.txtPlainText.Size = New System.Drawing.Size(460, 292)
        Me.txtPlainText.TabIndex = 1
        Me.txtPlainText.Tag = Nothing
        Me.txtPlainText.TextDetached = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(270, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Add the text you want to convey in the QR Code below:"
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        '
        'C1SuperTooltip2
        '
        Me.C1SuperTooltip2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        '
        'epGood
        '
        Me.epGood.BlinkCount = 1
        Me.epGood.BlinkRate = 50
        Me.epGood.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epGood.ContainerControl = Me
        Me.epGood.Icon = CType(resources.GetObject("epGood.Icon"), System.Drawing.Icon)
        Me.epGood.Image = CType(resources.GetObject("epGood.Image"), System.Drawing.Image)
        Me.epGood.ToolTip = Me.C1SuperTooltip2
        '
        'epBad
        '
        Me.epBad.BlinkCount = 1
        Me.epBad.BlinkRate = 50
        Me.epBad.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epBad.ContainerControl = Me
        Me.epBad.Icon = CType(resources.GetObject("epBad.Icon"), System.Drawing.Icon)
        Me.epBad.Image = CType(resources.GetObject("epBad.Image"), System.Drawing.Image)
        Me.epBad.ToolTip = Me.C1SuperTooltip2
        '
        'QrFormatter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 585)
        Me.Controls.Add(Me.dckTab)
        Me.Controls.Add(Me.bcQRCode)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QrFormatter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quick Response Code Builder"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dckTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dckTab.ResumeLayout(False)
        Me.pgeContact.ResumeLayout(False)
        Me.pgeContact.PerformLayout()
        CType(Me.txtEmailAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStreet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWebsite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMobileTelephone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMainTelephone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgeURL.ResumeLayout(False)
        Me.pgeURL.PerformLayout()
        CType(Me.txtFormWebsiteAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgeSMS.ResumeLayout(False)
        Me.pgeSMS.PerformLayout()
        CType(Me.txtSMSMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSMSTelephoneNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgeEmail.ResumeLayout(False)
        Me.pgeEmail.PerformLayout()
        CType(Me.txtBody, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormEmailAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgeProperties.ResumeLayout(False)
        Me.pgeIntro.ResumeLayout(False)
        Me.pgePlainText.ResumeLayout(False)
        Me.pgePlainText.PerformLayout()
        CType(Me.txtPlainText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epGood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epBad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonTab1 As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents dckTab As C1.Win.C1Command.C1DockingTab
    Friend WithEvents pgeContact As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pgeURL As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pgeSMS As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pgeEmail As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pgeProperties As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents bcQRCode As C1.Win.C1BarCode.C1QRCode
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtStreet As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtWebsite As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtMobileTelephone As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtMainTelephone As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtLastName As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtFirstName As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblMemo As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblWebsite As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblTelNo As System.Windows.Forms.Label
    Friend WithEvents btnContact As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents btnUrl As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents btnSMS As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents btnEmail As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonGroup2 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents btnCreateQRCode As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonGroup3 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents btnSaveImage As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents btnCopyToClipboard As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonGroup4 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents btnProperties As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents pgeIntro As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents lblIntro As C1.Win.C1SuperTooltip.C1SuperLabel
    Friend WithEvents txtFormWebsiteAddress As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSMSMessage As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtSMSTelephoneNumber As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBody As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtSubject As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtFormEmailAddress As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMemo As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCountry As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtPostcode As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtTown As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtYear As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMonth As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDay As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEmailAddress As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnPlainText As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents pgePlainText As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents txtPlainText As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Private WithEvents epGood As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Private WithEvents C1SuperTooltip2 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Private WithEvents epBad As C1.Win.C1SuperTooltip.C1SuperErrorProvider

End Class
