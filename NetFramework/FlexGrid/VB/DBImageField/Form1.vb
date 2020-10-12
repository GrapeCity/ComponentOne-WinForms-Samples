Imports System
Imports System.Data
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

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
    Friend WithEvents dataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents _imgList As System.Windows.Forms.ImageList
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.dataGrid1 = New System.Windows.Forms.DataGrid()
        Me.label1 = New System.Windows.Forms.Label()
        Me._imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGrid1
        '
        Me.dataGrid1.CaptionText = "MSDataGrid"
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.Dock = System.Windows.Forms.DockStyle.Left
        Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.Size = New System.Drawing.Size(240, 237)
        Me.dataGrid1.TabIndex = 3
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.label1.Location = New System.Drawing.Point(240, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(288, 24)
        Me.label1.TabIndex = 4
        Me.label1.Text = " C1FlexGrid"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_imgList
        '
        Me._imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me._imgList.ImageSize = New System.Drawing.Size(16, 15)
        Me._imgList.ImageStream = CType(resources.GetObject("_imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgList.TransparentColor = System.Drawing.Color.Red
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.BackColor = System.Drawing.SystemColors.Window
        Me.C1FlexGrid1.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.Location = New System.Drawing.Point(240, 24)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Size = New System.Drawing.Size(288, 213)
        Me.C1FlexGrid1.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.C1FlexGrid1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 237)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1FlexGrid1, Me.label1, Me.dataGrid1})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Binding to Image Fields"
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()
        dt.Columns.Add("String", GetType(String))
        dt.Columns.Add("Integer", GetType(Integer))
        dt.Columns.Add("Image", GetType(Image))

        Dim str As String() = "the|quick|brown|fox|jumped|over|the|lazy|yellow|dow".Split("|")
        Dim i As Integer
        For i = 0 To 1000 - 1
            Dim row As DataRow = dt.NewRow()
            row("String") = str(i Mod 10)
            row("Integer") = i
            row("Image") = _imgList.Images(i Mod _imgList.Images.Count)
            dt.Rows.Add(row)
        Next

        dataGrid1.DataSource = dt
        Me.C1FlexGrid1.DataSource = dt
    End Sub
End Class
