Public Class MainForm

    Private Sub showSimpleBinding_Click(sender As System.Object, e As System.EventArgs) Handles showSimpleBinding.Click
        Dim form As New SimpleBinding()
        form.Show()
    End Sub

    Private Sub showServerSideFiltering_Click(sender As System.Object, e As System.EventArgs) Handles showServerSideFiltering.Click
        Dim form As New ServerSideFiltering()
        form.Show()
    End Sub

    Private Sub showMasterDetailBinding_Click(sender As System.Object, e As System.EventArgs) Handles showMasterDetailBinding.Click
        Dim form As New MasterDetailBinding()
        form.Show()
    End Sub

    Private Sub showPaging_Click(sender As System.Object, e As System.EventArgs) Handles showPaging.Click
        Dim form As New Paging()
        form.Show()
    End Sub

    Private Sub showLargeDataset_Click(sender As System.Object, e As System.EventArgs) Handles showLargeDataset.Click
        Dim form As New LargeDataset()
        form.Show()
    End Sub

    Private Sub showCustomColumns_Click(sender As System.Object, e As System.EventArgs) Handles showCustomColumns.Click
        Dim form As New CustomColumns()
        form.Show()
    End Sub

    Private Sub showDataSourcesInCode_Click(sender As System.Object, e As System.EventArgs) Handles showDataSourcesInCode.Click
        Dim form As New DataSourcesInCode()
        form.Show()
    End Sub

    Private Sub showClientSideQuerying_Click(sender As System.Object, e As System.EventArgs) Handles showClientSideQuerying.Click
        Dim form As New ClientSideQuerying()
        form.Show()
    End Sub

    Private Sub showMVVM_Click(sender As System.Object, e As System.EventArgs) Handles showMVVM.Click
        Dim form As New CategoryProductsView()
        form.Show()
    End Sub
End Class
