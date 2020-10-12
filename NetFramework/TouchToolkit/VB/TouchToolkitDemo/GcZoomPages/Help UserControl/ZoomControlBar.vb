Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.TouchToolKit

Namespace C1ZoomPages.Help_Forms
	Public Partial Class ControlBarUserControl02
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(e As EventArgs)
            myTrackBar1.Value = Me.gcZoomCommandProvider1.OwnerGcZoom.ZoomFactor
            AddHandler myTrackBar1.ValueChanged, AddressOf myTrackBar1_ValueChanged
            AddHandler Me.gcZoomCommandProvider1.OwnerGcZoom.ZoomFactorChanged, AddressOf OwnerGcZoom_ZoomFactorChanged
            MyBase.OnLoad(e)
        End Sub

        Private Sub OwnerGcZoom_ZoomFactorChanged(sender As Object, e As EventArgs)
            myTrackBar1.Value = Me.gcZoomCommandProvider1.OwnerGcZoom.ZoomFactor
        End Sub

        Private Sub myTrackBar1_ValueChanged(sender As Object, e As EventArgs)
            Me.gcZoomCommandProvider1.OwnerGcZoom.ZoomFactor = myTrackBar1.Value
        End Sub
	End Class
End Namespace
