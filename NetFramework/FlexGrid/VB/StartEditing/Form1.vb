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
    'It can be modified imports  the Windows Form Designer.  
    'Do not modify it imports  the code editor.
    Friend WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboBox1
        '
        Me.comboBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"EnterCell", "StartEdit", "BeforeEdit"})
        Me.comboBox1.Location = New System.Drawing.Point(0, 280)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(464, 21)
        Me.comboBox1.TabIndex = 2
        '
        '_flex
        '
        Me._flex.BackColor = System.Drawing.SystemColors.Window
        Me._flex.ColumnInfo = "5,1,0,0,0,85,Columns:1{Caption:""Bool"";DataType:System.Boolean;Format:""yes;no"";Ima" &
        "geAlign:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Caption:""Date"";DataType:System.DateTime;Format:""d"";Text" &
        "Align:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Caption:""Int"";DataType:System.Int32;TextAlign:RightCenter;}" &
        "" & Microsoft.VisualBasic.ChrW(9) & "4{Caption:""String"";DataType:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.ForeColor = System.Drawing.SystemColors.WindowText
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(464, 280)
        Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("")
        Me._flex.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 301)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me.comboBox1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub _flex_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles _flex.EnterCell
        If comboBox1.SelectedIndex = 0 Or comboBox1.SelectedIndex = 1 Then
            SetupEditor() '7927
        End If
        _flex.StartEditing()

    End Sub

    Private Sub _flex_StartEdit(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.RowColEventArgs) Handles _flex.StartEdit
        If comboBox1.SelectedIndex = 1 Then
            SetupEditor()
        End If

    End Sub

    Private Sub _flex_AfterResizeRow(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.RowColEventArgs) Handles _flex.AfterResizeRow

    End Sub

    Private Sub _flex_BeforeEdit(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.RowColEventArgs) Handles _flex.BeforeEdit
        _flex.EditOptions = EditFlags.All

        Dim type As Type = _flex.Cols(_flex.Col).DataType

        If type Is GetType(Integer) Then
            _flex.EditOptions = _flex.EditOptions And Not EditFlags.UseNumericEditor
        End If

        If comboBox1.SelectedIndex = 2 Then SetupEditor()
    End Sub

    Private _ctr As Integer = 0
    Private Sub SetupEditor()

        Console.WriteLine("Setting up {0}", _ctr)
        _ctr += 1
        _flex.ComboList = ""
        _flex.EditMask = ""

        Dim type As Type = _flex.Cols(_flex.Col).DataType
        If type Is GetType(Boolean) Then
            _flex.ComboList = "true|false"
        End If
        If type Is GetType(DateTime) Then
            _flex.EditMask = "99/99/9999"
        End If
        If type Is GetType(Integer) Then
            _flex.EditMask = "999999"
        End If
    End Sub
End Class
