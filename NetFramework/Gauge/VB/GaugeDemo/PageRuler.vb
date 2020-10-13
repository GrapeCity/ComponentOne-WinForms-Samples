Imports C1.Win.C1Gauge

Public Class PageRuler

    Private _leftPointer As C1GaugePointer, _hangingPointer As C1GaugePointer
    Private _firstLinePointer As C1GaugePointer, _rIndentPointer As C1GaugePointer
    Private _oldCursor As Cursor

    Public Sub New()
        MyBase.New()

        InitializeComponent()

        _leftPointer = rulerGauge.MorePointers("LeftIndent")
        _hangingPointer = rulerGauge.MorePointers("HangingIndent")
        _firstLinePointer = rulerGauge.MorePointers("FirstLineIndent")
        _rIndentPointer = rulerGauge.MorePointers("RightIndent")

        richTextBox1.SelectAll()
    End Sub

    Private Sub c1Gauge1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1Gauge1.Resize
        rulerGauge.Maximum = c1Gauge1.Width - (rulerGauge.Viewport.MarginX * 2) + rulerGauge.Minimum
    End Sub

    Private Sub RichTextBox1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles richTextBox1.SelectionChanged
        Dim n As Int32 = richTextBox1.SelectionIndent
        _firstLinePointer.Value = n
        n += richTextBox1.SelectionHangingIndent
        _leftPointer.Value = Math.Max(n, 0)
        _rIndentPointer.Value = richTextBox1.RightMargin - richTextBox1.SelectionRightIndent
    End Sub

    Private Sub rulerGauge_PointerDragMove(ByVal sender As System.Object, ByVal e As PointerDragEventArgs) Handles rulerGauge.PointerDragMove
        e.Pointer.UpdateValue(Math.Max(e.NewValue, 0), 10)
        If e.Pointer.Name = "LeftIndent" Then
            _firstLinePointer.Value = Math.Max(e.Pointer.Value - richTextBox1.SelectionHangingIndent, 0)
        ElseIf e.Pointer.Name = "RightIndent" Then
            If Convert.ToInt32(e.Pointer.Value) > richTextBox1.RightMargin Then
                e.Pointer.Value = richTextBox1.RightMargin
            End If
        End If
    End Sub

    Private Sub rulerGauge_PointerValueChanged(ByVal sender As System.Object, ByVal e As PointerValueChangedEventArgs) Handles rulerGauge.PointerValueChanged
        If e.Pointer.Name = "LeftIndent" Then
            _hangingPointer.Value = e.Pointer.Value
        ElseIf e.Pointer.Name = "HangingIndent" Then
            _leftPointer.Value = e.Pointer.Value
        ElseIf e.Pointer.Name = "RightMargin" Then
            _rIndentPointer.Value = e.Pointer.Value - richTextBox1.SelectionRightIndent
        End If
    End Sub

    Private Sub rulerGauge_PointerDragEnd(ByVal sender As System.Object, ByVal e As PointerDragEventArgs) Handles rulerGauge.PointerDragEnd
        Dim m As Int32
        Dim n As Int32 = Convert.ToInt32(e.Pointer.Value)
        Select Case e.Pointer.Name
            Case "LeftIndent"
                m = richTextBox1.SelectionHangingIndent
                n -= m
                If n >= 0 Then
                    richTextBox1.SelectionIndent = n
                    richTextBox1.SelectionHangingIndent = m
                Else
                    richTextBox1.SelectionIndent = 0
                    richTextBox1.SelectionHangingIndent += n
                End If
                _firstLinePointer.Value = richTextBox1.SelectionIndent

            Case "FirstLineIndent"
                m = richTextBox1.SelectionHangingIndent + richTextBox1.SelectionIndent - n
                richTextBox1.SelectionIndent = n
                richTextBox1.SelectionHangingIndent = m

            Case "HangingIndent"
                richTextBox1.SelectionHangingIndent = n - richTextBox1.SelectionIndent

            Case "RightIndent"
                m = Math.Max(richTextBox1.RightMargin - n, 0)
                richTextBox1.SelectionRightIndent = m
                _rIndentPointer.Value = richTextBox1.RightMargin - m

            Case "RightMargin"
                m = richTextBox1.SelectionRightIndent
                richTextBox1.RightMargin = n
                richTextBox1.SelectionRightIndent = m

        End Select
    End Sub

    Private Sub rulerGauge_ItemStateChanged(ByVal sender As System.Object, ByVal e As C1.Win.C1Gauge.ItemEventArgs) Handles rulerGauge.ItemStateChanged
        If TypeOf e.Item Is C1GaugePointer Then
            Dim p As C1GaugePointer = CType(e.Item, C1GaugePointer)
            If p.Name = "RightMargin" Then
                If e.ItemHot Or e.ItemPressed Then
                    If _oldCursor Is Nothing Then
                        _oldCursor = c1Gauge1.Cursor
                        c1Gauge1.Cursor = Cursors.SizeWE
                    End If
                ElseIf _oldCursor IsNot Nothing Then
                    c1Gauge1.Cursor = _oldCursor
                    _oldCursor = Nothing
                End If
            Else
                c1Gauge1.BeginUpdate()
                If e.ItemHot Or e.ItemPressed Then
                    p.Border.CommonBorderName = "Hot"
                    p.Filling.CommonFillingName = "Hot"
                Else
                    p.Border.CommonBorderName = "Normal"
                    p.Filling.CommonFillingName = "Normal"
                End If
                c1Gauge1.EndUpdate()
            End If
        End If
    End Sub

    Private Sub rulerGauge_ItemMouseEnter(ByVal sender As System.Object, ByVal e As C1.Win.C1Gauge.ItemEventArgs) Handles rulerGauge.ItemMouseEnter
        If Not e.ItemPressed AndAlso TypeOf e.Item Is C1GaugePointer Then
            Dim p As C1GaugePointer = CType(e.Item, C1GaugePointer)
            Select Case p.Name
                Case "LeftIndent"
                    ToolTip1.SetToolTip(c1Gauge1, "Left Indent")

                Case "FirstLineIndent"
                    ToolTip1.SetToolTip(c1Gauge1, "First Line Indent")

                Case "HangingIndent"
                    ToolTip1.SetToolTip(c1Gauge1, "Hanging Indent")

                Case "RightIndent"
                    ToolTip1.SetToolTip(c1Gauge1, "Right Indent")

                Case "RightMargin"
                    ToolTip1.SetToolTip(c1Gauge1, "Right Margin")

            End Select
        End If
    End Sub

    Private Sub rulerGauge_ItemMouseLeave(ByVal sender As System.Object, ByVal e As C1.Win.C1Gauge.ItemEventArgs) Handles rulerGauge.ItemMouseLeave
        If TypeOf e.Item Is C1GaugePointer Then
            ToolTip1.SetToolTip(c1Gauge1, "")
        End If
    End Sub

End Class
