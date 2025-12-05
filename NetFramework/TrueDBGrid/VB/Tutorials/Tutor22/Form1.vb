Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim borderColor As Color
    Dim borderLeft As Integer, borderTop As Integer, borderRight As Integer, borderBottom As Integer
    Dim borderType As C1.Win.TrueDBGrid.BorderTypeEnum
    Dim dbTable As DataTable  'a copy of the data

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
    Friend WithEvents DsCustomers1 As Tutor22.dsCustomers
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents C1TrueDBGrid1 As C1.Win.TrueDBGrid.C1TrueDBGrid
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsCustomers2 As Tutor22.dsCustomers

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.TrueDBGrid.C1TrueDBGrid()
        Me.DsCustomers2 = New Tutor22.dsCustomers()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustomers2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowAddNew = True
        Me.C1TrueDBGrid1.AllowArrows = False
        Me.C1TrueDBGrid1.AllowFilter = True
        Me.C1TrueDBGrid1.AllowRowSizing = C1.Win.TrueDBGrid.RowSizingEnum.AllRows
        Me.C1TrueDBGrid1.AllowSort = True
        Me.C1TrueDBGrid1.Anchor = (System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)
        Me.C1TrueDBGrid1.Caption = "C1True DBGrid .Net"
        Me.C1TrueDBGrid1.CaptionHeight = 17
        Me.C1TrueDBGrid1.CollapseColor = System.Drawing.Color.Black
        Me.C1TrueDBGrid1.DataChanged = False
        Me.C1TrueDBGrid1.DataMember = "Customer"
        Me.C1TrueDBGrid1.DataSource = Me.DsCustomers2
        Me.C1TrueDBGrid1.ExpandColor = System.Drawing.Color.Black
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(24, 4)
        Me.C1TrueDBGrid1.MarqueeStyle = C1.Win.TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.RecordSelectorWidth = 16
        Me.C1TrueDBGrid1.RowHeight = 40
        Me.C1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1TrueDBGrid1.ScrollTips = False
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(600, 360)
        Me.C1TrueDBGrid1.TabIndex = 13
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = CType(resources.GetObject("C1TrueDBGrid1.PropBag"), String)
        '
        'DsCustomers2
        '
        Me.DsCustomers2.DataSetName = "dsCustomers"
        Me.DsCustomers2.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsCustomers2.Namespace = "http://www.tempuri.org/dsCustomers.xsd"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Company", "Company"), New System.Data.Common.DataColumnMapping("Contacted", "Contacted"), New System.Data.Common.DataColumnMapping("CustType", "CustType"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("UserCode", "UserCode")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Customer WHERE (UserCode = ?) AND (Company = ? OR ? IS NULL AND Comp" & _
        "any IS NULL) AND (Contacted = ? OR ? IS NULL AND Contacted IS NULL) AND (CustTyp" & _
        "e = ? OR ? IS NULL AND CustType IS NULL) AND (FirstName = ? OR ? IS NULL AND Fir" & _
        "stName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Phone " & _
        "= ? OR ? IS NULL AND Phone IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection2
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
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Customer(Company, Contacted, CustType, FirstName, LastName, Phone, U" & _
        "serCode) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection2
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
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection2
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Customer SET Company = ?, Contacted = ?, CustType = ?, FirstName = ?, Las" & _
        "tName = ?, Phone = ?, UserCode = ? WHERE (UserCode = ?) AND (Company = ? OR ? IS" & _
        " NULL AND Company IS NULL) AND (Contacted = ? OR ? IS NULL AND Contacted IS NULL" & _
        ") AND (CustType = ? OR ? IS NULL AND CustType IS NULL) AND (FirstName = ? OR ? I" & _
        "S NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NUL" & _
        "L) AND (Phone = ? OR ? IS NULL AND Phone IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection2
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
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Top Width:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Bottom Width:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Left Width:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Right Width:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(264, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Border Appearance:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(264, 432)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.Text = "ComboBox1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.ComboBox5, Me.ComboBox4, Me.ComboBox3, Me.ComboBox2, Me.Label3, Me.Label1, Me.Label2, Me.Label4})
        Me.GroupBox1.Location = New System.Drawing.Point(24, 384)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 168)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Border Size"
        '
        'ComboBox5
        '
        Me.ComboBox5.Location = New System.Drawing.Point(96, 136)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox5.TabIndex = 24
        Me.ComboBox5.Text = "ComboBox5"
        '
        'ComboBox4
        '
        Me.ComboBox4.Location = New System.Drawing.Point(96, 96)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox4.TabIndex = 23
        Me.ComboBox4.Text = "ComboBox4"
        '
        'ComboBox3
        '
        Me.ComboBox3.Location = New System.Drawing.Point(96, 56)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox3.TabIndex = 22
        Me.ComboBox3.Text = "ComboBox3"
        '
        'ComboBox2
        '
        Me.ComboBox2.Location = New System.Drawing.Point(96, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox2.TabIndex = 21
        Me.ComboBox2.Text = "ComboBox2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 48)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Border Color"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.CheckBox2, Me.CheckBox1})
        Me.GroupBox2.Location = New System.Drawing.Point(456, 392)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 160)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scrolling"
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(40, 104)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "ScrollTracking"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(40, 40)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "ScrollTips"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 573)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.Button1, Me.GroupBox1, Me.ComboBox1, Me.Label5, Me.C1TrueDBGrid1})
        Me.Name = "Form1"
        Me.Text = "Tutorial 22"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustomers2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'fill DsCustomers1 with data
        Try
            Me.OleDbConnection2.ConnectionString = GetModifiedConnectionString(Me.OleDbConnection2.ConnectionString)
            Me.OleDbDataAdapter1.Fill(Me.DsCustomers2)
        Catch eLoad As System.Exception
            MsgBox(eLoad.Message)
        End Try
        'copy the data to dbTable as well
        dbTable = Me.DsCustomers2.Tables(0).Copy()

        'fill each combobox
        FillComboBox1()
        FillCombo(ComboBox2)
        FillCombo(ComboBox3)
        FillCombo(ComboBox4)
        FillCombo(ComboBox5)
        Me.CheckBox2.Checked = True

        'init border sizes
        Me.borderBottom = 1
        Me.borderLeft = 1
        Me.borderRight = 1
        Me.borderTop = 1
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As DialogResult

        result = Me.ColorDialog1.ShowDialog()
        If result = System.Windows.Forms.DialogResult.OK Then
            borderColor = Me.ColorDialog1.Color
            Button1.BackColor = borderColor
        End If

        UpdateBorder()
    End Sub

    Private Sub UpdateBorder()
        With Me.C1TrueDBGrid1.Splits(0).DisplayColumns(Me.C1TrueDBGrid1.Col).Style.Borders
            .BorderType = borderType
            .Bottom = borderBottom
            .Left = borderLeft
            .Right = borderRight
            .Top = borderTop
            .Color = borderColor

        End With
        Me.C1TrueDBGrid1.Refresh()
    End Sub

    'fill each combo with numbers from 1 to 10
    Private Sub FillCombo(ByRef com As ComboBox)
        Dim i As Integer

        com.Text = 1
        For i = 1 To 10
            com.Items.Add(i)
        Next
    End Sub

    'fill the first combo with border types
    Private Sub FillComboBox1()
        Me.ComboBox1.Text = "None"
        With Me.ComboBox1.Items
            .Add("Fillet")
            .Add("Flat")
            .Add("Groove")
            .Add("Inset")
            .Add("InsetBevel")
            .Add("None")
            .Add("Raised")
            .Add("RaisedBevel")
        End With
    End Sub


    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        Me.C1TrueDBGrid1.ScrollTips = Me.CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        Me.C1TrueDBGrid1.ScrollTrack = Me.CheckBox2.Checked
    End Sub

    Private Sub C1TrueDBGrid1_FetchScrollTips(ByVal sender As System.Object, ByVal e As C1.Win.TrueDBGrid.FetchScrollTipsEventArgs) Handles C1TrueDBGrid1.FetchScrollTips
        ' Set the ScrollTip depending on which
        ' scroll bar was moved
        Select Case e.ScrollBar
            Case C1.Win.TrueDBGrid.ScrollBarEnum.Horizontal
                e.ScrollTip = Me.C1TrueDBGrid1.Columns(e.ColIndex).Caption
            Case C1.Win.TrueDBGrid.ScrollBarEnum.Vertical
                e.ScrollTip = "Record: " & CStr(e.Row + 1) & " of " & _
                    CStr(Me.dbTable.Rows.Count) & vbCrLf & "Company: " & _
                    Me.dbTable.Rows(e.Row).Item("Company") & vbCrLf & "User code: " & Me.dbTable.Rows(e.Row).Item("UserCode")
        End Select
        e.TipStyle.ForeColor = Color.Blue
    End Sub


    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Dim choice As String = Me.ComboBox1.SelectedItem
        Select Case choice
            Case "Fillet"
                Me.borderType = C1.Win.TrueDBGrid.BorderTypeEnum.Fillet
            Case "Flat"
                Me.borderType = C1.Win.TrueDBGrid.BorderTypeEnum.Flat
            Case "Groove"
                Me.borderType = C1.Win.TrueDBGrid.BorderTypeEnum.Groove
            Case "Inset"
                Me.borderType = C1.Win.TrueDBGrid.BorderTypeEnum.Inset
            Case "InsetBevel"
                Me.borderType = C1.Win.TrueDBGrid.BorderTypeEnum.InsetBevel
            Case "None"
                Me.borderType = C1.Win.TrueDBGrid.BorderTypeEnum.None
            Case "Raised"
                Me.borderType = C1.Win.TrueDBGrid.BorderTypeEnum.Raised
            Case "RaisedBevel"
                Me.borderType = C1.Win.TrueDBGrid.BorderTypeEnum.RaisedBevel
        End Select

        Me.UpdateBorder()
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted
        Me.borderTop = Me.ComboBox2.SelectedItem
        Me.UpdateBorder()
    End Sub

    Private Sub ComboBox3_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectionChangeCommitted
        Me.borderBottom = Me.ComboBox3.SelectedItem
        Me.UpdateBorder()
    End Sub

    Private Sub ComboBox4_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectionChangeCommitted
        Me.borderLeft = Me.ComboBox4.SelectedItem
        Me.UpdateBorder()
    End Sub

    Private Sub ComboBox5_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectionChangeCommitted
        Me.borderRight = Me.ComboBox5.SelectedItem
        Me.UpdateBorder()
    End Sub

    Private Function GetModifiedConnectionString(ByVal connstring As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function

End Class
