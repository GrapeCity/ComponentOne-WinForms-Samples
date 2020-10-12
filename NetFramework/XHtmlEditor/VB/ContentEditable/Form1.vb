Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml

Partial Public Class Form1
    Inherits Form
    Private _fieldIDs As List(Of String) = Nothing

    Public Sub New()
        InitializeComponent()

        _fieldIDs = New List(Of String)(New String() {"f01", "f02", "f03", "f04", "f05", "f06", "f07", "f08"})

        AddHandler c1Editor1.KeyDown, AddressOf c1Editor1_KeyDown
        AddHandler c1Editor1.KeyUp, AddressOf c1Editor1_KeyUp

        c1Editor1.XmlExtensions = "<customization><attributes><attribute name=""contenteditable"" /></attributes></customization>"
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        c1Editor1.LoadXml(Resources.Document, Nothing)

        'select first input field
        Dim node As XmlNode = c1Editor1.Document.GetElementById(_fieldIDs(0))
        If node IsNot Nothing Then
            c1Editor1.CreateRange(node).[Select]()
        End If

        MyBase.OnLoad(e)
    End Sub

    Private Sub c1Editor1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If
    End Sub

    Private Sub c1Editor1_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Tab Then
            'searching current focused field
            Dim node As XmlNode = c1Editor1.Selection.Start.Node
            Dim currentField As XmlNode = Nothing
            While node IsNot Nothing
                Dim id As XmlAttribute = Nothing
                If node.Attributes IsNot Nothing Then
                    id = node.Attributes("id")
                End If
                If id IsNot Nothing AndAlso _fieldIDs.Contains(id.Value) Then
                    currentField = node
                    Exit While
                End If
                node = node.ParentNode
            End While

            'move focus to the next input field
            If currentField IsNot Nothing Then
                Dim currentId As String = currentField.Attributes("id").Value
                Dim idIndex As Integer = _fieldIDs.IndexOf(currentId)
                Dim nextIdIndex As Integer
                If e.Shift Then
                    If idIndex > 0 Then
                        nextIdIndex = idIndex - 1
                    Else
                        nextIdIndex = _fieldIDs.Count - 1
                    End If
                Else
                    If idIndex < _fieldIDs.Count - 1 Then
                        nextIdIndex = idIndex + 1
                    Else
                        nextIdIndex = 0
                    End If
                End If
                Dim nextField As XmlNode = c1Editor1.Document.SelectSingleNode(String.Format("//*[@id='{0}']", _fieldIDs(nextIdIndex)))
                If nextField IsNot Nothing Then
                    Dim range As C1.Win.C1Editor.C1TextRange = c1Editor1.CreateRange(nextField)
                    range.Normalize()
                    range.[Select]()
                End If
            End If

            'cancel internal handling of the 'Tab' pressing
            e.Handled = True
        End If
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Design
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Source
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
        'show publication data
        Dim sb As New StringBuilder()
        sb.Append("Publication data:" & vbLf & vbLf)
        For Each id As String In _fieldIDs
            'find node with data
            Dim node As XmlNode = c1Editor1.Document.GetElementById(id)
            If node IsNot Nothing Then
                'also find description for this node, it is previous text node
                Dim previousNode As XmlNode = node.PreviousSibling
                While previousNode IsNot Nothing AndAlso previousNode.NodeType <> XmlNodeType.Text
                    previousNode = previousNode.PreviousSibling
                End While
                If previousNode IsNot Nothing Then
                    sb.Append(previousNode.Value + node.InnerText & vbLf)
                Else
                    sb.Append(node.InnerText & vbLf)
                End If
            End If
        Next
        MessageBox.Show(sb.ToString())
    End Sub

End Class
