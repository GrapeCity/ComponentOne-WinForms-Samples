Imports C1.Win.FlexGrid

'/ <summary>
'/ CellNoteManager manages CellNote objects stored in C1FlexGrid 
'/ cells. It does three things:
'/ 
'/ 1) Hooks up some event handlers to detect when the mouse moves 
'/ over cells that contain CellNote objects and displays the notes.
'/ 
'/ 2) Provides an OwnerDraw handler that displays the cell note 
'/ indicator on the upper right corner of cells that contain notes.
'/ 
'/ 3) Provides a ContextMenu that allows users to create, edit, 
'/ and delete CellNotes.
'/ 
'/ To use the CellNoteManager, instantiate it and pass a C1FlexGrid
'/ control as a parameter:
'/ 
'/    CellNoteManager mgr = new CellNoteManager(_flex)
'/  
'/ </summary>
Public Class CellNoteManager

    '------------------------------------------------------------------------------------------------------

    Dim _flex As C1FlexGrid     ' grid that owns the notes
    Dim _note As CellNote       ' note currently displayed
    Dim _menuActive As Boolean  ' context menu is active (don't display notes)

    Dim _menu As ContextMenu
    Dim _mInsertNote As MenuItem
    Dim _mEditNote As MenuItem
    Dim _mDeleteNote As MenuItem


    '------------------------------------------------------------------------------------------------------

    Public Sub New(ByVal flex As C1FlexGrid)
        Me._flex = flex
        Me._flex.DrawMode = DrawModeEnum.OwnerDraw
        AddHandler Me._flex.MouseHoverCell, New EventHandler(AddressOf Me._flex_MouseHoverCell)
        AddHandler Me._flex.OwnerDrawCell, New OwnerDrawCellEventHandler(AddressOf Me._flex_OwnerDrawCell)
        AddHandler Me._flex.MouseDown, New MouseEventHandler(AddressOf Me._flex_MouseDown)
        Me._menu = New ContextMenu()
        Me._mInsertNote = New MenuItem("Insert Note", New EventHandler(AddressOf Me._mInsertNote_Click))
        Me._mEditNote = New MenuItem("Edit Note", New EventHandler(AddressOf Me._mEditNote_Click))
        Me._mDeleteNote = New MenuItem("Delete Note", New EventHandler(AddressOf Me._mDeleteNote_Click))
        Me._menu.MenuItems.Add(Me._mInsertNote)
        Me._menu.MenuItems.Add(Me._mDeleteNote)
        Me._menu.MenuItems.Add(Me._mEditNote)
    End Sub

    '------------------------------------------------------------------------------------------------------

    Private Function GetNoteAtMouse() As CellNote
        Dim row As Integer = Me._flex.MouseRow
        Dim col As Integer = Me._flex.MouseCol
        If ((row >= Me._flex.Rows.Fixed) AndAlso (col >= Me._flex.Cols.Fixed)) Then
            Dim rg As CellRange = Me._flex.GetCellRange(row, col)
            Return CType(rg.UserData, CellNote)
        End If
        Return Nothing
    End Function

    '------------------------------------------------------------------------------------------------------

    ' show/hide cell notes
    Private Sub _flex_MouseHoverCell(ByVal sender As Object, ByVal e As EventArgs)

        ' hide current note, if any
        If (Not Me._note Is Nothing) Then
            Me._note.HideNote()
            Me._note = Nothing
        End If

        ' show note if the grid is focused or if the context menu is inactive
        If (Me._flex.Focused AndAlso Not Me._menuActive) Then
            Me._note = Me.GetNoteAtMouse
            If (Not Me._note Is Nothing) Then
                Dim rc As Rectangle = Me._flex.GetCellRect(Me._flex.MouseRow, Me._flex.MouseCol)
                rc = Me._flex.RectangleToScreen(rc)
                Me._note.ShowNote(rc)
            End If
        End If
    End Sub


    ' draw cell note indicator on the cell 
    ' (a little red triangle on the upper-right corner)
    Private Sub _flex_OwnerDrawCell(ByVal sender As Object, ByVal e As OwnerDrawCellEventArgs)
        Dim rg As CellRange = Me._flex.GetCellRange(e.Row, e.Col)

        ' check if the cell has a note
        If TypeOf rg.UserData Is CellNote Then

            ' default drawing
            e.DrawCell()

            ' add the little red rectangle that indicaates there's a note on this cell
            Dim pt As New Point(e.Bounds.Right, e.Bounds.Y)
            Dim ptarr As Point() = New Point() {New Point((pt.X - 4), pt.Y), pt, New Point(pt.X, (pt.Y + 4))}
            e.Graphics.FillPolygon(Brushes.Red, ptarr)
        End If
    End Sub

    ' show context menu when user presses the right button
    Private Sub _flex_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        If (e.Button = MouseButtons.Right) Then

            ' hide current note, if any
            If (Not Me._note Is Nothing) Then
                Me._note.HideNote()
                Me._note = Nothing
            End If

            ' make sure user clicked a valid cell
            Dim row As Integer = Me._flex.MouseRow
            Dim col As Integer = Me._flex.MouseCol
            If ((row >= Me._flex.Rows.Fixed) AndAlso (col >= Me._flex.Cols.Fixed)) Then

                ' select cell that was clicked
                Me._flex.Select(row, col)

                ' update context menu
                Dim hasNote As Boolean = (Not Me.GetNoteAtMouse Is Nothing)
                Me._mInsertNote.Visible = Not hasNote
                Me._mEditNote.Visible = hasNote
                Me._mDeleteNote.Visible = hasNote

                ' show the menu
                Me._menuActive = True
                Me._menu.Show(Me._flex, New Point(e.X, e.Y))
                Me._menuActive = False
            End If
        End If
    End Sub

    '------------------------------------------------------------------------------------------------------

    Private Sub _mDeleteNote_Click(ByVal sender As Object, ByVal e As EventArgs)

        ' get note
        Dim rg As CellRange = Me._flex.Selection

        ' clear note
        If TypeOf rg.UserData Is CellNote Then
            rg.UserData = Nothing
            Me._flex.Invalidate()
        End If

        ' resume showing notes
        Me._menuActive = False
    End Sub

    Private Sub _mInsertNote_Click(ByVal sender As Object, ByVal e As EventArgs)

        ' create note
        Dim note As New CellNote("Note: ")

        ' attach note to cell
        Dim rg As CellRange = Me._flex.Selection
        rg.UserData = note
        Me._flex.Invalidate()

        ' go edit the new note
        Me._mEditNote_Click(sender, e)
    End Sub

    Private Sub _mEditNote_Click(ByVal sender As Object, ByVal e As EventArgs)

        ' get note
        Dim rg As CellRange = Me._flex.Selection
        Dim note As CellNote = CType(rg.UserData, CellNote)

        ' edit note
        If (Not note Is Nothing) Then
            Dim rc As Rectangle = Me._flex.GetCellRect(rg.r1, rg.c1)
            rc = Me._flex.RectangleToScreen(rc)
            note.EditNote(rc)
        End If

        ' resume showing notes
        Me._menuActive = False
    End Sub
End Class
