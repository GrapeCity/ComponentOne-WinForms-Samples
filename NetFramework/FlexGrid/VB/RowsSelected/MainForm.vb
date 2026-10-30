Imports C1.Win.FlexGrid
Imports C1.Win.Ribbon
Imports C1.Win.Themes
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms

Public Class MainForm
    Inherits C1RibbonForm

    Public Sub New()
        InitializeComponent()
        InitThemes()
        c1FlexGridData.AutoResize = True
        LoadData()
        For Each mode As SelectionModeEnum In [Enum].GetValues(GetType(SelectionModeEnum))
            ribbonComboBoxSelMode.Items.Add(mode.ToString())
        Next
        ribbonComboBoxSelMode.SelectedIndex = 0
    End Sub

    Private Sub InitThemes()
        Dim themes As IEnumerable(Of String) = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office365"))
        For Each theme In themes
            ribbonComboBoxThemes.Items.Add(theme)
        Next
        ribbonComboBoxThemes.SelectedIndex = ribbonComboBoxThemes.Items.IndexOf("Office365Green")
    End Sub

    Private Sub ribbonComboBoxThemes_SelectedIndexChanged(sender As Object, e As EventArgs)
        c1ThemeController1.Theme = ribbonComboBoxThemes.SelectedItem.Text
    End Sub

    Private Sub LoadData()
        Dim conn As String = GetConnectionString()
        Dim sql = "SELECT ( SELECT COUNT(*) FROM customers AS T2 WHERE T2.CustomerId <= T1.CustomerId ) AS RowNumber, T1.* FROM customers AS T1 ORDER BY T1.CustomerId;"
        Dim da = New OleDb.OleDbDataAdapter(sql, conn)
        Dim dt = New DataTable()
        da.Fill(dt)
        c1FlexGridData.DataSource = dt
    End Sub

    Private Function GetConnectionString() As String
        Dim path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn = "provider=Microsoft.ACE.OLEDB.12.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

    Private Sub c1FlexGridData_AfterSelChange(sender As Object, e As RangeEventArgs)
        c1FlexGridRowsSelected.BeginUpdate()
        c1FlexGridRowsSelected.Rows.Count = 1
        For Each row As Row In c1FlexGridData.Rows.Selected
            c1FlexGridRowsSelected.AddItem($"row: {row.Index}")
        Next
        c1FlexGridRowsSelected.EndUpdate()
    End Sub

    Private Sub ribbonComboBoxSelMode_SelectedIndexChanged(sender As Object, e As EventArgs)
        c1FlexGridData.SelectionMode = CType([Enum].Parse(GetType(SelectionModeEnum), ribbonComboBoxSelMode.Text), SelectionModeEnum)
    End Sub
End Class
