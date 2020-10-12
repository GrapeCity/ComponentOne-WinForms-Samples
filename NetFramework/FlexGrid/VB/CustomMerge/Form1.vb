Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports C1.Win.C1FlexGrid

Namespace CustomMerge
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
        Friend WithEvents _flex As FlexSchedule
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me._flex = New FlexSchedule()
            CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            '_flex
            '
            Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
            Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
            Me._flex.Location = New System.Drawing.Point(0, 0)
            Me._flex.Name = "_flex"
            Me._flex.Rows.DefaultSize = 21
            Me._flex.Size = New System.Drawing.Size(416, 229)
            Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
            Me._flex.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
            Me.ClientSize = New System.Drawing.Size(416, 229)
            Me.Controls.Add(Me._flex)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "C1FlexGrid: Custom Merging"
            CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        'private flexgrid
        ' Friend WithEvents _flex As New FlexSchedule()
        ' Private _flex As C1FlexGrid

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'don't change the tv schedule
            _flex.Visible = True
            _flex.AllowEditing = False
            _flex.AllowDragging = AllowDraggingEnum.None
            _flex.AllowResizing = AllowResizingEnum.None

            'create header row (weekdays)
            _flex.Cols.Count = 8
            _flex.Rows.Count = 0
            _flex.AddItem(ControlChars.Tab & "Monday|Tuesday|Wednesday|Thursday|Friday|Saturday|Sunday".Replace("|", ControlChars.Tab))
            _flex.Rows.Fixed = 1

            'add the schedule
            _flex.AddItem("12:00|Walker|Morning Show|Morning Show|Sport|Weather|N/A|N/A".Replace("|", ControlChars.Tab))
            _flex.AddItem("13:00|Today Show|Today Show|Sesame Street|Football|Market Watch|N/A|N/A".Replace("|", ControlChars.Tab))
            _flex.AddItem("14:00|Today Show|Today Show|Kid Zone|Football|Soap Opera|N/A|N/A".Replace("|", ControlChars.Tab))
            _flex.AddItem("15:00|News|News|News|News|News|N/A|N/A".Replace("|", ControlChars.Tab))
            _flex.AddItem("16:00|News|News|News|News|News|N/A|N/A".Replace("|", ControlChars.Tab))

            'add some formatting 
            _flex.Styles.Normal.Border.Style = BorderStyleEnum.Double
            _flex.Styles.Normal.TextAlign = TextAlignEnum.CenterCenter
            _flex.Cols(0).Width = 50
            _flex.Rows.MinSize = 40

            Dim i As Integer
            For i = 1 To _flex.Cols.Count - 1
                _flex.Cols(i).Width = 100
            Next

            'allow merging (that's the whole point)
            _flex.AllowMerging = AllowMergingEnum.Free
            For i = 1 To _flex.Cols.Count - 1
                _flex.Cols(i).AllowMerging = True
            Next
            For i = 1 To _flex.Rows.Count - 1
                _flex.Rows(i).AllowMerging = True
            Next

        End Sub
    End Class

    'FlexSchedule
    '
    'Inherits from C1Flexgrid and implements custom cell merging by
    'overriding the GetMergedRange virtual method
    '
    'The control calls this function internally, to determine row
    'and column spans
    '
    'Note: This is a critical function.  It should be as fast as 
    'possible, and always return consistent ranges.  Otherwise the 
    'control will slow down or paint in really strange ways.

    Public Class FlexSchedule
        Inherits C1.Win.C1FlexGrid.C1FlexGrid

        Public Overrides Function GetMergedRange(ByVal row As Integer, ByVal col As Integer, ByVal clip As Boolean) As CellRange
            'create basic cell range
            Dim rg As CellRange = GetCellRange(row, col)

            'expand left/right
            Dim i As Integer
            Dim cnt As Integer = Cols.Count
            Dim ifx As Integer = Cols.Fixed
            For i = rg.c1 To cnt - 2
                If GetDataDisplay(rg.r1, i) <> GetDataDisplay(rg.r1, i + 1) Then Exit For
                rg.c2 = i + 1
            Next

            For i = rg.c1 To ifx + 1 Step -1
                If GetDataDisplay(rg.r1, i) <> GetDataDisplay(rg.r1, i - 1) Then Exit For
                rg.c1 = i - 1
            Next

            'expand up/down
            cnt = Rows.Count
            ifx = Rows.Fixed

            For i = rg.r1 To cnt - 2
                If GetDataDisplay(i, rg.c1) <> GetDataDisplay(i + 1, rg.c1) Then Exit For
                rg.r2 = i + 1
            Next

            For i = rg.r1 To ifx + 1 Step -1
                If GetDataDisplay(i, rg.c1) <> GetDataDisplay(i - 1, rg.c1) Then Exit For
                rg.r1 = i - 1
            Next

            Return rg
        End Function
    End Class
End Namespace