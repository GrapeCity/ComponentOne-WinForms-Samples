Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports Resources = C1Words.Resources

Namespace C1WordsX
	Public Partial Class InsertSymbol
		Inherits Form
		' ** fields
		Private _editor As C1RibbonEditorXhtml
		Private _selectedSymbol As SymbolLabel

		' ** ctor
		Public Sub New()
			InitializeComponent()

			_panel.SuspendLayout()
			For Each line As String In Resources.Symbols_tbl.Split(ControlChars.Cr)
				Dim lbl As SymbolLabel = New SymbolLabel(toolTip1, line.Trim())
				AddHandler lbl.Click, AddressOf lbl_Click
				AddHandler lbl.DoubleClick, AddressOf _btnInsert_Click
				_panel.Controls.Add(lbl)
			Next
			_panel.ResumeLayout()
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

		Private Property SelectedIndex() As Integer
			Get
				Return _panel.Controls.IndexOf(SelectedSymbol)
			End Get
			Set
				value = Math.Min(Math.Max(value, 0), _panel.Controls.Count - 1)
				SelectedSymbol = DirectCast(_panel.Controls(value), SymbolLabel)
			End Set
		End Property
		Private Property SelectedSymbol() As SymbolLabel
			Get
				Return _selectedSymbol
			End Get
			Set
				If _selectedSymbol IsNot value Then
					If _selectedSymbol IsNot Nothing Then
						_selectedSymbol.BackColor = SystemColors.Window
						_selectedSymbol.ForeColor = SystemColors.WindowText
						_lblDescription.Text = String.Empty
					End If

					_selectedSymbol = value

					If _selectedSymbol IsNot Nothing Then
						_selectedSymbol.BackColor = SystemColors.Highlight
						_selectedSymbol.ForeColor = SystemColors.HighlightText
						_lblDescription.Text = _selectedSymbol.Description
						_panel.ScrollControlIntoView(_selectedSymbol)
					End If
				End If
			End Set
		End Property

		' ** implementation
		Private Sub lbl_Click(sender As Object, e As EventArgs)
			SelectedSymbol = TryCast(sender, SymbolLabel)
			_focusBox.Focus()
		End Sub
		Private Sub _btnInsert_Click(sender As Object, e As EventArgs)
			Editor.SelectedText = SelectedSymbol.Text
		End Sub
		Private Sub _focusBox_KeyDown(sender As Object, e As KeyEventArgs)
			Select Case e.KeyCode
				Case Keys.Up
					SelectVertical(-1)
					Exit Select
				Case Keys.Down
					SelectVertical(+1)
					Exit Select
				Case Keys.PageUp
					For i As Integer = 0 To 3
						SelectVertical(-1)
					Next
					Exit Select
				Case Keys.PageDown
					For i As Integer = 0 To 3
						SelectVertical(+1)
					Next
					Exit Select
				Case Keys.Left
					SelectedIndex -= 1
					Exit Select
				Case Keys.Right
					SelectedIndex += 1
					Exit Select
				Case Keys.Home
					SelectedIndex = 0
					Exit Select
				Case Keys.[End]
					SelectedIndex = _panel.Controls.Count - 1
					Exit Select
			End Select
			e.Handled = True
		End Sub
		Private Sub SelectVertical(offset As Integer)
			Dim i As Integer = SelectedIndex + offset
			While i >= 0 AndAlso i < _panel.Controls.Count
				If _panel.Controls(i).Left = SelectedSymbol.Left Then
					SelectedIndex = i
					Exit While
				End If
				i += offset
			End While
		End Sub

		' ** helper class
		Private Class SymbolLabel
			Inherits Label
			Shared _sz As New Size(40, 40)
			Private _description As String

			Public Sub New(tip As ToolTip, symbol As String)
				SetStyle(ControlStyles.Selectable, True)
				DirectCast(Me, Control).TabStop = True

				AutoSize = False
				Size = _sz
				Margin = New Padding(3)

				TextAlign = ContentAlignment.MiddleCenter
				BackColor = SystemColors.Window
				ForeColor = SystemColors.WindowText

				Text = symbol(0).ToString()
				Description = symbol.Substring(2).Trim()
				tip.SetToolTip(Me, Description)
			End Sub
			Public Property Description() As String
				Get
					Return _description
				End Get
				Set
					_description = value
				End Set
			End Property
		End Class
	End Class
End Namespace
