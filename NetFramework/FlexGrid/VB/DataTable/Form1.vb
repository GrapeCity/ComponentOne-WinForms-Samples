Imports System
Imports System.Data
Imports System.ComponentModel
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing

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
    Friend WithEvents dataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dataGrid1 = New System.Windows.Forms.DataGrid()
        Me.splitter1 = New System.Windows.Forms.Splitter()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.flex = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGrid1
        '
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid1.Location = New System.Drawing.Point(0, 172)
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.Size = New System.Drawing.Size(592, 161)
        Me.dataGrid1.TabIndex = 5
        '
        'splitter1
        '
        Me.splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.splitter1.Location = New System.Drawing.Point(0, 168)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(592, 4)
        Me.splitter1.TabIndex = 6
        Me.splitter1.TabStop = False
        '
        'panel1
        '
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.button1, Me.button2})
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 333)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(592, 40)
        Me.panel1.TabIndex = 4
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(8, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(120, 24)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Add Record"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(144, 8)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(120, 24)
        Me.button2.TabIndex = 0
        Me.button2.Text = "Delete Record"
        '
        'flex
        '
        Me.flex.BackColor = System.Drawing.SystemColors.Window
        Me.flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.flex.Dock = System.Windows.Forms.DockStyle.Top
        Me.flex.Name = "flex"
        Me.flex.Size = New System.Drawing.Size(592, 168)
        Me.flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.flex.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 373)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dataGrid1, Me.splitter1, Me.panel1, Me.flex})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataTable"
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me.flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum MaritalStatus As Integer
        Single_
        Married
        Separated
        Widow
        Deceased
        Unknown
    End Enum

    Public Enum Gender As Integer
        male
        Female
        Unknown
    End Enum

    Private _dt As System.Data.DataTable

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'create new table
        _dt = New System.Data.DataTable("MyDataTable")
        _dt.Columns.Add("Name", GetType(String))
        _dt.Columns.Add("Age", GetType(Integer))
        _dt.Columns.Add("Gender", GetType(Gender))
        _dt.Columns.Add("Status", GetType(MaritalStatus))

        'populate it
        _dt.Rows.Add(New Object() {"Joe", 12, Gender.male, MaritalStatus.Single_})
        _dt.Rows.Add(New Object() {"Bob", 14, Gender.male, MaritalStatus.Single_})
        _dt.Rows.Add(New Object() {"Sue", 13, Gender.Female, MaritalStatus.Single_})
        _dt.Rows.Add(New Object() {"Chris", 26, Gender.Unknown, MaritalStatus.Unknown})

        'bind the grid to it
        flex.Cols(0).Width = flex.Cols.DefaultSize \ 3
        flex.DataSource = _dt
        dataGrid1.DataSource = _dt
    End Sub

    'add a record

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        _dt.Rows.Add(New Object() {"New", 0, Gender.Unknown, MaritalStatus.Unknown})
    End Sub
    'delete a record
    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        If flex.Row >= 0 Then
            Dim r As Integer = flex.Rows(flex.Row).DataIndex
            If r >= 0 Then
                _dt.Rows.RemoveAt(r)
            End If
        End If
    End Sub
End Class
