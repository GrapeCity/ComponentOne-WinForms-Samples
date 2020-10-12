Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formBackColorEditor.SelectedColor = BackColor
        formForeColorEditor.SelectedColor = ForeColor
        labelColorEditor.SelectedColor = demoLabel.ForeColor
        formFontEditor.SelectedFont = Font
        labelFontEditor.SelectedFont = demoLabel.Font
    End Sub

    Private Sub formBackColorEditor_SelectedColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles formBackColorEditor.SelectedColorChanged
        Dim c As Color = formBackColorEditor.SelectedColor
        If c <> Color.Empty Then
            BackColor = c
        End If
    End Sub

    Private Sub formForeColorEditor_SelectedColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles formForeColorEditor.SelectedColorChanged
        Dim c As Color = formForeColorEditor.SelectedColor
        If c <> Color.Empty Then
            ForeColor = c
        End If
    End Sub

    Private Sub labelColorEditor_SelectedColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelColorEditor.SelectedColorChanged
        Dim c As Color = labelColorEditor.SelectedColor
        If c <> Color.Empty Then
            demoLabel.ForeColor = c
        End If
    End Sub

    Private Sub formFontEditor_SelectedFontChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles formFontEditor.SelectedFontChanged
        Dim f As Font = formFontEditor.SelectedFont
        If f IsNot Nothing Then
            Font = f
        End If
    End Sub

    Private Sub labelFontEditor_SelectedFontChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelFontEditor.SelectedFontChanged
        Dim f As Font = labelFontEditor.SelectedFont
        If f IsNot Nothing Then
            demoLabel.Font = f
        End If
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        MessageBox.Show("OK button pressed.", "Accept Button")
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        MessageBox.Show("Cancel button pressed.", "Cancel Button")
    End Sub
End Class
