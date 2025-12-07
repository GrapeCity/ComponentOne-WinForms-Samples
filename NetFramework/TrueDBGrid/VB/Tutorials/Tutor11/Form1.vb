
Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim bFlag As Integer

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
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsCustomer1 As Tutor11.dsCustomer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.TrueDBGrid.C1TrueDBGrid()
        Me.DsCustomer1 = New Tutor11.dsCustomer()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustomer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowFilter = True
        Me.C1TrueDBGrid1.AllowRowSizing = C1.Win.TrueDBGrid.RowSizingEnum.AllRows
        Me.C1TrueDBGrid1.AllowSort = True
        Me.C1TrueDBGrid1.Caption = "C1TrueDBGrid.Net"
        Me.C1TrueDBGrid1.CaptionHeight = 17
        Me.C1TrueDBGrid1.CollapseColor = System.Drawing.Color.Black
        Me.C1TrueDBGrid1.DataMember = "Contacts"
        Me.C1TrueDBGrid1.DataSource = Me.DsCustomer1
        Me.C1TrueDBGrid1.DataView = C1.Win.TrueDBGrid.DataViewEnum.Normal
        Me.C1TrueDBGrid1.ExpandColor = System.Drawing.Color.Black
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("resource.Images2"), System.Drawing.Bitmap))
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("resource.Images3"), System.Drawing.Bitmap))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(8, 8)
        Me.C1TrueDBGrid1.MarqueeStyle = C1.Win.TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.RecordSelectorWidth = 16
        Me.C1TrueDBGrid1.RowHeight = 20
        Me.C1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1TrueDBGrid1.ScrollTips = False
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(536, 200)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = CType(resources.GetObject("C1TrueDBGrid1.PropBag"), String)
        '
        'DsCustomer1
        '
        Me.DsCustomer1.DataSetName = "dsCustomer"
        Me.DsCustomer1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsCustomer1.Namespace = "http://www.tempuri.org/dsCustomer.xsd"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Contacts", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Contacts.UserCode", "Contacts.UserCode"), New System.Data.Common.DataColumnMapping("ContactDate", "ContactDate"), New System.Data.Common.DataColumnMapping("Callback", "Callback"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("ContactType", "ContactType"), New System.Data.Common.DataColumnMapping("Customer.UserCode", "Customer.UserCode"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("Company", "Company"), New System.Data.Common.DataColumnMapping("Contacted", "Contacted"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("CustType", "CustType")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Contacts.Callback, Contacts.Comments, Contacts.ContactDate, Contacts.Conta" & _
        "ctType, Contacts.UserCode, Customer.Company, Customer.Contacted, Customer.Cus" & _
        "tType, Customer.FirstName, Customer.LastName, Customer.Phone, Customer.UserC" & _
        "ode AS Expr1 FROM Contacts INNER JOIN Customer ON Contacts.UserCode = Customer" & _
        ".UserCode"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Prospective Customers"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(200, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Distributors"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(368, 224)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Reset the Grid"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 269)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button3, Me.Button2, Me.Button1, Me.C1TrueDBGrid1})
        Me.Name = "Form1"
        Me.Text = "Tutorial 11"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustomer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
        Me.OleDbConnection1.ConnectionString = GetModifiedConnectionString(Me.OleDbConnection1.ConnectionString)
            Me.OleDbDataAdapter1.Fill(Me.DsCustomer1)
        Catch eLoad As System.Exception
            MsgBox(eLoad.Message)
        End Try

    End Sub
 
    Private Sub C1TrueDBGrid1_UnboundColumnFetch(ByVal sender As Object, ByVal e As C1.Win.TrueDBGrid.UnboundColumnFetchEventArgs) Handles C1TrueDBGrid1.UnboundColumnFetch
        e.Value = Me.DsCustomer1.Contacts.Rows(e.Row).Item("FirstName") & " " & Me.DsCustomer1.Contacts.Rows(e.Row).Item("LastName")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'prospective
        Me.C1TrueDBGrid1.FetchRowStyles = True
        bFlag = 1
        Me.C1TrueDBGrid1.Refresh()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'distributors
        Me.C1TrueDBGrid1.FetchRowStyles = True
        bFlag = 2
        Me.C1TrueDBGrid1.Refresh()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'reset styles
        Me.C1TrueDBGrid1.FetchRowStyles = False
        Me.C1TrueDBGrid1.Refresh()

    End Sub

    Private Sub C1TrueDBGrid1_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.TrueDBGrid.FetchRowStyleEventArgs) Handles C1TrueDBGrid1.FetchRowStyle
        If bFlag = 1 And Me.C1TrueDBGrid1.Columns("CustType").CellValue(e.Row) = 1 Then
            Dim fntFont As New Font(e.CellStyle.Font.Name, e.CellStyle.Font.Size, FontStyle.Bold)
            e.CellStyle.Font = fntFont
            e.CellStyle.ForeColor = System.Drawing.Color.Blue
        End If

        If bFlag = 2 And Me.C1TrueDBGrid1.Columns("CustType").CellValue(e.Row) = 4 Then
            e.CellStyle.ForeColor = System.Drawing.Color.White
            e.CellStyle.BackColor = System.Drawing.Color.Red

        End If



    End Sub
    Private Function GetModifiedConnectionString(ByVal connstring As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function
End Class
