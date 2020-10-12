Imports C1.Framework
Imports C1.Win.TreeView

Public Class CategoryCustomNode
    Inherits CustomContentPresenter
    ' level 0
    Private _name As TextElement
    Private _description As TextElement
    Private _img As ImageElement
    Private _rw As RowPanel
    ' level 1
    Private _product As TextElement

    Public Sub New()
        ' level 0
        ' init text elements
        ' name
        _name = New TextElement()
        _name.Style = New Style()
        ' description
        _description = New TextElement()
        _description.Style = New Style()
        _description.Width = 120
        ' init image element
        _img = New ImageElement()
        _img.Style = New Style()
        _img.Size = New Size(70, 50)
        ' init a grid for text elements
        Dim cp = New ColumnPanel()
        cp.Children.Add(_name)
        cp.Children.Add(_description)
        ' init panel for image
        _rw = New RowPanel()
        _rw.Children.Add(cp)
        _rw.Children.Add(_img)
        _rw.Style = New Style()
        _rw.Style.VerticalAlignment = Alignment.Center
        ' level 1
        _product = New TextElement()
        _product.Style = New Style()
    End Sub

    Public Overrides ReadOnly Property ToolTipText() As String
        Get
            Return _name.Text
        End Get
    End Property

    Public Overrides Sub SetStyle(styles As TreeNodeCellStyles)
        MyBase.SetStyle(styles)
        ' level 0
        ' name 
        _name.Style.Margins = New Thickness(1)
        _name.Style.Font = New Font("Calibri", 10, FontStyle.Bold)
        ' description
        _description.Style.Margins = New Thickness(1)
        _description.Style.Font = New Font("Calibri", 9, FontStyle.Italic)
        _description.Style.WordWrap = True
        ' img
        _img.Style.ImageScaling = ImageScaling.Scale
        _img.Style.ImageAlignment = ImageAlignment.CenterCenter
        ' level 1
        _product.Style.Font = New Font("Calibri", 10, FontStyle.Bold)
        _product.Style.Margins = New Thickness(2)
        _product.Style.HorizontalAlignment = Alignment.Center
        _product.Style.VerticalAlignment = Alignment.Center
    End Sub

    Public Overrides Sub SetValue(value As Object)
        If Node.Level = 0 Then
            Dim row = DirectCast(Node.GetValue(), DataSet1.CategoriesRow)
            _name.Text = row.CategoryName
            _description.Text = row.Description
            Dim converter = New ImageConverter()
            If _img.Image IsNot Nothing Then
                _img.Image.Dispose()
                _img.Image = Nothing
            End If
            _img.Image = DirectCast(converter.ConvertFrom(row.Picture), Image)
            ' set root panel
            Child = _rw
        Else
            _product.Text = value.ToString()
            ' set root element
            Child = _product
        End If
    End Sub

    Public Overrides Sub SetFormat(format As String)
    End Sub
End Class

Public Class ProductCustomNode
    Inherits CustomContentPresenter
    ' level 0
    Private _count As TextElement
    ' level 1
    Private _quantityPerUnit As TextElement
    Private _unitPrice As TextElement
    Private _unitInStock As TextElement
    Private _unitsOnOrder As TextElement
    Private _reorderLevel As TextElement
    Private _gp As GridPanel
    Private _eStyle As Style

    Public Sub New()
        ' level 0
        ' count in category
        _count = New TextElement()
        _count.Style = New Style()
        _count.Style.Margins = New Thickness(2)
        ' level 1
        ' lable style
        Dim lStyle = New Style()
        lStyle.HorizontalAlignment = Alignment.Far
        lStyle.Margins = New Thickness(1)
        lStyle.Font = New Font("Calibri", 9, FontStyle.Regular)
        ' elements style
        _eStyle = New Style()
        _eStyle.Margins = New Thickness(1)
        _eStyle.Font = New Font("Calibri", 9, FontStyle.Regular)
        ' init elements
        _quantityPerUnit = New TextElement(_eStyle.Clone())
        _unitPrice = New TextElement(_eStyle.Clone())
        _unitInStock = New TextElement(_eStyle.Clone())
        _unitsOnOrder = New TextElement(_eStyle.Clone())
        _reorderLevel = New TextElement(_eStyle.Clone())
        ' init a grid for text elements
        _gp = New GridPanel()
        _gp.Columns.Add()
        ' labels
        _gp.Columns(0).Width = 100
        _gp.Columns.Add()
        ' text
        _gp.Columns(1).Width = 120

        _gp.Rows.Add()
        ' ReorderLevel
        _gp(0, 0).Element = New TextElement(lStyle, "Reorder level:")
        _gp(0, 1).Element = _reorderLevel
        _gp.Rows.Add()
        ' UnitPrice
        _gp(1, 0).Element = New TextElement(lStyle, "Unit price:")
        _gp(1, 1).Element = _unitPrice
        _gp.Rows.Add()
        ' QuantityPerUnit
        _gp(2, 0).Element = New TextElement(lStyle, "Quantity per unit:")
        _gp(2, 1).Element = _quantityPerUnit

        _gp.Columns.Add()
        ' labels
        _gp.Columns(2).Width = 100
        _gp.Columns.Add()
        ' text
        ' UnitsInStock
        _gp(0, 2).Element = New TextElement(lStyle, "Units in stock:")
        _gp(0, 3).Element = _unitInStock
        ' UnitsOnOrder
        _gp(1, 2).Element = New TextElement(lStyle, "Units on order:")

        _gp(1, 3).Element = _unitsOnOrder
    End Sub

    Public Overrides ReadOnly Property ToolTipText() As String
        Get
            Return String.Empty


        End Get
    End Property

    Public Overrides Sub SetStyle(styles As TreeNodeCellStyles)
        MyBase.SetStyle(styles)
        ' level 0
        _count.Style.HorizontalAlignment = Alignment.Center
        _count.Style.VerticalAlignment = Alignment.Center
        _count.Style.Font = New Font("Calibri", 11, FontStyle.Bold)
        ' level 1
        _unitPrice.Style.Font = New Font(_eStyle.Font, FontStyle.Bold)
        If _unitInStock.Text = "0" Then
            _unitInStock.Style.ForeColor = Color.Red
            _unitInStock.Style.Font = New Font(_eStyle.Font, FontStyle.Bold)
        End If
        If _unitsOnOrder.Text = "0" Then
            _unitsOnOrder.Style.ForeColor = Color.Red
            _unitsOnOrder.Style.Font = New Font(_eStyle.Font, FontStyle.Bold)
        End If
    End Sub

    Public Overrides Sub SetValue(value As Object)
        If Node.Level = 0 Then
            Dim count = If(Node.HasChildren, Node.Nodes.Count, 0)
            _count.Text = count.ToString()
            Child = _count
        Else
            Dim row = DirectCast(Node.GetValue(), DataSet1.ProductsRow)
            _quantityPerUnit.Text = row.QuantityPerUnit
            _unitPrice.Text = row.UnitPrice.ToString("C")
            _unitInStock.Text = row.UnitsInStock.ToString()
            _unitsOnOrder.Text = row.UnitsOnOrder.ToString()
            _reorderLevel.Text = row.ReorderLevel.ToString()
            Child = _gp
        End If
    End Sub

    Public Overrides Sub SetFormat(format As String)

    End Sub
End Class

