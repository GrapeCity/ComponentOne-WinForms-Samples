Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text

Imports C1.C1Preview
Imports C1.C1Preview.Serialization

Public Structure UnitRectangle
    Private _x As Unit
    Private _y As Unit
    Private _width As Unit
    Private _height As Unit

    Public Overrides Function ToString() As String
        Return String.Format("X = {0}; Y = {1}; Width = {2}; Height = {3}", _x, _y, _width, _height)
    End Function

    Public Property X() As Unit
        Get
            Return _x
        End Get
        Set(ByVal value As Unit)
            _x = value
        End Set
    End Property

    Public Property Y() As Unit
        Get
            Return _y
        End Get
        Set(ByVal value As Unit)
            _y = value
        End Set
    End Property

    Public Property Width() As Unit
        Get
            Return _width
        End Get
        Set(ByVal value As Unit)
            _width = value
        End Set
    End Property

    Public Property Height() As Unit
        Get
            Return _height
        End Get
        Set(ByVal value As Unit)
            _height = value
        End Set
    End Property

End Structure

Public Class MeasureInfo
    Private _renderedAreas As UnitRectangle()
    Private _newPage As Boolean
    Private _newColumn As Boolean

    Public Sub New(ByVal renderObject As RenderObject)
        If Not renderObject.HasFragments Then
            Throw New Exception("RenderObject is not resolved.")
        End If

        Dim priorPage As C1Page = Nothing
        _renderedAreas = New UnitRectangle(renderObject.Fragments.Count) {}
        Dim i As Integer
        For i = 0 To renderObject.Fragments.Count - 1
            _renderedAreas(i) = New UnitRectangle()
            _renderedAreas(i).X = New Unit(renderObject.Fragments(i).Bounds.X, renderObject.Document.ResolvedUnit)
            _renderedAreas(i).Y = New Unit(renderObject.Fragments(i).Bounds.Y, renderObject.Document.ResolvedUnit)
            _renderedAreas(i).Width = New Unit(renderObject.Fragments(i).Bounds.Width, renderObject.Document.ResolvedUnit)
            _renderedAreas(i).Height = New Unit(renderObject.Fragments(i).Bounds.Height, renderObject.Document.ResolvedUnit)

            If priorPage Is Nothing Then
                If Not renderObject.Fragments(i).Page.Equals(priorPage) Then
                    _newPage = True
                Else
                    _newColumn = True
                End If
            End If
            priorPage = renderObject.Fragments(i).Page
        Next
    End Sub

    Public Sub New(ByVal renderObject As RenderObject, ByVal size As SizeD, ByVal resolvedUnit As UnitTypeEnum)
        _renderedAreas = New UnitRectangle(1) {}
        _renderedAreas(0).X = New Unit(0, resolvedUnit)
        _renderedAreas(0).Y = New Unit(0, resolvedUnit)
        _renderedAreas(0).Width = New Unit(size.Width, resolvedUnit)
        _renderedAreas(0).Height = New Unit(size.Height, resolvedUnit)
    End Sub

    ''' <summary>
    ''' Returns the latest area on the latest page occupied by the render object. 
    ''' </summary>
    Public ReadOnly Property RenderedArea() As UnitRectangle
        Get
            Return _renderedAreas(_renderedAreas.Length - 1)
        End Get
    End Property

    ''' <summary>
    ''' Returns all areas occupied by the render object.
    ''' </summary>
    Public ReadOnly Property RenderedAreas() As UnitRectangle()
        Get
            Return _renderedAreas
        End Get
    End Property

    ''' <summary>
    ''' Width of last rendered area in the RenderedAreas array.
    ''' </summary>
    Public ReadOnly Property WidthUnit() As Unit
        Get
            Return RenderedArea.Width
        End Get
    End Property

    ''' <summary>
    ''' Width of last rendered area in the RenderedAreas array in
    ''' default document's units, defined by C1PrintDocument.ResolvedUnit property.
    ''' </summary>
    Public ReadOnly Property Width() As Double
        Get
            Return WidthUnit.Value
        End Get
    End Property

    ''' <summary>
    ''' Height of last rendered area in the RenderedAreas array.
    ''' </summary>
    Public ReadOnly Property HeightUnit() As Unit
        Get
            Return RenderedArea.Height
        End Get
    End Property

    ''' <summary>
    ''' Height of last rendered area in the RenderedAreas array in
    ''' default document's units, defined by C1PrintDocument.ResolvedUnit property.
    ''' </summary>
    Public ReadOnly Property Height() As Double
        Get
            Return HeightUnit.Value
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether new page started as a result of rendering
    ''' </summary>
    Public ReadOnly Property NewPage() As Boolean
        Get
            Return _newPage
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether new column started as a result of rendering
    ''' </summary>
    Public ReadOnly Property NewColumn() As Boolean
        Get
            Return _newColumn
        End Get
    End Property
End Class

Public Class C1PrintDocumentWrapper
    Inherits C1PrintDocument
    Private _lastRenderedInfo As MeasureInfo

#Region "RenderXXX methods"

    Public Overloads Function RenderBlock(ByVal ro As RenderObject) As MeasureInfo
        MyBase.RenderBlock(ro)
        _lastRenderedInfo = New MeasureInfo(ro)
        Return _lastRenderedInfo
    End Function

    Public Overloads Function RenderDirect(ByVal x As Unit, ByVal y As Unit, ByVal ro As RenderObject) As MeasureInfo
        MyBase.RenderDirect(x, y, ro)
        _lastRenderedInfo = New MeasureInfo(ro)
        Return _lastRenderedInfo
    End Function

    Public Overloads Function RenderDirect(ByVal x As Unit, ByVal y As Unit, ByVal ro As RenderObject, ByVal width As Unit, ByVal height As Unit) As MeasureInfo
        MyBase.RenderDirect(x, y, ro, width, height)
        _lastRenderedInfo = New MeasureInfo(ro)
        Return _lastRenderedInfo
    End Function

#End Region

#Region "MeasureXXX methods"

    Public Function MeasureObject(ByVal ro As RenderObject, ByVal width As Unit, ByVal height As Unit) As MeasureInfo
        Dim wasAdded As Boolean = ro.Document Is Nothing
        If ro.Document Is Nothing Then
            Body.Children.Add(ro)
        End If

        Dim sz As SizeD = ro.CalcSize(width, height)
        Dim resolvedUnit As UnitTypeEnum = ro.Document.ResolvedUnit

        If wasAdded Then
            Body.Children.Remove(ro)
        End If

        Return New MeasureInfo(ro, sz, resolvedUnit)
    End Function

#End Region

    Public ReadOnly Property LastRenderedInfo() As MeasureInfo
        Get
            Return _lastRenderedInfo
        End Get
    End Property

End Class

