Imports System.IO
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Text
Imports C1.Win.C1Ribbon
Imports System.Linq

Namespace RichTextEditor
    ''' <summary>
    ''' Class that handles the recently used document list.
    ''' Manages the list that appears in the application's main menu,
    ''' including persistence to the settings file.
    ''' </summary>
    Public Class RecentDocumentList

        Const MAX_ITEMS As Integer = 10
        ' Initializes a new instance of a RecentDocumentList.
        Public Sub New(ByVal docs As List(Of RecentDocumentItem))
            RecentDocuments = docs
        End Sub
        ' add a document to the MRU list
        Public Sub AddDocument(ByVal fileName As String)
            Dim doc As RecentDocumentItem = RecentDocuments.FirstOrDefault(Function(x) x.FileName = fileName)
            If doc IsNot Nothing Then
                doc.ItemDate = DateTime.Now
            ElseIf Not String.IsNullOrEmpty(fileName) Then
                doc = New RecentDocumentItem()
                doc.Text = Path.GetFileName(fileName)
                doc.SubText = Path.GetDirectoryName(fileName)
                doc.ItemDate = DateTime.Now
                RecentDocuments.Add(doc)
            End If

            While RecentDocuments.Count > MAX_ITEMS
                Dim notPinned As IEnumerable(Of RecentDocumentItem) = RecentDocuments.Where(Function(x) Not x.Pinned).OrderBy(Function(x) x.ItemDate)
                If notPinned.Count() > 0 Then
                    RecentDocuments.Remove(notPinned.Last())
                Else
                    RecentDocuments.Remove(RecentDocuments.OrderBy(Function(x) x.ItemDate).Last())
                End If
            End While
        End Sub
        ' get or set the list of recent documents.
        Public Property RecentDocuments As List(Of RecentDocumentItem)

        Public Sub RemoveDocument(ByVal fileName As String)
            Dim doc As RecentDocumentItem = RecentDocuments.FirstOrDefault(Function(x) x.FileName = fileName)
            If doc IsNot Nothing Then RecentDocuments.Remove(doc)
        End Sub
    End Class

    ''' <summary>
    ''' Represents each item in the most recently used documents list.
    ''' </summary>
    <Serializable>
    Public Class RecentDocumentItem

        Public Property Text As String

        Public Property SubText As String

        Public Property ItemDate As DateTime

        Public Property Pinned As Boolean

        Public ReadOnly Property FileName As String
            Get
                Return Path.Combine(SubText, Text)
            End Get
        End Property
    End Class
End Namespace
