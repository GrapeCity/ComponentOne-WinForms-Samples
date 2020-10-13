Imports System.IO
Imports System.Drawing.Drawing2D
Imports C1.Win.C1FlexGrid

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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.SystemColors.Window
        Me.fg.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.fg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fg.Name = "fg"
        Me.fg.Size = New System.Drawing.Size(399, 293)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:LightBlue;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppW" & _
        "orkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackC" & _
        "olor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeC" & _
        "olor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{Bac" & _
        "kColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;For" & _
        "eColor:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.fg.TabIndex = 0
        Me.fg.Tree.LineColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(128, Byte))
        Me.fg.Tree.NodeImageCollapsed = CType(resources.GetObject("fg.Tree.NodeImageCollapsed"), System.Drawing.Bitmap)
        Me.fg.Tree.NodeImageExpanded = CType(resources.GetObject("fg.Tree.NodeImageExpanded"), System.Drawing.Bitmap)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(399, 293)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.fg})
        Me.Name = "Form1"
        Me.Text = "C1FlexGrid Tutorial - Custom Tree"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' initialize grid layout
        fg.Cols.Fixed = 0
        fg.Cols.Count = 1
        fg.Rows.Count = 1
        fg.ExtendLastCol = True
        fg.Styles.Normal.TextAlign = TextAlignEnum.LeftCenter
        fg.Styles.Normal.Border.Style = BorderStyleEnum.None

        ' use owner-draw to add gradients
        fg.DrawMode = DrawModeEnum.OwnerDraw

        ' create custom style for tree nodes
        Dim cs As CellStyle = fg.Styles.Add("Node")
        cs.Font = New Font(Font, FontStyle.Bold + FontStyle.Italic)
        cs.ForeColor = Color.DarkBlue

        ' show outline tree
        fg.Tree.Column = 0
        fg.Tree.Style = TreeStyleFlags.SimpleLeaf
        fg.Tree.LineColor = Color.DarkBlue

        ' populate the grid
        AddDirectory("c:\", 0)

    End Sub

    Private Sub AddDirectory(ByVal dir As String, ByVal level As Integer)

        ' check whether we have access to this dir
        Dim files As String()
        Try
            files = Directory.GetFiles(dir)
        Catch
            Exit Sub
        End Try

        ' add this directory
        Dim thisDir As String
        thisDir = Path.GetFileName(dir)
        If thisDir.Length = 0 Then thisDir = dir
        fg.AddItem(thisDir.ToUpper())

        ' make this new row a node
        Dim row As Row
        row = fg.Rows(fg.Rows.Count - 1)
        row.IsNode = True

        ' apply custom style "Node" to this row
        row.Style = fg.Styles("Node")

        ' set node level
        Dim nd As Node
        nd = row.Node
        nd.Level = level

        ' add files in this directory
        Dim file As String, cnt As Integer
        cnt = 1
        For Each file In Directory.GetFiles(dir)
            fg.AddItem(Path.GetFileName(file).ToLower())
            cnt = cnt + 1
            If cnt > 10 Then Exit For
        Next

        ' add subdirectories (up to level 4)
        If level <= 4 Then
            Dim subdir As String
            cnt = 1
            For Each subdir In Directory.GetDirectories(dir)
                AddDirectory(subdir, level + 1)
                cnt = cnt + 1
                If cnt > 10 Then Exit For
            Next
        End If

    End Sub

    ' brush to use with owner-draw cells
    Dim m_GradientBrush As LinearGradientBrush

    Private Sub fg_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.Resize

        ' update gradient brush when the control is resized
        ' (the brush is used in OwnerDraw cells)
        m_GradientBrush = New LinearGradientBrush(ClientRectangle, Color.SteelBlue, Color.White, 45)

    End Sub

    Private Sub fg_OwnerDrawCell(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles fg.OwnerDrawCell

        ' draw scrollable cell background using gradient brush
        If e.Row > 0 Then

            ' draw background
            e.Graphics.FillRectangle(m_GradientBrush, e.Bounds)

            ' let the grid draw the content
            e.DrawCell(DrawCellFlags.Content)

            ' we're done drawing this cell
            e.Handled = True
        End If

    End Sub


    Private Sub fg_AfterScroll(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs) Handles fg.AfterScroll

        ' force full repaint to get gradients right
        fg.Invalidate()

    End Sub
End Class
