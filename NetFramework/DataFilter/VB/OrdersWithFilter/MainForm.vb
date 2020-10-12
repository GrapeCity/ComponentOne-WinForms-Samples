Imports System.Data.OleDb
Imports C1.Win.C1Themes

Public Class MainForm

#Region "Ctor"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
    End Sub

    Private Sub Initialize()
        For Each theme In C1ThemeController.GetThemes()
            RibbonCMBThemes.Items.Add(theme)
        Next
        _ordersTable = GetDataSource()
        C1TrueDBGrid1.DataSource = _ordersTable
        C1DataFilter1.DataSource = _ordersTable
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
            C1TrueDBGrid1.SuspendLayout()

            For i As Integer = 0 To C1TrueDBGrid1.Splits(0).Rows.Count - 1
                C1TrueDBGrid1.Splits(0).Rows(i).AutoSize()
            Next

            C1TrueDBGrid1.ResumeLayout()
        End If
    End Sub

#End Region

#Region "data source"

    Private _ordersTable As DataTable

    Private Shared Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

    Private Shared Function GetDataSource() As DataTable
        Dim rs As String = "select * from Orders;"
        Dim cn As String = GetConnectionString()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(rs, cn)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

#End Region

    Private Sub C1DataFilter1_FilterAutoGenerating(sender As Object, e As C1.DataFilter.FilterAutoGeneratingEventArgs) Handles C1DataFilter1.FilterAutoGenerating
        Select Case e.[Property].Name
            Case "OrderDate"
                Dim orderDateFilter = CType(e.Filter, C1.Win.DataFilter.DateRangeFilter)
                orderDateFilter.Maximum = _ordersTable.AsEnumerable().Max(Function(x) x.Field(Of DateTime)("OrderDate"))
                orderDateFilter.Minimum = _ordersTable.AsEnumerable().Min(Function(x) x.Field(Of DateTime)("OrderDate"))
                orderDateFilter.HeaderText = "Order date"
            Case "RequiredDate"
                Dim reqDateFilter = CType(e.Filter, C1.Win.DataFilter.DateRangeFilter)
                reqDateFilter.Maximum = _ordersTable.AsEnumerable().Max(Function(x) x.Field(Of DateTime)("RequiredDate"))
                reqDateFilter.Minimum = _ordersTable.AsEnumerable().Min(Function(x) x.Field(Of DateTime)("RequiredDate"))
                reqDateFilter.HeaderText = "Required date"
            Case "Freight"
                Dim freightFilter = CType(e.Filter, C1.Win.DataFilter.RangeFilter)
                freightFilter.Maximum = CDbl(_ordersTable.AsEnumerable().Max(Function(x) x.Field(Of Decimal)("Freight")))
                freightFilter.Minimum = CDbl(_ordersTable.AsEnumerable().Min(Function(x) x.Field(Of Decimal)("Freight")))
                freightFilter.Increment = 10
                freightFilter.HeaderText = "Freight"
            Case "ShipCountry"
                Dim countryFilter = CType(e.Filter, C1.Win.DataFilter.ChecklistFilter)
                countryFilter.HeaderText = "Ship country"
                countryFilter.ShowSelectAll = True
                countryFilter.ShowSearchBox = True
                countryFilter.SelectAll()
            Case Else
                e.Cancel = True
        End Select
    End Sub

End Class
