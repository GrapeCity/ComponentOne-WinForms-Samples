Imports C1.Win.C1Chart

Public Class Form1
	Inherits Form

	Public Sub New()
		InitializeComponent()
		Me.BackColor = Color.LightBlue

		C1Chart1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
	End Sub


	Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		' Populate the Logarithmic Base combo box.	Note that the base value
		' is the base of the log used for both axes.  It can be any double value
		' greater than zero.  "e" is interpreted as the "natural" algorithm.
		Dim strItems() As String = {"e", "2", "3", "5", "7.5", "10", "16"}
		comboBoxLogBase.Items.AddRange(strItems)
		comboBoxLogBase.SelectedIndex = comboBoxLogBase.FindStringExact("10")

		' Populate the chart with some Power Series values as these
		' readily show logarithmic behavior.
		Const pointCount As Integer = 10
		Dim baseValues() As Integer = {2, 4, 5, 10}

		Dim cdsc As ChartDataSeriesCollection = C1Chart1.ChartGroups.Group0.ChartData.SeriesList
		cdsc.RemoveAll()

		Dim bi As Integer
		For bi = 0 To baseValues.Length - 1
			Dim baseValue As Integer = baseValues(bi)

			' create the Power Series data array
			Dim points(pointCount - 1) As PointF
			Dim i As Integer
			For i = 1 To pointCount - 1
				points(i).X = i
				points(i).Y = CSng(Math.Pow(baseValue, i))
			Next i

			' Create and add a new ChartDataSeries and copy in the data array.
			Dim cds As ChartDataSeries = cdsc.AddNewSeries()
			cds.PointData.CopyDataIn(points)
			cds.Label = "y = Math.Pow(" + baseValue.ToString() + ",x)"

			' Create a Chart Label to indicate the equation used to generate the data
			' and attach it to the series appropriately.
			Dim clabs As C1.Win.C1Chart.ChartLabels = C1Chart1.ChartLabels
			clabs.AutoArrangement.Method = AutoLabelArrangementMethodEnum.FindingOptimum

			Dim lab As C1.Win.C1Chart.Label = clabs.LabelsCollection.AddNewLabel()
			lab.Text = cds.Label
			lab.AttachMethod = AttachMethodEnum.DataIndex
			lab.AttachMethodData.GroupIndex = 0
			lab.AttachMethodData.PointIndex = pointCount / 2 + bi
			lab.AttachMethodData.SeriesIndex = bi
			lab.Connected = True
			lab.Compass = LabelCompassEnum.Auto
			lab.Style.Border.BorderStyle = BorderStyleEnum.Solid
			lab.Visible = True
		Next bi

		' set the initial Logarithmic base values for the X and Y axes.
		Dim area As Area = C1Chart1.ChartArea
		area.AxisX.LogarithmicBase = 10
		area.AxisX.Thickness = 1
		area.AxisY.LogarithmicBase = 10
		area.AxisY.Thickness = 1

		' call the check box handler to set axes values appropriate for
		' log or non-log axes.
		checkLOG_CheckedChanged(checkXLOG, Nothing)
		checkLOG_CheckedChanged(checkYLOG, Nothing)

		' Add some cosmetic attributes
		Dim style As Style = C1Chart1.Style
		style.BackColor = Color.DarkRed
		style.BackColor2 = Color.OrangeRed
		style.GradientStyle = GradientStyleEnum.DiagonalCenter
		style.Border.Rounding.All = 20

		style = C1Chart1.ChartArea.Style
		style.BackColor = Color.White
		style.GradientStyle = GradientStyleEnum.None
	End Sub	'Form1_Load


	Private Sub checkLOG_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkXLOG.CheckedChanged, checkYLOG.CheckedChanged
		' determine which checkbox is firing this event handler
		' and operate on the appropriate chart axis.
		Dim useYAxis As Boolean = sender.Equals(checkYLOG)

		Dim ax As Axis = Nothing
		If useYAxis Then
			ax = C1Chart1.ChartArea.AxisY
		Else
			ax = C1Chart1.ChartArea.AxisX
		End If
		ax.IsLogarithmic = CType(sender, CheckBox).Checked

		' Because the Y axis values may be extreme, use special formatting
		' typical of Log axes in chart.
		If useYAxis Then
			If ax.IsLogarithmic Then
				ax.AnnoFormat = FormatEnum.NumericManual
				If ax.LogarithmicBase <= 0 Then
					ax.AnnoFormatString = "" '"e**{0}" default for manual, no text
				Else
					ax.AnnoFormatString = ax.LogarithmicBase.ToString() + "**{0}"
				End If
			Else
				ax.AnnoFormat = FormatEnum.NumericGeneral
			End If
		End If
	End Sub

	Private Sub comboBoxLogBase_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxLogBase.SelectedIndexChanged
		'Handles comboBoxLogBase.SelectedIndexChanged
		Dim slogbase As String = comboBoxLogBase.SelectedItem '
		Dim logbase As Double = 0

		If slogbase = "e" Then
			logbase = 0
		Else
			logbase = Double.Parse(slogbase)
		End If
		Dim area As Area = C1Chart1.ChartArea
		area.AxisX.LogarithmicBase = logbase
		area.AxisY.LogarithmicBase = logbase

		' update the formats using the new log base
		checkLOG_CheckedChanged(checkXLOG, Nothing)
		checkLOG_CheckedChanged(checkYLOG, Nothing)
	End Sub
End Class
