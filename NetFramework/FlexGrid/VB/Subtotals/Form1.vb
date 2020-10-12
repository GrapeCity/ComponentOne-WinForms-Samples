Imports System
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified imports  the Windows Form Designer.  
    'Do not modify it imports  the code editor.
    Friend WithEvents _btnPrint As System.Windows.Forms.Button
    Friend WithEvents _chkAbove As System.Windows.Forms.CheckBox
    Friend WithEvents _chkGrand As System.Windows.Forms.CheckBox
    Friend WithEvents _chkDirection As System.Windows.Forms.CheckBox
    Friend WithEvents _chkRegion As System.Windows.Forms.CheckBox
    Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._btnPrint = New System.Windows.Forms.Button()
        Me._chkAbove = New System.Windows.Forms.CheckBox()
        Me._chkGrand = New System.Windows.Forms.CheckBox()
        Me._chkDirection = New System.Windows.Forms.CheckBox()
        Me._chkRegion = New System.Windows.Forms.CheckBox()
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_btnPrint
        '
        Me._btnPrint.Location = New System.Drawing.Point(424, 8)
        Me._btnPrint.Name = "_btnPrint"
        Me._btnPrint.Size = New System.Drawing.Size(72, 20)
        Me._btnPrint.TabIndex = 7
        Me._btnPrint.Text = "&Print"
        '
        '_chkAbove
        '
        Me._chkAbove.Checked = True
        Me._chkAbove.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkAbove.Location = New System.Drawing.Point(8, 8)
        Me._chkAbove.Name = "_chkAbove"
        Me._chkAbove.Size = New System.Drawing.Size(144, 16)
        Me._chkAbove.TabIndex = 6
        Me._chkAbove.Text = "Subtotals Above Data"
        '
        '_chkGrand
        '
        Me._chkGrand.Checked = True
        Me._chkGrand.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkGrand.Location = New System.Drawing.Point(168, 8)
        Me._chkGrand.Name = "_chkGrand"
        Me._chkGrand.Size = New System.Drawing.Size(72, 16)
        Me._chkGrand.TabIndex = 5
        Me._chkGrand.Text = "Grand"
        '
        '_chkDirection
        '
        Me._chkDirection.Checked = True
        Me._chkDirection.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkDirection.Location = New System.Drawing.Point(256, 8)
        Me._chkDirection.Name = "_chkDirection"
        Me._chkDirection.Size = New System.Drawing.Size(72, 16)
        Me._chkDirection.TabIndex = 3
        Me._chkDirection.Text = "Direction"
        '
        '_chkRegion
        '
        Me._chkRegion.Checked = True
        Me._chkRegion.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkRegion.Location = New System.Drawing.Point(336, 8)
        Me._chkRegion.Name = "_chkRegion"
        Me._chkRegion.Size = New System.Drawing.Size(80, 16)
        Me._chkRegion.TabIndex = 4
        Me._chkRegion.Text = "Region"
        '
        '_flex
        '
        Me._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Location = New System.Drawing.Point(8, 32)
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(536, 280)
        Me._flex.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 317)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me._btnPrint, Me._chkAbove, Me._chkGrand, Me._chkDirection, Me._chkRegion})
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'populate grid
        Dim rnd As New Random()
        _flex.Rows.Count = 14
        _flex(0, 1) = "Direction"
        _flex(0, 2) = "Region"
        Dim rg As CellRange = _flex.GetCellRange(0, 3, 0, _flex.Cols.Count - 1)
        rg.Data = "Rnd"
        Dim r As Integer
        For r = 1 To _flex.Rows.Count - 1
            _flex(r, 0) = r
            If r < 7 Then
                _flex(r, 1) = "Inbound"
            Else
                _flex(r, 1) = "Outbound"
            End If

            If r < 3 Then
                _flex(r, 2) = "North"
            ElseIf r < 7 Then
                _flex(r, 2) = "South"
            ElseIf r < 10 Then
                _flex(r, 2) = "East"
            Else
                _flex(r, 2) = "West"
            End If

            Dim c As Integer
            For c = 3 To _flex.Cols.Count - 1
                _flex(r, c) = rnd.Next(1000)
                _flex.Cols(c).Format = "#,###"
            Next
        Next

        'set up styles
        Dim s As CellStyle = _flex.Styles(CellStyleEnum.Subtotal0)
        s.BackColor = Color.Black
        s.ForeColor = Color.White
        s.Font = New Font(_flex.Font, FontStyle.Bold)

        s = _flex.Styles(CellStyleEnum.Subtotal1)
        s.BackColor = Color.DarkBlue
        s.ForeColor = Color.White
        s = _flex.Styles(CellStyleEnum.Subtotal2)
        s.BackColor = Color.DarkRed
        s.ForeColor = Color.White

        'more setup
        _flex.AllowDragging = AllowDraggingEnum.None
        _flex.AllowEditing = False
        _flex.Cols(0).WidthDisplay \= 3
        _flex.Tree.Column = 1

        'show totals
        updatetotals()
    End Sub

    Private Sub UpdateTotals()
        'clear existing totals
        _flex.Subtotal(AggregateEnum.Clear)

        'calculate subtotals (three levels, totals on every column)
        Dim c As Integer
        For c = 3 To _flex.Cols.Count - 1
            If _chkGrand.Checked Then
                _flex.Subtotal(AggregateEnum.Sum, 0, -1, c, "Grand Total")
            End If
            If _chkDirection.Checked Then _flex.Subtotal(AggregateEnum.Sum, 1, 1, c, "Total for {0}")
            If _chkRegion.Checked Then _flex.Subtotal(AggregateEnum.Sum, 2, 2, c, "Total for {0}")
        Next

        'done, autosize columns to finish
        _flex.AutoSizeCols()

    End Sub

    Private Sub _chk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _chkAbove.CheckedChanged, _chkDirection.CheckedChanged, _chkGrand.CheckedChanged, _chkRegion.CheckedChanged
        'set subtotal position
        If _chkAbove.Checked Then
            _flex.SubtotalPosition = SubtotalPositionEnum.AboveData
        Else
            _flex.SubtotalPosition = SubtotalPositionEnum.BelowData
        End If

        UpdateTotals()
    End Sub


    Private Sub _btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnPrint.Click
        Dim pd As PrintDocument = _flex.PrintParameters.PrintDocument
        pd.DefaultPageSettings.Landscape = True
        Dim m As Margins = pd.DefaultPageSettings.Margins
        m.Left = 25
        m.Right = 25
        m.Top = 25
        m.Bottom = 25
        _flex.PrintGrid("Subtotals", PrintGridFlags.ShowPreviewDialog Or PrintGridFlags.FitToPage)

    End Sub
End Class
