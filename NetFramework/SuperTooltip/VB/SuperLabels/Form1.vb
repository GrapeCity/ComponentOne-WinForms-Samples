Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' populate combo list with html snippets
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim res As String
        For Each res In a.GetManifestResourceNames()
            If res.EndsWith(".htm") Then
                Dim name As String() = res.Split(".")
                Dim item As String = name(name.Length - 2)
                comboBox1.Items.Add(item)
            End If
        Next

        ' select the first item
        comboBox1.SelectedIndex = 0
    End Sub

    ' show html resource
    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged

        ' load selected html snippet
        If comboBox1.Text.Length > 0 Then

            Dim res As String = String.Format("SuperLabels.{0}.htm", comboBox1.Text)
            Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Using s As New System.IO.StreamReader(a.GetManifestResourceStream(res))
                richTextBox1.Text = s.ReadToEnd()
            End Using
        End If
    End Sub

    ' display an existing html file in the c1SuperLabel
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click

        Using dlg As New OpenFileDialog()

            dlg.FileName = "*.htm"
            If dlg.ShowDialog() = DialogResult.OK Then
                Using r As New System.IO.StreamReader(dlg.FileName)
                    richTextBox1.Text = r.ReadToEnd()
                End Using
            End If
        End Using
    End Sub

    ' use timer to wait a little while user types
    Private Sub richTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles richTextBox1.KeyDown
        Timer1.Enabled = False
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        c1SuperLabel1.Text = richTextBox1.Text
        Timer1.Enabled = False
    End Sub

    ' update preview whenever text changes
    Private Sub richTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles richTextBox1.TextChanged
        If Not Timer1.Enabled Then
            c1SuperLabel1.Text = richTextBox1.Text
        End If
    End Sub

End Class
