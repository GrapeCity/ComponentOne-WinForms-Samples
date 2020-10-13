Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.TouchToolKit
Imports ClickOnceDemo.C1ZoomPages.Help_Forms
Imports TouchToolKitDemo.C1ZoomPages.Help_Forms

Namespace C1ZoomPages
    Partial Public Class MiscFeatureDemo
        Inherits DemoBase
        Public Sub New()
            InitializeComponent()
            InitializeDemo()
        End Sub

        Private Sub InitializeDemo()
            Me.Title = "Misc Features"
            Me.Description = "In this page you can try a few features."

            NoneFullScreenRadioButton.Checked = True
            MiddleCenterRadioButton.Checked = True
            AddHandler layoutButton.Click, AddressOf layoutButton_Click

            TileRadioButton.Checked = True
            backcolorPreviewPanel.BackColor = SystemColors.Control
            AddHandler backgroundButton.Click, AddressOf backgroundButton_Click
            AddHandler TileRadioButton.CheckedChanged, AddressOf BackgroundImageLayoutRadioButton_CheckedChanged
            AddHandler NoneBackgroundImagRadioButton.CheckedChanged, AddressOf BackgroundImageLayoutRadioButton_CheckedChanged
            AddHandler stretchRadioButton.CheckedChanged, AddressOf BackgroundImageLayoutRadioButton_CheckedChanged
            AddHandler zoomRadioButton.CheckedChanged, AddressOf BackgroundImageLayoutRadioButton_CheckedChanged
            AddHandler centerRadioButton.CheckedChanged, AddressOf BackgroundImageLayoutRadioButton_CheckedChanged
            AddHandler bcButton.Click, AddressOf bcButton_Click
            AddHandler biButton.Click, AddressOf biButton_Click

            AddHandler keepAspectRationButton.Click, AddressOf keepAspectRationButton_Click
        End Sub

#Region "Layout"

        Private Sub layoutButton_Click(sender As Object, e As EventArgs)
            Using form As New MiscFeatureForm()
                form.Text = "Full Screen Form"
                Dim gcZoom As New C1Zoom()
                gcZoom.FullScreenMode = GetFullScreenMode()
                gcZoom.InnerPanelLayoutMode = GetInnerPanelLayoutMode()
                gcZoom.Target = form
                gcZoom.ControlBars.Add(New C1.Win.TouchToolKit.ControlBar() With {
                    .Content = GetType(ControlBarUserControl03),
                    .Opacity = 1,
                    .DockPosition = ContentAlignment.TopRight
                })
                form.ShowDialog(Me)
            End Using
        End Sub

        Private Function GetFullScreenMode() As FullScreenMode
            If NoneFullScreenRadioButton.Checked Then
                Return FullScreenMode.None
            ElseIf FullScreenRadioButton.Checked Then
                Return FullScreenMode.FullScreen
            Else
                Return FullScreenMode.FullScreenWithTaskBar
            End If
        End Function

        Private Function GetInnerPanelLayoutMode() As InnerPanelLayoutMode
            If MiddleCenterRadioButton.Checked Then
                Return InnerPanelLayoutMode.MiddleCenter
            Else
                Return InnerPanelLayoutMode.None
            End If
        End Function

        Private Sub NoneInnerPanelLayout_Click(sender As Object, e As EventArgs)
            If Not LeftLayoutRadioButton.Checked Then
                LeftLayoutRadioButton.Checked = True
            End If
        End Sub

        Private Sub MiddleCenterInnerPanelLayout_Click(sender As Object, e As EventArgs)
            If Not MiddleCenterRadioButton.Checked Then
                MiddleCenterRadioButton.Checked = True
            End If
        End Sub

#End Region

#Region "Custom Background"

        Private _gcZoomForBackground As New C1Zoom()

        Private Sub backgroundButton_Click(sender As Object, e As EventArgs)
            Using form As New MiscFeatureForm()
                form.Text = "Custom Background Form"
                _gcZoomForBackground.Target = form
                form.ShowDialog(Me)
            End Using
        End Sub

        Private Sub BackgroundImageLayoutRadioButton_CheckedChanged(sender As Object, e As EventArgs)
            If TileRadioButton.Checked Then
                _gcZoomForBackground.BackgroundImageLayout = ImageLayout.Tile
            ElseIf NoneBackgroundImagRadioButton.Checked Then
                _gcZoomForBackground.BackgroundImageLayout = ImageLayout.None
            ElseIf stretchRadioButton.Checked Then
                _gcZoomForBackground.BackgroundImageLayout = ImageLayout.Stretch
            ElseIf zoomRadioButton.Checked Then
                _gcZoomForBackground.BackgroundImageLayout = ImageLayout.Zoom
            ElseIf centerRadioButton.Checked Then
                _gcZoomForBackground.BackgroundImageLayout = ImageLayout.Center
            End If
            backcolorPreviewPanel.BackgroundImageLayout = _gcZoomForBackground.BackgroundImageLayout
        End Sub

        Private Sub bcButton_Click(sender As Object, e As EventArgs)
            Dim dialog As New ColorDialog()
            If DialogResult.OK = dialog.ShowDialog() Then
                _gcZoomForBackground.BackColor = dialog.Color
                backcolorPreviewPanel.BackColor = dialog.Color
            End If
        End Sub

        Private Sub biButton_Click(sender As Object, e As EventArgs)
            Dim dialog As New OpenFileDialog()
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
            If DialogResult.OK = dialog.ShowDialog() Then
                Dim bitmap As Bitmap = Nothing
                Try
                    bitmap = New Bitmap(dialog.FileName)
                Catch generatedExceptionName As ArgumentException
                    MessageBox.Show("This is not a suitable file.")
                    Return
                End Try
                If backcolorPreviewPanel.BackgroundImage IsNot Nothing Then
                    _gcZoomForBackground.BackgroundImage = Nothing
                    backcolorPreviewPanel.BackgroundImage.Dispose()
                    backcolorPreviewPanel.BackgroundImage = Nothing
                End If
                _gcZoomForBackground.BackgroundImage = bitmap
                backcolorPreviewPanel.BackgroundImage = bitmap
            End If
        End Sub

#End Region

#Region "KeepAspectRatio"

        Private Sub keepAspectRationButton_Click(sender As Object, e As EventArgs)
            Using form As New MiscFeatureForm()
                form.Text = "KeepAspectRatio Form"
                Dim gcZoom As New C1Zoom()
                gcZoom.KeepAspectRatio = KeepAspectRatioCheckBox.Checked
				gcZoom.Target = form
				form.ShowDialog(Me)
			End Using
		End Sub

		#End Region
	End Class
End Namespace
