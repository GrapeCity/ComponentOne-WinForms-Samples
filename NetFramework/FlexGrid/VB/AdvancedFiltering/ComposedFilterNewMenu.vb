Imports System
Imports System.Xml
Imports C1.Win.C1FlexGrid

Namespace AdvancedFiltering
    Friend Class ComposedFilterNewMenu
        Implements IC1ColumnFilter2
        Private _ColumnFilter As ColumnFilter, _WeekdayFilter As WeekdayFilter

        Friend Property ColumnFilter As ColumnFilter
            Get
                Return _ColumnFilter
            End Get
            Private Set(ByVal value As ColumnFilter)
                _ColumnFilter = value
            End Set
        End Property

        Friend Property WeekdayFilter As WeekdayFilter
            Get
                Return _WeekdayFilter
            End Get
            Private Set(ByVal value As WeekdayFilter)
                _WeekdayFilter = value
            End Set
        End Property

        Public Sub New()
            ColumnFilter = New ColumnFilter()
            WeekdayFilter = New WeekdayFilter()
        End Sub

        Public Sub Reset() Implements IC1ColumnFilter2.Reset
            ColumnFilter.Reset()
            WeekdayFilter.Reset()
        End Sub

        Public Function Apply(ByVal value As Object) As Boolean Implements IC1ColumnFilter2.Apply
            Return ColumnFilter.Apply(value) AndAlso WeekdayFilter.Apply(value)
        End Function

        Public Function GetEditor() As IC1ColumnFilterEditor Implements IC1ColumnFilter2.GetEditor
            Return New ComposedFilterEditorNewMenu()
        End Function

        Public ReadOnly Property IsActive As Boolean Implements IC1ColumnFilter2.IsActive
            Get
                Return ColumnFilter.IsActive OrElse WeekdayFilter.IsActive
            End Get
        End Property
        Public Sub WriteXmlDefinition(ByVal xw As XmlWriter) Implements IC1ColumnFilter2.WriteXmlDefinition
            ColumnFilter.WriteXmlDefinition(xw)

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

        Public Sub ReadXmlDefinition(ByVal xr As XmlReader) Implements IC1ColumnFilter2.ReadXmlDefinition
            ColumnFilter.ReadXmlDefinition(xr)

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
