Imports System.IO
Imports System.Linq

''' <summary>
''' Class that handles the recently used document list.
''' Manages the list that appears in the application's main menu, including persistence to the settings file.
''' </summary>
Public Class RecentDocumentList
    Const MAX_ITEMS As Integer = 10

    Public Sub New(ByVal docs As List(Of RecentDocumentItem))
        RecentDocuments = docs
    End Sub

    Public Sub AddDocument(ByVal fileName As String)
        Dim doc As RecentDocumentItem = RecentDocuments.FirstOrDefault(Function(x) x.FileName = fileName)

        If doc IsNot Nothing Then
            doc.LDate = DateTime.Now
        ElseIf Not String.IsNullOrEmpty(fileName) Then
            doc = New RecentDocumentItem With {
                .Text = Path.GetFileName(fileName),
                .SubText = Path.GetDirectoryName(fileName),
                .LDate = DateTime.Now
            }
            RecentDocuments.Add(doc)
        End If

        While RecentDocuments.Count > MAX_ITEMS
            Dim notPinned = RecentDocuments.Where(Function(x) Not x.Pinned).OrderBy(Function(x) x.LDate)

            If notPinned.Count() > 0 Then
                RecentDocuments.Remove(notPinned.Last())
            Else
                RecentDocuments.Remove(RecentDocuments.OrderBy(Function(x) x.LDate).Last())
            End If
        End While
    End Sub

    Public Property RecentDocuments As List(Of RecentDocumentItem)

    Public Sub RemoveDocument(ByVal fileName As String)
        Dim doc = RecentDocuments.FirstOrDefault(Function(x) x.FileName = fileName)
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
    Public Property LDate As DateTime
    Public Property Pinned As Boolean

    Public ReadOnly Property FileName As String
        Get
            Return Path.Combine(SubText, Text)
        End Get
    End Property
End Class
