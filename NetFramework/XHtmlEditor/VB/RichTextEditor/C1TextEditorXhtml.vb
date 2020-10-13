Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Text
Imports System.Xml
Imports C1.Win.C1Editor

Namespace RichTextEditor
	#Region "enums"

	''' <summary>
	''' Specifies how text in a text range is horizontally aligned.
	''' </summary>
	Friend Enum TextAlignment
		[Default] = 0
		Left = 1
		Right = 2
		Center = 3
		Justify = 4
	End Enum

	''' <summary>
	''' Specifies type of list numbering
	''' </summary>
	Friend Enum ListNumbering
		Arabic
		Bullets
		Lowercase
		RomanLowercase
		RomanUppercase
		Uppercase
		None
	End Enum

	''' <summary>
	''' Represents change case options
	''' </summary>
	Friend Enum CharCasing
		SentenceCase
		LowerCase
		UpperCase
		CapitalizeWords
		ToggleCase
	End Enum

	#End Region

	Public Class C1RibbonEditorXhtml
		'----------------------------------------------------------------------
		#Region "** fields"

        Private _editor As C1Editor
        Private _newDocumentCounter As Integer = 0
        Private _doc As XhtmlPrintDocument

#End Region

        '----------------------------------------------------------------------
#Region "** ctor"

        Public Sub New(ByVal editor As C1Editor)
            _editor = editor
            _editor.AcceptsTab = True
        End Sub

#End Region

#Region "common tasks"

        Friend ReadOnly Property Editor() As C1Editor
            Get
                Return _editor
            End Get
        End Property

        ' GetWebBrowser2
        Friend Function GetWebBrowser2() As Object
            Return _editor.GetActiveXInstance()
        End Function

        ''' <summary>
        ''' Sets or gets editor mode
        ''' </summary>
        Friend Property Mode() As EditorMode
            Get
                Return _editor.Mode
            End Get
            Set(ByVal value As EditorMode)
                _editor.Mode = value
            End Set
        End Property

#End Region

		#Region "file operations"

		''' <summary>
		''' Clears editor content
		''' </summary>
		Friend Sub Clear()
			Dim html As String = String.Format("<html><head><title>New Document {0}</title></head><body><p></p></body></html>", System.Threading.Interlocked.Increment(_newDocumentCounter))
			_editor.LoadXml(html, Nothing)
		End Sub

		''' <summary>
		''' Loads document from file
		''' </summary>
		''' <param name="fileName">File name</param>
		''' <returns>True if file is loaded</returns>
		Friend Function Load(fileName As String) As Boolean
			Try
                _editor.Mode = EditorMode.Design
                If System.IO.Path.GetExtension(fileName.ToLower()) = ".rtf" Then
                    _editor.LoadRtf(fileName)
                Else
                    _editor.LoadXml(fileName)
                End If
                Return True
            Catch x As Exception
                MessageBox.Show(x.Message, Application.ProductName)
                Return False
            End Try
		End Function

		''' <summary>
		''' Saves document to file
		''' </summary>
		''' <param name="fileName">File name to save</param>
		''' <returns>True if file is saved</returns>
		Friend Function Save(fileName As String) As Boolean
			Try
				'replace default document title with fileName
				Dim nsManager As New XmlNamespaceManager(_editor.Document.NameTable)
				nsManager.AddNamespace("xhtml", _editor.Document.DocumentElement.NamespaceURI)
				Dim title As XmlNode = _editor.Document.DocumentElement.SelectSingleNode("//xhtml:head/xhtml:title", nsManager)
				If title IsNot Nothing AndAlso Not String.IsNullOrEmpty(title.InnerText) AndAlso title.InnerText.StartsWith("New Document") Then
					title.InnerText = System.IO.Path.GetFileNameWithoutExtension(fileName)
				End If

                If System.IO.Path.GetExtension(fileName.ToLower()) = ".rtf" Then
                    _editor.SaveRtf(fileName)
                Else
                    _editor.SaveXml(fileName)
                End If
                Return True
            Catch x As Exception
                MessageBox.Show(x.Message, Application.ProductName)
                Return False
            End Try
		End Function

		#End Region

		#Region "Validate & Fix"

		''' <summary>
		''' Validates document in source mode and shows validation errors if found.
		''' </summary>
		''' <returns><b>True</b> if document validated; otherwise, False. </returns>
		Friend Function ValidateSource() As Boolean
			Return _editor.ValidateSource()
		End Function

		''' <summary>
		''' Fixes document in source mode.
		''' </summary>
		Friend Sub FixSource()
			_editor.FixSource()
		End Sub

		''' <summary>
		''' Customizes open/save file dialog
		''' </summary>
		''' <param name="dlg"></param>
		Friend Sub CustomizeFileDialog(dlg As FileDialog)
			dlg.DefaultExt = ".htm"
			dlg.AddExtension = True
            dlg.Filter = "XHTML File Format (*.html *.htm)|*.htm;*.html|" & "Rich Text Format (*.rtf)|*.rtf|" & "All Files (*.*)|*.*"
		End Sub

		#End Region

		#Region "printing support"

		''' <summary>
		''' Returns printing object
		''' </summary>
		Friend ReadOnly Property PrintDocument() As PrintDocument
			Get
				If _doc Is Nothing Then
					_doc = New XhtmlPrintDocument(_editor)
				End If
				Return _doc
			End Get
		End Property

		''' <summary>
		''' Prints current document.
		''' </summary>
		''' <param name="selectPrinter">If true, display select printer dialog.</param>
		Friend Sub Print(selectPrinter As Boolean)
			_editor.Print(selectPrinter)
		End Sub

		''' <summary>
		''' Shows print preview dialog.
		''' </summary>
		Friend Sub PrintPreview()
			_editor.PrintPreview()
		End Sub

		''' <summary>
		''' Shows page setup page
		''' </summary>
		Friend Sub PageSetup()
			_editor.ShowDialog(DialogType.PageSetup)
		End Sub

		#End Region

		#Region "text"

		'Sets or gets text of editor document
		Friend Property Text() As String
			Get
				Return _editor.Text
			End Get
			Set
				_editor.Text = value
			End Set
		End Property

		''' <summary>
		''' Inserts page break to current selection
		''' </summary>
		Friend Sub InsertPageBreak()
			Dim range As C1TextRange = _editor.Selection
			range.Start.MoveTo(range.[End])
			range.XmlText = "<br style=""page-break-before: always""/>"
		End Sub

		#End Region

		#Region "undo/redo"

		''' <summary>
		''' Returns a value that indicates whether the most recent action can be undone.
		''' </summary>
		Friend ReadOnly Property CanUndo() As Boolean
			Get
				Return _editor.CanUndo()
			End Get
		End Property

		''' <summary>
		''' Returns a value that indicates whether the most recent undo action can be redone.
		''' </summary>
		Friend ReadOnly Property CanRedo() As Boolean
			Get
				Return _editor.CanRedo()
			End Get
		End Property

		''' <summary>
		''' Performs Undo action in the current (design or source) editor mode.
		''' </summary>
		Friend Sub Undo()
			_editor.Undo()
		End Sub

		''' <summary>
		''' Performs Redo action in the current (design or source) editor mode.
		''' </summary>
		Friend Sub Redo()
			_editor.Redo()
		End Sub

		#End Region

		#Region "find/replace"

		''' <summary>
		''' Shows find/replace dialog in "find" mode
		''' </summary>
		Friend Sub Find()
			_editor.ShowDialog(DialogType.Find)
		End Sub

		''' <summary>
		''' Shows find/replace dialog in "replace" mode
		''' </summary>
		Friend Sub FindAndReplace()
			_editor.ShowDialog(DialogType.Replace)
		End Sub

		#End Region

		#Region "clipboard"

		''' <summary>
		''' Moves the current selection in the editor to the Clipboard.
		''' </summary>
		Friend Sub Cut()
			_editor.Cut()
		End Sub

		''' <summary>
		''' Copies the current selection in the editor to the Clipboard.
		''' </summary>
		Friend Sub Copy()
			_editor.Copy()
		End Sub

		''' <summary>
		''' Pastes the contents of the Clipboard into the editor
		''' </summary>
		''' <param name="plainText">If true, pastes text only</param>
		Friend Sub Paste(plainText As Boolean)
			If plainText Then
				' paste as plain text
				_editor.PasteAsText()
			Else
				' automatically select format
				_editor.Paste()
			End If
		End Sub

		''' <summary>
		''' Gets a value indicating whether the cut command is supported on the current selection.
		''' </summary>
		Friend ReadOnly Property CanCut() As Boolean
			Get
				Return _editor.CanCut
			End Get
		End Property

		''' <summary>
		''' Gets a value indicating whether the copy command is supported on the current selection.
		''' </summary>
		Friend ReadOnly Property CanCopy() As Boolean
			Get
				Return _editor.CanCopy
			End Get
		End Property

		''' <summary>
		''' Gets a value indicating whether the paste command is supported on the current selection.
		''' </summary>
		Friend ReadOnly Property CanPaste() As Boolean
			Get
				Return _editor.CanPaste
			End Get
		End Property

		''' <summary>
		''' Determines whether you can paste information from the Clipboard in the text format.
		''' </summary>
		Friend ReadOnly Property CanPasteAsText() As Boolean
			Get
				Return _editor.CanPasteAsText
			End Get
		End Property

		#End Region

		#Region "selection/formatting"

		''' <summary>
		''' Gets or sets index of the first selected character.
		''' </summary>
		Friend Property SelectionStart() As Integer
			Get
				Return _editor.SelectionStart
			End Get
			Set
				_editor.SelectionStart = value
			End Set
		End Property

		''' <summary>
		''' Gets or sets number of selected characters.
		''' </summary>
		Friend Property SelectionLength() As Integer
			Get
				Return _editor.SelectionLength
			End Get
			Set
				_editor.SelectionLength = value
			End Set
		End Property

		''' <summary>
		''' Selects text from start text position to specified length
		''' </summary>
		''' <param name="start">Initial text position</param>
		''' <param name="length">Length of selection</param>
		Friend Sub [Select](start As Integer, length As Integer)
			_editor.SelectionStart = start
			_editor.SelectionLength = length
		End Sub

		''' <summary>
		''' Gets or sets font name of selection
		''' </summary>
		Friend Property SelectionFontName() As String
			Get
                Return Util.IIFS(_editor.Mode = EditorMode.Design, _editor.Selection.GetStyleValue("font-family"), String.Empty)
			End Get
			Set
				If [String].IsNullOrEmpty(value) Then
					_editor.Selection.RemoveStyle("font-family", Nothing)
				Else
					_editor.Selection.ApplyStyle("font-family", value, C1StyleType.Character)
				End If
			End Set
		End Property

		''' <summary>
		''' Gets or sets font size of selection
		''' </summary>
		Friend Property SelectionFontSize() As String
			Get
				If _editor.Mode = EditorMode.Design Then
                    Dim Size As String = _editor.Selection.GetStyleValue("font-size")
                    If Size Is Nothing Then
                        Size = String.Empty
                    End If
                    If Size.EndsWith("pt") Then
                        Return Size.Substring(0, Size.Length - 2)
                    Else
                        Return Size
                    End If
                Else
                    Return String.Empty
                End If
            End Get
			Set
				If [String].IsNullOrEmpty(value) Then
					_editor.Selection.RemoveStyle("font-size", Nothing)
				Else
                    _editor.Selection.ApplyStyle("font-size", Value & (Util.IIFS(Value.EndsWith("pt"), "", "pt")), C1StyleType.Character)
				End If
			End Set
		End Property

		''' <summary>
		''' Gets true if tags "strong" or "b" applied to selection
		''' Sets "strong" tag to selection
		''' </summary>
		Friend Property SelectionFontBold() As Boolean
			Get
				Return Util.IIFB(Mode = EditorMode.Design, _editor.Selection.IsTagApplied("strong") Or _editor.Selection.IsTagApplied("b"), False)
			End Get
			Set
				If value Then
					_editor.Selection.ApplyTag("strong")
				Else
					_editor.BeginTransaction("Remove style")
					Try
						_editor.Selection.RemoveTag("strong")
						_editor.Selection.RemoveTag("b")
						_editor.CommitTransaction()
					Catch
						_editor.RollbackTransaction()
					End Try
				End If
			End Set
		End Property

		''' <summary>
		''' Gets true if tags "em" or "i" applied to selection
		''' Sets "em" tag to selection
		''' </summary>
		Friend Property SelectionFontItalic() As Boolean
			Get
				Return Util.IIFB(Mode = EditorMode.Design, _editor.Selection.IsTagApplied("em") Or _editor.Selection.IsTagApplied("i"), False)
			End Get
			Set
				If value Then
					_editor.Selection.ApplyTag("em")
				Else
					_editor.BeginTransaction("Remove style")
					Try
						_editor.Selection.RemoveTag("em")
						_editor.Selection.RemoveTag("i")
						_editor.CommitTransaction()
					Catch
						_editor.RollbackTransaction()
					End Try
				End If
			End Set
		End Property

		''' <summary>
		''' Gets true if style attribute "text-decoration:line-through" or tag "strike" applied to selection
		''' Sets style attribute "text-decoration:line-through" to selection
		''' </summary>
		Friend Property SelectionFontStrikethrough() As Boolean
			Get
				If _editor.Mode = EditorMode.Design Then
					Dim res As Boolean = _editor.Selection.IsTagApplied("strike")
					If Not res And _editor.Selection.IsStyleApplied("text-decoration") Then
						res = String.Compare(_editor.Selection.GetStyleValue("text-decoration", C1StyleType.Character), "line-through", True) = 0
					End If
					Return res
				Else
					Return False
				End If
			End Get
			Set
				If value Then
					_editor.Selection.ApplyStyle("text-decoration", "line-through", C1StyleType.Character)
				Else
					_editor.BeginTransaction("Remove style")
					Try
						_editor.Selection.RemoveStyle("text-decoration", Nothing)
						_editor.Selection.RemoveTag("strike")
						_editor.CommitTransaction()
					Catch
						_editor.RollbackTransaction()
					End Try
				End If
			End Set
		End Property

		''' <summary>
		''' Gets true if style attribute "text-decoration:underline" or tag "u" applied to selection
		''' Sets style attribute "text-decoration:underline" to selection
		''' </summary>
		Friend Property SelectionFontUnderline() As Boolean
			Get
				If _editor.Mode = EditorMode.Design Then
					Dim res As Boolean = _editor.Selection.IsTagApplied("u")
					If Not res And _editor.Selection.IsStyleApplied("text-decoration") Then
						res = String.Compare(_editor.Selection.GetStyleValue("text-decoration", C1StyleType.Character), "underline", True) = 0
					End If
					Return res
				Else
					Return False
				End If
			End Get
			Set
				If value Then
					_editor.Selection.ApplyStyle("text-decoration", "underline", C1StyleType.Character)
				Else
					_editor.BeginTransaction("Remove style")
					Try
						_editor.Selection.RemoveStyle("text-decoration", Nothing)
						_editor.Selection.RemoveTag("u")
						_editor.CommitTransaction()
					Catch
						_editor.RollbackTransaction()
					End Try
				End If
			End Set
		End Property

		''' <summary>
		''' Gets true if tag "big" applied to selection
		''' Sets "big" tag to selection
		''' </summary>
		Friend Property SelectionFontBig() As Boolean
			Get
                Return Util.IIFB(Mode = EditorMode.Design, _editor.Selection.IsTagApplied("big"), False)
			End Get
			Set
				If value Then
					_editor.BeginTransaction("Apply style")
					Try
						_editor.Selection.RemoveTag("small")
						_editor.Selection.ApplyTag("big")
						_editor.CommitTransaction()
					Catch
						_editor.RollbackTransaction()
					End Try
				Else
					_editor.Selection.RemoveTag("big")
				End If
			End Set
		End Property

		''' <summary>
		''' Gets true if tag "small" applied to selection
		''' Sets "small" tag to selection
		''' </summary>
		Friend Property SelectionFontSmall() As Boolean
			Get
                Return Util.IIFB(Mode = EditorMode.Design, _editor.Selection.IsTagApplied("small"), False)
			End Get
			Set
				If value Then
					_editor.BeginTransaction("Apply style")
					Try
						_editor.Selection.RemoveTag("big")
						_editor.Selection.ApplyTag("small")
						_editor.CommitTransaction()
					Catch
						_editor.RollbackTransaction()

					End Try
				Else
					_editor.Selection.RemoveTag("small")
				End If
			End Set
		End Property

		''' <summary>
		''' Gets color from current selection's style attribute "color"
		''' Sets color to current selection's style attribute "color"
		''' </summary>
		Friend Property SelectionColor() As Color
			Get
				If _editor.Mode = EditorMode.Design Then
					Dim foreColor As String = _editor.Selection.GetStyleValue("color", C1StyleType.Character)
					Return System.Drawing.ColorTranslator.FromHtml(foreColor)
				Else
					Return Color.Empty
				End If
			End Get
			Set
				If value.IsEmpty Then
					_editor.Selection.RemoveStyle("color", Nothing)
				Else
					Dim foreColor As String = System.Drawing.ColorTranslator.ToHtml(value)
					_editor.Selection.ApplyStyle("color", foreColor, C1StyleType.Character)
				End If
			End Set
		End Property

		''' <summary>
		''' Gets color from current selection's style attribute "background-color"
		''' Sets color to current selection's style attribute "background-color"
		''' </summary>
		Friend Property SelectionBackColor() As Color
			Get
				If _editor.Mode = EditorMode.Design Then
					Dim backColor As String = _editor.Selection.GetStyleValue("background-color", C1StyleType.Character)
					Return System.Drawing.ColorTranslator.FromHtml(backColor)
				Else
					Return Color.Empty
				End If
			End Get
			Set
				If value.IsEmpty Then
					_editor.Selection.RemoveStyle("background-color", Nothing)
				Else
					Dim backColor As String = System.Drawing.ColorTranslator.ToHtml(value)
					_editor.Selection.ApplyStyle("background-color", backColor, C1StyleType.Character)
				End If
			End Set
		End Property

		''' <summary>
		''' Gets color from current selection's paragraph style attribute "background-color"
		''' Sets color to current selection's paragragh style attribute "background-color"
		''' </summary>
		Friend Property SelectionParagraphColor() As Color
			Get
				If _editor.Mode = EditorMode.Design Then
					Dim htmlColor As String = _editor.Selection.GetStyleValue("background-color", C1StyleType.Paragraph)
					Return ColorTranslator.FromHtml(htmlColor)
				Else
					Return Color.Empty
				End If
			End Get
			Set
				Dim htmlColor As String = ColorTranslator.ToHtml(value)
				_editor.Selection.ApplyStyle("background-color", htmlColor, C1StyleType.Paragraph)
			End Set
		End Property

		''' <summary>
		''' Gets line spacing from current selection's paragraph style attribute "line-height"
		''' Sets line spacing to current selection's paragragh style attribute "line-height"
		''' </summary>
		Friend Property SelectionLineSpacing() As Single
			Get
				If _editor.Mode = EditorMode.Design Then
					Dim lsp As Single = 1F
					Dim lineSpacing As String = _editor.Selection.GetStyleValue("line-height")
					If String.IsNullOrEmpty(lineSpacing) Then
						Return 1F
					End If

                    If Single.TryParse(lineSpacing, lsp) Then
                        Return lsp / 100
                    End If
					Return 1F
				Else
					Return 1F
				End If
			End Get
			Set
				_editor.Selection.ApplyStyle("line-height", (value * 100).ToString() & "%", C1StyleType.Paragraph)
			End Set
		End Property

		''' <summary>
		''' Gets or sets selected text
		''' </summary>
		Friend Property SelectedText() As String
			Get
                Return Util.IIFS(Mode = EditorMode.Design, _editor.Selection.Text, String.Empty)
			End Get
			Set
				Dim range As C1TextRange = _editor.Selection.Clone()
				range.Text = value
				'after inserting text we must collapse selection to the end
				range.Normalize()
				range.Start.MoveTo(range.[End])
				range.[Select]()
			End Set
		End Property

		''' <summary>
		''' Gets text alignment from current selection's paragraph style attribute "text-align"
		''' Sets text alignment to current selection's paragragh style attribute "text-align"
		''' </summary>
		Friend Property SelectionAlignment() As TextAlignment
			Get
				If _editor.Mode = EditorMode.Design Then
					Dim textAlign As String = _editor.Selection.GetStyleValue("text-align")
					If [String].Compare(textAlign, "center") = 0 Then
						Return TextAlignment.Center
					ElseIf [String].Compare(textAlign, "right") = 0 Then
						Return TextAlignment.Right
					ElseIf [String].Compare(textAlign, "left") = 0 Then
						Return TextAlignment.Left
					ElseIf [String].Compare(textAlign, "justify") = 0 Then
						Return TextAlignment.Justify
					Else
						Return TextAlignment.[Default]
					End If
				Else
					Return TextAlignment.[Default]
				End If
			End Get
			Set
				Select Case value
					Case TextAlignment.Left
						_editor.Selection.ApplyStyle("text-align", "left", C1StyleType.Paragraph)
						Exit Select
					Case TextAlignment.Center
						_editor.Selection.ApplyStyle("text-align", "center", C1StyleType.Paragraph)
						Exit Select
					Case TextAlignment.Right
						_editor.Selection.ApplyStyle("text-align", "right", C1StyleType.Paragraph)
						Exit Select
					Case TextAlignment.Justify
						_editor.Selection.ApplyStyle("text-align", "justify", C1StyleType.Paragraph)
						Exit Select
					Case Else
						_editor.Selection.RemoveStyle("text-align", Nothing)
						Exit Select
				End Select
			End Set
		End Property

		''' <summary>
		''' Gets numbering type of current selection's paragraphs
		''' Sets numbering type to current selection's paragraghs
		''' </summary>
		Friend Property SelectionNumbering() As ListNumbering
			Get
				If _editor.Mode = EditorMode.Design Then
					Dim orderedList As Boolean = _editor.Selection.IsTagApplied("ol")
					Dim unorderedList As Boolean = _editor.Selection.IsTagApplied("ul")
					If orderedList AndAlso Not unorderedList Then
						Return ListNumbering.Arabic
					ElseIf unorderedList AndAlso Not orderedList Then
						Return ListNumbering.Bullets
					Else
						Return ListNumbering.None
					End If
				Else
					Return ListNumbering.None
				End If
			End Get
			Set
				_editor.BeginTransaction("Apply style")
				Try
					_editor.Selection.RemoveTag("ol")
					_editor.Selection.RemoveTag("ul")
					Select Case value
						Case ListNumbering.Arabic, ListNumbering.Lowercase, ListNumbering.RomanLowercase, ListNumbering.RomanUppercase, ListNumbering.Uppercase
							_editor.Selection.ApplyTag("ol")
							Exit Select
						Case ListNumbering.Bullets
							_editor.Selection.ApplyTag("ul")
							Exit Select
					End Select
					_editor.CommitTransaction()
				Catch
					_editor.RollbackTransaction()
				End Try
			End Set
		End Property

		''' <summary>
		''' Gets true if tag "sup" applied to selection
		''' Sets "sup" tag to selection
		''' </summary>
		Friend Property SelectionSuperscript() As Boolean
			Get
                Return Util.IIFB(Mode = EditorMode.Design, _editor.Selection.IsTagApplied("sup"), False)
			End Get
			Set
				If value Then
					_editor.Selection.RemoveTag("sub")
					_editor.Selection.ApplyTag("sup")
				Else
					_editor.Selection.RemoveTag("sup")
				End If
			End Set
		End Property

		''' <summary>
		''' Gets true if tag "sub" applied to selection
		''' Sets "sub" tag to selection
		''' </summary>
		Friend Property SelectionSubscript() As Boolean
			Get
                Return Util.IIFB(Mode = EditorMode.Design, _editor.Selection.IsTagApplied("sub"), False)
			End Get
			Set
				If value Then
					_editor.Selection.RemoveTag("sup")
					_editor.Selection.ApplyTag("sub")
				Else
					_editor.Selection.RemoveTag("sub")
				End If
			End Set
		End Property

		''' <summary>
		''' Clears selection formatting
		''' </summary>
		Friend Sub ClearFontFormatting()
			_editor.Selection.ClearFormatting()
		End Sub

		''' <summary>
		''' Sets character case to selection by setting "text-transform" attribute
		''' </summary>
		''' <param name="casing"></param>
		Friend Sub SelectionChangeCase(casing As CharCasing)
			If casing = CharCasing.CapitalizeWords Then
				_editor.Selection.ApplyStyle("text-transform", "capitalize", C1StyleType.Character)
			ElseIf casing = CharCasing.LowerCase Then
				_editor.Selection.ApplyStyle("text-transform", "lowercase", C1StyleType.Character)
			ElseIf casing = CharCasing.UpperCase Then
				_editor.Selection.ApplyStyle("text-transform", "uppercase", C1StyleType.Character)
			End If
        End Sub

        Friend Function IsSelectionInsideList() As Boolean
            Dim res As Boolean = False

            Dim start As XmlNode = _editor.Selection.Start.Node
            Dim [end] As XmlNode = _editor.Selection.End.Node

            While start IsNot Nothing AndAlso start.Name <> "li"
                start = start.ParentNode
            End While
            While [end] IsNot Nothing AndAlso [end].Name <> "li"
                [end] = [end].ParentNode
            End While

            If start IsNot Nothing AndAlso [end] IsNot Nothing Then
                If start.Equals([end]) Then
                    res = True
                Else
                    Dim parent As XmlNode = GetCommonParent(start, [end])
                    If start.Equals(parent) Or [end].Equals(parent) Then
                        parent = parent.ParentNode
                    End If
                    res = parent IsNot Nothing AndAlso (parent.Name = "ol" Or parent.Name = "ul")
                End If
            End If

            Return res
        End Function

        Friend Sub IncreaseIndent()
            _editor.BeginTransaction("Apply style")
            Try
                Dim paragraphs As List(Of XmlNode) = _editor.Selection.GetTags(C1StyleType.Paragraph, True)
                Dim doc As XmlDocument = _editor.Document
                For Each node As XmlNode In paragraphs
                    Dim newNode As XmlNode = doc.CreateElement("blockquote", doc.DocumentElement.NamespaceURI)
                    node.ParentNode.InsertAfter(newNode, node)
                    newNode.AppendChild(node)
                Next
                _editor.CommitTransaction()
            Catch
                _editor.RollbackTransaction()
            End Try
        End Sub

        Friend Sub DecreaseIndent()
            _editor.BeginTransaction("Remove style")
            Try
                Dim nodes As List(Of XmlNode) = _editor.Selection.GetTags(C1StyleType.Paragraph, True)
                Dim doc As XmlDocument = _editor.Document

                For i As Integer = 0 To nodes.Count - 1 Step 1
                    Dim node As XmlNode = nodes.Item(i)

                    While node IsNot Nothing AndAlso node.Name <> "blockquote"
                        node = node.ParentNode
                    End While

                    If node IsNot Nothing AndAlso node.Name = "blockquote" Then
                        While node.HasChildNodes
                            node.ParentNode.InsertBefore(node.FirstChild, node)
                        End While
                        node.ParentNode.RemoveChild(node)
                    End If
                Next

                _editor.CommitTransaction()
            Catch
                _editor.RollbackTransaction()
            End Try
        End Sub

#End Region

#Region "table, image, flash, links"

        ''' <summary>
        ''' Shows picture dialog and inserts/edits picture
        ''' </summary>
        Friend Sub InsertPicture()
            _editor.ShowDialog(DialogType.Image)
        End Sub

        ''' <summary>
        ''' Shows flash movie dialog and inserts/edits flash movie
        ''' </summary>
        Friend Sub InsertFlashMovie()
            _editor.ShowDialog(DialogType.FlashMovie)
        End Sub

        ''' <summary>
        ''' Shows hyperlink dialog and inserts/edits hyperlink
        ''' </summary>
        Friend Sub InsertHyperlink()
            _editor.ShowDialog(DialogType.Hyperlink)
        End Sub

        ''' <summary>
        ''' Shows bookmark dialog and inserts/edits bookmark
        ''' </summary>
        Friend Sub InsertBookmark()
            _editor.ShowDialog(DialogType.Bookmark)
        End Sub

        ''' <summary>
        ''' Shows table dialog and inserts/edits table
        ''' </summary>
        Friend Sub InsertTable()
            _editor.ShowDialog(DialogType.NewTable)
        End Sub

        ''' <summary>
        ''' Inserts table row above current selected cell
        ''' </summary>
        Friend Sub InsertTableRowAbove()
            _editor.Selection.Table.Execute(Table.Action.InsertRowAbove)
        End Sub

        ''' <summary>
        ''' Inserts table row below current selected cell
        ''' </summary>
        Friend Sub InsertTableRowBelow()
            _editor.Selection.Table.Execute(Table.Action.InsertRowBelow)
        End Sub

        ''' <summary>
        ''' Inserts table column before current selected cell
        ''' </summary>
        Friend Sub InsertTableColumnBefore()
            _editor.Selection.Table.Execute(Table.Action.InsertColumnBefore)
        End Sub

        ''' <summary>
        ''' Inserts table column after current selected cell
        ''' </summary>
        Friend Sub InsertTableColumnAfter()
            _editor.Selection.Table.Execute(Table.Action.InsertColumnAfter)
        End Sub

        ''' <summary>
        ''' Deletes selected table
        ''' </summary>
        Friend Sub DeleteTable()
            _editor.Selection.Table.Execute(Table.Action.DeleteTable)
        End Sub

        ''' <summary>
        ''' Deletes selected table rows
        ''' </summary>
        Friend Sub DeleteTableRows()
            _editor.Selection.Table.Execute(Table.Action.DeleteRows)
        End Sub

        ''' <summary>
        ''' Deletes selected table columns
        ''' </summary>
        Friend Sub DeleteTableColumns()
            _editor.Selection.Table.Execute(Table.Action.DeleteColumns)
        End Sub

        ''' <summary>
        ''' Shows table properties dialog, edits table properties
        ''' </summary>
        Friend Sub TableProperties()
            _editor.Selection.Table.ShowDialog(Table.DialogType.Table)
        End Sub

        ''' <summary>
        ''' Shows table row properties dialog, edits table row properties
        ''' </summary>
        Friend Sub TableRowProperties()
            _editor.Selection.Table.ShowDialog(Table.DialogType.Row)
        End Sub

        ''' <summary>
        ''' Shows table column properties dialog, edits table column properties
        ''' </summary>
        Friend Sub TableColumnProperties()
            _editor.Selection.Table.ShowDialog(Table.DialogType.Column)
        End Sub

        ''' <summary>
        ''' Shows table cell properties dialog, edits table cell properties
        ''' </summary>
        Friend Sub TableCellProperties()
            _editor.Selection.Table.ShowDialog(Table.DialogType.Cell)
        End Sub

        ''' <summary>
        ''' Returns true if picture can be inserted to current selection
        ''' </summary>
        Friend ReadOnly Property InsertPictureEnabled() As Boolean
            Get
                Return _editor.CanShowDialog(DialogType.Image)
            End Get
        End Property

        ''' <summary>
        ''' Returns true if flash movie can be inserted to current selection
        ''' </summary>
        Friend ReadOnly Property InsertFlashMovieEnabled() As Boolean
            Get
                Return _editor.CanShowDialog(DialogType.FlashMovie)
            End Get
        End Property

        ''' <summary>
        ''' Returns true if hyperlink can be inserted to current selection
        ''' </summary>
        Friend ReadOnly Property InsertHyperlinkEnabled() As Boolean
            Get
                Return _editor.CanShowDialog(DialogType.Hyperlink)
            End Get
        End Property

        ''' <summary>
        ''' Returns true if bookmark can be inserted to current selection
        ''' </summary>
        Friend ReadOnly Property InsertBookmarkEnabled() As Boolean
            Get
                Return _editor.CanShowDialog(DialogType.Bookmark)
            End Get
        End Property

        ''' <summary>
        ''' Returns true if table can be inserted to current selection
        ''' </summary>
        Friend ReadOnly Property InsertTableEnabled() As Boolean
            Get
                Return _editor.CanShowDialog(DialogType.NewTable)
            End Get
        End Property

        ''' <summary>
        ''' Returns true if table row can be inserted to current selection
        ''' </summary>
        Friend ReadOnly Property InsertTableRowEnabled() As Boolean
            Get
                If _editor.Mode = EditorMode.Design AndAlso _editor.Selection.Table IsNot Nothing Then
                    Return _editor.Selection.Table.CanExecute(Table.Action.InsertRowAbove)
                Else
                    Return False
                End If
            End Get
        End Property

        ''' <summary>
        ''' Returns true if table column can be inserted to current selection
        ''' </summary>
        Friend ReadOnly Property InsertTableColumnEnabled() As Boolean
            Get
                If _editor.Mode = EditorMode.Design AndAlso _editor.Selection.Table IsNot Nothing Then
                    Return _editor.Selection.Table.CanExecute(Table.Action.InsertColumnAfter)
                Else
                    Return False
                End If
            End Get
        End Property

        ''' <summary>
        ''' Returns true if table can be deleted
        ''' </summary>
        Friend ReadOnly Property DeleteTableEnabled() As Boolean
            Get
                If _editor.Mode = EditorMode.Design AndAlso _editor.Selection.Table IsNot Nothing Then
                    Return _editor.Selection.Table.CanExecute(Table.Action.DeleteTable)
                Else
                    Return False
                End If
            End Get
        End Property

        ''' <summary>
        ''' Returns true if table rows can be deleted
        ''' </summary>
        Friend ReadOnly Property DeleteTableRowsEnabled() As Boolean
            Get
                If _editor.Mode = EditorMode.Design AndAlso _editor.Selection.Table IsNot Nothing Then
                    Return _editor.Selection.Table.CanExecute(Table.Action.DeleteRows)
                Else
                    Return False
                End If
            End Get
        End Property

        ''' <summary>
        ''' Returns true if table columns can be deleted
        ''' </summary>
        Friend ReadOnly Property DeleteTableColumnsEnabled() As Boolean
            Get
                If _editor.Mode = EditorMode.Design AndAlso _editor.Selection.Table IsNot Nothing Then
                    Return _editor.Selection.Table.CanExecute(Table.Action.DeleteColumns)
                Else
                    Return False
                End If
            End Get
        End Property

        ''' <summary>
        ''' Returns true if table properties dialog can be shown
        ''' </summary>
        Friend ReadOnly Property TablePropertiesEnabled() As Boolean
            Get
                If _editor.Mode = EditorMode.Design AndAlso _editor.Selection.Table IsNot Nothing Then
                    Return _editor.Selection.Table.CanShowDialog(Table.DialogType.Table)
                Else
                    Return False
                End If
            End Get
        End Property

        ''' <summary>
        ''' Returns true if table row properties dialog can be shown
        ''' </summary>
        Friend ReadOnly Property TableRowPropertiesEnabled() As Boolean
            Get
                If _editor.Mode = EditorMode.Design AndAlso _editor.Selection.Table IsNot Nothing Then
                    Return _editor.Selection.Table.CanShowDialog(Table.DialogType.Row)
                Else
                    Return False
                End If
            End Get
        End Property

        ''' <summary>
        ''' Returns true if table column properties dialog can be shown
        ''' </summary>
        Friend ReadOnly Property TableColumnPropertiesEnabled() As Boolean
            Get
                If _editor.Mode = EditorMode.Design AndAlso _editor.Selection.Table IsNot Nothing Then
                    Return _editor.Selection.Table.CanShowDialog(Table.DialogType.Column)
                Else
                    Return False
                End If
            End Get
        End Property

        ''' <summary>
        ''' Returns true if table cell properties dialog can be shown
        ''' </summary>
        Friend ReadOnly Property TableCellPropertiesEnabled() As Boolean
            Get
                If _editor.Mode = EditorMode.Design AndAlso _editor.Selection.Table IsNot Nothing Then
                    Return _editor.Selection.Table.CanShowDialog(Table.DialogType.Cell)
                Else
                    Return False
                End If
            End Get
        End Property

#End Region

#Region "implementation"

        Private Function GetCommonParent(ByVal node1 As XmlNode, ByVal node2 As XmlNode) As XmlNode
            If node1 Is Nothing Then
                Return node2
            End If
            If node2 Is Nothing Then
                Return node1
            End If

            Dim commonNode As XmlNode = Nothing
            If node1.Equals(node2) Then
                commonNode = node1
            Else
                Dim documentElement As XmlNode = node1.OwnerDocument.DocumentElement
                Dim node As XmlNode = Nothing

                Dim node1Parents As List(Of XmlNode) = New List(Of XmlNode)()
                node = node1
                While node IsNot Nothing AndAlso Not node.Equals(documentElement)
                    node1Parents.Insert(0, node)
                    node = node.ParentNode
                End While

                Dim node2Parents As List(Of XmlNode) = New List(Of XmlNode)()
                node = node2
                While node IsNot Nothing AndAlso Not node.Equals(documentElement)
                    node2Parents.Insert(0, node)
                    node = node.ParentNode
                End While

                Dim length As Integer = Math.Min(node1Parents.Count, node2Parents.Count)
                For i As Integer = 0 To length - 1 Step 1
                    If Not node1Parents.Item(i).Equals(node2Parents.Item(i)) Then
                        Exit For
                    Else
                        commonNode = node1Parents.Item(i)
                    End If
                Next
            End If

            Return commonNode
        End Function

#End Region

    End Class

    Public Class Util
        Public Shared Function IIFS(ByVal flag As Boolean, ByVal s1 As String, ByVal s2 As String) As String
            If flag Then
                Return s1
            Else
                Return s2
            End If
        End Function
        Public Shared Function IIFB(ByVal flag As Boolean, ByVal v1 As Boolean, ByVal v2 As Boolean) As Boolean
            If flag Then
                Return v1
            Else
                Return v2
            End If
        End Function
        Public Shared Function IIFF(ByVal flag As Boolean, ByVal v1 As Single, ByVal v2 As Single) As Single
            If flag Then
                Return v1
            Else
                Return v2
            End If
        End Function
        Public Shared Function IIFSS(ByVal flag As Boolean, ByVal s1 As String(), ByVal s2 As String()) As String()
            If flag Then
                Return s1
            Else
                Return s2
            End If
        End Function
    End Class
End Namespace
