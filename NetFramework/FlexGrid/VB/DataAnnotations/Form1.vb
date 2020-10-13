Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _flex.DataSource = Data.GetSampleData(20)
    End Sub
End Class
