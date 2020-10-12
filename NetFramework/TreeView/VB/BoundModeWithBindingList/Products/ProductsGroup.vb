Imports System.ComponentModel

Public Class ProductsGroup

    Public Property ID As Guid
    Public Property Name As String
    Public Property Products As BindingList(Of Product)
    Public ReadOnly Property CountOfProducts As Int32
        Get
            Return Products.Count
        End Get
    End Property

    Public Sub New(Name As String)
        Me.ID = Guid.NewGuid()
        Me.Name = Name
        Me.Products = New BindingList(Of Product)
    End Sub

    Public Overrides Function ToString() As String
        Return Name
    End Function

End Class
