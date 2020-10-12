Imports System.IO
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Text
Imports C1.Win.C1Ribbon

Imports Resources = C1Words.Resources
Imports Settings = C1Words.Properties.Settings

Namespace C1WordsX
	''' <summary>
	''' Class that handles the recently used document list.
	''' Manages the list that appears in the application's main menu,
	''' including persistence to the settings file.
	''' </summary>
	Class RecentDocumentList
		Private _ribbon As C1TextEditorRibbon
		Const TOP_INDEX As Integer = 2
		Const MAX_ITEMS As Integer = 10

		' Initializes a new instance of a RecentDocumentList.
		Public Sub New(ribbon As C1TextEditorRibbon)
			' save reference to parent ribbon
			_ribbon = ribbon

			' create header
			Dim header As RibbonListItem = C1TextEditorRibbonTab.CreateHeader("RecentDocuments")

			' add header and separator
			Items.Clear()
			Items.Add(header)
			Items.Add(New RibbonListItem(New RibbonSeparator()))

			' add documents saved in settings file
			RecentDocuments = Settings.[Default].RecentDocuments
		End Sub

		' gets the items that show the recent documents.
		Public ReadOnly Property Items() As RibbonItemCollection
			Get
				Return _ribbon.ApplicationMenu.RightPaneItems
			End Get
		End Property

		' add a document to the MRU list
		Public Sub AddDocument(fileName As String)
			' look for the file in the current list
			Dim doc As RecentDocumentItem = FindDocumentByName(fileName)
			If doc IsNot Nothing Then
				' already a member of the list: move to top
				If Items.IndexOf(doc) > TOP_INDEX Then
					Items.Remove(doc)
					Items.Insert(TOP_INDEX, doc)
				End If
			ElseIf Not String.IsNullOrEmpty(fileName) Then
				' not a member, add at the top
				Items.Insert(TOP_INDEX, New RecentDocumentItem(fileName, False))
			End If

			' trim list
			While Items.Count > MAX_ITEMS
				If Not RemoveBottomItem() Then
					Exit While
				End If
			End While
		End Sub

		' remove a document from the MRU
		Public Sub RemoveDocument(fileName As String)
			' look for the file in the current list
			Dim doc As RecentDocumentItem = FindDocumentByName(fileName)
			If doc IsNot Nothing Then
				Items.Remove(doc)
			End If
		End Sub

		' find a document on the list by its name.
		Private Function FindDocumentByName(fileName As String) As RecentDocumentItem
			For Each item As RibbonItem In Items
				Dim doc As RecentDocumentItem = TryCast(item, RecentDocumentItem)
				If doc IsNot Nothing AndAlso String.Equals(doc.FileName, fileName, StringComparison.OrdinalIgnoreCase) Then
					Return doc
				End If
			Next
			Return Nothing
		End Function

		' remove unpinned items from the bottom of the list
		Private Function RemoveBottomItem() As Boolean
			For i As Integer = Items.Count - 1 To TOP_INDEX Step -1
				Dim doc As RecentDocumentItem = TryCast(Items(i), RecentDocumentItem)
				If doc IsNot Nothing AndAlso Not doc.Pinned Then
					Items.RemoveAt(i)
					Return True
				End If
			Next
			Return False
		End Function

		' get or set the list of recent documents.
		Public Property RecentDocuments() As StringCollection
			Get
				Dim list As StringCollection = New StringCollection()
				For Each item As Object In Items
					Dim doc As RecentDocumentItem = TryCast(item, RecentDocumentItem)
					If doc IsNot Nothing AndAlso Not String.IsNullOrEmpty(doc.FileName) Then
						Dim fileName As String = doc.FileName
						If doc.Pinned Then
							' append a '*' to indicate the document is pinned
							fileName += "*"
						End If
						list.Add(fileName)
					End If
				Next
				Return list
			End Get
			Set
				' remove old items (keep title and separator)
				While Items.Count > TOP_INDEX
					Items.RemoveAt(TOP_INDEX)
				End While

				' add new items
				If value IsNot Nothing Then
					For Each entry As String In value
						Dim fileName As String = entry
						Dim pinned As Boolean = False
						If entry.EndsWith("*") Then
							fileName = fileName.TrimEnd("*"C)
							pinned = True
						End If
						If File.Exists(fileName) Then
							Items.Add(New RecentDocumentItem(fileName, pinned))
						End If
					Next
				End If
			End Set
		End Property
	End Class

	''' <summary>
	''' Represents each item in the most recently used documents list.
	''' </summary>
	Class RecentDocumentItem
		Inherits RibbonListItem
		Private _fileName As String
		Private _label As RibbonLabel
		Private _pin As RibbonToggleButton

		Public Sub New(fileName As String, pinned As Boolean)
			' save file name
			_fileName = fileName

			' initialize label and pin
			_label = New RibbonLabel(Path.GetFileName(fileName))
			_pin = New RibbonToggleButton()
			_pin.AllowSelection = True
			_pin.SmallImage = Resources.Unpinned
			AddHandler _pin.PressedChanged, AddressOf pin_PressedChanged
			_pin.Pressed = pinned

			' populate this element
			Items.Add(_label)
			Items.Add(_pin)
			ToolTip = fileName
		End Sub
        Private Sub pin_PressedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _pin.Pressed Then
                _pin.SmallImage = Resources.Pinned
            Else
                _pin.SmallImage = Resources.Unpinned
            End If
        End Sub
		Public ReadOnly Property FileName() As String
			Get
				Return _fileName
			End Get
		End Property
		Public ReadOnly Property Pinned() As Boolean
			Get
				Return _pin.Pressed
			End Get
		End Property
	End Class
End Namespace
