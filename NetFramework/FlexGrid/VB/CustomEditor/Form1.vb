Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Windows.Forms.Control

Imports C1.Win.C1FlexGrid
Namespace CustomEditor
    Public Class Form1
        Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

        End Sub

        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified imports the Windows Form Designer.  
        'Do not modify it imports the code editor.
        Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid()
            CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            '_flex
            '
            Me._flex.BackColor = System.Drawing.SystemColors.Window
            Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
            Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
            Me._flex.Name = "_flex"
            Me._flex.Size = New System.Drawing.Size(400, 349)
            Me._flex.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(400, 349)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex})
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "C1FlexGrid: Custom Editors"
            CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        'custom Editor
        Dim _myEditor As MyEditor

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            'create custom editor
            _myEditor = New MyEditor(_flex)

            'make first column a DateTime (just for testing)
            '_flex.Cols(1).Datatype = type.Gettype("System.DateTime")

            'assign first column a mask so the control won't display the
            'drop-down button for the calendar
            '_flex.Cols(1).EditMask ="99/99/99"

        End Sub

        'use custom editor to edit column 1
        Private Sub _flex_StartEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles _flex.StartEdit
            If e.Col = 1 Then
                'start editing the cell with the custom editor
                _myEditor.StartEditing(e.Row, e.Col)

                'cancel built-in editor
                e.Cancel = True
            End If
        End Sub

        'if the custom editor is visible, make it follow the cell being edited
        Private Sub _flex_AfterScroll(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs) Handles _flex.AfterScroll
            If _myEditor.Visible Then
                _myEditor.UpdatePosition()
            End If
        End Sub

        'save last key pressed for the custom editor
        Private Sub _flex_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _flex.KeyPress
            _myEditor.SetPendingKey(e.KeyChar)
        End Sub
    End Class

    ''<summary>
    'MyEditor inherits from a TextBox and can be used as a custom editor
    'for a C1FlexGrid control
    '</summary>

    Public Class MyEditor
        Inherits System.Windows.Forms.TextBox

        Dim WithEvents _owner As C1FlexGrid
        Dim _row As Integer
        Dim _col As Integer
        Dim _pendingKey As Char
        Dim _cancel As Boolean

        'constructor: attach to owner grid
        Public Sub New(ByVal owner As C1FlexGrid)
            MyBase.New()
            Visible = False
            AutoSize = False
            BackColor = Color.Beige
            BorderStyle = BorderStyle.None

            _pendingKey = Chr(0)
            _cancel = False
            _owner = owner
            _owner.Controls.Add(Me)

        End Sub

        'start editing: move to cell and activate
        Public Sub StartEditing(ByVal row As Integer, ByVal col As Integer)

            'save coordinates of cell being edited
            _row = row
            _col = col

            'assume we'll save the edits
            _cancel = False

            'move editor over the current cell
            Dim rc As Rectangle = _owner.GetCellRect(row, col, True)
            rc.Width = rc.Width - 1
            rc.Height = rc.Height - 1

            MyBase.Bounds = rc

            'initialize control content
            MyBase.Text = ""
            If _pendingKey > " " Then
                MyBase.Text = _pendingKey.ToString()
            ElseIf Not _owner(row, col) Is Nothing Then
                MyBase.Text = _owner(row, col).ToString()
            End If
            MyBase.Select(Text.Length, 0)

            'make editor visible
            MyBase.Visible = True

            'and get the focus
            MyBase.Select()
        End Sub

        'save key that started the editing mode
        Public Sub SetPendingKey(ByVal chr As Char)
            _pendingKey = chr
        End Sub

        'move editor after the grid has scrolled
        Public Sub UpdatePosition()

            'get cell rect now
            Dim rcCell As Rectangle = _owner.GetCellRect(_row, _col, False)

            'intersect with scrollable part of the grid
            Dim rcScroll As Rectangle = _owner.ClientRectangle
            rcScroll.X = _owner.Cols(_owner.Cols.Fixed).Left
            rcScroll.Y = _owner.Rows(_owner.Rows.Fixed).Top
            rcScroll.Width = rcScroll.Width - rcScroll.X
            rcScroll.Height = rcScroll.Height - rcScroll.Y
            rcCell = Rectangle.Intersect(rcCell, rcScroll)

            'and move the control
            If (rcCell.Width > 0) Then rcCell.Width = rcCell.Width - 1
            If (rcCell.Height > 0) Then rcCell.Height = rcCell.Height - 1
            MyBase.Bounds = rcCell
        End Sub

        'lost focus:hide the editor
        Protected Overrides Sub OnLeave(ByVal e As System.EventArgs)

            'base processing
            MyBase.OnLeave(e)

            'copy text to owner grid
            If Not _cancel Then
                _owner(_row, _col) = MyBase.Text
            End If

            'no more pending keys
            _pendingKey = Chr(0)

            'done for now, hide editor
            MyBase.Visible = False
        End Sub

        'we will handle the tab key ourselves
        Protected Overrides Function IsInputkey(ByVal keydata As Keys) As Boolean
            If keydata = Keys.Tab Then
                Return True
            End If
            Return MyBase.IsInputKey(keydata)
        End Function

        'some keys end the editing
        Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
            Select Case e.KeyCode
                Case Keys.Escape
                    _cancel = True
                    _owner.Select()
                    e.Handled = True
                Case Keys.Enter, Keys.Tab, Keys.Up, Keys.Down, Keys.PageUp, Keys.PageDown
                    _owner.Select()
                    e.Handled = True
                    MoveCursor(e.KeyCode)
                Case Else
                    MyBase.OnKeyDown(e)

            End Select
        End Sub

        'mov cursor after done editing
        Protected Sub MoveCursor(ByVal key As Keys)
            Dim row As Integer = _owner.Row
            Dim col As Integer = _owner.Col

            Select Case key
                Case Keys.Tab
                    col = col + 1
                Case Keys.Up
                    row = row - 1
                Case Keys.Down
                    row = row + 1
                Case Keys.PageUp
                    row -= 10
                Case Keys.PageUp
                    row += 10
            End Select

            'validate new selection
            If (row < _owner.Rows.Fixed) Then row = _owner.Rows.Fixed
            If (col < _owner.Cols.Fixed) Then col = _owner.Cols.Fixed
            If (row > _owner.Rows.Count - 1) Then row = _owner.Rows.Count - 1
            If (col > _owner.Cols.Count - 1) Then col = _owner.Cols.Count - 1

            'apply new selection
            _owner.Select(row, col)

        End Sub

        Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
            Select Case e.KeyChar
                Case Chr(27), Chr(13), Chr(9)
                    e.Handled = True
                    Return
            End Select
            MyBase.OnKeyPress(e)

        End Sub
    End Class
End Namespace