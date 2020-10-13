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
    Friend WithEvents C1DropDownControl1 As C1.Win.C1Input.C1DropDownControl
    Public WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Public WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Public WithEvents DataSet11 As WindowsApplication2.DataSet1
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents C1DbNavigator1 As C1.Win.C1Input.C1DbNavigator
    Friend WithEvents C1Label1 As C1.Win.C1Input.C1Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents C1Label2 As C1.Win.C1Input.C1Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1DropDownControl1 = New C1.Win.C1Input.C1DropDownControl
        Me.DataSet11 = New WindowsApplication2.DataSet1
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.C1DbNavigator1 = New C1.Win.C1Input.C1DbNavigator
        Me.C1Label1 = New C1.Win.C1Input.C1Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.C1Label2 = New C1.Win.C1Input.C1Label
        CType(Me.C1DropDownControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DbNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DropDownControl1
        '
        Me.C1DropDownControl1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet11.Orders, "EmployeeID", True))
        Me.C1DropDownControl1.DataType = GetType(Integer)
        Me.C1DropDownControl1.DisableOnNoData = False
        Me.C1DropDownControl1.DropDownFormClassName = "WindowsApplication2.Form2"
        Me.C1DropDownControl1.FormatType = C1.Win.C1Input.FormatTypeEnum.UseEvent
        Me.C1DropDownControl1.Location = New System.Drawing.Point(143, 112)
        Me.C1DropDownControl1.Name = "C1DropDownControl1"
        Me.C1DropDownControl1.Size = New System.Drawing.Size(193, 20)
        Me.C1DropDownControl1.TabIndex = 0
        Me.C1DropDownControl1.Tag = Nothing
        Me.C1DropDownControl1.VisibleButtons = CType(((C1.Win.C1Input.DropDownControlButtonFlags.UpDown Or C1.Win.C1Input.DropDownControlButtonFlags.DropDown) _
                    Or C1.Win.C1Input.DropDownControlButtonFlags.Modal), C1.Win.C1Input.DropDownControlButtonFlags)
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("ru-RU")
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = resources.GetString("OleDbConnection1.ConnectionString")
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Employees", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("Name", "Name")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Employees(EmployeeID, FirstName, LastName) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.[Integer], 0, "EmployeeID"), New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"), New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName")})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT EmployeeID, FirstName, LastName, FirstName + ' ' + LastName AS Name FROM E" & _
            "mployees"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EmployeeID1", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_OrderDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO Orders(OrderDate, EmployeeID, CustomerID) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"), New System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.[Integer], 0, "EmployeeID"), New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID")})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT OrderDate, EmployeeID, OrderID, CustomerID FROM Orders"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"), New System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.[Integer], 0, "EmployeeID"), New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"), New System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EmployeeID1", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_OrderDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing)})
        '
        'C1DbNavigator1
        '
        Me.C1DbNavigator1.DataSource = Me.DataSet11.Orders
        Me.C1DbNavigator1.Location = New System.Drawing.Point(64, 16)
        Me.C1DbNavigator1.Name = "C1DbNavigator1"
        Me.C1DbNavigator1.Size = New System.Drawing.Size(256, 24)
        Me.C1DbNavigator1.TabIndex = 1
        Me.C1DbNavigator1.UIStrings.Content = New String() {"Row`::Orders:"}
        Me.C1DbNavigator1.VisibleButtons = CType((((((C1.Win.C1Input.NavigatorButtonFlags.First Or C1.Win.C1Input.NavigatorButtonFlags.Previous) _
                    Or C1.Win.C1Input.NavigatorButtonFlags.[Next]) _
                    Or C1.Win.C1Input.NavigatorButtonFlags.Last) _
                    Or C1.Win.C1Input.NavigatorButtonFlags.Apply) _
                    Or C1.Win.C1Input.NavigatorButtonFlags.Cancel), C1.Win.C1Input.NavigatorButtonFlags)
        '
        'C1Label1
        '
        Me.C1Label1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet11.Orders, "EmployeeID", True))
        Me.C1Label1.DataType = GetType(Integer)
        Me.C1Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.C1Label1.Location = New System.Drawing.Point(143, 78)
        Me.C1Label1.Name = "C1Label1"
        Me.C1Label1.Size = New System.Drawing.Size(100, 23)
        Me.C1Label1.TabIndex = 2
        Me.C1Label1.Tag = Nothing
        Me.C1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "EmployeeID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Employee Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "OrderID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1Label2
        '
        Me.C1Label2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet11.Orders, "OrderID", True))
        Me.C1Label2.DataType = GetType(Integer)
        Me.C1Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.C1Label2.Location = New System.Drawing.Point(144, 48)
        Me.C1Label2.Name = "C1Label2"
        Me.C1Label2.Size = New System.Drawing.Size(100, 23)
        Me.C1Label2.TabIndex = 5
        Me.C1Label2.Tag = Nothing
        Me.C1Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 158)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C1DbNavigator1)
        Me.Controls.Add(Me.C1Label2)
        Me.Controls.Add(Me.C1Label1)
        Me.Controls.Add(Me.C1DropDownControl1)
        Me.HelpButton = True
        Me.Name = "Form1"
        Me.Text = "Lookup dropdown sample"
        CType(Me.C1DropDownControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DbNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'fill source and lookup datasets
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & _
                      "\\ComponentOne Samples\\Common\\C1NWind.mdb"

        Dim conn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & ";Mode=Share Deny None;"
        OleDbConnection1.ConnectionString = conn

        OleDbDataAdapter1.Fill(DataSet11)
        OleDbDataAdapter2.Fill(DataSet11)
        DataSet11.Employees.DefaultView.Sort = "Name"
        'link lookup dataset to dropdown listbox
        Dim f As Form2 = CType(C1DropDownControl1.DropDownForm, Form2)
        f.ListBox1.DataSource = DataSet11.Employees
        f.ListBox1.DisplayMember = "Name"
        f.ListBox1.ValueMember = "EmployeeID"
    End Sub

    Private Sub C1DropDownControl1_Formatting(ByVal sender As Object, ByVal e As C1.Win.C1Input.FormatEventArgs) Handles C1DropDownControl1.Formatting
        'get text using value
        Dim foundRow As DataRow
        foundRow = DataSet11.Employees.FindByEmployeeID(e.Value)
        If Not (foundRow Is Nothing) Then
            e.Text = foundRow.Item("Name").ToString()
        End If
    End Sub

    Private Sub C1DropDownControl1_DropDownOpened(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DropDownControl1.DropDownOpened
        'select current text within dropdown list using current value
        Dim f As Form2 = CType(C1DropDownControl1.DropDownForm, Form2)
        f.ListBox1.SelectedValue = C1DropDownControl1.Value
    End Sub

    Private Sub C1DropDownControl1_Parsing(ByVal sender As Object, ByVal e As C1.Win.C1Input.ParseEventArgs) Handles C1DropDownControl1.Parsing
        'parse current text and find corresponding value
        Dim i As Integer = DataSet11.Employees.DefaultView.Find(e.Text)
        If i >= 0 Then
            e.Value = DataSet11.Employees.DefaultView.Item(i).Item("EmployeeID")
        End If
    End Sub

    Private Sub C1DropDownControl1_UpDownButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1Input.UpDownButtonClickEventArgs) Handles C1DropDownControl1.UpDownButtonClick
        If DataSet11.Employees.Rows.Count = 0 Then Exit Sub
        'move to the next or previous item from list using default sorting by Name
        Dim i As Integer = DataSet11.Employees.DefaultView.Find(C1DropDownControl1.Text)
        If e.Delta > 0 Then
            i = i + 1
        Else
            i = i - 1
        End If
        If i < 0 Then i = DataSet11.Employees.DefaultView.Count - 1
        If i >= DataSet11.Employees.DefaultView.Count Then i = 0
        C1DropDownControl1.Value = DataSet11.Employees.DefaultView.Item(i).Item("EmployeeID")
    End Sub

    Private Sub C1DropDownControl1_ModalButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DropDownControl1.ModalButtonClick
        Dim f3 As New Form3
        f3.C1TextBox1.Value = DataSet11.Employees.Compute("Max(EmployeeID) + 1", "")

        If f3.ShowDialog() = DialogResult.OK Then
            Dim foundRow As DataRow



            foundRow = DataSet11.Employees.FindByEmployeeID(f3.C1TextBox1.Value)
            If Not (foundRow Is Nothing) Then
                MsgBox("This EmployeeID already exists, row can't be added")
                Exit Sub
            End If
            Dim new_row As DataRow = DataSet11.Employees.NewRow()
            new_row.Item("EmployeeID") = f3.C1TextBox1.Value
            new_row.Item("FirstName") = f3.C1TextBox2.Value
            new_row.Item("LastName") = f3.C1TextBox3.Value
            new_row.Item("Name") = f3.C1TextBox2.Value + " " + f3.C1TextBox3.Value
            DataSet11.Employees.AddEmployeesRow(new_row)
            C1DropDownControl1.Value = f3.C1TextBox1.Value
        End If
    End Sub
End Class
