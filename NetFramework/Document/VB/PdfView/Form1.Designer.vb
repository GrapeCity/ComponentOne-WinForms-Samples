Imports C1.Win.Ribbon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits C1RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1FlexViewer1 = New C1.Win.FlexViewer.C1FlexViewer()
        Me.C1PdfDocumentSource1 = New C1.Win.Document.C1PdfDocumentSource(Me.components)
        Me.ilLarge = New System.Windows.Forms.ImageList(Me.components)
        Me.ilSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        CType(Me.C1FlexViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexViewer1
        '
        Me.C1FlexViewer1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.C1FlexViewer1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.C1FlexViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexViewer1.DocumentSource = Me.C1PdfDocumentSource1
        Me.C1FlexViewer1.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexViewer1.Name = "C1FlexViewer1"
        Me.C1FlexViewer1.Size = New System.Drawing.Size(983, 579)
        Me.C1FlexViewer1.TabIndex = 0
        '
        'ilLarge
        '
        Me.ilLarge.ImageStream = CType(resources.GetObject("ilLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.ilLarge.Images.SetKeyName(0, "FolderLarge.png")
        '
        'ilSmall
        '
        Me.ilSmall.ImageStream = CType(resources.GetObject("ilSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.ilSmall.Images.SetKeyName(0, "FolderSmall.png")
        '
        'ofdOpen
        '
        Me.ofdOpen.DefaultExt = "pdf"
        Me.ofdOpen.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 579)
        Me.Controls.Add(Me.C1FlexViewer1)
        Me.Name = "Form1"
        Me.Text = "PDF Viewer"
        CType(Me.C1FlexViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1FlexViewer1 As C1.Win.FlexViewer.C1FlexViewer
    Friend WithEvents C1PdfDocumentSource1 As C1.Win.Document.C1PdfDocumentSource
    Friend WithEvents ilLarge As ImageList
    Friend WithEvents ilSmall As ImageList
    Private WithEvents ofdOpen As OpenFileDialog
End Class
