Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.TouchToolKit

Imports TouchToolKitDemoVB.C1ZoomPages.Help_Forms

Namespace C1ZoomPages
    Partial Public Class ControlBarDemo
        Inherits DemoBase
        Public Sub New()
            InitializeComponent()

            Me.Title = "ControlBar"
            Me.Description = "ControlBar can provide a floating, translucent window for form." & vbCr & vbLf & "- ControlBar provides built-in actions, the map demo shows how to use the built-in actions." & vbCr & vbLf & "- Of course, customize the action is simple, keyboard demo shows how to costomize the actions."
        End Sub

        Private Sub button1_Click(sender As Object, e As EventArgs)
            Dim form As Form = New MapViewFormForControlBar()
            form.Show(Me)
        End Sub

        Private Sub button3_Click(sender As Object, e As EventArgs)
            Dim form As Form = New InputFormforControlBar()
            form.Show()
        End Sub
    End Class
End Namespace
