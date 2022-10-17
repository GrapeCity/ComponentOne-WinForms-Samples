Imports System.IO
Imports C1.Win.C1Document
Imports C1.Win.Ribbon

Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        '
        If (File.Exists("..\..\DefaultDocument.pdf")) Then
            C1PdfDocumentSource1.LoadFromFile("..\..\DefaultDocument.pdf")
        End If

        ' initialize Ribbon control
        Dim rgFile As RibbonGroup = New RibbonGroup() With {.Text = "File"}
        C1FlexViewer1.Ribbon.Tabs(0).Groups.Insert(0, rgFile)

        Dim rbOpen As RibbonButton = New RibbonButton() With {.Text = "Open..."}
        rbOpen.ToolTip = "Open PDF file"
        rbOpen.ShortcutKeys = Keys.O Or Keys.Control
        rbOpen.KeyTip = "O"
        rbOpen.LargeImage = ilLarge.Images(0)
        rbOpen.SmallImage = ilSmall.Images(0)
        AddHandler rbOpen.Click, AddressOf Open_Click
        rgFile.Items.Insert(0, rbOpen)
    End Sub

    Private Sub Open_Click(sender As Object, e As EventArgs)
        If (ofdOpen.ShowDialog(Me) <> DialogResult.OK) Then
            Return
        End If

        While (True)
            Try
                C1PdfDocumentSource1.LoadFromFile(ofdOpen.FileName)
                Return
            Catch pex As PdfPasswordException
                Dim password As String = PasswordForm.DoEnterPassword(ofdOpen.FileName)
                If (password Is Nothing) Then
                    Return
                End If
                C1PdfDocumentSource1.Credential.Password = password
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End While

    End Sub
End Class
