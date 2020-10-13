Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.TouchToolKit

Namespace C1ZoomPages.Help_Forms
    Partial Public Class ControlBarUserControl03
        Inherits UserControl
        Public Sub New()
            InitializeComponent()
        End Sub

        Private zoomObj As C1Zoom
        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            zoomObj = Me.gcZoomCommandProvider1.OwnerGcZoom

            button5_Click(Nothing, EventArgs.Empty)
		End Sub

		Private Sub button5_Click(sender As Object, e As EventArgs)
			If zoomObj.FullScreenMode = FullScreenMode.FullScreen OrElse zoomObj.FullScreenMode = FullScreenMode.FullScreenWithTaskBar Then
				button5.Text = "Normal form"
			Else
				button5.Text = "Full screen"
			End If
		End Sub

		Private Sub button4_Click(sender As Object, e As EventArgs)
			TryCast(zoomObj.Target, Form).Close()
		End Sub
	End Class
End Namespace
