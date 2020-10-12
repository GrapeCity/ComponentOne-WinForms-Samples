Imports C1.Win.TouchToolKit
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace C1ZoomPages.Help_Forms
	Public Partial Class MapViewFormForControlBar
		Inherits Form
		Private sliceCount As Integer = 4

		Public Sub New()
			InitializeComponent()

			Dim thread As New System.Threading.Thread(AddressOf ShowSplashForm)

			thread.Start()

			Dim b As Bitmap = My.Resources.world

			Dim width As Integer = Me.Width
			Dim height As Integer = Me.Height

			Dim sourceWidth As Integer = b.Width / sliceCount
			Dim sourceHeight As Integer = b.Height / sliceCount

			For column As Integer = 0 To sliceCount - 1
				For row As Integer = 0 To sliceCount - 1
					Dim image As New C1MultiScaleImage()

					Dim targetWidth As Integer = width \ sliceCount + 1
					Dim targetHeight As Integer = height \ sliceCount + 1

					image.Size = New Size(targetWidth, targetHeight)

					image.Location = New Point(row * width / sliceCount, column * height / sliceCount)

					Dim sourceRect As New Rectangle(row * sourceWidth, column * sourceHeight, sourceWidth, sourceHeight)

					Dim image4 = GetImagePart(image.Size, b, sourceRect, 4)
					image.Images.Add(New ImageItem(image4, 4F))
					Dim image2 = GetImagePart(image.Size, image4, New Rectangle(0, 0, image4.Width, image4.Height), 2)
					image.Images.Add(New ImageItem(image2, 2F))
					image.Image = GetImagePart(image.Size, image2, New Rectangle(0, 0, image2.Width, image2.Height), 1)

					Me.Controls.Add(image)
				Next
			Next

			b.Dispose()

			CloseSplashForm()
			thread.Abort()
		End Sub

		Private form As SplashForm

		Private Sub CloseSplashForm()
			If form.InvokeRequired Then
				form.Invoke(New Action(AddressOf CloseSplashForm))
			Else
				form.Close()
			End If
		End Sub

		Private Sub ShowSplashForm()
			form = New SplashForm()
			form.ShowDialog()
		End Sub

		Private Function GetImagePart(targetSize As Size, imageFrom As Image, boundsFrom As Rectangle, currentFactor As Integer) As Image
			Dim bitmap As New Bitmap(targetSize.Width * currentFactor, targetSize.Height * currentFactor)

			Using g As Graphics = Graphics.FromImage(bitmap)
				g.DrawImage(imageFrom, New Rectangle(Point.Empty, bitmap.Size), boundsFrom, GraphicsUnit.Pixel)
			End Using

			Return bitmap
		End Function
	End Class
End Namespace
