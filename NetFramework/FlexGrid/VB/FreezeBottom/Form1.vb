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
    'It can be modified imports  the Windows Form Designer.  
    'Do not modify it imports  the code editor.
    Friend WithEvents _btnCustomers As System.Windows.Forms.Button
    Friend WithEvents _btnEmployees As System.Windows.Forms.Button
    Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me._btnCustomers = New System.Windows.Forms.Button
        Me._btnEmployees = New System.Windows.Forms.Button
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_btnCustomers
        '
        Me._btnCustomers.Location = New System.Drawing.Point(10, 9)
        Me._btnCustomers.Name = "_btnCustomers"
        Me._btnCustomers.Size = New System.Drawing.Size(144, 28)
        Me._btnCustomers.TabIndex = 3
        Me._btnCustomers.Text = "Customers"
        '
        '_btnEmployees
        '
        Me._btnEmployees.Location = New System.Drawing.Point(160, 9)
        Me._btnEmployees.Name = "_btnEmployees"
        Me._btnEmployees.Size = New System.Drawing.Size(144, 28)
        Me._btnEmployees.TabIndex = 2
        Me._btnEmployees.Text = "Employees"
        '
        '_flex
        '
        Me._flex.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Location = New System.Drawing.Point(10, 46)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 19
        Me._flex.ShowCursor = True
        Me._flex.Size = New System.Drawing.Size(428, 303)
        Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
        Me._flex.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(448, 358)
        Me.Controls.Add(Me._flex)
        Me.Controls.Add(Me._btnCustomers)
        Me.Controls.Add(Me._btnEmployees)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Frozen rows at the bottom of the grid"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' initialize control
        _flex.AllowResizing = AllowResizingEnum.Both
        _flex.AllowFreezing = AllowFreezingEnum.Both

        ' bind main grid to Customers table
        bind("select * from customers")

        ' create frozen area at the bottom, with 3 rows
        Dim ffb As FlexFreezeBottom.FlexFreezeBottom = New FreezeBottom.FlexFreezeBottom.FlexFreezeBottom(_flex, 3)
    End Sub

    Private Sub _btnCustomers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnCustomers.Click
        bind("Select * from customers")
    End Sub

    Private Sub _btnEmployees_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnEmployees.Click
        bind("Select * from employees")
    End Sub

    Private Sub Bind(ByVal sql As String)

        ' bind grid to data source
        Dim conn As String = GetConnectionString()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)
        _flex.DataSource = dt

        ' add row indices
        Dim r As Integer
        For r = 0 To _flex.Rows.Count - 1
            _flex(r, 0) = r
        Next
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
