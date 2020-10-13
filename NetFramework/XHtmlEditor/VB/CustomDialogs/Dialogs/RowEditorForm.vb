Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Xml
Imports System.Configuration
Imports C1.Win.C1Editor.UICustomization

''' <summary>
''' Represents a form for editing table row properties.
''' </summary>
Partial Friend Class RowEditorForm
    Inherits BaseEditorForm
    Implements IRowItemDialog
#Region "ctors"

    Public Sub New()
        InitializeComponent()

        LoadAlignmentHorizontalFormat(_cbxHorizontalAlignment)
        LoadAlignmentVerticalFormat(_cbxVerticalAlignment)

        AddHandler _cbxHorizontalAlignment.SelectedIndexChanged, New EventHandler(AddressOf _cbxHorizontalAlignment_SelectedIndexChanged)
        AddHandler _cbxVerticalAlignment.SelectedIndexChanged, New EventHandler(AddressOf _cbxVerticalAlignment_SelectedIndexChanged)
    End Sub

#End Region

#Region "implementation"

    Private ReadOnly Property Item() As XHTMLRowItem
        Get
            Return TryCast(_item, XHTMLRowItem)
        End Get
    End Property

#End Region

#Region "event handlers"

    ' changes the row vertical alignment type
    Private Sub _cbxVerticalAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Item IsNot Nothing Then
            Item.VerticalAlignment = CType(_cbxVerticalAlignment.SelectedIndex, C1.Win.C1Editor.UICustomization.VerticalAlignment)
        End If
    End Sub

    ' changes the row horizontal alignment type
    Private Sub _cbxHorizontalAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Item IsNot Nothing Then
            Item.HorizontalAlignment = CType(_cbxHorizontalAlignment.SelectedIndex, C1.Win.C1Editor.UICustomization.HorizontalAlignment)
        End If
    End Sub

#End Region

#Region "IRowItemDialog Members"

    ''' <summary>
    ''' Binds data from the item to GUI controls on the form.
    ''' Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
    ''' to read data from the item and write it back.
    ''' </summary>
    ''' <param name="item">The item to be bound to the GUI controls.</param>
    Private Sub IRowItemDialog_BindData(ByVal item__1 As XHTMLRowItem) Implements IRowItemDialog.BindData
        _item = item__1
        _cbxVerticalAlignment.DataBindings.Add("SelectedIndex", Item, "VerticalAlignment")
        _cbxHorizontalAlignment.DataBindings.Add("SelectedIndex", Item, "HorizontalAlignment")
    End Sub

    ''' <summary>
    ''' Shows the form with the specified owner to the user.
    ''' </summary>
    ''' <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
    ''' the top-level window that will own this form.</param>
    ''' <returns>True if the form was displayed successfully and the item was changed.</returns>
    Private Function IRowItemDialog_Show(ByVal owner As IWin32Window) As Boolean Implements IRowItemDialog.Show
        Return Show(owner)
    End Function

#End Region
End Class

