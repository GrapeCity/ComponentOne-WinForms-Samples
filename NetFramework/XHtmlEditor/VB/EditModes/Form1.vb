Public Class Form1

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Design
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Source
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Preview
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        If openFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            c1Editor1.LoadXml(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        If saveFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            c1Editor1.SaveXml(saveFileDialog1.FileName)
        End If
    End Sub
End Class
