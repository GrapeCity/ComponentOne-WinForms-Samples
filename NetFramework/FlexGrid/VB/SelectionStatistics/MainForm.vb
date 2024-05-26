Imports C1.Win.C1Themes
Imports C1.Win.Ribbon

Partial Public Class MainForm
    Inherits C1RibbonForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitThemes()
    End Sub

#Region "Themes"

    Private Sub CmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThemes.SelectedIndexChanged
        C1ThemeController1.Theme = cmbThemes.SelectedItem.Text
        C1ThemeController1.SetTheme(SelectionStatisticsControl1.c1FlexGrid1, C1ThemeController1.Theme)
        SelectionStatisticsControl1.tslSelectionStatistics.Font = SelectionStatisticsControl1.c1FlexGrid1.Font
        SelectionStatisticsControl1.tsSelectionStatistics.BackColor = SelectionStatisticsControl1.c1FlexGrid1.BackColor
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office365"))

        For Each theme In themes
            cmbThemes.Items.Add(theme)
        Next
        cmbThemes.SelectedIndex = cmbThemes.Items.IndexOf("Office365Green")
    End Sub

#End Region

End Class
