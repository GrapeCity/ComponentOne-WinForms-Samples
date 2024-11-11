Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports C1.Win.Ribbon

Imports EditorMode = C1.Win.C1Editor.EditorMode

Namespace RichTextEditor
	Class ViewTab
		Inherits C1TextEditorRibbonTab
		#Region "declarations"

		Private _modeDesign As RibbonToggleButton
		Private _modeSource As RibbonToggleButton
		Private _modePreview As RibbonToggleButton
		Private _fixErrors As RibbonButton
		Private _validateDocument As RibbonButton
		Private _isFixing As Boolean

		#End Region

		#Region "ctors"

		Public Sub New()
			Me.ID = InlineAssignHelper(Me.Text, "View")
			Groups.Add(CreateDocumentViewsGroup())
			Groups.Add(CreateSourceGroup())
			_isFixing = False
		End Sub

		#End Region

		#Region "overrides"

		Friend Overloads Overrides Sub InitTab()
			AddHandler Ribbon.EditorTextChanged, AddressOf EditorTextChangedHandler
			MyBase.InitTab()
		End Sub

		Protected Overloads Overrides Sub OnSelect(e As EventArgs)
			MyBase.OnSelect(e)
			UpdateEditorModeButtons()
		End Sub

		Friend Overloads Overrides Sub HandleItemEvent(e As RibbonEventArgs)
			Dim item As RibbonItem = DirectCast(e.Item, RibbonItem)
			If e.EventType = RibbonEventType.Click Then
				If item Is _modeDesign Then
					SetEditorMode(EditorMode.Design)
				ElseIf item Is _modeSource Then
					SetEditorMode(EditorMode.Source)
				ElseIf item Is _modePreview Then
					SetEditorMode(EditorMode.Preview)
				ElseIf item Is _fixErrors Then
					_isFixing = True
					Try
						Editor.FixSource()
					Finally
						_isFixing = False
					End Try
					_fixErrors.Enabled = False
					_validateDocument.Enabled = False
				ElseIf item Is _validateDocument Then
					Dim errorsFixed As Boolean = TryCast(Editor, C1RibbonEditorXhtml).ValidateSource()
					_fixErrors.Enabled = Not errorsFixed
					_validateDocument.Enabled = False
				End If
			End If
		End Sub

		#End Region

		#Region "implementation"

		Private Sub UpdateEditorModeButtons()
			Dim ed As C1RibbonEditorXhtml = TryCast(Editor, C1RibbonEditorXhtml)

			_modeDesign.Visible = ed IsNot Nothing
			_modeSource.Visible = ed IsNot Nothing
			_modePreview.Visible = ed IsNot Nothing
			If ed IsNot Nothing Then
				_modeDesign.Pressed = ed.Mode = EditorMode.Design
				_modeSource.Pressed = ed.Mode = EditorMode.Source
				_modePreview.Pressed = ed.Mode = EditorMode.Preview
				Groups("Validation").Visible = ed.Mode = EditorMode.Source
			End If
		End Sub

		Private Sub UpdateRibbonState(mode As EditorMode)
			Dim home As RibbonTab = Ribbon.Tabs("Home")
			home.Groups("Clipboard").Enabled = mode <> EditorMode.Preview
			home.Groups("Font").Enabled = mode = EditorMode.Design
			home.Groups("Paragraph").Enabled = mode = EditorMode.Design
            home.Groups("Editing").Enabled = mode <> EditorMode.Preview
			Dim insert As RibbonTab = Ribbon.Tabs("Insert")
			insert.Groups("Tables").Enabled = mode = EditorMode.Design
			insert.Groups("Illustrations").Enabled = mode = EditorMode.Design
			insert.Groups("Links").Enabled = mode = EditorMode.Design
			insert.Groups("Text").Enabled = mode = EditorMode.Design
			Dim review As RibbonTab = Ribbon.Tabs("Review")
			review.Groups("Proofing").Enabled = mode = EditorMode.Design
		End Sub

		Private Function CreateDocumentViewsGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Document Views")

			g.Items.Add(InlineAssignHelper(_modeDesign, CreateToggleButton("EditorDesignMode")))
			g.Items.Add(InlineAssignHelper(_modeSource, CreateToggleButton("EditorSourceMode")))
			g.Items.Add(InlineAssignHelper(_modePreview, CreateToggleButton("EditorPreviewMode")))

			Return g
		End Function

		Private Function CreateSourceGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Validation")

			g.Items.Add(InlineAssignHelper(_fixErrors, CreateButton("FixErrors")))
			g.Items.Add(InlineAssignHelper(_validateDocument, CreateButton("ValidateDocument")))

			Return g
		End Function

		Private Sub SetEditorMode(mode As EditorMode)
			Dim ed As C1RibbonEditorXhtml = TryCast(Editor, C1RibbonEditorXhtml)
			ed.Mode = mode
			_fixErrors.Enabled = False
			_validateDocument.Enabled = False
			UpdateEditorModeButtons()
			If ed.Mode = mode Then
				UpdateRibbonState(mode)
			End If
			If ed.Mode <> mode AndAlso ed.Mode = EditorMode.Source Then
				_fixErrors.Enabled = True
				_validateDocument.Enabled = False
			End If
		End Sub

		Private Sub EditorTextChangedHandler(sender As Object, e As EventArgs)
			Dim ed As C1RibbonEditorXhtml = TryCast(Editor, C1RibbonEditorXhtml)
			If ed IsNot Nothing AndAlso ed.Mode = EditorMode.Source AndAlso Not _isFixing Then
				_validateDocument.Enabled = True
			End If
		End Sub
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function

		#End Region
	End Class
End Namespace
