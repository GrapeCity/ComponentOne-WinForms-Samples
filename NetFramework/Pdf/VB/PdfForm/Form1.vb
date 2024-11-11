Imports System.IO
Imports System.Reflection
Imports System.Diagnostics

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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents _c1pdf As C1.Win.Pdf.C1PdfDocument
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents _txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents _txtTo As System.Windows.Forms.TextBox
    Friend WithEvents _txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents _txtMemo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me._c1pdf = New C1.Win.Pdf.C1PdfDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._txtSubject = New System.Windows.Forms.TextBox()
        Me._txtTo = New System.Windows.Forms.TextBox()
        Me._txtPhone = New System.Windows.Forms.TextBox()
        Me._txtMemo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Create Pdf"
        '
        '_c1pdf
        '
        Me._c1pdf.DocumentInfo.Producer = "ComponentOne C1Pdf"
        Me._c1pdf.Security.AllowCopyContent = True
        Me._c1pdf.Security.AllowEditAnnotations = True
        Me._c1pdf.Security.AllowEditContent = True
        Me._c1pdf.Security.AllowPrint = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "To:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Phone/Fax:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Subject:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Memo:"
        '
        '_txtSubject
        '
        Me._txtSubject.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtSubject.Location = New System.Drawing.Point(96, 8)
        Me._txtSubject.Name = "_txtSubject"
        Me._txtSubject.Size = New System.Drawing.Size(288, 20)
        Me._txtSubject.TabIndex = 3
        Me._txtSubject.Text = "Your order"
        '
        '_txtTo
        '
        Me._txtTo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTo.Location = New System.Drawing.Point(96, 32)
        Me._txtTo.Name = "_txtTo"
        Me._txtTo.Size = New System.Drawing.Size(288, 20)
        Me._txtTo.TabIndex = 3
        Me._txtTo.Text = "Mr Wiley E. Coyote"
        '
        '_txtPhone
        '
        Me._txtPhone.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtPhone.Location = New System.Drawing.Point(96, 56)
        Me._txtPhone.Name = "_txtPhone"
        Me._txtPhone.Size = New System.Drawing.Size(288, 20)
        Me._txtPhone.TabIndex = 3
        Me._txtPhone.Text = "555 555-1212"
        '
        '_txtMemo
        '
        Me._txtMemo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtMemo.Location = New System.Drawing.Point(96, 80)
        Me._txtMemo.Multiline = True
        Me._txtMemo.Name = "_txtMemo"
        Me._txtMemo.Size = New System.Drawing.Size(288, 96)
        Me._txtMemo.TabIndex = 3
        Me._txtMemo.Text = "Dear Sir," & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "We regret to inform you that we no longer carry the item you request" & _
        "ed, and are thus unable to fulfill your order." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Even if we were, we have told " & _
        "you repeatedly that our rockets are not suitable for personal transportation or " & _
        "hunting, and our insureance company has forbidden us to provide you with any ass" & _
        "istance in the future." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Yours Sincerely," & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "ACME ROCKETS INC."
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 213)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._txtSubject, Me.Label1, Me.Button1, Me.Label2, Me.Label3, Me.Label4, Me._txtTo, Me._txtPhone, Me._txtMemo})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Pdf: Automated Pdf forms"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' load blank form from resource (enhanced metafile)
        Dim resName As String = "PdfForm.faxcover.emf"
        Dim s As Stream = [Assembly].GetExecutingAssembly().GetManifestResourceStream(resName)
        Dim img As Image = Image.FromStream(s)

        ' render blank form (center it on page)
        _c1pdf.Clear()
        Dim rc As RectangleF = _c1pdf.PageRectangle
        _c1pdf.DrawImage(img, rc, ContentAlignment.MiddleCenter, C1.Util.ImageSizeMode.Clip)

        ' fill in fields
        Dim sf As StringFormat = New StringFormat()
        sf.LineAlignment = StringAlignment.Center
        sf.Alignment = StringAlignment.Near

        ' date
        rc = New RectangleF(2.2 * 72, 2.7 * 72, 2 * 72, 0.4 * 72)
        _c1pdf.DrawString(DateTime.Today.ToShortDateString(), _txtSubject.Font, Brushes.Black, rc, sf)

        ' subject
        rc.X = 5.7 * 72
        _c1pdf.DrawString(_txtSubject.Text, _txtSubject.Font, Brushes.Black, rc, sf)
        rc.X = 2.2 * 72

        ' to
        rc.Y = rc.Y + 0.6 * 72
        rc.Height = 0.8 * 72
        _c1pdf.DrawString(_txtTo.Text, _txtTo.Font, Brushes.Black, rc, sf)

        ' phone/fax
        rc.Y = rc.Y + 0.8 * 72
        _c1pdf.DrawString(_txtPhone.Text, _txtPhone.Font, Brushes.Black, rc, sf)

        ' memo
        rc.X = 1 * 72
        rc.Y = 6 * 72
        rc.Height = 4 * 72
        rc.Width = 6 * 72
        _c1pdf.DrawString(_txtMemo.Text, _txtMemo.Font, Brushes.Black, rc)

        ' generate pdf and show it
	Dim tempdir As String = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")+1)
        Dim fileName As String = tempdir + "faxcover.pdf"
        _c1pdf.Save(fileName)
        Process.Start(fileName)

    End Sub
End Class
