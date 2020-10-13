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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSet11 As CustomSorting.DataSet1
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DataSet11 = New CustomSorting.DataSet1
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(416, 230)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = resources.GetString("OleDbInsertCommand1.CommandText")
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"), New System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Freight", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Freight", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"), New System.Data.OleDb.OleDbParameter("OrderID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, "RequiredDate"), New System.Data.OleDb.OleDbParameter("ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, "ShipAddress"), New System.Data.OleDb.OleDbParameter("ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCity"), New System.Data.OleDb.OleDbParameter("ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCountry"), New System.Data.OleDb.OleDbParameter("ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, "ShipName"), New System.Data.OleDb.OleDbParameter("ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, "ShippedDate"), New System.Data.OleDb.OleDbParameter("ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "ShipPostalCode"), New System.Data.OleDb.OleDbParameter("ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipRegion"), New System.Data.OleDb.OleDbParameter("ShipVia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ShipVia", System.Data.DataRowVersion.Current, Nothing)})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\ComponentOne Studi" & _
            "o.NET 2.0\Common\C1Nwind.mdb;"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CustomerID, EmployeeID, Freight, OrderDate, OrderID, RequiredDate, ShipAdd" & _
            "ress, ShipCity, ShipCountry, ShipName, ShippedDate, ShipPostalCode, ShipRegion, " & _
            "ShipVia FROM Orders"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 230)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Enum SortDir
        None
        Asc
        Desc
    End Enum 'SortDir
    Private _sortup, _sortdn As Bitmap

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OleDbConnection1.ConnectionString = GetModifiedConnectionString(Me.OleDbConnection1.ConnectionString)
        Me.OleDbDataAdapter1.Fill(Me.DataSet11)
        Me.C1TrueDBGrid1.DataSource = Me.DataSet11.Tables(0).DefaultView
        ' we're going to handle the sorting ourselves in the grids headclick event
        Me.C1TrueDBGrid1.AllowSort = False

        Dim dc As C1.Win.C1TrueDBGrid.C1DisplayColumn
        For Each dc In Me.C1TrueDBGrid1.Splits(0).DisplayColumns
            ' make the column headers act like buttons
            dc.ButtonHeader = True
            ' default sort order
            dc.DataColumn.Tag = SortDir.None
        Next dc
        ' get the sorting indicators that we'll use in the column headers
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim an As String = a.GetName().Name
        _sortdn = New Bitmap(a.GetManifestResourceStream((an + ".SortDn.bmp")))
        _sortup = New Bitmap(a.GetManifestResourceStream((an + ".SortUp.bmp")))
        _sortdn.MakeTransparent(Color.Red)
        _sortup.MakeTransparent(Color.Red)

    End Sub

    Private Sub C1TrueDBGrid1_HeadClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1TrueDBGrid1.HeadClick
        ' get the display column that was clicked
        Dim dc As C1.Win.C1TrueDBGrid.C1DisplayColumn = Me.C1TrueDBGrid1.Splits(0).DisplayColumns(e.ColIndex)

        ' new sort order
        Dim newsort As SortDir = SortDir.None
        Select Case CType(dc.DataColumn.Tag, SortDir)
            Case SortDir.None, SortDir.Desc
                newsort = SortDir.Asc
            Case Else
                newsort = SortDir.Desc
        End Select

        ' clear all sort states and our sort indicators
        Dim col As C1.Win.C1TrueDBGrid.C1DisplayColumn
        For Each col In Me.C1TrueDBGrid1.Splits(0).DisplayColumns
            col.DataColumn.Tag = SortDir.None
            col.HeadingStyle.ForegroundImage = Nothing
        Next col

        ' build our new sort condition
        Dim sortCondition As String = dc.DataColumn.DataField + " "
        sortCondition += IIf(newsort = SortDir.Desc, "DESC", "")

        ' sort it
        Me.DataSet11.Tables(0).DefaultView.Sort = sortCondition

        ' save the sort state
        dc.DataColumn.Tag = newsort

        ' update the sorting indicator
        If newsort = SortDir.Asc Then
            dc.HeadingStyle.ForegroundImage = Me._sortup
        Else
            dc.HeadingStyle.ForegroundImage = Me._sortdn
        End If ' indicators go to the right of text
        dc.HeadingStyle.ForeGroundPicturePosition = C1.Win.C1TrueDBGrid.ForeGroundPicturePositionEnum.RightOfText

    End Sub

    Private Function GetModifiedConnectionString(ByVal connstring As String) As String
        Dim dataSource As Integer = connstring.IndexOf("Data Source=", 0, StringComparison.OrdinalIgnoreCase)
        Dim dataSourceEnd As Integer = connstring.LastIndexOf("\", connstring.IndexOf(";", dataSource))
        connstring = connstring.Substring(0, dataSource) + "Data Source=" + _
         Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
         "\ComponentOne Samples\Common" + connstring.Substring(dataSourceEnd)
        Return connstring
    End Function

End Class
