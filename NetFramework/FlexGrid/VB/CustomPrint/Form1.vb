Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Collections
Imports C1.Win.FlexGrid

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
    Friend WithEvents _rpp As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents _btnPrint As System.Windows.Forms.Button
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents _cpp As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        Me._rpp = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me._btnPrint = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me._cpp = New System.Windows.Forms.TextBox()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_flex
        '
        Me._flex.BackColor = System.Drawing.SystemColors.Window
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Location = New System.Drawing.Point(0, 37)
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(512, 352)
        Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
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
        '_rpp
        '
        Me._rpp.Location = New System.Drawing.Point(80, 9)
        Me._rpp.Name = "_rpp"
        Me._rpp.Size = New System.Drawing.Size(37, 20)
        Me._rpp.TabIndex = 8
        Me._rpp.Text = "20"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(73, 22)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Rows/page:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_btnPrint
        '
        Me._btnPrint.Location = New System.Drawing.Point(336, 8)
        Me._btnPrint.Name = "_btnPrint"
        Me._btnPrint.Size = New System.Drawing.Size(80, 22)
        Me._btnPrint.TabIndex = 4
        Me._btnPrint.Text = "Print"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(160, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 22)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Cols/page:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_cpp
        '
        Me._cpp.Location = New System.Drawing.Point(232, 9)
        Me._cpp.Name = "_cpp"
        Me._cpp.Size = New System.Drawing.Size(36, 20)
        Me._cpp.TabIndex = 7
        Me._cpp.Text = "3"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 389)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._rpp, Me.label1, Me._btnPrint, Me.label2, Me._cpp, Me._flex})
        Me.DockPadding.Top = 37
        Me.Name = "Form1"
        Me.Text = "C1FlexGrid: Custom Printing"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' create data source
        Dim conn As String = GetConnectionString()
        Dim sql As String = "select * from customers"
        Dim da As New System.Data.OleDb.OleDbDataAdapter(sql, conn)
        Dim dt As New DataTable()
        da.Fill(dt)

        ' bind grid
        _flex.DataSource = dt
        _flex.Cols(0).Width = _flex.Rows(0).HeightDisplay
        _flex.ShowCursor = True
    End Sub

    Private Sub _btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnPrint.Click

        ' get rows/cols per page
        Dim rpp As Integer = 10
        Dim cpp As Integer = 3
        Try
            rpp = Integer.Parse(_rpp.Text)
            cpp = Integer.Parse(_cpp.Text)
        Catch
        End Try

        ' mark grid with row/column breaks
        Dim r As Integer
        For r = _flex.Rows.Fixed To _flex.Rows.Count - 1

            _flex.Rows(r).UserData = IIf(r Mod rpp = 0, "*", Nothing)

            Dim c As Integer
            For c = _flex.Cols.Fixed To _flex.Cols.Count - 1

                _flex.Cols(c).UserData = IIf(c Mod cpp = 0, "*", Nothing)
            Next
        Next

        ' print the grid using the specified page/column breaks
        Dim dlg As New PrintPreviewDialog()
        dlg.Document = New FlexPrintDocument(_flex)
        dlg.ShowDialog()
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class



' <summary>
' FlexPrintDocument
' 
' Inherits from PrintDocument and renders a C1FlexGrid using specified
' row and column breaks.
' 
' The row and column breaks are specified by setting the Row.UserData
' (or Column.UserData) to an asterisk.
' 
' </summary>
Public Class FlexPrintDocument
    Inherits PrintDocument

    ' ** fields
    Private _images As ArrayList
    Private _currentPage As Integer
    Private _zoom As Single

    ' ** ctor
    Public Sub New(ByVal flex As C1FlexGrid)
        MyBase.New()

        ' initialize document name
        DocumentName = flex.Name

        ' initialize zoom factor
        _zoom = 1

        ' create page images
        _images = New ArrayList()

        ' initialize
        Dim r1 As Integer, c1 As Integer, r2 As Integer, c2 As Integer

        ' loop through columns looking for breaks
        c1 = flex.Cols.Fixed
        c2 = flex.Cols.Fixed
        Dim c As Integer
        For c = flex.Cols.Fixed To flex.Cols.Count - 1

            ' check if this is a column break
            If (c = flex.Cols.Count - 1 Or flex.Cols(c).UserData = "*") Then

                ' found break, column range is c1-c
                c2 = c

                ' loop through rows looking for breaks
                r1 = flex.Rows.Fixed
                r2 = flex.Rows.Fixed
                Dim r As Integer
                For r = flex.Rows.Fixed To flex.Rows.Count - 1

                    ' look for next row break
                    If (r = flex.Rows.Count - 1 Or flex.Rows(r).UserData = "*") Then

                        ' found break, row range is r1-r
                        r2 = r

                        ' create image
                        _images.Add(flex.CreateImage(r1, c1, r2, c2))

                        ' update row range
                        r1 = r + 1
                    End If
                Next

                ' update column range
                c1 = c + 1

            End If
        Next
    End Sub

    ' ** event handlers
    Protected Overrides Sub OnBeginPrint(ByVal e As PrintEventArgs)
        _currentPage = 0
        MyBase.OnBeginPrint(e)
    End Sub

    Protected Overrides Sub OnPrintPage(ByVal e As PrintPageEventArgs)

        ' sanity on empty documents
        If (_currentPage >= _images.Count) Then
            e.HasMorePages = False
            e.Cancel = True
            Return
        End If

        ' calculate zoom factor
        If _currentPage = 0 Then

            ' get size of largest image
            Dim szMax As SizeF = SizeF.Empty
            Dim page As Image
            For Each page In _images
                szMax.Height = Math.Max(szMax.Height, page.Height)
                szMax.Width = Math.Max(szMax.Width, page.Width)
            Next

            ' get size of page bounds
            Dim szPage As Size = e.MarginBounds.Size

            ' calculate zoom so largest image doesn't overflow the page
            _zoom = 1
            Dim zh As Single = szPage.Width / szMax.Width
            Dim zv As Single = szPage.Height / szMax.Height
            If zh < 1 Or zv < 1 Then
                _zoom = Math.Min(zh, zv)
            End If
        End If

        ' prepare to draw on the page
        Dim g As Graphics = e.Graphics

        ' draw page header and footer

        ' draw grid image
        Dim rc As Rectangle = e.MarginBounds
        Dim img As Image = _images(_currentPage)
        rc.Width = img.Width * _zoom
        rc.Height = img.Height * _zoom
        g.DrawImage(img, rc)

        ' get ready for next
        _currentPage = _currentPage + 1
        e.HasMorePages = _currentPage < _images.Count

        ' call base class
        MyBase.OnPrintPage(e)
    End Sub
End Class

