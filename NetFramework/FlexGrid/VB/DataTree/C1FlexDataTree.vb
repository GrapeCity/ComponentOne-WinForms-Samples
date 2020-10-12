' --------------------------------------------------------------------------------------
' C1FlexDataTree.vb
'
' Implements hierarchical data-binding (MS Access style) using the C1FlexGrid control.
'
' Bind the grid to a table in a hierarchical data set and any rows with child tables 
' will be displayed as tree nodes. Clicking on the expand button (+) on a fixed row 
' will open a child grid showing the child table. Child tables may in turn contain 
' more child tables (nesting is allowed with no pre-set limit).
'
' This type of data binding is similar to what is provided in Microsoft Access 2000 
' and later in its default table views.
'
' --------------------------------------------------------------------------------------
' This is a part of the C1FlexGrid package.
'
' This source code is intended as a supplement to the C1FlexGrid control and related 
' documentation provided with the product. See these sources for detailed information 
' regarding the C1FlexGrid product.
'
' The C1FlexGroup control demonstrates how you can inherit from the C1FlexGrid 
' control to provide additional functionality.
'
' You may use this code as-is or modify it for any purpose you see fit, including the 
' development of commercial applications. If you make any improvements that you would 
' like to share with other users, please post them at the C1FlexGrid newsgroup. 
' Thanks.
'
' --------------------------------------------------------------------------------------
' Version history:
'
' 1.0: December 2003
'		Sample created
'
' 1.1: August 2004
'		Added extra 'header' grid to prevent child grids from painting over parent's
'      fixed rows when the grid scrolls vertically.
'
' 1.2: March 2005
'		Added check to see if master rows have children.
'		If they don't, show an "add" glyph instead of the regular collapsed glyph 
'      (user can still open the empty detail grid to add rows if AllowAddNew is true).
' --------------------------------------------------------------------------------------
Imports C1.Win.C1FlexGrid
Imports System.ComponentModel

<ToolboxBitmap(GetType(C1FlexDataTree))>
Public Class C1FlexDataTree
    Inherits C1FlexGrid
    Implements ISupportInitialize

    '-----------------------------------------------------------------------------------
#Region "** fields"

    ' reference to hidden column that contains details rows for each master record
    '
    ' this is created automatically by a DataSet based on its Relations.
    '
    ' e.g. if the parent table is 'Orders', this could be an 'OrderDetails' table 
    ' with the order details for each order on the master data table.

    Private _colChild As Column = Nothing

    ' child grid that displays the headers rows over the native header rows.
    '
    ' this grid appears on top of all child controls and prevents children from
    ' hiding the parent grid's header rows when they scroll.

    Private _hdr As GridHeader = Nothing


    Private _suspendUpdates As Boolean = False
    ''' <summary>
    ''' Allows to suspend redrawing during heavy operations
    ''' </summary>
    Private Property SuspendUpdates() As Boolean
        Get
            Return _suspendUpdates
        End Get
        Set
            If Value <> _suspendUpdates Then
                _suspendUpdates = Value
                If _suspendUpdates Then
                    BeginUpdate()
                Else
                    EndUpdate()
                End If
            End If
        End Set
    End Property

#End Region

    '-----------------------------------------------------------------------------------
#Region "** ctor"

    Public Sub New()
        Initialize()

        ' create 'header' grid <<1.1>>
        _hdr = New GridHeader(Me)
    End Sub

#End Region

    '-----------------------------------------------------------------------------------
#Region "** interfaces"

    ' ISupportInitialize
    Public Overrides Sub BeginInit()
        MyBase.BeginInit()
    End Sub
    Public Overrides Sub EndInit()
        MyBase.EndInit()
        Initialize()
    End Sub

#End Region

    '-----------------------------------------------------------------------------------
#Region "** object model"

    ' fire event to allow setting up child grids
    ' the event sender is the child grid that was just bound
    Public Event SetupColumns As EventHandler

    Protected Overridable Sub OnSetupColumns(ByVal sender As Object)
        RaiseEvent SetupColumns(sender, EventArgs.Empty)
    End Sub

    ' get top-level grid (overall parent)
    Public ReadOnly Property ParentGrid() As C1FlexDataTree
        Get
            Dim parent As C1FlexDataTree = Me
            While TypeOf parent.Parent Is C1FlexDataTree
                parent = TryCast(parent.Parent, C1FlexDataTree)
            End While
            Return parent
        End Get
    End Property

    ' toggle row state (collapsed/expanded)
    Public Function ToggleRowState(ByVal row As Integer) As Boolean
        ' sanity
        If row < Rows.Fixed OrElse row >= Rows.Count Then
            Return False
        End If

        ' toggle collapse/expand state
        If Rows(row).UserData Is Nothing Then
            Return ExpandRow(row)
        Else
            Return CollapseRow(row)
        End If

    End Function

    ' expand all rows
    Public Sub ExpandAll(ByVal level As Integer)

        Dim needSuspendUpdates As Boolean = Not SuspendUpdates
        If needSuspendUpdates Then
            ' stop redrawing
            SuspendUpdates = True
        End If

        For r As Integer = Rows.Fixed To Rows.Count - 1

            ' expand all child rows
            Dim expanded As Boolean = ExpandRow(r)
            If expanded Then
                r += 1
            End If
        Next

        ' recurse to expand children
        If level > 0 Then
            For Each ctl As Control In Me.Controls
                Dim child As C1FlexDataTree = TryCast(ctl, C1FlexDataTree)
                If child IsNot Nothing Then
                    child.ExpandAll(level - 1)
                End If
            Next
        End If

        ' done
        If needSuspendUpdates Then
            SuspendUpdates = False
        End If
    End Sub

    ' collapse all rows
    Public Sub CollapseAll()

        For r As Integer = Rows.Fixed To Rows.Count - 1
            CollapseRow(r)
        Next
    End Sub

    ' expand row
    Public Function ExpandRow(ByVal row As Integer) As Boolean

        ' sanity
        If row < Rows.Fixed OrElse row >= Rows.Count Then
            Return False
        End If

        ' check that the row is not already expanded
        Dim childGrid As C1FlexDataTree = TryCast(Rows(row).UserData, C1FlexDataTree)
        If childGrid IsNot Nothing Then
            Return False
        End If

        ' check that we have a data source for this row
        Dim dataSource As Object = Nothing
        If _colChild IsNot Nothing Then
            dataSource = _colChild(row)
        End If

        ' check that the data source is valid
        If Not (TypeOf dataSource Is IBindingList) Then
            Return False
        End If

        ' fire BeforeCollapse event
        Dim e As New RowColEventArgs(row, -1)
        MyBase.OnBeforeCollapse(e)
        If e.Cancel Then Return False

        ' add node row (unbound) to display child
        Rows.InsertNode(row + 1, -1)

        ' make new row non-editable (it's just a placeholder)
        Rows(row + 1).AllowEditing = False

        ' create child grid
        childGrid = New C1FlexDataTree()
        If SuspendUpdates Then
            childGrid.SuspendUpdates = True
        End If
        childGrid.Visible = False
        childGrid.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal

        ' attach child grid to parent, set data source
        Controls.Add(childGrid)

        childGrid.ApplyParentStyles(Me)
        childGrid.DataSource = dataSource

        ' save references: 
        ' child grid Tag property contains a reference to the parent row
        ' parent row UserData contains a reference to the child grid
        childGrid.Tag = Rows(row)
        Rows(row).UserData = childGrid

        ' move child grid into position, make it visible
        childGrid.UpdatePosition()
        childGrid.Visible = True
        If Not SuspendUpdates Then
            childGrid.Focus()
        End If

        ' fire AfterCollapse event
        MyBase.OnAfterCollapse(e)

        ' done
        Return True
    End Function

    ' collapse row
    Public Function CollapseRow(ByVal row As Integer) As Boolean

        ' sanity
        If row < Rows.Fixed OrElse row >= Rows.Count Then
            Return False
        End If

        ' check that the row is expanded
        Dim childGrid As C1FlexDataTree = TryCast(Rows(row).UserData, C1FlexDataTree)
        If childGrid Is Nothing Then
            Return False
        End If

        ' fire BeforeCollapse event
        Dim e As New RowColEventArgs(row, -1)
        MyBase.OnBeforeCollapse(e)
        If e.Cancel Then Return False

        ' break references
        Rows(row).UserData = Nothing
        childGrid.Tag = Nothing

        ' clear child and remove it from parent
        childGrid.Controls.Clear()
        Controls.Remove(childGrid)

        ' delete container row
        Rows.Remove(row + 1)

        ' fire AfterCollapse event
        MyBase.OnAfterCollapse(e)

        ' done
        Return True
    End Function
#End Region

    '-----------------------------------------------------------------------------------
#Region "** private methods"

    ' called by ctor and ISupportInitialize to set default properties
    Private Sub Initialize()
        DrawMode = DrawModeEnum.OwnerDraw
        Cols(0).ImageAlign = ImageAlignEnum.RightCenter
        Cols(0).Width = Rows(0).HeightDisplay * 2
    End Sub

    ' update size/position of all child grids and of this grid within this parent.
    ' this is called when the grid scrolls, when it's size changes, and when 
    ' rows or columns are added, removed, or resized.
    Private Sub UpdateChildren()

        ' update position of all children
        For row As Integer = 0 To Rows.Count - 1
            Dim child As C1FlexDataTree = TryCast(Rows(row).UserData, C1FlexDataTree)
            If child IsNot Nothing Then
                child.SuspendUpdates = False
                child.UpdatePosition()
            End If
        Next
    End Sub

    Private Sub ApplyParentStyles(parent As C1FlexDataTree)
        If parent IsNot Nothing Then
            Cols(0).Width = parent.Cols(0).Width
            ShowCursor = parent.ShowCursor
            AllowAddNew = parent.AllowAddNew
            AllowDelete = parent.AllowDelete
            BorderStyle = parent.BorderStyle
            Styles.ParseString(parent.Styles.BuildString(True))
        End If
    End Sub

    ' update position of this child grid within its parent.
    ' this is called by the UpdateChildren method above and also 
    ' when child grids are created.
    Private Sub UpdatePosition()

        ' sanity
        Dim parent As C1FlexDataTree = TryCast(Me.Parent, C1FlexDataTree)
        Dim parentRow As Row = TryCast(Tag, Row)
        If parent Is Nothing OrElse parentRow Is Nothing Then
            Return
        End If

        ' get cell rectangle
        Dim row As Integer = parentRow.Index
        Dim rc As Rectangle = parent.GetCellRectDisplay(row, 0)

        ' calculate child location and client size
        rc.X = rc.Right
        rc.Y = rc.Bottom
        rc.Width = Cols(Cols.Count - 1).Right
        rc.Width = Math.Max(Cols(Cols.Count - 1).Right, parent.ScrollableRectangle.Width)
        rc.Height = Rows(Rows.Count - 1).Bottom

        ' make sure child grid width doesn't extend past parent client width
        Dim maxRight As Integer = parent.ClientSize.Width - 2
        If rc.Right > maxRight Then
            rc.Width = maxRight - rc.X
        End If

        ' update size/position
        If Location <> rc.Location Then
            Location = rc.Location
        End If
        If ClientSize <> rc.Size Then
            ClientSize = rc.Size
        End If

        ' update height of container row
        parent.Rows(row + 1).Height = Height
    End Sub

#End Region

    '-----------------------------------------------------------------------------------
#Region "** overrides"

    ' collapse row before deleting it
    Protected Overrides Sub OnBeforeDeleteRow(e As C1.Win.C1FlexGrid.RowColEventArgs)
        CollapseRow(e.Row)
        MyBase.OnBeforeDeleteRow(e)
    End Sub

    ' draw collapse/expand icon on first fixed column (right-aligned)
    '
    ' the icon is drawn if the grid contains subordinate data tables
    ' (_colChild != null)
    '
    ' the row is expanded if there is a child grid under it, otherwise
    ' it's collapsed.
    '
    Protected Overloads Overrides Sub OnOwnerDrawCell(ByVal e As OwnerDrawCellEventArgs)

        ' always call base implementation
        MyBase.OnOwnerDrawCell(e)

        ' draw collapse/expand icon
        If _colChild IsNot Nothing AndAlso e.Col = 0 AndAlso Cols.Fixed > 0 AndAlso e.Row >= Rows.Fixed AndAlso Not Rows(e.Row).IsNode AndAlso Not Rows(e.Row).IsNew Then
            If Rows(e.Row).UserData IsNot Nothing Then
                ' this row has children and they're visible
                e.Image = Glyphs(GlyphEnum.Expanded)
            Else
                ' check if this row has children <<B2>>
                Dim list As IList = TryCast(_colChild(e.Row), IList)
                If list IsNot Nothing Then
                    If list.Count > 0 Then
                        ' it does, but they're not visible
                        e.Image = Glyphs(GlyphEnum.Collapsed)
                    ElseIf Me.AllowAddNew Then
                        ' no children, but maybe the user want to add some...
                        e.Image = Glyphs(GlyphEnum.DBAdd)
                    End If
                End If
            End If
        End If
    End Sub

    ' expand/collapse child grid
    '
    ' if the user clicks the icons (drawn in the method above), either
    ' create a child grid (and bind it to the detail records), or remove
    ' the existing one.
    '
    Protected Overloads Overrides Sub OnBeforeMouseDown(ByVal e As BeforeMouseDownEventArgs)

        ' always call base implementation
        MyBase.OnBeforeMouseDown(e)

        ' check that it's the Left button and that we have a hierarchy
        If e.Button <> System.Windows.Forms.MouseButtons.Left OrElse _colChild Is Nothing Then
            Return
        End If

        ' check that it's a row header cell
        Dim hit As HitTestInfo = HitTest(e.X, e.Y)
        If hit.Type <> HitTestTypeEnum.RowHeader OrElse hit.Row < Rows.Fixed Then
            Return
        End If

        ' check that the click was over the collapse/expand icon
        If e.X < Cols(0).Right - (Glyphs(GlyphEnum.Collapsed).Width + 4) Then
            Return
        End If

        ' if the row has no children and the user can't add new, cancel <<B2>>
        Dim list As IList = TryCast(_colChild(hit.Row), IList)
        If list Is Nothing OrElse list.Count = 0 Then
            If Not AllowAddNew Then
                Return
            End If
        End If

        ' all checks OK, cancel click before proceeding
        e.Cancel = True
        [Select](hit.Row, Cols.Fixed, hit.Row, Cols.Count - 1, False)

        ' toggle row state
        ToggleRowState(hit.Row)
    End Sub

    ' update position of child grids after scrolling
    '
    ' when the grid scrolls vertically, move child grids so they
    ' stay in their proper position.
    '
    Protected Overloads Overrides Sub OnScroll(ByVal sb As ScrollBars)

        ' always call base implementation
        MyBase.OnScroll(sb)

        ' adjust horizontal position of the 'header' flex <<1.1>>
        If sb <> System.Windows.Forms.ScrollBars.Vertical Then
            _hdr.ScrollPosition = New Point(ScrollPosition.X, 0)
        End If

        ' adjust vertical position of the child grids
        If Not SuspendUpdates AndAlso sb <> System.Windows.Forms.ScrollBars.Horizontal Then
            UpdateChildren()
        End If
    End Sub

    ' update position of child grids when size changes
    '
    ' when the grid is resized, move child grids so they
    ' stay in their proper position.
    '
    Protected Overloads Overrides Sub OnSizeChanged(ByVal e As EventArgs)

        ' always call base implementation
        MyBase.OnSizeChanged(e)

        ' if this is the top-level grid, update position of child grids
        Dim parent As C1FlexDataTree = TryCast(Me.Parent, C1FlexDataTree)
        If Not SuspendUpdates AndAlso parent Is Nothing Then
            UpdateChildren()
        End If
    End Sub

    ' update position of child grids when column widths/etc change
    '
    ' when rows are added, removed, or resized, move child grids so they
    ' stay in their proper position.
    '
    Protected Overloads Overrides Sub OnGridChanged(ByVal sender As Object, ByVal e As GridChangedEventArgs)

        ' always call base implementation
        MyBase.OnGridChanged(sender, e)

        ' reset data if child column became invalid
        If _colChild IsNot Nothing AndAlso Not Cols.Contains(_colChild) Then
            ResetChildren()
        End If

        ' update positions after adding/removing/resizing rows/columns
        If Not SuspendUpdates AndAlso
        (e.GridChangedType = GridChangedTypeEnum.GridChanged OrElse
        e.GridChangedType = GridChangedTypeEnum.RowAdded OrElse
        e.GridChangedType = GridChangedTypeEnum.RowRemoved) Then
            UpdateChildren()
        End If
    End Sub

    ' keep track of column with child information (if any)
    '
    ' when the grid receives a Refresh notification from the DataSource,
    ' scan the columns looking for subordinate tables, and keep track of
    ' the column so we can draw the collapse/expand icons and bind the
    ' child grids to the subordinate tables.
    '
    ' note: this implementation keeps only one detail column per table.
    ' if the master table contains several detail columns, the grid will 
    ' only show the first subordinate column. e.g. a Client table with 
    ' ClientOrders and ClientDetails would expand to show ClientOrders
    ' only.
    '
    Protected Overloads Overrides Sub OnDataRefresh(ByVal e As ListChangedEventArgs)

        ' always call base implementation
        MyBase.OnDataRefresh(e)

        ' only want the Reset event
        If e.ListChangedType <> ListChangedType.Reset Then
            Return
        End If

        ResetChildren()
    End Sub

    Private Sub ResetChildren()

        ' clear any existing children
        Dim ii As Integer = 0
        While ii < Controls.Count
            Dim childGrid As C1FlexDataTree = TryCast(Controls(ii), C1FlexDataTree)
            If childGrid IsNot Nothing Then
                Controls.Remove(childGrid)
                ii -= 1
            End If
            ii += 1
        End While
        For i As Integer = 0 To Me.Rows.Count - 1

            ' reset all row heights
            Rows(i).Height = -1
            Rows(i).UserData = Nothing
        Next

        ' keep track of hierarchical column
        _colChild = Nothing
        For Each col As Column In Cols
            Dim type As Type = col.DataType
            If type IsNot Nothing AndAlso GetType(IList).IsAssignableFrom(type) AndAlso type IsNot GetType(Byte()) Then
                _colChild = col
                Exit For
            End If
        Next

        ' fire event to allow customization of master/child grids
        ParentGrid.OnSetupColumns(Me)
    End Sub
#End Region

    '-----------------------------------------------------------------------------------
#Region "** helper class"

    Private Class GridHeader

        Inherits C1FlexGrid

        Public Sub New(ByVal parent As C1FlexDataTree)

            ' initialize
            Dock = DockStyle.Top
            BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
            Height = Rows(Rows.Fixed - 1).Bottom
            ScrollBars = System.Windows.Forms.ScrollBars.None
            Select Case parent.BorderStyle
                Case Util.BaseControls.BorderStyleEnum.Fixed3D
                    Height = Rows(Rows.Fixed - 1).Bottom - 2
                Case Util.BaseControls.BorderStyleEnum.None
                    Height = Rows(Rows.Fixed - 1).Bottom
                Case Else
                    Height = Rows(Rows.Fixed - 1).Bottom - 1
            End Select

            ' add to parent Controls collection
            parent.Controls.Add(Me)

            ' header grid uses parent as a DataSource, causing both grids to share
            ' the same underlying grid model (rows/cols).
            DataSource = parent
        End Sub

        ' keep grids synchronized
        Protected Overloads Overrides Sub OnAfterScroll(ByVal e As RangeEventArgs)
            Dim parent As C1FlexDataTree = TryCast(Me.Parent, C1FlexDataTree)
            parent.ScrollPosition = New Point(ScrollPosition.X, parent.ScrollPosition.Y)
        End Sub

        ' call On... method on parent grid
        Protected Overloads Overrides Sub OnBeforeSort(ByVal e As SortColEventArgs)
            Dim parent As C1FlexDataTree = TryCast(Me.Parent, C1FlexDataTree)
            parent.OnBeforeSort(e)
        End Sub

        Protected Overloads Overrides Sub OnAfterSort(ByVal e As SortColEventArgs)
            Dim parent As C1FlexDataTree = TryCast(Me.Parent, C1FlexDataTree)
            parent.OnAfterSort(e)
        End Sub
    End Class
#End Region
End Class
