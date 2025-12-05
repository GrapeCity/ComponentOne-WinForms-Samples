Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' create spell dialog
        Dim dlg As New C1.Win.SpellChecker.C1SpellDialog()

        ' change form caption, font, color
        dlg.Text = "My very own spell dialog!!!"
        dlg.Font = Me.Font
        dlg.BackColor = Color.Beige

        ' change button styles
        For Each ctl As Control In dlg.Controls
            Dim btn As Button = TryCast(ctl, Button)
            If btn IsNot Nothing Then
                btn.FlatStyle = FlatStyle.Popup
            End If
        Next

        ' change captions on buttons and labels
        ' (dialog uses invisible labels to hold dynamic button captions)
        For Each ctl As Control In dlg.Controls
            If ctl.GetType() Is GetType(Button) OrElse ctl.GetType() Is GetType(Label) Then
                ctl.Text = ctl.Text.Replace("&", String.Empty) + "!!!"
            End If
        Next

        ' spell-check control passing custmized dialog
        Me.C1SpellChecker1.CheckControl(RichTextBox1, False, dlg)

    End Sub

End Class
