Imports System.ComponentModel
Imports System.Text

Namespace CustomFilters
	Partial Public Class ColorFilterEditor
		Inherits UserControl
        Implements C1.Win.C1FlexGrid.IC1ColumnFilterEditor

        '-------------------------------------------------------------------------------
#Region "** fields"

        Private _filter As ColorFilter
        Private _keepFormOpen As Boolean

#End Region

        '-------------------------------------------------------------------------------
#Region "** ctor"

        Public Sub New()
            InitializeComponent()
        End Sub

#End Region

        '-------------------------------------------------------------------------------
#Region "** IC1ColumnFilterEditor Members"

        Public Sub Initialize(ByVal grid As C1.Win.C1FlexGrid.C1FlexGridBase, ByVal columnIndex As Integer, ByVal filter As C1.Win.C1FlexGrid.IC1ColumnFilter) Implements C1.Win.C1FlexGrid.IC1ColumnFilterEditor.Initialize
            ' store reference to filter
            _filter = TryCast(filter, ColorFilter)

            ' initialize editor
            _target.BackColor = _filter.TargetColor
            _threshold.Value = _filter.Tolerance
        End Sub
        Public Sub ApplyChanges() Implements C1.Win.C1FlexGrid.IC1ColumnFilterEditor.ApplyChanges
            If Validate() Then
                ' copy editor values back into the filter
                _filter.TargetColor = _target.BackColor
                _filter.Tolerance = CInt(Fix(_threshold.Value))
            End If
        End Sub
        '
        ' read-only version required by interface spec
        '
        Public ReadOnly Property KeepFormOpen() As Boolean Implements C1.Win.C1FlexGrid.IC1ColumnFilterEditor.KeepFormOpen
            Get
                Return _keepFormOpen
            End Get
        End Property
        '
        ' read-write version used within the application
        '
        Public Property KeepFormOpenVB() As Boolean
            Get
                Return _keepFormOpen
            End Get
            Set(ByVal value As Boolean)
                _keepFormOpen = value
            End Set
        End Property

#End Region

        '-------------------------------------------------------------------------------
#Region "** event handlers"

        ' pick target color from panel in the palette
        Private Sub panel1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panel1.Click, panel2.Click, panel3.Click, panel4.Click, panel5.Click, panel6.Click, panel7.Click, panel8.Click, panel9.Click, panel10.Click, panel11.Click, panel12.Click
            ' copy color to target
            _target.BackColor = (CType(sender, Panel)).BackColor

            ' apply changes and close parent form (optional)
            ApplyChanges()
            Dim f As Form = TryCast(TopLevelControl, Form)
            f.DialogResult = DialogResult.OK
            f.Close()
        End Sub

        ' pick target color using a ColorDialog
        Private Sub _target_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _target.Click
            Using dlg = New ColorDialog()
                dlg.Color = _target.BackColor
                KeepFormOpenVB = True ' needed to show modal dialogs
                If dlg.ShowDialog(Me) = DialogResult.OK Then
                    _target.BackColor = dlg.Color
                End If
                KeepFormOpenVB = False
            End Using
        End Sub
#End Region

    End Class
End Namespace
