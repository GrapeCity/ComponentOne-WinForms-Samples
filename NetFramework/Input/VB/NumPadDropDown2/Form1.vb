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
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSet11 As NumPadDropDown2.DataSet1
    Friend WithEvents C1DbNavigator1 As C1.Win.C1Input.C1DbNavigator
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents c1NumericEdit2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1NumericEdit1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit3 As C1.Win.C1Input.C1NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.DataSet11 = New NumPadDropDown2.DataSet1()
        Me.C1DbNavigator1 = New C1.Win.C1Input.C1DbNavigator()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.c1NumericEdit2 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1NumericEdit1 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit3 = New C1.Win.C1Input.C1NumericEdit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DbNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1NumericEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1NumericEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Order Details", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Discount", "Discount")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [Order Details] WHERE (OrderID = ?) AND (ProductID = ?) AND (Discount" & _
        " = ?) AND (Quantity = ?) AND (UnitPrice = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Discount", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(0, Byte), "Discount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Quantity", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program" & _
        " Files\ComponentOne Studio.NET\Common\Nwind.mdb;Mode=Share Deny None;Extended Pr" & _
        "operties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Da" & _
        "tabase Password="""";Jet OLEDB:Engine Type=4;Jet OLEDB:Database Locking Mode=0;Jet" & _
        " OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:" & _
        "New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encryp" & _
        "t Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact " & _
        "Without Replica Repair=False;Jet OLEDB:SFP=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [Order Details] (Discount, OrderID, ProductID, Quantity, UnitPrice) V" & _
        "ALUES (?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Discount", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(0, Byte), "Discount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Discount, OrderID, ProductID, Quantity, UnitPrice FROM [Order Details]"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [Order Details] SET Discount = ?, OrderID = ?, ProductID = ?, Quantity = ?" & _
        ", UnitPrice = ? WHERE (OrderID = ?) AND (ProductID = ?) AND (Discount = ?) AND (" & _
        "Quantity = ?) AND (UnitPrice = ?)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Discount", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(0, Byte), "Discount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Discount", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(0, Byte), "Discount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Quantity", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        '
        'C1DbNavigator1
        '
        Me.C1DbNavigator1.DataMember = "Order Details"
        Me.C1DbNavigator1.DataSource = Me.DataSet11
        Me.C1DbNavigator1.Location = New System.Drawing.Point(14, 128)
        Me.C1DbNavigator1.Name = "C1DbNavigator1"
        Me.C1DbNavigator1.Size = New System.Drawing.Size(334, 24)
        Me.C1DbNavigator1.TabIndex = 0
        Me.C1DbNavigator1.VisibleButtons = ((((C1.Win.C1Input.NavigatorButtonFlags.Navigation Or C1.Win.C1Input.NavigatorButtonFlags.Apply) _
                    Or C1.Win.C1Input.NavigatorButtonFlags.Cancel) _
                    Or C1.Win.C1Input.NavigatorButtonFlags.Update) _
                    Or C1.Win.C1Input.NavigatorButtonFlags.Refresh)
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 92)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(72, 16)
        Me.label3.TabIndex = 12
        Me.label3.Text = "Discount:"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 56)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 16)
        Me.label2.TabIndex = 11
        Me.label2.Text = "UnitPrice:"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 16)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Quantity:"
        '
        'c1NumericEdit2
        '
        Me.c1NumericEdit2.Culture = 1031
        Me.c1NumericEdit2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet11, "Order Details.UnitPrice"))
        Me.c1NumericEdit2.DropDownFormClassName = "NumPadDropDown2.KeyPadDropDown"
        Me.c1NumericEdit2.Location = New System.Drawing.Point(92, 52)
        Me.c1NumericEdit2.Name = "c1NumericEdit2"
        Me.c1NumericEdit2.Size = New System.Drawing.Size(232, 20)
        Me.c1NumericEdit2.TabIndex = 8
        Me.c1NumericEdit2.Tag = Nothing
        '
        'c1NumericEdit1
        '
        Me.c1NumericEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet11, "Order Details.Quantity"))
        Me.c1NumericEdit1.DataType = GetType(System.Int16)
        Me.c1NumericEdit1.DropDownFormClassName = "NumPadDropDown2.KeyPadDropDown"
        Me.c1NumericEdit1.Location = New System.Drawing.Point(92, 16)
        Me.c1NumericEdit1.Name = "c1NumericEdit1"
        Me.c1NumericEdit1.Size = New System.Drawing.Size(232, 20)
        Me.c1NumericEdit1.TabIndex = 7
        Me.c1NumericEdit1.Tag = Nothing
        '
        'C1NumericEdit3
        '
        Me.C1NumericEdit3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet11, "Order Details.Discount"))
        Me.C1NumericEdit3.DataType = GetType(System.Single)
        Me.C1NumericEdit3.DropDownFormClassName = "NumPadDropDown2.KeyPadDropDown"
        Me.C1NumericEdit3.Location = New System.Drawing.Point(92, 88)
        Me.C1NumericEdit3.Name = "C1NumericEdit3"
        Me.C1NumericEdit3.Size = New System.Drawing.Size(232, 20)
        Me.C1NumericEdit3.TabIndex = 13
        Me.C1NumericEdit3.Tag = Nothing
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(356, 165)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1NumericEdit3, Me.label3, Me.label2, Me.label1, Me.c1NumericEdit2, Me.c1NumericEdit1, Me.C1DbNavigator1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Advanced NumPad DropDown"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DbNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1NumericEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1NumericEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & _
                      "\\ComponentOne Samples\\Common\\C1NWind.mdb"

        Dim conn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & ";Mode=Share Deny None;"
        OleDbConnection1.ConnectionString = conn
        OleDbDataAdapter1.Fill(DataSet11)
    End Sub

    Private Sub C1DbNavigator1_RefreshData(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DbNavigator1.RefreshData
        OleDbDataAdapter1.Fill(DataSet11)
    End Sub

    Private Sub C1DbNavigator1_UpdateData(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DbNavigator1.UpdateData
        OleDbDataAdapter1.Update(DataSet11)
    End Sub
End Class
