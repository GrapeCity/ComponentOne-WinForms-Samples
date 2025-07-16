Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Xml
Imports System.IO

Imports C1.Win.FlexGrid

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
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnMoveOut As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSelect As System.Windows.Forms.ComboBox
    Friend WithEvents chkDrag As System.Windows.Forms.CheckBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents cmbAdd As System.Windows.Forms.ComboBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents btnMoveIn As System.Windows.Forms.Button
    Friend WithEvents btnMoveDown As System.Windows.Forms.Button
    Friend WithEvents btnMoveUp As System.Windows.Forms.Button
    Friend WithEvents btnMoveFirst As System.Windows.Forms.Button
    Friend WithEvents btnMoveLast As System.Windows.Forms.Button
    Friend WithEvents btnSortDescending As System.Windows.Forms.Button
    Friend WithEvents btnSortAscending As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnMoveOut = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cmbSelect = New System.Windows.Forms.ComboBox()
        Me.chkDrag = New System.Windows.Forms.CheckBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.cmbAdd = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnMoveIn = New System.Windows.Forms.Button()
        Me.btnMoveDown = New System.Windows.Forms.Button()
        Me.btnMoveUp = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnSortDescending = New System.Windows.Forms.Button()
        Me.btnSortAscending = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.flex = New C1.Win.FlexGrid.C1FlexGrid()
        Me.panel1.SuspendLayout()
        CType(Me.flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnMoveOut, Me.label1, Me.cmbSelect, Me.chkDrag, Me.btnRefresh, Me.cmbAdd, Me.label2, Me.label3, Me.label4, Me.btnMoveIn, Me.btnMoveDown, Me.btnMoveUp, Me.btnMoveFirst, Me.btnMoveLast, Me.btnSortDescending, Me.btnSortAscending, Me.btnPrint})
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(544, 56)
        Me.panel1.TabIndex = 1
        '
        'btnMoveOut
        '
        Me.btnMoveOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMoveOut.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveOut.Location = New System.Drawing.Point(156, 32)
        Me.btnMoveOut.Name = "btnMoveOut"
        Me.btnMoveOut.Size = New System.Drawing.Size(24, 20)
        Me.btnMoveOut.TabIndex = 4
        Me.btnMoveOut.Text = "<"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(344, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 16)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Add:"
        '
        'cmbSelect
        '
        Me.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelect.Items.AddRange(New Object() {"Root", "Parent", "FirstChild", "LastChild", "FirstSibling", "LastSibling", "NextSibling", "PreviousSibling"})
        Me.cmbSelect.Location = New System.Drawing.Point(152, 10)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.Size = New System.Drawing.Size(164, 21)
        Me.cmbSelect.TabIndex = 2
        '
        'chkDrag
        '
        Me.chkDrag.Checked = True
        Me.chkDrag.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDrag.Location = New System.Drawing.Point(8, 36)
        Me.chkDrag.Name = "chkDrag"
        Me.chkDrag.Size = New System.Drawing.Size(80, 16)
        Me.chkDrag.TabIndex = 1
        Me.chkDrag.Text = "&Dragging"
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Location = New System.Drawing.Point(8, 8)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 20)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "&Refresh"
        '
        'cmbAdd
        '
        Me.cmbAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdd.Items.AddRange(New Object() {"FirstChild", "LastChild", "FirstSibling", "LastSibling", "NextSibling", "PreviousSibling"})
        Me.cmbAdd.Location = New System.Drawing.Point(392, 10)
        Me.cmbAdd.Name = "cmbAdd"
        Me.cmbAdd.Size = New System.Drawing.Size(140, 21)
        Me.cmbAdd.TabIndex = 2
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(104, 12)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(44, 16)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Select:"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(104, 36)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(44, 16)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Move"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(344, 36)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(44, 16)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Sort"
        '
        'btnMoveIn
        '
        Me.btnMoveIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMoveIn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveIn.Location = New System.Drawing.Point(180, 32)
        Me.btnMoveIn.Name = "btnMoveIn"
        Me.btnMoveIn.Size = New System.Drawing.Size(24, 20)
        Me.btnMoveIn.TabIndex = 4
        Me.btnMoveIn.Text = ">"
        '
        'btnMoveDown
        '
        Me.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMoveDown.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveDown.Location = New System.Drawing.Point(236, 32)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(24, 20)
        Me.btnMoveDown.TabIndex = 4
        Me.btnMoveDown.Text = "v"
        '
        'btnMoveUp
        '
        Me.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMoveUp.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveUp.Location = New System.Drawing.Point(212, 32)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(24, 20)
        Me.btnMoveUp.TabIndex = 4
        Me.btnMoveUp.Text = "^"
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMoveFirst.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveFirst.Location = New System.Drawing.Point(264, 32)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(24, 20)
        Me.btnMoveFirst.TabIndex = 4
        Me.btnMoveFirst.Text = "^^"
        '
        'btnMoveLast
        '
        Me.btnMoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMoveLast.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveLast.Location = New System.Drawing.Point(288, 32)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(24, 20)
        Me.btnMoveLast.TabIndex = 4
        Me.btnMoveLast.Text = "vv"
        '
        'btnSortDescending
        '
        Me.btnSortDescending.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSortDescending.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortDescending.Location = New System.Drawing.Point(416, 32)
        Me.btnSortDescending.Name = "btnSortDescending"
        Me.btnSortDescending.Size = New System.Drawing.Size(24, 20)
        Me.btnSortDescending.TabIndex = 4
        Me.btnSortDescending.Text = "v"
        '
        'btnSortAscending
        '
        Me.btnSortAscending.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSortAscending.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortAscending.Location = New System.Drawing.Point(392, 32)
        Me.btnSortAscending.Name = "btnSortAscending"
        Me.btnSortAscending.Size = New System.Drawing.Size(24, 20)
        Me.btnSortAscending.TabIndex = 4
        Me.btnSortAscending.Text = "^"
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Location = New System.Drawing.Point(452, 32)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 20)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "&Print"
        '
        'flex
        '
        Me.flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flex.Location = New System.Drawing.Point(0, 56)
        Me.flex.Name = "flex"
        Me.flex.Size = New System.Drawing.Size(544, 301)
        Me.flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:ControlForeColor:ControlTextBorder:Flat,1,ControlDark,Both}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:HighlightForeColor:HighlightText}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        "ForeColor:HighlightText}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "paceBorder:Flat,1,ControlDarkDark,Both}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:BlackForeColor:W" & _
        "hite}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDarkForeColor:White}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDarkForeColor:White}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDarkForeColor" & _
        ":White}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDarkForeColor:White}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDarkForeColor:White}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDarkForeCol" & _
        "or:White}" & Microsoft.VisualBasic.ChrW(9))
        Me.flex.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 357)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.flex, Me.panel1})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Tree Handling with the Node Object"
        Me.panel1.ResumeLayout(False)
        CType(Me.flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'to handle node dragging
    Friend Structure DRAGINFO
        Public dragging As Boolean 'currently dragging
        Public checkDrag As Boolean 'currently checking mouse to start dragging
        Public row As Integer 'index of row being dragged
        Public mousedown As Point ' mouse down position

    End Structure

    Private m_DragInfo As DRAGINFO
    Private Const DRAGTOL As Integer = 5 'mouse movement before dragging starts


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'initialize grid

        'layout
        flex.Rows.Count = 1
        flex.Cols.Count = 2
        flex.Cols.Fixed = 0
        flex.ExtendLastCol = True
        flex(0, 0) = "Tag"
        flex(0, 1) = "Value"

        'styles
        Dim cs As CellStyle = flex.Styles.Normal
        cs.Border.Direction = BorderDirEnum.Vertical
        cs.TextAlign = TextAlignEnum.LeftCenter
        cs.WordWrap = False
        cs = flex.Styles.Add("Data")
        cs.BackColor = SystemColors.Info
        cs.ForeColor = SystemColors.InfoText
        cs = flex.Styles.Add("SourceNode")
        cs.BackColor = Color.Yellow
        cs.Font = New Font(flex.Font, FontStyle.Bold)

        'outline tree
        flex.Tree.Column = 0
        flex.Tree.Style = TreeStyleFlags.Simple
        flex.AllowMerging = AllowMergingEnum.Nodes

        'other
        flex.AllowResizing = AllowResizingEnum.Columns
        flex.SelectionMode = SelectionModeEnum.Cell

        'read XML document into the grid
        populategrid()
        flex.AutoSizeCols()

    End Sub

    Private Sub PopulateGrid()

        'build filename
        Dim path1 As String = Path.GetDirectoryName(Application.ExecutablePath)
        Dim i As Integer = path1.LastIndexOf("\bin")
        If i > -1 Then path1 = path1.Substring(0, i)
        Dim fileName As String = path1 + "\test.xml"

        'load XML document
        Dim xdoc As XmlDocument = New XmlDocument()
        xdoc.Load(fileName)

        'copy document to grid
        flex.Rows.Count = 1
        GetXMLData(xdoc.ChildNodes(1), 0)

    End Sub

    Private Sub GetXMLData(ByVal node As XmlNode, ByVal level As Integer)
        'skip comment nodes
        If node.NodeType = XmlNodeType.Comment Then Return

        'add new row for this node
        Dim row As Integer = flex.Rows.Count
        flex.Rows.Add()
        flex(row, 0) = node.Name
        If node.ChildNodes.Count = 1 Then
            flex(row, 1) = node.InnerText
            flex.SetCellStyle(row, 1, flex.Styles("Data"))
        End If

        'make new row a node
        flex.Rows(row).IsNode = True
        flex.Rows(row).Node.Level = level

        'if this node has children, get them as well
        If node.ChildNodes.Count > 1 Then
            'recurse to get children
            Dim child As XmlNode
            For Each child In node.ChildNodes
                GetXMLData(child, level + 1)
            Next
        End If
    End Sub

    'refresh the grid with info from XML file

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        PopulateGrid()
    End Sub

    'handle select combo

    Private Sub cmbSelect_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSelect.SelectionChangeCommitted
        'get current row's node
        Dim nd As Node = flex.Rows(flex.Row).Node

        'get relative node selected by the user
        nd = nd.GetNode(CType(cmbSelect.SelectedIndex, NodeTypeEnum))

        'if failed, show message
        If nd Is Nothing Then
            MessageBox.Show("Can't find " + cmbSelect.Text + " for this node.")
            Return
        End If

        'select node and make sure it's visible
        nd.Select()
        nd.EnsureVisible()
        flex.Focus()

    End Sub

    'handle add combo
    Private Sub cmbAdd_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAdd.SelectionChangeCommitted
        'get current row's node
        Dim nd As Node = flex.Rows(flex.Row).Node

        'add relative as requested by user
        '(could be a child or sibling)
        nd.AddNode(CType(cmbAdd.SelectedIndex + 2, NodeTypeEnum), cmbAdd.Text)
        flex.Focus()

    End Sub
    'move selected node to a new position
    Private Sub btnMove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMoveDown.Click, btnMoveFirst.Click, btnMoveIn.Click, btnMoveLast.Click, btnMoveOut.Click, btnMoveUp.Click
        'get current row's node
        Dim nd As Node = flex.Rows(flex.Row).Node

        'apply movement selected by the user
        '(this will move the selected node)
        If (sender Is btnMoveOut) Then
            nd.Move(NodeMoveEnum.Out)
        ElseIf sender Is btnMoveIn Then
            nd.Move(NodeMoveEnum.In)
        ElseIf sender Is btnMoveUp Then
            nd.Move(NodeMoveEnum.Up)
        ElseIf sender Is btnMoveDown Then
            nd.Move(NodeMoveEnum.Down)
        ElseIf sender Is btnMoveFirst Then
            nd.Move(NodeMoveEnum.First)
        ElseIf sender Is btnMoveLast Then
            nd.Move(NodeMoveEnum.Last)
        End If

        'make sure the node is still visible
        nd.EnsureVisible()
        flex.Focus()
    End Sub

    'sort selected node

    Private Sub btnSortDescending_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSortDescending.Click, btnSortAscending.Click
        'get current row's node
        Dim nd As Node = flex.Rows(flex.Row).Node

        'apply sorting selected by the user
        '(this will sort the selected node's children)
        If sender Is btnSortAscending Then
            nd.Sort(SortFlags.Ascending)
        Else
            nd.Sort(SortFlags.Descending)
        End If

        'done
        flex.Focus()

    End Sub

    'start dragging node

    Private Sub flex_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles flex.MouseDown
        m_DragInfo.checkDrag = False

        'left button, no shift: start trackign mouse to drag
        If e.Button <> MouseButtons.Left Then Return
        If Not chkDrag.Checked OrElse m_DragInfo.dragging Then Return
        If flex.MouseRow < flex.Rows.Fixed OrElse flex.MouseCol <> 0 Then Return

        'save current row and mouse position
        m_DragInfo.row = flex.Row
        m_DragInfo.mousedown = New Point(e.X, e.Y)

        'start checking
        m_DragInfo.checkDrag = True
    End Sub

    'drag node
    Private Sub flex_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles flex.MouseMove
        'if checking and the user moved past our tolerance, start dragging
        If Not m_DragInfo.checkDrag OrElse e.Button <> MouseButtons.Left Then Return
        If Math.Abs(e.X - m_DragInfo.mousedown.X) + Math.Abs(e.Y - m_DragInfo.mousedown.Y) <= DRAGTOL Then Return

        'update flags
        m_DragInfo.dragging = True

        'set cursor and highlight node
        Dim cs As CellStyle = flex.Styles("SourceNode")
        flex.Cursor = Cursors.NoMove2D
        flex.SetCellStyle(m_DragInfo.row, 0, cs)

        'check whether we can drop here
        Dim c As Cursor
        If nodrophere() Then
            c = Cursors.No
        Else
            c = Cursors.NoMove2D
        End If
    End Sub

    Private Function NoDropHere() As Boolean
        If (flex.MouseRow < flex.Rows.Fixed) Then Return True
        If (flex.MouseCol < flex.Cols.Fixed) Then Return True
        If (flex.GetDataDisplay(flex.Row, 0) = "SKU") Then Return True
        Return False
    End Function


    Private Sub flex_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles flex.MouseUp

        'we're not checking until the mouse goes down again
        m_DragInfo.checkDrag = False

        'not dragging? we're done
        If Not m_DragInfo.dragging Then Return

        'stop dragging 
        m_DragInfo.dragging = False
        Dim noStyle As CellStyle = Nothing
        flex.SetCellStyle(m_DragInfo.row, 0, noStyle)
        flex.Cursor = Cursors.Default

        'test whether the drop is allowed
        If NoDropHere() Then Return

        'move node into new parent node
        Dim ndSrc As Node = flex.Rows(m_DragInfo.row).Node
        Dim nddst As Node = flex.Rows(flex.Row).Node
        ndSrc.Move(NodeMoveEnum.ChildOf, nddst)
        ndSrc.Select()

    End Sub
    'print the grid
    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        flex.PrintGrid("FlexTree", PrintGridFlags.ShowPreviewDialog)
    End Sub
End Class
