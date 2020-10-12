Public Class Form1

    Private _tile4Flipped As Boolean

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _tile4Flipped = Not _tile4Flipped
        If _tile4Flipped Then
            tile4.Template = template42
        Else
            tile4.Template = template41
        End If
    End Sub
End Class
