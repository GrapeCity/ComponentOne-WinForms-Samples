Imports C1.Chart
Imports C1.Win.Chart

Namespace ChartAsDataFilter
    Partial Public Class FlexChartFilterView
        Inherits UserControl
#Region "fields"
        Private _selectedIndices As List(Of Integer)
        Private _selecting As Boolean, _showSelectionMode As Boolean = True, _showRangeSlider As Boolean = False
        Private _ptStart As Point = Point.Empty, _ptEnd As Point = Point.Empty
        Private _items As IEnumerable(Of Object)
        Private _selectionMode As SelectionMode = SelectionMode.NormalSelect
        Private _chbClear As CheckBox
        Private _cbSelectionMode As ComboBox
        Private _chart As FlexChart
        Private _slider As RangeSliderView
        Protected _pnlControlOptions As FlowLayoutPanel
#End Region
#Region "Properties"
        Public ReadOnly Property Chart As FlexChart
            Get
                Return _chart
            End Get
        End Property

        Public ReadOnly Property Slider As RangeSliderView
            Get
                Return _slider
            End Get
        End Property

        Public Property SelectionMode As SelectionMode
            Get
                Return _selectionMode
            End Get
            Set(ByVal value As SelectionMode)

                If _selectionMode <> value Then
                    _selectionMode = value
                    _cbSelectionMode.SelectedIndex = If(_cbSelectionMode.SelectedIndex = -1, -1, CInt(value))
                End If
            End Set
        End Property

        Public Property ShowSelectionMode As Boolean
            Get
                Return _showSelectionMode
            End Get
            Set(ByVal value As Boolean)

                If value <> _showSelectionMode AndAlso _cbSelectionMode IsNot Nothing Then
                    _showSelectionMode = value
                    _cbSelectionMode.Visible = value
                End If
            End Set
        End Property

        Public Property ShowRangeSlider As Boolean
            Get
                Return _showRangeSlider
            End Get
            Set(ByVal value As Boolean)
                _showRangeSlider = value
                If Me.IsHandleCreated Then Slider.Visible = value
            End Set
        End Property

        Public ReadOnly Property IsGroupedData As Boolean
            Get
                Return _items.First().[GetType]() = GetType(GroupItem) OrElse _items.First().[GetType]().IsSubclassOf(GetType(GroupItem))
            End Get
        End Property

        Public ReadOnly Property IsFilterApplied As Boolean
            Get
                Return Not _chbClear.Checked
            End Get
        End Property
#End Region
#Region "Events"
        Public Event SelectionChanged As EventHandler
#End Region
#Region "c'tor"
        Public Sub New(ByVal items As IEnumerable(Of Object), ByVal bindingX As String, ByVal binding As String, ByVal Optional chartType As ChartType = ChartType.Column)
            InitializeComponent()
            _selectedIndices = New List(Of Integer)()
            Me._items = items
            _chart = New FlexChart() With {
                .ChartType = chartType,
                .DataSource = items,
                .BindingX = bindingX,
                .Binding = binding,
                .Dock = DockStyle.Fill,
                .Margin = New Padding(0, 30, 0, 0)
            }
            Dim ser = New Series()
            AddHandler ser.SymbolRendering, AddressOf OnSeriesSymbolRendering
            Me.Chart.Series.Add(ser)
            Me.Chart.SelectionStyle.Stroke = Brushes.DarkBlue
            Me.Chart.SelectionStyle.StrokeWidth = 2
            Me.Chart.SelectionStyle.Fill = New SolidBrush(Color.FromArgb(200, Color.CornflowerBlue))
            Me.Chart.ToolTip.Content = "X: {x} " & vbLf & "Y: {y}"
            Me.Chart.AxisX.LabelMax = True
            Me.Chart.AxisX.LabelMin = True
            AddHandler Me.Chart.MouseClick, AddressOf OnChartMouseClick
            AddHandler Me.Chart.Rendered, AddressOf OnChartRendered
            _pnlControlOptions = New FlowLayoutPanel() With {
                .FlowDirection = FlowDirection.LeftToRight,
                .Dock = DockStyle.Top,
                .Height = 30,
                .AutoScroll = True
            }
            _chbClear = New CheckBox() With {
                .Text = "Clear",
                .Checked = True,
                .Enabled = False,
                .AutoSize = True
            }
            AddHandler _chbClear.CheckedChanged, AddressOf OnClearChanged
            _cbSelectionMode = New ComboBox() With {
                .Width = 80,
                .Visible = ShowSelectionMode,
                .FlatStyle = FlatStyle.Flat,
                .DataSource = [Enum].GetValues(GetType(SelectionMode))
            }
            AddHandler _cbSelectionMode.SelectedIndexChanged, Sub(s, e)
                                                                  Me.SelectionMode = CType(_cbSelectionMode.SelectedValue, SelectionMode)
                                                                  OnSelectionModeChanged()
                                                              End Sub

            _pnlControlOptions.Controls.Add(_chbClear)
            _pnlControlOptions.Controls.Add(_cbSelectionMode)
            Dim isDateTime = items.First().[GetType]().GetProperty(Chart.BindingX).PropertyType = GetType(DateTime)
            _slider = New RangeSliderView(isDateTime) With {
                .Dock = DockStyle.Bottom
            }
            SetupRangeSlider()
            AddHandler Slider.RangeChanged, AddressOf RangeSliderView_RangeChanged
            Controls.Add(_pnlControlOptions)
            Controls.Add(Chart)
            Controls.Add(Slider)
        End Sub
#End Region
#Region "Private Methods"
#Region "Control Event Handlers"
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            _cbSelectionMode.SelectedIndex = CInt(SelectionMode)
            Slider.Visible = ShowRangeSlider
            Slider.Height = If(Slider.Height >= 80, 80, 40)
        End Sub

        Private Sub OnClearChanged()
            If _chbClear.Checked Then
                _selectedIndices.Clear()
                Slider.SetFullRange()
                OnSelectedPointsChanged()
            End If

            _chbClear.Enabled = Not _chbClear.Checked
        End Sub

        Private Sub OnChartRendered(ByVal sender As Object, ByVal e As RenderEventArgs)
            If _selecting Then
                e.Engine.SetStroke(Brushes.Red)
                Dim minX = Math.Min(_ptStart.X, _ptEnd.X)
                Dim minY = Math.Min(_ptStart.Y, _ptEnd.Y)
                Dim maxX = Math.Max(_ptStart.X, _ptEnd.X)
                Dim maxY = Math.Max(_ptStart.Y, _ptEnd.Y)
                e.Engine.DrawRect(minX, minY, maxX - minX, maxY - minY)
            End If
        End Sub

        Private Sub OnChartMouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hitTest = Chart.HitTest(e.Location)

            If hitTest.Item IsNot Nothing AndAlso hitTest.Distance = 0 Then
                Dim currentSelected = hitTest.PointIndex

                If Not _selectedIndices.Contains(currentSelected) Then
                    _selectedIndices.Add(currentSelected)
                Else
                    _selectedIndices.Remove(currentSelected)
                End If

                OnSelectedPointsChanged()
            End If
        End Sub

        Private Sub OnChartMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            If _selecting Then
                _ptEnd = e.Location
                FindItemsInRectRange()
                _ptStart = Point.Empty
                _ptEnd = Point.Empty
                _selecting = False
                Chart.Capture = False
                Chart.Refresh()
            Else
                _ptStart = Point.Empty
                _ptEnd = Point.Empty
            End If
        End Sub

        Private Sub OnChartMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            If _ptStart <> Point.Empty Then
                _ptEnd = e.Location
                Chart.Refresh()
                _selecting = True
            End If
        End Sub

        Private Sub OnChartMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            _ptStart = e.Location
            Chart.Capture = True
        End Sub

        Private Sub OnSeriesSymbolRendering(ByVal sender As Object, ByVal e As RenderSymbolEventArgs)
            If _selectedIndices.Contains(e.Index) Then
                If Chart.SelectionStyle.Stroke IsNot Nothing Then e.Engine.SetStroke(Chart.SelectionStyle.Stroke)
                If Chart.SelectionStyle.StrokeWidth > 0 Then e.Engine.SetStrokeThickness(Chart.SelectionStyle.StrokeWidth)
                If Chart.SelectionStyle.Fill IsNot Nothing Then e.Engine.SetFill(Chart.SelectionStyle.Fill)
            End If
        End Sub

        Private Sub RangeSliderView_RangeChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not Slider.IsFullRange Then
                Chart.AxisX.Min = Slider.LowerValue
                Chart.AxisX.Max = Slider.UpperValue
            Else
                Chart.AxisX.Min = Double.NaN
                Chart.AxisX.Max = Double.NaN
            End If

            OnSelectedPointsChanged()
        End Sub
#End Region
        Private Sub OnSelectionModeChanged()
            RemoveHandler Chart.MouseClick, AddressOf OnChartMouseClick
            RemoveHandler Chart.MouseDown, AddressOf OnChartMouseDown
            RemoveHandler Chart.MouseMove, AddressOf OnChartMouseMove
            RemoveHandler Chart.MouseUp, AddressOf OnChartMouseUp

            Select Case SelectionMode
                Case SelectionMode.NormalSelect
                    AddHandler Chart.MouseClick, AddressOf OnChartMouseClick
                Case SelectionMode.RangeSelect
                    AddHandler Chart.MouseDown, AddressOf OnChartMouseDown
                    AddHandler Chart.MouseMove, AddressOf OnChartMouseMove
                    AddHandler Chart.MouseUp, AddressOf OnChartMouseUp
            End Select
        End Sub

        Private Sub OnSelectedPointsChanged()
            _chbClear.Checked = If(_selectedIndices.Count = 0, Slider.IsFullRange, False)
            Chart.Refresh()
            RaiseEvent SelectionChanged(Me, Nothing)
        End Sub

        Private Sub SetupRangeSlider()
            Dim values = GetChartXValues().ToList()
            Slider.Maximum = values.Max()
            Slider.Minimum = values.Min()
            Slider.SetFullRange()
        End Sub

        Private Sub FindItemsInRectRange()
            Dim startX = Chart.AxisX.ConvertBack(Math.Min(_ptStart.X, _ptEnd.X))
            Dim endX = Chart.AxisX.ConvertBack(Math.Max(_ptStart.X, _ptEnd.X))
            Dim startY = Chart.AxisY.ConvertBack(Math.Max(_ptStart.Y, _ptEnd.Y))
            Dim endY = Chart.AxisY.ConvertBack(Math.Min(_ptStart.Y, _ptEnd.Y))
            Dim xValues = GetChartXValues()
            Dim yValues = Chart.Series(0).GetValues(0)

            For idx As Integer = 0 To xValues.Count() - 1
                If (startX <= xValues(idx)) AndAlso (xValues(idx) <= endX) AndAlso (startY <= yValues(idx)) AndAlso (yValues(idx) <= endY) Then _selectedIndices.Add(idx)
            Next

            OnSelectedPointsChanged()
        End Sub

        Private Function GetChartXValues() As Double()
            Dim values = Chart.Series(0).GetValues(1)

            If values Is Nothing Then
                values = New Double(_items.Count() - 1) {}
                Dim idx As Integer = 0
                _items.ToList().ForEach(Sub(x)
                                            values(idx) = idx
                                            idx += 1
                                        End Sub)
            End If

            Return values
        End Function
#End Region
#Region "Public Methods"
        Public Function GetSelectedValues() As IEnumerable(Of Object)
            Dim items = Me._items.ToList()
            Return items.Where(Function(x) _selectedIndices.Contains(items.IndexOf(x)))
        End Function

        Public Function GetSliderRange() As Tuple(Of Object, Object)
            Dim values As Tuple(Of Object, Object) = Nothing
            If Slider.IsFullRange Then Return values

            If Slider.IsDateTimeRange AndAlso Not IsGroupedData Then
                values = New Tuple(Of Object, Object)(DateTime.FromOADate(Slider.LowerValue), DateTime.FromOADate(Slider.UpperValue))
            Else
                values = New Tuple(Of Object, Object)(Slider.LowerValue, Slider.UpperValue)
            End If

            Return values
        End Function

        Public Sub ChangeDataSource(ByVal items As IEnumerable(Of Object), ByVal Optional bindingX As String = "", ByVal Optional binding As String = "")
            Me._items = items
            Chart.DataSource = items
            Chart.BindingX = If(bindingX <> String.Empty, bindingX, Chart.BindingX)
            Chart.Series(0).Binding = If(binding <> String.Empty, binding, Chart.Series(0).Binding)
            Slider.Controls(0).Controls(1).Visible = Not IsGroupedData
            Slider.Height = If(Not IsGroupedData, 80, 40)
            SetupRangeSlider()
            _selectedIndices.Clear()
            OnSelectedPointsChanged()
        End Sub
#End Region
    End Class
End Namespace