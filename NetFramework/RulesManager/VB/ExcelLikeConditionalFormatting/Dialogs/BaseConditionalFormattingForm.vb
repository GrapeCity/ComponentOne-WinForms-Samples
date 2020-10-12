Imports System.ComponentModel

Public Class BaseConditionalFormattingForm
    <DefaultValue("Operation:")>
    Public Property ConditionalOperationText As String
        Get
            Return lblOperationText?.Text
        End Get
        Set(ByVal value As String)
            Dim operationText = lblOperationText

            If operationText IsNot Nothing Then
                operationText.Text = value
            End If
        End Set
    End Property

    <DefaultValue(DirectCast(Nothing, Object))>
    Public Property EditorRowControl As Control
        Get
            Return tlpMainLayout?.GetControlFromPosition(0, 1)
        End Get
        Set(ByVal value As Control)
            Dim mainLayout = tlpMainLayout

            If mainLayout Is Nothing Then
                Return
            End If

            Dim control = mainLayout.GetControlFromPosition(0, 1)

            If control IsNot Nothing Then

                If control IsNot value Then
                    mainLayout.Controls.Remove(control)
                Else
                    Return
                End If
            End If

            mainLayout.Controls.Add(value, 0, 1)
        End Set
    End Property
End Class