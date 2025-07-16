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
    Friend WithEvents C1TrueDBGrid2 As C1.Win.TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsMasterDetail1 As Tutor03.dsMasterDetail

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.TrueDBGrid.C1TrueDBGrid()
        Me.DsMasterDetail1 = New Tutor03.dsMasterDetail()
        Me.C1TrueDBGrid2 = New C1.Win.TrueDBGrid.C1TrueDBGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMasterDetail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.C1TrueDBGrid1.DataChanged = False
        Me.C1TrueDBGrid1.DataMember = "Composer"
        Me.C1TrueDBGrid1.DataSource = Me.DsMasterDetail1
        Me.C1TrueDBGrid1.ExpandColor = System.Drawing.Color.Black
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(8, 32)
        Me.C1TrueDBGrid1.MarqueeStyle = C1.Win.TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.RecordSelectorWidth = 16
        Me.C1TrueDBGrid1.RowHeight = 15
        Me.C1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1TrueDBGrid1.ScrollTips = False
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(480, 176)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = CType(resources.GetObject("C1TrueDBGrid1.PropBag"), String)
        '
        'DsMasterDetail1
        '
        Me.DsMasterDetail1.DataSetName = "dsMasterDetail"
        Me.DsMasterDetail1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsMasterDetail1.Namespace = "http://www.tempuri.org/dsMasterDetail.xsd"
        '
        'C1TrueDBGrid2
        '
        Me.C1TrueDBGrid2.AllowFilter = True
        Me.C1TrueDBGrid2.AllowRowSizing = C1.Win.TrueDBGrid.RowSizingEnum.AllRows
        Me.C1TrueDBGrid2.AllowSort = True
        Me.C1TrueDBGrid2.CaptionHeight = 17
        Me.C1TrueDBGrid2.CollapseColor = System.Drawing.Color.Black
        Me.C1TrueDBGrid2.DataChanged = False
        Me.C1TrueDBGrid2.DataMember = "Composer.ComposerOpus"
        Me.C1TrueDBGrid2.DataSource = Me.DsMasterDetail1
        Me.C1TrueDBGrid2.ExpandColor = System.Drawing.Color.Black
        Me.C1TrueDBGrid2.ExtendRightColumn = True
        Me.C1TrueDBGrid2.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.C1TrueDBGrid2.Location = New System.Drawing.Point(8, 264)
        Me.C1TrueDBGrid2.MarqueeStyle = C1.Win.TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1TrueDBGrid2.Name = "C1TrueDBGrid2"
        Me.C1TrueDBGrid2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid2.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid2.RecordSelectorWidth = 16
        Me.C1TrueDBGrid2.RowHeight = 15
        Me.C1TrueDBGrid2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1TrueDBGrid2.ScrollTips = False
        Me.C1TrueDBGrid2.Size = New System.Drawing.Size(480, 144)
        Me.C1TrueDBGrid2.TabIndex = 1
        Me.C1TrueDBGrid2.Text = "C1TrueDBGrid2"
        Me.C1TrueDBGrid2.PropBag = CType(resources.GetObject("C1TrueDBGrid2.PropBag"), String)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Composers:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Their Works:"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Composer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("First", "First"), New System.Data.Common.DataColumnMapping("Last", "Last"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Birth", "Birth"), New System.Data.Common.DataColumnMapping("Death", "Death")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Composer(Birth, Country, Death, First, Last) VALUES (?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Birth", System.Data.OleDb.OleDbType.DBDate, 0, "Birth"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Death", System.Data.OleDb.OleDbType.DBDate, 0, "Death"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("First", System.Data.OleDb.OleDbType.VarWChar, 50, "First"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last"))
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
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Birth, Country, Death, First, Last FROM Composer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Opus", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Last", "Last"), New System.Data.Common.DataColumnMapping("Opus", "Opus")})})
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO Opus(Last, Opus) VALUES (?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Opus", System.Data.OleDb.OleDbType.VarWChar, 150, "Opus"))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Last, Opus FROM Opus"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 413)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.Label1, Me.C1TrueDBGrid2, Me.C1TrueDBGrid1})
        Me.Name = "Form1"
        Me.Text = "Tutorial 03"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMasterDetail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
        Me.OleDbConnection1.ConnectionString = GetModifiedConnectionString(Me.OleDbConnection1.ConnectionString)
            Me.OleDbDataAdapter1.Fill(Me.DsMasterDetail1)
            Me.OleDbDataAdapter2.Fill(Me.DsMasterDetail1)
        Catch eLoad As System.Exception
            MsgBox(eLoad.Message)

        End Try
    End Sub
    Private Function GetModifiedConnectionString(ByVal connstring As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function
End Class
