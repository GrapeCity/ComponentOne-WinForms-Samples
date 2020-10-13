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
    Friend WithEvents C1List1 As C1.Win.C1List.C1List
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C1List1 = New C1.Win.C1List.C1List()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(40, 384)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(352, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "TextBox1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(408, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Display"
        '
        'C1List1
        '
        Me.C1List1.AddItemCols = 0
        Me.C1List1.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1List1.AllowSort = True
        Me.C1List1.AlternatingRows = False
        Me.C1List1.Caption = "C1List .Net"
        Me.C1List1.CaptionHeight = 17
        Me.C1List1.ColumnCaptionHeight = 17
        Me.C1List1.ColumnFooterHeight = 17
        Me.C1List1.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.C1List1.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1List1.ItemHeight = 15
        Me.C1List1.Location = New System.Drawing.Point(48, 16)
        Me.C1List1.MatchCol = C1.Win.C1List.MatchColEnum.DisplayMember
        Me.C1List1.MatchCompare = C1.Win.C1List.MatchCompareEnum.PartiallyEqual
        Me.C1List1.MatchEntry = C1.Win.C1List.MatchEntryEnum.None
        Me.C1List1.MatchEntryTimeout = CType(2000, Long)
        Me.C1List1.Name = "C1List1"
        Me.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1List1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1List1.ScrollTips = False
        Me.C1List1.Size = New System.Drawing.Size(440, 344)
        Me.C1List1.TabIndex = 3
        Me.C1List1.Text = "C1List1"
        Me.C1List1.PropBag = CType(resources.GetObject("C1List1.PropBag"), String)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 437)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1List1, Me.Button1, Me.TextBox1})
        Me.Name = "Form1"
        Me.Text = "C1List .Net Tutorial14"
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Add the title
        Me.C1List1.AddItemTitles("File Name; Picture")
        'extend the second column width 
        Me.C1List1.ExtendRightColumn = True
        'enlarge the row height
        Me.C1List1.ItemHeight = 50

        'Add the items for the list
        Dim dir, str, fileName As String
        dir = Me.TextBox1.Text.Trim()
        Dim strCol As String()
        strCol = System.IO.Directory.GetFiles(dir, "*.bmp")

        For Each str In strCol
            fileName = str.Substring(str.LastIndexOf("\") + 1)
            Me.C1List1.AddItem(fileName & ";")
        Next

        'fire FecthCellStyle event
        Me.C1List1.Splits(0).DisplayColumns(1).FetchStyle = True

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Get image directory
        Dim dir As String
        dir = Application.StartupPath
        dir = dir.Substring(0, dir.LastIndexOf("\"))
        dir = dir.Substring(0, dir.LastIndexOf("\"))
        dir = dir & "\Flags"
        Me.TextBox1.Text = dir
    End Sub


    Private Sub C1List1_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1List.FetchCellStyleEventArgs) Handles C1List1.FetchCellStyle
        If e.Col = 1 Then
            'Get the image name
            Dim file As String
            file = Me.C1List1.Splits(0).DisplayColumns(0).DataColumn.CellText(e.Row)
            file = Me.TextBox1.Text.Trim() & "\" & file
            e.CellStyle.ForeGroundPicturePosition = C1.Win.C1List.ForeGroundPicturePositionEnum.PictureOnly
            e.CellStyle.ForegroundImage = Image.FromFile(file)
        End If
    End Sub
End Class
