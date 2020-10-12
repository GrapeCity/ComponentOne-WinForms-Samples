Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace MultipleForms
    Partial Public Class DHBaseForm
        Inherits Form
        Private _mainForm As Form1

        Public Property MainForm() As Form1
            Get
                Return _mainForm
            End Get
            Set(ByVal value As Form1)
                _mainForm = value
                RemoveHandler c1DynamicHelp1.TopicMap.TopicMapChanged, AddressOf TopicMap_TopicMapChanged
                RemoveHandler c1DynamicHelp1.TopicMap.TopicMapSaved, AddressOf TopicMap_TopicMapSaved
                ' set MainControl property to allow c1DynamicHelp1 on this form to use properties of the c1DynamicHelp1 on the _mainForm
                c1DynamicHelp1.MainControl = _mainForm.c1DynamicHelp1
                AddHandler c1DynamicHelp1.TopicMap.TopicMapChanged, AddressOf TopicMap_TopicMapChanged
                AddHandler c1DynamicHelp1.TopicMap.TopicMapSaved, AddressOf TopicMap_TopicMapSaved
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
            ' handle the following events to notify the user about changes in topic map
            AddHandler c1DynamicHelp1.TopicMap.TopicMapChanged, AddressOf TopicMap_TopicMapChanged
            AddHandler c1DynamicHelp1.TopicMap.TopicMapSaved, AddressOf TopicMap_TopicMapSaved
        End Sub

        Private Sub TopicMap_TopicMapSaved(ByVal sender As Object, ByVal e As EventArgs)
            ' don't display * when topic map is saved and has ho changes
            Me.Text = Me.Name
        End Sub

        Private Sub TopicMap_TopicMapChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' display * when topic map has changes
            Me.Text = Me.Name & " *"
        End Sub

        ' toggle authoring mode when the user hits ctrl+shift+a
        Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.A AndAlso e.Control AndAlso e.Shift Then
                c1DynamicHelp1.AuthoringMode = Not c1DynamicHelp1.AuthoringMode
            End If
            MyBase.OnKeyDown(e)
        End Sub

        Private Sub DHBaseForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' need to refresh the topic map, because Form has just been created, and C1DynamicHelp control was already initialized prior to that
            c1DynamicHelp1.TopicMap.Refresh()
        End Sub
    End Class
End Namespace