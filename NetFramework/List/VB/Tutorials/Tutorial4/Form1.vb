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
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSet11 As Tutorial4.DataSet1
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DataSet21 As Tutorial4.DataSet2
    Friend WithEvents dblOpus As C1.Win.C1List.C1List
    Friend WithEvents dbcComp As C1.Win.C1List.C1Combo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.DataSet11 = New Tutorial4.DataSet1()
        Me.DataSet21 = New Tutorial4.DataSet2()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.dblOpus = New C1.Win.C1List.C1List()
        Me.dbcComp = New C1.Win.C1List.C1Combo()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dblOpus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbcComp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        '
        'DataSet21
        '
        Me.DataSet21.DataSetName = "DataSet2"
        Me.DataSet21.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet21.Namespace = "http://www.tempuri.org/DataSet2.xsd"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Composer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("LAST", "LAST")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Composer(Last) VALUES (?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last"))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=..\..\..\Data\" & _
        "C1ListDemo.mdb;Mode=Share Deny None;Extend" & _
        "ed Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLE" & _
        "DB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=" & _
        "1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet O" & _
        "LEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:E" & _
        "ncrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Com" & _
        "pact Without Replica Repair=False;Jet OLEDB:SFP=False"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Last FROM Composer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Opus", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Last", "Last"), New System.Data.Common.DataColumnMapping("Opus", "Opus")})})
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO Opus(Last, Opus) VALUES (?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Opus", System.Data.OleDb.OleDbType.VarWChar, 150, "Opus"))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Last, Opus FROM Opus"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'dblOpus
        '
        Me.dblOpus.AddItemCols = 0
        Me.dblOpus.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.dblOpus.AllowSort = True
        Me.dblOpus.AlternatingRows = False
        Me.dblOpus.CaptionHeight = 17
        Me.dblOpus.ColumnCaptionHeight = 17
        Me.dblOpus.ColumnFooterHeight = 17
        Me.dblOpus.ColumnWidth = 100
        Me.dblOpus.DataMode = C1.Win.C1List.DataModeEnum.Normal
        Me.dblOpus.DataSource = Me.DataSet21.Opus
        Me.dblOpus.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.dblOpus.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.dblOpus.ItemHeight = 15
        Me.dblOpus.Location = New System.Drawing.Point(224, 40)
        Me.dblOpus.MatchCol = C1.Win.C1List.MatchColEnum.DisplayMember
        Me.dblOpus.MatchCompare = C1.Win.C1List.MatchCompareEnum.PartiallyEqual
        Me.dblOpus.MatchEntry = C1.Win.C1List.MatchEntryEnum.None
        Me.dblOpus.MatchEntryTimeout = CType(2000, Long)
        Me.dblOpus.Name = "dblOpus"
        Me.dblOpus.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dblOpus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.dblOpus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dblOpus.ScrollTips = False
        Me.dblOpus.Size = New System.Drawing.Size(232, 208)
        Me.dblOpus.TabIndex = 1
        Me.dblOpus.Text = "C1List1"
        Me.dblOpus.PropBag = CType(resources.GetObject("dblOpus.PropBag"), String)
        '
        'dbcComp
        '
        Me.dbcComp.AddItemCols = 0
        Me.dbcComp.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.dbcComp.AllowColMove = True
        Me.dbcComp.AllowSort = True
        Me.dbcComp.AlternatingRows = False
        Me.dbcComp.BackColor = System.Drawing.SystemColors.Window
        Me.dbcComp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dbcComp.Caption = ""
        Me.dbcComp.CaptionHeight = 17
        Me.dbcComp.CellTips = C1.Win.C1List.CellTipEnum.NoCellTips
        Me.dbcComp.CellTipsDelay = 500
        Me.dbcComp.CellTipsWidth = 0
        Me.dbcComp.ColumnCaptionHeight = 17
        Me.dbcComp.ColumnFooterHeight = 17
        Me.dbcComp.ColumnFooters = False
        Me.dbcComp.ColumnHeaders = True
        Me.dbcComp.ColumnWidth = 100
        Me.dbcComp.DataMode = C1.Win.C1List.DataModeEnum.Normal
        Me.dbcComp.DataSource = Me.DataSet11.Composer
        Me.dbcComp.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.dbcComp.DefColWidth = 0
        Me.dbcComp.EditorBackColor = System.Drawing.SystemColors.Window
        Me.dbcComp.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dbcComp.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.dbcComp.EditorHeight = 21
        Me.dbcComp.EmptyRows = False
        Me.dbcComp.ExtendRightColumn = False
        Me.dbcComp.FetchRowStyles = False
        Me.dbcComp.GapHeight = 2
        Me.dbcComp.IntegralHeight = False
        Me.dbcComp.ItemHeight = 15
        Me.dbcComp.Location = New System.Drawing.Point(40, 48)
        Me.dbcComp.MatchEntryTimeout = 100
        Me.dbcComp.MaxDropDownItems = CType(5, Short)
        Me.dbcComp.MaxLength = 32767
        Me.dbcComp.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.dbcComp.Name = "dbcComp"
        Me.dbcComp.PropBag = "<?xml version=""1.0""?><Blob><DataCols><C1DataColumn Level=""0"" Caption=""Last"" DataF" & _
        "ield=""Last""><ValueItems /></C1DataColumn></DataCols><Styles type=""C1.Win.C1List." & _
        "Design.ContextWrapper""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;Back" & _
        "Color:ControlDark;}Style12{AlignHorz:Near;}Style2{}Style5{}Style4{}Style7{}Style" & _
        "6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:HighlightText;BackColor:Highlight;" & _
        "}Style3{}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}Foote" & _
        "r{}Caption{AlignHorz:Center;}Normal{BackColor:Window;}HighlightRow{ForeColor:Hig" & _
        "hlightText;BackColor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center" & _
        ";}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:Contro" & _
        "lText;AlignVert:Center;}Style8{}Style10{}Style11{}Style14{}Style13{AlignHorz:Nea" & _
        "r;}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView All" & _
        "owColSelect=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFo" & _
        "oterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0," & _
        " 0, 142, 198</ClientRect><internalCols><C1DisplayColumn><HeadingStyle parent=""St" & _
        "yle2"" me=""Style12"" /><Style parent=""Normal"" me=""Style13"" /><FooterStyle parent=""" & _
        "Style3"" me=""Style14"" /><Visible>True</Visible><ColumnDivider><Color>DarkGray</Co" & _
        "lor><Style>Single</Style></ColumnDivider><Height>15</Height><DCIdx>0</DCIdx></C1" & _
        "DisplayColumn></internalCols><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRo" & _
        "wStyle parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /" & _
        "><GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""St" & _
        "yle2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle pa" & _
        "rent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><Record" & _
        "SelectorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Sele" & _
        "cted"" me=""Style5"" /><Style parent="""" me=""Normal"" /></C1.Win.C1List.ListBoxView><" & _
        "/Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""H" & _
        "eading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capt" & _
        "ion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Select" & _
        "ed"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""Even" & _
        "Row"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSe" & _
        "lector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vert" & _
        "Splits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16" & _
        "</DefaultRecSelWidth></Blob>"
        Me.dbcComp.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dbcComp.RowTracking = True
        Me.dbcComp.ScrollTips = False
        Me.dbcComp.ScrollTrack = True
        Me.dbcComp.SelectionLength = 0
        Me.dbcComp.SelectionStart = 0
        Me.dbcComp.Size = New System.Drawing.Size(144, 21)
        Me.dbcComp.TabIndex = 2
        Me.dbcComp.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 285)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dbcComp, Me.dblOpus})
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dblOpus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbcComp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OleDbConnection1.ConnectionString = AdjustConnectionString(Me.OleDbConnection1.ConnectionString)
        Me.OleDbDataAdapter1.Fill(Me.DataSet11)
        Me.OleDbDataAdapter2.Fill(Me.DataSet21)
        Me.dbcComp_Change(Nothing, e.Empty)
    End Sub

    Private Sub dbcComp_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbcComp.Change
        Dim dr As DataRow()
        dr = Me.DataSet21.Opus.Select("Last" & "='" & Me.dbcComp.Text + "'")
        Dim tb As DataSet2.OpusDataTable
        tb = New DataSet2.OpusDataTable()

        Dim item As DataRow
        For Each item In dr
            tb.ImportRow(item)
        Next

        Me.dblOpus.DataSource = tb
    End Sub

    Private Function AdjustConnectionString(ByVal connectionString As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function
End Class
