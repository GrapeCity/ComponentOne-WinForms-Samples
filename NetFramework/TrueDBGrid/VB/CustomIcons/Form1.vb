
Imports C1.Win.Themes
Imports C1.Win.TrueDBGrid

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitThemes()
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Flag", GetType(Boolean))

        For i As Integer = 0 To 100 - 1
            dt.Rows.Add(New Object() {i, i Mod 2 = 0})
        Next

        c1TrueDBGrid1.DataSource = dt
        cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365White")
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office365"))

        For Each theme In themes
            cmbTheme.Items.Add(theme)
        Next

    End Sub

    Private Sub cmbTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTheme.SelectedIndexChanged
        C1ThemeController1.Theme = cmbTheme.SelectedItem.Text

        If c1Ribbon1.RibbonStyle.IsDarkTheme Then
            c1TrueDBGrid1.Glyphs(GlyphType.CheckBoxChecked) = My.Resources.CheckedIconDark
            c1TrueDBGrid1.Glyphs(GlyphType.CheckBoxUnchecked) = My.Resources.UncheckedIconDark
            c1TrueDBGrid1.Glyphs(GlyphType.CheckBoxIndeterminate) = My.Resources.IndeterminateIconDark
        Else
            c1TrueDBGrid1.Glyphs(GlyphType.CheckBoxChecked) = My.Resources.CheckedIcon
            c1TrueDBGrid1.Glyphs(GlyphType.CheckBoxUnchecked) = My.Resources.UncheckedIcon
            c1TrueDBGrid1.Glyphs(GlyphType.CheckBoxIndeterminate) = My.Resources.IndeterminateIcon
        End If

        c1TrueDBGrid1.Splits(0).DisplayColumns(1).Style.HorizontalAlignment = C1.Win.TrueDBGrid.AlignHorzEnum.Center
        c1TrueDBGrid1.Splits(0).DisplayColumns(1).Style.VerticalAlignment = C1.Win.TrueDBGrid.AlignVertEnum.Center
    End Sub
End Class
