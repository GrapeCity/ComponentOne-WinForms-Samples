Public Class Geolocation

    'use the following as a template
    'http://maps.google.com/maps/geo?q=149+Harold+Road,+Hastings,+UK&output=csv


    ' Fields...
    ' Properties...

    Public Property Street() As String
    
    Public Property GeoLocationCode() As String
    
    Public Property Longitude() As String

    Public Property Latitude() As String

    Public Property Country() As String
    
    Public Property Town() As String

    Public Property Street3() As String

    Public Property Street2() As String

    Public Property Street1() As String

    Public Property HouseNumber() As String

    Public Property PostCode As String

    Public Property CompiledStreet As String
    

    Public Sub PrepareStreetName()
        Dim s1 As Boolean = False
        Dim s2 As Boolean = False
        Dim s3 As Boolean = False
        Dim strArray As String()
        Dim ns As String = Street
        strArray = ns.Split(" ")
        For i As Integer = 0 To strArray.Length - 1
            If Not s3 And Not s2 And Not s1 Then
                Street1 = strArray(i)
                s1 = True
            ElseIf Not s3 And Not s2 Then
                Street2 = strArray(i)
                s2 = True
            Else
                Street3 = strArray(i)
                s3 = True
            End If
        Next
    End Sub

    Private Function CompileCompletedStreet() As String

        'just get house number if that's all there is
        If HouseNumber <> String.Empty And Street1 = String.Empty Then
            Return HouseNumber
        End If

        If HouseNumber <> String.Empty Then
            If Street3 <> String.Empty Then
                Return String.Format("{0}+{1}+{2}+{3}", HouseNumber, Street1, Street2, Street3)
            ElseIf Street2 <> String.Empty Then
                Return String.Format("{0}+{1}+{2}", HouseNumber, Street1, Street2)
            Else
                Return String.Format("{0}+{1}", HouseNumber, Street1)
            End If
        Else
            If Street3 <> String.Empty Then
                Return String.Format("{0}+{1}+{2}", Street1, Street2, Street3)
            ElseIf Street2 <> String.Empty Then
                Return String.Format("{0}+{1}", Street1, Street2)
            Else
                Return Street1
            End If
       
        End If
    End Function

    Private Function CompileRestOfAddress() As String
        If Country <> String.Empty Then
            If PostCode <> String.Empty Then
                If Town <> String.Empty Then
                    Return String.Format("+{0},+{1},+{2}", Town, PostCode, Country)
                End If
                Return String.Format("+{0},+{1}", PostCode, Country)
            End If
            Return "+" & Country
        End If
    End Function


    Public Function CreateUriString() As String

        ' this is an example of what we are trying to build
        '"http://maps.google.com/maps/geo?q=149+Harold+Road,+Hastings,+UK&output=csv"
        ' 
        ' 

        Const part1 As String = "http://maps.google.com/maps/geo?q="
        Const part2 As String = "&output=csv"

        Dim uristring As String = String.Format("{0}{1},{2}{3}", part1, CompileCompletedStreet(), CompileRestOfAddress(), part2)
        Return uristring

    End Function

    Public Function CreateMapUriString() As String
        'http://maps.googleapis.com/maps/api/staticmap?center=63.259591,-144.667969&zoom=6&size=400x400\
        '&markers=color:blue%7Clabel:S%7C62.107733,-145.541936&markers=size:tiny%7Ccolor:green%7CDelta+Junction,AK\
        '&markers=size:mid%7Ccolor:0xFFFF00%7Clabel:C%7CTok,AK&sensor=false"
        ' 

        Const part1 As String = "http://maps.googleapis.com/maps/api/staticmap?center="
        Const part2 As String = "&zoom=16&size=400x400&markers=color:red%7Clabel:X%7C"
        Const part3 As String = "&sensor=false"

        Dim completeAddress As String = String.Format("{0},{1}", CompileCompletedStreet(), CompileRestOfAddress())
        Dim uristring As String = part1 & completeAddress & part2 & completeAddress & part3
        Return uristring
    End Function

    Public Function CreateGeoLocationCode() As String
        Return String.Format("geo:{0},{1}", Latitude, Longitude)
    End Function

End Class
