Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
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
    Friend WithEvents panel3 As System.Windows.Forms.Panel
    Friend WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents splitter3 As System.Windows.Forms.Splitter
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents _splitterTop As System.Windows.Forms.Splitter
    Friend WithEvents _splitterBottom As System.Windows.Forms.Splitter
    Friend WithEvents _flexBR As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents _flexTL As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents _flexBL As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents _flexTR As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panel3 = New System.Windows.Forms.Panel
        Me.panel2 = New System.Windows.Forms.Panel
        Me._flexBR = New C1.Win.FlexGrid.C1FlexGrid
        Me._splitterBottom = New System.Windows.Forms.Splitter
        Me._flexBL = New C1.Win.FlexGrid.C1FlexGrid
        Me.splitter3 = New System.Windows.Forms.Splitter
        Me.panel1 = New System.Windows.Forms.Panel
        Me._flexTR = New C1.Win.FlexGrid.C1FlexGrid
        Me._splitterTop = New System.Windows.Forms.Splitter
        Me._flexTL = New C1.Win.FlexGrid.C1FlexGrid
        Me.panel3.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me._flexBR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flexBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me._flexTR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flexTL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel3
        '
        Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel3.Controls.Add(Me.panel2)
        Me.panel3.Controls.Add(Me.splitter3)
        Me.panel3.Controls.Add(Me.panel1)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(0, 0)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(536, 373)
        Me.panel3.TabIndex = 2
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me._flexBR)
        Me.panel2.Controls.Add(Me._splitterBottom)
        Me.panel2.Controls.Add(Me._flexBL)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(0, 185)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(532, 184)
        Me.panel2.TabIndex = 0
        '
        '_flexBR
        '
        Me._flexBR.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me._flexBR.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flexBR.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flexBR.Location = New System.Drawing.Point(221, 0)
        Me._flexBR.Name = "_flexBR"
        Me._flexBR.Rows.DefaultSize = 19
        Me._flexBR.Size = New System.Drawing.Size(311, 184)
        Me._flexBR.StyleInfo = resources.GetString("_flexBR.StyleInfo")
        Me._flexBR.TabIndex = 5
        '
        '_splitterBottom
        '
        Me._splitterBottom.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me._splitterBottom.Location = New System.Drawing.Point(211, 0)
        Me._splitterBottom.Name = "_splitterBottom"
        Me._splitterBottom.Size = New System.Drawing.Size(10, 184)
        Me._splitterBottom.TabIndex = 3
        Me._splitterBottom.TabStop = False
        '
        '_flexBL
        '
        Me._flexBL.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me._flexBL.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flexBL.Dock = System.Windows.Forms.DockStyle.Left
        Me._flexBL.Location = New System.Drawing.Point(0, 0)
        Me._flexBL.Name = "_flexBL"
        Me._flexBL.Rows.DefaultSize = 19
        Me._flexBL.Size = New System.Drawing.Size(211, 184)
        Me._flexBL.StyleInfo = resources.GetString("_flexBL.StyleInfo")
        Me._flexBL.TabIndex = 4
        '
        'splitter3
        '
        Me.splitter3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.splitter3.Dock = System.Windows.Forms.DockStyle.Top
        Me.splitter3.Location = New System.Drawing.Point(0, 175)
        Me.splitter3.Name = "splitter3"
        Me.splitter3.Size = New System.Drawing.Size(532, 10)
        Me.splitter3.TabIndex = 1
        Me.splitter3.TabStop = False
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me._flexTR)
        Me.panel1.Controls.Add(Me._splitterTop)
        Me.panel1.Controls.Add(Me._flexTL)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(532, 175)
        Me.panel1.TabIndex = 0
        '
        '_flexTR
        '
        Me._flexTR.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me._flexTR.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flexTR.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flexTR.Location = New System.Drawing.Point(221, 0)
        Me._flexTR.Name = "_flexTR"
        Me._flexTR.Rows.DefaultSize = 19
        Me._flexTR.Size = New System.Drawing.Size(311, 175)
        Me._flexTR.StyleInfo = resources.GetString("_flexTR.StyleInfo")
        Me._flexTR.TabIndex = 7
        '
        '_splitterTop
        '
        Me._splitterTop.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me._splitterTop.Location = New System.Drawing.Point(211, 0)
        Me._splitterTop.Name = "_splitterTop"
        Me._splitterTop.Size = New System.Drawing.Size(10, 175)
        Me._splitterTop.TabIndex = 1
        Me._splitterTop.TabStop = False
        '
        '_flexTL
        '
        Me._flexTL.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me._flexTL.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flexTL.Dock = System.Windows.Forms.DockStyle.Left
        Me._flexTL.Location = New System.Drawing.Point(0, 0)
        Me._flexTL.Name = "_flexTL"
        Me._flexTL.Rows.DefaultSize = 19
        Me._flexTL.Size = New System.Drawing.Size(211, 175)
        Me._flexTL.StyleInfo = resources.GetString("_flexTL.StyleInfo")
        Me._flexTL.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(536, 373)
        Me.Controls.Add(Me.panel3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Splits"
        Me.panel3.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        CType(Me._flexBR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flexBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me._flexTR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flexTL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'bind subordinate splits to "master" split
        '(all subordinate splits use master as a DataSource)
        _flexBL.DataSource = _flexTL
        _flexBR.DataSource = _flexTL
        _flexTR.DataSource = _flexTL

        'adjust scrollbars
        _flexTL.ScrollBars = ScrollBars.None
        _flexTR.ScrollBars = ScrollBars.Vertical
        _flexBL.ScrollBars = ScrollBars.Horizontal
        _flexBR.ScrollBars = ScrollBars.Both

        'cosmetic
        _flexTL.Cols(0).Width = _flexTL.Rows(0).HeightDisplay
        _flexTL.ShowCursor = True
        _flexTR.ShowCursor = True
        _flexBL.ShowCursor = True
        _flexBR.ShowCursor = True

        Dim conn As String = GetConnectionString()
        Dim rs As String = "select * from Customers"
        Dim da As New OleDbDataAdapter(rs, conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        _flexTL.DataSource = dt
    End Sub

    ' keep vertical splitters in synch
    Private Sub _splitterTop_SplitterMoved(ByVal sender As Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles _splitterTop.SplitterMoved
        _flexBL.Width = _flexTL.Width
    End Sub

    Private Sub _splitterBottom_SplitterMoved(ByVal sender As Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles _splitterBottom.SplitterMoved
        _flexTL.Width = _flexBL.Width
    End Sub

    Private _synchronizing As Boolean = False
    Private Sub _flex_AfterScroll(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.RangeEventArgs) Handles _flexBL.AfterScroll, _flexBR.AfterScroll, _flexTL.AfterScroll, _flexTR.AfterScroll
        If Not _synchronizing Then

            ' avoid reentrant calls
            _synchronizing = True

            ' get new scrollposition for sender control
            Dim src As C1FlexGrid = CType(sender, C1FlexGrid)
            src.Update()
            Dim pt As Point = src.ScrollPosition

            ' apply to others
            If src.Equals(Me._flexTL) Then
                _flexTR.ScrollPosition = New Point(_flexTR.ScrollPosition.X, pt.Y)
                _flexBL.ScrollPosition = New Point(pt.X, _flexBL.ScrollPosition.Y)

            ElseIf src.Equals(Me._flexTR) Then
                _flexTL.ScrollPosition = New Point(_flexTL.ScrollPosition.X, pt.Y)
                _flexBR.ScrollPosition = New Point(pt.X, _flexBR.ScrollPosition.Y)

            ElseIf src.Equals(Me._flexBL) Then
                _flexTL.ScrollPosition = New Point(pt.X, _flexTL.ScrollPosition.Y)
                _flexBR.ScrollPosition = New Point(_flexBR.ScrollPosition.X, pt.Y)

            ElseIf src.Equals(Me._flexBR) Then
                _flexBL.ScrollPosition = New Point(_flexBL.ScrollPosition.X, pt.Y)
                _flexTR.ScrollPosition = New Point(pt.X, _flexTR.ScrollPosition.Y)

            End If
            _synchronizing = False
        End If

    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

End Class
