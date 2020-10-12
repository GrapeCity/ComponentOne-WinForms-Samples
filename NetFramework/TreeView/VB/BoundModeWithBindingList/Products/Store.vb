Imports System.ComponentModel

Public Class Store
    Public Property ID As Guid
    Public Property Name As String
    Public Property ProductsGroups As BindingList(Of ProductsGroup)
    Public ReadOnly Property CountOfProducts As Int32
        Get
            Dim count = 0
            For Each pg As ProductsGroup In ProductsGroups
                count += pg.CountOfProducts
            Next
            Return count
            End Get
    End Property

    Public Sub New(name As String)

        Me.ID = Guid.NewGuid()
        Me.Name = name
        Me.ProductsGroups = New BindingList(Of ProductsGroup)
    End Sub

    Public Overrides Function ToString() As String
        Return Name
    End Function

End Class
