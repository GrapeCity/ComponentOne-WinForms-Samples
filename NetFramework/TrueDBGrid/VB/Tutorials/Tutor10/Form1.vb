Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        Application.EnableVisualStyles()
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

    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsContacts1 As Tutor10.dsContacts
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DsContacts1 = New Tutor10.dsContacts()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContacts1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowArrows = False
        Me.C1TrueDBGrid1.AllowFilter = True
        Me.C1TrueDBGrid1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1TrueDBGrid1.AllowSort = True
        Me.C1TrueDBGrid1.Anchor = (System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)
        Me.C1TrueDBGrid1.Caption = "C1True DBGrid .Net"
        Me.C1TrueDBGrid1.CaptionHeight = 17
        Me.C1TrueDBGrid1.CollapseColor = System.Drawing.Color.Black
        Me.C1TrueDBGrid1.DataChanged = False
        Me.C1TrueDBGrid1.DataMember = "Contacts"
        Me.C1TrueDBGrid1.DataSource = Me.DsContacts1
        Me.C1TrueDBGrid1.ExpandColor = System.Drawing.Color.Black
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("resource.Images2"), System.Drawing.Bitmap))
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("resource.Images3"), System.Drawing.Bitmap))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(8, 8)
        Me.C1TrueDBGrid1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.RecordSelectorWidth = 16
        Me.C1TrueDBGrid1.RowHeight = 15
        Me.C1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1TrueDBGrid1.ScrollTips = False
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(552, 192)
        Me.C1TrueDBGrid1.TabIndex = 13
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = CType(resources.GetObject("C1TrueDBGrid1.PropBag"), String)
        '
        'DsContacts1
        '
        Me.DsContacts1.DataSetName = "dsContacts"
        Me.DsContacts1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsContacts1.Namespace = "http://www.tempuri.org/dsContacts.xsd"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Contacts", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("CustType", "CustType"), New System.Data.Common.DataColumnMapping("ContactType", "ContactType"), New System.Data.Common.DataColumnMapping("Callback", "Callback"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("ContactDate", "ContactDate"), New System.Data.Common.DataColumnMapping("Company", "Company"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("UserCode", "UserCode"), New System.Data.Common.DataColumnMapping("Expr2", "Expr2")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Customer.FirstName, Customer.LastName, Customer.CustType, Contacts.Cont" & _
        "actType, Contacts.Callback, Contacts.Comments, Contacts.ContactDate, Customer.C" & _
        "ompany, Customer.Phone AS Expr1, Contacts.UserCode, Customer.UserCode AS Expr2" & _
        " FROM Contacts INNER JOIN Customer ON Contacts.UserCode = Customer.UserCode"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection2
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program" & _
        " Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended" & _
        " Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB" & _
        ":Database Password="""";Jet OLEDB:Engine Type=4;Jet OLEDB:Database Locking Mode=0;" & _
        "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLE" & _
        "DB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Enc" & _
        "rypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compa" & _
        "ct Without Replica Repair=False;Jet OLEDB:SFP=False"
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program" & _
        " Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended" & _
        " Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB" & _
        ":Database Password="""";Jet OLEDB:Engine Type=4;Jet OLEDB:Database Locking Mode=0;" & _
        "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLE" & _
        "DB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Enc" & _
        "rypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compa" & _
        "ct Without Replica Repair=False;Jet OLEDB:SFP=False"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(568, 205)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1TrueDBGrid1})
        Me.Name = "Form1"
        Me.Text = "Tutorial 10"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContacts1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.OleDbConnection2.ConnectionString = GetModifiedConnectionString(Me.OleDbConnection2.ConnectionString)
            Me.OleDbDataAdapter1.Fill(Me.DsContacts1)
        Catch eLoad As System.Exception
            MsgBox(eLoad.Message)
        End Try
    End Sub

    Private Function GetModifiedConnectionString(ByVal connstring As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function
End Class
