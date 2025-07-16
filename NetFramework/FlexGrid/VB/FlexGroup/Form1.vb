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
    Friend WithEvents _flexGroup As FlexGroupControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._flexGroup = New FlexGroupVB.FlexGroupControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me._flexGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flexGroup.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_flexGroup
        '
        Me._flexGroup.BackColor = System.Drawing.SystemColors.ControlDark
        Me._flexGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._flexGroup.Controls.AddRange(New System.Windows.Forms.Control() {Me._flexGroup.Grid})
        Me._flexGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flexGroup.FilterRow = True
        Me._flexGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        '
        '_flexGroup.Grid
        '
        Me._flexGroup.Grid.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.Nodes
        Me._flexGroup.Grid.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None
        Me._flexGroup.Grid.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me._flexGroup.Grid.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:18;}" & Microsoft.VisualBasic.ChrW(9)
        Me._flexGroup.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me._flexGroup.Grid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._flexGroup.Grid.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw
        Me._flexGroup.Grid.Location = New System.Drawing.Point(0, 33)
        Me._flexGroup.Grid.Rows.Fixed = 2
        Me._flexGroup.Grid.ShowCursor = True
        Me._flexGroup.Grid.Size = New System.Drawing.Size(556, 272)
        Me._flexGroup.Grid.Styles = New C1.Win.FlexGrid.CellStyleCollection("Normal{Font:Tahoma, 9pt;Border:Flat,1,Control,Horizontal;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:208, 2" & _
        "08, 200;ForeColor:0, 0, 0;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:8" & _
        ", 36, 104;ForeColor:248, 252, 248;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:8, 36, 104;ForeColor:248, 2" & _
        "52, 248;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:240, 244, 216;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:128, 128, 128;Bor" & _
        "der:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:0, 0, 0;ForeColor:248, 25" & _
        "2, 248;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:64, 64, 64;ForeColor:248, 252, 248;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Back" & _
        "Color:64, 64, 64;ForeColor:248, 252, 248;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:64, 64, 64;ForeCo" & _
        "lor:248, 252, 248;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:64, 64, 64;ForeColor:248, 252, 248;}" & Microsoft.VisualBasic.ChrW(9) & "Sub" & _
        "total4{BackColor:64, 64, 64;ForeColor:248, 252, 248;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:64, 64" & _
        ", 64;ForeColor:248, 252, 248;}" & Microsoft.VisualBasic.ChrW(9) & "Group{Font:Tahoma, 9pt, style=Bold;BackColor:208," & _
        " 208, 200;ForeColor:0, 0, 0;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Empty{BackColor:128" & _
        ", 128, 128;ForeColor:248, 252, 248;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flexGroup.Grid.TabIndex = 1
        Me._flexGroup.Grid.Tree.Style = C1.Win.FlexGrid.TreeStyleFlags.Symbols
        Me._flexGroup.Name = "_flexGroup"
        Me._flexGroup.ShowGroups = True
        Me._flexGroup.Size = New System.Drawing.Size(560, 309)
        Me._flexGroup.TabIndex = 0
        Me._flexGroup.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.CheckBox1, Me.Button1, Me.Button2, Me.Button3})
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 309)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 40)
        Me.Panel1.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.Location = New System.Drawing.Point(376, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(152, 16)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "&Filter Row"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "By Country"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(128, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 24)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "By Title"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(248, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 24)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Country/Title"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(560, 349)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flexGroup, Me.Panel1})
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Outlook-style grouping"
        CType(Me._flexGroup.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flexGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mdb As String = "C:\Program Files\ComponentOne Studio.NET 2.0\Common\NWIND.MDB"
        Dim conn As String = GetConnectionString()
        Dim rs As String = "select * from customers"

        ' create data table
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(rs, conn)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)

        ' initialize grid
        _flexGroup.Grid.DataSource = dt
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me._flexGroup.Groups = "Country"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me._flexGroup.Groups = "ContactTitle"
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me._flexGroup.Groups = "Country,ContactTitle"
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Me._flexGroup.FilterRow = Me.CheckBox1.Checked
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
