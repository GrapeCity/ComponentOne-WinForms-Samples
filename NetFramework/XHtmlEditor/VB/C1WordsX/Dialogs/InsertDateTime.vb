Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace C1WordsX
	Public Partial Class InsertDateTime
		Inherits Form
		' ** fields
		Private _editor As C1RibbonEditorXhtml

		' ** ctor
		Public Sub New()
			InitializeComponent()

			Dim formats As String() = New String() {"MMMM dd, yyyy", "M/d/yyyy", "yyyy-MM-dd", "dd-MMM-yy", "M.d.yyyy", "MMM. d, yy", _
				"d MMMM yyyy", "MMMM yy", "MMM-yy", "M/d/yyyy h:mm tt", "M/d/yyyy h:mm:ss tt", "h:mm:ss tt", _
				"H:mm", "H:mm:ss"}

			' show current time
			Dim now As DateTime = DateTime.Now

			' clear list
			_list.Items.Clear()

			' predefined formats
			_list.Items.Add(now.ToShortDateString())
			_list.Items.Add(now.ToLongDateString())
			_list.Items.Add(now.ToShortTimeString())
			_list.Items.Add(now.ToLongTimeString())

			' custom formats
			For Each fmt As String In formats
				_list.Items.Add(now.ToString(fmt))
			Next

			' select first item
			_list.SelectedIndex = 0

			' select item on double-click
			AddHandler _list.DoubleClick, AddressOf _btnInsert_Click
		End Sub


		' ** object model
		Public Overloads Function ShowDialog(editor As C1RibbonEditorXhtml) As DialogResult
			_editor = editor
			Return ShowDialog()
        End Function

		Private ReadOnly Property Editor() As C1RibbonEditorXhtml
			Get
				Return _editor
			End Get
		End Property

		' ** event handlers
		Private Sub _btnInsert_Click(sender As Object, e As EventArgs)
			If _list.SelectedIndex > -1 AndAlso Editor IsNot Nothing Then
				Editor.SelectedText = _list.Text
				DialogResult = DialogResult.OK
			End If
		End Sub
	End Class
End Namespace
