Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Configuration
Imports C1.Win.C1Editor.UICustomization

''' <summary>
''' Represents a form for editing table properties.
''' </summary>
Partial Friend Class TableEditorForm
    Inherits BaseEditorForm
    Implements ITableItemDialog
#Region "ctors"

    Public Sub New()
        InitializeComponent()

        AddHandler _chkWidth.CheckedChanged, New EventHandler(AddressOf _chkWidth_CheckedChanged)
        AddHandler _cbxWidthType.SelectedIndexChanged, New EventHandler(AddressOf _cbxWidthType_SelectedIndexChanged)
        AddHandler _nudColumnCount.Validated, New EventHandler(AddressOf ValidateNumber)
        AddHandler _nudRowCount.Validated, New EventHandler(AddressOf ValidateNumber)
        AddHandler _nudCellPadding.Validated, New EventHandler(AddressOf ValidateNumber)
        AddHandler _nudCellSpacing.Validated, New EventHandler(AddressOf ValidateNumber)
        AddHandler _tbWidthValue.Validated, New EventHandler(AddressOf ValidateNumber)
        AddHandler _nudBorder.Validated, New EventHandler(AddressOf ValidateNumber)
        LoadSizeFormat(_cbxWidthType)
    End Sub

#End Region

#Region "implementation"

    Private ReadOnly Property Item() As XHTMLTableItem
        Get
            Return TryCast(_item, XHTMLTableItem)
        End Get
    End Property

#End Region

#Region "event handlers"

    Protected Overloads Overrides Sub OnItemPropertiesChanged()
        'don't allow decrease table size in the edit mode
        If _item IsNot Nothing AndAlso _item.IsEditMode Then
            _nudRowCount.Minimum = Item.RowCount
        Else
            _nudRowCount.Minimum = 1
        End If

        If _item IsNot Nothing AndAlso _item.IsEditMode Then
            _nudColumnCount.Minimum = Item.ColumnCount
        Else
            _nudColumnCount.Minimum = 1
        End If
    End Sub

    ' enables/disables controls for setting table width
    Private Sub _chkWidth_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        _tbWidthValue.Enabled = _chkWidth.Checked
        _cbxWidthType.Enabled = _chkWidth.Checked
    End Sub

    ' changes the table width type
    Private Sub _cbxWidthType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Item.WidthType = CType(_cbxWidthType.SelectedIndex, C1.Win.C1Editor.UICustomization.SizeType)
    End Sub

#End Region

#Region "ITableItemDialog Members"

    ''' <summary>
    ''' Binds data from the item to GUI controls on the form.
    ''' Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
    ''' to read data from the item and write it back.
    ''' </summary>
    ''' <param name="item">The item to be bound to the GUI controls.</param>
    Private Sub ITableItemDialog_BindData(ByVal item__1 As XHTMLTableItem) Implements ITableItemDialog.BindData
        _item = item__1
        _cbxWidthType.SelectedIndex = CInt(Item.WidthType)
        _nudRowCount.DataBindings.Add("Value", Item, "RowCount")
        _nudColumnCount.DataBindings.Add("Value", Item, "ColumnCount")
        _tbWidthValue.DataBindings.Add("Value", Item, "WidthValue")
        _nudCellPadding.DataBindings.Add("Value", Item, "CellPadding")
        _nudCellSpacing.DataBindings.Add("Value", Item, "CellSpacing")
        _nudBorder.DataBindings.Add("Value", Item, "Border")
        _chkWidth.DataBindings.Add("Checked", Item, "UseWidth")
        _tbCaption.DataBindings.Add("Text", Item, "Caption")
        _tbSummary.DataBindings.Add("Text", Item, "Summary")

        OnItemPropertiesChanged()
    End Sub

    ''' <summary>
    ''' Shows the form with the specified owner to the user.
    ''' </summary>
    ''' <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
    ''' the top-level window that will own this form.</param>
    ''' <returns>True if the form was displayed successfully and the item was changed.</returns>
    Private Function ITableItemDialog_Show(ByVal owner As IWin32Window) As Boolean Implements ITableItemDialog.Show
        Return Show(owner)
    End Function

#End Region
End Class

