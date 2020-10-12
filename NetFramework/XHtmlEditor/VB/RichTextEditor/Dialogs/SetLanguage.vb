Imports System.IO
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Globalization
Imports C1.Win.C1SpellChecker

Namespace RichTextEditor
	Public Partial Class SetLanguage
		Inherits Form
		' ** fields
		Private _spellChecker As C1SpellChecker

		' ** ctors
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub New(spellChecker As C1SpellChecker)
			InitializeComponent()

			' save reference to spell checker
			_spellChecker = spellChecker

			' populate list
			_list.Items.Add("Default (built-in English US)")
			For Each fn As String In Directory.GetFiles(Application.StartupPath, "c1spell_*.dct")
				Dim item As Dictionary = New Dictionary(fn)
				If item.IsValid Then
					_list.Items.Add(item)
				End If
			Next

			' select current
			_list.SelectedIndex = 0
			Dim current As String = _spellChecker.MainDictionary.FileName
			If Not String.IsNullOrEmpty(current) Then
				For Each item As Object In _list.Items
					Dim dct As Dictionary = TryCast(item, Dictionary)
					If dct IsNot Nothing AndAlso String.Equals(Path.GetFileName(dct.FileName), Path.GetFileName(current), StringComparison.OrdinalIgnoreCase) Then
						_list.SelectedItem = dct
						Exit For
					End If
				Next
			End If
		End Sub

		' ** event handlers
		Private Sub _btnOK_Click(sender As Object, e As EventArgs)
			' save main dictionary
			Dim dct As Dictionary = TryCast(_list.SelectedItem, Dictionary)
            _spellChecker.MainDictionary.FileName = Util.IIFS(dct IsNot Nothing, dct.FileName, Nothing)
		End Sub

		''' <summary>
		''' Helper class to keep track of dictionary names and languages.
		''' </summary>
		Private Class Dictionary
			Private _fileName As String
			Private _ci As CultureInfo

			Public Sub New(fileName As String)
				_fileName = fileName
				Dim name As String = Path.GetFileNameWithoutExtension(fileName).Substring(8)
				Try
					_ci = New CultureInfo(name)
				Catch
				End Try
            End Sub

			Public ReadOnly Property IsValid() As Boolean
				Get
					Return _ci IsNot Nothing
				End Get
            End Property

			Public ReadOnly Property FileName() As String
				Get
					Return _fileName
				End Get
            End Property

			Public Overloads Overrides Function ToString() As String
				Return _ci.EnglishName
			End Function
		End Class
	End Class
End Namespace
