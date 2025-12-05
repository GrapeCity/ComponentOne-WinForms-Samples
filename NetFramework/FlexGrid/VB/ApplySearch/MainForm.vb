Imports System.Data.OleDb
Imports C1.Win.FlexGrid
Imports C1.Win.Themes
Imports C1.Win.Ribbon

Partial Public Class MainForm
    Inherits C1RibbonForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitThemes()
        c1FlexGridSearchPanel1.SetC1FlexGridSearchPanel(c1FlexGrid1, c1FlexGridSearchPanel1)
        For Each searchHighlightMode In CType([Enum].GetValues(GetType(SearchHighlightMode)), SearchHighlightMode())
            rcbHighlightMode.Items.Add(searchHighlightMode.ToString())
        Next
        rcbHighlightMode.SelectedIndex = 1
        rcbSearchFilter.SelectedIndex = 0
        Dim path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Dim dataAdapter = New OleDbDataAdapter("select * from orders", String.Format(conn, path))
        Dim dataTable = New DataTable()
        dataAdapter.Fill(dataTable)
        c1FlexGrid1.DataSource = dataTable
    End Sub

#Region "Themes"

    Private Sub CmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTheme.SelectedIndexChanged
        c1ThemeController1.Theme = cmbTheme.SelectedItem.Text
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office365"))

        For Each theme In themes
            cmbTheme.Items.Add(theme)
        Next
        cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365Green")
    End Sub

    Private Sub rcbHighlightMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rcbHighlightMode.SelectedIndexChanged
        c1FlexGridSearchPanel1.HighlightSearchResultsMode = CType(rcbHighlightMode.SelectedIndex, SearchHighlightMode)
    End Sub

    Private Sub rcbSearchFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rcbSearchFilter.SelectedIndexChanged
        c1FlexGridSearchPanel1.FilterSearchResults = If(rcbSearchFilter.SelectedIndex = 0, True, False)
    End Sub

    Private Sub rcbSearchTemplates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rcbSearchTemplates.SelectedIndexChanged
        c1FlexGridSearchPanel1.Text = rcbSearchTemplates.Text
    End Sub

#End Region

End Class
