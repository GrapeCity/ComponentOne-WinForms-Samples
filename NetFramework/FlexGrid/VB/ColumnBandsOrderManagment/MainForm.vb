Imports C1.Win.Themes
Imports C1.Win.Ribbon

Partial Public Class MainForm
    Inherits C1RibbonForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitThemes()
        columnBandsUserControl1.Init()
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office365"))

        For Each theme In themes
            cmbTheme.Items.Add(theme)
        Next

        cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365Green")
    End Sub

    Private Sub cmbTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTheme.SelectedIndexChanged
        c1ThemeController1.Theme = cmbTheme.SelectedItem.Text
        columnBandsUserControl1.ApplyTheme(cmbTheme.SelectedItem.Text)
    End Sub
End Class

