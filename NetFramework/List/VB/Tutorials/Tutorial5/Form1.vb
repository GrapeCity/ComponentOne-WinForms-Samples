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
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsComposer1 As Tutorial5.DsComposer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents C1List1 As C1.Win.C1List.C1List
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.DsComposer1 = New Tutorial5.DsComposer()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.C1List1 = New C1.Win.C1List.C1List()
        CType(Me.DsComposer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Button1.Location = New System.Drawing.Point(40, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Execute SQL"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(40, 296)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(456, 72)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Enter SQL statement here"
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
        Me.C1List1.DataSource = Me.DsComposer1.Composer
        Me.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.C1List1.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1List1.ItemHeight = 15
        Me.C1List1.Location = New System.Drawing.Point(40, 16)
        Me.C1List1.MatchCol = C1.Win.C1List.MatchColEnum.DisplayMember
        Me.C1List1.MatchCompare = C1.Win.C1List.MatchCompareEnum.PartiallyEqual
        Me.C1List1.MatchEntry = C1.Win.C1List.MatchEntryEnum.None
        Me.C1List1.MatchEntryTimeout = CType(2000, Long)
        Me.C1List1.Name = "C1List1"
        Me.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1List1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1List1.ScrollTips = False
        Me.C1List1.Size = New System.Drawing.Size(456, 216)
        Me.C1List1.TabIndex = 8
        Me.C1List1.Text = "C1List1"
        Me.C1List1.PropBag = CType(resources.GetObject("C1List1.PropBag"), String)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 381)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1List1, Me.TextBox1, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "C1List .Net Tutorial5"
        CType(Me.DsComposer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OleDbConnection1.ConnectionString = AdjustConnectionString(Me.OleDbConnection1.ConnectionString)
        Me.OleDbDataAdapter1.Fill(Me.DsComposer1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ds As DataSet = New DataSet()
        Dim sqlStr As String
        Dim da As OleDb.OleDbDataAdapter

        sqlStr = Me.TextBox1.Text.Trim()
        da = New OleDb.OleDbDataAdapter(sqlStr, Me.OleDbConnection1)

        Try
            da.Fill(ds, "TestSQL")
            Me.C1List1.DataSource = Nothing
            Me.C1List1.ClearFields()
            Me.C1List1.DataSource = ds.Tables("TestSQL")
        Catch x As Exception
            MsgBox("Invalid SQL statement.")
        End Try
    End Sub

    Private Function AdjustConnectionString(ByVal connectionString As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function
End Class
