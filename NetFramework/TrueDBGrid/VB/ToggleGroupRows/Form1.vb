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
    Friend WithEvents C1TrueDBGrid1 As C1.Win.TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSet11 As ToggleGroupRows.DataSet1
    Friend WithEvents radioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton4 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.TrueDBGrid.C1TrueDBGrid()
        Me.DataSet11 = New ToggleGroupRows.DataSet1()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButton4 = New System.Windows.Forms.RadioButton()
        Me.radioButton3 = New System.Windows.Forms.RadioButton()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.DataSource = Me.DataSet11.Orders
        Me.C1TrueDBGrid1.DataView = C1.Win.TrueDBGrid.DataViewEnum.GroupBy
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(16, 16)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.C1TrueDBGrid1.PrintInfo.MeasurementPrinterName = Nothing
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(536, 220)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.Text = "c1TrueDBGrid1"
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
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
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\ComponentOne Studio" &
    ".NET 2.0\Common\C1Nwind.mdb;"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CustomerID, EmployeeID, Freight, OrderDate, OrderID, RequiredDate, ShipAdd" &
    "ress, ShipCity, ShipCountry, ShipName, ShippedDate, ShipPostalCode, ShipRegion, " &
    "ShipVia FROM Orders"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioButton4)
        Me.GroupBox1.Controls.Add(Me.radioButton3)
        Me.GroupBox1.Controls.Add(Me.radioButton2)
        Me.GroupBox1.Controls.Add(Me.radioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(576, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 168)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "groupBox1"
        '
        'radioButton4
        '
        Me.radioButton4.Location = New System.Drawing.Point(16, 120)
        Me.radioButton4.Name = "radioButton4"
        Me.radioButton4.Size = New System.Drawing.Size(136, 24)
        Me.radioButton4.TabIndex = 3
        Me.radioButton4.Text = "Collapse All"
        '
        'radioButton3
        '
        Me.radioButton3.Location = New System.Drawing.Point(16, 88)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(136, 24)
        Me.radioButton3.TabIndex = 2
        Me.radioButton3.Text = "Expand All"
        '
        'radioButton2
        '
        Me.radioButton2.Location = New System.Drawing.Point(16, 48)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(144, 32)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "Collapse Group row"
        '
        'radioButton1
        '
        Me.radioButton1.Location = New System.Drawing.Point(16, 24)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(144, 24)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.Text = "Expand Group row"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(760, 266)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' expand a grouped row
    Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged
        If Me.radioButton1.Checked Then
            Dim row As Integer = Me.C1TrueDBGrid1.Row
            If Me.C1TrueDBGrid1.Splits(0).Rows(row).RowType = C1.Win.TrueDBGrid.RowTypeEnum.CollapsedGroupRow Then
                Me.C1TrueDBGrid1.ExpandGroupRow(row)
            End If
        End If
    End Sub 'radioButton1_CheckedChanged

    ' collapse a grouped row
    Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton2.CheckedChanged
        If Me.radioButton2.Checked Then
            Dim row As Integer = Me.C1TrueDBGrid1.Row
            If Me.C1TrueDBGrid1.Splits(0).Rows(row).RowType = C1.Win.TrueDBGrid.RowTypeEnum.ExpandedGroupRow Then
                Me.C1TrueDBGrid1.CollapseGroupRow(row)
            End If
        End If
    End Sub 'radioButton2_CheckedChanged

    ' expand all grouped rows
    Private Sub radioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton3.CheckedChanged
        If Me.radioButton3.Checked Then
            Dim i As Integer = 0
            ' can't use for...next, doesn't re-evaluate the upper bound and the Rows collection does change as you expand/collapse
            While (i < Me.C1TrueDBGrid1.Splits(0).Rows.Count)
                If Me.C1TrueDBGrid1.Splits(0).Rows(i).RowType <> C1.Win.TrueDBGrid.RowTypeEnum.DataRow Then
                    Me.C1TrueDBGrid1.ExpandGroupRow(i)
                End If
                i = i + 1
            End While
        End If
    End Sub 'radioButton3_CheckedChanged

    ' collapse all grouped rows
    Private Sub radioButton4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton4.CheckedChanged
        If Me.radioButton4.Checked Then
            Dim i As Integer = 0
            ' can't use for...next, doesn't re-evaluate the upper bound and the Rows collection does change as you expand/collapse
            While (i < Me.C1TrueDBGrid1.Splits(0).Rows.Count)
                If Me.C1TrueDBGrid1.Splits(0).Rows(i).RowType <> C1.Win.TrueDBGrid.RowTypeEnum.DataRow Then
                    Me.C1TrueDBGrid1.CollapseGroupRow(i)
                End If
                i = i + 1
            End While
        End If
    End Sub 'radioButton4_CheckedChanged

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OleDbConnection1.ConnectionString = GetModifiedConnectionString(Me.OleDbConnection1.ConnectionString)
        Me.OleDbDataAdapter1.Fill(Me.DataSet11)
        ' intialize the grid to be grouped by CustomerID on load
        Me.C1TrueDBGrid1.GroupedColumns.Add(Me.C1TrueDBGrid1.Columns("CustomerID"))
    End Sub

    ' set the state of the expand/collapse radio button on row change
    Private Sub c1TrueDBGrid1_RowColChange(ByVal sender As Object, ByVal e As C1.Win.TrueDBGrid.RowColChangeEventArgs) Handles C1TrueDBGrid1.RowColChange
        If Me.C1TrueDBGrid1.Splits(0).Rows.Count <= 0 OrElse IsNothing(Me.C1TrueDBGrid1.Splits(0).Rows(Me.C1TrueDBGrid1.Row)) Then Exit Sub '#10989
        ' get the type/state of the row
        Dim rtype As C1.Win.TrueDBGrid.RowTypeEnum = Me.C1TrueDBGrid1.Splits(0).Rows(Me.C1TrueDBGrid1.Row).RowType
        Select Case rtype
            Case C1.Win.TrueDBGrid.RowTypeEnum.CollapsedGroupRow
                Me.radioButton2.Checked = True
            Case C1.Win.TrueDBGrid.RowTypeEnum.ExpandedGroupRow
                Me.radioButton1.Checked = True
        End Select
    End Sub 'c1TrueDBGrid1_RowColChange
    Private Function GetModifiedConnectionString(ByVal connstring As String) As String
        Dim dataSource As Integer = connstring.IndexOf("Data Source=", 0, StringComparison.OrdinalIgnoreCase)
        Dim dataSourceEnd As Integer = connstring.LastIndexOf("\", connstring.IndexOf(";", dataSource))
        connstring = connstring.Substring(0, dataSource) + "Data Source=" + _
         Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
         "\ComponentOne Samples\Common" + connstring.Substring(dataSourceEnd)
        Return connstring
    End Function

End Class
