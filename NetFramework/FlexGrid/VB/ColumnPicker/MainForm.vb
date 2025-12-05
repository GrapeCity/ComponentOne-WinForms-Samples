Imports C1.Win.FlexGrid
Imports C1.Win.Themes
Imports C1.Win.Ribbon

Partial Public Class MainForm
    Inherits C1RibbonForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'C1NWindDataSet.Orders' table. You can move, or remove it, as needed.
        Dim conn = $"provider=microsoft.jet.oledb.4.0;data source={Environment.GetFolderPath(Environment.SpecialFolder.Personal)}\ComponentOne Samples\Common\c1nwind.mdb;"
        OrdersTableAdapter.Connection.ConnectionString = conn
        Me.OrdersTableAdapter.Fill(Me.C1NWindDataSet.Orders)
        InitThemes()
    End Sub

#Region "Themes"

    Private Sub CmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThemes.SelectedIndexChanged
        C1ThemeController1.Theme = cmbThemes.SelectedItem.Text
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office365"))
        For Each theme In themes
            cmbThemes.Items.Add(theme)
        Next
        cmbThemes.SelectedIndex = cmbThemes.Items.IndexOf("Office365Green")
    End Sub

#End Region

    Private Sub rbCreateBands_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbCreateBands.Click
        If C1FlexGridBandedView1.FlexGrid IsNot Nothing Then Return
        C1FlexGrid1.BeginUpdate()
        C1FlexGridBandedView1.FlexGrid = C1FlexGrid1
        C1FlexGridBandedView1.BandsColumnsRelation = BandsColumnsRelation.BandsBeforeColumns
        C1FlexGridBandedView1.BeginUpdate()
        C1FlexGridBandedView1.Bands.Clear()
        Dim bands = C1FlexGridBandedView1.Bands
        Dim b1 = bands.Add(C1FlexGrid1.Cols("OrderID"))
        b1.Caption = "Order"
        Dim b2 = b1.Children.Add(C1FlexGrid1.Cols("OrderDate"))
        b2.Caption = "Date"
        Dim b3 = b1.Children.Add(C1FlexGrid1.Cols("CustomerID"))
        b3.Caption = "Customer"
        C1FlexGridBandedView1.EndUpdate()
        C1FlexGrid1.EndUpdate()
    End Sub

    Private Sub rbRemoveBands_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbRemoveBands.Click
        If C1FlexGridBandedView1.FlexGrid Is Nothing Then Return
        C1FlexGrid1.BeginUpdate()
        C1FlexGridBandedView1.FlexGrid = Nothing
        C1FlexGridBandedView1.BeginUpdate()
        C1FlexGridBandedView1.Bands.Clear()
        C1FlexGridBandedView1.EndUpdate()
        C1FlexGrid1.EndUpdate()
    End Sub
End Class
