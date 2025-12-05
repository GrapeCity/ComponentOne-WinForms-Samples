Imports System.IO
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.SpellChecker

Namespace ToolStrips
	Class ToolStripMain
		Inherits ToolStripBase
		'----------------------------------------------------------------------------
		#Region "** fields"

		Private _fileName As String
		Private _dirty As Boolean
		Private _spellChecker As C1SpellChecker
		Private _btnNew As ToolStripButton, _btnOpen As ToolStripButton, _btnSave As ToolStripButton, _btnPrint As ToolStripButton
		Private _btnCut As ToolStripButton, _btnCopy As ToolStripButton, _btnPaste As ToolStripButton
		Private _btnUndo As ToolStripButton, _btnRedo As ToolStripButton
		Private _btnFind As ToolStripButton, _btnReplace As ToolStripButton
		Private _btnShowErrors As ToolStripButton, _btnSpell As ToolStripButton
		Private _btnWordCount As ToolStripButton
		Private _btnHelp As ToolStripButton

		#End Region

		'----------------------------------------------------------------------------
		#Region "** object model"

		Public Property SpellChecker() As C1SpellChecker
			Get
				Return _spellChecker
			End Get
			Set
				_spellChecker = value
			End Set
		End Property

		#End Region

		'----------------------------------------------------------------------------
		#Region "** event handlers"

		' initialize the toolstrip
		Protected Overloads Overrides Sub OnInitialize()
			' populate toolstrip
            _btnNew = AddButton("New", Resources.New_small, AddressOf New_Click)
            _btnOpen = AddButton("Open", Resources.Open_small, AddressOf Open_Click)
            _btnSave = AddButton("Save", Resources.Save_small, AddressOf Save_Click)
            _btnPrint = AddButton("Print", Resources.Print_small, AddressOf Print_Click)
            Items.Add(New ToolStripSeparator())
            _btnCut = AddButton("Cut", Resources.Cut_small, AddressOf Cut_Click)
            _btnCopy = AddButton("Copy", Resources.Copy_small, AddressOf Copy_Click)
            _btnPaste = AddButton("Paste", Resources.Paste_small, AddressOf Paste_Click)
            Items.Add(New ToolStripSeparator())
            _btnUndo = AddButton("Undo", Resources.Undo_small, AddressOf Undo_Click)
            _btnRedo = AddButton("Redo", Resources.Redo_small, AddressOf Redo_Click)
            Items.Add(New ToolStripSeparator())
            _btnShowErrors = AddButton("Show Spelling Errors", Resources.ShowErrors_small, AddressOf ShowSpellingErrors_Click)
            _btnSpell = AddButton("Spell", Resources.Spelling_small, AddressOf Spell_Click)
            Items.Add(New ToolStripSeparator())
            _btnFind = AddButton("Find", Resources.Find_small, AddressOf Find_Click)
            _btnReplace = AddButton("Replace", Resources.Replace_small, AddressOf Replace_Click)
            Items.Add(New ToolStripSeparator())
            _btnWordCount = AddButton("Word Count", Resources.WordCount_small, AddressOf WordCount_Click)
            Items.Add(New ToolStripSeparator())
            _btnHelp = AddButton("Help", Resources.Help_small, AddressOf Help_Click)
        End Sub

        ' enable/disable buttons
        Public Overloads Overrides Sub UpdateState()
            Dim isDesign = (Editor.Mode = C1.Win.C1Editor.EditorMode.Design)
            Dim isPreview = (Editor.Mode = C1.Win.C1Editor.EditorMode.Preview)

            Enabled = Editor IsNot Nothing
            _btnCopy.Enabled = InlineAssignHelper(_btnCut.Enabled, Editor.CanCopy)
            _btnPaste.Enabled = Editor.CanPasteAsText
            ' CanPaste
            _btnUndo.Enabled = Editor.CanUndo()
            _btnRedo.Enabled = Editor.CanRedo()

            _btnShowErrors.Enabled = isDesign And (SpellChecker IsNot Nothing)
            _btnSpell.Enabled = isDesign And (SpellChecker IsNot Nothing)
            _btnFind.Enabled = Not isPreview
            _btnReplace.Enabled = Not isPreview
        End Sub

        ' keep track of changes in the document
        Protected Overloads Overrides Sub OnDocumentChanged(ByVal e As EventArgs)
            SetDirty(True)
        End Sub

        ' keep track of changes in the document
        Protected Overloads Overrides Sub OnModeChanged(ByVal e As EventArgs)
            UpdateState()
        End Sub

        Protected Overloads Overrides Sub OnEditorKeyDownHandler(ByVal e As KeyEventArgs)
            If e.Control And e.KeyCode = Keys.S Then
                e.Handled = True
                Save_Click(Nothing, e)
            ElseIf e.Control And e.KeyCode = Keys.O Then
                e.Handled = True
                Open_Click(Nothing, e)
            ElseIf e.Control And e.KeyCode = Keys.P Then
                e.Handled = True
                Print_Click(Nothing, e)
            ElseIf e.Control And e.KeyCode = Keys.N Then
                e.Handled = True
                New_Click(Nothing, e)
            End If
        End Sub

        ' file commands
        Private Sub New_Click(ByVal sender As Object, ByVal e As EventArgs)
            NewDocument()
        End Sub
        Private Sub Open_Click(ByVal sender As Object, ByVal e As EventArgs)
            LoadDocument()
        End Sub
        Private Sub Save_Click(ByVal sender As Object, ByVal e As EventArgs)
            SaveDocument()
        End Sub

        ' preview/print
        Private Sub Print_Click(ByVal sender As Object, ByVal e As EventArgs)
            Editor.PrintPreview()
        End Sub

        ' clipboard
        Private Sub Cut_Click(ByVal sender As Object, ByVal e As EventArgs)
            Editor.Cut()
        End Sub
        Private Sub Copy_Click(ByVal sender As Object, ByVal e As EventArgs)
            Editor.Copy()
        End Sub
        Private Sub Paste_Click(ByVal sender As Object, ByVal e As EventArgs)
            Editor.PasteAsText()
            '.Paste();
        End Sub

        ' undo/redo
        Private Sub Undo_Click(ByVal sender As Object, ByVal e As EventArgs)
            Editor.Undo()
        End Sub
        Private Sub Redo_Click(ByVal sender As Object, ByVal e As EventArgs)
            Editor.Redo()
        End Sub

        ' find/replace
        Private Sub Find_Click(ByVal sender As Object, ByVal e As EventArgs)
            Editor.ShowDialog(C1.Win.C1Editor.DialogType.Find)
        End Sub
        Private Sub Replace_Click(ByVal sender As Object, ByVal e As EventArgs)
            Editor.ShowDialog(C1.Win.C1Editor.DialogType.Replace)
        End Sub

        ' spelling
        Private Sub ShowSpellingErrors_Click(ByVal sender As Object, ByVal e As EventArgs)
            If SpellChecker IsNot Nothing Then
                Dim show As Boolean = Not _btnShowErrors.Checked
                _btnShowErrors.Checked = show
                SpellChecker.SetActiveSpellChecking(Editor, Editor.GetActiveXInstance(), show)
            End If
        End Sub
        Private Sub Spell_Click(ByVal sender As Object, ByVal e As EventArgs)
            If SpellChecker IsNot Nothing Then
                SpellChecker.CheckControl(Editor, Editor.GetActiveXInstance())
            End If
        End Sub

        ' word count
        Private Sub WordCount_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = Editor.Text
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

        ' help
        Private Sub Help_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim msg As String = String.Format(Resources.About, Editor.[GetType]().Assembly.GetName().Version)
            MessageBox.Show(msg, ProductName)
        End Sub

#End Region

        '----------------------------------------------------------------------------
#Region "** implementation"

        ' keep track of changes
        Private Sub SetDirty(ByVal dirty As Boolean)
            _dirty = dirty
            UpdateCaption()
        End Sub

        ' check with user before discarding changes
        Private Function OKToDiscardChanges() As Boolean
            If _dirty Then
                Dim dr As DialogResult = MessageBox.Show(Resources.PromptSaveChanges, ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                Select Case dr
                    ' save document, then proceed
                    Case DialogResult.Yes
                        Return SaveDocument()

                        ' proceed without saving
                    Case DialogResult.No
                        Return True

                        ' do not proceed
                    Case DialogResult.Cancel
                        Return False
                End Select
            End If

            ' no changes, ok to proceed
            Return True
        End Function

        ' show current document and modified state
        Private Sub UpdateCaption()
            Dim form As Form = TryCast(TopLevelControl, Form)
            If form IsNot Nothing Then
                Dim sb As StringBuilder = New StringBuilder(ProductName)
                If Not String.IsNullOrEmpty(_fileName) Then
                    sb.AppendFormat(" - {0}", Path.GetFileName(_fileName))
                    If _dirty Then
                        sb.Append(" *")
                    End If
                End If
                form.Text = sb.ToString()
            End If
        End Sub

        ' create a new document
        Private Function NewDocument() As Boolean
            If OKToDiscardChanges() Then
                Editor.Document = New System.Xml.XmlDocument()
                _fileName = Nothing
                SetDirty(False)
                Return True
            End If
            Return False
        End Function

        ' load a document into the editor
        Private Function LoadDocument() As Boolean
            If OKToDiscardChanges() Then
                Using dlg As OpenFileDialog = New OpenFileDialog()
                    ' get file name
                    dlg.Filter = Resources.FileFilter
                    dlg.DefaultExt = Resources.DefaultExt
                    If dlg.ShowDialog() = DialogResult.OK Then
                        Try
                            ' load document
                            Editor.LoadXml(dlg.FileName)
                            _fileName = dlg.FileName
                            SetDirty(False)
                            Return True
                        Catch x As Exception
                            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                            Return False
                        End Try
                    End If
                End Using
            End If

            ' canceled...
            Return False
        End Function

        ' save current document using current file name
        Private Function SaveDocument() As Boolean
            ' no name? go get one...
            If String.IsNullOrEmpty(_fileName) Then
                Return SaveDocumentAs()
            End If

            ' got the name, save the file
            Try
                Editor.SaveXml(_fileName)
                SetDirty(False)
                Return True
            Catch x As Exception
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return False
            End Try
        End Function

        ' save current document using a new name
        Private Function SaveDocumentAs() As Boolean
            Using dlg As SaveFileDialog = New SaveFileDialog()
                dlg.Filter = Resources.FileFilter
                dlg.DefaultExt = Resources.DefaultExt
                If dlg.ShowDialog() = DialogResult.OK Then
                    _fileName = dlg.FileName
                    Return SaveDocument()
                End If
            End Using
            Return False
        End Function
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
            target = value
            Return value
        End Function

#End Region

	End Class
End Namespace
