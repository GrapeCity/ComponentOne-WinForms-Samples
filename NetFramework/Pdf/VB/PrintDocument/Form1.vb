Imports System.Drawing.Printing
Imports System.Drawing.Imaging

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
    Private WithEvents _document As System.Drawing.Printing.PrintDocument
    Private WithEvents _pdf As C1.Win.Pdf.C1PdfDocument
    Friend WithEvents _btnGo As System.Windows.Forms.Button
    Friend WithEvents _preview As System.Windows.Forms.PrintPreviewControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._document = New System.Drawing.Printing.PrintDocument()
        Me._pdf = New C1.Win.Pdf.C1PdfDocument()
        Me._btnGo = New System.Windows.Forms.Button()
        Me._preview = New System.Windows.Forms.PrintPreviewControl()
        Me.SuspendLayout()
        '
        '_document
        '
        '
        '_btnGo
        '
        Me._btnGo.Location = New System.Drawing.Point(8, 8)
        Me._btnGo.Name = "_btnGo"
        Me._btnGo.Size = New System.Drawing.Size(96, 24)
        Me._btnGo.TabIndex = 0
        Me._btnGo.Text = "Show Pdf"
        '
        '_preview
        '
        Me._preview.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me._preview.AutoZoom = False
        Me._preview.Location = New System.Drawing.Point(8, 40)
        Me._preview.Name = "_preview"
        Me._preview.Size = New System.Drawing.Size(400, 424)
        Me._preview.TabIndex = 1
        Me._preview.Zoom = 0.30000001192092896
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 469)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._preview, Me._btnGo})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Pdf: Render PrintDocument"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' show document in preview control (can also do this at design-time)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _preview.Document = _document
        _preview.AutoZoom = True
    End Sub

    ' generate single-page document
    Private Sub _document_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _document.PrintPage
        Dim text As String = "The dog jumped over the gate and chased the cat."
        Dim font As New Font("Arial", 15.75!)
        With e.Graphics
            .DrawString(text, font, Brushes.Black, e.MarginBounds.X, e.MarginBounds.Y)
            .DrawRectangle(Pens.Blue, e.MarginBounds)
        End With
    End Sub

    ' render PrintDocument into pdf file
    Private Sub _btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnGo.Click

        Cursor = Cursors.WaitCursor

        ' save original PrintController
        Dim savePrintController As PrintController = _document.PrintController

        ' replace print controller with a PreviewPrintController
        Dim previewController As New PreviewPrintController()
        _document.PrintController = previewController

        ' print document into our preview controller
        _document.Print()

        ' restore original PrintController
        _document.PrintController = savePrintController

        ' set up new pdf document
        _pdf.Clear()
        _pdf.PaperKind = _document.DefaultPageSettings.PaperSize.Kind
        _pdf.Landscape = _document.DefaultPageSettings.Landscape

        ' render document pages into pdf
        Dim pages() As PreviewPageInfo = previewController.GetPreviewPageInfo
        Dim i As Integer
        For i = 0 To pages.Length - 1
            If i > 0 Then _pdf.NewPage()
            _pdf.DrawImage(pages(i).Image, _pdf.PageRectangle)
        Next

        Cursor = Cursors.Default

        ' save pdf file and display it
        Dim fileName As String
        fileName = Application.StartupPath + "\test.pdf"
        _pdf.Save(fileName)
        System.Diagnostics.Process.Start(fileName)

    End Sub

End Class
