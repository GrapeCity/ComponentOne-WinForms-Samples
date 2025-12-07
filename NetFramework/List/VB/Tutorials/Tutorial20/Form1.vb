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
    Friend WithEvents C1Combo1 As C1.Win.List.C1Combo
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSet11 As Tutorial20.DataSet1
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.C1Combo1 = New C1.Win.List.C1Combo()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.DataSet11 = New Tutorial20.DataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Combo1
        '
        Me.C1Combo1.AddItemCols = 0
        Me.C1Combo1.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo1.AllowColMove = True
        Me.C1Combo1.AllowSort = True
        Me.C1Combo1.AlternatingRows = False
        Me.C1Combo1.Caption = ""
        Me.C1Combo1.CaptionHeight = 17
        Me.C1Combo1.CellTips = C1.Win.List.CellTipEnum.NoCellTips
        Me.C1Combo1.CellTipsWidth = 0
        Me.C1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo1.ColumnCaptionHeight = 17
        Me.C1Combo1.ColumnFooterHeight = 17
        Me.C1Combo1.ColumnWidth = 100
        Me.C1Combo1.ContentHeight = 17
        Me.C1Combo1.ContextMenu = Me.ContextMenu1
        Me.C1Combo1.DataMode = C1.Win.List.DataModeEnum.Normal
        Me.C1Combo1.DataSource = Me.DataSet11.Composer
        Me.C1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo1.DefColWidth = 0
        Me.C1Combo1.DisplayMember = "First"
        Me.C1Combo1.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo1.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo1.EditorHeight = 17
        Me.C1Combo1.GapHeight = 2
        Me.C1Combo1.IntegralHeight = False
        Me.C1Combo1.ItemHeight = 15
        Me.C1Combo1.Location = New System.Drawing.Point(32, 72)
        Me.C1Combo1.MatchEntryTimeout = CType(100, Long)
        Me.C1Combo1.MaxDropDownItems = CType(5, Short)
        Me.C1Combo1.MaxLength = 32767
        Me.C1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo1.Name = "C1Combo1"
        Me.C1Combo1.PropBag = "<?xml version=""1.0""?><Blob><DataCols><C1DataColumn Level=""0"" Caption=""Birth"" Data" & _
        "Field=""Birth""><ValueItems /></C1DataColumn><C1DataColumn Level=""0"" Caption=""Coun" & _
        "try"" DataField=""Country""><ValueItems /></C1DataColumn><C1DataColumn Level=""0"" Ca" & _
        "ption=""Death"" DataField=""Death""><ValueItems /></C1DataColumn><C1DataColumn Level" & _
        "=""0"" Caption=""First"" DataField=""First""><ValueItems /></C1DataColumn><C1DataColum" & _
        "n Level=""0"" Caption=""Last"" DataField=""Last""><ValueItems /></C1DataColumn></DataC" & _
        "ols><Styles type=""C1.Win.List.Design.ContextWrapper""><Data>Caption{AlignHorz:C" & _
        "enter;}Normal{BackColor:Window;}Style25{AlignHorz:Near;}Selected{ForeColor:Highl" & _
        "ightText;BackColor:Highlight;}Style18{AlignHorz:Far;}Style19{AlignHorz:Far;}Styl" & _
        "e14{}Style15{AlignHorz:Near;}Style16{AlignHorz:Near;}Style17{}Style10{}Style11{}" & _
        "OddRow{}Style13{AlignHorz:Far;}Style12{AlignHorz:Far;}Footer{}HighlightRow{ForeC" & _
        "olor:HighlightText;BackColor:Highlight;}Style26{}RecordSelector{AlignImage:Cente" & _
        "r;}Style24{AlignHorz:Near;}Style23{}Style22{AlignHorz:Near;}Style21{AlignHorz:Ne" & _
        "ar;}Style20{}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}E" & _
        "venRow{BackColor:Aqua;}Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1" & _
        ", 1;ForeColor:ControlText;BackColor:Control;}Style4{}Style9{AlignHorz:Near;}Styl" & _
        "e8{}Style5{}Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center" & _
        ";}Style7{}Style6{}Style1{}Style3{}Style2{}</Data></Styles><Splits><C1.Win.List" & _
        ".ListBoxView AllowColSelect=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeig" & _
        "ht=""17"" ColumnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1" & _
        """><ClientRect>0, 0, 116, 156</ClientRect><internalCols><C1DisplayColumn><Heading" & _
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
        """ me=""Style5"" /><Style parent="""" me=""Normal"" /></C1.Win.List.ListBoxView></Spl" & _
        "its><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Headi" & _
        "ng"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption""" & _
        " /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" " & _
        "/><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow""" & _
        " /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelect" & _
        "or"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</De" & _
        "faultRecSelWidth></Blob>"
        Me.C1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Combo1.RowDivider.Style = C1.Win.List.LineStyleEnum.None
        Me.C1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo1.ScrollTips = False
        Me.C1Combo1.SelectionStart = 0
        Me.C1Combo1.Size = New System.Drawing.Size(168, 21)
        Me.C1Combo1.TabIndex = 0
        Me.C1Combo1.Text = "C1Combo1"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Welcome"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "to"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "ComponentOne"
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Limit To List"
        '
        'Button2
        '
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Name = "Button5"
        Me.Button5.TabIndex = 0
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Composer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("First", "First"), New System.Data.Common.DataColumnMapping("Last", "Last"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Birth", "Birth"), New System.Data.Common.DataColumnMapping("Death", "Death")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Composer(Birth, Country, Death, First, Last) VALUES (?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Birth", System.Data.OleDb.OleDbType.DBDate, 0, "Birth"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Death", System.Data.OleDb.OleDbType.DBDate, 0, "Death"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("First", System.Data.OleDb.OleDbType.VarWChar, 50, "First"))
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
        Me.OleDbSelectCommand1.CommandText = "SELECT Birth, Country, Death, First, Last FROM Composer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Try right clicking on the C1Combo to popup the context menu."
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 276)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.Button1, Me.C1Combo1})
        Me.Name = "Form1"
        Me.Text = "C1List .Net Tutorial20"
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fill the dataset
        Me.OleDbConnection1.ConnectionString = AdjustConnectionString(Me.OleDbConnection1.ConnectionString)
        Me.OleDbDataAdapter1.Fill(Me.DataSet11)

        'some settings
        With Me.C1Combo1
            .SelectedIndex = 0
            .DropDownWidth = 500
            .MaxDropDownItems = 10
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Prevent MisMatch
        With Me.C1Combo1
            .LimitToList = True
            .AutoCompletion = True
            .SuperBack = True
        End With
    End Sub

    Private Function AdjustConnectionString(ByVal connectionString As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function
End Class
