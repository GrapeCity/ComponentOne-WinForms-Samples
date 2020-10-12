Imports System.ComponentModel
Imports System.Windows.Forms
Imports C1.Win.C1Editor.UICustomization

''' <summary>
''' Represents a Find/Replace dialog.
''' </summary>
Friend Partial Class FindReplaceForm
	Inherits Form
	Implements IFindReplaceDialog
	#Region "declarations"

	Private _currentControl As FindOptions
	Private _support As FindReplaceSupport

	#End Region

	#Region "ctors"

	Public Sub New()
		InitializeComponent()
		ShowInTaskbar = False
		Font = SystemInformation.MenuFont

        AddHandler _findOption.ButtonCloseClick, AddressOf CloseForm

        AddHandler _replaceOption.ButtonCloseClick, AddressOf CloseForm
        AddHandler _findOption.ButtonFindNextClick, AddressOf FindNext
        AddHandler _replaceOption.ButtonFindNextClick, AddressOf FindNext
        AddHandler _replaceOption.ButtonReplaceClick, AddressOf Replace
        AddHandler _replaceOption.ButtonReplaceAllClick, AddressOf ReplaceAll
    End Sub

	#End Region

	#Region "implementation"

	Private Sub SetFindReplaceOptions()
		_support.SearchUp = _currentControl.SearchUp
		_support.MatchWholeWord = _currentControl.MatchWholeWord
		_support.MatchCase = _currentControl.MatchCase
		_support.SearchPattern = _currentControl.SearchPattern
		_support.ReplacePattern = _replaceOption.ReplacePattern
	End Sub

    Private Sub FindNext(ByVal sender As Object, ByVal e As EventArgs)
        SetFindReplaceOptions()
        _support.FindNext()
    End Sub

    Private Sub Replace(ByVal sender As Object, ByVal e As EventArgs)
        SetFindReplaceOptions()
        _support.Replace()
    End Sub

    Private Sub CloseForm(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub ReplaceAll(ByVal sender As Object, ByVal e As EventArgs)
        SetFindReplaceOptions()
        _support.ReplaceAll()
    End Sub

	Private Sub ChangeMode(sender As Object, e As EventArgs)
		If _tbcFindReplace.SelectedIndex = 0 Then
			_currentControl = _findOption
			_currentControl.MatchCase = _replaceOption.MatchCase
			_currentControl.MatchWholeWord = _replaceOption.MatchWholeWord
			_currentControl.SearchUp = _replaceOption.SearchUp
			_currentControl.SearchPattern = _replaceOption.SearchPattern
		Else
			_currentControl = _replaceOption
			_currentControl.MatchCase = _findOption.MatchCase
			_currentControl.MatchWholeWord = _findOption.MatchWholeWord
			_currentControl.SearchUp = _findOption.SearchUp
			_currentControl.SearchPattern = _findOption.SearchPattern
		End If

		_currentControl.SetActiveControl()
		AcceptButton = _currentControl.AcceptButton
		CancelButton = _currentControl.CancelButton
	End Sub

	Private Sub SetMode(startWithFindDialog As Boolean, init As Boolean)
		Dim needToChange As Boolean = _tbcFindReplace.SelectedIndex = 0 <> startWithFindDialog
		If needToChange Then

            If startWithFindDialog Then
                _tbcFindReplace.SelectedIndex = 0
            Else
                _tbcFindReplace.SelectedIndex = 1
            End If

        End If

        If needToChange OrElse init Then
            ChangeMode(Me, EventArgs.Empty)
        End If
	End Sub

	Protected Overloads Overrides Sub OnShown(e As EventArgs)
		_currentControl.SetActiveControl()
		Focus()
		MyBase.OnShown(e)
	End Sub

	#End Region

	#Region "IFindReplaceDialog Members"

	''' <summary>
	''' Binds data from the item to GUI controls on the form.
	''' Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
	''' to read data from the item and write it back.
	''' </summary>
	''' <param name="item">The item to be bound to the GUI controls.</param>
	Private Sub IFindReplaceDialog_BindData(support As FindReplaceSupport) Implements IFindReplaceDialog.BindData
		_support = support
		_findOption.SearchPattern = support.SearchPattern
		_replaceOption.SearchPattern = support.SearchPattern
	End Sub

	''' <summary>
	''' Shows the form with the specified owner to the user.
	''' </summary>
	''' <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
	''' the top-level window that will own this form.</param>
	''' <returns>True if the form was displayed successfully and the item was changed.</returns>
	Private Sub IFindReplaceDialog_Show(owner As IWin32Window, startWithFindDialog As Boolean) Implements IFindReplaceDialog.Show
		If Not Visible Then
			SetMode(startWithFindDialog, True)
			Show(owner)
		Else
			SetMode(startWithFindDialog, False)
			Activate()
		End If

	End Sub

	#End Region
End Class
