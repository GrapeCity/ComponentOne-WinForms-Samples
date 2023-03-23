Public Class frmSubtotals
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkMerge As System.Windows.Forms.CheckBox
    Friend WithEvents chkSubTotals As System.Windows.Forms.CheckBox
    Friend WithEvents flex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubtotals))
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkMerge = New System.Windows.Forms.CheckBox
        Me.chkSubTotals = New System.Windows.Forms.CheckBox
        Me.flex = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(728, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  SubTotals"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkMerge
        '
        Me.chkMerge.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMerge.Location = New System.Drawing.Point(132, 72)
        Me.chkMerge.Name = "chkMerge"
        Me.chkMerge.Size = New System.Drawing.Size(104, 24)
        Me.chkMerge.TabIndex = 1
        Me.chkMerge.Text = "Merge Cells"
        '
        'chkSubTotals
        '
        Me.chkSubTotals.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSubTotals.Location = New System.Drawing.Point(132, 96)
        Me.chkSubTotals.Name = "chkSubTotals"
        Me.chkSubTotals.Size = New System.Drawing.Size(148, 24)
        Me.chkSubTotals.TabIndex = 2
        Me.chkSubTotals.Text = "Automatic SubTotals"
        '
        'flex
        '
        Me.flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.flex.Cursor = System.Windows.Forms.Cursors.Default
        Me.flex.Location = New System.Drawing.Point(8, 128)
        Me.flex.Name = "flex"
        Me.flex.Rows.DefaultSize = 17
        Me.flex.Size = New System.Drawing.Size(728, 344)
        Me.flex.StyleInfo = resources.GetString("flex.StyleInfo")
        Me.flex.TabIndex = 3
        Me.flex.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.flex.Tree.NodeImageCollapsed = CType(resources.GetObject("flex.Tree.NodeImageCollapsed"), System.Drawing.Image)
        Me.flex.Tree.NodeImageExpanded = CType(resources.GetObject("flex.Tree.NodeImageExpanded"), System.Drawing.Image)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(538, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSubtotals
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 477)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.flex)
        Me.Controls.Add(Me.chkSubTotals)
        Me.Controls.Add(Me.chkMerge)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSubtotals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subtotals"
        CType(Me.flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function mRegion() As String

        Select Case Int((Rnd() * 1000) Mod 4)
            Case 0 : mRegion = "North"
            Case 1 : mRegion = "East"
            Case 2 : mRegion = "South"
            Case Else : mRegion = "West"
        End Select

    End Function

    Private Function Employee() As String

        Select Case Int((Rnd() * 1000) Mod 3)
            Case 0 : Employee = "Mary"
            Case 1 : Employee = "Sarah"
            Case Else : Employee = "Paula"
        End Select

    End Function

    Private Function Sales() As String

        Sales = 5000 + Rnd() * 10000

    End Function

    Private Function Product() As String

        Select Case Int((Rnd() * 1000) Mod 4)
            Case 0 : Product = "SizerOne"
            Case 1 : Product = "C1 Chart"
            Case Else : Product = "FlexGrid"
        End Select

    End Function


    Private Sub frmSubtotals_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i%
        With flex

            ' set dimension
            .Rows.Count = 0
            .Cols.Count = 4
            .Cols.Fixed = 0
            .AllowEditing = True
            .AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
            .ExtendLastCol = True
            .HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
            .FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None

            ' customize look and feel of columns

            .Cols(3).Format = "#,###.00"


            ' use pipe instead tab in additem
            .ClipSeparators = "|;"

            ' enter grid title
            .AddItem("Region|Product|Employee|Sales")
            .Rows.Fixed = 1

            ' add data
            For i = 0 To 50
                .AddItem(mRegion() & "|" & Product() & "|" & Employee() & "|" & Sales())
            Next

            ' sort the data
            .AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Columns
            .Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, 0, .Cols.Count - 1)

        End With

    End Sub


    Private Sub flex_AfterDragColumn(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.DragRowColEventArgs) Handles flex.AfterDragColumn

        ' sort the data
        flex.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, 0, flex.Cols.Count - 1)

        ' recalculate subtotals if necessary
        If chkSubTotals.Checked Then DoSubtotals()

    End Sub

    Private Sub chkMerge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMerge.CheckedChanged
        If chkMerge.Checked Then
            flex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
            flex.Cols(0).AllowMerging = True
            flex.Cols(1).AllowMerging = True
            flex.Cols(2).AllowMerging = True
        Else
            flex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        End If
    End Sub

    Private Sub chkSubtotals_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSubTotals.CheckedChanged

        If chkSubTotals.Checked Then

            DoSubtotals()

        Else
            flex.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
        End If

    End Sub
    Private Sub DoSubtotals()
        With flex
            .Redraw = False

            ' set the tree on column 0
            .Tree.Column = 0
            .Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.Simple

            'calculate subtotals
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, 0, 3, "{0}")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 1, 3, "{0}")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 2, 2, 3, "{0}")

            'change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Moccasin
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Black

            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.Linen
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Black

            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal2).BackColor = Color.Beige
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal2).ForeColor = Color.Black

            '.AutoSizeCols()
            .Cols(0).Width = 150
            .Cols(1).Width = 150
            .Cols(2).Width = 150

            .Redraw = True

        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim printer As C1FlexGridPrintable.C1.Win.C1FlexGrid.C1FlexGridPrintable
        printer = New C1FlexGridPrintable.C1.Win.C1FlexGrid.C1FlexGridPrintable(flex)
        printer.PrintInfo.ShowOptionsDialog = True
        printer.PrintPreview()
    End Sub
End Class
