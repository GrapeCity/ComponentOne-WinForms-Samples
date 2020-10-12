Imports C1.Data.Transactions
Imports C1.Data.Entities
Imports C1.LiveLinq.LiveViews
Imports C1.LiveLinq.Collections
Imports C1.LiveLinq
Imports C1.WPF.LiveLinq

Public Class OrderForm

    ' All changes in this form are made in the scope of this client transaction.
    Private _transaction As ClientTransaction

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(order As Order, transaction As ClientTransaction)
        InitializeComponent()
        _transaction = transaction

        ' Create a proxy for the order that automatically opens the transaction scope
        ' each time a value is assigned to a property.
        Dim tranOrder = _transaction.ScopeDataContext(order)

        ' Bind text boxes to the properties of the proxy object.
        BindTextBox(textBoxID, tranOrder, "OrderID")
        BindTextBox(textBoxFreight, tranOrder, "Freight")
        BindTextBox(textBoxOrderDate, tranOrder, "OrderDate")
        BindTextBox(textBoxShipName, tranOrder, "ShipName")
        BindTextBox(textBoxShipCity, tranOrder, "ShipCity")

        ' Define a live view of order details.
        Dim orderDetailsView = From od In order.Order_Details.AsLive()
                               Select New OrderDetailsInfo With
                               {
                                   .OrderID = od.OrderID,
                                   .ProductID = od.ProductID,
                                   .UnitPrice = od.UnitPrice,
                                   .Discount = od.Discount,
                                   .Quantity = od.Quantity
                               }
        ' All changes in this view are made in the transaction scope.
        orderDetailsView.SetTransaction(_transaction)
        orderDetailsGrid.DataSource = orderDetailsView
    End Sub

    Sub BindTextBox(textBox As TextBox, dataSource As Object, dataMember As String)
        ' Bind the text of the text box to the property of the dataSource object.
        textBox.DataBindings.Add(New Binding("Text", dataSource, dataMember) With {.FormattingEnabled = True})
    End Sub

    Private Sub buttonOK_Click(sender As System.Object, e As System.EventArgs) Handles buttonOK.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub buttonCancel_Click(sender As System.Object, e As System.EventArgs) Handles buttonCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class

' This class is used as the result item type of an order detail view defined above.
Public Class OrderDetailsInfo
    Public Overridable Property OrderID As Integer
    Public Overridable Property ProductID As Integer
    Public Overridable Property UnitPrice As Decimal
    Public Overridable Property Discount As Single
    Public Overridable Property Quantity As Decimal
End Class
