Imports C1.Win.C1FlexGrid
Imports System
Imports System.Xml

Namespace AdvancedFiltering
    Friend Class InheritedFilterNewMenu
        Inherits ColumnFilter
        Public WeekdayFilter As WeekdayFilter = New WeekdayFilter()

        Public Overrides Function GetEditor() As IC1ColumnFilterEditor
            Return New InheritedFilterEditorNewMenu()
        End Function

        Public Overrides Sub Reset()
            MyBase.Reset()
            WeekdayFilter.Reset()
        End Sub

        Public Overrides Function Apply(ByVal value As Object) As Boolean
            Return MyBase.Apply(value) AndAlso WeekdayFilter.Apply(value)
        End Function

        Public Overrides ReadOnly Property IsActive As Boolean
            Get
                Return MyBase.IsActive OrElse WeekdayFilter.IsActive
            End Get
        End Property

        Public Overrides Sub WriteXmlDefinition(ByVal xw As XmlWriter)
            MyBase.WriteXmlDefinition(xw)

            If WeekdayFilter.IsActive Then
                xw.WriteAttributeString("ActiveFilter", WeekdayFilter.[GetType]().Name)
                xw.WriteStartElement(WeekdayFilter.[GetType]().Name)
                xw.WriteStartElement("Monday")
                xw.WriteAttributeString("Value", WeekdayFilter.Monday.ToString())
                xw.WriteEndElement()
                xw.WriteStartElement("Tuesday")
                xw.WriteAttributeString("Value", WeekdayFilter.Tuesday.ToString())
                xw.WriteEndElement()
                xw.WriteStartElement("Wednesday")
                xw.WriteAttributeString("Value", WeekdayFilter.Wednesday.ToString())
                xw.WriteEndElement()
                xw.WriteStartElement("Thursday")
                xw.WriteAttributeString("Value", WeekdayFilter.Thursday.ToString())
                xw.WriteEndElement()
                xw.WriteStartElement("Friday")
                xw.WriteAttributeString("Value", WeekdayFilter.Friday.ToString())
                xw.WriteEndElement()
                xw.WriteStartElement("Saturday")
                xw.WriteAttributeString("Value", WeekdayFilter.Saturday.ToString())
                xw.WriteEndElement()
                xw.WriteStartElement("Sunday")
                xw.WriteAttributeString("Value", WeekdayFilter.Sunday.ToString())
                xw.WriteEndElement()
                xw.WriteEndElement()
            End If
        End Sub

        Public Overrides Sub ReadXmlDefinition(ByVal xr As XmlReader)
            ReadXmlDefinition(xr, GetType(DateTime))

            While xr.Read()
                If xr.NodeType = XmlNodeType.Element Then
                    If Equals(xr.Name, "Monday") Then
                        Boolean.TryParse(xr.GetAttribute("Value"), WeekdayFilter.Monday)
                    ElseIf Equals(xr.Name, "Tuesday") Then
                        Boolean.TryParse(xr.GetAttribute("Value"), WeekdayFilter.Tuesday)
                    ElseIf Equals(xr.Name, "Wednesday") Then
                        Boolean.TryParse(xr.GetAttribute("Value"), WeekdayFilter.Wednesday)
                    ElseIf Equals(xr.Name, "Thursday") Then
                        Boolean.TryParse(xr.GetAttribute("Value"), WeekdayFilter.Thursday)
                    ElseIf Equals(xr.Name, "Friday") Then
                        Boolean.TryParse(xr.GetAttribute("Value"), WeekdayFilter.Friday)
                    ElseIf Equals(xr.Name, "Saturday") Then
                        Boolean.TryParse(xr.GetAttribute("Value"), WeekdayFilter.Saturday)
                    ElseIf Equals(xr.Name, "Sunday") Then
                        Boolean.TryParse(xr.GetAttribute("Value"), WeekdayFilter.Sunday)
                    End If
                End If
            End While
        End Sub
    End Class
End Namespace
