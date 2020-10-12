Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace MultiScaleImagePages
    Partial Public Class MultiScaleImageDemo
        Inherits DemoBase
        Public Sub New()
            InitializeComponent()

            Me.Title = "C1MultiScaleImage"
            Me.Description = "C1MultiScaleImage can show image with better quality in zoom. This page shows difference between PictureBox and C1MultiScaleImage. " & vbLf & " -Please try zoom in the following zoompanel by touch."

            zoomFactorLabel.Text = "ZoomFactor:" & (gcZoomPanel1.ZoomFactor * 100).ToString() & "%"
            AddHandler gcZoomPanel1.ZoomFactorChanged, AddressOf gcZoomPanel1_ZoomFactorChanged
        End Sub

        Private Sub gcZoomPanel1_ZoomFactorChanged(sender As Object, e As EventArgs)
            zoomFactorLabel.Text = "ZoomFactor:" & (gcZoomPanel1.ZoomFactor * 100).ToString() & "%"
        End Sub
    End Class
End Namespace