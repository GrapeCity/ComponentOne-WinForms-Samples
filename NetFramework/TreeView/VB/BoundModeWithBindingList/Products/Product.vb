Public Class Product

    Public Property ID As Guid
    Public Property Name As String
    Public Property Price As Double

    Public Sub New(name As String, price As Double)
        Me.ID = Guid.NewGuid()
        Me.Name = name
        Me.Price = price
    End Sub


    Public Overrides Function ToString() As String
        Return Name
    End Function

End Class
