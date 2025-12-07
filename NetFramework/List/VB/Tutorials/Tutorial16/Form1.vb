Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim tb As DataTable 'A copy of the data
    Dim borderColor As Color
    Dim bLeft, bTop, bRight, bBottom As Integer
    Dim bType As C1.Win.List.BorderTypeEnum

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsCustomer1 As Tutorial16.DsCustomer
    Friend WithEvents C1List1 As C1.Win.List.C1List
    Friend WithEvents C1Combo1 As C1.Win.List.C1Combo
    Friend WithEvents C1Combo2 As C1.Win.List.C1Combo
    Friend WithEvents C1Combo3 As C1.Win.List.C1Combo
    Friend WithEvents C1Combo4 As C1.Win.List.C1Combo
    Friend WithEvents C1Combo5 As C1.Win.List.C1Combo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.DsCustomer1 = New Tutorial16.DsCustomer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.C1Combo4 = New C1.Win.List.C1Combo()
        Me.C1Combo3 = New C1.Win.List.C1Combo()
        Me.C1Combo2 = New C1.Win.List.C1Combo()
        Me.C1Combo1 = New C1.Win.List.C1Combo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.C1List1 = New C1.Win.List.C1List()
        Me.C1Combo5 = New C1.Win.List.C1Combo()
        CType(Me.DsCustomer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1Combo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsCustomer1
        '
        Me.DsCustomer1.DataSetName = "DsCustomer"
        Me.DsCustomer1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsCustomer1.Namespace = "http://www.tempuri.org/DsCustomer.xsd"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1Combo4, Me.C1Combo3, Me.C1Combo2, Me.C1Combo1, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(32, 376)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Border Size"
        '
        'C1Combo4
        '
        Me.C1Combo4.AddItemCols = 0
        Me.C1Combo4.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo4.AllowColMove = True
        Me.C1Combo4.AllowSort = True
        Me.C1Combo4.AlternatingRows = False
        Me.C1Combo4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.C1Combo4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1Combo4.Caption = ""
        Me.C1Combo4.CaptionHeight = 17
        Me.C1Combo4.CellTips = C1.Win.List.CellTipEnum.NoCellTips
        Me.C1Combo4.CellTipsDelay = 500
        Me.C1Combo4.CellTipsWidth = 0
        Me.C1Combo4.ColumnCaptionHeight = 17
        Me.C1Combo4.ColumnFooterHeight = 17
        Me.C1Combo4.ColumnFooters = False
        Me.C1Combo4.ColumnHeaders = True
        Me.C1Combo4.ColumnWidth = -1
        Me.C1Combo4.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList

        Me.C1Combo4.DataMode = C1.Win.List.DataModeEnum.AddItem
        Me.C1Combo4.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo4.DefColWidth = 0
        Me.C1Combo4.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo4.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1Combo4.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo4.EditorHeight = 21
        Me.C1Combo4.EmptyRows = False
        Me.C1Combo4.ExtendRightColumn = False
        Me.C1Combo4.FetchRowStyles = False
        Me.C1Combo4.GapHeight = 2
        Me.C1Combo4.IntegralHeight = False
        Me.C1Combo4.ItemHeight = 15
        Me.C1Combo4.Location = New System.Drawing.Point(104, 144)
        Me.C1Combo4.MatchEntryTimeout = 100
        Me.C1Combo4.MaxDropDownItems = CType(5, Short)
        Me.C1Combo4.MaxLength = 32767
        Me.C1Combo4.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo4.Name = "C1Combo4"
        Me.C1Combo4.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:High" & _
        "lightText;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{Alig" & _
        "nHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVer" & _
        "t:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Styl" & _
        "e8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.List.ListBoxView" & _
        " AllowColSelect=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" Colu" & _
        "mnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRec" & _
        "t>0, 0, 118, 198</ClientRect><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRo" & _
        "wStyle parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /" & _
        "><GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""St" & _
        "yle2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle pa" & _
        "rent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><Record" & _
        "SelectorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Sele" & _
        "cted"" me=""Style5"" /><Style parent="""" me=""Normal"" /></C1.Win.List.ListBoxView><" & _
        "/Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""H" & _
        "eading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capt" & _
        "ion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Select" & _
        "ed"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""Even" & _
        "Row"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSe" & _
        "lector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vert" & _
        "Splits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</De" & _
        "faultRecSelWidth></Blob>"
        Me.C1Combo4.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo4.RowTracking = True
        Me.C1Combo4.ScrollTips = False
        Me.C1Combo4.ScrollTrack = True
        Me.C1Combo4.SelectionLength = 0
        Me.C1Combo4.SelectionStart = 0
        Me.C1Combo4.Size = New System.Drawing.Size(120, 21)
        Me.C1Combo4.TabIndex = 7
        Me.C1Combo4.TabStop = False
        Me.C1Combo4.Text = ""
        '
        'C1Combo3
        '
        Me.C1Combo3.AddItemCols = 0
        Me.C1Combo3.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo3.AllowColMove = True
        Me.C1Combo3.AllowSort = True
        Me.C1Combo3.AlternatingRows = False
        Me.C1Combo3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.C1Combo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1Combo3.Caption = ""
        Me.C1Combo3.CaptionHeight = 17
        Me.C1Combo3.CellTips = C1.Win.List.CellTipEnum.NoCellTips
        Me.C1Combo3.CellTipsDelay = 500
        Me.C1Combo3.CellTipsWidth = 0
        Me.C1Combo3.ColumnCaptionHeight = 17
        Me.C1Combo3.ColumnFooterHeight = 17
        Me.C1Combo3.ColumnFooters = False
        Me.C1Combo3.ColumnHeaders = True
        Me.C1Combo3.ColumnWidth = -1
        Me.C1Combo3.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList
        Me.C1Combo3.DataMode = C1.Win.List.DataModeEnum.AddItem
        Me.C1Combo3.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo3.DefColWidth = 0
        Me.C1Combo3.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo3.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1Combo3.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo3.EditorHeight = 21
        Me.C1Combo3.EmptyRows = False
        Me.C1Combo3.ExtendRightColumn = False
        Me.C1Combo3.FetchRowStyles = False
        Me.C1Combo3.GapHeight = 2
        Me.C1Combo3.IntegralHeight = False
        Me.C1Combo3.ItemHeight = 15
        Me.C1Combo3.Location = New System.Drawing.Point(104, 104)
        Me.C1Combo3.MatchEntryTimeout = 100
        Me.C1Combo3.MaxDropDownItems = CType(5, Short)
        Me.C1Combo3.MaxLength = 32767
        Me.C1Combo3.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo3.Name = "C1Combo3"
        Me.C1Combo3.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:High" & _
        "lightText;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{Alig" & _
        "nHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVer" & _
        "t:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Styl" & _
        "e8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.List.ListBoxView" & _
        " AllowColSelect=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" Colu" & _
        "mnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRec" & _
        "t>0, 0, 118, 198</ClientRect><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRo" & _
        "wStyle parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /" & _
        "><GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""St" & _
        "yle2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle pa" & _
        "rent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><Record" & _
        "SelectorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Sele" & _
        "cted"" me=""Style5"" /><Style parent="""" me=""Normal"" /></C1.Win.List.ListBoxView><" & _
        "/Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""H" & _
        "eading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capt" & _
        "ion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Select" & _
        "ed"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""Even" & _
        "Row"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSe" & _
        "lector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vert" & _
        "Splits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</De" & _
        "faultRecSelWidth></Blob>"
        Me.C1Combo3.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo3.RowTracking = True
        Me.C1Combo3.ScrollTips = False
        Me.C1Combo3.ScrollTrack = True
        Me.C1Combo3.SelectionLength = 0
        Me.C1Combo3.SelectionStart = 0
        Me.C1Combo3.Size = New System.Drawing.Size(120, 21)
        Me.C1Combo3.TabIndex = 6
        Me.C1Combo3.TabStop = False
        Me.C1Combo3.Text = ""
        '
        'C1Combo2
        '
        Me.C1Combo2.AddItemCols = 0
        Me.C1Combo2.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo2.AllowColMove = True
        Me.C1Combo2.AllowSort = True
        Me.C1Combo2.AlternatingRows = False
        Me.C1Combo2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.C1Combo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1Combo2.Caption = ""
        Me.C1Combo2.CaptionHeight = 17
        Me.C1Combo2.CellTips = C1.Win.List.CellTipEnum.NoCellTips
        Me.C1Combo2.CellTipsDelay = 500
        Me.C1Combo2.CellTipsWidth = 0
        Me.C1Combo2.ColumnCaptionHeight = 17
        Me.C1Combo2.ColumnFooterHeight = 17
        Me.C1Combo2.ColumnFooters = False
        Me.C1Combo2.ColumnHeaders = True
        Me.C1Combo2.ColumnWidth = -1
        Me.C1Combo2.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList
        Me.C1Combo2.DataMode = C1.Win.List.DataModeEnum.AddItem
        Me.C1Combo2.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo2.DefColWidth = 0
        Me.C1Combo2.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo2.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1Combo2.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo2.EditorHeight = 21
        Me.C1Combo2.EmptyRows = False
        Me.C1Combo2.ExtendRightColumn = False
        Me.C1Combo2.FetchRowStyles = False
        Me.C1Combo2.GapHeight = 2
        Me.C1Combo2.IntegralHeight = False
        Me.C1Combo2.ItemHeight = 15
        Me.C1Combo2.Location = New System.Drawing.Point(104, 64)
        Me.C1Combo2.MatchEntryTimeout = 100
        Me.C1Combo2.MaxDropDownItems = CType(5, Short)
        Me.C1Combo2.MaxLength = 32767
        Me.C1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo2.Name = "C1Combo2"
        Me.C1Combo2.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:High" & _
        "lightText;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{Alig" & _
        "nHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVer" & _
        "t:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Styl" & _
        "e8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.List.ListBoxView" & _
        " AllowColSelect=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" Colu" & _
        "mnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRec" & _
        "t>0, 0, 118, 198</ClientRect><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRo" & _
        "wStyle parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /" & _
        "><GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""St" & _
        "yle2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle pa" & _
        "rent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><Record" & _
        "SelectorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Sele" & _
        "cted"" me=""Style5"" /><Style parent="""" me=""Normal"" /></C1.Win.List.ListBoxView><" & _
        "/Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""H" & _
        "eading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capt" & _
        "ion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Select" & _
        "ed"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""Even" & _
        "Row"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSe" & _
        "lector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vert" & _
        "Splits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</De" & _
        "faultRecSelWidth></Blob>"
        Me.C1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo2.RowTracking = True
        Me.C1Combo2.ScrollTips = False
        Me.C1Combo2.ScrollTrack = True
        Me.C1Combo2.SelectionLength = 0
        Me.C1Combo2.SelectionStart = 0
        Me.C1Combo2.Size = New System.Drawing.Size(120, 21)
        Me.C1Combo2.TabIndex = 5
        Me.C1Combo2.TabStop = False
        Me.C1Combo2.Text = ""
        '
        'C1Combo1
        '
        Me.C1Combo1.AddItemCols = 0
        Me.C1Combo1.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo1.AllowColMove = True
        Me.C1Combo1.AllowSort = True
        Me.C1Combo1.AlternatingRows = False
        Me.C1Combo1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.C1Combo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1Combo1.Caption = ""
        Me.C1Combo1.CaptionHeight = 17
        Me.C1Combo1.CellTips = C1.Win.List.CellTipEnum.NoCellTips
        Me.C1Combo1.CellTipsDelay = 500
        Me.C1Combo1.CellTipsWidth = 0
        Me.C1Combo1.ColumnCaptionHeight = 17
        Me.C1Combo1.ColumnFooterHeight = 17
        Me.C1Combo1.ColumnFooters = False
        Me.C1Combo1.ColumnHeaders = True
        Me.C1Combo1.ColumnWidth = -1
        Me.C1Combo1.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList
        Me.C1Combo1.DataMode = C1.Win.List.DataModeEnum.AddItem
        Me.C1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo1.DefColWidth = 0
        Me.C1Combo1.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo1.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo1.EditorHeight = 21
        Me.C1Combo1.EmptyRows = False
        Me.C1Combo1.ExtendRightColumn = False
        Me.C1Combo1.FetchRowStyles = False
        Me.C1Combo1.GapHeight = 2
        Me.C1Combo1.IntegralHeight = False
        Me.C1Combo1.ItemHeight = 15
        Me.C1Combo1.Location = New System.Drawing.Point(104, 24)
        Me.C1Combo1.MatchEntryTimeout = 100
        Me.C1Combo1.MaxDropDownItems = CType(5, Short)
        Me.C1Combo1.MaxLength = 32767
        Me.C1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo1.Name = "C1Combo1"
        Me.C1Combo1.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:High" & _
        "lightText;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{Alig" & _
        "nHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVer" & _
        "t:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Styl" & _
        "e8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.List.ListBoxView" & _
        " AllowColSelect=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" Colu" & _
        "mnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRec" & _
        "t>0, 0, 118, 198</ClientRect><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRo" & _
        "wStyle parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /" & _
        "><GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""St" & _
        "yle2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle pa" & _
        "rent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><Record" & _
        "SelectorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Sele" & _
        "cted"" me=""Style5"" /><Style parent="""" me=""Normal"" /></C1.Win.List.ListBoxView><" & _
        "/Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""H" & _
        "eading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capt" & _
        "ion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Select" & _
        "ed"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""Even" & _
        "Row"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSe" & _
        "lector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vert" & _
        "Splits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</De" & _
        "faultRecSelWidth></Blob>"
        Me.C1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo1.RowTracking = True
        Me.C1Combo1.ScrollTips = False
        Me.C1Combo1.ScrollTrack = True
        Me.C1Combo1.SelectionLength = 0
        Me.C1Combo1.SelectionStart = 0
        Me.C1Combo1.Size = New System.Drawing.Size(120, 21)
        Me.C1Combo1.TabIndex = 4
        Me.C1Combo1.TabStop = False
        Me.C1Combo1.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Right Width:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Left Width:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bottom Width:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Top Width:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(320, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Border Appearance:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Border Color"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.CheckBox2, Me.CheckBox1})
        Me.GroupBox2.Location = New System.Drawing.Point(488, 392)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 128)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scrolling"
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(24, 80)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(96, 24)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "ScrollTracking"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(24, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 16)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "ScrollTips"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("UserCode", "UserCode"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("Company", "Company"), New System.Data.Common.DataColumnMapping("Contacted", "Contacted"), New System.Data.Common.DataColumnMapping("Phone", "Phone")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Customer(Company, Contacted, FirstName, LastName, Phone, UserCode) VA" & _
        "LUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.VarWChar, 30, "Company"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.DBDate, 0, "Contacted"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, "UserCode"))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Company, Contacted, FirstName, LastName, Phone, UserCode FROM Customer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'C1List1
        '
        Me.C1List1.AddItemCols = 0
        Me.C1List1.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1List1.AllowSort = True
        Me.C1List1.AlternatingRows = False
        Me.C1List1.CaptionHeight = 17
        Me.C1List1.ColumnCaptionHeight = 17
        Me.C1List1.ColumnFooterHeight = 17
        Me.C1List1.ColumnWidth = 100
        Me.C1List1.DataMember = "Customer"
        Me.C1List1.DataMode = C1.Win.List.DataModeEnum.Normal
        Me.C1List1.DataSource = Me.DsCustomer1
        Me.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.C1List1.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1List1.ItemHeight = 15
        Me.C1List1.Location = New System.Drawing.Point(32, 16)
        Me.C1List1.MatchCol = C1.Win.List.MatchColEnum.DisplayMember
        Me.C1List1.MatchCompare = C1.Win.List.MatchCompareEnum.PartiallyEqual
        Me.C1List1.MatchEntry = C1.Win.List.MatchEntryEnum.None
        Me.C1List1.MatchEntryTimeout = CType(2000, Long)
        Me.C1List1.Name = "C1List1"
        Me.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1List1.RowDivider.Style = C1.Win.List.LineStyleEnum.None
        Me.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1List1.ScrollTips = False
        Me.C1List1.Size = New System.Drawing.Size(584, 344)
        Me.C1List1.TabIndex = 6
        Me.C1List1.Text = "C1List1"
        Me.C1List1.PropBag = CType(resources.GetObject("C1List1.PropBag"), String)
        '
        'C1Combo5
        '
        Me.C1Combo5.AddItemCols = 0
        Me.C1Combo5.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo5.AllowColMove = True
        Me.C1Combo5.AllowSort = True
        Me.C1Combo5.AlternatingRows = False
        Me.C1Combo5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.C1Combo5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1Combo5.Caption = ""
        Me.C1Combo5.CaptionHeight = 17
        Me.C1Combo5.CellTips = C1.Win.List.CellTipEnum.NoCellTips
        Me.C1Combo5.CellTipsDelay = 500
        Me.C1Combo5.CellTipsWidth = 0
        Me.C1Combo5.ColumnCaptionHeight = 17
        Me.C1Combo5.ColumnFooterHeight = 17
        Me.C1Combo5.ColumnFooters = False
        Me.C1Combo5.ColumnHeaders = True
        Me.C1Combo5.ColumnWidth = -1
        Me.C1Combo5.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList
        Me.C1Combo5.DataMode = C1.Win.List.DataModeEnum.AddItem
        Me.C1Combo5.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo5.DefColWidth = 0
        Me.C1Combo5.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo5.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1Combo5.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo5.EditorHeight = 21
        Me.C1Combo5.EmptyRows = False
        Me.C1Combo5.ExtendRightColumn = False
        Me.C1Combo5.FetchRowStyles = False
        Me.C1Combo5.GapHeight = 2
        Me.C1Combo5.IntegralHeight = False
        Me.C1Combo5.ItemHeight = 15
        Me.C1Combo5.Location = New System.Drawing.Point(320, 424)
        Me.C1Combo5.MatchEntryTimeout = 100
        Me.C1Combo5.MaxDropDownItems = CType(5, Short)
        Me.C1Combo5.MaxLength = 32767
        Me.C1Combo5.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo5.Name = "C1Combo5"
        Me.C1Combo5.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:High" & _
        "lightText;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{Alig" & _
        "nHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVer" & _
        "t:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Styl" & _
        "e8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.List.ListBoxView" & _
        " AllowColSelect=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" Colu" & _
        "mnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRec" & _
        "t>0, 0, 142, 198</ClientRect><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRo" & _
        "wStyle parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /" & _
        "><GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""St" & _
        "yle2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle pa" & _
        "rent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><Record" & _
        "SelectorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Sele" & _
        "cted"" me=""Style5"" /><Style parent="""" me=""Normal"" /></C1.Win.List.ListBoxView><" & _
        "/Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""H" & _
        "eading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capt" & _
        "ion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Select" & _
        "ed"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""Even" & _
        "Row"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSe" & _
        "lector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vert" & _
        "Splits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</De" & _
        "faultRecSelWidth></Blob>"
        Me.C1Combo5.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo5.RowTracking = True
        Me.C1Combo5.ScrollTips = False
        Me.C1Combo5.ScrollTrack = True
        Me.C1Combo5.SelectionLength = 0
        Me.C1Combo5.SelectionStart = 0
        Me.C1Combo5.Size = New System.Drawing.Size(144, 21)
        Me.C1Combo5.TabIndex = 7
        Me.C1Combo5.TabStop = False
        Me.C1Combo5.Text = "C1Combo5"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 581)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1Combo5, Me.C1List1, Me.GroupBox2, Me.Button1, Me.Label5, Me.GroupBox1})
        Me.Name = "Form1"
        Me.Text = "C1List .Net Tutorial16"
        CType(Me.DsCustomer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1Combo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OleDbConnection1.ConnectionString = AdjustConnectionString()
        Me.OleDbDataAdapter1.Fill(Me.DsCustomer1)

        tb = Me.DsCustomer1.Tables(0).Copy()
        Me.C1List1.ItemHeight = 40

        'fill each combo
        Me.CheckBox2.Checked = True
        FillCombo(Me.C1Combo1)
        FillCombo(Me.C1Combo2)
        FillCombo(Me.C1Combo3)
        FillCombo(Me.C1Combo4)
        FillCombo5()

        'init border size
        Me.bBottom = 1
        Me.bTop = 1
        Me.bLeft = 1
        Me.bRight = 1
        Me.bType = C1.Win.List.BorderTypeEnum.None
    End Sub


    'Fill each combo with numbers from 1 to 10
    Private Sub FillCombo(ByRef combo As C1.Win.List.C1Combo)
        Dim i As Integer

        For i = 1 To 10
            combo.AddItem(i.ToString())
        Next
        combo.SelectedIndex = 0

        combo.ColumnHeaders = False
    End Sub


    Private Sub FillCombo5()
        With Me.C1Combo5
            .AddItem("Fillet")
            .AddItem("Flat")
            .AddItem("Groove")
            .AddItem("Inset")
            .AddItem("InsetBevel")
            .AddItem("None")
            .AddItem("Raised")
            .AddItem("RaisedBevel")
            .SelectedIndex = 5
            .ColumnHeaders = False
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As DialogResult

        result = Me.ColorDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Me.borderColor = Me.ColorDialog1.Color
            Me.Button1.BackColor = Me.borderColor
        End If

        UpdateBorder()
    End Sub

    Private Sub UpdateBorder()
        If Me.C1List1.Splits(0).DisplayColumns(Me.C1List1.Col) Is Nothing Then
            Exit Sub
        End If

        With Me.C1List1.Splits(0).DisplayColumns(Me.C1List1.Col).Style.Borders
            .Color = Me.borderColor
            .BorderType = Me.bType
            .Bottom = Me.bBottom
            .Left = Me.bLeft
            .Right = Me.bRight
            .Top = Me.bTop
        End With
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        Me.C1List1.ScrollTips = Me.CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        Me.C1List1.ScrollTrack = Me.CheckBox2.Checked
    End Sub


    Private Sub C1List1_FetchScrollTips(ByVal sender As Object, ByVal e As C1.Win.List.FetchScrollTipsEventArgs) Handles C1List1.FetchScrollTips
        'set the ScrollTip depending on which scroll bar was moved
        Select Case e.ScrollBar
            Case C1.Win.List.ScrollBarEnum.Horizontal
                e.ScrollTip = Me.C1List1.Columns(e.ColIndex).Caption
            Case C1.Win.List.ScrollBarEnum.Vertical
                e.ScrollTip = "Record: " & CStr(e.Row + 1) & " of " & _
                CStr(Me.C1List1.ListCount) & vbCrLf & "Company: " & _
                Me.tb.Rows(e.Row).Item("Company") & vbCrLf & "User Code: " & Me.tb.Rows(e.Row).Item("UserCode")
        End Select
        e.TipStyle.ForeColor = Color.Blue
    End Sub

    Private Sub C1Combo5_RowChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Combo5.RowChange
        Select Case Me.C1Combo5.Text
            Case "Fillet"
                Me.bType = C1.Win.List.BorderTypeEnum.Fillet
            Case "Flat"
                Me.bType = C1.Win.List.BorderTypeEnum.Flat
            Case "Groove"
                Me.bType = C1.Win.List.BorderTypeEnum.Groove
            Case "Inset"
                Me.bType = C1.Win.List.BorderTypeEnum.Inset
            Case "InsetBevel"
                Me.bType = C1.Win.List.BorderTypeEnum.InsetBevel
            Case "None"
                Me.bType = C1.Win.List.BorderTypeEnum.None
            Case "Raised"
                Me.bType = C1.Win.List.BorderTypeEnum.Raised
            Case "RaisedBevel"
                Me.bType = C1.Win.List.BorderTypeEnum.RaisedBevel
        End Select

        Me.UpdateBorder()

    End Sub

    Private Sub C1Combo4_RowChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Combo4.RowChange
        Me.bRight = Me.C1Combo4.SelectedIndex + 1
        Me.UpdateBorder()
    End Sub

    Private Sub C1Combo3_RowChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Combo3.RowChange
        Me.bLeft = Me.C1Combo3.SelectedIndex + 1
        Me.UpdateBorder()
    End Sub

    Private Sub C1Combo2_RowChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Combo2.RowChange
        Me.bBottom = Me.C1Combo2.SelectedIndex + 1
        Me.UpdateBorder()
    End Sub

    Private Sub C1Combo1_RowChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Combo1.RowChange
        Me.bTop = Me.C1Combo1.SelectedIndex + 1
        Me.UpdateBorder()
    End Sub

    Private Function AdjustConnectionString() As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function
End Class
