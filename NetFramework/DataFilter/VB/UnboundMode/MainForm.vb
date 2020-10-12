Imports C1.DataCollection.BindingList
Imports C1.Win.C1Themes
Imports C1.Win.DataFilter
Imports C1.Win.Ribbon

Partial Public Class MainForm
    Inherits C1RibbonForm

    Private _dropDownFilter As DropDownFilter
    Private _dataSource As C1BindingListDataCollection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dropDownFilter = New DropDownFilter()
        AddHandler _dropDownFilter.Closed, AddressOf DropDownFilter_Closed

        'TODO: This line of code loads data into the 'DataSet1.Cars' table. You can move, or remove it, as needed.
        Using connection = New OleDb.OleDbConnection(GetConnectionString())
            CarsTableAdapter.Connection = connection
            CarsTableAdapter.Fill(DataSet1.Cars)
        End Using
        _dataSource = New C1BindingListDataCollection(CarsBindingSource)

        InitThemes()
        cmbThemes.SelectedIndex = 1

        InitFilters()
    End Sub

    Private Sub InitFilters()
        Dim modelFilter = New ChecklistFilter With {
            .Expanded = False,
            .ItemsSource = DataSet1.Cars.[Select](Function(x) x.Model),
            .ShowHeader = False,
            .ShowSearchBox = True,
            .ShowSelectAll = True,
            .PropertyName = "Model"
        }
        _dropDownFilter.AddFilter(modelFilter)
        Dim brandFilter = New ChecklistFilter With {
            .Expanded = False,
            .ItemsSource = DataSet1.Cars.[Select](Function(x) x.Brand),
            .ShowHeader = False,
            .ShowSearchBox = True,
            .ShowSelectAll = True,
            .PropertyName = "Brand"
        }
        _dropDownFilter.AddFilter(brandFilter)
        Dim literFilter = New RangeFilter With {
            .Expanded = False,
            .Digits = 3,
            .ShowHeader = False,
            .Maximum = DataSet1.Cars.Max(Function(x) x.Liter),
            .Minimum = DataSet1.Cars.Min(Function(x) x.Liter),
            .PropertyName = "Liter"
        }
        _dropDownFilter.AddFilter(literFilter)
        Dim categoryFilter = New ChecklistFilter With {
            .Expanded = False,
            .ItemsSource = DataSet1.Cars.[Select](Function(x) x.Category),
            .ShowHeader = False,
            .ShowSearchBox = True,
            .ShowSelectAll = True,
            .PropertyName = "Category"
        }
        _dropDownFilter.AddFilter(categoryFilter)
        Dim priceFilter = New RangeFilter With {
            .Expanded = False,
            .Digits = 0,
            .ShowHeader = False,
            .Maximum = DataSet1.Cars.Max(Function(x) x.Price),
            .Minimum = DataSet1.Cars.Min(Function(x) x.Price),
            .PropertyName = "Price"
        }
        _dropDownFilter.AddFilter(priceFilter)
    End Sub

#Region "Themes"

    Private Sub CmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThemes.SelectedIndexChanged
        C1ThemeController1.Theme = cmbThemes.SelectedItem.Text
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office2016"))

        For Each theme In themes
            cmbThemes.Items.Add(theme)
        Next
    End Sub

#End Region

    Public Shared Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

    Private Sub DropDownFilter_Closed(sender As Object, e As ToolStripDropDownClosedEventArgs)
        _dropDownFilter.ApplyFilter(_dataSource)
    End Sub

    Private Sub C1FlexGrid1_MouseUp(sender As Object, e As MouseEventArgs) Handles C1FlexGrid1.MouseUp
        If e.Button = MouseButtons.Right Then
            Dim columnIndex = C1FlexGrid1.MouseCol
            If columnIndex >= 0 AndAlso columnIndex < C1FlexGrid1.Cols.Count Then
                _dropDownFilter.ShowFilter(C1FlexGrid1.Cols(columnIndex).Name, C1FlexGrid1, e.Location)
            End If
        End If
    End Sub


End Class
