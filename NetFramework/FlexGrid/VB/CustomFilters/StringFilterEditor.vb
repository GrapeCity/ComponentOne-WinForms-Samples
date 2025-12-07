Imports System.ComponentModel
Imports System.Text

Namespace CustomFilters
	''' <summary>
	''' Represents an editor for modifying a <see cref="StringFilterEditor"/>.
	''' </summary>
	Partial Public Class StringFilterEditor
		Inherits UserControl
		Implements C1.Win.FlexGrid.IC1ColumnFilterEditor
		'-------------------------------------------------------------------------------
		#Region "** fields"

		Private _filter As StringFilter

		#End Region

		'-------------------------------------------------------------------------------
		#Region "** ctor"

		Public Sub New()
			InitializeComponent()
		End Sub

		#End Region

		'-------------------------------------------------------------------------------
		#Region "** IC1ColumnFilterEditor"

		Public Sub Initialize(ByVal grid As C1.Win.FlexGrid.C1FlexGridBase, ByVal columnIndex As Integer, ByVal filter As C1.Win.FlexGrid.IC1ColumnFilter) Implements C1.Win.FlexGrid.IC1ColumnFilterEditor.Initialize
			_filter = CType(filter, StringFilter)

			' initialize checkbox values
			For Each pt In _filter.Ranges
                Select Case CChar(ChrW(pt.X))
                    Case "A"c
                        _chkAE.Checked = True
                    Case "F"c
                        _chkFJ.Checked = True
                    Case "K"c
                        _chkKO.Checked = True
                    Case "P"c
                        _chkPT.Checked = True
                    Case "U"c
                        _chkUZ.Checked = True
                End Select
			Next pt
		End Sub
		Public Sub ApplyChanges() Implements C1.Win.FlexGrid.IC1ColumnFilterEditor.ApplyChanges
			' reset filter
			_filter.Ranges.Clear()

			' add selected ranges
			For Each ctl As Control In Me.Controls
				Dim cb = TryCast(ctl, CheckBox)
				If cb IsNot Nothing AndAlso cb.Checked Then
                    Dim pt = New Point(Convert.ToInt32(cb.Text(0)), Convert.ToInt32(cb.Text(cb.Text.Length - 1)))
                    _filter.Ranges.Add(pt)
				End If
			Next ctl
		End Sub
		Public ReadOnly Property KeepFormOpen() As Boolean Implements C1.Win.FlexGrid.IC1ColumnFilterEditor.KeepFormOpen
			Get
				Return False
			End Get
		End Property

		#End Region

		'-------------------------------------------------------------------------------
		#Region "** event handlers"

		Private Sub _chkAE_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _chkAE.CheckedChanged, _chkFJ.CheckedChanged, _chkKO.CheckedChanged, _chkPT.CheckedChanged, _chkUZ.CheckedChanged
			Dim cb = TryCast(sender, CheckBox)
			cb.Font = New Font(Font,If(cb.Checked, FontStyle.Bold, FontStyle.Regular))
		End Sub

		#End Region
	End Class
End Namespace
