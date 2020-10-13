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
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSet11 As AggreGateFooter.DataSet1
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
      Private _countries As New Hashtable()
      Private _cities As New Hashtable()

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.DataSet11 = New AggreGateFooter.DataSet1
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.ColumnFooters = True
        Me.C1TrueDBGrid1.DataSource = Me.DataSet11.Customers
        Me.C1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TrueDBGrid1.FilterBar = True
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(696, 302)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.Text = "c1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("City", "City")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Customers(CustomerID, Country, ContactTitle, ContactName, CompanyName" & _
            ", City) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"), New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"), New System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"), New System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"), New System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City")})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\ComponentOne Studi" & _
            "o.NET 2.0\Common\C1Nwind.mdb;"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CustomerID, Country, ContactTitle, ContactName, CompanyName, City FROM Cus" & _
            "tomers"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(696, 302)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()
        Me.OleDbConnection1.ConnectionString = GetModifiedConnectionString(Me.OleDbConnection1.ConnectionString)
        Me.OleDbDataAdapter1.Fill(Me.DataSet11)
        ' calculate the unique number of countries and cities to place in the footer
        _calcFooter()
        ' now attach a listener so we know when the filter changes
        ' First get the currency manager
        Dim cm As CurrencyManager = Me.BindingContext(Me.C1TrueDBGrid1.DataSource, Me.C1TrueDBGrid1.DataMember)
        ' now get the bindinglist
        Dim blist As System.ComponentModel.IBindingList = cm.List
        ' if the bindinglist supports notification then attach a listener
        If Not (blist Is Nothing) AndAlso blist.SupportsChangeNotification Then
            AddHandler blist.ListChanged, AddressOf BindingListChanged
        End If

    End Sub
      Private Sub _calcFooter()
         ' clear our counters
         Me._countries.Clear()
         Me._cities.Clear()
         ' get the total # of rows in the grid
         Dim rows As Integer = Me.c1TrueDBGrid1.Splits(0).Rows.Count
         
         ' now compute the number of unique values for the country and city columns
         Dim i As Integer
         For i = 0 To rows - 1
            Dim s As String = Me.c1TrueDBGrid1(i, "Country").ToString()
            If Not Me._countries.Contains(s) Then
               Me._countries.Add(s, 0)
            End If
            s = Me.c1TrueDBGrid1(i, "City").ToString()
            If Not Me._cities.Contains(s) Then
               Me._cities.Add(s, 0)
            End If
         Next i 
         Me.c1TrueDBGrid1.Columns("Country").FooterText = Me._countries.Count.ToString()
         Me.c1TrueDBGrid1.Columns("City").FooterText = Me._cities.Count.ToString()
      End Sub '_calcFooter
       
    Private Sub BindingListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs)
        If e.ListChangedType = System.ComponentModel.ListChangedType.Reset Then
            _calcFooter()
        End If
    End Sub 'BindingListChanged

    Private Function GetModifiedConnectionString(ByVal connstring As String) As String
        Dim dataSource As Integer = connstring.IndexOf("Data Source=", 0, StringComparison.OrdinalIgnoreCase)
        Dim dataSourceEnd As Integer = connstring.LastIndexOf("\", connstring.IndexOf(";", dataSource))
        connstring = connstring.Substring(0, dataSource) + "Data Source=" + _
         Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
         "\ComponentOne Samples\Common" + connstring.Substring(dataSourceEnd)
        Return connstring
    End Function

End Class
