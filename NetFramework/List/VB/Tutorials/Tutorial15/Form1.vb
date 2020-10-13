Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim bh1, bh2 As Brush
    Dim ft As Font

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
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsCustomer1 As Tutorial15.DsCustomer
    Friend WithEvents C1List1 As C1.Win.C1List.C1List
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.DsCustomer1 = New Tutorial15.DsCustomer()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.C1List1 = New C1.Win.C1List.C1List()
        CType(Me.DsCustomer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsCustomer1
        '
        Me.DsCustomer1.DataSetName = "DsCustomer"
        Me.DsCustomer1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsCustomer1.Namespace = "http://www.tempuri.org/DsCustomer.xsd"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("UserCode", "UserCode"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("Company", "Company"), New System.Data.Common.DataColumnMapping("Contacted", "Contacted"), New System.Data.Common.DataColumnMapping("Phone", "Phone")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Customer(Company, Contacted, FirstName, LastName, Phone, UserCode) VA" & _
        "LUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.VarWChar, 30, "Company"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.DBDate, 0, "Contacted"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, "UserCode"))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Company, Contacted, FirstName, LastName, Phone, UserCode FROM Customer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'C1List1
        '
        Me.C1List1.AddItemCols = 0
        Me.C1List1.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1List1.AllowSort = True
        Me.C1List1.AlternatingRows = False
        Me.C1List1.CaptionHeight = 17
        Me.C1List1.ColumnCaptionHeight = 17
        Me.C1List1.ColumnFooterHeight = 17
        Me.C1List1.ColumnWidth = 100
        Me.C1List1.DataMode = C1.Win.C1List.DataModeEnum.Normal
        Me.C1List1.DataSource = Me.DsCustomer1.Customer
        Me.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.C1List1.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1List1.ItemHeight = 15
        Me.C1List1.Location = New System.Drawing.Point(40, 16)
        Me.C1List1.MatchCol = C1.Win.C1List.MatchColEnum.DisplayMember
        Me.C1List1.MatchCompare = C1.Win.C1List.MatchCompareEnum.PartiallyEqual
        Me.C1List1.MatchEntry = C1.Win.C1List.MatchEntryEnum.None
        Me.C1List1.MatchEntryTimeout = CType(2000, Long)
        Me.C1List1.Name = "C1List1"
        Me.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1List1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1List1.ScrollTips = False
        Me.C1List1.Size = New System.Drawing.Size(448, 288)
        Me.C1List1.TabIndex = 0
        Me.C1List1.Text = "C1List1"
        Me.C1List1.PropBag = CType(resources.GetObject("C1List1.PropBag"), String)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1List1})
        Me.Name = "Form1"
        Me.Text = "C1List .Net Tutorial15"
        CType(Me.DsCustomer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OleDbConnection1.ConnectionString = AdjustConnectionString()
        'fill the data
        Me.OleDbDataAdapter1.Fill(Me.DsCustomer1)

        'owner draw every columns
        Dim i As Integer
        For i = 0 To Me.C1List1.Splits(0).DisplayColumns.Count - 1
            Me.C1List1.Splits(0).DisplayColumns(i).OwnerDraw = True
        Next

        'set the row height
        Me.C1List1.ItemHeight = 25

        'set the brushs and font
        Me.bh1 = New SolidBrush(Color.Pink)
        Me.bh2 = New SolidBrush(Color.Yellow)
        Dim ff As FontFamily
        ff = New FontFamily("Arial")
        Me.ft = New Font(ff, 14, FontStyle.Regular, GraphicsUnit.Pixel)
    End Sub

    Private Function AdjustConnectionString() As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function


    Private Sub C1List1_OwnerDrawCell(ByVal sender As Object, ByVal e As C1.Win.C1List.OwnerDrawCellEventArgs) Handles C1List1.OwnerDrawCell
        'draw alterlative background
        If (e.Row Mod 2 = 0) Then
            e.Graphics.FillRectangle(Me.bh1, e.CellRect)
        Else
            e.Graphics.FillRectangle(Me.bh2, e.CellRect)
        End If
        e.Graphics.DrawString(e.Text, Me.ft, New SolidBrush(Color.Black), e.CellRect.Left, e.CellRect.Top)
        e.Handled = True
    End Sub

End Class
