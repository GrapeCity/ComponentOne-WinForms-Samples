Imports System
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid

Namespace AdvancedFiltering
    Partial Public Class ComposedFilterEditorNewMenu
        Inherits UserControl
        Implements IC1ColumnFilterEditor
        Private _composedFilter As ComposedFilterNewMenu

        Public Sub New()
            InitializeComponent()

            _columnFilterEditor.UseComposedMenu = True
            _columnFilterEditor.MenuFilters.DropDownItems.Add(_mnuWeekdayFilter)
            AddHandler _columnFilterEditor.ActiveEditorChanged, Sub(s, e) _columnFilterEditor_ActiveEditorChanged(s, e)
        End Sub

        Private Sub _columnFilterEditor_ActiveEditorChanged(ByVal sender As Object, ByVal e As EventArgs)
            CheckActiveEditor()
        End Sub

        Public Sub Initialize(ByVal grid As C1FlexGridBase, ByVal columnIndex As Integer, ByVal filter As IC1ColumnFilter) Implements IC1ColumnFilterEditor.Initialize
            _composedFilter = CType(filter, ComposedFilterNewMenu)

            _columnFilterEditor.Initialize(grid, columnIndex, _composedFilter.ColumnFilter)
            _weekdayFilterEditor.Initialize(grid, columnIndex, _composedFilter.WeekdayFilter)

            If _composedFilter.WeekdayFilter.IsActive OrElse Not _composedFilter.IsActive Then
                _weekdayFilterEditor.Visible = True
                _columnFilterEditor.ActiveEditor = Nothing
                _mnuWeekdayFilter.Highlighted = True
            Else
                _weekdayFilterEditor.Visible = False
            End If

            _mnuWeekdayFilter.Checked = _composedFilter.WeekdayFilter.IsActive
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

        Private Sub _mnuWeekdayFilter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _mnuWeekdayFilter.Click
            _columnFilterEditor.ActiveEditor = Nothing
            CheckActiveEditor()
        End Sub

        Private Sub CheckActiveEditor()
            _weekdayFilterEditor.Visible = _columnFilterEditor.ActiveEditor Is Nothing
            _mnuWeekdayFilter.Highlighted = _weekdayFilterEditor.Visible
        End Sub
    End Class
End Namespace
