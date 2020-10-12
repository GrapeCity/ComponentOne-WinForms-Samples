Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles
Imports C1.Win.C1SpellChecker

Partial Public Class SpellDialogWord
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
    Private _sentence As CharRange
    ' sentence that contains the error 
    Private _textChanged As Boolean
    ' user typed into replacement textbox 
    Private _textChangeTo As String
    ' replacement text 
    Private _errorBackColor As Color
    Private _errorForeColor As Color

    ' change all dictionary 
    Private _changeAll As New Dictionary(Of String, String)()

#End Region

    '------------------------------------------------------------------------ 
#Region "** ctor"

    ''' <summary> 
    ''' Initializes a new instance of a <see cref="C1SpellDialog"/>. 
    ''' </summary> 
    Public Sub New()
        InitializeComponent()

        ' change font *after* initializing the form 
        Font = SystemInformation.MenuFont

        ' initialize position of repeated word label 
        _lblRepeatedWord.Location = _lblNotInDictionary.Location

        ' forecolor used to highlight errors 
        _errorForeColor = Color.Red

        ' backcolor used to keep track of the error within the 
        ' sentence shown in the _txtError control 
        ' (just a little different from the regular backcolor) 
        Dim r As Integer = _txtError.BackColor.R
        r = IIf((r = 255), 254, r + 1)
        _errorBackColor = Color.FromArgb(r, _txtError.BackColor.G, _txtError.BackColor.B)
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
    Public Sub Initialize(ByVal spell As C1SpellChecker, ByVal editor As ISpellCheckableEditor, ByVal errors As CharRangeList) Implements C1.Win.C1SpellChecker.ISpellDialog.Initialize
        ' initialize members 
        _spell = spell
        _editor = editor
        _errors = errors

        ' initialize 'change all' list 
        _changeAll.Clear()
        For Each key As String In _spell.AutoReplaceList.Keys
            _changeAll(key) = _spell.AutoReplaceList(key)
        Next

        ' initialize error list 
        If _errors Is Nothing Then
            _errors = _spell.CheckText(_editor.Text)
        End If
        _errorCount += _errors.Count
    End Sub
    ''' <summary> 
    ''' Gets the total number of errors detected in the control. 
    ''' </summary> 
    Public ReadOnly Property ErrorCount() As Integer Implements C1.Win.C1SpellChecker.ISpellDialog.ErrorCount
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
            _textChangeTo = _changeAll(err.Text)
            _btnChange_Click(Me, EventArgs.Empty)
            Return
        End If

        ' show whole sentence, highlight bad word 
        _sentence = GetSentence(_editor.Text, err)
        _txtError.Font = _editor.Control.Font
        _txtError.Text = _sentence.Text
        _txtError.[Select](err.Start - _sentence.Start, err.Length)
        _txtError.SelectionFont = New Font(_txtError.Font, FontStyle.Bold)
        _txtError.SelectionColor = _errorForeColor
        _txtError.SelectionBackColor = _errorBackColor
        _txtError.[Select](_txtError.SelectionStart + _txtError.SelectionLength, 0)

        ' repeated word? 
        If err.Duplicate Then
            ' adjust dialog 
            _lblNotInDictionary.Visible = False
            _lblRepeatedWord.Visible = True
            _btnChange.Text = _lblRemove.Text
            _btnIgnoreAll.Enabled = False
            _btnChangeAll.Enabled = False
            _btnAdd.Enabled = False

            ' no suggestions 
            _listSuggestions.Items.Clear()
        Else
            ' adjust dialog 
            _lblRepeatedWord.Visible = False
            _lblNotInDictionary.Visible = True
            _btnChange.Text = _lblChange.Text
            _btnIgnoreAll.Enabled = True
            _btnChange.Enabled = False
            _btnChangeAll.Enabled = False
            _btnAdd.Enabled = True

            ' show suggestions 
            ShowSuggestions(err.Text)
        End If

        ' focus to new word 
        _txtError.Focus()
        _btnSuggest.Enabled = False
        AcceptButton = _btnIgnore

        ' show 'Add' button only if user dictionary is enabled 
        _btnAdd.Visible = _spell.UserDictionary.Enabled

        ' ready, fire BadWordDetected event 
        Dim e As New BadWordEventArgs(Me, _editor.Control, err, _errors)
        _spell.OnBadWordFound(e)

        ' ignore error on event-handler request 
        If e.Cancel Then
            ErrorIndex += 1
        End If
    End Sub
    Private Function GetSentence(ByVal text As String, ByVal err As CharRange) As CharRange
        ' find sentence start 
        Dim start As Integer = -1
        Dim i As Integer = err.Start
        While i > 0 AndAlso start < 0
            Select Case text(i)
                Case "."c, "!"c, "?"c, Chr(10), Chr(13)
                    For j As Integer = i To err.Start - 1
                        If Char.IsLetterOrDigit(text(j)) Then
                            start = j
                            Exit For
                        End If
                    Next
                    Exit Select
            End Select
            i -= 1
        End While
        If start < 0 Then
            start = 0
        End If

        ' find sentence end 
        Dim [end] As Integer = -1
        i = err.Start
        While i < text.Length AndAlso [end] < 0
            Select Case text(i)
                Case "."c, "!"c, "?"c
                    [end] = i
                    Exit Select
                Case Chr(10), Chr(13)
                    [end] = i - 1
                    Exit Select
            End Select
            i += 1
        End While
        If [end] < 0 Then
            [end] = text.Length - 1
        End If

        ' done, return result 
        Dim sentence As String = text.Substring(start, [end] - start + 1)
        Return New CharRange(sentence, start, False)
    End Function
    Private Function GetReplacement() As CharRange
        Dim start As Integer = -1
        Dim [end] As Integer = -1
        Using _txtError.CreateSelectionContext()
            For i As Integer = 0 To _txtError.Text.Length - 1
                _txtError.[Select](i, 1)
                If _txtError.SelectionBackColor = _errorBackColor Then
                    If start < 0 Then
                        start = i
                    End If
                    [end] = i
                End If
            Next
        End Using
        Return IIf(start > -1, New CharRange(_txtError.Text.Substring(start, [end] - start + 1), start, False), Nothing)
    End Function
    Private Property ReplacementTextChanged() As Boolean
        Get
            Return _textChanged
        End Get
        Set(ByVal value As Boolean)
            _textChanged = value
            _textChangeTo = String.Empty

            If _textChanged Then
                ' update controls 
                _btnIgnore.Text = "&Undo Edit"
                _btnIgnoreAll.Enabled = False
                _btnAdd.Enabled = False
                _btnChange.Enabled = True
                _btnChangeAll.Enabled = True

                _btnSuggest.Enabled = True
                _listSuggestions.Enabled = False

                ' remove error highlight 
                Using _txtError.CreateSelectionContext()
                    _txtError.SelectAll()
                    _txtError.SelectionFont = _editor.Control.Font
                    _txtError.SelectionColor = _txtError.ForeColor
                End Using
            Else
                ' update controls 
                _btnIgnore.Text = "&Ignore Once"
                _btnIgnoreAll.Enabled = True
                _btnAdd.Enabled = True

                _btnSuggest.Enabled = False
                _listSuggestions.Enabled = _listSuggestions.Items.Count > 0
            End If
        End Set
    End Property
    Private Sub ShowSuggestions(ByVal word As String)
        Dim suggestions As String() = _spell.GetSuggestions(word)
        _listSuggestions.Items.Clear()
        If suggestions.Length > 0 Then
            _listSuggestions.Items.AddRange(suggestions)
            _listSuggestions.SelectedIndex = 0
            _listSuggestions.Enabled = True
        Else
            _listSuggestions.Items.Add(_lblNoSuggestions.Text)
            _listSuggestions.SelectedIndex = -1
            _listSuggestions.Enabled = False
        End If
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

        ' show first error (after firing load event) 
        ErrorIndex = 0
    End Sub

    ' update ChangeTo text when a suggestion is selected 
    Private Sub _listSuggestions_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _listSuggestions.SelectedIndexChanged
        If _listSuggestions.SelectedIndex > -1 Then
            _btnChange.Enabled = True
            _btnChangeAll.Enabled = True
            _textChangeTo = _listSuggestions.Text
        End If
    End Sub

    ' move to the next error (ignore the current one) 
    Private Sub _btnIgnore_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnIgnore.Click
        If ReplacementTextChanged Then
            UpdateCurrentError()
        Else
            ErrorIndex += 1
        End If
    End Sub

    ' add current word to the ignore list in the spell-checker 
    Private Sub _btnIgnoreAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnIgnoreAll.Click
        _spell.IgnoreList.Add(CurrentError.Text)
        _errors = _spell.CheckText(_editor.Text)
        UpdateCurrentError()
    End Sub

    ' change current word into 'ChangeTo' value 
    Private Sub _btnChange_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnChange.Click
        ' save starting point to continue checking from here 
        Dim start As Integer = CurrentError.Start

        ' if the user typed into the text error box, handle that 
        Dim replacement As CharRange = Nothing
        If ReplacementTextChanged AndAlso _listSuggestions.Enabled = False Then
            ' get part of the text that replaced the actual error within the sentence 
            replacement = GetReplacement()
            If replacement IsNot Nothing AndAlso replacement.Text.Length > 0 Then
                ' warn if replacement is bad 
                If _spell.CheckText(replacement.Text).Count > 0 Then
                    Dim msg As String = "You have chosen a word that is not in the dictionary." & Chr(13) & "" & Chr(10) & "" + "Do you want to use this word and continue checking?"
                    Dim dr As DialogResult = MessageBox.Show(Me, msg, "Spelling", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If dr = DialogResult.No Then
                        Return
                    End If
                End If

                ' honor ChangeAll button 
                If sender.Equals(_btnChangeAll) Then
                    _changeAll(CurrentError.Text) = replacement.Text
                End If
            End If

            ' replace whole sentence in text 
            _editor.[Select](_sentence.Start, _sentence.Length)
            _editor.SelectedText = _txtError.Text

            ' resume checking from sentence start 
            start = _sentence.Start
        Else
            ' no changes in text, use Suggestion/ChangeAll value stored in _txtChangeTo 
            Dim changeTo As String = _textChangeTo
            If changeTo.Length = 0 Then
                ' if replacement is empty, expand over spaces and commas 
                Dim delete As CharRange = CharRange.ExpandOverWhitespace(_editor.Text, CurrentError)
                _editor.[Select](delete.Start, delete.Text.Length)
            End If

            ' honor ChangeAll button 
            If sender.Equals(_btnChangeAll) Then
                _changeAll(CurrentError.Text) = changeTo
            End If

            ' replace word in text 
            _editor.SelectedText = changeTo
            _errors = _spell.CheckText(_editor.Text)
        End If

        ' re-check 
        _errors = _spell.CheckText(_editor.Text)
        _errorIndex = -1
        For index As Integer = 0 To _errors.Count - 1
            If _errors(index).Start >= start Then
                If replacement Is Nothing OrElse replacement.Text <> _errors(index).Text Then
                    _errorIndex = index
                    Exit For
                End If
            End If
        Next

        ' show the current error 
        UpdateCurrentError()
    End Sub

    ' change all instances of the current word into 'ChangeTo' value 
    Private Sub _btnChangeAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnChangeAll.Click
        _btnChange_Click(Me, e)
    End Sub

    ' add current word to the user dictionary 
    Private Sub _btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnAdd.Click
        _spell.UserDictionary.AddWord(CurrentError.Text)
        _errors = _spell.CheckText(_editor.Text)
        UpdateCurrentError()
    End Sub

    ' update suggestion list with current content 
    Private Sub _btnSuggest_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnSuggest.Click
        _listSuggestions.Items.Clear()
        Dim replacement As CharRange = GetReplacement()
        If replacement IsNot Nothing AndAlso replacement.Text.Length > 0 Then
            ShowSuggestions(replacement.Text)
        End If
        _btnSuggest.Enabled = False
    End Sub

    ' cancel dialog 
    Private Sub _btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    ' double-click selects word and changes it 
    Private Sub _listSuggestions_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles _listSuggestions.DoubleClick
        _btnChange_Click(Me, e)
    End Sub

    ' changing the replacement text enables change buttons 
    Private Sub _txtError_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles _txtError.KeyDown
        ReplacementTextChanged = True
    End Sub

#End Region

    
End Class

''' <summary> 
''' Class that derives from <see cref="RichTextBox"/> to provide a flat border. 
''' </summary> 


Public Class RicherTextBox
    Inherits RichTextBox
    ' ** ctor 
    Public Sub New()
    End Sub

    ' ** preserve selection 
    Public Function CreateSelectionContext() As IDisposable
        Return New SelectionContext(Me)
    End Function
    Private Class SelectionContext
        Implements IDisposable
        Private _tb As RicherTextBox
        Private _start As Integer, _len As Integer
        Private _focus As Boolean

        Public Sub New(ByVal tb As RicherTextBox)
            _tb = tb
            _start = tb.SelectionStart
            _len = tb.SelectionLength
            _focus = tb.Focused
            SetFocus(IntPtr.Zero)
        End Sub
        Private Sub Dispose() Implements IDisposable.Dispose
            _tb.[Select](_start, _len)
            If _focus Then
                _tb.Focus()
            End If
        End Sub
    End Class

    ' ** win32 stuff 
    Protected Overloads Overrides Sub WndProc(ByRef m As Message)
        Const WM_NCPAINT As Integer = 133

        Select Case m.Msg
            Case WM_NCPAINT
                If BorderStyle = BorderStyle.FixedSingle Then
                    ' paint scrollbars 
                    MyBase.WndProc(m)

                    ' paint border 
                    DrawFlatNCBorder(m)

                    ' don't call base.WndProc, we're done. 
                    Return
                End If
                Exit Select
        End Select

        ' allow default processing 
        MyBase.WndProc(m)
    End Sub
    Private Sub DrawFlatNCBorder(ByRef msg As Message)
        Dim hRgn As IntPtr = msg.WParam
        Dim hdc As IntPtr = GetDCEx(msg.HWnd, hRgn, DCX_WINDOW Or DCX_PARENTCLIP Or DCX_INTERSECTRGN)
        If hdc <> IntPtr.Zero Then
            Using g As Graphics = Graphics.FromHdc(hdc)
                MyBase.UpdateBounds()
                Dim r As New Rectangle(0, 0, Width, Height)
                ControlPaint.DrawBorder(g, r, VisualStyleInformation.TextControlBorder, ButtonBorderStyle.Solid)
                r.Inflate(-1, -1)
                ControlPaint.DrawBorder(g, r, BackColor, ButtonBorderStyle.Solid)
            End Using
            msg.Result = CType(1, IntPtr)
            ReleaseDC(msg.HWnd, hdc)
        End If
    End Sub
    <System.Runtime.InteropServices.DllImport("USER32.DLL")> _
    Private Shared Function GetDCEx(ByVal hWnd As IntPtr, ByVal hRgnClip As IntPtr, ByVal flags As UInteger) As IntPtr
    End Function
    <System.Runtime.InteropServices.DllImport("USER32.DLL")> _
    Private Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hdc As IntPtr) As Integer
    End Function
    <System.Runtime.InteropServices.DllImport("USER32.DLL")> _
    Private Shared Function SetFocus(ByVal hWnd As IntPtr) As Integer
    End Function

    Private Const DCX_WINDOW As Integer = 1, DCX_CACHE As Integer = 2, DCX_NORESETATTRS As Integer = 4, DCX_CLIPCHILDREN As Integer = 8, DCX_CLIPSIBLINGS As Integer = 16, DCX_PARENTCLIP As Integer = 32, _
    DCX_EXCLUDERGN As Integer = 64, DCX_INTERSECTRGN As Integer = 128, DCX_EXCLUDEUPDATE As Integer = 256, DCX_INTERSECTUPDATE As Integer = 512, DCX_LOCKWINDOWUPDATE As Integer = 1024, DCX_VALIDATE As Integer = 2097152
End Class