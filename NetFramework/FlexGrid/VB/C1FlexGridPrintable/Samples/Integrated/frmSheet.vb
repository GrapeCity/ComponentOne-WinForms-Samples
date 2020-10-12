Imports C1.Win.C1FlexGrid

Public Class frmSheet
    Inherits System.Windows.Forms.Form
    Dim range As CellRange

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
    Friend WithEvents chkWallpaper As System.Windows.Forms.CheckBox
    Friend WithEvents picDraft As System.Windows.Forms.PictureBox
    Friend WithEvents flex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctBlank As System.Windows.Forms.PictureBox
    Friend WithEvents picLeftArrow As System.Windows.Forms.PictureBox
    Friend WithEvents picRightArrow As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSheet))
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkWallpaper = New System.Windows.Forms.CheckBox
        Me.picDraft = New System.Windows.Forms.PictureBox
        Me.flex = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pctBlank = New System.Windows.Forms.PictureBox
        Me.picLeftArrow = New System.Windows.Forms.PictureBox
        Me.picRightArrow = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.picDraft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBlank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(604, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  Balance Sheet"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkWallpaper
        '
        Me.chkWallpaper.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWallpaper.Location = New System.Drawing.Point(156, 72)
        Me.chkWallpaper.Name = "chkWallpaper"
        Me.chkWallpaper.Size = New System.Drawing.Size(116, 24)
        Me.chkWallpaper.TabIndex = 1
        Me.chkWallpaper.Text = "Draft Wallpaper"
        '
        'picDraft
        '
        Me.picDraft.BackgroundImage = CType(resources.GetObject("picDraft.BackgroundImage"), System.Drawing.Image)
        Me.picDraft.Location = New System.Drawing.Point(276, 72)
        Me.picDraft.Name = "picDraft"
        Me.picDraft.Size = New System.Drawing.Size(40, 20)
        Me.picDraft.TabIndex = 2
        Me.picDraft.TabStop = False
        Me.picDraft.Visible = False
        '
        'flex
        '
        Me.flex.BackColor = System.Drawing.Color.White
        Me.flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.flex.Location = New System.Drawing.Point(8, 96)
        Me.flex.Name = "flex"
        Me.flex.Rows.DefaultSize = 17
        Me.flex.Size = New System.Drawing.Size(604, 416)
        Me.flex.StyleInfo = resources.GetString("flex.StyleInfo")
        Me.flex.TabIndex = 3
        Me.flex.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.flex.Tree.NodeImageCollapsed = CType(resources.GetObject("flex.Tree.NodeImageCollapsed"), System.Drawing.Image)
        Me.flex.Tree.NodeImageExpanded = CType(resources.GetObject("flex.Tree.NodeImageExpanded"), System.Drawing.Image)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(344, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 12)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'pctBlank
        '
        Me.pctBlank.Location = New System.Drawing.Point(388, 76)
        Me.pctBlank.Name = "pctBlank"
        Me.pctBlank.Size = New System.Drawing.Size(24, 16)
        Me.pctBlank.TabIndex = 5
        Me.pctBlank.TabStop = False
        '
        'picLeftArrow
        '
        Me.picLeftArrow.Image = CType(resources.GetObject("picLeftArrow.Image"), System.Drawing.Image)
        Me.picLeftArrow.Location = New System.Drawing.Point(436, 72)
        Me.picLeftArrow.Name = "picLeftArrow"
        Me.picLeftArrow.Size = New System.Drawing.Size(24, 12)
        Me.picLeftArrow.TabIndex = 6
        Me.picLeftArrow.TabStop = False
        Me.picLeftArrow.Visible = False
        '
        'picRightArrow
        '
        Me.picRightArrow.Image = CType(resources.GetObject("picRightArrow.Image"), System.Drawing.Image)
        Me.picRightArrow.Location = New System.Drawing.Point(484, 72)
        Me.picRightArrow.Name = "picRightArrow"
        Me.picRightArrow.Size = New System.Drawing.Size(24, 12)
        Me.picRightArrow.TabIndex = 7
        Me.picRightArrow.TabStop = False
        Me.picRightArrow.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(430, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSheet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(620, 517)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picRightArrow)
        Me.Controls.Add(Me.picLeftArrow)
        Me.Controls.Add(Me.pctBlank)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.flex)
        Me.Controls.Add(Me.picDraft)
        Me.Controls.Add(Me.chkWallpaper)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance Sheet"
        CType(Me.picDraft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBlank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With flex
            Dim mCol As Integer, t As Integer, sp$

            .Styles.Normal.Border.Style = BorderStyleEnum.None
            .Rows.Fixed = 0
            .Cols.Fixed = 0
            .Cols.Count = 15
            .Tree.Column = 3
            .AllowMerging = AllowMergingEnum.Spill
            .AllowEditing = False
            .HighLight = HighLightEnum.Never
            .FocusRect = FocusRectEnum.None

            ' scroll tips settings
            .ScrollTips = True
            .ScrollTrack = False

            ' set variables
            mCol = .Tree.Column     ' tree column
            t = 8                   ' amount column
            sp = Space$(5)          ' outline indentention

            DoSetStyles()

            ' set title
            flex(1, 3) = "The Company Inc."
            flex.SetCellStyle(1, 3, flex.Styles("Heading"))
            .AutoSizeRow(1)
            ' set subtitle
            flex(2, 3) = "A ficticious company"
            flex(3, t) = "As of " & Format$(Now, "MMM dd, yyyy") & "   "

            ' apply pictures
            range = flex.GetCellRange(3, t - 1)
            range.Image = PictureBox1.Image

            range = flex.GetCellRange(3, t + 1)
            range.Image = PictureBox1.Image

            ' set column width
            Dim i%
            For i = 0 To 10
                .Cols(i).Width = 13
            Next i

            .Cols(.Tree.Column).Width = 350   ' more space for the tree column
            .Cols(8).Width = 110

            '------------------------------------------------------------
            ' create outline structure
            '------------------------------------------------------------
            DoGroup(3, 0)
            DoGroup(4, 1)
            DoGroup(5, 2)
            DoGroup(6, 3)
            DoGroup(13, 3)
            DoGroup(17, 3)
            DoGroup(26, 2)
            DoGroup(27, 3)
            DoGroup(33, 1)
            DoGroup(34, 2)
            DoGroup(35, 3)
            DoGroup(40, 2)

            ' enter data
            flex(3, mCol) = "BALANCE SHEET"
            flex(4, mCol) = "ASSETS"
            flex(4, t) = "3,972,500.00"

            flex(5, mCol) = "Current Assets"
            flex(5, t) = "1,232,500.00"

            flex(6, mCol) = "Checking/Savings"
            flex(6, t) = "340,070.00"
            flex(7, mCol) = sp & "Bank - Checking"
            flex(7, t) = "32,500.00"
            flex(8, mCol) = sp & "Bank - Money Market"
            flex(8, t) = "140,070.00"
            flex(9, mCol) = sp & "Bank ComponentOne -  Money Market"
            flex(9, t) = "94,080.00"
            flex(10, mCol) = sp & "Bank ComponentOne - Savings"
            flex(10, t) = "73,420.00"
            flex(11, mCol) = "Total Checking/Savings"
            flex(11, t) = "340,070.00"

            flex(13, mCol) = "Accounts Receivable"
            flex(13, t) = "280,500.00"
            flex(14, mCol) = sp & sp & "Accounts Receivable"
            flex(14, t) = "280,500.00"
            flex(15, mCol) = "Total Accounts Receivable"
            flex(14, t) = "280,500.00"
            flex(15, t) = "280,500.00"

            flex(17, mCol) = "Other Current Assets"
            flex(17, t) = "611,930.00"
            flex(18, mCol) = sp & sp & "Other Receivables"
            flex(18, t) = "32,500.00"
            flex(19, mCol) = sp & sp & "Short Term Investments"
            flex(19, t) = "432,100.00"
            flex(20, mCol) = sp & sp & "Inventory"
            flex(20, t) = "15,440.00"
            flex(21, mCol) = sp & sp & "Pre-paid Expenses"
            flex(21, t) = "131,890.00"
            flex(22, mCol) = "Total Other Current Assets"
            flex(22, t) = "611,930.00"

            flex(24, mCol) = "Total Current Assets"
            flex(24, t) = "1,232,500.00"
            flex(24, t) = &H8000000F

            flex(26, mCol) = "Fixed Assets"
            flex(26, t) = "2,740,000.00"
            flex(27, mCol) = "Fixed Assets"
            flex(27, t) = "2,740,000.00"
            flex(28, mCol) = sp & sp & "Accumulated Depreciation"
            flex(28, t) = "1,240,000.00"
            flex(29, mCol) = sp & sp & "Equipment"
            flex(29, t) = "1,500,000.00"
            flex(30, mCol) = "Total Fixed Assets"
            flex(30, t) = "2,740,000.00"

            flex(33, mCol) = "LIABILITIES & EQUITY"
            flex(33, t) = "3,972,500.00"
            flex(34, mCol) = "Liabilities"
            flex(34, t) = "235,400.00"
            flex(35, mCol) = "Current Liabilities"
            flex(35, t) = "235,400.00"
            flex(36, mCol) = sp & sp & "Accounts Payable"
            flex(36, t) = "64,250.00"
            flex(37, mCol) = sp & sp & "Payroll Liabilities"
            flex(37, t) = "171,150.00"
            flex(38, mCol) = "Total Current Liabilities"
            flex(38, t) = "235,400.00"

            flex(40, mCol) = "Equity"
            flex(40, t) = "3,737,100.00"
            flex(41, mCol) = sp & sp & "Retained Earnings"
            flex(41, t) = "570,000.00"
            flex(42, mCol) = sp & sp & "Net Income"
            flex(42, t) = "1,750,000.00"
            flex(43, mCol) = sp & sp & "Common Stock"
            flex(43, t) = "640,000.00"
            flex(44, mCol) = sp & sp & "Paid-In Capital"
            flex(44, t) = "777,100.00"
            flex(45, mCol) = "Total Equity"
            flex(45, t) = "3,737,100.00"

            DoDrawSubtotalLines()
        End With

    End Sub

    Private Sub DoGroup(ByVal Row As Integer, ByVal lvl As Integer)

        ' set the row as a group
        flex.Rows(Row).IsNode = True

        ' set the indentation level of the group
        flex.Rows(Row).Node.Level = lvl

        If lvl = 0 Then Exit Sub

        If lvl = 1 Then flex.SetCellStyle(Row, 8, flex.Styles("Contrast"))

    End Sub

    Private Sub flex_BeforeScrollTip(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles flex.BeforeScrollTip

        If e.Row < 3 Or flex(e.Row, 3) = "" Then Exit Sub
        flex.ScrollTipText = " " & Trim$(flex(e.Row, 3)) & " "

    End Sub

    Private Sub DoSetStyles()

        Dim s As CellStyle
        '----------------------------------------------
        ' Heading
        '----------------------------------------------
        s = flex.Styles.Add("Heading")
        s.ForeColor = Color.RoyalBlue
        s.Font = New Font(flex.Styles.Normal.Font, FontStyle.Bold)
        s.Font = New Font(flex.Font.Name, 14)

        '----------------------------------------------
        ' Contrast
        '----------------------------------------------
        s = flex.Styles.Add("Contrast")
        s.ForeColor = Color.White
        s.BackColor = Color.Black

        '----------------------------------------------
        ' OneLine
        '----------------------------------------------
        s = flex.Styles.Add("OneLine")
        s.Border.Direction = BorderDirEnum.Vertical
        s.Border.Style = BorderStyleEnum.Double


    End Sub

    Private Sub DoDrawSubtotalLines()

        With flex
            .SetCellStyle(11, 8, .Styles("OneLine"))
            .SetCellStyle(15, 8, .Styles("OneLine"))
            .SetCellStyle(22, 8, .Styles("OneLine"))
            .SetCellStyle(24, 8, .Styles("OneLine"))
            .SetCellStyle(30, 8, .Styles("OneLine"))
            .SetCellStyle(38, 8, .Styles("OneLine"))
            .SetCellStyle(45, 8, .Styles("OneLine"))
        End With

    End Sub


    Private Sub flex_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles flex.MouseMove
        Static r As Integer

        ' avoid extra work
        If flex.MouseRow = r Then Exit Sub

        ' MouseRow returns -1 when not over sheet
        If flex.MouseRow = -1 Then Exit Sub
        r = flex.MouseRow

        ' move selection (even with no click)
        flex.Select(r, 8)

        ' remove cursor image
        range = flex.GetCellRange(4, 7, flex.Rows.Count - 1, 7)
        range.Image = pctBlank.Image

        range = flex.GetCellRange(4, 9, flex.Rows.Count - 1, 9)
        range.Image = pctBlank.Image

        ' show cursor image if there is some text in column 5
        Try
            If r < 4 Or flex(r, 8) = "" Then Exit Sub
        Catch ex As InvalidCastException
        End Try

        range = flex.GetCellRange(r, 7)
        range.Image = picLeftArrow.Image

        range = flex.GetCellRange(r, 9)
        range.Image = picRightArrow.Image

    End Sub

    Private Sub chkWallpaper_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWallpaper.CheckedChanged

        If chkWallpaper.Checked Then
            flex.BackColor = System.Drawing.Color.Transparent
            flex.BackgroundImage = picDraft.BackgroundImage
        Else
            flex.BackColor = System.Drawing.Color.White
            flex.BackgroundImage = Nothing
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim printer As C1.Win.C1FlexGrid.C1FlexGridPrintable
        printer = New C1.Win.C1FlexGrid.C1FlexGridPrintable(flex)
        printer.PrintPreview()
    End Sub
End Class
