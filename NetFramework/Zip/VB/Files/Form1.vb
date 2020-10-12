Imports System.IO
Imports C1.C1Zip

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
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents btnCompress As System.Windows.Forms.Button
    Friend WithEvents btnExpand As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnCompress = New System.Windows.Forms.Button()
        Me.btnExpand = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(200, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(272, 144)
        Me.label1.TabIndex = 4
        '
        'btnCompress
        '
        Me.btnCompress.Location = New System.Drawing.Point(8, 16)
        Me.btnCompress.Name = "btnCompress"
        Me.btnCompress.Size = New System.Drawing.Size(176, 40)
        Me.btnCompress.TabIndex = 3
        Me.btnCompress.Text = "Compress Files"
        '
        'btnExpand
        '
        Me.btnExpand.Enabled = False
        Me.btnExpand.Location = New System.Drawing.Point(8, 64)
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.Size = New System.Drawing.Size(176, 40)
        Me.btnExpand.TabIndex = 2
        Me.btnExpand.Text = "Expand Files"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 181)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1, Me.btnCompress, Me.btnExpand})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Zip: Compress/Expand individual files"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' 
    ' utilities to compress/expand files
    '
    Private Function CompressFile(ByVal dstFile As String, ByVal srcFile As String) As Boolean

        ' prepare to compress file
        Dim retval As Boolean = True
        Dim srcStream As FileStream = Nothing
        Dim dstStream As FileStream = Nothing
        Try

            ' open the files
            srcStream = New FileStream(srcFile, FileMode.Open, FileAccess.Read)
            dstStream = New FileStream(dstFile, FileMode.Create, FileAccess.Write)

            ' open compressor stream on destination file
            Dim sw As C1ZStreamWriter = New C1ZStreamWriter(dstStream)

            ' copy source into compressor stream
            StreamCopy(sw, srcStream)

        Catch ' exception? tell caller we failed

            retval = False

        Finally ' always close our streams

            If Not (srcStream Is Nothing) Then srcStream.Close()
            If Not (dstStream Is Nothing) Then dstStream.Close()

        End Try

        ' done
        CompressFile = False

    End Function

    Private Function ExpandFile(ByVal dstFile As String, ByVal srcFile As String) As Boolean

        ' prepare to expand file
        Dim retval As Boolean = True
        Dim srcStream As FileStream = Nothing
        Dim dstStream As FileStream = Nothing
        Try
            ' open the files
            srcStream = New FileStream(srcFile, FileMode.Open, FileAccess.Read)
            dstStream = New FileStream(dstFile, FileMode.Create, FileAccess.Write)

            ' open expander stream on compressed source
            Dim sr As C1ZStreamReader = New C1ZStreamReader(srcStream)

            ' copy expander stream into destination file
            StreamCopy(dstStream, sr)

        Catch ' exception? tell caller we failed

            retval = False

        Finally ' always close our streams

            If Not (srcStream Is Nothing) Then srcStream.Close()
            If Not (dstStream Is Nothing) Then dstStream.Close()
        End Try

        ' done
        ExpandFile = retval
    End Function

    Private Sub StreamCopy(ByVal dstStream As Stream, ByVal srcStream As Stream)
        Dim buffer(32768) As Byte
        Dim read As Integer
        Do
            read = srcStream.Read(buffer, 0, buffer.Length)
            If read = 0 Then Exit Do
            dstStream.Write(buffer, 0, read)
        Loop
        dstStream.Flush()
    End Sub

    Private Const DIR_COMP As String = "\compressed"
    Private Const DIR_EXP As String = "\expanded"

    Private Sub btnCompress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompress.Click

        ' get application directory
        Dim appPath As String = Application.ExecutablePath
        Dim i As Integer = appPath.IndexOf("\bin\")
        If i > 0 Then appPath = appPath.Substring(0, i)

        ' create directory for compressed files
        If (Directory.Exists(appPath + DIR_COMP)) Then
            Directory.Delete(appPath + DIR_COMP, True)
        End If
        Directory.CreateDirectory(appPath + DIR_COMP)

        ' prepare to collect compression statistics
        Dim count As Long
        Dim size As Long
        Dim sizeCompressed As Long
        Dim ticks As Long = DateTime.Now.Ticks

        ' compress all files in application dir into compressed dir
        Dim files As String() = Directory.GetFiles(appPath)
        Dim srcFile As String
        For Each srcFile In files

            ' compress file
            Dim dstFile As String = appPath + DIR_COMP + "\" + Path.GetFileName(srcFile) + ".cmp"
            CompressFile(dstFile, srcFile)

            ' update stats
            count = count + 1
            size = size + New FileInfo(srcFile).Length
            sizeCompressed = sizeCompressed + New FileInfo(dstFile).Length
        Next

        ' show stats
        Dim msg As String = String.Format( _
                "Compressed {0} files in {1} ms." & vbCrLf & _
                "Original size:   {2:#,###}" & vbCrLf & _
                "Compressed size: {3:#,###} ({4:0.00}% of original)", _
                count, _
                (DateTime.Now.Ticks - ticks) / TimeSpan.TicksPerMillisecond, _
                size, sizeCompressed, _
                (sizeCompressed / size) * 100.0)
        label1.Text = msg

        ' now we can expand
        btnExpand.Enabled = True
    End Sub

    Private Sub btnExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpand.Click

        ' get application directory
        Dim appPath As String = Application.ExecutablePath
        Dim i As Integer = appPath.IndexOf("\bin\")
        If i > 0 Then appPath = appPath.Substring(0, i)

        ' create directory for expanded files
        If Directory.Exists(appPath + DIR_EXP) Then
            Directory.Delete(appPath + DIR_EXP, True)
        End If
        Directory.CreateDirectory(appPath + DIR_EXP)

        ' prepare to collect compression statistics
        Dim count As Long
        Dim size As Long
        Dim sizeExpanded As Long
        Dim ticks As Long = DateTime.Now.Ticks

        ' expand all files in "compressed" dir to "expanded" dir
        Dim srcFile As String
        Dim files As String() = Directory.GetFiles(appPath + DIR_COMP)
        For Each srcFile In files

            ' expand file
            Dim dstFile As String = appPath + DIR_EXP + "\" + Path.GetFileName(srcFile)
            dstFile = dstFile.Replace(".cmp", "")
            ExpandFile(dstFile, srcFile)

            ' update stats
            count = count + 1
            size = size + New FileInfo(srcFile).Length
            sizeExpanded = sizeExpanded + New FileInfo(dstFile).Length
        Next

        ' show stats
        Dim msg As String = String.Format( _
                "Expanded {0} files in {1} ms." & vbCrLf & _
                "Original size:   {2:#,###}" & vbCrLf & _
                "Expanded size: {3:#,###} ({4:0.00} x size of compressed)", _
                count, _
                (DateTime.Now.Ticks - ticks) / TimeSpan.TicksPerMillisecond, _
                size, sizeExpanded, _
                sizeExpanded / size)
        label1.Text = msg
    End Sub

End Class
