Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.SpellChecker

Partial Public Class SpellDialog
    Inherits Form
    Implements ISpellDialog
    '------------------------------------------------------------------------ 
#Region "** fields"

    Private _spell As C1SpellChecker
    ' spell-checker to use 
    Private _editor As ISpellCheckableEditor
    ' generic wrapper for editor 
    Private _errors As CharRangeList
    ' current error list 
    Private _errorIndex As Integer = -1
    ' current error index 
    Private _errorCount As Integer
    ' error count 
    Private _changeAll As New Dictionary(Of String, String)()

    ''' <summary> 
    ''' Event that fires when the <see cref="C1SpellDialog"/> displays an error 
    ''' to the user. 
    ''' </summary> 
    ''' <remarks> 
    ''' You can use the <see cref="ErrorIndex"/> and <see cref="Errors"/> properties 
    ''' to display information about the error in a status bar. 
    ''' </remarks> 
    Public Event ErrorDisplayed As EventHandler

#End Region

    '------------------------------------------------------------------------ 
#Region "** ctor"

    ''' <summary> 
    ''' Initializes a new instance of a <see cref="C1SpellDialog"/>. 
    ''' </summary> 
    Public Sub New()
        InitializeComponent()
        Font = SystemInformation.MenuFont
    End Sub

#End Region

    '------------------------------------------------------------------------ 
#Region "** object model"

    ''' <summary> 
    ''' Initializes the dialog to use the given parameters. 
    ''' </summary> 
    ''' <param name="spell"><see cref="C1SpellChecker"/> to use for spelling.</param> 
    ''' <param name="editor"><see cref="ISpellCheckableEditor"/> that contains the text to spell-check.</param> 
    ''' <param name="errors"><see cref="CharRangeList"/> that contains the initial error list.</param> 
    Public Sub Initialize(ByVal spell As C1SpellChecker, ByVal editor As ISpellCheckableEditor, ByVal errors As CharRangeList) Implements C1.Win.SpellChecker.ISpellDialog.Initialize
        _spell = spell
        _editor = editor
        _errors = errors
        If _errors Is Nothing Then
            _errors = _spell.CheckText(_editor.Text)
        End If
        _errorCount += _errors.Count
    End Sub
    ''' <summary> 
    ''' Gets the total number of errors detected in the control. 
    ''' </summary> 
    Public ReadOnly Property ErrorCount() As Integer Implements C1.Win.SpellChecker.ISpellDialog.ErrorCount
        Get
            Return _errorCount
        End Get
    End Property
    ''' <summary> 
    ''' Gets a <see cref="CharRangeList"/> object with all the errors detected by the 
    ''' <see cref="C1SpellChecker"/> component that owns the dialog. 
    ''' </summary> 
    Public ReadOnly Property Errors() As CharRangeList
        Get
            Return _errors
        End Get
    End Property
    ''' <summary> 
    ''' Gets or sets the index of the current error into the <see cref="Errors"/> list. 
    ''' </summary> 
    Public Property ErrorIndex() As Integer
        Get
            Return _errorIndex
        End Get
        Set(ByVal value As Integer)
            _errorIndex = value
            UpdateCurrentError()
        End Set
    End Property
    ''' <summary> 
    ''' Gets the <see cref="CharRange"/> object that represents the error currently 
    ''' displayed in the dialog. 
    ''' </summary> 
    Public ReadOnly Property CurrentError() As CharRange
        Get
            Return _errors(_errorIndex)
        End Get
    End Property
    ''' <summary> 
    ''' Raises the <see cref="ErrorDisplayed"/> event. 
    ''' </summary> 
    ''' <param name="e"><see cref="EventArgs"/> that contains the event data.</param> 
    Protected Overridable Sub OnErrorDisplayed(ByVal e As EventArgs)
        RaiseEvent ErrorDisplayed(Me, e)
    End Sub

#End Region

    '------------------------------------------------------------------------ 
#Region "** private stuff"

    ' update dialog to show current error 
    Private Sub UpdateCurrentError()
        ' design time 
        If DesignMode OrElse _errors Is Nothing Then
            Return
        End If

        ' finished with this batch of errors 
        If ErrorIndex >= _errors.Count Then
            ' check whether the editor has more text to check 
            While _editor.HasMoreText()
                _errors = _spell.CheckText(_editor.Text)
                If _errors.Count > 0 Then
                    _errorCount += _errors.Count
                    ErrorIndex = 0
                    Return
                End If
            End While

            ' editor has no more text... 
            DialogResult = DialogResult.OK
            Return
        End If

        ' update current error 
        Dim err As CharRange = CurrentError

        ' select word in editor 
        _editor.[Select](err.Start, err.Text.Length)

        ' honor 'change all' list 
        If _changeAll.ContainsKey(err.Text) Then
            _txtChangeTo.Text = _changeAll(err.Text)
            _btnChange_Click(Me, EventArgs.Empty)
            Return
        End If

        ' show bad word, new text 
        _txtError.Text = err.Text
        _txtChangeTo.Text = String.Empty

        ' repeated word? 
        If err.Duplicate Then
            ' adjust dialog 
            _lblNotInDictionary.Visible = False
            _lblRepeatedWord.Visible = True
            _btnIgnoreAll.Enabled = False
            _btnChangeAll.Enabled = False
            _btnAdd.Enabled = False

            ' no suggestions 
            _listSuggestions.Items.Clear()
        Else
            ' adjust dialog 
            _lblRepeatedWord.Visible = False
            _lblNotInDictionary.Visible = True
            _btnIgnoreAll.Enabled = True
            _btnChangeAll.Enabled = True
            _btnAdd.Enabled = True

            ' show suggestions 
            Dim suggestions As String() = _spell.GetSuggestions(err.Text)
            _listSuggestions.Items.Clear()
            If suggestions.Length > 0 Then
                _listSuggestions.Items.AddRange(suggestions)
                _listSuggestions.SelectedIndex = 0
            Else
                _listSuggestions.Items.Add(_lblNoSuggestions.Text)
                _listSuggestions.SelectedIndex = -1
            End If
        End If

        ' focus to new word 
        _txtChangeTo.SelectAll()
        _txtChangeTo.Focus()
        _btnSuggest.Enabled = False
        AcceptButton = _btnIgnore

        ' show 'Add' button only if user dictionary is enabled 
        _btnAdd.Visible = _spell.UserDictionary.Enabled

        ' all ready, fire ErrorDisplayed event 
        OnErrorDisplayed(EventArgs.Empty)
    End Sub
#End Region

    '------------------------------------------------------------------------ 
#Region "** event handlers"

    ''' <summary> 
    ''' Raises the <see cref="Form.Load"/> event. 
    ''' </summary> 
    ''' <param name="e"><see cref="EventArgs"/> that contains the event data.</param> 
    Protected Overloads Overrides Sub OnLoad(ByVal e As EventArgs)
        ' fire load event 
        MyBase.OnLoad(e)

        ' initialize position of 'repeated word' label 
        _lblRepeatedWord.Location = _lblNotInDictionary.Location

        ' show first error (after firing load event) 
        ErrorIndex = 0
    End Sub

    ' update ChangeTo text when a suggestion is selected 
    Private Sub _listSuggestions_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _listSuggestions.SelectedIndexChanged
        _txtChangeTo.Text = IIf(_listSuggestions.Text = _lblNoSuggestions.Text, String.Empty, _listSuggestions.Text)
    End Sub

    ' move to the next error (ignore the current one) 
    Private Sub _btnIgnore_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnIgnore.Click
        ErrorIndex += 1
    End Sub

    ' add current word to the ignore list in the spell-checker 
    Private Sub _btnIgnoreAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnIgnoreAll.Click
        _spell.IgnoreList.Add(CurrentError.Text)
        _errors = _spell.CheckText(_editor.Text, CurrentError.Start)
        UpdateCurrentError()
    End Sub

    ' change current word into 'ChangeTo' value 
    Private Sub _btnChange_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnChange.Click
        ' save starting point to continue checking from here 
        Dim start As Integer = CurrentError.Start

        ' get replacement text 
        Dim replacement As String = _txtChangeTo.Text
        If replacement.Length = 0 Then
            ' if replacement is empty, expand over spaces and commas 
            Dim delete As CharRange = CharRange.ExpandOverWhitespace(_editor.Text, CurrentError)
            _editor.[Select](delete.Start, delete.Text.Length)
        End If

        ' replace word in text and re-check 
        _editor.SelectedText = replacement
        _errors = _spell.CheckText(_editor.Text, start)

        ' update index 
        ErrorIndex = 0
    End Sub

    ' change all instances of the current word into 'ChangeTo' value 
    Private Sub _btnChangeAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnChangeAll.Click
        _changeAll(CurrentError.Text) = _txtChangeTo.Text
        _btnChange_Click(Me, e)
    End Sub

    ' add current word to the user dictionary 
    Private Sub _btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnAdd.Click
        _spell.UserDictionary.AddWord(CurrentError.Text)
        _errors = _spell.CheckText(_editor.Text, CurrentError.Start)
        ErrorIndex = 0
    End Sub

    ' update suggestion list with current content 
    Private Sub _btnSuggest_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnSuggest.Click
        _listSuggestions.Items.Clear()
        _listSuggestions.Items.AddRange(_spell.GetSuggestions(_txtChangeTo.Text))
    End Sub

    ' disable ChangeAll button when deleting words 
    Private Sub _txtChangeTo_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _txtChangeTo.TextChanged
        ' update button status 
        If _txtChangeTo.Text.Length > 0 Then
            ' update change buttons 
            _btnChange.Text = _lblChange.Text
            _btnChangeAll.Enabled = Not CurrentError.Duplicate

            ' update suggest button 
            Dim text As String = _txtChangeTo.Text
            If text.IndexOf(" "c) < 0 AndAlso Not _listSuggestions.Items.Contains(text) Then
                Dim enable As Boolean = True
                Dim i As Integer = 0
                While i < text.Length AndAlso enable
                    If Not Char.IsLetterOrDigit(text, i) AndAlso text(i) <> "'"c Then
                        enable = False
                    End If
                    i += 1
                End While
                _btnSuggest.Enabled = enable
            End If

            ' indicate whether current text is valid 
            _txtChangeTo.ForeColor = IIf(_spell.CheckText(_txtChangeTo.Text).Count = 0, SystemColors.WindowText, Color.DarkRed)
        Else
            _btnChange.Text = _lblRemove.Text
            _btnChangeAll.Enabled = False
            _btnSuggest.Enabled = False
            _txtChangeTo.ForeColor = SystemColors.WindowText
        End If

        ' change default button 
        AcceptButton = _btnChange
    End Sub

    ' cancel dialog 
    Private Sub _btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    ' double-click selects word and changes it 
    Private Sub _listSuggestions_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        If _txtChangeTo.Text = _listSuggestions.Text Then
            _btnChange_Click(Me, e)
        End If
    End Sub

#End Region


End Class