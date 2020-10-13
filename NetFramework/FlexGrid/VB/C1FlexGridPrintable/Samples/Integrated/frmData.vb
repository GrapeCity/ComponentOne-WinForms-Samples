Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Collections

Public Class frmData
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents flex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents msGrid As System.Windows.Forms.DataGrid
    Friend WithEvents lblFlex As System.Windows.Forms.Label
    Friend WithEvents lblMSGrid As System.Windows.Forms.Label
    Friend WithEvents cmbTables As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmData))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbTables = New System.Windows.Forms.ComboBox
        Me.flex = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.msGrid = New System.Windows.Forms.DataGrid
        Me.lblFlex = New System.Windows.Forms.Label
        Me.lblMSGrid = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.flex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.msGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(712, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  ADO.NET Data Binding"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tables"
        '
        'cmbTables
        '
        Me.cmbTables.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTables.Location = New System.Drawing.Point(24, 96)
        Me.cmbTables.Name = "cmbTables"
        Me.cmbTables.Size = New System.Drawing.Size(308, 23)
        Me.cmbTables.TabIndex = 2
        '
        'flex
        '
        Me.flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.flex.Location = New System.Drawing.Point(24, 124)
        Me.flex.Name = "flex"
        Me.flex.Rows.DefaultSize = 17
        Me.flex.Size = New System.Drawing.Size(336, 196)
        Me.flex.StyleInfo = resources.GetString("flex.StyleInfo")
        Me.flex.TabIndex = 3
        Me.flex.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.flex.Tree.NodeImageCollapsed = CType(resources.GetObject("flex.Tree.NodeImageCollapsed"), System.Drawing.Image)
        Me.flex.Tree.NodeImageExpanded = CType(resources.GetObject("flex.Tree.NodeImageExpanded"), System.Drawing.Image)
        '
        'msGrid
        '
        Me.msGrid.DataMember = ""
        Me.msGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.msGrid.Location = New System.Drawing.Point(368, 124)
        Me.msGrid.Name = "msGrid"
        Me.msGrid.Size = New System.Drawing.Size(336, 196)
        Me.msGrid.TabIndex = 4
        '
        'lblFlex
        '
        Me.lblFlex.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlex.Location = New System.Drawing.Point(52, 328)
        Me.lblFlex.Name = "lblFlex"
        Me.lblFlex.Size = New System.Drawing.Size(188, 16)
        Me.lblFlex.TabIndex = 5
        Me.lblFlex.Text = "Time to load ="
        '
        'lblMSGrid
        '
        Me.lblMSGrid.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSGrid.Location = New System.Drawing.Point(408, 328)
        Me.lblMSGrid.Name = "lblMSGrid"
        Me.lblMSGrid.Size = New System.Drawing.Size(172, 16)
        Me.lblMSGrid.TabIndex = 6
        Me.lblMSGrid.Text = "Time to load = "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 345)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMSGrid)
        Me.Controls.Add(Me.lblFlex)
        Me.Controls.Add(Me.msGrid)
        Me.Controls.Add(Me.flex)
        Me.Controls.Add(Me.cmbTables)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data"
        CType(Me.flex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.msGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbTables.Items.Add("Customers")
        cmbTables.Items.Add("Employees")
        cmbTables.Items.Add("Products")
        cmbTables.Items.Add("Invoices")
        cmbTables.Items.Add("Sales")
        cmbTables.SelectedItem = 1

        flex.Cols(0).Width = 50
        flex.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
        flex.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        flex.AutoResize = False

    End Sub

    Private Sub cmbTables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTables.SelectedIndexChanged

        ' find out what sql statement to use
        Dim rs As String = String.Empty
        Select Case (CType(sender.text, String))
            Case "Customers" : rs = "select * from customers"
            Case "Employees" : rs = "select * from employees"
            Case "Products" : rs = "select * from products"
            Case "Invoices" : rs = "select * from invoices"
            Case "Sales" : rs = "select * from [sales by category]"
        End Select

        Cursor = Cursors.WaitCursor

        Dim conn As New OleDbConnection()
        Dim da As New OleDbDataAdapter()
        Dim ds As New DataSet()

        ' connect to database and create dataset
        conn.ConnectionString = GetConnectionString()
        da.SelectCommand = New OleDbCommand(rs, conn)
        da.Fill(ds)

        ' msgrid
        Dim t As Double = Microsoft.VisualBasic.Timer
        msGrid.DataSource = ds.Tables(0)
        lblMSGrid.Text = "Time to load " & Str(Microsoft.VisualBasic.Timer - t)

        ' flexgrid
        t = Microsoft.VisualBasic.Timer
        flex.DataSource = ds.Tables(0)
        lblFlex.Text = "Time to load " & Str(Microsoft.VisualBasic.Timer - t)

        flex.AutoSizeCols()
        Cursor = Cursors.Default

    End Sub

    Private Sub cmbTables_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTables.SelectedValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim printer As C1.Win.C1FlexGrid.C1FlexGridPrintable
        printer = New C1.Win.C1FlexGrid.C1FlexGridPrintable(flex)
        Dim doc As New C1.C1Preview.C1PrintDocument
        Dim rc1 As New C1.C1Preview.RenderC1Printable
        rc1.Object = printer
        doc.Body.Children.Add(rc1)
        Dim pview As New C1.Win.C1Preview.C1PrintPreviewDialog
        pview.Document = doc
        pview.ShowDialog()
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
