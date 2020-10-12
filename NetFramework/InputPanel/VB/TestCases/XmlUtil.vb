Imports System.Xml
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

''' <summary>
''' Utility class for reading Xml.
''' </summary>
Friend Class XmlUtil

    Shared Function Read(ByVal nd As XmlNode, ByVal attName As String, ByVal defVal As Boolean) As Boolean
        Dim att As XmlAttribute = nd.Attributes(attName)
        If att IsNot Nothing Then
            Return Boolean.Parse(att.Value)
        End If
        Return defVal
    End Function

    Shared Function Read(ByVal nd As XmlNode, ByVal attName As String, ByVal defVal As Int32) As Int32
        Dim att As XmlAttribute = nd.Attributes(attName)
        If att IsNot Nothing Then
            Return Int32.Parse(att.Value)
        End If
        Return defVal
    End Function

    Shared Function Read(ByVal nd As XmlNode, ByVal attName As String, ByVal defVal As String) As String
        Dim att As XmlAttribute = nd.Attributes(attName)
        If att IsNot Nothing Then
            Return att.Value
        End If
        Return defVal
    End Function

    Shared Function ReadImage(ByVal nd As XmlNode, ByVal prefix As String) As Image

        ' read image from file
        Dim att As XmlAttribute = nd.Attributes(prefix + "File")
        If att IsNot Nothing Then
            Dim fileName As String = att.Value
            If Not Path.IsPathRooted(fileName) And nd.BaseURI.Length > 0 Then
                Dim path As String = System.IO.Path.GetDirectoryName(nd.BaseURI)
                If path.StartsWith("file:\\") Then
                    path = path.Substring(6)
                End If
                fileName = System.IO.Path.Combine(path, fileName)
            End If
            If File.Exists(fileName) Then
                Return Image.FromFile(fileName)
            End If
        End If

        ' read image from base64 string
        att = nd.Attributes(prefix + "Base64")
        If att IsNot Nothing Then
            Dim buf() As Byte = Convert.FromBase64String(att.Value)
            Dim ms As MemoryStream = New MemoryStream(buf)
            Dim bf As BinaryFormatter = New BinaryFormatter()
            Return CType(bf.Deserialize(ms), Image)
        End If

        ' no image data in node
        Return Nothing
    End Function

End Class
