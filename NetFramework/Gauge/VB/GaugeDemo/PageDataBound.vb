Public Class PageDataBound

    Public Sub New()
        MyBase.New()

        InitializeComponent()

        Dim productsDataSet As DataSet = New DataSet("ProductsDataSet")
        productsDataSet.ReadXml("..\..\products.xml", System.Data.XmlReadMode.Auto)
        dataGridView1.DataSource = productsDataSet
        dataGridView1.DataMember = "Products"

        c1LinearGauge1.DataBindings.Add(New Binding( _
            "MorePointersValue_0", productsDataSet, "Products.ReorderLevel"))
        c1LinearGauge1.DataBindings.Add(New Binding( _
            "MorePointersValue_1", productsDataSet, "Products.UnitsOnOrder"))

        c1LinearGauge1.DataSource = productsDataSet
        c1LinearGauge1.DataField = "Products.UnitsInStock"

        Dim coll As DataGridViewColumnCollection = dataGridView1.Columns
        coll(0).Width = 70
        coll(1).Width = 80
        coll(2).Width = 80
        coll(3).Width = 80

    End Sub

End Class
