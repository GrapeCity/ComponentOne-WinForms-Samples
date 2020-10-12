Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml

Namespace WorkingWithTopicMap
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
            ' load default topic map
            ' its name is c1DynamicHelp1.HelpSource + ".xml" name (in this sample: C1Sample.chm.xml)
            c1DynamicHelp1.TopicMap.Load()
        End Sub

        Private Sub btnLoadFrom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadFrom.Click
            Using dlg As New OpenFileDialog()
                ' set up and show OpenFileDialog
                dlg.InitialDirectory = Application.StartupPath
                dlg.Filter = "Topic map files (*.xml)|*.xml|All files (*.*)|*.*"
                If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    ' load topic map from the selected file
                    c1DynamicHelp1.TopicMap.Load(dlg.FileName)
                End If
            End Using
        End Sub

        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
            ' save topic map to the default file name: c1DynamicHelp1.HelpSource + ".xml" (in this sample: C1Sample.chm.xml)
            c1DynamicHelp1.TopicMap.Save()
        End Sub

        Private Sub btnSaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveAs.Click
            Using dlg As New SaveFileDialog()
                ' set up and show SaveFileDialog
                dlg.InitialDirectory = Application.StartupPath
                dlg.Filter = "Topic map files (*.xml)|*.xml|All files (*.*)|*.*"
                If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    ' save topic map to the selected file
                    c1DynamicHelp1.TopicMap.Save(dlg.FileName)
                End If
            End Using
        End Sub

        Private Sub btnLoadFromRes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadFromRes.Click
            ' create new XmlDocument
            Dim topicMap As New XmlDocument()
            ' load XmlDocument from application resources
            topicMap.LoadXml(Resources.ResTopicMap())
            ' set XmlDocument as the source for the c1DynamicHelp1.TopicMap
            c1DynamicHelp1.TopicMap.XmlSource = topicMap
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' need to refresh the topic map, because Form1 has just been created, and C1DynamicHelp control was already initialized prior to that
            c1DynamicHelp1.TopicMap.Refresh()
        End Sub

        ' toggle authoring mode when the user hits ctrl+shift+a
        Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
            ' you can activate authoring mode, change topic map and try to save it to different locations and 
            ' then load it back 
            If e.KeyCode = Keys.A AndAlso e.Control AndAlso e.Shift Then
                c1DynamicHelp1.AuthoringMode = Not c1DynamicHelp1.AuthoringMode
            End If
            MyBase.OnKeyDown(e)
        End Sub

    End Class
End Namespace