Imports System.IO

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
    Friend WithEvents C1PdfDocument1 As C1.Win.Pdf.C1PdfDocument
    Friend WithEvents _rpp As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents _btnPrint As System.Windows.Forms.Button
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents _cpp As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1PdfDocument1 = New C1.Win.Pdf.C1PdfDocument
        Me._rpp = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me._btnPrint = New System.Windows.Forms.Button
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid
        Me.label2 = New System.Windows.Forms.Label
        Me._cpp = New System.Windows.Forms.TextBox
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_rpp
        '
        Me._rpp.Location = New System.Drawing.Point(80, 8)
        Me._rpp.Name = "_rpp"
        Me._rpp.Size = New System.Drawing.Size(37, 20)
        Me._rpp.TabIndex = 9
        Me._rpp.Text = "20"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(7, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(73, 22)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Rows/page:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_btnPrint
        '
        Me._btnPrint.Location = New System.Drawing.Point(328, 8)
        Me._btnPrint.Name = "_btnPrint"
        Me._btnPrint.Size = New System.Drawing.Size(104, 22)
        Me._btnPrint.TabIndex = 5
        Me._btnPrint.Text = "Export to Pdf"
        '
        '_flex
        '
        Me._flex.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Location = New System.Drawing.Point(0, 37)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 17
        Me._flex.Size = New System.Drawing.Size(456, 289)
        Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
        Me._flex.TabIndex = 4
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(161, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 22)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Cols/page:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_cpp
        '
        Me._cpp.Location = New System.Drawing.Point(227, 8)
        Me._cpp.Name = "_cpp"
        Me._cpp.Size = New System.Drawing.Size(36, 20)
        Me._cpp.TabIndex = 8
        Me._cpp.Text = "3"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 326)
        Me.Controls.Add(Me._rpp)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me._btnPrint)
        Me.Controls.Add(Me._flex)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me._cpp)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(0, 37, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Export Grid to Pdf"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' create data source
        Dim conn As String = GetConnectionString()
        Dim sql As String = "select * from customers"
        Dim adapter1 As New System.Data.OleDb.OleDbDataAdapter(sql, conn)
        Dim dt As New DataTable()
        adapter1.Fill(dt)

        ' bind grid
        Me._flex.DataSource = dt
        Me._flex.Cols.Item(0).Width = Me._flex.Rows.Item(0).HeightDisplay
        Me._flex.ShowCursor = True

    End Sub

    Private Sub _btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnPrint.Click

        ' get rows/cols per page
        Dim rpp As Integer = 10
        Dim cpp As Integer = 3
        Try
            rpp = Integer.Parse(Me._rpp.Text)
            cpp = Integer.Parse(Me._cpp.Text)
        Catch
        End Try

        ' mark grid with row/column breaks
        Dim r%
        For r = Me._flex.Rows.Fixed To Me._flex.Rows.Count - 1
            Me._flex.Rows(r).UserData = IIf(((r Mod rpp) = 0), "*", Nothing)
        Next
        Dim c%
        For c = Me._flex.Cols.Fixed To Me._flex.Cols.Count - 1
            Me._flex.Cols.Item(c).UserData = IIf(((c Mod cpp) = 0), "*", Nothing)
        Next
        Dim creator1 As New FlexPdfCreator(Me._flex)
        Dim filename As String = Path.Combine(Directory.GetCurrentDirectory(), "flex.pdf")
        creator1.Save(filename)
        Process.Start(filename)

    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

End Class

' FlexPdfCreator
' 
' Renders a C1FlexGrid using specified row and column breaks into a pdf file.
' 
' The row and column breaks are specified by setting the Row.UserData
' (or Column.UserData) to an asterisk.
' 
Public Class FlexPdfCreator

    ' Fields
    Private _images As ArrayList
    Private _zoom As Single

    ' ctor
    Public Sub New(ByVal flex As C1.Win.FlexGrid.C1FlexGrid)

        ' initialize zoom factor
        Me._zoom = 1.0!

        ' create page images
        Me._images = New ArrayList()

        ' initialize
        Dim r1%, c1%, r2%, c2%

        ' loop through columns looking for breaks
        c1 = flex.Cols.Fixed
        c2 = flex.Cols.Fixed

        Dim c%
        For c = flex.Cols.Fixed To flex.Cols.Count - 1

            ' check if this is a column break
            If ((c = flex.Cols.Count - 1) OrElse (Not (flex.Cols(c).UserData Is Nothing)) AndAlso (flex.Cols(c).UserData.ToString = "*")) Then

                ' found break, column range is c1-c
                c2 = c

                ' loop through rows looking for breaks
                r1 = flex.Rows.Fixed
                r2 = flex.Rows.Fixed
                Dim r%
                For r = flex.Rows.Fixed To flex.Rows.Count - 1

                    ' look for next row break
                    If ((r = flex.Rows.Count - 1) OrElse (Not (flex.Rows.Item(r).UserData Is Nothing) AndAlso (flex.Rows(r).UserData.ToString = "*"))) Then
                        r2 = r
                        Me._images.Add(flex.CreateImage(r1, c1, r2, c2))
                        r1 = (r + 1)
                    End If
                Next
            End If
        Next
    End Sub

    ' Methods
    Public Sub Save(ByVal fileName As String)

        ' create new pdf document
        Dim doc As New C1.Win.Pdf.C1PdfDocument()

        ' add pages to document
        Dim page%
        For page = 0 To Me._images.Count - 1
            Me.DrawPageImage(doc, page)
        Next

        ' done
        doc.Save(fileName)
    End Sub

    Private Sub DrawPageImage(ByVal pdf As C1.Win.Pdf.C1PdfDocument, ByVal index As Integer)

        ' get image bounds
        Dim rcBounds As RectangleF = pdf.PageRectangle
        rcBounds.Inflate(-72.0!, -72.0!)

        ' calculate zoom factor
        Dim img As Image
        If (index = 0) Then

            ' get size of largest image
            Dim sizeMax As SizeF
            For Each img In Me._images
                sizeMax.Height = Math.Max(sizeMax.Height, CType(img.Height, Single))
                sizeMax.Width = Math.Max(sizeMax.Width, CType(img.Width, Single))
            Next

            ' get size of page bounds
            Dim szPage As SizeF = rcBounds.Size

            ' calculate zoom so largest image doesn't overflow the page
            Me._zoom = 1.0!
            Dim zh As Single = (szPage.Width / sizeMax.Width)
            Dim zv As Single = (szPage.Height / sizeMax.Height)
            If ((zh < 1.0!) OrElse (zv < 1.0!)) Then
                Me._zoom = Math.Min(zh, zv)
            End If
        End If

        ' draw grid image
        Dim rc As RectangleF = rcBounds
        img = _images(index)
        rc.Width = img.Width * _zoom
        rc.Height = img.Height * _zoom
        If (index > 0) Then
            pdf.NewPage()
        End If
        pdf.DrawImage(img, rc)

    End Sub
End Class


