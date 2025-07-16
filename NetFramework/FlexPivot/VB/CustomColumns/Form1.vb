
Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()

        ' get data
        Dim da = New OleDbDataAdapter(My.Resources.sql, GetConnectionString())
        Dim dt = New DataTable("NorthWind Sales Data")
        da.Fill(dt)

        ' assign data to FlexPivotPage control
        _c1FlexPivotPage.DataSource = dt

        Dim fp = _c1FlexPivotPage.PivotEngine
        fp.ValueFields.MaxItems = 3
        AddHandler fp.Updated, AddressOf FlexPivot_Updated
        fp.BeginUpdate()
        fp.RowFields.Add("Country")
        fp.ColumnFields.Add("Product")
        fp.ValueFields.Add("Sales")
        fp.EndUpdate()
    End Sub

    ' add custom columns after every FlexPivot update
    Private Sub FlexPivot_Updated(sender As Object, e As EventArgs)
        If _chkCustomColumns.Checked Then
            ' add a new calculated column to the output table
            Dim fp = _c1FlexPivotPage.PivotEngine
            Dim dt = fp.PivotTable
            If dt.Columns.Count >= 2 Then
                ' [column 0] - [column 1]
                dt.Columns.Add("Diff", GetType(Double), String.Format("[{0}] - [{1}]", dt.Columns(1).ColumnName, dt.Columns(0).ColumnName))

                ' [column 0] * [column 1]
                dt.Columns.Add("Prod", GetType(Double), String.Format("[{0}] * [{1}]", dt.Columns(1).ColumnName, dt.Columns(0).ColumnName))

                ' format the new columns on the grid
                Dim cols = _c1FlexPivotPage.FlexPivotGrid.Cols
                For i As Integer = 0 To 1
                    Dim col = cols(cols.Count - 1 - i)
                    col.Format = "n2"
                    col.TextAlignFixed = C1.Win.FlexGrid.TextAlignEnum.CenterCenter
                Next
            End If
        End If
    End Sub

    ' refresh FlexPivot output to reflect new setting
    Private Sub _chkCustomColumns_CheckedChanged(sender As Object, e As EventArgs) Handles _chkCustomColumns.CheckedChanged
        _c1FlexPivotPage.PivotEngine.Update()
    End Sub

    ' get standard nwind mdb connection string
    Private Shared Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
