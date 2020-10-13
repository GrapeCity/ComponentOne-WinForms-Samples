
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()

        ' prepare to build view 
        Dim connectionString As String = "Data Source=http://ssrs.componentone.com/OLAP/msmdpump.dll;Provider=msolap;Initial Catalog=AdventureWorksDW2012Multidimensional"
        Dim cubeName As String = "Adventure Works"
        Try
            c1FlexPivotPage1.FlexPivotPanel.ConnectCube(cubeName, connectionString)

            ' show some data.
            Dim fp = c1FlexPivotPage1.FlexPivotEngine
            fp.BeginUpdate()
            fp.ColumnFields.Add("Color")
            fp.RowFields.Add("Category")
            fp.ValueFields.Add("Order Count")
            fp.EndUpdate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        AddHandler c1FlexPivotPage1.FlexPivotEngine.Updated, AddressOf FlexPivotEngine_Updated
        AddHandler c1FlexPivotPage1.FlexPivotEngine.UpdateProgressChanged, AddressOf FlexPivotEngine_UpdateProgressChanged
    End Sub

    ' hide progress bar
    Private Sub FlexPivotEngine_Updated(sender As Object, e As EventArgs)
        progressBar1.Visible = False
    End Sub

    ' update progress bar
    Private Sub FlexPivotEngine_UpdateProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        progressBar1.Visible = True
        progressBar1.Value = CInt(e.ProgressPercentage)
    End Sub

End Class
