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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents _btnByRow As System.Windows.Forms.Button
    Friend WithEvents _btnByColumn As System.Windows.Forms.Button
    Friend WithEvents _imgList As System.Windows.Forms.ImageList
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me._btnByRow = New System.Windows.Forms.Button()
        Me._btnByColumn = New System.Windows.Forms.Button()
        Me._imgList = New System.Windows.Forms.ImageList(Me.components)
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_btnByRow
        '
        Me._btnByRow.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me._btnByRow.Location = New System.Drawing.Point(8, 248)
        Me._btnByRow.Name = "_btnByRow"
        Me._btnByRow.Size = New System.Drawing.Size(128, 24)
        Me._btnByRow.TabIndex = 3
        Me._btnByRow.Text = "By &Row"
        '
        '_btnByColumn
        '
        Me._btnByColumn.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me._btnByColumn.Location = New System.Drawing.Point(152, 248)
        Me._btnByColumn.Name = "_btnByColumn"
        Me._btnByColumn.Size = New System.Drawing.Size(128, 24)
        Me._btnByColumn.TabIndex = 2
        Me._btnByColumn.Text = "By &Column"
        '
        '_imgList
        '
        Me._imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me._imgList.ImageSize = New System.Drawing.Size(16, 15)
        Me._imgList.ImageStream = CType(resources.GetObject("_imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgList.TransparentColor = System.Drawing.Color.Red
        '
        '_flex
        '
        Me._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Location = New System.Drawing.Point(8, 8)
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(440, 232)
        Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
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
        Me.ClientSize = New System.Drawing.Size(456, 277)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me._btnByColumn, Me._btnByRow})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Row and Column properties"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _imgMap As Hashtable = New Hashtable()
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To _imgList.Images.Count - 1
            _imgMap.Add(i, _imgList.Images(i))
        Next

        _flex.Styles.Add("Hdr").Font = New Font("Tahoma", 8, FontStyle.Bold)
    End Sub

    Private Sub _btnByRow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnByRow.Click
        _flex.Clear()
        Dim row As C1.Win.FlexGrid.RowCollection = _flex.Rows

        row(1).Caption = "String/Mask"
        row(1).DataType = GetType(String)
        row(1).EditMask = "(999) 999-9999;*"
        row(1).StyleFixed = _flex.Styles("Hdr")

        row(2).Caption = "Int/ImgMap"
        row(2).DataType = GetType(Integer)
        row(2).ImageMap = _imgMap
        row(2).ImageAndText = True
        row(2).ComboList = "0|1|2|3|4|5"
        row(2).StyleFixed = _flex.Styles("Hdr")

        row(3).Caption = "Currency"
        row(3).DataType = GetType(Decimal)
        row(3).ComboList = "|0|1,000|100,000|1,000,000"
        row(3).StyleFixed = _flex.Styles("Hdr")

        row(4).Caption = "DateTime"
        row(4).DataType = GetType(DateTime)
        row(4).StyleFixed = _flex.Styles("Hdr")

        row(5).Caption = "Aggregate"
        row(5).DataType = GetType(C1.Win.FlexGrid.AggregateEnum)
        row(5).StyleFixed = _flex.Styles("Hdr")
    End Sub

    Private Sub _btnByColumn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnByColumn.Click
        _flex.Clear()
        Dim col As C1.Win.FlexGrid.ColumnCollection = _flex.Cols

        col(1).Caption = "String/Mask"
        col(1).DataType = GetType(String)
        col(1).EditMask = "(999) 999-9999;*"
        col(1).StyleFixed = _flex.Styles("Hdr")

        col(2).Caption = "Int/ImgMap"
        col(2).DataType = GetType(Integer)
        col(2).ImageMap = _imgMap
        col(2).ImageAndText = True
        col(2).ComboList = "0|1|2|3|4|5"
        col(2).StyleFixed = _flex.Styles("Hdr")

        col(3).Caption = "Currency"
        col(3).DataType = GetType(Decimal)
        col(3).ComboList = "|0|1,000|100,000|1,000,000"
        col(3).StyleFixed = _flex.Styles("Hdr")

        col(4).Caption = "DateTime"
        col(4).DataType = GetType(DateTime)
        col(4).StyleFixed = _flex.Styles("Hdr")

        col(5).Caption = "Aggregate"
        col(5).DataType = GetType(C1.Win.FlexGrid.AggregateEnum)
        col(5).StyleFixed = _flex.Styles("Hdr")
    End Sub
End Class
