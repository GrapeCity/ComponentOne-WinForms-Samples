Imports C1.Data.Entities

' This file contains View Models used in the CategoryProductsView.

' The properties of the following two view models 
' must be virtual to make live view items modifiable.
Public Class CategoryViewModel
    Public Overridable Property CategoryID As Integer
    Public Overridable Property CategoryName As String
End Class


Public Class ProductViewModel
    Public Overridable Property ProductID As Integer
    Public Overridable Property ProductName As String
    Public Overridable Property CategoryID As Integer?
    Public Overridable Property CategoryName As String
    Public Overridable Property SupplierID As Integer?
    Public Overridable Property SupplierName As String
    Public Overridable Property UnitPrice As Decimal?
    Public Overridable Property QuantityPerUnit As String
    Public Overridable Property UnitsInStock As Short?
    Public Overridable Property UnitsOnOrder As Short?
End Class

Public Class CategoryProductsViewModel
    ' This client scope will be used to load the data.
    Private _scope As EntityClientScope = Program.ClientCache.CreateScope()

    ' Data grids in this view are bound to these data sources.
    Private _categories As BindingSource
    Public Property Categories As BindingSource
        Get
            Return _categories
        End Get
        Private Set(value As BindingSource)
            _categories = value
        End Set
    End Property

    Private _products As BindingSource
    Public Property Products As BindingSource
        Get
            Return _products
        End Get
        Private Set(value As BindingSource)
            _products = value
        End Set
    End Property

    Public Sub New()
        ' These binding sources will be used by the CategoryProductsView
        ' to display categories and products.
        Dim CategoriesView As Object =
            From c In _scope.GetItems(Of TutorialsWinForms.Category)()
            Select New CategoryViewModel With
            {
                .CategoryID = c.CategoryID,
                .CategoryName = c.CategoryName
            }
        Categories = New BindingSource(CategoriesView, Nothing)

        ' Products are filtered by CategoryID on the server.
        ' Filtering is performed automatically when the current Category changes.
        ' Product suppliers are fetched along with the products.
        Dim ProductsView As Object =
            From p In _scope.GetItems(Of TutorialsWinForms.Product)().AsFilteredBound(Function(p) p.CategoryID).BindFilterKey(Categories, "Current.CategoryID").Include("Supplier")
            Select New ProductViewModel With
            {
                .ProductID = p.ProductID,
                .ProductName = p.ProductName,
                .CategoryID = p.CategoryID,
                .CategoryName = p.Category.CategoryName,
                .SupplierID = p.SupplierID,
                .SupplierName = p.Supplier.CompanyName,
                .UnitPrice = p.UnitPrice,
                .QuantityPerUnit = p.QuantityPerUnit,
                .UnitsInStock = p.UnitsInStock,
                .UnitsOnOrder = p.UnitsOnOrder
            }
        Products = New BindingSource(ProductsView, Nothing)

    End Sub
End Class
