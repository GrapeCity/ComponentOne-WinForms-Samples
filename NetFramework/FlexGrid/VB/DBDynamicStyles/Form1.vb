Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Collections
Imports System.Data
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
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_flex
        '
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Location = New System.Drawing.Point(0, 0)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 19
        Me._flex.Size = New System.Drawing.Size(709, 378)
        Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
        Me._flex.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(709, 378)
        Me.Controls.Add(Me._flex)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Dynamic Styles"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'get the data
        Dim strSelect As String = "select * from Products"
        Dim strConn As String = GetConnectionString()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(strSelect, strConn)
        Dim dt As DataTable = New DataTable("Products")
        da.Fill(dt)

        'bind to grid
        _flex.ShowCursor = True
        _flex.Cols(0).Width = _flex.Rows.DefaultSize
        _flex.DataSource = dt

        'create custom style and use OwnerDraw to apply them
        Dim s As C1.Win.FlexGrid.CellStyle = _flex.Styles.Add("Critical")
        s.BackColor = Color.DarkOrchid
        s.ForeColor = Color.White
        s.Font = New Font(_flex.Font, FontStyle.Bold)
        _flex.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw
    End Sub

    Private Sub _flex_OwnerDrawCell(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.OwnerDrawCellEventArgs) Handles _flex.OwnerDrawCell

        ' ignore fixed cells
        If e.Row < _flex.Rows.Fixed OrElse e.Col < _flex.Cols.Fixed Then Return

        ' apply custom style if reorder level is critical
        If _flex.Cols(e.Col).Name = "UnitsInStock" Then
            If CType(_flex(e.Row, "UnitsInStock"), Short) < CType(_flex(e.Row, "ReorderLevel"), Short) Then
                e.Style = _flex.Styles("Critical")
            End If
        End If
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
