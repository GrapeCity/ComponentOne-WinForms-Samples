Namespace C1ZoomPages.Help_Forms
	Partial Class MapViewFormForControlBar
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim controlBar1 As New C1.Win.TouchToolKit.ControlBar()
			Dim controlBar2 As New C1.Win.TouchToolKit.ControlBar()
			Me.gcZoom1 = New C1.Win.TouchToolKit.C1Zoom(Me.components)
			Me.SuspendLayout()
			' 
			' gcZoom1
			' 
            controlBar1.Content = GetType(C1ZoomPages.Help_Forms.ControlBarUserControl01)
			controlBar1.TransparencyKey = System.Drawing.SystemColors.Control
			controlBar1.DockPosition = System.Drawing.ContentAlignment.TopRight
			controlBar1.Margin = New System.Windows.Forms.Padding(10)
			controlBar1.Opacity = 0.7
			controlBar1.TransparentBackground = True
            controlBar2.Content = GetType(C1ZoomPages.Help_Forms.ControlBarUserControl02)
			controlBar2.TransparencyKey = System.Drawing.SystemColors.Control
			controlBar2.DockPosition = System.Drawing.ContentAlignment.TopLeft
			controlBar2.Margin = New System.Windows.Forms.Padding(10)
			controlBar2.Opacity = 0.7
			controlBar2.TransparentBackground = True
			Me.gcZoom1.ControlBars.Add(controlBar1)
			Me.gcZoom1.ControlBars.Add(controlBar2)
			Me.gcZoom1.FullScreenMode = C1.Win.TouchToolKit.FullScreenMode.FullScreen
			Me.gcZoom1.InnerPanelLayoutMode = C1.Win.TouchToolKit.InnerPanelLayoutMode.MiddleCenter
			Me.gcZoom1.IsHorizontalRailEnabled = False
			Me.gcZoom1.IsVerticalRailEnabled = False
			Me.gcZoom1.MaxZoomFactor = 4F
			Me.gcZoom1.Target = Me
			' 
			' MapViewForControlBar
			' 
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
			Me.ClientSize = New System.Drawing.Size(1500, 1000)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "MapViewForControlBar"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "ControlBarForm"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gcZoom1 As C1.Win.TouchToolKit.C1Zoom
	End Class
End Namespace
