Imports C1.Data.Entities
Imports C1.Data

Public Class DataSourcesInCode

    Private _scope As EntityClientScope


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _scope = Program.ClientCache.CreateScope()

        Dim viewCategories As ClientView(Of Category) = _scope.GetItems(Of Category)()

        comboBox1.DisplayMember = "CategoryName"
        comboBox1.ValueMember = "CategoryID"
        comboBox1.DataSource = viewCategories

        BindGrid(viewCategories.First().CategoryID)
    End Sub

    Private Sub BindGrid(categoryID As Integer)
        C1FlexGrid1.DataSource =
                (From p In _scope.GetItems(Of Product)().AsFiltered(Function(p As Product) p.CategoryID.HasValue AndAlso p.CategoryID.Value = categoryID)
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
    End Sub


    Private Sub btnSaveChanges_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveChanges.Click
        Program.ClientCache.SaveChanges()
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        If comboBox1.SelectedValue IsNot Nothing Then
            BindGrid(CType(comboBox1.SelectedValue, Integer))
        End If
    End Sub
End Class