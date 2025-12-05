Imports System.ComponentModel
Imports System.Text

Namespace CustomFilters
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			' create data table
			Dim dt = New DataTable()
			dt.Columns.Add("Some Date", GetType(Date))
			dt.Columns.Add("Some Integer", GetType(Integer))
			dt.Columns.Add("KnownColor", GetType(KnownColor))
			dt.Columns.Add("Color", GetType(Color))

			Dim rnd = New Random()
			For Each kc As KnownColor In System.Enum.GetValues(GetType(KnownColor))
				Dim clr As Color = Color.FromKnownColor(kc)
				dt.Rows.Add(Date.Today.AddDays(-rnd.Next(0, 100)), rnd.Next(0, 1000), kc, clr)
			Next kc

			' configure grid
			_flex.DataSource = dt
			_flex.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw
			AddHandler _flex.OwnerDrawCell, AddressOf _flex_OwnerDrawCell
			_flex.ExtendLastCol = True
			_flex.AllowEditing = False
			_flex.AllowFiltering = True

			' assign custom filters
			_flex.Cols("Color").Filter = New ColorFilter()
			_flex.Cols("Some Date").Filter = New DateFilter()
			_flex.Cols("KnownColor").Filter = New StringFilter()
		End Sub

		Private Sub _flex_OwnerDrawCell(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.OwnerDrawCellEventArgs)
			If TypeOf _flex(e.Row, e.Col) Is Color Then
				Dim clr = CType(_flex(e.Row, e.Col), Color)
                If clr <> Nothing Then
                    e.DrawCell(C1.Win.FlexGrid.DrawCellFlags.Background Or C1.Win.FlexGrid.DrawCellFlags.Border)
                    Dim rc = e.Bounds
                    rc.Inflate(-4, -2)
                    Using br = New SolidBrush(clr)
                        e.Graphics.FillRectangle(br, rc)
                        e.Graphics.DrawRectangle(Pens.Black, rc)
                    End Using
                End If
			End If
		End Sub
	End Class
End Namespace
