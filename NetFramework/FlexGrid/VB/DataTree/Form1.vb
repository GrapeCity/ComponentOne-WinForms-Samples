Imports System.Collections.Specialized
Imports System.Data.OleDb
Imports C1.Win.C1FlexGrid

Public Class Form1

    Dim _ds As DataSet = New DataSet()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' initialize db connection variables
        Dim conn As String = GetConnectionString()

        ' load some tables
        Dim tables As String() = "Customers, Orders, Order Details, Products, Employees, Shippers".Split(","c)
        For Each tableName As String In tables
            FillTable(_ds, tableName, conn)
        Next

        ' set up some relations
        _ds.Relations.Add("Customers_Orders", _ds.Tables("Customers").Columns("CustomerID"), _ds.Tables("Orders").Columns("CustomerID"))

        _ds.Relations.Add("Orders_OrderDetails", _ds.Tables("Orders").Columns("OrderID"), _ds.Tables("Order Details").Columns("OrderID"))

        ' build display parameters for "Orders" table
        '
        ' the parameters consist of a string array containing column names,
        ' captions, and formats (applied to the table), as well as data maps 
        ' bound to columns to show data other than raw IDs (e.g. product name 
        ' instead of productID).
        '
        ' we attach this info to the tables and columns as ExtendedProperties 
        ' so the child grids can pick it up in the SetupColumns event.
        '
        ' note that most of this work can be done at design time using the 
        ' grid's Column Editor, but in this case we use code because all the
        ' binding is done at run time.
        '
        Dim dt As DataTable = _ds.Tables("Orders")
        dt.ExtendedProperties.Add("ShowColumns", New String() {"OrderID", "EmployeeID, Employee", "OrderDate, Order Date", "RequiredDate, Required Date", "ShippedDate, Shipped Date", "ShipVia, Ship Via", _
         "Freight, Freight, c"})
        dt.Columns("EmployeeID").ExtendedProperties.Add("DataMap", BuildDataMap("Employees", "EmployeeID", "LastName"))
        dt.Columns("ShipVia").ExtendedProperties.Add("DataMap", BuildDataMap("Shippers", "ShipperID", "CompanyName"))

        ' build display parameters for "Order Details" table
        '
        dt = _ds.Tables("Order Details")
        dt.ExtendedProperties.Add("ShowColumns", New String() {"ProductID, Product", "UnitPrice, Unit Price, c", "Quantity, Qty, 0.00", "Discount, Discount, c"})
        dt.Columns("ProductID").ExtendedProperties.Add("DataMap", BuildDataMap("Products", "ProductID", "ProductName"))

        ' add a calculated column to Customers table so we can see the number of orders for each customer
        '
        dt = _ds.Tables("Customers")
        Dim col As DataColumn = dt.Columns.Add("OrderCount", GetType(Integer), "Count(Child.OrderID)")

        ' re-arrange the columns on the customer table
        '
        dt.ExtendedProperties.Add("ShowColumns", New String() {"CustomerID, Customer", "OrderCount, Orders", "CompanyName, Company", "ContactName, Contact", "Phone", "City", _
         "Region", "Country"})

        ' show customers to begin with
        _flex.SetDataBinding(_ds, "Customers")
    End Sub

    Private Sub FillTable(ByVal ds As DataSet, ByVal tableName As String, ByVal conn As String)
        tableName = tableName.Trim()
        Dim sql As String = String.Format("select * from [{0}]", tableName)
        Dim da As New OleDbDataAdapter(sql, conn)
        da.Fill(ds, tableName)
    End Sub

    ' build a data map
    Private Function BuildDataMap(ByVal table As String, ByVal key As String, ByVal value As String) As IDictionary
        Dim ld As New ListDictionary()
        For Each dr As DataRow In _ds.Tables(table).Rows
            ld.Add(dr(key), dr(value))
        Next
        Return ld
    End Function

    Private Sub _flex_SetupColumns(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flex.SetupColumns
        ' get grid that was just bound
        Dim grid As C1FlexDataTree = TryCast(sender, C1FlexDataTree)
        If grid Is Nothing OrElse grid.DataSource Is Nothing Then
            Return
        End If

        ' get source DataTable
        Dim cm As CurrencyManager = DirectCast(BindingContext(grid.DataSource, grid.DataMember), CurrencyManager)
        Dim dt As DataTable = DirectCast(cm.List, DataView).Table

        ' apply custom column order, captions, format
        Dim columns As String() = TryCast(dt.ExtendedProperties("ShowColumns"), String())
        If columns IsNot Nothing Then
            SetupColumns(grid, columns)
        End If

        ' apply custom data maps
        For Each gridColumn As Column In grid.Cols
            Dim dataColumn As DataColumn = dt.Columns(gridColumn.Name)
            If dataColumn Is Nothing Then
                Continue For
            End If
            gridColumn.DataMap = TryCast(dataColumn.ExtendedProperties("DataMap"), IDictionary)
            If gridColumn.DataMap IsNot Nothing Then
                gridColumn.TextAlign = TextAlignEnum.LeftCenter
            End If
        Next

        ' all done, autosize to show mapped data
        If grid.AutoResize Then
            grid.AutoSizeCols(12)
        End If
    End Sub

    ' apply column information to a grid
    ' this will set the column positions, caption, format, and visibility
    ' (any columns not included in the 'columns' array will not be displayed
    Private Sub SetupColumns(ByVal grid As C1FlexDataTree, ByVal columns As String())
        ' initialize column position
        Dim position As Integer = grid.Cols.Fixed

        ' apply column information
        For Each s As String In columns
            ' split column info (name, caption, format)
            Dim columnInfo As String() = s.Split(","c)

            ' move column to proper position based on its name
            Dim column As Column = grid.Cols(columnInfo(0).Trim())
            If column IsNot Nothing Then
                column.Move(position)
                position += 1

                ' apply caption
                If columnInfo.Length > 1 Then
                    column.Caption = columnInfo(1).Trim()
                End If

                ' apply format
                If columnInfo.Length > 2 Then
                    column.Format = columnInfo(2).Trim()
                End If
            End If
        Next
        For i As Integer = position To grid.Cols.Count - 1
            grid.Cols(i).Visible = False
        Next

        ' hide all other columns
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _flex.AutoResize = True ' small table, fast autoresize
        _flex.SetDataBinding(_ds, "Customers")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        _flex.AutoResize = False ' (for speed)
        _flex.SetDataBinding(_ds, "Orders")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        _flex.SetDataBinding(Nothing, String.Empty)
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
