Imports C1.C1Report

Class Window1

    WithEvents c1r As C1Report = New C1Report()

    Private Sub c1r_StartReport(ByVal sender As System.Object, ByVal e As EventArgs) Handles c1r.StartReport
        ' expose TextBox1 control to _c1r scripts
        c1r.AddScriptObject("ExternalControl", textBox1)

        ' expose a MathHelper object to _c1r scripts
        c1r.AddScriptObject("MathHelper", New MathHelper())
    End Sub

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

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        c1r.Load("..\..\report.xml", "Alphabetical List of Products")
        CorrectConnectionString(c1r)

        ' show a report
        Dim w As Window2 = New Window2()
        w.C1DocumentViewer1.Document = c1r.C1Document.FixedDocumentSequence
        w.ShowDialog()
    End Sub
End Class

Public Class MathHelper
    Public Function Factorial(ByVal value As Double) As Integer
        If value > 1 Then
            Return value * Factorial(value - 1)
        Else
            Return 1
        End If
    End Function
End Class