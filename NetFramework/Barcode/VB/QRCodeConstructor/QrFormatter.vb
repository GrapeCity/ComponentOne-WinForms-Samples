Imports C1.Win.C1Win7Pack
Imports System.Drawing.Printing
Imports System.Drawing.Imaging
Imports System.IO


Public Class QrFormatter

#Region "Fields"
    Private Shared _CodeBuilt As Boolean
    Private Shared _CodeToBuild As String = String.Empty
    Private Shared _TextPresent As Boolean
    Private Shared _QRText As String
    Private Shared _item As Integer
    Private Const MAX_LENGTH As Integer = 271
#End Region

#Region "Form Initialisation"



    Private Sub QrFormatter_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisableButtons()
        SetBackColourOfLabels(Me, dckTab.TabPages(0).BackColor)
        lblIntro.BackColor = dckTab.TabPages(0).BackColor
        dckTab.ShowTabs = False
        pgeIntro.Visible = True
    End Sub

    Private Shared Sub SetBackColourOfLabels(ByVal ctrlParent As Control, ByVal clr As Color)
        'just makes the labels a little more visually appealing on the tabs
        For Each ctrl As Control In ctrlParent.Controls
            If TypeOf ctrl Is Label Then
                ctrl.BackColor = clr
            End If
            If ctrl.HasChildren Then
                SetBackColourOfLabels(ctrl, clr)
            End If
        Next
    End Sub
#End Region

#Region "Tab Selection"

    Private Shared Sub ClearTextFromTabPageControls(ByVal ctrlParent As Control)
        For Each ctrl As Control In ctrlParent.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = String.Empty
            End If
            If ctrl.HasChildren Then
                ClearTextFromTabPageControls(ctrl)
            End If
        Next
    End Sub

    Private Sub DisableButtons()
        btnCopyToClipboard.Enabled = False
        btnSaveImage.Enabled = False
        btnPrint.Enabled = False
    End Sub

    Private Sub EnableButtons()
        btnCopyToClipboard.Enabled = True
        btnSaveImage.Enabled = True
        btnPrint.Enabled = True
    End Sub
    Private Sub GotToTab(ByVal sender As Object)
        Select Case sender
            Case btnContact
                pgeContact.Visible = True
            Case btnEmail
                pgeEmail.Visible = True
            Case btnSMS
                pgeSMS.Visible = True
            Case btnUrl
                pgeURL.Visible = True
            Case btnPlainText
                pgePlainText.Visible = True
            Case Else
                pgeProperties.Visible = True
        End Select
    End Sub

    Private Shared Sub RunThroughTextBoxes(ByVal ctrlParent As Control)
        For Each ctrl As Control In ctrlParent.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Text.Count > 0 Then
                    _TextPresent = True
                End If
            End If
            If ctrl.HasChildren Then
                RunThroughTextBoxes(ctrl)
            End If
        Next
    End Sub
    Public Sub SelectTabPage(sender As Object, e As EventArgs) Handles btnContact.Click, btnEmail.Click, btnSMS.Click, btnUrl.Click, btnProperties.Click, btnPlainText.Click
        If pgeProperties.Visible Then
            GotToTab(sender)
        Else
            If _CodeToBuild <> String.Empty Then
                If _CodeToBuild = "URL" Then
                    If Trim(txtFormWebsiteAddress.Text) = "http://" Then
                        SetupTab(sender)
                        Return
                    End If
                End If
                _TextPresent = False
                RunThroughTextBoxes(dckTab)
                SetupTabCarefully(sender)
            Else
                SetupTab(sender)
            End If
        End If
    End Sub

    Private Sub SetupTab(ByVal sender As Object)
        Select Case sender
            Case btnContact
                DisableButtons()
                epBad.SetError(txtEmailAddress, "")
                epGood.SetError(txtEmailAddress, "")
                pgeContact.Visible = True
                ClearTextFromTabPageControls(dckTab)
                _CodeToBuild = "Contact"
                txtFirstName.Focus()

            Case btnEmail
                DisableButtons()
                epBad.SetError(txtFormEmailAddress, "")
                epGood.SetError(txtFormEmailAddress, "")
                pgeEmail.Visible = True
                ClearTextFromTabPageControls(dckTab)
                _CodeToBuild = "Email"
                txtFormEmailAddress.Focus()
            Case btnSMS
                DisableButtons()
                epBad.SetError(txtSMSMessage, "")
                epGood.SetError(txtSMSMessage, "")
                pgeSMS.Visible = True
                ClearTextFromTabPageControls(dckTab)
                _CodeToBuild = "SMS"
                txtSMSTelephoneNumber.Focus()
            Case btnUrl
                DisableButtons()
                pgeURL.Visible = True
                ClearTextFromTabPageControls(dckTab)
                txtFormWebsiteAddress.Text = "http://"
                _CodeToBuild = "URL"
            Case btnPlainText
                DisableButtons()
                epBad.SetError(txtPlainText, "")
                epGood.SetError(txtPlainText, "")
                pgePlainText.Visible = True
                ClearTextFromTabPageControls(dckTab)
                _CodeToBuild = "PlainText"
                txtPlainText.Focus()
            Case btnProperties
                pgeProperties.Visible = True
            Case Else
                pgeContact.Visible = True
                ClearTextFromTabPageControls(dckTab)
        End Select
    End Sub
    Private Sub SetupTabCarefully(ByVal sender As Object)
        Select Case sender
            Case btnContact
                If _TextPresent Then
                    CallDecissionDialog(pgeContact, "Contact")
                    epBad.SetError(txtEmailAddress, "")
                    epGood.SetError(txtEmailAddress, "")
                    txtFirstName.Focus()
                Else
                    SetupTab(sender)
                End If

            Case btnEmail
                If _TextPresent Then
                    CallDecissionDialog(pgeEmail, "Email")
                    epBad.SetError(txtFormEmailAddress, "")
                    epGood.SetError(txtFormEmailAddress, "")
                    txtFormEmailAddress.Focus()
                Else
                    SetupTab(sender)
                End If
            Case btnSMS
                If _TextPresent Then
                    CallDecissionDialog(pgeSMS, "SMS")
                    epBad.SetError(txtSMSMessage, "")
                    epGood.SetError(txtSMSMessage, "")
                    txtSMSTelephoneNumber.Focus()
                Else
                    SetupTab(sender)
                End If
            Case btnUrl
                If _TextPresent Then
                    CallDecissionDialog(pgeURL, "URL")
                Else
                    SetupTab(sender)
                End If
            Case btnPlainText
                If _TextPresent Then
                    CallDecissionDialog(pgeURL, "PlainText")
                    epBad.SetError(txtPlainText, "")
                    epGood.SetError(txtPlainText, "")
                Else
                    SetupTab(sender)
                End If
            Case btnProperties
                pgeProperties.Visible = True
            Case Else
                pgeContact.Visible = True
                ClearTextFromTabPageControls(dckTab)
        End Select

    End Sub
#End Region

#Region "Creating QR Code"
    Private Sub btnCreateQRCode_Click(sender As Object, e As EventArgs) Handles btnCreateQRCode.Click
        Select Case _CodeToBuild
            Case "Contact"
                CreateContactCode()
            Case "Email"
                CreateEmailCode()
            Case "SMS"
                CreateSMSCode()
            Case "URL"
                CreateURLCode()
            Case "PlainText"
                CreatePlainText()
            Case Else

        End Select
    End Sub

    Private Function QrCodeSizeCheck() As Boolean

        ' encode content
        bcQRCode.Text = _QRText

        ' check whether the encoding succeeded
        If IsNothing(bcQRCode.EncodingException) Then
            Return True
        Else
            DisplayLengthWarning()
            Return False
        End If

        End Function
#End Region

#Region "Build Contact"


    Private Sub CreateContactCode()

        Dim con As New ContactCard
        If txtFirstName.Text <> String.Empty Then
            con.FirstName = Trim(txtFirstName.Text)
        End If
        If txtLastName.Text <> String.Empty Then
            con.LastName = Trim(txtLastName.Text)
        End If
        If txtMainTelephone.Text <> String.Empty Then
            con.MainTelephone = Trim(txtMainTelephone.Text)
        End If
        If txtMobileTelephone.Text <> String.Empty Then
            con.MobileTelephone = Trim(txtMainTelephone.Text)
        End If
        If txtEmailAddress.Text <> String.Empty Then
            con.EMailAddress = Trim(txtEmailAddress.Text)
        End If
        If txtWebsite.Text <> String.Empty Then
            con.WebsiteAddress = Trim(txtWebsite.Text)
        End If
        If txtStreet.Text <> String.Empty Then
            con.Street = Trim(txtStreet.Text)
        End If
        If txtTown.Text <> String.Empty Then
            con.Town = Trim(txtTown.Text)
        End If
        If txtPostcode.Text <> String.Empty Then
            con.PostCode = Trim(txtPostcode.Text)
        End If
        If txtCountry.Text <> String.Empty Then
            con.Country = Trim(txtCountry.Text)
        End If
        If txtMemo.Text <> String.Empty Then
            con.Memo = Trim(txtMemo.Text)
        End If
        If txtDay.Text <> String.Empty Then
            con.Day = Trim(txtDay.Text)
        End If
        If txtMonth.Text <> String.Empty Then
            con.Month = Trim(txtMonth.Text)
        End If
        If txtYear.Text <> String.Empty Then
            con.Year = Trim(txtYear.Text)
        End If
        con.CreateContactCode()
        _QRText = con.ContactCode

        If QrCodeSizeCheck() Then
            _CodeBuilt = True
            EnableButtons()
        Else
            Return
        End If
    End Sub

    Private Sub txtDay_TextChanged(sender As Object, e As EventArgs) Handles txtDay.TextChanged
        If txtDay.Text.Length >= 2 Then
            txtMonth.Focus()
        End If
    End Sub

    Private Sub txtEmailAddress_TextChanged(sender As Object, e As EventArgs) Handles txtEmailAddress.TextChanged
        Dim txb As TextBox = CType(sender, TextBox)
        Dim s As String = txb.Text
        If Not Utils.EmailAddressIsValid(s) Then
            epBad.SetError(txb, "Invalid E Mail")
            epGood.SetError(txb, "")
        Else
            epGood.SetError(txb, "Valid E Mail")
            epBad.SetError(txb, "")
        End If
    End Sub

    Private Sub txtFirstName_LostFocus(sender As Object, e As EventArgs) Handles txtFirstName.LostFocus
        If txtFirstName.Text <> String.Empty Then
            txtFirstName.Text = StrConv(txtFirstName.Text, VbStrConv.ProperCase)
        End If
    End Sub

    Private Sub txtLastName_LostFocus(sender As Object, e As EventArgs) Handles txtLastName.LostFocus
        If txtLastName.Text <> String.Empty Then
            txtLastName.Text = StrConv(txtLastName.Text, VbStrConv.ProperCase)
        End If
    End Sub

    Private Sub txtCountry_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtCountry.LostFocus
        If txtCountry.Text <> String.Empty Then
            txtCountry.Text = StrConv(txtCountry.Text, VbStrConv.ProperCase)
        End If
    End Sub

    Private Sub txtMonth_TextChanged(sender As Object, e As EventArgs) Handles txtMonth.TextChanged
        If txtMonth.Text.Length >= 2 Then
            txtYear.Focus()
        End If
    End Sub

    Private Sub txtStreet_LostFocus(sender As Object, e As EventArgs) Handles txtStreet.LostFocus
        If txtStreet.Text <> String.Empty Then
            txtStreet.Text = StrConv(txtStreet.Text, VbStrConv.ProperCase)
        End If
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        If txtYear.Text.Length >= 4 Then
        End If
    End Sub
#End Region

#Region "Build Email"

    Private Sub CreateEmailCode()
        Dim eqr As New EmailForm
        If txtFormEmailAddress.Text <> String.Empty Then
            eqr.FormEmailAddress = Trim(txtFormEmailAddress.Text)
        Else
            CallEmailAddressingMissing()
            Return
        End If

        If txtSubject.Text <> String.Empty Then
            eqr.Subject = Trim(txtSubject.Text)
        End If

        If txtBody.Text <> String.Empty Then
            eqr.Body = Trim(txtBody.Text)
        End If
        eqr.CreateEmailCode()
        _QRText = eqr.EmailCode
        If QrCodeSizeCheck() Then
            _CodeBuilt = True
            EnableButtons()
        Else
            Return
        End If

    End Sub

    Private Sub txtFormEmailAddress_TextChanged(sender As Object, e As EventArgs) Handles txtFormEmailAddress.TextChanged
        Dim txb As TextBox = CType(sender, TextBox)
        Dim s As String = txb.Text
        If Not Utils.EmailAddressIsValid(s) Then
            epBad.SetError(txb, "Invalid E Mail")
            epGood.SetError(txb, "")
        Else
            epGood.SetError(txb, "Valid E Mail")
            epBad.SetError(txb, "")
        End If
    End Sub
#End Region

#Region "Build SMS Message"

    Private Sub CreateSMSCode()
        Dim sm As New SmsCode
        If txtSMSTelephoneNumber.Text <> String.Empty Then
            sm.SMSTelephoneNumber = Trim(txtSMSTelephoneNumber.Text)
        End If
        If txtSMSMessage.Text <> String.Empty Then
            sm.SmsBody = Trim(txtSMSMessage.Text)
        End If
        sm.CreateSmsCode()
        _QRText = sm.SmsCode
        If QrCodeSizeCheck() Then
            _CodeBuilt = True
            EnableButtons()
        Else
            Return
        End If
    End Sub

    Private Sub txtSMSMessage_TextChanged(sender As Object, e As EventArgs) Handles txtSMSMessage.TextChanged
        Dim txb As TextBox = CType(sender, TextBox)
        Dim s As String = txb.Text
        If s.Length > 160 Then
            epBad.SetError(txb, "Text is longer than 160 Characters.  Consider shortening it.")
            epGood.SetError(txb, "")
        Else
            epGood.SetError(txb, "Text Message Good")
            epBad.SetError(txb, "")
        End If
    End Sub
#End Region

#Region "Build Website Address"



    Private Sub CreateURLCode()
        _QRText = Trim(txtFormWebsiteAddress.Text)
        If QrCodeSizeCheck() Then
            _CodeBuilt = True
            EnableButtons()
        Else
            Return
        End If
    End Sub

    Private Sub txtFormWebsiteAddress_Enter(sender As Object, e As EventArgs) Handles txtFormWebsiteAddress.Enter
        With txtFormWebsiteAddress
            .SelectionStart = Len(.Text)
        End With
    End Sub
#End Region

#Region "Build Plain Text"



    Private Sub CreatePlainText()
        _QRText = Trim(txtPlainText.Text)
        If QrCodeSizeCheck() Then
            _CodeBuilt = True
            EnableButtons()
        Else
            Return
        End If
    End Sub

    Private Sub txtPlainText_TextChanged(sender As Object, e As EventArgs) Handles txtPlainText.TextChanged
        Dim txb As TextBox = CType(sender, TextBox)
        Dim s As String = txb.Text.Trim()
        If s.Length > MAX_LENGTH Then
            epBad.SetError(txb, "Text is longer than " + CStr(MAX_LENGTH) + " Characters. Consider shortening it.")
            epGood.SetError(txb, "")
        Else
            epGood.SetError(txb, "Text is within allowable length.")
            epBad.SetError(txb, "")
        End If
    End Sub
#End Region

#Region "Warnings"

    Private Sub CallDecissionDialog(pge As C1.Win.C1Command.C1DockingTabPage, codeToBuild As String)
        Using dlg As New C1TaskDialog()
            If C1TaskDialog.IsPlatformSupported Then
                With dlg
                    .MainInstruction = "Discard Current QR Code  "
                    .Content = String.Format("You currently have a QR Code under construction {0} Discard the code under construction? ", Environment.NewLine)
                    .WindowTitle = "QR Code Under Construction"
                    .CommonButtons = TaskDialogCommonButtons.Ok Or TaskDialogCommonButtons.Cancel
                    .MainCommonIcon = TaskDialogCommonIcon.Warning
                    If .Show = TaskDialogCommonButtons.Ok Then
                        pge.Visible = True
                        ClearTextFromTabPageControls(dckTab)
                        _CodeToBuild = codeToBuild
                        _CodeBuilt = False
                    End If
                End With
            Else
                If MessageBox.Show(String.Format("You currently have a QR Code under construction {0} Discard the code under construction? ", Environment.NewLine), "QR Code Under Construction", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                    pge.Visible = True
                    ClearTextFromTabPageControls(dckTab)
                    _CodeToBuild = codeToBuild
                    _CodeBuilt = False
                End If
            End If
        End Using
    End Sub

    Private Sub CallEmailAddressingMissing()

        Using dlg As New C1TaskDialog()
            If C1TaskDialog.IsPlatformSupported Then
                With dlg
                    .MainInstruction = "Add an E Mail Address  "
                    .Content = "THere is no E maill Address.  Add One."
                    .WindowTitle = "E Maill Address Missing"
                    .CommonButtons = TaskDialogCommonButtons.Ok
                    .MainCommonIcon = TaskDialogCommonIcon.Error
                    .Show()
                End With
            Else
                MessageBox.Show("THere is no E maill Address.  Add One.", "E Maill Address Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
        txtFormEmailAddress.Focus()


    End Sub

    Private Shared Sub DisplayLengthWarning()

        Using dlg As New C1TaskDialog()
            If C1TaskDialog.IsPlatformSupported Then
                With dlg
                    .MainInstruction = "QR Code Contains Too Much Information  "
                    .Content = String.Format("The code you have constructed contains too many characters. {0}You need to alter it", Environment.NewLine)
                    .WindowTitle = "QR Code Too Long"
                    .CommonButtons = TaskDialogCommonButtons.Ok
                    .MainCommonIcon = TaskDialogCommonIcon.Error
                    .Show()
                End With
            Else
                MessageBox.Show(String.Format("The code you have constructed contains too many characters. {0}You need to alter it", Environment.NewLine), "QR Code Too Long", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using

    End Sub
#End Region

#Region "Saving the Code"

    Private Sub _beginPrint(ByVal sender As Object, ByVal e As PrintEventArgs)
        _item = 0
    End Sub

    Private Sub _printPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics

        ' build rectangle for QR image:
        ' location is top left of the page, size is the image size
        Dim rc As New RectangleF(e.MarginBounds.Location, bcQRCode.Image.Size)

        ' draw QR image
        g.DrawImage(bcQRCode.Image, rc)

        ' build rectangle for text:
        ' make it as wide as the page, below image rectangle
        rc.Width = e.MarginBounds.Width
        rc.Y = rc.Bottom + 40
        rc.Height = e.MarginBounds.Bottom - rc.Y

        ' write out the text:
        Dim f As New Font("Tahoma", 12.0!)
        g.DrawString(bcQRCode.Text, f, Brushes.Black, rc)
    End Sub

    Private Sub btnCopyToClipboard_Click(sender As Object, e As EventArgs) Handles btnCopyToClipboard.Click
        Clipboard.SetText(bcQRCode.Text)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.BeginPrint, New PrintEventHandler(AddressOf Me._beginPrint)
        AddHandler printDoc.PrintPage, New PrintPageEventHandler(AddressOf Me._printPage)
        Using dlg As New CoolPrintPreviewDialog 'PrintPreviewDialog()
            dlg.Document = printDoc
            dlg.ShowDialog()
        End Using
    End Sub

    Private Sub btnSaveImage_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveImage.Click

        Dim dlg As New SaveFileDialog
        dlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        dlg.FileName = "Qr Code"
        dlg.Filter = "Bitmap Image|*.bmp|Gif Image|*.gif|JPeg Image|*.jpeg|Portable Network Graphic|*.png"
        dlg.Title = "Save QR Code as an Image"
        dlg.ShowDialog()
        If dlg.FileName <> "" Then
            Dim fs As FileStream = CType(dlg.OpenFile(), FileStream)
            Select Case dlg.FilterIndex
                Case 1
                    bcQRCode.Image.Save(fs, ImageFormat.Bmp)
                Case 2
                    bcQRCode.Image.Save(fs, ImageFormat.Gif)
                Case 3
                    bcQRCode.Image.Save(fs, ImageFormat.Jpeg)
                Case 4
                    bcQRCode.Image.Save(fs, ImageFormat.Png)
            End Select
            fs.Close()
        End If
    End Sub
#End Region

End Class
