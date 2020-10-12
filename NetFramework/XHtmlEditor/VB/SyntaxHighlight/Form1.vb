Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Xml
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports C1.Win.C1Editor

Public Partial Class Form1
	Inherits Form
	' keep track of time to update syntax coloring efficiently
	Private _lastChange As DateTime
	Const MINIMUM_UPDATE_DELAY As Integer = 500

	Public Sub New()
		' designer support
		InitializeComponent()

		' load document
        c1Editor1.LoadXml(Resources.Syntax, Nothing)

        ' update syntax when document changes
        AddHandler c1Editor1.DocumentChanged, AddressOf c1Editor1_DocumentChanged
        AddHandler Application.Idle, AddressOf Application_Idle
    End Sub

    '-------------------------------------------------------------------------------------
#Region "** event handlers"

    ' keep track of the time when the document was modified
    Private Sub c1Editor1_DocumentChanged(ByVal sender As Object, ByVal e As EventArgs)
        _lastChange = DateTime.Now
    End Sub

    ' if the document was modified and some time has elapsed, update syntax
    Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
        Dim t As Double = DateTime.Now.Subtract(_lastChange).TotalMilliseconds
        If t > MINIMUM_UPDATE_DELAY Then
            c1Editor1.BeginTransaction("Highlight document")
            Try
                UpdateSyntax()
                c1Editor1.CommitTransaction()
            Catch
                c1Editor1.RollbackTransaction()
            End Try

            ' wait for the next change
            _lastChange = DateTime.MaxValue
        End If
    End Sub

#End Region

    '-------------------------------------------------------------------------------------
#Region "** implementation"

    Private Sub UpdateSyntax()
        ' get text
        Dim text As String = c1Editor1.Text

        ' remove formatting
        Dim rng As C1TextRange = c1Editor1.CreateRange(0, text.Length)
        rng.RemoveTag("span")

        ' apply all syntax descriptors
        For Each sd As SyntaxDescriptor In GetSyntaxDescriptors()
            ' initialize
            Dim start As Integer = 0
            rng.Start.Move(MoveUnit.Character, -50000000)
            rng.[End].MoveTo(rng.Start)

            ' if there's a group called 'match', use it;
            ' otherwise, use the first one
            Dim gIndex As Integer = sd.Regex.GroupNumberFromName("match")
            If gIndex < 0 Then
                gIndex = 0
            End If

            ' find all matches for this descriptor
            Dim match As Match = sd.Regex.Match(text)
            While match.Success
                ' apply descriptor style for this match
                Dim g As Group = match.Groups(gIndex)
                For Each c As Capture In g.Captures
                    rng.Move(c.Index - start, c.Length)

                    ' avoid nested spans (e.g. reserved words in comments, etc)
                    If rng.Node.ParentNode.Name <> "span" Then
                        rng.ApplyClass(sd.ClassName, C1StyleType.Character)
                    End If

                    start = c.Index
                Next
                match = match.NextMatch()
            End While
        Next
    End Sub

    Private _sd As List(Of SyntaxDescriptor)
    Private Function GetSyntaxDescriptors() As List(Of SyntaxDescriptor)
        If _sd Is Nothing Then
            _sd = New List(Of SyntaxDescriptor)()

            ' comments
            _sd.Add(New SyntaxDescriptor("(?m)//.*$", "comment"))
            _sd.Add(New SyntaxDescriptor("/\*[\s\S]*\*/", "comment"))

            ' strings and chars
            _sd.Add(New SyntaxDescriptor("@?""[^""\n]*""", "string"))
            _sd.Add(New SyntaxDescriptor("@?'\\?[^']'", "string"))

            ' reserved words
            Dim resWords As String = Resources.reservedWords.Replace(vbCr & vbLf, "|")
            resWords = String.Format("(^|\W)(?<match>{0})(?=$|\W)", resWords)
            _sd.Add(New SyntaxDescriptor(resWords, "resWord"))
        End If
        Return _sd
    End Function

#End Region
End Class

''' <summary>
''' Class used to associate syntax elements to display styles.
''' </summary>
Public Class SyntaxDescriptor
	'------------------------------------------------------------------------
	#Region "** fields"

	Public ReadOnly Regex As Regex
	Public ReadOnly ClassName As String

	#End Region

	'------------------------------------------------------------------------
	#Region "** ctors"

	Public Sub New(pattern As String, className__1 As String)
		Regex = New Regex(pattern, RegexOptions.Compiled Or RegexOptions.Multiline)
		ClassName = className__1
	End Sub

	#End Region
End Class
