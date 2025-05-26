Imports System
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid

Namespace AdvancedFiltering
    Partial Public Class ComposedFilterEditor
        Inherits UserControl
        Implements IC1ColumnFilterEditor
        Private _composedFilter As ComposedFilter

        Public Sub New()
            InitializeComponent()
            AddHandler _columnFilterEditor.ActiveEditorChanged, Sub(s, e) _columnFilterEditor_ActiveEditorChanged(s, e)
        End Sub

        Private Sub _columnFilterEditor_ActiveEditorChanged(ByVal sender As Object, ByVal e As EventArgs)
            _weekdayFilterEditor.Visible = _columnFilterEditor.ActiveEditor Is Nothing
        End Sub

        Public Sub Initialize(ByVal grid As C1FlexGridBase, ByVal columnIndex As Integer, ByVal filter As IC1ColumnFilter) Implements IC1ColumnFilterEditor.Initialize
            _composedFilter = CType(filter, ComposedFilter)

            _columnFilterEditor.Initialize(grid, columnIndex, _composedFilter.ColumnFilter)
            _weekdayFilterEditor.Initialize(grid, columnIndex, _composedFilter.WeekdayFilter)

            If _composedFilter.WeekdayFilter.IsActive OrElse Not _composedFilter.IsActive Then
                _weekdayFilterEditor.Visible = True
                _columnFilterEditor.ActiveEditor = Nothing
            Else
                _weekdayFilterEditor.Visible = False
            End If
        End Sub

        Public Sub ApplyChanges() Implements IC1ColumnFilterEditor.ApplyChanges
            If _weekdayFilterEditor.Visible Then
                _weekdayFilterEditor.ApplyChanges()
                _composedFilter.ColumnFilter.Reset()
            Else
                _columnFilterEditor.ApplyChanges()
                _composedFilter.WeekdayFilter.Reset()
            End If
        End Sub

        Public ReadOnly Property KeepFormOpen As Boolean Implements IC1ColumnFilterEditor.KeepFormOpen
            Get
                Return False
            End Get
        End Property

        Private Sub _btnWeekdayFilter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnWeekdayFilter.Click
            _columnFilterEditor.ActiveEditor = Nothing
            _weekdayFilterEditor.Visible = True
        End Sub
    End Class
End Namespace
