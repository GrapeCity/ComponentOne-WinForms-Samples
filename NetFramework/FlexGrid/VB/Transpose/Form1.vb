Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports C1.Win.C1FlexGrid


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
    'It can be modified imports the Windows Form Designer.  
    'Do not modify it imports the code editor.
    Friend WithEvents _btnTranspose As System.Windows.Forms.Button
    Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me._btnTranspose = New System.Windows.Forms.Button
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_btnTranspose
        '
        Me._btnTranspose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._btnTranspose.Location = New System.Drawing.Point(10, 291)
        Me._btnTranspose.Name = "_btnTranspose"
        Me._btnTranspose.Size = New System.Drawing.Size(172, 28)
        Me._btnTranspose.TabIndex = 2
        Me._btnTranspose.Text = "Transpose"
        '
        '_flex
        '
        Me._flex.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Location = New System.Drawing.Point(10, 9)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 19
        Me._flex.Size = New System.Drawing.Size(504, 273)
        Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
        Me._flex.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(528, 329)
        Me.Controls.Add(Me._flex)
        Me.Controls.Add(Me._btnTranspose)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' get some data
        Dim conn As String = GetConnectionString()
        Dim rs As String = "select * from products"
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(rs, conn)
        Dim dt As DataTable = New DataTable("Customers")
        da.Fill(dt)

        ' populate grid
        _flex.DataSource = dt

    End Sub

    Private Sub _btnTranspose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnTranspose.Click

        ' create temp grid to transpose data
        Dim temp As C1FlexGrid = New C1FlexGrid()

        ' set up dimensions
        temp.Rows.Count = _flex.Cols.Count
        temp.Cols.Count = _flex.Rows.Count
        temp.Rows.Fixed = _flex.Cols.Fixed
        temp.Cols.Fixed = _flex.Rows.Fixed

        ' copy data types, formats, styles, etc.
        ' from source columns to dest rows
        Dim i As Integer
        For i = 0 To _flex.Cols.Count - 1
            copyrowcol(_flex.Cols(i), temp.Rows(i))
        Next

        ' copy data types, formats, styles, etc
        ' from source rows to dest columns
        For i = 0 To _flex.Rows.Count - 1
            copyrowcol(_flex.Rows(i), temp.Cols(i))
        Next

        ' transpose data
        Dim r, c As Integer
        For r = 0 To _flex.Rows.Count - 1
            For c = 0 To _flex.Cols.Count - 1
                temp(c, r) = _flex(r, c)
            Next
        Next

        ' transfer all data back to original grid
        _flex.DataSource = temp

        ' and do an autosize
        _flex.AutoSizeCols()

    End Sub

    Private Sub CopyRowCol(ByVal src As RowCol, ByVal dst As RowCol)
        dst.DataType = src.DataType
        dst.Style = src.Style
        dst.StyleFixed = src.StyleFixed
        dst.Visible = src.Visible
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
