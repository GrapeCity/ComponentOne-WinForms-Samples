Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim path As String = Application.StartupPath
        Dim pos As Integer = path.IndexOf("\bin")
        path = path.Substring(0, pos)

	Dim tempdir As String = Application.ExecutablePath.Substring(0,	Application.ExecutablePath.LastIndexOf("\")+1)
        Dim xlsFileName As String = tempdir + "combineSheets.xls"
        If System.IO.File.Exists(xlsFileName) Then
            System.IO.File.Delete(xlsFileName)
        End If

        ' clear the book
        C1XLBook1.Clear()
        C1XLBook1.Sheets.Clear()
        Dim fileName As String
        For Each fileName In System.IO.Directory.GetFiles(path, "*.xls")

            ' load Excel file
            Dim book As New C1.C1Excel.C1XLBook()
            book.Load(fileName)

            ' clone and rename first sheet (sheet names must be unique)
            Dim clone As C1.C1Excel.XLSheet = book.Sheets(0).Clone()
            clone.Name = System.IO.Path.GetFileNameWithoutExtension(fileName)

            ' add cloned sheet to main book
            C1XLBook1.Sheets.Add(clone)
        Next

        C1XLBook1.Save(xlsFileName)
        System.Diagnostics.Process.Start(xlsFileName)

    End Sub
End Class
