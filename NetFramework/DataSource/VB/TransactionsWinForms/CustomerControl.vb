Imports C1.Data
Imports C1.Data.Entities
Imports C1.Data.Transactions
Imports C1.WPF.LiveLinq

Public Class CustomerControl
    Private _mainForm As MainForm
    Private _tabPage As TabPage
    ' The customer being edited.
    Public Customer As Customer
    ' This view contains the orders of the customer.
    Private _ordersView As C1.LiveLinq.LiveViews.View
    ' All changes in this control are made in the scope of this transaction.
    Private _transaction As ClientTransaction
    Private _cache As EntityClientCache

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainFrm As MainForm, tabPage As TabPage, cust As Customer, clientCache As EntityClientCache)
        InitializeComponent()
        _mainForm = mainFrm
        _tabPage = tabPage
        _cache = clientCache
        Customer = cust

        ' Define and bind a live view of orders of the current customer.
        _ordersView = From o In Customer.Orders.AsLive()
                      Select New OrderInfo(o) With
                      {
                          .OrderID = o.OrderID,
                          .OrderDate = o.OrderDate,
                          .Freight = o.Freight,
                          .ShipName = o.ShipName,
                          .ShipCity = o.ShipCity
                      }
        CreateTransaction()
        ordersGrid.DataSource = _ordersView
    End Sub

    Private Sub transaction_PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs)
        ' The Undo button is enabled if and only if there are changes made in the transaction scope.
        buttonUndo.Enabled = _transaction.HasChanges
    End Sub

    Private Sub CreateTransaction()
        ' Initialize the client transaction.
        ' Specify that all changes to _ordersView are automatically considered changes made in the scope of this transaction.
        _transaction = _cache.CreateTransaction()
        _ordersView.SetTransaction(_transaction)

        ' Enable/disable the Undo button when the _transaction.HasChanges property value changes.
        AddHandler _transaction.PropertyChanged, AddressOf transaction_PropertyChanged
        buttonUndo.Enabled = False
    End Sub


    Private Sub buttonClose_Click(sender As System.Object, e As System.EventArgs) Handles buttonClose.Click
        If _transaction.HasChanges Then
            ' Ask the user whether they will save or cancel the changes made by this control.
            Select Case MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    _transaction.Commit()
                Case DialogResult.No
                    _transaction.Rollback()
                Case DialogResult.Cancel
                    Exit Sub
            End Select
        End If
        ' Tell MainForm to remove the tab page containing this control.
        _mainForm.CloseRequested(_tabPage)
    End Sub

    Private Sub buttonUndo_Click(sender As System.Object, e As System.EventArgs) Handles buttonUndo.Click
        ' Cancel the changes made by this control
        ' by rolling back the _transaction.
        RemoveHandler _transaction.PropertyChanged, AddressOf transaction_PropertyChanged
        _transaction.Rollback()
        ' Create a new transaction.
        CreateTransaction()
    End Sub

    Private Sub buttonEdit_Click(sender As System.Object, e As System.EventArgs) Handles buttonEdit.Click
        If Not (TypeOf BindingContext(_ordersView).Current Is C1.LiveLinq.LiveViews.ViewRow) Then
            Exit Sub
        End If
        Dim row As C1.LiveLinq.LiveViews.ViewRow = CType(BindingContext(_ordersView).Current, C1.LiveLinq.LiveViews.ViewRow)
        If row Is Nothing Then
            Exit Sub
        End If
        Dim order As Order = CType(row.Value, OrderInfo).GetOrder()

        ' Edit the order in a child transaction scope.
        ' Rolling back the child transaction will not roll back the parent transaction.
        Using tran2 As New ClientTransaction(_transaction)
            Dim window As OrderForm = New OrderForm(order, tran2)
            If window.ShowDialog() = DialogResult.OK Then
                tran2.Commit()
            End If
        End Using ' The child transaction will be rolled back automatically if it is not committed.

    End Sub

    Private Sub buttonAdd_Click(sender As System.Object, e As System.EventArgs) Handles buttonAdd.Click
        ' Add a new Order in a child transaction scope.
        ' Rolling back the child transaction will not roll back the parent transaction.
        Using tran2 As New ClientTransaction(_transaction)
            Dim order As Order = New Order()
            Using scope As Object = tran2.Scope()
                _cache.ObjectContext.AddObject("Orders", order)
            End Using
            Dim window As OrderForm = New OrderForm(order, tran2)
            If window.ShowDialog() = DialogResult.OK Then
                ' Add the order to the Customer.Orders in the child transaction scope and commit the transaction.
                Using scope As Object = tran2.Scope()
                    Customer.Orders.Add(order)
                    tran2.Commit()
                End Using
            End If
        End Using ' The child transaction will be rolled back automatically if it is not committed.
    End Sub

    Private Sub buttonDelete_Click(sender As System.Object, e As System.EventArgs) Handles buttonDelete.Click
        ' Remove the selected order.
        If Not (TypeOf BindingContext(_ordersView).Current Is C1.LiveLinq.LiveViews.ViewRow) Then
            Exit Sub
        End If
        Dim row As C1.LiveLinq.LiveViews.ViewRow = CType(BindingContext(_ordersView).Current, C1.LiveLinq.LiveViews.ViewRow)
        If row Is Nothing Then
            Exit Sub
        End If
        Dim order As Order = CType(row.Value, OrderInfo).GetOrder()

        Using scope As Object = _transaction.Scope()
            ' Make the change in the transaction scope.
            Customer.Orders.Remove(order)
        End Using
    End Sub
End Class

' This class is used as the result item type of an order view defined above.
Public Class OrderInfo
    Private _order As Order

    Public Sub New(o As Order)
        _order = o
    End Sub

    Public Function GetOrder() As Order
        Return _order
    End Function

    Public Overridable Property OrderID As Integer
    Public Overridable Property OrderDate As DateTime?
    Public Overridable Property Freight As Decimal?
    Public Overridable Property ShipName As String
    Public Overridable Property ShipCity As String
End Class
