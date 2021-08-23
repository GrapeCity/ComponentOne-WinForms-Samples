Imports C1.C1Report

Class Window1

    WithEvents _c1r As C1Report

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
        _c1r = New C1Report()
        _c1r.Load("..\..\report.xml", "Alphabetical List of Products Report")
        CorrectConnectionString(_c1r)

        ' populate list with fields available for sorting
        For Each f As Field In _c1r.Fields
            If Not f.Calculated And f.Text.IndexOfAny(New Char() {"&"c, "("c, ")"c, " "c}) < 0 Then
                listBox1.Items.Add(f.Text)
            End If
        Next
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        ' apply sorting expression to report's first (and only) group
        _c1r.Groups(0).GroupBy = listBox1.SelectedItem
        If (rbAscending.IsChecked) Then
            _c1r.Groups(0).Sort = SortEnum.Ascending
        Else
            _c1r.Groups(0).Sort = SortEnum.Descending
        End If

        ' show report
        Dim w As Window2 = New Window2()
        w.Title = "Report sorted by " + listBox1.SelectedItem
        w.c1DocumentViewer1.Document = _c1r.C1Document.FixedDocumentSequence
        w.ShowDialog()
    End Sub
End Class
