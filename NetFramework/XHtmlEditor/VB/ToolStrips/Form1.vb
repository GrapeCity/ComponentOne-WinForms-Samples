Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Editor.ToolStrips

Partial Public Class Form1
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub toolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
        ShowDocumentInformation()
    End Sub

    Private Sub ShowDocumentInformation()
        Dim text As String = c1C1Editor1.Text
        Dim chars As Integer = 0
        Dim nonSpaceChars As Integer = 0
        Dim words As Integer = 0
        Dim paragraphs As Integer = 0
        Dim sentences As Integer = 0

        Dim length As Integer = text.Length

        ' calculate statistics
        For i As Integer = 0 To length - 1
            Dim c As Char = text(i)

            ' count chars
            chars += 1

            ' count non-space chars
            If Not Char.IsWhiteSpace(c) Then
                nonSpaceChars += 1
            End If

            ' count paragraphs
            If c = ControlChars.Lf OrElse i = length - 1 Then
                If i = length - 1 OrElse text(i + 1) <> ControlChars.Lf Then
                    paragraphs += 1
                End If
            End If

            ' count sentences
            If c = "."c OrElse c = "!"c OrElse c = "?"c OrElse i = length - 1 Then
                If i = length - 1 OrElse Char.IsWhiteSpace(text, i + 1) Then
                    sentences += 1
                End If
            End If

            ' count words
            If Char.IsLetterOrDigit(c) Then
                If i = length - 1 OrElse Not Char.IsLetterOrDigit(text, i + 1) Then
                    words += 1
                End If
            End If
        Next

        ' show statistics
        Dim nonSpaceChars_words As Single = 0.0F
        Dim nonSpaceChars_paragraphs As Single = 0.0F
        Dim nonSpaceChars_sentences As Single = 0.0F
        If words > 0 Then
            nonSpaceChars_words = nonSpaceChars / CSng(words)
        End If

        If sentences > 0 Then
            nonSpaceChars_sentences = nonSpaceChars / CSng(sentences)
        End If

        If paragraphs > 0 Then
            nonSpaceChars_paragraphs = nonSpaceChars / CSng(paragraphs)
        End If

        Dim msg As String = String.Format("Words: {0:n0}" & vbCr & vbLf & "Characters: {1:n0}" & vbCr & vbLf & "Non-Space Characters: {2:n0}" & vbCr & vbLf & "Sentences: {3:n0}" & vbCr & vbLf & "Paragraphs: {4:n0}" & vbCr & vbLf & "Average Word Length: {5:n1}" & vbCr & vbLf & "Average Sentence Length: {6:n1}" & vbCr & vbLf & "Average Paragraph Length: {7:n1}" & vbCr & vbLf, words, chars, nonSpaceChars, sentences, paragraphs, _
         nonSpaceChars_words, nonSpaceChars_sentences, nonSpaceChars_paragraphs)
        MessageBox.Show(msg, "Word Count")
    End Sub


    Private Sub UpdateToolStripLayout(ByVal toolStrip As System.Windows.Forms.ToolStrip, ByVal visible As Boolean)
        Dim panel As ToolStripPanel = DirectCast(toolStrip.Parent, ToolStripPanel)
        If Not visible AndAlso panel IsNot Nothing Then
            ' Hide
            toolStrip.Parent.Controls.Remove(toolStrip)
        Else
            If visible AndAlso panel Is Nothing Then
                panel = toolStripContainer1.TopToolStripPanel
                ' Show
                Dim done As Boolean = False
                Dim width As Integer = toolStrip.Width
                For i As Integer = 0 To toolStripContainer1.TopToolStripPanel.Rows.Length - 1
                    Dim row As ToolStripPanelRow = toolStripContainer1.TopToolStripPanel.Rows(i)
                    Dim leftPos As Integer = 0
                    For Each c As Control In row.Controls
                        leftPos = Math.Max(leftPos, c.Right + 1)
                    Next
                    If row.Bounds.Width >= leftPos + width Then
                        panel.Join(toolStrip, leftPos, row.Bounds.Top)
                        System.Diagnostics.Debug.WriteLine(toolStrip.Name & " Join " & leftPos.ToString() & "," & row.Bounds.Top.ToString())
                        done = True
                    End If
                Next
                If Not done Then
                    panel.Join(toolStrip, panel.Rows.Length)
                    toolStrip.Left = 0
                End If
            End If
        End If
    End Sub

    Private Sub UpdateUI()
        UpdateToolStripLayout(c1EditorToolStripMain1, checkBox1.Checked)
        UpdateToolStripLayout(c1EditorToolStripStyle1, checkBox1.Checked)
        UpdateToolStripLayout(c1EditorToolStripObjects1, checkBox1.Checked)
        UpdateToolStripLayout(c1EditorToolStripTable1, checkBox1.Checked)
        UpdateToolStripLayout(toolStrip2, checkBox2.Checked)
        UpdateToolStripLayout(_myToolStrip, checkBox3.Checked)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        _myToolStrip.Editor = c1C1Editor1
        toolStripContainer1.TopToolStripPanel.Controls.Clear()
        UpdateUI()
        c1C1Editor1.LoadXml("tesla.htm")
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        UpdateUI()
    End Sub

    Private _myToolStrip As New MyToolStrip()

    ''' <summary>
    ''' Custom toolstrip
    ''' </summary>
    Private Class MyToolStrip
        Inherits C1.Win.C1Editor.ToolStrips.C1EditorToolStripBase
        Protected Overloads Overrides Sub OnInitialize()
            MyBase.OnInitialize()
            AddButton(CommandButton.[New])
            AddButton(CommandButton.Open)
            AddButton(CommandButton.Save)
            Items.Add(New ToolStripSeparator())
            AddComboBox(CommandComboBox.Style)
            AddButton(CommandButton.Left)
            AddButton(CommandButton.Center)
            AddButton(CommandButton.Right)
            AddButton(CommandButton.Justify)
            Items.Add(New ToolStripSeparator())
            AddButton(CommandButton.Undo)
            AddButton(CommandButton.Redo)
            Items.Add(New ToolStripSeparator())
            AddSplitButton(CommandSplitButton.Border)
        End Sub
    End Class

End Class
