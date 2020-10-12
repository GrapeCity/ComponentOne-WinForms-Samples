Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Text
Imports C1.Win.C1Editor

Namespace ToolStrips
    MustInherit Class ToolStripBase
        Inherits System.Windows.Forms.ToolStrip
        ' editor connected to this toolstrip
        Private _editor As C1Editor

        ' ctor
        Public Sub New()
            MyBase.New()
            OnInitialize()
        End Sub

        ' notify of changes to the editor content
        Public Property Editor() As C1.Win.C1Editor.C1Editor
            Get
                Return _editor
            End Get
            Set(ByVal value As C1.Win.C1Editor.C1Editor)
                If Editor IsNot Nothing Then
                    RemoveHandler Editor.SelectionChanged, AddressOf Editor_SelectionChanged
                    RemoveHandler Editor.DocumentChanged, AddressOf Editor_DocumentChanged
                    RemoveHandler Editor.ModeChanged, AddressOf Editor_ModeChanged
                    RemoveHandler Editor.KeyDown, AddressOf Editor_KeyDown
                End If

                _editor = value

                If Editor IsNot Nothing Then
                    AddHandler Editor.SelectionChanged, AddressOf Editor_SelectionChanged
                    AddHandler Editor.DocumentChanged, AddressOf Editor_DocumentChanged
                    AddHandler Editor.ModeChanged, AddressOf Editor_ModeChanged
                    AddHandler Editor.KeyDown, AddressOf Editor_KeyDown
                End If
            End Set
        End Property
        Private Sub Editor_DocumentChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnDocumentChanged(e)
        End Sub
        Private Sub Editor_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnSelectionChanged(e)
        End Sub
        Private Sub Editor_ModeChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnModeChanged(e)
        End Sub
        Private Sub Editor_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            OnEditorKeyDownHandler(e)
        End Sub
        Protected Overridable Sub OnDocumentChanged(ByVal e As EventArgs)
        End Sub
        Protected Overridable Sub OnSelectionChanged(ByVal e As EventArgs)
        End Sub
        Protected Overridable Sub OnModeChanged(ByVal e As EventArgs)
        End Sub
        Protected Overridable Sub OnEditorKeyDownHandler(ByVal e As KeyEventArgs)
        End Sub

        ' initialize toolstrip
        Protected Overridable Sub OnInitialize()
        End Sub

        ' enable/disable toolbar buttons
        Public Overridable Sub UpdateState()
        End Sub

        ' helper for populating the toolstrip
        Protected Function AddButton(ByVal text As String, ByVal image As Image, ByVal handler As EventHandler) As ToolStripButton
            Dim btn As ToolStripButton = New ToolStripButton(text, image)
            btn.DisplayStyle = ToolStripItemDisplayStyle.Image
            AddHandler btn.Click, handler
            Items.Add(btn)
            Return btn
        End Function
    End Class
End Namespace
