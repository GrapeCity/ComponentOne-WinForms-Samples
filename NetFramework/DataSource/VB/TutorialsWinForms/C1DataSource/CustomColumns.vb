Imports C1.LiveLinq.LiveViews

Public Class CustomColumns

    Public Sub New()
        InitializeComponent()

        ' Define a live view with custom fields.
        ' The data grid will automatically generate columns based on these fields.
        dataGridView1.DataSource = _
            (From p In c1DataSource1("Products").AsLive(Of Product)()
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
             }).AsDynamic() ' AsDynamic() is required for data binding because an anonymous class is used (select new ...)
    End Sub
End Class