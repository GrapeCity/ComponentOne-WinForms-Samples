Imports C1.Data
Imports C1.Data.Entities
Imports C1.LiveLinq.LiveViews

Public Class MainForm
    ' A client cache and a client scope that are used to load the data.
    Private _clientCache As EntityClientCache
    Private _scope As EntityClientScope

    Public Sub New()
        InitializeComponent()

        ' Initialize the client cache and the client scope.
        _clientCache = New EntityClientCache(New NORTHWNDEntities())
        _scope = New EntityClientScope(_clientCache)

        ' Bind a combo box to the list of cities
        ' using a live view of customers grouped by city.
        comboBoxCity.DisplayMember = "City"
        comboBoxCity.DataSource =
            (From c In _scope.GetItems(Of Customer)()
             Group c By Key = c.City Into g = Group
             Order By Key
             Select New With
             {
                 .City = Key,
                 .Customers = g
             }).AsDynamic()
    End Sub

    Private Sub EditOrdersForCustomer()
        If Not (TypeOf listBoxCustomers.SelectedItem Is ViewRow) Then
            Exit Sub
        End If
        ' Start editing the selected customer.
        Dim row As ViewRow = CType(listBoxCustomers.SelectedItem, ViewRow)
        Dim customer As Customer = row.Value

        ' If the customer is already being edited, then select the tab page associated with that customer.
        For Each page In tabControl1.TabPages
            If page.Text = customer.ContactName Then
                tabControl1.SelectedTab = page
                Exit Sub
            End If
        Next

        ' Create a CustomerControl for the current customer
        ' and display it in the tab control.
        tabControl1.TabPages.Add(customer.ContactName)
        Dim tabIdx As Integer = tabControl1.TabPages.Count - 1
        Dim tabPage As TabPage = tabControl1.TabPages(tabIdx)
        Dim customerControl As CustomerControl = New CustomerControl(Me, tabPage, customer, _clientCache)
        customerControl.Anchor = AnchorStyles.Bottom + AnchorStyles.Top + AnchorStyles.Right + AnchorStyles.Left
        customerControl.Size = tabPage.Size
        customerControl.Parent = tabPage
        tabControl1.SelectedIndex = tabIdx
    End Sub

    Public Sub CloseRequested(tabPage As TabPage)
        ' Remove the tab page when its Close button is pressed.
        tabControl1.TabPages.Remove(tabPage)
    End Sub

    Private Sub comboBoxCity_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboBoxCity.SelectedIndexChanged
        If Not (TypeOf comboBoxCity.SelectedItem Is ViewRow) Then
            Exit Sub
        End If
        ' Display the customers of the selected city.
        Dim row As ViewRow = CType(comboBoxCity.SelectedItem, ViewRow)
        If Not (row Is Nothing) Then
            listBoxCustomers.DisplayMember = "ContactName"
            listBoxCustomers.DataSource = row.Value.Customers
        End If
    End Sub

    Private Sub listBoxCustomers_DoubleClick(sender As System.Object, e As System.EventArgs) Handles listBoxCustomers.DoubleClick
        ' Start editing the selected customer on double click.
        EditOrdersForCustomer()
    End Sub

End Class
