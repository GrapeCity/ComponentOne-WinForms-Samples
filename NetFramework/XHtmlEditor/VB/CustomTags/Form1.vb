Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Xml
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Partial Class Form1
	Inherits Form
	#Region "ctor"

	Public Sub New()
		InitializeComponent()
	End Sub

	#End Region

	#Region "event handlers"

	''' <summary>
	''' Switches mode between design, source and preview
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnMode_Click(sender As Object, e As EventArgs)
		Dim strMode As String = DirectCast(sender, Button).Text
		lblMode.Text = strMode
		If strMode.Equals("Design") Then
            editor.Mode = C1.Win.C1Editor.EditorMode.Design
        ElseIf strMode.Equals("Source") Then
            editor.Mode = C1.Win.C1Editor.EditorMode.Source
        Else
            editor.Mode = C1.Win.C1Editor.EditorMode.Preview
        End If
    End Sub

    ''' <summary>
    ''' Loads document, custom tag specification, design and preview CSS
    ''' </summary>
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        'Load xml extension from file
        editor.XmlExtensions = System.IO.File.ReadAllText("CustomTags.xml")
        'Load xml document from file
        editor.LoadXml("doc.xml")
        'Load design css from file
        editor.LoadDesignCSS("design.css")
        'Load preview css from file
        editor.LoadPreviewCSS("preview.css")
    End Sub

    ''' <summary>
    ''' Shows document statistics, accordingly with its structure
    ''' </summary>
    Private Sub btnStatistics_Click(ByVal sender As Object, ByVal e As EventArgs)
        editor.Selection.ApplyClass("className", C1.Win.C1Editor.C1StyleType.Paragraph)

        Dim document As XmlDocument = editor.Document
        Dim statistics As New StringBuilder()
        'Add statistic info from document to string builder
        AddStatistics(TryCast(document, XmlNode), statistics)
        'Show statistics in message box
        MessageBox.Show(statistics.ToString())
    End Sub

	''' <summary>
	''' Collects document statistics from custom tags
	''' </summary>
	''' <param name="node">Current node</param>
	''' <param name="statistics">collected statistics in StringBuilder</param>
	Private Sub AddStatistics(node As XmlNode, statistics As StringBuilder)
		Dim element As XmlElement = TryCast(node, XmlElement)
        Dim s As String
        If element IsNot Nothing Then
            If element.Name = "topic" Then
                If statistics.Length > 0 Then
                    statistics.Append(vbLf)
                End If
                If element.HasAttribute("name") Then
                    s = element.GetAttribute("name")
                Else
                    s = "(unknown)"
                End If
                statistics.Append("Topic: " & s & vbLf)
                If element.HasAttribute("author") Then
                    statistics.Append("    Author: " & element.GetAttribute("author") & vbLf)
                End If
                If element.HasAttribute("date") Then
                    statistics.Append("    Date: " & element.GetAttribute("date") & vbLf)
                End If
                If element.HasAttribute("category") Then
                    statistics.Append("    Category: " & element.GetAttribute("category") & vbLf)
                End If
            ElseIf element.Name = "comment" Then
                statistics.Append("    Comment: " & element.InnerText & vbLf)
            ElseIf element.Name = "header" Then
                statistics.Append("    Header: " & element.InnerText & vbLf)
            ElseIf element.Name = "pointer" Then
                If element.HasAttribute("to") Then
                    s = element.GetAttribute("to")
                Else
                    s = "(unknown)"
                End If
                statistics.Append("    Link to: " & s & vbLf)
            End If
        End If
		For Each childNode As XmlNode In node
			AddStatistics(childNode, statistics)
		Next
	End Sub

	#End Region
End Class
