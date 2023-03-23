Public Class CategoryProductsView

    Private viewModel As CategoryProductsViewModel = New CategoryProductsViewModel()

    Public Sub New()
        InitializeComponent()

        ' Connect this view to the view model.
        comboBox1.DisplayMember = "CategoryName"
        comboBox1.ValueMember = "CategoryID"
        comboBox1.DataSource = viewModel.Categories
        C1FlexGrid1.DataSource = viewModel.Products

    End Sub
End Class