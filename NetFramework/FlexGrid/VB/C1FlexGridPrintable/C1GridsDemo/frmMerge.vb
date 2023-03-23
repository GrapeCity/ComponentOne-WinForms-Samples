Public Class frmMerge
    Inherits System.Windows.Forms.Form
    Public imgMap As New Hashtable()

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
    Friend WithEvents chkPictures As System.Windows.Forms.CheckBox
    Friend WithEvents chkMergeCells As System.Windows.Forms.CheckBox
    Friend WithEvents flex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents imgListFlags As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMerge))
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkPictures = New System.Windows.Forms.CheckBox
        Me.chkMergeCells = New System.Windows.Forms.CheckBox
        Me.flex = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.imgListFlags = New System.Windows.Forms.ImageList(Me.components)
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
        Me.Label1.Size = New System.Drawing.Size(576, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  Merge Cells"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkPictures
        '
        Me.chkPictures.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPictures.Location = New System.Drawing.Point(12, 84)
        Me.chkPictures.Name = "chkPictures"
        Me.chkPictures.Size = New System.Drawing.Size(104, 24)
        Me.chkPictures.TabIndex = 1
        Me.chkPictures.Text = "Add Pictures"
        '
        'chkMergeCells
        '
        Me.chkMergeCells.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMergeCells.Location = New System.Drawing.Point(12, 120)
        Me.chkMergeCells.Name = "chkMergeCells"
        Me.chkMergeCells.Size = New System.Drawing.Size(104, 24)
        Me.chkMergeCells.TabIndex = 2
        Me.chkMergeCells.Text = "Merge Cells"
        '
        'flex
        '
        Me.flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.flex.Location = New System.Drawing.Point(132, 80)
        Me.flex.Name = "flex"
        Me.flex.Rows.DefaultSize = 17
        Me.flex.Size = New System.Drawing.Size(444, 296)
        Me.flex.StyleInfo = resources.GetString("flex.StyleInfo")
        Me.flex.TabIndex = 3
        Me.flex.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.flex.Tree.NodeImageCollapsed = CType(resources.GetObject("flex.Tree.NodeImageCollapsed"), System.Drawing.Image)
        Me.flex.Tree.NodeImageExpanded = CType(resources.GetObject("flex.Tree.NodeImageExpanded"), System.Drawing.Image)
        '
        'imgListFlags
        '
        Me.imgListFlags.ImageStream = CType(resources.GetObject("imgListFlags.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListFlags.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListFlags.Images.SetKeyName(0, "")
        Me.imgListFlags.Images.SetKeyName(1, "")
        Me.imgListFlags.Images.SetKeyName(2, "")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMerge
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(592, 385)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.flex)
        Me.Controls.Add(Me.chkMergeCells)
        Me.Controls.Add(Me.chkPictures)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Merge"
        CType(Me.flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMerge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

            ' use constructor to change font size
            .Font = New Font(.Font.Name, 12)
            .Styles.Fixed.Font = New Font(.Font.Name, 14)


            ' use pipe instead tab in additem
            .ClipSeparators = "|;"

            ' enter titles
            .AddItem("Country|Product|Type|Total")
            .Rows.Fixed = 1
            .Styles.Fixed.BackColor = Color.Black
            .Styles.Fixed.ForeColor = Color.White

            ' enter all data
            .AddItem("Germany|Gold|Export|1,267")
            .AddItem("Germany|Gold|Import|167")
            .AddItem("Germany|Silver|Import|167")
            .AddItem("Canada|Silver|Import|70")
            .AddItem("Canada|Silver|Export|70")
            .AddItem("Canada|Gold|Export|70")
            .AddItem("Canada|Gold|Import|70")
            .AddItem("USA|Silver|Export|70")
            .AddItem("USA|Gold|Export|70")
            .AddItem("USA|Gold|Import|70")

            ' sort the data
            .AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Columns
            .Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, 0, .Cols.Count - 1)

            ' create image list
            imgMap.Add("Canada", imgListFlags.Images(0))
            imgMap.Add("Germany", imgListFlags.Images(1))
            imgMap.Add("USA", imgListFlags.Images(2))


        End With
    End Sub

    Private Sub chkMergeCells_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMergeCells.CheckedChanged
        If chkMergeCells.Checked Then
            flex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.RestrictAll
            flex.Cols(0).AllowMerging = True
            flex.Cols(1).AllowMerging = True
            flex.Cols(2).AllowMerging = True
            flex.Cols(3).AllowDragging = False
        Else
            flex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        End If
        AutoSizeFlex()
    End Sub

    Private Sub flex_AfterDragColumn(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.DragRowColEventArgs) Handles flex.AfterDragColumn

        ' sort the data
        flex.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, 0, flex.Cols.Count - 1)

    End Sub

    Private Sub chkPictures_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPictures.CheckedChanged

        If chkPictures.Checked Then
            ' associate image list to column 0 (Country)
            flex.Cols(0).ImageMap = imgMap
            flex.Cols(0).ImageAndText = True
            flex.Cols(0).ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.LeftCenter
        Else
            flex.Cols(0).ImageMap = Nothing
        End If
        AutoSizeFlex()

    End Sub

    Private Sub AutoSizeFlex()
        With flex
            .AutoSizeCols() : .AutoSizeRows()
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim printer As C1FlexGridPrintable.C1.Win.C1FlexGrid.C1FlexGridPrintable
        printer = New C1FlexGridPrintable.C1.Win.C1FlexGrid.C1FlexGridPrintable(flex)
        printer.PrintInfo.ShowOptionsDialog = True
        printer.PrintPreview()
    End Sub
End Class
