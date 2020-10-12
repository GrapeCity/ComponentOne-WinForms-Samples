Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub radioButtonPreview_CheckedChanged(sender As Object, e As EventArgs)
		If radioButtonDesign.Checked Then
            c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Design
        End If
        If radioButtonSource.Checked Then
            c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Source
        End If
        If radioButtonPreview.Checked Then
            c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Preview
        End If
        ' Template Source
        richTextBox1.Visible = radioButtonTemplateSource.Checked
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        c1Editor1.LoadXml("samplepage.htm")
        richTextBox1.Visible = False
        comboBox1.SelectedIndex = 0
        c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Preview

    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.templateName = String.Format("template{0:D}.htm", comboBox1.SelectedIndex + 1)
        richTextBox1.LoadFile(Me.templateName, RichTextBoxStreamType.PlainText)
        Dim previewOnly As Boolean = comboBox1.SelectedItem.ToString().Contains("Preview Only")
        button2.Enabled = Not previewOnly
        button3.Enabled = Not previewOnly
    End Sub

    Private templateName As String


    ' Print Preview
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        c1Editor1.PrintPreview(System.IO.Path.GetFullPath(Me.templateName))
    End Sub

    ' Print with Prompt
    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        c1Editor1.Print(True, System.IO.Path.GetFullPath(Me.templateName))
    End Sub

    ' Print w/o Prompt
    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
        c1Editor1.Print(False, System.IO.Path.GetFullPath(Me.templateName))
    End Sub

End Class
