Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Configuration
Imports System.ComponentModel
Imports C1.Util
Imports C1.Win.C1Editor.UICustomization
Imports Resources = CustomDialogs.Resources

''' <summary>
''' Represents a form for editing image properties.
''' </summary>
Partial Friend Class ImageEditorForm
    Inherits BaseEditorForm
    Implements IImageItemDialog

#Region "declarations"

    Private _image As Image = Nothing

#End Region

#Region "ctors"

    Public Sub New()
        InitializeComponent()

        _tooltip = New ToolTip()
        _tooltip.SetToolTip(_btnSelectImageSource, Resources.sBrowseTooltip)
        AddHandler _btnSelectImageSource.Click, New EventHandler(AddressOf _btnSelectImageSource_Click)
        AddHandler _chkWidth.CheckedChanged, New EventHandler(AddressOf _chkWidth_CheckedChanged)
        AddHandler _chkHeight.CheckedChanged, New EventHandler(AddressOf _chkHeight_CheckedChanged)
        AddHandler _cbxWidthType.SelectedIndexChanged, New EventHandler(AddressOf _cbxWidthType_SelectedIndexChanged)
        AddHandler _cbxHeightType.SelectedIndexChanged, New EventHandler(AddressOf _cbxHeightType_SelectedIndexChanged)
        AddHandler _tbWidthValue.ValueChanged, New EventHandler(AddressOf _tbWidthValue_ValueChanged)
        AddHandler _tbHeightValue.ValueChanged, New EventHandler(AddressOf _tbHeightValue_ValueChanged)
        AddHandler _pbSourceImage.SizeChanged, New EventHandler(AddressOf PreviewImage)
        AddHandler _tbWidthValue.Validated, New EventHandler(AddressOf ValidateNumber)
        AddHandler _tbHeightValue.Validated, New EventHandler(AddressOf ValidateNumber)
        LoadSizeFormat(_cbxWidthType)
        LoadSizeFormat(_cbxHeightType)
        AddHandler _tbSource.TextChanged, New EventHandler(AddressOf SourceChanged)
        AddHandler _tbSource.TextChanged, New EventHandler(AddressOf SetButtonState)
    End Sub

#End Region

#Region "implementation"

    Protected Overloads Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        AdjustBrowseButtons(New Button() {_btnSelectImageSource}, New Control() {_tbSource})
    End Sub

    ''' <summary> 
    ''' Disposes of the resources (other than memory) used by the System.Windows.Forms.Form.
    ''' </summary>
    ''' <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Image IsNot Nothing Then
            Image.Dispose()
        End If

        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub SourceChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim currentDirectory As String = Nothing
        If _item.DocumentName IsNot Nothing Then
            currentDirectory = Directory.GetCurrentDirectory()
            Directory.SetCurrentDirectory(Path.GetDirectoryName(_item.DocumentName))
        End If
        Try
            Dim fileName As String = GetLocalPath(_tbSource.Text)
            If File.Exists(fileName) Then
                Try
                    Image = Image.FromFile(fileName)
                    If _tbSource.Text <> Item.Source Then
                        _chkWidth.Checked = True
                        _chkHeight.Checked = True
                        _cbxHeightType.SelectedIndex = CInt(C1.Win.C1Editor.UICustomization.SizeType.Pixel)
                        _cbxWidthType.SelectedIndex = CInt(C1.Win.C1Editor.UICustomization.SizeType.Pixel)
                        _tbWidthValue.Value = _image.Width
                        _tbHeightValue.Value = _image.Height
                    End If
                    PreviewImage(sender, e)
                Catch
                    Image = Nothing
                End Try
            Else
                Image = Nothing
            End If
        Finally
            If _item.DocumentName IsNot Nothing Then
                Directory.SetCurrentDirectory(currentDirectory)
            End If
        End Try
    End Sub

    Private Sub SetButtonState(ByVal sender As Object, ByVal e As EventArgs)
        _btnOK.Enabled = InlineAssignHelper(_btnAplly.Enabled, Not String.IsNullOrEmpty(_tbSource.Text.Trim()))
    End Sub

    Private ReadOnly Property Item() As XHTMLImageItem
        Get
            Return TryCast(_item, XHTMLImageItem)
        End Get
    End Property

    ' gets or sets the current image
    Private Property Image() As Image
        Get
            Return _image
        End Get
        Set(ByVal value As Image)
            _image = value
            _pbSourceImage.Image = _image
        End Set
    End Property

    ' gets the width of the current image for preview
    Private ReadOnly Property ImageWidth() As Integer
        Get
            If _image Is Nothing Then
                Return 1
            End If
            If Not _chkWidth.Checked Then
                Return _image.Width
            End If
            If _cbxWidthType.SelectedIndex = CInt(C1.Win.C1Editor.UICustomization.SizeType.Pixel) Then
                Return CInt(_tbWidthValue.Value)
            End If
            Return Math.Max(CInt((_pbSourceImage.Width * _tbWidthValue.Value / 100)), 1)
        End Get
    End Property

    ' gets the height of the current image for preview
    Private ReadOnly Property ImageHeight() As Integer
        Get
            If _image Is Nothing Then
                Return 1
            End If
            If Not _chkHeight.Checked Then
                Return _image.Height
            End If
            If CInt(_cbxHeightType.SelectedIndex) = CInt(C1.Win.C1Editor.UICustomization.SizeType.Pixel) Then
                Return CInt(_tbHeightValue.Value)
            End If
            Return Math.Max(CInt((_pbSourceImage.Height * _tbHeightValue.Value / 100)), 1)
        End Get
    End Property

    ' updates the current image size for preview
    Private Sub PreviewImage(ByVal sender As Object, ByVal e As EventArgs)
        If _image Is Nothing Then
            Return
        End If
        Dim current As Image = _pbSourceImage.Image
        Dim width As Integer = ImageWidth
        Dim height As Integer = ImageHeight
        ScaleSize(width, height, _pbSourceImage.ClientSize.Width, _pbSourceImage.ClientSize.Height)
        If current.Width <> width OrElse current.Height <> height Then
            Dim image As Image = New Bitmap(_image, width, height)
            image = AddBorder(image, 0, Color.Black)
            _pbSourceImage.Image = image
        End If
    End Sub

#End Region

#Region "implementation"

    Private Sub _btnSelectImageSource_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim dlg As New OpenFileDialog()
        dlg.Title = Resources.sSelectImageFile
        dlg.Filter = Resources.sFilterImage
        dlg.Multiselect = False
        dlg.FilterIndex = 1
        dlg.InitialDirectory = Path.GetDirectoryName(_item.DocumentName)
        If dlg.ShowDialog() = DialogResult.OK Then
            _tbSource.Text = GetUriFromPath(_item.DocumentName, dlg.FileName)
            BindingContext(_item).EndCurrentEdit()
        End If
    End Sub

    ' enables controls for setting image width
    Private Sub _chkWidth_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim enbabled As Boolean = _chkWidth.Checked
        _tbWidthValue.Enabled = enbabled
        _cbxWidthType.Enabled = enbabled
        PreviewImage(sender, e)
    End Sub

    ' enables controls for setting image height
    Private Sub _chkHeight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim enabled As Boolean = _chkHeight.Checked
        _tbHeightValue.Enabled = enabled
        _cbxHeightType.Enabled = enabled
        PreviewImage(sender, e)
    End Sub

    ' changes the image width type
    Private Sub _cbxWidthType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Item.WidthType = CType(_cbxWidthType.SelectedIndex, C1.Win.C1Editor.UICustomization.SizeType)
        Dim inPixel As Boolean = Item.WidthType = C1.Win.C1Editor.UICustomization.SizeType.Pixel
        If inPixel Then
            _tbWidthValue.Maximum = 5000
        Else
            _tbWidthValue.Maximum = 200
        End If


        If _image IsNot Nothing Then
            If inPixel Then
                _tbWidthValue.Value = Math.Max(Math.Min(_image.Width, 5000), 1)
            Else
                _tbWidthValue.Value = 100
            End If
            PreviewImage(sender, e)
        End If
    End Sub

    ' changes the image height type
    Private Sub _cbxHeightType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Item.HeightType = CType(_cbxHeightType.SelectedIndex, C1.Win.C1Editor.UICustomization.SizeType)
        Dim inPixel As Boolean = Item.HeightType = C1.Win.C1Editor.UICustomization.SizeType.Pixel
        If inPixel Then
            _tbHeightValue.Maximum = 5000
        Else
            _tbHeightValue.Maximum = 200
        End If

        If _image IsNot Nothing Then
            If inPixel Then
                _tbHeightValue.Maximum = Math.Max(Math.Min(_image.Height, 5000), 1)
            Else
                _tbHeightValue.Maximum = 100
            End If
            PreviewImage(sender, e)
        End If
    End Sub

    ' changes the image width
    Private Sub _tbWidthValue_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Item.WidthValue = CInt(_tbWidthValue.Value)
        PreviewImage(sender, e)
    End Sub

    ' changes the image height
    Private Sub _tbHeightValue_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Item.HeightValue = CInt(_tbHeightValue.Value)
        PreviewImage(sender, e)
    End Sub

#End Region

#Region "IImageItemDialog Members"

    ''' <summary>
    ''' Binds data from the item to GUI controls on the form.
    ''' Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
    ''' to read data from the item and write it back.
    ''' </summary>
    ''' <param name="item">The item to be bound to the GUI controls.</param>
    Private Sub IImageItemDialog_BindData(ByVal item__1 As XHTMLImageItem) Implements IImageItemDialog.BindData
        _item = item__1
        _cbxWidthType.SelectedIndex = CInt(Item.WidthType)
        _cbxHeightType.SelectedIndex = CInt(Item.HeightType)
        _tbWidthValue.Value = Math.Max(Item.WidthValue, 1)
        _tbHeightValue.Value = Math.Max(Item.HeightValue, 1)
        _tbSource.DataBindings.Add("Text", Item, "Source")
        _chkWidth.DataBindings.Add("Checked", Item, "UseWidth")
        _chkHeight.DataBindings.Add("Checked", Item, "UseHeight")
        _tbAlternate.DataBindings.Add("Text", Item, "Alternate")

        SetButtonState(Me, EventArgs.Empty)
    End Sub

    ''' <summary>
    ''' Shows the form with the specified owner to the user.
    ''' </summary>
    ''' <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
    ''' the top-level window that will own this form.</param>
    ''' <returns>True if the form was displayed successfully and the item was changed.</returns>
    Private Function IImageItemDialog_Show(ByVal owner As IWin32Window) As Boolean Implements IImageItemDialog.Show
        Return Show(owner)
    End Function
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

#End Region
End Class

