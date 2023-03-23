Imports C1.Win.C1Input

Namespace ChartAsDataFilter
    Partial Public Class RangeSliderView
        Inherits UserControl
#Region "fields"
        Private rangeSlider As C1RangeSlider
        Private fromDatePicker, toDatePicker As DateTimePicker
        Private fromNumeric, toNumeric As NumericUpDown
        Private _delay As Timer
        Private _lowerValue As Double = Double.NaN, _upperValue As Double = Double.NaN
        Private _minValue As Double = Double.NaN, _maxValue As Double = Double.NaN
#End Region
#Region "Properties"
        Public Property LowerValue As Double
            Get
                Return _lowerValue
            End Get
            Set(ByVal value As Double)

                If value <> Double.NaN AndAlso _lowerValue <> value Then
                    _lowerValue = value
                    If _lowerValue > UpperValue Then UpperValue = value

                    If Me.IsHandleCreated Then
                        rangeSlider.LowerValue = _lowerValue
                        If fromNumeric IsNot Nothing AndAlso toNumeric IsNot Nothing Then
                            toNumeric.Minimum = CDec(_lowerValue)
                            fromNumeric.Value = CDec(_lowerValue)
                        End If
                        If fromDatePicker IsNot Nothing AndAlso toDatePicker IsNot Nothing Then
                            toDatePicker.MinDate = DateTime.FromOADate(_lowerValue)
                            fromDatePicker.Value = DateTime.FromOADate(_lowerValue)
                        End If
                        OnRangeChanged()
                    End If
                End If
            End Set
        End Property

        Public Property UpperValue As Double
            Get
                Return _upperValue
            End Get
            Set(ByVal value As Double)

                If value <> Double.NaN AndAlso _upperValue <> value Then
                    _upperValue = value
                    If _upperValue < LowerValue Then LowerValue = value

                    If Me.IsHandleCreated Then
                        rangeSlider.UpperValue = _upperValue
                        If fromNumeric IsNot Nothing AndAlso toNumeric IsNot Nothing Then
                            fromNumeric.Maximum = CDec(_upperValue)
                            toNumeric.Value = CDec(_upperValue)
                        End If
                        If fromDatePicker IsNot Nothing AndAlso toDatePicker IsNot Nothing Then
                            fromDatePicker.MaxDate = DateTime.FromOADate(_upperValue)
                            toDatePicker.Value = DateTime.FromOADate(_upperValue)
                        End If
                        OnRangeChanged()
                    End If
                End If
            End Set
        End Property

        Public Property Minimum As Double
            Get
                Return _minValue
            End Get
            Set(ByVal value As Double)

                If value <> Double.NaN AndAlso _minValue <> value Then
                    _minValue = value
                    If _minValue > Maximum Then Maximum = value

                    If Me.IsHandleCreated Then
                        rangeSlider.Minimum = _minValue
                        If fromNumeric IsNot Nothing Then fromNumeric.Minimum = CDec(_minValue)
                        If fromDatePicker IsNot Nothing Then fromDatePicker.MinDate = DateTime.FromOADate(_minValue)
                    End If
                End If
            End Set
        End Property

        Public Property Maximum As Double
            Get
                Return _maxValue
            End Get
            Set(ByVal value As Double)

                If value <> Double.NaN AndAlso _maxValue <> value Then
                    _maxValue = value
                    If _maxValue < Minimum Then Minimum = value

                    If Me.IsHandleCreated Then
                        rangeSlider.Maximum = _maxValue
                        If toNumeric IsNot Nothing Then toNumeric.Maximum = CDec(_maxValue)
                        If toDatePicker IsNot Nothing Then toDatePicker.MaxDate = DateTime.FromOADate(_maxValue)
                    End If
                End If
            End Set
        End Property

        Public ReadOnly Property IsFullRange As Boolean
            Get
                Return Minimum = LowerValue AndAlso Maximum = UpperValue
            End Get
        End Property

        Public ReadOnly Property IsDateTimeRange As Boolean
            Get
                Return fromDatePicker IsNot Nothing AndAlso toDatePicker IsNot Nothing
            End Get
        End Property
#End Region
#Region "c'tor"
        Public Sub New(ByVal Optional isDateRange As Boolean = False)
            InitializeComponent()
            Dim container = New TableLayoutPanel() With {
                .RowCount = 2,
                .Dock = DockStyle.Fill
            }
            rangeSlider = New C1RangeSlider() With {
                .Orientation = System.Windows.Forms.Orientation.Horizontal,
                .Height = 20,
                .Dock = DockStyle.Fill
            }
            Dim editors = New FlowLayoutPanel() With {
                .FlowDirection = FlowDirection.LeftToRight,
                .Height = 30,
                .Dock = DockStyle.Fill
            }
            Dim fromLabel = New Label() With {
                .Text = "From :",
                .AutoSize = True,
                .Margin = New Padding(5)
            }
            Dim toLabel = New Label() With {
                .Text = "To :",
                .AutoSize = True,
                .Margin = New Padding(5)
            }

            If isDateRange Then
                fromDatePicker = New DateTimePicker() With {
                    .Width = 60,
                    .Format = DateTimePickerFormat.Short
                }
                toDatePicker = New DateTimePicker() With {
                    .Width = 60,
                    .Format = DateTimePickerFormat.Short
                }
                editors.Controls.Add(fromLabel)
                editors.Controls.Add(fromDatePicker)
                editors.Controls.Add(toLabel)
                editors.Controls.Add(toDatePicker)
            Else
                fromNumeric = New NumericUpDown() With {
                    .Width = 50,
                    .Increment = 1
                }
                toNumeric = New NumericUpDown() With {
                    .Width = 50,
                    .Increment = 1
                }
                editors.Controls.Add(fromLabel)
                editors.Controls.Add(fromNumeric)
                editors.Controls.Add(toLabel)
                editors.Controls.Add(toNumeric)
            End If

            container.Controls.Add(rangeSlider, 0, 0)
            container.Controls.Add(editors, 0, 1)
            Controls.Add(container)
            _delay = New Timer() With {
                .Interval = 500
            }
            AddHandler _delay.Tick, AddressOf _delay_Tick
            AddHandler Load, AddressOf RangeSliderView_Load
        End Sub
#End Region
#Region "Control Event Handlers"
        Private Sub RangeSliderView_Load(ByVal sender As Object, ByVal eArgs As EventArgs)
            rangeSlider.Maximum = Maximum
            rangeSlider.Minimum = Minimum
            AddHandler rangeSlider.UpperValueChanged, Sub(s, e)
                                                          UpperValue = rangeSlider.UpperValue
                                                      End Sub

            AddHandler rangeSlider.LowerValueChanged, Sub(s, e)
                                                          LowerValue = rangeSlider.LowerValue
                                                      End Sub

            rangeSlider.UpperValue = UpperValue
            rangeSlider.LowerValue = LowerValue

            If fromDatePicker IsNot Nothing AndAlso toDatePicker IsNot Nothing Then
                AddHandler fromDatePicker.ValueChanged, Sub(s, e)
                                                            LowerValue = fromDatePicker.Value.ToOADate()
                                                        End Sub

                AddHandler toDatePicker.ValueChanged, Sub(s, e)
                                                          UpperValue = toDatePicker.Value.ToOADate()
                                                      End Sub

                toDatePicker.Value = DateTime.FromOADate(UpperValue)
                fromDatePicker.Value = DateTime.FromOADate(LowerValue)
            End If

            If fromNumeric IsNot Nothing AndAlso toNumeric IsNot Nothing Then
                AddHandler fromNumeric.ValueChanged, Sub(s, e)
                                                         LowerValue = CDbl(fromNumeric.Value)
                                                     End Sub

                AddHandler toNumeric.ValueChanged, Sub(s, e)
                                                       UpperValue = CDbl(toNumeric.Value)
                                                   End Sub

                toNumeric.Value = CDec(UpperValue)
                fromNumeric.Value = CDec(LowerValue)
            End If
            RaiseEvent RangeChanged(Me, eArgs)
        End Sub
#End Region
        Private Sub _delay_Tick(ByVal sender As Object, ByVal e As EventArgs)
            _delay.Stop()
            RaiseEvent RangeChanged(Me, e)
        End Sub

        Public Sub SetFullRange()
            Me.UpperValue = Me.Maximum
            Me.LowerValue = Me.Minimum
        End Sub

        Public Event RangeChanged As EventHandler

        Protected Overridable Sub OnRangeChanged()
            _delay.Start()
        End Sub
    End Class
End Namespace
