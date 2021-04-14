
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports C1.PivotEngine

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
        def = Nothing
        If String.IsNullOrEmpty(def) Then
            ' initialize view in code
            Dim fp = Me.c1FlexPivotPage1.PivotEngine
            fp.RowFields.Add("ProductName")
            fp.ColumnFields.Add("Country")
            fp.ValueFields.MaxItems = 5
            fp.ValueFields.Add("ExtendedPrice", "Freight")

            ' set up conditional formats in code
            For Each f As PivotField In fp.ValueFields
                ' show top 10% of the values in bold, with a green background
                Dim sh = f.StyleHigh
                sh.ConditionType = ConditionType.Percentage
                sh.Value = 0.9
                sh.BackColor = Color.FromArgb(230, 255, 230)
                sh.FontBold = True

                ' show bottom 10% of the values in bold, with a red background
                Dim sl = f.StyleLow
                sl.ConditionType = ConditionType.Percentage
                sl.Value = 0.1
                sl.BackColor = Color.FromArgb(255, 230, 230)
                sl.FontBold = True
            Next
        Else
            ' load view definition saved in previous runs
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
