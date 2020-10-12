Public Class MyExtRecordsetForm
    Public Function Edit(recordset As MyExtRecordset) As Boolean
        tbRecCount.Text = recordset.RecCount.ToString()
        Dim result As Boolean = ShowDialog() = System.Windows.Forms.DialogResult.OK
        If (result) Then
            recordset.RecCount = Integer.Parse(tbRecCount.Text)
        End If
        Return result
    End Function
End Class