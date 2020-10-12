Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Configuration
Imports C1.Win.C1Editor.UICustomization

''' <summary>
''' Represents a form for editing table column properties.
''' </summary>
Partial Friend Class ColumnEditorForm
    Inherits BaseEditorForm
    Implements IColumnItemDialog
#Region "ctors"

    Public Sub New()
        InitializeComponent()

        LoadSizeFormat(_cbxWidthType)
        LoadAlignmentHorizontalFormat(_cbxHorizontalAlignment)
        LoadAlignmentVerticalFormat(_cbxVerticalAlignment)

        AddHandler _cbxHorizontalAlignment.SelectedIndexChanged, New EventHandler(AddressOf _cbxHorizontalAlignment_SelectedIndexChanged)
        AddHandler _cbxVerticalAlignment.SelectedIndexChanged, New EventHandler(AddressOf _cbxVerticalAlignment_SelectedIndexChanged)
        AddHandler _chkWidth.CheckedChanged, New EventHandler(AddressOf _chkWidth_CheckedChanged)
        AddHandler _cbxWidthType.SelectedIndexChanged, New EventHandler(AddressOf _cbxWidthType_SelectedIndexChanged)
        AddHandler _nudSpan.Validated, New EventHandler(AddressOf ValidateNumber)
        AddHandler _tbWidthValue.Validated, New EventHandler(AddressOf ValidateNumber)

        _nudSpan.Minimum = 1
    End Sub

#End Region

#Region "implementation"

    Private ReadOnly Property Item() As XHTMLColumnItem
        Get
            Return TryCast(_item, XHTMLColumnItem)
        End Get
    End Property

#End Region

#Region "#event handlers"

    ' enables/disables controls for setting column width
    Private Sub _chkWidth_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        _tbWidthValue.Enabled = _chkWidth.Checked
        _cbxWidthType.Enabled = _chkWidth.Checked
    End Sub

    ' changes the column size type
    Private Sub _cbxWidthType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Item.WidthType = CType(_cbxWidthType.SelectedIndex, C1.Win.C1Editor.UICustomization.SizeType)
    End Sub

    ' changes the column vertical alignment type
    Private Sub _cbxVerticalAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Item IsNot Nothing Then
            Item.VerticalAlignment = CType(_cbxVerticalAlignment.SelectedIndex, C1.Win.C1Editor.UICustomization.VerticalAlignment)
        End If
    End Sub

    ' changes the column horizontal alignment type
    Private Sub _cbxHorizontalAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Item IsNot Nothing Then
            Item.HorizontalAlignment = CType(_cbxHorizontalAlignment.SelectedIndex, C1.Win.C1Editor.UICustomization.HorizontalAlignment)
        End If
    End Sub

#End Region

#Region "IColumnItemDialog Members"

    ''' <summary>
    ''' Binds data from the item to GUI controls on the form.
    ''' Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
    ''' to read data from the item and write it back.
    ''' </summary>
    ''' <param name="item">The item to be bound to the GUI controls.</param>
    Private Sub IColumnItemDialog_BindData(ByVal item__1 As XHTMLColumnItem) Implements IColumnItemDialog.BindData
        _item = item__1
        _cbxWidthType.SelectedIndex = CInt(Item.WidthType)
        _cbxVerticalAlignment.SelectedIndex = CInt(Item.VerticalAlignment)
        _cbxHorizontalAlignment.SelectedIndex = CInt(Item.HorizontalAlignment)
        _nudSpan.DataBindings.Add("Value", Item, "Span")
        _tbWidthValue.DataBindings.Add("Value", Item, "WidthValue")
        _chkWidth.DataBindings.Add("Checked", Item, "UseWidth")
    End Sub

    ''' <summary>
    ''' Shows the form with the specified owner to the user.
    ''' </summary>
    ''' <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
    ''' the top-level window that will own this form.</param>
    ''' <returns>True if the form was displayed successfully and the item was changed.</returns>
    Private Function IColumnItemDialog_Show(ByVal owner As IWin32Window) As Boolean Implements IColumnItemDialog.Show
        Return Show(owner)
    End Function

#End Region
End Class

