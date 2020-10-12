Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Data
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
    Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_flex
        '
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Location = New System.Drawing.Point(0, 0)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 19
        Me._flex.Size = New System.Drawing.Size(805, 340)
        Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
        Me._flex.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(805, 340)
        Me.Controls.Add(Me._flex)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: RTF text in grid cells"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' set up grid
        _flex.AutoResize = False
        _flex.AllowResizing = AllowResizingEnum.Both
        _flex.DrawMode = DrawModeEnum.OwnerDraw
        _flex.Rows.DefaultSize = 50
        _flex.ShowCursor = True
        _flex.Cols(0).Width = _flex.Rows(0).HeightDisplay

        ' load DataSet with Employees table and RTF
        Dim ds As New DataSet()
        ds.ReadXml(New StringReader(My.Resources.RtfDataSet))

        ' bind grid
        _flex.DataSource = ds.Tables(0)

        ' make Notes field conspicuous and non-editable
        Dim colNotes As Column = _flex.Cols("Notes")
        colNotes.Width = 5 * colNotes.WidthDisplay
        _flex.Cols.Move(colNotes.Index, 3)

        ' use RTF class to edit values in the "Notes" column
        colNotes.Editor = New RTF()

        ' use a different backcolor
        colNotes.StyleNew.BackColor = Color.LightGoldenrodYellow
        _flex.Styles.Normal.BackColor = Color.Bisque

    End Sub

    Dim _rtf As New RTF()
    Private Sub _flex_OwnerDrawCell(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles _flex.OwnerDrawCell

        ' check whether the cell contains RTF
        Dim rtfText As String = _flex.GetDataDisplay(e.Row, e.Col)
        If (rtfText.StartsWith("{\rtf")) Then

            ' it does, so draw background
            e.DrawCell(DrawCellFlags.Background)

            ' draw the RTF text
            _rtf.Rtf = rtfText
            _rtf.ForeColor = e.Style.ForeColor
            _rtf.BackColor = e.Style.BackColor
            _rtf.RenderTo(e.Graphics, e.Bounds)

            ' and draw border last
            e.DrawCell(DrawCellFlags.Border)

            ' we're done with this cell
            e.Handled = True
        End If
    End Sub
End Class
