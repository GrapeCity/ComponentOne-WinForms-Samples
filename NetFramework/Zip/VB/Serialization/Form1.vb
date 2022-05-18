Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.OleDb
Imports C1.Zip

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
    Friend WithEvents statusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents dataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnLoadCompressed As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.statusBar1 = New System.Windows.Forms.StatusBar()
        Me.dataGrid1 = New System.Windows.Forms.DataGrid()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnLoadCompressed = New System.Windows.Forms.Button()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusBar1
        '
        Me.statusBar1.Location = New System.Drawing.Point(0, 279)
        Me.statusBar1.Name = "statusBar1"
        Me.statusBar1.Size = New System.Drawing.Size(608, 22)
        Me.statusBar1.TabIndex = 8
        Me.statusBar1.Text = "Ready"
        '
        'dataGrid1
        '
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid1.Location = New System.Drawing.Point(208, 8)
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.Size = New System.Drawing.Size(392, 256)
        Me.dataGrid1.TabIndex = 7
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(8, 8)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(184, 40)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "Create Data Table"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(8, 56)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(184, 40)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save Data Table"
        '
        'btnLoad
        '
        Me.btnLoad.Enabled = False
        Me.btnLoad.Location = New System.Drawing.Point(8, 176)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(184, 40)
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "Load Data Table"
        '
        'btnLoadCompressed
        '
        Me.btnLoadCompressed.Enabled = False
        Me.btnLoadCompressed.Location = New System.Drawing.Point(8, 224)
        Me.btnLoadCompressed.Name = "btnLoadCompressed"
        Me.btnLoadCompressed.Size = New System.Drawing.Size(184, 40)
        Me.btnLoadCompressed.TabIndex = 5
        Me.btnLoadCompressed.Text = "Load Compressed Data Table"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 301)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.statusBar1, Me.dataGrid1, Me.btnCreate, Me.btnSave, Me.btnLoad, Me.btnLoadCompressed})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Zip: Compressed Serialization"
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const FN_REGULAR As String = "\DataTable.regular"
    Private Const FN_COMPRESSED As String = "\DataTable.compressed"

    ' create DataTable object and populate it from NorthWind database
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        ' open table
        Dim conn As String = GetConnectionString()
        Dim rs As String = "select * from customers"

        ' show status
        Cursor = Cursors.WaitCursor
        statusBar1.Text = "Loading data from mdb file..."

        ' load data
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(rs, conn)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds)

        ' show status
        Cursor = Cursors.Default
        statusBar1.Text = "Loaded " & ds.Tables(0).Rows.Count & " records from mdb file."

        ' bind to grid
        dataGrid1.DataSource = ds.Tables(0)

        ' enable save button
        btnSave.Enabled = True
    End Sub

    ' save DataTable object into two files: regular and compressed versions.
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        ' get data table from grid
        Dim dt As DataTable = dataGrid1.DataSource

        ' show status
        Cursor = Cursors.WaitCursor
        statusBar1.Text = "Serializing data to regular file..."

        ' serialize the data set to a regular file
        Dim fn As String = Application.StartupPath + FN_REGULAR
        Dim fs As FileStream = New FileStream(fn, FileMode.Create)
        Dim bf As BinaryFormatter = New BinaryFormatter()
        bf.Serialize(fs, dt)
        Dim lenRegular As Long = fs.Length
        fs.Close()

        ' show status
        Cursor = Cursors.WaitCursor
        statusBar1.Text = "Serializing data to compressed file..."

        ' serialize the data set to a compressed file
        fn = Application.StartupPath & FN_COMPRESSED
        fs = New FileStream(fn, FileMode.Create)
        Dim compressor As C1ZStreamWriter = New C1ZStreamWriter(fs)
        bf = New BinaryFormatter()
        bf.Serialize(compressor, dt)
        Dim lenCompressed As Long = fs.Length
        fs.Close()

        ' show status
        Cursor = Cursors.Default
		statusBar1.Text = string.Format( _
				"Saved to regular file ({0:#,###} bytes) and " & _
				"compressed file ({1:#,###} bytes)", _
				lenRegular, lenCompressed)

        ' enable load buttons
        btnLoad.Enabled = True
        btnLoadCompressed.Enabled = True
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

        ' clear grid, show status
        Cursor = Cursors.WaitCursor
        dataGrid1.DataSource = Nothing
        statusBar1.Text = "Loading DataTable from regular file..."

        ' deserialize from regular file
        Dim fn As String = Application.StartupPath & FN_REGULAR
        Dim fs As FileStream = New FileStream(fn, FileMode.Open)
        Dim bf As BinaryFormatter = New BinaryFormatter()
        Dim ticks As Long = DateTime.Now.Ticks
        Dim dt As DataTable = bf.Deserialize(fs)
        Dim ms As Long = (DateTime.Now.Ticks - ticks) / TimeSpan.TicksPerMillisecond
        fs.Close()

        ' show result
        Cursor = Cursors.Default
        dataGrid1.DataSource = dt
        statusBar1.Text = "Loaded data from regular file in " & ms.ToString() & " ms."

    End Sub

    Private Sub btnLoadCompressed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadCompressed.Click

        ' clear grid, show status
        Cursor = Cursors.WaitCursor
        dataGrid1.DataSource = Nothing
        statusBar1.Text = "Loading DataTable from compressed file..."

        ' deserialize from compressed file
        Dim fn As String = Application.StartupPath + FN_COMPRESSED
        Dim fs As FileStream = New FileStream(fn, FileMode.Open)
        Dim decompressor As C1ZStreamReader = New C1ZStreamReader(fs)
        Dim bf As BinaryFormatter = New BinaryFormatter()
        Dim ticks As Long = DateTime.Now.Ticks
        Dim dt As DataTable = bf.Deserialize(decompressor)
        Dim ms As Long = (DateTime.Now.Ticks - ticks) / TimeSpan.TicksPerMillisecond
        fs.Close()

        ' show result
        Cursor = Cursors.Default
        dataGrid1.DataSource = dt
        statusBar1.Text = "Loaded data from compressed file in " & ms.ToString() & " ms."
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

End Class
