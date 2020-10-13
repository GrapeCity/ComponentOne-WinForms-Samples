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
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCompressString As System.Windows.Forms.Button
    Friend WithEvents btnExpandString As System.Windows.Forms.Button
    Friend WithEvents btnCompressData As System.Windows.Forms.Button
    Friend WithEvents btnExpandData As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.btnCompressString = New System.Windows.Forms.Button()
        Me.btnExpandString = New System.Windows.Forms.Button()
        Me.btnCompressData = New System.Windows.Forms.Button()
        Me.btnExpandData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(176, 192)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(368, 144)
        Me.label1.TabIndex = 8
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(176, 16)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(368, 160)
        Me.textBox1.TabIndex = 7
        Me.textBox1.Text = "zlib is a general purpose data compression library.  All the code is reentrant (t" & _
        "hread safe).  The data format used by the zlib library is described by RFCs (Req" & _
        "uest for Comments) 1950 to 1952 in the files ftp://ds.internic.net/rfc/rfc1950.t" & _
        "xt (zlib format), rfc1951.txt (deflate format) and rfc1952.txt (gzip format). Th" & _
        "ese documents are also available in other formats from ftp://ftp.uu.net/graphics" & _
        "/png/documents/zlib/zdoc-index.html" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "All functions of the compression library " & _
        "are documented in the file zlib.h. A usage example of the library is given in th" & _
        "e file example.c which also tests that the library is working correctly. Another" & _
        " example is given in the file minigzip.c. The compression library itself is comp" & _
        "osed of all source files except example.c and minigzip.c." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "To compile all file" & _
        "s and run the test program, follow the instructions given at the top of Makefile" & _
        ". In short ""make test; make install"" should work for most machines.  For MSDOS, " & _
        "use one of the special makefiles such as Makefile.msc; for VMS, use Make_vms.com" & _
        " or descrip.mms." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Questions about zlib should be sent to <zlib@quest.jpl.nasa." & _
        "gov> or, if this fails, to the addresses given below in the Copyright section. T" & _
        "he zlib home page is http://quest.jpl.nasa.gov/zlib/" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The changes made in vers" & _
        "ion 1.0.4 are documented in the file ChangeLog. The main changes since 1.0.3 are" & _
        ":" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- In very rare conditions, deflate(s, Z_FINISH) could fail to produce an EO" & _
        "F   bit, so the decompressor could decompress all the correct data but went on t" & _
        "o attempt decompressing extra garbage data. This affected minigzip too." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- zlibV" & _
        "ersion and gzerror return const char* (needed for DLL)" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- port to RISCOS (no fdo" & _
        "pen, no multiple dots, no unlink, no fileno)" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "A Perl interface to zlib written" & _
        " by Paul Marquess <pmarquess@bfsec.bt.co.uk> is in the CPAN (Comprehensive Perl " & _
        "Archive Network) sites, such as: ftp://ftp.cis.ufl.edu/pub/perl/CPAN/modules/by-" & _
        "module/Compress/Compress-Zlib*" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Notes for some targets:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- For Turbo C the s" & _
        "mall model is supported only with reduced performance to avoid any far allocatio" & _
        "n; it was tested with -DMAX_WBITS=11 -DMAX_MEM_LEVEL=3" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- For 64-bit Iris, defla" & _
        "te.c must be compiled without any optimization. With -O, one libpng test fails. " & _
        "The test works in 32 bit mode (with the -32 compiler flag). The compiler bug has" & _
        " been reported to SGI." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- zlib doesn't work with gcc 2.6.3 on a DEC 3000/300LX u" & _
        "nder OSF/1 2.1 it works when compiled with cc." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- zlib doesn't work on HP-UX 9.0" & _
        "5 with one cc compiler (the one not accepting the -O option). It works with the " & _
        "other cc compiler." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- To build a Windows DLL version, include in a DLL project z" & _
        "lib.def, zlib.rc and all .c files except example.c and minigzip.c; compile with " & _
        "-DZLIB_DLL For help on building a zlib DLL, contact Alessandro Iacopetti <iaco@e" & _
        "mail.alessandria.alpcom.it>  http://lisa.unial.it/iaco, or contact Brad Clarke <" & _
        "bclarke@cyberus.ca>." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- gzdopen is not supported on RISCOS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Acknowledgments:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & _
        "" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The deflate format used by zlib was defined by Phil Katz. The deflate and zlib" & _
        " specifications were written by Peter Deutsch. Thanks to all the people who repo" & _
        "rted problems and suggested various improvements in zlib; they are too numerous " & _
        "to cite here." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Copyright notice:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " (C) 1995-1996 Jean-loup Gailly and Mark A" & _
        "dler" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "This software is provided 'as-is', without any express or implied  warra" & _
        "nty.  In no event will the authors be held liable for any damages arising from t" & _
        "he use of this software." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Permission is granted to anyone to use this software f" & _
        "or any purpose,  including commercial applications, and to alter it and redistri" & _
        "bute it freely, subject to the following restrictions:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "1. The origin of this " & _
        "software must not be misrepresented; you must not claim that you wrote the origi" & _
        "nal software. If you use this software in a product, an acknowledgment in the pr" & _
        "oduct documentation would be appreciated but is not required." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "2. Altered source" & _
        " versions must be plainly marked as such, and must not be misrepresented as bein" & _
        "g the original software." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "3. This notice may not be removed or altered from any " & _
        "source distribution." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Jean-loup Gailly        Mark Adler" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "gzip@prep.ai.mit.edu" & _
        "    madler@alumni.caltech.edu" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "If you use the zlib library in a product, we wo" & _
        "uld appreciate *not* receiving lengthy legal documents to sign. The sources are " & _
        "provided for free but without warranty of any kind.  The library has been entire" & _
        "ly written by Jean-loup Gailly and Mark Adler; it does not include third-party c" & _
        "ode." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "If you redistribute modified sources, we would appreciate that you inclu" & _
        "de in the file ChangeLog history information documenting your changes."
        '
        'btnCompressString
        '
        Me.btnCompressString.Location = New System.Drawing.Point(8, 16)
        Me.btnCompressString.Name = "btnCompressString"
        Me.btnCompressString.Size = New System.Drawing.Size(144, 32)
        Me.btnCompressString.TabIndex = 6
        Me.btnCompressString.Text = "Compress String"
        '
        'btnExpandString
        '
        Me.btnExpandString.Enabled = False
        Me.btnExpandString.Location = New System.Drawing.Point(8, 64)
        Me.btnExpandString.Name = "btnExpandString"
        Me.btnExpandString.Size = New System.Drawing.Size(144, 32)
        Me.btnExpandString.TabIndex = 3
        Me.btnExpandString.Text = "Decompress String"
        '
        'btnCompressData
        '
        Me.btnCompressData.Location = New System.Drawing.Point(8, 192)
        Me.btnCompressData.Name = "btnCompressData"
        Me.btnCompressData.Size = New System.Drawing.Size(144, 32)
        Me.btnCompressData.TabIndex = 4
        Me.btnCompressData.Text = "Compress Data"
        '
        'btnExpandData
        '
        Me.btnExpandData.Enabled = False
        Me.btnExpandData.Location = New System.Drawing.Point(8, 240)
        Me.btnExpandData.Name = "btnExpandData"
        Me.btnExpandData.Size = New System.Drawing.Size(144, 32)
        Me.btnExpandData.TabIndex = 5
        Me.btnExpandData.Text = "Decompress Data"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 349)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1, Me.textBox1, Me.btnCompressString, Me.btnExpandString, Me.btnCompressData, Me.btnExpandData})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Zip: Compress/Expand data in memory"
        Me.ResumeLayout(False)

    End Sub

#End Region

    '
    ' utilities to compress/expand a string
    '
    Public Function CompressString(ByVal str As String) As Byte()

        ' open memory stream
        Dim ms As MemoryStream = New MemoryStream()

        ' attach compressor stream to memory stream
        Dim sw As C1ZStreamWriter = New C1ZStreamWriter(ms)

        ' write data into compressor stream
        Dim writer As StreamWriter = New StreamWriter(sw)
        writer.Write(str)

        ' flush any pending data
        writer.Flush()

        ' return the memory buffer
        CompressString = ms.ToArray()
    End Function

    Public Function ExpandString(ByVal buffer As Byte()) As String

        ' turn buffer into a memory stream
        Dim ms As MemoryStream = New MemoryStream(buffer)

        ' attach decompressor stream to memory stream
        Dim sr As C1ZStreamReader = New C1ZStreamReader(ms)

        ' read uncompressed data
        Dim reader As StreamReader = New StreamReader(sr)
        ExpandString = reader.ReadToEnd()

    End Function

    '
    ' compress/expand string
    '
    Dim m_CompressedString As Byte()
    Private Sub btnCompressString_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompressString.Click

        ' compress the string
        Dim ticks As Long = DateTime.Now.Ticks
        m_CompressedString = CompressString(textBox1.Text)

        ' tell user how long it took
        Dim ms As Integer = (DateTime.Now.Ticks - ticks) / TimeSpan.TicksPerMillisecond
        Dim lenBefore As Integer = textBox1.Text.Length * 2 ' << 1 unicode char = 2 bytes
        Dim lenAfter As Integer = m_CompressedString.Length
        Dim msg As String = String.Format("Compressed from {0} bytes to {1} bytes in {2} milliseconds.", lenBefore, lenAfter, ms)
        MessageBox.Show(msg, "Compressed", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' we can now expand it
        btnExpandString.Enabled = True
    End Sub

    Private Sub btnExpandString_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpandString.Click

        ' expand the string
        Dim ticks As Long = DateTime.Now.Ticks
        textBox1.Text = ExpandString(m_CompressedString)

        ' tell user how long it took
        Dim ms As Integer = (DateTime.Now.Ticks - ticks) / TimeSpan.TicksPerMillisecond
        Dim lenBefore As Integer = m_CompressedString.Length
        Dim lenAfter As Integer = textBox1.Text.Length * 2 ' << 1 unicode char = 2 bytes
        Dim msg As String = String.Format("Expanded from {0} bytes to {1} bytes in {2} milliseconds.", lenBefore, lenAfter, ms)
        MessageBox.Show(msg, "Expanded", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    '
    ' compress/expand binary data
    '
    Private m_CompressedData As Byte()
    Private Sub btnCompressData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompressData.Click

        ' open memory stream
        Dim ms As MemoryStream = New MemoryStream()

        ' attach compressor stream to memory stream
        Dim sw As C1ZStreamWriter = New C1ZStreamWriter(ms)

        ' attach BinaryWriter to the compressor stream
        Dim bw As BinaryWriter = New BinaryWriter(sw)

        ' write a bunch of numbers into the stream
        Dim i As Integer
        Dim count As Integer = 1000
        bw.Write(count)
        For i = 0 To count - 1
            Dim a As Double = i * Math.PI / 180.0
            bw.Write(i)
            bw.Write(a)
            bw.Write(Math.Sin(a))
            bw.Write(Math.Cos(a))
        Next

        ' flush any pending output
        bw.Flush()

        ' save the compressed data
        m_CompressedData = ms.ToArray()

        ' done
        Dim msg As String = String.Format("Generated table with {0} points, saved into {1} bytes", count, m_CompressedData.Length)
        label1.Text = msg

        ' we can now expand it
        btnExpandData.Enabled = True

    End Sub

    Private Sub btnExpandData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpandData.Click

        ' open memory stream on saved data
        Dim ms As MemoryStream = New MemoryStream(m_CompressedData)

        ' attach decompressor stream to memory stream
        Dim sr As C1ZStreamReader = New C1ZStreamReader(ms)

        ' read uncompressed data
        Dim i As Integer
        Dim br As BinaryReader = New BinaryReader(sr)
        Dim count As Integer = br.ReadInt32()
        For i = 0 To count - 1
            Dim deg As Integer = br.ReadInt32()
            Dim rad As Double = br.ReadDouble()
            Dim sin As Double = br.ReadDouble()
            Dim cos As Double = br.ReadDouble()
        Next

        ' done
        Dim msg As String = String.Format("Read table with {0} points from stream with {1} bytes.", count, m_CompressedData.Length)
        label1.Text = msg
    End Sub
End Class
