Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports C1.Win.C1Ribbon

Namespace RichTextEditor
	Class ReviewTab
		Inherits C1TextEditorRibbonTab
		'---------------------------------------------------------------------------
		#Region "** create tab"

		Public Sub New()
			Me.ID = InlineAssignHelper(Me.Text, "Review")
            Groups.Add(CreateProofingGroup())
		End Sub
		Private Function CreateProofingGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Proofing")
			g.HasLauncherButton = True
			g.Items.Add(CreateButton("Spelling"))
			g.Items.Add(CreateToggleButton("ShowErrors"))
			g.Items.Add(CreateButton("SetLanguage"))
			g.Items.Add(CreateButton("WordCount"))
			Return g
		End Function
		Private Function CreateCompareGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Compare")
			g.Items.Add(CreateButton("Compare"))
			g.Items.Add(CreateButton("CompareVersions"))
			Return g
		End Function
		Private Function CreateProtectGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Protect")
			g.Items.Add(CreateButton("Protect"))
			Return g
		End Function

		#End Region

		'---------------------------------------------------------------------------
		#Region "** handle commands"

		Friend Overloads Overrides Sub HandleItemEvent(e As RibbonEventArgs)
			Dim item As RibbonItem = DirectCast(e.Item, RibbonItem)
			If e.EventType = RibbonEventType.Click Then
				Select Case item.ID
					Case "Spelling"
						Ribbon.SpellCheck()
						Exit Select
					Case "ShowErrors"
						Ribbon.SetActiveSpellChecking(DirectCast(item, RibbonToggleButton).Pressed)
						Exit Select
					Case "SetLanguage"
						Ribbon.SetSpellingLanguage()
						Exit Select
					Case "WordCount"
						Using dlg As WordCount = New WordCount(Editor.Text)
							dlg.Font = Ribbon.Font
							dlg.ShowDialog()
						End Using
						Exit Select
				End Select
			End If
		End Sub
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function

		#End Region
	End Class
End Namespace
