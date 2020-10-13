Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports C1.Win.C1Ribbon

Namespace RichTextEditor
	Class ReferencesTab
		Inherits C1TextEditorRibbonTab
		Public Sub New()
			Me.ID = InlineAssignHelper(Me.Text, "References")
			Groups.Add(New RibbonGroup("Table of Contents"))
			Groups.Add(New RibbonGroup("Index"))
		End Sub
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function
	End Class
End Namespace
