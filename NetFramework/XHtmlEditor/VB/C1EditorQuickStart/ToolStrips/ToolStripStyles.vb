Imports System.IO
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Xml
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1SpellChecker
Imports C1.Win.C1Editor

Namespace ToolStrips
	Class ToolStripStyles
		Inherits ToolStripBase
		'----------------------------------------------------------------------------
		#Region "** fields"

		Private _cmbStyle As ToolStripComboBox
        Private _btnBold As ToolStripButton, _btnItalic As ToolStripButton, _btnUnderline As ToolStripButton, _btnClear As ToolStripButton
        Private _btnBullets As ToolStripButton, _btnNumbering As ToolStripButton, _btnIncreaseIndent As ToolStripButton, _btnDecreaseIndent As ToolStripButton
		Private _selectionChanged As Boolean

		#End Region

		'----------------------------------------------------------------------------
		#Region "** implementation"

		' initialize toolstrip
		Protected Overloads Overrides Sub OnInitialize()
			' style combo
			_cmbStyle = AddStyleCombo()
			AddHandler _cmbStyle.LostFocus, AddressOf _cmbStyle_LostFocus
			AddHandler _cmbStyle.KeyDown, AddressOf _cmbStyle_KeyDown
			AddHandler _cmbStyle.SelectedIndexChanged, AddressOf _cmbStyle_SelectedIndexChanged

			Items.Add(New ToolStripSeparator())

			' inline formatting buttons
            _btnBold = AddButton("Bold", Resources.Bold_small, AddressOf Bold_Click)
            _btnItalic = AddButton("Italic", Resources.Italic_small, AddressOf Italic_Click)
            _btnUnderline = AddButton("Underline", Resources.Underline_small, AddressOf Underline_Click)
            _btnClear = AddButton("Clear Formatting", Resources.ClearFormatting_small, AddressOf ClearFormatting_Click)

            Items.Add(New ToolStripSeparator())

            _btnBullets = AddButton("Bullets", Resources.Bullets_small, AddressOf BulletsClick)
            _btnNumbering = AddButton("Numbering", Resources.Numbering_small, AddressOf NumberingClick)
            _btnDecreaseIndent = AddButton("Decrease Indent", Resources.DecreaseIndent_small, AddressOf DecreaseIndentClick)
            _btnIncreaseIndent = AddButton("Increase Indent", Resources.IncreaseIndent_small, AddressOf IncreaseIndentClick)

		End Sub
		Private Function AddStyleCombo() As ToolStripComboBox
			Dim cmb As ToolStripComboBox = New ToolStripComboBox()
			cmb.AutoSize = False
            cmb.Width = 150
            cmb.DropDownStyle = ComboBoxStyle.DropDownList

            cmb.Items.Add("(None)")
			cmb.Items.Add("Paragraph <p>")
			For i As Integer = 1 To 6
				cmb.Items.Add(String.Format("Heading {0} <h{0}>", i))
			Next
			cmb.Items.Add("Unordered List <ul>")
			cmb.Items.Add("Ordered List <ol>")
			cmb.Items.Add("Preformatted <pre>")

			Items.Add(cmb)
			Return cmb
		End Function

		' remember selection has changed, update style later 
		Protected Overloads Overrides Sub OnSelectionChanged(e As EventArgs)
			_selectionChanged = True
		End Sub

        ' keep track of changes in the document
        Protected Overloads Overrides Sub OnModeChanged(ByVal e As EventArgs)
            ShowStyles()
        End Sub

		' show currently selected style
		Public Overloads Overrides Sub UpdateState()
			If _selectionChanged Then
				_selectionChanged = False
				ShowStyles()
			End If
		End Sub

		Private Sub ShowStyles()
			' show inline styles
            Dim s As Selection = Editor.Selection
            Dim isDesignMode = (Editor.Mode = C1.Win.C1Editor.EditorMode.Design)

            _btnBold.Enabled = isDesignMode
            _btnItalic.Enabled = isDesignMode
            _btnUnderline.Enabled = isDesignMode
            _btnClear.Enabled = isDesignMode
            _cmbStyle.Enabled = isDesignMode
            _btnBullets.Enabled = isDesignMode
            _btnNumbering.Enabled = isDesignMode
            If isDesignMode Then
                _btnIncreaseIndent.Enabled = Not IsSelectionInsideList() Or s.List.CanExecute(List.Action.IncreaseLevel)
                _btnDecreaseIndent.Enabled = Not IsSelectionInsideList() Or s.List.CanExecute(List.Action.DecreaseLevel)
            Else
                _btnIncreaseIndent.Enabled = False
                _btnDecreaseIndent.Enabled = False
            End If

            If s IsNot Nothing Then
                _btnBold.Checked = SelectionFontBold
                _btnItalic.Checked = SelectionFontItalic
                _btnUnderline.Checked = SelectionFontUnderline
                _btnBullets.Checked = s.List.Type = C1.Win.C1Editor.List.ListType.Bulleted
                _btnNumbering.Checked = s.List.Type = C1.Win.C1Editor.List.ListType.Numbered
            End If

			' find selected style
			Dim node As XmlNode = GetSelectedNode()
			If node Is Nothing Then
				_cmbStyle.SelectedIndex = 0
			Else
				Dim found As Boolean = False
				While node IsNot Nothing AndAlso Not found
					Dim style As String = String.Format("<{0}>", node.Name)
					For Each item As String In _cmbStyle.Items
                        If item.IndexOf(style) > -1 Then
                            RemoveHandler _cmbStyle.SelectedIndexChanged, AddressOf _cmbStyle_SelectedIndexChanged
                            Try
                                _cmbStyle.Text = item
                            Finally
                                AddHandler _cmbStyle.SelectedIndexChanged, AddressOf _cmbStyle_SelectedIndexChanged
                            End Try
                            found = True
                            Exit For
                        End If
					Next
					node = node.ParentNode
				End While
			End If
		End Sub

		' validate and apply selected style
		Private Sub ValidateAndApplyStyle()
			Dim style As String = _cmbStyle.Text
			Dim start As Integer = style.IndexOf("<"C)
			Dim [end] As Integer = style.IndexOf(">"C)
			If [end] > -1 AndAlso [end] > start Then
				Editor.Selection.ApplyTag(style.Substring(start + 1, [end] - start - 1))
			End If
		End Sub
		Private Function GetSelectedNode() As XmlNode
            ' return node if start and end nodes are the same
			Dim selRange As Selection = Editor.Selection
			If selRange IsNot Nothing Then
				Dim startNode As XmlNode = selRange.Start.Node
				Dim endNode As XmlNode = selRange.[End].Node
                If Object.Equals(startNode, endNode) Then
                    Return startNode
                Else
                    Return Nothing
                End If
            End If

            Return Nothing
        End Function

        Private Sub IncreaseIndent()
            Editor.BeginTransaction("Apply style")
            Try
                Dim paragraphs As List(Of XmlNode) = Editor.Selection.GetTags(C1StyleType.Paragraph, True)
                Dim doc As XmlDocument = Editor.Document
                For Each node As XmlNode In paragraphs
                    Dim newNode As XmlNode = doc.CreateElement("blockquote", doc.DocumentElement.NamespaceURI)
                    node.ParentNode.InsertAfter(newNode, node)
                    newNode.AppendChild(node)
                Next
                Editor.CommitTransaction()
            Catch
                Editor.RollbackTransaction()
            End Try
        End Sub

        Private Sub DecreaseIndent()
            Editor.BeginTransaction("Remove style")
            Try
                Dim nodes As List(Of XmlNode) = Editor.Selection.GetTags(C1StyleType.Paragraph, True)
                Dim doc As XmlDocument = Editor.Document

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

                Editor.CommitTransaction()
            Catch
                Editor.RollbackTransaction()
            End Try
        End Sub

        Private Function IsSelectionInsideList() As Boolean
            Dim res As Boolean = False

            Dim start As XmlNode = Editor.Selection.Start.Node
            Dim [end] As XmlNode = Editor.Selection.End.Node

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

		'----------------------------------------------------------------------------
		#Region "** event handlers"

		Private Sub _cmbStyle_LostFocus(sender As Object, e As EventArgs)
            'ValidateAndApplyStyle()
        End Sub
		Private Sub _cmbStyle_SelectedIndexChanged(sender As Object, e As EventArgs)
			ValidateAndApplyStyle()
		End Sub
		Private Sub _cmbStyle_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.Enter Then
				ValidateAndApplyStyle()
			End If
		End Sub
		Private Sub Bold_Click(sender As Object, e As EventArgs)
			_btnBold.Checked = InlineAssignHelper(SelectionFontBold, Not SelectionFontBold)
		End Sub
		Private Sub Italic_Click(sender As Object, e As EventArgs)
			_btnItalic.Checked = InlineAssignHelper(SelectionFontItalic, Not SelectionFontItalic)
		End Sub
		Private Sub Underline_Click(sender As Object, e As EventArgs)
			_btnUnderline.Checked = InlineAssignHelper(SelectionFontUnderline, Not SelectionFontUnderline)
		End Sub
		Private Sub ClearFormatting_Click(sender As Object, e As EventArgs)
			Dim s As Selection = Editor.Selection
			s.ClearFormatting()
        End Sub
        Private Sub BulletsClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim applied As Boolean = _btnBullets.Checked
            If applied Then
                Editor.Selection.List.Type = List.ListType.None
            Else
                Editor.Selection.List.Type = List.ListType.Bulleted
            End If
            _selectionChanged = True
            UpdateState()
        End Sub
        Private Sub NumberingClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim applied As Boolean = _btnNumbering.Checked
            If applied Then
                Editor.Selection.List.Type = List.ListType.None
            Else
                Editor.Selection.List.Type = List.ListType.Numbered
            End If
            _selectionChanged = True
            UpdateState()
        End Sub
        Private Sub IncreaseIndentClick(ByVal sender As Object, ByVal e As EventArgs)
            If IsSelectionInsideList() Then
                Editor.Selection.List.Execute(List.Action.IncreaseLevel)
            Else
                IncreaseIndent()
            End If
        End Sub
        Private Sub DecreaseIndentClick(ByVal sender As Object, ByVal e As EventArgs)
            If IsSelectionInsideList() Then
                Editor.Selection.List.Execute(List.Action.DecreaseLevel)
            Else
                DecreaseIndent()
            End If
        End Sub

		#End Region

		#Region "** formatting properties"

		Private Property SelectionFontBold() As Boolean
            Get
                If Editor.Mode = EditorMode.Design Then
                    Return Editor.Selection.IsTagApplied("strong")
                Else
                    Return False
                End If
            End Get
			Set
				If value Then
					Editor.Selection.ApplyTag("strong")
				Else
					Editor.Selection.RemoveTag("strong")
				End If
			End Set
		End Property

		Private Property SelectionFontItalic() As Boolean
			Get
                If Editor.Mode = EditorMode.Design Then
                    Return Editor.Selection.IsTagApplied("em")
                Else
                    Return False
                End If
            End Get
			Set
				If value Then
					Editor.Selection.ApplyTag("em")
				Else
					Editor.Selection.RemoveTag("em")
				End If
			End Set
		End Property

		Private Property SelectionFontUnderline() As Boolean
			Get
				If Editor.Mode = EditorMode.Design Then
					Dim res As Boolean = False
					If Editor.Selection.IsStyleApplied("text-decoration") Then
						res = String.Compare(Editor.Selection.GetStyleValue("text-decoration", C1StyleType.Character), "underline", True) = 0
					End If
					Return res
				Else
					Return False
				End If
			End Get
			Set
				If value Then
					Editor.Selection.ApplyStyle("text-decoration", "underline", C1StyleType.Character)
				Else
					Editor.Selection.RemoveStyle("text-decoration", Nothing)
				End If
			End Set
		End Property
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function

		#End Region
	End Class
End Namespace
