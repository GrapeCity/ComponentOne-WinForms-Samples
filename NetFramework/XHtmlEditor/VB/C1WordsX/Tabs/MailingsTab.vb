Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports C1.Win.C1Ribbon

Namespace C1WordsX
	Class MailingsTab
		Inherits C1TextEditorRibbonTab
		Public Sub New()
			Me.ID = InlineAssignHelper(Me.Text, "Mailings")
			Groups.Add(New RibbonGroup("Create"))
			Groups.Add(New RibbonGroup("Start Mail Merge"))
			Groups.Add(New RibbonGroup("Write && Insert Fields"))
			Groups.Add(New RibbonGroup("Preview Results"))
			Groups.Add(New RibbonGroup("Finish"))
		End Sub
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function
	End Class
End Namespace
