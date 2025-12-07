Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.SpellChecker

Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.C1SpellChecker1.CustomParser = New MyCSharpSpellParser()
    End Sub

    Private Sub RichTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyDown
        If e.KeyCode = Keys.F7 Then
            Me.C1SpellChecker1.CheckControl(Me.RichTextBox1)
        End If
    End Sub

    ' Class that parses c# files and retrieves words in comments for spell-checking.
    Public Class MyCSharpSpellParser
        Implements C1.Win.SpellChecker.ISpellParser

        ' '' fields
        Dim _text As String
        Dim _commentRanges As CharRangeList = New CharRangeList()

        ' '' ctor
        Public Sub New()
        End Sub

        ' '' ISpellParser
        Public Function FilterWord(ByVal word As String) As String Implements C1.Win.SpellChecker.ISpellParser.FilterWord
            Return word
        End Function

        Public Function GetNextWord(ByVal text As String, ByVal start As Integer, ByVal ignore As IgnoreOptions, ByVal previousWord As String) As C1.Win.SpellChecker.CharRange Implements C1.Win.SpellChecker.ISpellParser.GetNextWord
            ' refresh list of comment ranges to check
            If text <> _text Then
                _text = text
                BuildCommentRangeList()
            End If

            ' use CharRange implementation by default
            Dim range As CharRange = CharRange.GetNextWord(text, start, ignore, previousWord)
            If range Is Nothing Then
                Return Nothing
            End If

            ' check that the returned range is in the comment list
            Dim r As CharRange
            For Each r In _commentRanges
                ' range is in the list, use it
                If r.Start <= range.Start And r.End >= range.End Then
                    Return range
                End If

                ' range is not in the list, continue with next comment
                If r.Start > range.End Then
                    Return GetNextWord(text, r.Start, ignore, previousWord)
                End If
            Next

            ' done...
            Return Nothing
        End Function

        ''' private
        Private Sub BuildCommentRangeList()
            ' clear old list
            _commentRanges.Clear()

            ' scan the string and save comments
            Dim index As Integer
            For index = 0 To _text.Length - 1 Step index + 1
                If _text(index) = "/"c And index < _text.Length - 1 Then
                    If _text(index + 1) = "*"c Then
                        ' comments /* xxxx */
                        Dim _end As Integer = _text.IndexOf("*/", index + 2)
                        If _end > -1 Then
                            Dim range As CharRange = New CharRange(_text.Substring(index, _end - index + 1), index, False)
                            _commentRanges.Add(range)
                            index = _end + 1
                        End If
                    ElseIf _text(index + 1) = "/"c Then
                        ' comments // xxxx \n
                        Dim _end As Integer = _text.IndexOf(Chr(10), index + 2)
                        If _end > -1 Then
                            Dim range As CharRange = New CharRange(_text.Substring(index, _end - index + 1), index, False)
                            _commentRanges.Add(range)
                            index = _end + 1
                        End If
                    End If
                End If

                ' skip over strings in case they contain comment chars: "xxx // foo /* yyy */"
                If _text(index) = """" And IsRealQuote(index) Then
                    Dim _end As Integer = FindNextQuote(index)
                    If _end > -1 Then
                        index = _end
                    End If
                End If
            Next
        End Sub

        Private Function IsRealQuote(ByVal index As Integer) As Boolean
            If index > -1 AndAlso _text(index) = """"c Then
                Return IIf(index > 0 AndAlso (_text(index - 1) = "\"c OrElse _text(index - 1) = "'"c), False, True)
            End If
            Return False
        End Function

        Private Function FindNextQuote(ByVal index As Integer) As Integer
            Dim pos As Integer = _text.IndexOf("""", index + 1)
            While pos > -1 And Not IsRealQuote(pos)
                pos = _text.IndexOf("""", pos + 1)
            End While
            Return pos
        End Function

    End Class

End Class
