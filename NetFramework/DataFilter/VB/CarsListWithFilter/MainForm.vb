Imports System.Data.OleDb
Imports C1.Win.Themes

Public Class MainForm

    Private ReadOnly _fileName As String = "Expressions.xml"

#Region "Ctor"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
    End Sub

    Private Sub Initialize()
        For Each theme In C1ThemeController.GetThemes()
            RibbonCMBThemes.Items.Add(theme)
        Next

        ThemeName = "Office365White"
        RibbonCMBThemes.SelectedIndex = RibbonCMBThemes.Items.IndexOf(ThemeName)
        ApplyTheme(Me)

        _carsTable = GetDataSource()
        C1FlexGrid1.DataSource = _carsTable
        C1DataFilter1.DataSource = _carsTable
        C1DataFilter1.SaveFilterExpression(_fileName)
        C1DataFilter1.ApplyFilter()
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

#Region "Data"

    Private _carsTable As DataTable

    Private Shared Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

    Private Shared Function GetDataSource() As DataTable
        Dim rs As String = "select * from Cars;"
        Dim cn As String = GetConnectionString()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(rs, cn)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

#End Region

    Private Class TransmissAutomatic
        Public Property DisplayValue As String
        Public Property Value As Object
    End Class

    Private Sub C1DataFilter1_FilterAutoGenerating(sender As Object, e As C1.DataFilter.FilterAutoGeneratingEventArgs) Handles C1DataFilter1.FilterAutoGenerating
        Select Case e.[Property].Name
            Case "Model"
                Dim modelFilter = CType(e.Filter, C1.Win.DataFilter.ChecklistFilter)
                modelFilter.ShowSearchBox = True
                modelFilter.SelectAll()
            Case "Brand"
                Dim brandFilter = CType(e.Filter, C1.Win.DataFilter.ChecklistFilter)
                brandFilter.SelectAll()
            Case "Liter"
                Dim literFilter = CType(e.Filter, C1.Win.DataFilter.RangeFilter)
                literFilter.Maximum = _carsTable.AsEnumerable().Max(Function(x) x.Field(Of Double)("Liter"))
                literFilter.Minimum = _carsTable.AsEnumerable().Min(Function(x) x.Field(Of Double)("Liter"))
                literFilter.Increment = 0.01
            Case "TransmissSpeedCount"
                Dim tskFilter = New C1.Win.DataFilter.ChecklistFilter("TransmissSpeedCount") With {
                    .HeaderText = "Transmiss speed count",
                    .ShowSelectAll = False
                }
                ' Ensure the filter is populated with data from the DataTable
                Dim distinctValues = _carsTable.AsEnumerable() _
                                      .Select(Function(row) row.Field(Of Int16)("TransmissSpeedCount")) _
                                      .Distinct() _
                                      .OrderBy(Function(value) value) _
                                      .ToList()

                For Each value In distinctValues
                    tskFilter.Items.Add(New C1.DataFilter.ChecklistItem(value.ToString(), value.ToString()))
                Next
                tskFilter.SelectAll()
                e.Filter = tskFilter
            Case "Category"
                Dim categoryFilter = CType(e.Filter, C1.Win.DataFilter.ChecklistFilter)
                categoryFilter.ShowSelectAll = False
                categoryFilter.SelectAll()
            Case "TransmissAutomatic"
                Dim taFilter = CType(e.Filter, C1.Win.DataFilter.ChecklistFilter)
                taFilter.ItemsSource = New List(Of TransmissAutomatic)() From {
                    New TransmissAutomatic() With {
                        .DisplayValue = "Yes",
                        .Value = "Yes"
                    },
                    New TransmissAutomatic() With {
                        .DisplayValue = "No",
                        .Value = "No"
                    },
                    New TransmissAutomatic() With {
                        .DisplayValue = "No information",
                        .Value = DBNull.Value
                    }
                }
                taFilter.DisplayMemberPath = "DisplayValue"
                taFilter.ValueMemberPath = "Value"
                taFilter.ShowSelectAll = False
                taFilter.LayoutType = C1.DataFilter.LayoutType.List
                taFilter.SelectAll()
            Case "Price"
                Dim priceFilter = CType(e.Filter, C1.Win.DataFilter.RangeFilter)
                priceFilter.Maximum = _carsTable.AsEnumerable().Max(Function(x) x.Field(Of Double)("Price"))
                priceFilter.Minimum = _carsTable.AsEnumerable().Min(Function(x) x.Field(Of Double)("Price"))
                priceFilter.Increment = 1000
                priceFilter.Digits = 0
            Case Else
                e.Cancel = True
        End Select
    End Sub

    Private Sub cbAutoApply_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoApply.CheckedChanged
        C1DataFilter1.AutoApply = cbAutoApply.Checked
    End Sub

    Private Sub rbtnApplyFilter_Click(sender As Object, e As EventArgs) Handles rbtnApplyFilter.Click
        C1DataFilter1.ApplyFilter()
    End Sub

    Private Sub rbtnSaveFilter_Click(sender As Object, e As EventArgs) Handles rbtnSaveFilter.Click
        C1DataFilter1.SaveFilterExpression(_fileName)
    End Sub

    Private Sub rbtnResetFilter_Click(sender As Object, e As EventArgs) Handles rbtnResetFilter.Click
        C1DataFilter1.LoadFilterExpression(_fileName)
    End Sub
End Class
