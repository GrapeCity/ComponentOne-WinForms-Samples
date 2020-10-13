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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsCustomers1 As Tutorial18.DsCustomers
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents C1List1 As C1.Win.C1List.C1List
    Friend WithEvents C1Combo1 As C1.Win.C1List.C1Combo
    Friend WithEvents C1Combo2 As C1.Win.C1List.C1Combo
    Friend WithEvents C1Combo3 As C1.Win.C1List.C1Combo
    Friend WithEvents C1Combo4 As C1.Win.C1List.C1Combo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.DsCustomers1 = New Tutorial18.DsCustomers()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.C1List1 = New C1.Win.C1List.C1List()
        Me.C1Combo1 = New C1.Win.C1List.C1Combo()
        Me.C1Combo2 = New C1.Win.C1List.C1Combo()
        Me.C1Combo3 = New C1.Win.C1List.C1Combo()
        Me.C1Combo4 = New C1.Win.C1List.C1Combo()
        CType(Me.DsCustomers1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsCustomers1
        '
        Me.DsCustomers1.DataSetName = "DsCustomers"
        Me.DsCustomers1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsCustomers1.Namespace = "http://www.tempuri.org/DsCustomers.xsd"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MatchCol"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(168, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Compare Mode:"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("UserCode", "UserCode"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("Company", "Company"), New System.Data.Common.DataColumnMapping("Contacted", "Contacted"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("CustType", "CustType")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Customer WHERE (UserCode = ?) AND (Company = ? OR ? IS NULL AND Comp" & _
        "any IS NULL) AND (Contacted = ? OR ? IS NULL AND Contacted IS NULL) AND (CustTyp" & _
        "e = ? OR ? IS NULL AND CustType IS NULL) AND (FirstName = ? OR ? IS NULL AND Fir" & _
        "stName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Phone " & _
        "= ? OR ? IS NULL AND Phone IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Company", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Company", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Company1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Company", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Contacted", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacted", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Contacted1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacted", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustType1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=..\..\..\Data\" & _
        "C1ListDemo.mdb;Mode=Share Deny None;Extended" & _
        " Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB" & _
        ":Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;" & _
        "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLE" & _
        "DB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Enc" & _
        "rypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compa" & _
        "ct Without Replica Repair=False;Jet OLEDB:SFP=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Customer(Company, Contacted, CustType, FirstName, LastName, Phone, U" & _
        "serCode) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.VarWChar, 30, "Company"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.DBDate, 0, "Contacted"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustType", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, "UserCode"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Company, Contacted, CustType, FirstName, LastName, Phone, UserCode FROM Cu" & _
        "stomer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Customer SET Company = ?, Contacted = ?, CustType = ?, FirstName = ?, Las" & _
        "tName = ?, Phone = ?, UserCode = ? WHERE (UserCode = ?) AND (Company = ? OR ? IS" & _
        " NULL AND Company IS NULL) AND (Contacted = ? OR ? IS NULL AND Contacted IS NULL" & _
        ") AND (CustType = ? OR ? IS NULL AND CustType IS NULL) AND (FirstName = ? OR ? I" & _
        "S NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NUL" & _
        "L) AND (Phone = ? OR ? IS NULL AND Phone IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.VarWChar, 30, "Company"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.DBDate, 0, "Contacted"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustType", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, "UserCode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Company", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Company", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Company1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Company", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Contacted", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacted", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Contacted1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacted", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustType1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(448, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "MatchEntry"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(304, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "MatchEntryTimeout:"
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
        Me.C1List1.DataMode = C1.Win.C1List.DataModeEnum.Normal
        Me.C1List1.DataSource = Me.DsCustomers1.Customer
        Me.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.C1List1.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1List1.ItemHeight = 15
        Me.C1List1.Location = New System.Drawing.Point(32, 24)
        Me.C1List1.MatchCol = C1.Win.C1List.MatchColEnum.DisplayMember
        Me.C1List1.MatchCompare = C1.Win.C1List.MatchCompareEnum.PartiallyEqual
        Me.C1List1.MatchEntry = C1.Win.C1List.MatchEntryEnum.None
        Me.C1List1.MatchEntryTimeout = CType(2000, Long)
        Me.C1List1.Name = "C1List1"
        Me.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1List1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1List1.ScrollTips = False
        Me.C1List1.Size = New System.Drawing.Size(496, 288)
        Me.C1List1.TabIndex = 11
        Me.C1List1.Text = "C1List1"
        Me.C1List1.PropBag = CType(resources.GetObject("C1List1.PropBag"), String)
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
        Me.C1Combo1.CellTips = C1.Win.C1List.CellTipEnum.NoCellTips
        Me.C1Combo1.CellTipsDelay = 500
        Me.C1Combo1.CellTipsWidth = 0
        Me.C1Combo1.ColumnCaptionHeight = 17
        Me.C1Combo1.ColumnFooterHeight = 17
        Me.C1Combo1.ColumnFooters = False
        Me.C1Combo1.ColumnHeaders = True
        Me.C1Combo1.ColumnWidth = -1
        Me.C1Combo1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.C1Combo1.DataMode = C1.Win.C1List.DataModeEnum.AddItem
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
        Me.C1Combo1.Location = New System.Drawing.Point(32, 360)
        Me.C1Combo1.MatchEntryTimeout = 100
        Me.C1Combo1.MaxDropDownItems = CType(5, Short)
        Me.C1Combo1.MaxLength = 32767
        Me.C1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo1.Name = "C1Combo1"
        Me.C1Combo1.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:High" & _
        "lightText;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{Alig" & _
        "nHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVer" & _
        "t:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Styl" & _
        "e8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView" & _
        " AllowColSelect=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" Colu" & _
        "mnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRec" & _
        "t>0, 0, 110, 198</ClientRect><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRo" & _
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
        "Splits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</De" & _
        "faultRecSelWidth></Blob>"
        Me.C1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo1.RowTracking = True
        Me.C1Combo1.ScrollTips = False
        Me.C1Combo1.ScrollTrack = True
        Me.C1Combo1.SelectionLength = 0
        Me.C1Combo1.SelectionStart = 0
        Me.C1Combo1.Size = New System.Drawing.Size(112, 21)
        Me.C1Combo1.TabIndex = 12
        Me.C1Combo1.TabStop = False
        Me.C1Combo1.Text = "C1Combo1"
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
        Me.C1Combo2.CellTips = C1.Win.C1List.CellTipEnum.NoCellTips
        Me.C1Combo2.CellTipsDelay = 500
        Me.C1Combo2.CellTipsWidth = 0
        Me.C1Combo2.ColumnCaptionHeight = 17
        Me.C1Combo2.ColumnFooterHeight = 17
        Me.C1Combo2.ColumnFooters = False
        Me.C1Combo2.ColumnHeaders = True
        Me.C1Combo2.ColumnWidth = -1
        Me.C1Combo2.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.C1Combo2.DataMode = C1.Win.C1List.DataModeEnum.AddItem
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
        Me.C1Combo2.Location = New System.Drawing.Point(168, 360)
        Me.C1Combo2.MatchEntryTimeout = 100
        Me.C1Combo2.MaxDropDownItems = CType(5, Short)
        Me.C1Combo2.MaxLength = 32767
        Me.C1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo2.Name = "C1Combo2"
        Me.C1Combo2.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:High" & _
        "lightText;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{Alig" & _
        "nHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVer" & _
        "t:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Styl" & _
        "e8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView" & _
        " AllowColSelect=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" Colu" & _
        "mnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRec" & _
        "t>0, 0, 86, 198</ClientRect><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRow" & _
        "Style parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" />" & _
        "<GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Sty" & _
        "le2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle par" & _
        "ent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordS" & _
        "electorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selec" & _
        "ted"" me=""Style5"" /><Style parent="""" me=""Normal"" /></C1.Win.C1List.ListBoxView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenR" & _
        "ow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSel" & _
        "ector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertS" & _
        "plits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Def" & _
        "aultRecSelWidth></Blob>"
        Me.C1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo2.RowTracking = True
        Me.C1Combo2.ScrollTips = False
        Me.C1Combo2.ScrollTrack = True
        Me.C1Combo2.SelectionLength = 0
        Me.C1Combo2.SelectionStart = 0
        Me.C1Combo2.Size = New System.Drawing.Size(88, 21)
        Me.C1Combo2.TabIndex = 13
        Me.C1Combo2.TabStop = False
        Me.C1Combo2.Text = "C1Combo2"
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
        Me.C1Combo3.CellTips = C1.Win.C1List.CellTipEnum.NoCellTips
        Me.C1Combo3.CellTipsDelay = 500
        Me.C1Combo3.CellTipsWidth = 0
        Me.C1Combo3.ColumnCaptionHeight = 17
        Me.C1Combo3.ColumnFooterHeight = 17
        Me.C1Combo3.ColumnFooters = False
        Me.C1Combo3.ColumnHeaders = True
        Me.C1Combo3.ColumnWidth = -1
        Me.C1Combo3.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.C1Combo3.DataMode = C1.Win.C1List.DataModeEnum.AddItem
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
        Me.C1Combo3.Location = New System.Drawing.Point(448, 360)
        Me.C1Combo3.MatchEntryTimeout = 100
        Me.C1Combo3.MaxDropDownItems = CType(5, Short)
        Me.C1Combo3.MaxLength = 32767
        Me.C1Combo3.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo3.Name = "C1Combo3"
        Me.C1Combo3.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:High" & _
        "lightText;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{Alig" & _
        "nHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVer" & _
        "t:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Styl" & _
        "e8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView" & _
        " AllowColSelect=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" Colu" & _
        "mnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRec" & _
        "t>0, 0, 78, 198</ClientRect><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRow" & _
        "Style parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" />" & _
        "<GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Sty" & _
        "le2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle par" & _
        "ent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordS" & _
        "electorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selec" & _
        "ted"" me=""Style5"" /><Style parent="""" me=""Normal"" /></C1.Win.C1List.ListBoxView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenR" & _
        "ow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSel" & _
        "ector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertS" & _
        "plits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Def" & _
        "aultRecSelWidth></Blob>"
        Me.C1Combo3.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo3.RowTracking = True
        Me.C1Combo3.ScrollTips = False
        Me.C1Combo3.ScrollTrack = True
        Me.C1Combo3.SelectionLength = 0
        Me.C1Combo3.SelectionStart = 0
        Me.C1Combo3.Size = New System.Drawing.Size(80, 21)
        Me.C1Combo3.TabIndex = 14
        Me.C1Combo3.TabStop = False
        Me.C1Combo3.Text = "C1Combo3"
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
        Me.C1Combo4.CellTips = C1.Win.C1List.CellTipEnum.NoCellTips
        Me.C1Combo4.CellTipsDelay = 500
        Me.C1Combo4.CellTipsWidth = 0
        Me.C1Combo4.ColumnCaptionHeight = 17
        Me.C1Combo4.ColumnFooterHeight = 17
        Me.C1Combo4.ColumnFooters = False
        Me.C1Combo4.ColumnHeaders = True
        Me.C1Combo4.ColumnWidth = -1
        Me.C1Combo4.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        
        Me.C1Combo4.DataMode = C1.Win.C1List.DataModeEnum.AddItem
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
        Me.C1Combo4.Location = New System.Drawing.Point(304, 360)
        Me.C1Combo4.MatchEntryTimeout = 100
        Me.C1Combo4.MaxDropDownItems = CType(5, Short)
        Me.C1Combo4.MaxLength = 32767
        Me.C1Combo4.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo4.Name = "C1Combo4"
        Me.C1Combo4.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:High" & _
        "lightText;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{Alig" & _
        "nHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVer" & _
        "t:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Styl" & _
        "e8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView" & _
        " AllowColSelect=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" Colu" & _
        "mnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRec" & _
        "t>0, 0, 102, 198</ClientRect><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRo" & _
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
        "Splits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</De" & _
        "faultRecSelWidth></Blob>"
        Me.C1Combo4.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo4.RowTracking = True
        Me.C1Combo4.ScrollTips = False
        Me.C1Combo4.ScrollTrack = True
        Me.C1Combo4.SelectionLength = 0
        Me.C1Combo4.SelectionStart = 0
        Me.C1Combo4.Size = New System.Drawing.Size(104, 21)
        Me.C1Combo4.TabIndex = 15
        Me.C1Combo4.TabStop = False
        Me.C1Combo4.Text = "C1Combo4"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 397)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1Combo4, Me.C1Combo3, Me.C1Combo2, Me.C1Combo1, Me.C1List1, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "C1List .Net Tutorial18"
        CType(Me.DsCustomers1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fill the dataset
        Me.OleDbConnection1.ConnectionString = AdjustConnectionString(Me.OleDbConnection1.ConnectionString)
        Me.OleDbDataAdapter1.Fill(Me.DsCustomers1)

        'Fill Combo1
        With Me.C1Combo1
            .AddItem("Current Mouse Position")
            .AddItem("DisplayMember")
            .AddItem("Current Selected Col")
            .SelectedIndex = 0
        End With

        'Fill combo2
        With Me.C1Combo2
            .AddItem("Partial Include")
            .AddItem("Equal")
            .AddItem("Less Than")
            .AddItem("Greater Than")
            .SelectedIndex = 0
        End With

        'Fill Combo3
        With Me.C1Combo3
            .AddItem("Standard")
            .AddItem("Extended")
            .SelectedIndex = 0
        End With

        'Fill combo4
        With Me.C1Combo4
            .AddItem("2000")
            .AddItem("1000")
            .AddItem("3000")
            .SelectedIndex = 0
        End With

        'Start
        With Me.C1List1
            .MatchCol = C1.Win.C1List.MatchColEnum.CurrentMousePos
            .MatchCompare = C1.Win.C1List.MatchCompareEnum.PartiallyEqual
            .MatchEntry = C1.Win.C1List.MatchEntryEnum.Standard
            .MatchEntryTimeout = 2000
        End With
    End Sub


    Private Sub C1Combo1_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Combo1.Change
        Select Case Me.C1Combo1.Text
            Case "Current Mouse Position"
                Me.C1List1.MatchCol = C1.Win.C1List.MatchColEnum.CurrentMousePos
            Case "ListField"
                Me.C1List1.MatchCol = C1.Win.C1List.MatchColEnum.DisplayMember
            Case "Current Selected Col"
                Me.C1List1.MatchCol = C1.Win.C1List.MatchColEnum.CurrentSelectedCol
        End Select
    End Sub

    Private Sub C1Combo2_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Combo2.Change
        Select Case Me.C1Combo2.Text
            Case "Partial Include"
                Me.C1List1.MatchCompare = C1.Win.C1List.MatchCompareEnum.PartiallyEqual
            Case "Equal"
                Me.C1List1.MatchCompare = C1.Win.C1List.MatchCompareEnum.Equal
            Case "Less Than"
                Me.C1List1.MatchCompare = C1.Win.C1List.MatchCompareEnum.LessThan
            Case "Greater Than"
                Me.C1List1.MatchCompare = C1.Win.C1List.MatchCompareEnum.GreaterThan
        End Select
    End Sub

    Private Sub C1Combo3_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Combo3.Change
        Select Case Me.C1Combo3.Text
            Case "Standard"
                Me.C1List1.MatchEntry = C1.Win.C1List.MatchEntryEnum.Standard
            Case "Extended"
                Me.C1List1.MatchEntry = C1.Win.C1List.MatchEntryEnum.Extended
        End Select
    End Sub

    Private Sub C1Combo4_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Combo4.Change
        Select Case Me.C1Combo4.Text
            Case "2000"
                Me.C1List1.MatchEntryTimeout = 2000
            Case "1000"
                Me.C1List1.MatchEntryTimeout = 1000
            Case "3000"
                Me.C1List1.MatchEntryTimeout = 3000
        End Select
    End Sub

    Private Function AdjustConnectionString(ByVal connectionString As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function
End Class
