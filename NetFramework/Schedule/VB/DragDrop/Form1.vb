Public Class Form1

    Private Sub C1Schedule1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles C1Schedule1.DragDrop
        If e.Data.GetDataPresent(GetType(C1.C1Schedule.Appointment)) Then
            Dim app As C1.C1Schedule.Appointment
            app = e.Data.GetData(GetType(C1.C1Schedule.Appointment))
            app.Subject = "my test dragged appointment"
        End If

    End Sub
End Class
