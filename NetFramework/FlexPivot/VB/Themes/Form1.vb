Imports System.Data.OleDb
Imports C1.Win.C1Themes

Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' fill c1 predefined themes
        For Each theme As String In C1ThemeController.GetThemes()
            cbTheme.Items.Add(theme)
        Next
        cbTheme.SelectedIndex = cbTheme.Items.IndexOf("Office365White")
        AddHandler cbTheme.SelectedIndexChanged, AddressOf cbTheme_SelectedIndexChanged
        ApplyTheme()

        ' connect to sample data
        Dim da = New OleDbDataAdapter(My.Resources.sql, GetConnectionString())
        Dim dt = New DataTable("NorthWind Sales Data")
        da.Fill(dt)

        ' assign data to C1FlexPivotPage control
        _c1FlexPivotPage.DataSource = dt

        ' set default view
        Dim fp = _c1FlexPivotPage.PivotEngine
        fp.ValueFields.MaxItems = 3
        fp.BeginUpdate()
        fp.RowFields.Add("Country")
        fp.ColumnFields.Add("Product")
        fp.ValueFields.Add("Sales")
        fp.EndUpdate()

    End Sub

    ' apply theme to the FlexPivot page
    Private Sub cbTheme_SelectedIndexChanged(sender As Object, e As EventArgs)
        ApplyTheme()
    End Sub

    Private Sub ApplyTheme()
        Dim theme As C1Theme = C1ThemeController.GetThemeByName(cbTheme.Text, False)
        If theme IsNot Nothing Then
            C1ThemeController.ApplyThemeToObject(_c1FlexPivotPage, theme)
        End If
    End Sub

    ' get standard nwind mdb connection string
    Private Shared Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

End Class
