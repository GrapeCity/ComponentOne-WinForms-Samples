Imports C1.Win.C1Themes

Public Class MainForm

    Private _searchService As AutoSearchService

#Region "Ctor"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
    End Sub

    Private Sub Initialize()
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common")

        For Each theme In C1ThemeController.GetThemes()
            RibbonCMBThemes.Items.Add(theme)
        Next
        RibbonCMBThemes.SelectedIndex = RibbonCMBThemes.Items.IndexOf("Office365White")
        Me.RegionTableAdapter.Fill(Me.DataSet1._Region)
        Me.TerritoriesTableAdapter.Fill(Me.DataSet1.Territories)

        C1TreeView1.BindingInfo.DataMemberPath.Add(0, "Region")
        C1TreeView1.BindingInfo.DataMemberPath.Add(1, "Territories")
        C1TreeView1.BindingInfo.KeyField = "RegionID"
        C1TreeView1.BindingInfo.DataSource = DataSet1

        _searchService = New AutoSearchService(C1TreeView1)
    End Sub
#End Region

#Region "Themes"
    Private Sub RibbonCMBThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RibbonCMBThemes.SelectedIndexChanged
        ThemeName = RibbonCMBThemes.SelectedItem.Text
        ApplyTheme(Me)
    End Sub

    Private Property ThemeName As String

    Private Sub ApplyTheme(control As Control)
        If Not (String.IsNullOrEmpty(ThemeName)) Then
            Dim theme = C1ThemeController.GetThemeByName(ThemeName, False)
            If Not (theme Is Nothing) Then
                C1ThemeController.ApplyThemeToControlTree(control, theme)
            End If
        End If
    End Sub
#End Region

    Private Sub RibbonTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RibbonTextBox1.TextChanged
        _searchService.Search(RibbonTextBox1.Text)
    End Sub

End Class
