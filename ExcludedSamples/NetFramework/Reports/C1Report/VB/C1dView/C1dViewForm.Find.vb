Imports System
Imports System.ComponentModel
Imports C1.C1Preview
Imports C1.C1Report
Imports C1.Win.C1Preview
Imports C1.Win.C1Ribbon
Imports C1.Win.C1Command

Partial Public Class C1dViewForm

    ''' <summary>
    ''' Instance of the helper class providing text search functionality.
    ''' </summary>
    Protected Property FindHelper As FindHelper

    ''' <summary>
    ''' Initializes text search functionality.
    ''' </summary>
    Protected Sub InitFind()
        Me.FindHelper = New FindHelper(PreviewPane)
        '' wire up 'find' command:
        AddHandler Me.cmdFind.Click, New ClickEventHandler(AddressOf cmdFind_Click)
        AddHandler Me.cmdFind.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy AndAlso PreviewPane.Pages.Count > 0
        AddHandler Me.cmdFind.EnabledChanged, Sub(s, e) Me.rbtnFind.Enabled = Me.cmdFind.Enabled
        '' wire up 'find next' command:
        AddHandler Me.cmdFindNext.Click, Sub(s, e) FindNext(False)
        AddHandler Me.cmdFindNext.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy AndAlso PreviewPane.Pages.Count > 0 AndAlso Not String.IsNullOrEmpty(rtbFindText.Text)
        AddHandler Me.cmdFindNext.EnabledChanged, Sub(s, e) Me.rbtnFindAgain.Enabled = Me.cmdFind.Enabled
        '' wire up find text bar's controls:
        AddHandler Me.rbtnFindClose.Click, New EventHandler(AddressOf rbtnFindClose_Click)
        AddHandler Me.rtbFindText.TextChanged, New EventHandler(AddressOf rtbFindText_TextChanged)
        AddHandler Me.rtbFindText.KeyPress, New KeyPressEventHandler(AddressOf rtbFindText_KeyPress)
        AddHandler Me.rbtnFindMatchCase.PressedChanged, New EventHandler(AddressOf rtbFindText_TextChanged)
        AddHandler Me.rbtnFindNext.Click, Sub(s, e) FindNext(False)
        AddHandler Me.rbtnFindPrev.Click, Sub(s, e) FindNext(True)
        '' ensure consistent initial state:
        FindSetButtonsState(False, False)
    End Sub

    ''' <summary>
    ''' Finds the next occurrence of the search text in the specified direction.
    ''' </summary>
    ''' <param name="up">Direction: true to search up, false to search down.</param>
    Private Sub FindNext(ByVal up As Boolean)
        FindAdjustDisplay(FindHelper.FindNext(Me.rtbFindText.Text, Me.rbtnFindMatchCase.Pressed, up))
    End Sub

    ''' <summary>
    ''' Adjusts the visual cues and state of the controls associated with the find text functionality
    ''' depending on whether a search was successful or not.
    ''' </summary>
    ''' <param name="success">True for successful search, false otherwise.</param>
    Private Sub FindAdjustDisplay(ByVal success As Boolean)
        If (success) Then
            Me.rtbFindText.ForeColorTextBox = SystemColors.ControlText
        Else
            Me.rtbFindText.ForeColorTextBox = Color.Red
            PreviewPane.SelectionClear()
        End If
        FindSetButtonsState(True, success)
    End Sub

    ''' <summary>
    ''' Sets the visibility and enable state of the find text bar's controls.
    ''' </summary>
    ''' <param name="show">True to show find text bar, false to hide it.</param>
    ''' <param name="enable">True to enable find text controls, false to disable them.</param>
    Private Sub FindSetButtonsState(ByVal show As Boolean, ByVal enable As Boolean)
        Me.rbtnFindClose.Visible = show
        Me.rtbFindText.Visible = show
        Me.rbtnFindMatchCase.Visible = show
        Me.rbtnFindNext.Visible = show
        Me.rbtnFindPrev.Visible = show
        ''
        Me.rbtnFindNext.Enabled = enable AndAlso FindHelper.HasNext
        Me.rbtnFindPrev.Enabled = enable AndAlso FindHelper.HasPrev
        ''
        Me.rlblStatusText.Visible = Not show
    End Sub

    ''' <summary>
    ''' Handles key presses for the find text textbox:
    ''' Performs search on Enter, hides the find text bar on Escape.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub rtbFindText_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If (e.KeyChar = vbCr) Then
            FindNext(False)
        ElseIf (e.KeyChar = CType(ChrW(27), Char)) Then
            FindSetButtonsState(False, True)
        End If
    End Sub

    ''' <summary>
    ''' Handles the TextChanged event for the find text textbox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub rtbFindText_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        FindAdjustDisplay(FindHelper.Find(Me.rtbFindText.Text, Me.rbtnFindMatchCase.Pressed))
    End Sub

    ''' <summary>
    ''' Handles the Click event for the find text bar's close button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub rbtnFindClose_Click(ByVal sender As Object, ByVal e As EventArgs)
        FindAdjustDisplay(False)
        FindSetButtonsState(False, True)
    End Sub

    ''' <summary>
    ''' Handles the Click event for the 'find' command:
    ''' shows and activates the find text bar.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdFind_Click(sender As Object, e As ClickEventArgs)
        FindAdjustDisplay(FindHelper.Find(Me.rtbFindText.Text, Me.rbtnFindMatchCase.Pressed))
        Application.DoEvents()
        Me.rtbFindText.TextBox.Focus()
    End Sub

End Class
