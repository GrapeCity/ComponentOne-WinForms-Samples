Imports System.Windows.Forms
Imports System.Configuration
Imports System.ComponentModel
Imports C1.Util
Imports C1.Win.C1Editor.UICustomization
Imports Resources = CustomDialogs.Resources

''' <summary>
''' Represents a form for editing Flash movie properties.
''' </summary>
Partial Friend Class FlashMovieEditorForm
    Inherits BaseEditorForm
    Implements IFlashMovieItemDialog
#Region "ctors"

    Public Sub New()
        InitializeComponent()

        _tooltip = New ToolTip()
        _tooltip.SetToolTip(_btnSelectFile, Resources.sBrowseTooltip)
        AddHandler _btnSelectFile.Click, New EventHandler(AddressOf _btnSelectFile_Click)
        AddHandler _chkWidth.CheckedChanged, New EventHandler(AddressOf _chkWidth_CheckedChanged)
        AddHandler _chkHeight.CheckedChanged, New EventHandler(AddressOf _chkHeight_CheckedChanged)
        AddHandler _cbxWidthType.SelectedIndexChanged, New EventHandler(AddressOf _cbxWidthType_SelectedIndexChanged)
        AddHandler _cbxHeightType.SelectedIndexChanged, New EventHandler(AddressOf _cbxHeightType_SelectedIndexChanged)
        AddHandler _nudWidthValue.Validated, New EventHandler(AddressOf ValidateNumber)
        AddHandler _nudHeightValue.Validated, New EventHandler(AddressOf ValidateNumber)
        LoadSizeFormat(_cbxWidthType)
        LoadSizeFormat(_cbxHeightType)
        AddHandler _tbData.TextChanged, New EventHandler(AddressOf SetButtonState)
    End Sub

#End Region

#Region "implementation"

    Protected Overloads Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        AdjustBrowseButtons(New Button() {_btnSelectFile}, New Control() {_tbData})
    End Sub

    Private Sub SetButtonState(ByVal sender As Object, ByVal e As EventArgs)
        _btnOK.Enabled = InlineAssignHelper(_btnAplly.Enabled, Not String.IsNullOrEmpty(_tbData.Text.Trim()))
    End Sub

    Private ReadOnly Property Item() As XHTMLFlashMovieItem
        Get
            Return TryCast(_item, XHTMLFlashMovieItem)
        End Get
    End Property

#End Region

#Region "event handlers"

    Private Sub _btnSelectFile_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim dlg As New OpenFileDialog()
        dlg.Filter = Resources.sFilterFlashMovie
        dlg.Multiselect = False
        dlg.FilterIndex = 1
        dlg.InitialDirectory = System.IO.Path.GetDirectoryName(_item.DocumentName)
        If dlg.ShowDialog() = DialogResult.OK Then
            _tbData.Text = GetUriFromPath(_item.DocumentName, dlg.FileName)

            Dim size As New FlashMovieSize(dlg.FileName)
            _cbxHeightType.SelectedIndex = CInt(C1.Win.C1Editor.UICustomization.SizeType.Pixel)
            _cbxWidthType.SelectedIndex = CInt(C1.Win.C1Editor.UICustomization.SizeType.Pixel)
            If size.Width > 0 AndAlso size.Height > 0 Then
                _chkWidth.Checked = True
                _chkHeight.Checked = True
                _nudHeightValue.Value = size.Height
                _nudWidthValue.Value = size.Width
            Else
                _chkWidth.Checked = False
                _chkHeight.Checked = False
                _nudHeightValue.Value = 0
                _nudWidthValue.Value = 0
            End If

            BindingContext(_item).EndCurrentEdit()
        End If
    End Sub

    ' enables/disables controls for setting object width
    Private Sub _chkWidth_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        _nudWidthValue.Enabled = _chkWidth.Checked
        _cbxWidthType.Enabled = _chkWidth.Checked
    End Sub

    ' enables/disables controls for setting object height
    Private Sub _chkHeight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        _nudHeightValue.Enabled = _chkHeight.Checked
        _cbxHeightType.Enabled = _chkHeight.Checked
    End Sub

    ' changes the object width type
    Private Sub _cbxWidthType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Item.WidthType = CType(_cbxWidthType.SelectedIndex, C1.Win.C1Editor.UICustomization.SizeType)
        If Item.WidthType = C1.Win.C1Editor.UICustomization.SizeType.Pixel Then
            _nudWidthValue.Maximum = 5000
        Else
            _nudWidthValue.Maximum = 200
            _nudWidthValue.Value = 100
            Item.WidthValue = 100
        End If
    End Sub

    ' changes the object height type
    Private Sub _cbxHeightType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Item.HeightType = CType(_cbxHeightType.SelectedIndex, C1.Win.C1Editor.UICustomization.SizeType)
        If Item.HeightType = C1.Win.C1Editor.UICustomization.SizeType.Pixel Then
            _nudHeightValue.Maximum = 5000
        Else
            _nudHeightValue.Maximum = 200
            _nudHeightValue.Value = 100
            Item.HeightValue = 100
        End If

    End Sub

#End Region

#Region "IFlashMovieItemDialog Members"

    ''' <summary>
    ''' Binds data from the item to GUI controls on the form.
    ''' Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
    ''' to read data from the item and write it back.
    ''' </summary>
    ''' <param name="item">The item to be bound to the GUI controls.</param>
    Private Sub IFlashMovieItemDialog_BindData(ByVal item__1 As XHTMLFlashMovieItem) Implements IFlashMovieItemDialog.BindData
        _item = item__1
        _cbxWidthType.SelectedIndex = CInt(Item.WidthType)
        _cbxHeightType.SelectedIndex = CInt(Item.HeightType)
        _nudWidthValue.DataBindings.Add("Value", Item, "WidthValue")
        _nudHeightValue.DataBindings.Add("Value", Item, "HeightValue")
        _tbData.DataBindings.Add("Text", Item, "Data")
        _chbAutoplay.DataBindings.Add("Checked", Item, "Autoplay")
        _chbLoop.DataBindings.Add("Checked", Item, "Loop")
        _chkWidth.DataBindings.Add("Checked", Item, "UseWidth")
        _chkHeight.DataBindings.Add("Checked", Item, "UseHeight")
        _tbTitle.DataBindings.Add("Text", Item, "Title")

        SetButtonState(Me, EventArgs.Empty)
    End Sub

    ''' <summary>
    ''' Shows the form with the specified owner to the user.
    ''' </summary>
    ''' <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
    ''' the top-level window that will own this form.</param>
    ''' <returns>True if the form was displayed successfully and the item was changed.</returns>
    Private Function IFlashMovieItemDialog_Show(ByVal owner As IWin32Window) As Boolean Implements IFlashMovieItemDialog.Show
        Return Show(owner)
    End Function
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

#End Region
End Class

