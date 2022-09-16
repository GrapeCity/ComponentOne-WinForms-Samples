Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Themes
Imports C1.Win.Ribbon

Namespace AdvancedFiltering
    Partial Public Class MainForm
        Inherits C1RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitThemes()

            InitData()

            c1FlexGrid1.AllowFiltering = True
            c1FlexGrid1.Cols("InheritedFilter").Filter = New InheritedFilterNewMenu()
            c1FlexGrid1.Cols("InheritedNoValue").Filter = New InheritedFilterNewMenu() With {
            .ValueFilterEnabled = False
            }
            c1FlexGrid1.Cols("InheritedNoCondition").Filter = New InheritedFilterNewMenu() With {
                .ConditionFilterEnabled = False
            }
            c1FlexGrid1.Cols("InheritedClassicMenu").Filter = New InheritedFilter()
            c1FlexGrid1.Cols("ComposedClassicMenu").Filter = New ComposedFilter()
            c1FlexGrid1.Cols("ComposedFilter").Filter = New ComposedFilterNewMenu()
            c1FlexGrid1.Cols("ValueFilter").Filter = New ValueFilter()
            c1FlexGrid1.Cols("ConditionFilter").Filter = New ConditionFilter()
        End Sub

        Private Sub InitData()
            Dim dataAdapter = New OleDbDataAdapter("select * from orders", GetConnectionString())
            Dim dataTable = New DataTable()
            dataAdapter.Fill(dataTable)
            Dim newColumn = dataTable.Columns.Add("ConditionFilter", GetType(Date))
            newColumn.SetOrdinal(1)
            newColumn = dataTable.Columns.Add("ValueFilter", GetType(Date))
            newColumn.SetOrdinal(1)
            newColumn = dataTable.Columns.Add("ComposedClassicMenu", GetType(Date))
            newColumn.SetOrdinal(1)
            newColumn = dataTable.Columns.Add("InheritedClassicMenu", GetType(Date))
            newColumn.SetOrdinal(1)
            newColumn = dataTable.Columns.Add("InheritedNoValue", GetType(Date))
            newColumn.SetOrdinal(1)
            newColumn = dataTable.Columns.Add("InheritedNoCondition", GetType(Date))
            newColumn.SetOrdinal(1)
            newColumn = dataTable.Columns.Add("ComposedFilter", GetType(Date))
            newColumn.SetOrdinal(1)
            newColumn = dataTable.Columns.Add("InheritedFilter", GetType(Date))
            newColumn.SetOrdinal(1)
            For Each row As DataRow In dataTable.Rows
                row("InheritedFilter") = row("OrderDate")
                row("InheritedNoValue") = row("OrderDate")
                row("InheritedNoCondition") = row("OrderDate")
                row("InheritedClassicMenu") = row("OrderDate")
                row("ComposedClassicMenu") = row("OrderDate")
                row("ComposedFilter") = row("OrderDate")
                row("ConditionFilter") = row("OrderDate")
                row("ValueFilter") = row("OrderDate")
            Next
            c1FlexGrid1.DataSource = dataTable
        End Sub

        Private Function GetConnectionString() As String
            Dim path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
            Dim conn = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
            Return String.Format(conn, path)
        End Function

#Region "Themes"

        Private Sub InitThemes()
            Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office2016"))
            For Each theme In themes
                cmbTheme.Items.Add(theme)
            Next
        End Sub

        Private Sub cmbTheme_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text
        End Sub

#End Region

        Private Sub rbSaveFiltersToXml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbSaveFiltersToXml.Click
            c1TextBox1.Text = c1FlexGrid1.FilterDefinition.Replace(">", ">" & vbCrLf)
        End Sub

        Private Sub rbCreateFilters_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbCreateFilters.Click
            c1FlexGrid1.ClearFilter()
            CType(c1FlexGrid1.Cols("InheritedFilter").Filter, InheritedFilterNewMenu).WeekdayFilter.Monday = False
            Dim filter = CType(c1FlexGrid1.Cols("InheritedNoValue").Filter, ColumnFilter)
            filter.ConditionFilter.Condition1.[Operator] = ConditionOperator.LessThan
            filter.ConditionFilter.Condition1.Parameter = c1FlexGrid1(9, "InheritedNoValue")
            c1FlexGrid1.ApplyFilters()
        End Sub

        Private Sub rbClearFilters_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbClearFilters.Click
            c1FlexGrid1.ClearFilter()
        End Sub

        Private Sub rbLoadFiltersFromXml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbLoadFiltersFromXml.Click
            c1FlexGrid1.FilterDefinition = c1TextBox1.Text
        End Sub
    End Class
End Namespace
