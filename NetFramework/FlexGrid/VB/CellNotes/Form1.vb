Imports System.Text
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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents _btnShowNotes As System.Windows.Forms.Button
    Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.label1 = New System.Windows.Forms.Label()
        Me._btnShowNotes = New System.Windows.Forms.Button()
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.Location = New System.Drawing.Point(140, 5)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(477, 37)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Move the mouse over cells to see notes. Use the context menu to edit notes."
        '
        '_btnShowNotes
        '
        Me._btnShowNotes.Location = New System.Drawing.Point(10, 9)
        Me._btnShowNotes.Name = "_btnShowNotes"
        Me._btnShowNotes.Size = New System.Drawing.Size(124, 28)
        Me._btnShowNotes.TabIndex = 6
        Me._btnShowNotes.Text = "Show all notes"
        '
        '_flex
        '
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:23;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Location = New System.Drawing.Point(0, 45)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 17
        Me._flex.Size = New System.Drawing.Size(640, 392)
        Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
        Me._flex.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(640, 437)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me._btnShowNotes)
        Me.Controls.Add(Me._flex)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(0, 45, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: CellNotes"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim conn As String = GetConnectionString()
        Dim sql As String = "select * from employees"

        Dim da As New OleDbDataAdapter(sql, conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        Me._flex.DataSource = dt
        Me._flex.Cols.Item("Notes").Visible = False

        Dim col As Integer = Me._flex.Cols.Item("FirstName").Index
        Dim row As Integer = Me._flex.Rows.Fixed
        Do While (row < Me._flex.Rows.Count)
            Dim note As New CellNote(CType(Me._flex.Item(row, "Notes"), String))
            Dim rg As CellRange = Me._flex.GetCellRange(row, col)
            rg.UserData = note
            row += 1
        Loop
        Dim manager1 As New CellNoteManager(Me._flex)
    End Sub

    Private Sub _btnShowNotes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnShowNotes.Click

        Dim sb As New StringBuilder()
        sb.Append("** Cell Notes:")

        Dim r As Integer
        Dim c As Integer
        Dim count As Integer = 0

        For r = 0 To _flex.Rows.Count - 1

            For c = 0 To _flex.Cols.Count - 1

                Dim rg As CellRange = _flex.GetCellRange(r, c)
                Dim note As CellNote = CType(rg.UserData, CellNote)
                If Not note Is Nothing Then
                    count = count + 1
                    sb.Append("\r\n-----------------------------\r\n")
                    sb.AppendFormat("Notes for cell {0}, {1}: (form size is {2} by {3})\r\n", _
                     r, c, note.Width, note.Height)
                    sb.Append(note.NoteText)
                End If
            Next
        Next

        If count = 0 Then

            sb.Append("\r\nThis form contains no notes.")
        End If

        MessageBox.Show(sb.ToString())
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

End Class
