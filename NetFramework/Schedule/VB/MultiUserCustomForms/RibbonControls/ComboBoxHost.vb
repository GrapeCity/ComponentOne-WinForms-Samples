Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports System.Reflection
Imports System.Data
Imports C1.Win.C1Ribbon

<System.ComponentModel.DefaultBindingProperty("SelectedValue")> _
Public Class ComboBoxHost
    Inherits C1.Win.C1Ribbon.RibbonControlHost
    Implements IBindableComponent

    Public Sub New()
        Me.New(New System.Windows.Forms.ComboBox())
    End Sub

    Public Sub New(ByVal box)
        MyBase.New(box)
    End Sub

    <Browsable(False)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property ComboBox() As ComboBox
        Get
            Return CType(Control, ComboBox)
        End Get
    End Property

#Region "** object model"

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property BindingContext() As BindingContext Implements IBindableComponent.BindingContext
        Get
            Return ComboBox.BindingContext
        End Get

        Set(ByVal value As BindingContext)
            ComboBox.BindingContext = value
        End Set
    End Property

    <Category("Data")> _
    Public ReadOnly Property DataBindings() As ControlBindingsCollection Implements IBindableComponent.DataBindings
        Get
            Return ComboBox.DataBindings
        End Get
    End Property

    <Category("Data"), Browsable(False), Bindable(True), _
    DefaultValue(CStr(Nothing)), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property SelectedValue() As Object
        Get
            Return ComboBox.SelectedValue
        End Get
        Set(ByVal value As Object)
            ComboBox.SelectedValue = value
        End Set
    End Property

    <Category("Data"), Browsable(False), Bindable(True), _
    DefaultValue(CStr(Nothing)), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property SelectedItem() As Object
        Get
            Return ComboBox.SelectedItem
        End Get
        Set(ByVal value As Object)
            ComboBox.SelectedItem = value
        End Set
    End Property

    <Category("Data"), Description("Indicates the list that this control will use to get its items."), _
    AttributeProvider("System.ComponentModel.IListSource"), _
    DefaultValue(CStr(Nothing)), _
    RefreshProperties(RefreshProperties.Repaint)> _
    Public Property DataSource() As Object
        Get
            Return ComboBox.DataSource
        End Get
        Set(ByVal value As Object)
            ComboBox.DataSource = value
        End Set
    End Property

    <Category("Data"), Description("Indicates the property to display for the items in the control."), _
    Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", "System.Drawing.Design.UITypeEditor"), _
    TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design"), _
    DefaultValue("")> _
    Public Property DisplayMember() As String
        Get
            Return ComboBox.DisplayMember
        End Get

        Set(ByVal value As String)
            ComboBox.DisplayMember = value
        End Set
    End Property

    <Category("Data"), Description("Indicates the property to use as the actual value for the items in the control."), _
    Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", "System.Drawing.Design.UITypeEditor"), _
    TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design"), _
    DefaultValue("")> _
    Public Property ValueMember() As String
        Get
            Return ComboBox.ValueMember
        End Get

        Set(ByVal value As String)
            ComboBox.ValueMember = value
        End Set
    End Property

    <Category("Data"), Description("Gets the collection of items in this ComboBox.")> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    <Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design", GetType(UITypeEditor))> _
    Public ReadOnly Property Items() As ComboBox.ObjectCollection
        Get
            Return ComboBox.Items
        End Get
    End Property

    <Category("Behavior"), Description("Indicates whether the code or the operating system will handle drawing of elements in the list.")> _
    <DefaultValue(DrawMode.Normal)> _
    Public Property DrawMode() As DrawMode
        Get
            Return ComboBox.DrawMode
        End Get

        Set(ByVal value As DrawMode)
            ComboBox.DrawMode = value
        End Set
    End Property

    <Category("Appearance"), Description("Controls the appearance and functionality of the ComboBox.")> _
    <DefaultValue(ComboBoxStyle.DropDown)> _
    Public Property DropDownStyle() As ComboBoxStyle
        Get
            Return ComboBox.DropDownStyle
        End Get

        Set(ByVal value As ComboBoxStyle)
            ComboBox.DropDownStyle = value
        End Set
    End Property

    <Category("Appearance"), Description("Occurs when a visual aspect of an owner-drawn ComboBox changes.")> _
    Public Event DrawItem As System.Windows.Forms.DrawItemEventHandler
    ''' <summary>
    ''' Raises the <see cref="DrawItem"/> event.
    ''' </summary>
    Protected Overridable Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        RaiseEvent DrawItem(ComboBox, e)
    End Sub

    <Category("Property Changed")> _
    Public Event SelectedValueChanged As EventHandler
    ''' <summary>
    ''' Raises the <see cref="SelectedValueChanged"/> event.
    ''' </summary>
    Protected Overridable Sub OnSelectedValueChanged(ByVal e As EventArgs)
        RaiseEvent SelectedValueChanged(ComboBox, e)
    End Sub

#End Region

#Region "** methods"

    Protected Overrides Sub OnSubscribeControlEvents(ByVal ctrl As Control)
        MyBase.OnSubscribeControlEvents(ctrl)
        AddHandler CType(ctrl, ComboBox).DrawItem, AddressOf HandleDrawItem
        AddHandler CType(ctrl, ComboBox).SelectedValueChanged, AddressOf HandleSelectedValueChanged
    End Sub

    Protected Overrides Sub OnUnsubscribeControlEvents(ByVal ctrl As Control)
        MyBase.OnUnsubscribeControlEvents(ctrl)
        RemoveHandler CType(ctrl, ComboBox).DrawItem, AddressOf HandleDrawItem
        RemoveHandler CType(ctrl, ComboBox).SelectedValueChanged, AddressOf HandleSelectedValueChanged
    End Sub

    Private Sub HandleDrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Me.OnDrawItem(e)
    End Sub

    Private Sub HandleSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnSelectedValueChanged(e)
    End Sub

#End Region

End Class
