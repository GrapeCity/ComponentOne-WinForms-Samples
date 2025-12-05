Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
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
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents toolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button()
        Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.toolBar1 = New System.Windows.Forms.ToolBar()
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(80, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(176, 32)
        Me.button1.TabIndex = 4
        Me.button1.Text = "Save (this one gets the focus!)"
        '
        'toolBarButton1
        '
        Me.toolBarButton1.Text = "Save"
        Me.toolBarButton1.ToolTipText = "Save"
        '
        'toolBar1
        '
        Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton1})
        Me.toolBar1.DropDownArrows = True
        Me.toolBar1.Name = "toolBar1"
        Me.toolBar1.ShowToolTips = True
        Me.toolBar1.Size = New System.Drawing.Size(512, 39)
        Me.toolBar1.TabIndex = 3
        '
        '_flex
        '
        Me._flex.BackColor = System.Drawing.SystemColors.Window
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Location = New System.Drawing.Point(0, 39)
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(512, 234)
        Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me.button1, Me.toolBar1})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: LostFocus and DataRowState"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub toolBar1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolBar1.Click
        'the toolbar doesn't get the focus when clicked, so
        'the grid could still be in edit mode...
        _flex.FinishEditing()

        'the grid still has the focus and the cursor hasn't moved to a new row,
        'so the data source still doesn't see the row as changed
        'so we use the currency manager to end the edits
        Dim cm As CurrencyManager = CType(BindingContext(_flex.DataSource, _flex.DataMember), CurrencyManager)
        cm.EndCurrentEdit()

        'proceed as usual
        button1_click(sender, EventArgs.Empty)

    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Console.WriteLine("*** Checking for changes...")

        'check which rows have been modified
        Dim cnt As Integer = 0
        Dim dr As DataRow
        For Each dr In _dt.rows
            If dr.RowState = DataRowState.Modified Then
                cnt = cnt + 1
            End If
        Next
        Console.WriteLine("{0} changed row(s).", cnt)

        'another way
        Dim dtChanges As DataTable = _dt.GetChanges(DataRowState.Modified)
        If Not (dtChanges Is Nothing) Then
            Console.WriteLine("{0} changed row(s).", dtChanges.Rows.Count)
        Else
            Console.WriteLine("{0} changed row(s).", 0)
        End If

        'commit changes
        _dt.AcceptChanges()

    End Sub

    Dim _dt As DataTable

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _dt = New DataTable("test")
        Dim Name_tp As Type = "Name".GetType()

        _dt.Columns.Add("Name", Type.GetType("System.String"))
        _dt.Columns.Add("Age", Type.GetType("System.Int64"))

        Dim data() As Object = New Object(1) {}
        Dim names() As String = "Sue|Ann|Mary|Bob|Joe".Split("|")
        Dim rnd As New Random()

        Dim i As Integer = 0

        For i = 0 To 30 - 1
            data(0) = names(rnd.Next(names.Length - 1))
            data(1) = rnd.Next(6, 102)
            _dt.Rows.Add(data)
        Next

        _dt.AcceptChanges() 'added -> unchanged

        _flex.DataSource = _dt


    End Sub
End Class
