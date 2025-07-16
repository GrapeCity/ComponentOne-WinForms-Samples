Imports System
Imports System.Data
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports C1.Win.FlexGrid


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
    Friend WithEvents _btnAdd As System.Windows.Forms.Button
    Friend WithEvents _btnDel As System.Windows.Forms.Button
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dataGrid1 = New System.Windows.Forms.DataGrid()
        Me._btnAdd = New System.Windows.Forms.Button()
        Me._btnDel = New System.Windows.Forms.Button()
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGrid1
        '
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid1.Location = New System.Drawing.Point(8, 176)
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.Size = New System.Drawing.Size(496, 128)
        Me.dataGrid1.TabIndex = 5
        '
        '_btnAdd
        '
        Me._btnAdd.Location = New System.Drawing.Point(8, 312)
        Me._btnAdd.Name = "_btnAdd"
        Me._btnAdd.Size = New System.Drawing.Size(136, 32)
        Me._btnAdd.TabIndex = 4
        Me._btnAdd.Text = "Add a column"
        '
        '_btnDel
        '
        Me._btnDel.Location = New System.Drawing.Point(168, 312)
        Me._btnDel.Name = "_btnDel"
        Me._btnDel.Size = New System.Drawing.Size(136, 32)
        Me._btnDel.TabIndex = 3
        Me._btnDel.Text = "Remove a column"
        '
        '_flex
        '
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Location = New System.Drawing.Point(8, 8)
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(496, 160)
        Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 349)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me.dataGrid1, Me._btnAdd, Me._btnDel})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum CountryEnum
        Austria
        Brazil
        Chile
        Denmark
        Ecuador
        Finland
        Germany
        Herzegovina
        Italy
        Japan
        Korea
        Luxembourg
        Madagascar
        Netherlands
        Oman
        Portugla
        Qatar
        Russia
        Spain
        Turkey
        USA
        Venezuela
        Waaaa
        Xaaaa
        Zaire
    End Enum

    Private _dt As DataTable

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _dt = New DataTable("my table")

        Dim c As DataColumnCollection = _dt.Columns
        c.Add("Name", GetType(String))
        c.Add("Male", GetType(Boolean))
        c.Add("Birth", GetType(DateTime))
        c.Add("Country", GetType(CountryEnum))

        Dim r As DataRowCollection = _dt.Rows
        r.Add(New Object() {"Joe", True, New DateTime(1962, 10, 5), CountryEnum.Austria})
        r.Add(New Object() {"Sue", False, New DateTime(1972, 11, 7), CountryEnum.Germany})
        r.Add(New Object() {"Etti", False, New DateTime(1972, 1, 17), CountryEnum.Germany})
        r.Add(New Object() {"Bill", True, New DateTime(1980, 5, 6), CountryEnum.USA})

        _flex.DataSource = _dt
        Me.dataGrid1.DataSource = _dt
    End Sub

    Private _new As Integer = 1

    Private Sub _btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnAdd.Click
        Dim c As DataColumnCollection = _dt.Columns
        c.Add("NewCol " + _new.ToString(), GetType(String))
        _new += 1

    End Sub

    Private Sub _btnDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnDel.Click
        Dim c As DataColumnCollection = _dt.Columns
        Dim lastindex As Integer = c.Count - 1

        If (lastindex > -1) Then
            c.RemoveAt(lastindex)
        End If
    End Sub
End Class
