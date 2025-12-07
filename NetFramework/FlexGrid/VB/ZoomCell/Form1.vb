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
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_flex
        '
        Me._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me._flex.BackColor = System.Drawing.SystemColors.Window
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:23;}" & Microsoft.VisualBasic.ChrW(9)
        Me._flex.Location = New System.Drawing.Point(8, 8)
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(392, 244)
        Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Normal{Font:Microsoft Sans Serif, 8.25pt;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:Control;ForeColor:Cont" & _
        "rolText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Highlight;ForeColor" & _
        ":HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{Bac" & _
        "kColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Bo" & _
        "th;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDar" & _
        "kDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Su" & _
        "btotal2{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlD" & _
        "arkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & _
        "Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Button1.Location = New System.Drawing.Point(8, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "First, Last"
        '
        'Button2
        '
        Me.Button2.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Button2.Location = New System.Drawing.Point(120, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ID, Last, Title"
        '
        'Button3
        '
        Me.Button3.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Button3.Location = New System.Drawing.Point(232, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 24)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Default"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 293)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me._flex, Me.Button2, Me.Button3})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Click a cell to zoom in"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _al As ArrayList
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' create data source
        _al = New ArrayList()
        _al.Add(New Employee(1, "Jimmy", "Page", "Guitarist"))
        _al.Add(New Employee(2, "Robert", "Plant", "Singer"))
        _al.Add(New Employee(3, "John", "Bonham", "Drummer"))
        _al.Add(New Employee(4, "John", "Jones", "Bassist"))

        ' bind to grid
        _flex.DataSource = _al

        ' set grid style
        _flex.Styles.Alternate.BackColor = Color.LightGreen

        ' create ZoomCell, attach it to grid
        Dim z As New ZoomCell(_flex)
    End Sub


    ' bind to FirstName, LastName
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _flex.DataSource = _al
        _flex.Cols.Count = 1 ' clear existing columns
        AddColumn("FirstName", GetType(String))
        AddColumn("LastName", GetType(String))
    End Sub

    ' bind to ID, LastName, Title
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        _flex.DataSource = _al
        _flex.Cols.Count = 1 ' clear existing columns
        AddColumn("ID", GetType(Integer))
        AddColumn("LastName", GetType(String))
        AddColumn("Title", GetType(String))
    End Sub

    ' default binding
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        _flex.DataSource = Nothing
        _flex.DataSource = _al
    End Sub

    ' helper
    Private Sub AddColumn(ByVal name As String, ByVal type As Type)
        Dim col As C1.Win.FlexGrid.Column = _flex.Cols.Add()
        col.Name = name
        col.Caption = name
        col.DataType = type
    End Sub
End Class

' <summary>
' Employee
' simple class used to show data binding
' </summary>
Public Class Employee

    Dim _id As Integer
    Dim _first As String
    Dim _last As String
    Dim _title As String

    Public Sub New(ByVal id As Integer, ByVal first As String, ByVal last As String, ByVal title As String)
        _id = id
        _first = first
        _last = last
        _title = title
    End Sub

    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return _first
        End Get
        Set(ByVal value As String)
            _first = value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return _last
        End Get
        Set(ByVal value As String)
            _last = value
        End Set
    End Property
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal Value As String)
            _title = Value
        End Set
    End Property
End Class
