Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.IO
Imports System.Windows.Forms

Namespace Tutorial2
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
            c1DynamicHelp1.HelpSource = Path.GetFileName(c1DynamicHelp1.HelpSource)
        End Sub

        Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
            Return MyBase.ProcessCmdKey(msg, keyData)
        End Function

        ' toggle authoring mode when the user hits ctrl+shift+a
        Overrides Protected Sub OnKeyDown(ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.A AndAlso e.Control AndAlso e.Shift Then
                 c1DynamicHelp1.AuthoringMode = Not c1DynamicHelp1.AuthoringMode
            End If
            MyBase.OnKeyDown(e)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            c1DynamicHelp1.TopicMap.Refresh()
        End Sub

        Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If c1DynamicHelp1.TopicMap.HasChanges Then
                Dim dr As DialogResult = MessageBox.Show("Would you like to save the changes you made to control/topic map?", "C1DynamicHelp Tutorial", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If dr = System.Windows.Forms.DialogResult.Yes Then
                    c1DynamicHelp1.TopicMap.Save()
                ElseIf dr = System.Windows.Forms.DialogResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        End Sub
    End Class
End Namespace