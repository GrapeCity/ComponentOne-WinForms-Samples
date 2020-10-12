Imports System.IO
Imports System.Text
Imports C1.Win.C1Editor

''' <summary>
''' Class used to edit and render Html in C1FlexGrid cells.
''' </summary>
''' <remarks></remarks>
Public Class HtmlEditor
    Inherits C1Editor

    ' save HTML content when done editing
    Public Function C1EditorGetValue() As Object
        Dim ms As New MemoryStream
        MyBase.SaveXml(ms)
        Dim byteArray As New List(Of Byte)(ms.ToArray)
        byteArray.RemoveRange(0, 3)
        Return Encoding.UTF8.GetString(byteArray.ToArray)
    End Function

    ' assign HTML content when editing starts
    Public Sub C1EditorInitialize(ByVal value As Object, ByVal editorAttributes As IDictionary)
        MyBase.LoadXml(CStr(value), Nothing)
    End Sub

    Public Function C1EditorValueIsValid() As Boolean
        Return MyBase.Enabled
    End Function

    ' support ctrl-B, I, U to implement bold/italic/underline
    Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
        If ((Not MyBase.SelectedText Is Nothing) AndAlso (e.Modifiers = Keys.Control)) Then
            Select Case e.KeyCode
                Case Keys.B
                    Me.ToggleStyle(FontStyle.Bold)
                    e.Handled = True
                    e.SuppressKeyPress = True
                    Return
                Case Keys.I
                    Me.ToggleStyle(FontStyle.Italic)
                    e.Handled = True
                    e.SuppressKeyPress = True
                    Return
                Case Keys.U
                    Me.ToggleStyle(FontStyle.Underline)
                    e.Handled = True
                    e.SuppressKeyPress = True
                    Return
            End Select
        End If
        MyBase.OnKeyDown(e)
    End Sub

    Private Sub ToggleStyle(ByVal fs As FontStyle)
        Select Case fs
            Case FontStyle.Bold
                If Not MyBase.Selection.IsTagApplied("b") Then
                    MyBase.Selection.ApplyTag("b")
                    Exit Select
                End If
                MyBase.Selection.RemoveTag("b")
                Exit Select
            Case FontStyle.Italic
                If Not MyBase.Selection.IsTagApplied("i") Then
                    MyBase.Selection.ApplyTag("i")
                    Exit Select
                End If
                MyBase.Selection.RemoveTag("i")
                Exit Select
            Case FontStyle.Underline
                If (Not MyBase.Selection.IsStyleApplied("text-decoration") OrElse (String.Compare(MyBase.Selection.GetStyleValue("text-decoration", C1StyleType.Character), "underline", True) <> 0)) Then
                    MyBase.Selection.ApplyStyle("text-decoration", "underline", C1StyleType.Character)
                    Exit Select
                End If
                MyBase.Selection.RemoveStyle("text-decoration", Nothing)
                Exit Select
        End Select
    End Sub

End Class
