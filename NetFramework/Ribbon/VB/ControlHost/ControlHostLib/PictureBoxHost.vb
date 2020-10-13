Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Windows.Forms
Imports System.Xml
Imports C1.Win.C1Ribbon

''' <summary>
''' The Ribbon element that contains a PictureBox.
''' </summary>
Public Class PictureBoxHost
    Inherits RibbonControlHost

    Public Const XmlNodeName As String = "pictureBoxHost"

    ''' <summary>
    ''' Creates the PictureBox control and its host element.
    ''' </summary>
    Public Sub New()
        MyBase.New(New PictureBox())
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
    ''' Gets the hosted PictureBox control.
    ''' </summary>
    <Browsable(False)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property PictureBox() As PictureBox
        Get
            Return CType(Control, PictureBox)
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets the image that the PictureBox displays.
    ''' </summary>
    <Category("Appearance")> _
    <Description("Gets or sets the image that the PictureBox displays.")> _
    Public Property Image() As Image
        Get
            Return PictureBox.Image
        End Get
        Set(ByVal value As Image)
            PictureBox.Image = value
        End Set
    End Property

    ''' <summary>
    ''' This property is not applicable to the PictureBox.
    ''' </summary>
    <Browsable(False)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
        End Set
    End Property

    Protected Overrides Sub LoadControlHostProperties(ByVal node As XmlNode)
        MyBase.LoadControlHostProperties(node)
        Image = ReadImage(node, "image")
    End Sub

    Protected Overrides Sub SaveControlHostProperties(ByVal writer As XmlWriter)
        MyBase.SaveControlHostProperties(writer)
        If Image IsNot Nothing Then
            WriteImage(writer, "image", Image)
        End If
    End Sub

    Private Shared Function ReadImage(ByVal node As XmlNode, ByVal prefix As String) As Image
        Dim att As XmlAttribute = node.Attributes(prefix & "Base64")
        If att IsNot Nothing Then
            Dim buf As Byte() = Convert.FromBase64String(att.Value)
            Dim ms As MemoryStream = New MemoryStream(buf)
            Dim bf As BinaryFormatter = New BinaryFormatter()
            Return TryCast(bf.Deserialize(ms), Image)
        End If

        Return Nothing
    End Function

    Private Shared Sub WriteImage(ByVal writer As XmlWriter, ByVal prefix As String, ByVal image As Image)
        If image IsNot Nothing Then
            Dim ms As MemoryStream = New MemoryStream()
            Dim bf As BinaryFormatter = New BinaryFormatter()
            bf.Serialize(ms, image)
            Dim base64 As String = Convert.ToBase64String(ms.GetBuffer(), 0, CInt(ms.Length))
            writer.WriteAttributeString(prefix & "Base64", base64)
        End If
    End Sub

End Class
