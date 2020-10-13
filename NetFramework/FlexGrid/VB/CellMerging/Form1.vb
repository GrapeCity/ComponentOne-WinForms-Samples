Imports C1.Win.C1FlexGrid
Imports System.Data.OleDb

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
    Friend WithEvents fgBound As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fgBound = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgBound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.BackColor = System.Drawing.SystemColors.Window
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.fg.Dock = System.Windows.Forms.DockStyle.Top
        Me.fg.Name = "fg"
        Me.fg.Size = New System.Drawing.Size(440, 120)
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
        'fgBound
        '
        Me.fgBound.BackColor = System.Drawing.SystemColors.Window
        Me.fgBound.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.fgBound.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.fgBound.Location = New System.Drawing.Point(0, 253)
        Me.fgBound.Name = "fgBound"
        Me.fgBound.Size = New System.Drawing.Size(440, 176)
        Me.fgBound.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:LightBlue;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppW" & _
        "orkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackC" & _
        "olor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeC" & _
        "olor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{Bac" & _
        "kColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;For" & _
        "eColor:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.fgBound.TabIndex = 1
        Me.fgBound.Tree.LineColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(128, Byte))
        Me.fgBound.Tree.NodeImageCollapsed = CType(resources.GetObject("fgBound.Tree.NodeImageCollapsed"), System.Drawing.Bitmap)
        Me.fgBound.Tree.NodeImageExpanded = CType(resources.GetObject("fgBound.Tree.NodeImageExpanded"), System.Drawing.Bitmap)
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Spill
        Me.C1FlexGrid1.BackColor = System.Drawing.SystemColors.Window
        Me.C1FlexGrid1.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 120)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Size = New System.Drawing.Size(440, 133)
        Me.C1FlexGrid1.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:LightBlue;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppW" & _
        "orkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackC" & _
        "olor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeC" & _
        "olor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{Bac" & _
        "kColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;For" & _
        "eColor:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.C1FlexGrid1.TabIndex = 2
        Me.C1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(128, Byte))
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 429)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1FlexGrid1, Me.fgBound, Me.fg})
        Me.Name = "Form1"
        Me.Text = "C1FlexGrid: Merging Cells"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgBound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetHeaders()
        BindGrid()
    End Sub

    Private Sub SetHeaders()
        Dim i%

        ' initialize control
        fg.Styles.Normal.WordWrap = True
        fg.Cols.Count = 9
        fg.Rows.Fixed = 2
        fg.AllowMerging = AllowMergingEnum.FixedOnly

        ' create row headers
        fg.Rows(0).AllowMerging = True

        ' four cells, will merge
        Dim rng As CellRange = fg.GetCellRange(0, 1, 0, 4)
        rng.Data = "North"

        ' four cells, will merge
        rng = fg.GetCellRange(0, 5, 0, 8)
        rng.Data = "South"
        For i = 1 To 4
            fg(1, i) = "Qtr " & i
            fg(1, i + 4) = "Qtr " & i
        Next

        ' create column header
        fg.Cols(0).AllowMerging = True

        ' two cells, will merge
        rng = fg.GetCellRange(0, 0, 1, 0)
        rng.Data = "Sales by Product"

        ' align and autozise the cells
        fg.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
        fg.AutoSizeCols(1, fg.Cols.Count - 1, 10)

    End Sub

    Private Sub BindGrid()

        ' create data source
        Dim conn As String = GetConnectionString()
        Dim sql As String = "Select Country,City,CompanyName,ContactName From Customers Order By Country,City,CompanyName,ContactName;"
        Dim da As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter(sql, conn)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)

        ' bind grid to a data source
        fgBound.DataSource = dt

        ' set up cell merging
        fgBound.AllowMerging = AllowMergingEnum.RestrictCols
        Dim i%
        For i = fgBound.Cols.Fixed To fgBound.Cols.Count - 1
            fgBound.Cols(i).AllowMerging = True
        Next

        ' make first column skinny
        fgBound.Cols(0).Width = fgBound.Rows.DefaultSize

    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

End Class
