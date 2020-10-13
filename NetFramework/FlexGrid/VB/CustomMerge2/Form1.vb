Imports System
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid

Namespace WindowsApplication1
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
        Friend WithEvents _btnPrint As System.Windows.Forms.Button
        Friend WithEvents _chkRows As System.Windows.Forms.CheckBox
        Friend WithEvents label1 As System.Windows.Forms.Label
        Friend WithEvents _cmb As System.Windows.Forms.ComboBox
        Friend WithEvents _chkCols As System.Windows.Forms.CheckBox
        Friend WithEvents _chkCustom As System.Windows.Forms.CheckBox
        Friend WithEvents _flex As WindowsApplication1.CustomMergeFlex
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me._btnPrint = New System.Windows.Forms.Button()
            Me._chkRows = New System.Windows.Forms.CheckBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me._cmb = New System.Windows.Forms.ComboBox()
            Me._chkCols = New System.Windows.Forms.CheckBox()
            Me._chkCustom = New System.Windows.Forms.CheckBox()
            Me._flex = New CustomMergeFlex()
            CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            '_btnPrint
            '
            Me._btnPrint.Location = New System.Drawing.Point(448, 8)
            Me._btnPrint.Name = "_btnPrint"
            Me._btnPrint.Size = New System.Drawing.Size(72, 24)
            Me._btnPrint.TabIndex = 10
            Me._btnPrint.Text = "&Print"
            '
            '_chkRows
            '
            Me._chkRows.Checked = True
            Me._chkRows.CheckState = System.Windows.Forms.CheckState.Checked
            Me._chkRows.Location = New System.Drawing.Point(216, 6)
            Me._chkRows.Name = "_chkRows"
            Me._chkRows.Size = New System.Drawing.Size(56, 24)
            Me._chkRows.TabIndex = 9
            Me._chkRows.Text = "&Rows"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(8, 12)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(72, 13)
            Me.label1.TabIndex = 6
            Me.label1.Text = "AllowMerging"
            '
            '_cmb
            '
            Me._cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me._cmb.Location = New System.Drawing.Point(88, 8)
            Me._cmb.Name = "_cmb"
            Me._cmb.Size = New System.Drawing.Size(112, 21)
            Me._cmb.TabIndex = 5
            '
            '_chkCols
            '
            Me._chkCols.Checked = True
            Me._chkCols.CheckState = System.Windows.Forms.CheckState.Checked
            Me._chkCols.Location = New System.Drawing.Point(280, 6)
            Me._chkCols.Name = "_chkCols"
            Me._chkCols.Size = New System.Drawing.Size(80, 24)
            Me._chkCols.TabIndex = 7
            Me._chkCols.Text = "&Columns"
            '
            '_chkCustom
            '
            Me._chkCustom.Location = New System.Drawing.Point(368, 6)
            Me._chkCustom.Name = "_chkCustom"
            Me._chkCustom.Size = New System.Drawing.Size(72, 24)
            Me._chkCustom.TabIndex = 8
            Me._chkCustom.Text = "Custo&m"
            '
            '_flex
            '
            Me._flex.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me._flex.BackColor = System.Drawing.SystemColors.Window
            Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
            Me._flex.Location = New System.Drawing.Point(8, 40)
            Me._flex.Name = "_flex"
            Me._flex.Size = New System.Drawing.Size(512, 248)
            Me._flex.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
            "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
            ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
            "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
            "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
            ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
            ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
            "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
            "or:White;}" & Microsoft.VisualBasic.ChrW(9))
            Me._flex.TabIndex = 11
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(528, 293)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me._btnPrint, Me._chkRows, Me.label1, Me._cmb, Me._chkCols, Me._chkCustom})
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "C1FlexGrid: Custom Merging with override"
            CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'set up the grid
            _flex.Rows.count = 5
            _flex.rows.fixed = 2
            _flex.Cols.Count = 7
            _flex.cols.fixed = 0

            'populate header cells
            _flex(0, 0) = "1998"
            _flex(1, 0) = "1998"
            _flex(0, 1) = "1999"
            _flex(0, 2) = "1999"
            _flex(0, 3) = "1999"
            _flex(0, 4) = "1999"
            _flex(0, 5) = "2000"
            _flex(0, 6) = "2000"

            Dim i As Integer
            For i = 1 To 4
                _flex(1, i) = String.Format("Q{0} 1999", i)
            Next

            'populate data cells
            Dim col As Column
            For Each col In _flex.cols
                col.DataType = Type.GetType("System.String")
            Next

            _flex(2, 0) = 100
            _flex(3, 0) = 100
            _flex(4, 0) = 100
            _flex(2, 1) = 100
            _flex(3, 1) = 100
            _flex(4, 1) = 1
            _flex(2, 2) = 100
            _flex(3, 2) = 9
            _flex(4, 2) = 2
            _flex(2, 3) = 100
            _flex(3, 3) = 9
            _flex(4, 3) = 3
            _flex(2, 4) = 9
            _flex(3, 4) = 9
            _flex(4, 4) = 3
            _flex(2, 5) = 9
            _flex(3, 5) = 9
            _flex(4, 5) = 5

            'populate combo
            Dim v As AllowMergingEnum
            v.GetType()
            For Each v In System.Enum.GetValues(v.GetType())
                _cmb.Items.Add(v)
            Next

            'fake event to initialize
            _chkRowsCols_CheckedChanged(Me, EventArgs.Empty)

        End Sub

        Private Sub _cmb_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _cmb.SelectedIndexChanged
            _flex.Allowmerging = CType(_cmb.SelectedItem, AllowMergingEnum)
        End Sub

        Private Sub _chkRowsCols_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _chkRows.CheckedChanged
            Dim col As Column
            For Each col In _flex.cols
                col.AllowMerging = _chkCols.Checked
            Next

            Dim row As Row
            For Each row In _flex.rows
                row.AllowMerging = _chkRows.Checked
            Next

        End Sub

        Private Sub _chkCustom_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _chkCustom.CheckedChanged
            _flex.custommerging = _chkCustom.Checked
        End Sub


        Private Sub _btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnPrint.Click
            Dim pd As PrintDocument = _flex.PrintParameters.PrintDocument
            pd.DefaultPageSettings.Landscape = True
            Dim m As Margins = pd.DefaultPageSettings.Margins
            m.Left = 25
            m.Right = 25
            m.Top = 25
            m.Bottom = 25
            _flex.PrintGrid("Hello", PrintGridFlags.ShowPreviewDialog)
        End Sub
    End Class

    '<summary>
    'CustomMergeFlex
    'Inherits from C1FlexGrid to provide custom merging logic
    'Set the CustomMerging to true and the grid will merge the 
    'header cells using custom logic.  the default behavior is 
    'used for the rest of the grid.
    '</summary>

    Public Class CustomMergeFlex
        Inherits C1FlexGrid

        'constructor
        Public Sub New()
            MyBase.New()
        End Sub

        'custom merging property
        Protected _custommerging As Boolean
        Public Property CustomMerging() As Boolean
            Get
                Return _custommerging
            End Get
            Set(ByVal Value As Boolean)
                _custommerging = Value
                Invalidate()
            End Set
        End Property

        '**override merging logic

        Public Overloads Function GetMergedRange(ByVal row As Integer, ByVal col As Integer, ByVal clip As Boolean) As CellRange
            'use custom merging for fixed rows
            If _custommerging AndAlso row < Rows.Fixed Then
                If col = 0 OrElse col = 5 Then Return GetCellRange(0, col, 1, col)
                If row = 0 AndAlso col > 0 AndAlso col < 5 Then Return GetCellRange(0, 1, 0, 4)
            End If

            'use default implementation
            Return MyBase.GetMergedRange(row, col, clip)

        End Function

    End Class
End Namespace