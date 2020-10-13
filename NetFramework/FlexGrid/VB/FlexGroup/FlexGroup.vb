'
' FlexGroup.vb
'
' Implements Outlook-style grouping using the C1FlexGrid control
'
' Version history:
'
' 1.0: Jun 2002    Ported from C# sample                       Ron MacKee
' 1.1: Jun 2003    Updated (minor fixes and improvements)      Bernardo Castilho
' 1.2: Jan 2004    Updated (minor fixes and improvements)      Bernardo Castilho
' 1.5: Dec 2004    Updated (allow sorting ungrouped cols)      Bernardo Castilho
'
'
Imports System.Text
Imports System.ComponentModel
Imports System.Reflection
Imports C1.Win.C1FlexGrid

Public Class FlexGroupControl
    Inherits System.Windows.Forms.PictureBox
    Implements ISupportInitialize

    ' fields
    Dim WithEvents _flex As C1FlexGrid         ' grid control
    Dim _groups As ArrayList        ' list of fields (columns) in the group area
    Dim _dragger As FieldDragger    ' aux control to drag fields
    Dim _styleGroup As CellStyle    ' used to paint groups
    Dim _styleEmpty As CellStyle    ' used to paint empty area
    Dim _showGroups As Boolean      ' show/hide grouping area
    Dim _insGroup As Boolean        ' whether column being inserted is a group/column 
    Dim _dirty As Boolean           ' need to refresh groups
    Dim _insIndex As Integer        ' index where group/column should be inserted
    Dim _insRect As Rectangle       ' rectangle where insert indicator is drawn
    Dim _insRectLast As Rectangle   ' rectangle where last insert indicator was drawn
    Dim _brBack As SolidBrush       ' gdi objects used for painting group area
    Dim _brFore As SolidBrush
    Dim _brGrp As SolidBrush
    Dim _brBdr As SolidBrush
    Dim _filterRow As FilterRow     ' filter row (control visibility with FilterRow property)
    Dim _groupMessage As String     ' message displayed in the empty group area

    Shared _sf As StringFormat
    Shared _bmpInsert As Bitmap     ' insert icon
    Shared _bmpSortUp As Bitmap     ' sort icon
    Shared _bmpSortDn As Bitmap     ' sort icon

    Const SPACING As Integer = 8               ' spacing between groups, edges
    Const SCROLLSTEP As Integer = 15           ' scroll step (while dragging mouse)
    Const DRAGTHRESHOLD As Integer = 8         ' pixels before starting column drag
    Const GROUP_MSG As String = "Drag column headers here to create groups"


    Public Sub New()
        MyBase.New()

        ' initialize static (shared) members
        If _sf Is Nothing Then
            _sf = New StringFormat(StringFormat.GenericDefault)
            _sf.Alignment = StringAlignment.Center
            _sf.LineAlignment = StringAlignment.Center
            _bmpInsert = LoadBitmap("InsertPoint", Color.White)
            _bmpSortUp = LoadBitmap("SortUp", Color.Red)
            _bmpSortDn = LoadBitmap("SortDn", Color.Red)
        End If

        ' initialize contained Flex control
        _flex = New C1FlexGrid()
        _flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        _flex.Dock = DockStyle.Bottom
        _flex.Size = New Size(10, 10)
        _flex.AllowSorting = AllowSortingEnum.None
        _flex.AllowMerging = AllowMergingEnum.Nodes
        _flex.Cols(0).Width = _flex.Rows.DefaultSize
        _flex.ShowCursor = True
        _flex.Tree.Style = TreeStyleFlags.Symbols
        _flex.DrawMode = DrawModeEnum.OwnerDraw

        ' initialize styles
        _flex.Styles.Normal.Border.Direction = BorderDirEnum.Horizontal
        _styleGroup = _flex.Styles.Add("Group", _flex.Styles.Fixed)
        _styleEmpty = _flex.Styles.Add("Empty", _flex.Styles.EmptyArea)
        _styleEmpty.BackColor = SystemColors.ControlDarkDark
        _styleEmpty.ForeColor = SystemColors.ControlLightLight

        ' initialize internal members
        _groupMessage = GROUP_MSG
        _groups = New ArrayList()
        _showGroups = True
        _insIndex = -1

        ' initialize field dragger control
        _dragger = New FieldDragger(Me)

        ' add filter row (control visibility with 'FilterRow' property)
        _filterRow = New FilterRow(_flex)
        _filterRow.Visible = False

        ' initialize parent control
        SuspendLayout()
        BorderStyle = BorderStyle.Fixed3D
        BackColor = SystemColors.ControlDark
        ForeColor = SystemColors.ControlLightLight
        Controls.AddRange(New System.Windows.Forms.Control() {_dragger, _flex})
        ResumeLayout(False)

    End Sub

    ' ** ISupportInitialize

    Sub BeginInit() Implements ISupportInitialize.BeginInit
        _flex.BeginInit()
    End Sub

    Sub EndInit() Implements ISupportInitialize.EndInit

        ' don't call EndInit without BeginInit first <<B4>>
        _flex.BeginInit()
        _flex.EndInit()

        ' flex has re-created the styles, 
        ' so get a fresh reference to the custom ones we'll use
        _styleGroup = _flex.Styles("Group")
        _styleEmpty = _flex.Styles("Empty")

        ' make sure grid is visible <<B4>>
        _flex.Visible = True
        UpdateLayout()

    End Sub

    ' ** object model

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    ReadOnly Property Grid() As C1FlexGrid
        Get
            Grid = _flex
        End Get
    End Property

    Property ShowGroups() As Boolean
        Get
            Return _showGroups
        End Get
        Set(ByVal Value As Boolean)
            _showGroups = Value
            UpdateLayout()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    ReadOnly Property StyleGroupRows() As CellStyle
        Get
            Return _styleGroup
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    ReadOnly Property StyleGroupArea() As CellStyle
        Get
            Return _styleGroup
        End Get
    End Property

    <Description("Gets or sets the message shown in the empty group area."), _
    Localizable(True), _
    DefaultValue(GROUP_MSG)> _
    Public Property GroupMessage() As String ' <<B4>>
        Get
            Return _groupMessage
        End Get
        Set(ByVal Value As String)
            _groupMessage = Value
            Invalidate()
        End Set
    End Property

    <Description("Gets or sets a comma-delimited list of the groups (by column name)."), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property Groups() As String
        Get
            ' build string with column names
            Dim sb As New StringBuilder()
            Dim col As Column
            For Each col In _groups
                If sb.Length > 0 Then sb.Append(", ")
                sb.Append(col.Name)
            Next
            Return sb.ToString()
        End Get
        Set(ByVal Value As String)
            ' make current group columns visible
            _flex.Redraw = False
            Dim col As Column
            For Each col In _groups
                col.Visible = True
            Next

            ' rebuild _groups collection
            _groups.Clear()
            Dim colName As String
            For Each colName In Value.Split(",")
                col = _flex.Cols(colName.Trim())
                If Not IsNothing(col) Then _groups.Add(col)
            Next

            ' apply new collection
            UpdateGroups()
            UpdateLayout()

            ' done
            _flex.Redraw = True
        End Set
    End Property

    <Description("Gets or sets whether the control should display a filter row above the data."), _
     DefaultValue(False)> _
    Public Property FilterRow() As Boolean
        Get
            Return _filterRow.Visible
        End Get
        Set(ByVal Value As Boolean)
            If _filterRow.Visible <> Value Then
                _filterRow.Clear()
                _filterRow.Visible = Value
            End If
        End Set
    End Property

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)> _
    Shadows Property Image() As Image
        Get
            Return MyBase.Image
        End Get
        Set(ByVal Value As Image)
            MyBase.Image = Value
        End Set
    End Property

    ' ** overrides

    ' adjust layout when the control is resized
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        UpdateLayout()
        MyBase.OnResize(e)
    End Sub

    ' start dragging groups
    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)

        ' we're interested in the left button
        Dim i As Integer, rc As Rectangle
        If (e.Button And MouseButtons.Left) <> 0 Then
            For i = 0 To _groups.Count - 1
                rc = GetGroupRectangle(i)
                If rc.Contains(e.X, e.Y) Then
                    _dragger.StartDragging(_groups(i), rc)
                    Exit Sub
                End If
            Next
        End If

        ' allow base class processing
        MyBase.OnMouseDown(e)
    End Sub

    ' paint group area
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        UpdateObjects()
        Dim g As Graphics = e.Graphics

        ' get group area
        Dim rc As Rectangle = ClientRectangle
        rc.Height = _flex.Top

        ' draw background
        g.FillRectangle(_brBack, rc)
        If _groups.Count = 0 Then
            g.DrawString(_groupMessage, _styleEmpty.Font, _brFore, ToRCF(rc), _sf)
        Else ' draw groups
            Dim i As Integer
            For i = 0 To _groups.Count - 1
                rc = GetGroupRectangle(i)
                PaintGroup(g, rc, _groups(i))
            Next
        End If

        ' show insert position while dragging
        If _dragger.Visible Then
            DrawImageCentered(g, _bmpInsert, _insRect)
        End If
    End Sub

    ' update GDI objects based on grid style
    Sub UpdateObjects()
        Dim clr As Color

        ' update objects used to draw group area
        clr = _styleEmpty.BackColor
        If (_brBack Is Nothing) OrElse (Not _brBack.Color.Equals(clr)) Then _brBack = New SolidBrush(clr)

        clr = _styleEmpty.ForeColor
        If (_brFore Is Nothing) OrElse (Not _brFore.Color.Equals(clr)) Then _brFore = New SolidBrush(clr)

        ' update objects used to draw grid
        clr = _styleGroup.BackColor
        If (_brGrp Is Nothing) OrElse (Not _brGrp.Color.Equals(clr)) Then _brGrp = New SolidBrush(clr)

        clr = _styleGroup.Border.Color
        If (_brBdr Is Nothing) OrElse (Not _brBdr.Color.Equals(clr)) Then _brBdr = New SolidBrush(clr)
    End Sub

    ' ** event handlers

    ' cancel dragging when a key is pressed
    Private Sub _flex_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles _flex.KeyPress
        If _dragger.Visible Then
            _dragger.Visible = False
            Invalidate()
        End If
    End Sub

    ' start dragging columns
    Private Sub _flex_BeforeMouseDown(ByVal sender As Object, ByVal e As BeforeMouseDownEventArgs) Handles _flex.BeforeMouseDown

        ' we're interested in the left button
        If (e.Button And MouseButtons.Left) = 0 Then Exit Sub

        ' check that the click was on a column header
        Dim hti As HitTestInfo = _flex.HitTest(e.X, e.Y)
        If hti.Type <> HitTestTypeEnum.ColumnHeader Then Exit Sub

        ' check that the click was on a scrollable column
        Dim cols As ColumnCollection = _flex.Cols
        If hti.Column < cols.Fixed Then Exit Sub

        ' check that the click was on the first row
        ' (in case there's additional fixed rows)
        If hti.Row > 0 Then Exit Sub

        ' eat the event 
        e.Cancel = True

        ' check that we have at least one non-grouped column
        If _groups.Count >= cols.Count - cols.Fixed - 1 Then Exit Sub

        ' start dragging column
        _dragger.StartDragging(cols(hti.Column))
    End Sub

    ' prevent editing group headers // <<B5>>
    Private Sub _flexBeforeEdit(ByVal sender As Object, ByVal e As RowColEventArgs) Handles _flex.BeforeEdit
        If _flex.Rows(e.Row).IsNode Then
            e.Cancel = True
        End If
    End Sub

    ' update layout after resizing columns
    Private Sub _flex_AfterResizeColumn(ByVal sender As Object, ByVal e As RowColEventArgs) Handles _flex.AfterResizeColumn
        UpdateLayout()
    End Sub

    ' draw cells to make them look like Outlook
    Private Sub _flex_OwnerDrawCell(ByVal sender As Object, ByVal e As OwnerDrawCellEventArgs) Handles _flex.OwnerDrawCell

        ' don't draw while measuring
        If e.Measuring Then Exit Sub

        ' custom draw only scrollable rows on tree column
        If _groups.Count = 0 Then Exit Sub
        If e.Col <> _flex.Tree.Column Then Exit Sub
        If e.Row < _flex.Rows.Fixed Then Exit Sub

        ' make sure we got the gdi objects we need
        UpdateObjects()

        ' get parameters we'll need
        Dim row As Row = _flex.Rows(e.Row)
        If row.Node Is Nothing Then Return
        Dim idt As Integer = _flex.Tree.Indent
        Dim x As Integer = _flex.ScrollPosition.X
        Dim lvl As Integer = row.Node.Level
        Dim rc As Rectangle

        ' custom draw nodes
        If row.IsNode Then

            ' draw background and content
            e.Style = _styleGroup
            e.DrawCell(DrawCellFlags.Background Or DrawCellFlags.Content)

            ' draw line above
            If (lvl = 0) OrElse (Not _flex.Rows(e.Row - 1).IsNode) Then
                rc = e.Bounds
                OffsetLeft(rc, lvl * idt + x)
                rc.Height = 1
                e.Graphics.FillRectangle(_brBdr, rc)
            End If

            ' if the node is expanded, draw line below
            If row.Node.Expanded Then
                rc = e.Bounds
                OffsetLeft(rc, (lvl + 1) * idt + x)
                rc.Y = rc.Bottom - 1
                rc.Height = 1
                e.Graphics.FillRectangle(_brBdr, rc)
            End If

            ' draw vertical lines to the left of the symbol
            rc = e.Bounds
            rc.X += x
            rc.Width = 1
            Dim i As Integer
            For i = 0 To lvl
                e.Graphics.FillRectangle(_brBdr, rc)
                rc.Offset(idt, 0)
            Next

        Else ' custom draw data

            ' base painting
            e.DrawCell()

            ' fill area on the left
            rc = e.Bounds
            rc.Width = (lvl + 1) * idt
            e.Graphics.FillRectangle(_brGrp, rc)

            ' draw vertical lines over filled area
            rc = e.Bounds
            rc.Width = 1
            Dim i As Integer
            For i = 0 To lvl + 1
                e.Graphics.FillRectangle(_brBdr, rc)
                rc.Offset(idt, 0)
            Next
        End If
    End Sub

    Public Sub OffsetLeft(ByRef rc As Rectangle, ByVal x As Integer)
        rc.X = rc.X + x
        rc.Width = rc.Width - x
    End Sub

    ' reset groups when data source changes <<1.1>>
    Private Sub _flex_DataChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles _flex.AfterDataRefresh
        If e.ListChangedType = ListChangedType.Reset Then
            UpdateGroups()
        End If
    End Sub

    ' repaint control when styles change
    Private Sub _flex_GridChanged(ByVal sender As Object, ByVal e As GridChangedEventArgs) Handles _flex.GridChanged
        If e.GridChangedType = GridChangedTypeEnum.RepaintGrid Then
            Invalidate()
        End If
    End Sub

    ' ** utilities

    ' update the size of the group area
    Sub UpdateLayout()

        ' calculate size of grouping area
        Dim hei As Integer = 0
        If _showGroups Then
            If _groups.Count > 0 Then
                hei = GetGroupRectangle(_groups.Count - 1).Bottom + SPACING
            Else
                hei = _flex.Rows.DefaultSize + 2 * SPACING ' <<B5>>
            End If
        End If

        ' move grid to remaining area
        _flex.Height = ClientRectangle.Height - hei

        ' repaint the control
        Invalidate()

        ' and update groups
        UpdateGroups()
    End Sub

    ' update grouping/sorting
    Function UpdateGroupNeeded() As Boolean

        ' reset groups if the data source has changed <<1.1>>
        Dim i As Integer
        For i = 0 To _groups.Count - 1
            Dim col As Column = _groups(i)

            ' if index is bad, try fixing it
            If col.Index < 0 Then
                If _flex.Cols.Contains(col.Name) Then
                    _groups(i) = _flex.Cols(col.Name)
                Else
                    _groups.Clear()
                    Return True
                End If
            End If
        Next

        ' groups must be the first columns and must be hidden
        Dim cols As ColumnCollection = _flex.Cols
        Dim iFixed As Integer = cols.Fixed
        For i = 0 To _groups.Count - 1
            Dim col As Column = cols(i + iFixed)
            If (col.Visible) OrElse (Not _groups(i).Equals(col)) Then Return True
        Next

        ' remaining columns must be visible
        For i = iFixed + _groups.Count To cols.Count - 1
            If Not cols(i).Visible Then Return True
            Return False
        Next
    End Function

    ' update grouping/sorting
    Sub UpdateGroups()

        ' check whether we need to update the groups
        If (Not _dirty) AndAlso (Not UpdateGroupNeeded()) Then Return

        ' stop painting for a while
        _flex.Redraw = False

        ' remove subtotals
        _flex.Subtotal(AggregateEnum.Clear)

        ' adjust group columns
        Dim cols As ColumnCollection = _flex.Cols
        Dim index As Integer = cols.Fixed
        Dim col As Column
        For Each col In _groups

            ' adjust column position/visibility
            col.Visible = False
            cols.Move(col.Index, index)
            index = index + 1

            ' initialize sorting direction if necessary
            If (col.Sort And (SortFlags.Ascending Or SortFlags.Descending)) = 0 Then
                col.Sort = SortFlags.Ascending
            End If
        Next
        For index = index To cols.Count - 1
            cols(index).Visible = True
        Next

        ' sort columns
        '_flex.Sort(SortFlags.UseColSort, cols.Fixed, _groups.Count)
        _flex.Sort(SortFlags.UseColSort, cols.Fixed, cols.Count - 1) ' <<B5>>

        ' make sure tree is in the right position
        _flex.Tree.Column = cols.Fixed + _groups.Count

        ' and make sure tree contents are left-aligned (or there's no spill merge) <<1.1>>
        _flex.Cols(_flex.Tree.Column).TextAlign = TextAlignEnum.LeftCenter

        ' and insert subtotals
        For index = 0 To _groups.Count - 1
            Dim icol As Integer = index + cols.Fixed
            Dim fmt As String = cols(icol).Caption + ": {0}"
            _flex.Subtotal(AggregateEnum.None, index, icol, 0, fmt)
        Next

        ' done
        _dirty = False
        _flex.Redraw = True
    End Sub

    ' update the position of the insertion indicator
    Sub UpdateInsertLocation()
        Dim loc As Point = PointToClient(Control.MousePosition)
        Dim rc As Rectangle

        ' initialize members
        _insRect = Rectangle.Empty
        _insIndex = -1

        ' insert into group list
        If loc.Y < _flex.Top Then

            ' find position where new group should be inserted
            Dim index As Integer = _groups.Count
            Dim i As Integer
            For i = 0 To _groups.Count - 1
                rc = GetGroupRectangle(i)
                If rc.X + rc.Width / 2 > loc.X Then
                    index = i
                    Exit For
                End If
            Next

            ' update insert info
            _insGroup = True
            _insIndex = index

            ' update insert position
            If index < _groups.Count Then
                _insRect = GetGroupRectangle(index)
                _insRect.X = _insRect.X - SPACING
            Else
                _insRect = GetGroupRectangle(_groups.Count - 1)
                _insRect.X = _insRect.Right
            End If
            If index > 0 AndAlso index < _groups.Count Then
                _insRect.Y = _insRect.Y - _insRect.Height / 2
                _insRect.Height = _insRect.Height + _insRect.Height / 2
            End If
            _insRect.Width = SPACING

        Else ' remove from group list (insert into grid)

            ' find position where grid column should be inserted
            Dim index As Integer = _flex.Cols.Count
            Dim i As Integer
            For i = _flex.Cols.Fixed To _flex.Cols.Count - 1
                rc = _flex.GetCellRect(0, i, False)
                If rc.X + rc.Width / 2 > loc.X Then
                    index = i
                    Exit For
                End If
            Next

            ' and update insert info
            _insGroup = False
            _insIndex = index

            ' update insert position
            If index < _flex.Cols.Count Then
                _insRect = _flex.GetCellRect(0, index, False)
                _insRect.Width = 0
            Else
                _insRect = _flex.GetCellRect(0, index - 1, False)
                _insRect.X = _insRect.Right
                _insRect.Width = 0
            End If
            _insRect.Inflate(SPACING / 2, 5)
            _insRect.Offset(0, _flex.Top)
        End If

        ' invalidate to show new insertion point
        If Not _insRect.Equals(_insRectLast) Then
            Invalidate()
            _insRectLast = _insRect
        End If
    End Sub

    ' finish dragging a column (or group)
    Sub FinishDragging(ByVal col As Column, ByVal dragged As Boolean)

        ' didn't drag? then it was a click: apply/reverse sort
        If Not dragged Then

            ' reverse column sort
            If (col.Sort And SortFlags.Ascending) <> 0 Then
                col.Sort = SortFlags.Descending
            Else
                col.Sort = SortFlags.Ascending
            End If

            ' if this is a non-grouped column, reset Sort property on all other <<B5>>
            ' non-grouped columns and re-apply sort
            If Not _groups.Contains(col) Then

                ' reset sort order on other columns
                Dim colIndex As Integer = col.Index
                Dim cols As ColumnCollection = _flex.Cols
                Dim c As Integer
                For c = _groups.Count To cols.Count - 1
                    If c <> colIndex Then
                        _flex.Cols(c).Sort = SortFlags.None
                    End If
                Next

                ' apply sort
                _flex.Col = colIndex
                _flex.Sort(SortFlags.UseColSort, cols.Fixed, cols.Count - 1)
                _flex.ShowSortAt(col.Sort, colIndex)
                Return
            End If

            ' OLD CODE
            ' if this is a non-grouped column, sort only when unbound
            ' (to avoid screwing up the groups)
            'If Not _groups.Contains(col) Then
            '    If (_groups.Count = 0) OrElse (_flex.DataSource Is Nothing) Then
            '        _flex.Sort(col.Sort, col.Index)
            '        Return
            '    End If
            'End If

            ' insert column into group collection
        ElseIf _insGroup Then

            ' add group to list at the proper position (col->grp, grp->grp)
            _groups.Insert(_insIndex, col)
            Dim i As Integer
            For i = 0 To _groups.Count - 1
                If (i <> _insIndex) AndAlso (_groups(i).Equals(col)) Then
                    _groups.RemoveAt(i)
                    Exit For
                End If
                col.Visible = False
            Next

        Else ' insert column into grid

            ' move column to a new position (col->col, grp->col)
            Dim oldIndex As Integer = col.Index
            Dim newIndex As Integer = _insIndex
            If newIndex > oldIndex Then newIndex = newIndex - 1
            _flex.Cols.Move(oldIndex, newIndex)
            col.Visible = True

            ' remove from group list, if it's there (grp->col)
            If _groups.Contains(col) Then
                _groups.Remove(col)
            End If
        End If

        ' update layout and repaint
        _dirty = True
        UpdateLayout()
    End Sub

    ' get the position of a group in the group area
    Function GetGroupRectangle(ByVal index As Integer) As Rectangle

        ' build skinny rectangle at the top
        Dim rc As Rectangle = New Rectangle(SPACING, SPACING, 0, _flex.Rows.DefaultSize)

        ' set width if we can
        ' (don't use WidthDisplay because the group column is invisible,
        ' so WidthDisplay will return zero)
        Dim wid As Integer
        If (index > -1) AndAlso (index < _groups.Count) Then
            wid = _groups(index).Width ' <<B1.2>>
            If wid < 0 Then wid = Grid.Cols.DefaultSize
            rc.Width = wid
        End If

        ' loop/adjust position
        Dim i As Integer
        For i = 0 To index - 1
            wid = _groups(i).Width ' <<B1.2>>
            If wid < 0 Then wid = Grid.Cols.DefaultSize
            rc.X = rc.X + wid + SPACING
            rc.Y = rc.Y + rc.Height / 2
        Next

        ' return the rectangle
        Return rc
    End Function

    ' draw image centering it on rectangle
    Sub DrawImageCentered(ByVal g As Graphics, ByVal img As Image, ByVal rc As Rectangle)
        Dim sz As Size = img.Size
        rc.Offset((rc.Width - sz.Width) / 2, (rc.Height - sz.Height) / 2)
        rc.Size = sz
        g.DrawImageUnscaled(img, rc)
        Console.WriteLine("rc is {0} {1} {2} {3}", rc.X, rc.Y, rc.Width, rc.Height)
    End Sub

    ' load a bitmap from the assembly resources
    Function LoadBitmap(ByVal name As String, ByVal transparent As Color) As Bitmap
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim resName As String = String.Format("{0}.{1}.bmp", a.GetName().Name, name)
        Dim s As String() = a.GetManifestResourceNames()
        Dim bmp As Bitmap = New Bitmap(a.GetManifestResourceStream(resName))
        bmp.MakeTransparent(transparent)
        Return bmp
    End Function

    ' paint group using dragger control
    Sub PaintGroup(ByVal g As Graphics, ByVal rc As Rectangle, ByVal col As Column)

        ' draw control
        _dragger.PaintControl(g, rc, col.Caption, False)

        ' draw sorting glyph
        Dim img As Image = Nothing
        If _flex.ShowSort Then
            If (col.Sort And SortFlags.Ascending) <> 0 Then
                img = _bmpSortUp
            ElseIf (col.Sort And SortFlags.Descending) <> 0 Then
                img = _bmpSortDn
            End If
            If Not img Is Nothing Then
                rc.X = rc.Right - rc.Height
                rc.Width = rc.Height
                DrawImageCentered(g, img, rc)
            End If
        End If
    End Sub

    Function ToRCF(ByVal rc As Rectangle) As RectangleF
        Return New RectangleF(rc.X, rc.Y, rc.Width, rc.Height)
    End Function

    '/ <summary>
    '/ FieldDragger
    '/ internal class used to implement field dragging
    '/ </summary>
    Private Class FieldDragger
        Inherits Label
        Dim _owner As FlexGroupControl
        Dim _column As Column
        Dim _offset As Point
        Dim _ptDown As Point
        Dim _dragging As Boolean
        Dim _rcClip As Rectangle
        Dim _brBack As SolidBrush
        Dim _brFore As SolidBrush
        Dim _brDrag As SolidBrush

        Shared _sf As StringFormat
        Shared _pDark As Pen
        Shared _pLite As Pen

        ' ** ctor
        Public Sub New(ByVal owner As FlexGroupControl)

            ' initialize static members
            If _sf Is Nothing Then
                _pDark = SystemPens.ControlDark
                _pLite = SystemPens.ControlLightLight
                _sf = New StringFormat(StringFormat.GenericDefault)
                _sf.Alignment = StringAlignment.Near
                _sf.LineAlignment = StringAlignment.Center
                _sf.FormatFlags = _sf.FormatFlags Or StringFormatFlags.NoWrap
            End If

            ' initialize control
            _owner = owner
            Visible = False
            BackColor = Color.Transparent
        End Sub

        ' ** overrides

        ' use custom painting routine
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Dim rc As Rectangle = ClientRectangle
            PaintControl(e.Graphics, rc, _column.Caption, True)
        End Sub

        ' move with the mouse
        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)

            ' drag while the left button is down
            If (e.Button And MouseButtons.Left) = 0 Then Return

            ' make sure the mouse moved at least a little
            If Not _dragging Then
                Dim ptNow As Point = Control.MousePosition
                If Math.Abs(ptNow.X - _ptDown.X) < DRAGTHRESHOLD AndAlso _
                    Math.Abs(ptNow.Y - _ptDown.Y) < DRAGTHRESHOLD Then Return
                _dragging = True
            End If

            ' calculate new position for the control
            Dim pos As Point = _owner.PointToClient(Control.MousePosition)
            Dim loc As Point = pos
            loc.Offset(-_offset.X, -_offset.Y)

            ' clip to grouping area, scroll
            Dim rc As Rectangle = _rcClip
            Dim g As C1FlexGrid = _owner.Grid
            Dim pt As Point = g.ScrollPosition
            If loc.X + Width > rc.Right Then
                loc.X = rc.Right - Width
                pt.X = pt.X - SCROLLSTEP
            End If
            If loc.X < 0 Then
                loc.X = 0
                pt.X = pt.X + SCROLLSTEP
            End If
            If loc.Y + Height > rc.Bottom Then loc.Y = rc.Bottom - Height
            If loc.Y < 0 Then loc.Y = 0

            ' move dragger control
            If Not Location.Equals(loc) Then Location = loc

            ' scroll grid
            Dim scroll As Boolean = False
            If (pos.Y >= _owner.Grid.Top) AndAlso (Not g.ScrollPosition.Equals(pt)) Then
                Dim oldPos As Point = g.ScrollPosition
                g.ScrollPosition = pt
                scroll = Not g.ScrollPosition.Equals(oldPos)
            End If

            ' update insert location (after scrolling grid)
            _owner.UpdateInsertLocation()

            ' keep scrolling
            If scroll Then
                _owner.Update()
                OnMouseMove(e)
            End If
        End Sub

        ' finish dragging when the left mouse button is released
        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)

            ' make sure left button is up
            If (Control.MouseButtons And MouseButtons.Left) <> 0 Then Return

            ' make sure we're visible
            If Not Visible Then Return

            ' hide and finish dragging
            Visible = False
            _owner.FinishDragging(_column, _dragging)
        End Sub

        ' lost focus? cancel
        Protected Overrides Sub OnLeave(ByVal a As EventArgs)
            Visible = False
        End Sub

        ' ** utilities

        ' update GDI objects based on grid style
        Sub UpdateObjects()

            Dim clr As Color

            Dim cs As CellStyle = _owner.Grid.Styles("Group")

            clr = cs.BackColor
            If (_brBack Is Nothing) OrElse (Not _brBack.Color.Equals(clr)) Then
                _brBack = New SolidBrush(clr)
                _brDrag = New SolidBrush(Color.FromArgb(100, clr))
            End If

            clr = cs.ForeColor
            If (_brFore Is Nothing) OrElse (Not _brFore.Color.Equals(clr)) Then
                _brFore = New SolidBrush(clr)
            End If

            Font = cs.Font
        End Sub

        ' start dragging a grid column
        Sub StartDragging(ByVal col As Column)
            Dim g As C1FlexGrid = _owner.Grid
            Dim rc As Rectangle = g.GetCellRect(0, col.Index, False)
            rc.Width = col.WidthDisplay ' <<B1.2>>
            rc = g.RectangleToScreen(rc)
            rc = _owner.RectangleToClient(rc)
            StartDragging(col, rc)
        End Sub

        ' start dragging a group
        Sub StartDragging(ByVal col As Column, ByVal rc As Rectangle)
            Dim g As C1FlexGrid = _owner.Grid
            _column = col

            ' initialize position/visibility
            Size = New Size(rc.Width, rc.Height)
            Location = New Point(rc.X, rc.Y)
            Visible = True

            ' calculate clip rectangle
            _rcClip = _owner.ClientRectangle
            _rcClip.Height = g.Top + g.Rows(0).HeightDisplay

            ' keep track of the mouse position
            _ptDown = Control.MousePosition
            _offset = PointToClient(_ptDown)
            _dragging = False

            ' capture mouse to track MouseMove event
            Capture = True
        End Sub

        ' custom paint routine, usable by anyone
        Sub PaintControl(ByVal g As Graphics, ByVal rc As Rectangle, ByVal text As String, ByVal dragging As Boolean)

            ' paint control
            UpdateObjects()
            If dragging Then
                g.FillRectangle(_brDrag, rc)
            Else
                g.FillRectangle(_brBack, rc)
            End If
            g.DrawString(text, Font, _brFore, ToRCF(rc), _sf)

            ' paint border 
            ' note: ControlPaint.DrawBorder3D is not good with transparent stuff
            rc.Width = rc.Width - 1 : rc.Height = rc.Height - 1
            g.DrawLine(_pDark, rc.Left + 1, rc.Bottom, rc.Right, rc.Bottom)
            g.DrawLine(_pDark, rc.Right, rc.Bottom, rc.Right, rc.Top + 1)
            g.DrawLine(_pLite, rc.Left, rc.Bottom - 1, rc.Left, rc.Top)
            g.DrawLine(_pLite, rc.Left, rc.Top, rc.Right - 1, rc.Top)
        End Sub

        Function ToRCF(ByVal rc As Rectangle) As RectangleF
            Return New RectangleF(rc.X, rc.Y, rc.Width, rc.Height)
        End Function

    End Class
End Class
