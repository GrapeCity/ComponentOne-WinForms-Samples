Imports System.Drawing.Printing
Imports C1.C1Excel

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim pk As PaperKind
        For Each pk In [Enum].GetValues(GetType(PaperKind))
            _cmbPaperSize.Items.Add(pk)
        Next

    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click

        ' load book
        Using dlg As New OpenFileDialog()

            dlg.FileName = "*.xls"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                C1XLBook1.Load(dlg.FileName)
                ShowPrintSettings()
            End If
        End Using

    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click

        ' apply print settings
        ApplyPrintSettings()

        ' save book
        Dim xlsFile As String = Application.StartupPath + "\psOut.xls"
        C1XLBook1.Save(xlsFile)
        System.Diagnostics.Process.Start(xlsFile)

    End Sub

    ' read print settings from sheet, show in form
    Private Sub ShowPrintSettings()

        Dim sheet As XLSheet = C1XLBook1.Sheets(0)
        Dim ps As XLPrintSettings = sheet.PrintSettings

        ' paper size, orientation
        _cmbPaperSize.SelectedItem = ps.PaperKind
        _rdLandscape.Checked = ps.Landscape

        ' scaling
        If (ps.AutoScale) Then
            _rdFit.Checked = True
        Else
            _rdAdjust.Checked = True
        End If

        _udAcross.Value = ps.FitPagesAcross
        _udDown.Value = ps.FitPagesDown
        _udPercentSize.Value = ps.ScalingFactor

        ' start page
        _txtStartPage.Text = ps.StartPage.ToString()

        ' margins
        _udLeft.Value = New Decimal(ps.MarginLeft)
        _udTop.Value = New Decimal(ps.MarginTop)
        _udRight.Value = New Decimal(ps.MarginRight)
        _udBottom.Value = New Decimal(ps.MarginBottom)
        _udHeader.Value = New Decimal(ps.MarginHeader)
        _udFooter.Value = New Decimal(ps.MarginFooter)

        ' header/footer
        _txtHeader.Text = ps.Header
        _txtFooter.Text = ps.Footer
    End Sub

    ' read print settings from form, apply to sheet
    Private Sub ApplyPrintSettings()

        Dim sheet As XLSheet = C1XLBook1.Sheets(0)
        Dim ps As XLPrintSettings = sheet.PrintSettings

        ' paper size, orientation
        If Not (_cmbPaperSize.SelectedItem Is Nothing) Then
            ps.PaperKind = Convert.ChangeType(_cmbPaperSize.SelectedItem, GetType(PaperKind))
        End If
        ps.Landscape = _rdLandscape.Checked

        ' scaling
        ' ** note: 
        '    setting the FitPagesAcross, FitPagesDown, and ScalingFactor properties
        '    changes the value of AutoScale, so set AutoScale last.
        ps.FitPagesAcross = Decimal.ToInt32(_udAcross.Value)
        ps.FitPagesDown = Decimal.ToInt32(_udDown.Value)
        ps.ScalingFactor = Decimal.ToInt32(_udPercentSize.Value)
        ps.AutoScale = _rdFit.Checked

        ' start page
        ps.StartPage = 1
        Integer.TryParse(_txtStartPage.Text, ps.StartPage)

        ' margins
        ps.MarginLeft = Decimal.ToDouble(_udLeft.Value)
        ps.MarginTop = Decimal.ToDouble(_udTop.Value)
        ps.MarginRight = Decimal.ToDouble(_udRight.Value)
        ps.MarginBottom = Decimal.ToDouble(_udBottom.Value)
        ps.MarginHeader = Decimal.ToDouble(_udHeader.Value)
        ps.MarginFooter = Decimal.ToDouble(_udFooter.Value)

        ' header/footer
        ps.Header = _txtHeader.Text
        ps.Footer = _txtFooter.Text
    End Sub

End Class
