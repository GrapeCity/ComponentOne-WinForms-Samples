Imports System.IO

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        CorrectConnectionString(_c1r)
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
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents _c1r As C1.C1Report.C1Report
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me._c1r = New C1.C1Report.C1Report
        CType(Me._c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(8, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(240, 32)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Show Standard Report"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(8, 56)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(240, 32)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Show Raw Html Report"
        '
        '_c1r
        '
        Me._c1r.ReportDefinition = resources.GetString("_c1r.ReportDefinition")
        Me._c1r.ReportName = "Products"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(258, 101)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Report: Reports with Raw Html"
        CType(Me._c1r, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CorrectConnectionString(ByVal rep As C1.C1Report.C1Report)
        Dim cs As String = rep.DataSource.ConnectionString
        If (IsNothing(cs)) Then
            Return
        End If

        '
        Dim i As Integer = cs.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase)
        If (i < 0) Then
            Return
        End If
        While (i < cs.Length And cs(i) <> "=")
            i = i + 1
        End While
        If (i >= cs.Length) Then
            Return
        End If

        Dim j As Integer = i
        While (i < cs.Length And cs(i) <> ";")
            i = i + 1
        End While

        '
        Dim mdbName As String = cs.Substring(j + 1, i - j - 1).Trim()
        If (mdbName.Length <= 0) Then
            Return
        End If
        mdbName = System.IO.Path.GetFileName(mdbName)
        If (String.Compare(mdbName, "nwind.mdb", True) = 0) Then
            mdbName = "c1nwind.mdb"
        End If

        '
        cs = cs.Substring(0, j + 1) + _
            Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
            "\ComponentOne Samples\Common\" + _
            mdbName + _
            cs.Substring(i)

        rep.DataSource.ConnectionString = cs

        '
        For i = 0 To rep.Fields.Count - 1 Step 1
            If (Not IsNothing(rep.Fields(i).Subreport)) Then
                CorrectConnectionString(rep.Fields(i).Subreport)
            End If
        Next
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click

        ' open regular output stream
        Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\out.htm"
        Dim s As Stream = New FileStream(fileName, FileMode.Create)

        ' render report to stream
        Cursor = Cursors.WaitCursor
        _c1r.RenderToStream(s, C1.C1Report.FileFormatEnum.HTML)
        Cursor = Cursors.Default

        ' close stream
        s.Close()

        ' show what we got
        System.Diagnostics.Process.Start(fileName)

    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click

        ' open custom output stream
        Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\out.htm"
        Dim s As RawHtmlStream = New RawHtmlStream(fileName, FileMode.Create)

        ' render report to stream
        Cursor = Cursors.WaitCursor
        _c1r.RenderToStream(s, C1.C1Report.FileFormatEnum.HTML)
        Cursor = Cursors.Default

        ' close stream
        s.Close()

        ' show what we got
        System.Diagnostics.Process.Start(fileName)

    End Sub

End Class

' <summary>
' RawHtmlStream
' Inherits from a regular file stream and 'unescapes' html characters
' so "&lt;i&gt;" becomes "<i>" again.
'  </summary>
Public Class RawHtmlStream
    Inherits System.IO.FileStream

    ' ** ctor
    Public Sub New(ByVal path As String, ByVal mode As FileMode)
        MyBase.New(path, mode)
    End Sub

    ' ** overrides
    Public Overrides Sub Write(ByVal buffer() As Byte, ByVal offset As Integer, ByVal count As Integer)

        ' convert bytes to string
        Dim s As String = System.Text.Encoding.Default.GetString(buffer, offset, count)

        ' 'unescape' html sequences
        If s.IndexOf("&") > -1 Then
            s = s.Replace("&gt;", ">")
            s = s.Replace("&lt;", "<")
            buffer = System.Text.Encoding.Default.GetBytes(s)
            offset = 0
            count = buffer.Length
        End If

        ' write converted bytes to stream
        MyBase.Write(buffer, offset, count)
    End Sub

End Class
