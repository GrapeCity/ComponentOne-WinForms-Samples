Imports C1.Win
Imports C1.Win.C1Themes

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitThemes()
    End Sub

#Region "Themes"

    Private Sub CmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTheme.SelectedIndexChanged
        C1ThemeController1.Theme = cmbTheme.SelectedItem.Text
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office365"))

        For Each theme In themes
            cmbTheme.Items.Add(theme)
        Next
        cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365White")
    End Sub

#End Region
End Class
