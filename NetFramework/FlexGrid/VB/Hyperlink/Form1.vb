Imports System.Diagnostics
Imports C1.Win.C1FlexGrid

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
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_flex
        '
        Me._flex.BackColor = System.Drawing.SystemColors.Window
        Me._flex.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(488, 344)
        Me._flex.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(488, 344)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Hyperlinks"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' create custom style for links
        Dim cs As CellStyle = _flex.Styles.Add("NewLink")
        cs.Font = New Font(_flex.Font, FontStyle.Underline)
        cs.ForeColor = Color.Blue
        cs = _flex.Styles.Add("OldLink")
        cs.Font = New Font(_flex.Font, FontStyle.Underline)
        cs.ForeColor = Color.Purple

        ' create data source
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Description", GetType(String))
        dt.Columns.Add("Link", GetType(Hyperlink))
        dt.Columns("Link").ReadOnly = True

        Dim name$, desc$, url$
        name = "Google.com"
        desc = "Google: search engine"
        url = "http://www.google.com"
        AddDataRow(dt, name, desc, url)

        name = "MSN.com"
        desc = "Microsoft Network: news etc"
        url = "http://www.microsoft.com/isapi/redir.dll?prd=ie&pver=6&ar=IStart"
        AddDataRow(dt, name, desc, url)

        name = "Radio"
        desc = "Radio Station Guide"
        url = "http://www.microsoft.com/isapi/redir.dll?prd=windows&sbp=mediaplayer&plcid=&pver=6.1&os=&over=&olcid=&clcid=&ar=Media&sba=RadioBar&o1=&o2=&o3="
        AddDataRow(dt, name, desc, url)

        name = "Travel"
        desc = "Expedia: travel agency"
        url = "http://www.expedia.com"
        AddDataRow(dt, name, desc, url)

        name = "PayPal"
        desc = "PayPal: buy and sell on-line"
        url = "http://www.paypal.com"
        AddDataRow(dt, name, desc, url)

        name = "Guitar"
        desc = "Guitar: music and instruments"
        url = "http://www.guitar.com"
        AddDataRow(dt, name, desc, url)

        ' bind the grid to the data source and turn on owner-drawing
        _flex.DataSource = dt
        _flex.DrawMode = DrawModeEnum.OwnerDraw
    End Sub

    ' add a row to the data table
    Private Sub AddDataRow(ByVal dt As DataTable, ByVal name As String, ByVal desc As String, ByVal url As String)
        Dim data(2) As Object
        data(0) = name
        data(1) = desc
        data(2) = New Hyperlink(name, url)
        dt.Rows.Add(data)
    End Sub

    ' change cursor into a hand when the mouse hovers over a link
    Private Sub _flex_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _flex.MouseMove
        Dim ht As HitTestInfo = _flex.HitTest(e.X, e.Y)
        Dim hand As Boolean
        If (ht.Type = HitTestTypeEnum.Cell) Then
            If TypeOf _flex(ht.Row, ht.Column) Is Hyperlink Then
                Dim link As Hyperlink = _flex(ht.Row, ht.Column)
                Dim rc As Rectangle = _flex.GetCellRect(ht.Row, ht.Column, False)
                Dim g As Graphics = _flex.CreateGraphics()
                Dim width As Integer = g.MeasureString(link.ToString(), _flex.Font).Width
                If (e.X - rc.Left <= width) Then hand = True
                g.Dispose()
            End If
        End If
        If hand Then Cursor = Cursors.Hand Else Cursor = Cursors.Default
    End Sub

    ' visit link when user clicks on it
    Private Sub _flex_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _flex.MouseDown
        If (Cursor Is Cursors.Hand) Then
            Dim ht As HitTestInfo = _flex.HitTest(e.X, e.Y)
            If (ht.Type = HitTestTypeEnum.Cell) Then
                If TypeOf _flex(ht.Row, ht.Column) Is Hyperlink Then
                    Dim link As Hyperlink = _flex(ht.Row, ht.Column)
                    link.Activate()
                End If
            End If
        End If
    End Sub

    ' use custom style to paint hyperlinks
    Private Sub _flex_OwnerDrawCell(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles _flex.OwnerDrawCell
        If TypeOf _flex(e.Row, e.Col) Is Hyperlink Then
            Dim link As Hyperlink = _flex(e.Row, e.Col)
            If link.Visited Then e.Style = _flex.Styles("OldLink") Else e.Style = _flex.Styles("NewLink")
        End If
    End Sub
End Class


'
' Helper class to handle hyperlinks
'
Public Class Hyperlink

    Dim _text As String
    Dim _link As String
    Dim _visited As Boolean

    Public Sub New(ByVal text As String, ByVal link As String)
        _text = text
        _link = link
        _visited = False
    End Sub

    Public ReadOnly Property Visited() As Boolean
        Get
            Return _visited
        End Get
    End Property

    Public Function Activate() As Process
        _visited = True
        Return Process.Start(_link)
    End Function

    Public Overrides Function ToString() As String
        Return _text
    End Function

End Class