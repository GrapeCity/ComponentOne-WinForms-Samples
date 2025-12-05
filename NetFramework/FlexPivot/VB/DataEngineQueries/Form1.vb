Imports C1.DataEngine
Imports System.IO
Public Class Form1
    ' query descriptions
    Private desc As String() = New String() {
        "Product information: how many times it was ordered (from Order Details) and how many items are left in stock (from Products table)",
        "Join Order Details table with Products table by ProductID",
        "Discount information for the specified product",
        "Products within the specified unit price range",
        "Products that were ordered more than the specified number of times",
        "Orders information by month"}

    Private workspace As C1.DataEngine.Workspace = Nothing

    Public Sub New()
        ' designer support
        InitializeComponent()

        ' initial state of controls
        panelProduct.Top = panelUnitPriceRange.Top
        panelJoin.Top = panelUnitPriceRange.Top
        panelJoinFlexPivot.Top = panelUnitPriceRange.Top
        panelGroupRange.Top = panelUnitPriceRange.Top
        btnFlexPivot.Enabled = False
        cbQuery.SelectedIndex = 0

        ' where DataEngine data is stored
        workspace = C1.Win.FlexPivot.C1FlexPivotPanel.CreateWorkspace()
        workspace.Init(Path.Combine(System.Windows.Forms.Application.StartupPath, "Data"))
    End Sub

    ' initialize controls with data
    Protected Overrides Sub OnLoad(e As EventArgs)
        RefreshControls()
        MyBase.OnLoad(e)
    End Sub

    ' save workspace metadata
    Protected Overrides Sub OnClosed(e As EventArgs)
        workspace.Save()
        MyBase.OnClosed(e)
    End Sub

    ' generates data
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim cnt As Integer
        If Integer.TryParse(cbItemsCount.Text.Replace(",", ""), cnt) Then
            gbQuery.Enabled = False

            ' remove previously generated data
            workspace.Clear()

            ' generate table
            Utils.Products.Generate(workspace, 77, 500, 500)
            Utils.OrderDetails.Generate(workspace, cnt, 0, CInt(workspace.GetTableData(Utils.Products.Name).Size), 50, 100, _
                10)
            Utils.Orders.Generate(workspace, cnt, DateTime.Now.Subtract(New TimeSpan(170, 0, 0, 0)), DateTime.Now, 2, 14)

            ' update controls
            RefreshControls()
            ExecuteQuery()
            gbQuery.Enabled = True
        End If
    End Sub

    ' shows appropriate controls to run a specific query
    Private Sub cbQuery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbQuery.SelectedIndexChanged
        panelUnitPriceRange.Hide()
        panelProduct.Hide()
        panelJoin.Hide()
        panelGroupRange.Hide()
        panelJoinFlexPivot.Hide()
        btnFlexPivot.Enabled = False
        If cbQuery.SelectedIndex = 0 Then
            panelJoin.Show()
        ElseIf cbQuery.SelectedIndex = 1 Then
            panelJoinFlexPivot.Show()
        ElseIf cbQuery.SelectedIndex = 2 Then
            panelProduct.Show()
        ElseIf cbQuery.SelectedIndex = 3 Then
            panelUnitPriceRange.Show()
        ElseIf cbQuery.SelectedIndex = 4 Then
            panelGroupRange.Show()
        ElseIf cbQuery.SelectedIndex = 5 Then
            panelJoin.Show()
        End If
        lblDesc.Text = desc(cbQuery.SelectedIndex)
    End Sub

    ' don't allow "from" to be greater than "to"
    Private Sub nudUnitPriceFrom_ValueChanged(sender As Object, e As EventArgs) Handles nudUnitPriceFrom.ValueChanged
        If nudUnitPriceFrom.Value > nudUnitPriceTo.Value Then
            nudUnitPriceTo.Value = nudUnitPriceFrom.Value
        End If
    End Sub

    ' analyze join query results in C1 FlexPivot
    Private Sub btnFlexPivot_Click(sender As Object, e As EventArgs) Handles btnFlexPivot.Click
        Using f As New FlexPivotForm()
            f.FlexPivot.Workspace = workspace
            f.FlexPivot.ConnectDataEngine("query_join")
            f.FlexPivot.ViewDefinition = My.Resources.JoinView
            f.ShowDialog(Me)
        End Using
    End Sub

    ' executes the selected query
    Private Sub btnExec_Click(sender As Object, e As EventArgs) Handles btnExec.Click
        gbQuery.Enabled = False
        ExecuteQuery()
        gbQuery.Enabled = True
        btnFlexPivot.Enabled = True
    End Sub

    ' executes the selected query
    Private Sub ExecuteQuery()
        tabControl1.SelectedIndex = 3
        Application.DoEvents()
        Dim start As DateTime = DateTime.Now
        Dim res As IDataList = Nothing
        If cbQuery.SelectedIndex = 0 Then
            res = QueryJoin()
        ElseIf cbQuery.SelectedIndex = 1 Then
            res = QueryJoinWithFlexPivot()
        ElseIf cbQuery.SelectedIndex = 2 Then
            res = QueryProduct()
        ElseIf cbQuery.SelectedIndex = 3 Then
            res = QueryUnitPriceRange()
        ElseIf cbQuery.SelectedIndex = 4 Then
            res = QueryGroupRange()
        ElseIf cbQuery.SelectedIndex = 5 Then
            res = QueryMonth()
        End If
        Dim sec As Double = DateTime.Now.Subtract(start).TotalSeconds
        lblTime.Text = String.Format("Time: {0:n2} sec.", sec)
        FillGrid(dgvResult, res)
    End Sub

    ' products within specified unit price range
    Private Function QueryUnitPriceRange() As IDataList
        Dim from As Double = CDbl(nudUnitPriceFrom.Value)
        Dim [to] As Double = CDbl(nudUnitPriceTo.Value)

        ' get OrderDetails table
        Dim od As Object = workspace.table(Utils.OrderDetails.Name)
        ' aggregate OrderDetails table
        ' narrow data to the specified unit price range
        ' calculate the discount for a product in an order
        ' group by UnitPrice
        ' how many times products with the same price were ordered
        ' what is the maximum discount for products with the same price
        Dim qr As Object = workspace.query("query_range", New With { _
            Key ._range = od.UnitPrice.Gte(from).Lte([to]), _
            Key .ds = Op.Mul(od.UnitPrice, od.Discount), _
            Key .Price = od.UnitPrice, _
            Key .OrdersCount = Op.Count(od.OrderID), _
            Key .MaxDiscount = Op.Max("ds") _
        })
        Return qr.Query.Execute()
    End Function

    ' discount information for the specified product
    Private Function QueryProduct() As IDataList
        Dim productID As Integer = cbProduct.SelectedIndex
        ' get OrderDetails table
        Dim od As Object = workspace.table(Utils.OrderDetails.Name)
        ' aggregate OrderDetails table
        ' narrow data to the specified product
        ' calculate the discount for a product in an order
        ' group by product
        ' and group by discount
        ' order count for products with the same discount in all orders
        ' total discount for products with the same discount in all orders
        Dim qp As Object = workspace.query("query_product", New With { _
            Key ._range = od.ProductID.Eq(productID), _
            Key .ds = Op.Mul(od.UnitPrice, od.Discount), _
            Key .Product = od.ProductID, _
            Key .Discount = od.Discount, _
            Key .OrdersCount = Op.Count(od.OrderID), _
            Key .DiscountSum = Op.Sum("ds") _
        })
        Return qp.Query.Execute()
    End Function

    ' products information: how many times it was ordered (from Order Details) and how many items are left in stock (from Products table)
    Private Function QueryJoin() As IDataList
        ' get tables
        Dim od As Object = workspace.table(Utils.OrderDetails.Name)
        Dim pr As Object = workspace.table(Utils.Products.Name)
        ' join OrderDetails and Products tables
        ' get ProductID and OrderID from the OrderDetails table
        ' get UnitsInStock from the Products table and join OrderDetails and Products table on ProductID field
        Dim jq As Object = workspace.join("query_join", od, New With { _
            Key .od = od.ProductID + od.OrderID, _
            Key .pr = pr.UnitsInStock Or od.ProductID = pr.ProductID _
        })
        ' aggregate joined data 
        ' group by ProductID
        ' order count of a product
        ' how many units of a product left in stock
        Dim qjf As Object = workspace.query("query_join_result", New With { _
            Key .Product = jq.ProductID, _
            Key .OrdersCount = Op.Count(jq.OrderID), _
            Key .UnitsOnStock = Op.First(jq.UnitsInStock) _
        })
        Return qjf.Query.Execute()
    End Function

    ' join Odrer Details table with Products table by ProductID
    Private Function QueryJoinWithFlexPivot() As IDataList
        ' get tables
        Dim od As Object = workspace.table(Utils.OrderDetails.Name)
        Dim pr As Object = workspace.table(Utils.Products.Name)
        ' join OrderDetails and Products tables
        ' get ProductID and OrderID from the OrderDetails table
        ' get UnitsInStock from the Products table and join OrderDetails and Products table on ProductID field
        Dim jq As Object = workspace.join("query_join", od, New With { _
            Key .od = od.ProductID + od.OrderID, _
            Key .pr = pr.UnitsInStock Or od.ProductID = pr.ProductID _
        })
        jq.Query.Execute()
        Return workspace.GetQueryData("query_join", 300)
        ' get the first 300 rows from the query result
    End Function

    ' products that were ordered more than specified number of times
    Private Function QueryGroupRange() As IDataList
        ' get OrderDetails table
        Dim od As Object = workspace.table(Utils.OrderDetails.Name)
        ' aggregate OrderDetails
        ' group by ProducID
        ' order count of that product
        ' price sum of that product
        Dim qb As Object = workspace.query("query_group", New With { _
            Key .Product = od.ProductID, _
            Key .OrdersCount = Op.Count(od.OrderID), _
            Key .SumPrice = Op.Sum(od.UnitPrice) _
        })
        ' filter products by order count
        Dim from As Long = CLng(nudGroupFilter.Value)
        ' include all columns from the aggregated OrderDetails
        ' filter products by order count
        Dim qg As Object = workspace.query("query_group_range", New With { _
            Key ._base = "*", _
            Key ._range = qb.OrdersCount.Gte(from).Lte(Long.MaxValue) _
        })
        Return qg.Query.Execute()
    End Function

    ' order information by month
    Private Function QueryMonth() As IDataList
        ' get Orders table
        Dim orders As Object = workspace.table(Utils.Orders.Name)
        ' create a query from Orders table with additional OrdersMonth column
        ' all columns from the Orders table
        ' month from Orders.OrderDate column
        Dim qm As Object = workspace.query("query_date", New With { _
            Key ._base = "*", _
            Key .OrderMonth = Op.DtPart(orders.OrderDate, DateTimeParts.Month) _
        })
        ' aggregate query_date data 
        ' group by OrderMonth
        ' first order date in that month
        ' order count in that month
        Dim qdt As Object = workspace.query("query_month", New With { _
            Key .Month = qm.OrderMonth, _
            Key .FirstOrderDate = Op.Min(qm.OrderDate), _
            Key .OrderCount = Op.Count(qm.OrderID) _
        })
        Return qdt.Query.Execute()
    End Function

    ' fills the grid by the table name
    Private Sub FillGrid(grid As C1.Win.FlexGrid.C1FlexGrid, tableName As String, Optional maxRows As Integer = 0)
        If String.IsNullOrEmpty(tableName) Then
            Return
        End If
        FillGrid(grid, workspace.GetTableData(tableName, maxRows))
    End Sub

    ' fills the grid with table data
    Private Sub FillGrid(grid As C1.Win.FlexGrid.C1FlexGrid, source As IDataList)
        lblResultTotalRows.Text = "0"
        grid.DataSource = source
        Dim count As Long = 0
        If source IsNot Nothing Then
            count = source.Size
            ' updates column names and format using data schema
            Dim cols = source.GetSchemaTable().Rows
            For i As Integer = 1 To cols.Count - 1
                grid.Cols(i + 1).Caption = DirectCast(cols(i)("caption"), String)
                Dim type As Type = System.Type.[GetType](DirectCast(cols(i)("type"), String))
                If IsFloat(type) Then
                    grid.Cols(i + 1).Style.Format = "n2"
                End If
            Next
        End If
        Dim lbl As Label = Nothing
        If grid Is dgvResult Then
            lbl = lblResultTotalRows
        ElseIf grid Is dgvOrderDetails Then
            lbl = lblODRowsTotal
        ElseIf grid Is dgvProducts Then
            lbl = lblProductsRowsTotal
        ElseIf grid Is dgvOrders Then
            lbl = lblOrdersTotalRows
        End If
        If lbl IsNot Nothing Then
            lbl.Text = String.Format("{0:n0}", count)
        End If
    End Sub

    ' check whether the data type is float
    Private Shared Function IsFloat(type__1 As Type) As Boolean
        Select Case Type.GetTypeCode(type__1)
            Case TypeCode.[Double], TypeCode.[Single]
                Return True
            Case Else
                Return False
        End Select
    End Function

    ' fills controls with data
    Private Sub RefreshControls()
        CheckItemsCount()
        FillGrid(dgvOrderDetails, Utils.OrderDetails.Name, 300)
        FillGrid(dgvProducts, Utils.Products.Name, 300)
        FillGrid(dgvOrders, Utils.Orders.Name, 300)
        RefreshMinMaxUnitPriceRange()
        RefreshProductsList()
    End Sub

    ' whether to require generating data
    Private Sub CheckItemsCount()
        Dim colOd As IDataList = workspace.GetTableData(Utils.OrderDetails.Name)
        Dim colProducts As IDataList = workspace.GetTableData(Utils.Products.Name)
        Dim colOrders As IDataList = workspace.GetTableData(Utils.Orders.Name)
        If colOd IsNot Nothing AndAlso colProducts IsNot Nothing AndAlso colOrders IsNot Nothing Then
            lblItemsCount.Text = String.Format("{0:n0}", colOd.Size)
        Else
            lblItemsCount.Text = "0"
            If String.IsNullOrEmpty(cbItemsCount.Text) Then
                cbItemsCount.SelectedIndex = 0
            End If
        End If
        Dim hasItems As Boolean = lblItemsCount.Text <> "0"
        gbQuery.Enabled = hasItems
        lblWarning.Visible = Not hasItems
    End Sub

    ' updates min and max values of the price range
    Private Sub RefreshMinMaxUnitPriceRange()
        If workspace.GetTableData(Utils.OrderDetails.Name) Is Nothing Then
            Return
        End If

        ' aggregate min and max price in the OrderDetails table
        Dim od As Object = workspace.table(Utils.OrderDetails.Name)
        Dim qod As Object = workspace.query("query_order_details", New With { _
            Key .maxPrice = Op.Max(od.UnitPrice), _
            Key .minPrice = Op.Min(od.UnitPrice) _
        })
        Dim list As IDataList = qod.Query.Execute()
        If list Is Nothing OrElse list.Size <> 1 Then
            Return
        End If

        ' read aggregated values
        Dim item = list.GetItem(0)
        Dim max As Double = item.GetDouble(item.GetOrdinal(qod.maxPrice.Name))
        Dim min As Double = item.GetDouble(item.GetOrdinal(qod.minPrice.Name))

        ' set bound values in the controls
        RemoveHandler Me.nudUnitPriceFrom.ValueChanged, AddressOf Me.nudUnitPriceFrom_ValueChanged
        nudUnitPriceFrom.Minimum = CDec(min)
        nudUnitPriceFrom.Maximum = CDec(max)
        nudUnitPriceTo.Minimum = CDec(min)
        nudUnitPriceTo.Maximum = CDec(max)
        AddHandler Me.nudUnitPriceFrom.ValueChanged, AddressOf Me.nudUnitPriceFrom_ValueChanged
    End Sub

    ' fills product list box with values from the Product table
    Private Sub RefreshProductsList()
        cbProduct.Items.Clear()
        Dim col As IDataList = workspace.GetTableData(Utils.Products.Name)
        If col Is Nothing Then
            Return
        End If

        For i As Long = 0 To col.Size - 1
            cbProduct.Items.Add(String.Format("Product #{0}", i))
        Next
        cbProduct.SelectedIndex = 0
    End Sub

End Class