Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports C1.Win.C1FlexGrid

'based on original sample by Mike Hoeffner.*

Namespace CustomMergeLogic

    'Demostrates how to based merging on a cell attribute other than the displayed text
    '(in this example, the UserData Attribute is used)

    Public Class Form1
        Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call
            _flex.Rows.Fixed = 0
            _flex.Cols.Fixed = 0
            _flex.Styles.Normal.Border.Color = Color.Red
            _flex.Styles.Normal.Border.Width = 2
            _flex.Styles.Normal.TextAlign = TextAlignEnum.CenterCenter
            _flex.SelectionMode = SelectionModeEnum.Row

            _flex.AllowMerging = AllowMergingEnum.RestrictCols
            LoadFlex(False, 6, New String() {"A", "A", "B", "B", "C", "C", "D", "D", "D", "D", "D", "D", "E", "E", "F", "F", "G", "G"})
            LoadFlex(True, 6, New String() {"A", "A", "B", "B", "C", "C", "D 1", "D 1", "D 2", "D 2", "D 3", "D 3", "E", "E", "F", "F", "G", "G"})


        End Sub

        Private Sub LoadFlex(ByVal forUserData As Boolean, ByVal colCount As Integer, ByVal data As String())
            Dim len As Integer = data.Length
            Dim i As Integer

            For i = 0 To len - 1
                Dim rowLoc As Integer
                rowLoc = System.Math.Floor(i / colCount)
                Debug.WriteLine("i: " + i.ToString() + " colCount: " + colCount.ToString() + " rowloc: " + rowLoc.ToString())
                Dim colLoc As Integer = i Mod colCount

                _flex.Rows(rowLoc).AllowMerging = True
                _flex.Cols(colLoc).AllowMerging = True

                If forUserData Then
                    Dim cellrange As CellRange = _flex.GetCellRange(rowLoc, colLoc)
                    cellrange.UserData = data(i)
                Else
                    _flex(rowLoc, colLoc) = data(i)
                End If

                If i = len - 1 Then
                    _flex.Rows.Count = rowLoc + 1
                    _flex.Cols.Count = colLoc + 1
                End If

            Next
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
        Friend WithEvents _chkCustom As System.Windows.Forms.CheckBox
        Friend WithEvents _chkMerge As System.Windows.Forms.CheckBox
        Friend WithEvents _flex As CustomMergeFlex
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me._chkCustom = New System.Windows.Forms.CheckBox()
            Me._chkMerge = New System.Windows.Forms.CheckBox()
            Me._flex = New CustomMergeFlex()
            CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            '_chkCustom
            '
            Me._chkCustom.Location = New System.Drawing.Point(160, 0)
            Me._chkCustom.Name = "_chkCustom"
            Me._chkCustom.Size = New System.Drawing.Size(132, 24)
            Me._chkCustom.TabIndex = 3
            Me._chkCustom.Text = "Use Logic Overrides"
            '
            '_chkMerge
            '
            Me._chkMerge.Checked = True
            Me._chkMerge.CheckState = System.Windows.Forms.CheckState.Checked
            Me._chkMerge.Location = New System.Drawing.Point(8, 0)
            Me._chkMerge.Name = "_chkMerge"
            Me._chkMerge.Size = New System.Drawing.Size(132, 24)
            Me._chkMerge.TabIndex = 2
            Me._chkMerge.Text = "Merge Cells"
            '
            '_flex
            '
            Me._flex.BackColor = System.Drawing.SystemColors.Window
            Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
            Me._flex.Location = New System.Drawing.Point(8, 28)
            Me._flex.Name = "_flex"
            Me._flex.Size = New System.Drawing.Size(480, 84)
            Me._flex.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
            "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
            ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
            "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
            "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
            ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
            ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
            "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
            "or:White;}" & Microsoft.VisualBasic.ChrW(9))
            Me._flex.TabIndex = 4
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(500, 121)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me._chkCustom, Me._chkMerge})
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "Form1"
            Me.Text = "C1FlexGrid: Custom Merging Logic"
            CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub _chkCustom_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _chkCustom.CheckedChanged
            _flex.setUseOverrides(_chkCustom.Checked)
        End Sub

        Private Sub _chkMerge_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _chkMerge.CheckedChanged
            If _chkMerge.Checked Then
                _flex.AllowMerging = AllowMergingEnum.RestrictCols
            Else
                _flex.AllowMerging = AllowMergingEnum.None
            End If
        End Sub

        Public Class CustomMergeFlex
            Inherits C1FlexGrid

            Private _doingMerge As Boolean = False
            Private _useOverrides As Boolean = False

            Public Sub New()
                MyBase.New()
            End Sub

            Public Sub SetUseOverrides(ByVal useOverrides As Boolean)
                _useOverrides = useOverrides
                Invalidate()
            End Sub

            Public Overrides Function GetMergedRange(ByVal row As Integer, ByVal col As Integer, ByVal clip As Boolean) As CellRange
                _doingMerge = True
                Dim cellRange As CellRange = MyBase.GetMergedRange(row, col, clip)
                _doingMerge = False
                Return cellRange
            End Function

            Public Overrides Function GetData(ByVal row As Integer, ByVal col As Integer) As Object
                If _useOverrides AndAlso _doingMerge Then
                    Dim cellrange As CellRange = GetCellRange(row, col)
                    Return cellrange.UserData
                Else
                    Return MyBase.GetData(row, col)
                End If
            End Function


        End Class
    End Class


End Namespace