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
    Friend WithEvents DsComposer1 As Tutorial12.DsComposer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents C1List1 As C1.Win.C1List.C1List
    Friend WithEvents C1List2 As C1.Win.C1List.C1List
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.DsComposer1 = New Tutorial12.DsComposer()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.C1List1 = New C1.Win.C1List.C1List()
        Me.C1List2 = New C1.Win.C1List.C1List()
        CType(Me.DsComposer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1List2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Fix Columns"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(312, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Unfix Columns"
        '
        'C1List1
        '
        Me.C1List1.AddItemCols = 0
        Me.C1List1.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1List1.AllowHorizontalSplit = True
        Me.C1List1.AllowSort = True
        Me.C1List1.AlternatingRows = False
        Me.C1List1.CaptionHeight = 17
        Me.C1List1.ColumnCaptionHeight = 17
        Me.C1List1.ColumnFooterHeight = 17
        Me.C1List1.ColumnWidth = 100
        Me.C1List1.DataMode = C1.Win.C1List.DataModeEnum.Normal
        Me.C1List1.DataSource = Me.DsComposer1.Composer
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
        Me.C1List1.Size = New System.Drawing.Size(424, 208)
        Me.C1List1.TabIndex = 4
        Me.C1List1.Text = "C1List1"
        Me.C1List1.PropBag = CType(resources.GetObject("C1List1.PropBag"), String)
        '
        'C1List2
        '
        Me.C1List2.AddItemCols = 0
        Me.C1List2.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1List2.AllowSort = True
        Me.C1List2.AlternatingRows = False
        Me.C1List2.CaptionHeight = 17
        Me.C1List2.ColumnCaptionHeight = 17
        Me.C1List2.ColumnFooterHeight = 17
        Me.C1List2.ColumnWidth = 100
        Me.C1List2.DataMode = C1.Win.C1List.DataModeEnum.Normal
        Me.C1List2.DataSource = Me.DsComposer1.Composer
        Me.C1List2.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.C1List2.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.C1List2.ItemHeight = 15
        Me.C1List2.Location = New System.Drawing.Point(48, 248)
        Me.C1List2.MatchCol = C1.Win.C1List.MatchColEnum.DisplayMember
        Me.C1List2.MatchCompare = C1.Win.C1List.MatchCompareEnum.PartiallyEqual
        Me.C1List2.MatchEntry = C1.Win.C1List.MatchEntryEnum.None
        Me.C1List2.MatchEntryTimeout = CType(2000, Long)
        Me.C1List2.Name = "C1List2"
        Me.C1List2.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1List2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1List2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1List2.ScrollTips = False
        Me.C1List2.Size = New System.Drawing.Size(424, 168)
        Me.C1List2.TabIndex = 5
        Me.C1List2.Text = "C1List2"
        Me.C1List2.PropBag = CType(resources.GetObject("C1List2.PropBag"), String)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 477)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1List2, Me.C1List1, Me.Button2, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "C1List .Net Tutorial12"
        CType(Me.DsComposer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1List2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OleDbConnection1.ConnectionString = AdjustConnectionString(Me.OleDbConnection1.ConnectionString)
        Me.OleDbDataAdapter1.Fill(Me.DsComposer1)

        'hide all the columns from the laft split except col 0 and 1
        Dim i As Integer
        For i = 2 To Me.C1List1.Columns.Count - 1
            Me.C1List1.Splits(0).DisplayColumns(i).Visible = False
        Next

        'configure the left split to display 2 columns exactly
        With Me.C1List1.Splits(0)
            .SplitSizeMode = C1.Win.C1List.SizeModeEnum.NumberOfColumns
            .SplitSize = 2
            .AllowHorizontalSizing = False
        End With

        'make col 0 and 1 invisible in the right split
        Me.C1List1.Splits(1).DisplayColumns(0).Visible = False
        Me.C1List1.Splits(1).DisplayColumns(1).Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'make country & birth columns fixed
        Me.C1List2.Splits(0).DisplayColumns("Birth").FixColumn(True)
        Me.C1List2.Splits(0).DisplayColumns("Country").FixColumn(True, 1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'make country & birth columns unfixed
        Me.C1List2.Splits(0).DisplayColumns("Country").FixColumn(False, 1)
        Me.C1List2.Splits(0).DisplayColumns("Birth").FixColumn(False, 0)
    End Sub

    Private Function AdjustConnectionString(ByVal connectionString As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function
End Class
