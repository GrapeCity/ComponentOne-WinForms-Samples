Imports C1.Win.C1Chart

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        C1Chart1.Header.Text = "Header Element" + Environment.NewLine + _
            "Click chart elements for user dialogs" + Environment.NewLine + _
            "Click outside an element for entire chart dialog." + Environment.NewLine + _
            "Use left-click for dialog, right-click for property grid."

        C1Chart1.Legend.Text = "Legend Element" + Environment.NewLine + "Click series" + Environment.NewLine + "to toggle display"
        C1Chart1.Footer.Text = "Footer Element"
        C1Chart1.ChartArea.AxisX.Text = "X-Axis Element" + Environment.NewLine + "Click the axis for a dialog."
        C1Chart1.ChartArea.AxisY.Text = "Y-Axis Element" + Environment.NewLine + "Click the axis for a dialog."
        C1Chart1.Header.Visible = True
        C1Chart1.Footer.Visible = True
        C1Chart1.Legend.Visible = True
        C1Chart1.Header.Style.Border.BorderStyle = BorderStyleEnum.Solid
        C1Chart1.Footer.Style.Border.BorderStyle = BorderStyleEnum.Solid
        C1Chart1.Legend.Style.Border.BorderStyle = BorderStyleEnum.Solid

        ' add some Chart Labels for full chart dialogs
        Call makeLabel("Label 0" + Environment.NewLine + "Element", New Point(5, 5), LabelCompassEnum.SouthEast)
        Call makeLabel("Label 1" + Environment.NewLine + "Element", New Point(-5 + Me.ClientSize.Width, 5), LabelCompassEnum.SouthWest)
        Call makeLabel("Label 2" + Environment.NewLine + "Element", New Point(-5, -5) + Me.ClientSize, LabelCompassEnum.NorthWest)
        Call makeLabel("Label 3" + Environment.NewLine + "Element", New Point(5, -5 + Me.ClientSize.Height), LabelCompassEnum.NorthEast)

    End Sub

    Private Sub makeLabel(text As String, location As Point, compass As LabelCompassEnum)
        Dim lab As C1.Win.C1Chart.Label = C1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
        lab.Style.Border.BorderStyle = BorderStyleEnum.Solid
        lab.Text = text
        lab.AttachMethod = AttachMethodEnum.Coordinate
        lab.AttachMethodData.X = location.X
        lab.AttachMethodData.Y = location.Y
        lab.Style.HorizontalAlignment = AlignHorzEnum.Near
        lab.Compass = compass
        lab.Visible = True
    End Sub

    Private Sub showPropertyGridForm(selectedObject As Object, title As String)
        Dim pg As PropertyGrid = New PropertyGrid()
        pg.SelectedObject = selectedObject
        pg.Dock = DockStyle.Fill
        pg.Size = New Size(100, 300)

        Dim f As Form = New Form()
        f.Text = title
        f.Controls.Add(pg)
        f.ShowDialog()
    End Sub

    Private Sub C1Chart1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles C1Chart1.MouseDown
        Dim cre As ChartRegionEnum = C1Chart1.ChartRegionFromCoord(e.X, e.Y)
        If (cre = ChartRegionEnum.Legend) Then
            Dim leg As Legend = C1Chart1.Legend
            Dim groupIndex As Integer = -1
            Dim seriesIndex As Integer = -1

            If (leg.SeriesFromCoord(e.X, e.Y, groupIndex, seriesIndex)) Then
                ' Toggle chart series display by clicking on the series in the legend
                Dim cds As ChartDataSeries = C1Chart1.ChartGroups(groupIndex).ChartData.SeriesList(seriesIndex)
                If (cds.Display = SeriesDisplayEnum.Show) Then
                    cds.Display = SeriesDisplayEnum.Hide
                    cds.Tag = New Color() {cds.LineStyle.Color, cds.SymbolStyle.Color, cds.SymbolStyle.OutlineColor}
                    cds.LineStyle.Color = Color.Gray
                    cds.SymbolStyle.Color = Color.Gray
                    cds.SymbolStyle.OutlineColor = Color.DarkSlateGray
                Else
                    Dim clrs As Color() = cds.Tag
                    cds.LineStyle.Color = clrs(0)
                    cds.SymbolStyle.Color = clrs(1)
                    cds.SymbolStyle.OutlineColor = clrs(2)
                    cds.Display = SeriesDisplayEnum.Show
                End If
            Else
                ' Show property dialog for the chart Legend, in this case when a specific series is not clicked.
                If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                    C1Chart1.ShowProperties(PropertyPageFlags.AppearanceLegend)
                ElseIf (e.Button = System.Windows.Forms.MouseButtons.Right) Then
                    showPropertyGridForm(C1Chart1.Legend, "Legend properties")
                End If
            End If

        ElseIf (cre = ChartRegionEnum.XAxis) Then
            ' Show property dialog for the chart X Axis, including Scaling, Fonts, Colors, and annotations etc.
            If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                C1Chart1.ShowProperties(PropertyPageFlags.AxisXScale Or PropertyPageFlags.AxisX Or PropertyPageFlags.AxisXAnno)
            ElseIf (e.Button = System.Windows.Forms.MouseButtons.Right) Then
                showPropertyGridForm(C1Chart1.ChartArea.AxisX, "X axis properties")
            End If

        ElseIf (cre = ChartRegionEnum.YAxis) Then
            ' Show property dialog for the chart Y Axis, including Scaling, Fonts, Colors, and annotations etc.
            If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                C1Chart1.ShowProperties(PropertyPageFlags.AxisYScale Or PropertyPageFlags.AxisY Or PropertyPageFlags.AxisYAnno)
            ElseIf (e.Button = System.Windows.Forms.MouseButtons.Right) Then
                showPropertyGridForm(C1Chart1.ChartArea.AxisY, "Y axis properties")
            End If

        ElseIf (cre = ChartRegionEnum.Footer) Then
            ' Show property dialog for the chart Footer
            If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                C1Chart1.ShowProperties(PropertyPageFlags.AppearanceFooter)
            ElseIf (e.Button = System.Windows.Forms.MouseButtons.Right) Then
                showPropertyGridForm(C1Chart1.Footer.Style, "Footer Style properties")
            End If

        ElseIf (cre = ChartRegionEnum.Header) Then
            ' Show property dialog for the chart Header
            If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                C1Chart1.ShowProperties(PropertyPageFlags.AppearanceHeader)
            ElseIf (e.Button = System.Windows.Forms.MouseButtons.Right) Then
                showPropertyGridForm(C1Chart1.Header.Style, "Header Style properties")
            End If

        ElseIf (cre = ChartRegionEnum.PlotArea) Then
            ' Show property dialog for the chart PlotArea
            If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                C1Chart1.ShowProperties(PropertyPageFlags.AppearancePlotArea Or PropertyPageFlags.Group0Data)
            ElseIf (e.Button = System.Windows.Forms.MouseButtons.Right) Then
                If ((Control.ModifierKeys OrElse Keys.Shift) = 0) Then
                    showPropertyGridForm(C1Chart1.ChartArea.PlotArea, "PlotArea properties")
                Else
                    showPropertyGridForm(C1Chart1.ChartGroups.Group0, "Group 0 properties")
                End If
            End If

        ElseIf (cre = ChartRegionEnum.ChartLabel) Then
            ' Toggle the forecolor of the clicked label, or for right clicks,
            ' show a modal form with a property page.
            Dim labIndex As Integer = -1
            If (C1Chart1.ChartLabels.LabelFromCoord(e.X, e.Y, labIndex)) Then
                Dim lab As C1.Win.C1Chart.Label = C1Chart1.ChartLabels(labIndex)
                If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                    If (lab.Style.ForeColor <> Color.Red) Then
                        lab.Style.ForeColor = Color.Red
                    Else
                        lab.Style.ForeColor = Color.Black
                    End If
                ElseIf (e.Button = System.Windows.Forms.MouseButtons.Right) Then
                    showPropertyGridForm(lab.Style, "Style properties for " + lab.Name)
                End If
            End If

        Else
            If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                C1Chart1.ShowProperties(PropertyPageFlags.All)
            ElseIf (e.Button = System.Windows.Forms.MouseButtons.Right) Then
                showPropertyGridForm(C1Chart1, "Chart Properties")
            End If
        End If
    End Sub

    Private Sub C1Chart1_Resize(sender As System.Object, e As System.EventArgs) Handles C1Chart1.Resize
        ' update the label positions to match the new chart boundaries.
        If C1Chart1.ChartLabels.LabelsCollection.Count > 0 Then
            Dim adm As AttachMethodData = C1Chart1.ChartLabels(1).AttachMethodData
            adm.X = -5 + Me.ClientSize.Width
            adm.Y = 5

            adm = C1Chart1.ChartLabels(2).AttachMethodData
            adm.X = -5 + Me.ClientSize.Width
            adm.Y = -5 + Me.ClientSize.Height

            adm = C1Chart1.ChartLabels(3).AttachMethodData
            adm.X = 5
            adm.Y = -5 + Me.ClientSize.Height
        End If

    End Sub

End Class
