Public Class Form1

    Public Sub New()
        InitializeComponent()
        Font = SystemInformation.MenuFont
    End Sub

    Private Sub inputTextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles inputTextBox1.Validating
        If inputTextBox1.Text.Length > 0 AndAlso Not inputTextBox1.Text.StartsWith("a") Then
            inputTextBox1.ErrorText = BuildErrorTip(inputTextBox1, My.Resources.ErrStartWithA)
            e.Cancel = True
        Else
            inputTextBox1.ErrorText = String.Empty
        End If
    End Sub

    Private Sub inputNumericBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles inputNumericBox1.Validating
        If Not inputNumericBox1.ValueIsNull AndAlso inputNumericBox1.Value Mod 2 <> 0 Then
            inputNumericBox1.ErrorText = BuildErrorTip(inputNumericBox1, My.Resources.ErrEven)
            e.Cancel = True
        Else
            inputNumericBox1.ErrorText = String.Empty
        End If
    End Sub

    Private Sub inputNumericBox1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles inputNumericBox1.ValueChanged, inputNumericBox2.ValueChanged
        If inputNumericBox1.Value + inputNumericBox2.Value < 100 Then
            inputNumericBox2.ErrorText = BuildErrorTip(inputNumericBox2, My.Resources.Err100)
        Else
            inputNumericBox2.ErrorText = String.Empty
        End If
    End Sub

    Private Sub inputTimePicker1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles inputTimePicker1.Validating
        If Not inputTimePicker1.ValueIsNull AndAlso inputTimePicker1.Value < New TimeSpan(12, 0, 0) Then
            inputTimePicker1.ErrorText = BuildErrorTip(inputTimePicker1, My.Resources.ErrAfter12)
            e.Cancel = True
        Else
            inputTimePicker1.ErrorText = String.Empty
        End If
    End Sub

    Private Sub inputCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputCheckBox1.CheckedChanged, inputCheckBox2.CheckedChanged
        Dim S As String = String.Empty
        If Not inputCheckBox1.Checked AndAlso Not inputCheckBox2.Checked Then
            S = BuildErrorTip(inputCheckBox1, My.Resources.ErrOneBox)
        End If
        inputCheckBox1.ErrorText = S
        inputCheckBox2.ErrorText = S
    End Sub

    Private Function BuildErrorTip(ByVal c As C1.Win.C1InputPanel.InputComponent, ByVal err As String) As String
        Return String.Format( _
            "{0}<table style='background-color:#FFDDDD'>" + _
            "<tr style='vertical-align:top;'>" + _
            "<td><img src='res://errorinfo'/>" + _
            "<td>{1}</table>", _
            c.ToolTipText, _
            err)
    End Function
End Class
