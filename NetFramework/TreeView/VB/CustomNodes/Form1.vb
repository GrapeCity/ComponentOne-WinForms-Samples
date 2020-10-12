Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common")
        ' fill data
        ProductsTableAdapter1.Fill(DataSet11.Products)
        CategoriesTableAdapter1.Fill(DataSet11.Categories)
        ' set data to treeview            
        C1TreeView1.BindingInfo.DataMember = "Categories\Products"
        C1TreeView1.BindingInfo.KeyField = "CategoryID\CategoryID"
        C1TreeView1.BindingInfo.DataSource = DataSet11
        ' set custom nodes
        C1TreeView1.Columns(0).CustomContentPresenter = New CategoryCustomNode()
        C1TreeView1.Columns(1).CustomContentPresenter = New ProductCustomNode()
    End Sub
End Class
