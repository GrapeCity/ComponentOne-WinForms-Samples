
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()

        ' get data
        Dim da = New OleDbDataAdapter("select * from invoices", GetConnectionString())
        Dim dt = New DataTable()
        da.Fill(dt)

        ' bind to FlexPivot page
        Me.c1FlexPivotPage1.DataSource = dt

        ' initialize view
        Dim def = My.Settings.ViewDefinition
        If String.IsNullOrEmpty(def) Then
            Dim fp = Me.c1FlexPivotPage1.PivotEngine
            fp.RowFields.Add("ProductName")
            fp.ColumnFields.Add("Country")
            fp.ValueFields.MaxItems = 5
            fp.ValueFields.Add("ExtendedPrice", "Freight")
        Else
            Me.c1FlexPivotPage1.ViewDefinition = def
        End If
    End Sub

    ' save view when closing
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        Dim def = Me.c1FlexPivotPage1.ViewDefinition
        My.Settings.ViewDefinition = def
        My.Settings.Save()

        MyBase.OnClosing(e)
    End Sub

    ' get connection string to sample database
    Private Shared Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
