Public Class SaleInfo
    Public Property DateSold As DateTime
    Public Property Seller As Transactor
    Public Property Buyer As Transactor
    Public Property ItemsInfo As String
    Public Property ItemsValue As Integer
    Public Property FormOfPayment As String

    Public Sub New(ByVal dateS As DateTime, ByVal s As Transactor, ByVal b As Transactor, ByVal itemsInfo As String, ByVal itemsValue As Integer, ByVal formPayment As String)
        Me.DateSold = dateS
        Me.Seller = s
        Me.Buyer = b
        Me.ItemsInfo = itemsInfo
        Me.ItemsValue = itemsValue
        Me.FormOfPayment = formPayment
    End Sub
End Class

Public Structure Transactor
    Public Property PrintedName As String
    Public Property Address As String
    Public Property City As String
    Public Property State As String
    Public Property Zip As String
    Public Property HomePhone As String
    Public Property CellPhone As String
    Public Property Work As String
    Public Property DateSign As DateTime

    Public Sub New(ByVal printName As String, ByVal adress As String, ByVal city As String, ByVal state As String, ByVal zip As String, ByVal homePhone As String, ByVal cellPhone As String, ByVal work As String, ByVal dateSign As DateTime)
        Me.PrintedName = printName
        Me.Address = adress
        Me.City = city
        Me.State = state
        Me.Zip = zip
        Me.HomePhone = homePhone
        Me.CellPhone = cellPhone
        Me.Work = work
        Me.DateSign = dateSign
    End Sub
End Structure