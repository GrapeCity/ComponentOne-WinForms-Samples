Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports System.Configuration
Imports C1.Win.C1Editor.UICustomization

''' <summary>
''' Represents a form for editing table cell properties.
''' </summary>
Partial Friend Class CellEditorForm
    Inherits BaseEditorForm
    Implements ICellItemDialog
#Region "ctors"

    Public Sub New()
        InitializeComponent()

        LoadAlignmentHorizontalFormat(_cbxHorizontalAlignment)
        LoadAlignmentVerticalFormat(_cbxVerticalAlignment)

        AddHandler _cbxHorizontalAlignment.SelectedIndexChanged, New EventHandler(AddressOf _cbxHorizontalAlignment_SelectedIndexChanged)
        AddHandler _cbxVerticalAlignment.SelectedIndexChanged, New EventHandler(AddressOf _cbxVerticalAlignment_SelectedIndexChanged)
        AddHandler _nudColSpan.Validated, New EventHandler(AddressOf ValidateNumber)
        AddHandler _nudRowSpan.Validated, New EventHandler(AddressOf ValidateNumber)

        _nudRowSpan.Minimum = 1
        _nudColSpan.Minimum = 1
    End Sub

#End Region

#Region "implementation"

    Private ReadOnly Property Item() As XHTMLCellItem
        Get
            Return TryCast(_item, XHTMLCellItem)
        End Get
    End Property

#End Region

#Region "#event handlers"

    ' changes the cell vertical alignment type
    Private Sub _cbxVerticalAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Item IsNot Nothing Then
            Item.VerticalAlignment = CType(_cbxVerticalAlignment.SelectedIndex, C1.Win.C1Editor.UICustomization.VerticalAlignment)
        End If
    End Sub

    ' changes the cell horizontal alignment type
    Private Sub _cbxHorizontalAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Item IsNot Nothing Then
            Item.HorizontalAlignment = CType(_cbxHorizontalAlignment.SelectedIndex, C1.Win.C1Editor.UICustomization.HorizontalAlignment)
        End If
    End Sub

#End Region

#Region "ICellItemDialog Members"

    ''' <summary>
    ''' Binds data from the item to GUI controls on the form.
    ''' Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
    ''' to read data from the item and write it back.
    ''' </summary>
    ''' <param name="item">The item to be bound to the GUI controls.</param>
    Private Sub ICellItemDialog_BindData(ByVal item__1 As XHTMLCellItem) Implements ICellItemDialog.BindData
        _item = item__1
        _cbxVerticalAlignment.SelectedIndex = CInt(Item.VerticalAlignment)
        _cbxHorizontalAlignment.SelectedIndex = CInt(Item.HorizontalAlignment)
        _nudColSpan.DataBindings.Add("Value", Item, "ColSpan")
        _nudRowSpan.DataBindings.Add("Value", Item, "RowSpan")
        _chbHeader.DataBindings.Add("Checked", Item, "IsHeader")
    End Sub

    ''' <summary>
    ''' Shows the form with the specified owner to the user.
    ''' </summary>
    ''' <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
    ''' the top-level window that will own this form.</param>
    ''' <returns>True if the form was displayed successfully and the item was changed.</returns>
    Private Function ICellItemDialog_Show(ByVal owner As IWin32Window) As Boolean Implements ICellItemDialog.Show
        Return Show(owner)
    End Function

#End Region
End Class

