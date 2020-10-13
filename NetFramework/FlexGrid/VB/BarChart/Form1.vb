Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_flex
        '
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:34;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Location = New System.Drawing.Point(0, 0)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 19
        Me._flex.Size = New System.Drawing.Size(737, 355)
        Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
        Me._flex.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(737, 355)
        Me.Controls.Add(Me._flex)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: OwnerDraw Chart"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' bind grid to data source
        Dim conn As String = GetConnectionString()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter("select * from products", conn)
        Dim dt As New DataTable("Products")
        da.Fill(dt)
        _flex.DataSource = dt

        ' hide ID columns so the bars stand out more
        Dim col_ID As Column
        For Each col_ID In _flex.Cols
            If col_ID.Name.EndsWith("ID") Then
                col_ID.Visible = False
            End If
        Next

        ' attach scaling info to each numeric column
        Dim r1 As Integer = _flex.Rows.Fixed
        Dim r2 As Integer = _flex.Rows.Count - 1
        Dim s As String = Nothing
        Dim barCols() As String = New String() {"UnitPrice", "UnitsInStock", "UnitsOnOrder", "ReorderLevel"}

        For Each s In barCols
            Dim col As Column = _flex.Cols(s)
            Dim max As Double = _flex.Aggregate(AggregateEnum.Max, r1, col.Index, r2, col.Index)
            col.UserData = max
        Next

        ' turn on ownerdraw
        _flex.DrawMode = DrawModeEnum.OwnerDraw

    End Sub

    Private Sub _flex_OwnerDrawCell(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles _flex.OwnerDrawCell
        If Not _flex.Cols(e.Col).UserData Is Nothing AndAlso e.Row >= _flex.Rows.Fixed Then
            Dim value As Double
            If Double.TryParse(_flex.GetDataDisplay(e.Row, e.Col), NumberStyles.Any, CultureInfo.CurrentCulture, value) Then

                ' calculate bar extent 
                Dim rc As Rectangle = e.Bounds
                Dim max As Double = CType(_flex.Cols(e.Col).UserData, Double)
                rc.Width = CType((System.Math.Floor(_flex.Cols(e.Col).WidthDisplay * value / max)), Integer)

                ' draw background
                e.DrawCell(DrawCellFlags.Background Or DrawCellFlags.Border)

                ' draw bar
                rc.Inflate(-2, -2)
                e.Graphics.FillRectangle(Brushes.Gold, rc)
                rc.Inflate(-1, -1)
                e.Graphics.FillRectangle(Brushes.LightGoldenrodYellow, rc)

                ' draw cell content
                e.DrawCell(DrawCellFlags.Content)
            End If

        End If
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

End Class
