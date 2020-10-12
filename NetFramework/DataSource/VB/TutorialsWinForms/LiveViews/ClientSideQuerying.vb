Imports C1.Data.Entities
Imports C1.Data
Imports C1.LiveLinq
Imports C1.LiveLinq.LiveViews

Public Class ClientSideQuerying
    Private _scope As EntityClientScope = Program.ClientCache.CreateScope()
    Private _seafoodProductsView As ClientView(Of Product)
    Private _viewProducts As View(Of Object)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _viewProducts =
            (From p In _scope.GetItems(Of Product)()
             Where Not p.Discontinued And p.UnitPrice >= 30
             Order By p.UnitPrice
             Select New With
             {
                 p.ProductID,
                 p.ProductName,
                 p.CategoryID,
                 p.Category.CategoryName,
                 p.SupplierID,
                 .Supplier = p.Supplier.CompanyName,
                 p.UnitPrice,
                 p.QuantityPerUnit,
                 p.UnitsInStock,
                 p.UnitsOnOrder
             }).AsDynamic()

        dataGridView1.DataSource = _viewProducts

        _seafoodProductsView = _scope.GetItems(Of Product)().AsFiltered(Function(p) p.CategoryID.HasValue AndAlso p.CategoryID.Value = 8)

        labelCount.DataBindings.Add(New Binding("Text", _viewProducts.LiveCount(), "Value"))

    End Sub

    Private Sub raiseButton_Click(sender As System.Object, e As System.EventArgs) Handles raiseButton.Click
        For Each p In _seafoodProductsView
            p.UnitPrice *= 1.2
        Next
    End Sub

    Private Sub cutButton_Click(sender As System.Object, e As System.EventArgs) Handles cutButton.Click
        For Each p In _seafoodProductsView
            p.UnitPrice /= 1.2
        Next
    End Sub
End Class