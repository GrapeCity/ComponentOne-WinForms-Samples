Imports System.Data.OleDb
Imports System.Drawing.Printing

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
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents _c1BarCode As C1.Win.C1BarCode.C1BarCode
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button()
        Me._c1BarCode = New C1.Win.C1BarCode.C1BarCode()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(8, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(112, 32)
        Me.button1.TabIndex = 3
        Me.button1.Text = "Show Document"
        '
        '_c1BarCode
        '
        Me._c1BarCode.Location = New System.Drawing.Point(128, 8)
        Me._c1BarCode.Name = "_c1BarCode"
        Me._c1BarCode.Size = New System.Drawing.Size(75, 23)
        Me._c1BarCode.TabIndex = 2
        Me._c1BarCode.Text = "c1BarCode1"
        Me._c1BarCode.Visible = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(224, 45)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.button1, Me._c1BarCode})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1BarCode"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _dt As New DataTable()
    Dim _item As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' get some data for the report
        Dim sql As String = "select * from products"
        Dim conn As String = GetConnectionString()
        Dim da As New OleDbDataAdapter(sql, conn)
        da.Fill(_dt)
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click

        ' create PrintDocument
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.BeginPrint, New PrintEventHandler(AddressOf Me._beginPrint)
        AddHandler printDoc.PrintPage, New PrintPageEventHandler(AddressOf Me._printPage)

        ' show preview
        Dim dlg As New PrintPreviewDialog()
        dlg.Document = printDoc
        dlg.ShowDialog()
    End Sub

    Private Sub _beginPrint(ByVal sender As Object, ByVal e As PrintEventArgs)
        _item = 0
    End Sub

    Private Sub _printPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Dim g As Graphics = e.Graphics
        Dim f As New Font("Tahoma", 12.0!)
        Dim rcPage As RectangleF = New RectangleF(e.MarginBounds.X, e.MarginBounds.Y, e.MarginBounds.Width, e.MarginBounds.Height)
        Dim rc1 As RectangleF = rcPage
        rc1.Height = 30
        rc1.Width = 100
        Dim rc2 As RectangleF = rc1
        rc2.Offset(rc1.Width, 0)
        rc2.Width = 300
        Dim rc3 As RectangleF = rc2
        rc3.Offset(rc2.Width, 0)
        rc3.Width = 100

        ' show header at the top of the page
        g.DrawString("Product ID", f, Brushes.Black, CType(rc1, RectangleF))
        g.DrawString("Name", f, Brushes.Black, CType(rc2, RectangleF))
        g.DrawString("Code", f, Brushes.Black, CType(rc3, RectangleF))
        rc1.Y = (rc1.Y + (rc1.Height + 10))
        rc2.Y = (rc2.Y + (rc2.Height + 10))
        rc3.Y = (rc3.Y + (rc3.Height + 10))

        ' loop through rows until done (or until out of room)
        Do While ((rc1.Bottom <= rcPage.Bottom) AndAlso (Me._item < Me._dt.Rows.Count))

            Dim row1 As DataRow = Me._dt.Rows.Item(_item)
            Dim text1 As String = String.Format("{0:0000}", row1.Item("ProductID"))
            Dim text2 As String = CType(row1.Item("ProductName"), String)

            g.DrawString(text1, f, Brushes.Black, CType(rc1, RectangleF))
            g.DrawString(text2, f, Brushes.Black, CType(rc2, RectangleF))

            Me._c1BarCode.Text = text1
            g.DrawImage(Me._c1BarCode.Image, rc3)

            rc1.Y = (rc1.Y + (rc1.Height + 10))
            rc2.Y = (rc2.Y + (rc2.Height + 10))
            rc3.Y = (rc3.Y + (rc3.Height + 10))
            Me._item += 1
        Loop

        ' continue if necessary
        e.HasMorePages = (Me._item < (Me._dt.Rows.Count - 1))
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function


End Class
