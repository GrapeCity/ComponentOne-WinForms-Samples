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
    Friend WithEvents DsComposer1 As Tutorial2.DsComposer
    Friend WithEvents C1Combo1 As C1.Win.C1List.C1Combo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DsComposer1 = New Tutorial2.DsComposer()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.C1Combo1 = New C1.Win.C1List.C1Combo()
        CType(Me.DsComposer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsComposer1
        '
        Me.DsComposer1.DataSetName = "DsComposer"
        Me.DsComposer1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsComposer1.Namespace = "http://www.tempuri.org/DsComposer.xsd"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Composer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("First", "First"), New System.Data.Common.DataColumnMapping("Last", "Last"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Birth", "Birth"), New System.Data.Common.DataColumnMapping("Death", "Death")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Composer(First, Last, Country, Birth, Death) VALUES (?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("First", System.Data.OleDb.OleDbType.VarWChar, 50, "First"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Birth", System.Data.OleDb.OleDbType.DBDate, 0, "Birth"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Death", System.Data.OleDb.OleDbType.DBDate, 0, "Death"))
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
        Me.OleDbSelectCommand1.CommandText = "SELECT First, Last, Country, Birth, Death FROM Composer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'C1Combo1
        '
        Me.C1Combo1.AddItemCols = 0
        Me.C1Combo1.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo1.AllowColMove = True
        Me.C1Combo1.AllowSort = True
        Me.C1Combo1.AlternatingRows = False
        Me.C1Combo1.BackColor = System.Drawing.SystemColors.Window
        Me.C1Combo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1Combo1.Caption = ""
        Me.C1Combo1.CaptionHeight = 17
        Me.C1Combo1.CellTips = C1.Win.C1List.CellTipEnum.NoCellTips
        Me.C1Combo1.CellTipsDelay = 500
        Me.C1Combo1.CellTipsWidth = 0
        Me.C1Combo1.ColumnCaptionHeight = 17
        Me.C1Combo1.ColumnFooterHeight = 17
        Me.C1Combo1.ColumnFooters = False
        Me.C1Combo1.ColumnHeaders = True
        Me.C1Combo1.ColumnWidth = 100
        Me.C1Combo1.DataMode = C1.Win.C1List.DataModeEnum.Normal
        Me.C1Combo1.DataSource = Me.DsComposer1.Composer
        Me.C1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo1.DefColWidth = 0
        Me.C1Combo1.DisplayMember = "First"
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
        Me.C1Combo1.Location = New System.Drawing.Point(72, 40)
        Me.C1Combo1.MatchEntryTimeout = 100
        Me.C1Combo1.MaxDropDownItems = CType(5, Short)
        Me.C1Combo1.MaxLength = 32767
        Me.C1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo1.Name = "C1Combo1"
        Me.C1Combo1.PropBag = "<?xml version=""1.0""?><Blob><DataCols><C1DataColumn Level" & _
        "=""0"" Caption=""First"" DataField=""First""><ValueItems /></C1DataColumn><C1DataColum" & _
        "n Level=""0"" Caption=""Last"" DataField=""Last""><ValueItems /></C1DataColumn>" & _
        "<C1DataColumn Level=""0"" Caption=""Country"" DataField=""Country""><ValueItems /></C1DataColumn>" & _
        "<C1DataColumn Level=""0"" Caption=""Birth"" Data" & _
        "Field=""Birth""><ValueItems /></C1DataColumn><C1DataColumn Level=""0"" Ca" & _
        "ption=""Death"" DataField=""Death""><ValueItems /></C1DataColumn></DataC" & _
        "ols><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Data>Caption{AlignHorz:C" & _
        "enter;}Normal{BackColor:Window;}Style25{AlignHorz:Near;}Selected{ForeColor:Highl" & _
        "ightText;BackColor:Highlight;}Style18{AlignHorz:Far;}Style19{AlignHorz:Far;}Styl" & _
        "e14{}Style15{AlignHorz:Near;}Style16{AlignHorz:Near;}Style17{}Style10{}Style11{}" & _
        "OddRow{}Style13{AlignHorz:Far;}Style12{AlignHorz:Far;}Footer{}HighlightRow{ForeC" & _
        "olor:HighlightText;BackColor:Highlight;}Style26{}RecordSelector{AlignImage:Cente" & _
        "r;}Style24{AlignHorz:Near;}Style23{}Style22{AlignHorz:Near;}Style21{AlignHorz:Ne" & _
        "ar;}Style20{}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}E" & _
        "venRow{BackColor:Aqua;}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, " & _
        "1, 1;ForeColor:ControlText;AlignVert:Center;}Style4{}Style9{AlignHorz:Near;}Styl" & _
        "e8{}Style5{}Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark" & _
        ";}Style7{}Style6{}Style1{}Style3{}Style2{}</Data></Styles><Splits><C1.Win.C1List" & _
        ".ListBoxView AllowColSelect=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeig" & _
        "ht=""17"" ColumnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1" & _
        """><ClientRect>0, 0, 246, 198</ClientRect><internalCols><C1DisplayColumn><Heading" & _
        "Style parent=""Style2"" me=""Style12"" /><Style parent=""Normal"" me=""Style13"" /><Foot" & _
        "erStyle parent=""Style3"" me=""Style14"" /><Visible>True</Visible><ColumnDivider><Co" & _
        "lor>DarkGray</Color><Style>Single</Style></ColumnDivider><Height>15</Height><DCI" & _
        "dx>0</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=""Style2"" me=" & _
        """Style15"" /><Style parent=""Normal"" me=""Style16"" /><FooterStyle parent=""Style3"" m" & _
        "e=""Style17"" /><Visible>True</Visible><ColumnDivider><Color>DarkGray</Color><Styl" & _
        "e>Single</Style></ColumnDivider><Height>15</Height><DCIdx>1</DCIdx></C1DisplayCo" & _
        "lumn><C1DisplayColumn><HeadingStyle parent=""Style2"" me=""Style18"" /><Style parent" & _
        "=""Normal"" me=""Style19"" /><FooterStyle parent=""Style3"" me=""Style20"" /><Visible>Tr" & _
        "ue</Visible><ColumnDivider><Color>DarkGray</Color><Style>Single</Style></ColumnD" & _
        "ivider><Height>15</Height><DCIdx>2</DCIdx></C1DisplayColumn><C1DisplayColumn><He" & _
        "adingStyle parent=""Style2"" me=""Style21"" /><Style parent=""Normal"" me=""Style22"" />" & _
        "<FooterStyle parent=""Style3"" me=""Style23"" /><Visible>True</Visible><ColumnDivide" & _
        "r><Color>DarkGray</Color><Style>Single</Style></ColumnDivider><Height>15</Height" & _
        "><DCIdx>3</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=""Style2" & _
        """ me=""Style24"" /><Style parent=""Normal"" me=""Style25"" /><FooterStyle parent=""Styl" & _
        "e3"" me=""Style26"" /><Visible>True</Visible><ColumnDivider><Color>DarkGray</Color>" & _
        "<Style>Single</Style></ColumnDivider><Height>15</Height><DCIdx>4</DCIdx></C1Disp" & _
        "layColumn></internalCols><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRowSty" & _
        "le parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /><Gr" & _
        "oupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Style2" & _
        """ /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle parent" & _
        "=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordSele" & _
        "ctorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selected" & _
        """ me=""Style5"" /><Style parent="""" me=""Normal"" /></C1.Win.C1List.ListBoxView></Spl" & _
        "its><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Headi" & _
        "ng"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption""" & _
        " /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" " & _
        "/><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow""" & _
        " /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelect" & _
        "or"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</De" & _
        "faultRecSelWidth></Blob>"
        Me.C1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo1.RowTracking = True
        Me.C1Combo1.ScrollTips = False
        Me.C1Combo1.ScrollTrack = True
        Me.C1Combo1.SelectedText = ""
        Me.C1Combo1.SelectionLength = 0
        Me.C1Combo1.SelectionStart = 0
        Me.C1Combo1.Size = New System.Drawing.Size(248, 21)
        Me.C1Combo1.TabIndex = 0
        Me.C1Combo1.Text = "C1Combo1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 285)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1Combo1})
        Me.Name = "Form1"
        Me.Text = "C1List .Net Tutorial2"
        CType(Me.DsComposer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OleDbConnection1.ConnectionString = AdjustConnectionString(Me.OleDbConnection1.ConnectionString)
        Me.OleDbDataAdapter1.Fill(Me.DsComposer1)
    End Sub

    Private Function AdjustConnectionString(ByVal connectionString As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function
End Class
