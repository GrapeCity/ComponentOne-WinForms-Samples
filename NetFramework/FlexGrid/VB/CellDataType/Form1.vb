Imports System
Imports System.Drawing
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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
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
        Me._flex.Size = New System.Drawing.Size(256, 325)
        Me._flex.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(256, 325)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "C1FlexGrid: Cells & DataTypes"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set up grid 
        _flex.Cols.Count = 2
        _flex.Rows.Count = 7
        _flex.Cols(0).Caption = "Item"
        _flex.Cols(1).Caption = "Value"
        _flex.Styles.Fixed.BackColor = Color.DarkGray
        _flex.Styles.Fixed.ForeColor = Color.White

        'create styles with data types, formats, etc
        Dim cs As CellStyle = _flex.Styles.Add("emp")
        cs.DataType = GetType(String)
        cs.ComboList = "|Tom|Dick|Harry"
        cs.ForeColor = Color.Navy
        cs.Font = New Font(Font, FontStyle.Bold)

        cs = _flex.Styles.Add("date")
        cs.DataType = GetType(DateTime)
        cs.Format = "dd-MMM-yy"
        cs.ForeColor = Color.DarkGoldenrod

        cs = _flex.Styles.Add("curr")
        cs.DataType = GetType(Decimal)
        cs.Format = "c"
        cs.ForeColor = Color.DarkGreen
        cs.Font = New Font(Font, FontStyle.Bold)

        cs = _flex.Styles.Add("bool")
        cs.DataType = GetType(Boolean)
        cs.ImageAlign = ImageAlignEnum.CenterCenter

        'show captions
        _flex(1, 0) = "Employee"
        _flex(2, 0) = "Start"
        _flex(3, 0) = "End"
        _flex(4, 0) = "Amount"
        _flex(5, 0) = "Discount"
        _flex(6, 0) = "Active"

        'assign styles to editable cells
        Dim rg As CellRange = _flex.GetCellRange(1, 1)
        rg.Style = _flex.Styles("emp")

        rg = _flex.GetCellRange(2, 1, 3, 1)
        rg.Style = _flex.Styles("date")

        rg = _flex.GetCellRange(4, 1, 5, 1)
        rg.Style = _flex.Styles("curr")

        rg = _flex.GetCellRange(6, 1)
        rg.Style = _flex.Styles("bool")

    End Sub
End Class
