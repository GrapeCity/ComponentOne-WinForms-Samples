Imports System.IO
Imports System.ComponentModel
Imports System.Data.OleDb
Imports C1.Win.Tile

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dbPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
            "\\ComponentOne Samples\\Common\\C1NWind.mdb"
        If File.Exists(dbPath) Then
            Dim csb As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder(productsConnection.ConnectionString)
            csb.DataSource = dbPath
            productsConnection.ConnectionString = csb.ToString()
        End If

        categoriesDataAdapter.Fill(DataSet11)
        suppliersDataAdapter.Fill(DataSet11)
        productsDataAdapter.Fill(DataSet11)

    End Sub

    Private Sub c1TileControl1_FormatValue(ByVal sender As System.Object, ByVal e As C1.Win.Tile.FormatValueEventArgs) Handles c1TileControl1.FormatValue

        If e.TileProperty = TileProperty.BackColor Then
            If TypeOf e.Value Is Boolean AndAlso CType(e.Value, Boolean) Then
                e.Value = Color.Firebrick
            Else
                e.Value = Color.DimGray
            End If
        ElseIf e.TileProperty = TileProperty.IntValue Then
            Dim result As Int32 = 0
            If TypeOf e.Value Is String Then
                Select CType(e.Value, String)
                    Case "UK"
                        result = 1
                    Case "France"
                        result = 2
                    Case "Brazil"
                        result = 3
                    Case "Singapore"
                        result = 4
                    Case "USA"
                        result = 5
                    Case "Germany"
                        result = 6
                    Case "Australia"
                        result = 7
                    Case "Japan"
                        result = 8
                    Case "Canada"
                        result = 9
                    Case "Netherlands"
                        result = 10
                    Case "Finland"
                        result = 11
                    Case "Norway"
                        result = 12
                    Case "Italy"
                        result = 13
                    Case "Spain"
                        result = 14
                    Case "Sweden"
                        result = 15
                    Case "Denmark"
                        result = 16
                End Select
            End If
            e.Value = result
        End If

    End Sub

    Private Sub c1TileControl1_TileClicked(ByVal sender As System.Object, ByVal e As C1.Win.Tile.TileEventArgs) Handles c1TileControl1.TileClicked

        Dim cm As CurrencyManager = Me.BindingContext(DataSet11, "Products")
        Dim list As IBindingList = cm.List
        Dim pd As PropertyDescriptor = cm.GetItemProperties()("ProductID")
        cm.Position = list.Find(pd, e.Tile.Tag)

    End Sub

End Class
