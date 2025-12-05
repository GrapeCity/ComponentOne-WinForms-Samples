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
    Friend WithEvents C1TrueDBGrid1 As C1.Win.TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.TrueDBGrid.C1TrueDBGrid
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(480, 294)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.Text = "c1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 294)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' create data source
        Dim dt As New DataTable()
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Description", GetType(String))
        dt.Columns.Add("Link", GetType(Hyperlink))
        dt.Columns("Link").ReadOnly = True

        Dim name, desc, url As String

        name = "Google.com"
        desc = "Google: search engine"
        url = "http://www.google.com"
        dt.Rows.Add(New Object() {name, desc, New Hyperlink(name, url)})

        name = "MSN.com"
        desc = "Microsoft Network: news etc"
        url = "http://www.microsoft.com/isapi/redir.dll?prd=ie&pver=6&ar=IStart"
        dt.Rows.Add(New Object() {name, desc, New Hyperlink(name, url)})

        name = "Radio"
        desc = "Radio Station Guide"
        url = "http://www.microsoft.com/isapi/redir.dll?prd=windows&sbp=mediaplayer&plcid=&pver=6.1&os=&over=&olcid=&clcid=&ar=Media&sba=RadioBar&o1=&o2=&o3="
        dt.Rows.Add(New Object() {name, desc, New Hyperlink(name, url)})

        name = "Travel"
        desc = "Expedia: travel agency"
        url = "http://www.expedia.com"
        dt.Rows.Add(New Object() {name, desc, New Hyperlink(name, url)})

        name = "PayPal"
        desc = "PayPal: buy and sell on-line"
        url = "http://www.paypal.com"
        dt.Rows.Add(New Object() {name, desc, New Hyperlink(name, url)})

        name = "Guitar"
        desc = "Guitar: music and instruments"
        url = "http://www.guitar.com"
        dt.Rows.Add(New Object() {name, desc, New Hyperlink(name, url)})

        Me.C1TrueDBGrid1.SetDataBinding(dt, "")
        ' size the description column
        Me.C1TrueDBGrid1.Splits(0).DisplayColumns("Description").AutoSize()

        ' no dead area in the grid
        Me.C1TrueDBGrid1.EmptyRows = True
        Me.C1TrueDBGrid1.ExtendRightColumn = True

        ' raise an event so we color code the link column
        Me.C1TrueDBGrid1.Splits(0).DisplayColumns("Link").FetchStyle = True

    End Sub

      ' color the link properly
    Private Sub C1TrueDBGrid1_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.TrueDBGrid.FetchCellStyleEventArgs) Handles C1TrueDBGrid1.FetchCellStyle
        Dim link As Hyperlink = CType(Me.C1TrueDBGrid1(e.Row, "Link"), Hyperlink)
        If Not (link Is Nothing) Then
            e.CellStyle.Font = New Font(Me.C1TrueDBGrid1.Font, FontStyle.Underline)
            If link.Visited Then
                e.CellStyle.ForeColor = Color.Purple
            Else
                e.CellStyle.ForeColor = Color.Blue
            End If
        End If

    End Sub

      ' go to the link
    Private Sub C1TrueDBGrid1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles C1TrueDBGrid1.MouseDown
        If Me.C1TrueDBGrid1.Cursor Is Cursors.Hand Then
            Dim row, col As Integer
            If Me.C1TrueDBGrid1.CellContaining(e.X, e.Y, row, col) Then
                Dim dispcol As C1.Win.TrueDBGrid.C1DisplayColumn = Me.C1TrueDBGrid1.FocusedSplit.DisplayColumns(col)
                Dim link As Hyperlink = CType(Me.C1TrueDBGrid1(row, dispcol.DataColumn.DataField), Hyperlink)
                If Not (link Is Nothing) Then
                    link.Activate()
                End If
            End If
        End If

    End Sub

      ' change the cursor over a link
    Private Sub C1TrueDBGrid1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles C1TrueDBGrid1.MouseMove
         Dim cursor As Cursor = Cursors.Default
         
         Dim row, col As Integer
         If Me.c1TrueDBGrid1.CellContaining(e.X, e.Y, row, col) Then
            Dim dispcol As C1.Win.TrueDBGrid.C1DisplayColumn = Me.C1TrueDBGrid1.FocusedSplit.DisplayColumns(col)
            'fix for 17718 [30063-139][VBSample] InvalidCastException is raised on hovering the mouse over Name or Description column
            Dim link As Hyperlink = TryCast(Me.C1TrueDBGrid1(row, dispcol.DataColumn.DataField), Hyperlink)
            If Not (link Is Nothing) Then
                Dim g As Graphics = Me.C1TrueDBGrid1.CreateGraphics()
                Try
                    Dim r As Rectangle = Me.C1TrueDBGrid1.Splits(0).GetCellBounds(row, col)
                    Dim width As Integer = CInt(g.MeasureString(link.ToString(), Me.C1TrueDBGrid1.Font).Width)
                    If e.X - r.Left <= width Then
                        cursor = Cursors.Hand
                    End If
                Finally
                    g.Dispose()
                End Try
            End If
        End If
         Me.c1TrueDBGrid1.Cursor = cursor

    End Sub
End Class
