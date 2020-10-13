Imports System.ComponentModel
Imports C1.Win.C1Gauge

Public Class BaseGaugePage

    Private _resetMenuItem As ToolStripMenuItem
    Private _categorizedMenuItem As ToolStripMenuItem
    Private _alphabeticMenuItem As ToolStripMenuItem
    Private _descriptionMenuItem As ToolStripMenuItem
    Private _random As Random

    Public Sub New()
        MyBase.New()

        InitializeComponent()

        gaugeGrid.ContextMenuStrip = CreateMenuStrip()
        _random = New Random()

    End Sub

#Region "** private"

    Private Function CreateMenuStrip() As ContextMenuStrip
        Dim result As ContextMenuStrip = New ContextMenuStrip()
        Dim separator1 As ToolStripSeparator = New ToolStripSeparator()
        Dim separator2 As ToolStripSeparator = New ToolStripSeparator()
        _resetMenuItem = New ToolStripMenuItem()
        _descriptionMenuItem = New ToolStripMenuItem()
        _categorizedMenuItem = New ToolStripMenuItem()
        _alphabeticMenuItem = New ToolStripMenuItem()
        result.Items.AddRange(New System.Windows.Forms.ToolStripItem() { _
            _resetMenuItem, separator1, _categorizedMenuItem, _alphabeticMenuItem, _
            separator2, _descriptionMenuItem})
        _resetMenuItem.Text = "&Reset"
        _categorizedMenuItem.Text = "&Categorized"
        _alphabeticMenuItem.Text = "&Alphabetic"
        _descriptionMenuItem.Text = "&Description"
        AddHandler result.Opening, AddressOf contextMenu_Opening
        AddHandler _resetMenuItem.Click, AddressOf resetMenuItem_Click
        AddHandler _categorizedMenuItem.Click, AddressOf categorizedMenuItem_Click
        AddHandler _alphabeticMenuItem.Click, AddressOf alphabeticMenuItem_Click
        AddHandler _descriptionMenuItem.Click, AddressOf descriptionMenuItem_Click
        Return result
    End Function

    Private Sub contextMenu_Opening(ByVal sender As Object, ByVal e As CancelEventArgs)
        Dim resetEnabled As Boolean = False
        Dim item As GridItem = gaugeGrid.SelectedGridItem
        If item IsNot Nothing AndAlso item.GridItemType = GridItemType.Property Then
            Dim parent As GridItem = item.Parent
            Dim pd As PropertyDescriptor = item.PropertyDescriptor
            If parent.GridItemType = GridItemType.Root Or parent.GridItemType = GridItemType.Category Then
                resetEnabled = pd.CanResetValue(gaugeGrid.SelectedObject)
            ElseIf parent.GridItemType = GridItemType.Property Then
                resetEnabled = pd.CanResetValue(parent.Value)
            End If
        End If
        _resetMenuItem.Enabled = resetEnabled
        _descriptionMenuItem.Checked = gaugeGrid.HelpVisible
        If gaugeGrid.PropertySort = PropertySort.CategorizedAlphabetical Then
            _categorizedMenuItem.Checked = True
        Else
            _categorizedMenuItem.Checked = False
        End If
        If gaugeGrid.PropertySort = PropertySort.Alphabetical Then
            _alphabeticMenuItem.Checked = True
        Else
            _alphabeticMenuItem.Checked = False
        End If
    End Sub

    Private Sub resetMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim item As GridItem = gaugeGrid.SelectedGridItem
        If (item IsNot Nothing AndAlso item.GridItemType = GridItemType.Property) Then
            Dim parent As GridItem = item.Parent
            Dim pd As PropertyDescriptor = item.PropertyDescriptor
            Dim obj As Object = Nothing
            Dim rootObj As Object = gaugeGrid.SelectedObject
            Dim rootPd As PropertyDescriptor = Nothing
            If Parent.GridItemType = GridItemType.Root Or Parent.GridItemType = GridItemType.Category Then
                obj = rootObj
            ElseIf Parent.GridItemType = GridItemType.Property Then
                rootPd = Parent.PropertyDescriptor
                obj = Parent.Value
            End If
            If obj IsNot Nothing Then
                pd.ResetValue(obj)
            End If
            gaugeGrid.Refresh()
        End If
    End Sub

    Private Sub descriptionMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        gaugeGrid.HelpVisible = Not gaugeGrid.HelpVisible
    End Sub

    Private Sub categorizedMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        gaugeGrid.PropertySort = PropertySort.CategorizedAlphabetical
    End Sub

    Private Sub alphabeticMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        gaugeGrid.PropertySort = PropertySort.Alphabetical
    End Sub

    Private Sub gaugeGrid_SelectedObjectsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gaugeGrid.SelectedObjectsChanged
        Dim s As String = String.Empty
        Dim obj As Object = gaugeGrid.SelectedObject
        If obj IsNot Nothing Then
            Dim name As String = obj.GetType().ToString()
            Dim n As Int32 = name.LastIndexOf(".")
            If n <> -1 Then
                s = name.Substring(n + 1) + " properties:"
            End If
        End If
        objectLabel.Text = s
    End Sub

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
        If Not IsDisposed AndAlso Visible Then
            OnTimer()
        End If
    End Sub

#End Region

    Friend Sub UpdateValue(ByVal gauge As C1GaugeBase, ByVal maxStep As Double)
        Dim v As Double = gauge.Value
        Dim min, max As Double
        If (gauge.IsLogarithmic) Then
            Dim logLogBase As Double = Math.Log(gauge.LogarithmicBase)
            min = Math.Max(Math.Log(gauge.Minimum) / logLogBase, Math.Log(v) / logLogBase - maxStep)
            max = Math.Min(Math.Log(gauge.Maximum) / logLogBase, Math.Log(v) / logLogBase + maxStep)
            gauge.Value = Math.Exp((_random.NextDouble() * (max - min) + min) * logLogBase)
        Else
            min = Math.Max(gauge.Minimum, v - maxStep)
            max = Math.Min(gauge.Maximum, v + maxStep)
            gauge.Value = _random.NextDouble() * (max - min) + min
        End If
    End Sub

    Friend Sub UpdateValue(ByVal gauge As C1GaugeBase, ByVal pointerIndex As Int32, ByVal maxStep As Double)
        Dim v As Double = gauge.MorePointers(pointerIndex).Value
        Dim min As Double = Math.Max(gauge.Minimum, v - maxStep)
        Dim max As Double = Math.Min(gauge.Maximum, v + maxStep)
        gauge.MorePointers(pointerIndex).Value = _random.NextDouble() * (max - min) + min
    End Sub

    Friend Sub UpdateValue(ByVal gauge As C1GaugeBase, ByVal pointerName As String, ByVal maxStep As Double, ByVal min As Double, ByVal max As Double)
        Dim pointer As C1GaugePointer = gauge.MorePointers(pointerName)
        min = Math.Max(min, pointer.Value - maxStep)
        max = Math.Min(max, pointer.Value + maxStep)
        pointer.Value = _random.NextDouble() * (max - min) + min
    End Sub

    Protected Overridable Sub OnTimer()
    End Sub

End Class
