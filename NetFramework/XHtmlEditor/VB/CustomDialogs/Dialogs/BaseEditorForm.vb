Imports System.IO
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Windows.Forms.VisualStyles
Imports C1.Win.C1Editor
Imports C1.Win.C1Editor.UICustomization
Imports Resources = CustomDialogs.Resources


''' <summary>
''' This type is for internal use only.
''' </summary>
Partial Friend Class BaseEditorForm
    Inherits Form
#Region "declarations"

    Private _editor As C1Editor = Nothing

    ''' <summary>
    ''' This member is for internal use only.
    ''' </summary>
    Protected _tooltip As ToolTip = Nothing
    ''' <summary>
    ''' This member is for internal use only.
    ''' </summary>
    Protected _item As XHTMLItemBase

#End Region

#Region "ctors"

    ''' <summary>
    ''' This member is for internal use only.
    ''' </summary>
    Protected Sub New()
        InitializeComponent()
        Font = SystemInformation.MenuFont
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

#End Region

#Region "implementation"

    ''' <summary>
    ''' Gets or sets the editor.
    ''' </summary>
    Public Property Editor() As C1Editor
        Get
            Return _editor
        End Get
        Set(ByVal value As C1Editor)
            _editor = value
        End Set
    End Property

    Private Sub AdjustFormWidth()
        AdjustMinimumSize()
    End Sub

    Private Sub AdjustMinimumSize()
        ' calculate minimum width for the controls on the form
        Dim minWidth As Integer = _containerMain.MinimumSize.Width
        Dim btnWidth As Integer = ClientSize.Width - _btnOK.Left
        If _btnAplly.Visible Then
            btnWidth = btnWidth + _btnAplly.Width
        End If
        ' check whether more space for the bottom buttons is required
        If btnWidth > minWidth Then
            minWidth = btnWidth
        End If
        Dim border As Integer = Me.Width - Me.ClientSize.Width
        Dim right As Integer = Me.Width - _containerMain.Left - _containerMain.Width
        Dim left As Integer = _containerMain.Left
        If Me.Text <> "BaseEditorForm" Then
            Me.MinimumSize = New Size(minWidth + left + right + border, Me.MinimumSize.Height)
        End If
    End Sub

    Protected Overridable Sub ApllyClick(ByVal sender As Object, ByVal e As EventArgs)
        BindingContext(_item).EndCurrentEdit()
        If _item.IsEditMode Then
            _item.ApplyChanges()
            OnItemPropertiesChanged()
            Focus()
        End If
    End Sub

    Protected Overridable Sub OnItemPropertiesChanged()
        ' used in derived classes
    End Sub

    ''' <summary>
    ''' If the sender is <see cref="NumericUpDown"/>, its <see cref="p:NumericUpDown.Value"/> property will be set to the <see cref="p:NumericUpDown.Text"/> property.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An <see cref="EventArgs"/> that contains no event data.</param>
    Protected Overridable Sub ValidateNumber(ByVal sender As Object, ByVal e As EventArgs)
        Dim control As NumericUpDown = TryCast(sender, NumericUpDown)
        If control IsNot Nothing Then
            control.Text = control.Value.ToString()
        End If
    End Sub

    Protected Shadows Function Show(ByVal owner As IWin32Window) As Boolean
        _btnAplly.Visible = _item.ApplyButtonVisible
        Dim margin As Integer = _btnCancel.Left - _btnOK.Right
        If _item.ApplyButtonVisible Then
            _btnCancel.Left = _btnAplly.Left - margin - _btnCancel.Width
        Else
            _btnCancel.Left = _btnAplly.Left
        End If
        _btnOK.Left = _btnCancel.Left - margin - _btnOK.Width
        Return ShowDialog(owner) = DialogResult.OK
    End Function

    Protected Sub PaintBorder(ByVal sender As Object, ByVal e As PaintEventArgs)
        Dim rectangle As Rectangle = DirectCast(sender, Control).ClientRectangle
        If Application.RenderWithVisualStyles AndAlso VisualStyleRenderer.IsElementDefined(VisualStyleElement.TextBox.TextEdit.Normal) Then
            Dim render As New VisualStyleRenderer(VisualStyleElement.TextBox.TextEdit.Normal)
            render.DrawBackground(e.Graphics, rectangle)
        Else
            rectangle.Width -= 1
            rectangle.Height -= 1
            Dim render As New ToolStripProfessionalRenderer()
            e.Graphics.DrawRectangle(New Pen(Color.FromArgb(21, 66, 139)), rectangle)
        End If
    End Sub

    ''' <summary>
    ''' This member is for internal use only.
    ''' </summary>
    Protected Sub LoadSizeFormat(ByVal control As ComboBox)
        control.Items.Clear()
        control.Items.Add(Resources.sPixels)
        control.Items.Add(Resources.sPercent)
    End Sub

    ''' <summary>
    ''' This member is for internal use only.
    ''' </summary>
    Protected Sub LoadAlignmentHorizontalFormat(ByVal control As ComboBox)
        control.Items.Clear()
        control.Items.Add(Resources.sAlignmentDefault)
        control.Items.Add(Resources.sAlignmentLeft)
        control.Items.Add(Resources.sAlignmentCenter)
        control.Items.Add(Resources.sAlignmentRight)
    End Sub

    ''' <summary>
    ''' This member is for internal use only.
    ''' </summary>
    Protected Sub LoadAlignmentVerticalFormat(ByVal control As ComboBox)
        control.Items.Clear()
        control.Items.Add(Resources.sAlignmentDefault)
        control.Items.Add(Resources.sAlignmentTop)
        control.Items.Add(Resources.sAlignmentMiddle)
        control.Items.Add(Resources.sAlignmentBottom)
    End Sub

    ''' <summary>
    ''' Adjusts the buttons height and top position according to the size and position of controls.
    ''' </summary>
    ''' <param name="buttons">An array of <see cref="Button"/>s to be adjusted.</param>
    ''' <param name="controls">An array of <see cref="Control"/>s used for button adjusting.</param>
    Protected Sub AdjustBrowseButtons(ByVal buttons As Button(), ByVal controls As Control())
        For i As Integer = 0 To buttons.Length - 1
            Dim button As Button = buttons(i)
            Dim control As Control = controls(i)
            button.Top = control.Top - 1
            button.Height = control.Height + 2
        Next
    End Sub

    ''' <summary>
    ''' Returns a relative or absolute path in Windows local file format.
    ''' </summary>
    ''' <param name="path">A path in any format.</param>
    ''' <returns>A path in Windows local file format.</returns>
    Protected Function GetLocalPath(ByVal path As String) As String
        Dim uri__1 As Uri = Nothing
        If Not Uri.TryCreate(path, UriKind.RelativeOrAbsolute, uri__1) Then
            Return Nothing
        End If
        If uri__1.IsAbsoluteUri Then
            path = uri__1.LocalPath
        Else
            path = uri__1.OriginalString.Replace("/"c, System.IO.Path.DirectorySeparatorChar)
        End If
        Return Uri.UnescapeDataString(path)
    End Function

    ''' <summary>
    ''' Returns a relative URI for the fileName according to the given base path
    ''' </summary>
    ''' <param name="path">Base path used to calculate the relative URI.</param>
    ''' <param name="fileName">File name to be converted to URI format.</param>
    ''' <returns>Relative URI</returns>
    Protected Function GetUriFromPath(ByVal path As String, ByVal fileName As String) As String
        Dim fileNameUri As New Uri(fileName)
        Dim uri__1 As Uri
        If path IsNot Nothing Then
            uri__1 = New Uri(path).MakeRelativeUri(fileNameUri)
        Else
            uri__1 = fileNameUri
        End If
        Return Uri.UnescapeDataString(New Uri(uri__1.ToString(), UriKind.RelativeOrAbsolute).ToString())
    End Function


    ''' <summary>
    ''' Corrects width and height: if width/height exceeds maxWidth/maxHeight, 
    ''' they are decreased to maxWidth/maxHeight with saving ratio.
    ''' </summary>
    ''' <param name="width">The width of the object.</param>
    ''' <param name="height">The height of the object.</param>
    ''' <param name="maxWidth">The maximum width of the object.</param>
    ''' <param name="maxHeight">The maximum height of the object.</param>
    Protected Sub ScaleSize(ByRef width As Integer, ByRef height As Integer, ByVal maxWidth As Integer, ByVal maxHeight As Integer)
        Dim scaleX As Double
        If maxWidth > 0 Then
            scaleX = (CDbl(width) / CDbl(maxWidth))
        Else
            scaleX = 0
        End If

        Dim scaleY As Double
        If maxHeight > 0 Then
            scaleY = (CDbl(height) / CDbl(maxHeight))
        Else
            scaleY = 0
        End If

        If scaleX > 1 OrElse scaleY > 1 Then
            Dim proportion As Double
            If height > 0 Then
                proportion = (CDbl(width) / CDbl(height))
            Else
                proportion = 0
            End If

            If scaleX > scaleY Then
                width = maxWidth
                If proportion > 0 Then
                    height = CInt((maxWidth / proportion))
                Else
                    height = 0
                End If

            Else
                If proportion > 0 Then
                    width = CInt((maxHeight * proportion))
                Else
                    width = 0
                End If

                height = maxHeight
            End If
        End If
        If width < 1 Then
            width = 1
        End If
        If height < 1 Then
            height = 1
        End If
    End Sub

    ''' <summary>
    ''' Adds a border to the <see cref="Image"/>.
    ''' </summary>
    ''' <param name="image">An <see cref="Image"/> to add border.</param>
    ''' <param name="width">Border width.</param>
    ''' <param name="color"><see cref="Color"/> of the border.</param>
    ''' <returns>The <see cref="Image"/> with the specified border.</returns>
    Protected Function AddBorder(ByVal image As Image, ByVal width As Integer, ByVal color As Color) As Image
        If image Is Nothing OrElse width <= 0 Then
            Return image
        End If

        Dim imageWidth As Integer = image.Width + width * 2
        Dim imageHeight As Integer = image.Height + width * 2
        Dim rects As Rectangle() = New Rectangle(width - 1) {}
        For i As Integer = 1 To width
            rects(i - 1) = New Rectangle(i - 1, i - 1, imageWidth - i * 2 + 1, imageHeight - i * 2 + 1)
        Next

        Dim bitmap As New Bitmap(imageWidth, imageHeight)
        Using graphics__1 As Graphics = Graphics.FromImage(bitmap)
            Using pen As New Pen(color)
                graphics__1.DrawRectangles(pen, rects)
            End Using
        End Using
        Return CombineImages(bitmap, image, AnchorStyles.None)
    End Function

    ''' <summary>
    ''' Merges two images into the single image.
    ''' </summary>
    ''' <param name="img1">The first image to be drawn at background.</param>
    ''' <param name="img2">The second image to be drawn at foreground.</param>
    ''' <param name="anchor">The anchor specifying how to align the second image.</param>
    ''' <returns>The merged image.</returns>
    Protected Function CombineImages(ByVal img1 As Image, ByVal img2 As Image, ByVal anchor As AnchorStyles) As Image
        Dim img As New Bitmap(img1)
        Using g As Graphics = Graphics.FromImage(img)
            Dim rc1 As New Rectangle(Point.Empty, img1.Size)
            Dim rc2 As New Rectangle(Point.Empty, img2.Size)
            If (anchor And AnchorStyles.Bottom) = AnchorStyles.Bottom Then
                rc2.Offset(0, img1.Height - img2.Height)
            End If
            If (anchor And AnchorStyles.Right) = AnchorStyles.Right Then
                rc2.Offset(img1.Width - img2.Width, 0)
            End If
            If anchor = AnchorStyles.None Then
                rc2.Offset((img1.Width - img2.Width) \ 2, (img1.Height - img2.Height) \ 2)
            End If
            g.DrawImage(img2, rc2)
        End Using
        Return img
    End Function

#End Region

#Region "internal classes"

    ''' <summary>
    ''' Represents a List of strings.
    ''' </summary>
    Friend Class StringList
        Inherits List(Of String)
        Private _comparer As StringComparer = StringComparer.InvariantCultureIgnoreCase
        ''' <summary>
        ''' Determines whether a string is in the <see cref="StringList"/>. 
        ''' </summary>
        ''' <param name="item">The string to locate in the <see cref="StringList"/>. The value can be null for reference types.</param>            
        ''' <returns>true if <paramref name="item"/> is found in the <see cref="StringList"/>; otherwise, false.</returns>
        Public Shadows Function Contains(ByVal item As String) As Boolean
            If item Is Nothing Then
                For i As Integer = 0 To Me.Count - 1
                    If Me(i) Is Nothing Then
                        Return True
                    End If
                Next
                Return False
            End If
            For j As Integer = 0 To Me.Count - 1
                If _comparer.Equals(Me(j), item) Then
                    Return True
                End If
            Next
            Return False
        End Function
    End Class

    ''' <summary>
    ''' Calculates the size of a Flash movie.
    ''' </summary>
    Friend Class FlashMovieSize
        Private _sizes As Integer() = New Integer(3) {}

#Region "ctors"

        Public Sub New(ByVal fileName As String)
            Dim buffer As Byte() = New Byte(16) {}
            Try
                Using fs As FileStream = File.Open(fileName, FileMode.Open)
                    fs.Seek(8, SeekOrigin.Begin)
                    fs.Read(buffer, 0, 17)
                End Using
                Parse(buffer)
            Catch
                Dim i As Integer = 0
                While i < _sizes.Length


                    _sizes(System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)) = 0
                End While
            End Try
        End Sub

#End Region

#Region "implementation"

        Private Function BinaryFormat(ByVal value As Byte) As String
            Dim res As String = Convert.ToString(value, 2)
            Return New String("0"c, 8 - res.Length) & res
        End Function

        Private Sub Parse(ByVal buffer As Byte())
            Dim s As String = String.Empty
            For i As Integer = 0 To buffer.Length - 1
                s += BinaryFormat(buffer(i))
            Next

            Dim dimensionLength As Integer = Convert.ToInt32(s.Substring(0, 5), 2)
            For i As Integer = 0 To _sizes.Length - 1
                Dim temp As String = s.Substring(5 + dimensionLength * i, dimensionLength)
                If temp(0) = "1"c Then
                    temp = New String("1"c, 32 - temp.Length) & temp
                End If
                _sizes(i) = Convert.ToInt32(temp, 2) \ 20
            Next

            Return
        End Sub

#End Region

#Region "properties"

        Public ReadOnly Property Width() As Integer
            Get
                If _sizes(1) > _sizes(0) Then
                    Return _sizes(1) - _sizes(0)
                Else
                    Return 0
                End If
            End Get
        End Property

        Public ReadOnly Property Height() As Integer
            Get
                If _sizes(3) > _sizes(2) Then
                    Return _sizes(3) - _sizes(2)
                Else
                    Return 0
                End If
            End Get
        End Property

#End Region
    End Class

#End Region
End Class
