Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data


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
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button()
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(8, 232)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(176, 32)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Build Outline"
        '
        '_flex
        '
        Me._flex.BackColor = System.Drawing.SystemColors.Window
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(416, 224)
        Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("")
        Me._flex.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 269)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me.button1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'configure grid
        _flex.Cols.Count = 2
        _flex.Cols.Fixed = 0
        _flex.Rows.Count = 1

        Dim s As C1.Win.FlexGrid.CellStyle = _flex.Styles(C1.Win.FlexGrid.CellStyleEnum.Subtotal0)
        s.BackColor = _flex.Styles.Normal.BackColor
        s.ForeColor = _flex.Styles.Normal.ForeColor

        'populate grid
        _flex(0, 0) = "Type"
        _flex(0, 1) = "Item"
        _flex.AddItem("Fruit" & vbTab & "Apple")
        _flex.AddItem("Fruit" & vbTab & "Banana")
        _flex.AddItem("Fruit" & vbTab & "Orange")
        _flex.AddItem("Fruit" & vbTab & "Grape")
        _flex.AddItem("Meat" & vbTab & "Steak")
        _flex.AddItem("Meat" & vbTab & "Rib")
        _flex.AddItem("Meat" & vbTab & "Pot Roast")
        _flex.AddItem("Salad" & vbTab & "Green")
        _flex.AddItem("Salad" & vbTab & "Caesar")
        _flex.AddItem("Salad" & vbTab & "Greek")
        _flex.AddItem("Salad" & vbTab & "Spinach")

    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        'hide column(s) you don't want to show
        _flex.Cols(0).Visible = False

        'move outline tree to first visible column
        _flex.Tree.Column = 1
        _flex.Tree.Style = C1.Win.FlexGrid.TreeStyleFlags.SimpleLeaf

        'build the outline 
        _flex.Subtotal(C1.Win.FlexGrid.AggregateEnum.Clear)
        _flex.Subtotal(C1.Win.FlexGrid.AggregateEnum.None, 0, 0, 0, "{0}")

    End Sub
End Class
