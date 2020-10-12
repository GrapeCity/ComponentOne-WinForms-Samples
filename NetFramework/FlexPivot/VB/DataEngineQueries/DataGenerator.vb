Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports C1.DataEngine
Imports System.IO
Imports System.Globalization

Namespace Utils
    Public Class DataGenerator
        ' genarates a random integer value
        Friend Shared Function GenerateInt(index As Integer, minValue As Integer, maxValue As Integer, r As Random) As Integer
            If r Is Nothing Then
                Return index
            End If
            Return r.[Next](minValue, maxValue)
        End Function

        ' generates a random short value
        Friend Shared Function GenerateShort(minValue As Integer, maxValue As Integer, r As Random) As Short
            Return CShort(r.[Next](minValue, maxValue))
        End Function

        ' generates a random double value
        Friend Shared Function GenerateDouble(minValue As Integer, maxValue As Integer, r As Random) As Double
            Return CDbl(r.[Next](minValue, maxValue)) / 100
        End Function

        ' generates a random float value
        Friend Shared Function GenerateFloat(minValue As Integer, maxValue As Integer, r As Random) As Single
            Return CSng(r.[Next](minValue, maxValue)) / 100
        End Function

        ' generates a random date
        Friend Shared Function GenerateDate(minValue As DateTime, maxValue As DateTime, r As Random) As DateTime
            Return New DateTime(LongRandom(minValue.Ticks, maxValue.Ticks, r))
        End Function

        ' generates a random shifted date from the specific date
        Friend Shared Function GenerateShiftedDate(baseDate As DateTime, minShiftDays As Integer, maxShiftDays As Integer, r As Random) As DateTime
            Dim tiksPerDay As Long = 10000L * 1000 * 60 * 60 * 24
            Dim minTicks As Long = minShiftDays * tiksPerDay
            Dim maxTicks As Long = maxShiftDays * tiksPerDay
            Return New DateTime(baseDate.Ticks + LongRandom(minTicks, maxTicks, r))
        End Function

        ' ganarates a random long value
        Private Shared Function LongRandom(min As Long, max As Long, r As Random) As Long
            Dim buf As Byte() = New Byte(7) {}
            r.NextBytes(buf)
            Dim longRand As Long = BitConverter.ToInt64(buf, 0)
            Return (Math.Abs(longRand Mod (max - min)) + min)
        End Function

        ' generates a random string value from the specific string list
        Friend Shared Function GenerateString(data As List(Of String), r As Random) As String
            Dim minIndex As Integer = 0
            Dim maxIndex As Integer = data.Count - 1
            Dim idx As Integer = r.[Next](minIndex, maxIndex)
            Return data(idx)
        End Function

        ' gets a list of all countries
        Public Shared Function GetCountries() As List(Of String)
            Dim countries As New List(Of String)()
            Dim cis As CultureInfo() = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            For Each ci As CultureInfo In cis
                Dim ri As New RegionInfo(ci.LCID)
                If Not countries.Contains(ri.EnglishName) Then
                    countries.Add(ri.EnglishName)
                End If
            Next
            Return countries
        End Function

        ' gets a list of random names
        Public Shared Function GetUserNames() As List(Of String)
            Dim line As String = vbNullString
            Dim names As New List(Of String)()
            Dim dataPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\FakeNameGenerator.com_dc989f6c.csv")
            Dim reader As New StreamReader(dataPath)
            While (InlineAssignHelper(line, reader.ReadLine())) IsNot Nothing
                names.Add(line.Replace(","c, " "c))
            End While
            Return names
        End Function
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class

    ' OrderDetails table
    Public Class OrderDetails
        Public Shared ReadOnly Property Name() As String
            Get
                Return "order_details"
            End Get
        End Property

        ' generates C1.DataEngine table
        Public Shared Sub Generate(workspace As Workspace, totalRows As Integer, maxOrders As Integer, maxProducts As Integer, maxQuantity As Integer, maxUnitPrices As Integer, _
            maxDiscounts As Integer)
            Dim list = Item.GenerateList(totalRows, maxOrders, maxProducts, maxQuantity, maxUnitPrices, maxDiscounts)
            Dim connector = New C1.DataEngine.ObjectConnector(Of Item)(workspace, list)
            connector.GetData(Name)
        End Sub

        ' table row
        Private Class Item
            Public Property OrderID() As Integer
                Get
                    Return m_OrderID
                End Get
                Set(value As Integer)
                    m_OrderID = Value
                End Set
            End Property
            Private m_OrderID As Integer
            Public Property ProductID() As Integer
                Get
                    Return m_ProductID
                End Get
                Set(value As Integer)
                    m_ProductID = Value
                End Set
            End Property
            Private m_ProductID As Integer
            Public Property Quantity() As Short
                Get
                    Return m_Quantity
                End Get
                Set(value As Short)
                    m_Quantity = Value
                End Set
            End Property
            Private m_Quantity As Short
            Public Property UnitPrice() As Double
                Get
                    Return m_UnitPrice
                End Get
                Set(value As Double)
                    m_UnitPrice = Value
                End Set
            End Property
            Private m_UnitPrice As Double
            Public Property Discount() As Single
                Get
                    Return m_Discount
                End Get
                Set(value As Single)
                    m_Discount = Value
                End Set
            End Property
            Private m_Discount As Single

            ' generates a list of rows with random data
            Public Shared Iterator Function GenerateList(totalRows As Integer, maxOrders As Integer, maxProducts As Integer, maxQuantity As Integer, maxUnitPrices As Integer, maxDiscounts As Integer) As IEnumerable(Of Item)
                Dim r As New Random()
                If totalRows = 0 Then
                    totalRows = r.[Next]()
                End If
                If maxOrders = 0 AndAlso maxProducts = 0 Then
                    maxProducts = r.[Next](20, 1000)
                End If
                If maxOrders = 0 Then
                    maxOrders = totalRows \ maxProducts
                Else
                    maxProducts = totalRows \ maxOrders
                End If
                If maxQuantity = 0 Then
                    maxQuantity = r.[Next](totalRows)
                End If
                If maxUnitPrices = 0 Then
                    maxUnitPrices = r.[Next](totalRows)
                End If
                If maxDiscounts = 0 Then
                    maxDiscounts = r.[Next](totalRows)
                End If
                For i As Integer = 0 To totalRows - 1
                    Dim item = New Item()
                    item.OrderID = DataGenerator.GenerateInt(i, 0, maxOrders, r)
                    item.ProductID = DataGenerator.GenerateInt(i, 0, maxProducts, r)
                    item.Quantity = DataGenerator.GenerateShort(1, maxQuantity, r)
                    item.UnitPrice = DataGenerator.GenerateDouble(100, 100 + maxUnitPrices, r)
                    item.Discount = DataGenerator.GenerateFloat(0, maxDiscounts, r)
                    Yield item
                Next
            End Function
        End Class
    End Class

    ' Products table
    Public Class Products
        Public Shared ReadOnly Property Name() As String
            Get
                Return "products"
            End Get
        End Property

        ' generates C1.DataEngine table
        Public Shared Sub Generate(workspace As Workspace, totalRows As Integer, maxUnitsInStock As Integer, maxUnitsOnOrder As Integer)
            Dim list = Item.GenerateList(totalRows, maxUnitsInStock, maxUnitsOnOrder)
            Dim connector = New C1.DataEngine.ObjectConnector(Of Item)(workspace, list)
            connector.GetData(Name)
        End Sub

        ' table row
        Private Class Item
            Public Property ProductID() As Integer
                Get
                    Return m_ProductID
                End Get
                Set(value As Integer)
                    m_ProductID = Value
                End Set
            End Property
            Private m_ProductID As Integer
            Public Property UnitsInStock() As Short
                Get
                    Return m_UnitsInStock
                End Get
                Set(value As Short)
                    m_UnitsInStock = Value
                End Set
            End Property
            Private m_UnitsInStock As Short
            Public Property UnitsOnOrder() As Short
                Get
                    Return m_UnitsOnOrder
                End Get
                Set(value As Short)
                    m_UnitsOnOrder = Value
                End Set
            End Property
            Private m_UnitsOnOrder As Short

            ' generates a list of rows with random data
            Public Shared Iterator Function GenerateList(totalRows As Integer, maxUnitsInStock As Integer, maxUnitsOnOrder As Integer) As IEnumerable(Of Item)
                Dim r As New Random()
                If totalRows = 0 Then
                    totalRows = r.[Next]()
                End If
                If maxUnitsInStock = 0 Then
                    maxUnitsInStock = r.[Next](totalRows)
                End If
                If maxUnitsOnOrder = 0 Then
                    maxUnitsOnOrder = r.[Next](totalRows)
                End If
                For i As Integer = 0 To totalRows - 1
                    Dim item = New Item()
                    item.ProductID = DataGenerator.GenerateInt(i, 0, totalRows, Nothing)
                    item.UnitsInStock = DataGenerator.GenerateShort(1, maxUnitsInStock, r)
                    item.UnitsOnOrder = DataGenerator.GenerateShort(1, maxUnitsOnOrder, r)
                    Yield item
                Next
            End Function
        End Class
    End Class

    ' Orders table
    Public Class Orders
        Public Shared ReadOnly Property Name() As String
            Get
                Return "orders"
            End Get
        End Property

        ' generates C1.DataEngine table
        Public Shared Sub Generate(workspace As Workspace, totalRows As Integer, minOrderDate As DateTime, maxOrderDate As DateTime, minShippedDays As Integer, maxShippedDays As Integer)
            Dim list = Item.GenerateList(totalRows, minOrderDate, maxOrderDate, minShippedDays, maxShippedDays)
            Dim connector = New C1.DataEngine.ObjectConnector(Of Item)(workspace, list)
            connector.GetData(Name)
        End Sub

        ' table row
        Private Class Item
            Public Property OrderID() As Integer
                Get
                    Return m_OrderID
                End Get
                Set(value As Integer)
                    m_OrderID = Value
                End Set
            End Property
            Private m_OrderID As Integer
            Public Property OrderDate() As DateTime
                Get
                    Return m_OrderDate
                End Get
                Set(value As DateTime)
                    m_OrderDate = Value
                End Set
            End Property
            Private m_OrderDate As DateTime
            Public Property ShippedDate() As DateTime
                Get
                    Return m_ShippedDate
                End Get
                Set(value As DateTime)
                    m_ShippedDate = Value
                End Set
            End Property
            Private m_ShippedDate As DateTime
            Public Property ShipName() As String
                Get
                    Return m_ShipName
                End Get
                Set(value As String)
                    m_ShipName = Value
                End Set
            End Property
            Private m_ShipName As String
            Public Property ShipCountry() As String
                Get
                    Return m_ShipCountry
                End Get
                Set(value As String)
                    m_ShipCountry = Value
                End Set
            End Property
            Private m_ShipCountry As String

            ' generates a list of rows with random data
            Public Shared Iterator Function GenerateList(totalRows As Integer, minOrderDate As DateTime, maxOrderDate As DateTime, minShippedDays As Integer, maxShippedDays As Integer) As IEnumerable(Of Item)
                Dim r As New Random()
                If totalRows = 0 Then
                    totalRows = r.[Next]()
                End If
                If minShippedDays = 0 Then
                    minShippedDays = 1
                End If
                If maxShippedDays = 0 Then
                    maxShippedDays = r.[Next](minShippedDays, totalRows)
                End If
                Dim names = DataGenerator.GetUserNames()
                Dim countries = DataGenerator.GetCountries()
                For i As Integer = 0 To totalRows - 1
                    Dim item = New Item()
                    item.OrderID = DataGenerator.GenerateInt(i, 0, totalRows, r)
                    item.OrderDate = DataGenerator.GenerateDate(minOrderDate, maxOrderDate, r)
                    item.ShippedDate = DataGenerator.GenerateShiftedDate(item.OrderDate, minShippedDays, maxShippedDays, r)
                    item.ShipName = DataGenerator.GenerateString(names, r)
                    item.ShipCountry = DataGenerator.GenerateString(countries, r)
                    Yield item
                Next
            End Function
        End Class
    End Class
End Namespace
