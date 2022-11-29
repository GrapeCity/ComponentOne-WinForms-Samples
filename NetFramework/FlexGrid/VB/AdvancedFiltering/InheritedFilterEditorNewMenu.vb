Imports C1.Win.C1FlexGrid
Imports System
Imports System.Windows.Forms

Namespace AdvancedFiltering
    Partial Public Class InheritedFilterEditorNewMenu
        Inherits ColumnFilterEditor
        Private _inheritedFilter As InheritedFilterNewMenu

        Public Sub New()
            InitializeComponent()

            UseComposedMenu = True
            MenuFilters.DropDownItems.Add(_mnuWeekdayFilter)
        End Sub

        Public Overrides Sub Initialize(ByVal grid As C1FlexGridBase, ByVal columnIndex As Integer, ByVal filter As IC1ColumnFilter)
            MyBase.Initialize(grid, columnIndex, filter)
            _weekdayFilterEditor.Initialize(grid, columnIndex, filter)
            _inheritedFilter = CType(filter, InheritedFilterNewMenu)

            If _inheritedFilter.WeekdayFilter.IsActive OrElse Not _inheritedFilter.IsActive Then
                ActiveEditor = _weekdayFilterEditor
            End If

            _mnuWeekdayFilter.Checked = _inheritedFilter.WeekdayFilter.IsActive
        End Sub

        Private Sub _mnuWeekdayFilter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _mnuWeekdayFilter.Click
            ActiveEditor = _weekdayFilterEditor
        End Sub

        Public Overrides Sub ApplyChanges()
            MyBase.ApplyChanges()

            If ActiveEditor IsNot _weekdayFilterEditor Then
                _inheritedFilter.WeekdayFilter.Reset()
            End If
        End Sub

        Public Overrides Property ActiveEditor As IC1ColumnFilterEditor
            Get
                Return If(_weekdayFilterEditor.Visible, _weekdayFilterEditor, MyBase.ActiveEditor)
            End Get
            Set(ByVal value As IC1ColumnFilterEditor)
                MyBase.ActiveEditor = value
                _weekdayFilterEditor.Visible = value Is _weekdayFilterEditor
                _mnuWeekdayFilter.Highlighted = _weekdayFilterEditor.Visible
            End Set
        End Property
    End Class
End Namespace
