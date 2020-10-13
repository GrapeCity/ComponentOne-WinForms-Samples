Imports System
Imports System.Drawing
Imports System.Drawing.Printing
Imports C1.C1Preview

Namespace C1.Win.C1FlexGrid
    ''' <summary>
    ''' Object to manage custom page headers and footers when printing and previewing.
    ''' </summary>
    Public Class C1OwnerDrawPrint
        Private Const DefaultHeightInch As Double = 1

        Private _height As Double = DefaultHeightInch
        Private _rootObject As RenderArea = Nothing
        Private _doc As C1PrintDocument = Nothing

        Shared Sub New()
        End Sub

        Friend Sub New(ByVal doc As C1PrintDocument)
            _doc = doc
        End Sub

        ''' <summary>
        ''' Set the height of the printing area (in inches)
        ''' </summary>
        ''' <param name="value"></param>
        Friend Sub SetHeightInch(ByVal value As Double)
            If (value >= 0) Then
                _height = value
            Else
                _height = 0
            End If
        End Sub

        ''' <summary>
        ''' Gets the height of the header/footer area in inches.
        ''' </summary>
        Public ReadOnly Property HeightInch() As Double
            Get
                Return _height
            End Get
        End Property

        Friend Sub StartDrawing()
            _rootObject = New RenderArea(_doc)
            _rootObject.Height = New Unit(_height, UnitTypeEnum.Inch)
        End Sub

        Friend Sub EndDrawing()
            ''
        End Sub

        Friend Function GetRootObject() As RenderObject
            Return _rootObject
        End Function

        ''' <summary>
        ''' Gets the RenderArea object representing the entire area of the owner-drawn page header or footer.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property RenderArea() As RenderArea
            Get
                Return _rootObject
            End Get
        End Property

        ''' <summary>
        ''' Adds text to the owner-drawn page header or footer.
        ''' </summary>
        ''' <param name="x">The X coordinate of the text.</param>
        ''' <param name="y">The Y coordinate of the text.</param>
        ''' <param name="text">The text to render.</param>
        ''' <param name="width">The width of the text area.</param>
        ''' <param name="height">The height of the text area.</param>
        ''' <param name="font">The text font.</param>
        ''' <param name="textColor">The text color.</param>
        ''' <param name="align">The text alignment.</param>
        ''' <remarks>
        ''' The <paramref name="text"/> parameter may contain the following placeholders:
        ''' <list type="bullet">
        ''' <item><c>\p</c> - current page number (equivalent to C1PrintDocument tag <c>[PagenNo]</c></item>
        ''' <item><c>\P</c> - total page count (equivalent to C1PrintDocument tag <c>[PageCount]</c></item>
        ''' <item><c>\s</c> - horizontal page number (equivalent to C1PrintDocument tag <c>[PageX]</c></item>
        ''' <item><c>\S</c> - total horizontal page count (equivalent to C1PrintDocument tag <c>[PageXCount]</c></item>
        ''' <item><c>\g</c> - vertical page number (equivalent to C1PrintDocument tag <c>[PageY]</c></item>
        ''' <item><c>\G</c> - total vertical page count (equivalent to C1PrintDocument tag <c>[PageYCount]</c></item>
        ''' </list>
        ''' </remarks>
        Public Sub RenderDirectText( _
            ByVal x As Unit, ByVal y As Unit, ByVal text As String, ByVal width As Unit, ByVal height As Unit, _
            ByVal font As Font, ByVal textColor As Color, ByVal align As TextAlignEnum)

            Dim dText As New RenderText(_doc)
            Select Case align
                Case TextAlignEnum.CenterBottom
                    dText.Style.TextAlignHorz = AlignHorzEnum.Center
                    dText.Style.TextAlignVert = AlignVertEnum.Bottom
                Case TextAlignEnum.CenterCenter
                    dText.Style.TextAlignHorz = AlignHorzEnum.Center
                    dText.Style.TextAlignVert = AlignVertEnum.Center
                Case TextAlignEnum.CenterTop
                    dText.Style.TextAlignHorz = AlignHorzEnum.Center
                    dText.Style.TextAlignVert = AlignVertEnum.Top
                Case TextAlignEnum.GeneralBottom
                    dText.Style.TextAlignHorz = AlignHorzEnum.Left
                    dText.Style.TextAlignVert = AlignVertEnum.Bottom
                Case TextAlignEnum.GeneralCenter
                    dText.Style.TextAlignHorz = AlignHorzEnum.Left
                    dText.Style.TextAlignVert = AlignVertEnum.Center
                Case TextAlignEnum.GeneralTop
                    dText.Style.TextAlignHorz = AlignHorzEnum.Left
                    dText.Style.TextAlignVert = AlignVertEnum.Top
                Case TextAlignEnum.LeftBottom
                    dText.Style.TextAlignHorz = AlignHorzEnum.Left
                    dText.Style.TextAlignVert = AlignVertEnum.Bottom
                Case TextAlignEnum.LeftCenter
                    dText.Style.TextAlignHorz = AlignHorzEnum.Left
                    dText.Style.TextAlignVert = AlignVertEnum.Center
                Case TextAlignEnum.LeftTop
                    dText.Style.TextAlignHorz = AlignHorzEnum.Left
                    dText.Style.TextAlignVert = AlignVertEnum.Top
                Case TextAlignEnum.RightBottom
                    dText.Style.TextAlignHorz = AlignHorzEnum.Right
                    dText.Style.TextAlignVert = AlignVertEnum.Bottom
                Case TextAlignEnum.RightCenter
                    dText.Style.TextAlignHorz = AlignHorzEnum.Right
                    dText.Style.TextAlignVert = AlignVertEnum.Center
                Case TextAlignEnum.RightTop
                    dText.Style.TextAlignHorz = AlignHorzEnum.Right
                    dText.Style.TextAlignVert = AlignVertEnum.Top
            End Select

            dText.Text = C1FlexGridPrintable.ReplacePageText(text)
            dText.Style.Font = Font
            dText.Style.TextColor = textColor
            dText.Width = width
            dText.Height = height
            dText.X = x
            dText.Y = y
            _rootObject.Children.Add(dText)
        End Sub

        ''' <summary>
        ''' Adds text to the owner-drawn page header or footer.
        ''' </summary>
        ''' <param name="x">The X coordinate of the text.</param>
        ''' <param name="y">The Y coordinate of the text.</param>
        ''' <param name="text">The text to render.</param>
        ''' <param name="width">The width of the text area.</param>
        ''' <param name="font">The text font.</param>
        ''' <param name="textColor">The text color.</param>
        ''' <param name="align">The text alignment.</param>
        ''' <remarks>
        ''' The <paramref name="text"/> parameter may contain the following placeholders:
        ''' <list type="bullet">
        ''' <item><c>\p</c> - current page number (equivalent to C1PrintDocument tag <c>[PagenNo]</c></item>
        ''' <item><c>\P</c> - total page count (equivalent to C1PrintDocument tag <c>[PageCount]</c></item>
        ''' <item><c>\s</c> - horizontal page number (equivalent to C1PrintDocument tag <c>[PageX]</c></item>
        ''' <item><c>\S</c> - total horizontal page count (equivalent to C1PrintDocument tag <c>[PageXCount]</c></item>
        ''' <item><c>\g</c> - vertical page number (equivalent to C1PrintDocument tag <c>[PageY]</c></item>
        ''' <item><c>\G</c> - total vertical page count (equivalent to C1PrintDocument tag <c>[PageYCount]</c></item>
        ''' </list>
        ''' </remarks>
        Public Sub RenderDirectText( _
            ByVal x As Unit, ByVal y As Unit, ByVal text As String, ByVal width As Unit, _
            ByVal font As Font, ByVal textColor As Color, ByVal align As TextAlignEnum)
            RenderDirectText(x, y, text, width, Unit.Auto, font, textColor, align)
        End Sub

        ''' <summary>
        ''' Adds text to the owner-drawn page header or footer.
        ''' </summary>
        ''' <param name="x">The X coordinate of the text.</param>
        ''' <param name="y">The Y coordinate of the text.</param>
        ''' <param name="text">The text to render.</param>
        ''' <param name="width">The width of the text area.</param>
        ''' <param name="font">The text font.</param>
        ''' <param name="textColor">The text color.</param>
        ''' <param name="align">The text alignment.</param>
        ''' <remarks>
        ''' The <paramref name="text"/> parameter may contain the following placeholders:
        ''' <list type="bullet">
        ''' <item><c>\p</c> - current page number (equivalent to C1PrintDocument tag <c>[PagenNo]</c></item>
        ''' <item><c>\P</c> - total page count (equivalent to C1PrintDocument tag <c>[PageCount]</c></item>
        ''' <item><c>\s</c> - horizontal page number (equivalent to C1PrintDocument tag <c>[PageX]</c></item>
        ''' <item><c>\S</c> - total horizontal page count (equivalent to C1PrintDocument tag <c>[PageXCount]</c></item>
        ''' <item><c>\g</c> - vertical page number (equivalent to C1PrintDocument tag <c>[PageY]</c></item>
        ''' <item><c>\G</c> - total vertical page count (equivalent to C1PrintDocument tag <c>[PageYCount]</c></item>
        ''' </list>
        ''' </remarks>
        Public Sub RenderDirectText( _
            ByVal x As Object, ByVal y As Object, ByVal text As String, ByVal width As Object, _
            ByVal font As Font, ByVal textColor As Color, ByVal align As TextAlignEnum)
            RenderDirectText(New Unit(x.ToString()), New Unit(y.ToString()), text, _
                New Unit(width.ToString()), font, textColor, align)
        End Sub

        ''' <summary>
        ''' Adds image to the owner-drawn page header or footer.
        ''' </summary>
        ''' <param name="x">The X coordinate of the image.</param>
        ''' <param name="y">The Y coordinate of the image.</param>
        ''' <param name="image">The image to render.</param>
        ''' <param name="width">The image width.</param>
        ''' <param name="height">The image height.</param>
        ''' <param name="align">Image alignment options.</param>
        Public Sub RenderDirectImage( _
            ByVal x As Unit, ByVal y As Unit, ByVal image As Image, _
            ByVal width As Unit, ByVal height As Unit, ByVal align As ImageAlignEnum)

            Dim dImage As New RenderImage(_doc)
            dImage.Image = image
            dImage.Width = width
            dImage.Height = height
            Dim ia = ImageAlign.Default
            Select Case align
                Case ImageAlignEnum.CenterCenter
                    ia.AlignHorz = ImageAlignHorzEnum.Center
                    ia.AlignVert = ImageAlignVertEnum.Center
                Case ImageAlignEnum.CenterTop
                    ia.AlignHorz = ImageAlignHorzEnum.Center
                    ia.AlignVert = ImageAlignVertEnum.Top
                Case ImageAlignEnum.CenterBottom
                    ia.AlignHorz = ImageAlignHorzEnum.Center
                    ia.AlignVert = ImageAlignVertEnum.Bottom
                Case ImageAlignEnum.LeftBottom
                    ia.AlignHorz = ImageAlignHorzEnum.Left
                    ia.AlignVert = ImageAlignVertEnum.Bottom
                Case ImageAlignEnum.LeftCenter
                    ia.AlignHorz = ImageAlignHorzEnum.Left
                    ia.AlignVert = ImageAlignVertEnum.Center
                Case ImageAlignEnum.LeftTop
                    ia.AlignHorz = ImageAlignHorzEnum.Left
                    ia.AlignVert = ImageAlignVertEnum.Top
                Case ImageAlignEnum.RightBottom
                    ia.AlignHorz = ImageAlignHorzEnum.Right
                    ia.AlignVert = ImageAlignVertEnum.Bottom
                Case ImageAlignEnum.RightCenter
                    ia.AlignHorz = ImageAlignHorzEnum.Right
                    ia.AlignVert = ImageAlignVertEnum.Center
                Case ImageAlignEnum.RightTop
                    ia.AlignHorz = ImageAlignHorzEnum.Right
                    ia.AlignVert = ImageAlignVertEnum.Top
                Case ImageAlignEnum.Scale
                    ia.KeepAspectRatio = True
                Case ImageAlignEnum.Stretch
                    ia.KeepAspectRatio = False
                    ia.StretchHorz = True
                    ia.StretchVert = True
                Case ImageAlignEnum.Tile
                    ia.TileHorz = True
                    ia.TileVert = True
            End Select
            dImage.Style.ImageAlign = ia
            dImage.Width = width
            dImage.Height = height
            dImage.X = x
            dImage.Y = y
            _rootObject.Children.Add(dImage)
        End Sub

        ''' <summary>
        ''' Adds image to the owner-drawn page header or footer.
        ''' </summary>
        ''' <param name="x">X-coordinate.</param>
        ''' <param name="y">Y-coordinate.</param>
        ''' <param name="image">Image to render.</param>
        ''' <param name="width">Width to render.</param>
        ''' <param name="height">Height to render.</param>
        ''' <param name="align">Alignment options.</param>
        Public Sub RenderDirectImage( _
            ByVal x As Object, ByVal y As Object, ByVal image As Image, _
            ByVal width As Object, ByVal height As Object, ByVal align As ImageAlignEnum)
            RenderDirectImage(New Unit(x.ToString()), New Unit(y.ToString()), image, _
            New Unit(width.ToString()), New Unit(height.ToString()), align)
        End Sub
    End Class
End Namespace
