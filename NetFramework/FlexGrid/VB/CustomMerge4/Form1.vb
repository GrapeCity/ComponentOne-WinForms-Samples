Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Collections
Imports C1.Win.C1FlexGrid

'//based on original sample by Mike Hoeffner

Namespace CustomMergeLogic


    Public Class Form1
        Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call
            'create data table
            Dim dt As DataTable = New DataTable()
            dt.Columns.Add("ID", Type.GetType("System.String"))
            dt.Columns.Add("Start", Type.GetType("System.DateTime"))
            dt.Columns.Add("Finish", Type.GetType("System.DateTime"))
            dt.Columns.Add("Description", Type.GetType("System.String"))
            dt.Columns.Add("Name", Type.GetType("System.String"))
            dt.Columns.Add("CreatedBy", Type.GetType("System.String"))

            'populate data table
            dt.Rows.Add(New Object() {"123123123", New DateTime(2003, 1, 1), New DateTime(2003, 1, 10), "Talk about contract", "Pedro", "Marc"})
            dt.Rows.Add(New Object() {"111111111", New DateTime(2003, 1, 1), New DateTime(2003, 1, 10), "Talk about contract", "Johnny", "Marc"})
            dt.Rows.Add(New Object() {"111111111", New DateTime(2003, 1, 1), New DateTime(2003, 1, 10), "Talk about contract", "Pedro", "Marc"})
            dt.Rows.Add(New Object() {"321321321", New DateTime(2003, 1, 1), New DateTime(2003, 1, 10), "View property", "Johnny", "Marc"})

            'assign data table to grid
            _flex.DataSource = dt

            'initialize merging
            _flex.AllowMerging = AllowMergingEnum.Free
            Dim c As C1.Win.C1FlexGrid.Column

            For Each c In _flex.Cols
                c.AllowMerging = True
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
        Friend WithEvents _chkMerge As System.Windows.Forms.CheckBox
        Friend WithEvents _flex As CustomMergeflex
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me._chkMerge = New System.Windows.Forms.CheckBox()
            Me._flex = New CustomMergeflex()
            CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me._flex.BackColor = System.Drawing.SystemColors.Window
            Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
            Me._flex.Location = New System.Drawing.Point(8, 28)
            Me._flex.Name = "_flex"
            Me._flex.Size = New System.Drawing.Size(480, 212)
            Me._flex.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
            "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
            ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
            "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
            "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
            ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
            ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
            "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
            "or:White;}" & Microsoft.VisualBasic.ChrW(9))
            Me._flex.TabIndex = 3
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(500, 247)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me._chkMerge})
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "Form1"
            Me.Text = "C1FlexGrid: Custom Merging Logic"
            CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        ' toggle merging when user clicks the checkbox
        Private Sub _chkMerge_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _chkMerge.CheckedChanged
            If _chkMerge.Checked Then
                _flex.AllowMerging = AllowMergingEnum.Free
            Else
                _flex.AllowMerging = AllowMergingEnum.None
            End If
        End Sub

    End Class

    'summary 
    'CustomMergeFlex
    'derives from the C1FlexGrid to override merging logic
    'summary

    ' <LicenseProvider(t.gettype())> _
    Public Class CustomMergeflex
        Inherits C1FlexGrid

        Private _doingMerge As Boolean = False
        Private _colIndex As Integer

        Public Overrides Function GetMergedRange(row As Integer, col As Integer, clip As Boolean) As C1.Win.C1FlexGrid.CellRange

            ' save index of ID column to use in merging logic
            _colIndex = MyBase.Cols("ID").Index

            ' set flag to use custom data when merging
            _doingMerge = True

            ' call base class merging logic (will retrieve data using GetData method)
            Dim cellRange As CellRange = MyBase.GetMergedRange(row, col, clip)

            ' reset flag so GetData behaves as usual
            _doingMerge = False

            'return the merged range
            Return cellRange

        End Function

        Public Overrides Function GetData(ByVal row As Integer, ByVal col As Integer) As Object

            'getting data to determine merging range
            'append content of ID column to avoid merging cells in rows with different IDs
            If _doingMerge AndAlso _colIndex > -1 AndAlso col <> _colIndex Then
                Return MyBase.GetDataDisplay(row, col) + MyBase.GetDataDisplay(row, _colIndex)
            End If

            'getting data to display, measure, edit etc
            'let base class handle it as usual
            Return MyBase.GetData(row, col)
        End Function


    End Class

End Namespace
