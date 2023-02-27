Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common")
        'TODO: This line of code loads data into the 'C1NWindDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.C1NWindDataSet.Products)

    End Sub
    Private Sub Evaluate()
        'check if there are no errors in ExpressionEditor
        If (C1ExpressionEditor1.IsValid) Then
            'set ItemContext - data row which needs to be calculated
            C1ExpressionEditor1.ItemContext = C1NWindDataSet.Products.Rows(C1DbNavigator1.Position)
            Dim result As Object = Nothing
            'try to evaluate expression
            If (C1ExpressionEditor1.TryEvaluate(result)) Then
                TextBox1.Text = result.ToString()
            Else
                TextBox1.Text = C1ExpressionEditor1.GetErrors()(0).ToString()
            End If
        End If
    End Sub
    Private Sub C1ExpressionEditor1_ExpressionChanged(sender As Object, e As EventArgs) Handles C1ExpressionEditor1.ExpressionChanged
        Evaluate()
    End Sub

    Private Sub C1DbNavigator1_PositionChanged(sender As Object, e As EventArgs) Handles C1DbNavigator1.PositionChanged
        Evaluate()
    End Sub
End Class
