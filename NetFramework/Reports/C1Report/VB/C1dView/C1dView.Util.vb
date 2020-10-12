Option Explicit On
Option Strict On

Imports System
Imports System.ComponentModel
Imports C1.C1Preview
Imports C1.C1Report
Imports C1.Win.C1Preview
Imports C1.Win.C1Ribbon
Imports C1.Win.C1Command

Public Class Pair(Of T1, T2)
    Public Property First As T1
    Public Property Second As T2
    Public Sub New()
        ''First = default(T1);
        ''Second = default(T2);
    End Sub
    Public Sub New(ByVal first As T1, ByVal second As T2)
        Me.First = first
        Me.Second = second
    End Sub
End Class


''' <summary>
''' Utility class implementing find text functionality.
''' This class maintains a current state so that operations such as "find next"
''' can be supported.
''' </summary>
Public Class FindHelper

    Private _findArgs As C1TextSearchArgs = Nothing
    Private _finds As C1TextFragment() = Nothing
    Private _findCurrent As Integer = -1

    ''' <summary>
    ''' Gets the preview pane associated with this find helper.
    ''' </summary>
    Public Property PreviewPane As C1PreviewPane ''qq readonly 

    ''' <summary>
    ''' Gets a value indicating whether an occurrence of the current search text
    ''' can be found below the current occurrence.
    ''' </summary>
    Public ReadOnly Property HasNext As Boolean
        Get
            Return _finds IsNot Nothing AndAlso (_findCurrent + 1) < _finds.Length
        End Get
    End Property

    ''' <summary>
    ''' Gets a value indicating whether an occurrence of the current search text
    ''' can be found above the current occurrence.
    ''' </summary>
    Public ReadOnly Property HasPrev As Boolean
        Get
            Return _finds IsNot Nothing AndAlso _findCurrent > 0
        End Get
    End Property

    ''' <summary>
    ''' Initializes a new instance of the find helper.
    ''' </summary>
    ''' <param name="previewPane">The preview pane associated with this instance.</param>
    Public Sub New(ByVal previewPane As C1PreviewPane)
        Me.PreviewPane = previewPane
    End Sub

    ''' <summary>
    ''' Searches for all occurrences of a text in the preview pane.
    ''' Highlights the first occurrence and ensures that it is shown in the preview.
    ''' </summary>
    ''' <param name="text">The search text.</param>
    ''' <param name="matchCase">Indicates whether to perform a case-sensitive search.</param>
    ''' <returns>True if at least one occurrence was found, false otherwise.</returns>
    Public Function Find(ByVal text As String, ByVal matchCase As Boolean) As Boolean
        If (String.IsNullOrEmpty(text)) Then
            Return False
        End If
        _findArgs = New C1TextSearchArgs()
        _findArgs.Text = text
        _findArgs.IgnoreCase = Not matchCase
        _finds = PreviewPane.TextSearchAll(_findArgs)
        _findCurrent = If(_finds IsNot Nothing AndAlso _finds.Length > 0, 0, -1)
        If (_findCurrent <> -1) Then
            PreviewPane.SelectTextFragment(_finds(_findCurrent))
            PreviewPane.GoToSelection()
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Searches for the next occurrence of a text in the preview pane.
    ''' Highlights the found occurrence and ensures that it is shown in the preview.
    ''' If there are no more occurrences of the search text in the specified direction,
    ''' wraps to the beginning or end of the document.
    ''' </summary>
    ''' <param name="text">The search text.</param>
    ''' <param name="matchCase">Indicates whether to perform a case-sensitive search.</param>
    ''' <param name="up">Indicates whether to search up or down in the document.</param>
    ''' <returns>True if the next occurrence was found, false otherwise.</returns>
    Public Function FindNext(ByVal text As String, ByVal matchCase As Boolean, ByVal up As Boolean) As Boolean
        If (_finds Is Nothing OrElse _finds.Length = 0) Then
            Return Find(text, matchCase)
        Else
            If (Not up) Then
                _findCurrent += 1
                If (_findCurrent >= _finds.Length) Then
                    _findCurrent = 0
                End If
            Else
                _findCurrent -= 1
                If (_findCurrent < 0) Then
                    _findCurrent = _finds.Length - 1
                End If
            End If
            If (_findCurrent >= 0 AndAlso _findCurrent < _finds.Length) Then
                PreviewPane.SelectTextFragment(_finds(_findCurrent))
                PreviewPane.GoToSelection()
                Return True
            Else
                Return False
            End If
        End If
    End Function
End Class

