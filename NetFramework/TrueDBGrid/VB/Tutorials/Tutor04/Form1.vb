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
    Friend WithEvents C1TrueDBGrid1 As C1.Win.TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsCustomers1 As Tutor04.dsCustomers
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.TrueDBGrid.C1TrueDBGrid()
        Me.DsCustomers1 = New Tutor04.dsCustomers()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustomers1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowAddNew = True
        Me.C1TrueDBGrid1.AllowDelete = True
        Me.C1TrueDBGrid1.AllowFilter = True
        Me.C1TrueDBGrid1.AllowRowSizing = C1.Win.TrueDBGrid.RowSizingEnum.AllRows
        Me.C1TrueDBGrid1.AllowSort = True
        Me.C1TrueDBGrid1.Caption = "C1TrueDBGrid.Net"
        Me.C1TrueDBGrid1.CaptionHeight = 17
        Me.C1TrueDBGrid1.CollapseColor = System.Drawing.Color.Black
        Me.C1TrueDBGrid1.DataChanged = False
        Me.C1TrueDBGrid1.DataMember = "Customer"
        Me.C1TrueDBGrid1.DataSource = Me.DsCustomers1
        Me.C1TrueDBGrid1.ExpandColor = System.Drawing.Color.Black
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(8, 8)
        Me.C1TrueDBGrid1.MarqueeStyle = C1.Win.TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.RecordSelectorWidth = 16
        Me.C1TrueDBGrid1.RowHeight = 15
        Me.C1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1TrueDBGrid1.ScrollTips = False
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(368, 216)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = CType(resources.GetObject("C1TrueDBGrid1.PropBag"), String)
        '
        'DsCustomers1
        '
        Me.DsCustomers1.DataSetName = "dsCustomers"
        Me.DsCustomers1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsCustomers1.Namespace = "http://www.tempuri.org/dsCustomers.xsd"
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.DsCustomers1
        Me.ListBox1.DisplayMember = "Customer.LastName"
        Me.ListBox1.Location = New System.Drawing.Point(8, 272)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 121)
        Me.ListBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Last Name List:"
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
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program" & _
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
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCustomers1, "Customer.FirstName"))
        Me.TextBox1.Location = New System.Drawing.Point(152, 248)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "TextBox1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(152, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(152, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCustomers1, "Customer.LastName"))
        Me.TextBox2.Location = New System.Drawing.Point(152, 304)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 20)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "TextBox2"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(152, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Company:"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCustomers1, "Customer.Company"))
        Me.TextBox3.Location = New System.Drawing.Point(152, 360)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(176, 20)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "TextBox3"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(384, 24)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 32)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(384, 64)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 32)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(384, 104)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 32)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add New"
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(384, 168)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(96, 32)
        Me.btnFirst.TabIndex = 12
        Me.btnFirst.Text = "First"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(384, 208)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(96, 32)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "Next"
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(384, 248)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(96, 32)
        Me.btnPrevious.TabIndex = 14
        Me.btnPrevious.Text = "Previous"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(384, 288)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(96, 32)
        Me.btnLast.TabIndex = 15
        Me.btnLast.Text = "Last"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 405)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnLast, Me.btnPrevious, Me.btnNext, Me.btnFirst, Me.btnAdd, Me.btnDelete, Me.btnUpdate, Me.TextBox3, Me.Label4, Me.TextBox2, Me.Label3, Me.Label2, Me.TextBox1, Me.Label1, Me.ListBox1, Me.C1TrueDBGrid1})
        Me.Name = "Form1"
        Me.Text = "Tutorial 04"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustomers1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.OleDbConnection1.ConnectionString = GetModifiedConnectionString(Me.OleDbConnection1.ConnectionString)
            Me.OleDbDataAdapter1.Fill(Me.DsCustomers1)
        Catch eLoad As System.Exception
            MsgBox(eLoad.Message)
        End Try
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        'Move to the first record in the grid
        Me.C1TrueDBGrid1.MoveFirst()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'Move to the next record in the grid
        Me.C1TrueDBGrid1.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        'Move to the previous record in the grid
        Me.C1TrueDBGrid1.MovePrevious()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        'Move to the last record in the grid
        Me.C1TrueDBGrid1.MoveLast()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'Delete the current record and save the changes to the database
        Me.C1TrueDBGrid1.Delete()
        Call UpdateCustomers()


    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'Update the grid and then call the UpdateCustomers sub to save the
        'changes to the recordset

        Me.C1TrueDBGrid1.UpdateData()
        Call UpdateCustomers()


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' This "Add New" button moves the cursor to the
        ' "new (blank) row" at the end so that user can start
        ' adding data to the new record.
        ' Move to last record so that "new row" will be visible
        Me.C1TrueDBGrid1.MoveLast()

        ' Move the cursor to the "addnew row", and set focus to the grid
        Me.C1TrueDBGrid1.Row = Me.C1TrueDBGrid1.Row + 1
        Me.C1TrueDBGrid1.Select()
    End Sub

    Private Sub UpdateCustomers()
        Me.OleDbConnection1.Open()

        Dim UpdatedRows As System.Data.DataSet
        Dim InsertedRows As System.Data.DataSet
        Dim DeletedRows As System.Data.DataSet

        'these three are Data Tables that hold any changes that have been made to the dataset
        'since the last update.

        UpdatedRows = Me.DsCustomers1.GetChanges(DataRowState.Modified)
        InsertedRows = Me.DsCustomers1.GetChanges(DataRowState.Added)
        DeletedRows = Me.DsCustomers1.GetChanges(DataRowState.Deleted)

        Try
            'For each of these, we have to make sure that the Data Tables contain
            'any records, otherwise, we will get an error.
            If Not UpdatedRows Is Nothing Then Me.OleDbDataAdapter1.Update(UpdatedRows)
            If Not InsertedRows Is Nothing Then Me.OleDbDataAdapter1.Update(InsertedRows)
            If Not DeletedRows Is Nothing Then Me.OleDbDataAdapter1.Update(DeletedRows)
            Me.DsCustomers1.AcceptChanges()
        Catch eUpdate As System.Exception
            MsgBox("Caught exception: " & eUpdate.Message)
        End Try

        Me.OleDbConnection1.Close()

    End Sub
    Private Function GetModifiedConnectionString(ByVal connstring As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function
End Class
