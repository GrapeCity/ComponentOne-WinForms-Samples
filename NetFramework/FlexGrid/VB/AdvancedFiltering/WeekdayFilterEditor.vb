Imports C1.Win.FlexGrid
Imports System
Imports System.Windows.Forms

Namespace AdvancedFiltering
    Partial Public Class WeekdayFilterEditor
        Inherits UserControl
        Implements IC1ColumnFilterEditor
        Private _weekdayFilter As WeekdayFilter

        Public Sub New()
            Me.Text = "Week Day Filter"
            InitializeComponent()
        End Sub

        Public Sub Initialize(ByVal grid As C1FlexGridBase, ByVal columnIndex As Integer, ByVal filter As IC1ColumnFilter) Implements IC1ColumnFilterEditor.Initialize
            Dim inheritedFilter As InheritedFilter = Nothing, composedFilter As ComposedFilter = Nothing

            If CSharpImpl.__Assign(inheritedFilter, TryCast(filter, InheritedFilter)) IsNot Nothing Then
                _weekdayFilter = inheritedFilter.WeekdayFilter

            ElseIf CSharpImpl.__Assign(composedFilter, TryCast(filter, ComposedFilter)) IsNot Nothing Then
                _weekdayFilter = composedFilter.WeekdayFilter
                Else
                    _weekdayFilter = CType(filter, WeekdayFilter)
            End If

            chkMon.Checked = _weekdayFilter.Monday
            chkTue.Checked = _weekdayFilter.Tuesday
            chkWed.Checked = _weekdayFilter.Wednesday
            chkThu.Checked = _weekdayFilter.Thursday
            chkFri.Checked = _weekdayFilter.Friday
            chkSat.Checked = _weekdayFilter.Saturday
            chkSun.Checked = _weekdayFilter.Sunday
        End Sub

        Public Sub ApplyChanges() Implements IC1ColumnFilterEditor.ApplyChanges
            _weekdayFilter.Monday = chkMon.Checked
            _weekdayFilter.Tuesday = chkTue.Checked
            _weekdayFilter.Wednesday = chkWed.Checked
            _weekdayFilter.Thursday = chkThu.Checked
            _weekdayFilter.Friday = chkFri.Checked
            _weekdayFilter.Saturday = chkSat.Checked
            _weekdayFilter.Sunday = chkSun.Checked
        End Sub

        Public ReadOnly Property KeepFormOpen As Boolean Implements IC1ColumnFilterEditor.KeepFormOpen
            Get
                Return False
            End Get
        End Property
        Private Class CSharpImpl
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
