Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports C1.Win.C1Ribbon

''' <summary>
''' The Ribbon element that contains a CheckedListBox.
''' </summary>
Public Class CheckedListBoxHost
    Inherits RibbonControlHost

    Public Const XmlNodeName As String = "checkedListBoxHost"

    ''' <summary>
    ''' Creates the CheckedListBox control and its host element.
    ''' </summary>
    Public Sub New()
        MyBase.New(New CheckedListBox())
        CheckedListBox.BorderStyle = BorderStyle.None
        CheckedListBox.CheckOnClick = True
    End Sub

    ''' <summary>
    ''' <inheritdoc />
    ''' </summary>
    Public Overrides ReadOnly Property ControlHostNodeName As String
        Get
            Return XmlNodeName
        End Get
    End Property

    ''' <summary>
    ''' Gets the hosted CheckedListBox control.
    ''' </summary>
    <Browsable(False)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property CheckedListBox() As CheckedListBox
        Get
            Return CType(Control, CheckedListBox)
        End Get
    End Property

    ''' <summary>
    ''' Gets the collection of items in this CheckedListBox.
    ''' </summary>
    <Category("Data")> _
    <Description("Gets the collection of items in this CheckedListBox.")> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    <Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design", GetType(UITypeEditor))> _
    Public ReadOnly Property Items() As CheckedListBox.ObjectCollection
        Get
            Return CheckedListBox.Items
        End Get
    End Property

    ''' <summary>
    ''' Occurs when the checked state of an item changes.
    ''' </summary>
    <Category("Behavior")> _
    <Description("Occurs when the checked state of an item changes.")> _
    Public Event ItemCheck As ItemCheckEventHandler
    ''' <summary>
    ''' Raises the <see cref="ItemCheck"/> event.
    ''' </summary>
    Protected Overridable Sub OnItemCheck(ByVal e As ItemCheckEventArgs)
        RaiseEvent ItemCheck(Me, e)
    End Sub

    ''' <summary>
    ''' Returns a value indicating whether the specified item is checked.
    ''' </summary>
    Public Function GetItemChecked(ByVal index As Int32) As Boolean
        Return CheckedListBox.GetItemChecked(index)
    End Function
    ''' <summary>
    ''' Sets the checked state for the item at the specified index.
    ''' </summary>
    Public Sub SetItemChecked(ByVal index As Int32, ByVal value As Boolean)
        CheckedListBox.SetItemChecked(index, value)
    End Sub

    Protected Overrides Sub OnSubscribeControlEvents(ByVal ctrl As Control)
        MyBase.OnSubscribeControlEvents(ctrl)
        AddHandler CType(ctrl, CheckedListBox).ItemCheck, AddressOf HandleItemCheck
    End Sub
    Protected Overrides Sub OnUnsubscribeControlEvents(ByVal ctrl As Control)
        MyBase.OnUnsubscribeControlEvents(ctrl)
        RemoveHandler CType(ctrl, CheckedListBox).ItemCheck, AddressOf HandleItemCheck
    End Sub

    Private Sub HandleItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs)
        Me.OnItemCheck(e)
    End Sub

    Protected Overrides Sub LoadControlHostProperties(ByVal node As XmlNode)
        MyBase.LoadControlHostProperties(node)
        Dim s As String = Read(node, "items", String.Empty)
        If s.Length > 0 Then
            Dim arr As String() = s.Split(";"c)
            For i As Integer = 0 To arr.Length - 1
                Dim a As String = arr(i)
                Items.Add(a.Substring(1), a.StartsWith("1"))
            Next
        End If
    End Sub

    Protected Overrides Sub SaveControlHostProperties(ByVal writer As XmlWriter)
        MyBase.SaveControlHostProperties(writer)
        Dim count As Integer = Items.Count
        If count > 0 Then
            Dim sb As StringBuilder = New StringBuilder()
            For i As Integer = 0 To count - 1
                If i > 0 Then sb.Append(";"c)
                sb.Append(If(GetItemChecked(i), "1"c, "0"c))
                sb.Append(Items(i).ToString())
            Next

            writer.WriteAttributeString("items", sb.ToString())
        End If
    End Sub

    Private Shared Function Read(ByVal node As XmlNode, ByVal attName As String, ByVal defVal As String) As String
        Dim att As XmlAttribute = node.Attributes(attName)
        If att IsNot Nothing Then
            Return att.Value
        End If

        Return defVal
    End Function

End Class
