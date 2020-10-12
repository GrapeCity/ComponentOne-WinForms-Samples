Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics
Imports C1.Win.C1Chart

Public Class Form1
   Inherits Form
   Private pieGrouper As PieGrouper = Nothing
   
   Public Sub New()
      InitializeComponent()
   End Sub
   
	Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles c1Chart1.Load
		c1Chart1.BackColor = Color.FromKnownColor(KnownColor.Window)

		' use light colors so all of the labels are easily read.
		c1Chart1.ColorGeneration = ColorGeneration.Flow

		' stacked pie chart
		c1Chart1.ChartGroups.Group0.ChartType = Chart2DTypeEnum.Pie
		c1Chart1.ChartGroups.Group0.Stacked = chkStacked.Checked

		' 3d effects
		If chk3D.Checked Then
			c1Chart1.ChartArea.PlotArea.View3D.Depth = 15
			c1Chart1.ChartArea.PlotArea.View3D.Elevation = 75
		End If

		' with tooltips
		c1Chart1.ToolTip.SelectAction = SelectActionEnum.Click
		c1Chart1.ToolTip.Enabled = True

		' maximize the ChartArea
		c1Chart1.ChartArea.Margins.SetMargins(0, 0, 0, 0)
		c1Chart1.ChartArea.Style.Border.BorderStyle = BorderStyleEnum.None

		' Use the PieGrouper class to input the data.
		Dim pgBaseNode As New PieGrouper()
		Dim pgRootNode As PieGrouper = Nothing
		Dim pgMidNode As PieGrouper = Nothing

		' Brackets are not required, but show the nesting of
		' the data nodes.
		pgRootNode = pgBaseNode.AddRoot("Beverages", Color.LightBlue)
		If (True) Then
			pgMidNode = pgRootNode.AddIntermediate("Cold", Color.Transparent)
			If (True) Then
				pgMidNode.AddLeaf("Apple Cider", 300, Color.Transparent)
				pgMidNode.AddLeaf("Orange juice", 200, Color.Orange)
			End If
			pgMidNode = pgRootNode.AddIntermediate("Hot", Color.Empty)
			If (True) Then
				pgMidNode.AddLeaf("Tea", 120, Color.Transparent)
				pgMidNode.AddLeaf("Chocolate", 80, Color.Transparent)
			End If
		End If

		pgRootNode = pgBaseNode.AddRoot("Dairy", Color.LightCoral)
		If (True) Then
			pgMidNode = pgRootNode.AddIntermediate("Confections", Color.Transparent)
			If (True) Then
				pgMidNode.AddLeaf("Ice Cream", 256, Color.Transparent)
			End If

			pgMidNode = pgRootNode.AddIntermediate("Cheeses", Color.Transparent)
			If (True) Then
				pgMidNode.AddLeaf("Cheddar", 350, Color.Transparent)
				pgMidNode.AddLeaf("Rocky Cheese", 310, Color.Transparent)
			End If
		End If

		pgRootNode = pgBaseNode.AddRoot("Condiments", Color.LightGray)
		If (True) Then
			pgMidNode = pgRootNode.AddIntermediate("Sweet")
			If (True) Then
				pgMidNode.AddLeaf("Demiglace", 220)
				pgMidNode.AddLeaf("Pure sugar", 180)
			End If
			pgMidNode = pgRootNode.AddIntermediate("Spicy")
			If (True) Then
				pgMidNode.AddLeaf("Bl. Pepper", 150)
				pgMidNode.AddLeaf("Cayenne", 170)
				pgMidNode.AddLeaf("Chili", 84)
				pgMidNode.AddLeaf("Jalepeno", 52)
			End If
		End If

		' save the class instance to allow changes later.
		pieGrouper = pgBaseNode

		' create the new ChartDataSeriesCollection with the current settings
		pgBaseNode.AddToChartDataSeriesCollection(chkAscending.Checked, c1Chart1.ChartGroups.Group0.ChartData.SeriesList)
	End Sub
   
	Private Sub CheckBoxCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkStacked.CheckedChanged, chkAscending.CheckedChanged, chk3D.CheckedChanged
		Dim cb As CheckBox = CType(sender, Object)
		If Not (cb Is Nothing) Then
			Select Case cb.Name
				Case "chk3D"
					If chk3D.Checked Then
						c1Chart1.ChartArea.PlotArea.View3D.Depth = 20
						c1Chart1.ChartArea.PlotArea.View3D.Elevation = 75
					Else
						c1Chart1.ChartArea.PlotArea.View3D.Depth = 0
					End If

				Case "chkStacked"
					c1Chart1.ChartGroups.Group0.Stacked = cb.Checked

				Case "chkAscending"
					pieGrouper.AddToChartDataSeriesCollection(chkAscending.Checked, c1Chart1.ChartGroups.Group0.ChartData.SeriesList)
			End Select
		End If
	End Sub
End Class
