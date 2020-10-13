Imports System.ComponentModel

Public Class StoreCollection
    Inherits BindingList(Of Store)

    Public Shared Function GetData() As StoreCollection
        Dim stores = New StoreCollection()

        stores.Add(New Store("Pear Inc."))
        stores(0).ProductsGroups.Add(New ProductsGroup("Mobile phones"))
        stores(0).ProductsGroups(0).Products.Add(New Product("fPhone 34", 999.99))
        stores(0).ProductsGroups(0).Products.Add(New Product("fPhone 34Z", 9999.99))
        stores(0).ProductsGroups(0).Products.Add(New Product("fPhone 34XX", 100000))
        stores(0).ProductsGroups.Add(New ProductsGroup("Notebooks"))
        stores(0).ProductsGroups(1).Products.Add(New Product("DuckBook S", 9999.99))
        stores(0).ProductsGroups(1).Products.Add(New Product("DuckBook Ultra", 14000))
        stores(0).ProductsGroups(1).Products.Add(New Product("DuckBook Pro", 20000))
        stores(0).ProductsGroups.Add(New ProductsGroup("Computers"))
        stores(0).ProductsGroups(2).Products.Add(New Product("DuckPC 3", 10000.99))
        stores(0).ProductsGroups(2).Products.Add(New Product("DuckPro X", 15000))
        stores(0).ProductsGroups(2).Products.Add(New Product("DuckPro Ultra", 19000))

        stores.Add(New Store("Space Inc."))
        stores(1).ProductsGroups.Add(New ProductsGroup("Mobile phones"))
        stores(1).ProductsGroups(0).Products.Add(New Product("Rocket 1A", 900))
        stores(1).ProductsGroups(0).Products.Add(New Product("Rocket 2X", 3999))
        stores(1).ProductsGroups(0).Products.Add(New Product("Rocket 3E", 20000))
        stores(1).ProductsGroups.Add(New ProductsGroup("Notebooks"))
        stores(1).ProductsGroups(1).Products.Add(New Product("Shuttle 1A", 9999.99))
        stores(1).ProductsGroups(1).Products.Add(New Product("Shuttle 1X", 14000))
        stores(1).ProductsGroups(1).Products.Add(New Product("Shuttle Pro", 20000))
        stores(1).ProductsGroups.Add(New ProductsGroup("Computers"))
        stores(1).ProductsGroups(2).Products.Add(New Product("IssPC 2D", 10000.99))
        stores(1).ProductsGroups(2).Products.Add(New Product("IssPro 2X", 15000))
        stores(1).ProductsGroups(2).Products.Add(New Product("IssPro Pro", 19000))

        stores.Add(New Store("Fruit Inc."))
        stores(2).ProductsGroups.Add(New ProductsGroup("Mobile phones"))
        stores(2).ProductsGroups(0).Products.Add(New Product("Pineapple 1", 2900))
        stores(2).ProductsGroups(0).Products.Add(New Product("Mango 1", 3099))
        stores(2).ProductsGroups(0).Products.Add(New Product("Orange 1", 5000))
        stores(2).ProductsGroups.Add(New ProductsGroup("Notebooks"))
        stores(2).ProductsGroups(1).Products.Add(New Product("Mandarin X", 9999.99))
        stores(2).ProductsGroups(1).Products.Add(New Product("Lemon X", 14000))
        stores(2).ProductsGroups(1).Products.Add(New Product("Lemon Pro", 20000))
        stores(2).ProductsGroups.Add(New ProductsGroup("Computers"))
        stores(2).ProductsGroups(2).Products.Add(New Product("Plum X", 10000.99))
        stores(2).ProductsGroups(2).Products.Add(New Product("Plum Z", 15000))
        stores(2).ProductsGroups(2).Products.Add(New Product("Plum Pro", 19000))

        Return stores
    End Function
End Class
