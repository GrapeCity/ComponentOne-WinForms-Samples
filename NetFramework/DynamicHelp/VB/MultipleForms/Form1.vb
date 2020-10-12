Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace MultipleForms
    Partial Public Class Form1
        Inherits DHBaseForm
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            ' show Form2
            Dim f As New Form2()
            ' use the MainForm property to allow the C1DynamicHelp control on Form2 to the control on Form1 as its data source
            f.MainForm = Me
            f.ShowDialog()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
            ' show Form3
            Dim f As New Form3()
            ' use the MainForm property to allow the C1DynamicHelp control on Form3 to use the control on Form1 as its data source
            f.MainForm = Me
            f.ShowDialog()
        End Sub
    End Class
End Namespace