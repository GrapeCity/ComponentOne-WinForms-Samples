Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace RichTextEditor
	Public Partial Class WordCount
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub New(text As String)
			InitializeComponent()

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
				If c = "."C OrElse c = "!"C OrElse c = "?"C OrElse i = length - 1 Then
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
			_lblWords.Text = words.ToString("n0")
			_lblChars.Text = chars.ToString("n0")
			_lblCharsNoSpace.Text = nonSpaceChars.ToString("n0")
			_lblParagraphs.Text = paragraphs.ToString("n0")
			_lblSentences.Text = sentences.ToString("n0")
            _lblWordLength.Text = String.Format("{0:n1}", Util.IIFF(words > 0, nonSpaceChars / CSng(words), 0.0F))
            _lblSentenceLength.Text = String.Format("{0:n1}", Util.IIFF(sentences > 0, nonSpaceChars / CSng(sentences), 0.0F))
            _lblParagraphLength.Text = String.Format("{0:n1}", Util.IIFF(paragraphs > 0, nonSpaceChars / CSng(paragraphs), 0.0F))
		End Sub
	End Class
End Namespace
