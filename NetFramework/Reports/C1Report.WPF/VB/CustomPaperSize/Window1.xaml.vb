Imports System.Drawing.Printing

Class Window1

    Private Sub CorrectConnectionString(ByVal rep As C1.C1Report.C1Report)
        Dim cs As String = rep.DataSource.ConnectionString
        If (IsNothing(cs)) Then
            Return
        End If

        '
        Dim i As Integer = cs.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase)
        If (i < 0) Then
            Return
        End If
        While (i < cs.Length And cs(i) <> "=")
            i = i + 1
        End While
        If (i >= cs.Length) Then
            Return
        End If

        Dim j As Integer = i
        While (i < cs.Length And cs(i) <> ";")
            i = i + 1
        End While

        '
        Dim mdbName As String = cs.Substring(j + 1, i - j - 1).Trim()
        If (mdbName.Length <= 0) Then
            Return
        End If
        mdbName = System.IO.Path.GetFileName(mdbName)
        If (String.Compare(mdbName, "nwind.mdb", True) = 0) Then
            mdbName = "c1nwind.mdb"
        End If

        '
        cs = cs.Substring(0, j + 1) + _
            Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
            "\ComponentOne Samples\Common\" + _
            mdbName + _
            cs.Substring(i)

        rep.DataSource.ConnectionString = cs

        '
        For i = 0 To rep.Fields.Count - 1 Step 1
            If (Not IsNothing(rep.Fields(i).Subreport)) Then
                CorrectConnectionString(rep.Fields(i).Subreport)
            End If
        Next
    End Sub

    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim c1r As C1.C1Report.C1Report = New C1.C1Report.C1Report()

        ' load report definition
        c1r.Load("..\..\report.xml", "Alphabetical List of Products Report")
        CorrectConnectionString(c1r)

        ' define custom paper size, 20" x 60"
        Dim cps As PaperSize = New PaperSize("MyCustomSize", 2000, 6000)

        ' assign custom paper size to report
        c1r.Document.DefaultPageSettings.PaperSize = cps
        c1r.Render()

        c1DocumentViewer1.Document = c1r.C1Document.FixedDocumentSequence
    End Sub
End Class
