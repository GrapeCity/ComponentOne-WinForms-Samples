Public Class ServerSideFiltering

    Private Sub comboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        ' Update current filter value. It will trigger automatic loading.
        C1DataSource1.ViewSources("Products").FilterDescriptors(0).Value = comboBox1.SelectedValue
    End Sub

    Private Sub btnSaveChanges_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveChanges.Click
        C1DataSource1.ClientCache.SaveChanges()
    End Sub
End Class