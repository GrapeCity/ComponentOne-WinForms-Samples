Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

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
    Friend WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents C1FlexGrid1 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGrid2 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGrid3 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGrid4 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGrid5 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGrid6 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGrid7 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGrid8 As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.C1FlexGrid1 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.C1FlexGrid2 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.C1FlexGrid3 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.C1FlexGrid4 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.C1FlexGrid5 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.C1FlexGrid6 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.C1FlexGrid7 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.C1FlexGrid8 = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checkBox1
        '
        Me.checkBox1.Location = New System.Drawing.Point(544, 328)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(224, 32)
        Me.checkBox1.TabIndex = 13
        Me.checkBox1.Text = "No Rows"
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(160, 16)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Default"
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(272, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(160, 16)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Cell"
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(8, 160)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(160, 16)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Row"
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(272, 160)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(160, 16)
        Me.label4.TabIndex = 5
        Me.label4.Text = "RowRange"
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(536, 8)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(160, 16)
        Me.label5.TabIndex = 4
        Me.label5.Text = "CellRange"
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(536, 160)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(160, 16)
        Me.label6.TabIndex = 6
        Me.label6.Text = "ListBox"
        '
        'label7
        '
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(8, 312)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(160, 16)
        Me.label7.TabIndex = 8
        Me.label7.Text = "Col"
        '
        'label8
        '
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(272, 312)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(160, 16)
        Me.label8.TabIndex = 7
        Me.label8.Text = "ColRange"
        '
        'checkBox2
        '
        Me.checkBox2.Location = New System.Drawing.Point(544, 368)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(224, 32)
        Me.checkBox2.TabIndex = 12
        Me.checkBox2.Text = "No Cols"
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid1.BackColor = System.Drawing.SystemColors.Window
        Me.C1FlexGrid1.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.C1FlexGrid1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1FlexGrid1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.C1FlexGrid1.Location = New System.Drawing.Point(8, 24)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Size = New System.Drawing.Size(256, 128)
        Me.C1FlexGrid1.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.C1FlexGrid1.TabIndex = 15
        '
        'C1FlexGrid2
        '
        Me.C1FlexGrid2.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid2.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid2.BackColor = System.Drawing.SystemColors.Window
        Me.C1FlexGrid2.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.C1FlexGrid2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1FlexGrid2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.C1FlexGrid2.Location = New System.Drawing.Point(272, 24)
        Me.C1FlexGrid2.Name = "C1FlexGrid2"
        Me.C1FlexGrid2.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.Cell
        Me.C1FlexGrid2.Size = New System.Drawing.Size(256, 128)
        Me.C1FlexGrid2.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.C1FlexGrid2.TabIndex = 16
        '
        'C1FlexGrid3
        '
        Me.C1FlexGrid3.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid3.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid3.BackColor = System.Drawing.SystemColors.Window
        Me.C1FlexGrid3.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.C1FlexGrid3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1FlexGrid3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.C1FlexGrid3.Location = New System.Drawing.Point(272, 176)
        Me.C1FlexGrid3.Name = "C1FlexGrid3"
        Me.C1FlexGrid3.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.RowRange
        Me.C1FlexGrid3.Size = New System.Drawing.Size(256, 128)
        Me.C1FlexGrid3.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.C1FlexGrid3.TabIndex = 17
        '
        'C1FlexGrid4
        '
        Me.C1FlexGrid4.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid4.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid4.BackColor = System.Drawing.SystemColors.Window
        Me.C1FlexGrid4.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.C1FlexGrid4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1FlexGrid4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.C1FlexGrid4.Location = New System.Drawing.Point(8, 176)
        Me.C1FlexGrid4.Name = "C1FlexGrid4"
        Me.C1FlexGrid4.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.Row
        Me.C1FlexGrid4.Size = New System.Drawing.Size(256, 128)
        Me.C1FlexGrid4.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.C1FlexGrid4.TabIndex = 18
        '
        'C1FlexGrid5
        '
        Me.C1FlexGrid5.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid5.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid5.BackColor = System.Drawing.SystemColors.Window
        Me.C1FlexGrid5.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.C1FlexGrid5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1FlexGrid5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.C1FlexGrid5.Location = New System.Drawing.Point(272, 328)
        Me.C1FlexGrid5.Name = "C1FlexGrid5"
        Me.C1FlexGrid5.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.ColumnRange
        Me.C1FlexGrid5.Size = New System.Drawing.Size(256, 128)
        Me.C1FlexGrid5.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.C1FlexGrid5.TabIndex = 19
        '
        'C1FlexGrid6
        '
        Me.C1FlexGrid6.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid6.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid6.BackColor = System.Drawing.SystemColors.Window
        Me.C1FlexGrid6.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.C1FlexGrid6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1FlexGrid6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.C1FlexGrid6.Location = New System.Drawing.Point(8, 328)
        Me.C1FlexGrid6.Name = "C1FlexGrid6"
        Me.C1FlexGrid6.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.Column
        Me.C1FlexGrid6.Size = New System.Drawing.Size(256, 128)
        Me.C1FlexGrid6.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.C1FlexGrid6.TabIndex = 20
        '
        'C1FlexGrid7
        '
        Me.C1FlexGrid7.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid7.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid7.BackColor = System.Drawing.SystemColors.Window
        Me.C1FlexGrid7.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.C1FlexGrid7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1FlexGrid7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.C1FlexGrid7.Location = New System.Drawing.Point(536, 24)
        Me.C1FlexGrid7.Name = "C1FlexGrid7"
        Me.C1FlexGrid7.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.CellRange
        Me.C1FlexGrid7.Size = New System.Drawing.Size(256, 128)
        Me.C1FlexGrid7.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.C1FlexGrid7.TabIndex = 21
        '
        'C1FlexGrid8
        '
        Me.C1FlexGrid8.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid8.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid8.BackColor = System.Drawing.SystemColors.Window
        Me.C1FlexGrid8.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.C1FlexGrid8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1FlexGrid8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.C1FlexGrid8.Location = New System.Drawing.Point(536, 176)
        Me.C1FlexGrid8.Name = "C1FlexGrid8"
        Me.C1FlexGrid8.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.ListBox
        Me.C1FlexGrid8.Size = New System.Drawing.Size(256, 128)
        Me.C1FlexGrid8.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.C1FlexGrid8.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(800, 469)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1FlexGrid8, Me.C1FlexGrid7, Me.C1FlexGrid6, Me.C1FlexGrid5, Me.C1FlexGrid4, Me.C1FlexGrid3, Me.C1FlexGrid2, Me.C1FlexGrid1, Me.checkBox1, Me.label1, Me.label2, Me.label3, Me.label4, Me.label5, Me.label6, Me.label7, Me.label8, Me.checkBox2})
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private _i As Integer = 0

    Private Sub C1FlexGrid1_AfterSelChange(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.RangeEventArgs) Handles C1FlexGrid1.AfterSelChange, C1FlexGrid2.AfterSelChange, C1FlexGrid3.AfterSelChange, C1FlexGrid4.AfterSelChange, C1FlexGrid5.AfterSelChange, C1FlexGrid6.AfterSelChange, C1FlexGrid7.AfterSelChange, C1FlexGrid8.AfterSelChange
        _i += 1
        Console.WriteLine("c1FlexGrid1_AfterSelChange " + _i.ToString())
        Console.WriteLine("-------------------\n")
    End Sub

    Private Sub C1FlexGrid1_AfterRowColChange(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.RangeEventArgs) Handles C1FlexGrid1.AfterRowColChange, C1FlexGrid2.AfterRowColChange, C1FlexGrid3.AfterRowColChange, C1FlexGrid4.AfterRowColChange, C1FlexGrid5.AfterRowColChange, C1FlexGrid6.AfterRowColChange, C1FlexGrid7.AfterRowColChange, C1FlexGrid8.AfterRowColChange
        _i += 1
        Console.WriteLine("c1FlexGrid1_AfterRowColChange " + _i.ToString())
    End Sub

    Private Sub C1FlexGrid1_BeforeRowColChange(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.RangeEventArgs) Handles C1FlexGrid1.BeforeRowColChange, C1FlexGrid2.BeforeRowColChange, C1FlexGrid3.BeforeRowColChange, C1FlexGrid4.BeforeRowColChange, C1FlexGrid5.BeforeRowColChange, C1FlexGrid6.BeforeRowColChange, C1FlexGrid7.BeforeRowColChange, C1FlexGrid8.BeforeRowColChange
        _i += 1
        Console.WriteLine("c1FlexGrid1_BeforeRowColChange " + _i.ToString())
    End Sub

    Private Sub C1FlexGrid1_BeforeSelChange(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.RangeEventArgs) Handles C1FlexGrid1.BeforeSelChange, C1FlexGrid2.BeforeSelChange, C1FlexGrid3.BeforeSelChange, C1FlexGrid4.BeforeSelChange, C1FlexGrid5.BeforeSelChange, C1FlexGrid6.BeforeSelChange, C1FlexGrid7.BeforeSelChange, C1FlexGrid8.BeforeSelChange
        _i += 1
        Console.WriteLine("c1FlexGrid1_BeforeSelChange " + _i.ToString())
    End Sub

    Private Sub C1FlexGrid1_RowColChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1FlexGrid1.RowColChange, C1FlexGrid2.RowColChange, C1FlexGrid3.RowColChange, C1FlexGrid4.RowColChange, C1FlexGrid5.RowColChange, C1FlexGrid6.RowColChange, C1FlexGrid7.RowColChange, C1FlexGrid8.RowColChange
        _i += 1
        Console.WriteLine("c1FlexGrid1_RowColChange " + _i.ToString())
    End Sub

    Private Sub C1FlexGrid1_SelChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1FlexGrid1.SelChange, C1FlexGrid2.SelChange, C1FlexGrid3.SelChange, C1FlexGrid4.SelChange, C1FlexGrid5.SelChange, C1FlexGrid6.SelChange, C1FlexGrid7.SelChange, C1FlexGrid8.SelChange
        _i += 1
        Console.WriteLine("c1FlexGrid1_SelChange " + _i.ToString())
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Dim n As Integer
        If checkBox1.Checked Then
            n = 1
        Else
            n = 50
        End If

        C1FlexGrid1.Rows.Count = n
        C1FlexGrid2.Rows.Count = n
        C1FlexGrid3.Rows.Count = n
        C1FlexGrid4.Rows.Count = n
        C1FlexGrid5.Rows.Count = n
        C1FlexGrid6.Rows.Count = n
        C1FlexGrid7.Rows.Count = n
        C1FlexGrid8.Rows.Count = n
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        Dim n As Integer
        If checkBox2.Checked Then
            n = 1
        Else
            n = 10
        End If

        C1FlexGrid1.Cols.Count = n
        C1FlexGrid2.Cols.Count = n
        C1FlexGrid3.Cols.Count = n
        C1FlexGrid4.Cols.Count = n
        C1FlexGrid5.Cols.Count = n
        C1FlexGrid6.Cols.Count = n
        C1FlexGrid7.Cols.Count = n
        C1FlexGrid8.Cols.Count = n
    End Sub

End Class
