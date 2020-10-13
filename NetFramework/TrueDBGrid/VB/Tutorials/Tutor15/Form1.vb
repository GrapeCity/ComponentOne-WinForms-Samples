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
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsComposer1 As Tutor15.dsComposer
    Friend WithEvents Button1 As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.DsComposer1 = New Tutor15.dsComposer
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsComposer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowAddNew = True
        Me.C1TrueDBGrid1.Caption = "C1TrueDBGrid.Net"
        Me.C1TrueDBGrid1.DataMember = "Composer"
        Me.C1TrueDBGrid1.DataSource = Me.DsComposer1
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(8, 8)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(464, 218)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'DsComposer1
        '
        Me.DsComposer1.DataSetName = "dsComposer"
        Me.DsComposer1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsComposer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Birth", System.Data.OleDb.OleDbType.DBDate, 0, "Birth"), New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"), New System.Data.OleDb.OleDbParameter("Death", System.Data.OleDb.OleDbType.DBDate, 0, "Death"), New System.Data.OleDb.OleDbParameter("First", System.Data.OleDb.OleDbType.VarWChar, 50, "First"), New System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last")})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = resources.GetString("OleDbConnection1.ConnectionString")
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Birth, Country, Death, First, Last FROM Composer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Print Preview"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 273)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Name = "Form1"
        Me.Text = "Tutorial 15"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsComposer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.OleDbConnection1.ConnectionString = GetModifiedConnectionString(Me.OleDbConnection1.ConnectionString)
            Me.OleDbDataAdapter1.Fill(Me.DsComposer1)
        Catch eLoad As System.Exception
            MsgBox(eLoad.Message)
        End Try

        'change the presentation of the grid
        With Me.C1TrueDBGrid1.Splits(0).DisplayColumns
            .Item("Country").Style.BackColor = System.Drawing.Color.Cyan
            Dim fntFont As Font
            fntFont = New Font("Times New Roman", .Item("Country").Style.Font.Size, FontStyle.Regular)
            .Item("Country").Style.Font = fntFont
            .Item("Last").Style.ForeColor = System.Drawing.Color.Red

        End With
        Me.C1TrueDBGrid1.Columns("last").NumberFormat = "FormatText Event"


        With Me.C1TrueDBGrid1.HeadingStyle
            Dim fntfont As Font
            fntfont = New Font(.Font.Name, .Font.Size, FontStyle.Bold)
            .Font = fntfont
            .BackColor = System.Drawing.Color.Blue
            .ForeColor = System.Drawing.Color.Yellow

        End With
    End Sub

    Private Sub C1TrueDBGrid1_FormatText(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FormatTextEventArgs) Handles C1TrueDBGrid1.FormatText
        e.Value = UCase(e.Value)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With Me.C1TrueDBGrid1.PrintInfo
            Dim fntFont As Font
            fntFont = New Font(.PageHeaderStyle.Font.Name, .PageHeaderStyle.Font.Size, FontStyle.Italic)
            .PageHeaderStyle.Font = fntFont
            .PageHeader = "Composers Table"

            'column headers will be on every page
            .RepeatColumnHeaders = True

            'display page numbers (centered)
            .PageFooter = "Page: \p"

            'invoke print preview
            .UseGridColors = True
            .PrintPreview()


        End With
    End Sub
    Private Function GetModifiedConnectionString(ByVal connstring As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function
End Class
