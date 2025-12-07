Imports System.Data.OleDb
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_flex
        '
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Location = New System.Drawing.Point(120, 0)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 17
        Me._flex.Size = New System.Drawing.Size(552, 412)
        Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
        Me._flex.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Slow"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Fast"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(10, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 26)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Fastest"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(120, 412)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(552, 25)
        Me.StatusBar1.TabIndex = 2
        Me.StatusBar1.Text = "StatusBar1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(672, 437)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me._flex)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.StatusBar1)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(120, 0, 0, 0)
        Me.Text = "Form1"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _dt As New DataTable()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' load data into table
        Dim sql As String = "select * from customers"
        Dim conn As String = GetConnectionString()
        Dim da As New OleDbDataAdapter(sql, conn)
        da.Fill(_dt)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim start As DateTime = DateTime.Now

        ' slow loading (repaint on, string concatenation)
        _flex.Rows.Count = 1
        _flex.Cols.Count = _dt.Columns.Count + 1
        Dim dr As DataRow, dc As DataColumn
        For Each dr In _dt.Rows

            Dim line As String = ""
            For Each dc In _dt.Columns
                line = line & vbTab & String.Format("{0}", dr(dc))
            Next
            _flex.AddItem(line)

        Next

        Dim ts As TimeSpan = DateTime.Now.Subtract(start)
        Me.StatusBar1.Text = String.Format("Slow loading done in {0} msec", ts.TotalMilliseconds)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim start As DateTime = DateTime.Now

        ' faster loading (repaint off, StringBuilder)
        _flex.Redraw = False

        _flex.Rows.Count = 1
        _flex.Cols.Count = _dt.Columns.Count + 1
        Dim dr As DataRow, dc As DataColumn
        For Each dr In _dt.Rows

            Dim sb As New System.Text.StringBuilder()
            For Each dc In _dt.Columns
                sb.Append(vbTab)
                sb.Append(String.Format("{0}", dr(dc)))
            Next
            _flex.AddItem(sb.ToString())

        Next

        _flex.Redraw = True

        Dim ts As TimeSpan = DateTime.Now.Subtract(start)
        Me.StatusBar1.Text = String.Format("Faster loading done in {0} msec", ts.TotalMilliseconds)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim start As DateTime = DateTime.Now

        ' faster loading (repaint off, no strings at all)
        _flex.Redraw = False

        _flex.Rows.Count = _dt.Rows.Count + 1
        _flex.Cols.Count = _dt.Columns.Count + 1
        Dim dr As DataRow, dc As DataColumn
        Dim rowIndex%, colIndex%
        rowIndex = 0
        For Each dr In _dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In _dt.Columns
                colIndex = colIndex + 1
                _flex(rowIndex, colIndex) = dr(dc)
            Next
        Next

        _flex.Redraw = True

        Dim ts As TimeSpan = DateTime.Now.Subtract(start)
        Me.StatusBar1.Text = String.Format("Fastest loading done in {0} msec", ts.TotalMilliseconds)

    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

End Class
