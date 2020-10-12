Imports System.IO
Imports System.Xml
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Editor

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		' initialize application
		InitializeComponent()
		Text = ProductName
		AddHandler Application.Idle, AddressOf Application_Idle

		' load a simple document
        Me.c1Editor1.LoadXml(Resources.tesla, Nothing)
    End Sub

    Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
        mainToolStrip.UpdateState()
        styleToolStrip.UpdateState()
    End Sub

    ' change editor mode
    Private Sub _lblDesign_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' set editor mode
        If sender Is _lblDesign Then
            Me.c1Editor1.Mode = EditorMode.Design
        End If
        If sender Is _lblSource Then
            Me.c1Editor1.Mode = EditorMode.Source
        End If
        If sender Is _lblPreview Then
            Me.c1Editor1.Mode = EditorMode.Preview
        End If

        ' highlight the selected option
        For Each lbl As ToolStripLabel In New ToolStripLabel() {_lblDesign, _lblSource, _lblPreview}
            If Object.Equals(sender, lbl) Then
                lbl.BackColor = Color.Orange
            Else
                lbl.BackColor = Color.Transparent
            End If
        Next

        toolStrip1.Enabled = (Me.c1Editor1.Mode = EditorMode.Design)
    End Sub

    ' utilities
    Private Function SelectNodes(ByVal doc As XmlDocument, ByVal xpath As String) As XmlNodeList
        If doc.DocumentElement.Attributes("xmlns") IsNot Nothing Then
            ' add namespace manager
            Dim xmlns As String = doc.DocumentElement.Attributes("xmlns").Value
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("x", xmlns)
            xpath = xpath.Replace("/", "/x:")
            Return doc.SelectNodes(xpath, nsmgr)
        Else
            Return doc.SelectNodes(xpath)
        End If
    End Function
    Private Sub ReplaceNodeText(ByVal node As XmlNode, ByVal search As String, ByVal replace As String)
        For Each child As XmlNode In node.ChildNodes
            ReplaceNodeText(child, search, replace)
        Next
        If node.NodeType = XmlNodeType.Text Then
            node.InnerText = node.InnerText.Replace(search, replace)
        End If
    End Sub
    Private Function IndexOf(ByVal text As String, ByVal chr As Char, ByVal count As Integer) As Integer
        For index As Integer = 0 To text.Length - 1
            If text(index) = chr Then
                count -= 1
                If count <= 0 Then
                    Return index
                End If
            End If
        Next
        Return text.Length
    End Function


    '--------------------------------------------------------------------------------
#Region "** how-to's"

    ' select a paragraph
    Private Sub selectParagraph_Click(ByVal sender As Object, ByVal e As EventArgs)

        MessageBox.Show("Selecting 6th paragraph using Select method.")

        're-Load document
        c1Editor1.LoadXml(Resources.tesla, Nothing)
        ' get text (notice new line handling)
        Dim txt As String = Me.c1Editor1.Text
        txt = txt.Replace(vbCr & vbLf, vbLf)

        ' find 6th paragraph
        Dim start As Integer = IndexOf(txt, ControlChars.Lf, 6) + 1
        Dim len As Integer = IndexOf(txt, ControlChars.Lf, 7) - start

        ' select the paragraph
        c1Editor1.Select(start, len)
    End Sub

    ' perform search and replace using Selection properties
    Private Sub replaceUsingSelection_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' re-load document
        Me.c1Editor1.LoadXml(Resources.tesla, Nothing)

        ' strings to search and replace
        Dim search As String = "work"
        Dim replace As String = "labor"

        ' do the work
        Dim count As Integer = 0
        Dim start As Integer = 0
        Dim previousStart As Integer = 0
        Dim range As C1TextRange = Me.c1Editor1.CreateRange()

        While True
            ' get text (notice new line handling)
            Dim txt As String = Me.c1Editor1.Text
            txt = txt.Replace(vbCr & vbLf, vbLf)

            ' find text, break when done
            start = txt.IndexOf(search, start, StringComparison.OrdinalIgnoreCase)
            If start < 0 Then
                Exit While
            End If

            ' select match
            ' recommended way (better performance): move range relative to its current position
            range.Move(start - previousStart, search.Length)
            range.Select()

            ' not recommended way (slower): using the Select method
            'Me.c1Editor1.Select(start, search.Length)

            ' tell user we're about to replace
            Dim msg As String = String.Format("About to replace instance {0}.", System.Threading.Interlocked.Increment(count))
            If MessageBox.Show(msg, "Replace", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                Exit While
            End If

            ' second part of the code moving range
            range.Text = replace
            range.ApplyTag("strong")
            previousStart = start

            ' second part of the code using the Select method
            'Me.c1Editor1.Selection.Text = replace
            'Me.c1Editor1.Selection.ApplyTag("strong")
            start += search.Length
        End While

        ' done
        MessageBox.Show(String.Format("Done, {0} instances found.", count))
    End Sub

    ' select an XmlNode in the document
    Private Sub selectXmlNode_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' re-load document
        c1Editor1.LoadXml(Resources.tesla, Nothing)

        ' find 6th <p> node in document
        Dim doc As XmlDocument = c1Editor1.Document
        Dim nodes As XmlNodeList = SelectNodes(doc, "/html/body/p")
        If nodes.Count > 5 Then
            Dim node As XmlNode = nodes(5)

            MessageBox.Show("Selecting 6th paragraph.")
            Dim range As C1TextRange = c1Editor1.CreateRange()
            range.MoveTo(node)
            range.[Select]()
        End If
    End Sub

    ' perform search and replace using XmlDocument
    Private Sub replaceUsingXmlDocument(ByVal sender As Object, ByVal e As EventArgs)
        Dim doc As XmlDocument = Me.c1Editor1.Document
        Dim nodes As XmlNodeList = SelectNodes(doc, "/html/body")
        If nodes.Count > 0 Then
            ReplaceNodeText(nodes(0), "work", "labor")
        End If
        MessageBox.Show("Finished XmlDocument search/replace.")
    End Sub

#End Region
End Class
