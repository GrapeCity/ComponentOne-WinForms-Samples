Imports C1.Win.TreeView

Public Class CustomDatePicker
    Inherits DateTimePicker
    Implements IC1TreeEditor

    Public Sub C1EditorInitialize(value As Object, attrs As IDictionary) Implements IC1TreeEditor.C1EditorInitialize
        AutoSize = False
        TabStop = False

        If (attrs.Contains("BackColor")) Then
            BackColor = CType(attrs("BackColor"), Color)
        End If
        If (attrs.Contains("Font")) Then
            Font = CType(attrs("Font"), Font)
        End If
        If (attrs.Contains("ForeColor")) Then
            ForeColor = CType(attrs("ForeColor"), Color)
        End If
        If (attrs.Contains("DisabledForeColor")) Then
            ForeColor = CType(attrs("DisabledForeColor"), Color)
        End If

        value = value
    End Sub

    Public Sub C1EditorSetFormat(format As String) Implements IC1TreeEditor.C1EditorSetFormat

    End Sub

    Public Sub C1EditorUpdateBounds(rc As Rectangle) Implements IC1TreeEditor.C1EditorUpdateBounds
        Bounds = rc
    End Sub

    Public Function C1EditorGetValue() As Object Implements IC1TreeEditor.C1EditorGetValue
        Return Value
    End Function

    Public Function C1EditorKeyDownFinishEdit(e As KeyEventArgs) As Boolean Implements IC1TreeEditor.C1EditorKeyDownFinishEdit
        If (e.KeyData = Keys.Enter) Then
            Return True
        End If
        Return False
    End Function

    Public Function C1EditorValueIsValid() As Boolean Implements IC1TreeEditor.C1EditorValueIsValid
        Return True
    End Function
End Class
