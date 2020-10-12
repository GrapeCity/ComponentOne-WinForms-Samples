Imports System.ComponentModel
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Editor.UICustomization
Imports Resources = CustomDialogs.Resources

''' <summary>
''' Represents a form for editing bookmark properties.
''' </summary>
Friend Partial Class BookmarkEditorForm
	Inherits BaseEditorForm
	Implements IBookmarkItemDialog
	#Region "ctors"

	Public Sub New()
		InitializeComponent()

		AddHandler _tbName.TextChanged, New EventHandler(AddressOf ButtonOKEnabledChanged)

		Dim render As New ToolStripProfessionalRenderer()
		render.RoundedEdges = False
		_toolStrip.Renderer = render
		AddHandler _toolStrip.ItemClicked, New ToolStripItemClickedEventHandler(AddressOf _toolStrip_ItemClicked)

		_tree.ImageList = New ImageList()
		_tree.ImageList.ColorDepth = ColorDepth.Depth32Bit
		_tree.ImageList.Images.Add(Resources.bookmark)
		AddHandler _tree.AfterSelect, New TreeViewEventHandler(AddressOf _tree_AfterSelect)
		AddHandler _tree.KeyDown, New KeyEventHandler(AddressOf _tree_KeyDown)
		AddHandler _tree.DoubleClick, New EventHandler(AddressOf _tree_DoubleClick)

		AddHandler _panel.Paint, New PaintEventHandler(AddressOf PaintBorder)
	End Sub

	#End Region

	#Region "implementation"

	Private ReadOnly Property Item() As XHTMLBookmarkItem
		Get
			Return TryCast(_item, XHTMLBookmarkItem)
		End Get
	End Property

	Private Sub LoadBookmarks()
		_tree.Nodes.Clear()
		For Each bookmark As Bookmark In Item.Bookmarks
			Dim node As TreeNode = _tree.Nodes.Add(bookmark.Name)
			node.Tag = bookmark
		Next
		UpdateToolbarState()
	End Sub

	Private Sub UpdateToolbarState()
		Dim enabled As Boolean = _tree.SelectedNode IsNot Nothing
		_btnRemove.Enabled = enabled
		_btnGoTo.Enabled = enabled
	End Sub

	Private Sub RemoveBookmark(node As TreeNode)
		If node Is Nothing Then
			Return
        End If

        Dim bookmark As Bookmark = TryCast(node.Tag, Bookmark)
        Dim isSelected As Boolean = bookmark.IsSelected
        bookmark.Remove()
        _tree.Nodes.Remove(node)
        If isSelected Then
            If _tree.Nodes.Count = 0 Then
                _tbName.Text = ""
            ElseIf Not _tree.SelectedNode Is Nothing Then
                GotoBookmark(_tree.SelectedNode)
            End If
        End If
        UpdateToolbarState()
        ButtonOKEnabledChanged(Me, EventArgs.Empty)
    End Sub

	Private Sub GotoBookmark(node As TreeNode)
		If node Is Nothing Then
			Return
        End If

        Dim bookmark As Bookmark = TryCast(node.Tag, Bookmark)
        bookmark.Select()
        _tbName.Text = bookmark.Name
	End Sub

	#End Region

	#Region "#event handlers"

	Private Sub _toolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
		If e.ClickedItem Is _btnRemove Then
			RemoveBookmark(_tree.SelectedNode)
		ElseIf e.ClickedItem Is _btnGoTo Then
			GotoBookmark(_tree.SelectedNode)
		End If
	End Sub

	Private Sub _tree_KeyDown(sender As Object, e As KeyEventArgs)
		If e.Modifiers <> Keys.None Then
			Return
		End If
		Select Case e.KeyCode
			Case Keys.Delete
				_btnRemove.PerformClick()
				Exit Select
			Case Keys.Enter
				_btnGoTo.PerformClick()
				Exit Select
		End Select
	End Sub

	Private Sub _tree_DoubleClick(sender As Object, e As EventArgs)
		_btnGoTo.PerformClick()
	End Sub

	Private Sub ButtonOKEnabledChanged(sender As Object, e As EventArgs)
		_btnOK.Enabled = _btnAplly.Visible OrElse Not String.IsNullOrEmpty(_tbName.Text.Trim()) OrElse HaveDeletedBookmarks()
	End Sub

	Private Sub _tree_AfterSelect(sender As Object, e As TreeViewEventArgs)
		UpdateToolbarState()
	End Sub

	Protected Overloads Overrides Sub ApllyClick(sender As Object, e As EventArgs)
		ApplyChanges(False)
	End Sub

	Protected Overloads Overrides Sub OnFormClosing(e As FormClosingEventArgs)
		If DialogResult = DialogResult.OK AndAlso Not ApplyChanges(True) Then
			e.Cancel = True
		End If
		MyBase.OnFormClosing(e)
	End Sub

	Private Function HaveDeletedBookmarks() As Boolean
		For i As Integer = Item.Bookmarks.Count - 1 To 0 Step -1
			If Item.Bookmarks(i).IsRemoved Then
				Return True
			End If
		Next
		Return False
	End Function

	Private Function ApplyChanges(checkCurrentBookmarkOnly As Boolean) As Boolean
		Try
			If checkCurrentBookmarkOnly Then
				Item.CheckCurrentBookmark()
				Return True
			End If
			Item.ApplyChanges()
			If Not [String].IsNullOrEmpty(_tbName.Text) Then
				For Each node As TreeNode In _tree.Nodes
					Dim bookmark As Bookmark = TryCast(node.Tag, Bookmark)
					If bookmark.IsSelected AndAlso [String].Compare(node.Text, _tbName.Text) <> 0 Then
						node.Text = _tbName.Text
					End If
				Next
			End If
			Focus()
			Return True
		Catch generatedExceptionName As InvalidBookmarkNameException
			MessageBox.Show(Me, Resources.sInvalidBookmarkName, Resources.sApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Return False
		Catch generatedExceptionName As ExistingBookmarkException
			MessageBox.Show(Me, Resources.sBookmarkExists, Resources.sApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Return False
		Catch
			Throw
		End Try
	End Function

	#End Region

	#Region "IBookmarkItemDialog Members"

	''' <summary>
	''' Binds data from the item to GUI controls on the form.
	''' Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
	''' to read data from the item and write it back.
	''' </summary>
	''' <param name="item">The item to be bound to the GUI controls.</param>
	Private Sub IBookmarkItemDialog_BindData(item__1 As XHTMLBookmarkItem) Implements IBookmarkItemDialog.BindData
		_item = item__1
		_tbName.DataBindings.Add("Text", Item, "Name")
		LoadBookmarks()
		ButtonOKEnabledChanged(Me, EventArgs.Empty)
	End Sub

	''' <summary>
	''' Shows the form with the specified owner to the user.
	''' </summary>
	''' <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
	''' the top-level window that will own this form.</param>
	''' <returns>True if the form was displayed successfully and the item was changed.</returns>
	Private Function IBookmarkItemDialog_Show(owner As IWin32Window) As Boolean Implements IBookmarkItemDialog.Show
		Return Show(owner)
	End Function

	#End Region
End Class


