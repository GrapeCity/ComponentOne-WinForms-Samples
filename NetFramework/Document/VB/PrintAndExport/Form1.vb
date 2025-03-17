Imports System.IO
Imports C1.Win.C1Document
Imports C1.Document.Export

Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        '
        tbFile.Text = "DefaultDocument.pdf"

        '
        cbAction.Items.Add(New FileAction() With {.Text = "Print..."})
        Dim supportedExportProviders = c1PdfDocumentSource1.SupportedExportProviders
        For Each sep In supportedExportProviders
            cbAction.Items.Add(New FileAction() With {.Text = String.Format("Export to {0}...", sep.FormatName), .ExportProvider = sep})
        Next
        cbAction.SelectedIndex = 0
    End Sub

    Private Class FileAction
        Public Property Text As String

        Public Property ExportProvider As ExportProvider

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Sub DoPrint(pds As C1PdfDocumentSource)
        If (printDialog1.ShowDialog(Me) <> DialogResult.OK) Then
            Return
        End If

        Try
            Dim po As C1PrintOptions = New C1PrintOptions()
            po.PrinterSettings = printDialog1.PrinterSettings
            pds.Print(po)
            MessageBox.Show(Me, "Document was successfully printed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DoExport(pds As C1PdfDocumentSource, ep As ExportProvider)
        saveFileDialog1.DefaultExt = "." + ep.DefaultExtension
        saveFileDialog1.FileName = Path.GetFileName(tbFile.Text) + "." + ep.DefaultExtension
        saveFileDialog1.Filter = String.Format("{0} (*.{1})|*.{1}|All files (*.*)|*.*", ep.FormatName, ep.DefaultExtension)
        If (saveFileDialog1.ShowDialog(Me) <> DialogResult.OK) Then
            Return
        End If

        Try
            Dim exporter = ep.NewExporter()
            exporter.ShowOptions = False
            exporter.FileName = saveFileDialog1.FileName
            If (exporter.ShowOptionsDialog()) Then
                pds.Export(exporter)
                MessageBox.Show(Me, "Document was successfully exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        If (String.IsNullOrEmpty(tbFile.Text)) Then
            MessageBox.Show(Me, "Please select a PDF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (Not File.Exists(tbFile.Text)) Then
            MessageBox.Show(Me, String.Format("File ""{0}"" does not exist.", tbFile.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' load document
        While (True)
            Try
                c1PdfDocumentSource1.LoadFromFile(tbFile.Text)
                Exit While
            Catch pex As PdfPasswordException
                Dim password As String = PasswordForm.DoEnterPassword(tbFile.Text)
                If (password Is Nothing) Then
                    Return
                End If
                c1PdfDocumentSource1.Credential.Password = password
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End While

        ' execute action
        If (cbAction.SelectedIndex = 0) Then
            DoPrint(c1PdfDocumentSource1)
        Else
            DoExport(c1PdfDocumentSource1, (CType(cbAction.SelectedItem, FileAction).ExportProvider))
        End If
    End Sub

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        If (openFileDialog1.ShowDialog(Me) = DialogResult.OK) Then
            tbFile.Text = openFileDialog1.FileName
        End If
    End Sub
End Class
