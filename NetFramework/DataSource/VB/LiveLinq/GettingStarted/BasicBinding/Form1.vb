Imports C1.LiveLinq
Imports C1.LiveLinq.Collections

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' create data source
        Dim contacts As New IndexedCollection(Of Contact)()

        ' bind list to grid (before adding elements)
        DataGridView1.DataSource =
          From c In contacts.AsLive()
          Where c.Name.Contains("g")
          Select c

        ' add elements to collection (after binding)
        Dim names As String = "Paul,Ringo,John,George,Robert,Jimmy,John Paul,Bonzo"
        For Each s As String In names.Split(",")
            contacts.Add(New Contact With {.Name = s})
        Next
    End Sub
End Class
